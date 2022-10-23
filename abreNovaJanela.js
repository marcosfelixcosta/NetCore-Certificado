
function novaJanela(pPagina){
	var topo = 0;
	var esquerda = 0;
	var altura = window.screen.availHeight - 50;
	var largura = window.screen.availWidth - 10;
	
	if (document.all) { 
		window.open(pPagina,'Visualizar','left='+esquerda+',top='+topo+',width='+largura+',height='+altura+',status=yes,scrollbars=yes,menubar=no,resizable=yes');
	}
	
}

