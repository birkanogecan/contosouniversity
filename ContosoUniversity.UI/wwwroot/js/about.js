Blazor.registerFunction('drawEnrollmentStatsChart', (data) => {
    console.log(data);
    var chartLabels = data.map(item => item.enrollmentsdate);
    var chartData = data.map(item => item.studentcount);
    var ctx = $("#statsChart");
    var myChart = new Chart(ctx, {
        type: 'line',
        data: {
            labels: chartLabels,
            datasets: [{
                label: 'Enrollments',
                backgroundColor: "rgb(54, 162, 235)",
                borderColor: "rgb(54, 162, 235)",
                data: chartData,
                borderWidth: 1,
                fill: false,
            }]
        },
        options: {
            scales: {
                yAxes: [{
                    ticks: {
                        beginAtZero: true
                    }
                }]
            }
        }
    });
    return true;
});