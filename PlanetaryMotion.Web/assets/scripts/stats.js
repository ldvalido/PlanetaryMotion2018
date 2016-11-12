type = ['', 'info', 'success', 'warning', 'danger'];


stats = {
    drawChart: function (stpQuantity, unknownQuantity, rainyQuantity, droughtQuantity) {

        Chartist.Bar('#chartPreferences', {
            labels: [
                'STP (' + stpQuantity + ')',
                'Unknown (' + unknownQuantity + ')',
                'Rainy (' + rainyQuantity + ')',
                'Drought (' + droughtQuantity + ')'],
            series: [stpQuantity, unknownQuantity, rainyQuantity, droughtQuantity]
        }, {
            distributeSeries: true
        });
    },
    showMaxTrianglePerimeter: function (maxTrianglePerimeter) {
        var formattedPerimeter = maxTrianglePerimeter.toFixed(2);
        $('#spanMaxPerimeter').html(formattedPerimeter);
    },
    initChartist: function(apiPrefix) {
        $.ajax(
        {
            url: apiPrefix+'/stats',
            crossDomain: true,
            type:'GET'
        }).done(function (data) {
            stats.drawChart(data.StpPeriods || 0, data.UnknownPeriods || 0 , data.RainyPeriods || 0, data.DroughtPeriods || 0);
            stats.showMaxTrianglePerimeter(data.MaxTrianglePerimter);
        }).fail(function () {
            alert('An error was ocurr');
        });
    },
    init: function (apiPrefix) {
        stats.initChartist(apiPrefix);

        $.notify({
            icon: 'pe-7s-gift',
            message: "Welcome to <b>Weather Stats Application</b> - a nice exercise for process weather events."

        }, {
            type: 'info',
            timer: 4000
        });
    }
}