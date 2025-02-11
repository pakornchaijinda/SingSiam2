// Salse & Revenue Chart

var myChart2

function linechart(labels,data1, data2) {
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


function barchart() {
    var ctx2 = $("#salse-revenue").get(0).getContext("2d");
    var myChart2 = new Chart(ctx2, {
        type: "bar",
        data: {
            labels: ["2016", "2017", "2018", "2019", "2020", "2021", "2022"],
            datasets: [{
                label: "Salse",
                data: [15, 30, 55, 45, 70, 65, 85],
                backgroundColor: "rgba(0, 156, 255, .5)",
                fill: true
            },
            {
                label: "Revenue",
                data: [99, 135, 170, 130, 190, 180, 270],
                backgroundColor: "rgba(0, 156, 255, .3)",
                fill: true
            }
            ]
        },
        options: {
            responsive: true
        }
    });
}
