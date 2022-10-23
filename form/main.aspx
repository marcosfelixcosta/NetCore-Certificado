<%@ Page Language="VB" AutoEventWireup="false" CodeFile="main.aspx.vb" Inherits="Forms_main" %>
 <%@ Register Assembly="MagicAjax" Namespace="MagicAjax.UI.Controls" TagPrefix="AJAX" %> 
 <!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
<TITLE>.:CURSO DE ESPECIALIZAÇÃO DO CENTEC</TITLE>
	<link href="../Estilo.css" type="text/css" rel="stylesheet">
       
<script language="javascript" type="text/javascript">

</script>
</head>
<body topmargin=0 leftmargin=0 bottommargin=0 rightmargin=0  background="../imagens/bg.gif">
 
    <form id="form1" runat="server">
         <div style="text-align: left; left: 0px; top: 0px;">
           <table style="font-weight: bold; font-size: 12pt; text-transform: uppercase; height: 54px; background-color: transparent;" align="center" width="100%">
                        <tr>
                            <td align="center" background="../imagens/cabec.png" colspan="3" style="font-weight: bold; text-transform: uppercase; height: 76px; color: white; background-color: white; width: 955px;">
                                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;CURSO DE PÓS-GRADUAÇÃO LATO SENSU &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                            </td>
                        </tr>
                    </table>
            <table border="0" width="100" align="center">
                <tr>
                    <td style="width: 6px; height: 1px" valign="top">
                    </td>
                    <td style="width: 100px; height: 1px;" valign="top">
                        <asp:ImageButton ID="ImageButton11" runat="server" ImageUrl="~/imagens/M_alunos.gif" ToolTip="Cadastro de Alunos" /></td>
                    <td style="width: 96px; height: 1px;" valign="top">
                        <asp:ImageButton ID="ImageButton14" runat="server" ImageUrl="~/imagens/M_curso.gif" ToolTip="Cadastro de Cursos" /></td>
                    <td style="width: 100px; height: 1px;" valign="top">
                        <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/imagens/M_certificado.gif" ToolTip="Certificado" /><br />
                        <br />
                        </td>
                    <td style="width: 101px; height: 1px" valign="top">
                        <asp:ImageButton ID="ImageButton15" runat="server" ImageUrl="~/imagens/M_disciplina.gif" ToolTip="Cadastro de Disciplinas" /></td>
                    <td style="width: 100px; height: 1px" valign="top">
                        <asp:ImageButton ID="ImageButton18" runat="server" ImageUrl="~/imagens/M_professor.gif" ToolTip="Cadastro de Professores" /></td>
                    <td style="height: 1px" valign="top">
                        <asp:ImageButton ID="ImageButton22" runat="server" ImageUrl="~/imagens/historico.gif" ToolTip="Histórico Escolar" /></td>
                    <td style="width: 1633px; height: 1px" valign="top">
                        <asp:ImageButton ID="ImageButton19" runat="server" ImageUrl="~/imagens/Diario_.gif" ToolTip="Imprimir Diário de Classe" />
                    </td>
                </tr>
            </table>
            <hr />
                                <asp:Label ID="lbsau" runat="server" Font-Size="Small" ForeColor="MidnightBlue" Width="100%" Visible="False"></asp:Label>
               <AJAX:AjaxPanel ID="AjaxPanel1" runat="server" Width="100%"> 
               <asp:MultiView ID="Multicertificado" runat="server">
                 <asp:View ID="View_Luno" runat="server">
                    <table border="0" align="center" contenteditable="false">
                        <tr>
                            <td colspan="3" bgcolor="#99ccff">
                            
                            <asp:ImageButton ID="ImageButton4" runat="server" ImageUrl="~/imagens/Novo_.gif" ToolTip="Novo aluno" /><asp:ImageButton ID="Alu_btnsalvar" runat="server" ImageUrl="~/imagens/Salvar_.gif" Enabled="False" ToolTip="Salvar" /><asp:ImageButton ID="alu_btncancelar" runat="server" ImageUrl="~/imagens/Cancelar_.gif" Enabled="False" ToolTip="Cancelar" /><asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/imagens/Consultar_.gif" ToolTip="Consultar" /><asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/imagens/Imprimir_.gif" ToolTip="Imprimir" /></td>
                        </tr>
                        <tr>
                            <td bgcolor="#99ccff" colspan="3" style="font-weight: bold; text-transform: uppercase; border-top-style: none; border-right-style: none; border-left-style: none;
                            height: 36px; text-align: center; border-bottom-style: none;">
                                <span style="font-size: 16pt; font-family: Arial"><strong><em style="color: white">&nbsp;Cadastro
                                    de ALUNOS</em></strong></span></td>
                        </tr>
                        
                      
                        <tr>
                            <td bgcolor="#99ccff" colspan="3"><table border="0" bgcolor="#99ccff">
                                <tr>
                                    <td colspan="1" style="width: 3px;">
                            <asp:Label ID="Label1" runat="server" Text="Curso:" CssClass="estlabel" Height="1px"></asp:Label><asp:DropDownList ID="a_DropDowncurso" runat="server" Enabled="False" Width="248px" BackColor="#FFFFC0" DataTextField="cur_curso" DataValueField="cur_codigo" Font-Bold="False" ForeColor="Blue" CssClass="estTextbox" AutoPostBack="True">
                            </asp:DropDownList></td>
                                    <td colspan="1">
                            <asp:Label ID="Label2" runat="server" Text="Local:" CssClass="estlabel" Height="1px"></asp:Label><br />
                                        <asp:TextBox ID="a_txtlocal" runat="server" Width="160px" Enabled="False" ForeColor="Blue" BorderStyle="Groove" CssClass="estTextboxRO"></asp:TextBox></td>
                                    <td colspan="1">
                            <asp:Label ID="Label3" runat="server" Text="Turno:" ForeColor="Black" CssClass="estlabel" Height="8px"></asp:Label><br />
                                        <asp:DropDownList ID="a_DropDownturno" runat="server" Width="78px" Enabled="False" ForeColor="Blue" BackColor="#FFFFC0" CssClass="estTextbox">
                                <asp:ListItem>Manh&#227;</asp:ListItem>
                                <asp:ListItem>Tarde</asp:ListItem>
                                <asp:ListItem>Noite</asp:ListItem>
                                <asp:ListItem>Intermedi&#225;rio</asp:ListItem>
                            </asp:DropDownList></td>
                                    <td colspan="1" style="width: 3px;">
                            <asp:Label ID="Label8" runat="server" Text="Inicio:" ForeColor="Black" CssClass="estlabel" Height="1px"></asp:Label><br />
                                        <asp:TextBox ID="a_txtinicio" runat="server" Width="88px" Enabled="False" ForeColor="Blue" BorderStyle="Groove" CssClass="estTextboxRO" AutoPostBack="True"></asp:TextBox></td>
                                    <td colspan="1" style="width: 3px">
                            <asp:Label ID="Label9" runat="server" Text="Termino:" ForeColor="Black" CssClass="estlabel" Height="1px"></asp:Label><br />
                                        <asp:TextBox ID="a_txtfim" runat="server" Width="88px" Enabled="False" ForeColor="Blue" BorderStyle="Groove" CssClass="estTextboxRO" AutoPostBack="True"></asp:TextBox></td>
                                </tr>
                            </table>
                                <table border="0" bgcolor="#99ccff">
                                    <tr>
                                        <td colspan="1" style="width: 3px;">
                            <asp:Label ID="Label4" runat="server" Text="Matrícula:" CssClass="estlabel" Height="1px"></asp:Label><asp:TextBox ID="a_txtidentificacao" runat="server" Width="64px" Enabled="False" ForeColor="Blue" BorderStyle="Groove" BackColor="#FFFFC0" ReadOnly="True" CssClass="estTextboxRO"></asp:TextBox></td>
                                        <td colspan="1" style="width: 3px;">
                            <asp:Label ID="Label5" runat="server" Text="Aluno:*" CssClass="estlabel" Height="8px" Width="32px"></asp:Label><asp:TextBox ID="a_txtaluno" runat="server" Width="208px" Enabled="False" ForeColor="Blue" BorderStyle="Groove" CssClass="estTextboxRO"></asp:TextBox></td>
                                        <td colspan="1" style="width: 3px;">
                            <asp:Label ID="Label6" runat="server" Text="Endereço:" CssClass="estlabel" Height="1px"></asp:Label><asp:TextBox ID="a_txtendereco" runat="server" Width="224px" Enabled="False" ForeColor="Blue" BorderStyle="Groove" CssClass="estTextboxRO"></asp:TextBox></td>
                                        <td colspan="1" style="width: 3px;">
                            <asp:Label ID="Label7" runat="server" Text="Nº:" CssClass="estlabel" Height="1px"></asp:Label><asp:TextBox ID="a_txtn" runat="server" Width="44px" Enabled="False" ForeColor="Blue" BorderStyle="Groove" CssClass="estTextboxRO"></asp:TextBox></td>
                                        <td colspan="1" style="width: 3px">
                            <asp:Label ID="Label10" runat="server" Text="Complemento:" CssClass="estlabel" Height="8px"></asp:Label><asp:TextBox ID="a_txtcompl" runat="server" Width="112px" Enabled="False" ForeColor="Blue" BorderStyle="Groove" CssClass="estTextboxRO"></asp:TextBox></td>
                                    </tr>
                                </table>
                                <table border="0" bgcolor="#99ccff">
                                    <tr>
                                        <td colspan="1" style="width: 3px; height: 38px">
                            <asp:Label ID="Label11" runat="server" Text="Bairro:" CssClass="estlabel" Height="1px"></asp:Label><asp:TextBox ID="a_txtbairro" runat="server" Width="224px" Enabled="False" ForeColor="Blue" BorderStyle="Groove" CssClass="estTextboxRO"></asp:TextBox></td>
                                        <td colspan="1" style="height: 38px; width: 3px;">
                            <asp:Label ID="Label12" runat="server" Text="UF:" CssClass="estlabel" Height="1px"></asp:Label><asp:DropDownList ID="a_DropDownuf" runat="server" Width="76px" Enabled="False" AutoPostBack="True" ForeColor="Blue" BackColor="#FFFFC0" CssClass="estTextbox">
                                <asp:ListItem>AC</asp:ListItem>
                                <asp:ListItem>AL</asp:ListItem>
                                <asp:ListItem>AM</asp:ListItem>
                                <asp:ListItem>AP</asp:ListItem>
                                <asp:ListItem>BA</asp:ListItem>
                                <asp:ListItem>CE</asp:ListItem>
                                <asp:ListItem>DF</asp:ListItem>
                                <asp:ListItem>ES</asp:ListItem>
                                <asp:ListItem>GO</asp:ListItem>
                                <asp:ListItem>MA</asp:ListItem>
                                <asp:ListItem>MG</asp:ListItem>
                                <asp:ListItem>MS</asp:ListItem>
                                <asp:ListItem>MT</asp:ListItem>
                                <asp:ListItem>PA</asp:ListItem>
                                <asp:ListItem>PB</asp:ListItem>
                                <asp:ListItem>PE</asp:ListItem>
                                <asp:ListItem>PI</asp:ListItem>
                                <asp:ListItem>PR</asp:ListItem>
                                <asp:ListItem>RJ</asp:ListItem>
                                <asp:ListItem>RN</asp:ListItem>
                                <asp:ListItem>RO</asp:ListItem>
                                <asp:ListItem>RR</asp:ListItem>
                                <asp:ListItem>RS</asp:ListItem>
                                <asp:ListItem>SC</asp:ListItem>
                                <asp:ListItem>SE</asp:ListItem>
                                <asp:ListItem>SP</asp:ListItem>
                                <asp:ListItem>TO</asp:ListItem>
                            </asp:DropDownList></td>
                                        <td colspan="1" style="width: 3px; height: 38px;">
                            <asp:Label ID="Label13" runat="server" Text="Cidade:" CssClass="estlabel" Height="1px"></asp:Label><asp:DropDownList ID="a_DropDowncidade" runat="server" Width="232px" Enabled="False" DataTextField="CD_CIDADE" DataValueField="CD_CODIGO" ForeColor="Blue" BackColor="#FFFFC0" CssClass="estTextbox">
                            </asp:DropDownList></td>
                                        <td colspan="1" style="width: 3px; height: 38px">
                            <asp:Label ID="Label14" runat="server" Text="CEP:" CssClass="estlabel" Height="1px"></asp:Label><asp:TextBox ID="a_txtcep" runat="server" Width="140px" Enabled="False" ForeColor="Blue" BorderStyle="Groove" CssClass="estTextboxRO"></asp:TextBox></td>
                                    </tr>
                                </table>
                                <table border="0" bgcolor="#99ccff" style="width: 1px">
                                    <tr>
                                        <td colspan="1" style="width: 3px;">
                            <asp:Label ID="Label15" runat="server" Text="Fone1:" CssClass="estlabel" Height="1px" Width="48px"></asp:Label><asp:TextBox ID="a_txtfone1" runat="server" Width="88px" Enabled="False" ForeColor="Blue" BorderStyle="Groove" CssClass="estTextboxRO"></asp:TextBox></td>
                                        <td colspan="1" style="width: 3px;">
                            <asp:Label ID="Label19" runat="server" Text="Fone2:" CssClass="estlabel" Height="8px" Width="40px"></asp:Label><asp:TextBox ID="a_txtfone2" runat="server" Width="88px" Enabled="False" ForeColor="Blue" BorderStyle="Groove" CssClass="estTextboxRO"></asp:TextBox></td>
                                        <td colspan="1" style="width: 3px;">
                            <asp:Label ID="Label16" runat="server" Text="Fax:" CssClass="estlabel" Height="1px" Width="24px"></asp:Label><asp:TextBox ID="a_txtfax" runat="server" Width="88px" Enabled="False" ForeColor="Blue" BorderStyle="Groove" CssClass="estTextboxRO"></asp:TextBox></td>
                                        <td colspan="1" style="width: 3px;">
                            <asp:Label ID="Label17" runat="server" Text="Email:" CssClass="estlabel" Height="8px" Width="40px"></asp:Label><asp:TextBox ID="a_txtemail" runat="server" Width="200px" Enabled="False" ForeColor="Blue" BorderStyle="Groove" CssClass="estTextboxRO"></asp:TextBox></td>
                                        <td colspan="1" style="width: 3px">
                            <asp:Label ID="Label18" runat="server" Text="Celular:" CssClass="estlabel" Height="1px"></asp:Label><asp:TextBox ID="a_txtcelular" runat="server" Width="80px" Enabled="False" ForeColor="Blue" BorderStyle="Groove" CssClass="estTextboxRO"></asp:TextBox></td>
                                        <td colspan="1" style="width: 3px">
                            <asp:Label ID="Label20" runat="server" Text="CPF:" CssClass="estlabel" Width="32px" Height="1px"></asp:Label><asp:TextBox ID="a_txtcpf" runat="server" Width="96px" Enabled="False" ForeColor="Blue" BorderStyle="Groove" CssClass="estTextboxRO"></asp:TextBox></td>
                                    </tr>
                                </table>
                                <table border="0" bgcolor="#99ccff" width="100">
                                    <tr>
                                        <td colspan="1" style="width: 3px;">
                            <asp:Label ID="Label21" runat="server" Text="Identidade:" CssClass="estlabel" Height="1px"></asp:Label><asp:TextBox ID="a_txtidentidade" runat="server" Width="88px" Enabled="False" ForeColor="Blue" BorderStyle="Groove" CssClass="estTextboxRO"></asp:TextBox></td>
                                        <td colspan="1" style="width: 2px;">
                            <asp:Label ID="Label22" runat="server" Text="Org.emissor:" Width="80px" CssClass="estlabel" Height="1px"></asp:Label><asp:TextBox ID="a_txtemissor" runat="server" Width="96px" Enabled="False" ForeColor="Blue" BorderStyle="Groove" CssClass="estTextboxRO"></asp:TextBox></td>
                                        <td colspan="1" style="width: 3px;">
                            <asp:Label ID="Label23" runat="server" Text="Naturalidade:" CssClass="estlabel" Height="1px" Width="72px"></asp:Label><asp:TextBox ID="a_txtnaturalidade" runat="server" Width="128px" Enabled="False" ForeColor="Blue" BorderStyle="Groove" CssClass="estTextboxRO"></asp:TextBox></td>
                                        <td colspan="1" style="width: 3px;">
                            <asp:Label ID="Label24" runat="server" Text="Nascimento:" CssClass="estlabel" Height="1px"></asp:Label><asp:TextBox ID="a_txtnascimento" runat="server" Width="96px" Enabled="False" ForeColor="Blue" BorderStyle="Groove" CssClass="estTextboxRO" AutoPostBack="True"></asp:TextBox></td>
                                        <td colspan="1" style="width: 3px">
                            <asp:Label ID="Label26" runat="server" Text="Formação:" CssClass="estlabel" Width="40px" Height="1px"></asp:Label><asp:TextBox ID="a_txtformacao" runat="server" Width="240px" Enabled="False" ForeColor="Blue" BorderStyle="Groove" CssClass="estTextboxRO"></asp:TextBox></td>
                                    </tr>
                                </table>
                                <table border="0" bgcolor="#99ccff" width="100">
                                    <tr>
                                        <td colspan="1" style="width: 3px; height: 38px;">
                            <asp:Label ID="Label25" runat="server" Text="Instituição:" CssClass="estlabel" Height="1px"></asp:Label><asp:TextBox ID="a_txtinstituicao" runat="server" Width="248px" Enabled="False" ForeColor="Blue" BorderStyle="Groove" CssClass="estTextboxRO"></asp:TextBox></td>
                                        <td colspan="1" style="width: 3px; height: 38px;">
                            <asp:Label ID="Label27" runat="server" Text="Data:" CssClass="estlabel" Height="1px"></asp:Label><asp:TextBox ID="a_txtano" runat="server" Width="63px" Enabled="False" ForeColor="Blue" BorderStyle="Groove" CssClass="estTextboxRO" AutoPostBack="True"></asp:TextBox></td>
                                        <td colspan="1" style="width: 3px; height: 38px;">
                            <asp:Label ID="Label28" runat="server" Text="Titulação:" CssClass="estlabel" Height="8px" Width="64px"></asp:Label><asp:TextBox ID="a_txttitulacaomaxima" runat="server" Width="208px" Enabled="False" ForeColor="Blue" BorderStyle="Groove" CssClass="estTextboxRO"></asp:TextBox></td>
                                        <td colspan="1" style="width: 3px; height: 38px;">
                            <asp:Label ID="Label29" runat="server" Text="Data:" CssClass="estlabel" Height="1px" Width="40px"></asp:Label><asp:TextBox ID="a_txtanotitulacao" runat="server" Width="136px" Enabled="False" ForeColor="Blue" BorderStyle="Groove" CssClass="estTextboxRO" AutoPostBack="True"></asp:TextBox></td>
                                    </tr>
                                </table>
                <table border="0" bgcolor="#99ccff">
                    <tr>
                        <td colspan="1">
                            <asp:Label ID="Label30" runat="server" Text="Área de Atuação:" CssClass="estlabel" Height="8px" Width="104px"></asp:Label><br />
                            <asp:TextBox ID="a_txtareadeatuacao" runat="server" Width="248px" Enabled="False" ForeColor="Blue" BorderStyle="Groove" CssClass="estTextboxRO"></asp:TextBox></td>
                    </tr>
                </table>
                                &nbsp;
                                <table border="0">
                                    <tr>
                                        <td colspan="8" style="height: 18px">
                            <asp:Label ID="Label31" runat="server" Font-Bold="True" Text="Dados Profissionais: " Width="184px"></asp:Label></td>
                                    </tr>
                                </table>
                <table border="0" bgcolor="#99ccff" style="width: 1px">
                    <tr>
                        <td colspan="1">
                            <asp:Label ID="Label32" runat="server" Text="Instituição de Origem:" CssClass="estlabel" Height="8px"></asp:Label><br />
                            <asp:TextBox ID="a_txtinstorigem" runat="server" Width="232px" Enabled="False" ForeColor="Blue" BorderStyle="Groove" CssClass="estTextboxRO"></asp:TextBox></td>
                        <td colspan="1" style="width: 199px">
                            <asp:Label ID="Label34" runat="server" Text="Endereço:" CssClass="estlabel" Height="1px"></asp:Label><br />
                            <asp:TextBox ID="a_txtenderecoinst" runat="server" Width="176px" Enabled="False" ForeColor="Blue" BorderStyle="Groove" CssClass="estTextboxRO"></asp:TextBox></td>
                        <td colspan="1">
                            <asp:Label ID="Label35" runat="server" Text="Nº:" CssClass="estlabel" Height="8px"></asp:Label><br />
                            <asp:TextBox ID="a_txtninst" runat="server" Width="41px" Enabled="False" ForeColor="Blue" BorderStyle="Groove" CssClass="estTextboxRO"></asp:TextBox></td>
                        <td colspan="1" style="width: 179px">
                            <asp:Label ID="Label33" runat="server" Text="Complemento:" CssClass="estlabel" Height="8px"></asp:Label><br />
                            <asp:TextBox ID="a_txtcompinst" runat="server" Width="168px" Enabled="False" ForeColor="Blue" BorderStyle="Groove" CssClass="estTextboxRO"></asp:TextBox></td>
                    </tr>
                </table>
                <table border="0" bgcolor="#99ccff">
                    <tr>
                        <td colspan="1">
                            <asp:Label ID="Label36" runat="server" Text="Bairro:" CssClass="estlabel" Height="8px"></asp:Label><br />
                            <asp:TextBox ID="a_txtbairroinst" runat="server" Width="184px" Enabled="False" ForeColor="Blue" BorderStyle="Groove" CssClass="estTextboxRO"></asp:TextBox></td>
                        <td colspan="1">
                            <asp:Label ID="Label37" runat="server" Text="UF:" CssClass="estlabel" Height="8px"></asp:Label><br />
                            <asp:DropDownList ID="a_DropDownufinst" runat="server" Width="74px" Enabled="False" AutoPostBack="True" ForeColor="Blue" BackColor="#FFFFC0" CssClass="estTextbox">
                                <asp:ListItem>AC</asp:ListItem>
                                <asp:ListItem>AL</asp:ListItem>
                                <asp:ListItem>AM</asp:ListItem>
                                <asp:ListItem>AP</asp:ListItem>
                                <asp:ListItem>BA</asp:ListItem>
                                <asp:ListItem>CE</asp:ListItem>
                                <asp:ListItem>DF</asp:ListItem>
                                <asp:ListItem>ES</asp:ListItem>
                                <asp:ListItem>GO</asp:ListItem>
                                <asp:ListItem>MA</asp:ListItem>
                                <asp:ListItem>MG</asp:ListItem>
                                <asp:ListItem>MS</asp:ListItem>
                                <asp:ListItem>MT</asp:ListItem>
                                <asp:ListItem>PA</asp:ListItem>
                                <asp:ListItem>PB</asp:ListItem>
                                <asp:ListItem>PE</asp:ListItem>
                                <asp:ListItem>PI</asp:ListItem>
                                <asp:ListItem>PR</asp:ListItem>
                                <asp:ListItem>RJ</asp:ListItem>
                                <asp:ListItem>RN</asp:ListItem>
                                <asp:ListItem>RO</asp:ListItem>
                                <asp:ListItem>RR</asp:ListItem>
                                <asp:ListItem>RS</asp:ListItem>
                                <asp:ListItem>SC</asp:ListItem>
                                <asp:ListItem>SE</asp:ListItem>
                                <asp:ListItem>SP</asp:ListItem>
                                <asp:ListItem>TO</asp:ListItem>
                            </asp:DropDownList></td>
                        <td colspan="1">
                            <asp:Label ID="Label38" runat="server" Text="Cidade:" CssClass="estlabel" Height="8px"></asp:Label><br />
                            <asp:DropDownList ID="a_DropDowncidadeinst" runat="server" Width="232px" Enabled="False" DataTextField="cd_cidade" DataValueField="cd_codigo" ForeColor="Blue" BackColor="#FFFFC0" CssClass="estTextbox">
                            </asp:DropDownList></td>
                        <td colspan="1">
                            <asp:Label ID="Label39" runat="server" Text="CEP:" CssClass="estlabel" Height="8px"></asp:Label><br />
                            <asp:TextBox ID="a_txtcepinst" runat="server" Width="136px" Enabled="False" ForeColor="Blue" BorderStyle="Groove" CssClass="estTextboxRO"></asp:TextBox></td>
                    </tr>
                </table>
                <table border="0" bgcolor="#99ccff" id="TABLE4" onclick="return TABLE4_onclick()" style="width: 8px">
                    <tr>
                        <td colspan="1">
                            <asp:Label ID="Label40" runat="server" Text="Fone(1):" CssClass="estlabel" Height="1px" Width="56px"></asp:Label><br />
                            <asp:TextBox ID="a_txtfone1inst" runat="server" Width="120px" Enabled="False" ForeColor="Blue" BorderStyle="Groove" CssClass="estTextboxRO"></asp:TextBox></td>
                        <td colspan="1">
                            <asp:Label ID="Label41" runat="server" Text="Fone(2):" CssClass="estlabel" Height="1px" Width="56px"></asp:Label><br />
                            <asp:TextBox ID="a_txtfone2inst" runat="server" Width="104px" Enabled="False" ForeColor="Blue" BorderStyle="Groove" CssClass="estTextboxRO"></asp:TextBox></td>
                        <td colspan="1">
                            <asp:Label ID="Label43" runat="server" Text="Fax:" CssClass="estlabel" Height="1px"></asp:Label><br />
                            <asp:TextBox ID="a_txtfaxinst" runat="server" Width="120px" Enabled="False" ForeColor="Blue" BorderStyle="Groove" CssClass="estTextboxRO"></asp:TextBox></td>
                        <td colspan="1" style="width: 291px">
                            <asp:Label ID="Label42" runat="server" Text="E-mail:" CssClass="estlabel" Height="8px"></asp:Label><br />
                            <asp:TextBox ID="a_txtemailinst" runat="server" Width="264px" Enabled="False" ForeColor="Blue" BorderStyle="Groove" CssClass="estTextboxRO"></asp:TextBox></td>
                        <td colspan="1" style="width: 20%; height: 23px">
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" style="height: 38px">
                            <asp:Label ID="Label44" runat="server" Text="Cargo:" CssClass="estlabel" Height="8px"></asp:Label><br />
                            <asp:TextBox ID="a_txtcargo" runat="server" BorderStyle="Groove" Width="232px" Enabled="False" ForeColor="#0000C0" CssClass="estTextboxRO"></asp:TextBox></td>
                        <td colspan="2" style="height: 38px">
                            <asp:Label ID="Label47" runat="server" Text="Função:" CssClass="estlabel" Height="8px"></asp:Label><br />
                            <asp:TextBox ID="a_txtformacaoinst" runat="server" BorderStyle="Groove" Width="304px" Enabled="False" ForeColor="#0000C0" CssClass="estTextboxRO"></asp:TextBox></td>
                        <td colspan="1" style="width: 20%; height: 38px">
                        </td>
                    </tr>
                </table>
                <table border="0" bgcolor="#99ccff">
                    <tr>
                        <td colspan="4" style="height: 22px;">
                            <asp:Label ID="Label45" runat="server" Font-Bold="True" Text="Documentos:"></asp:Label>
                            <asp:TextBox ID="a_txtH" runat="server" Visible="False" Width="27px" CssClass="estTextboxRO"></asp:TextBox>
                            <asp:TextBox ID="a_txtD" runat="server" Visible="False" Width="27px" CssClass="estTextboxRO"></asp:TextBox>
                            <asp:TextBox ID="a_txtF" runat="server" Visible="False" Width="31px" CssClass="estTextboxRO"></asp:TextBox>
                            <asp:TextBox ID="txtcodigoalu" runat="server" Visible="False" Width="21px" CssClass="estTextboxRO"></asp:TextBox></td>
                    </tr>
                </table><table border="0" bgcolor="#99ccff">
                    <tr>
                        <td colspan="1" style="width: 44px; height: 22px;">
                            <asp:DropDownList ID="a_DropDowndocumento" runat="server" Width="192px" Enabled="False" AutoPostBack="True" ForeColor="Blue" DataTextField="ALU_DOCUMENTO" DataValueField="ALU_DOCUMENTO" BackColor="#FFFFC0" CssClass="estTextbox">
                                <asp:ListItem Value="------------Selecione---------------">------------Selecione------------</asp:ListItem>
                                <asp:ListItem>Completo</asp:ListItem>
                                <asp:ListItem>Incompleto</asp:ListItem>
                            </asp:DropDownList></td>
                        <td colspan="1" style="width: 49px; height: 22px;">
                            <asp:CheckBox ID="a_CheckBoxhistorico" runat="server" Text="Histórico " Enabled="False" Width="72px" Visible="False" /></td>
                        <td colspan="1" style="width: 53px; height: 22px;">
                            <asp:CheckBox ID="a_CheckBoxdiplomainst" runat="server" Text="Diploma" Enabled="False" Width="72px" Visible="False" /></td>
                        <td colspan="1" style="width: 85px; height: 22px;">
                            <asp:CheckBox ID="a_CheckBoxfoto" runat="server" Text="Foto-3x4" Enabled="False" Width="72px" Visible="False" /></td>
                    </tr>
                </table>
                            <asp:DataGrid ID="DataGridaluno" runat="server" CellPadding="4" GridLines="None" AutoGenerateColumns="False" AllowPaging="True" ForeColor="#333333" CssClass="estGrid">
                                <FooterStyle BackColor="#507CD1" ForeColor="White" Font-Bold="True" />
                                <EditItemStyle BackColor="#2461BF" BorderColor="#99CCFF" BorderStyle="Groove" />
                                <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" CssClass="estPagerGrid" Mode="NumericPages" Font-Bold="True" />
                                <AlternatingItemStyle BackColor="White" />
                                <ItemStyle BackColor="#EFF3FB" Font-Bold="False" Font-Size="Smaller" />
                                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                <Columns>
                                    <asp:BoundColumn DataField="alu_codigo" HeaderText="C&#243;digo" Visible="False">
                                        <HeaderStyle Width="5%" />
                                    </asp:BoundColumn>
                                    <asp:BoundColumn DataField="alu_identificado" HeaderText="Matr&#237;cula">
                                        <ItemStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                            Font-Underline="False" HorizontalAlign="Center" />
                                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                            Font-Underline="False" HorizontalAlign="Center" Width="10%" />
                                    </asp:BoundColumn>
                                    <asp:BoundColumn DataField="alu_nome" HeaderText="Aluno">
                                        <HeaderStyle Width="40%" />
                                    </asp:BoundColumn>
                                    <asp:BoundColumn DataField="alu_periodo" HeaderText="Inicio" DataFormatString="{0:dd/MM/yyyy}">
                                        <HeaderStyle Width="5%" />
                                    </asp:BoundColumn>
                                    <asp:BoundColumn DataField="alu_termino" HeaderText="Termino" DataFormatString="{0:dd/MM/yyyy}">
                                        <HeaderStyle Width="5%" />
                                    </asp:BoundColumn>
                                    <asp:ButtonColumn CommandName="Delete" HeaderText="Excluir" Text="&lt;img src=&quot;../Imagens/e_excluir.png&quot; border=&quot;0&quot;&gt;">
                                        <ItemStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                            Font-Underline="False" HorizontalAlign="Center" />
                                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                            Font-Underline="False" HorizontalAlign="Center" Width="5%" />
                                        <FooterStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                            Font-Underline="False" HorizontalAlign="Center" />
                                    </asp:ButtonColumn>
                                    <asp:ButtonColumn CommandName="Edit" HeaderText="Editar" Text="&lt;img src=&quot;../Imagens/e_editar.png&quot; border=&quot;0&quot;&gt;">
                                        <ItemStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                            Font-Underline="False" HorizontalAlign="Center" />
                                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                            Font-Underline="False" HorizontalAlign="Center" Width="5%" />
                                        <FooterStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                            Font-Underline="False" HorizontalAlign="Center" />
                                    </asp:ButtonColumn>
                                </Columns>
                            </asp:DataGrid></td>
                        </tr>
                    </table>
                   
                </asp:View>
               
             
            <asp:View ID="View_Professor" runat="server">
                <table border="0" width="100" bgcolor="#99ccff" align="center">
                <tr>
                        <td colspan="3" style="border-top-width: thin; border-left-width: thin; border-left-color: white; border-top-color: white; border-bottom: white thin solid; border-right-width: thin; border-right-color: white; height: 48px; width: 797px;" rowspan="">
                            &nbsp;<asp:ImageButton ID="ImageButton5" runat="server" ImageUrl="~/imagens/Novo_.gif" ToolTip="Novo professor" />
                            <asp:ImageButton ID="p_btnsalvar" runat="server" ImageUrl="~/imagens/Salvar_.gif" ToolTip="Salvar" />
                            <asp:ImageButton ID="p_btncancelar" runat="server" ImageUrl="~/imagens/Cancelar_.gif" ToolTip="Cancelar" />
                            <asp:ImageButton ID="ImageButton31" runat="server" ImageUrl="~/imagens/Consultar_.gif" ToolTip="Consultar" />
                            <asp:ImageButton ID="ImageButton8" runat="server" ImageUrl="~/imagens/Imprimir_.gif" ToolTip="Imprimir" />
                            <asp:ImageButton ID="ImageButton26" runat="server" ImageUrl="~/imagens/prof_curso.gif" ToolTip="Associar professor ao curso/disciplina" />
                            </td>
                    </tr>
                    <tr>
                        <td colspan="3" style="font-weight: bold; font-size: 15pt; text-transform: uppercase;
                            width: 797px; color: white; text-indent: 15pt; height: 25px; text-align: center; border-bottom: white thin solid;">
                            <span style="font-family: Arial"><em style="color: white">&nbsp;Cadastro de Professores</em></span></td>
                    </tr>
                    <tr>
                        <td colspan="3" style="width: 797px; height: 31px">
                <table border="0" width="100%">
                    <tr>
                        <td colspan="1" style="width: 215px; height: 21px">
                            <asp:Label ID="Label46" runat="server" Text="Professor: *" CssClass="estlabel" Width="83px"></asp:Label><br />
                            <asp:TextBox ID="p_txtprofessor" runat="server" Width="208px" Enabled="False" BorderStyle="Groove" ForeColor="Blue" CssClass="estTextboxRO"></asp:TextBox></td>
                        <td colspan="4" style="width: 28%; height: 21px">
                            <asp:Label ID="Label48" runat="server" Text="Formação:" CssClass="estlabel" Width="70px"></asp:Label><br />
                            <asp:TextBox ID="p_txtformacao" runat="server" Width="216px" Enabled="False" BorderStyle="Groove" ForeColor="Blue" CssClass="estTextboxRO"></asp:TextBox></td>
                        <td colspan="1" style="height: 21px; width: 206px;">
                            <asp:Label ID="Label49" runat="server" Text="Area de Atuação:" CssClass="estlabel" Width="106px"></asp:Label><br />
                            <asp:TextBox ID="p_txtatuacao" runat="server" Width="190px" Enabled="False" BorderStyle="Groove" ForeColor="Blue" CssClass="estTextboxRO"></asp:TextBox></td>
                    </tr>
                </table>
                <table border="0" width="100%">
                    <tr>
                        <td colspan="1" style="width: 263px; height: 21px">
                            <asp:Label ID="Label50" runat="server" Text="Titulação:" CssClass="estlabel" Width="70px"></asp:Label><br />
                            <asp:DropDownList ID="p_txttitulacao" runat="server" Enabled="False"
                                Width="208px" CssClass="estTextbox" ForeColor="Blue">
                                <asp:ListItem>******  Selecione a Titula&#231;&#227;o ******</asp:ListItem>
                                <asp:ListItem>Doutor</asp:ListItem>
                                <asp:ListItem>Mestre</asp:ListItem>
                                <asp:ListItem>Especialista</asp:ListItem>
                                <asp:ListItem>Phd</asp:ListItem>
                            </asp:DropDownList></td>
                        <td colspan="4" style="width: 17%; height: 21px">
                            <asp:Label ID="Label51" runat="server" Text="Data de Ingresso:" CssClass="estlabel" Height="1px" Width="112px"></asp:Label><br />
                            <asp:TextBox ID="p_txtingresso" runat="server" Width="108px" Enabled="False" BorderStyle="Groove" ForeColor="Blue" CssClass="estTextboxRO" AutoPostBack="True"></asp:TextBox></td>
                        <td colspan="1" style="width: 391px; height: 21px">
                            <asp:Label ID="Label72" runat="server" Text="Unidade:" CssClass="estlabel" Width="64px"></asp:Label><br />
                            <asp:DropDownList ID="p_dropunidade" runat="server" DataTextField="uni_nome"
                                DataValueField="uni_codigo" Enabled="False" ForeColor="Blue" Width="312px" CssClass="estTextbox">
                            </asp:DropDownList></td>
                        <td colspan="1" style="height: 21px">
                            <br />
                            </td>
                    </tr>
                </table>
                            <asp:TextBox ID="txtcodigoprof" runat="server" Visible="False" Width="32px" CssClass="estTextboxRO"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td colspan="3" style="width: 797px; height: 36px">
                            <asp:DataGrid ID="DataGridprofessor" runat="server" CellPadding="4" GridLines="None" Width="100%" AutoGenerateColumns="False" AllowPaging="True" Height="130px" ForeColor="#333333">
                                <FooterStyle BackColor="#507CD1" ForeColor="White" Font-Bold="True" />
                                <EditItemStyle BackColor="#2461BF" BorderColor="#99CCFF" BorderStyle="Groove" />
                                <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" CssClass="estPagerGrid" Mode="NumericPages" />
                                <AlternatingItemStyle BackColor="White" />
                                <ItemStyle BackColor="#EFF3FB" Font-Size="Smaller" />
                                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                <Columns>
                                    <asp:BoundColumn DataField="prof_codigo" HeaderText="C&#243;digo" Visible="False">
                                        <HeaderStyle Width="5%" />
                                    </asp:BoundColumn>
                                    <asp:BoundColumn DataField="Prof_nome" HeaderText="Professor">
                                        <HeaderStyle Width="30%" />
                                    </asp:BoundColumn>
                                    <asp:BoundColumn DataField="prof_formacao" HeaderText="Forma&#231;&#227;o" DataFormatString="{0:dd/MM/yyyy}">
                                        <HeaderStyle Width="20%" />
                                    </asp:BoundColumn>
                                    <asp:BoundColumn DataField="prof_atuacao" HeaderText="Area de atua&#231;&#227;o">
                                        <ItemStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                            Font-Underline="False" HorizontalAlign="Center" />
                                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                            Font-Underline="False" HorizontalAlign="Center" />
                                    </asp:BoundColumn>
                                    <asp:BoundColumn DataField="prof_titulacao" HeaderText="Titula&#231;&#227;o"></asp:BoundColumn>
                                    <asp:BoundColumn DataField="prof_ingresso" HeaderText="Ingresso" DataFormatString="{0:dd/MM/yyyy}">
                                        <HeaderStyle Width="5%" />
                                    </asp:BoundColumn>
                                    <asp:ButtonColumn CommandName="Delete" HeaderText="Excluir" Text="&lt;img src=&quot;../Imagens/e_excluir.png&quot; border=&quot;0&quot;&gt;">
                                        <ItemStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                            Font-Underline="False" HorizontalAlign="Center" />
                                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                            Font-Underline="False" HorizontalAlign="Center" Width="5%" />
                                        <FooterStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                            Font-Underline="False" HorizontalAlign="Center" />
                                    </asp:ButtonColumn>
                                    <asp:ButtonColumn CommandName="Edit" HeaderText="Editar" Text="&lt;img src=&quot;../Imagens/e_editar.png&quot; border=&quot;0&quot;&gt;">
                                        <ItemStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                            Font-Underline="False" HorizontalAlign="Center" />
                                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                            Font-Underline="False" HorizontalAlign="Center" Width="5%" />
                                        <FooterStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                            Font-Underline="False" HorizontalAlign="Center" />
                                    </asp:ButtonColumn>
                                </Columns>
                            </asp:DataGrid></td>
                    </tr>
                </table>
            </asp:View>
            <asp:View ID="View_disciplina" runat="server">
                <table border="0" align="center" width="100">
                    <tr>
                        <td colspan="3" style="height: 36px;" bgcolor="#99ccff" width="40%">
                            &nbsp;<asp:ImageButton ID="ImageButton9" runat="server" ImageUrl="~/imagens/Novo_.gif" ToolTip="Nova disciplina" />
                            <asp:ImageButton ID="d_btnsalvar" runat="server" ImageUrl="~/imagens/Salvar_.gif" ToolTip="Salvar" />
                            <asp:ImageButton ID="d_btncancelar" runat="server" ImageUrl="~/imagens/Cancelar_.gif" ToolTip="Cancelar" />
                            <asp:ImageButton ID="ImageButton6" runat="server" ImageUrl="~/imagens/Consultar_.gif" ToolTip="Consultar" />
                            <asp:ImageButton ID="ImageButton12" runat="server" ImageUrl="~/imagens/Imprimir_.gif" ToolTip="Imprimir" />
                            </td>
                    </tr>
                    <tr>
                        <td bgcolor="#99ccff" colspan="3" style="font-weight: bold; text-transform: uppercase; border-top-style: none; border-right-style: none; border-left-style: none;
                            height: 31px; text-align: center; border-bottom-style: none" width="40%">
                            <span style="font-size: 16pt; font-family: Arial"><strong><em style="color: white">Cadastro
                                de Disciplinas<asp:TextBox ID="txtdsci_cod" runat="server" BorderStyle="Groove" Visible="False"
                                Width="33px" CssClass="estTextboxRO"></asp:TextBox></em></strong></span></td>
                    </tr>
                    <tr>
                        <td bgcolor="#99ccff" colspan="3" style="height: 36px;" width="40%">
                <table border="0" width="100%">
                    <tr>
                        <td colspan="2" style="width: 13%; height: 10px">
                            <asp:Label ID="Label54" runat="server" Text="Código:" CssClass="estlabel" Height="1px"></asp:Label><br />
                            <asp:TextBox ID="d_txtcoddisciplina" runat="server" Width="90%" Enabled="False" BorderStyle="Groove" ForeColor="Blue" CssClass="estTextboxRO"></asp:TextBox></td>
                        <td colspan="1" style="width: 39%; height: 10px">
                            <asp:Label ID="Label85" runat="server" Text="Disciplina:" CssClass="estlabel" Height="1px" Width="64px"></asp:Label><br />
                            <asp:TextBox ID="d_txtdisciplina" runat="server" BorderStyle="Groove" Enabled="False"
                                Width="300px" ForeColor="Blue" CssClass="estTextboxRO"></asp:TextBox></td>
                        <td colspan="1" style="width: 72px; height: 10px">
                            <asp:Label ID="Label55" runat="server" Text="CH. Teórica:" CssClass="estlabel" Height="8px"></asp:Label><br />
                            <asp:TextBox ID="d_txtchteorica" runat="server" Width="72px" Enabled="False" BorderStyle="Groove" ForeColor="Blue" CssClass="estTextboxRO"></asp:TextBox></td>
                        <td colspan="1" style="width: 12%; height: 10px">
                            <asp:Label ID="Label56" runat="server" Text="CH. Pratica:" CssClass="estlabel" Height="8px"></asp:Label><br />
                            <asp:TextBox ID="d_txtchpratica" runat="server" Width="80px" Enabled="False" BorderStyle="Groove" ForeColor="Blue" CssClass="estTextboxRO"></asp:TextBox></td>
                        <td colspan="3" style="height: 10px; width: 158px;">
                            <asp:Label ID="Label57" runat="server" Text="Creditos:" CssClass="estlabel" Height="1px"></asp:Label><br />
                            <asp:TextBox ID="d_txtcredito" runat="server" BorderStyle="Groove" CssClass="estTextboxRO"
                                Enabled="False" Width="73px" ForeColor="Blue"></asp:TextBox></td>
                    </tr>
                </table><table border="0" width="100%">
                    <tr>
                        <td colspan="2" style="width: 14%; height: 10px">
                            <asp:Label ID="Label71" runat="server" Text="Vigência:" CssClass="estlabel"></asp:Label><br />
                            <asp:TextBox ID="d_txtvigencia" runat="server" BorderStyle="Groove" Enabled="False"
                                ForeColor="Blue" Width="94%" CssClass="estTextboxRO"></asp:TextBox></td>
                        <td colspan="1" style="width: 66%; height: 10px">
                            <asp:Label ID="Label90" runat="server" Text="Módulo:" CssClass="estlabel"></asp:Label><br />
                            <asp:DropDownList ID="d_dropmodulo" runat="server" DataTextField="mod_modulo"
                                DataValueField="mod_codigo" Enabled="False" Width="184px" ForeColor="Blue" CssClass="estTextbox">
                            </asp:DropDownList></td>
                        <td colspan="1" style="width: 79px; height: 10px">
                            <br />
                        </td>
                    </tr>
                </table>
                            <asp:DataGrid ID="DataGrid_disciplina" runat="server" CellPadding="4" GridLines="None" Width="100%" AutoGenerateColumns="False" AllowPaging="True" Height="130px" ForeColor="#333333">
                    <FooterStyle BackColor="#507CD1" ForeColor="White" Font-Bold="True" />
                    <EditItemStyle BackColor="#2461BF" BorderColor="#99CCFF" BorderStyle="Groove" />
                    <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" CssClass="estPagerGrid" Mode="NumericPages" />
                    <AlternatingItemStyle BackColor="White" />
                    <ItemStyle BackColor="#EFF3FB" Font-Size="Smaller" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <Columns>
                        <asp:BoundColumn DataField="dc_codigo" HeaderText="C&#243;digo" Visible="False">
                            <HeaderStyle Width="5%" />
                        </asp:BoundColumn>
                        <asp:BoundColumn DataField="dc_coddisciplina" HeaderText="C&#243;digo"></asp:BoundColumn>
                        <asp:BoundColumn DataField="dc_disciplina" HeaderText="Disciplina">
                            <HeaderStyle Width="30%" />
                        </asp:BoundColumn>
                        <asp:BoundColumn HeaderText="M&#243;dulo" DataField="mod_modulo">
                            <HeaderStyle Width="20%" Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" />
                            <ItemStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" />
                        </asp:BoundColumn>
                        <asp:BoundColumn HeaderText="CH.Te&#243;rica" DataField="dc_chteorica">
                            <ItemStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" />
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" />
                        </asp:BoundColumn>
                        <asp:BoundColumn HeaderText="CH. Pr&#225;tica" DataField="dc_chpratica">
                            <ItemStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" />
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" />
                        </asp:BoundColumn>
                        <asp:BoundColumn DataField="dc_vigencia" HeaderText="Vig&#234;ncia">
                            <HeaderStyle Width="3%" />
                            <ItemStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" />
                        </asp:BoundColumn>
                        <asp:ButtonColumn CommandName="Delete" HeaderText="Excluir" Text="&lt;img src=&quot;../Imagens/e_excluir.png&quot; border=&quot;0&quot;&gt;">
                            <ItemStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                            Font-Underline="False" HorizontalAlign="Center" />
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                            Font-Underline="False" HorizontalAlign="Center" Width="5%" />
                            <FooterStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                            Font-Underline="False" HorizontalAlign="Center" />
                        </asp:ButtonColumn>
                        <asp:ButtonColumn CommandName="Edit" HeaderText="Editar" Text="&lt;img src=&quot;../Imagens/e_editar.png&quot; border=&quot;0&quot;&gt;">
                            <ItemStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                            Font-Underline="False" HorizontalAlign="Center" />
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                            Font-Underline="False" HorizontalAlign="Center" Width="5%" />
                            <FooterStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                            Font-Underline="False" HorizontalAlign="Center" />
                        </asp:ButtonColumn>
                    </Columns>
                </asp:DataGrid></td>
                    </tr>
                </table>
            </asp:View>
            <asp:View ID="View_curso" runat="server">
                <table border="0" width="100" align="center">
                    <tr>
                        <td colspan="3" style="width: 100%; height: 36px;" bgcolor="#99ccff">
                            &nbsp;<asp:ImageButton ID="ImageButton13" runat="server" ImageUrl="~/imagens/Novo_.gif" ToolTip="Novo curso" />
                            <asp:ImageButton ID="c_btnsalvar" runat="server" ImageUrl="~/imagens/Salvar_.gif" Enabled="False" ToolTip="Salvar" />
                            <asp:ImageButton ID="c_btncancelar" runat="server" ImageUrl="~/imagens/Cancelar_.gif" Enabled="False" ToolTip="Cancelar" />
                            <asp:ImageButton ID="ImageButton7" runat="server" ImageUrl="~/imagens/Consultar_.gif" ToolTip="Consultar" />
                            <asp:ImageButton ID="ImageButton16" runat="server" ImageUrl="~/imagens/Imprimir_.gif" ToolTip="Imprimir" />
                            </td>
                    </tr>
                    <tr>
                        <td bgcolor="#99ccff" colspan="3" style="font-weight: bold; font-size: 16pt; text-transform: uppercase;
                            width: 100%; color: white; height: 36px; text-align: center;">
                            <span style="font-size: 16pt; font-family: Arial"><strong><em>Cadastro de Cursos</em></strong></span></td>
                    </tr>
                    <tr>
                        <td bgcolor="#99ccff" colspan="3" style="width: 100%; height: 36px">
                <table border="0" width="100%">
                    <tr>
                        <td colspan="1" style="width: 60px;" valign="top">
                            <asp:Label ID="Label69" runat="server" Text="Código:" CssClass="estlabel"></asp:Label><br />
                            <asp:TextBox ID="cc_txtcodigodocurso" runat="server" BorderStyle="Groove" Enabled="False" Width="152px" ForeColor="Blue" CssClass="estTextboxRO"></asp:TextBox></td>
                        <td colspan="3" style="width: 97%; height: 28px;" valign="top">
                            <asp:Label ID="Label59" runat="server" Text="Curso:*" CssClass="estlabel"></asp:Label><br />
                            <asp:TextBox ID="c_txtcurso" runat="server" Width="256px" Enabled="False" BorderStyle="Groove" ForeColor="Blue" CssClass="estTextboxRO"></asp:TextBox></td>
                        <td colspan="1" style="height: 28px" valign="top">
                            <asp:Label ID="Label60" runat="server" Text="Resolução:" CssClass="estlabel"></asp:Label><br />
                            <asp:DropDownList ID="c_DropDresolucao" runat="server" Width="232px" Enabled="False" BackColor="#FFFFC0" DataTextField="res_resolucao" DataValueField="res_codigo" ForeColor="Blue" CssClass="estTextbox">
                            </asp:DropDownList><br />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="1" style="width: 60px; height: 23px">
                            <asp:Label ID="Label61" runat="server" Text="Classificação:" CssClass="estlabel"></asp:Label><br />
                            <asp:DropDownList ID="c_Dropclassificacao" runat="server" Width="160px" Enabled="False" BackColor="#FFFFC0" DataTextField="clas_classificacao" DataValueField="clas_codigo" ForeColor="Blue" CssClass="estTextbox">
                            </asp:DropDownList></td>
                        <td colspan="7" style="height: 23px">
                            <asp:Label ID="label_cv" runat="server" Text="Portaria:" CssClass="estlabel"></asp:Label>&nbsp;<br />
                            <asp:DropDownList ID="c_DropDownportaria" runat="server" Enabled="False" Width="287px" BackColor="#FFFFC0" DataTextField="po_portaria" DataValueField="po_codigo" ForeColor="Blue" CssClass="estTextbox">
                            </asp:DropDownList>
                            <asp:TextBox ID="Textocd_curso" runat="server" BorderStyle="Groove" Visible="False"
                                Width="30px" CssClass="estTextboxRO"></asp:TextBox></td>
                    </tr>
                </table>
                        </td>
                    </tr>
                    <tr>
                        <td bgcolor="#99ccff" colspan="3" style="width: 100%; height: 30px">
                            <asp:DataGrid ID="DataGrid_curso" runat="server" CellPadding="4" GridLines="None" Width="100%" AutoGenerateColumns="False" AllowPaging="True" Height="130px" ForeColor="#333333">
                                <FooterStyle BackColor="#507CD1" ForeColor="White" Font-Bold="True" />
                                <EditItemStyle BackColor="#2461BF" BorderColor="#99CCFF" BorderStyle="Groove" />
                                <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" CssClass="estPagerGrid" Mode="NumericPages" />
                                <AlternatingItemStyle BackColor="White" />
                                <ItemStyle BackColor="#EFF3FB" Font-Size="Smaller" />
                                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                <Columns>
                                    <asp:BoundColumn DataField="cur_codigo" HeaderText="C&#243;digo" Visible="False">
                                        <HeaderStyle Width="5%" />
                                    </asp:BoundColumn>
                                    <asp:BoundColumn DataField="cur_codcurso" HeaderText="C&#243;digo">
                                        <ItemStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                            Font-Underline="False" HorizontalAlign="Center" />
                                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                            Font-Underline="False" HorizontalAlign="Center" />
                                    </asp:BoundColumn>
                                    <asp:BoundColumn DataField="cur_curso" HeaderText="Curso">
                                        <HeaderStyle Width="40%" />
                                    </asp:BoundColumn>
                                    <asp:BoundColumn DataField="clas_classificacao" HeaderText="Classifica&#231;&#227;o">
                                        <HeaderStyle Width="10%" />
                                    </asp:BoundColumn>
                                    <asp:BoundColumn DataField="res_resolucao" HeaderText="Resolu&#231;&#227;o">
                                        <HeaderStyle Width="25%" />
                                    </asp:BoundColumn>
                                    <asp:BoundColumn DataField="po_portaria" HeaderText="Portaria">
                                        <HeaderStyle Width="20%" />
                                    </asp:BoundColumn>
                                    <asp:ButtonColumn CommandName="Delete" HeaderText="Excluir" Text="&lt;img src=&quot;../Imagens/e_excluir.png&quot; border=&quot;0&quot;&gt;">
                                        <ItemStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                            Font-Underline="False" HorizontalAlign="Center" />
                                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                            Font-Underline="False" HorizontalAlign="Center" Width="3%" />
                                        <FooterStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                            Font-Underline="False" HorizontalAlign="Center" />
                                    </asp:ButtonColumn>
                                    <asp:ButtonColumn CommandName="Edit" HeaderText="Editar" Text="&lt;img src=&quot;../Imagens/e_editar.png&quot; border=&quot;0&quot;&gt;">
                                        <ItemStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                            Font-Underline="False" HorizontalAlign="Center" />
                                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                            Font-Underline="False" HorizontalAlign="Center" Width="3%" />
                                        <FooterStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                            Font-Underline="False" HorizontalAlign="Center" />
                                    </asp:ButtonColumn>
                                </Columns>
                            </asp:DataGrid></td>
                    </tr>
                </table>
            </asp:View>
                &nbsp;&nbsp;&nbsp;<asp:View ID="View_certifrente" runat="server">
                <table border="0" width="100" align="center">
                    <tr>
                        <td colspan="3" style="width: 100%; height: 36px" bgcolor="#99ccff">
                            &nbsp;<asp:ImageButton ID="ImageButton17" runat="server" ImageUrl="~/imagens/Novo_.gif" ToolTip="Novo certificado" />
                            <asp:ImageButton ID="cf_btnsalvar" runat="server" ImageUrl="~/imagens/Salvar_.gif" Enabled="False" ToolTip="Salvar" />
                            <asp:ImageButton ID="cf_btncancelar" runat="server" ImageUrl="~/imagens/Cancelar_.gif" Enabled="False" ToolTip="Cancelar" />
                            <asp:ImageButton ID="ImageButton20" runat="server" ImageUrl="~/imagens/Consultar_.gif" ToolTip="Consultar" />
                            </td>
                    </tr>
                    <tr>
                        <td bgcolor="#99ccff" colspan="3" style="font-weight: bold; font-size: 15pt; text-transform: uppercase;
                            width: 100%; color: white; height: 36px; text-align: center">
                            <span style="font-family: Arial"><em> Certificado</em></span></td>
                    </tr>
                    <tr>
                        <td bgcolor="#99ccff" colspan="3" style="width: 100%; height: 35px">
                   <table border="0" width="100%">
                    <tr>
                        <td colspan="3" style="width: 42%; height: 35px;">
                            <asp:Label ID="Label62" runat="server" Text="Nome do Aluno: *" CssClass="estlabel"></asp:Label><br />
                            <asp:DropDownList ID="cf_Dropaluno" runat="server" Width="312px" Enabled="False" BackColor="#FFFFC0" DataTextField="alu_nome" DataValueField="alu_codigo" ForeColor="Blue" CssClass="estTextbox">
                            </asp:DropDownList></td>
                        <td colspan="1" style="width: 6px; height: 35px;">
                            <asp:Label ID="Label64" runat="server" Text="Curso:" CssClass="estlabel"></asp:Label><br />
                            <asp:DropDownList ID="cf_Dropcurso" runat="server" Width="328px" Enabled="False" BackColor="#FFFFC0" DataTextField="cur_curso" DataValueField="cur_codigo" ForeColor="Blue" CssClass="estTextbox">
                            </asp:DropDownList></td>
                    </tr>
                </table>
                <table border="0" width="100%">
                    <tr>
                        <td colspan="1" style="height: 42px; width: 40%;">
                            <asp:Label ID="Label65" runat="server" Text="Realização do Curso:"
                                Width="128px" CssClass="estlabel"></asp:Label><br />
                            <asp:TextBox ID="cf_txtrealizacao" runat="server" Width="288px" Enabled="False" BorderStyle="Groove" ForeColor="Blue" CssClass="estTextboxRO"></asp:TextBox></td>
                        <td colspan="1" style="width: 6px; height: 42px">
                            </td>
                    </tr>
                </table>
                <table border="0" width="100%">
                    <tr>
                        <td colspan="4" style="height: 55px" align="left">
                            <asp:Label ID="Label67" runat="server" CssClass="estlabel" Text="Título da Monografia:"></asp:Label><br />
                        <asp:TextBox ID="cf_titulomonografia" runat="server" Width="640px" MaxLength="250" Enabled="False" BorderStyle="Groove" ForeColor="Blue" CssClass="estTextboxRO"></asp:TextBox></td>
                    </tr>
                </table>
                            <asp:TextBox ID="txtcod_cert_frent" runat="server" Visible="False" Width="1px" BorderStyle="Groove" CssClass="estTextboxRO" Height="7px"></asp:TextBox>
                            <asp:DataGrid ID="DataGridCfrente" runat="server" CellPadding="4" GridLines="None" Width="100%" AutoGenerateColumns="False" AllowPaging="True" Height="130px" ForeColor="#333333">
                                <FooterStyle BackColor="#507CD1" ForeColor="White" Font-Bold="True" />
                                <EditItemStyle BackColor="#2461BF" BorderColor="#99CCFF" BorderStyle="Groove" />
                                <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" CssClass="estPagerGrid" Mode="NumericPages" />
                                <AlternatingItemStyle BackColor="White" />
                                <ItemStyle BackColor="#EFF3FB" Font-Size="Smaller" />
                                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                <Columns>
                                    <asp:BoundColumn DataField="cer_codigo" HeaderText="C&#243;digo" Visible="False">
                                        <ItemStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                            Font-Underline="False" HorizontalAlign="Center" />
                                        <HeaderStyle Width="5%" Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" />
                                    </asp:BoundColumn>
                                    <asp:BoundColumn DataField="alu_nome" HeaderText="Aluno"></asp:BoundColumn>
                                    <asp:BoundColumn DataField="cur_curso" HeaderText="Curso"></asp:BoundColumn>
                                    <asp:BoundColumn DataField="cer_realizacaodocurso" HeaderText="Realiza&#231;&#227;o">
                                        <HeaderStyle Width="20%" />
                                    </asp:BoundColumn>
                                    <asp:ButtonColumn CommandName="Delete" HeaderText="Excluir" Text="&lt;img src=&quot;../Imagens/e_excluir.png&quot; border=&quot;0&quot;&gt;">
                                        <ItemStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                            Font-Underline="False" HorizontalAlign="Center" />
                                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                            Font-Underline="False" HorizontalAlign="Center" Width="3%" />
                                        <FooterStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                            Font-Underline="False" HorizontalAlign="Center" />
                                    </asp:ButtonColumn>
                                    <asp:ButtonColumn CommandName="Edite" HeaderText="Editar" Text="&lt;img src=&quot;../Imagens/e_editar.png&quot; border=&quot;0&quot;&gt;">
                                        <ItemStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                            Font-Underline="False" HorizontalAlign="Center" />
                                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                            Font-Underline="False" HorizontalAlign="Center" Width="3%" />
                                        <FooterStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                            Font-Underline="False" HorizontalAlign="Center" />
                                    </asp:ButtonColumn>
                                </Columns>
                            </asp:DataGrid></td>
                    </tr>
                </table>
            </asp:View>
                &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;&nbsp;
                <asp:View ID="View_Diario" runat="server">
                    <table border="0" width="100" align="center">
                        <tr>
                            <td bgcolor="#99ccff" colspan="3" style="font-weight: bold; font-size: 15pt; text-transform: uppercase;
                            width: 100%; color: white; height: 36px; text-align: center">
                                <span style="font-family: Arial"><em>DIÁRIO DE CLASSE</em></span></td>
                        </tr>
                        <tr>
                            <td bgcolor="#99ccff" colspan="3" style="width: 100%; height: 36px">
                                <table border="0" width="100%">
                                    <tr>
                                        <td colspan="1" style="height: 21px">
                                            <asp:Label ID="Label80" runat="server" Text="Informe o Nome do Curso:" CssClass="estlabel"></asp:Label><br />
                                            <asp:DropDownList ID="dro_curso" runat="server" Width="545px" BackColor="#FFFFC0" DataTextField="cur_curso" DataValueField="cur_codigo" AutoPostBack="True" ForeColor="Blue" CssClass="estTextbox">
                                            </asp:DropDownList></td>
                                    </tr>
                                </table>
                                <table border="0" width="100%">
                                    <tr>
                                        <td colspan="1" style="height: 21px; width: 551px;">
                                            <asp:Label ID="Label68" runat="server" Text="Informe o Nome do Professor:" CssClass="estlabel"></asp:Label><br />
                                            <asp:DropDownList ID="dro_professor" runat="server" Width="545px" BackColor="#FFFFC0" DataTextField="prof_nome" DataValueField="prof_codigo" AutoPostBack="True" ForeColor="Blue" CssClass="estTextbox">
                                            </asp:DropDownList></td>
                                    </tr>
                                </table>
                                <table border="0" width="100%">
                                    <tr>
                                        <td colspan="1" style="height: 21px">
                                            <asp:Label ID="Label75" runat="server" Text="Informe o Nome da Disciplina:" CssClass="estlabel"></asp:Label><br />
                                            <asp:DropDownList ID="dro_disciplina" runat="server" Width="545px" BackColor="#FFFFC0" DataTextField="dc_disciplina" DataValueField="dc_codigo" AutoPostBack="True" ForeColor="Blue" CssClass="estTextbox">
                                            </asp:DropDownList></td>
                                    </tr>
                                </table>
                                <table border="0" width="100%">
                                    <tr>
                                        <td colspan="1" style="height: 21px; width: 121px;">
                                            <asp:Label ID="Label76" runat="server" Text="Início do Curso:" CssClass="estlabel"></asp:Label><br />
                                            <asp:TextBox ID="dro_txtinicio" runat="server" Width="113px" ForeColor="Blue" BorderStyle="Groove" CssClass="estTextboxRO" AutoPostBack="True"></asp:TextBox></td>
                                        <td colspan="1" style="width: 420px; height: 21px">
                                            <asp:Label ID="Label77" runat="server" Text="Término do Curso:" CssClass="estlabel"></asp:Label><br />
                                            <asp:TextBox ID="dro_txttermino" runat="server" Width="114px" ForeColor="Blue" BorderStyle="Groove" CssClass="estTextboxRO" AutoPostBack="True"></asp:TextBox></td>
                                    </tr>
                                </table>
                                <table border="0" width="100%">
                                    <tr>
                                        <td colspan="1" style="height: 21px; width: 256px;">
                                            <asp:Label ID="Label78" runat="server" Text="Informe o turno:" CssClass="estlabel"></asp:Label><br />
                                            <asp:DropDownList ID="dro_turno" runat="server" Width="230px" ForeColor="Blue" BackColor="#FFFFC0" CssClass="estTextbox" Enabled="False">
                                                <asp:ListItem>Manh&#227;</asp:ListItem>
                                                <asp:ListItem>Tarde</asp:ListItem>
                                                <asp:ListItem>Noite</asp:ListItem>
                                                <asp:ListItem>Intermedi&#225;rio</asp:ListItem>
                                            </asp:DropDownList><br />
                                            <br />
                                            <asp:Label ID="Label79" runat="server" Text="Informe o mês:" CssClass="estlabel"></asp:Label><br />
                                            <asp:DropDownList ID="dro_mes" runat="server" Width="230px" BackColor="#FFFFC0" DataTextField="cer_titulomonografia" DataValueField="cer_codigo" ForeColor="Blue" CssClass="estTextbox" Enabled="False">
                                                <asp:ListItem>JANEIRO</asp:ListItem>
                                                <asp:ListItem>FEVEREIRO</asp:ListItem>
                                                <asp:ListItem>MAR&#199;O</asp:ListItem>
                                                <asp:ListItem>ABRIL</asp:ListItem>
                                                <asp:ListItem>MAIO</asp:ListItem>
                                                <asp:ListItem>JUNHO</asp:ListItem>
                                                <asp:ListItem>JULHO</asp:ListItem>
                                                <asp:ListItem>AGOSTO</asp:ListItem>
                                                <asp:ListItem>SETEMBRO</asp:ListItem>
                                                <asp:ListItem>OUTUBRO</asp:ListItem>
                                                <asp:ListItem>NOVEMBRO</asp:ListItem>
                                                <asp:ListItem>DEZEMBRO</asp:ListItem>
                                            </asp:DropDownList></td>
                                        <td align="center" colspan="1" style="height: 21px">
                                            <asp:Panel ID="Panel1" runat="server" BorderStyle="Groove" BorderWidth="2px" Height="50px"
                                                HorizontalAlign="Left" Width="125px">
                                                <asp:CheckBox ID="Check_diario" runat="server" AutoPostBack="True"
                                                    Text="Diário" CssClass="estlabel" /><br />
                                                <asp:CheckBox ID="Check_chamada" runat="server" AutoPostBack="True"
                                                    Text="Chamada" CssClass="estlabel" /></asp:Panel>
                                        </td>
                                    </tr>
                                </table>
                                <table border="0" width="100%">
                                    <tr>
                                        <td colspan="1" style="height: 21px">
                                            <asp:Label ID="Label81" runat="server" Text="Data:" Visible="False" CssClass="estlabel"></asp:Label><br />
                                            <asp:TextBox ID="di_txtcoddisciplina" runat="server" Width="64px" Visible="False" CssClass="estTextboxRO"></asp:TextBox>
                                            <asp:TextBox ID="di_txtmod" runat="server" Visible="False" Width="72px" CssClass="estTextboxRO"></asp:TextBox><br />
                                            <asp:TextBox ID="hi_txthorapra" runat="server" Visible="False" Width="64px" CssClass="estTextboxRO"></asp:TextBox>
                                            <asp:TextBox ID="hi_txtorate" runat="server" Visible="False" Width="72px" CssClass="estTextboxRO"></asp:TextBox></td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td bgcolor="#99ccff" colspan="3" style="width: 100%; height: 39px">
                                <table border="0" width="100%">
                                    <tr>
                                        <td colspan="1" style="height: 21px" align="right">
                                            <asp:ImageButton ID="ImageButton23" runat="server" ImageUrl="~/imagens/Cancelar_.gif" /><asp:ImageButton ID="ImageButton25" runat="server" ImageUrl="~/imagens/Consultar_.gif" ToolTip="Listar diário" /></td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td bgcolor="#99ccff" colspan="3" style="width: 100%; height: 34px">
                            </td>
                        </tr>
                    </table>
                </asp:View><asp:View ID="View_historico" runat="server">
                    <table border="0" align="center" width="100">
                        <tr>
                            <td colspan="3" style="width: 290%; height: 36px;" bgcolor="#99ccff">
                                &nbsp;<asp:ImageButton ID="ImageButton28" runat="server" ImageUrl="~/imagens/Novo_.gif" ToolTip="Novo histórico" />
                                <asp:ImageButton ID="h_btnsalvar" runat="server" ImageUrl="~/imagens/Salvar_.gif" Enabled="False" ToolTip="Salvar" />
                                <asp:ImageButton ID="h_btncancelar" runat="server" ImageUrl="~/imagens/Cancelar_.gif" Enabled="False" ToolTip="Cancelar" />
                                <asp:ImageButton ID="ImageButton32" runat="server" ImageUrl="~/imagens/Consultar_.gif" ToolTip="Consultar" />
                                <asp:ImageButton ID="ImageButton33" runat="server" ImageUrl="~/imagens/Imprimir_.gif" ToolTip="Imprimir" />
                            </td>
                        </tr>
                        <tr>
                            <td bgcolor="#99ccff" colspan="3" style="font-weight: bold; text-transform: uppercase;
                            width: 290%; border-top-style: none; border-right-style: none; border-left-style: none;
                            height: 36px; text-align: center; border-bottom-style: none">
                                <span style="font-size: 16pt; font-family: Arial"><strong><em style="color: white">HISTÓRICO
                                    ESCOLAR<asp:TextBox ID="h_txtcod" runat="server" BorderStyle="Groove" Visible="False"
                                        Width="33px"></asp:TextBox></em></strong></span></td>
                        </tr>
                        <tr>
                            <td bgcolor="#99ccff" colspan="3" style="width: 290%; height: 36px;">
                                <table border="0" width="100%">
                                    <tr>
                                        <td colspan="2" style="width: 30%; height: 40px">
                                            <asp:Label ID="Label52" runat="server" Text="Aluno: *" CssClass="estlabel"></asp:Label><br />
                                            <asp:DropDownList ID="h_dropaluno" runat="server" BackColor="#FFFFC0" DataTextField="alu_nome"
                                                DataValueField="alu_codigo" Enabled="False" Width="344px" ForeColor="Blue" CssClass="estTextbox">
                                            </asp:DropDownList></td>
                                        <td colspan="5" style="height: 40px; width: 31%;">
                                            <asp:Label ID="Label53" runat="server" Text="Professor:" CssClass="estlabel"></asp:Label><br />
                                            <asp:DropDownList ID="h_dropprofessor" runat="server" BackColor="#FFFFC0" Enabled="False"
                                                Width="328px" DataTextField="prof_nome" DataValueField="prof_codigo" ForeColor="Blue" AutoPostBack="True" CssClass="estTextbox">
                                            </asp:DropDownList></td>
                                    </tr>
                                </table>
                                <table border="0" width="100%">
                                    <tr>
                                        <td colspan="5" style="width: 62%; height: 10px">
                                            <asp:Label ID="Label58" runat="server" Text="Disciplina:" CssClass="estlabel"></asp:Label>
                                            <asp:DropDownList ID="drop_trabDrop" runat="server" BackColor="#FFFFC0" DataTextField="dc_disciplina"
                                                DataValueField="dc_codigo" Enabled="False" Width="320px" ForeColor="Blue" CssClass="estTextbox">
                                            </asp:DropDownList></td>
                                        <td colspan="1" style="width: 6%; height: 10px">
                                            <asp:Label ID="Label63" runat="server" Text="CH:" CssClass="estlabel"></asp:Label><br />
                                            <asp:TextBox ID="h_txthora" runat="server" BorderStyle="Groove" Enabled="False" Width="40px" ForeColor="Blue" CssClass="estTextboxRO"></asp:TextBox></td>
                                        <td colspan="1" style="width: 7%; height: 10px">
                                            <asp:Label ID="Label66" runat="server" Text="Faltas:" CssClass="estlabel"></asp:Label><br />
                                            <asp:TextBox ID="h_faltas" runat="server" BorderStyle="Groove" Enabled="False" Width="40px" ForeColor="Blue" CssClass="estTextboxRO"></asp:TextBox></td>
                                        <td colspan="1" style="height: 10px; width: 6%;">
                                            <asp:Label ID="Label74" runat="server" Text="Freq.:" CssClass="estlabel"></asp:Label><br />
                                            <asp:TextBox ID="h_txtfrequencia" runat="server" BorderStyle="Groove" Enabled="False"
                                                Width="40px" ForeColor="Blue" CssClass="estTextboxRO"></asp:TextBox></td>
                                        <td colspan="1" style="width: 6%; height: 10px">
                                            <asp:Label ID="Label82" runat="server" Text="NP1:" CssClass="estlabel"></asp:Label><br />
                                            <asp:TextBox ID="h_txtnotas" runat="server" BorderStyle="Groove" Enabled="False"
                                                Width="40px" ForeColor="Blue" CssClass="estTextboxRO"></asp:TextBox></td>
                                        <td colspan="1" style="width: 6%; height: 10px">
                                            <asp:Label ID="Label86" runat="server" Text="NP2:" CssClass="estlabel"></asp:Label><br />
                                            <asp:TextBox ID="h_txtnota2" runat="server" BorderStyle="Groove" Enabled="False"
                                                Width="40px" ForeColor="Blue" CssClass="estTextboxRO"></asp:TextBox></td>
                                        <td colspan="1" style="width: 1%; height: 10px">
                                            <asp:Label ID="Label88" runat="server" Text="NP3:" CssClass="estlabel"></asp:Label><br />
                                            <asp:TextBox ID="h_txtnota3" runat="server" BorderStyle="Groove" Enabled="False"
                                                Width="40px" ForeColor="Blue" CssClass="estTextboxRO"></asp:TextBox></td>
                                        <td colspan="1" style="width: 65px; height: 10px">
                                            <asp:Label ID="Label89" runat="server" Text="Média:" CssClass="estlabel"></asp:Label><br />
                                            <asp:TextBox ID="h_txtmedia" runat="server" BorderStyle="Groove" Enabled="False"
                                                Width="40px" ForeColor="Blue" CssClass="estTextboxRO"></asp:TextBox></td>
                                    </tr>
                                </table>
                                <asp:DataGrid ID="DataGrid_historico" runat="server" AutoGenerateColumns="False" CellPadding="4"
                                ForeColor="#333333" GridLines="None" Width="100%" AllowPaging="True">
                                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                    <EditItemStyle BackColor="#2461BF" />
                                    <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" CssClass="estPagerGrid" Mode="NumericPages" />
                                    <AlternatingItemStyle BackColor="White" />
                                    <ItemStyle BackColor="#EFF3FB" Font-Size="Smaller" />
                                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                    <Columns>
                                        <asp:BoundColumn HeaderText="C&#243;digo" Visible="False" DataField="his_codigo"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="dc_disciplina" HeaderText="Disciplina">
                                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                Font-Underline="False" HorizontalAlign="Center" Width="60%" />
                                        </asp:BoundColumn>
                                        <asp:BoundColumn DataField="prof_nome" HeaderText="Professor">
                                            <FooterStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                Font-Underline="False" HorizontalAlign="Center" />
                                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                Font-Underline="False" Width="50%" />
                                        </asp:BoundColumn>
                                        <asp:BoundColumn DataField="prof_titulacao" HeaderText="Titula&#231;&#227;o">
                                            <HeaderStyle Width="30%" />
                                        </asp:BoundColumn>
                                        <asp:BoundColumn DataField="his_cargahora" HeaderText="CH">
                                            <FooterStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                Font-Underline="False" HorizontalAlign="Center" />
                                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                Font-Underline="False" HorizontalAlign="Center" />
                                        </asp:BoundColumn>
                                        <asp:BoundColumn DataField="his_faltas" HeaderText="Faltas">
                                            <ItemStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                            Font-Underline="False" HorizontalAlign="Center" />
                                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                            Font-Underline="False" HorizontalAlign="Center" />
                                        </asp:BoundColumn>
                                        <asp:BoundColumn DataField="his_frequencia" HeaderText="Freq&#252;encia">
                                            <ItemStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                            Font-Underline="False" HorizontalAlign="Center" />
                                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                            Font-Underline="False" HorizontalAlign="Center" />
                                        </asp:BoundColumn>
                                        <asp:BoundColumn DataField="his_media" HeaderText="M&#233;dia" DataFormatString="{0:N2}">
                                            <ItemStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                            Font-Underline="False" HorizontalAlign="Center" />
                                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                            Font-Underline="False" HorizontalAlign="Center" />
                                        </asp:BoundColumn>
                                        <asp:ButtonColumn CommandName="delete" HeaderText="Excluir" Text="&lt;img src=&quot;../Imagens/e_excluir.png&quot; border=&quot;0&quot;&gt;">
                                            <ItemStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                            Font-Underline="False" HorizontalAlign="Center" />
                                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                            Font-Underline="False" HorizontalAlign="Center" Width="10%" />
                                        </asp:ButtonColumn>
                                        <asp:ButtonColumn CommandName="Edite" HeaderText="Editar" Text="&lt;img src=&quot;../Imagens/e_editar.png&quot; border=&quot;0&quot;&gt;">
                                            <ItemStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                            Font-Underline="False" HorizontalAlign="Center" />
                                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                            Font-Underline="False" HorizontalAlign="Center" Width="10%" />
                                        </asp:ButtonColumn>
                                    </Columns>
                                </asp:DataGrid></td>
                        </tr>
                    </table>
                </asp:View>
                &nbsp;
                &nbsp;&nbsp;
                <asp:View ID="View_imp_historico" runat="server">
                    <table border="0" width="100" align="center">
                        <tr>
                            <td bgcolor="#99ccff" colspan="3" style="font-weight: bold; font-size: 15pt; text-transform: uppercase;
                            width: 100%; color: white; height: 36px; text-align: center">
                                <span style="font-family: Arial"><em>imprimir histórico</em></span></td>
                        </tr>
                        <tr>
                            <td bgcolor="#99ccff" colspan="3" style="width: 100%; height: 36px">
                                <table border="0" width="100%">
                                    <tr>
                                        <td colspan="1" style="height: 21px">
                                            <asp:Label ID="Label73" runat="server" Text="Informe o Nome do Aluno:" CssClass="estlabel"></asp:Label><br />
                                            <asp:DropDownList ID="Hit_dropaluno" runat="server" Width="545px" BackColor="#FFFFC0" DataTextField="alu_nome" DataValueField="alu_codigo" AutoPostBack="True" ForeColor="Blue" CssClass="estTextbox">
                                            </asp:DropDownList></td>
                                    </tr>
                                </table>
                                <table border="0" width="100%">
                                    <tr>
                                        <td colspan="1" style="height: 21px; width: 551px;">
                                            <asp:Label ID="Label84" runat="server" Text="Informe o Nome do Curso:" CssClass="estlabel"></asp:Label><br />
                                            <asp:DropDownList ID="hit_drocurso" runat="server" Width="545px" BackColor="#FFFFC0" DataTextField="cur_curso" DataValueField="cur_codigo" AutoPostBack="True" ForeColor="Blue" CssClass="estTextbox">
                                            </asp:DropDownList></td>
                                    </tr>
                                </table>
                                <table border="0" width="100%">
                                    <tr>
                                        <td colspan="1" style="height: 21px">
                                            <asp:Label ID="Label91" runat="server" Text="Informe o Nome da Instituição:" CssClass="estlabel"></asp:Label><br />
                                            <asp:TextBox ID="hit_txtinstituicao" runat="server" BorderStyle="Groove" ForeColor="Blue"
                                                Width="536px" CssClass="estTextboxRO">Instituto Centro de Ensino Tecnol&#243;gico - CENTEC</asp:TextBox></td>
                                    </tr>
                                </table>
                                <table border="0" width="100%">
                                    <tr>
                                        <td colspan="1" style="height: 21px; width: 121px;">
                                            <asp:Label ID="Label92" runat="server" Text="Início do Curso:" CssClass="estlabel"></asp:Label><br />
                                            <asp:TextBox ID="hit_txtinicio" runat="server" BorderStyle="Groove" ForeColor="Blue"
                                                Width="113px" CssClass="estTextboxRO" AutoPostBack="True"></asp:TextBox></td>
                                        <td colspan="1" style="width: 420px; height: 21px">
                                            <asp:Label ID="Label93" runat="server" Text="Término do Curso:" CssClass="estlabel"></asp:Label><br />
                                            <asp:TextBox ID="hit_txttermino" runat="server" BorderStyle="Groove" ForeColor="Blue"
                                                Width="114px" CssClass="estTextboxRO" AutoPostBack="True"></asp:TextBox></td>
                                    </tr>
                                </table>
                                <table border="0" width="100%">
                                    <tr>
                                        <td colspan="1" style="height: 21px">
                                            <asp:Label ID="Label94" runat="server" Text="Observação:" CssClass="estlabel"></asp:Label><br />
                                            <asp:TextBox ID="hit_txtobs" runat="server" BorderStyle="Groove" ForeColor="Blue"
                                                Width="534px" CssClass="estTextboxRO"></asp:TextBox>&nbsp;<br />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td bgcolor="#99ccff" colspan="3" style="width: 100%; height: 39px">
                                <table border="0" width="100%">
                                    <tr>
                                        <td colspan="1" style="height: 21px" align="right">
                                            <asp:Button ID="Button1" runat="server" Text="Button" />
                                            <asp:ImageButton ID="ImageButton21" runat="server" ImageUrl="~/imagens/Cancelar_.gif" /><asp:ImageButton ID="ImageButton24" runat="server" ImageUrl="~/imagens/Consultar_.gif" ToolTip="Listar diário" /></td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td bgcolor="#99ccff" colspan="3" style="width: 100%; height: 34px">
                            </td>
                        </tr>
                    </table>
                </asp:View>
               
        <asp:View ID="View_prof_curso" runat="server">
                    <table border="0" width="100" align="center" id="TABLE1">
                        <tr>
                            <td colspan="3" style="width: 110%; height: 25px" bgcolor="#99ccff">
                                &nbsp;<asp:ImageButton ID="ImageButton34" runat="server" ImageUrl="~/imagens/Novo_.gif" ToolTip="Novo curso/professor" />
                                <asp:ImageButton ID="aspc_btnsalvar" runat="server" ImageUrl="~/imagens/Salvar_.gif" Enabled="False" ToolTip="Salvar" />
                                <asp:ImageButton ID="aspc_btncancela" runat="server" ImageUrl="~/imagens/Cancelar_.gif" Enabled="False" ToolTip="Cancelar" />
                                <asp:ImageButton ID="ImageButton37" runat="server" ImageUrl="~/imagens/Consultar_.gif" ToolTip="Consultar" />
                                <asp:TextBox ID="aspc_txtcod" runat="server" BorderStyle="Groove" Visible="False" Width="24px"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td bgcolor="#99ccff" colspan="3" style="font-weight: bold; font-size: 15pt; text-transform: uppercase;
                            width: 110%; color: white; height: 36px; text-align: center">
                                <span style="font-family: Arial"><em>associar professor ao curso</em></span></td>
                        </tr>
                        <tr>
                            <td bgcolor="#99ccff" colspan="3" style="width: 110%; height: 36px">
                                <table border="0" width="100%">
                                    <tr>
                                        <td colspan="4" style="height: 25px; width: 4px;">
                                            <asp:Label ID="Label83" runat="server" Text="Curso*:" CssClass="estlabel" Height="8px"></asp:Label><asp:DropDownList ID="aspc_curso" runat="server" Width="320px" Enabled="False" BackColor="#FFFFC0" DataTextField="cur_curso" DataValueField="cur_codigo" ForeColor="Blue" CssClass="estTextbox">
                                            </asp:DropDownList></td>
                                        <td colspan="1" style="width: 167px; height: 25px">
                                            <asp:Label ID="Label70" runat="server" Text="Disciplina:" CssClass="estlabel"></asp:Label><br />
                                            <asp:DropDownList ID="aspc_dropdisciplina" runat="server" BackColor="#FFFFC0" Width="352px" DataTextField="dc_disciplina" DataValueField="dc_codigo" Enabled="False" ForeColor="Blue" CssClass="estTextbox">
                                            </asp:DropDownList></td>
                                    </tr>
                                </table>
                                <table border="0" width="100%">
                                    <tr>
                                        <td colspan="6" style="height: 21px; width: 201px;">
                                            <asp:Label ID="Label87" runat="server" Text="Professor:" CssClass="estlabel"></asp:Label><br />
                                            <asp:DropDownList ID="aspc_professor" runat="server" Width="320px" Enabled="False" BackColor="#FFFFC0" DataTextField="prof_nome" DataValueField="prof_codigo" ForeColor="Blue" CssClass="estTextbox">
                                            </asp:DropDownList></td>
                                        <td colspan="1" style="width: 400px; height: 21px">
                                            </td>
                                    </tr>
                                </table>
                                </td>
                        </tr>
                        <tr>
                            <td bgcolor="#99ccff" colspan="3" style="width: 110%; height: 34px">
                                <asp:DataGrid ID="DataGrid_prof_curso" runat="server" AutoGenerateColumns="False"
                                    CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%" AllowPaging="True">
                                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                    <EditItemStyle BackColor="#2461BF" />
                                    <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                    <PagerStyle BackColor="#2461BF" CssClass="estPagerGrid" ForeColor="White" HorizontalAlign="Center"
                                        Mode="NumericPages" />
                                    <AlternatingItemStyle BackColor="White" />
                                    <ItemStyle BackColor="#EFF3FB" />
                                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                    <Columns>
                                        <asp:BoundColumn DataField="pc_codigo" HeaderText="C&#243;digo" Visible="False"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="prof_nome" HeaderText="Professor"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="cur_curso" HeaderText="curso"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="dc_disciplina" HeaderText="Disciplina"></asp:BoundColumn>
                                        <asp:ButtonColumn CommandName="delete" HeaderText="Excluir" Text="&lt;img src=&quot;../Imagens/e_excluir.png&quot; border=&quot;0&quot;&gt;">
                                            <ItemStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                Font-Underline="False" HorizontalAlign="Center" />
                                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                Font-Underline="False" HorizontalAlign="Center" Width="5px" />
                                        </asp:ButtonColumn>
                                        <asp:ButtonColumn CommandName="edit" HeaderText="Editar" Text="&lt;img src=&quot;../Imagens/e_editar.png&quot; border=&quot;0&quot;&gt;">
                                            <ItemStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                Font-Underline="False" HorizontalAlign="Center" />
                                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                Font-Underline="False" HorizontalAlign="Center" Width="5px" />
                                        </asp:ButtonColumn>
                                    </Columns>
                                </asp:DataGrid></td>
                        </tr>
                    </table>
                </asp:View>
          </asp:MultiView>
        </AJAX:AjaxPanel>
     <br />     
             <asp:Label ID="rodape" runat="server" CssClass="base" ForeColor="White" Text=" © 2006 Instituto Centro de Ensino Tecnológico - CENTEC. Todos os direitos reservados. "></asp:Label></div>         
 </form>
</body>
</html>
