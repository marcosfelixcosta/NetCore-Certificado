'Analista: Marcos Felix
'Data: 21/08/2004

Imports Microsoft.VisualBasic
Imports System.Data.SqlClient

Public Class Menssagem

    Public Function exibirmenssagem_historico() As String


        Try
            'Cx.Open()
            'Cm.ExecuteNonQuery()
            Return "Nenhum Histórico foi encontrado para este aluno! "
        Catch ex As Exception
            Return "Erro ao alterar os dados!"
        Finally
            'Cx.Close()
            ' Cx = Nothing
            'Cm = Nothing
            'Sql = Nothing
        End Try
    End Function
    Public Function exibirmenssagem_prof_curso() As String


        Try
            'Cx.Open()
            'Cm.ExecuteNonQuery()
            Return "Nenhum registro foi encontrado! "
        Catch ex As Exception
            Return "Erro ao alterar os dados!"
        Finally
            'Cx.Close()
            ' Cx = Nothing
            'Cm = Nothing
            'Sql = Nothing
        End Try
    End Function

    Public Function exibirmenssagem_certificadofrente() As String
       

        Try
            'Cx.Open()
            'Cm.ExecuteNonQuery()
            Return "Os seguintes campos são obrigatórios: Aluno, Curso, Realização do curso, Titulo da monografia! "
        Catch ex As Exception
            Return "Erro ao alterar os dados!"
        Finally
            'Cx.Close()
            ' Cx = Nothing
            'Cm = Nothing
            'Sql = Nothing
        End Try
    End Function

    Public Function exibirmenssagem_Professor() As String
       

        Try
            'Cx.Open()
            'Cm.ExecuteNonQuery()
            Return "Os seguintes campos são obrigatórios: Nome do professor, Formação, Área de atuaçao, Titulação, Data de ingresso, Unidade! "
        Catch ex As Exception
            Return "Erro ao alterar os dados!"
        Finally
            'Cx.Close()
            ' Cx = Nothing
            'Cm = Nothing
            'Sql = Nothing
        End Try
    End Function

    Public Function exibirmenssagem_disciplina() As String
      
        Try
            'Cx.Open()
            'Cm.ExecuteNonQuery()
            Return "Os seguintes campos são obrigatórios: Disciplina, Código da disciplina, Carga horária, Créditos, Vigência, Módulo! "
        Catch ex As Exception
            Return "Erro ao alterar os dados!"
        Finally
            'Cx.Close()
            ' Cx = Nothing
            'Cm = Nothing
            'Sql = Nothing
        End Try
    End Function

    Public Function exibirmenssagem_curso() As String
        

        Try
            'Cx.Open()
            'Cm.ExecuteNonQuery()
            Return "Os seguintes campos são obrigatórios: Curso, Código do curso, Resolução, Classificação, Portaria! "
        Catch ex As Exception
            Return "Erro ao alterar os dados!"
        Finally
            'Cx.Close()
            ' Cx = Nothing
            'Cm = Nothing
            'Sql = Nothing
        End Try
    End Function

    Public Function exibirmenssagem_certificadoverso() As String
      

        Try
            'Cx.Open()
            'Cm.ExecuteNonQuery()
            Return "Os seguintes campos são obrigatórios: Nota, Professor, Disciplina, Monografia! "
        Catch ex As Exception
            Return "Erro ao alterar os dados!"
        Finally
            'Cx.Close()
            ' Cx = Nothing
            'Cm = Nothing
            'Sql = Nothing
        End Try
    End Function

End Class

