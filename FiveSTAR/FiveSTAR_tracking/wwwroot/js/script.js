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
  var income = parseInt(document.getElementById("income").value);
  var expense = parseInt(document.getElementById("expense").value);
  var result = income - expense;
    document.getElementById("net").value = result;
    x = income;
    pie(income, expense, pieViewAction);

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
                        { y: income },
                        { y: expense },                      
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
