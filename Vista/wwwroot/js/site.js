// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function filtroDinamico() {
    var input, filter, tBody, tr, td, i, txtValue;
    input = document.getElementById('myInput');
    filter = input.value.toUpperCase();
    tBody = document.getElementById("myTBody");
    tr = tBody.getElementsByTagName('tr');

    for (i = 0; i < tr.length; i++) {
        td = tr[i].getElementsByTagName("td")[2];
        txtValue = td.textContent || td.innerText;
        if (txtValue.toUpperCase().indexOf(filter) > -1) {
            tr[i].style.display = "";
        } else {
            tr[i].style.display = "none";
        }
    }
}

function obtenereEmpleadoSeleccionado(x) {
    var table = document.getElementById("tablaEmpleados");
    for (var i = 0; i < table.rows.length; i++) {
        table.rows[i].style.backgroundColor = "white";
        table.rows[i].style.fontSize = "1em";
        table.rows[i].style.fontWeight = "Normal";
    }

    x.style.backgroundColor = "gray";
    x.style.fontSize = "1.2em";
    x.style.fontWeight = "bold";

    var legajo = table.rows[x.rowIndex].cells[0].innerHTML;
    document.getElementById("legajoSeleccionado").value = legajo;
}