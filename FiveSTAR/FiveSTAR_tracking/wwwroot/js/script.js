// Create new row in tablewindow.onload
function newRow() {
    document.getElementById("test").disabled = true;
    var row = table.insertRow(1);

    var cell1 = row.insertCell(0);
    var cell2 = row.insertCell(1);
    var cell3 = row.insertCell(2);

    cell1.innerHTML = '<div class="input-group mb-2 mr-sm-2">' +
                        '<div class="input-group-prepend">' +
                          '<div class="input-group-text">$</div>' +
                        '</div>' +
                        '<input type="text" class="form-control" onChange="return isNumberKey(event)" placeholder="0.00" id="income"></label>'
                      '</div>'
    cell2.innerHTML = '<div class="input-group mb-2 mr-sm-2">' +
                        '<div class="input-group-prepend">' +
                          '<div class="input-group-text">$</div>' +
                        '</div>' +
                        '<input type="text" class="form-control" onChange="return isNumberKey(event)" placeholder="0.00" id="expense"></label>'
                      '</div>'
    cell3.innerHTML = '<div class="input-group mb-2 mr-sm-2">' +
                        '<div class="input-group-prepend">' +
                          '<div class="input-group-text">$</div>' +
                        '</div>' +
                        '<input type="text" class="form-control" placeholder="0.00" id="net" readonly></label>'
                      '</div>'   

}

// delete row in table
function byeRow() {
  var table = document.getElementById("table");
  table.deleteRow(1);
}

//numbers only in table
function isNumberKey(evt){
    var charCode = (evt.which) ? evt.which : event.keyCode
    if (charCode > 31 && (charCode < 48 || charCode > 57))
       return false;

       if(netFormula())
        return true;
    pie(charCode);

    return true;
 }

// if false display doughnut view
// if true display pie view
var pieViewAction = true;

//income - expense = net
function netFormula(){
    var income = parseInt(document.getElementById("est_cost").value);
    var expense = parseInt(document.getElementById("act_cost").value);
    var result = est_cost - act_cost;
    document.getElementById("net").value = result;
    x = est_cost;
    pie(est_cost, act_cost, pieViewAction);

  return true;
}


//pie chart on load
window.onload = function() {   

    var chart = new CanvasJS.Chart("pie",
  {
    data: [
    {
      type: "doughnut",
    dataPoints: [
        { y: 1},
        { y: 1},        
      ]
    }
    ]
    });
    chart.render();
  }


function pie(income, expense, pieViewAction) {
    var view = "";

    if (pieViewAction === true)
        view = "doughnut";
    else
        view = "pie";

    var chart = new CanvasJS.Chart("pie",
        {
            data: [
                {
                    type: view,
                    dataPoints: [
                        { y: est_cost },
                        { y: act_cost },                      
                    ]
                }
            ]
        });
    chart.render();
}



function pieView() {
    pieViewAction = !pieViewAction;
    
    netFormula();
}


window.onload = function() {
    var chart = new CanvasJS.Chart("chartContainer", {
        animationEnabled: true,
        title: {
            text: "Olympic Medals of all Times (till 2016 Olympics)"
        },
        axisY: {
            title: "Medals"
        },
        legend: {
            cursor: "pointer",
            itemclick: toggleDataSeries
        },
        toolTip: {
            shared: true,
            content: toolTipFormatter
        },
        data: [{
            type: "bar",
            showInLegend: true,
            name: "Gold",
            color: "gold",
            dataPoints: [
                { y: 243, label: "Italy" },
                { y: 236, label: "China" },
                { y: 243, label: "France" },
                { y: 273, label: "Great Britain" },
                { y: 269, label: "Germany" },
                { y: 196, label: "Russia" },
                { y: 1118, label: "USA" }
            ]
        },
        {
            type: "bar",
            showInLegend: true,
            name: "Silver",
            color: "silver",
            dataPoints: [
                { y: 212, label: "Italy" },
                { y: 186, label: "China" },
                { y: 272, label: "France" },
                { y: 299, label: "Great Britain" },
                { y: 270, label: "Germany" },
                { y: 165, label: "Russia" },
                { y: 896, label: "USA" }
            ]
        },
        {
            type: "bar",
            showInLegend: true,
            name: "Bronze",
            color: "#A57164",
            dataPoints: [
                { y: 236, label: "Italy" },
                { y: 172, label: "China" },
                { y: 309, label: "France" },
                { y: 302, label: "Great Britain" },
                { y: 285, label: "Germany" },
                { y: 188, label: "Russia" },
                { y: 788, label: "USA" }
            ]
        }]
    });
    chart.render();

}