'Analista: Marcos Felix
'Data: 15/08/2006

Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient

Public Class objdisciplina

    ' Declaracao das variaveis das instancias dos objetos
    Private Cx As SqlConnection
    Private Cm As SqlCommand
    Private Da As SqlDataAdapter
    Private Ds As DataSet

    ' Declaracao das variaveis de trabalho
    Private vlCodigo As Integer
    Private vlcoddisciplina As String
    Private vldisciplina As String
    Private vlchteorica As Integer
    Private vlchpratica As Integer
    Private vlcredito As Integer
    Private vlvigencia As String
    Private vlmodulo As Integer
    Private vlconexao As String
   
    'Private vlcurcodigo As Integer
   

    ' Declaracao das propriedades
    Property codigo()
        Get
            Return vlCodigo
        End Get
        Set(ByVal value)
            vlCodigo = value
        End Set
    End Property
    Property codigodisciplina()
        Get
            Return vlcoddisciplina
        End Get
        Set(ByVal value)
            vlcoddisciplina = value
        End Set
    End Property
    Property disciplina()
        Get
            Return vldisciplina
        End Get
        Set(ByVal value)
            vldisciplina = value
        End Set
    End Property
    Property horateorica()
        Get
            Return vlchteorica
        End Get
        Set(ByVal value)
            vlchteorica = value
        End Set
    End Property
    Property horapratica()
        Get
            Return vlchpratica
        End Get
        Set(ByVal value)
            vlchpratica = value
        End Set
    End Property
    Property creditos()
        Get
            Return vlcredito
        End Get
        Set(ByVal value)
            vlcredito = value
        End Set
    End Property
    Property vigencia()
        Get
            Return vlvigencia
        End Get
        Set(ByVal value)
            vlvigencia = value
        End Set
    End Property
    Property modulo()
        Get
            Return vlmodulo
        End Get
        Set(ByVal value)
            vlmodulo = value
        End Set
    End Property
    Property receberconexao()
        Get
            Return vlconexao
        End Get
        Set(ByVal value)
            vlconexao = value
        End Set
    End Property
    
    Public Function Inserir() As String
        Dim Sql As New System.Text.StringBuilder
        Sql.Append("INSERT INTO TB_DISCIPLINA")
        Sql.Append("(DC_CODIGO,DC_CODDISCIPLINA,DC_DISCIPLINA,DC_CHTEORICA,DC_CHPRATICA,DC_CREDITO,DC_VIGENCIA,MOD_CODIGO) ")
        Sql.Append("VALUES (@dcodigo, @dcoddisciplina, @ddisciplina, @dteorica, @dpratica, @dcredito, @dvigencia, @dmodulo) ")
        Cx = New SqlConnection
        'Cx.ConnectionString = "server=marcos\marcos;database=c_certificado;Trusted_Connection=Yes"
        Cx.ConnectionString = ConfigurationSettings.AppSettings("cStrConexao") & vlconexao
        Cm = New SqlCommand
        Cm.CommandText = Sql.ToString
        Cm.Connection = Cx
        Cm.Parameters.Add("@dcodigo", vlCodigo)
        Cm.Parameters.Add("@dcoddisciplina", vlcoddisciplina)
        Cm.Parameters.Add("@ddisciplina", vldisciplina)
        Cm.Parameters.Add("@dteorica", vlchteorica)
        If vlchpratica <> 0 Then Cm.Parameters.Add("@dpratica", vlchpratica) Else Cm.Parameters.Add("@dpratica", DBNull.Value)
        Cm.Parameters.Add("@dcredito", vlcredito)
        Cm.Parameters.Add("@dvigencia", vlvigencia)
        Cm.Parameters.Add("@dmodulo", vlmodulo)

        'Cm.Parameters.Add("@codcurso", vlcurcodigo)
        'If vlObservacao <> "" Then Cm.Parameters.Add("@OBSERVACAO", vlObservacao) Else Cm.Parameters.Add("@OBSERVACAO", DBNull.Value)
        Try
            Cx.Open()
            Cm.ExecuteNonQuery()
            Return "Inclusão efetudada com sucesso!"
        Catch ex As Exception
            Return "Erro ao inserir os dados!"
        Finally
            Cx.Close()
            Cx = Nothing
            Cm = Nothing
            Sql = Nothing
        End Try
    End Function
    ' Declaracao dos metodos
    Public Function Excluir(ByVal pCondicao As String) As String
        Dim Sql As New System.Text.StringBuilder
        Sql.Append("DELETE FROM TB_DISCIPLINA ")
        If Trim(pCondicao) <> "" Then Sql.Append("WHERE " & pCondicao & " ")
        Cx = New SqlConnection
        'Cx.ConnectionString = "server=marcos\marcos;database=c_certificado;Trusted_Connection=Yes"
        Cx.ConnectionString = ConfigurationSettings.AppSettings("cStrConexao") & vlconexao
        Cm = New SqlCommand
        Cm.CommandText = Sql.ToString
        Cm.Connection = Cx
        Try
            Cx.Open()
            Cm.ExecuteNonQuery()
            Return "Exclusão efetudada com sucesso!"
        Catch ex As Exception
            Return "Erro ao excluir os dados!"
        Finally
            Cx.Close()
            Cx = Nothing
            Cm = Nothing
            Sql = Nothing
        End Try
    End Function

    Public Function Alterar() As String
        Dim Sql As New System.Text.StringBuilder
        Sql.Append("UPDATE TB_DISCIPLINA SET DC_CODDISCIPLINA=@dcoddisciplina,DC_DISCIPLINA=@ddisciplina,DC_CHTEORICA=@dteorica,DC_CHPRATICA=@dpratica,DC_CREDITO=@dcredito,DC_VIGENCIA=@dvigencia,MOD_CODIGO=@dmodulo WHERE dc_codigo=@dcodigo")
        Cx = New SqlConnection
        'Cx.ConnectionString = "server=marcos\marcos;database=c_certificado;Trusted_Connection=Yes"
        Cx.ConnectionString = ConfigurationSettings.AppSettings("cStrConexao") & vlconexao
        Cm = New SqlCommand
        Cm.CommandText = Sql.ToString
        Cm.Connection = Cx
        Cm.Parameters.Add("@dcodigo", vlCodigo)
        Cm.Parameters.Add("@dcoddisciplina", vlcoddisciplina)
        Cm.Parameters.Add("@ddisciplina", vldisciplina)
        Cm.Parameters.Add("@dteorica", vlchteorica)
        'If vlemail_inst <> "" Then Cm.Parameters.Add("@email_inst", vlemail_inst)
        If vlchpratica <> 0 Then Cm.Parameters.Add("@dpratica", vlchpratica) Else Cm.Parameters.Add("@dpratica", DBNull.Value)
        'If Not IsDBNull(Ds.Tables(0).Rows(0)("@dpratica")) Then Cm.Parameters.Add("@dpratica", vlchpratica)
        Cm.Parameters.Add("@dcredito", vlcredito)
        Cm.Parameters.Add("@dvigencia", vlvigencia)
        Cm.Parameters.Add("@dmodulo", vlmodulo)
        Try
            Cx.Open()
            Cm.ExecuteNonQuery()
            Return "Alteração efetudada com sucesso!"
        Catch ex As Exception
            Return "Erro ao alterar os dados!"
        Finally
            Cx.Close()
            Cx = Nothing
            Cm = Nothing
            Sql = Nothing
        End Try
    End Function

    Public Function Consultar(ByVal pParametro As String) As Data.DataSet
        Dim Sql As New System.Text.StringBuilder
        Sql.Append("SELECT A.MOD_CODIGO,A.DC_CODIGO,A.DC_CODDISCIPLINA,A.DC_DISCIPLINA,A.DC_CHTEORICA,A.DC_CHPRATICA,A.DC_VIGENCIA,B.MOD_MODULO FROM TB_DISCIPLINA A, TB_MODULO B WHERE A.MOD_CODIGO=B.MOD_CODIGO ")
        'Sql.Append("SELECT * ")
        'Sql.Append("FROM TB_DISCIPLINA ")
        If Trim(pParametro) <> "" Then Sql.Append("AND " & pParametro & " ")
        Sql.Append("ORDER BY DC_CODIGO ")
        Cx = New SqlConnection
        'Cx.ConnectionString = "server=marcos\marcos;database=c_certificado;Trusted_Connection=Yes"
        Cx.ConnectionString = ConfigurationSettings.AppSettings("cStrConexao") & vlconexao
        Cm = New SqlCommand
        Cm.CommandText = Sql.ToString
        Cm.Connection = Cx
        Try
            Ds = New DataSet
            Da = New SqlDataAdapter
            Da.SelectCommand = Cm
            Da.Fill(Ds)
            Return Ds
        Catch ex As Exception
            Return Nothing
        Finally
            Cx.Close()
            Cx = Nothing
            Cm = Nothing
            Sql = Nothing
        End Try
    End Function

    Public Function Consultaraltera(ByVal pParametro As String) As Data.DataSet
        Dim Sql As New System.Text.StringBuilder
        'Sql.Append("SELECT A.MOD_CODIGO,A.DC_CODIGO,A.DC_CODDISCIPLINA,A.DC_DISCIPLINA,A.DC_CHTEORICA,A.DC_CHPRATICA,A.DC_VIGENCIA,B.MOD_MODULO FROM TB_DISCIPLINA A, TB_MODULO B WHERE A.MOD_CODIGO=B.MOD_CODIGO ")
        Sql.Append("SELECT * ")
        Sql.Append("FROM TB_DISCIPLINA ")
        If Trim(pParametro) <> "" Then Sql.Append("WHERE " & pParametro & " ")
        Sql.Append("ORDER BY DC_CODIGO ")
        Cx = New SqlConnection
        'Cx.ConnectionString = "server=marcos\marcos;database=c_certificado;Trusted_Connection=Yes"
        Cx.ConnectionString = ConfigurationSettings.AppSettings("cStrConexao") & vlconexao
        Cm = New SqlCommand
        Cm.CommandText = Sql.ToString
        Cm.Connection = Cx
        Try
            Ds = New DataSet
            Da = New SqlDataAdapter
            Da.SelectCommand = Cm
            Da.Fill(Ds)
            Return Ds
        Catch ex As Exception
            Return Nothing
        Finally
            Cx.Close()
            Cx = Nothing
            Cm = Nothing
            Sql = Nothing
        End Try
    End Function

    Public Function Consultar_diaridis(ByVal pParametro As String) As Data.DataSet
        Dim Sql As New System.Text.StringBuilder
        Sql.Append("SELECT DISTINCT A.DC_CODIGO,B.DC_DISCIPLINA,C.PROF_CODIGO,C.PROF_NOME FROM TB_PROF_CURSO A,TB_DISCIPLINA B,TB_PROFESSORES C WHERE A.DC_CODIGO=B.DC_CODIGO AND A.PROF_CODIGO=C.PROF_CODIGO ")
        'Sql.Append("SELECT A.PROF_CODIGO,A.DC_CODIGO,B.PROF_NOME,C.DC_DISCIPLINA FROM TB_PROF_DISCIPLINA A,TB_PROFESSORES B,TB_DISCIPLINA C WHERE A.PROF_CODIGO=B.PROF_CODIGO AND A.DC_CODIGO=C.DC_CODIGO ")
        'Sql.Append("FROM TB_DISCIPLINA ")
        If Trim(pParametro) <> "" Then Sql.Append("AND " & pParametro & " ")
        Sql.Append("ORDER BY A.DC_CODIGO ")
        Cx = New SqlConnection
        'Cx.ConnectionString = "server=marcos\marcos;database=c_certificado;Trusted_Connection=Yes"
        Cx.ConnectionString = ConfigurationSettings.AppSettings("cStrConexao") & vlconexao
        Cm = New SqlCommand
        Cm.CommandText = Sql.ToString
        Cm.Connection = Cx
        Try
            Ds = New DataSet
            Da = New SqlDataAdapter
            Da.SelectCommand = Cm
            Da.Fill(Ds)
            Return Ds
        Catch ex As Exception
            Return Nothing

        Finally
            Cx.Close()
            Cx = Nothing
            Cm = Nothing
            Sql = Nothing
        End Try
    End Function
End Class
