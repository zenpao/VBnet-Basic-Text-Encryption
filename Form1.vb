Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Function encrypt(text As String, v As Long) As String
        Dim total As String
        Dim tmp As String
        For i = 1 To Len(text)
            tmp = Mid(text, i, 1)
            tmp = Asc(tmp) + v
            tmp = Chr(tmp)
            total = total & tmp
        Next i
        encrypt = total
    End Function

    Public Function decrypt(text As String, v As Long) As String
        Dim total As String
        Dim tmp As String
        For i = 1 To Len(text)
            tmp = Mid(text, i, 1)
            tmp = Asc(tmp) - v
            tmp = Chr(tmp)
            total = total & tmp
        Next i
        decrypt = total
    End Function

    Private Sub btn_Encrypt_Click(sender As Object, e As EventArgs) Handles btn_Encrypt.Click
        txt_String.Text = encrypt(txt_String.Text, 3)
    End Sub

    Private Sub btn_Decrypt_Click(sender As Object, e As EventArgs) Handles btn_Decrypt.Click
        txt_String.Text = decrypt(txt_String.Text, 3)
    End Sub

End Class

