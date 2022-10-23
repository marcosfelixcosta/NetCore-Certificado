<%@ Page Language="vb" AutoEventWireup="false" Inherits="index" CodeFile="index.aspx.vb" %>
 <%@ Register Assembly="MagicAjax" Namespace="MagicAjax.UI.Controls" TagPrefix="AJAX" %> 
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<html>
	<head>
		<title>.: CURSO DE ESPECIALIZAÇÃO DO CENTEC :.</TITLE>
				<link href="Estilo.css" type="text/css" rel="stylesheet">
					
	</head>
<body Background="imagens/bg.gif">
		<form id="Form1" method="post" runat="server">
			<table id="Table1" cellspacing="1" cellpadding="1" width="100%" height="100%" border="0">
				<tr>
					<td align="center">
						&nbsp;<table id="Table12" height="300" cellspacing="0" cellpadding="2" width="400" background="Imagens/plogin.png"
							border="0">
							<tr>
								<td valign="bottom" style="height: 300px">
									<table id="Table3" cellspacing="2" cellpadding="2" width="100%" border="0">
										<TR>
											<TD style="WIDTH: 137px"></TD>
											<TD>
												<ASP:LABEL id="Label1" runat="server" cssclass="estLabel">Usuário</ASP:LABEL></TD>
										</TR>
										<TR>
											<TD style="WIDTH: 137px"></TD>
											<TD>
												<ASP:TEXTBOX id="txtLogin" runat="server" cssclass="estTextbox" width="216px"></ASP:TEXTBOX></TD>
										</TR>
										<TR>
											<TD style="WIDTH: 137px; height: 17px;"></TD>
											<TD style="height: 17px">
												<ASP:LABEL id="Label2" runat="server" cssclass="estLabel">Senha</ASP:LABEL></TD>
										</TR>
										<TR>
											<TD style="WIDTH: 137px"></TD>
											<TD>
												<ASP:TEXTBOX id="txtSenha" runat="server" cssclass="estTextbox" width="216px" textmode="Password"></ASP:TEXTBOX></TD>
										</TR>
										<TR>
											<TD style="WIDTH: 137px"></TD>
											<TD>
												<ASP:LABEL id="LABEL3" runat="server" cssclass="estLabel">Unidade</ASP:LABEL></TD>
										</TR>
										<TR>
											<TD style="WIDTH: 137px"></TD>
											<TD>
												<ASP:DROPDOWNLIST id="ddlUnidade" runat="server" cssclass="estTextbox" width="216px">
                                                    <asp:ListItem>****  Selecione a Faculdade  ****</asp:ListItem>
                                                    <asp:ListItem Value="db_esplimoeiro">Centec Limoeiro do Norte</asp:ListItem>
                                                    <asp:ListItem Value="db_espcariri">Centec Juazeiro do Norte</asp:ListItem>
                                                    <asp:ListItem Value="db_espsobral">Centec Sobral</asp:ListItem>
                                                </ASP:DROPDOWNLIST></TD>
										</TR>
										<TR>
											<TD style="WIDTH: 137px; HEIGHT: 80px"></TD>
											<TD valign="top">
												<ASP:BUTTON id="btnLogin" runat="server" cssclass="estBotao" text="Login"></ASP:BUTTON>&nbsp;
												<ASP:BUTTON id="btnLimpar" runat="server" cssclass="estBotao" text="Limpar"></ASP:BUTTON></TD>
										</TR>
									</TABLE>
								</TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
			</TABLE>
		</FORM>
	</BODY>
</HTML>
