'Classe error
'Analista: Marcos Felix
'Data: 28/07/2004

Partial Class pau
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Session("usu_nome") = ""
        Response.Redirect("index.aspx")
    End Sub
End Class
