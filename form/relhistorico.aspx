<%@ Page Language="VB" AutoEventWireup="false" CodeFile="relhistorico.aspx.vb" Inherits="relhistorico" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>.: Histórico Escolar :.</title>
     <LINK href="../EstiloReport.css" type="text/css" rel="stylesheet">
   </head>
<body>
    <form id="form1" runat="server">
    <div>
        <table align="center" border="0" width="100%">
            <tr>
                <td colspan="3" style="width: 27%; height: 10px">
                    <asp:Image ID="Image1" runat="server" Height="70px" ImageUrl="~/imagens/Centec.png"
                        Width="113px" /></td>
                <td align="center" colspan="1" style="height: 10px; width: 469px;">
                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="HISTÓRICO ESCOLAR" CssClass="estTexto14N" EnableTheming="True" Font-Size="X-Large"></asp:Label>
                    <br />
                    </td>
                <td align="center" colspan="1" style="height: 10px">
                </td>
            </tr>
        </table>
    
    </div><table border="0" width="100%">
        <tr>
            <td colspan="6" style="height: 10px;" align="right">
                    <asp:Label ID="lblrealizacao" runat="server" Font-Bold="True" Width="539px" Font-Size="Medium"></asp:Label></td>
        </tr>
    </table>
        <table border="0" width="100%">
            <tr>
                <td style="height: 10px;" align="right" rowspan="">
                <asp:Label ID="lblcurso" runat="server" Font-Bold="True" Width="539px" Font-Size="Medium"></asp:Label>
                </td>
            </tr>
        </table>
        <table border="0" width="100%">
            <tr>
                <td colspan="6" style="height: 10px;" align="right">
                    <asp:Label ID="lblperiodo" runat="server" Font-Bold="True" Width="539px" Font-Size="Medium"></asp:Label></td>
            </tr>
        </table>
        <table border="0" width="100%">
            <tr>
                <td colspan="6" style="height: 10px;" align="left">
                    <asp:Label ID="lblaluno" runat="server" Font-Bold="True" Width="416px" Font-Size="Medium"></asp:Label>&nbsp;</td>
            </tr>
        </table>
        <table width="100%">
            <tr>
                <td colspan="3" style="height: 74px" align="left">
                    &nbsp;<asp:DataGrid ID="dtg1" runat="server" AutoGenerateColumns="False" CssClass="estGrid"
                        Width="100%">
                        <ItemStyle CssClass="estItemGrid" />
                        <HeaderStyle CssClass="estHeaderGrid" />
                        <Columns>
                            <asp:BoundColumn DataField="dc_disciplina" HeaderText="Disciplina">
                                <HeaderStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                    Font-Underline="False" HorizontalAlign="Center" Width="30%" />
                            </asp:BoundColumn>
                            <asp:BoundColumn HeaderText="C/Hora" DataField="his_cargahora">
                                <ItemStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                    Font-Underline="False" HorizontalAlign="Center" />
                                <HeaderStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                    Font-Underline="False" HorizontalAlign="Center" Width="5%" />
                            </asp:BoundColumn>
                            <asp:BoundColumn HeaderText="Freq&#252;&#234;ncia" DataField="his_frequencia">
                                <ItemStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                    Font-Underline="False" HorizontalAlign="Center" />
                                <HeaderStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                    Font-Underline="False" HorizontalAlign="Center" Width="5%" />
                            </asp:BoundColumn>
                            <asp:BoundColumn HeaderText="Falta" DataField="his_faltas">
                                <ItemStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                    Font-Underline="False" HorizontalAlign="Center" />
                                <HeaderStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                    Font-Underline="False" HorizontalAlign="Center" Width="5%" />
                            </asp:BoundColumn>
                            <asp:BoundColumn HeaderText="Nota" DataField="his_media">
                                <ItemStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                    Font-Underline="False" HorizontalAlign="Center" />
                                <HeaderStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                    Font-Underline="False" HorizontalAlign="Center" Width="5%" />
                            </asp:BoundColumn>
                            <asp:BoundColumn HeaderText="Professor" DataField="prof_nome">
                                <HeaderStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                    Font-Underline="False" HorizontalAlign="Center" Width="20%" />
                            </asp:BoundColumn>
                            <asp:BoundColumn HeaderText="Titula&#231;&#227;o" DataField="prof_titulacao">
                                <HeaderStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                    Font-Underline="False" HorizontalAlign="Center" Width="10%" />
                            </asp:BoundColumn>
                        </Columns>
                    </asp:DataGrid><asp:Label ID="lbimpresso" runat="server" Font-Size="X-Small"></asp:Label>&nbsp;
                    <br />
                    <asp:Label ID="lblobs" runat="server" Font-Size="X-Small"></asp:Label></td>
            </tr>
        </table>
        &nbsp;
    </form>
</body>
</html>
