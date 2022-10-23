'Classe login
'Analista: Marcos Felix
'Data: 24/07/2004


Imports System.Data.SqlClient
Imports System.Web.Security
Partial Class index
    Inherits System.Web.UI.Page
    Protected fn As New classFuncao
    Protected Sub validarlogin()
        'Dim conn As New SqlConnection
        'Dim strQuery As String
        'Dim strRetorno As String
        'conn.ConnectionString = ConfigurationSettings.AppSettings("cStrConexao")
        'strQuery = "SELECT usu_nome FROM TB_USUARIO WHERE usu_nome = @Login AND usu_senha = @Senha"
        'Dim cmd As SqlCommand = New SqlCommand(strQuery, conn)

        'Dim Login As SqlParameter = New SqlParameter("@Login", SqlDbType.VarChar, 15)
        'Login.Value = Me.txtLogin.Text.Trim
        'cmd.Parameters.Add(Login)

        'Dim Senha As SqlParameter = New SqlParameter("@Senha", SqlDbType.VarChar, 10)
        'Senha.Value = Me.txtSenha.Text.Trim
        'cmd.Parameters.Add(Senha)

        'Try
        '    conn.Open()
        '    strRetorno = Convert.ToString(cmd.ExecuteScalar())
        '    conn.Close()
        'Catch ex As Exception
        '    Response.Write(ex.ToString)
        'Finally
        '    If Not strRetorno = String.Empty Then
        '        FormsAuthentication.RedirectFromLoginPage(Me.txtLogin.Text.Trim, _
        '        Me.chkLembrar.Checked)
        '    Else
        '        Fn.Alerta("Usuário ou senha invalido!", Page)
        '        'Me.lblMensagem.Visible = True
        '    End If
        'End Try


        '*************************CÓDIGO ANTIGO ***************************************
        Dim selec = "Select * from tb_usuario where usu_nome= @nome and usu_senha= @senha"
        Dim sqlcn As New SqlConnection
        Dim sqlcm As New SqlCommand
        Dim sqlda As New SqlDataAdapter
        Dim Ds As New Data.DataSet
        Session("Unidade") = ddlUnidade.SelectedValue
        sqlcn.ConnectionString = ConfigurationSettings.AppSettings("cStrConexao") & Session("Unidade")
        sqlcm.Connection = sqlcn
        sqlcm.CommandText = selec
        sqlcm.Parameters.Add("@nome", txtLogin.Text)
        sqlcm.Parameters.Add("@senha", txtSenha.Text)
        sqlda.SelectCommand = sqlcm
        sqlda.Fill(Ds)
        If Ds.Tables(0).Rows.Count <> 0 Then
            'FormsAuthentication.RedirectFromLoginPage(txtLogin.Text, False)
            FormsAuthentication.SetAuthCookie(Session("usu_nome"), True)
            Session("usu_nome") = Ds.Tables(0).Rows(0)("usu_nome")
            'FormsAuthentication.SetAuthCookie(Session("username"), False)
            'Session("username") = txtLogin.Text
            Response.Redirect("form/main.aspx")
        Else
            txtLogin.Text = ""
            txtSenha.Text = ""
            fn.Alerta("Usuário não encontrado, senha inválida ou usuário não tem acesso a aplicação!", Page)
            txtLogin.Focus()
            FormsAuthentication.SignOut()
        End If
    End Sub

    Protected Sub btnLimpar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLimpar.Click
        fn.LimpaForm(Page.Controls)
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            txtLogin.Focus()
            FormsAuthentication.SignOut()
            Session("usu_nome") = ""
            Session("usu_senha") = ""
        End If
    End Sub

    Protected Sub btnLogin_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        If ddlUnidade.SelectedItem.Text = "****  Selecione a Faculdade  ****" Then
            fn.Alerta("Selecione a Faculdade!", Page)
        Else
            validarlogin()
        End If
    End Sub
End Class
