// Salse & Revenue Chart

var myChart2

function linechart(labels, data1, data2) {
    var ctx2 = $("#salse-revenue").get(0).getContext("2d");

    if (myChart2) {
        myChart2.destroy();
    }

    myChart2 = new Chart(ctx2, {
        type: "line",
        data: {
            labels: labels,
            datasets: [{
                label: "จำนวนสัญญา",
                data: data1,
                backgroundColor: "rgba(0, 156, 255, .4)",
                borderColor: "rgba(0, 156, 255, 1)",
                pointStyle: 'circle',
                pointRadius: 6,
                pointColor: "red"
            },
            {
                label: "รายได้รวม",
                data: data2,
                backgroundColor: "rgba(40, 180, 99, .4)",
                borderColor: "rgba(40, 180, 99, 1)",
                fill: true
            }
            ]
        },
        options: {
            responsive: true,
            scales: {
                y: {
                    beginAtZero: true
                }
            },
            //plugins: {
            //    tooltip: {
            //        callbacks: {
            //            footer: footer,
            //        }
            //    }
            //}
        }
    });
}

function initChart(labels, data1, data2) {
    var ctx2 = $("#salse-revenue").get(0).getContext("2d");
    myChart2 = new Chart(ctx2, {
        type: "line",
        data: {
            labels: labels,
            datasets: [{
                label: "จำนวนสัญญา",
                data: data1,
                backgroundColor: "rgba(0, 156, 255, 1)",
                borderColor: "rgba(0, 156, 255, 1)",
                pointStyle: 'circle',
                pointRadius: 6,
                pointColor: "red"
            },
            {
                label: "รายได้รวม",
                data: data2,
                backgroundColor: "rgba(0, 156, 255, .3)",
                fill: true
            }
            ]
        },
        options: {
            responsive: true,
            scales: {
                y: {
                    beginAtZero: true
                }
            },

        }
    });
}


function barchart(labels, data1label, data1, data2label, data2) {
    var ctx2 = $("#salse-revenue").get(0).getContext("2d");

    if (myChart2) {
        myChart2.destroy();
    }

    myChart2 = new Chart(ctx2, {
        type: "bar",
        data: {
            labels: labels,
            datasets: [{
                label: data1label,
                data: data1,
                backgroundColor: "rgba(34, 153, 84, .4)",
                borderColor: "rgba(34, 153, 84, 1)",
                fill: true
            },
            {
                label: data2label,
                data: data2,
                backgroundColor: "rgba(235, 40, 20, .4)",
                borderColor: "rgba(235, 40, 20, 1)",
                fill: true
            }
            ]
        },
        options: {
            responsive: true
        }
    });
}
