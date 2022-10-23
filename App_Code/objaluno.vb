'Analista: Marcos Felix
'Data: 10/08/2006



Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.Globalization

Public Class objaluno

    ' Declaracao das variaveis das instancias dos objetos
    Private Dados As DataSet
    Private Cx As SqlConnection
    Private Cm As SqlCommand
    Private Da As SqlDataAdapter
    Private Ds As DataSet

    ' Declaracao das variaveis de trabalho
    Private vlcodigo As Integer
    Private vlaluno As String
    Private vlendereco As String
    Private vlnumero As Integer
    Private vlcomplemento As String
    Private vlbairro As String
    Private vlcidade As Integer
    Private vluf As String
    Private vlCep As String
    Private vlfone1 As String
    Private vlfone2 As String
    Private vlfax As String
    Private vlemail As String
    Private vlcelular As String
    Private vlcpf As String
    Private vlrg As String
    Private vlorgaemissor As String
    Private vlnaturalidade As String
    Private vlnascimento As DateTime
    Private vlformacao As String
    Private vlinstituicao As String
    Private vlano As DateTime
    Private vltitulacaomaxima As String
    Private vlanotitulacao As DateTime
    Private vlareadeatuacao As String
    Private vlins_origem As String
    Private vlend_instituicao As String
    Private vlnum_instituicao As Integer
    Private vlcomplemento_inst As String
    Private vlbairro_inst As String
    Private vluf_inst As String
    Private vlcep_inst As String
    Private vlfone1_inst As String
    Private vlfone2_inst As String
    Private vlfax_inst As String
    Private vlemail_inst As String
    Private vlcargo_inst As String
    Private vlfuncao_inst As String
    Private vllocal As String
    Private vlperiodo As DateTime
    Private vltermino As DateTime
    Private vlturno As String
    Private vldocumentos As String
    Private vlhistorico As String
    Private vldiploma As String
    Private vlfoto As String
    Private vlidentificado As String
    Private vlcurso As Integer
    Private vlcidade_inst As Integer
    Private vlconexao As String

    ' Declaracao das propriedades
    Property _codigo()
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
    Property endereco()
        Get
            Return vlendereco
        End Get
        Set(ByVal value)
            vlendereco = value
        End Set
    End Property
    Property numero()
        Get
            Return vlnumero
        End Get
        Set(ByVal value)
            vlnumero = value
        End Set
    End Property
    Property _complemento()
        Get
            Return vlcomplemento
        End Get
        Set(ByVal value)
            vlcomplemento = value
        End Set
    End Property
    Property _bairro()
        Get
            Return vlbairro
        End Get
        Set(ByVal value)
            vlbairro = value
        End Set
    End Property
    Property cidade()
        Get
            Return vlcidade
        End Get
        Set(ByVal value)
            vlcidade = value
        End Set
    End Property
    Property uf()
        Get
            Return vluf
        End Get
        Set(ByVal value)
            vluf = value
        End Set
    End Property
    Property cep()
        Get
            Return vlCep
        End Get
        Set(ByVal value)
            vlCep = value
        End Set
    End Property
    Property fone1()
        Get
            Return vlfone1
        End Get
        Set(ByVal value)
            vlfone1 = value
        End Set
    End Property
    Property fone2()
        Get
            Return vlfone2
        End Get
        Set(ByVal value)
            vlfone2 = value
        End Set
    End Property
    Property fax()
        Get
            Return vlfax
        End Get
        Set(ByVal value)
            vlfax = value
        End Set
    End Property
    Property email()
        Get
            Return vlemail
        End Get
        Set(ByVal value)
            vlemail = value
        End Set
    End Property
    Property celular()
        Get
            Return vlcelular
        End Get
        Set(ByVal value)
            vlcelular = value
        End Set
    End Property
    Property cpf()
        Get
            Return vlcpf
        End Get
        Set(ByVal value)
            vlcpf = value
        End Set
    End Property
    Property rg()
        Get
            Return vlrg
        End Get
        Set(ByVal value)
            vlrg = value
        End Set
    End Property
    Property orgaemissor()
        Get
            Return vlorgaemissor
        End Get
        Set(ByVal value)
            vlorgaemissor = value
        End Set
    End Property
    Property naturalidade()
        Get
            Return vlnaturalidade
        End Get
        Set(ByVal value)
            vlnaturalidade = value
        End Set
    End Property
    Property nascimento()
        Get
            Return vlnascimento
        End Get
        Set(ByVal value)
            vlnascimento = value
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
    Property instituicao()
        Get
            Return vlinstituicao
        End Get
        Set(ByVal value)
            vlinstituicao = value
        End Set
    End Property
    Property ano()
        Get
            Return vlano
        End Get
        Set(ByVal value)
            vlano = value
        End Set
    End Property
    Property titulacaomaxima()
        Get
            Return vltitulacaomaxima
        End Get
        Set(ByVal value)
            vltitulacaomaxima = value
        End Set
    End Property
    Property anotitulacao()
        Get
            Return vlanotitulacao
        End Get
        Set(ByVal value)
            vlanotitulacao = value
        End Set
    End Property
    Property atuacao()
        Get
            Return vlareadeatuacao
        End Get
        Set(ByVal value)
            vlareadeatuacao = value
        End Set
    End Property
    Property Inst_origem()
        Get
            Return vlins_origem
        End Get
        Set(ByVal value)
            vlins_origem = value

        End Set
    End Property
    Property endereco_inst()
        Get
            Return vlend_instituicao
        End Get
        Set(ByVal value)
            vlend_instituicao = value
        End Set
    End Property
    Property numero_inst()
        Get
            Return vlnum_instituicao
        End Get
        Set(ByVal value)
            vlnum_instituicao = value
        End Set
    End Property
    Property comlemento_inst()
        Get
            Return vlcomplemento_inst
        End Get
        Set(ByVal value)
            vlcomplemento_inst = value
        End Set
    End Property
    Property bairro_inst()
        Get
            Return vlbairro_inst
        End Get
        Set(ByVal value)
            vlbairro_inst = value
        End Set
    End Property
    Property uf_inst()
        Get
            Return vluf_inst
        End Get
        Set(ByVal value)
            vluf_inst = value
        End Set
    End Property
    Property cep_inst()
        Get
            Return vlcep_inst
        End Get
        Set(ByVal value)
            vlcep_inst = value
        End Set
    End Property
    Property fone1_inst()
        Get
            Return vlfone1_inst
        End Get
        Set(ByVal value)
            vlfone1_inst = value
        End Set
    End Property
    Property fone2_inst()
        Get
            Return vlfone2_inst
        End Get
        Set(ByVal value)
            vlfone2_inst = value
        End Set
    End Property
    Property fax_inst()
        Get
            Return vlfax_inst
        End Get
        Set(ByVal value)
            vlfax_inst = value
        End Set
    End Property
    Property email_inst()
        Get
            Return vlemail_inst
        End Get
        Set(ByVal value)
            vlemail_inst = value
        End Set
    End Property
    Property cargo_inst()
        Get
            Return vlcargo_inst
        End Get
        Set(ByVal value)
            vlcargo_inst = value
        End Set
    End Property
    Property funcao_inst()
        Get
            Return vlfuncao_inst
        End Get
        Set(ByVal value)
            vlfuncao_inst = value
        End Set
    End Property
    Property lacal()
        Get
            Return vllocal
        End Get
        Set(ByVal value)
            vllocal = value
        End Set
    End Property
    Property periodo()
        Get
            Return vlperiodo
        End Get
        Set(ByVal value)
            vlperiodo = value
        End Set
    End Property
    Property termino()
        Get
            Return vltermino
        End Get
        Set(ByVal value)
            vltermino = value
        End Set
    End Property
    Property turno()
        Get
            Return vlturno
        End Get
        Set(ByVal value)
            vlturno = value
        End Set
    End Property
    Property documento()
        Get
            Return vldocumentos
        End Get
        Set(ByVal value)
            vldocumentos = value
        End Set
    End Property
    Property historico()
        Get
            Return vlhistorico
        End Get
        Set(ByVal value)
            vlhistorico = value

        End Set
    End Property
    Property diploma()
        Get
            Return vldiploma
        End Get
        Set(ByVal value)
            vldiploma = value
        End Set
    End Property
    Property foto()
        Get
            Return vlfoto
        End Get
        Set(ByVal value)
            vlfoto = value
        End Set
    End Property
    Property identificacao()
        Get
            Return vlidentificado
        End Get
        Set(ByVal value)
            vlidentificado = value
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
    Property cidade_inst()
        Get
            Return vlcidade_inst
        End Get
        Set(ByVal value)
            vlcidade_inst = value
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
        Sql.Append("INSERT INTO TB_ALUNO ")
        Sql.Append("(ALU_CODIGO,ALU_NOME,ALU_ENDERECO,ALU_NUMERO,ALU_COMPLEMENTO,ALU_BAIRRO,ALU_CIDADE,ALU_UF,ALU_CEP,ALU_FONE1,ALU_FONE2,ALU_FAX,ALU_EMAIL,ALU_CELULAR,ALU_CPF,ALU_RG,ALU_ORGAOEMISSOR,ALU_NATURALIDADE,ALU_NASCIMENTO,ALU_FORMACAO,ALU_INSTITUICAO,ALU_ANO,ALU_TITULACAOMAXIMA,ALU_ANOTITULACAOMAXIMA,ALU_AREADEATUACAO,ALU_INST_DEORIGEM,ALU_END_INSTITUICAO,ALU_NUM_INSTITUICAO,ALU_COMPLEMENTO_INST,ALU_BAIRRO_INST,ALU_UF_INST,ALU_CEP_INST,ALU_FONE1_INST,ALU_FONE2_INST,ALU_FAX_INST,ALU_EMAIL_INST,ALU_CARGO_INST,ALU_FUNCAO_INST,ALU_LOCAL,ALU_PERIODO,ALU_TERMINO,ALU_TURNO,ALU_DOCUMENTO,ALU_HISTORICO,ALU_DIPLOMA,ALU_FOTO,ALU_IDENTIFICADO,CUR_CODIGO,ALU_CIDADE_INST) ")
        Sql.Append("VALUES (@Ccodigo,@Cnome,@Cendereco,@Cnumero,@complemento,@bairro,@cidade,@uf,@cep,@fone1,@fone2,@fax,@email,@celular,@cpf,@rg,@orgaoemisso,@naturalidade,@nascimento,@formacao,@instituicao,@ano,@titulacaomaxima,@anotitulacaomaxima,@areadeatuacao,@inst_origem,@end_instituicao,@num_instituicao,@complemento_inst, @bairro_inst,@uf_inst,@cep_inst,@fone1_inst,@fone2_inst,@fax_inst,@email_inst,@cargo_inst,@funcao_inst,@local,@periodo,@termino,@turno,@Cdocumento,@historico,@diploma,@foto,@identificado,@cu_codigo,@cidade_inst) ")
        Cx = New SqlConnection
        'Cx.ConnectionString = "server=marcos\marcos;database=c_certificado;Trusted_Connection=Yes"
        Cx.ConnectionString = ConfigurationSettings.AppSettings("cStrConexao") & vlconexao
        Cm = New SqlCommand
        Cm.CommandText = Sql.ToString
        Cm.Connection = Cx
        Cm.Parameters.Add("@Ccodigo", vlcodigo)
        Cm.Parameters.Add("@Cnome", vlaluno)
        Cm.Parameters.Add("@Cendereco", vlendereco)
        If vlnumero <> 0 Then Cm.Parameters.Add("@cnumero", vlnumero) Else Cm.Parameters.Add("@cnumero", DBNull.Value)
        'Cm.Parameters.Add("@Cnumero", vlnumero)
        'Cm.Parameters.Add("@complemento", vlcomplemento)
        If vlcomplemento <> "" Then Cm.Parameters.Add("@complemento", vlcomplemento) Else Cm.Parameters.Add("@complemento", DBNull.Value)
        Cm.Parameters.Add("@bairro", vlbairro)
        Cm.Parameters.Add("@cidade", vlcidade)
        Cm.Parameters.Add("@uf", vluf)
        Cm.Parameters.Add("@cep", vlCep)
        If vlfone1 <> "" Then Cm.Parameters.Add("@fone1", vlfone1) Else Cm.Parameters.Add("@fone1", DBNull.Value)
        'Cm.Parameters.Add("@fone1", vlfone1)
        'Cm.Parameters.Add("@fone2", vlfone2)
        If vlfone2 <> "" Then Cm.Parameters.Add("@fone2", vlfone2) Else Cm.Parameters.Add("@fone2", DBNull.Value)
        'Cm.Parameters.Add("@fax", vlfax)
        If vlfax <> "" Then Cm.Parameters.Add("@fax", vlfax) Else Cm.Parameters.Add("@fax", DBNull.Value)
        'Cm.Parameters.Add("@email", vlemail)
        If vlemail <> "" Then Cm.Parameters.Add("@email", vlemail) Else Cm.Parameters.Add("@email", DBNull.Value)
        If vlcelular <> "" Then Cm.Parameters.Add("@celular", vlcelular) Else Cm.Parameters.Add("@celular", DBNull.Value)
        'Cm.Parameters.Add("@celular", vlcelular)
        Cm.Parameters.Add("@cpf", vlcpf)
        Cm.Parameters.Add("@rg", vlrg)
        Cm.Parameters.Add("@orgaoemisso", vlorgaemissor)
        Cm.Parameters.Add("@naturalidade", naturalidade)
        Cm.Parameters.Add("nascimento", vlnascimento)
        Cm.Parameters.Add("@formacao", vlformacao)
        Cm.Parameters.Add("@instituicao", vlinstituicao)
        Cm.Parameters.Add("@ano", vlano)
        Cm.Parameters.Add("@titulacaomaxima", vltitulacaomaxima)
        Cm.Parameters.Add("@anotitulacaomaxima", vlanotitulacao)
        Cm.Parameters.Add("@areadeatuacao", vlareadeatuacao)
        If vlins_origem <> "" Then Cm.Parameters.Add("@inst_origem", vlins_origem) Else Cm.Parameters.Add("@inst_origem", DBNull.Value)
        'Cm.Parameters.Add("@inst_origem", vlins_origem)
        If vlend_instituicao <> "" Then Cm.Parameters.Add("@end_instituicao", vlend_instituicao) Else Cm.Parameters.Add("@end_instituicao", DBNull.Value)
        'Cm.Parameters.Add("@end_instituicao", vlend_instituicao)
        If vlnum_instituicao <> 0 Then Cm.Parameters.Add("@num_instituicao", vlnum_instituicao) Else Cm.Parameters.Add("@num_instituicao", DBNull.Value)
        'Cm.Parameters.Add("@num_instituicao", vlnum_instituicao)
        If vlcomplemento_inst <> "" Then Cm.Parameters.Add("@complemento_inst", vlcomplemento_inst) Else Cm.Parameters.Add("@complemento_inst", DBNull.Value)
        'Cm.Parameters.Add("@complemento_inst", vlcomplemento_inst)
        If vlbairro_inst <> "" Then Cm.Parameters.Add("@bairro_inst", vlbairro_inst) Else Cm.Parameters.Add("@bairro_inst", DBNull.Value)
        'Cm.Parameters.Add("@bairro_inst", vlbairro_inst)
        Cm.Parameters.Add("@uf_inst", vluf_inst)
        If vlcep_inst <> "" Then Cm.Parameters.Add("@cep_inst", vlcep_inst) Else Cm.Parameters.Add("@cep_inst", DBNull.Value)
        'Cm.Parameters.Add("@cep_inst", vlcep_inst)
        If vlfone1_inst <> "" Then Cm.Parameters.Add("@fone1_inst", vlfone1_inst) Else Cm.Parameters.Add("@fone1_inst", DBNull.Value)
        'Cm.Parameters.Add("@fone1_inst", vlfone1_inst)
        If vlfone2_inst <> "" Then Cm.Parameters.Add("@fone2_inst", vlfone2_inst) Else Cm.Parameters.Add("@fone2_inst", DBNull.Value)
        'Cm.Parameters.Add("@fone2_inst", vlfone2_inst)
        If vlfax_inst <> "" Then Cm.Parameters.Add("@fax_inst", vlfax_inst) Else Cm.Parameters.Add("@fax_inst", DBNull.Value)
        'Cm.Parameters.Add("@fax_inst", vlfax_inst)
        If vlemail_inst <> "" Then Cm.Parameters.Add("@email_inst", vlemail_inst) Else Cm.Parameters.Add("@email_inst", DBNull.Value)
        'Cm.Parameters.Add("@email_inst", vlemail_inst)
        If vlcargo_inst <> "" Then Cm.Parameters.Add("@cargo_inst", vlcargo_inst) Else Cm.Parameters.Add("@cargo_inst", DBNull.Value)
        'Cm.Parameters.Add("@cargo_inst", vlcargo_inst)
        If vlfuncao_inst <> "" Then Cm.Parameters.Add("@funcao_inst", vlfuncao_inst) Else Cm.Parameters.Add("@funcao_inst", DBNull.Value)
        'Cm.Parameters.Add("@funcao_inst", vlfuncao_inst)
        Cm.Parameters.Add("@local", vllocal)
        Cm.Parameters.Add("@periodo", vlperiodo)
        Cm.Parameters.Add("@termino", vltermino)
        If vlturno <> "" Then Cm.Parameters.Add("@turno", vlturno) Else Cm.Parameters.Add("turno", DBNull.Value)
        'Cm.Parameters.Add("@turno", vlturno)
        Cm.Parameters.Add("@Cdocumento", vldocumentos)
        Cm.Parameters.Add("@historico", vlhistorico)
        Cm.Parameters.Add("@diploma", vldiploma)
        Cm.Parameters.Add("@foto", vlfoto)
        Cm.Parameters.Add("@identificado", vlidentificado)
        Cm.Parameters.Add("@cu_codigo", vlcurso)
        Cm.Parameters.Add("@cidade_inst", vlcidade_inst)
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
        Sql.Append("UPDATE TB_ALUNO SET ALU_NOME=@Cnome,ALU_ENDERECO=@Cendereco,ALU_NUMERO=@Cnumero,ALU_COMPLEMENTO=@complemento,ALU_BAIRRO=@bairro,ALU_CIDADE=@cidade,ALU_UF=@uf,ALU_CEP=@cep,ALU_FONE1=@fone1,ALU_FONE2=@fone2,ALU_FAX=@fax,ALU_EMAIL=@email,ALU_CELULAR=@celular,ALU_CPF=@cpf,ALU_RG=@rg,ALU_ORGAOEMISSOR=@orgaoemisso,ALU_NATURALIDADE=@naturalidade,ALU_NASCIMENTO=@nascimento,ALU_FORMACAO=@formacao,ALU_INSTITUICAO=@instituicao,ALU_ANO=@ano,ALU_TITULACAOMAXIMA=@titulacaomaxima,ALU_ANOTITULACAOMAXIMA=@anotitulacaomaxima,ALU_AREADEATUACAO=@areadeatuacao,ALU_INST_DEORIGEM=@inst_origem,ALU_END_INSTITUICAO=@end_instituicao,ALU_NUM_INSTITUICAO=@num_instituicao,ALU_COMPLEMENTO_INST=@complemento_inst,ALU_BAIRRO_INST=@bairro_inst,ALU_UF_INST=@uf_inst,ALU_CEP_INST=@cep_inst,ALU_FONE1_INST=@fone1_inst,ALU_FONE2_INST=@fone2_inst,ALU_FAX_INST=@fax_inst,ALU_EMAIL_INST=@email_inst,ALU_CARGO_INST=@cargo_inst,ALU_FUNCAO_INST=@funcao_inst,ALU_LOCAL=@local,ALU_PERIODO=@periodo,ALU_TERMINO=@termino,ALU_TURNO=@turno,ALU_DOCUMENTO=@Cdocumento,ALU_HISTORICO=@historico,ALU_DIPLOMA=@diploma,ALU_FOTO=@foto,ALU_IDENTIFICADO=@identificado,CUR_CODIGO=@cu_codigo,ALU_CIDADE_INST=@cidade_inst WHERE alu_codigo=@Ccodigo")
        'Sql.Append("(ALU_NOME=@Cnome,ALU_ENDERECO=@Cendereco,ALU_NUMERO=@Cnumero,ALU_COMPLEMENTO=@complemento,ALU_BAIRRO=@bairro,ALU_CIDADE=@cidade,ALU_UF=@uf,ALU_CEP=@cep,ALU_FONE1=@fone1,ALU_FONE2=@fone2,ALU_FAX=@fax,ALU_EMAIL=@email,ALU_CELULAR=@celular,ALU_CPF=@cpf,ALU_RG=@rg,ALU_ORGAOEMISSOR=@orgaoemisso,ALU_NATURALIDADE=@naturalidade,ALU_NASCIMENTO=@nascimento,ALU_FORMACAO=@formacao,ALU_INSTITUICAO=@instituicao,ALU_ANO=@ano,ALU_TITULACAOMAXIMA=@titulacaomaxima,ALU_ANOTITULACAOMAXIMA=@anotitulacaomaxima,ALU_AREADEATUACAO=@areadeatuacao,ALU_INST_DEORIGEM=@inst_origem,ALU_END_INSTITUICAO=@end_instituicao,ALU_NUM_INSTITUICAO=@num_instituicao,ALU_COMPLEMENTO_INST=@complemento_inst,ALU_BAIRRO_INST=@bairro_inst,ALU_UF_INST=@uf_inst,ALU_CEP_INST=@cep_inst,ALU_FONE1_INST=@fone1_inst,ALU_FONE2_INST=@fone2_inst,ALU_FAX_INST=@fax_inst,ALU_EMAIL_INST=@email_inst,ALU_CARGO_INST=@cargo_inst,ALU_FUNCAO_INST=@funcao_inst,ALU_LOCAL=@local,ALU_PERIODO=@periodo,ALU_TERMINO=@termino,ALU_TURNO=@turno,ALU_DOCUMENTO=@Cdocumento,ALU_HISTORICO=@historico,ALU_DIPLOMA=@diploma,ALU_FOTO=@foto,ALU_IDENTIFICADO=@identificado,CUR_CODIGO=@cu_codigo,ALU_CIDADE_INST=@cidade_inst WHERE alu_codigo=@Ccodigo) ")
        Cx = New SqlConnection
        'Cx.ConnectionString = "server=marcos\marcos;database=c_certificado;Trusted_Connection=Yes"
        Cx.ConnectionString = ConfigurationSettings.AppSettings("cStrConexao") & vlconexao
        Cm = New SqlCommand
        Cm.CommandText = Sql.ToString
        Cm.Connection = Cx
        Cm.Parameters.Add("@Ccodigo", vlcodigo)
        Cm.Parameters.Add("@Cnome", vlaluno)
        Cm.Parameters.Add("@Cendereco", vlendereco)
        If vlnumero <> 0 Then Cm.Parameters.Add("@cnumero", vlnumero) Else Cm.Parameters.Add("@cnumero", DBNull.Value)
        'Cm.Parameters.Add("@Cnumero", vlnumero)
        'Cm.Parameters.Add("@complemento", vlcomplemento)
        If vlcomplemento <> "" Then Cm.Parameters.Add("@complemento", vlcomplemento) Else Cm.Parameters.Add("@complemento", DBNull.Value)
        Cm.Parameters.Add("@bairro", vlbairro)
        Cm.Parameters.Add("@cidade", vlcidade)
        Cm.Parameters.Add("@uf", vluf)
        Cm.Parameters.Add("@cep", vlCep)
        If vlfone1 <> "" Then Cm.Parameters.Add("@fone1", vlfone1) Else Cm.Parameters.Add("@fone1", DBNull.Value)
        'Cm.Parameters.Add("@fone1", vlfone1)
        'Cm.Parameters.Add("@fone2", vlfone2)
        If vlfone2 <> "" Then Cm.Parameters.Add("@fone2", vlfone2) Else Cm.Parameters.Add("@fone2", DBNull.Value)
        'Cm.Parameters.Add("@fax", vlfax)
        If vlfax <> "" Then Cm.Parameters.Add("@fax", vlfax) Else Cm.Parameters.Add("@fax", DBNull.Value)
        'Cm.Parameters.Add("@email", vlemail)
        If vlemail <> "" Then Cm.Parameters.Add("@email", vlemail) Else Cm.Parameters.Add("@email", DBNull.Value)
        If vlcelular <> "" Then Cm.Parameters.Add("@celular", vlcelular) Else Cm.Parameters.Add("@celular", DBNull.Value)
        'Cm.Parameters.Add("@celular", vlcelular)
        Cm.Parameters.Add("@cpf", vlcpf)
        Cm.Parameters.Add("@rg", vlrg)
        Cm.Parameters.Add("@orgaoemisso", vlorgaemissor)
        Cm.Parameters.Add("@naturalidade", naturalidade)
        Cm.Parameters.Add("nascimento", vlnascimento)
        Cm.Parameters.Add("@formacao", vlformacao)
        Cm.Parameters.Add("@instituicao", vlinstituicao)
        Cm.Parameters.Add("@ano", vlano)
        Cm.Parameters.Add("@titulacaomaxima", vltitulacaomaxima)
        Cm.Parameters.Add("@anotitulacaomaxima", vlanotitulacao)
        Cm.Parameters.Add("@areadeatuacao", vlareadeatuacao)
        If vlins_origem <> "" Then Cm.Parameters.Add("@inst_origem", vlins_origem) Else Cm.Parameters.Add("@inst_origem", DBNull.Value)
        'Cm.Parameters.Add("@inst_origem", vlins_origem)
        If vlend_instituicao <> "" Then Cm.Parameters.Add("@end_instituicao", vlend_instituicao) Else Cm.Parameters.Add("@end_instituicao", DBNull.Value)
        'Cm.Parameters.Add("@end_instituicao", vlend_instituicao)
        If vlnum_instituicao <> 0 Then Cm.Parameters.Add("@num_instituicao", vlnum_instituicao) Else Cm.Parameters.Add("@num_instituicao", DBNull.Value)
        'Cm.Parameters.Add("@num_instituicao", vlnum_instituicao)
        If vlcomplemento_inst <> "" Then Cm.Parameters.Add("@complemento_inst", vlcomplemento_inst) Else Cm.Parameters.Add("@complemento_inst", DBNull.Value)
        'Cm.Parameters.Add("@complemento_inst", vlcomplemento_inst)
        If vlbairro_inst <> "" Then Cm.Parameters.Add("@bairro_inst", vlbairro_inst) Else Cm.Parameters.Add("@bairro_inst", DBNull.Value)
        'Cm.Parameters.Add("@bairro_inst", vlbairro_inst)
        Cm.Parameters.Add("@uf_inst", vluf_inst)
        If vlcep_inst <> "" Then Cm.Parameters.Add("@cep_inst", vlcep_inst) Else Cm.Parameters.Add("@cep_inst", DBNull.Value)
        'Cm.Parameters.Add("@cep_inst", vlcep_inst)
        If vlfone1_inst <> "" Then Cm.Parameters.Add("@fone1_inst", vlfone1_inst) Else Cm.Parameters.Add("@fone1_inst", DBNull.Value)
        'Cm.Parameters.Add("@fone1_inst", vlfone1_inst)
        If vlfone2_inst <> "" Then Cm.Parameters.Add("@fone2_inst", vlfone2_inst) Else Cm.Parameters.Add("@fone2_inst", DBNull.Value)
        'Cm.Parameters.Add("@fone2_inst", vlfone2_inst)
        If vlfax_inst <> "" Then Cm.Parameters.Add("@fax_inst", vlfax_inst) Else Cm.Parameters.Add("@fax_inst", DBNull.Value)
        'Cm.Parameters.Add("@fax_inst", vlfax_inst)
        If vlemail_inst <> "" Then Cm.Parameters.Add("@email_inst", vlemail_inst) Else Cm.Parameters.Add("@email_inst", DBNull.Value)
        'Cm.Parameters.Add("@email_inst", vlemail_inst)
        If vlcargo_inst <> "" Then Cm.Parameters.Add("@cargo_inst", vlcargo_inst) Else Cm.Parameters.Add("@cargo_inst", DBNull.Value)
        'Cm.Parameters.Add("@cargo_inst", vlcargo_inst)
        If vlfuncao_inst <> "" Then Cm.Parameters.Add("@funcao_inst", vlfuncao_inst) Else Cm.Parameters.Add("@funcao_inst", DBNull.Value)
        'Cm.Parameters.Add("@funcao_inst", vlfuncao_inst)
        Cm.Parameters.Add("@local", vllocal)
        Cm.Parameters.Add("@periodo", vlperiodo)
        Cm.Parameters.Add("@termino", vltermino)
        If vlturno <> "" Then Cm.Parameters.Add("@turno", vlturno) Else Cm.Parameters.Add("turno", DBNull.Value)
        'Cm.Parameters.Add("@turno", vlturno)
        Cm.Parameters.Add("@Cdocumento", vldocumentos)
        Cm.Parameters.Add("@historico", vlhistorico)
        Cm.Parameters.Add("@diploma", vldiploma)
        Cm.Parameters.Add("@foto", vlfoto)
        Cm.Parameters.Add("@identificado", vlidentificado)
        Cm.Parameters.Add("@cu_codigo", vlcurso)
        Cm.Parameters.Add("@cidade_inst", vlcidade_inst)

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
        Sql.Append("FROM TB_ALUNO ")
        If Trim(pParametro) <> "" Then Sql.Append("WHERE " & pParametro & " ")
        Sql.Append("ORDER BY ALU_CODIGO ")
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
        Sql.Append("DELETE FROM TB_ALUNO ")
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
            Return "Não é possível excluir este aluno. Existem dependencias relacionadas com  esta matrícula!"
        Finally
            Cx.Close()
            Cx = Nothing
            Cm = Nothing
            Sql = Nothing
        End Try
    End Function

    Public Function Povoar_cidades(ByVal pParametro As String) As Data.DataSet
        Dim Sql As New System.Text.StringBuilder
        Sql.Append("SELECT * ")
        Sql.Append("FROM TB_CIDADE ")
        If Trim(pParametro) <> "" Then Sql.Append("WHERE " & pParametro & " ")
        Sql.Append("ORDER BY CD_CODIGO ")
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
    Public Function Consultar_valida(ByVal pParametro As String) As Data.DataSet
        Dim Sql As New System.Text.StringBuilder
        Sql.Append("SELECT ALU_NOME,ALU_IDENTIFICADO ")
        Sql.Append("FROM TB_ALUNO ")
        If Trim(pParametro) <> "" Then Sql.Append("WHERE " & pParametro & "")
        ' Sql.Append("ORDER BY ALU_CODIGO ")
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