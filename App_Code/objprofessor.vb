'Analista: Marcos Felix
'Data: 19/08/2006

Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient


Public Class objprofessor

    ' Declaracao das variaveis das instancias dos objetos
    Private Cx As SqlConnection
    Private Cm As SqlCommand
    Private Da As SqlDataAdapter
    Private Ds As DataSet
    ' Declaracao das variaveis de trabalho
    Private vlCodigo As Integer
    Private vlnome As String
    Private vlformacao As String
    Private vlatuacao As String
    Private vltitulacao As String
    Private vlingresso As DateTime
    Private vlunidade As Integer
    Private vlconexao As String
    Property codigo()
        Get
            Return vlCodigo
        End Get
        Set(ByVal value)
            vlCodigo = value
        End Set
    End Property
    Property nome()
        Get
            Return vlnome
        End Get
        Set(ByVal value)
            vlnome = value
        End Set
    End Property
    Property formacao()
        Get
            Return vlformacao
        End Get
        Set(ByVal value)
            vlformacao = value
        End Set
    End Property
    Property atuacao()
        Get
            Return vlatuacao
        End Get
        Set(ByVal value)
            vlatuacao = value
        End Set
    End Property
    Property titulacao()
        Get
            Return vltitulacao
        End Get
        Set(ByVal value)
            vltitulacao = value
        End Set
    End Property
    Property ingresso()
        Get
            Return vlingresso
        End Get
        Set(ByVal value)
            vlingresso = value
        End Set
    End Property
    Property unidade()
        Get
            Return vlunidade
        End Get
        Set(ByVal value)
            vlunidade = value
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

    ' Declaracao dos metodos
    Public Function Inserir() As String
        Dim Sql As New System.Text.StringBuilder
        Sql.Append("INSERT INTO TB_PROFESSORES")
        Sql.Append("(PROF_CODIGO,PROF_NOME,PROF_FORMACAO,PROF_ATUACAO,PROF_TITULACAO,PROF_INGRESSO,UNI_CODIGO) ")
        Sql.Append("VALUES (@codigo, @nome, @formacao, @atuacao, @titulacao, @ingresso, @unidade) ")
        Cx = New SqlConnection
        Cx.ConnectionString = ConfigurationSettings.AppSettings("cStrConexao") & vlconexao
        Cm = New SqlCommand
        Cm.CommandText = Sql.ToString
        Cm.Connection = Cx
        Cm.Parameters.Add("@codigo", vlCodigo)
        Cm.Parameters.Add("@nome", vlnome)
        Cm.Parameters.Add("@formacao", vlformacao)
        Cm.Parameters.Add("@atuacao", vlatuacao)
        Cm.Parameters.Add("@titulacao", vltitulacao)
        Cm.Parameters.Add("@ingresso", vlingresso)
        Cm.Parameters.Add("@unidade", vlunidade)
        'If vlSuperior <> 0 Then Cm.Parameters.Add("@SUPERIOR", vlSuperior) Else Cm.Parameters.Add("@SUPERIOR", DBNull.Value)
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

    Public Function Alterar() As String
        Dim Sql As New System.Text.StringBuilder
        Sql.Append("UPDATE TB_PROFESSORES SET PROF_NOME=@nome,PROF_FORMACAO=@formacao,PROF_ATUACAO=@atuacao,PROF_TITULACAO=@titulacao,PROF_INGRESSO=@ingresso,UNI_CODIGO=@unidade WHERE prof_codigo=@codigo")
        Cx = New SqlConnection
        'Cx.ConnectionString = "server=marcos\marcos;database=c_certificado;Trusted_Connection=Yes"
        Cx.ConnectionString = ConfigurationSettings.AppSettings("cStrConexao") & vlconexao
        Cm = New SqlCommand
        Cm.CommandText = Sql.ToString
        Cm.Connection = Cx
        Cm.Parameters.Add("@codigo", vlCodigo)
        Cm.Parameters.Add("@nome", vlnome)
        Cm.Parameters.Add("@formacao", vlformacao)
        Cm.Parameters.Add("@atuacao", vlatuacao)
        Cm.Parameters.Add("@titulacao", vltitulacao)
        Cm.Parameters.Add("@ingresso", vlingresso)
        Cm.Parameters.Add("@unidade", vlunidade)

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
        Sql.Append("SELECT * ")
        Sql.Append("FROM TB_PROFESSORES ")
        If Trim(pParametro) <> "" Then Sql.Append("WHERE " & pParametro & " ")
        Sql.Append("ORDER BY PROF_CODIGO ")
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
    ' Declaracao dos metodos
    Public Function Excluir(ByVal pCondicao As String) As String
        Dim Sql As New System.Text.StringBuilder
        Sql.Append("DELETE FROM TB_PROFESSORES ")
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
    Public Function Consultar_diario(ByVal pParametro As String) As Data.DataSet
        Dim Sql As New System.Text.StringBuilder
        Sql.Append("SELECT DISTINCT A.CUR_CODIGO,A.PROF_CODIGO,B.CUR_CURSO,C.PROF_NOME FROM TB_PROF_CURSO A,TB_CURSO B,TB_PROFESSORES C WHERE A.CUR_CODIGO = B.CUR_CODIGO AND A.PROF_CODIGO = C.PROF_CODIGO ")
        'Sql.Append("FROM TB_PROFESSORES ")
        If Trim(pParametro) <> "" Then Sql.Append("AND " & pParametro & " ")
        Sql.Append("ORDER BY A.PROF_CODIGO ")
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
