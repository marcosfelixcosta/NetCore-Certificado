'********************************************************************
' Classe de implementação de funções de criptografia
' Autor: Marcos Felix - 28/10/2005
'********************************************************************

Imports System.Security.Cryptography
Imports System.Text


Namespace conacnet


Public Class classMD5

	'********************************************************************
	' Procedimento para limpar os campos do formulário
	' Implementação: MD5("valor")
	'********************************************************************
	Public Shared Function MD5(ByVal valor As String) As String

		Dim ASCIIenc As New ASCIIEncoding
		Dim Md5Hash As New MD5CryptoServiceProvider
		Dim strReturn As String
		Dim b As Byte

		'Retrieve a byte array based on the source text
		Dim ByteSourceText() As Byte = ASCIIenc.GetBytes(valor)

		'Compute the hash value from the source
		Dim ByteHash() As Byte = Md5Hash.ComputeHash(ByteSourceText)

		For Each b In ByteHash		'Cycle through the hash and convert to string
			strReturn &= b.ToString("x2")			'Convert byte(s) to string
		Next

		Return strReturn

	End Function

End Class

End Namespace
