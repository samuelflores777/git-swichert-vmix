Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text = "" Then
            MsgBox("EL CUADRO DE ID WEB ESTÁ VACIO", , "ERROR")
        Else
            ' Form3.Text = "SAM CTRL VMIX: " + Me.TextBox1.Text
            IDEWEB = Me.TextBox1.Text
            Form3.Button35.ForeColor = Color.White
            Form3.TextBox33.Text = IDEWEB
            Form3.Enabled = True
            Me.Close()
        End If
    End Sub
    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form3.Enabled = True
    End Sub
End Class
