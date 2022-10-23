/*
  o parametro "obj" deve receber um objeto que suporta texto...exemplo: "<INPUT type=text>"
  exemplo de chamada: validaNumero(document.form1.campotext);
  essa funcao deve ser chamada através do "onKeyUp"
   
  @Objetivo: garantir que somente números inteiros possam ser digitados no campo especificado.
 
 */
 

function validaNumero(obj)
{
	var tam = obj.value.length;
  for(var i=0;i<tam;i++)
  {
  	caracter = obj.value.charCodeAt(i);
   if(!(caracter >= 48 && caracter <= 57) )
	  {
       obj.value=obj.value.substring(0,tam-1);      
       validaNumero(obj);
      }
  }
}


/*
  o parametro "obj" deve receber um objeto que suporta texto...exemplo: "<INPUT type=text>"
  exemplo de chamada: validaNumeroComPontoVirg(document.form1.campotext);
  essa funcao deve ser chamada através do "onKeyUp"
   
  @Objetivo: garantir que números, o ponto e a vírgula possam ser digitados no campo especificado.
 
 */
function validaNumeroComPontoVirg(obj)
{
	var tam = obj.value.length;
  for(var i=0;i<tam;i++)
  {
  	caracter = obj.value.charCodeAt(i);
  	if (caracter != 46 && caracter != 44) {
      if(!(caracter >= 48 && caracter <= 57)) {
        obj.value=obj.value.substring(0,tam-1);      
        validaNumero(obj);
      }	
  	}
   
  }
}