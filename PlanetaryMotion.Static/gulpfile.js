// Include gulp
var gulp = require('gulp');

// Include Our Plugins
var jshint = require('gulp-jshint');
var concat = require('gulp-concat');
var uglify = require('gulp-uglify');
var rename = require('gulp-rename');
var gutil = require('gulp-util');

var cssMinifier = require('gulp-clean-css');
var dependences = {
	scripts: [
		{source: 'node_modules/jquery/dist/jquery.js'},
		{source: 'node_modules/chartist/dist/chartist.js'},
		{source: 'node_modules/bootstrap/dist/js/bootstrap.js'},
		{source: 'node_modules/bootstrap-notify/bootstrap-notify.js'},
	],
	styles: [
		{source: 'node_modules/bootstrap/dist/css/bootstrap.min.css'},
		{source: 'node_modules/animate.css/animate.min.css'},
	]
}
// Lint Task
gulp.task('lint', function() {
    return gulp.src('js/*.js')
        .pipe(jshint())
        .pipe(jshint.reporter('default'));
});

// Concatenate & Minify JS
gulp.task('scripts', function() {
    var sources = [];
	for (var i = 0; i < dependences.scripts.length; i++) {
		var file = dependences.scripts[i].source;
		sources.push(file);
	}
	return gulp.src(sources)
        .pipe(concat('planetarymotion-lib-bundle.js'))
        .pipe(gulp.dest('dist'))
        .pipe(rename('planetarymotion-lib-bundle.min.js'))
        .pipe(uglify())
        .pipe(gulp.dest('../PlanetaryMotion.Web/assets/'))
        .pipe(gulp.dest('dist'));
});

// Concatenate & Minify JS
gulp.task('libs', function() {
    var sources = [];
	sources.push('scripts/*.js');
	return gulp.src(sources)
        .pipe(concat('planetarymotion-bundle.js'))
        .pipe(gulp.dest('dist'))
        .pipe(rename('planetarymotion-bundle.min.js'))
        .pipe(uglify())
        .pipe(gulp.dest('../PlanetaryMotion.Web/assets/'))
        .pipe(gulp.dest('dist'));
});

// Concatenate & Minify CSS
gulp.task('styles', function() {
	var sources = [];
	sources.push('styles/*.css');
	for (var i = 0; i < dependences.styles.length; i++) {
		var file = dependences.styles[i].source;
		sources.push(file);
	}
    return gulp.src(sources)
        .pipe(concat('planetarymotion-bundle.css'))
        .pipe(gulp.dest('dist'))
        .pipe(rename('planetarymotion-bundle.min.css'))
        .pipe(cssMinifier({compatibility: 'ie8'}))
        .pipe(gulp.dest('../PlanetaryMotion.Web/assets/'))
		.pipe(gulp.dest('dist'));
});

// Default Task
gulp.task('default', ['lint', 'libs', 'scripts', 'styles']);