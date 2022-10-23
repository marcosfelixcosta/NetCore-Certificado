<%@ Page Language="VB" AutoEventWireup="false" CodeFile="esperro.aspx.vb" Inherits="pau" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body background="imagens/bg.gif">
    <form id="form1" runat="server">
    <div>
        <table id="Table1" border="0" cellpadding="1" cellspacing="1" height="100%" width="100%">
            <tr>
                <td align="center">
                    &nbsp;<br />
                    <img src="imagens/loard3.gif" />&nbsp;<br />
                    &nbsp;<br />
                    <asp:TextBox ID="TextBox1" runat="server" BackColor="WhiteSmoke" BorderColor="White"
                        BorderStyle="Groove" Enabled="False" EnableTheming="True" Font-Size="Small" ForeColor="White"
                        Height="240px" ReadOnly="True" TextMode="MultiLine" Width="816px">
Lamentamos pelo inconveniente.

Voc&#234; esbarrou em um problema tempor&#225;rio que estamos tendo aqui na Sede. Geralmente este problema &#233; resolvido rapidamente, sem que voc&#234; precise fazer nada. Na verdade ele est&#225; sendo resolvido agora. 
&#183;Tente pressionar o bot&#227;o Recarregar ou Atualizar em seu navegador, ou tente sair e ent&#227;o entrar novamente em sua conta do Usu&#225;rio e Senha. Esperamos que isso resolva o problema. 
Se isso n&#227;o resolver o problema, tenha paci&#234;ncia enquanto cuidamos da quest&#227;o e tente novamente em breve. O fato de voc&#234; estar lendo esta p&#225;gina significa que fomos avisados automaticamente sobre esta quest&#227;o e h&#225; grandes chances de estarmos trabalhando nela agora. 
&#183;Se voc&#234; acha que j&#225; foi paciente o suficiente e j&#225; tentou todas as dicas acima, n&#227;o hesite em contatar o Suporte : marcos@centec.org.br ou ilano@centec.org.br. 
Obrigado, 

A Equipe de Desenvolvimento Centec.

</asp:TextBox><br />
                    <br />
                    <asp:Button ID="Button1" runat="server" BorderStyle="Groove" Height="32px" Text="OK"
                        Width="128px" BackColor="#E0E0E0" /></td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
