'Analista: Marcos Felix
'Data: 24/07/2004



Imports Microsoft.VisualBasic
Imports System.Data.SqlClient

Public Class classFuncao
    'Private vlconexao As String
    ' Cria uma funcao compartilhada
    ' nao precisa criar uma instancia do objeto
    ' apenas importar e chamar a funcao
    Public Shared Function GeraCodigoaluno() As Integer
        ' Criacao das variaveis
        Dim lCx As SqlConnection
        Dim lCm As SqlCommand
        Dim lDa As SqlDataAdapter
        Dim lDs As Data.DataSet
        Dim Sql As New System.Text.StringBuilder
        Sql.Append("SELECT ISNULL(MAX(ALU_CODIGO), 0) + 1 AS CODIGO ")
        Sql.Append("FROM TB_ALUNO ")
        Try
            ' Criacao dos objetos
            lCx = New SqlConnection
            lCm = New SqlCommand
            lDa = New SqlDataAdapter
            lDs = New Data.DataSet

            'Atribui as propriedades dos objetos

            'Recupera a string de conexao do web.config
1:          'lCx.ConnectionString = "server=marcos\marcos;database=c_certificado;Trusted_Connection=Yes"
            lCx.ConnectionString = ConfigurationSettings.AppSettings("cStrConexao")
            ' Associa uma conexao a um command
            lCm.Connection = lCx
            ' Associa um comando SQL a propriedade commandtext
            lCm.CommandText = Sql.ToString
            ' Associa um command a propriedade selectcommand do dataadapter
            lDa.SelectCommand = lCm
            ' Povoa um dataset atraves do metodo fill
            lDa.Fill(lDs)
            ' Retorna o valor para o resultado da funcao
            Return lDs.Tables(0).Rows(0)("CODIGO")
        Catch ex As Exception
            Return -1
        Finally
            lCx = Nothing
            lCm = Nothing
            lDs = Nothing
            lDa = Nothing
        End Try
    End Function

    Public Shared Function GeraCodigohistorico() As Integer
        ' Criacao das variaveis
        Dim lCx As SqlConnection
        Dim lCm As SqlCommand
        Dim lDa As SqlDataAdapter
        Dim lDs As Data.DataSet
        Dim Sql As New System.Text.StringBuilder

        Sql.Append("SELECT ISNULL(MAX(HIS_CODIGO), 0) + 1 AS CODIGO ")
        Sql.Append("FROM TB_HISTORICO ")
        Try
            ' Criacao dos objetos
            lCx = New SqlConnection
            lCm = New SqlCommand
            lDa = New SqlDataAdapter
            lDs = New Data.DataSet

            ' Atribui as propriedades dos objetos

            ' Recupera a string de conexao do web.config
1:          'lCx.ConnectionString = "server=marcos\marcos;database=c_certificado;Trusted_Connection=Yes"
            lCx.ConnectionString = ConfigurationSettings.AppSettings("cStrConexao")
            ' Associa uma conexao a um command
            lCm.Connection = lCx
            ' Associa um comando SQL a propriedade commandtext
            lCm.CommandText = Sql.ToString
            ' Associa um command a propriedade selectcommand do dataadapter
            lDa.SelectCommand = lCm
            ' Povoa um dataset atraves do metodo fill
            lDa.Fill(lDs)
            ' Retorna o valor para o resultado da funcao
            Return lDs.Tables(0).Rows(0)("CODIGO")
        Catch ex As Exception
            Return -1
        Finally
            lCx = Nothing
            lCm = Nothing
            lDs = Nothing
            lDa = Nothing
        End Try
    End Function

    Public Shared Function GeraCodigodiciplina_professor() As Integer
        ' Criacao das variaveis
        Dim lCx As SqlConnection
        Dim lCm As SqlCommand
        Dim lDa As SqlDataAdapter
        Dim lDs As Data.DataSet
        Dim Sql As New System.Text.StringBuilder

        Sql.Append("SELECT ISNULL(MAX(PD_CODIGO), 0) + 1 AS CODIGO ")
        Sql.Append("FROM TB_PROF_DISCIPLINA ")
        Try
            ' Criacao dos objetos
            lCx = New SqlConnection
            lCm = New SqlCommand
            lDa = New SqlDataAdapter
            lDs = New Data.DataSet

            ' Atribui as propriedades dos objetos

            ' Recupera a string de conexao do web.config
