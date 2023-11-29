function filtroDinamicoProyecto(input_view, body_view) {
    var input, filter, tBody, tr, td, i, txtValue;
    input = document.getElementById(`${input_view}`);
    filter = input.value.toUpperCase();
    tBody = document.getElementById(`${body_view}`);
    tr = tBody.getElementsByTagName('tr');

    for (i = 0; i < tr.length; i++) {
        td = tr[i].getElementsByTagName("td")[0];
        txtValue = td.textContent || td.innerText;
        if (txtValue.toUpperCase().indexOf(filter) > -1) {
            tr[i].style.display = "";
        } else {
            tr[i].style.display = "none";
        }
    }
}

function limpiarView() {
    window.location.reload(); 
}