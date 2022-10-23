'Classe Frenquencia
'Analista: Marcos Felix
'Data: 10/07/2004



Imports System.Data.SqlClient


Partial Class rptlistafrequencia_
    Inherits System.Web.UI.Page
    Protected diario As New objdiario

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub


    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

    Private Fn As New classFuncao

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim vl1 As Integer
        Dim Vl2 As Integer
        Dim vlsoma As Integer
        If Session("usu_nome") = "" Then
            Response.Redirect("..\index.aspx", True)
        Else
            slRecebeParametros()
            lblDataImpressao.Text = "Data da impressão: " & Format(Now, "dddd/dd/MMMM/yyyy") & "  "
            lblTurma.Text = ViewState("turno")
            lblCurso.Text = ViewState("cursonome")
            lblPeriodo.Text = ViewState("inicio") + " a " + ViewState("termino")
            lblDisciplina.Text = ViewState("disciplina")
            lblProfessor.Text = ViewState("professor")
            lblTurma.Text = ViewState("modulo")
            lblPeriodoC.Text = "Ref." & UCase(Format(Now, "MMMM/yyyy"))
            lblReferenciaH.Text = UCase(Format(Now, "MMMM/yyyy"))
            lblsigla.Text = ViewState("sigla") & "-"
            lblDisciplinaC.Text = "Disciplina:" & ViewState("sigla")
            lblTurmaC.Text = lblTurma.Text
            'lblhora.Text = ViewState("horateorica") & ViewState("horapratica")
            vl1 = CInt(ViewState("hpratica"))
            Vl2 = CInt(ViewState("horap"))
            vlsoma = vl1 + Vl2
            lblhora.Text = CStr(vlsoma)
            lblProfessorC.Text = lblProfessor.Text
            lblOpcionalC.Text = " C/Hora: " & lblhora.Text

            'lblReferenciaH.Text = MonthName(ViewState("mes")) & Format(Now, "/yyyy")
            'lblReferenciaC.Text = "Ref.: " & MonthName(ViewState("mes")) & Format(Now, "/yyyy")
            'If Trim(Request("pTur")) <> "" Then
            'lblReferenciaC.Text = ViewState("curso")
            'lblReferenciaH.Text = ViewState("inicio")
            'Label9.Text = ViewState("termino")
            slMontaGrid()
            '		ViewState("turma") = Request("pTur")
            '		ViewState("periodo") = Request("pPer")
            '		ViewState("mes") = Request("pMes")
            '		slInicializaform()
            '		Fn.Imprimir(Page)
        End If
    End Sub
    Private Sub slRecebeParametros()
        ViewState("curso") = Request("pcur_codigo")
        ViewState("inicio") = Request("palu_inicio")
        ViewState("termino") = Request("palu_termino")
        ViewState("cursonome") = Request("pcurso")
        ViewState("professor") = Request("pprofessor")
        ViewState("disciplina") = Request("pdisciplina")
        ViewState("turno") = Request("pturno")
        ViewState("mes") = Request("pmes")
        ViewState("sigla") = Request("psigla")
        ViewState("modulo") = Request("pmodulo")
        ViewState("hpratica") = Request("phpratica")
        ViewState("hteorica") = Request("phprate")
        ViewState("horap") = Request("pht")

    End Sub
    Private Sub slMontaGrid()

        Dim Ds As New Data.DataSet
        Dim dssiario As New Data.DataSet
        Try

        Catch ex As Exception

        End Try
        diario.receberconexao = Session("Unidade")
        'If dro_curso.SelectedValue <> "" Then
        Ds = diario.Consultar_diario("b.cur_codigo = " & ViewState("curso") & " AND a.alu_periodo >= '" & ViewState("inicio") & "' AND a.alu_termino <= '" & ViewState("termino") & "' ")
        'Fn.AbreJanela("rptlistafrequencia.aspx?pcur_codigo=" & dro_curso.SelectedValue & "&palu_inicio=" & dro_txtinicio.Text & "&palu_termino=" & dro_txttermino.Text, "", "", "", Page)
        'Ds = diario.Consultar_diario(" b.cur_codigo = " & lblReferenciaC.Text & " AND a.alu_periodo >= '" & lblReferenciaH.Text & "' AND a.alu_termino <= '" & Label9.Text & "' ")
        dssiario = Ds
        dtg1.DataSource = Ds
        dtg2.DataSource = Ds
        dtg1.DataBind()
        dtg2.DataBind()
        Fn.Imprimir(Page)
    End Sub

End Class

