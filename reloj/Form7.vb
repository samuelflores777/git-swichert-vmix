Public Class Form7
    Public Shared _instancia As Form7
    Public Function getinstancia() As Form7
        If (_instancia Is Nothing) Then
            _instancia = New Form7
        End If
        Return _instancia
    End Function

    Private Sub Form7_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        MDIParent1.TRANSICIONESToolStripMenuItem.Checked = False
    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form7_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        _instancia = Nothing
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click

    End Sub

    Private Sub Button17_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button17.MouseDown
        Dim inputTR As String
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            inputTR = InputBox("ASIGNE NUMERO DE PISTA", "STINGER NUM. PISTA")
            Button17.Text = "TRANS. STINGER (" + inputTR + ")"
            TextBox4.Text = inputTR
        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click

    End Sub

    Private Sub Button18_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button18.MouseDown
        Dim inputPR As String
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            inputPR = InputBox("ASIGNE NUMERO DE PISTA", "PREVIO Nro. PISTA")
            Button18.Text = "PREVIO (" + inputPR + ")"
            TextBox3.Text = inputPR
        End If
    End Sub

    Private Sub Button1_MouseDown(sender As Object, e As MouseEventArgs) Handles Button1.MouseDown
        Dim inputFADE As String
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            inputFADE = InputBox("ASIGNE NUMERO DE PISTA", "FADE Nro. PISTA")
            Button1.Text = "FADE (" + inputFADE + ")"
            TextBox1.Text = inputFADE
        End If
    End Sub

    Private Sub Button19_MouseDown(sender As Object, e As MouseEventArgs) Handles Button19.MouseDown
        Dim inputCUT As String
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            inputCUT = InputBox("ASIGNE NUMERO DE PISTA", "CUT Nro. PISTA")
            Button19.Text = "CUT (" + inputCUT + ")"
            TextBox2.Text = inputCUT
        End If
    End Sub
End Class