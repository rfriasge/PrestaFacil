function InitTable1() {
    if ($.fn.dataTable.isDataTable(".table")) {
        //alert("Ya esta inicializada");
        return;
    } else {
        $(".tabl").DataTable({
            search: true,
            language: {
                url: "lib/datatable/idioma_espanol.json"
            },
            "drawCallback": function () {
                $('.dataTables_paginate > .pagination').addClass('pagination-sm');
            }
        });
    }
    
    //$(".table").DataTable({
    //    search: true,
    //    language: {
    //        url: "lib/datatable/idioma_espanol.json"
    //    },
    //    "drawCallback": function () {
    //        $('.dataTables_paginate > .pagination').addClass('pagination-sm');
    //    }
    //});

};

function esta_inicializada() {
    if ($.fn.dataTable.isDataTable(".table")) {
        //alert("TRUE")
        return true;
    }
    else {
       
    }
       
        return false;
}

function reload() {
    window.location.reload();
}