<%@ Page Language="VB" AutoEventWireup="false" CodeFile="rptlistafrequencia.aspx.vb" Inherits="rptlistafrequencia_ " %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<TITLE>rptlistafrequencia</TITLE>
		<META name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<META name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<META name="vs_defaultClientScript" content="JavaScript">
		<META name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK href="../EstiloReport.css" type="text/css" rel="stylesheet">
	</HEAD>
	<BODY leftmargin="0" rightmargin="0" topmargin="3" bottommargin="3">
		<FORM id="Form1" method="post" runat="server">
			<TABLE width="100%" border="0" cellspacing="0" cellpadding="0">
				<TR>
					<TD class="estBordaInferior" style="height: 75px; width: 342px;">&nbsp;
						<ASP:IMAGE id="Image1" runat="server" imageurl="~/imagens/Centec.png"></ASP:IMAGE></TD>
					<TD align="center" class="estBordaInferior" style="height: 75px; width: 258px;"><ASP:LABEL cssclass="estTexto14N" id="Label6" runat="server" text="DIÁRIO DE CLASSE" />
						<P>
							<ASP:LABEL cssclass="estTexto12N" id="Label7" runat="server" text="Referência: " />
							<ASP:LABEL cssclass="estTexto12N" id="lblReferenciaH" runat="server" />
						</P>
					</TD>
					<TD class="estBordaInferior" style="height: 75px" valign="middle" align="center">&nbsp;
                        <br />
                        <asp:Label ID="Label10" runat="server" CssClass="estTexto14N" Text="Carga Horária:"></asp:Label>
                        <br />
                        <asp:Label ID="lblhora" runat="server"></asp:Label></TD>
					<TD style="width: 10px; height: 75px;" class="estBordaSerrilhadaDireira">&nbsp;</TD>
					<TD class="estBordaInferior" style="width: 150px; height: 75px;">&nbsp;
						<ASP:IMAGE id="Image2" runat="server" imageurl="~/imagens/Centec.png"></ASP:IMAGE></TD>
				</TR>
				<TR>
					<TD style="height: 32px; width: 342px;"><ASP:LABEL cssclass="estTexto14N" id="Label1" runat="server" text="Curso: " />
						<ASP:LABEL cssclass="estTexto14" id="lblCurso" runat="server" /></TD>
					<TD style="height: 32px; width: 258px;"><ASP:LABEL cssclass="estTexto14N" id="Label2" runat="server" text="Modulo: " />
						<ASP:LABEL id="lblTurma" runat="server" /></TD>
					<TD style="height: 32px"><ASP:LABEL cssclass="estTexto14N" id="Label3" runat="server" text='Período: ' />
						<ASP:LABEL id="lblPeriodo" runat="server" /></TD>
					<TD style="width: 10px; height: 32px;" class="estBordaSerrilhadaDireira">&nbsp;</TD>
					<TD style="height: 32px; width: 150px;"><ASP:LABEL id="lblPeriodoC" runat="server" CssClass="estTexto14N" Font-Bold="True" Width="69px" />
						<BR>
						<ASP:LABEL id="lblReferenciaC" runat="server" CssClass="estTexto14N" Font-Bold="True" /></TD>
				</TR>
				<TR>
					<TD colspan="3" style="height: 32px"><ASP:LABEL cssclass="estTexto14N" id="Label4" runat="server" text="Disciplina: " />
						<ASP:LABEL id="lblsigla" runat="server" Width="46px" />
                        <ASP:LABEL id="lblDisciplina" runat="server" Width="267px" />
                    </TD>
					<TD style="width: 10px; height: 32px;" class="estBordaSerrilhadaDireira">&nbsp;</TD>
					<TD style="height: 32px; width: 150px;"><ASP:LABEL id="lblDisciplinaC" runat="server" CssClass="estTexto14N" Font-Bold="True" />
						<BR>
						<ASP:LABEL id="lblTurmaC" runat="server" Height="1px" Visible="False" Width="73px" CssClass="estTexto14N" Font-Bold="True" /></TD>
				</TR>
				<TR>
					<TD colspan="3" style="height: 32px"><ASP:LABEL cssclass="estTexto14N" id="Label5" runat="server" text="Professor: " />
						<ASP:LABEL id="lblProfessor" runat="server" Width="291px" /></TD>
					<TD style="width: 10px; height: 32px;" class="estBordaSerrilhadaDireira">&nbsp;</TD>
					<TD style="width: 150px; height: 32px"><ASP:LABEL id="lblProfessorC" runat="server" CssClass="estTexto14N" />
						<BR>
						<ASP:LABEL id="lblOpcionalC" runat="server" CssClass="estTexto14N" /></TD>
				</TR>
			</TABLE>
			<BR>
			<TABLE width="100%" border="0" cellspacing="0" cellpadding="0">
				<TR>
					<TD>&nbsp;
						<ASP:DATAGRID id="dtg1" runat="server" width="100%" cssclass="estGrid" autogeneratecolumns="False">
							<ITEMSTYLE cssclass="estItemGrid"></ITEMSTYLE>
							<HEADERSTYLE cssclass="estHeaderGrid"></HEADERSTYLE>
							<COLUMNS>
								<ASP:BOUNDCOLUMN datafield="alu_identificado" headertext="Matr&#237;cula">
									<HEADERSTYLE width="50px"></HEADERSTYLE>
								</ASP:BOUNDCOLUMN>
								<ASP:BOUNDCOLUMN datafield="alu_nome" headertext="Nome"></ASP:BOUNDCOLUMN>
								<ASP:BOUNDCOLUMN>
									<HEADERSTYLE width="20px"></HEADERSTYLE>
								</ASP:BOUNDCOLUMN>
								<ASP:BOUNDCOLUMN>
									<HEADERSTYLE width="20px"></HEADERSTYLE>
								</ASP:BOUNDCOLUMN>
								<ASP:BOUNDCOLUMN>
									<HEADERSTYLE width="20px"></HEADERSTYLE>
								</ASP:BOUNDCOLUMN>
								<ASP:BOUNDCOLUMN>
									<HEADERSTYLE width="20px"></HEADERSTYLE>
								</ASP:BOUNDCOLUMN>
								<ASP:BOUNDCOLUMN>
									<HEADERSTYLE width="20px"></HEADERSTYLE>
								</ASP:BOUNDCOLUMN>
								<ASP:BOUNDCOLUMN>
									<HEADERSTYLE width="20px"></HEADERSTYLE>
								</ASP:BOUNDCOLUMN>
								<ASP:BOUNDCOLUMN>
									<HEADERSTYLE width="20px"></HEADERSTYLE>
								</ASP:BOUNDCOLUMN>
								<ASP:BOUNDCOLUMN>
									<HEADERSTYLE width="20px"></HEADERSTYLE>
								</ASP:BOUNDCOLUMN>
								<ASP:BOUNDCOLUMN>
									<HEADERSTYLE width="20px"></HEADERSTYLE>
								</ASP:BOUNDCOLUMN>
								<ASP:BOUNDCOLUMN>
									<HEADERSTYLE width="20px"></HEADERSTYLE>
								</ASP:BOUNDCOLUMN>
								<ASP:BOUNDCOLUMN>
									<HEADERSTYLE width="20px"></HEADERSTYLE>
								</ASP:BOUNDCOLUMN>
								<ASP:BOUNDCOLUMN>
									<HEADERSTYLE width="20px"></HEADERSTYLE>
								</ASP:BOUNDCOLUMN>
								<ASP:BOUNDCOLUMN>
									<HEADERSTYLE width="20px"></HEADERSTYLE>
								</ASP:BOUNDCOLUMN>
								<ASP:BOUNDCOLUMN>
									<HEADERSTYLE width="20px"></HEADERSTYLE>
								</ASP:BOUNDCOLUMN>
								<ASP:BOUNDCOLUMN>
									<HEADERSTYLE width="20px"></HEADERSTYLE>
								</ASP:BOUNDCOLUMN>
							</COLUMNS>
						</ASP:DATAGRID></TD>
					<TD style="width: 10px" class="estBordaSerrilhadaDireira">&nbsp;</TD>
					<TD width="150">&nbsp;
						<ASP:DATAGRID id="dtg2" runat="server" width="100%" cssclass="estGrid" autogeneratecolumns="False">
							<ITEMSTYLE cssclass="estItemGrid"></ITEMSTYLE>
							<HEADERSTYLE cssclass="estHeaderGrid"></HEADERSTYLE>
							<COLUMNS>
								<ASP:BOUNDCOLUMN datafield="alu_identificado" headertext="Matr&#237;cula"></ASP:BOUNDCOLUMN>
								<ASP:BOUNDCOLUMN headertext="Pres"></ASP:BOUNDCOLUMN>
								<ASP:BOUNDCOLUMN headertext="Falta"></ASP:BOUNDCOLUMN>
							</COLUMNS>
						</ASP:DATAGRID></TD>
				</TR>
			</TABLE>
			<BR>
			<TABLE width="100%" border="0" cellspacing="0" cellpadding="0">
				<TR>
					<TD style="height: 15px">&nbsp;
						<ASP:LABEL cssclass="estTexto12N" id="lblDataImpressao" runat="server" Font-Size="Smaller" />
                        <asp:Label ID="Label9" runat="server" Text="Label" Visible="False" Font-Size="Smaller" Width="57px"></asp:Label></TD>
					<TD width="10" class="estBordaSerrilhadaDireira" style="height: 15px">&nbsp;</TD>
					<TD width="150" style="height: 15px">&nbsp;
						<ASP:LABEL id="Label8" runat="server" cssclass="estTexto12N">___________________</ASP:LABEL></TD>
				</TR>
			</TABLE>
		</FORM>
	</BODY>
</HTML>
