'Analista: Marcos Felix
'Data: 25/07/2004

Public Class clFuncaoGeral

    Public Enum OpcaoFormata
        ForCep = 1
        ForData = 2
        forCNPJ = 3
        forCPF = 4
        forTelefone = 5
    End Enum

    Public Function gfFormataCampo(ByVal Opcao As OpcaoFormata, ByVal txtTexto As TextBox)

        Select Case Opcao

            Case OpcaoFormata.ForData

                If Len(txtTexto.Text) = 2 Then 'Or Len(txtTexto.Text) = 5 Then
                    txtTexto.Text = txtTexto.Text & "/"
                Else
                    If Len(txtTexto.Text) = 5 Then
                        txtTexto.Text = txtTexto.Text & "/"
                        'txtTexto.AutoCompleteType = Len(txtTexto.Text) + 1
                    End If
                End If
            Case OpcaoFormata.ForCep

                If Len(txtTexto.Text) = 5 Then
                    txtTexto.Text = txtTexto.Text & "-"
                    'txtTexto.SelectionStart = Len(txtTexto.Text) + 1
                End If

            Case OpcaoFormata.forCNPJ

                If Len(txtTexto.Text) = 2 Or Len(txtTexto.Text) = 6 Then
                    txtTexto.Text = txtTexto.Text & "."
                    'txtTexto.SelectionStart = Len(txtTexto.Text) + 1
                End If

                If Len(txtTexto.Text) = 10 Then
                    txtTexto.Text = txtTexto.Text & "/"
                    'txtTexto.SelectionStart = Len(txtTexto.Text) + 1
                End If

                If Len(txtTexto.Text) = 15 Then
                    txtTexto.Text = txtTexto.Text & "-"
                    'txtTexto.SelectionStart = Len(txtTexto.Text) + 1
                End If

            Case OpcaoFormata.forCPF

                If Len(txtTexto.Text) = 3 Then
                    txtTexto.Text = txtTexto.Text & "."
                    'txtTexto.SelectionStart = Len(txtTexto.Text) + 1
                ElseIf Len(txtTexto.Text) = 7 Then
                    txtTexto.Text = txtTexto.Text & "."
                    ' txtTexto.SelectionStart = Len(txtTexto.Text) + 1
                ElseIf Len(txtTexto.Text) = 11 Then
                    txtTexto.Text = txtTexto.Text & "-"
                    ' txtTexto.SelectionStart = Len(txtTexto.Text) + 1
                End If

            Case OpcaoFormata.forTelefone

                If Len(txtTexto.Text) = 0 Then
                    txtTexto.Text = txtTexto.Text & "("
                    ' txtTexto.SelectionStart = Len(txtTexto.Text) + 1
                ElseIf Len(txtTexto.Text) = 3 Then
                    txtTexto.Text = txtTexto.Text & ")"
                    'txtTexto.SelectionStart = Len(txtTexto.Text) + 1
                ElseIf Len(txtTexto.Text) = 8 Then
                    txtTexto.Text = txtTexto.Text & "-"
                    'txtTexto.SelectionStart = Len(txtTexto.Text) + 1
                End If


        End Select
    End Function

End Class
