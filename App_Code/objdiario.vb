'Analista: Marcos Felix
'Data: 13/08/2006

Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient

Public Class objdiario

    ' Declaracao das variaveis das instancias dos objetos
    Private Cx As SqlConnection
    Private Cm As SqlCommand
    Private Da As SqlDataAdapter
    Private Ds As DataSet

    ' Declaracao das variaveis de trabalho
    Private vlCodigo As Integer
    Private vlcurcodigo As Integer
    Private vlprocodigo As Integer
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
            Return vlcurcodigo
        End Get
        Set(ByVal value)
            vlcurcodigo = value
        End Set
    End Property

    Property professor()
        Get
            Return vlprocodigo
        End Get
        Set(ByVal value)
            vlprocodigo = value
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
        Sql.Append("INSERT INTO TB_PROF_CURSO")
        Sql.Append("(PC_CODIGO,CUR_CODIGO,PROF_CODIGO) ")
        Sql.Append("VALUES (@codigo, @curso, @professor) ")
        Cx = New SqlConnection
        'Cx.ConnectionString = "server=marcos\marcos;database=c_certificado;Trusted_Connection=Yes"
        Cx.ConnectionString = ConfigurationSettings.AppSettings("cStrConexao") & vlconexao
        Cm = New SqlCommand
        Cm.CommandText = Sql.ToString
        Cm.Connection = Cx
        Cm.Parameters.Add("@codigo", vlCodigo)
        Cm.Parameters.Add("@curso", vlcurcodigo)
        Cm.Parameters.Add("@professor", vlprocodigo)
        'Cm.Parameters.Add("@clascodigo", vlclasscodigo)
        'Cm.Parameters.Add("@porcodigo", vlportcodigo)
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
        Sql.Append("DELETE FROM TB_PROF_CURSO ")
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
        Sql.Append("UPDATE TB_PROF_CURSO SET PC_CODIGO=@codigo,CUR_CODIGO=@ccodigo,PROF_CODIGO=@prcodigo WHERE PC_CODIGO=@codigo")
        Cx = New SqlConnection
        'Cx.ConnectionString = "server=marcos\marcos;database=c_certificado;Trusted_Connection=Yes"
        Cx.ConnectionString = ConfigurationSettings.AppSettings("cStrConexao") & vlconexao
        Cm = New SqlCommand
        Cm.CommandText = Sql.ToString
        Cm.Connection = Cx
        Cm.Parameters.Add("@codigo", vlCodigo)
        Cm.Parameters.Add("@ccodigo", vlcurcodigo)
        Cm.Parameters.Add("@prcodigo", vlprocodigo)
        'Cm.Parameters.Add("@clascodigo", vlclasscodigo)
        'Cm.Parameters.Add("@porcodigo", vlportcodigo)

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

    Public Function Consultar_diario(ByVal pParametro As String) As Data.DataSet
        Dim Sql As New System.Text.StringBuilder
        Sql.Append("SELECT A.ALU_IDENTIFICADO,A.ALU_CODIGO,A.ALU_NOME,A.CUR_CODIGO,B.CUR_CODIGO,B.CUR_CURSO FROM TB_ALUNO A INNER JOIN TB_CURSO B ON A.CUR_CODIGO=B.CUR_CODIGO ")
        If Trim(pParametro) <> "" Then Sql.Append("AND " & pParametro & " ")
        Sql.Append("ORDER BY B.CUR_CODIGO ")
        Cx = New SqlConnection
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
            'Cm = Nothing
            Sql = Nothing
        End Try
    End Function

    Public Function Consultar_prof_curso(ByVal pParametro As String) As Data.DataSet
        Dim Sql As New System.Text.StringBuilder
        Sql.Append("SELECT A.PC_CODIGO,B.CUR_CURSO,C.PROF_NOME FROM TB_PROF_CURSO A,TB_CURSO B,TB_PROFESSORES C WHERE A.CUR_CODIGO = B.CUR_CODIGO AND A.PROF_CODIGO = C.PROF_CODIGO ")
        If Trim(pParametro) <> "" Then Sql.Append("AND " & pParametro & " ")
        Sql.Append("ORDER BY PC_CODIGO ")
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

    Public Function Consultar_montadiario(ByVal pParametro As String) As Data.DataSet
        Dim Sql As New System.Text.StringBuilder
        Sql.Append("SELECT A.ALU_IDENTIFICADO,A.ALU_CODIGO,A.ALU_NOME,A.CUR_CODIGO,B.CUR_CODIGO,B.CUR_CURSO FROM TB_ALUNO A INNER JOIN TB_CURSO B ON A.CUR_CODIGO=B.CUR_CODIGO ")
        'Sql.Append("FROM TB_PROF_CURSO ")
        If Trim(pParametro) <> "" Then Sql.Append("AND " & pParametro & " ")
        'If Trim(pParametro) <> "" Then Sql.Append("AND " & pParametro & " ")
        'If Trim(pParametro) <> "" Then Sql.Append("AND " & pParametro & " ")
        Sql.Append("ORDER BY B.CUR_CODIGO ")
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
            'Cm = Nothing
            Sql = Nothing
        End Try
    End Function

End Class
