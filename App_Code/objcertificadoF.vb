'Analista: Marcos Felix
'Data: 11/08/2006


Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.Web.SessionState.HttpSessionState

Public Class objcertificadoFrente

    ' Declaracao das variaveis das instancias dos objetos
    Private Cx As SqlConnection
    Private Cm As SqlCommand
    Private Da As SqlDataAdapter
    Private Ds As DataSet

    ' Declaracao das variaveis de trabalho
    Private vlcodigo As Integer
    Private vlrealisacao As String
    Private vlmonografia As String
    Private vlprocesso As String
    Private vlalucodigo As Integer
    Private vlcurcodigo As Integer
    Private vlconexao As String
    'Private vlimpressao As DateTime
    'Private vlrescodigo As Integer
    'Private vlpocodigo As Integer

    ' Declaracao das propriedades
    Property codigo()
        Get
            Return vlcodigo
        End Get
        Set(ByVal value)
            vlcodigo = value
        End Set
    End Property
    Property realisacao()
        Get
            Return vlrealisacao
        End Get
        Set(ByVal value)
            vlrealisacao = value
        End Set
    End Property
    Property monografia()
        Get
            Return vlmonografia
        End Get
        Set(ByVal value)
            vlmonografia = value
        End Set
    End Property
    Property processo()
        Get
            Return vlprocesso
        End Get
        Set(ByVal value)
            vlprocesso = value
        End Set
    End Property
    Property codigoaluno()
        Get
            Return vlalucodigo
        End Get
        Set(ByVal value)
            vlalucodigo = value
        End Set
    End Property
    Property cursocodigo()
        Get
            Return vlcurcodigo
        End Get
        Set(ByVal value)
            vlcurcodigo = value
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
        Sql.Append("INSERT INTO TB_CERTIFICADO ")
        Sql.Append("(CER_CODIGO,CER_REALIZACAODOCURSO,CER_TITULOMONOGRAFIA,CER_PROCESSO,ALU_CODIGO,CUR_CODIGO) ")
        Sql.Append("VALUES (@c_codigo,@c_realizado,@c_titulo,@c_processo,@c_alu_codigo,@c_cur_codigo) ")
        Cx = New SqlConnection
        'Cx.ConnectionString = "server=marcos\marcos;database=c_certificado;Trusted_Connection=Yes"
        Cx.ConnectionString = ConfigurationSettings.AppSettings("cStrConexao") & vlconexao
        Cm = New SqlCommand
        Cm.CommandText = Sql.ToString
        Cm.Connection = Cx
        Cm.Parameters.Add("@c_codigo", vlcodigo)
        Cm.Parameters.Add("@c_realizado", vlrealisacao)
        Cm.Parameters.Add("@c_titulo", vlmonografia)
        'Cm.Parameters.Add("@c_processo", vlprocesso)
        Cm.Parameters.Add("@c_alu_codigo", vlalucodigo)
        Cm.Parameters.Add("@c_cur_codigo", vlcurcodigo)
        'Cm.Parameters.Add("@c_res_codigo", vlrescodigo)
        'Cm.Parameters.Add("@po_codigo", vlpocodigo)
        If vlprocesso <> "" Then Cm.Parameters.Add("@c_processo", vlprocesso) Else Cm.Parameters.Add("@c_processo", DBNull.Value)
        'If vlimpressao <> "" Then Cm.Parameters.Add("@impressao", vlimpressao) Else Cm.Parameters.Add("@impressao", DBNull.Value)
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
        Sql.Append("DELETE FROM TB_CERTIFICADO ")
        If Trim(pCondicao) <> "" Then Sql.Append("WHERE " & pCondicao & " ")
        Cx = New SqlConnection
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
        Sql.Append("UPDATE TB_CERTIFICADO SET CER_REALIZACAODOCURSO=@c_realizado,CER_TITULOMONOGRAFIA=@c_titulo,CER_PROCESSO=@c_processo,ALU_CODIGO=@c_alu_codigo,CUR_CODIGO=@c_cur_codigo WHERE CER_CODIGO=@c_codigo")
        Cx = New SqlConnection
        'Cx.ConnectionString = "server=marcos\marcos;database=c_certificado;Trusted_Connection=Yes"
        Cx.ConnectionString = ConfigurationSettings.AppSettings("cStrConexao") & vlconexao
        Cm = New SqlCommand
        Cm.CommandText = Sql.ToString
        Cm.Connection = Cx

        Cm.Parameters.Add("@c_codigo", vlcodigo)
        Cm.Parameters.Add("@c_realizado", vlrealisacao)
        Cm.Parameters.Add("@c_titulo", vlmonografia)
        'Cm.Parameters.Add("@c_processo", vlprocesso)
        Cm.Parameters.Add("@c_alu_codigo", vlalucodigo)
        Cm.Parameters.Add("@c_cur_codigo", vlcurcodigo)
        'Cm.Parameters.Add("@c_res_codigo", vlrescodigo)
        'Cm.Parameters.Add("@c_po_codigo", vlpocodigo)
        If vlprocesso <> "" Then Cm.Parameters.Add("@c_processo", vlprocesso) Else Cm.Parameters.Add("@c_processo", DBNull.Value)
        'If vlprocesso <> 0 Then Cm.Parameters.Add("@c_processo", vlprocesso) Else Cm.Parameters.Add("@c_processo", DBNull.Value)
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
        Sql.Append("FROM TB_CERTIFICADO ")
        If Trim(pParametro) <> "" Then Sql.Append("WHERE " & pParametro & " ")
        Sql.Append("ORDER BY CER_CODIGO ")
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

    Public Function Consultar_certificado(ByVal pParametro As String) As Data.DataSet
        Dim Sql As New System.Text.StringBuilder
        Sql.Append("SELECT A.CER_CODIGO,A.CER_REALIZACAODOCURSO,B.ALU_NOME,C.CUR_CURSO FROM TB_CERTIFICADO A,TB_ALUNO B,TB_CURSO C WHERE A.ALU_CODIGO=B.ALU_CODIGO AND A.CUR_CODIGO=C.CUR_CODIGO ")
        'Sql.Append("FROM TB_CERTIFICADO ")
        If Trim(pParametro) <> "" Then Sql.Append("AND " & pParametro & " ")
        Sql.Append("ORDER BY CER_CODIGO ")
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


