'Analista: Marcos Felix
'Data: 21/08/2004

Imports Microsoft.VisualBasic
Imports System.Data.SqlClient

Public Class Menssagem

    Public Function exibirmenssagem_historico() As String


        Try
            'Cx.Open()
            'Cm.ExecuteNonQuery()
            Return "Nenhum Hist�rico foi encontrado para este aluno! "
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
            Return "Os seguintes campos s�o obrigat�rios: Aluno, Curso, Realiza��o do curso, Titulo da monografia! "
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
            Return "Os seguintes campos s�o obrigat�rios: Nome do professor, Forma��o, �rea de atua�ao, Titula��o, Data de ingresso, Unidade! "
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
            Return "Os seguintes campos s�o obrigat�rios: Disciplina, C�digo da disciplina, Carga hor�ria, Cr�ditos, Vig�ncia, M�dulo! "
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
            Return "Os seguintes campos s�o obrigat�rios: Curso, C�digo do curso, Resolu��o, Classifica��o, Portaria! "
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
            Return "Os seguintes campos s�o obrigat�rios: Nota, Professor, Disciplina, Monografia! "
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

