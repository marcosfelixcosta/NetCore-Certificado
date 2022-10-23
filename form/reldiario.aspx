<%@ Page Language="VB" AutoEventWireup="false" CodeFile="reldiario.aspx.vb" Inherits="frequencia"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>.: Controle de Freqüência :.</title>
     <LINK  href="../EstiloReport.css" type="text/css" rel="stylesheet">
   </head>
<body>
    <form id="form1" runat="server">
    <div>
        <table align="center" border="0" style="height: 101px" width="100%">
            <tr>
                <td colspan="3" style="width: 27%; height: 16px">
                    <asp:Image ID="Image1" runat="server" Height="76px" ImageUrl="~/imagens/Centec.png"
                        Width="123px" /></td>
                <td align="right" colspan="1" style="height: 16px">
                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="CONTROLE DE FREQÜÊNCIA" CssClass="estTexto14N" EnableTheming="True" Font-Size="Large"></asp:Label>
                    <br />
                    <asp:Label ID="Label2" runat="server" Text="Instituto Centro de Ensino Tecnologico - CENTEC" Font-Bold="True"></asp:Label></td>
            </tr>
        </table>
        
        </div>
        <table style="height: 51px; border-right: black 1px ridge; border-top: black 1px ridge; border-left: black 1px ridge; border-bottom: black 1px ridge;" width="100%">
            <tr>
                <td colspan="3" style="width: 39%; border-right: black 1px ridge; height: 45px;">
                    <asp:Label ID="Label3" runat="server" Font-Bold="True" Text="Nome do Curso:"></asp:Label><br />
                    <asp:Label ID="lbcurso" runat="server"></asp:Label></td>
                <td colspan="1" style="width: 232px; border-right: black 1px ridge; height: 45px;" align="left">
                    <asp:Label ID="Label4" runat="server" Text="Disciplina:" Font-Bold="True"></asp:Label><br />
                    <asp:Label ID="lbdisciplina" runat="server"></asp:Label></td>
                <td colspan="1" style="width: 130px; border-right: black 1px ridge; height: 45px;" align="center">
                    <asp:Label ID="Label6" runat="server" Text="Carga Horário" Font-Bold="True"></asp:Label><br />
                    <asp:Label ID="lbch" runat="server"></asp:Label></td>
                <td colspan="1">
                    <asp:Label ID="Label8" runat="server" Text="Professor:" Font-Bold="True"></asp:Label><br />
                    <asp:Label ID="lbprofessor" runat="server"></asp:Label></td>
            </tr>
        </table>
        <table border="0" style="border-right: black 1px ridge; border-top: black 1px ridge; border-left: black 1px ridge; border-bottom: black 1px ridge;" width="100%">
            <tr>
                <td colspan="5" style="width: 65%; height: 10px;">
                    &nbsp;
                    <asp:Label ID="Label5" runat="server" Font-Bold="True" Text="Matrícula: " Width="126px"></asp:Label>
                    <asp:Label ID="Label7" runat="server" Font-Bold="True" Text="Nome do Aluno:" Width="104px"></asp:Label></td>
                <td colspan="1" style="width: 327px; height: 10px;">
                    <asp:Label ID="Label13" runat="server" Font-Bold="True" Text="MÊS:"></asp:Label>
                    <asp:Label ID="lbmes" runat="server"></asp:Label></td>
            </tr>
        </table>
        <table width="100%">
            <tr>
                <td colspan="3" style="height: 74px">
                    <asp:DataGrid ID="DataGrid_diario" runat="server" AutoGenerateColumns="False" Height="51px"
                        Width="100%" AllowSorting="True" ShowHeader="False" CssClass="estGrid">
                        <Columns>
                            <asp:BoundColumn DataField="alu_identificado" HeaderText="Matr&#237;cula">
                                <HeaderStyle Width="10%" />
                            </asp:BoundColumn>
                            <asp:BoundColumn DataField="alu_nome">
                                <HeaderStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                    Font-Underline="False" Wrap="False" Width="80%" />
                            </asp:BoundColumn>
                            <asp:ButtonColumn Text="&lt;img src=&quot;../Imagens/linfd.GIF&quot; border=&quot;0&quot;&gt;">
                                <HeaderStyle Width="10%" />
                            </asp:ButtonColumn>
                        </Columns>
                    </asp:DataGrid>
                    <asp:Label ID="lbimpresso" runat="server" Font-Size="X-Small"></asp:Label></td>
            </tr>
        </table>
        &nbsp;
    </form>
</body>
</html>
