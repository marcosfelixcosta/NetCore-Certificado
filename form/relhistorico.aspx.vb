'Classe Histório
'Analista: Marcos Felix
'Data: 26/07/2004



Imports System.Data.SqlClient
Partial Class relhistorico
    Inherits System.Web.UI.Page
    Protected diario As New objdiario
    Protected historico As New objhistorico
    Private Fn As New classFuncao
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("usu_nome") = "" Then
            Response.Redirect("..\index.aspx", True)
        Else

            slRecebeParametros()
            lbimpresso.Text = "Data da impressão: " & Format(Now, "dddd/dd/MMMM/yyyy") & "  "
            lblobs.Text = "Situação acadêmica: " & ViewState("obs")
            lblcurso.Text = "Curso de Especialização em " & ViewState("curso")
            lblaluno.Text = "Aluno(a): " & ViewState("aluno")
            lblrealizacao.Text = "Realização:" & ViewState("instituicao")
            lblperiodo.Text = "Período:" & ViewState("inicio") & " a " & ViewState("termino")
            slMontaGrid()
        End If
    End Sub
    Private Sub slRecebeParametros()
        ViewState("codigo") = Request("palu_codigo")
        ViewState("curso") = Request("pcurso")
        ViewState("aluno") = Request("paluno")
        ViewState("instituicao") = Request("pint")
        ViewState("inicio") = Request("pinicio")
        ViewState("termino") = Request("pterm")
        ViewState("obs") = Request("pobs")
    End Sub
    Private Sub slMontaGrid()
        Dim Ds As New Data.DataSet
        Dim dssiario As New Data.DataSet
        Try
        Catch ex As Exception
        End Try
        'If dro_curso.SelectedValue <> "" Then
        historico.receberconexao = Session("Unidade")
        Ds = historico.Consultar_historico_aluno("d.alu_codigo = " & ViewState("codigo")) '& " AND a.alu_periodo >= '" & ViewState("inicio") & "' AND a.alu_termino <= '" & ViewState("termino") & "' ")
        'Fn.AbreJanela("rptlistafrequencia.aspx?pcur_codigo=" & dro_curso.SelectedValue & "&palu_inicio=" & dro_txtinicio.Text & "&palu_termino=" & dro_txttermino.Text, "", "", "", Page)
        'Ds = diario.Consultar_diario(" b.cur_codigo = " & lblReferenciaC.Text & " AND a.alu_periodo >= '" & lblReferenciaH.Text & "' AND a.alu_termino <= '" & Label9.Text & "' ")
        dssiario = Ds
        dtg1.DataSource = Ds
        dtg1.DataBind()
        Fn.Imprimir(Page)
    End Sub
End Class
