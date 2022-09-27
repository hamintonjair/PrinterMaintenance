
//eliminar
$(document).on("click",".btnEliminar", function(e){
   e.preventDefault();
   
   $(this).parent().parent().find('td').each(function(index){
       
       switch(index){
           case 0:
               $('#idImpresoraEliminar').val($(this).text());
               break;  
           case 1:
               $('#idNombreEliminar').val($(this).text());
               break;                
       } 

   });

   $('#modalEliminarImpresora').modal('show');
   
});

$("#btnEliminar").click(function(){
      
   $.ajax({
       type: "POST",
       url: "/Impresoras/EditImpresoras?handler=Delete",
       contentType: "application/x-www-form-urlencoded; charset=utf-8",
       dataType: "html",
       headers: {
           "RequestVerificationToken": $('input:hidden[name="__RequestVerificationToken"]').val()
       },
       data: { "Id" : $("#idImpresoraEliminar").val()},
       
   })
   .done(function (result) {
      alert(result);
       eliminado();
     
   })
   .fail(function (error) {   
    alert(error);    
       _Error();
   });
});

//alert 
function _Error(){
   Swal.fire({
       icon: 'error',
       title: 'Error',
       text: 'Se produjo un Error en el sistema',      
     }),

    location.reload();
}

function eliminado(){
   Swal.fire({
       icon: 'success',
       title: 'Atencion',
       text: 'Se elimino la revisión',      
     }),

     location.reload();
}

//ver
$(document).on("click",".btnVer", function(e){
   e.preventDefault();
  
   $(this).parent().parent().find('td').each(function(index){

    switch(index){
       
        case 1:
            $('#Vernombre').val($(this).text());
            break;
        case 2:
            $('#Vermarca').val($(this).text());
            break;
        case 3:
            $('#Vertipo').val($(this).text());
            break;
        case 4:
            $('#Vermantenimiento').val($(this).text());
            break;
        case 5:
            $('#Verplaca').val($(this).text());
            break;   
               
    }
  
  }),
      $('#modalViewImpresoras').modal('show');
});
