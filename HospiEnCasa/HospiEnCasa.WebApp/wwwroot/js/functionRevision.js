

//eliminar
$(document).on("click",".btnEliminar", function(e){
   e.preventDefault();
   
   $(this).parent().parent().find('td').each(function(index){
       
       switch(index){
           case 0:
               $('#idTecnicoEliminar').val($(this).text());
               break;  
           case 1:
               $('#idNombreEliminar').val($(this).text());
               break;                
       } 

   });

   $('#modalEliminarRevision').modal('show');
   
});

$("#btnEliminarRevision").click(function(){
      
   $.ajax({
       type: "POST",
       url: "/Revisiones/EditRevision?handler=Delete",
       contentType: "application/x-www-form-urlencoded; charset=utf-8",
       dataType: "html",
       headers: {
           "RequestVerificationToken": $('input:hidden[name="__RequestVerificationToken"]').val()
       },
       data: { "Id" : $("#idTecnicoEliminar").val()},
       
   })
   .done(function (result) {
      
       eliminado();
     
   })
   .fail(function (error) {       
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
            $('#Vertecnico').val($(this).text());
            break;
        case 2:
            $('#Verimpresora').val($(this).text());
            break;
        case 3:
            $('#Verrepuesto').val($(this).text());
            break;
        case 4:
            $('#Verprecio').val($(this).text());
            break;
        case 5:
            $('#Verfecha').val($(this).text());
            break;  
         case 6:
             $('#detalle').val($(this).text());
             break;
               
    }
  
  }),
      $('#modalViewRevisiones').modal('show');
});
