'Classe função
'Analista: Marcos Felix
'Data: 24/07/2004


Imports System.Data.SqlClient
Imports classFuncao
Imports System.Globalization
Partial Class Forms_main
    Inherits System.Web.UI.Page
    Protected Alunos As New objaluno
    Protected Message As New Menssagem
    Protected Professor As New objprofessor
    Protected Disciplina As New objdisciplina
    Protected Curso As New objcurso
    Protected CertificadoF As New objcertificadoFrente
    Protected historico As New objhistorico
    Protected prof_curso As New objprof_curso
    Protected diario As New objdiario
    Private Fn As New classFuncao

    '**************************************************************************************************
    'Funções do formulário Histórico
    Protected Sub associar_historico()
        With historico
            .codigo = Gera_Codigohistorico()
            .aluno = h_dropaluno.SelectedValue
            .professor = h_dropprofessor.SelectedValue
            .disciplina = drop_trabDrop.SelectedValue
            .horas = h_txthora.Text
            .faltas = h_faltas.Text
            .frequencia = h_txtfrequencia.Text
            .nota = h_txtnotas.Text
            .nota2 = h_txtnota2.Text
            .nota3 = h_txtnota3.Text
            .media = h_txtmedia.Text
        End With
    End Sub

    Protected Sub Associar_alterar_historico()
        With historico
            .codigo = h_txtcod.Text
            .aluno = h_dropaluno.SelectedValue
            .professor = h_dropprofessor.SelectedValue
            .disciplina = drop_trabDrop.SelectedValue
            .horas = h_txthora.Text
            .faltas = h_faltas.Text
            .frequencia = h_txtfrequencia.Text
            .nota = h_txtnotas.Text
            .nota2 = h_txtnota2.Text
            .nota3 = h_txtnota3.Text
            .media = h_txtmedia.Text
        End With
    End Sub

    Protected Sub limpa_historico()
        h_dropaluno.Enabled = False
        'h_dropaluno.Text = ""
        'h_dropdisciplina.Text = ""
        h_dropprofessor.Enabled = False
        'h_dropprofessor.Text = ""
        h_txtfrequencia.Enabled = False
        drop_trabDrop.Enabled = False
        h_txtfrequencia.Text = ""
        h_txthora.Enabled = False
        h_txthora.Text = ""
        h_txtnotas.Enabled = False
        h_txtnotas.Text = ""
        h_faltas.Enabled = False
        h_txtnota2.Text = ""
        h_txtnota2.Enabled = False
        h_txtnota3.Text = ""
        h_txtnota3.Enabled = False
        h_txtmedia.Text = ""
        h_txtmedia.Enabled = False
        h_faltas.Text = ""
        h_btncancelar.Enabled = False
        h_btnsalvar.Enabled = False
    End Sub

    Protected Sub novo_historico()
        h_btncancelar.Enabled = True
        h_btnsalvar.Enabled = True
        h_dropaluno.Enabled = True
        drop_trabDrop.Enabled = True
        'h_dropaluno.Text = ""
        'h_dropdisciplina.Enabled = True
        'h_dropdisciplina.Text = ""
        h_dropprofessor.Enabled = True
        'h_dropprofessor.Text = ""
        h_txtfrequencia.Enabled = True
        h_txtfrequencia.Text = ""
        h_txthora.Enabled = True
        h_txtnota2.Enabled = True
        h_txtnota3.Enabled = True
        h_txtmedia.Enabled = True
        h_txthora.Text = ""
        h_txtnotas.Enabled = True
        h_txtnotas.Text = ""
        h_faltas.Enabled = True
        h_faltas.Text = ""
        povoa_aluno_historico()
        povoar_professor_historico()
    End Sub
    Protected Sub povoa_aluno_historico()

        Dim Sql As New System.Text.StringBuilder
        Dim Ds As New Data.DataSet
        Dim Cm As New SqlCommand
        Dim Cx As New SqlConnection
        Dim Da As New SqlDataAdapter
        Try
            Sql.Append("SELECT ALU_CODIGO,ALU_NOME FROM TB_ALUNO ORDER BY ALU_NOME")
            Cx.ConnectionString = ConfigurationSettings.AppSettings("cStrconexao") & Session("Unidade")
            Cm.Connection = Cx
            Cm.CommandText = Sql.ToString
            Da.SelectCommand = Cm
            Da.Fill(Ds)
            h_dropaluno.DataSource = Ds
            h_dropaluno.DataBind()
            h_dropaluno.Items.Insert(0, New ListItem("************* Selecione o Aluno *****************", String.Empty))
        Finally
            Cx = Nothing
            Cm = Nothing
            Da = Nothing
            Ds = Nothing
        End Try
    End Sub
    Protected Sub povoar_alu_hist_imp()
        Dim Sql As New System.Text.StringBuilder
        Dim Ds As New Data.DataSet
        Dim Cm As New SqlCommand
        Dim Cx As New SqlConnection
        Dim Da As New SqlDataAdapter
        Try
            Sql.Append("SELECT ALU_CODIGO,ALU_NOME FROM TB_ALUNO ORDER BY ALU_NOME")
            Cx.ConnectionString = ConfigurationSettings.AppSettings("cStrconexao") & Session("Unidade")
            Cm.Connection = Cx
            Cm.CommandText = Sql.ToString
            Da.SelectCommand = Cm
            Da.Fill(Ds)
            Hit_dropaluno.DataSource = Ds
            Hit_dropaluno.DataBind()
            Hit_dropaluno.Items.Insert(0, New ListItem("************ Informe o Aluno **************", String.Empty))
        Finally
            Cx = Nothing
            Cm = Nothing
            Da = Nothing
            Ds = Nothing
        End Try
    End Sub

    Protected Sub povoar_professor_historico()
        Dim Sql As New System.Text.StringBuilder
        Dim Ds As New Data.DataSet
        Dim Cm As New SqlCommand
        Dim Cx As New SqlConnection
        Dim Da As New SqlDataAdapter
        Try
            Sql.Append("SELECT COUNT(A.PROF_CODIGO) AS NUMERO,A.PROF_CODIGO,B.PROF_NOME FROM TB_PROF_CURSO A,TB_PROFESSORES B WHERE A.PROF_CODIGO=B.PROF_CODIGO GROUP BY A.PROF_CODIGO,B.PROF_NOME")
            Cx.ConnectionString = ConfigurationSettings.AppSettings("cStrconexao") & Session("Unidade")
            Cm.Connection = Cx
            Cm.CommandText = Sql.ToString
            Da.SelectCommand = Cm
            Da.Fill(Ds)
            h_dropprofessor.DataSource = Ds
            h_dropprofessor.DataBind()
            h_dropprofessor.Items.Insert(0, New ListItem("*********** Selecione o Professor *************", String.Empty))
        Finally
            Cx = Nothing
            Cm = Nothing
            Da = Nothing
            Ds = Nothing
        End Try
    End Sub

    Protected Sub povoar_grid_historico()
        Dim Sql As New System.Text.StringBuilder
        Dim Ds As New Data.DataSet
        Dim Cm As New SqlCommand
        Dim Cx As New SqlConnection
        Dim Da As New SqlDataAdapter
        Try
            Sql.Append("SELECT DISTINCT A.DC_DISCIPLINA,B.DC_CODIGO,B.PROF_CODIGO,C.PROF_NOME,C.PROF_TITULACAO,D.HIS_CODIGO,D.HIS_CARGAHORA,D.HIS_FALTAS,D.HIS_FREQUENCIA,D.HIS_MEDIA FROM TB_DISCIPLINA A,TB_PROF_CURSO B, TB_PROFESSORES C, TB_HISTORICO D WHERE A.DC_CODIGO=D.DC_CODIGO AND B.PROF_CODIGO=C.PROF_CODIGO AND D.PC_CODIGO=B.PC_CODIGO ")
            Cx.ConnectionString = ConfigurationSettings.AppSettings("cStrconexao") & Session("Unidade")
            Cm.Connection = Cx
            Cm.CommandText = Sql.ToString
            Da.SelectCommand = Cm
            Da.Fill(Ds)
            DataGrid_historico.DataSource = Ds
            DataGrid_historico.DataBind()
        Finally
            Cx = Nothing
            Cm = Nothing
            Da = Nothing
            Ds = Nothing
        End Try
    End Sub

    'Fim das funções do formulário Histórico
    '****************************************************************************************************
    'Funções do cadastro de professor curso
    Protected Sub associar_prof_curso()
        With prof_curso
            .codigo = Gera_Codigoprof_curso()
            .curso = aspc_curso.SelectedValue
            .professor = aspc_professor.SelectedValue
            .disciplina = aspc_dropdisciplina.SelectedValue
        End With
    End Sub

    Protected Sub associar_prof_curso_alterar()
        With prof_curso
            .codigo = aspc_txtcod.Text
            .curso = aspc_curso.SelectedValue
            .professor = aspc_professor.SelectedValue
            .disciplina = aspc_dropdisciplina.SelectedValue
        End With
    End Sub

    Protected Sub novo_prof_curso()
        aspc_curso.Enabled = True
        aspc_professor.Enabled = True
        aspc_btncancela.Enabled = True
        aspc_dropdisciplina.Enabled = True
        aspc_btnsalvar.Enabled = True
        povoar_disciplina_professor()
        povoa_prof_curso()
        povoar_prof()
    End Sub

    Protected Sub lipar_prof_curso()
        aspc_curso.Enabled = False
        aspc_professor.Enabled = False
        aspc_dropdisciplina.Enabled = False
        aspc_btncancela.Enabled = False
        aspc_btnsalvar.Enabled = False
    End Sub
    Protected Sub povoar_disciplina_professor()
        Dim Sql As New System.Text.StringBuilder
        Dim Ds As New Data.DataSet
        Dim Cm As New SqlCommand
        Dim Cx As New SqlConnection
        Dim Da As New SqlDataAdapter
        Try
            Sql.Append("SELECT * FROM TB_DISCIPLINA")
            'Cx.ConnectionString = "server=marcos\marcos;database=c_certificado;Trusted_Connection=Yes"
            Cx.ConnectionString = ConfigurationSettings.AppSettings("cStrconexao") & Session("Unidade")
            Cm.Connection = Cx
            Cm.CommandText = Sql.ToString
            Da.SelectCommand = Cm
            Da.Fill(Ds)
            aspc_dropdisciplina.DataSource = Ds
            aspc_dropdisciplina.DataBind()
            aspc_dropdisciplina.Items.Insert(0, New ListItem("********** Selecione uma Disciplina *************", String.Empty))

        Finally
            Cx = Nothing
            Cm = Nothing
            Da = Nothing
            Ds = Nothing
        End Try
    End Sub

    Protected Sub povoa_prof_curso()
        Dim Sql As New System.Text.StringBuilder
        Dim Ds As New Data.DataSet
        Dim Cm As New SqlCommand
        Dim Cx As New SqlConnection
        Dim Da As New SqlDataAdapter
        Try
            Sql.Append("SELECT * FROM TB_CURSO")
            'Cx.ConnectionString = "server=marcos\marcos;database=c_certificado;Trusted_Connection=Yes"
            Cx.ConnectionString = ConfigurationSettings.AppSettings("cStrconexao") & Session("Unidade")
            Cm.Connection = Cx
            Cm.CommandText = Sql.ToString
            Da.SelectCommand = Cm
            Da.Fill(Ds)
            aspc_curso.DataSource = Ds
            aspc_curso.DataBind()
            aspc_curso.Items.Insert(0, New ListItem("************ Selecione o Curso ****************", String.Empty))
        Finally
            Cx = Nothing
            Cm = Nothing
            Da = Nothing
            Ds = Nothing
        End Try
    End Sub

    Protected Sub povoar_prof()
        Dim Sql As New System.Text.StringBuilder
        Dim Ds As New Data.DataSet
        Dim Cm As New SqlCommand
        Dim Cx As New SqlConnection
        Dim Da As New SqlDataAdapter
        Try
            Sql.Append("SELECT * FROM TB_PROFESSORES ORDER BY PROF_CODIGO")
            'Cx.ConnectionString = "server=marcos\marcos;database=c_certificado;Trusted_Connection=Yes"
            Cx.ConnectionString = ConfigurationSettings.AppSettings("cStrconexao") & Session("Unidade")
            Cm.Connection = Cx
            Cm.CommandText = Sql.ToString
            Da.SelectCommand = Cm
            Da.Fill(Ds)
            aspc_professor.DataSource = Ds
            aspc_professor.DataBind()
            aspc_professor.Items.Insert(0, New ListItem("********** Selecione um Professor *************", String.Empty))
        Finally
            Cx = Nothing
            Cm = Nothing
            Da = Nothing
            Ds = Nothing
        End Try
    End Sub

    Protected Sub povoar_datagrid_prof_curso()
        Dim Sql As New System.Text.StringBuilder
        Dim Ds As New Data.DataSet
        Dim Cm As New SqlCommand
        Dim Cx As New SqlConnection
        Dim Da As New SqlDataAdapter
        Try
            Sql.Append("SELECT DISTINCT A.PC_CODIGO,B.CUR_CURSO,C.PROF_NOME,D.DC_DISCIPLINA FROM TB_PROF_CURSO A,TB_CURSO B,TB_PROFESSORES C, TB_DISCIPLINA D WHERE A.CUR_CODIGO = B.CUR_CODIGO AND A.PROF_CODIGO = C.PROF_CODIGO AND A.DC_CODIGO=D.DC_CODIGO ")
            Cx.ConnectionString = ConfigurationSettings.AppSettings("cStrconexao") & Session("Unidade")
            Cm.Connection = Cx
            Cm.CommandText = Sql.ToString
            Da.SelectCommand = Cm
            Da.Fill(Ds)
            DataGrid_prof_curso.DataSource = Ds
            DataGrid_prof_curso.DataBind()
        Finally
            Cx = Nothing
            Cm = Nothing
            Da = Nothing
            Ds = Nothing
        End Try

    End Sub

    'Fim da função cadastro professor curso
    '************************************************************************************************************
    'Função cadastro professor disciplina
    '***********************************************************************************************************
    Protected Sub Povoar_aluno_certificado()
        Dim Sql As New System.Text.StringBuilder
        Dim Ds As New Data.DataSet
        Dim Cm As New SqlCommand
        Dim Cx As New SqlConnection
        Dim Da As New SqlDataAdapter
        Try
            Sql.Append("SELECT * FROM TB_ALUNO")
            'Cx.ConnectionString = "server=marcos\marcos;database=c_certificado;Trusted_Connection=Yes"
            Cx.ConnectionString = ConfigurationSettings.AppSettings("cStrconexao") & Session("Unidade")
            Cm.Connection = Cx
            Cm.CommandText = Sql.ToString
            Da.SelectCommand = Cm
            Da.Fill(Ds)
            cf_Dropaluno.DataSource = Ds
            cf_Dropaluno.DataBind()
            cf_Dropaluno.Items.Insert(0, New ListItem("************ Selecione o Aluno ***************", String.Empty))
        Finally
            Cx = Nothing
            Cm = Nothing
            Da = Nothing
            Ds = Nothing
        End Try
    End Sub

    Protected Sub Povoar_resolucao_certificado()
        Dim Sql As New System.Text.StringBuilder
        Dim Ds As New Data.DataSet
        Dim Cm As New SqlCommand
        Dim Cx As New SqlConnection
        Dim Da As New SqlDataAdapter
        Try
            Sql.Append("SELECT * FROM TB_CURSO")
            'Cx.ConnectionString = "server=marcos\marcos;database=c_certificado;Trusted_Connection=Yes"
            Cx.ConnectionString = ConfigurationSettings.AppSettings("cStrconexao") & Session("Unidade")
            Cm.Connection = Cx
            Cm.CommandText = Sql.ToString
            Da.SelectCommand = Cm
            Da.Fill(Ds)
            cf_Dropcurso.DataSource = Ds
            cf_Dropcurso.DataBind()
            cf_Dropcurso.Items.Insert(0, New ListItem("************* Selecione o Curso *************", String.Empty))

        Finally
            Cx = Nothing
            Cm = Nothing
            Da = Nothing
            Ds = Nothing
        End Try

    End Sub

    Protected Sub novo_certificado()
        cf_Dropaluno.Enabled = True
        ' cf_DropDcurso.Enabled = True
        cf_Dropcurso.Enabled = True
        cf_titulomonografia.Enabled = True
        cf_txtrealizacao.Enabled = True
        'cf_DropDownportaria.Enabled = True
        cf_btncancelar.Enabled = True
        cf_btnsalvar.Enabled = True
        Povoar_aluno_certificado()
        'povoar_curso_certificado()
        Povoar_resolucao_certificado()
        'Povoar_portaria_certificado()
    End Sub

    Protected Sub limpar_certificado_frente()
        cf_Dropaluno.Enabled = False
        'cf_DropDcurso.Enabled = False
        cf_Dropcurso.Enabled = False
        cf_titulomonografia.Text = ""
        cf_titulomonografia.Enabled = False
        cf_txtrealizacao.Text = ""
        cf_txtrealizacao.Enabled = False
        ' cf_DropDownportaria.Enabled = False
        cf_btncancelar.Enabled = False
        cf_btnsalvar.Enabled = False
        povoardatagrid_certificado_frente()
    End Sub

    Protected Sub povoardatagrid_certificado_frente()
        Dim Sql As New System.Text.StringBuilder
        Dim Ds As New Data.DataSet
        Dim Cm As New SqlCommand
        Dim Cx As New SqlConnection
        Dim Da As New SqlDataAdapter
        Try
            Sql.Append("SELECT A.CER_CODIGO,A.CER_REALIZACAODOCURSO,B.ALU_NOME,C.CUR_CURSO FROM TB_CERTIFICADO A,TB_ALUNO B,TB_CURSO C WHERE(A.ALU_CODIGO = B.ALU_CODIGO And A.CUR_CODIGO = C.CUR_CODIGO)")
            'Sql.Append("SELECT * FROM TB_CERTIFICADO")
            'Cx.ConnectionString = "server=marcos\marcos;database=c_certificado;Trusted_Connection=Yes"
            Cx.ConnectionString = ConfigurationSettings.AppSettings("cStrconexao") & Session("Unidade")
            Cm.Connection = Cx
            Cm.CommandText = Sql.ToString
            Da.SelectCommand = Cm
            Da.Fill(Ds)
            DataGridCfrente.DataSource = Ds
            DataGridCfrente.DataBind()
        Finally
            Cx = Nothing
            Cm = Nothing
            Da = Nothing
            Ds = Nothing
        End Try
    End Sub

    Protected Sub associar_certificado_frente()
        With CertificadoF
            .codigo = Gera_cod_certifi()
            .realisacao = cf_txtrealizacao.Text
            .monografia = cf_titulomonografia.Text
            .codigoaluno = cf_Dropaluno.SelectedValue
            .cursocodigo = cf_Dropcurso.SelectedValue
            '.resolucao = cf_DropDresolucao.SelectedValue
            '.portaria = cf_DropDownportaria.SelectedValue
        End With
    End Sub

    Protected Sub associar_alterar_frente()
        With CertificadoF
            .codigo = txtcod_cert_frent.Text
            .realisacao = cf_txtrealizacao.Text
            .monografia = cf_titulomonografia.Text
            .codigoaluno = cf_Dropaluno.SelectedValue
            .cursocodigo = cf_Dropcurso.SelectedValue
            '.resolucao = cf_DropDresolucao.SelectedValue
            '.portaria = cf_DropDownportaria.SelectedValue
        End With
    End Sub

    Protected Sub alterar_certificado_frente()
        With CertificadoF
            .codigo = txtcod_cert_frent.Text
            .realisacao = cf_txtrealizacao.Text
            .monografia = cf_titulomonografia.Text
            .codigoaluno = cf_Dropaluno.SelectedValue
            '.cursocodigo = cf_DropDcurso.SelectedValue
            '.resolucao = cf_DropDresolucao.SelectedValue
            '.portaria = cf_DropDownportaria.SelectedValue
        End With
    End Sub

    Protected Sub associarprofessor()
        With Professor
            .codigo = Gera_Codigo_professor()
            .nome = p_txtprofessor.Text
            .formacao = p_txtformacao.Text
            .atuacao = p_txtatuacao.Text
            .titulacao = p_txttitulacao.SelectedItem.Text
            .ingresso = p_txtingresso.Text
            .unidade = p_dropunidade.SelectedValue
        End With
    End Sub

    Protected Sub Associar_curso()
        With Curso
            .codigo = Gera_Codigocurso()
            .curso = c_txtcurso.Text
            .resolucao = c_DropDresolucao.SelectedValue
            .classificacao = c_Dropclassificacao.SelectedValue
            .portaria = c_DropDownportaria.SelectedValue
            .codigodocurso = cc_txtcodigodocurso.Text
        End With
    End Sub

    Protected Sub Associar_curso_alterar()
        With Curso
            .codigo = Textocd_curso.Text
            .curso = c_txtcurso.Text
            .resolucao = c_DropDresolucao.SelectedValue
            .classificacao = c_Dropclassificacao.SelectedValue
            .portaria = c_DropDownportaria.SelectedValue
            .codigodocurso = cc_txtcodigodocurso.Text
        End With
    End Sub

    Protected Sub povoar_modulo()
        Dim Sql As New System.Text.StringBuilder
        Dim Ds As New Data.DataSet
        Dim Cm As New SqlCommand
        Dim Cx As New SqlConnection
        Dim Da As New SqlDataAdapter
        Try
            Sql.Append("SELECT * FROM TB_MODULO ORDER BY MOD_CODIGO")
            Cx.ConnectionString = ConfigurationSettings.AppSettings("cStrconexao") & Session("Unidade")
            Cm.Connection = Cx
            Cm.CommandText = Sql.ToString
            Da.SelectCommand = Cm
            Da.Fill(Ds)
            d_dropmodulo.DataSource = Ds
            d_dropmodulo.DataBind()
            d_dropmodulo.Items.Insert(0, New ListItem("*** Selecione o Módulo ****", String.Empty))
        Finally
            Cx = Nothing
            Cm = Nothing
            Da = Nothing
            Ds = Nothing
        End Try
    End Sub

    Protected Sub Povoar_resolucao()
        Dim Sql As New System.Text.StringBuilder
        Dim Ds As New Data.DataSet
        Dim Cm As New SqlCommand
        Dim Cx As New SqlConnection
        Dim Da As New SqlDataAdapter
        Try
            Sql.Append("SELECT * FROM TB_RESOLUCAO ORDER BY RES_CODIGO")
            'Cx.ConnectionString = "server=marcos\marcos;database=c_certificado;Trusted_Connection=Yes"
            Cx.ConnectionString = ConfigurationSettings.AppSettings("cStrconexao") & Session("Unidade")
            Cm.Connection = Cx
            Cm.CommandText = Sql.ToString
            Da.SelectCommand = Cm
            Da.Fill(Ds)
            c_DropDresolucao.DataSource = Ds
            c_DropDresolucao.DataBind()
            c_DropDresolucao.Items.Insert(0, New ListItem("*********** Selecione ************", String.Empty))

        Finally
            Cx = Nothing
            Cm = Nothing
            Da = Nothing
            Ds = Nothing
        End Try
    End Sub

    Protected Sub Povoar_cidades()
        Dim Sql As New System.Text.StringBuilder
        Dim Ds As New Data.DataSet
        Dim Cm As New SqlCommand
        Dim Cx As New SqlConnection
        Dim Da As New SqlDataAdapter
        Try
            Sql.Append("SELECT * FROM TB_CIDADE")
            'Cx.ConnectionString = "server=marcos\marcos;database=c_certificado;Trusted_Connection=Yes"
            Cx.ConnectionString = ConfigurationSettings.AppSettings("cStrconexao") & Session("Unidade")
            Cm.Connection = Cx
            Cm.CommandText = Sql.ToString
            Da.SelectCommand = Cm
            Da.Fill(Ds)
            a_DropDowncidade.DataSource = Ds
            a_DropDowncidade.DataBind()
            a_DropDowncidadeinst.DataSource = Ds
            a_DropDowncidadeinst.DataBind()
        Finally
            Cx = Nothing
            Cm = Nothing
            Da = Nothing
            Ds = Nothing
        End Try
    End Sub

    Protected Sub Povoar_Portaria()
        Dim Sql As New System.Text.StringBuilder
        Dim Ds As New Data.DataSet
        Dim Cm As New SqlCommand
        Dim Cx As New SqlConnection
        Dim Da As New SqlDataAdapter
        Try
            Sql.Append("SELECT * FROM TB_PORTARIA ORDER BY PO_CODIGO")
            'Cx.ConnectionString = "server=marcos\marcos;database=c_certificado;Trusted_Connection=Yes"
            Cx.ConnectionString = ConfigurationSettings.AppSettings("cStrconexao") & Session("Unidade")
            Cm.Connection = Cx
            Cm.CommandText = Sql.ToString
            Da.SelectCommand = Cm
            Da.Fill(Ds)
            c_DropDownportaria.DataSource = Ds
            c_DropDownportaria.DataBind()
            c_DropDownportaria.Items.Insert(0, New ListItem("********* Selecione **********", String.Empty))
        Finally
            Cx = Nothing
            Cm = Nothing
            Da = Nothing
            Ds = Nothing
        End Try
    End Sub

    Protected Sub Povoar_classificacao()
        Dim Sql As New System.Text.StringBuilder
        Dim Ds As New Data.DataSet
        Dim Cm As New SqlCommand
        Dim Cx As New SqlConnection
        Dim Da As New SqlDataAdapter
        Try
            Sql.Append("SELECT * FROM TB_CLASSIFICACAO ORDER BY CLAS_CODIGO")
            'Cx.ConnectionString = "server=marcos\marcos;database=c_certificado;Trusted_Connection=Yes"
            Cx.ConnectionString = ConfigurationSettings.AppSettings("cStrconexao") & Session("Unidade")
            Cm.Connection = Cx
            Cm.CommandText = Sql.ToString
            Da.SelectCommand = Cm
            Da.Fill(Ds)
            c_Dropclassificacao.DataSource = Ds
            c_Dropclassificacao.DataBind()
            c_Dropclassificacao.Items.Insert(0, New ListItem("******* Selecione ********", String.Empty))
        Finally
            Cx = Nothing
            Cm = Nothing
            Da = Nothing
            Ds = Nothing
        End Try
    End Sub

    Protected Sub associar_disciplina()
        With Disciplina
            .codigo = Gera_Codigo_disci()
            .codigodisciplina = d_txtcoddisciplina.Text & "0" & Gera_Codigo_disci()
            .disciplina = d_txtdisciplina.Text
            .horapratica = d_txtchpratica.Text
            .horateorica = d_txtchteorica.Text
            .creditos = d_txtcredito.Text
            .vigencia = d_txtvigencia.Text
            .modulo = d_dropmodulo.SelectedValue
        End With
    End Sub

    Protected Sub associar_altera_disciplina()
        With Disciplina
            .codigo = txtdsci_cod.Text
            .codigodisciplina = d_txtcoddisciplina.Text
            .disciplina = d_txtdisciplina.Text
            .horapratica = d_txtchpratica.Text
            .horateorica = d_txtchteorica.Text
            .creditos = d_txtcredito.Text
            .vigencia = d_txtvigencia.Text
            .modulo = d_dropmodulo.SelectedValue
        End With
    End Sub

    Protected Sub associarProfessor_alterar()
        With Professor
            .codigo = txtcodigoprof.Text
            .nome = p_txtprofessor.Text
            .formacao = p_txtformacao.Text
            .atuacao = p_txtatuacao.Text
            .titulacao = p_txttitulacao.SelectedItem.Text
            .ingresso = p_txtingresso.Text
            .unidade = p_dropunidade.SelectedValue
        End With
    End Sub

    Protected Sub associar_alunos_auterar()
        With Alunos
            ._codigo = txtcodigoalu.Text
            .aluno = a_txtaluno.Text
            .numero = a_txtn.Text
            ._complemento = a_txtcompl.Text
            .ano = a_txtano.Text
            .anotitulacao = a_txtanotitulacao.Text
            .atuacao = a_txtareadeatuacao.Text
            ._bairro = a_txtbairro.Text
            .bairro_inst = a_txtbairroinst.Text
            .cargo_inst = a_txtcargo.Text
            .celular = a_txtcelular.Text
            .cep = a_txtcep.Text
            .cep_inst = a_txtcepinst.Text
            .cidade = a_DropDowncidade.Text
            .cidade_inst = a_DropDowncidadeinst.Text
            .comlemento_inst = a_txtcompinst.Text
            .cpf = a_txtcpf.Text
            .curso = a_DropDowncurso.SelectedValue
            .diploma = a_txtD.Text
            .email = a_txtemail.Text
            .email_inst = a_txtemailinst.Text
            .endereco = a_txtendereco.Text
            .endereco_inst = a_txtenderecoinst.Text
            .fax = a_txtfax.Text
            .fax_inst = a_txtfaxinst.Text
            .fone1 = a_txtfone1.Text
            .fone1_inst = a_txtfone1inst.Text
            .fone2 = a_txtfone2.Text
            .fone2_inst = a_txtfone2inst.Text
            .formacao = a_txtformacao.Text
            .foto = a_txtF.Text
            .funcao_inst = a_txtformacaoinst.Text
            .historico = a_txtH.Text
            .identificacao = a_txtidentificacao.Text
            .Inst_origem = a_txtinstorigem.Text
            .instituicao = a_txtinstituicao.Text
            .lacal = a_txtlocal.Text
            .nascimento = a_txtnascimento.Text
            .naturalidade = a_txtnaturalidade.Text
            .numero_inst = a_txtninst.Text
            .documento = a_DropDowndocumento.SelectedValue
            .orgaemissor = a_txtemissor.Text
            .periodo = a_txtinicio.Text
            .termino = a_txtfim.Text
            .rg = a_txtidentidade.Text
            .titulacaomaxima = a_txttitulacaomaxima.Text
            .turno = a_DropDownturno.Text
            .uf = a_DropDownuf.SelectedValue
            .uf_inst = a_DropDownufinst.SelectedValue
        End With
    End Sub

    Protected Sub verificardocumento()
        If a_DropDowndocumento.SelectedValue = "Completo" Then
            a_CheckBoxfoto.Checked = True
            a_txtF.Text = "S"
            a_CheckBoxhistorico.Checked = True
            a_txtH.Text = "S"
            a_CheckBoxdiplomainst.Checked = True
            a_txtD.Text = "S"
        Else
            If a_DropDowndocumento.SelectedValue = "Incompleto" Then
                a_CheckBoxfoto.Checked = False
                a_txtF.Text = "N"
                a_CheckBoxhistorico.Checked = False
                a_txtH.Text = "N"
                a_CheckBoxdiplomainst.Checked = False
                a_txtD.Text = "N"
            End If
        End If
    End Sub

    Protected Sub povoa_cidade_inst()
        Dim Ds As New Data.DataSet
        Try

        Catch ex As Exception

        End Try
        Alunos.receberconexao = Session("Unidade")
        Ds = Alunos.Povoar_cidades("cd_estado ='" & a_DropDownufinst.SelectedValue & "'")
        a_DropDowncidadeinst.DataSource = Ds
        a_DropDowncidadeinst.DataBind()
        a_DropDowncidadeinst.Items.Insert(0, New ListItem("*********** Selecione a Cidade ***********", String.Empty))
    End Sub

    Protected Sub novo_professor()
        p_txtatuacao.Enabled = True
        p_txtformacao.Enabled = True
        p_txtingresso.Enabled = True
        p_txtprofessor.Enabled = True
        p_txttitulacao.Enabled = True
        p_btncancelar.Enabled = True
        p_btnsalvar.Enabled = True
        povoar_unidade()
        p_dropunidade.Enabled = True
        p_txtprofessor.Focus()
    End Sub

    Protected Sub novaDisciplina()
        d_txtchpratica.Enabled = True
        d_txtcoddisciplina.Enabled = True
        d_txtdisciplina.Enabled = True
        d_txtchpratica.Enabled = True
        d_txtchteorica.Enabled = True
        d_txtcredito.Enabled = True
        d_txtvigencia.Enabled = True
        d_dropmodulo.Enabled = True
        d_btncancelar.Enabled = True
        d_btnsalvar.Enabled = True
        povoar_modulo()
    End Sub

    Protected Sub novacurso()
        c_Dropclassificacao.Enabled = True
        cc_txtcodigodocurso.Enabled = True
        c_DropDresolucao.Enabled = True
        c_DropDownportaria.Enabled = True
        c_txtcurso.Enabled = True
        c_btncancelar.Enabled = True
        c_btnsalvar.Enabled = True
        Povoar_classificacao()
        Povoar_Portaria()
        Povoar_resolucao()
    End Sub

    Protected Sub liparprofessor()
        '**********************************
        p_txtatuacao.Text = ""
        p_txtformacao.Text = ""
        p_txtingresso.Text = ""
        p_txtprofessor.Text = ""
        '***********************************
        p_txtatuacao.Enabled = False
        p_txtformacao.Enabled = False
        p_txtingresso.Enabled = False
        p_txtprofessor.Enabled = False
        p_txttitulacao.Enabled = False
        p_btncancelar.Enabled = False
        p_dropunidade.Enabled = False
        p_btnsalvar.Enabled = False
    End Sub

    Protected Sub limpar_curso()
        c_txtcurso.Text = ""
        cc_txtcodigodocurso.Text = ""
        c_Dropclassificacao.Enabled = False
        c_DropDresolucao.Enabled = False
        c_DropDownportaria.Enabled = False
        cc_txtcodigodocurso.Enabled = False
        c_btnsalvar.Enabled = False
        c_btncancelar.Enabled = False
        c_txtcurso.Enabled = False
        Povoargridcurso()
    End Sub

    Protected Sub limpar_disciplina()
        d_txtchteorica.Text = ""
        d_txtchpratica.Text = ""
        d_txtcoddisciplina.Text = ""
        d_txtcredito.Text = ""
        d_txtvigencia.Text = ""
        d_txtdisciplina.Text = ""
        d_txtchpratica.Enabled = False
        d_txtcoddisciplina.Enabled = False
        d_txtchpratica.Enabled = False
        d_txtchteorica.Enabled = False
        d_txtcredito.Enabled = False
        d_txtvigencia.Enabled = False
        d_txtdisciplina.Enabled = False
        d_dropmodulo.Enabled = False
        d_btncancelar.Enabled = False
        d_btnsalvar.Enabled = False
    End Sub

    Protected Sub Povoar_cidade_alu()
        Dim Ds As New Data.DataSet
        Try

        Catch ex As Exception

        End Try
        Alunos.receberconexao = Session("Unidade")
        Ds = Alunos.Povoar_cidades("cd_estado ='" & a_DropDownuf.SelectedValue & "'")
        a_DropDowncidade.DataSource = Ds
        a_DropDowncidade.DataBind()
        a_DropDowncidade.Items.Insert(0, New ListItem("********** Selecione a Cidade ************ ", String.Empty))
    End Sub

    Protected Sub limpardezativa()
        a_txtaluno.Text = ""
        a_txtano.Text = ""
        a_txtanotitulacao.Text = ""
        a_txtbairro.Text = ""
        a_txtbairroinst.Text = ""
        a_txtcargo.Text = ""
        a_txtcelular.Text = ""
        a_txtcep.Text = ""
        a_txtcepinst.Text = ""
        a_txtcompinst.Text = ""
        a_txtcompl.Text = ""
        a_txtcpf.Text = ""
        a_txtemail.Text = ""
        a_txtemailinst.Text = ""
        a_txtemissor.Text = ""
        a_txtendereco.Text = ""
        a_txtenderecoinst.Text = ""
        a_txtfax.Text = ""
        a_txtfaxinst.Text = ""
        a_txtfim.Text = ""
        a_txtfone1.Text = ""
        a_txtfone1inst.Text = ""
        a_txtfone2.Text = ""
        a_txtfone2inst.Text = ""
        a_txtformacao.Text = ""
        a_txtformacaoinst.Text = ""
        a_txtidentidade.Text = ""
        a_txtidentificacao.Text = ""
        a_txtinicio.Text = ""
        a_txtinstituicao.Text = ""
        a_txtinstorigem.Text = ""
        a_txtlocal.Text = ""
        a_txtn.Text = ""
        a_txtnascimento.Text = ""
        a_txtnaturalidade.Text = ""
        a_txtninst.Text = ""
        a_txttitulacaomaxima.Text = ""
        a_txtareadeatuacao.Text = ""
        '***********************************
        alu_btncancelar.Enabled = False
        Alu_btnsalvar.Enabled = False
        '**********************************
        a_CheckBoxdiplomainst.Enabled = False
        a_CheckBoxfoto.Enabled = False
        a_CheckBoxhistorico.Enabled = False
        a_DropDowncidade.Enabled = False
        a_DropDowncidadeinst.Enabled = False
        a_DropDowncurso.Enabled = False
        a_DropDowndocumento.Enabled = False
        a_DropDownturno.Enabled = False
        a_DropDownuf.Enabled = False
        a_DropDownufinst.Enabled = False
        a_txtaluno.Enabled = False
        a_txtano.Enabled = False
        a_txtanotitulacao.Enabled = False
        a_txtbairro.Enabled = False
        a_txtbairroinst.Enabled = False
        a_txtcargo.Enabled = False
        a_txtcelular.Enabled = False
        a_txtcep.Enabled = False
        a_txtcepinst.Enabled = False
        a_txtcompinst.Enabled = False
        a_txtcompl.Enabled = False
        a_txtcpf.Enabled = False
        a_txtemail.Enabled = False
        a_txtemailinst.Enabled = False
        a_txtemissor.Enabled = False
        a_txtendereco.Enabled = False
        a_txtenderecoinst.Enabled = False
        a_txtfax.Enabled = False
        a_txtfaxinst.Enabled = False
        a_txtfim.Enabled = False
        a_txtfone1.Enabled = False
        a_txtfone1inst.Enabled = False
        a_txtfone2.Enabled = False
        a_txtfone2inst.Enabled = False
        a_txtformacao.Enabled = False
        a_txtformacaoinst.Enabled = False
        a_txtidentidade.Enabled = False
        a_txtidentificacao.Enabled = False
        a_txtinicio.Enabled = False
        a_txtinstituicao.Enabled = False
        a_txtinstorigem.Enabled = False
        a_txtlocal.Enabled = False
        a_txtn.Enabled = False
        a_txtnascimento.Enabled = False
        a_txtnaturalidade.Enabled = False
        a_txtninst.Enabled = False
        a_txttitulacaomaxima.Enabled = False
        a_txtareadeatuacao.Enabled = False
        a_DropDowncurso.Focus()
        '***********************************
    End Sub

    Protected Sub novoregistro()
        a_CheckBoxdiplomainst.Enabled = True
        a_CheckBoxfoto.Enabled = True
        a_CheckBoxhistorico.Enabled = True
        a_DropDowncidade.Enabled = True
        a_DropDowncidadeinst.Enabled = True
        a_DropDowncurso.Enabled = True
        a_DropDowndocumento.Enabled = True
        a_DropDownturno.Enabled = True
        a_DropDownuf.Enabled = True
        a_DropDownufinst.Enabled = True
        a_txtaluno.Enabled = True
        a_txtano.Enabled = True
        a_txtanotitulacao.Enabled = True
        a_txtbairro.Enabled = True
        a_txtbairroinst.Enabled = True
        a_txtcargo.Enabled = True
        a_txtcelular.Enabled = True
        a_txtcep.Enabled = True
        a_txtcepinst.Enabled = True
        a_txtcompinst.Enabled = True
        a_txtcompl.Enabled = True
        a_txtcpf.Enabled = True
        a_txtemail.Enabled = True
        a_txtemailinst.Enabled = True
        a_txtemissor.Enabled = True
        a_txtendereco.Enabled = True
        a_txtenderecoinst.Enabled = True
        a_txtfax.Enabled = True
        a_txtfaxinst.Enabled = True
        a_txtfim.Enabled = True
        a_txtfone1.Enabled = True
        a_txtfone1inst.Enabled = True
        a_txtfone2.Enabled = True
        a_txtfone2inst.Enabled = True
        a_txtformacao.Enabled = True
        a_txtformacaoinst.Enabled = True
        a_txtidentidade.Enabled = True
        a_txtidentificacao.Enabled = True
        a_txtinicio.Enabled = True
        a_txtinstituicao.Enabled = True
        a_txtinstorigem.Enabled = True
        a_txtlocal.Enabled = True
        a_txtn.Enabled = True
        a_txtnascimento.Enabled = True
        a_txtnaturalidade.Enabled = True
        a_txtninst.Enabled = True
        a_txttitulacaomaxima.Enabled = True
        a_txtareadeatuacao.Enabled = True
        Alu_btnsalvar.Enabled = True
        alu_btncancelar.Enabled = True
        povoacurso_()
    End Sub

    Protected Sub povoacurso_()
        Dim Sql As New System.Text.StringBuilder
        Dim Ds As New Data.DataSet
        Dim Cm As New SqlCommand
        Dim Cx As New SqlConnection
        Dim Da As New SqlDataAdapter
        Try
            Sql.Append("SELECT * FROM TB_CURSO")
            'Cx.ConnectionString = "server=marcos\marcos;database=c_certificado;Trusted_Connection=Yes"
            Cx.ConnectionString = ConfigurationSettings.AppSettings("cStrconexao") & Session("Unidade")
            Cm.Connection = Cx
            Cm.CommandText = Sql.ToString
            Da.SelectCommand = Cm
            Da.Fill(Ds)
            a_DropDowncurso.DataSource = Ds
            a_DropDowncurso.DataBind()
            a_DropDowncurso.Items.Insert(0, New ListItem("******** Selecione o Curso *********", String.Empty))
            'dro_curso.Items.Insert(0, New ListItem("********** Selecione um registro *************", String.Empty))
        Finally
            Cx = Nothing
            Cm = Nothing
            Da = Nothing
            Ds = Nothing
        End Try
    End Sub

    Protected Sub povoar_unidade()
        Dim sql As New System.Text.StringBuilder
        Dim ds As New Data.DataSet
        Dim cm As New SqlCommand
        Dim cx As New SqlConnection
        Dim da As New SqlDataAdapter
        Try
            sql.Append("SELECT * FROM TB_UNIDADE ")
            cx.ConnectionString = ConfigurationSettings.AppSettings("cStrconexao") & Session("Unidade")
            cm.Connection = cx
            cm.CommandText = sql.ToString
            da.SelectCommand = cm
            da.Fill(ds)
            p_dropunidade.DataSource = ds
            p_dropunidade.DataBind()
            p_dropunidade.Items.Insert(0, New ListItem("************** Selecione a Unidade *****************", String.Empty))
        Finally
            cx = Nothing
            cm = Nothing
            ds = Nothing
            da = Nothing
        End Try
    End Sub

    Protected Sub povoar_gridDisciplina()
        Dim Sql As New System.Text.StringBuilder
        Dim Ds As New Data.DataSet
        Dim Cm As New SqlCommand
        Dim Cx As New SqlConnection
        Dim Da As New SqlDataAdapter
        Try
            Sql.Append("SELECT A.MOD_CODIGO,A.DC_CODIGO,A.DC_CODDISCIPLINA,A.DC_DISCIPLINA,A.DC_CHTEORICA,A.DC_CHPRATICA,A.DC_CREDITO,A.DC_VIGENCIA,B.MOD_MODULO FROM TB_DISCIPLINA A, TB_MODULO B WHERE A.MOD_CODIGO=B.MOD_CODIGO ORDER BY dc_CODIGO")
            'Cx.ConnectionString = "server=marcos\marcos;database=c_certificado;Trusted_Connection=Yes"
            Cx.ConnectionString = ConfigurationSettings.AppSettings("cStrconexao") & Session("Unidade")
            Cm.Connection = Cx
            Cm.CommandText = Sql.ToString
            Da.SelectCommand = Cm
            Da.Fill(Ds)
            DataGrid_disciplina.DataSource = Ds
            DataGrid_disciplina.DataBind()
        Finally
            Cx = Nothing
            Cm = Nothing
            Da = Nothing
            Ds = Nothing
        End Try
    End Sub

    Protected Sub povoar_grid_professor()
        Dim Sql As New System.Text.StringBuilder
        Dim Ds As New Data.DataSet
        Dim Cm As New SqlCommand
        Dim Cx As New SqlConnection
        Dim Da As New SqlDataAdapter
        Try
            Sql.Append("SELECT * FROM TB_PROFESSORES ORDER BY PROF_CODIGO")
            'Cx.ConnectionString = "server=marcos\marcos;database=c_certificado;Trusted_Connection=Yes"
            Cx.ConnectionString = ConfigurationSettings.AppSettings("cStrconexao") & Session("Unidade")
            Cm.Connection = Cx
            Cm.CommandText = Sql.ToString
            Da.SelectCommand = Cm
            Da.Fill(Ds)
            DataGridprofessor.DataSource = Ds
            DataGridprofessor.DataBind()
        Finally
            Cx = Nothing
            Cm = Nothing
            Da = Nothing
            Ds = Nothing
        End Try
    End Sub

    Protected Sub Povoargridcurso()
        Dim Sql As New System.Text.StringBuilder
        Dim Ds As New Data.DataSet
        Dim Cm As New SqlCommand
        Dim Cx As New SqlConnection
        Dim Da As New SqlDataAdapter
        Try
            Sql.Append("SELECT A.CUR_CODCURSO,A.CUR_CODIGO,A.CUR_CURSO,B.RES_RESOLUCAO,C.CLAS_CLASSIFICACAO,D.PO_PORTARIA FROM TB_CURSO A,TB_RESOLUCAO B,TB_CLASSIFICACAO C,TB_PORTARIA D WHERE A.RES_CODIGO=B.RES_CODIGO AND A.CLAS_CODIGO=C.CLAS_CODIGO AND A.PO_CODIGO=D.PO_CODIGO ORDER BY CUR_CODIGO")
            'Cx.ConnectionString = "server=marcos\marcos;database=c_certificado;Trusted_Connection=Yes"
            Cx.ConnectionString = ConfigurationSettings.AppSettings("cStrconexao") & Session("Unidade")
            Cm.Connection = Cx
            Cm.CommandText = Sql.ToString
            Da.SelectCommand = Cm
            Da.Fill(Ds)
            DataGrid_curso.DataSource = Ds
            DataGrid_curso.DataBind()
        Finally
            Cx = Nothing
            Cm = Nothing
            Da = Nothing
            Ds = Nothing
        End Try
    End Sub

    Protected Sub povoar_curso_diario()
        Dim Sql As New System.Text.StringBuilder
        Dim Ds As New Data.DataSet
        Dim Cm As New SqlCommand
        Dim Cx As New SqlConnection
        Dim Da As New SqlDataAdapter
        Try
            Sql.Append("SELECT * FROM TB_CURSO ORDER BY CUR_CODIGO")
            'Cx.ConnectionString = "server=marcos\marcos;database=c_certificado;Trusted_Connection=Yes"
            Cx.ConnectionString = ConfigurationSettings.AppSettings("cStrconexao") & Session("Unidade")
            Cm.Connection = Cx
            Cm.CommandText = Sql.ToString
            Da.SelectCommand = Cm
            Da.Fill(Ds)
            dro_curso.DataSource = Ds
            dro_curso.DataBind()
            dro_curso.Items.Insert(0, New ListItem("********** Selecione um registro *************", String.Empty))
        Finally
            Cx = Nothing
            Cm = Nothing
            Da = Nothing
            Ds = Nothing
        End Try
    End Sub

    Protected Sub povoaalunos()
        Dim Sql As New System.Text.StringBuilder
        Dim Ds As New Data.DataSet
        Dim Cm As New SqlCommand
        Dim Cx As New SqlConnection
        Dim Da As New SqlDataAdapter
        Try
            Sql.Append("SELECT * FROM TB_ALUNO ORDER BY ALU_CODIGO")
            'Cx.ConnectionString = "server=marcos\marcos;database=c_certificado;Trusted_Connection=Yes"
            Cx.ConnectionString = ConfigurationSettings.AppSettings("cStrconexao") & Session("Unidade")
            Cm.Connection = Cx
            Cm.CommandText = Sql.ToString
            Da.SelectCommand = Cm
            Da.Fill(Ds)
            DataGridaluno.DataSource = Ds
            DataGridaluno.DataBind()
        Finally
            Cx = Nothing
            Cm = Nothing
            Da = Nothing
            Ds = Nothing
        End Try
    End Sub

    Private Sub associar_alunos()
        With Alunos
            '._codigo = GeraCodigoaluno()
            '.aluno =  a_txtaluno.Text))
            '.numero = Server.HtmlEncode(Trim(a_txtn.Text))
            '._complemento = Server.HtmlEncode(Trim(a_txtcompl.Text))
            '.ano = Server.HtmlEncode(Trim(a_txtano.Text))
            '.anotitulacao = Server.HtmlEncode(Trim(a_txtanotitulacao.Text))
            '.atuacao = Server.HtmlEncode(Trim(a_txtareadeatuacao.Text))
            '._bairro = Server.HtmlEncode(Trim(a_txtbairro.Text))
            '.bairro_inst = Server.HtmlEncode(Trim(a_txtbairroinst.Text))
            '.cargo_inst = Server.HtmlEncode(Trim(a_txtcargo.Text))
            '.celular = Server.HtmlEncode(Trim(a_txtcelular.Text))
            '.cep = Server.HtmlEncode(Trim(a_txtcep.Text))
            '.cep_inst = Server.HtmlEncode(Trim(a_txtcepinst.Text))
            '.cidade = Server.HtmlEncode(Trim(a_DropDowncidade.Text))
            '.cidade_inst = Server.HtmlEncode(Trim(a_DropDowncidadeinst.Text))
            '.comlemento_inst = Server.HtmlEncode(Trim(a_txtcompinst.Text))
            '.cpf = Server.HtmlEncode(Trim(a_txtcpf.Text))
            '.curso = a_DropDowncurso.SelectedValue
            '.diploma = Server.HtmlEncode(Trim(a_txtD.Text))
            '.email = Server.HtmlEncode(Trim(a_txtemail.Text))
            '.email_inst = Server.HtmlEncode(Trim(a_txtemailinst.Text))
            '.endereco = Server.HtmlEncode(Trim(a_txtendereco.Text))
            '.endereco_inst = Server.HtmlEncode(Trim(a_txtenderecoinst.Text))
            '.fax = Server.HtmlEncode(Trim(a_txtfax.Text))
            '.fax_inst = Server.HtmlEncode(Trim(a_txtfaxinst.Text))
            '.fone1 = Server.HtmlEncode(Trim(a_txtfone1.Text))
            '.fone1_inst = Server.HtmlEncode(Trim(a_txtfone1inst.Text))
            '.fone2 = Server.HtmlEncode(Trim(a_txtfone2.Text))
            '.fone2_inst = Server.HtmlEncode(Trim(a_txtfone2inst.Text))
            '.formacao = Server.HtmlEncode(Trim(a_txtformacao.Text))
            '.foto = Server.HtmlEncode(Trim(a_txtF.Text))
            '.funcao_inst = Server.HtmlEncode(Trim(a_txtformacaoinst.Text))
            '.historico = Server.HtmlEncode(Trim(a_txtH.Text))
            '.identificacao = Server.HtmlEncode(Trim(a_txtidentificacao.Text))
            '.Inst_origem = Server.HtmlEncode(Trim(a_txtinstorigem.Text))
            '.instituicao = Server.HtmlEncode(Trim(a_txtinstituicao.Text))
            '.lacal = Server.HtmlEncode(Trim(a_txtlocal.Text))
            '.nascimento = Server.HtmlEncode(Trim(a_txtnascimento.Text))
            '.naturalidade = Server.HtmlEncode(Trim(a_txtnaturalidade.Text))
            '.numero_inst = Server.HtmlEncode(Trim(a_txtninst.Text))
            '.documento = a_DropDowndocumento.SelectedValue
            '.orgaemissor = Server.HtmlEncode(Trim(a_txtemissor.Text))
            '.periodo = Server.HtmlEncode(Trim(a_txtinicio.Text))
            '.termino = Server.HtmlEncode(Trim(a_txtfim.Text))
            '.rg = Server.HtmlEncode(Trim(a_txtidentidade.Text))
            '.titulacaomaxima = Server.HtmlEncode(Trim(a_txttitulacaomaxima.Text))
            '.turno = a_DropDownturno.Text
            '.uf = a_DropDownuf.SelectedValue
            '.uf_inst = a_DropDownufinst.SelectedValue
            ._codigo = Gera_codigo_a()
            .aluno = a_txtaluno.Text
            .numero = a_txtn.Text
            ._complemento = a_txtcompl.Text
            .ano = a_txtano.Text
            .anotitulacao = a_txtanotitulacao.Text
            .atuacao = a_txtareadeatuacao.Text
            ._bairro = a_txtbairro.Text
            .bairro_inst = a_txtbairroinst.Text
            .cargo_inst = a_txtcargo.Text
            .celular = a_txtcelular.Text
            .cep = a_txtcep.Text
            .cep_inst = a_txtcepinst.Text
            .cidade = a_DropDowncidade.Text
            .cidade_inst = a_DropDowncidadeinst.Text
            .comlemento_inst = a_txtcompinst.Text
            .cpf = a_txtcpf.Text
            .curso = a_DropDowncurso.SelectedValue
            .diploma = a_txtD.Text
            .email = a_txtemail.Text
            .email_inst = a_txtemailinst.Text
            .endereco = a_txtendereco.Text
            .endereco_inst = a_txtenderecoinst.Text
            .fax = a_txtfax.Text
            .fax_inst = a_txtfaxinst.Text
            .fone1 = a_txtfone1.Text
            .fone1_inst = a_txtfone1inst.Text
            .fone2 = a_txtfone2.Text
            .fone2_inst = a_txtfone2inst.Text
            .formacao = a_txtformacao.Text
            .foto = a_txtF.Text
            .funcao_inst = a_txtformacaoinst.Text
            .historico = a_txtH.Text
            .identificacao = a_txtidentificacao.Text
            .Inst_origem = a_txtinstorigem.Text
            .instituicao = a_txtinstituicao.Text
            .lacal = a_txtlocal.Text
            .nascimento = a_txtnascimento.Text
            .naturalidade = a_txtnaturalidade.Text
            .numero_inst = a_txtninst.Text
            .documento = a_DropDowndocumento.SelectedValue
            .orgaemissor = a_txtemissor.Text
            .periodo = a_txtinicio.Text
            .termino = a_txtfim.Text
            .rg = a_txtidentidade.Text
            .titulacaomaxima = a_txttitulacaomaxima.Text
            .turno = a_DropDownturno.Text
            .uf = a_DropDownuf.SelectedValue
            .uf_inst = a_DropDownufinst.SelectedValue
        End With
    End Sub

    Protected Sub ImageButton2_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles alu_btncancelar.Click
        limpardezativa()
        txtcodigoalu.Text = ""
        povoaalunos()
    End Sub

    Protected Sub ImageButton5_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton5.Click
        novo_professor()
        txtcodigoprof.Text = ""
        MagicAjax.AjaxCallHelper.FocusControl(p_txtprofessor)
    End Sub

    Protected Sub ImageButton7_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles p_btncancelar.Click
        liparprofessor()
        povoar_grid_professor()
    End Sub

    Protected Sub ImageButton9_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton9.Click
        novaDisciplina()
        txtdsci_cod.Text = ""
        d_txtvigencia.Text = Format(Now, "yyyy")
        MagicAjax.AjaxCallHelper.FocusControl(d_txtcoddisciplina)
    End Sub

    Protected Sub ImageButton11_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles d_btncancelar.Click
        limpar_disciplina()
        povoar_gridDisciplina()
    End Sub

    Protected Sub ImageButton13_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton13.Click
        novacurso()
        MagicAjax.AjaxCallHelper.FocusControl(cc_txtcodigodocurso)
        Textocd_curso.Text = ""
    End Sub

    Protected Sub ImageButton15_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles c_btncancelar.Click
        limpar_curso()
    End Sub

    Protected Sub ImageButton17_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton17.Click
        novo_certificado()
        txtcod_cert_frent.Text = ""
        MagicAjax.AjaxCallHelper.FocusControl(cf_Dropaluno)
    End Sub

    Protected Sub ImageButton19_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles cf_btncancelar.Click
        limpar_certificado_frente()
        povoardatagrid_certificado_frente()
    End Sub

    Protected Sub a_DropDowndocumento_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles a_DropDowndocumento.SelectedIndexChanged
        verificardocumento()
    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles Alu_btnsalvar.Click
        Dim Dsaluno As New Data.DataSet
        Alunos.receberconexao = Session("Unidade")
        If a_txtaluno.Text = "" Or a_DropDowncurso.SelectedValue = "******** Selecione o Curso *********" Or a_DropDowncidade.SelectedValue = "" Or a_txtbairro.Text = "" Or a_txtanotitulacao.Text = "" Or a_txtareadeatuacao.Text = "" Or a_txtbairro.Text = "" Or a_txtcep.Text = "" Or a_txtemissor.Text = "" Or a_txtnaturalidade.Text = "" Or a_txtformacao.Text = "" Or a_txttitulacaomaxima.Text = "" Or a_txtanotitulacao.Text = "" Then
            MagicAjax.AjaxCallHelper.WriteAlert("Os seguintes campos são obrigatórios: Aluno, Curso, Endereço, Bairro, Cidade, Estado, CEP, CPF, RG, Orgão emissor, Naturalidade, Formação, Instituição, Ano, Titulação máxima, Ano da titulação, Area de atuação, Local, Periodo, Termino, Documentos, Cidade da Instituição!")
        Else
            If Trim(ViewState("alu_codigo")) = "" Then
                If Trim(txtcodigoalu.Text) = "" Then
                    Dsaluno = Alunos.Consultar_valida("alu_nome = '" & Server.HtmlDecode(Trim(a_txtaluno.Text & "'")))
                    If Dsaluno.Tables(0).Rows.Count <> 0 Then
                        MagicAjax.AjaxCallHelper.WriteAlert("Este aluno já foi cadastrado com matrícula:" & Dsaluno.Tables(0).Rows(0)("alu_identificado"))
                        limpardezativa()
                    Else
                        associar_alunos()
                        MagicAjax.AjaxCallHelper.WriteAlert(Alunos.Inserir())
                        povoaalunos()
                        alu_btncancelar.Enabled = False
                        Alu_btnsalvar.Enabled = False
                        limpardezativa()
                    End If
                Else
                    If Trim(txtcodigoalu.Text) <> "" Then
                        associar_alunos_auterar()
                        MagicAjax.AjaxCallHelper.WriteAlert(Alunos.Alterar())
                        povoaalunos()
                        alu_btncancelar.Enabled = False
                        Alu_btnsalvar.Enabled = False
                        txtcodigoalu.Text = ""
                        limpardezativa()
                    End If
                End If
            End If
        End If
    End Sub

    Protected Sub a_DropDownuf_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles a_DropDownuf.SelectedIndexChanged
        Povoar_cidade_alu()
    End Sub

    Protected Sub a_DropDownufinst_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles a_DropDownufinst.SelectedIndexChanged
        povoa_cidade_inst()
    End Sub

    Protected Sub DataGridaluno_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles DataGridaluno.DeleteCommand
        Dim Ds As Data.DataSet
        If e.CommandName = "Delete" Then
            Alunos.receberconexao = Session("Unidade")
            Ds = Alunos.Consultar("alu_Codigo = " & e.Item.Cells(0).Text & "")
            txtcodigoalu.Text = e.Item.Cells(0).Text
            MagicAjax.AjaxCallHelper.WriteAlert(Alunos.Excluir("alu_codigo = " & e.Item.Cells(0).Text & ""))
            'Fn.Alerta(Alunos.Excluir("alu_codigo = " & e.Item.Cells(0).Text & ""), Page)
            povoaalunos()
        End If
    End Sub

    Protected Sub DataGridaluno_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles DataGridaluno.ItemCommand
        If e.CommandName = "Edit" Then
            Dim Ds As Data.DataSet
            Alunos.receberconexao = Session("Unidade")
            Ds = Alunos.Consultar("alu_Codigo = " & e.Item.Cells(0).Text & "")
            ViewState("alu_Codigo") = Ds.Tables(0).Rows(0)("alu_Codigo")
            txtcodigoalu.Text = Ds.Tables(0).Rows(0)("alu_codigo")
            '*****************************************************************
            novoregistro()
            verificardocumento()
            a_txtaluno.Text = Ds.Tables(0).Rows(0)("alu_nome")
            If Not IsDBNull(Ds.Tables(0).Rows(0)("alu_numero")) Then a_txtn.Text = Ds.Tables(0).Rows(0)("alu_numero")
            If Not IsDBNull(Ds.Tables(0).Rows(0)("alu_complemento")) Then a_txtcompl.Text = Ds.Tables(0).Rows(0)("alu_complemento")
            a_txtano.Text = Ds.Tables(0).Rows(0)("alu_ano")
            a_txtanotitulacao.Text = Ds.Tables(0).Rows(0)("alu_anotitulacaomaxima")
            a_txtareadeatuacao.Text = Ds.Tables(0).Rows(0)("alu_areadeatuacao")
            a_txtbairro.Text = Ds.Tables(0).Rows(0)("alu_bairro")
            If Not IsDBNull(Ds.Tables(0).Rows(0)("alu_bairro_inst")) Then a_txtbairroinst.Text = Ds.Tables(0).Rows(0)("alu_bairro_inst")
            If Not IsDBNull(Ds.Tables(0).Rows(0)("alu_cargo_inst")) Then a_txtcargo.Text = Ds.Tables(0).Rows(0)("alu_cargo_inst")
            If Not IsDBNull(Ds.Tables(0).Rows(0)("alu_celular")) Then a_txtcelular.Text = Ds.Tables(0).Rows(0)("alu_celular")
            a_txtcep.Text = Ds.Tables(0).Rows(0)("alu_cep")
            If Not IsDBNull(Ds.Tables(0).Rows(0)("alu_cep_inst")) Then a_txtcepinst.Text = Ds.Tables(0).Rows(0)("alu_cep_inst")
            If Not IsDBNull(Ds.Tables(0).Rows(0)("alu_complemento_inst")) Then a_txtcompinst.Text = Ds.Tables(0).Rows(0)("alu_complemento_inst")
            a_txtcpf.Text = Ds.Tables(0).Rows(0)("alu_cpf")
            a_DropDowncurso.SelectedValue = Ds.Tables(0).Rows(0)("cur_codigo")
            If Not IsDBNull(Ds.Tables(0).Rows(0)("alu_diploma")) Then a_txtD.Text = Ds.Tables(0).Rows(0)("alu_diploma")
            If Not IsDBNull(Ds.Tables(0).Rows(0)("alu_email")) Then a_txtemail.Text = Ds.Tables(0).Rows(0)("alu_email")
            If Not IsDBNull(Ds.Tables(0).Rows(0)("alu_email_inst")) Then a_txtemailinst.Text = Ds.Tables(0).Rows(0)("alu_email_inst")
            a_txtendereco.Text = Ds.Tables(0).Rows(0)("alu_endereco")
            If Not IsDBNull(Ds.Tables(0).Rows(0)("alu_end_instituicao")) Then a_txtenderecoinst.Text = Ds.Tables(0).Rows(0)("alu_end_instituicao")
            If Not IsDBNull(Ds.Tables(0).Rows(0)("alu_fax")) Then a_txtfax.Text = Ds.Tables(0).Rows(0)("alu_fax")
            If Not IsDBNull(Ds.Tables(0).Rows(0)("alu_fax_inst")) Then a_txtfaxinst.Text = Ds.Tables(0).Rows(0)("alu_fax_inst")
            If Not IsDBNull(Ds.Tables(0).Rows(0)("alu_fone1")) Then a_txtfone1.Text = Ds.Tables(0).Rows(0)("alu_fone1")
            If Not IsDBNull(Ds.Tables(0).Rows(0)("alu_fone1_inst")) Then a_txtfone1inst.Text = Ds.Tables(0).Rows(0)("alu_fone1_inst")
            If Not IsDBNull(Ds.Tables(0).Rows(0)("alu_fone2")) Then a_txtfone2.Text = Ds.Tables(0).Rows(0)("alu_fone2")
            If Not IsDBNull(Ds.Tables(0).Rows(0)("alu_fone2_inst")) Then a_txtfone2inst.Text = Ds.Tables(0).Rows(0)("alu_fone2_inst")
            a_txtformacao.Text = Ds.Tables(0).Rows(0)("alu_formacao")
            If Not IsDBNull(Ds.Tables(0).Rows(0)("alu_foto")) Then a_txtF.Text = Ds.Tables(0).Rows(0)("alu_foto")
            If Not IsDBNull(Ds.Tables(0).Rows(0)("alu_funcao_inst")) Then a_txtformacaoinst.Text = Ds.Tables(0).Rows(0)("alu_funcao_inst")
            If Not IsDBNull(Ds.Tables(0).Rows(0)("alu_historico")) Then a_txtH.Text = Ds.Tables(0).Rows(0)("alu_historico")
            a_txtidentificacao.Text = Ds.Tables(0).Rows(0)("alu_identificado")
            If Not IsDBNull(Ds.Tables(0).Rows(0)("alu_inst_deorigem")) Then a_txtinstorigem.Text = Ds.Tables(0).Rows(0)("alu_inst_deorigem")
            a_txtinstituicao.Text = Ds.Tables(0).Rows(0)("alu_instituicao")
            a_txtlocal.Text = Ds.Tables(0).Rows(0)("alu_local")
            a_txtnascimento.Text = Ds.Tables(0).Rows(0)("alu_nascimento")
            a_txtnaturalidade.Text = Ds.Tables(0).Rows(0)("alu_naturalidade")
            If Not IsDBNull(Ds.Tables(0).Rows(0)("alu_num_instituicao")) Then a_txtninst.Text = Ds.Tables(0).Rows(0)("alu_num_instituicao")
            a_DropDowndocumento.Text = Ds.Tables(0).Rows(0)("alu_documento")
            a_txtemissor.Text = Ds.Tables(0).Rows(0)("alu_orgaoemissor")
            If Not IsDBNull(Ds.Tables(0).Rows(0)("alu_periodo")) Then a_txtinicio.Text = Ds.Tables(0).Rows(0)("alu_periodo")
            If Not IsDBNull(Ds.Tables(0).Rows(0)("alu_termino")) Then a_txtfim.Text = Ds.Tables(0).Rows(0)("alu_termino")
            a_txtidentidade.Text = Ds.Tables(0).Rows(0)("alu_rg")
            a_txttitulacaomaxima.Text = Ds.Tables(0).Rows(0)("alu_titulacaomaxima")
            If Not IsDBNull(Ds.Tables(0).Rows(0)("alu_turno")) Then a_DropDownturno.Text = Ds.Tables(0).Rows(0)("alu_turno")
            a_DropDownuf.SelectedValue = Ds.Tables(0).Rows(0)("alu_uf")
            a_DropDownufinst.SelectedValue = Ds.Tables(0).Rows(0)("alu_uf_inst")
            Povoar_cidade_alu()
            povoa_cidade_inst()
            verificardocumento()
            '*****************************************************************
        End If
    End Sub

    Protected Sub DataGridaluno_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles DataGridaluno.ItemDataBound
        Dim Btnexcluir As New LinkButton
        If e.Item.ItemType = ListItemType.Item Or e.Item.ItemType = ListItemType.AlternatingItem Then
            Btnexcluir = e.Item.Cells(5).Controls(0)
            Btnexcluir.Attributes.Add("onclick", "javascript:return " + "confirm('Deseja realmente excluir este aluno:  " + (e.Item.Cells(2).Text + "  Matrícula: " + (e.Item.Cells(1).Text + " ?""')")))
        End If
    End Sub

    Protected Sub ImageButton1_Click1(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Dim Ds As New Data.DataSet
        DataGridaluno.CurrentPageIndex = 0
        Try

        Catch ex As Exception

        End Try
        If a_txtaluno.Text <> "" Then
            Alunos.receberconexao = Session("Unidade")
            Ds = Alunos.Consultar("alu_nome LIKE '%" & a_txtaluno.Text & "%'")
            'Ds = chave.Consultar("ch_sala LIKE '%" & TextBox1.Text & "%'") ' = " & e.Item.Cells(0).Text & "")
            DataGridaluno.DataSource = Ds
            DataGridaluno.DataBind()
        End If
    End Sub

    Protected Sub ImageButton6_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles p_btnsalvar.Click
        Dim ds As New Data.DataSet
        Professor.receberconexao = Session("Unidade")
        If p_txtatuacao.Text = "" Or p_txtformacao.Text = "" Or p_txtprofessor.Text = "" Or p_txttitulacao.Text = "" Or p_txtingresso.Text = "" Then
            'Fn.Alerta(Message.exibirmenssagem_Professor(), Page)
            MagicAjax.AjaxCallHelper.WriteAlert(Message.exibirmenssagem_Professor)
        Else
            If Trim(ViewState("prof_codigo")) = "" Then
                If txtcodigoprof.Text = "" Then
                    ds = Professor.Consultar("prof_nome = '" & p_txtprofessor.Text & "'")
                    If ds.Tables(0).Rows.Count <> 0 Then
                        MagicAjax.AjaxCallHelper.WriteAlert("O professor: " & ds.Tables(0).Rows(0)("prof_nome") & " já esta cadastrado!")
                        'Fn.Alerta("O professor: " & ds.Tables(0).Rows(0)("prof_nome") & " já esta cadastrado!", Page)
                        liparprofessor()
                    Else
                        associarprofessor()
                        MagicAjax.AjaxCallHelper.WriteAlert(Professor.Inserir)
                        'Fn.Alerta(Professor.Inserir(), Page)
                        'lpromessage.Text = Professor.Inserir
                        p_btnsalvar.Enabled = False
                        p_btncancelar.Enabled = False
                        liparprofessor()
                        povoar_grid_professor()
                    End If
                Else
                    If Trim(txtcodigoprof.Text) <> "" Then
                        associarProfessor_alterar()
                        MagicAjax.AjaxCallHelper.WriteAlert(Professor.Alterar)
                        p_btncancelar.Enabled = False
                        p_btnsalvar.Enabled = False
                        txtcodigoalu.Text = ""
                        liparprofessor()
                        povoar_grid_professor()
                    End If
                End If
                End If
            End If
    End Sub

    Protected Sub DataGridprofessor_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles DataGridprofessor.DeleteCommand
        Dim Ds As Data.DataSet
        If e.CommandName = "Delete" Then
            Professor.receberconexao = Session("Unidade")
            Ds = Professor.Consultar("prof_Codigo = " & e.Item.Cells(0).Text & "")
            txtcodigoalu.Text = e.Item.Cells(0).Text
            txtcodigoalu.Text = Ds.Tables(0).Rows(0)("prof_Codigo")
            Fn.Alerta(Professor.Excluir("prof_codigo =" & e.Item.Cells(0).Text & ""), Page)
            povoar_grid_professor()
        End If
    End Sub

    Protected Sub DataGridprofessor_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles DataGridprofessor.ItemCommand
        If e.CommandName = "Edit" Then
            Dim Ds As Data.DataSet
            Professor.receberconexao = Session("Unidade")
            Ds = Professor.Consultar("prof_Codigo = " & e.Item.Cells(0).Text & "")
            ViewState("prof_Codigo") = Ds.Tables(0).Rows(0)("prof_Codigo")
            txtcodigoprof.Text = Ds.Tables(0).Rows(0)("prof_codigo")
            '*****************************************************************
            novo_professor()
            p_txtprofessor.Text = Ds.Tables(0).Rows(0)("prof_nome")
            p_txtatuacao.Text = Ds.Tables(0).Rows(0)("prof_atuacao")
            p_txtformacao.Text = Ds.Tables(0).Rows(0)("prof_formacao")
            p_txtingresso.Text = Ds.Tables(0).Rows(0)("prof_ingresso")
            p_txttitulacao.Text = Ds.Tables(0).Rows(0)("prof_titulacao")
            p_dropunidade.SelectedValue = Ds.Tables(0).Rows(0)("uni_codigo")

        End If
    End Sub

    Protected Sub DataGridprofessor_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles DataGridprofessor.ItemDataBound
        Dim Btnexcluir As New LinkButton
        If e.Item.ItemType = ListItemType.Item Or e.Item.ItemType = ListItemType.AlternatingItem Then
            Btnexcluir = e.Item.Cells(6).Controls(0)
            Btnexcluir.Attributes.Add("onclick", "javascript:return " + "confirm('Deseja realmente excluir este Professor:  " + (e.Item.Cells(1).Text + "?""')"))
        End If
    End Sub

    Protected Sub DataGridprofessor_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles DataGridprofessor.PageIndexChanged
        DataGridprofessor.CurrentPageIndex = e.NewPageIndex
        povoar_grid_professor()
    End Sub

    Protected Sub ImageButton31_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton31.Click
        Dim Ds As New Data.DataSet
        DataGridprofessor.CurrentPageIndex = 0
        Try

        Catch ex As Exception

        End Try
        If p_txtprofessor.Text <> "" Then
            Professor.receberconexao = Session("Unidade")
            Ds = Professor.Consultar("prof_nome LIKE '%" & p_txtprofessor.Text & "%'")
            'Ds = chave.Consultar("ch_sala LIKE '%" & TextBox1.Text & "%'") ' = " & e.Item.Cells(0).Text & "")
            DataGridprofessor.DataSource = Ds
            DataGridprofessor.DataBind()
        End If
    End Sub

    Protected Sub ImageButton6_Click1(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton6.Click
        Dim Ds As New Data.DataSet
        DataGrid_disciplina.CurrentPageIndex = 0
        Try

        Catch ex As Exception

        End Try
        If d_txtdisciplina.Text <> "" Then
            Disciplina.receberconexao = Session("Unidade")
            Ds = Disciplina.Consultar("a.dc_disciplina LIKE '%" & d_txtdisciplina.Text & "%'")
            'Ds = chave.Consultar("ch_sala LIKE '%" & TextBox1.Text & "%'") ' = " & e.Item.Cells(0).Text & "")
            DataGrid_disciplina.DataSource = Ds
            DataGrid_disciplina.DataBind()
        End If
    End Sub

    Protected Sub d_btnsalvar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles d_btnsalvar.Click
        Dim ds As New Data.DataSet
        Disciplina.receberconexao = Session("Unidade")
        If d_txtcoddisciplina.Text = "" Or d_txtcoddisciplina.Text = "" Or d_txtchteorica.Text = "" Or d_txtchpratica.Text = "" Or d_txtcredito.Text = "" Then
            MagicAjax.AjaxCallHelper.WriteAlert(Message.exibirmenssagem_disciplina)
        Else
            If Trim(ViewState("dc_codigo")) = "" Then
                If txtdsci_cod.Text = "" Then
                    ds = Disciplina.Consultar("a.dc_disciplina = '" & d_txtdisciplina.Text & "'")
                    If ds.Tables(0).Rows.Count <> 0 Then
                        MagicAjax.AjaxCallHelper.WriteAlert("A disciplina: " & ds.Tables(0).Rows(0)("dc_disciplina") & " já esta cadastrada!")
                        'Fn.Alerta("A disciplina: " & ds.Tables(0).Rows(0)("dc_disciplina") & " já esta cadastrada!", Page)
                        limpar_disciplina()
                    Else
                        associar_disciplina()
                        MagicAjax.AjaxCallHelper.WriteAlert(Disciplina.Inserir)
                        d_btnsalvar.Enabled = False
                        d_btncancelar.Enabled = False
                        limpar_disciplina()
                        povoar_gridDisciplina()
                    End If
                Else
                    If Trim(txtdsci_cod.Text) <> "" Then
                        associar_altera_disciplina()
                        MagicAjax.AjaxCallHelper.WriteAlert(Disciplina.Alterar)
                        d_btncancelar.Enabled = False
                        d_btnsalvar.Enabled = False
                        txtdsci_cod.Text = ""
                        limpar_disciplina()
                        povoar_gridDisciplina()
                    End If
                End If
            End If
        End If
    End Sub

    Protected Sub DataGrid_disciplina_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles DataGrid_disciplina.DeleteCommand
        Dim Ds As Data.DataSet
        If e.CommandName = "Delete" Then
            Disciplina.receberconexao = Session("Unidade")
            Ds = Disciplina.Consultar("dc_Codigo = " & e.Item.Cells(0).Text & "")
            MagicAjax.AjaxCallHelper.WriteAlert(Disciplina.Excluir("dc_codigo =" & e.Item.Cells(0).Text & ""))
            povoar_gridDisciplina()
        End If
    End Sub

    Protected Sub DataGrid_disciplina_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles DataGrid_disciplina.ItemCommand
        If e.CommandName = "Edit" Then
            Dim Ds As Data.DataSet
            Disciplina.receberconexao = Session("Unidade")
            Ds = Disciplina.Consultaraltera("dc_Codigo = " & e.Item.Cells(0).Text & "")
            ViewState("dc_Codigo") = Ds.Tables(0).Rows(0)("dc_Codigo")
            txtdsci_cod.Text = Ds.Tables(0).Rows(0)("dc_codigo")
            '*****************************************************************
            novaDisciplina()
            d_txtcoddisciplina.Text = Ds.Tables(0).Rows(0)("dc_coddisciplina")
            d_txtdisciplina.Text = Ds.Tables(0).Rows(0)("dc_disciplina")
            d_txtchteorica.Text = Ds.Tables(0).Rows(0)("dc_chteorica")
            If Not IsDBNull(Ds.Tables(0).Rows(0)("dc_chpratica")) Then d_txtchpratica.Text = Ds.Tables(0).Rows(0)("dc_chpratica")
            d_txtcredito.Text = Ds.Tables(0).Rows(0)("dc_credito")
            d_txtvigencia.Text = Ds.Tables(0).Rows(0)("dc_vigencia")
            d_dropmodulo.SelectedValue = Ds.Tables(0).Rows(0)("mod_codigo")
        End If
    End Sub

    Protected Sub DataGrid_disciplina_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles DataGrid_disciplina.ItemDataBound
        Dim Btnexcluir As New LinkButton
        If e.Item.ItemType = ListItemType.Item Or e.Item.ItemType = ListItemType.AlternatingItem Then
            Btnexcluir = e.Item.Cells(7).Controls(0)
            Btnexcluir.Attributes.Add("onclick", "javascript:return " + "confirm('Deseja realmente excluir esta Disciplina:  " + (e.Item.Cells(1).Text + " ? ""')"))
        End If
    End Sub

    Protected Sub ImageButton14_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles c_btnsalvar.Click
        Dim ds As New Data.DataSet
        Curso.receberconexao = Session("Unidade")
        If c_txtcurso.Text = "" Or cc_txtcodigodocurso.Text = "" Or c_Dropclassificacao.Text = "" Or c_DropDownportaria.Text = "" Or c_DropDresolucao.Text = "" Then
            MagicAjax.AjaxCallHelper.WriteAlert(Message.exibirmenssagem_curso)
        Else
            If Trim(ViewState("cur_codigo")) = "" Then
                If Textocd_curso.Text = "" Then
                    ds = Curso.Consultar("cur_curso = '" & c_txtcurso.Text & "'")
                    If ds.Tables(0).Rows.Count <> 0 Then
                        MagicAjax.AjaxCallHelper.WriteAlert("O curso: " & ds.Tables(0).Rows(0)("cur_curso") & " já esta cadastrado!")
                        limpar_curso()
                    Else
                        Associar_curso()
                        MagicAjax.AjaxCallHelper.WriteAlert(Curso.Inserir)
                        limpar_curso()
                        Povoargridcurso()
                    End If
                Else
                    If Trim(Textocd_curso.Text) <> "" Then
                        Associar_curso_alterar()
                        MagicAjax.AjaxCallHelper.WriteAlert(Curso.Alterar)
                        limpar_curso()
                        Textocd_curso.Text = ""
                        Povoargridcurso()
                    End If
                End If
            End If
        End If
    End Sub

    Protected Sub DataGrid_curso_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles DataGrid_curso.DeleteCommand
        Dim Ds As Data.DataSet
        If e.CommandName = "Delete" Then
            Ds = Curso.Consultar("cur_Codigo = " & e.Item.Cells(0).Text & "")
            txtcodigoalu.Text = e.Item.Cells(0).Text
            txtcodigoalu.Text = Ds.Tables(0).Rows(0)("cur_Codigo")
            MagicAjax.AjaxCallHelper.WriteAlert("cur_codigo =" & e.Item.Cells(0).Text & "")
            Povoargridcurso()
        End If
    End Sub

    Protected Sub DataGrid_curso_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles DataGrid_curso.ItemCommand
        If e.CommandName = "Edit" Then
            Dim Ds As Data.DataSet
            Curso.receberconexao = Session("Unidade")
            Ds = Curso.Consultar("cur_Codigo = " & e.Item.Cells(0).Text & "")
            ViewState("cur_Codigo") = Ds.Tables(0).Rows(0)("cur_Codigo")
            Textocd_curso.Text = Ds.Tables(0).Rows(0)("cur_codigo")
            '*****************************************************************
            novacurso()
            c_txtcurso.Text = Ds.Tables(0).Rows(0)("cur_curso")
            c_Dropclassificacao.SelectedValue = Ds.Tables(0).Rows(0)("clas_codigo")
            c_DropDownportaria.SelectedValue = Ds.Tables(0).Rows(0)("po_codigo")
            c_DropDresolucao.SelectedValue = Ds.Tables(0).Rows(0)("res_codigo")
            cc_txtcodigodocurso.Text = Ds.Tables(0).Rows(0)("cur_codcurso")
        End If
    End Sub

    Protected Sub DataGrid_curso_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles DataGrid_curso.ItemDataBound
        Dim Btnexcluir As New LinkButton
        If e.Item.ItemType = ListItemType.Item Or e.Item.ItemType = ListItemType.AlternatingItem Then
            Btnexcluir = e.Item.Cells(6).Controls(0)
            Btnexcluir.Attributes.Add("onclick", "javascript:return " + "confirm('Deseja realmente excluir este Curso:  " + (e.Item.Cells(1).Text + "?""')"))
        End If
    End Sub

    Protected Sub ImageButton7_Click1(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton7.Click
        Dim Ds As New Data.DataSet
        DataGrid_curso.CurrentPageIndex = 0
        Try

        Catch ex As Exception

        End Try
        If c_txtcurso.Text <> "" Then
            Curso.receberconexao = Session("Unidade")
            Ds = Curso.Consultar("cur_curso LIKE '%" & c_txtcurso.Text & "%'")
            DataGrid_curso.DataSource = Ds
            DataGrid_curso.DataBind()
        End If
    End Sub

    Protected Sub ImageButton18_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles cf_btnsalvar.Click
        Dim ds As New Data.DataSet
        CertificadoF.receberconexao = Session("Unidade")
        If cf_Dropaluno.Text = "" Or cf_txtrealizacao.Text = "" Or cf_titulomonografia.Text = "" Then
            MagicAjax.AjaxCallHelper.WriteAlert(Message.exibirmenssagem_certificadofrente)
        Else

            If Trim(ViewState("cer_codigo")) = "" Then
                If txtcod_cert_frent.Text = "" Then
                    ds = CertificadoF.Consultar_certificado("A.alu_codigo = " & cf_Dropaluno.SelectedValue & "")
                    If ds.Tables(0).Rows.Count <> 0 Then
                        MagicAjax.AjaxCallHelper.WriteAlert("O aluno: " & ds.Tables(0).Rows(0)("alu_nome") & " já esta cadastrado!")
                        limpar_certificado_frente()
                    Else
                        associar_certificado_frente()
                        MagicAjax.AjaxCallHelper.WriteAlert(CertificadoF.Inserir)
                        limpar_certificado_frente()
                        povoardatagrid_certificado_frente()
                    End If
                Else
                    If Trim(txtcod_cert_frent.Text) <> "" Then
                        associar_alterar_frente()
                        MagicAjax.AjaxCallHelper.WriteAlert(CertificadoF.Alterar)
                        limpar_certificado_frente()
                        povoardatagrid_certificado_frente()
                    End If
                End If
            End If
        End If
    End Sub

    Protected Sub ImageButton20_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton20.Click
        Dim Ds As New Data.DataSet
        DataGridCfrente.CurrentPageIndex = 0
        Try

        Catch ex As Exception

        End Try
        If cf_Dropaluno.SelectedValue <> "" Then
            CertificadoF.receberconexao = Session("Unidade")
            Ds = CertificadoF.Consultar_certificado("A.alu_codigo = " & cf_Dropaluno.SelectedValue & "")
            DataGridCfrente.DataSource = Ds
            DataGridCfrente.DataBind()
        End If
    End Sub

    Protected Sub DataGridCfrente_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles DataGridCfrente.DeleteCommand
        Dim Ds As Data.DataSet
        If e.CommandName = "Delete" Then
            CertificadoF.receberconexao = Session("Unidade")
            Ds = CertificadoF.Consultar("cer_Codigo = " & e.Item.Cells(0).Text & "")
            MagicAjax.AjaxCallHelper.WriteAlert(CertificadoF.Excluir("cer_codigo =" & e.Item.Cells(0).Text & ""))
            'Fn.Alerta(CertificadoF.Excluir("cer_codigo =" & e.Item.Cells(0).Text & ""), Page)
            povoardatagrid_certificado_frente()
        End If
    End Sub

    Protected Sub DataGridCfrente_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles DataGridCfrente.ItemCommand
        If e.CommandName = "Edite" Then
            Dim Ds As Data.DataSet
            CertificadoF.receberconexao = Session("Unidade")
            Ds = CertificadoF.Consultar("cer_Codigo = " & e.Item.Cells(0).Text & "")
            ViewState("cer_Codigo") = Ds.Tables(0).Rows(0)("cer_Codigo")
            txtcod_cert_frent.Text = Ds.Tables(0).Rows(0)("cer_codigo")
            '*****************************************************************
            novo_certificado()
            cf_Dropaluno.SelectedValue = Ds.Tables(0).Rows(0)("alu_codigo")
            'cf_DropDcurso.SelectedValue = Ds.Tables(0).Rows(0)("cur_codigo")
            cf_Dropcurso.SelectedValue = Ds.Tables(0).Rows(0)("cur_codigo")
            'cf_DropDownportaria.SelectedValue = Ds.Tables(0).Rows(0)("po_codigo")
            cf_txtrealizacao.Text = Ds.Tables(0).Rows(0)("cer_realizacaodocurso")
            cf_titulomonografia.Text = Ds.Tables(0).Rows(0)("cer_titulomonografia")
        End If
    End Sub

    Protected Sub DataGridCfrente_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles DataGridCfrente.ItemDataBound
        Dim Btnexcluir As New LinkButton
        If e.Item.ItemType = ListItemType.Item Or e.Item.ItemType = ListItemType.AlternatingItem Then
            Btnexcluir = e.Item.Cells(4).Controls(0)
            Btnexcluir.Attributes.Add("onclick", "javascript:return " + "confirm('Deseja realmente excluir este Certificado:  " + (e.Item.Cells(1).Text + "?""')"))
        End If
    End Sub

    Protected Sub ImageButton11_Click1(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton11.Click
        rodape.Visible = False
        Multicertificado.ActiveViewIndex = 0
        povoaalunos()
    End Sub

    Protected Sub ImageButton14_Click1(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton14.Click
        rodape.Visible = False
        Multicertificado.ActiveViewIndex = 3
        Povoargridcurso()
    End Sub

    Protected Sub ImageButton15_Click1(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton15.Click
        rodape.Visible = False
        Multicertificado.ActiveViewIndex = 2
        povoar_gridDisciplina()
    End Sub

    Protected Sub ImageButton18_Click1(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton18.Click
        rodape.Visible = False
        Multicertificado.ActiveViewIndex = 1
        Professor.receberconexao = Session("Unidade")
        povoar_grid_professor()
    End Sub

    Protected Sub ImageButton2_Click1(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton2.Click
        rodape.Visible = False
        Multicertificado.ActiveViewIndex = 4
        CertificadoF.receberconexao = Session("Unidade")
        povoardatagrid_certificado_frente()
    End Sub

    Protected Sub ImageButton19_Click1(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton19.Click
        rodape.Visible = False
        Multicertificado.ActiveViewIndex = 5
        povoar_curso_diario()
    End Sub


    Protected Sub DataGridCfrente_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles DataGridCfrente.PageIndexChanged
        DataGridCfrente.CurrentPageIndex = e.NewPageIndex
        povoardatagrid_certificado_frente()
    End Sub

    Protected Sub DataGrid_disciplina_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles DataGrid_disciplina.PageIndexChanged
        DataGrid_disciplina.CurrentPageIndex = e.NewPageIndex
        povoar_gridDisciplina()
    End Sub

    Protected Sub DataGrid_curso_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles DataGrid_curso.PageIndexChanged
        DataGrid_curso.CurrentPageIndex = e.NewPageIndex
        Povoargridcurso()
    End Sub

    Protected Sub Check_diario_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Check_diario.CheckedChanged
        Check_chamada.Checked = False
        Check_diario.Checked = True
    End Sub

    Protected Sub Check_chamada_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Check_chamada.CheckedChanged
        Check_diario.Checked = False
        Check_chamada.Checked = True
    End Sub

    Protected Sub dro_curso_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dro_curso.SelectedIndexChanged
        Dim Ds As New Data.DataSet
        Try
        Catch ex As Exception
        End Try
        Professor.receberconexao = Session("Unidade")
        dro_professor.Items.Clear()
        Ds = Professor.Consultar_diario("b.cur_codigo =" & dro_curso.SelectedValue & "")
        dro_professor.DataSource = Ds
        dro_professor.DataBind()
        dro_professor.Items.Insert(0, New ListItem("********** Selecione o Professor *************", String.Empty))
    End Sub

    Protected Sub dro_professor_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dro_professor.SelectedIndexChanged
        Dim Ds As New Data.DataSet
        Try
        Catch ex As Exception
        End Try
        Disciplina.receberconexao = Session("Unidade")
        dro_disciplina.Items.Clear()
        Ds = Disciplina.Consultar_diaridis(" c.prof_codigo =" & dro_professor.SelectedValue & "")
        dro_disciplina.DataSource = Ds
        dro_disciplina.DataBind()
        dro_disciplina.Items.Insert(0, New ListItem("********** Selecione a Disciplina *************", String.Empty))
    End Sub

    Protected Sub ImageButton25_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton25.Click
        Dim Script As String
        Dim Script2 As String
        If Check_diario.Checked = True Then
            If dro_curso.SelectedValue <> "" And dro_professor.SelectedValue <> "" And dro_disciplina.SelectedValue <> "" And dro_txtinicio.Text <> "" And dro_txttermino.Text <> "" Then
                'Fn.AbreJanela("rptlistafrequencia.aspx?pcur_codigo=" & dro_curso.Text & "&palu_inicio=" & dro_txtinicio.Text & "&palu_termino=" & dro_txttermino.Text & "&pcurso=" & dro_curso.SelectedItem.Text & "&pprofessor=" & dro_professor.SelectedItem.Text & "&pdisciplina=" & dro_disciplina.SelectedItem.Text & "&pturno=" & dro_turno.Text & "&pmes=" & dro_mes.Text & "&psigla=" & di_txtcoddisciplina.Text & "&pmodulo=" & di_txtmod.Text & "&phpratica=" & hi_txthorapra.Text & "&phorate=" & hi_txtorate.Text & "&pht=" & hi_txtorate.Text, "1", "", "", Page)

                Script = "window.open('rptlistafrequencia.aspx?pcur_codigo=" & dro_curso.Text & "&palu_inicio=" & dro_txtinicio.Text & "&palu_termino=" & dro_txttermino.Text & "&pcurso=" & dro_curso.SelectedItem.Text & "&pprofessor=" & dro_professor.SelectedItem.Text & "&pdisciplina=" & dro_disciplina.SelectedItem.Text & "&pturno=" & dro_turno.Text & "&pmes=" & dro_mes.Text & "&psigla=" & di_txtcoddisciplina.Text & "&pmodulo=" & di_txtmod.Text & "&phpratica=" & hi_txthorapra.Text & "&phorate=" & hi_txtorate.Text & "&pht=" & hi_txtorate.Text & _
                         "','','fullscreen=no,scrollbars=1,titlebar=0,status=0,directories=0,menubar=1,location=0,resizable=1','');"

                '"','','height=800,width=600,status=no,toolbar=no,menubar=no,location=no','');"
                MagicAjax.AjaxCallHelper.WriteAddScriptElementScript(Script, New System.Collections.Specialized.NameValueCollection)

                'MagicAjax.AjaxCallHelper.Redirect("rptlistafrequencia.aspx?pcur_codigo=" & dro_curso.Text & "&palu_inicio=" & dro_txtinicio.Text & "&palu_termino=" & dro_txttermino.Text & "&pcurso=" & dro_curso.SelectedItem.Text & "&pprofessor=" & dro_professor.SelectedItem.Text & "&pdisciplina=" & dro_disciplina.SelectedItem.Text & "&pturno=" & dro_turno.Text & "&pmes=" & dro_mes.Text & "&psigla=" & di_txtcoddisciplina.Text & "&pmodulo=" & di_txtmod.Text & "&phpratica=" & hi_txthorapra.Text & "&phorate=" & hi_txtorate.Text & "&pht=" & hi_txtorate.Text)
            Else
                MagicAjax.AjaxCallHelper.WriteAlert("Os campos: Curso, Porfessor, Disciplina, Início e Termino do curso são de preenchimento obrigatório!")
                'Fn.Alerta("Os campos: Curso, Porfessor, Disciplina, Início e Termino do curso são de preenchimento obrigatório!", Page)
            End If
        Else
            ' FUNÇÃO PARA ABRIR UMA JANELA NO MODO FULLL (SEM BARRAS DE FERRAMENTAS DO NAVEGADOR)
            'Fn.AbreJanela("rptlistafrequencia.aspx?pcur_codigo=" & dro_curso.Text & "&palu_inicio=" & dro_txtinicio.Text & "&palu_termino=" & dro_txttermino.Text & "&pcurso=" & dro_curso.SelectedItem.Text & "&pprofessor=" & dro_professor.SelectedItem.Text & "&pdisciplina=" & dro_disciplina.SelectedItem.Text & "&pturno=" & dro_turno.Text & "&pmes=" & dro_mes.Text & "&psigla=" & di_txtcoddisciplina.Text & "&pmodulo=" & di_txtmod.Text, "1", "", "", Page)
            If Check_chamada.Checked = True Then
                If dro_curso.SelectedValue <> "" And dro_professor.SelectedValue <> "" And dro_disciplina.SelectedValue <> "" And dro_txtinicio.Text <> "" And dro_txttermino.Text <> "" Then
                    'Fn.AbreJanela("reldiario.aspx?pcur_codigo=" & dro_curso.Text & "&palu_inicio=" & dro_txtinicio.Text & "&palu_termino=" & dro_txttermino.Text & "&pcurso=" & dro_curso.SelectedItem.Text & "&pprofessor=" & dro_professor.SelectedItem.Text & "&pdisciplina=" & dro_disciplina.SelectedItem.Text & "&pturno=" & dro_turno.Text & "&pmes=" & dro_mes.Text & "&psigla=" & di_txtcoddisciplina.Text & "&pmodulo=" & di_txtmod.Text & "&phpratica=" & hi_txthorapra.Text & "&phorate=" & hi_txtorate.Text & "&pht=" & hi_txtorate.Text, "1", "", "", Page)
                    Script2 = "window.open('reldiario.aspx?pcur_codigo=" & dro_curso.Text & "&palu_inicio=" & dro_txtinicio.Text & "&palu_termino=" & dro_txttermino.Text & "&pcurso=" & dro_curso.SelectedItem.Text & "&pprofessor=" & dro_professor.SelectedItem.Text & "&pdisciplina=" & dro_disciplina.SelectedItem.Text & "&pturno=" & dro_turno.Text & "&pmes=" & dro_mes.Text & "&psigla=" & di_txtcoddisciplina.Text & "&pmodulo=" & di_txtmod.Text & "&phpratica=" & hi_txthorapra.Text & "&phorate=" & hi_txtorate.Text & "&pht=" & hi_txtorate.Text & _
                        "','','fullscreen=no,scrollbars=1,titlebar=0,status=0,directories=0,menubar=1,location=0,resizable=1','');"

                    MagicAjax.AjaxCallHelper.WriteAddScriptElementScript(Script2, New System.Collections.Specialized.NameValueCollection)

                    'MagicAjax.AjaxCallHelper.Redirect("reldiario.aspx?pcur_codigo=" & dro_curso.Text & "&palu_inicio=" & dro_txtinicio.Text & "&palu_termino=" & dro_txttermino.Text & "&pcurso=" & dro_curso.SelectedItem.Text & "&pprofessor=" & dro_professor.SelectedItem.Text & "&pdisciplina=" & dro_disciplina.SelectedItem.Text & "&pturno=" & dro_turno.Text & "&pmes=" & dro_mes.Text & "&psigla=" & di_txtcoddisciplina.Text & "&pmodulo=" & di_txtmod.Text & "&phpratica=" & hi_txthorapra.Text & "&phorate=" & hi_txtorate.Text & "&pht=" & hi_txtorate.Text)
                Else
                    'If dro_curso.SelectedValue = "" And dro_professor.SelectedValue = "" And dro_disciplina.SelectedValue = "" And dro_txtinicio.Text = "" And dro_txttermino.Text <> "" Then
                    MagicAjax.AjaxCallHelper.WriteAlert("Os campos: Curso, Porfessor, Disciplina, Início e Termino do curso são de preenchimento obrigatório!")
                    'Fn.Alerta("Os campos: Curso, Porfessor, Disciplina, Início e Termino do curso são de preenchimento obrigatório!", Page)
                End If
            Else
                MagicAjax.AjaxCallHelper.WriteAlert("Selecione o tipo de diário!")

                ' FUNÇÃO PARA ABRIR UMA JANELA NO MODO FULLL (SEM BARRAS DE FERRAMENTAS DO NAVEGADOR)
                'Fn.AbreJanela("rptlistafrequencia.aspx?pcur_codigo=" & dro_curso.Text & "&palu_inicio=" & dro_txtinicio.Text & "&palu_termino=" & dro_txttermino.Text & "&pcurso=" & dro_curso.SelectedItem.Text & "&pprofessor=" & dro_professor.SelectedItem.Text & "&pdisciplina=" & dro_disciplina.SelectedItem.Text & "&pturno=" & dro_turno.Text & "&pmes=" & dro_mes.Text & "&psigla=" & di_txtcoddisciplina.Text & "&pmodulo=" & di_txtmod.Text, "1", "", "", Page)
            End If
            End If
    End Sub

    Protected Sub ImageButton22_Click1(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton22.Click
        rodape.Visible = False
        Multicertificado.ActiveViewIndex = 6
        povoar_grid_historico()
    End Sub

    Protected Sub ImageButton26_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton26.Click
        Multicertificado.ActiveViewIndex = 8
        povoar_datagrid_prof_curso()
    End Sub

    Protected Sub ImageButton28_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton28.Click
        novo_historico()
        h_txtcod.Text = ""
        h_txtfrequencia.Text = "0"
        h_txthora.Text = "0"
        h_txtnota2.Text = "0"
        h_txtmedia.Text = "0"
        h_txtnota3.Text = "0"
        h_txtnotas.Text = "0"
        h_txtmedia.Text = "0"
        h_faltas.Text = "0"
        MagicAjax.AjaxCallHelper.FocusControl(h_dropaluno)
    End Sub

    Protected Sub h_btncancelar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles h_btncancelar.Click
        limpa_historico()
        povoar_grid_historico()
    End Sub

    Protected Sub h_btnsalvar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles h_btnsalvar.Click
        Dim ds As New Data.DataSet
        historico.receberconexao = Session("Unidade")
        If h_dropaluno.Text = "" Or drop_trabDrop.Text = "" Or h_dropprofessor.Text = "" Or h_txtfrequencia.Text = "" Or h_txthora.Text = "" Or h_txtmedia.Text = "" Then
            MagicAjax.AjaxCallHelper.WriteAlert("Os seguintes campos são obrigatórios: Aluno, Professor, Disciplina, Carga Horária, Freqüência, Média")
        Else
            If Trim(ViewState("his_codigo")) = "" Then
                If h_txtcod.Text = "" Then
                    ds = historico.Consultar_historico("d.alu_codigo = " & h_dropaluno.SelectedValue & "and a.dc_codigo=" & drop_trabDrop.SelectedValue & "")
                    If ds.Tables(0).Rows.Count <> 0 Then
                        MagicAjax.AjaxCallHelper.WriteAlert("A Disciplina: " & ds.Tables(0).Rows(0)("dc_disciplina") & " Já esta cadastrada para o Aluno: " & h_dropaluno.SelectedItem.Text & "")

                    Else
                        associar_historico()
                        MagicAjax.AjaxCallHelper.WriteAlert(historico.Inserir)
                        h_btnsalvar.Enabled = False
                        h_btncancelar.Enabled = False
                        limpa_historico()
                        povoar_grid_historico()
                    End If
                Else
                    If Trim(h_txtcod.Text) <> "" Then
                        Associar_alterar_historico()
                        MagicAjax.AjaxCallHelper.WriteAlert(historico.Alterar)
                        h_btnsalvar.Enabled = False
                        h_btncancelar.Enabled = False
                        limpa_historico()
                        povoar_grid_historico()
                    End If
                End If
            End If
        End If


        '************************
        'Dim ds As New Data.DataSet
        'If h_dropaluno.Text = "" Or drop_trabDrop.Text = "" Or h_dropprofessor.Text = "" Or h_txtfrequencia.Text = "" Or h_txthora.Text = "" Or h_txtmedia.Text = "" Then
        'MagicAjax.AjaxCallHelper.WriteAlert("Os seguintes campos são obrigatórios: Aluno, Professor, Disciplina, Carga Horária, Freqüência, Média")

        'Else
        '    If Trim(ViewState("his_codigo")) = "" Then
        '        ds = historico.Consultar_historico("d.alu_codigo = " & h_dropaluno.SelectedValue & "and a.dc_codigo=" & drop_trabDrop.SelectedValue & "")
        '        If ds.Tables(0).Rows.Count <> 0 Then
        '            MagicAjax.AjaxCallHelper.WriteAlert("A Disciplina: " & ds.Tables(0).Rows(0)("dc_disciplina") & " Já esta cadastrada para o Aluno: " & h_dropaluno.SelectedItem.Text & "")
        '        Else
        '            If Trim(h_txtcod.Text) = "" Then
        '                associar_historico()
        '                MagicAjax.AjaxCallHelper.WriteAlert(historico.Inserir)
        '                h_btnsalvar.Enabled = False
        '                h_btncancelar.Enabled = False
        '                limpa_historico()
        '                povoar_grid_historico()


        '                If Trim(h_txtcod.Text) <> "" Then
        '                    Associar_alterar_historico()
        '                    MagicAjax.AjaxCallHelper.WriteAlert(historico.Alterar)
        '                    h_btnsalvar.Enabled = False
        '                    h_btncancelar.Enabled = False
        '                    limpa_historico()
        '                    povoar_grid_historico()
        '                End If
        '            End If
        '        End If
        '    End If
        'End If
    End Sub

    Protected Sub ImageButton32_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton32.Click
        Dim Ds As New Data.DataSet
        DataGrid_historico.CurrentPageIndex = 0
        Try

        Catch ex As Exception

        End Try
        If h_dropaluno.SelectedValue <> "" Then
            historico.receberconexao = Session("Unidade")
            Ds = historico.Consultar_historico("d.alu_codigo = " & h_dropaluno.SelectedValue & "")
            DataGrid_historico.DataSource = Ds
            DataGrid_historico.DataBind()

            If Ds.Tables(0).Rows.Count = 0 Then
                Fn.Alerta(Message.exibirmenssagem_historico(), Page)
            End If
        End If
    End Sub

    Protected Sub DataGrid_historico_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles DataGrid_historico.DeleteCommand
        Dim Ds As Data.DataSet
        If e.CommandName = "delete" Then
            historico.receberconexao = Session("Unidade")
            Ds = historico.Consultar("his_Codigo = " & e.Item.Cells(0).Text & "")
            MagicAjax.AjaxCallHelper.WriteAlert(historico.Excluir("his_Codigo = " & e.Item.Cells(0).Text & ""))
            'Fn.Alerta(historico.Excluir("his_Codigo = " & e.Item.Cells(0).Text & ""), Page)
            povoar_grid_historico()
        End If
    End Sub

    Protected Sub DataGrid_historico_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles DataGrid_historico.ItemCommand
        If e.CommandName = "Edite" Then
            Dim Ds As New Data.DataSet
            historico.receberconexao = Session("Unidade")
            novo_historico()
            Ds = historico.Consultar("his_Codigo = " & e.Item.Cells(0).Text & "")
            ViewState("his_Codigo") = Ds.Tables(0).Rows(0)("his_Codigo")
            h_txtcod.Text = Ds.Tables(0).Rows(0)("his_codigo")
            '*****************************************************************
            'novo_historico()
            'disciplina_professor()
            'drop_trabDrop.SelectedValue = Ds.Tables(0).Rows(0)("dc_codigo")
            h_dropaluno.SelectedValue = Ds.Tables(0).Rows(0)("alu_codigo")
            h_dropprofessor.SelectedValue = Ds.Tables(0).Rows(0)("pc_codigo")
            h_txthora.Text = Ds.Tables(0).Rows(0)("his_cargahora")
            h_txtfrequencia.Text = Ds.Tables(0).Rows(0)("his_frequencia")
            If Not IsDBNull(Ds.Tables(0).Rows(0)("his_nota")) Then h_txtnotas.Text = Ds.Tables(0).Rows(0)("his_nota")
            h_faltas.Text = Ds.Tables(0).Rows(0)("his_faltas")
            If Not IsDBNull(Ds.Tables(0).Rows(0)("his_nota2")) Then h_txtnota2.Text = Ds.Tables(0).Rows(0)("his_nota2")
            If Not IsDBNull(Ds.Tables(0).Rows(0)("his_nota3")) Then h_txtnota3.Text = Ds.Tables(0).Rows(0)("his_nota3")
            h_txtmedia.Text = Ds.Tables(0).Rows(0)("his_media")
            disciplina_professor()
        End If
    End Sub

    Protected Sub DataGrid_historico_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles DataGrid_historico.ItemDataBound
        Dim Btnexcluir As New LinkButton
        If e.Item.ItemType = ListItemType.Item Or e.Item.ItemType = ListItemType.AlternatingItem Then
            Btnexcluir = e.Item.Cells(8).Controls(0)
            Btnexcluir.Attributes.Add("onclick", "javascript:return" + " confirm('Deseja realmente excluir este registro?')")
        End If
    End Sub

    Protected Sub DataGrid_historico_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles DataGrid_historico.PageIndexChanged
        DataGrid_historico.CurrentPageIndex = e.NewPageIndex
        povoar_grid_historico()
    End Sub

    Protected Sub ImageButton34_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton34.Click
        novo_prof_curso()
        aspc_txtcod.Text = ""
        MagicAjax.AjaxCallHelper.FocusControl(aspc_curso)
    End Sub

    Protected Sub ImageButton36_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles aspc_btncancela.Click
        lipar_prof_curso()
        povoar_datagrid_prof_curso()
    End Sub

    Protected Sub aspc_btnsalvar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles aspc_btnsalvar.Click
        Dim ds As New Data.DataSet
        prof_curso.receberconexao = Session("Unidade")
        If aspc_curso.SelectedItem.Text = "************ Selecione o Curso ****************" Or aspc_dropdisciplina.SelectedItem.Text = "********** Selecione uma Disciplina *************" Or aspc_professor.SelectedItem.Text = "********** Selecione um Professor *************" Then
            MagicAjax.AjaxCallHelper.WriteAlert("Os seguintes campos são obrigatórios: Curso, Disciplina, Professor")
            'Fn.Alerta("Os seguintes campos são obrigatórios: Curso, Disciplina, Professor", Page)
        Else
            If Trim(ViewState("pc_codigo")) = "" Then
                If aspc_txtcod.Text = "" Then
                    ds = prof_curso.Consultar("prof_codigo = " & aspc_professor.SelectedValue & "and cur_codigo=" & aspc_curso.SelectedValue & "and dc_codigo=" & aspc_dropdisciplina.SelectedValue & "")
                    If ds.Tables(0).Rows.Count <> 0 Then
                        MagicAjax.AjaxCallHelper.WriteAlert("Esta associação curso, disciplina e professor já foi cadastrada!, Operação cancelada")
                        lipar_prof_curso()
                    Else
                        'If Trim(ViewState("pc_codigo")) = "" Then
                        ' If aspc_txtcod.Text = "" Then
                        associar_prof_curso()
                        MagicAjax.AjaxCallHelper.WriteAlert(prof_curso.Inserir)
                        povoar_datagrid_prof_curso()
                        lipar_prof_curso()
                    End If
                Else
                    If Trim(aspc_txtcod.Text) <> "" Then
                        associar_prof_curso_alterar()
                        MagicAjax.AjaxCallHelper.WriteAlert(prof_curso.Alterar)
                        povoar_datagrid_prof_curso()
                        lipar_prof_curso()
                    End If
                    End If
                End If
            End If
    End Sub

    Protected Sub ImageButton37_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton37.Click
        Dim Ds As New Data.DataSet
        Try
        Catch ex As Exception
        End Try
        If aspc_curso.SelectedValue <> "" Then
            prof_curso.receberconexao = Session("Unidade")
            Ds = prof_curso.Consultar_prof_curso("a.cur_codigo = " & aspc_curso.SelectedValue & "")
            DataGrid_prof_curso.DataSource = Ds
            DataGrid_prof_curso.DataBind()
            If Ds.Tables(0).Rows.Count = 0 Then
                MagicAjax.AjaxCallHelper.WriteAlert(Message.exibirmenssagem_prof_curso())
            End If
        End If
    End Sub
    Protected Sub disciplina_professor()
        Dim Ds As New Data.DataSet
        Try
        Catch ex As Exception
        End Try
        Disciplina.receberconexao = Session("Unidade")
        Ds = Disciplina.Consultar_diaridis("c.prof_codigo =" & h_dropprofessor.SelectedValue & "")
        drop_trabDrop.DataSource = Ds
        drop_trabDrop.DataBind()
        drop_trabDrop.Items.Insert(0, New ListItem("************* Selecione a Disciplina *************", String.Empty))
    End Sub
    Protected Sub h_dropprofessor_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles h_dropprofessor.SelectedIndexChanged
        disciplina_professor()
    End Sub

    Protected Sub dro_disciplina_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dro_disciplina.SelectedIndexChanged
        Dim Ds As New Data.DataSet
        Try
        Catch ex As Exception
        End Try
        Disciplina.receberconexao = Session("Unidade")
        Ds = Disciplina.Consultar("a.dc_codigo =" & dro_disciplina.SelectedValue & "")
        'ViewState("Codigo") = Ds.Tables(0).Rows(0)("dc_coddisciplina")
        di_txtcoddisciplina.Text = Ds.Tables(0).Rows(0)("DC_CODDISCIPLINA")
        di_txtmod.Text = Ds.Tables(0).Rows(0)("mod_modulo")
        hi_txthorapra.Text = Ds.Tables(0).Rows(0)("dc_chpratica")
        hi_txtorate.Text = Ds.Tables(0).Rows(0)("dc_chteorica")
    End Sub

    Protected Sub ImageButton23_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton23.Click
        dro_txtinicio.Text = ""
        dro_txttermino.Text = ""
        di_txtcoddisciplina.Text = ""
        di_txtmod.Text = ""
    End Sub

    Protected Sub ImageButton33_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton33.Click
        Multicertificado.ActiveViewIndex = 7
        povoar_alu_hist_imp()
    End Sub

    Protected Sub Hit_dropaluno_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Hit_dropaluno.SelectedIndexChanged
        Dim Ds As New Data.DataSet
        Try
        Catch ex As Exception
        End Try
        historico.receberconexao = Session("Unidade")
        hit_drocurso.Items.Clear()
        Ds = historico.Consultar_Imprimir("a.alu_codigo =" & Hit_dropaluno.SelectedValue & "")
        hit_drocurso.DataSource = Ds
        hit_drocurso.DataBind()
        hit_drocurso.Items.Insert(0, New ListItem("**************** Informe o Curso ******************", String.Empty))
    End Sub

    Protected Sub ImageButton24_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton24.Click
        Dim Script As String
        If Hit_dropaluno.SelectedValue <> "" And hit_drocurso.SelectedValue <> "" And hit_txtinstituicao.Text <> "" And hit_txtinicio.Text <> "" And hit_txttermino.Text <> "" Then
            'função com o abre janela
            Script = "window.open('relhistorico.aspx?palu_codigo=" & Hit_dropaluno.SelectedValue & "&pcurso=" & hit_drocurso.SelectedItem.Text & "&paluno=" & Hit_dropaluno.SelectedItem.Text & "&pint=" & hit_txtinstituicao.Text & "&pinicio=" & hit_txtinicio.Text & "&pterm=" & hit_txttermino.Text & "&pobs=" & hit_txtobs.Text & _
                      "','','fullscreen=no,scrollbars=1,titlebar=0,status=0,directories=0,menubar=1,location=0,resizable=1','');"

            '"','','height=800,width=600,status=no,toolbar=no,menubar=no,location=no','');"
            MagicAjax.AjaxCallHelper.WriteAddScriptElementScript(Script, New System.Collections.Specialized.NameValueCollection)
            'MagicAjax.AjaxCallHelper.Redirect("relhistorico.aspx?palu_codigo=" & Hit_dropaluno.SelectedValue & "&pcurso=" & hit_drocurso.SelectedItem.Text & "&paluno=" & Hit_dropaluno.SelectedItem.Text & "&pint=" & hit_txtinstituicao.Text & "&pinicio=" & hit_txtinicio.Text & "&pterm=" & hit_txttermino.Text & "&pobs=" & hit_txtobs.Text)
        Else
            'If Hit_dropaluno.SelectedValue = "" And hit_drocurso.SelectedValue = "" And hit_txtinstituicao.Text = "" And hit_txtinicio.Text = "" And hit_txttermino.Text = "" Then
            MagicAjax.AjaxCallHelper.WriteAlert("Os campos: Aluno, Curso, Instituição, Início e Termino do curso são de preenchimento obrigatório!")
            'Fn.Alerta("Os campos: Aluno, Curso, Instituição, Início e Termino do curso são de preenchimento obrigatório!", Page)
        End If
    End Sub

    Protected Sub DataGridaluno_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles DataGridaluno.PageIndexChanged
        DataGridaluno.CurrentPageIndex = e.NewPageIndex
        povoaalunos()
    End Sub

    Protected Sub ImageButton21_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton21.Click
        hit_txtinicio.Text = ""
        hit_txttermino.Text = ""
        hit_txtobs.Text = ""
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        FormsAuthentication.SetAuthCookie(Session("usu_nome"), True)
        If Session("usu_nome") = "" Then
            'MagicAjax.AjaxCallHelper.WriteAlert("Por favor, informe seu login e senha antes de entrar no sistema.")
            'Fn.Alerta("Por favor, informe seu login e senha antes de entrar no sistema.", Page)
            'MagicAjax.AjaxCallHelper.Redirect("..\index.aspx")
            Response.Redirect("..\index.aspx", True)
        Else
            If Session("usu_nome") <> "" Then
                If Not Page.IsPostBack Then
                End If
                FormsAuthentication.SetAuthCookie(Session("usu_nome"), True)
                If CInt(Hour(TimeOfDay)) >= 6 And CInt(Hour(TimeOfDay)) < 12 Then
                    lbsau.Text = "Bom Dia" ',bem vindo ao site do Instituto Centec"
                End If
                If CInt(Hour(TimeOfDay)) >= 12 And CInt(Hour(TimeOfDay)) < 18 Then
                    lbsau.Text = "Boa Tarde" ',bem vindo ao site do Instituto Centec"
                End If
                If CInt(Hour(TimeOfDay)) >= 18 And CInt(Hour(TimeOfDay)) < 24 Then
                    lbsau.Text = "Boa Noite" ',bem vindo ao site do Instituto Centec"
                End If
                If CInt(Hour(TimeOfDay)) >= 0 And CInt(Hour(TimeOfDay)) <= 5 Then
                    lbsau.Text = "Boa Madrugada" ',bem vindo ao site do Instituto Centec"
                End If
            End If
        End If
    End Sub

    Protected Sub a_txtnascimento_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles a_txtnascimento.TextChanged
        Dim d1 As String
        Dim resp As Date
        Dim ciDe As New CultureInfo("pt-br")

        d1 = a_txtnascimento.Text

        Try
            resp = Date.Parse(d1, ciDe.DateTimeFormat)
        Catch e1 As Exception
            MagicAjax.AjaxCallHelper.WriteAlert("Data de nascimento invalida!")
            'Fn.Alerta("Data de nascimento invalida! ", Page)
            a_txtnascimento.Text = ""
            MagicAjax.AjaxCallHelper.FocusControl(a_txtnascimento)
        End Try
    End Sub

    Protected Sub a_txtano_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles a_txtano.TextChanged
        Dim d1 As String
        Dim resp As Date
        Dim ciDe As New CultureInfo("pt-br")

        d1 = a_txtano.Text

        Try
            resp = Date.Parse(d1, ciDe.DateTimeFormat)
        Catch e1 As Exception
            MagicAjax.AjaxCallHelper.WriteAlert("Informe uma data valida para Instituição!")
            a_txtano.Text = ""
            MagicAjax.AjaxCallHelper.FocusControl(a_txtano)
        End Try
    End Sub

    Protected Sub a_txtanotitulacao_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles a_txtanotitulacao.TextChanged
        Dim d1 As String
        Dim resp As Date
        Dim ciDe As New CultureInfo("pt-br")

        d1 = a_txtanotitulacao.Text

        Try
            resp = Date.Parse(d1, ciDe.DateTimeFormat)
        Catch e1 As Exception
            MagicAjax.AjaxCallHelper.WriteAlert("Informe uma data valida para Titulação máxima! ")
            a_txtanotitulacao.Text = ""
            MagicAjax.AjaxCallHelper.FocusControl(a_txtanotitulacao)
        End Try
    End Sub

    Protected Sub p_txtingresso_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles p_txtingresso.TextChanged
        Dim d1 As String
        Dim resp As Date
        Dim ciDe As New CultureInfo("pt-br")

        d1 = p_txtingresso.Text

        Try
            resp = Date.Parse(d1, ciDe.DateTimeFormat)
        Catch e1 As Exception
            MagicAjax.AjaxCallHelper.WriteAlert("Informe uma data de Ingresso valida! ")
            p_txtingresso.Text = ""
            MagicAjax.AjaxCallHelper.FocusControl(p_txtingresso)
        End Try
    End Sub

    Protected Sub dro_txtinicio_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dro_txtinicio.TextChanged
        Dim d1 As String
        Dim resp As Date
        Dim ciDe As New CultureInfo("pt-br")

        d1 = dro_txtinicio.Text

        Try
            resp = Date.Parse(d1, ciDe.DateTimeFormat)
        Catch e1 As Exception
            MagicAjax.AjaxCallHelper.WriteAlert("Informe uma data início valida! ")
            dro_txtinicio.Text = ""
            MagicAjax.AjaxCallHelper.FocusControl(dro_txtinicio)
        End Try
    End Sub

    Protected Sub dro_txttermino_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dro_txttermino.TextChanged
        Dim d1 As String
        Dim resp As Date
        Dim ciDe As New CultureInfo("pt-br")

        d1 = dro_txttermino.Text

        Try
            resp = Date.Parse(d1, ciDe.DateTimeFormat)
        Catch e1 As Exception
            MagicAjax.AjaxCallHelper.WriteAlert("Informe uma data término valida! ")
            dro_txttermino.Text = ""
            MagicAjax.AjaxCallHelper.FocusControl(dro_txttermino)
        End Try
    End Sub

    Protected Sub hit_txtinicio_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles hit_txtinicio.TextChanged
        Dim d1 As String
        Dim resp As Date
        Dim ciDe As New CultureInfo("pt-br")

        d1 = hit_txtinicio.Text

        Try
            resp = Date.Parse(d1, ciDe.DateTimeFormat)
        Catch e1 As Exception
            MagicAjax.AjaxCallHelper.WriteAlert("Informe uma data início valida! ")
            hit_txtinicio.Text = ""
            MagicAjax.AjaxCallHelper.FocusControl(hit_txtinicio)
        End Try
    End Sub

    Protected Sub hit_txttermino_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles hit_txttermino.TextChanged
        Dim d1 As String
        Dim resp As Date
        Dim ciDe As New CultureInfo("pt-br")

        d1 = hit_txttermino.Text

        Try
            resp = Date.Parse(d1, ciDe.DateTimeFormat)
        Catch e1 As Exception
            MagicAjax.AjaxCallHelper.WriteAlert("Informe uma data término valida! ")
            hit_txttermino.Text = ""
            MagicAjax.AjaxCallHelper.FocusControl(hit_txttermino)
        End Try
    End Sub

    Protected Sub a_txtinicio_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles a_txtinicio.TextChanged
        Dim d1 As String
        Dim resp As Date
        Dim ciDe As New CultureInfo("pt-br")

        d1 = a_txtinicio.Text

        Try
            resp = Date.Parse(d1, ciDe.DateTimeFormat)
        Catch e1 As Exception
            MagicAjax.AjaxCallHelper.WriteAlert("Informe uma data inicio valida! ")
            a_txtinicio.Text = ""
            MagicAjax.AjaxCallHelper.FocusControl(a_txtinicio)
        End Try
    End Sub

    Protected Sub a_txtfim_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles a_txtfim.TextChanged
        Dim d1 As String
        Dim resp As Date
        Dim ciDe As New CultureInfo("pt-br")

        d1 = a_txtfim.Text

        Try
            resp = Date.Parse(d1, ciDe.DateTimeFormat)
        Catch e1 As Exception
            MagicAjax.AjaxCallHelper.WriteAlert("Data término invalida! ")
            a_txtfim.Text = ""
            MagicAjax.AjaxCallHelper.FocusControl(a_txtfim)
        End Try
    End Sub

    Protected Sub ImageButton3_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton3.Click
        MagicAjax.AjaxCallHelper.WriteAlert("Página em desenvolvimento")
    End Sub

    Protected Sub ImageButton8_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton8.Click
        MagicAjax.AjaxCallHelper.WriteAlert("Página em desenvolvimento")
    End Sub

    Protected Sub ImageButton12_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton12.Click
        MagicAjax.AjaxCallHelper.WriteAlert("Página em desenvolvimento")
    End Sub

    Protected Sub ImageButton16_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton16.Click
        MagicAjax.AjaxCallHelper.WriteAlert("Página em desenvolvimento")
    End Sub
    Protected Sub DataGrid_prof_curso_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles DataGrid_prof_curso.ItemDataBound
        Dim Btnexcluir As New LinkButton
        If e.Item.ItemType = ListItemType.Item Or e.Item.ItemType = ListItemType.AlternatingItem Then
            Btnexcluir = e.Item.Cells(4).Controls(0)
            Btnexcluir.Attributes.Add("onclick", "javascript:return" + " confirm('Deseja realmente excluir este registro?')")
        End If
    End Sub

    Protected Sub DataGrid_prof_curso_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles DataGrid_prof_curso.DeleteCommand
        Dim Ds As Data.DataSet
        If e.CommandName = "delete" Then
            prof_curso.receberconexao = Session("Unidade")
            Ds = prof_curso.Consultar("pc_Codigo = " & e.Item.Cells(0).Text & "")
            MagicAjax.AjaxCallHelper.WriteAlert(prof_curso.Excluir("pc_Codigo = " & e.Item.Cells(0).Text & ""))
            povoar_datagrid_prof_curso()
        End If

    End Sub

    Protected Sub DataGrid_prof_curso_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles DataGrid_prof_curso.ItemCommand
        If e.CommandName = "edit" Then
            Dim Ds As Data.DataSet
            prof_curso.receberconexao = Session("Unidade")
            Ds = prof_curso.Consultar("pc_Codigo = " & e.Item.Cells(0).Text & "")
            ViewState("pc_Codigo") = Ds.Tables(0).Rows(0)("pc_Codigo")
            aspc_txtcod.Text = Ds.Tables(0).Rows(0)("pc_codigo")
            '*****************************************************************
            novo_prof_curso()
            aspc_curso.SelectedValue = Ds.Tables(0).Rows(0)("cur_codigo")
            aspc_professor.SelectedValue = Ds.Tables(0).Rows(0)("prof_codigo")
            aspc_dropdisciplina.SelectedValue = Ds.Tables(0).Rows(0)("dc_codigo")
        End If

    End Sub
    
    Protected Sub DataGrid_prof_curso_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles DataGrid_prof_curso.PageIndexChanged
        DataGrid_prof_curso.CurrentPageIndex = e.NewPageIndex
        povoar_datagrid_prof_curso()
    End Sub



    Protected Sub ImageButton4_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton4.Click
        novoregistro()
        txtcodigoalu.Text = ""
        'a_txtidentificacao.Text = Format(Now, "yyyy") & Gera_codigo_a()
        MagicAjax.AjaxCallHelper.FocusControl(a_DropDowncurso)
    End Sub
    Public Function Gera_codigo_a() As Integer
        'Protected Sub GeraCodigoaluno(Byval  AS integer)
        'Criacao das variaveis
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
            'lCx.ConnectionString = "server=marcos\marcos;database=c_certificado;Trusted_Connection=Yes"
            lCx.ConnectionString = ConfigurationSettings.AppSettings("cStrConexao") & Session("Unidade")
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

    Public Function Gera_Codigocurso() As Integer
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
            lCx.ConnectionString = ConfigurationSettings.AppSettings("cStrConexao") & Session("Unidade")
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
    Public Function Gera_cod_certifi()
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
            lCx.ConnectionString = ConfigurationSettings.AppSettings("cStrConexao") & Session("Unidade")
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
    Public Function Gera_Codigo_disci() As Integer
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
            lCx.ConnectionString = ConfigurationSettings.AppSettings("cStrConexao") & Session("Unidade")
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
    Public Function Gera_Codigo_professor() As Integer
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
            lCx.ConnectionString = ConfigurationSettings.AppSettings("cStrConexao") & Session("Unidade")
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

    Public Function Gera_Codigoprof_curso() As Integer
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
            'lCx.ConnectionString = "server=marcos\marcos;database=c_certificado;Trusted_Connection=Yes"
            lCx.ConnectionString = ConfigurationSettings.AppSettings("cStrConexao") & Session("Unidade")
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

    Protected Sub a_DropDowncurso_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles a_DropDowncurso.SelectedIndexChanged
        Dim UND As String
        If Session("Unidade").ToString = "db_espsobral" Then
            UND = "3"
            a_txtidentificacao.Text = UND & Format(Now, "yyyy") & a_DropDowncurso.SelectedValue & Gera_codigo_a()
        Else
            If Session("Unidade").ToString = "db_esplimoeiro" Then
                UND = "2"
                a_txtidentificacao.Text = UND & Format(Now, "yyyy") & a_DropDowncurso.SelectedValue & Gera_codigo_a()

            Else
            End If
            If Session("Unidade").ToString = "db_espcariri" Then
                UND = "1"
                a_txtidentificacao.Text = UND & Format(Now, "yyyy") & a_DropDowncurso.SelectedValue & Gera_codigo_a()
            End If
        End If
    End Sub

    Protected Sub h_txtfrequencia_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles h_txtfrequencia.TextChanged
        'Dim thoras As Integer
        'Dim tfaltas As Integer
        'Dim freg As Decimal
        'thoras = (h_txthora.Text)
        'tfaltas = (h_faltas.Text)
        'freg = (thoras - tfaltas * 100 / thoras)
        'h_txtfrequencia.Text = (freg)
    End Sub

    Public Function Gera_Codigohistorico() As Integer
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
            'lCx.ConnectionString = "server=marcos\marcos;database=c_certificado;Trusted_Connection=Yes"
            lCx.ConnectionString = ConfigurationSettings.AppSettings("cStrConexao") & Session("Unidade")
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

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Paramentros da consulta
        Dim Parametro, Parametro2, Parametro3, Script As String
        Parametro = "&S_SEXO=" + hit_txtobs.Text
        Parametro2 = "&PR=" + Hit_dropaluno.SelectedItem.Text
        Parametro3 = "&DC=" + hit_drocurso.SelectedItem.Text
        Script = "window.open('http://marcos/ReportServer/DiarioAluno?%2fDiarioAluno&rs%3aCommand=Render&rc%3aParameters=False" + Parametro + Parametro2 + Parametro3 & _
         "','','fullscreen=0,scrollbars=1,titlebar=1,status=0,directories=0,menubar=0,location=0,resizable=1','');"

        'SCRIPT FUNCIONAL EM JAVA SCRIPT
        'Response.Write("<script>windows.open(\'http://localhost/ReportServer?%2frltRelatorio_produtos_Web%2fprodutos&rs%aClearSession=true" + Parametro + "&rs%3aCommand=Render&rs%3aFormat=HTML4.0&rc%3aToolbar=True&rc%3aParameters=False&rc%3aJavaScript=True&rc%3alinkTarget=_top&rc%3aArea=Toolbar','_blank','scrollbars=yes,resizable=yes,toolbar=no,menubar=no,location=no,width=750,height=400,left=25,top=50');</script>")

        MagicAjax.AjaxCallHelper.WriteAddScriptElementScript(Script, New System.Collections.Specialized.NameValueCollection)
    End Sub
End Class