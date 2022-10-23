'Analista: Marcos Felix
'Data: 12/08/2006

Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient

Public Class objcurso

    ' Declaracao das variaveis das instancias dos objetos
    Private Cx As SqlConnection
    Private Cm As SqlCommand
    Private Da As SqlDataAdapter
    Private Ds As DataSet

    ' Declaracao das variaveis de trabalho
    Private vlCodigo As Integer
    Private vlcurso As String
    Private vlrescodigo As Integer
    Private vlclasscodigo As Integer
    Private vlportcodigo As Integer
    Private vlcodigocurso As String
    Private vlconexao As String

    ' Declaracao das propriedades
    Property codigo()
        Get
            Return vlCodigo
        End Get
        Set(ByVal value)
            vlCodigo = value
        End Set
    End Property

    Property curso()
        Get
            Return vlcurso
        End Get
        Set(ByVal value)
            vlcurso = value
        End Set
    End Property

    Property resolucao()
        Get
            Return vlrescodigo
        End Get
        Set(ByVal value)
            vlrescodigo = value
        End Set
    End Property

    Property classificacao()
        Get
            Return vlclasscodigo
        End Get
        Set(ByVal value)
            vlclasscodigo = value
        End Set
    End Property
    Property portaria()
        Get
            Return vlportcodigo
        End Get
        Set(ByVal value)
            vlportcodigo = value
        End Set
    End Property

    Property codigodocurso()
        Get
            Return vlcodigocurso
        End Get
        Set(ByVal value)
            vlcodigocurso = value
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
        Sql.Append("INSERT INTO TB_CURSO ")
        Sql.Append("(CUR_CODIGO,CUR_CODCURSO,CUR_CURSO,RES_CODIGO,CLAS_CODIGO,PO_CODIGO) ")
        Sql.Append("VALUES (@codigo, @cocurso, @curso, @rescodigo, @clascodigo,@porcodigo) ")
        Cx = New SqlConnection
        'Cx.ConnectionString = "server=marcos\marcos;database=c_certificado;Trusted_Connection=Yes"
        Cx.ConnectionString = ConfigurationSettings.AppSettings("cStrConexao") & vlconexao
        Cm = New SqlCommand
        Cm.CommandText = Sql.ToString
        Cm.Connection = Cx
        Cm.Parameters.Add("@codigo", vlCodigo)
        Cm.Parameters.Add("@cocurso", vlcodigocurso)
        Cm.Parameters.Add("@curso", vlcurso)
        Cm.Parameters.Add("@rescodigo", vlrescodigo)
        Cm.Parameters.Add("@clascodigo", vlclasscodigo)
        Cm.Parameters.Add("@porcodigo", vlportcodigo)


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
        Sql.Append("DELETE FROM TB_CURSO ")
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
        Sql.Append("UPDATE TB_CURSO SET CUR_CURSO=@curso,CUR_CODCURSO=@cocurso,RES_CODIGO=@rescodigo,CLAS_CODIGO=@clascodigo,PO_CODIGO=@porcodigo WHERE CUR_CODIGO=@codigo")
        Cx = New SqlConnection
        'Cx.ConnectionString = "server=marcos\marcos;database=c_certificado;Trusted_Connection=Yes"
        Cx.ConnectionString = ConfigurationSettings.AppSettings("cStrConexao") & vlconexao
        Cm = New SqlCommand
        Cm.CommandText = Sql.ToString
        Cm.Connection = Cx
        Cm.Parameters.Add("@codigo", vlCodigo)
        Cm.Parameters.Add("@curso", vlcurso)
        Cm.Parameters.Add("@rescodigo", vlrescodigo)
        Cm.Parameters.Add("@clascodigo", vlclasscodigo)
        Cm.Parameters.Add("@porcodigo", vlportcodigo)
        Cm.Parameters.Add("@cocurso", vlcodigocurso)
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
        'Sql.Append("SELECT * ")
        Sql.Append("SELECT A.CUR_CODCURSO,A.CUR_CODIGO,A.CUR_CURSO,B.RES_RESOLUCAO,B.RES_CODIGO,C.CLAS_CODIGO,C.CLAS_CLASSIFICACAO,D.PO_CODIGO,D.PO_PORTARIA FROM TB_CURSO A,TB_RESOLUCAO B,TB_CLASSIFICACAO C,TB_PORTARIA D WHERE A.RES_CODIGO=B.RES_CODIGO AND A.CLAS_CODIGO=C.CLAS_CODIGO AND A.PO_CODIGO=D.PO_CODIGO ")
        ' ORDER BY CUR_CODIGO
        'Sql.Append("FROM TB_CURSO ")
        If Trim(pParametro) <> "" Then Sql.Append("AND " & pParametro & " ")
        Sql.Append("ORDER BY CUR_CODIGO ")
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

    Public Function Consultar_alterar(ByVal pParametro As String) As Data.DataSet
        Dim Sql As New System.Text.StringBuilder
        'Sql.Append("SELECT * ")
        Sql.Append("SELECT A.CUR_CODCURSO,A.CUR_CODIGO,A.CUR_CURSO,B.RES_RESOLUCAO,C.CLAS_CLASSIFICACAO,D.PO_PORTARIA FROM TB_CURSO A,TB_RESOLUCAO B,TB_CLASSIFICACAO C,TB_PORTARIA D WHERE A.RES_CODIGO=B.RES_CODIGO AND A.CLAS_CODIGO=C.CLAS_CODIGO AND A.PO_CODIGO=D.PO_CODIGO ")
        ' ORDER BY CUR_CODIGO
        'Sql.Append("FROM TB_CURSO ")
        If Trim(pParametro) <> "" Then Sql.Append("AND " & pParametro & " ")
        Sql.Append("ORDER BY CUR_CODIGO ")
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
