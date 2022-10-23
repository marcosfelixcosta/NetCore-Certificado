// FormataData: Formata a data, com as barras, bastando digitar os números.
// chdata: checa validade da data digitada

function RemoveNoNumeric(caracs){	
	if (caracs.length > 0){ 
		var resultado = '';
		for (var i = 0; (i < caracs.length); i++) {		
			var aux = caracs.substr(i,1);			
			if ((aux.charCodeAt()  > 47) && (aux.charCodeAt() < 58)){
				resultado = resultado + aux;					
			}		
		}		
		return resultado;
	}
	else{
		return caracs;
	}
}

function anobissexto(year){
	if (year % 4 == 0)
		return true;
	else
		return false; 
}

function FormataData(Campo,teclapres) {
	if ( (parseInt(navigator.appVersion) >= 5) || (navigator.appName == 'Microsoft Internet Explorer') ) {		
		FormataData1(Campo, teclapres);
	}
	else {
		FormataData2(Campo, teclapres);
	}
}//Fim da função FormataData

function FormataData1(Campo,teclapres){
	var tecla = teclapres.keyCode;
	vr = RemoveNoNumeric(Campo.value);
	tam = vr.length;	
	
	if ( (tecla >= 48 && tecla <= 57) || (tecla >= 96 && tecla <= 105 ) ){
		if ( tam > 1 && tam < 3)
			Campo.value = vr.substr( 0, 2 ) + '/' + vr.substr( 2, 2 );
		if ( tam > 3)
			Campo.value = vr.substr( 0, 2 ) + '/' + vr.substr( 2, 2 ) + '/' +	vr.substr( 4, 4 );
	}//fim do if
	else {
		if (tecla != 8 && tecla != 9 && tecla != 13){			
			vr = RemoveNoNumeric(Campo.value);
			Campo.value = vr;
		}
	}//fim do else
}//Fim da função FormataData1

function FormataData2(Campo,teclapres){
	if (navigator.appName == 'Netscape') {tecla = teclapres.which;} else {tecla = teclapres.keyCode;}
		vr = RemoveNoNumeric(Campo.value);
		tam = vr.length;
		if ( tecla >= 48 && tecla <= 57 ){
			if ( tam >= 8 ) {
			Campo.value = vr.substr( 0, 2 ) + '/' + vr.substr( 2, 2 ) + '/' +
			vr.substr( 4, 4 );
			}
		}
		else{
			if (tecla != 9 && tecla != 13){
				vr = RemoveNoNumeric(Campo.value);
				Campo.value = FormataData2(vr);
				}
		}//fim do else
}//fim da função FormataData2

function chdata(xcampo){
	var campo = xcampo.value
	var datavalida = true;
	var quatro = true;
	if (campo!=""){
		if (campo.length != 10)
		datavalida = false
	else {
		dia = (campo.substr(0, 2));
		mes = (campo.substr(3, 2));
		ano = (campo.substr(6, 4));
		if (anobissexto(ano) == true)
		var dias = new Array(31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30,31)
	else
		var dias = new Array(31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30,31);
		if (ano < 1000){
			quatro = false;
		}
	if ((ano < 1) || (ano > 9999)) {
		datavalida = false;
	}
	else
	if ((mes < 1) || (mes > 12)) {
		datavalida = false;
	}
	else
		if ((dia < 1) || (dia > dias[mes-1])) {
			datavalida = false;
		}
	}//fim do else
	}//fim do if
	if (datavalida == false) {
		alert('Data informada esta invalida');
		xcampo.value = "";
		xcampo.focus();
	}
	else if (quatro == false) {
		alert('Informe o ano com 4 digitos');
		xcampo.value = "";
		xcampo.focus();
	}
	return datavalida;
}

/*

No sua página html use:

<script language="Javascript" src="fcValidaData.js"></script>

<input type="text" name="dt_teste" value=""
onKeyDown="FormataData(this,event)" onBlur="chdata(this)">
*/