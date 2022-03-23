Public Class Form2
    Dim conta As Integer
    Dim min As Integer
    Dim seg As Integer
    Private IMGboton(3) As Image
    Private _btn1 As botones

    Public Sub New()
        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        IMGboton(botones.Azul) = My.Resources.b1
        IMGboton(botones.Rojo) = My.Resources.b2
        IMGboton(botones.Nara) = My.Resources.b3
        IMGboton(botones.Verde) = My.Resources.b4
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        conta = conta - 1
        Me.Label1.Text = conta
        If conta = 0 Then
            seg = seg - 1
            Me.Label2.Text = Convert.ToInt32(seg)
            conta = 59
            Me.Label1.Text = conta
        End If
        If seg = 0 Then
            min = min - 1
            Me.Label3.Text = Convert.ToInt32(min)
            seg = 59
            Me.Label2.Text = seg
        End If
        If seg < 10 Then
            Label4.Text = "0" + Label3.Text + ":" + "0" + Label2.Text
        Else
            Label4.Text = "0" + Label3.Text + ":" + Label2.Text
        End If
        If min = 0 Then
            Timer1.Stop()
            Timer1.Enabled = False
            Timer2.Enabled = True
        End If

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conta = 59
        min = Convert.ToInt32(TextBox1.Text)
        seg = 59
        Me.Label1.Text = conta
        Me.Label2.Text = seg
        Me.Label3.Text = min
        Me.Timer1.Enabled = True
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        conta = conta - 1
        Me.Label1.Text = conta
        If conta = 0 Then
            seg = seg - 1
            Me.Label2.Text = Convert.ToInt32(seg)
            conta = 59
            Me.Label1.Text = conta
        End If
        If seg = 0 Then
            Timer2.Enabled = False
        End If
        If seg < 10 Then
            Label4.Text = "0" + Label3.Text + ":" + "0" + Label2.Text
        Else
            Label4.Text = "0" + Label3.Text + ":" + Label2.Text
        End If
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
        ComboBox1.Items.Add("01 MINUTO")
        ComboBox1.Items.Add("02 MINUTO")
        ComboBox1.Items.Add("03 MINUTO")
        ComboBox1.Items.Add("04 MINUTO")
        ComboBox1.Items.Add("05 MINUTO")
        ComboBox1.Items.Add("06 MINUTO")
        ComboBox1.Items.Add("07 MINUTO")
        ComboBox1.Items.Add("08 MINUTO")
        ComboBox1.Items.Add("09 MINUTO")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.SelectedIndex
            Case 0
                TextBox1.Text = "0"
            Case 1
                TextBox1.Text = "1"
            Case 2
                TextBox1.Text = "2"
            Case 3
                TextBox1.Text = "3"
            Case 4
                TextBox1.Text = "4"
            Case 5
                TextBox1.Text = "5"
            Case 6
                TextBox1.Text = "6"
            Case 7
                TextBox1.Text = "7"
            Case 8
                TextBox1.Text = "8"
            Case 9
                TextBox1.Text = "9"
        End Select
    End Sub
    Private Sub Label4_TextChanged(sender As Object, e As EventArgs) Handles Label4.TextChanged
        WebBrowser1.Navigate(TextBox2.Text + TextBox3.Text + "&Value=" + Label4.Text)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Stop()
        Timer2.Stop()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If min = 0 Then
            Timer2.Start()
        Else
            Timer1.Start()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Timer1.Stop()
        Timer2.Stop()
        min = 0
        seg = 0
        conta = 0
        Label1.Text = "0"
        Label2.Text = "0"
        Label3.Text = "0"
        Label4.Text = "00:00"

    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form3.ContadorRetrocesoToolStripMenuItem.Checked = False
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form3.ContadorRetrocesoToolStripMenuItem.Checked = True
        Me.Hide()
    End Sub
End Class