1:          'lCx.ConnectionString = "server=marcos\marcos;database=c_certificado;Trusted_Connection=Yes"
            lCx.ConnectionString = ConfigurationSettings.AppSettings("cStrConexao")
            ' Associa uma conexao a um command
            lCm.Connection = lCx
            ' Associa um comando SQL a propriedade commandtext
            lCm.CommandText = Sql.ToString
            ' Associa um command a propriedade selectcommand do dataadapter
            lDa.SelectCommand = lCm
            ' Povoa um dataset atraves do metodo fill
            lDa.Fill(lDs)
            ' Retorna o valor para o resultado da funcao
            Return lDs.Tables(0).Rows(0)("CODIGO")
        Catch ex As Exception
            Return -1
        Finally
            lCx = Nothing
            lCm = Nothing
            lDs = Nothing
            lDa = Nothing
        End Try
    End Function

    Public Shared Function GeraCodigoprof_curso() As Integer
        ' Criacao das variaveis
        Dim lCx As SqlConnection
        Dim lCm As SqlCommand
        Dim lDa As SqlDataAdapter
        Dim lDs As Data.DataSet
        Dim Sql As New System.Text.StringBuilder

        Sql.Append("SELECT ISNULL(MAX(PC_CODIGO), 0) + 1 AS CODIGO ")
        Sql.Append("FROM TB_PROF_CURSO ")
        Try
            ' Criacao dos objetos
            lCx = New SqlConnection
            lCm = New SqlCommand
            lDa = New SqlDataAdapter
            lDs = New Data.DataSet

            ' Atribui as propriedades dos objetos

            ' Recupera a string de conexao do web.config
