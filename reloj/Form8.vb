Public Class Form8
    Public Shared _instancia As Form8
    Public Function getinstancia() As Form8
        If (_instancia Is Nothing) Then
            _instancia = New Form8
        End If
        Return _instancia
    End Function

    Private Sub Form8_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        MDIParent1.AUDIOToolStripMenuItem1.Checked = False
    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form8_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        _instancia = Nothing
    End Sub

    Private Sub Button21_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button21.MouseDown
        Dim inputPLAY As String
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            inputPLAY = InputBox("ASIGNE NUMERO DE PISTA", "PLAY NUM. PISTA")
            Button21.Text = "PLAY (" + inputPLAY + ")"
            TextBox1.Text = inputPLAY
        End If
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click

    End Sub

    Private Sub Button26_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button26.MouseDown
        Dim inputPLAY2 As String
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            inputPLAY2 = InputBox("ASIGNE NUMERO DE PISTA", "PLAY NUM. PISTA")
            Button26.Text = "PLAY (" + inputPLAY2 + ")"
            TextBox6.Text = inputPLAY2
        End If
    End Sub
End Class