//$(document).ready(function(){
//$(".flip").click(function(){
  //  $(".panel").slideToggle("slow");
 // });
//});
//$(document).ready(function(){
  //$(e1).click(function(){
   // $(e).slideToggle("slow");
  //});
//});
function getdata(id)
{
    var e=document.getElementById('d'+id);       
    $(e).slideToggle("slow");
           
}
function getsno()
{
var inputFieldsValue=1;
 var inputFields=document.getElementsByTagName("input");
 for(i=0;i<inputFields.length;i++){
    if(inputFields[i].id.indexOf("Srno")!=-1){
        inputFields[i].value= inputFieldsValue;
        inputFieldsValue++;
    }
 }
}
window.onload = function(){
getsno();
}