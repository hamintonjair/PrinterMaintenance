
//eliminar
$(document).on("click",".btnEliminartipo", function(e){
    e.preventDefault();
    
    $(this).parent().parent().find('td').each(function(index){
        
        switch(index){
            case 0:
                $('#idtipoEliminar').val($(this).text());
                break;  
            case 1:
                $('#idNombreEliminar').val($(this).text());
                break;                
        } 
 
    });
 
    $('#modalEliminartipo').modal('show');
    
 });
 
 $("#btnEliminartipo").click(function(){
       
    $.ajax({
        type: "POST",
        url: "/Impresoras/EditTipo_Impresora?handler=Delete",
        contentType: "application/x-www-form-urlencoded; charset=utf-8",
        dataType: "html",
        headers: {
            "RequestVerificationToken": $('input:hidden[name="__RequestVerificationToken"]').val()
        },
        data: { "Id" : $("#idtipoEliminar").val()},
        
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
             $('#VerTipoimpresora').val($(this).text());
             break;         
     }
   
   }),
       $('#modalViewVerTipoimpresora').modal('show');
 });
 