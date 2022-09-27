
//eliminar
$(document).on("click",".btnEliminarSeguro", function(e){
    e.preventDefault();
    
    $(this).parent().parent().find('td').each(function(index){
        
        switch(index){
            case 0:
                $('#idSegurosEliminar').val($(this).text());
                break;  
            case 1:
                $('#idSeguroImpresoraEliminar').val($(this).text());
                break;                
        } 
 
    });
 
    $('#modalEliminarSeguro').modal('show');
    
 });
 
 $("#btnEliminarSeguros").click(function(){
       
    $.ajax({
        type: "POST",
        url: "/Seguros/EditSeguros?handler=Delete",
        contentType: "application/x-www-form-urlencoded; charset=utf-8",
        dataType: "html",
        headers: {
            "RequestVerificationToken": $('input:hidden[name="__RequestVerificationToken"]').val()
        },
        data: { "Id" : $("#idSegurosEliminar").val()},
        
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
             $('#VertipoSeguro').val($(this).text());
             break;
         case 2:
             $('#verprecio').val($(this).text());
             break;
         case 3:
             $('#verfechaActivacion').val($(this).text());
             break;
         case 4:
             $('#verfechaVencimiento').val($(this).text());
             break;         
          case 5:
              $('#verimpresora').val($(this).text());
              break;
                
     }
   
   }),
       $('#modalViewSeguro').modal('show');
 });
 