1:          'lCx.ConnectionString = "server=marcos\marcos;database=c_certificado;Trusted_Connection=Yes"
            lCx.ConnectionString = ConfigurationSettings.AppSettings("cStrConexao")
            ' Associa uma conexao a um command
            lCm.Connection = lCx
            ' Associa um comando SQL a propriedade commandtext
            lCm.CommandText = Sql.ToString
            ' Associa um command a propriedade selectcommand do dataadapter
            lDa.SelectCommand = lCm
            ' Povoa um dataset atraves do metodo fill
            lDa.Fill(lDs)
            ' Retorna o valor para o resultado da funcao
            Return lDs.Tables(0).Rows(0)("CODIGO")
        Catch ex As Exception
            Return -1
        Finally
            lCx = Nothing
            lCm = Nothing
            lDs = Nothing
            lDa = Nothing
        End Try
    End Function

    Public Shared Function GeraCodigoprofessor() As Integer
        ' Criacao das variaveis
        Dim lCx As SqlConnection
        Dim lCm As SqlCommand
        Dim lDa As SqlDataAdapter
        Dim lDs As Data.DataSet
        Dim Sql As New System.Text.StringBuilder

        Sql.Append("SELECT ISNULL(MAX(PROF_CODIGO), 0) + 1 AS CODIGO ")
        Sql.Append("FROM TB_PROFESSORES ")
        Try
            ' Criacao dos objetos
            lCx = New SqlConnection
            lCm = New SqlCommand
            lDa = New SqlDataAdapter
            lDs = New Data.DataSet

            ' Atribui as propriedades dos objetos

            ' Recupera a string de conexao do web.config
            'lCx.ConnectionString = "server=marcos\marcos;database=c_certificado;Trusted_Connection=Yes"
            lCx.ConnectionString = ConfigurationSettings.AppSettings("cStrConexao")
            ' Associa uma conexao a um command
            lCm.Connection = lCx
            ' Associa um comando SQL a propriedade commandtext
            lCm.CommandText = Sql.ToString
            ' Associa um command a propriedade selectcommand do dataadapter
            lDa.SelectCommand = lCm
            ' Povoa um dataset atraves do metodo fill
            lDa.Fill(lDs)
            ' Retorna o valor para o resultado da funcao
            Return lDs.Tables(0).Rows(0)("CODIGO")
        Catch ex As Exception
            Return -1
        Finally
            lCx = Nothing
            lCm = Nothing
            lDs = Nothing
            lDa = Nothing
        End Try
    End Function

    Public Shared Function GeraCodigodisciplina() As Integer
        ' Criacao das variaveis
        Dim lCx As SqlConnection
        Dim lCm As SqlCommand
        Dim lDa As SqlDataAdapter
        Dim lDs As Data.DataSet
        Dim Sql As New System.Text.StringBuilder

        Sql.Append("SELECT ISNULL(MAX(DC_CODIGO), 0) + 1 AS CODIGO ")
        Sql.Append("FROM TB_DISCIPLINA")
        Try
            ' Criacao dos objetos
            lCx = New SqlConnection
            lCm = New SqlCommand
            lDa = New SqlDataAdapter
            lDs = New Data.DataSet

            ' Atribui as propriedades dos objetos

            ' Recupera a string de conexao do web.config
            'lCx.ConnectionString = "server=marcos\marcos;database=c_certificado;Trusted_Connection=Yes"
            lCx.ConnectionString = ConfigurationSettings.AppSettings("cStrConexao")
            ' Associa uma conexao a um command
            lCm.Connection = lCx
            ' Associa um comando SQL a propriedade commandtext
            lCm.CommandText = Sql.ToString
            ' Associa um command a propriedade selectcommand do dataadapter
            lDa.SelectCommand = lCm
            ' Povoa um dataset atraves do metodo fill
            lDa.Fill(lDs)
            ' Retorna o valor para o resultado da funcao
            Return lDs.Tables(0).Rows(0)("CODIGO")
        Catch ex As Exception
            Return -1
        Finally
            lCx = Nothing
            lCm = Nothing
            lDs = Nothing
            lDa = Nothing
        End Try
    End Function

    Public Shared Function GeraCodigocurso() As Integer
        ' Criacao das variaveis
        Dim lCx As SqlConnection
        Dim lCm As SqlCommand
        Dim lDa As SqlDataAdapter
        Dim lDs As Data.DataSet
        Dim Sql As New System.Text.StringBuilder

        Sql.Append("SELECT ISNULL(MAX(CUR_CODIGO), 0) + 1 AS CODIGO ")
        Sql.Append("FROM TB_CURSO")
        Try
            ' Criacao dos objetos
            lCx = New SqlConnection
            lCm = New SqlCommand
            lDa = New SqlDataAdapter
            lDs = New Data.DataSet

            ' Atribui as propriedades dos objetos

            ' Recupera a string de conexao do web.config
            'lCx.ConnectionString = "server=marcos\marcos;database=c_certificado;Trusted_Connection=Yes"
            lCx.ConnectionString = ConfigurationSettings.AppSettings("cStrConexao")
            ' Associa uma conexao a um command
            lCm.Connection = lCx
            ' Associa um comando SQL a propriedade commandtext
            lCm.CommandText = Sql.ToString
            ' Associa um command a propriedade selectcommand do dataadapter
            lDa.SelectCommand = lCm
            ' Povoa um dataset atraves do metodo fill
            lDa.Fill(lDs)
            ' Retorna o valor para o resultado da funcao
            Return lDs.Tables(0).Rows(0)("CODIGO")
        Catch ex As Exception
            Return -1
        Finally
            lCx = Nothing
            lCm = Nothing
            lDs = Nothing
            lDa = Nothing
        End Try
    End Function

    Public Shared Function Geracodigo_certFrente()
        ' Criacao das variaveis
        Dim lCx As SqlConnection
        Dim lCm As SqlCommand
        Dim lDa As SqlDataAdapter
        Dim lDs As Data.DataSet
        Dim Sql As New System.Text.StringBuilder

        Sql.Append("SELECT ISNULL(MAX(CER_CODIGO), 0) + 1 AS CODIGO ")
        Sql.Append("FROM TB_CERTIFICADO")
        Try
            ' Criacao dos objetos
            lCx = New SqlConnection
            lCm = New SqlCommand
            lDa = New SqlDataAdapter
            lDs = New Data.DataSet

            ' Atribui as propriedades dos objetos

            ' Recupera a string de conexao do web.config
            'lCx.ConnectionString = "server=marcos\marcos;database=c_certificado;Trusted_Connection=Yes"
            lCx.ConnectionString = ConfigurationSettings.AppSettings("cStrConexao")
            ' Associa uma conexao a um command
            lCm.Connection = lCx
            ' Associa um comando SQL a propriedade commandtext
            lCm.CommandText = Sql.ToString
            ' Associa um command a propriedade selectcommand do dataadapter
            lDa.SelectCommand = lCm
            ' Povoa um dataset atraves do metodo fill
            lDa.Fill(lDs)
            ' Retorna o valor para o resultado da funcao
            Return lDs.Tables(0).Rows(0)("CODIGO")
        Catch ex As Exception
            Return -1
        Finally
            lCx = Nothing
            lCm = Nothing
            lDs = Nothing
            lDa = Nothing
        End Try
    End Function

    Public Sub LimpaForm(ByVal pControles As System.Web.UI.ControlCollection)
        ' Declaração da variáveis
        Dim vlControle As System.Web.UI.Control

        ' Percorre todos os controles da coleção de controles informada
        For Each vlControle In pControles
            ' Teste para controle TextBox
            If vlControle.GetType Is GetType(WebControls.TextBox) Then
                CType(vlControle, WebControls.TextBox).Text = ""
            End If
            ' Teste para controle Dropdownlist
            If vlControle.GetType Is GetType(WebControls.DropDownList) Then
                CType(vlControle, WebControls.DropDownList).ClearSelection()
            End If
            ' Teste para controle Radiobuttonlist
            If vlControle.GetType Is GetType(WebControls.RadioButtonList) Then
                CType(vlControle, WebControls.RadioButtonList).ClearSelection()
            End If
            ' Teste para controle Checkboxlist
            If vlControle.GetType Is GetType(WebControls.CheckBoxList) Then
                CType(vlControle, WebControls.RadioButtonList).ClearSelection()
            End If
            ' Teste para controle Checkbox
            If vlControle.GetType Is GetType(WebControls.CheckBox) Then
                CType(vlControle, WebControls.CheckBox).Checked = True
            End If

            ' Chamada recursiva da função
            LimpaForm(vlControle.Controls)
        Next
    End Sub

    '********************************************************************
    ' Procedimento para habilitar/desabilitar os campos do formulário
    ' Implementação: HabilitaControles(True, Page.Controls) - habilita os 
    ' controles de edição
    '********************************************************************

    Public Sub HabilitaControles(ByVal pHabilita As Boolean, ByVal pControles As System.Web.UI.ControlCollection)
        ' Declaração da variáveis
        Dim vlControle As System.Web.UI.Control

        ' Percorre todos os controles da coleção de controles informada
        For Each vlControle In pControles
            ' Teste para controle TextBox
            If vlControle.GetType Is GetType(WebControls.TextBox) Then
                CType(vlControle, WebControls.TextBox).Enabled = pHabilita
            End If
            ' Teste para controle Dropdownlist
            If vlControle.GetType Is GetType(WebControls.DropDownList) Then
                CType(vlControle, WebControls.DropDownList).Enabled = pHabilita
            End If
            ' Teste para controle Radiobutton
            If vlControle.GetType Is GetType(WebControls.RadioButtonList) Then
                CType(vlControle, WebControls.RadioButtonList).Enabled = pHabilita
            End If
            ' Teste para controle Radiobuttonlist
            If vlControle.GetType Is GetType(WebControls.RadioButtonList) Then
                CType(vlControle, WebControls.RadioButtonList).Enabled = pHabilita
            End If
            ' Teste para controle Checkboxlist
            If vlControle.GetType Is GetType(WebControls.CheckBoxList) Then
                CType(vlControle, WebControls.RadioButtonList).Enabled = pHabilita
            End If
            ' Teste para controle Checkbox
            If vlControle.GetType Is GetType(WebControls.CheckBox) Then
                CType(vlControle, WebControls.CheckBox).Enabled = pHabilita
            End If

            ' Chamada recursiva da função
            HabilitaControles(pHabilita, vlControle.Controls)
        Next
    End Sub

    '********************************************************************
    ' Procedimento para mostrar um alerta javascript
    ' Implementação: Alerta("mensagem", page)
    '********************************************************************
    Public Sub Alerta(ByVal pMensagem As String, ByVal pPagina As Object)
        Dim strJavascript As New System.Text.StringBuilder
        Dim ltrMain As New LiteralControl
        strJavascript.Append("<script language='javascript'> ")
        strJavascript.Append("alert('" & pMensagem & "'); ")
        strJavascript.Append("</script>")
        ltrMain.Text = strJavascript.ToString
        pPagina.Controls.Add(ltrMain)
        ltrMain = Nothing
    End Sub

    '********************************************************************
    ' Procedimento para setar o focus em um controle informado
    ' Implementação: Focus("nomedoform.controle", Page)
    '********************************************************************
    Public Sub Focus(ByVal pControle As String, ByVal pPagina As Object)
        Dim strJavascript As New System.Text.StringBuilder
        Dim ltrMain As New LiteralControl
        strJavascript.Append("<script language='javascript'> ")
        strJavascript.Append(pControle & ".focus();")
        strJavascript.Append("</script>")
        ltrMain.Text = strJavascript.ToString
        pPagina.Controls.Add(ltrMain)
        ltrMain = Nothing
    End Sub

    '********************************************************************
    ' Procedimento para montar o relógio digital
    ' Implementação: Relogio(Page)
    '********************************************************************
    Public Function Relogio(ByVal pPagina As Object)
        Dim strJavascript As New System.Text.StringBuilder
        Dim ltrMain As New LiteralControl
        strJavascript.Append("<script language='javascript'> ")
        strJavascript.Append("function RelogioDigital() {")
        strJavascript.Append("var RELOGIO = new Date();")
        strJavascript.Append("var HORA = RELOGIO.getHours();")
        strJavascript.Append("var MINUTO = RELOGIO.getMinutes();")
        strJavascript.Append("var SEGUNDO = RELOGIO.getSeconds();")
        strJavascript.Append("if (HORA <= 9) {")
        strJavascript.Append("   HORA = '0' + HORA;")
        strJavascript.Append(" }")
        strJavascript.Append(" if (MINUTO <= 9) {")
        strJavascript.Append("   MINUTO = '0' + MINUTO;")
        strJavascript.Append(" }")
        strJavascript.Append("if (SEGUNDO <= 9) {")
        strJavascript.Append("  SEGUNDO = '0' + SEGUNDO;")
        strJavascript.Append("}")
        strJavascript.Append("var clocklocation = document.getElementById('RelogioDigital');")
        strJavascript.Append(" clocklocation.innerHTML = HORA + ':' + MINUTO + ':' + SEGUNDO;;")
        strJavascript.Append("}")
        strJavascript.Append("window.setInterval('RelogioDigital()', 1000);")
        strJavascript.Append("</script>")
        ltrMain.Text = strJavascript.ToString
        pPagina.Controls.Add(ltrMain)
        ltrMain = Nothing
        'pPagina.Contros.add("<SPAN id='RelogioDigital'></SPAN>")
    End Function

    '********************************************************************
    ' Procedimento para alterar a cor de um datagrid
    ' Implementação: CorGridMouseOver(e, "Cor1", "Cor2")
    '********************************************************************
    Public Sub CorGridMouseOver(ByVal pObjeto As Object, ByVal pCorOver As String, ByVal pCorOriginal As String)
        If pObjeto.Item.ItemType = ListItemType.Item Or pObjeto.Item.ItemType = ListItemType.AlternatingItem Then
            pObjeto.Item.Attributes.Add("onmouseover", "this.style.backgroundColor='" & pCorOver & "';")
            pObjeto.Item.Attributes.Add("onmouseout", "this.style.backgroundColor='" & pCorOriginal & "';")
        End If
    End Sub

    '********************************************************************
    ' Procedimento para abrir uma nova janela
    ' Implementação: Abrejanela("url", 0 ou 1, "", "", Page)
    '********************************************************************
    Public Sub AbreJanela(ByVal pUrl As String, ByVal pFull As String, ByVal pAltura As String, ByVal pLargura As String, ByVal pPagina As Object)
        Dim strJavascript As New System.Text.StringBuilder
        Dim ltrMain As New LiteralControl
        strJavascript.Append("<script language='javascript'> ")
        If Trim(pAltura) <> "" Then
            strJavascript.Append("var altura = " & pAltura & ";")
        Else
            strJavascript.Append("var altura = screen.availHeight;")
        End If
        If Trim(pLargura) <> "" Then
            strJavascript.Append("var largura = " & pLargura & ";")
        Else
            strJavascript.Append("var largura = screen.availWidth;")
        End If
        'strJavascript.Append("window.open('" & pUrl & "','" & Left(pUrl, 1) & "','fullscreen=" & pFull & ",titlebar=0,status=0,directories=0,menubar=0,location=0,resizable=0,width=' + largura + ',height=' + altura + ';');")
        strJavascript.Append("window.open('" & pUrl & "','" & Left(pUrl, 1) & "','fullscreen=" & pFull & ",scrollbars=1,titlebar=0,status=0,directories=0,menubar=0,location=0,resizable=0,width=' + largura + ',height=' + altura + ';');")
        strJavascript.Append("</script>")
        ltrMain.Text = strJavascript.ToString
        pPagina.Controls.Add(ltrMain)
        ltrMain = Nothing
    End Sub

    '********************************************************************
    ' Procedimento para abrir uma nova janela
    ' Implementação: Abrejanela("url", 0 ou 1, "", "", Page)
    '********************************************************************
    Public Sub AbreJanela(ByVal pUrl As String, ByVal pAltura As String, ByVal pLargura As String, ByVal pPagina As Object)
        Dim strJavascript As New System.Text.StringBuilder
        Dim ltrMain As New LiteralControl
        strJavascript.Append("<script language='javascript'> ")
        If Trim(pAltura) <> "" Then
            strJavascript.Append("var altura = " & pAltura & ";")
        Else
            strJavascript.Append("var altura = screen.availHeight;")
        End If
        If Trim(pLargura) <> "" Then
            strJavascript.Append("var largura = " & pLargura & ";")
        Else
            strJavascript.Append("var largura = screen.availWidth;")
        End If
        strJavascript.Append("window.open('" & pUrl & "','" & Left(pUrl, 1) & "','fullscreen=no,scrollbars=1,titlebar=0,status=0,directories=0,menubar=0,location=0,resizable=1;');")
        strJavascript.Append("</script>")
        ltrMain.Text = strJavascript.ToString
        pPagina.Controls.Add(ltrMain)
        ltrMain = Nothing
    End Sub

    '********************************************************************
    ' Procedimento para fechar uma nova janela
    ' Implementação: Fechajanela(Page, "_parent")
    '********************************************************************
    Public Sub FechaJanela(ByVal pPagina As Object)
        Dim strJavascript As New System.Text.StringBuilder
        Dim ltrMain As New LiteralControl
        strJavascript.Append("<script language='javascript'> ")
        strJavascript.Append("parent.close();")
        strJavascript.Append("</script>")
        ltrMain.Text = strJavascript.ToString
        pPagina.Controls.Add(ltrMain)
        ltrMain = Nothing
    End Sub

    Public Sub Imprimir(ByVal pPagina As Object)
        Dim strJavascript As New System.Text.StringBuilder
        Dim ltrMain As New LiteralControl
        strJavascript.Append("<script language='javascript'> ")
        strJavascript.Append("window.print();")
        strJavascript.Append("</script>")
        ltrMain.Text = strJavascript.ToString
        pPagina.Controls.Add(ltrMain)
        ltrMain = Nothing
    End Sub
End Class

