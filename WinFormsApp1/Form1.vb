Public Class Form1
    Private Sub ingresar_Click(sender As Object, e As EventArgs) Handles ingresar.Click
        Dim user, pass As String
        user = usuario.Text
        pass = contraseña.Text
        If user = "Randon@gmail.com" And pass = "456789" Then
            Firmprincipal.Show()
            Me.Hide()
        Else
            MsgBox("usuario o contraseña incorrecta")
        End If
    End Sub
End Class
