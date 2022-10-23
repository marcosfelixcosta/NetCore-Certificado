'Analista: Marcos Felix
'Data: 16/08/2006

Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient

Public Class objhistorico

    ' Declaracao das variaveis das instancias dos objetos
    Private Cx As SqlConnection
    Private Cm As SqlCommand
    Private Da As SqlDataAdapter
    Private Ds As DataSet

    ' Declaracao das variaveis de trabalho
    Private vlcodigo As Integer
    Private vlaluno As Integer
    Private vlprofessor As Integer
    Private vlhoras As Integer
    Private vlfaltas As String
    Private vlfrenquecia As String
    Private vlnota As String
    Private vlnota2 As String
    Private vlnota3 As String
    Private vlmedia As String
    Private vldisciplina As Integer
    Private vlconexao As String
    'Declaracao das propriedades
    Property codigo()
        Get
            Return vlcodigo
        End Get
        Set(ByVal value)
            vlcodigo = value
        End Set
    End Property

    Property aluno()
        Get
            Return vlaluno
        End Get
        Set(ByVal value)
            vlaluno = value
        End Set
    End Property
    Property professor()
        Get
            Return vlprofessor
        End Get
        Set(ByVal value)
            vlprofessor = value
        End Set
    End Property
    Property horas()
        Get
            Return vlhoras
        End Get
        Set(ByVal value)
            vlhoras = value
        End Set
    End Property
    Property faltas()
        Get
            Return vlfaltas
        End Get
        Set(ByVal value)
            vlfaltas = value
        End Set
    End Property
    Property frequencia()
        Get
            Return vlfrenquecia
        End Get
        Set(ByVal value)
            vlfrenquecia = value
        End Set
    End Property
    Property nota()
        Get
            Return vlnota
        End Get
        Set(ByVal value)
            vlnota = value
        End Set
    End Property
    Property nota2()
        Get
            Return vlnota2
        End Get
        Set(ByVal value)
            vlnota2 = value
        End Set
    End Property
    Property nota3()
        Get
            Return vlnota3
        End Get
        Set(ByVal value)
            vlnota3 = value
        End Set
    End Property
    Property media()
        Get
            Return vlmedia
        End Get
        Set(ByVal value)
            vlmedia = value
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
        Sql.Append("INSERT INTO TB_HISTORICO")
        Sql.Append("(HIS_CODIGO,ALU_CODIGO,PC_CODIGO,HIS_CARGAHORA,HIS_FALTAS,HIS_FREQUENCIA,HIS_NOTA,HIS_NOTA2,HIS_NOTA3,HIS_MEDIA,DC_CODIGO) ")
        Sql.Append("VALUES (@codigo,@aluno,@professor,@horas,@falta,@frequencia,@nota,@nota2,@nota3,@media,@disciplina) ")
        Cx = New SqlConnection
        'Cx.ConnectionString = "server=marcos\marcos;database=c_certificado;Trusted_Connection=Yes"
        Cx.ConnectionString = ConfigurationSettings.AppSettings("cStrConexao") & vlconexao
        Cm = New SqlCommand
        Cm.CommandText = Sql.ToString
        Cm.Connection = Cx
        Cm.Parameters.Add("@codigo", vlcodigo)
        Cm.Parameters.Add("@aluno", vlaluno)
        Cm.Parameters.Add("@professor", vlprofessor)
        Cm.Parameters.Add("@horas", vlhoras)
        Cm.Parameters.Add("@falta", vlfaltas)
        Cm.Parameters.Add("@frequencia", vlfrenquecia)
        'Cm.Parameters.Add("@nota", vlnota)
        'Cm.Parameters.Add("@nota2", vlnota2)
        'Cm.Parameters.Add("@nota3", vlnota3)
        Cm.Parameters.Add("@media", vlmedia)
        Cm.Parameters.Add("@disciplina", vldisciplina)

        If vlnota <> "" Then Cm.Parameters.Add("@nota", vlnota) Else Cm.Parameters.Add("@nota", DBNull.Value)
        If vlnota2 <> "" Then Cm.Parameters.Add("@nota2", vlnota2) Else Cm.Parameters.Add("@nota2", DBNull.Value)
        If vlnota3 <> "" Then Cm.Parameters.Add("@nota3", vlnota3) Else Cm.Parameters.Add("@nota3", DBNull.Value)

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
        Sql.Append("DELETE FROM TB_HISTORICO ")
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
        Sql.Append("UPDATE TB_HISTORICO SET HIS_CODIGO=@codigo,ALU_CODIGO=@aluno,PC_CODIGO=@professor,HIS_CARGAHORA=@horas,HIS_FALTAS=@falta,HIS_FREQUENCIA=@frequencia,HIS_NOTA=@nota,HIS_NOTA2=@nota2,HIS_NOTA3=@nota3,HIS_MEDIA=@media,DC_CODIGO=@disciplina WHERE HIS_CODIGO=@codigo")
        Cx = New SqlConnection
        Cx.ConnectionString = ConfigurationSettings.AppSettings("cStrConexao") & vlconexao
        Cm = New SqlCommand
        Cm.CommandText = Sql.ToString
        Cm.Connection = Cx
        Cm.Parameters.Add("@codigo", vlcodigo)
        Cm.Parameters.Add("@aluno", vlaluno)
        Cm.Parameters.Add("@professor", vlprofessor)
        Cm.Parameters.Add("@horas", vlhoras)
        Cm.Parameters.Add("@falta", vlfaltas)
        Cm.Parameters.Add("@frequencia", vlfrenquecia)
        Cm.Parameters.Add("@nota", vlnota)
        Cm.Parameters.Add("@nota2", vlnota2)
        Cm.Parameters.Add("@nota3", vlnota3)
        Cm.Parameters.Add("@media", vlmedia)
        Cm.Parameters.Add("@disciplina", vldisciplina)
        'If vlprocesso <> 0 Then Cm.Parameters.Add("@c_processo", vlprocesso) Else Cm.Parameters.Add("@c_processo", DBNull.Value)
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

        'Sql.Append("SELECT A.HIS_CODIGO,A.DC_CODIGO,A.ALU_CODIGO,A.HIS_CODIGO,A.HIS_CARGAHORA,A.HIS_FALTAS,A.HIS_FREQUENCIA,A.HIS_NOTA,A.HIS_MEDIA,A.HIS_NOTA2,A.HIS_NOTA3,A.HIS_MEDIA,A.PC_CODIGO,A.DC_CODIGO,B.DC_DISCIPLINA FROM TB_HISTORICO A, TB_DISCIPLINA B WHERE A.DC_CODIGO = B.DC_CODIGO ")
        Sql.Append("SELECT * ")
        Sql.Append("FROM TB_HISTORICO ")
        If Trim(pParametro) <> "" Then Sql.Append("WHERE " & pParametro & " ")
        'If Trim(pParametro) <> "" Then Sql.Append(" AND " & pParametro & " ")
        'Sql.Append("ORDER BY HIS_CODIGO ")
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

    Public Function Consultar_historico(ByVal pParametro As String) As Data.DataSet
        Dim Sql As New System.Text.StringBuilder
        'Sql.Append("SELECT DISTINCT A.DC_DISCIPLINA,B.DC_CODIGO,B.PROF_CODIGO,C.PROF_NOME,C.PROF_TITULACAO,D.ALU_CODIGO,D.HIS_CODIGO,D.HIS_CARGAHORA,D.HIS_FALTAS,D.HIS_FREQUENCIA,D.HIS_MEDIA FROM TB_DISCIPLINA A,TB_PROF_CURSO B, TB_PROFESSORES C, TB_HISTORICO D WHERE A.DC_CODIGO=B.DC_CODIGO AND B.PROF_CODIGO=C.PROF_CODIGO AND D.PC_CODIGO=B.PC_CODIGO ")
        Sql.Append("SELECT DISTINCT A.DC_DISCIPLINA,B.DC_CODIGO,B.PROF_CODIGO,C.PROF_NOME,C.PROF_TITULACAO,D.HIS_CODIGO,D.HIS_CARGAHORA,D.HIS_FALTAS,D.HIS_FREQUENCIA,D.HIS_MEDIA FROM TB_DISCIPLINA A,TB_PROF_CURSO B, TB_PROFESSORES C, TB_HISTORICO D WHERE A.DC_CODIGO=D.DC_CODIGO AND B.PROF_CODIGO=C.PROF_CODIGO AND D.PC_CODIGO=B.PC_CODIGO ")
        'Sql.Append("FROM TB_HISTORICO ")
        If Trim(pParametro) <> "" Then Sql.Append("AND " & pParametro & " ")
        'Sql.Append("ORDER BY HIS_CODIGO ")
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
    Public Function Consultar_Imprimir(ByVal pParametro As String) As Data.DataSet
        Dim Sql As New System.Text.StringBuilder
        Sql.Append("SELECT A.CUR_CODIGO,A.ALU_NOME,B.CUR_CODIGO,B.CUR_CURSO FROM TB_ALUNO A, TB_CURSO B WHERE A.CUR_CODIGO=B.CUR_CODIGO ")
        'Sql.Append("SELECT A.DC_CODIGO,A.DC_DISCIPLINA,B.HIS_CODIGO,B.HIS_CARGAHORA,B.HIS_FALTAS,B.ALU_CODIGO,B.HIS_FREQUENCIA,B.HIS_MEDIA,C.PROF_NOME,C.PROF_TITULACAO FROM TB_DISCIPLINA A,TB_HISTORICO B,TB_PROFESSORES C WHERE A.DC_CODIGO=B.DC_CODIGO AND B.PROF_CODIGO=C.PROF_CODIGO ") ' AND B.ALU_CODIGO ")
        'Sql.Append("FROM TB_HISTORICO ")
        If Trim(pParametro) <> "" Then Sql.Append("AND " & pParametro & " ")
        'Sql.Append("ORDER BY HIS_CODIGO ")
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
    Public Function Consultar_historico_aluno(ByVal pParametro As String) As Data.DataSet
        Dim Sql As New System.Text.StringBuilder
        'Sql.Append("SELECT DISTINCT A.DC_DISCIPLINA,B.DC_CODIGO,B.PROF_CODIGO,C.PROF_NOME,C.PROF_TITULACAO,D.ALU_CODIGO,D.HIS_CODIGO,D.HIS_CARGAHORA,D.HIS_FALTAS,D.HIS_FREQUENCIA,D.HIS_MEDIA FROM TB_DISCIPLINA A,TB_PROF_CURSO B, TB_PROFESSORES C, TB_HISTORICO D WHERE A.DC_CODIGO=B.DC_CODIGO AND B.PROF_CODIGO=C.PROF_CODIGO AND D.PC_CODIGO=B.PC_CODIGO ")
        Sql.Append("SELECT DISTINCT A.DC_DISCIPLINA,B.DC_CODIGO,B.PROF_CODIGO,C.PROF_NOME,C.PROF_TITULACAO,D.HIS_CODIGO,D.HIS_CARGAHORA,D.HIS_FALTAS,D.HIS_FREQUENCIA,D.HIS_MEDIA FROM TB_DISCIPLINA A,TB_PROF_CURSO B, TB_PROFESSORES C, TB_HISTORICO D WHERE A.DC_CODIGO=D.DC_CODIGO AND B.PROF_CODIGO=C.PROF_CODIGO AND D.PC_CODIGO=B.PC_CODIGO ")
        'Sql.Append("FROM TB_HISTORICO ")
        If Trim(pParametro) <> "" Then Sql.Append("AND " & pParametro & " ")
        'Sql.Append("ORDER BY HIS_CODIGO ")
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


