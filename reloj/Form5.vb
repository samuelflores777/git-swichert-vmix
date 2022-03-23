Imports System.IO
Imports System.Data.OleDb
Imports System.ComponentModel

Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (OpenFileDialog1.ShowDialog = DialogResult.OK) Then
            Label1.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AxWindowsMediaPlayer1.URL = Label1.Text
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AxWindowsMediaPlayer1.URL = Label1.Text
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If (OpenFileDialog1.ShowDialog = DialogResult.OK) Then
            Label2.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If (OpenFileDialog1.ShowDialog = DialogResult.OK) Then
            Label3.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If (OpenFileDialog1.ShowDialog = DialogResult.OK) Then
            Label4.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If (OpenFileDialog1.ShowDialog = DialogResult.OK) Then
            Label5.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        If (OpenFileDialog1.ShowDialog = DialogResult.OK) Then
            Label6.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        If (OpenFileDialog1.ShowDialog = DialogResult.OK) Then
            Label7.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        If (OpenFileDialog1.ShowDialog = DialogResult.OK) Then
            Label8.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        If (OpenFileDialog1.ShowDialog = DialogResult.OK) Then
            Label9.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        If (OpenFileDialog1.ShowDialog = DialogResult.OK) Then
            Label10.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        If (OpenFileDialog1.ShowDialog = DialogResult.OK) Then
            Label11.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        AxWindowsMediaPlayer1.URL = Label2.Text
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        AxWindowsMediaPlayer1.URL = Label3.Text
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        AxWindowsMediaPlayer1.URL = Label4.Text
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        AxWindowsMediaPlayer1.URL = Label5.Text
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        AxWindowsMediaPlayer1.URL = Label6.Text
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        AxWindowsMediaPlayer1.URL = Label7.Text
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        AxWindowsMediaPlayer1.URL = Label8.Text
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        AxWindowsMediaPlayer1.URL = Label9.Text
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        AxWindowsMediaPlayer1.URL = Label10.Text
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        AxWindowsMediaPlayer1.URL = Label11.Text
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        AxWindowsMediaPlayer1.URL = Label2.Text
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        AxWindowsMediaPlayer1.URL = Label3.Text
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        AxWindowsMediaPlayer1.URL = Label4.Text
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        AxWindowsMediaPlayer1.URL = Label5.Text
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        AxWindowsMediaPlayer1.URL = Label6.Text
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        AxWindowsMediaPlayer1.URL = Label7.Text
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        AxWindowsMediaPlayer1.URL = Label8.Text
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        AxWindowsMediaPlayer1.URL = Label9.Text
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        AxWindowsMediaPlayer1.URL = Label10.Text
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        AxWindowsMediaPlayer1.URL = Label11.Text
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        AxWindowsMediaPlayer1.settings.volume = TrackBar1.Value
    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        Dim SFD As New SaveFileDialog
        SFD.Filter = "txt|*.txt"
        Dim ResultadoSFD As String
        SFD.ShowDialog()
        ResultadoSFD = SFD.FileName
        Me.Text = "SAM CTRL VMIX - " + ResultadoSFD
        My.Computer.FileSystem.WriteAllText(ResultadoSFD, TextBox1.Text & vbCrLf &
TextBox2.Text & vbCrLf &
TextBox3.Text & vbCrLf &
TextBox4.Text & vbCrLf &
TextBox5.Text & vbCrLf &
TextBox6.Text & vbCrLf &
TextBox7.Text & vbCrLf &
TextBox8.Text & vbCrLf &
TextBox9.Text & vbCrLf &
TextBox10.Text & vbCrLf &
TextBox11.Text & vbCrLf &
Label1.Text & vbCrLf &
Label2.Text & vbCrLf &
Label3.Text & vbCrLf &
Label4.Text & vbCrLf &
Label5.Text & vbCrLf &
Label6.Text & vbCrLf &
Label7.Text & vbCrLf &
Label8.Text & vbCrLf &
Label9.Text & vbCrLf &
Label10.Text & vbCrLf &
Label11.Text & vbCrLf & vbCrLf, False)
    End Sub

    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click
        Dim OFD As New OpenFileDialog
        OFD.Filter = "txt|*.txt"
        Dim resultadoOFD As String
        OFD.ShowDialog()
        resultadoOFD = OFD.FileName
        Me.Text = "SAM CTRL VMIX - " + resultadoOFD
        Try
            TextBox1.Text = File.ReadLines(resultadoOFD)(0)
            TextBox2.Text = File.ReadLines(resultadoOFD)(1)
            TextBox3.Text = File.ReadLines(resultadoOFD)(2)
            TextBox4.Text = File.ReadLines(resultadoOFD)(3)
            TextBox5.Text = File.ReadLines(resultadoOFD)(4)
            TextBox6.Text = File.ReadLines(resultadoOFD)(5)
            TextBox7.Text = File.ReadLines(resultadoOFD)(6)
            TextBox8.Text = File.ReadLines(resultadoOFD)(7)
            TextBox9.Text = File.ReadLines(resultadoOFD)(8)
            TextBox10.Text = File.ReadLines(resultadoOFD)(9)
            TextBox11.Text = File.ReadLines(resultadoOFD)(10)
            Label1.Text = File.ReadLines(resultadoOFD)(11)
            Label2.Text = File.ReadLines(resultadoOFD)(12)
            Label3.Text = File.ReadLines(resultadoOFD)(13)
            Label4.Text = File.ReadLines(resultadoOFD)(14)
            Label5.Text = File.ReadLines(resultadoOFD)(15)
            Label6.Text = File.ReadLines(resultadoOFD)(16)
            Label7.Text = File.ReadLines(resultadoOFD)(17)
            Label8.Text = File.ReadLines(resultadoOFD)(18)
            Label9.Text = File.ReadLines(resultadoOFD)(19)
            Label10.Text = File.ReadLines(resultadoOFD)(20)
            Label11.Text = File.ReadLines(resultadoOFD)(21)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button37_Click(sender As Object, e As EventArgs) Handles Button37.Click
        Form3.EfectosSonidoToolStripMenuItem.Checked = True
        Me.Hide()
    End Sub

    Private Sub Button36_Click(sender As Object, e As EventArgs) Handles Button36.Click
        Form3.EfectosSonidoToolStripMenuItem.Checked = False
        Me.Close()
    End Sub

    Private Sub Form5_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Form3.EfectosSonidoToolStripMenuItem.Checked = False
        ' Me.Close()
    End Sub
End Class