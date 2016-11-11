type = ['', 'info', 'success', 'warning', 'danger'];


stats = {
    initChartist: function () {

        var dataPreferences = {
            series: [
                [25, 30, 20, 25]
            ]
        };

        var optionsPreferences = {
            donut: true,
            donutWidth: 40,
            startAngle: 0,
            total: 100,
            showLabel: false,
            axisX: {
                showGrid: false
            }
        };

        Chartist.Pie('#chartPreferences', dataPreferences, optionsPreferences);

        Chartist.Pie('#chartPreferences', {
            labels: ['STP (50)', 'Unknown (0)', 'Rainy (35)', 'Drought (15)'],
            series: [50, 0, 35, 15]
        });
    },
    init: function() {
        stats.initChartist();

        $.notify({
            icon: 'pe-7s-gift',
            message: "Welcome to <b>Weather Stats Application</b> - a beautiful exercise for process weather events."

        }, {
            type: 'info',
            timer: 4000
        });
    }
}