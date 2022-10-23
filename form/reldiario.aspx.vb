'Classe Frequencia Aluno
'Analista: Marcos Felix
'Data: 28/07/2004



Imports System.Data.SqlClient
Partial Class Frequencia
    Inherits System.Web.UI.Page
    Protected diario As New objdiario
    Private Fn As New classFuncao
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim vl1 As Integer
        Dim Vl2 As Integer
        Dim vlsoma As Integer
        If Session("usu_nome") = "" Then
            Response.Redirect("..\index.aspx", True)
        Else
            slRecebeParametros()
            lbimpresso.Text = "Data da impressão: " & Format(Now, "dddd/dd/MMMM/yyyy") & "  "
            lbdisciplina.Text = ViewState("disciplina")
            lbcurso.Text = ViewState("cursonome")
            lbprofessor.Text = ViewState("professor")
            lbmes.Text = UCase(Format(Now, "MMMM/yyyy"))
            vl1 = CInt(ViewState("hpratica"))
            Vl2 = CInt(ViewState("horap"))
            vlsoma = vl1 + Vl2
            lbch.Text = CStr(vlsoma)
            'lbch.Text = ViewState("hpratica") & ViewState("horap")
            slMontaGrid()

            'lblTurma.Text = ViewState("turno")
            'lblCurso.Text = ViewState("cursonome")
            'lblPeriodo.Text = ViewState("inicio") + " a " + ViewState("termino")
            'lblDisciplina.Text = ViewState("disciplina")
            'lblProfessor.Text = ViewState("professor")
            'lblTurma.Text = ViewState("modulo")
            'lblPeriodoC.Text = "Ref." & UCase(Format(Now, "MMMM/yyyy"))
            'lblReferenciaH.Text = UCase(Format(Now, "MMMM/yyyy"))
            'lblsigla.Text = ViewState("sigla") & "-"
            'lblDisciplinaC.Text = "Disciplina:" & ViewState("sigla")
            'lblTurmaC.Text = lblTurma.Text
            'lblProfessorC.Text = lblProfessor.Text
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
        'If dro_curso.SelectedValue <> "" Then
        diario.receberconexao = Session("Unidade")
        Ds = diario.Consultar_diario("b.cur_codigo = " & ViewState("curso") & " AND a.alu_periodo >= '" & ViewState("inicio") & "' AND a.alu_termino <= '" & ViewState("termino") & "' ")
        'Fn.AbreJanela("rptlistafrequencia.aspx?pcur_codigo=" & dro_curso.SelectedValue & "&palu_inicio=" & dro_txtinicio.Text & "&palu_termino=" & dro_txttermino.Text, "", "", "", Page)
        'Ds = diario.Consultar_diario(" b.cur_codigo = " & lblReferenciaC.Text & " AND a.alu_periodo >= '" & lblReferenciaH.Text & "' AND a.alu_termino <= '" & Label9.Text & "' ")
        dssiario = Ds
        DataGrid_diario.DataSource = Ds
        DataGrid_diario.DataBind()
        Fn.Imprimir(Page)
    End Sub
End Class
