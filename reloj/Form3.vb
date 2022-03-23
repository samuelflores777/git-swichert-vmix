Imports System.IO
Imports System.Data.OleDb

Public Class Form3
    Public Shared _instancia As Form3
    Public wc As New Net.WebClient

    Private IMGboton(3) As Image
    Private _btn1 As botones

    Private IMGopcion(3) As Image
    Private _opc1 As opciones

    Private IMGoverlay(3) As Image
    Private _ove1 As overlays

    Public Sub New()
        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        IMGboton(botones.Azul) = My.Resources.b1
        IMGboton(botones.Rojo) = My.Resources.b2
        IMGboton(botones.Nara) = My.Resources.b3
        IMGboton(botones.Verde) = My.Resources.b4

        IMGopcion(opciones.azul) = My.Resources.oa
        IMGopcion(opciones.rojo) = My.Resources.ob
        IMGopcion(opciones.nara) = My.Resources.oc
        IMGopcion(opciones.blan) = My.Resources.od

        IMGoverlay(overlays.ove1) = My.Resources.ove1
        IMGoverlay(overlays.ove2) = My.Resources.ove2
        IMGoverlay(overlays.ove3) = My.Resources.ove3
        IMGoverlay(overlays.ove4) = My.Resources.ove4
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        Dim ActifeFor As Control = Me.ActiveControl
        If ((Not ActifeFor Is Nothing) AndAlso (ActifeFor.Parent Is Me)) Then
            If (keyData = Keys.F1) Then
                TextBox69.Visible = True
                Return True
            End If

            If (keyData = Keys.F2) Then
                TextBox69.Visible = False
                Return True
            End If

            If (keyData = Keys.F3) Then
                Label51.Visible = True
                Label52.Visible = True
                Label53.Visible = True
                Label54.Visible = True
                Label55.Visible = True
                Label56.Visible = True
                Label57.Visible = True
                Label58.Visible = True
                Label59.Visible = True
                Label60.Visible = True
                Label61.Visible = True
                Label62.Visible = True
                Label63.Visible = True
                Label64.Visible = True
                Label65.Visible = True
                Label66.Visible = True
                Label67.Visible = True
                Label68.Visible = True
                Label69.Visible = True
                Label70.Visible = True
                Label71.Visible = True
                Label72.Visible = True
                Label73.Visible = True
                Label74.Visible = True
                Label75.Visible = True
                Label76.Visible = True
                Label77.Visible = True
                Label78.Visible = True
                Label79.Visible = True
                Label80.Visible = True
                Label81.Visible = True
                Label82.Visible = True
                Label83.Visible = True
                Label84.Visible = True
                Label85.Visible = True
                Label86.Visible = True
                Label87.Visible = True
                Label88.Visible = True
                Label89.Visible = True
                Label90.Visible = True
                Label91.Visible = True
                Label92.Visible = True
                Label93.Visible = True
                Label94.Visible = True
                Label95.Visible = True
                Label96.Visible = True
                Label97.Visible = True
                Label98.Visible = True
                Label99.Visible = True
                Label100.Visible = True
                'Label101.Visible = True
                Label102.Visible = True
                Label103.Visible = True
                Label104.Visible = True
                Label105.Visible = True
                Label106.Visible = True
                Label107.Visible = True
                Label108.Visible = True
                Label109.Visible = True
                Label110.Visible = True
                Return True
            End If

            If (keyData = Keys.F4) Then
                Label51.Visible = False
                Label52.Visible = False
                Label53.Visible = False
                Label54.Visible = False
                Label55.Visible = False
                Label56.Visible = False
                Label57.Visible = False
                Label58.Visible = False
                Label59.Visible = False
                Label60.Visible = False
                Label61.Visible = False
                Label62.Visible = False
                Label63.Visible = False
                Label64.Visible = False
                Label65.Visible = False
                Label66.Visible = False
                Label67.Visible = False
                Label68.Visible = False
                Label69.Visible = False
                Label70.Visible = False
                Label71.Visible = False
                Label72.Visible = False
                Label73.Visible = False
                Label74.Visible = False
                Label75.Visible = False
                Label76.Visible = False
                Label77.Visible = False
                Label78.Visible = False
                Label79.Visible = False
                Label80.Visible = False
                Label81.Visible = False
                Label82.Visible = False
                Label83.Visible = False
                Label84.Visible = False
                Label85.Visible = False
                Label86.Visible = False
                Label87.Visible = False
                Label88.Visible = False
                Label89.Visible = False
                Label90.Visible = False
                Label91.Visible = False
                Label92.Visible = False
                Label93.Visible = False
                Label94.Visible = False
                Label95.Visible = False
                Label96.Visible = False
                Label97.Visible = False
                Label98.Visible = False
                Label99.Visible = False
                Label100.Visible = False
                'Label101.Visible = False
                Label102.Visible = False
                Label103.Visible = False
                Label104.Visible = False
                Label105.Visible = False
                Label106.Visible = False
                Label107.Visible = False
                Label108.Visible = False
                Label109.Visible = False
                Label110.Visible = False
                Return True
            End If



        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function
    Private Sub cargarcombo()
        Dim tabla As New DataTable
        Dim sql As String = "SELECT id, nombre, cargo FROM DATOS1"
        Dim adp As New OleDbDataAdapter(sql, conn)
        adp.Fill(tabla)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            wc.DownloadString(IDEWEB + OVE + TextBox1.Text + oveIN + Label1.Text)
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub
    Private Sub PictureBox24_Click(sender As Object, e As EventArgs) Handles PictureBox24.Click
        PictureBox23.Image = IMGopcion(3)
        PictureBox24.Image = IMGopcion(1)
        PictureBox25.Image = IMGopcion(3)
        Label30.Text = "2"
    End Sub

    Private Sub PictureBox25_Click(sender As Object, e As EventArgs) Handles PictureBox25.Click
        PictureBox23.Image = IMGopcion(3)
        PictureBox24.Image = IMGopcion(3)
        PictureBox25.Image = IMGopcion(2)
        Label30.Text = "3"
    End Sub

    Private Sub PictureBox23_Click(sender As Object, e As EventArgs) Handles PictureBox23.Click
        PictureBox23.Image = IMGopcion(0)
        PictureBox24.Image = IMGopcion(3)
        PictureBox25.Image = IMGopcion(3)
        Label30.Text = "1"
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        PictureBox1.Image = IMGopcion(0)
        PictureBox2.Image = IMGopcion(3)
        PictureBox3.Image = IMGopcion(3)
        Label27.Text = "1"
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        PictureBox1.Image = IMGopcion(3)
        PictureBox2.Image = IMGopcion(1)
        PictureBox3.Image = IMGopcion(3)
        Label27.Text = "2"

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        PictureBox1.Image = IMGopcion(3)
        PictureBox2.Image = IMGopcion(3)
        PictureBox3.Image = IMGopcion(2)
        Label27.Text = "3"
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        PictureBox11.Image = IMGopcion(0)
        PictureBox12.Image = IMGopcion(3)
        PictureBox13.Image = IMGopcion(3)
        Label28.Text = "1"
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        PictureBox11.Image = IMGopcion(3)
        PictureBox12.Image = IMGopcion(1)
        PictureBox13.Image = IMGopcion(3)
        Label28.Text = "2"
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        PictureBox11.Image = IMGopcion(3)
        PictureBox12.Image = IMGopcion(3)
        PictureBox13.Image = IMGopcion(2)
        Label28.Text = "3"
    End Sub

    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles PictureBox17.Click
        PictureBox17.Image = IMGopcion(0)
        PictureBox18.Image = IMGopcion(3)
        PictureBox19.Image = IMGopcion(3)
        Label29.Text = "1"
    End Sub

    Private Sub PictureBox18_Click(sender As Object, e As EventArgs) Handles PictureBox18.Click
        PictureBox17.Image = IMGopcion(3)
        PictureBox18.Image = IMGopcion(1)
        PictureBox19.Image = IMGopcion(3)
        Label29.Text = "2"
    End Sub

    Private Sub PictureBox19_Click(sender As Object, e As EventArgs) Handles PictureBox19.Click
        PictureBox17.Image = IMGopcion(3)
        PictureBox18.Image = IMGopcion(3)
        PictureBox19.Image = IMGopcion(2)
        Label29.Text = "3"
    End Sub

    Private Sub PictureBox29_Click(sender As Object, e As EventArgs) Handles PictureBox29.Click
        PictureBox29.Image = IMGopcion(0)
        PictureBox30.Image = IMGopcion(3)
        PictureBox31.Image = IMGopcion(3)
        Label31.Text = "1"
    End Sub

    Private Sub PictureBox30_Click(sender As Object, e As EventArgs) Handles PictureBox30.Click
        PictureBox29.Image = IMGopcion(3)
        PictureBox30.Image = IMGopcion(1)
        PictureBox31.Image = IMGopcion(3)
        Label31.Text = "2"
    End Sub

    Private Sub PictureBox31_Click(sender As Object, e As EventArgs) Handles PictureBox31.Click
        PictureBox29.Image = IMGopcion(3)
        PictureBox30.Image = IMGopcion(3)
        PictureBox31.Image = IMGopcion(2)
        Label31.Text = "3"
    End Sub

    Private Sub PictureBox59_Click(sender As Object, e As EventArgs) Handles PictureBox59.Click
        PictureBox59.Image = IMGopcion(0)
        PictureBox60.Image = IMGopcion(3)
        PictureBox61.Image = IMGopcion(3)
        Label32.Text = "1"
    End Sub

    Private Sub PictureBox60_Click(sender As Object, e As EventArgs) Handles PictureBox60.Click
        PictureBox59.Image = IMGopcion(3)
        PictureBox60.Image = IMGopcion(1)
        PictureBox61.Image = IMGopcion(3)
        Label32.Text = "2"
    End Sub

    Private Sub PictureBox61_Click(sender As Object, e As EventArgs) Handles PictureBox61.Click
        PictureBox59.Image = IMGopcion(3)
        PictureBox60.Image = IMGopcion(3)
        PictureBox61.Image = IMGopcion(2)
        Label32.Text = "3"
    End Sub

    Private Sub PictureBox53_Click(sender As Object, e As EventArgs) Handles PictureBox53.Click
        PictureBox53.Image = IMGopcion(0)
        PictureBox54.Image = IMGopcion(3)
        PictureBox55.Image = IMGopcion(3)
        Label33.Text = "1"
    End Sub

    Private Sub PictureBox54_Click(sender As Object, e As EventArgs) Handles PictureBox54.Click
        PictureBox53.Image = IMGopcion(3)
        PictureBox54.Image = IMGopcion(1)
        PictureBox55.Image = IMGopcion(3)
        Label33.Text = "2"
    End Sub

    Private Sub PictureBox55_Click(sender As Object, e As EventArgs) Handles PictureBox55.Click
        PictureBox53.Image = IMGopcion(3)
        PictureBox54.Image = IMGopcion(3)
        PictureBox55.Image = IMGopcion(2)
        Label33.Text = "3"
    End Sub

    Private Sub PictureBox47_Click(sender As Object, e As EventArgs) Handles PictureBox47.Click
        PictureBox47.Image = IMGopcion(0)
        PictureBox48.Image = IMGopcion(3)
        PictureBox49.Image = IMGopcion(3)
        Label34.Text = "1"
    End Sub

    Private Sub PictureBox48_Click(sender As Object, e As EventArgs) Handles PictureBox48.Click
        PictureBox47.Image = IMGopcion(3)
        PictureBox48.Image = IMGopcion(1)
        PictureBox49.Image = IMGopcion(3)
        Label34.Text = "2"
    End Sub

    Private Sub PictureBox49_Click(sender As Object, e As EventArgs) Handles PictureBox49.Click
        PictureBox47.Image = IMGopcion(3)
        PictureBox48.Image = IMGopcion(3)
        PictureBox49.Image = IMGopcion(2)
        Label34.Text = "3"
    End Sub

    Private Sub PictureBox41_Click(sender As Object, e As EventArgs) Handles PictureBox41.Click
        PictureBox41.Image = IMGopcion(0)
        PictureBox42.Image = IMGopcion(3)
        PictureBox43.Image = IMGopcion(3)
        Label35.Text = "1"
    End Sub

    Private Sub PictureBox42_Click(sender As Object, e As EventArgs) Handles PictureBox42.Click
        PictureBox41.Image = IMGopcion(3)
        PictureBox42.Image = IMGopcion(1)
        PictureBox43.Image = IMGopcion(3)
        Label35.Text = "2"
    End Sub

    Private Sub PictureBox43_Click(sender As Object, e As EventArgs) Handles PictureBox43.Click
        PictureBox41.Image = IMGopcion(3)
        PictureBox42.Image = IMGopcion(3)
        PictureBox43.Image = IMGopcion(2)
        Label35.Text = "3"
    End Sub

    Private Sub PictureBox35_Click(sender As Object, e As EventArgs) Handles PictureBox35.Click
        PictureBox35.Image = IMGopcion(0)
        PictureBox36.Image = IMGopcion(3)
        PictureBox37.Image = IMGopcion(3)
        Label36.Text = "1"
    End Sub

    Private Sub PictureBox36_Click(sender As Object, e As EventArgs) Handles PictureBox36.Click
        PictureBox35.Image = IMGopcion(3)
        PictureBox36.Image = IMGopcion(1)
        PictureBox37.Image = IMGopcion(3)
        Label36.Text = "2"
    End Sub

    Private Sub PictureBox37_Click(sender As Object, e As EventArgs) Handles PictureBox37.Click
        PictureBox35.Image = IMGopcion(3)
        PictureBox36.Image = IMGopcion(3)
        PictureBox37.Image = IMGopcion(2)
        Label36.Text = "3"
    End Sub
    Private Sub Form3_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        _instancia = Nothing
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "1" Then
            PictureBox28.Visible = True
            PictureBox28.Image = IMGoverlay(0)
        End If
        If TextBox1.Text = "2" Then
            PictureBox28.Visible = True
            PictureBox28.Image = IMGoverlay(1)
        End If
        If TextBox1.Text = "3" Then
            PictureBox28.Visible = True
            PictureBox28.Image = IMGoverlay(2)
        End If
        If TextBox1.Text = "4" Then
            PictureBox28.Visible = True
            PictureBox28.Image = IMGoverlay(3)
        End If
    End Sub
    Private Sub Button11_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button11.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "BTN11"
        End If
    End Sub
    Private Sub Button1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button1.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "BTN01"
        End If
    End Sub

    Private Sub Button2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button2.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "BTN02"
        End If
    End Sub

    Private Sub Button3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button3.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "BTN03"
        End If
    End Sub

    Private Sub Button4_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button4.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "BTN04"
        End If
    End Sub

    Private Sub Button5_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button5.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "BTN05"
        End If
    End Sub

    Private Sub Button6_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button6.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "BTN06"
        End If
    End Sub

    Private Sub Button7_MouseDown(sender As Object, e As MouseEventArgs) Handles Button7.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "BTN07"
        End If
    End Sub

    Private Sub Button8_MouseDown(sender As Object, e As MouseEventArgs) Handles Button8.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "BTN08"
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Try
            wc.DownloadString(IDEWEB + OVE + TextBox9.Text + oveIN + Label9.Text)
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Try
            wc.DownloadString(IDEWEB + OVE + TextBox15.Text + oveIN + Label15.Text)
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Try
            wc.DownloadString(IDEWEB + OVE + TextBox8.Text + oveIN + Label8.Text)
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub CambiarNombreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambiarNombreToolStripMenuItem.Click
        If BOK = "BTN16" Then
            Dim NOMB As String
            NOMB = InputBox("COLOCAR NOMBRE", "NUEVO")
            Button16.Text = NOMB
        End If

        If BOK = "BTN17" Then
            Dim NOMB As String
            NOMB = InputBox("COLOCAR NOMBRE", "NUEVO")
            Button17.Text = NOMB
        End If

        If BOK = "BTN18" Then
            Dim NOMB As String
            NOMB = InputBox("COLOCAR NOMBRE", "NUEVO")
            Button18.Text = NOMB
        End If

        If BOK = "BTN19" Then
            Dim NOMB As String
            NOMB = InputBox("COLOCAR NOMBRE", "NUEVO")
            Button19.Text = NOMB
        End If

        If BOK = "BTN20" Then
            Dim NOMB As String
            NOMB = InputBox("COLOCAR NOMBRE", "NUEVO")
            Button20.Text = NOMB
        End If

        If BOK = "BTN21" Then
            Dim NOMB As String
            NOMB = InputBox("COLOCAR NOMBRE", "NUEVO")
            Button21.Text = NOMB
        End If

        If BOK = "BTN22" Then
            Dim NOMB As String
            NOMB = InputBox("COLOCAR NOMBRE", "NUEVO")
            Button22.Text = NOMB
        End If

        If BOK = "BTN23" Then
            Dim NOMB As String
            NOMB = InputBox("COLOCAR NOMBRE", "NUEVO")
            Button23.Text = NOMB
        End If

        If BOK = "BTN24" Then
            Dim NOMB As String
            NOMB = InputBox("COLOCAR NOMBRE", "NUEVO")
            Button24.Text = NOMB
        End If

        If BOK = "BTN25" Then
            Dim NOMB As String
            NOMB = InputBox("COLOCAR NOMBRE", "NUEVO")
            Button25.Text = NOMB
        End If

        If BOK = "BTN54" Then
            Dim NOMB As String
            NOMB = InputBox("COLOCAR NOMBRE", "NUEVO")
            Button54.Text = NOMB
        End If

        If BOK = "BTN55" Then
            Dim NOMB As String
            NOMB = InputBox("COLOCAR NOMBRE", "NUEVO")
            Button55.Text = NOMB
        End If

        If BOK = "BTN56" Then
            Dim NOMB As String
            NOMB = InputBox("COLOCAR NOMBRE", "NUEVO")
            Button56.Text = NOMB
        End If

        If BOK = "BTN57" Then
            Dim NOMB As String
            NOMB = InputBox("COLOCAR NOMBRE", "NUEVO")
            Button57.Text = NOMB
        End If

        If BOK = "BTN58" Then
            Dim NOMB As String
            NOMB = InputBox("COLOCAR NOMBRE", "NUEVO")
            Button58.Text = NOMB
        End If

    End Sub

    Private Sub Button9_MouseDown(sender As Object, e As MouseEventArgs) Handles Button9.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "BTN09"
        End If
    End Sub

    Private Sub Button10_MouseDown(sender As Object, e As MouseEventArgs) Handles Button10.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "BTN10"
        End If
    End Sub

    Private Sub Button12_MouseDown(sender As Object, e As MouseEventArgs) Handles Button12.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "BTN12"
        End If
    End Sub

    Private Sub Button13_MouseDown(sender As Object, e As MouseEventArgs) Handles Button13.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "BTN13"
        End If
    End Sub

    Private Sub Button14_MouseDown(sender As Object, e As MouseEventArgs) Handles Button14.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "BTN14"
        End If
    End Sub

    Private Sub Button15_MouseDown(sender As Object, e As MouseEventArgs) Handles Button15.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "BTN15"
        End If
    End Sub

    Private Sub Button16_MouseDown(sender As Object, e As MouseEventArgs) Handles Button16.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "BTN16"
        End If
    End Sub

    Private Sub Button17_MouseDown(sender As Object, e As MouseEventArgs) Handles Button17.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "BTN17"
        End If
    End Sub

    Private Sub Button18_MouseDown(sender As Object, e As MouseEventArgs) Handles Button18.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "BTN18"
        End If
    End Sub

    Private Sub Button19_MouseDown(sender As Object, e As MouseEventArgs) Handles Button19.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "BTN19"
        End If
    End Sub

    Private Sub Button20_MouseDown(sender As Object, e As MouseEventArgs) Handles Button20.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "BTN20"
        End If
    End Sub

    Private Sub Button21_MouseDown(sender As Object, e As MouseEventArgs) Handles Button21.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "BTN21"
        End If
    End Sub

    Private Sub Button22_MouseDown(sender As Object, e As MouseEventArgs) Handles Button22.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "BTN22"
        End If
    End Sub

    Private Sub Button23_MouseDown(sender As Object, e As MouseEventArgs) Handles Button23.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "BTN23"
        End If
    End Sub

    Private Sub Button24_MouseDown(sender As Object, e As MouseEventArgs) Handles Button24.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "BTN24"
        End If
    End Sub

    Private Sub Button25_MouseDown(sender As Object, e As MouseEventArgs) Handles Button25.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "BTN25"
        End If
    End Sub

    Private Sub Button31_MouseDown(sender As Object, e As MouseEventArgs) Handles Button31.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "BTN31"
        End If
    End Sub

    Private Sub Button32_MouseDown(sender As Object, e As MouseEventArgs) Handles Button32.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "BTN32"
        End If
    End Sub

    Private Sub Button34_MouseDown(sender As Object, e As MouseEventArgs) Handles Button34.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "BTN34"
        End If
    End Sub

    Private Sub Button33_MouseDown(sender As Object, e As MouseEventArgs) Handles Button33.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "BTN33"
        End If
    End Sub

    Private Sub Button28_MouseDown(sender As Object, e As MouseEventArgs) Handles Button28.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "BTN28"
        End If
    End Sub

    Private Sub Button29_MouseDown(sender As Object, e As MouseEventArgs)
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "BTN29"
        End If
    End Sub

    Private Sub Button30_MouseDown(sender As Object, e As MouseEventArgs) Handles Button30.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "BTN30"
        End If
    End Sub

    Private Sub Overlay01ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Overlay01ToolStripMenuItem.Click
        If BOK = "BTN01" Then
            TextBox1.Text = "1"
        End If

        If BOK = "BTN02" Then
            TextBox2.Text = "1"
        End If

        If BOK = "BTN03" Then
            TextBox3.Text = "1"
        End If

        If BOK = "BTN04" Then
            TextBox4.Text = "1"
        End If

        If BOK = "BTN05" Then
            TextBox5.Text = "1"
        End If

        If BOK = "BTN06" Then
            TextBox6.Text = "1"
        End If

        If BOK = "BTN07" Then
            TextBox7.Text = "1"
        End If

        If BOK = "BTN08" Then
            TextBox8.Text = "1"
        End If

        If BOK = "BTN09" Then
            TextBox9.Text = "1"
        End If

        If BOK = "BTN10" Then
            TextBox10.Text = "1"
        End If

        If BOK = "BTN11" Then
            TextBox11.Text = "1"
        End If

        If BOK = "BTN12" Then
            TextBox12.Text = "1"
        End If

        If BOK = "BTN13" Then
            TextBox13.Text = "1"
        End If

        If BOK = "BTN14" Then
            TextBox14.Text = "1"
        End If

        If BOK = "BTN15" Then
            TextBox15.Text = "1"
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If TextBox2.Text = "1" Then
            PictureBox32.Visible = True
            PictureBox32.Image = IMGoverlay(0)
        End If
        If TextBox2.Text = "2" Then
            PictureBox32.Visible = True
            PictureBox32.Image = IMGoverlay(1)
        End If
        If TextBox2.Text = "3" Then
            PictureBox32.Visible = True
            PictureBox32.Image = IMGoverlay(2)
        End If
        If TextBox2.Text = "4" Then
            PictureBox32.Visible = True
            PictureBox32.Image = IMGoverlay(3)
        End If
    End Sub

    Private Sub Overlay02ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Overlay02ToolStripMenuItem.Click
        If BOK = "BTN01" Then
            TextBox1.Text = "2"
        End If

        If BOK = "BTN02" Then
            TextBox2.Text = "2"
        End If

        If BOK = "BTN03" Then
            TextBox3.Text = "2"
        End If

        If BOK = "BTN04" Then
            TextBox4.Text = "2"
        End If

        If BOK = "BTN05" Then
            TextBox5.Text = "2"
        End If

        If BOK = "BTN06" Then
            TextBox6.Text = "2"
        End If

        If BOK = "BTN07" Then
            TextBox7.Text = "2"
        End If

        If BOK = "BTN08" Then
            TextBox8.Text = "2"
        End If

        If BOK = "BTN09" Then
            TextBox9.Text = "2"
        End If

        If BOK = "BTN10" Then
            TextBox10.Text = "2"
        End If

        If BOK = "BTN11" Then
            TextBox11.Text = "2"
        End If

        If BOK = "BTN12" Then
            TextBox12.Text = "2"
        End If

        If BOK = "BTN13" Then
            TextBox13.Text = "2"
        End If

        If BOK = "BTN14" Then
            TextBox14.Text = "2"
        End If

        If BOK = "BTN15" Then
            TextBox15.Text = "2"
        End If
    End Sub

    Private Sub Overlay03ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Overlay03ToolStripMenuItem.Click
        If BOK = "BTN01" Then
            TextBox1.Text = "3"
        End If

        If BOK = "BTN02" Then
            TextBox2.Text = "3"
        End If

        If BOK = "BTN03" Then
            TextBox3.Text = "3"
        End If

        If BOK = "BTN04" Then
            TextBox4.Text = "3"
        End If

        If BOK = "BTN05" Then
            TextBox5.Text = "3"
        End If

        If BOK = "BTN06" Then
            TextBox6.Text = "3"
        End If

        If BOK = "BTN07" Then
            TextBox7.Text = "3"
        End If

        If BOK = "BTN08" Then
            TextBox8.Text = "3"
        End If

        If BOK = "BTN09" Then
            TextBox9.Text = "3"
        End If

        If BOK = "BTN10" Then
            TextBox10.Text = "3"
        End If

        If BOK = "BTN11" Then
            TextBox11.Text = "3"
        End If

        If BOK = "BTN12" Then
            TextBox12.Text = "3"
        End If

        If BOK = "BTN13" Then
            TextBox13.Text = "3"
        End If

        If BOK = "BTN14" Then
            TextBox14.Text = "3"
        End If

        If BOK = "BTN15" Then
            TextBox15.Text = "3"
        End If
    End Sub

    Private Sub Overlay04ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Overlay04ToolStripMenuItem.Click
        If BOK = "BTN01" Then
            TextBox1.Text = "4"
        End If

        If BOK = "BTN02" Then
            TextBox2.Text = "4"
        End If

        If BOK = "BTN03" Then
            TextBox3.Text = "4"
        End If

        If BOK = "BTN04" Then
            TextBox4.Text = "4"
        End If

        If BOK = "BTN05" Then
            TextBox5.Text = "4"
        End If

        If BOK = "BTN06" Then
            TextBox6.Text = "4"
        End If

        If BOK = "BTN07" Then
            TextBox7.Text = "4"
        End If

        If BOK = "BTN08" Then
            TextBox8.Text = "4"
        End If

        If BOK = "BTN09" Then
            TextBox9.Text = "4"
        End If

        If BOK = "BTN10" Then
            TextBox10.Text = "4"
        End If

        If BOK = "BTN11" Then
            TextBox11.Text = "4"
        End If

        If BOK = "BTN12" Then
            TextBox12.Text = "4"
        End If

        If BOK = "BTN13" Then
            TextBox13.Text = "4"
        End If

        If BOK = "BTN14" Then
            TextBox14.Text = "4"
        End If

        If BOK = "BTN15" Then
            TextBox15.Text = "4"
        End If
    End Sub

    Private Sub ASIGPISTAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ASIGPISTAToolStripMenuItem.Click
        If BOK = "BTN01" Then
            Dim BTN As String
            BTN = InputBox("ESCRIBA NUMERO DE PISTA", "PISTA")
            Label1.Text = BTN
        End If
        If BOK = "BTN02" Then
            Dim BTN As String
            BTN = InputBox("ESCRIBA NUMERO DE PISTA", "PISTA")
            Label2.Text = BTN
        End If
        If BOK = "BTN03" Then
            Dim BTN As String
            BTN = InputBox("ESCRIBA NUMERO DE PISTA", "PISTA")
            Label3.Text = BTN
        End If
        If BOK = "BTN04" Then
            Dim BTN As String
            BTN = InputBox("ESCRIBA NUMERO DE PISTA", "PISTA")
            Label4.Text = BTN
        End If
        If BOK = "BTN05" Then
            Dim BTN As String
            BTN = InputBox("ESCRIBA NUMERO DE PISTA", "PISTA")
            Label5.Text = BTN
        End If
        If BOK = "BTN06" Then
            Dim BTN As String
            BTN = InputBox("ESCRIBA NUMERO DE PISTA", "PISTA")
            Label6.Text = BTN
        End If
        If BOK = "BTN07" Then
            Dim BTN As String
            BTN = InputBox("ESCRIBA NUMERO DE PISTA", "PISTA")
            Label7.Text = BTN
        End If
        If BOK = "BTN08" Then
            Dim BTN As String
            BTN = InputBox("ESCRIBA NUMERO DE PISTA", "PISTA")
            Label8.Text = BTN
        End If
        If BOK = "BTN09" Then
            Dim BTN As String
            BTN = InputBox("ESCRIBA NUMERO DE PISTA", "PISTA")
            Label9.Text = BTN
        End If
        If BOK = "BTN10" Then
            Dim BTN As String
            BTN = InputBox("ESCRIBA NUMERO DE PISTA", "PISTA")
            Label10.Text = BTN
        End If
        If BOK = "BTN11" Then
            Dim BTN As String
            BTN = InputBox("ESCRIBA NUMERO DE PISTA", "PISTA")
            Label11.Text = BTN
        End If
        If BOK = "BTN12" Then
            Dim BTN As String
            BTN = InputBox("ESCRIBA NUMERO DE PISTA", "PISTA")
            Label12.Text = BTN
        End If
        If BOK = "BTN13" Then
            Dim BTN As String
            BTN = InputBox("ESCRIBA NUMERO DE PISTA", "PISTA")
            Label13.Text = BTN
        End If
        If BOK = "BTN14" Then
            Dim BTN As String
            BTN = InputBox("ESCRIBA NUMERO DE PISTA", "PISTA")
            Label14.Text = BTN
        End If
        If BOK = "BTN15" Then
            Dim BTN As String
            BTN = InputBox("ESCRIBA NUMERO DE PISTA", "PISTA")
            Label15.Text = BTN
        End If
        If BOK = "BTN16" Then
            Dim BTN As String
            BTN = InputBox("ESCRIBA NUMERO DE PISTA", "PISTA")
            TextBox16.Text = BTN
            Label101.Text = BTN
        End If
        If BOK = "BTN17" Then
            Dim BTN As String
            BTN = InputBox("ESCRIBA NUMERO DE PISTA", "PISTA")
            TextBox17.Text = BTN
            Label111.Text = BTN
        End If
        If BOK = "BTN18" Then
            Dim BTN As String
            BTN = InputBox("ESCRIBA NUMERO DE PISTA", "PISTA")
            TextBox18.Text = BTN
            Label112.Text = BTN
        End If
        If BOK = "BTN19" Then
            Dim BTN As String
            BTN = InputBox("ESCRIBA NUMERO DE PISTA", "PISTA")
            TextBox19.Text = BTN
            Label113.Text = BTN
        End If
        If BOK = "BTN20" Then
            Dim BTN As String
            BTN = InputBox("ESCRIBA NUMERO DE PISTA", "PISTA")
            TextBox20.Text = BTN
            Label114.Text = BTN
        End If
        If BOK = "BTN21" Then
            Dim BTN As String
            BTN = InputBox("ESCRIBA NUMERO DE PISTA", "PISTA")
            TextBox21.Text = BTN
            Label115.Text = BTN
        End If
        If BOK = "BTN22" Then
            Dim BTN As String
            BTN = InputBox("ESCRIBA NUMERO DE PISTA", "PISTA")
            TextBox22.Text = BTN
            Label116.Text = BTN
        End If
        If BOK = "BTN23" Then
            Dim BTN As String
            BTN = InputBox("ESCRIBA NUMERO DE PISTA", "PISTA")
            TextBox23.Text = BTN
            Label117.Text = BTN
        End If
        If BOK = "BTN24" Then
            Dim BTN As String
            BTN = InputBox("ESCRIBA NUMERO DE PISTA", "PISTA")
            TextBox24.Text = BTN
            Label118.Text = BTN
        End If
        If BOK = "BTN25" Then
            Dim BTN As String
            BTN = InputBox("ESCRIBA NUMERO DE PISTA", "PISTA")
            TextBox25.Text = BTN
            Label119.Text = BTN
        End If
        If BOK = "BTN28" Then
            Dim BTN As String
            BTN = InputBox("ESCRIBA NUMERO DE PISTA", "PISTA")
            TextBox26.Text = BTN
            Button28.Text = "TRANSI (" + BTN + ")"
        End If
        If BOK = "BTN29" Then
            'Dim BTN As String
            'BTN = InputBox("ESCRIBA NUMERO DE PISTA", "PISTA")
            'TextBox28.Text = BTN
            'Button29.Text = "CUT (" + BTN + ")"
        End If
        If BOK = "BTN30" Then
            Dim BTN As String
            BTN = InputBox("ESCRIBA NUMERO DE PISTA", "PISTA")
            TextBox30.Text = BTN
            Button30.Text = "STINGER (" + BTN + ")"
        End If
        If BOK = "BTN31" Then
            Dim BTN As String
            BTN = InputBox("ESCRIBA NUMERO DE PISTA", "PISTA")
            TextBox27.Text = BTN
        End If
        If BOK = "BTN32" Then
            Dim BTN As String
            BTN = InputBox("ESCRIBA NUMERO DE PISTA", "PISTA")
            TextBox29.Text = BTN
        End If

        If BOK = "BTN54" Then
            Dim BTN As String
            BTN = InputBox("ESCRIBA NUMERO DE PISTA", "PISTA")
            TextBox59.Text = BTN
            Label120.Text = BTN
        End If

        If BOK = "BTN55" Then
            Dim BTN As String
            BTN = InputBox("ESCRIBA NUMERO DE PISTA", "PISTA")
            TextBox60.Text = BTN
            Label121.Text = BTN
        End If

        If BOK = "BTN56" Then
            Dim BTN As String
            BTN = InputBox("ESCRIBA NUMERO DE PISTA", "PISTA")
            TextBox61.Text = BTN
            Label122.Text = BTN
        End If

        If BOK = "BTN57" Then
            Dim BTN As String
            BTN = InputBox("ESCRIBA NUMERO DE PISTA", "PISTA")
            TextBox62.Text = BTN
            Label123.Text = BTN
        End If

        If BOK = "BTN58" Then
            Dim BTN As String
            BTN = InputBox("ESCRIBA NUMERO DE PISTA", "PISTA")
            TextBox63.Text = BTN
            Label124.Text = BTN
        End If

    End Sub
    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click
        If TextBox33.Text = "" Then
            Me.Enabled = False
            Form1.Show()
        Else
            Button35.BackgroundImage = IMGboton(3)
            Button35.ForeColor = Color.White
            '    Me.Text = "SAM CTRL VMIX: " + TextBox33.Text
            IDEWEB = TextBox33.Text
        End If

    End Sub
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        If TextBox3.Text = "1" Then
            PictureBox33.Visible = True
            PictureBox33.Image = IMGoverlay(0)
        End If
        If TextBox3.Text = "2" Then
            PictureBox33.Visible = True
            PictureBox33.Image = IMGoverlay(1)
        End If
        If TextBox3.Text = "3" Then
            PictureBox33.Visible = True
            PictureBox33.Image = IMGoverlay(2)
        End If
        If TextBox3.Text = "4" Then
            PictureBox33.Visible = True
            PictureBox33.Image = IMGoverlay(3)
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        If TextBox4.Text = "1" Then
            PictureBox34.Visible = True
            PictureBox34.Image = IMGoverlay(0)
        End If
        If TextBox4.Text = "2" Then
            PictureBox34.Visible = True
            PictureBox34.Image = IMGoverlay(1)
        End If
        If TextBox4.Text = "3" Then
            PictureBox34.Visible = True
            PictureBox34.Image = IMGoverlay(2)
        End If
        If TextBox4.Text = "4" Then
            PictureBox34.Visible = True
            PictureBox34.Image = IMGoverlay(3)
        End If
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        If TextBox5.Text = "1" Then
            PictureBox38.Visible = True
            PictureBox38.Image = IMGoverlay(0)
        End If
        If TextBox5.Text = "2" Then
            PictureBox38.Visible = True
            PictureBox38.Image = IMGoverlay(1)
        End If
        If TextBox5.Text = "3" Then
            PictureBox38.Visible = True
            PictureBox38.Image = IMGoverlay(2)
        End If
        If TextBox5.Text = "4" Then
            PictureBox38.Visible = True
            PictureBox38.Image = IMGoverlay(3)
        End If
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        If TextBox6.Text = "1" Then
            PictureBox57.Visible = True
            PictureBox57.Image = IMGoverlay(0)
        End If

        If TextBox6.Text = "2" Then
            PictureBox57.Visible = True
            PictureBox57.Image = IMGoverlay(1)
        End If

        If TextBox6.Text = "3" Then
            PictureBox57.Visible = True
            PictureBox57.Image = IMGoverlay(2)
        End If

        If TextBox6.Text = "4" Then
            PictureBox57.Visible = True
            PictureBox57.Image = IMGoverlay(3)
        End If
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        If TextBox7.Text = "1" Then
            PictureBox56.Visible = True
            PictureBox56.Image = IMGoverlay(0)
        End If
        If TextBox7.Text = "2" Then
            PictureBox56.Visible = True
            PictureBox56.Image = IMGoverlay(1)
        End If
        If TextBox7.Text = "3" Then
            PictureBox56.Visible = True
            PictureBox56.Image = IMGoverlay(2)
        End If
        If TextBox7.Text = "4" Then
            PictureBox56.Visible = True
            PictureBox56.Image = IMGoverlay(3)
        End If
    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged
        If TextBox8.Text = "1" Then
            PictureBox52.Visible = True
            PictureBox52.Image = IMGoverlay(0)
        End If
        If TextBox8.Text = "2" Then
            PictureBox52.Visible = True
            PictureBox52.Image = IMGoverlay(1)
        End If
        If TextBox8.Text = "3" Then
            PictureBox52.Visible = True
            PictureBox52.Image = IMGoverlay(2)
        End If
        If TextBox8.Text = "4" Then
            PictureBox52.Visible = True
            PictureBox52.Image = IMGoverlay(3)
        End If
    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged
        If TextBox9.Text = "1" Then
            PictureBox51.Visible = True
            PictureBox51.Image = IMGoverlay(0)
        End If
        If TextBox9.Text = "2" Then
            PictureBox51.Visible = True
            PictureBox51.Image = IMGoverlay(1)
        End If
        If TextBox9.Text = "3" Then
            PictureBox51.Visible = True
            PictureBox51.Image = IMGoverlay(2)
        End If
        If TextBox9.Text = "4" Then
            PictureBox51.Visible = True
            PictureBox51.Image = IMGoverlay(3)
        End If
    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged
        If TextBox10.Text = "1" Then
            PictureBox50.Visible = True
            PictureBox50.Image = IMGoverlay(0)
        End If
        If TextBox10.Text = "2" Then
            PictureBox50.Visible = True
            PictureBox50.Image = IMGoverlay(1)
        End If
        If TextBox10.Text = "3" Then
            PictureBox50.Visible = True
            PictureBox50.Image = IMGoverlay(2)
        End If
        If TextBox10.Text = "4" Then
            PictureBox50.Visible = True
            PictureBox50.Image = IMGoverlay(3)
        End If
    End Sub

    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles TextBox11.TextChanged
        If TextBox11.Text = "1" Then
            PictureBox39.Visible = True
            PictureBox39.Image = IMGoverlay(0)
        End If
        If TextBox11.Text = "2" Then
            PictureBox39.Visible = True
            PictureBox39.Image = IMGoverlay(1)
        End If
        If TextBox11.Text = "3" Then
            PictureBox39.Visible = True
            PictureBox39.Image = IMGoverlay(2)
        End If
        If TextBox11.Text = "4" Then
            PictureBox39.Visible = True
            PictureBox39.Image = IMGoverlay(3)
        End If
    End Sub

    Private Sub TextBox12_TextChanged(sender As Object, e As EventArgs) Handles TextBox12.TextChanged
        If TextBox12.Text = "1" Then
            PictureBox40.Visible = True
            PictureBox40.Image = IMGoverlay(0)
        End If
        If TextBox12.Text = "2" Then
            PictureBox40.Visible = True
            PictureBox40.Image = IMGoverlay(1)
        End If
        If TextBox12.Text = "3" Then
            PictureBox40.Visible = True
            PictureBox40.Image = IMGoverlay(2)
        End If
        If TextBox12.Text = "4" Then
            PictureBox40.Visible = True
            PictureBox40.Image = IMGoverlay(3)
        End If
    End Sub

    Private Sub TextBox13_TextChanged(sender As Object, e As EventArgs) Handles TextBox13.TextChanged
        If TextBox13.Text = "1" Then
            PictureBox45.Visible = True
            PictureBox45.Image = IMGoverlay(0)
        End If
        If TextBox13.Text = "2" Then
            PictureBox45.Visible = True
            PictureBox45.Image = IMGoverlay(1)
        End If
        If TextBox13.Text = "3" Then
            PictureBox45.Visible = True
            PictureBox45.Image = IMGoverlay(2)
        End If
        If TextBox13.Text = "4" Then
            PictureBox45.Visible = True
            PictureBox45.Image = IMGoverlay(3)
        End If
    End Sub

    Private Sub TextBox14_TextChanged(sender As Object, e As EventArgs) Handles TextBox14.TextChanged
        If TextBox14.Text = "1" Then
            PictureBox44.Visible = True
            PictureBox44.Image = IMGoverlay(0)
        End If
        If TextBox14.Text = "2" Then
            PictureBox44.Visible = True
            PictureBox44.Image = IMGoverlay(1)
        End If
        If TextBox14.Text = "3" Then
            PictureBox44.Visible = True
            PictureBox44.Image = IMGoverlay(2)
        End If
        If TextBox14.Text = "4" Then
            PictureBox44.Visible = True
            PictureBox44.Image = IMGoverlay(3)
        End If
    End Sub

    Private Sub TextBox15_TextChanged(sender As Object, e As EventArgs) Handles TextBox15.TextChanged
        If TextBox15.Text = "1" Then
            PictureBox46.Visible = True
            PictureBox46.Image = IMGoverlay(0)
        End If
        If TextBox15.Text = "2" Then
            PictureBox46.Visible = True
            PictureBox46.Image = IMGoverlay(1)
        End If
        If TextBox15.Text = "3" Then
            PictureBox46.Visible = True
            PictureBox46.Image = IMGoverlay(2)
        End If
        If TextBox15.Text = "4" Then
            PictureBox46.Visible = True
            PictureBox46.Image = IMGoverlay(3)
        End If
    End Sub
    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Try
            If RadioButton1.Checked = True Then
                Call BOTONCOLORES()
                Call ejecutarAPI()
                Call CHAUDIO()
                Call audioONOF()
                wc.DownloadString(IDEWEB + PISTA + TextBox16.Text)
            End If

            If RadioButton2.Checked = True Then
                Call BOTONCOLORES()
                wc.DownloadString(IDEWEB + TextBox49.Text)
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Try
            If RadioButton3.Checked = True Then
                Call BOTONCOLORES()
                Call ejecutarAPI()
                Call CHAUDIO()
                Call audioONOF()
                wc.DownloadString(IDEWEB + PISTA + TextBox17.Text)
            End If
            If RadioButton4.Checked = True Then
                Call BOTONCOLORES()
                wc.DownloadString(IDEWEB + TextBox50.Text)
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Try
            If RadioButton5.Checked = True Then
                Call BOTONCOLORES()
                Call ejecutarAPI()
                Call CHAUDIO()
                Call audioONOF()
                wc.DownloadString(IDEWEB + PISTA + TextBox18.Text)
            End If
            If RadioButton6.Checked = True Then
                Call BOTONCOLORES()
                wc.DownloadString(IDEWEB + TextBox51.Text)
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Try
            If RadioButton7.Checked = True Then
                Call BOTONCOLORES()
                Call ejecutarAPI()
                Call CHAUDIO()
                Call audioONOF()
                wc.DownloadString(IDEWEB + PISTA + TextBox19.Text)
            End If
            If RadioButton8.Checked = True Then
                Call BOTONCOLORES()
                wc.DownloadString(IDEWEB + TextBox52.Text)
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Try
            If RadioButton9.Checked = True Then
                Call BOTONCOLORES()
                Call ejecutarAPI()
                Call CHAUDIO()
                Call audioONOF()
                wc.DownloadString(IDEWEB + PISTA + TextBox20.Text)
            End If
            If RadioButton10.Checked = True Then
                Call BOTONCOLORES()
                wc.DownloadString(IDEWEB + TextBox53.Text)
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Try
            If RadioButton11.Checked = True Then
                Call BOTONCOLORES()
                Call ejecutarAPI()
                Call CHAUDIO()
                Call audioONOF()
                wc.DownloadString(IDEWEB + PISTA + TextBox21.Text)
            End If
            If RadioButton12.Checked = True Then
                Call BOTONCOLORES()
                wc.DownloadString(IDEWEB + TextBox54.Text)
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Try
            If RadioButton13.Checked = True Then
                Call BOTONCOLORES()
                Call ejecutarAPI()
                Call CHAUDIO()
                Call audioONOF()
                wc.DownloadString(IDEWEB + PISTA + TextBox22.Text)
            End If
            If RadioButton14.Checked = True Then
                Call BOTONCOLORES()
                wc.DownloadString(IDEWEB + TextBox55.Text)
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        Try
            If RadioButton15.Checked = True Then
                Call BOTONCOLORES()
                Call ejecutarAPI()
                Call CHAUDIO()
                Call audioONOF()
                wc.DownloadString(IDEWEB + PISTA + TextBox23.Text)
            End If
            If RadioButton16.Checked = True Then
                Call BOTONCOLORES()
                wc.DownloadString(IDEWEB + TextBox56.Text)
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        Try
            If RadioButton17.Checked = True Then
                Call BOTONCOLORES()
                Call ejecutarAPI()
                Call CHAUDIO()
                Call audioONOF()
                wc.DownloadString(IDEWEB + PISTA + TextBox24.Text)
            End If
            If RadioButton18.Checked = True Then
                Call BOTONCOLORES()
                wc.DownloadString(IDEWEB + TextBox57.Text)
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        Try
            If RadioButton19.Checked = True Then
                Call BOTONCOLORES()
                Call ejecutarAPI()
                Call CHAUDIO()
                Call audioONOF()
                wc.DownloadString(IDEWEB + PISTA + TextBox25.Text)
            End If
            If RadioButton20.Checked = True Then
                Call BOTONCOLORES()
                wc.DownloadString(IDEWEB + TextBox58.Text)
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            wc.DownloadString(IDEWEB + OVE + TextBox2.Text + oveIN + Label2.Text)
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            wc.DownloadString(IDEWEB + OVE + TextBox3.Text + oveIN + Label3.Text)
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            wc.DownloadString(IDEWEB + OVE + TextBox4.Text + oveIN + Label4.Text)
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            wc.DownloadString(IDEWEB + OVE + TextBox5.Text + oveIN + Label5.Text)
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            wc.DownloadString(IDEWEB + OVE + TextBox6.Text + oveIN + Label6.Text)
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Try
            wc.DownloadString(IDEWEB + OVE + TextBox7.Text + oveIN + Label7.Text)
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Try
            wc.DownloadString(IDEWEB + OVE + TextBox10.Text + oveIN + Label10.Text)
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Try
            wc.DownloadString(IDEWEB + OVE + TextBox11.Text + oveIN + Label11.Text)
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Try
            wc.DownloadString(IDEWEB + OVE + TextBox12.Text + oveIN + Label12.Text)
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Try
            wc.DownloadString(IDEWEB + OVE + TextBox13.Text + oveIN + Label13.Text)
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Try
            wc.DownloadString(IDEWEB + OVE + TextBox14.Text + oveIN + Label14.Text)
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        Try
            If Button31.ForeColor = Color.Cyan Then
                Button31.BackgroundImage = IMGboton(0)
                Button31.ForeColor = Color.White
                Button31.Text = "PAUSE"
                wc.DownloadString(IDEWEB + PLAY + TextBox27.Text)
            Else
                Button31.ForeColor = Color.Cyan
                Button31.Text = "PLAY"
                Button31.BackgroundImage = IMGboton(2)
                wc.DownloadString(IDEWEB + PAUSE + TextBox27.Text)
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        Try
            If Button33.ForeColor = Color.Cyan Then
                Button33.BackgroundImage = IMGboton(0)
                Button33.ForeColor = Color.White
                Button33.Text = "DESACTIVAR"
                wc.DownloadString(IDEWEB + A_ACT + TextBox27.Text)
            Else
                Button33.ForeColor = Color.Cyan
                Button33.Text = "ACTIVAR"
                Button33.BackgroundImage = IMGboton(2)
                wc.DownloadString(IDEWEB + A_DESACT + TextBox27.Text)
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        Try
            If Button34.ForeColor = Color.Cyan Then
                Button34.BackgroundImage = IMGboton(0)
                Button34.ForeColor = Color.White
                Button34.Text = "DESACTIVAR"
                wc.DownloadString(IDEWEB + A_ACT + TextBox29.Text)
            Else
                Button34.ForeColor = Color.Cyan
                Button34.Text = "ACTIVAR"
                Button34.BackgroundImage = IMGboton(2)
                wc.DownloadString(IDEWEB + A_DESACT + TextBox29.Text)
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        Try
            If Button32.ForeColor = Color.Cyan Then
                Button32.BackgroundImage = IMGboton(0)
                Button32.ForeColor = Color.White
                Button32.Text = "PAUSE"
                wc.DownloadString(IDEWEB + PLAY + TextBox29.Text)
            Else
                Button32.ForeColor = Color.Cyan
                Button32.Text = "PLAY"
                Button32.BackgroundImage = IMGboton(2)
                wc.DownloadString(IDEWEB + PAUSE + TextBox29.Text)
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        Try
            Call BOTONCOLORES()
            Call ejecutarAPI()
            Call CHAUDIO()
            Call audioONOF()
            wc.DownloadString(IDEWEB + TRAN1 + ComboBox1.Text + TRAN2 + TextBox26.Text)
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub
    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        Try
            Call BOTONCOLORES()
            Call ejecutarAPI()
            Call CHAUDIO()
            Call audioONOF()
            wc.DownloadString(IDEWEB + STNG + TextBox30.Text)
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Label26_Click(sender As Object, e As EventArgs) Handles Label26.Click
        Process.Start("https://samuelflores.post.pro")
    End Sub

    Private Sub PictureBox58_Click(sender As Object, e As EventArgs) Handles PictureBox58.Click
        Process.Start("https://samuelflores.post.pro")
    End Sub

    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        TextBox31.Text = HScrollBar1.Value
    End Sub

    Private Sub HScrollBar2_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar2.Scroll
        TextBox32.Text = HScrollBar2.Value
    End Sub

    Private Sub TextBox31_TextChanged(sender As Object, e As EventArgs) Handles TextBox31.TextChanged
        Try
            wc.DownloadString(IDEWEB + VOLU1 + TextBox27.Text + VOLU2 + TextBox31.Text)
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub
    Private Sub TextBox32_TextChanged(sender As Object, e As EventArgs) Handles TextBox32.TextChanged
        Try
            wc.DownloadString(IDEWEB + VOLU1 + TextBox29.Text + VOLU2 + TextBox32.Text)
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub PictureBox22_Click(sender As Object, e As EventArgs) Handles PictureBox22.Click
        PictureBox22.Image = IMGopcion(0)
        PictureBox26.Image = IMGopcion(3)
        PictureBox27.Image = IMGopcion(3)
        Label37.Text = "1"
    End Sub

    Private Sub PictureBox26_Click(sender As Object, e As EventArgs) Handles PictureBox26.Click
        PictureBox22.Image = IMGopcion(3)
        PictureBox26.Image = IMGopcion(1)
        PictureBox27.Image = IMGopcion(3)
        Label37.Text = "2"
    End Sub

    Private Sub PictureBox27_Click(sender As Object, e As EventArgs) Handles PictureBox27.Click
        PictureBox22.Image = IMGopcion(3)
        PictureBox26.Image = IMGopcion(3)
        PictureBox27.Image = IMGopcion(2)
        Label37.Text = "3"
    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        PictureBox16.Image = IMGopcion(0)
        PictureBox20.Image = IMGopcion(3)
        PictureBox21.Image = IMGopcion(3)
        Label38.Text = "1"
    End Sub

    Private Sub PictureBox20_Click(sender As Object, e As EventArgs) Handles PictureBox20.Click
        PictureBox16.Image = IMGopcion(3)
        PictureBox20.Image = IMGopcion(1)
        PictureBox21.Image = IMGopcion(3)
        Label38.Text = "2"
    End Sub

    Private Sub PictureBox21_Click(sender As Object, e As EventArgs) Handles PictureBox21.Click
        PictureBox16.Image = IMGopcion(3)
        PictureBox20.Image = IMGopcion(3)
        PictureBox21.Image = IMGopcion(2)
        Label38.Text = "3"
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        PictureBox10.Image = IMGopcion(0)
        PictureBox14.Image = IMGopcion(3)
        PictureBox15.Image = IMGopcion(3)
        Label39.Text = "1"
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        PictureBox10.Image = IMGopcion(3)
        PictureBox14.Image = IMGopcion(1)
        PictureBox15.Image = IMGopcion(3)
        Label39.Text = "2"
    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        PictureBox10.Image = IMGopcion(3)
        PictureBox14.Image = IMGopcion(3)
        PictureBox15.Image = IMGopcion(2)
        Label39.Text = "3"
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        PictureBox7.Image = IMGopcion(0)
        PictureBox8.Image = IMGopcion(3)
        PictureBox9.Image = IMGopcion(3)
        Label40.Text = "1"
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        PictureBox7.Image = IMGopcion(3)
        PictureBox8.Image = IMGopcion(1)
        PictureBox9.Image = IMGopcion(3)
        Label40.Text = "2"
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        PictureBox7.Image = IMGopcion(3)
        PictureBox8.Image = IMGopcion(3)
        PictureBox9.Image = IMGopcion(2)
        Label40.Text = "3"
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        PictureBox4.Image = IMGopcion(0)
        PictureBox5.Image = IMGopcion(3)
        PictureBox6.Image = IMGopcion(3)
        Label41.Text = "1"
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        PictureBox4.Image = IMGopcion(3)
        PictureBox5.Image = IMGopcion(1)
        PictureBox6.Image = IMGopcion(3)
        Label41.Text = "2"
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        PictureBox4.Image = IMGopcion(3)
        PictureBox5.Image = IMGopcion(3)
        PictureBox6.Image = IMGopcion(2)
        Label41.Text = "3"
    End Sub
    Private Sub TextBox33_TextChanged(sender As Object, e As EventArgs) Handles TextBox33.TextChanged
        If TextBox33.Text = "" Then
            Button35.ForeColor = Color.Cyan
            Button15.BackgroundImage = IMGboton(2)
        Else
            Button35.BackgroundImage = IMGboton(3)
            Button35.ForeColor = Color.White
            '   Me.Text = "SAM CTRL VMIX: " + TextBox33.Text
            IDEWEB = TextBox33.Text
        End If
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        Dim SFD As New SaveFileDialog
        SFD.Filter = "txt|*.txt"
        Dim ResultadoSFD As String
        SFD.ShowDialog()
        ResultadoSFD = SFD.FileName
        Me.Text = "SAM CTRL VMIX - " + ResultadoSFD
        My.Computer.FileSystem.WriteAllText(ResultadoSFD, TextBox34.Text & vbCrLf &
TextBox1.Text & vbCrLf &
Label1.Text & vbCrLf &
TextBox35.Text & vbCrLf &
TextBox2.Text & vbCrLf &
Label2.Text & vbCrLf &
TextBox36.Text & vbCrLf &
TextBox3.Text & vbCrLf &
Label3.Text & vbCrLf &
TextBox37.Text & vbCrLf &
TextBox4.Text & vbCrLf &
Label4.Text & vbCrLf &
TextBox38.Text & vbCrLf &
TextBox5.Text & vbCrLf &
Label5.Text & vbCrLf &
TextBox39.Text & vbCrLf &
TextBox6.Text & vbCrLf &
Label6.Text & vbCrLf &
TextBox40.Text & vbCrLf &
TextBox7.Text & vbCrLf &
Label7.Text & vbCrLf &
TextBox41.Text & vbCrLf &
TextBox8.Text & vbCrLf &
Label8.Text & vbCrLf &
TextBox42.Text & vbCrLf &
TextBox9.Text & vbCrLf &
Label9.Text & vbCrLf &
TextBox43.Text & vbCrLf &
TextBox10.Text & vbCrLf &
Label10.Text & vbCrLf &
TextBox44.Text & vbCrLf &
TextBox11.Text & vbCrLf &
Label11.Text & vbCrLf &
TextBox45.Text & vbCrLf &
TextBox12.Text & vbCrLf &
Label12.Text & vbCrLf &
TextBox46.Text & vbCrLf &
TextBox13.Text & vbCrLf &
Label13.Text & vbCrLf &
TextBox47.Text & vbCrLf &
TextBox14.Text & vbCrLf &
Label14.Text & vbCrLf &
TextBox48.Text & vbCrLf &
TextBox15.Text & vbCrLf &
Label15.Text & vbCrLf &
Button16.Text & vbCrLf &
TextBox16.Text & vbCrLf &
Label16.Text & vbCrLf &
Button17.Text & vbCrLf &
TextBox17.Text & vbCrLf &
Label17.Text & vbCrLf &
Button18.Text & vbCrLf &
TextBox18.Text & vbCrLf &
Label18.Text & vbCrLf &
Button19.Text & vbCrLf &
TextBox19.Text & vbCrLf &
Label19.Text & vbCrLf &
Button20.Text & vbCrLf &
TextBox20.Text & vbCrLf &
Label20.Text & vbCrLf &
Button21.Text & vbCrLf &
TextBox21.Text & vbCrLf &
Label21.Text & vbCrLf &
Button22.Text & vbCrLf &
TextBox22.Text & vbCrLf &
Label22.Text & vbCrLf &
Button23.Text & vbCrLf &
TextBox23.Text & vbCrLf &
Label23.Text & vbCrLf &
Button24.Text & vbCrLf &
TextBox24.Text & vbCrLf &
Label24.Text & vbCrLf &
Button25.Text & vbCrLf &
TextBox25.Text & vbCrLf &
Label25.Text & vbCrLf &
TextBox27.Text & vbCrLf &
TextBox29.Text & vbCrLf &
TextBox33.Text & vbCrLf &
TextBox49.Text & vbCrLf &
TextBox50.Text & vbCrLf &
TextBox51.Text & vbCrLf &
TextBox52.Text & vbCrLf &
TextBox53.Text & vbCrLf &
TextBox54.Text & vbCrLf &
TextBox55.Text & vbCrLf &
TextBox56.Text & vbCrLf &
TextBox57.Text & vbCrLf &
TextBox58.Text & vbCrLf &
Button54.Text & vbCrLf &
TextBox59.Text & vbCrLf &
Label42.Text & vbCrLf &
Button55.Text & vbCrLf &
TextBox60.Text & vbCrLf &
Label43.Text & vbCrLf &
Button56.Text & vbCrLf &
TextBox61.Text & vbCrLf &
Label44.Text & vbCrLf &
Button57.Text & vbCrLf &
TextBox62.Text & vbCrLf &
Label45.Text & vbCrLf &
Button58.Text & vbCrLf &
TextBox63.Text & vbCrLf &
Label46.Text & vbCrLf &
TextBox64.Text & vbCrLf &
TextBox65.Text & vbCrLf &
TextBox66.Text & vbCrLf &
TextBox67.Text & vbCrLf &
TextBox68.Text & vbCrLf &
Label51.Text & vbCrLf &
Label52.Text & vbCrLf &
Label53.Text & vbCrLf &
Label54.Text & vbCrLf &
Label55.Text & vbCrLf &
Label56.Text & vbCrLf &
Label57.Text & vbCrLf &
Label58.Text & vbCrLf &
Label59.Text & vbCrLf &
Label60.Text & vbCrLf &
Label61.Text & vbCrLf &
Label62.Text & vbCrLf &
Label63.Text & vbCrLf &
Label64.Text & vbCrLf &
Label65.Text & vbCrLf &
Label66.Text & vbCrLf &
Label67.Text & vbCrLf &
Label68.Text & vbCrLf &
Label69.Text & vbCrLf &
Label70.Text & vbCrLf &
Label71.Text & vbCrLf &
Label72.Text & vbCrLf &
Label73.Text & vbCrLf &
Label74.Text & vbCrLf &
Label75.Text & vbCrLf &
Label76.Text & vbCrLf &
Label77.Text & vbCrLf &
Label78.Text & vbCrLf &
Label79.Text & vbCrLf &
Label80.Text & vbCrLf &
Label81.Text & vbCrLf &
Label82.Text & vbCrLf &
Label83.Text & vbCrLf &
Label84.Text & vbCrLf &
Label85.Text & vbCrLf &
Label86.Text & vbCrLf &
Label87.Text & vbCrLf &
Label88.Text & vbCrLf &
Label89.Text & vbCrLf &
Label90.Text & vbCrLf &
Label91.Text & vbCrLf &
Label92.Text & vbCrLf &
Label93.Text & vbCrLf &
Label94.Text & vbCrLf &
Label95.Text & vbCrLf &
Label96.Text & vbCrLf &
Label97.Text & vbCrLf &
Label98.Text & vbCrLf &
Label99.Text & vbCrLf &
Label100.Text & vbCrLf &
Label102.Text & vbCrLf &
Label103.Text & vbCrLf &
Label104.Text & vbCrLf &
Label105.Text & vbCrLf &
Label106.Text & vbCrLf &
Label107.Text & vbCrLf &
Label108.Text & vbCrLf &
Label109.Text & vbCrLf &
Label110.Text & vbCrLf &
Label101.Text & vbCrLf &
Label111.Text & vbCrLf &
Label112.Text & vbCrLf &
Label113.Text & vbCrLf &
Label114.Text & vbCrLf &
Label115.Text & vbCrLf &
Label116.Text & vbCrLf &
Label117.Text & vbCrLf &
Label118.Text & vbCrLf &
Label119.Text & vbCrLf &
Label120.Text & vbCrLf &
Label121.Text & vbCrLf &
Label122.Text & vbCrLf &
Label123.Text & vbCrLf &
Label124.Text & vbCrLf &
TextBox72.Text & vbCrLf &
TextBox73.Text & vbCrLf & vbCrLf, False)
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        Dim OFD As New OpenFileDialog
        OFD.Filter = "txt|*.txt"
        Dim resultadoOFD As String
        OFD.ShowDialog()
        resultadoOFD = OFD.FileName
        Me.Text = "SAM CTRL VMIX - " + resultadoOFD


        Try
            TextBox34.Text = File.ReadLines(resultadoOFD)(0)
            TextBox1.Text = File.ReadLines(resultadoOFD)(1)
            Label1.Text = File.ReadLines(resultadoOFD)(2)
            TextBox35.Text = File.ReadLines(resultadoOFD)(3)
            TextBox2.Text = File.ReadLines(resultadoOFD)(4)
            Label2.Text = File.ReadLines(resultadoOFD)(5)
            TextBox36.Text = File.ReadLines(resultadoOFD)(6)
            TextBox3.Text = File.ReadLines(resultadoOFD)(7)
            Label3.Text = File.ReadLines(resultadoOFD)(8)
            TextBox37.Text = File.ReadLines(resultadoOFD)(9)
            TextBox4.Text = File.ReadLines(resultadoOFD)(10)
            Label4.Text = File.ReadLines(resultadoOFD)(11)
            TextBox38.Text = File.ReadLines(resultadoOFD)(12)
            TextBox5.Text = File.ReadLines(resultadoOFD)(13)
            Label5.Text = File.ReadLines(resultadoOFD)(14)
            TextBox39.Text = File.ReadLines(resultadoOFD)(15)
            TextBox6.Text = File.ReadLines(resultadoOFD)(16)
            Label6.Text = File.ReadLines(resultadoOFD)(17)
            TextBox40.Text = File.ReadLines(resultadoOFD)(18)
            TextBox7.Text = File.ReadLines(resultadoOFD)(19)
            Label7.Text = File.ReadLines(resultadoOFD)(20)
            TextBox41.Text = File.ReadLines(resultadoOFD)(21)
            TextBox8.Text = File.ReadLines(resultadoOFD)(22)
            Label8.Text = File.ReadLines(resultadoOFD)(23)
            TextBox42.Text = File.ReadLines(resultadoOFD)(24)
            TextBox9.Text = File.ReadLines(resultadoOFD)(25)
            Label9.Text = File.ReadLines(resultadoOFD)(26)
            TextBox43.Text = File.ReadLines(resultadoOFD)(27)
            TextBox10.Text = File.ReadLines(resultadoOFD)(28)
            Label10.Text = File.ReadLines(resultadoOFD)(29)
            TextBox44.Text = File.ReadLines(resultadoOFD)(30)
            TextBox11.Text = File.ReadLines(resultadoOFD)(31)
            Label11.Text = File.ReadLines(resultadoOFD)(32)
            TextBox45.Text = File.ReadLines(resultadoOFD)(33)
            TextBox12.Text = File.ReadLines(resultadoOFD)(34)
            Label12.Text = File.ReadLines(resultadoOFD)(35)
            TextBox46.Text = File.ReadLines(resultadoOFD)(36)
            TextBox13.Text = File.ReadLines(resultadoOFD)(37)
            Label13.Text = File.ReadLines(resultadoOFD)(38)
            TextBox47.Text = File.ReadLines(resultadoOFD)(39)
            TextBox14.Text = File.ReadLines(resultadoOFD)(40)
            Label14.Text = File.ReadLines(resultadoOFD)(41)
            TextBox48.Text = File.ReadLines(resultadoOFD)(42)
            TextBox15.Text = File.ReadLines(resultadoOFD)(43)
            Label15.Text = File.ReadLines(resultadoOFD)(44)
            Button16.Text = File.ReadLines(resultadoOFD)(45)
            TextBox16.Text = File.ReadLines(resultadoOFD)(46)
            Label16.Text = File.ReadLines(resultadoOFD)(47)
            Button17.Text = File.ReadLines(resultadoOFD)(48)
            TextBox17.Text = File.ReadLines(resultadoOFD)(49)
            Label17.Text = File.ReadLines(resultadoOFD)(50)
            Button18.Text = File.ReadLines(resultadoOFD)(51)
            TextBox18.Text = File.ReadLines(resultadoOFD)(52)
            Label18.Text = File.ReadLines(resultadoOFD)(53)
            Button19.Text = File.ReadLines(resultadoOFD)(54)
            TextBox19.Text = File.ReadLines(resultadoOFD)(55)
            Label19.Text = File.ReadLines(resultadoOFD)(56)
            Button20.Text = File.ReadLines(resultadoOFD)(57)
            TextBox20.Text = File.ReadLines(resultadoOFD)(58)
            Label20.Text = File.ReadLines(resultadoOFD)(59)
            Button21.Text = File.ReadLines(resultadoOFD)(60)
            TextBox21.Text = File.ReadLines(resultadoOFD)(61)
            Label21.Text = File.ReadLines(resultadoOFD)(62)
            Button22.Text = File.ReadLines(resultadoOFD)(63)
            TextBox22.Text = File.ReadLines(resultadoOFD)(64)
            Label22.Text = File.ReadLines(resultadoOFD)(65)
            Button23.Text = File.ReadLines(resultadoOFD)(66)
            TextBox23.Text = File.ReadLines(resultadoOFD)(67)
            Label23.Text = File.ReadLines(resultadoOFD)(68)
            Button24.Text = File.ReadLines(resultadoOFD)(69)
            TextBox24.Text = File.ReadLines(resultadoOFD)(70)
            Label24.Text = File.ReadLines(resultadoOFD)(71)
            Button25.Text = File.ReadLines(resultadoOFD)(72)
            TextBox25.Text = File.ReadLines(resultadoOFD)(73)
            Label25.Text = File.ReadLines(resultadoOFD)(74)
            TextBox27.Text = File.ReadLines(resultadoOFD)(75)
            TextBox29.Text = File.ReadLines(resultadoOFD)(76)
            TextBox33.Text = File.ReadLines(resultadoOFD)(77)
            TextBox49.Text = File.ReadLines(resultadoOFD)(78)
            TextBox50.Text = File.ReadLines(resultadoOFD)(79)
            TextBox51.Text = File.ReadLines(resultadoOFD)(80)
            TextBox52.Text = File.ReadLines(resultadoOFD)(81)
            TextBox53.Text = File.ReadLines(resultadoOFD)(82)
            TextBox54.Text = File.ReadLines(resultadoOFD)(83)
            TextBox55.Text = File.ReadLines(resultadoOFD)(84)
            TextBox56.Text = File.ReadLines(resultadoOFD)(85)
            TextBox57.Text = File.ReadLines(resultadoOFD)(86)
            TextBox58.Text = File.ReadLines(resultadoOFD)(87)
            Button54.Text = File.ReadLines(resultadoOFD)(88)
            TextBox59.Text = File.ReadLines(resultadoOFD)(89)
            Label42.Text = File.ReadLines(resultadoOFD)(90)
            Button55.Text = File.ReadLines(resultadoOFD)(91)
            TextBox60.Text = File.ReadLines(resultadoOFD)(92)
            Label43.Text = File.ReadLines(resultadoOFD)(93)
            Button56.Text = File.ReadLines(resultadoOFD)(94)
            TextBox61.Text = File.ReadLines(resultadoOFD)(95)
            Label44.Text = File.ReadLines(resultadoOFD)(96)
            Button57.Text = File.ReadLines(resultadoOFD)(97)
            TextBox62.Text = File.ReadLines(resultadoOFD)(98)
            Label45.Text = File.ReadLines(resultadoOFD)(99)
            Button58.Text = File.ReadLines(resultadoOFD)(100)
            TextBox63.Text = File.ReadLines(resultadoOFD)(101)
            Label46.Text = File.ReadLines(resultadoOFD)(102)
            TextBox64.Text = File.ReadLines(resultadoOFD)(103)
            TextBox65.Text = File.ReadLines(resultadoOFD)(104)
            TextBox66.Text = File.ReadLines(resultadoOFD)(105)
            TextBox67.Text = File.ReadLines(resultadoOFD)(106)
            TextBox68.Text = File.ReadLines(resultadoOFD)(107)
            Label51.Text = File.ReadLines(resultadoOFD)(108)
            Label52.Text = File.ReadLines(resultadoOFD)(109)
            Label53.Text = File.ReadLines(resultadoOFD)(110)
            Label54.Text = File.ReadLines(resultadoOFD)(111)
            Label55.Text = File.ReadLines(resultadoOFD)(112)
            Label56.Text = File.ReadLines(resultadoOFD)(113)
            Label57.Text = File.ReadLines(resultadoOFD)(114)
            Label58.Text = File.ReadLines(resultadoOFD)(115)
            Label59.Text = File.ReadLines(resultadoOFD)(116)
            Label60.Text = File.ReadLines(resultadoOFD)(117)
            Label61.Text = File.ReadLines(resultadoOFD)(118)
            Label62.Text = File.ReadLines(resultadoOFD)(119)
            Label63.Text = File.ReadLines(resultadoOFD)(120)
            Label64.Text = File.ReadLines(resultadoOFD)(121)
            Label65.Text = File.ReadLines(resultadoOFD)(122)
            Label66.Text = File.ReadLines(resultadoOFD)(123)
            Label67.Text = File.ReadLines(resultadoOFD)(124)
            Label68.Text = File.ReadLines(resultadoOFD)(125)
            Label69.Text = File.ReadLines(resultadoOFD)(126)
            Label70.Text = File.ReadLines(resultadoOFD)(127)
            Label71.Text = File.ReadLines(resultadoOFD)(128)
            Label72.Text = File.ReadLines(resultadoOFD)(129)
            Label73.Text = File.ReadLines(resultadoOFD)(130)
            Label74.Text = File.ReadLines(resultadoOFD)(131)
            Label75.Text = File.ReadLines(resultadoOFD)(132)
            Label76.Text = File.ReadLines(resultadoOFD)(133)
            Label77.Text = File.ReadLines(resultadoOFD)(134)
            Label78.Text = File.ReadLines(resultadoOFD)(135)
            Label79.Text = File.ReadLines(resultadoOFD)(136)
            Label80.Text = File.ReadLines(resultadoOFD)(137)
            Label81.Text = File.ReadLines(resultadoOFD)(138)
            Label82.Text = File.ReadLines(resultadoOFD)(139)
            Label83.Text = File.ReadLines(resultadoOFD)(140)
            Label84.Text = File.ReadLines(resultadoOFD)(141)
            Label85.Text = File.ReadLines(resultadoOFD)(142)
            Label86.Text = File.ReadLines(resultadoOFD)(143)
            Label87.Text = File.ReadLines(resultadoOFD)(144)
            Label88.Text = File.ReadLines(resultadoOFD)(145)
            Label89.Text = File.ReadLines(resultadoOFD)(146)
            Label90.Text = File.ReadLines(resultadoOFD)(147)
            Label91.Text = File.ReadLines(resultadoOFD)(148)
            Label92.Text = File.ReadLines(resultadoOFD)(149)
            Label93.Text = File.ReadLines(resultadoOFD)(150)
            Label94.Text = File.ReadLines(resultadoOFD)(151)
            Label95.Text = File.ReadLines(resultadoOFD)(152)
            Label96.Text = File.ReadLines(resultadoOFD)(153)
            Label97.Text = File.ReadLines(resultadoOFD)(154)
            Label98.Text = File.ReadLines(resultadoOFD)(155)
            Label99.Text = File.ReadLines(resultadoOFD)(156)
            Label100.Text = File.ReadLines(resultadoOFD)(157)
            Label102.Text = File.ReadLines(resultadoOFD)(158)
            Label103.Text = File.ReadLines(resultadoOFD)(159)
            Label104.Text = File.ReadLines(resultadoOFD)(160)
            Label105.Text = File.ReadLines(resultadoOFD)(161)
            Label106.Text = File.ReadLines(resultadoOFD)(162)
            Label107.Text = File.ReadLines(resultadoOFD)(163)
            Label108.Text = File.ReadLines(resultadoOFD)(164)
            Label109.Text = File.ReadLines(resultadoOFD)(165)
            Label110.Text = File.ReadLines(resultadoOFD)(166)
            Label101.Text = File.ReadLines(resultadoOFD)(167)
            Label111.Text = File.ReadLines(resultadoOFD)(168)
            Label112.Text = File.ReadLines(resultadoOFD)(169)
            Label113.Text = File.ReadLines(resultadoOFD)(170)
            Label114.Text = File.ReadLines(resultadoOFD)(171)
            Label115.Text = File.ReadLines(resultadoOFD)(172)
            Label116.Text = File.ReadLines(resultadoOFD)(173)
            Label117.Text = File.ReadLines(resultadoOFD)(174)
            Label118.Text = File.ReadLines(resultadoOFD)(175)
            Label119.Text = File.ReadLines(resultadoOFD)(176)
            Label120.Text = File.ReadLines(resultadoOFD)(177)
            Label121.Text = File.ReadLines(resultadoOFD)(178)
            Label122.Text = File.ReadLines(resultadoOFD)(179)
            Label123.Text = File.ReadLines(resultadoOFD)(180)
            Label124.Text = File.ReadLines(resultadoOFD)(181)
            TextBox72.Text = File.ReadLines(resultadoOFD)(182)
            TextBox73.Text = File.ReadLines(resultadoOFD)(183)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Button36_Click(sender As Object, e As EventArgs) Handles Button36.Click
        Try
            wc.DownloadString(IDEWEB + OVE + TextBox1.Text + oveOUT + Label1.Text)
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try

    End Sub

    Private Sub Button37_Click(sender As Object, e As EventArgs) Handles Button37.Click
        Try
            wc.DownloadString(IDEWEB + OVE + TextBox2.Text + oveOUT + Label2.Text)
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button38_Click(sender As Object, e As EventArgs) Handles Button38.Click
        Try
            wc.DownloadString(IDEWEB + OVE + TextBox3.Text + oveOUT + Label3.Text)
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button39_Click(sender As Object, e As EventArgs) Handles Button39.Click
        Try
            wc.DownloadString(IDEWEB + OVE + TextBox4.Text + oveOUT + Label4.Text)
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub
    Private Sub Button40_Click(sender As Object, e As EventArgs) Handles Button40.Click
        Try

            wc.DownloadString(IDEWEB + OVE + TextBox5.Text + oveOUT + Label5.Text)
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub
    Private Sub Button41_Click(sender As Object, e As EventArgs) Handles Button41.Click
        Try
            wc.DownloadString(IDEWEB + OVE + TextBox6.Text + oveOUT + Label6.Text)
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub
    Private Sub Button42_Click(sender As Object, e As EventArgs) Handles Button42.Click
        Try
            wc.DownloadString(IDEWEB + OVE + TextBox7.Text + oveOUT + Label7.Text)
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub
    Private Sub Button43_Click(sender As Object, e As EventArgs) Handles Button43.Click
        Try
            wc.DownloadString(IDEWEB + OVE + TextBox8.Text + oveOUT + Label8.Text)
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button44_Click(sender As Object, e As EventArgs) Handles Button44.Click
        Try
            wc.DownloadString(IDEWEB + OVE + TextBox9.Text + oveOUT + Label9.Text)
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub
    Private Sub Button45_Click(sender As Object, e As EventArgs) Handles Button45.Click
        Try
            wc.DownloadString(IDEWEB + OVE + TextBox10.Text + oveOUT + Label10.Text)
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub
    Private Sub Button46_Click(sender As Object, e As EventArgs) Handles Button46.Click
        Try
            wc.DownloadString(IDEWEB + OVE + TextBox11.Text + oveOUT + Label11.Text)
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub
    Private Sub Button47_Click(sender As Object, e As EventArgs) Handles Button47.Click
        Try
            wc.DownloadString(IDEWEB + OVE + TextBox12.Text + oveOUT + Label12.Text)
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub
    Private Sub Button48_Click(sender As Object, e As EventArgs) Handles Button48.Click
        Try
            wc.DownloadString(IDEWEB + OVE + TextBox13.Text + oveOUT + Label13.Text)
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub
    Private Sub Button49_Click(sender As Object, e As EventArgs) Handles Button49.Click
        Try
            wc.DownloadString(IDEWEB + OVE + TextBox14.Text + oveOUT + Label14.Text)
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub
    Private Sub Button50_Click(sender As Object, e As EventArgs) Handles Button50.Click
        Try
            wc.DownloadString(IDEWEB + OVE + TextBox15.Text + oveOUT + Label15.Text)
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub
    Private Sub APIToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If BOK = "BTN16" Then
            Dim BTN As String
            BTN = InputBox("ESCRIBA NUMERO DE PISTA", "PISTA")
            Label1.Text = BTN
        End If
    End Sub

    Private Sub APIToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles APIToolStripMenuItem.Click
        If RadioButton2.Checked = True Then
            Form4.Show()
        End If
        If RadioButton4.Checked = True Then
            Form4.Show()
        End If
        If RadioButton6.Checked = True Then
            Form4.Show()
        End If
        If RadioButton8.Checked = True Then
            Form4.Show()
        End If
        If RadioButton10.Checked = True Then
            Form4.Show()
        End If
        If RadioButton12.Checked = True Then
            Form4.Show()
        End If
        If RadioButton14.Checked = True Then
            Form4.Show()
        End If
        If RadioButton16.Checked = True Then
            Form4.Show()
        End If
        If RadioButton18.Checked = True Then
            Form4.Show()
        End If
        If RadioButton20.Checked = True Then
            Form4.Show()
        End If
        If RadioButton32.Checked = True Then
            Form4.Show()
        End If
        If RadioButton35.Checked = True Then
            Form4.Show()
        End If
        If RadioButton38.Checked = True Then
            Form4.Show()
        End If
        If RadioButton41.Checked = True Then
            Form4.Show()
        End If
        If RadioButton44.Checked = True Then
            Form4.Show()
        End If
        If RadioButton47.Checked = True Then
            GroupBox16.Visible = True
            GroupBox18.Visible = False
            Form4.Show()
        End If
        If RadioButton49.Checked = True Then
            GroupBox17.Visible = True
            GroupBox19.Visible = False
            Form4.Show()
        End If
    End Sub

    Private Sub TextBox49_TextChanged(sender As Object, e As EventArgs) Handles TextBox49.TextChanged
        If TextBox49.Text = "" Then
            RadioButton1.Checked = True
        Else
            RadioButton2.Checked = True
        End If
    End Sub
    Private Sub TextBox50_TextChanged(sender As Object, e As EventArgs) Handles TextBox50.TextChanged
        If TextBox50.Text = "" Then
            RadioButton3.Checked = True
        Else
            RadioButton4.Checked = True
        End If
    End Sub

    Private Sub TextBox51_TextChanged(sender As Object, e As EventArgs) Handles TextBox51.TextChanged
        If TextBox51.Text = "" Then
            RadioButton5.Checked = True
        Else
            RadioButton6.Checked = True
        End If
    End Sub

    Private Sub TextBox52_TextChanged(sender As Object, e As EventArgs) Handles TextBox52.TextChanged
        If TextBox52.Text = "" Then
            RadioButton7.Checked = True
        Else
            RadioButton8.Checked = True
        End If
    End Sub

    Private Sub TextBox53_TextChanged(sender As Object, e As EventArgs) Handles TextBox53.TextChanged
        If TextBox53.Text = "" Then
            RadioButton9.Checked = True
        Else
            RadioButton10.Checked = True
        End If
    End Sub

    Private Sub TextBox54_TextChanged(sender As Object, e As EventArgs) Handles TextBox54.TextChanged
        If TextBox54.Text = "" Then
            RadioButton11.Checked = True
        Else
            RadioButton12.Checked = True
        End If
    End Sub

    Private Sub TextBox55_TextChanged(sender As Object, e As EventArgs) Handles TextBox55.TextChanged
        If TextBox55.Text = "" Then
            RadioButton13.Checked = True
        Else
            RadioButton14.Checked = True
        End If
    End Sub

    Private Sub TextBox56_TextChanged(sender As Object, e As EventArgs) Handles TextBox56.TextChanged
        If TextBox56.Text = "" Then
            RadioButton15.Checked = True
        Else
            RadioButton16.Checked = True
        End If
    End Sub

    Private Sub TextBox57_TextChanged(sender As Object, e As EventArgs) Handles TextBox57.TextChanged
        If TextBox57.Text = "" Then
            RadioButton17.Checked = True
        Else
            RadioButton18.Checked = True
        End If
    End Sub

    Private Sub TextBox58_TextChanged(sender As Object, e As EventArgs) Handles TextBox58.TextChanged
        If TextBox58.Text = "" Then
            RadioButton19.Checked = True
        Else
            RadioButton20.Checked = True
        End If
    End Sub
    Private Sub BOTONCOLORES()
        Try
            'BOTON OPCIONES DE COLORES BOTONES ROJO O AMARILLO
            If Label27.Text = "2" Then
                wc.DownloadString(IDEWEB + OVE + TextBox1.Text + oveOUT + Label1.Text)
            End If
            If Label27.Text = "3" Then
                wc.DownloadString(IDEWEB + OVE + TextBox1.Text + oveIN + Label1.Text)
            End If

            If Label28.Text = "2" Then
                wc.DownloadString(IDEWEB + OVE + TextBox2.Text + oveOUT + Label2.Text)
            End If
            If Label28.Text = "3" Then
                wc.DownloadString(IDEWEB + OVE + TextBox2.Text + oveIN + Label2.Text)
            End If

            If Label29.Text = "2" Then
                wc.DownloadString(IDEWEB + OVE + TextBox3.Text + oveOUT + Label3.Text)
            End If
            If Label29.Text = "3" Then
                wc.DownloadString(IDEWEB + OVE + TextBox3.Text + oveIN + Label3.Text)
            End If

            If Label30.Text = "2" Then
                wc.DownloadString(IDEWEB + OVE + TextBox4.Text + oveOUT + Label4.Text)
            End If
            If Label30.Text = "3" Then
                wc.DownloadString(IDEWEB + OVE + TextBox4.Text + oveIN + Label4.Text)
            End If

            If Label31.Text = "2" Then
                wc.DownloadString(IDEWEB + OVE + TextBox5.Text + oveOUT + Label5.Text)
            End If
            If Label31.Text = "3" Then
                wc.DownloadString(IDEWEB + OVE + TextBox5.Text + oveIN + Label5.Text)
            End If

            If Label32.Text = "2" Then
                wc.DownloadString(IDEWEB + OVE + TextBox6.Text + oveOUT + Label6.Text)
            End If
            If Label32.Text = "3" Then
                wc.DownloadString(IDEWEB + OVE + TextBox6.Text + oveIN + Label6.Text)
            End If

            If Label33.Text = "2" Then
                wc.DownloadString(IDEWEB + OVE + TextBox7.Text + oveOUT + Label7.Text)
            End If
            If Label33.Text = "3" Then
                wc.DownloadString(IDEWEB + OVE + TextBox7.Text + oveIN + Label7.Text)
            End If

            If Label34.Text = "2" Then
                wc.DownloadString(IDEWEB + OVE + TextBox8.Text + oveOUT + Label8.Text)
            End If
            If Label34.Text = "3" Then
                wc.DownloadString(IDEWEB + OVE + TextBox8.Text + oveIN + Label8.Text)
            End If

            If Label35.Text = "2" Then
                wc.DownloadString(IDEWEB + OVE + TextBox9.Text + oveOUT + Label9.Text)
            End If
            If Label35.Text = "3" Then
                wc.DownloadString(IDEWEB + OVE + TextBox9.Text + oveIN + Label9.Text)
            End If

            If Label36.Text = "2" Then
                wc.DownloadString(IDEWEB + OVE + TextBox10.Text + oveOUT + Label10.Text)
            End If
            If Label36.Text = "3" Then
                wc.DownloadString(IDEWEB + OVE + TextBox10.Text + oveIN + Label10.Text)
            End If

            If Label37.Text = "2" Then
                wc.DownloadString(IDEWEB + OVE + TextBox11.Text + oveOUT + Label11.Text)
            End If
            If Label37.Text = "3" Then
                wc.DownloadString(IDEWEB + OVE + TextBox11.Text + oveIN + Label11.Text)
            End If

            If Label38.Text = "2" Then
                wc.DownloadString(IDEWEB + OVE + TextBox12.Text + oveOUT + Label12.Text)
            End If
            If Label38.Text = "3" Then
                wc.DownloadString(IDEWEB + OVE + TextBox12.Text + oveIN + Label12.Text)
            End If

            If Label39.Text = "2" Then
                wc.DownloadString(IDEWEB + OVE + TextBox13.Text + oveOUT + Label13.Text)
            End If
            If Label39.Text = "3" Then
                wc.DownloadString(IDEWEB + OVE + TextBox13.Text + oveIN + Label13.Text)
            End If

            If Label40.Text = "2" Then
                wc.DownloadString(IDEWEB + OVE + TextBox14.Text + oveOUT + Label14.Text)
            End If
            If Label40.Text = "3" Then
                wc.DownloadString(IDEWEB + OVE + TextBox14.Text + oveIN + Label14.Text)
            End If

            If Label41.Text = "2" Then
                wc.DownloadString(IDEWEB + OVE + TextBox15.Text + oveOUT + Label15.Text)
            End If
            If Label41.Text = "3" Then
                wc.DownloadString(IDEWEB + OVE + TextBox15.Text + oveIN + Label15.Text)
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub
    Private Sub ejecutarAPI()
        If RadioButton21.Checked = True Then
            wc.DownloadString(IDEWEB + TextBox49.Text)
        End If
        If RadioButton22.Checked = True Then
            wc.DownloadString(IDEWEB + TextBox50.Text)
        End If
        If RadioButton23.Checked = True Then
            wc.DownloadString(IDEWEB + TextBox51.Text)
        End If
        If RadioButton24.Checked = True Then
            wc.DownloadString(IDEWEB + TextBox52.Text)
        End If
        If RadioButton25.Checked = True Then
            wc.DownloadString(IDEWEB + TextBox53.Text)
        End If
        If RadioButton26.Checked = True Then
            wc.DownloadString(IDEWEB + TextBox54.Text)
        End If
        If RadioButton27.Checked = True Then
            wc.DownloadString(IDEWEB + TextBox55.Text)
        End If
        If RadioButton28.Checked = True Then
            wc.DownloadString(IDEWEB + TextBox56.Text)
        End If
        If RadioButton29.Checked = True Then
            wc.DownloadString(IDEWEB + TextBox57.Text)
        End If
        If RadioButton30.Checked = True Then
            wc.DownloadString(IDEWEB + TextBox58.Text)
        End If
        If RadioButton33.Checked = True Then
            wc.DownloadString(IDEWEB + TextBox64.Text)
        End If
        If RadioButton36.Checked = True Then
            wc.DownloadString(IDEWEB + TextBox65.Text)
        End If
        If RadioButton39.Checked = True Then
            wc.DownloadString(IDEWEB + TextBox66.Text)
        End If
        If RadioButton42.Checked = True Then
            wc.DownloadString(IDEWEB + TextBox67.Text)
        End If
        If RadioButton45.Checked = True Then
            wc.DownloadString(IDEWEB + TextBox68.Text)
        End If
    End Sub

    Private Sub Button52_Click(sender As Object, e As EventArgs) Handles Button52.Click
        Me.Enabled = False
        Form1.Show()

    End Sub

    Private Sub Button53_Click(sender As Object, e As EventArgs)
        Form10.ShowDialog()
    End Sub

    Private Sub ASIGTITULOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ASIGTITULOSToolStripMenuItem.Click
        Form11.ShowDialog()
    End Sub

    Private Sub Button54_Click(sender As Object, e As EventArgs) Handles Button54.Click
        Try
            If RadioButton31.Checked = True Then
                Call BOTONCOLORES()
                Call ejecutarAPI()
                Call CHAUDIO()
                Call audioONOF()
                wc.DownloadString(IDEWEB + PISTA + TextBox59.Text)
            End If

            If RadioButton32.Checked = True Then
                Call BOTONCOLORES()
                wc.DownloadString(IDEWEB + TextBox64.Text)
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button55_Click(sender As Object, e As EventArgs) Handles Button55.Click
        Try
            If RadioButton34.Checked = True Then
                Call BOTONCOLORES()
                Call ejecutarAPI()
                Call CHAUDIO()
                Call audioONOF()
                wc.DownloadString(IDEWEB + PISTA + TextBox60.Text)
            End If

            If RadioButton35.Checked = True Then
                Call BOTONCOLORES()
                wc.DownloadString(IDEWEB + TextBox65.Text)
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button56_Click(sender As Object, e As EventArgs) Handles Button56.Click
        Try
            If RadioButton37.Checked = True Then
                Call BOTONCOLORES()
                Call ejecutarAPI()
                Call CHAUDIO()
                Call audioONOF()
                wc.DownloadString(IDEWEB + PISTA + TextBox61.Text)
            End If

            If RadioButton38.Checked = True Then
                Call BOTONCOLORES()
                wc.DownloadString(IDEWEB + TextBox66.Text)
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button57_Click(sender As Object, e As EventArgs) Handles Button57.Click
        Try
            If RadioButton40.Checked = True Then
                Call BOTONCOLORES()
                Call ejecutarAPI()
                Call CHAUDIO()
                Call audioONOF()
                wc.DownloadString(IDEWEB + PISTA + TextBox62.Text)
            End If

            If RadioButton41.Checked = True Then
                Call BOTONCOLORES()
                wc.DownloadString(IDEWEB + TextBox67.Text)
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button58_Click(sender As Object, e As EventArgs) Handles Button58.Click
        Try
            If RadioButton43.Checked = True Then
                Call BOTONCOLORES()
                Call ejecutarAPI()
                Call CHAUDIO()
                Call audioONOF()
                wc.DownloadString(IDEWEB + PISTA + TextBox63.Text)
            End If

            If RadioButton44.Checked = True Then
                Call BOTONCOLORES()
                wc.DownloadString(IDEWEB + TextBox68.Text)
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub TextBox64_TextChanged(sender As Object, e As EventArgs) Handles TextBox64.TextChanged
        If TextBox64.Text = "" Then
            RadioButton31.Checked = True
        Else
            RadioButton32.Checked = True
        End If
    End Sub

    Private Sub TextBox65_TextChanged(sender As Object, e As EventArgs) Handles TextBox65.TextChanged
        If TextBox65.Text = "" Then
            RadioButton34.Checked = True
        Else
            RadioButton35.Checked = True
        End If
    End Sub

    Private Sub TextBox66_TextChanged(sender As Object, e As EventArgs) Handles TextBox66.TextChanged
        If TextBox66.Text = "" Then
            RadioButton37.Checked = True
        Else
            RadioButton38.Checked = True
        End If
    End Sub

    Private Sub TextBox67_TextChanged(sender As Object, e As EventArgs) Handles TextBox67.TextChanged
        If TextBox67.Text = "" Then
            RadioButton40.Checked = True
        Else
            RadioButton41.Checked = True
        End If
    End Sub

    Private Sub TextBox68_TextChanged(sender As Object, e As EventArgs) Handles TextBox68.TextChanged
        If TextBox68.Text = "" Then
            RadioButton43.Checked = True
        Else
            RadioButton44.Checked = True
        End If
    End Sub

    Private Sub Button54_MouseDown(sender As Object, e As MouseEventArgs) Handles Button54.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "BTN54"
        End If
    End Sub

    Private Sub Button55_MouseDown(sender As Object, e As MouseEventArgs) Handles Button55.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "BTN55"
        End If
    End Sub

    Private Sub Button56_MouseDown(sender As Object, e As MouseEventArgs) Handles Button56.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "BTN56"
        End If
    End Sub

    Private Sub Button57_MouseDown(sender As Object, e As MouseEventArgs) Handles Button57.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "BTN57"
        End If
    End Sub

    Private Sub Button58_MouseDown(sender As Object, e As MouseEventArgs) Handles Button58.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "BTN58"
        End If
    End Sub
    Private Sub CHAUDIO()
        If CheckBox1.Checked = True Then
            wc.DownloadString(IDEWEB + PAUSE + TextBox27.Text)
        End If
        If CheckBox2.Checked = True Then
            wc.DownloadString(IDEWEB + PAUSE + TextBox29.Text)
        End If

        If CheckBox3.Checked = True Then
            wc.DownloadString(IDEWEB + PLAY + TextBox27.Text)
        End If

        If CheckBox4.Checked = True Then
            wc.DownloadString(IDEWEB + PLAY + TextBox29.Text)
        End If

    End Sub
    Private Sub SONIDOSENVIOToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Form6.Show()
    End Sub

    Private Sub TextBox69_TextChanged(sender As Object, e As EventArgs) Handles TextBox69.TextChanged
        Call TECLAS()
        TextBox69.Text = ""
    End Sub
    Private Sub TECLAS()

        If TextBox69.Text = Label51.Text Then
            Call Button1.PerformClick()
        End If

        If TextBox69.Text = Label52.Text Then
            Call Button2.PerformClick()
        End If

        If TextBox69.Text = Label53.Text Then
            Call Button3.PerformClick()
        End If

        If TextBox69.Text = Label54.Text Then
            Call Button4.PerformClick()
        End If

        If TextBox69.Text = Label55.Text Then
            Call Button5.PerformClick()
        End If

        If TextBox69.Text = Label56.Text Then
            Call Button6.PerformClick()
        End If

        If TextBox69.Text = Label57.Text Then
            Call Button7.PerformClick()
        End If

        If TextBox69.Text = Label58.Text Then
            Call Button8.PerformClick()
        End If

        If TextBox69.Text = Label59.Text Then
            Call Button9.PerformClick()
        End If

        If TextBox69.Text = Label60.Text Then
            Call Button10.PerformClick()
        End If

        If TextBox69.Text = Label61.Text Then
            Call Button11.PerformClick()
        End If

        If TextBox69.Text = Label62.Text Then
            Call Button12.PerformClick()
        End If

        If TextBox69.Text = Label63.Text Then
            Call Button13.PerformClick()
        End If

        If TextBox69.Text = Label64.Text Then
            Call Button14.PerformClick()
        End If

        If TextBox69.Text = Label65.Text Then
            Call Button15.PerformClick()
        End If

        If TextBox69.Text = Label66.Text Then
            Call Button16.PerformClick()
        End If

        If TextBox69.Text = Label67.Text Then
            Call Button17.PerformClick()
        End If

        If TextBox69.Text = Label68.Text Then
            Call Button18.PerformClick()
        End If

        If TextBox69.Text = Label69.Text Then
            Call Button19.PerformClick()
        End If

        If TextBox69.Text = Label70.Text Then
            Call Button20.PerformClick()
        End If

        If TextBox69.Text = Label71.Text Then
            Call Button21.PerformClick()
        End If

        If TextBox69.Text = Label72.Text Then
            Call Button22.PerformClick()
        End If

        If TextBox69.Text = Label73.Text Then
            Call Button23.PerformClick()
        End If

        If TextBox69.Text = Label74.Text Then
            Call Button24.PerformClick()
        End If

        If TextBox69.Text = Label75.Text Then
            Call Button25.PerformClick()
        End If

        If TextBox69.Text = Label76.Text Then
            Call Button26.PerformClick()
        End If

        If TextBox69.Text = Label77.Text Then
            Call Button27.PerformClick()
        End If

        If TextBox69.Text = Label78.Text Then
            Call Button28.PerformClick()
        End If

        '   If TextBox69.Text = Label79.Text Then
        '            Call Button29.PerformClick()
        '  End If

        If TextBox69.Text = Label80.Text Then
            Call Button30.PerformClick()
        End If

        If TextBox69.Text = Label81.Text Then
            Call Button31.PerformClick()
        End If

        If TextBox69.Text = Label82.Text Then
            Call Button32.PerformClick()
        End If

        If TextBox69.Text = Label83.Text Then
            Call Button33.PerformClick()
        End If

        If TextBox69.Text = Label84.Text Then
            Call Button34.PerformClick()
        End If

        If TextBox69.Text = Label85.Text Then
            Call Button35.PerformClick()
        End If

        If TextBox69.Text = Label86.Text Then
            Call Button36.PerformClick()
        End If

        If TextBox69.Text = Label87.Text Then
            Call Button37.PerformClick()
        End If

        If TextBox69.Text = Label88.Text Then
            Call Button38.PerformClick()
        End If

        If TextBox69.Text = Label89.Text Then
            Call Button39.PerformClick()
        End If

        If TextBox69.Text = Label90.Text Then
            Call Button40.PerformClick()
        End If

        If TextBox69.Text = Label91.Text Then
            Call Button41.PerformClick()
        End If

        If TextBox69.Text = Label92.Text Then
            Call Button42.PerformClick()
        End If

        If TextBox69.Text = Label93.Text Then
            Call Button43.PerformClick()
        End If

        If TextBox69.Text = Label94.Text Then
            Call Button44.PerformClick()
        End If

        If TextBox69.Text = Label95.Text Then
            Call Button45.PerformClick()
        End If

        If TextBox69.Text = Label96.Text Then
            Call Button46.PerformClick()
        End If

        If TextBox69.Text = Label97.Text Then
            Call Button47.PerformClick()
        End If

        If TextBox69.Text = Label98.Text Then
            Call Button48.PerformClick()
        End If

        If TextBox69.Text = Label99.Text Then
            Call Button49.PerformClick()
        End If

        If TextBox69.Text = Label100.Text Then
            Call Button50.PerformClick()
        End If

        '  If TextBox69.Text = Label101.Text Then
        '  Call Button51.PerformClick()
        '  End If

        If TextBox69.Text = Label102.Text Then
            Call Button52.PerformClick()
        End If

        'If TextBox69.Text = Label103.Text Then
        ' Call Button53.PerformClick()
        ' End If

        If TextBox69.Text = Label104.Text Then
            Call Button54.PerformClick()
        End If

        If TextBox69.Text = Label105.Text Then
            Call Button55.PerformClick()
        End If

        If TextBox69.Text = Label106.Text Then
            Call Button56.PerformClick()
        End If

        If TextBox69.Text = Label107.Text Then
            Call Button57.PerformClick()
        End If

        If TextBox69.Text = Label108.Text Then
            Call Button58.PerformClick()
        End If

    End Sub
    Private Sub ASIGNARTECLAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ASIGNARTECLAToolStripMenuItem.Click
        Form12.ShowDialog()
    End Sub

    Private Sub Button36_MouseDown(sender As Object, e As MouseEventArgs) Handles Button36.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "BTN36"
        End If
    End Sub

    Private Sub Button37_MouseDown(sender As Object, e As MouseEventArgs) Handles Button37.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "BTN37"
        End If
    End Sub

    Private Sub Button38_MouseDown(sender As Object, e As MouseEventArgs) Handles Button38.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "BTN38"
        End If
    End Sub

    Private Sub Button39_MouseDown(sender As Object, e As MouseEventArgs) Handles Button39.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "BTN39"
        End If
    End Sub

    Private Sub Button40_MouseDown(sender As Object, e As MouseEventArgs) Handles Button40.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "BTN40"
        End If
    End Sub

    Private Sub Button41_MouseDown(sender As Object, e As MouseEventArgs) Handles Button41.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "BTN41"
        End If
    End Sub

    Private Sub Button42_MouseDown(sender As Object, e As MouseEventArgs) Handles Button42.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "BTN42"
        End If
    End Sub

    Private Sub Button43_MouseDown(sender As Object, e As MouseEventArgs) Handles Button43.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "BTN43"
        End If
    End Sub

    Private Sub Button44_MouseDown(sender As Object, e As MouseEventArgs) Handles Button44.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "BTN44"
        End If
    End Sub

    Private Sub Button45_MouseDown(sender As Object, e As MouseEventArgs) Handles Button45.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "BTN45"
        End If
    End Sub

    Private Sub Button46_MouseDown(sender As Object, e As MouseEventArgs) Handles Button46.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "BTN46"
        End If
    End Sub

    Private Sub Button47_MouseDown(sender As Object, e As MouseEventArgs) Handles Button47.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "BTN47"
        End If
    End Sub

    Private Sub Button48_MouseDown(sender As Object, e As MouseEventArgs) Handles Button48.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "BTN48"
        End If
    End Sub

    Private Sub Button49_MouseDown(sender As Object, e As MouseEventArgs) Handles Button49.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "BTN49"
        End If
    End Sub

    Private Sub Button50_MouseDown(sender As Object, e As MouseEventArgs) Handles Button50.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "BTN50"
        End If
    End Sub

    Private Sub Button51_MouseDown(sender As Object, e As MouseEventArgs)
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "BTN51"
        End If
    End Sub

    Private Sub Button35_MouseDown(sender As Object, e As MouseEventArgs) Handles Button35.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "BTN35"
        End If
    End Sub

    Private Sub Button52_MouseDown(sender As Object, e As MouseEventArgs) Handles Button52.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "BTN52"
        End If
    End Sub

    Private Sub Button53_MouseDown(sender As Object, e As MouseEventArgs)
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "BTN53"
        End If
    End Sub

    Private Sub Button27_MouseDown(sender As Object, e As MouseEventArgs) Handles Button27.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "BTN27"
        End If
    End Sub

    Private Sub Button26_MouseDown(sender As Object, e As MouseEventArgs) Handles Button26.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "BTN26"
        End If
    End Sub

    Private Sub CheckBox1_Click(sender As Object, e As EventArgs) Handles CheckBox1.Click
        CheckBox3.Checked = False
    End Sub

    Private Sub CheckBox3_Click(sender As Object, e As EventArgs) Handles CheckBox3.Click
        CheckBox1.Checked = False
    End Sub

    Private Sub CheckBox2_Click(sender As Object, e As EventArgs) Handles CheckBox2.Click
        CheckBox4.Checked = False
    End Sub

    Private Sub CheckBox4_Click(sender As Object, e As EventArgs) Handles CheckBox4.Click
        CheckBox2.Checked = False
    End Sub

    Private Sub SonidoEnvioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SonidoEnvioToolStripMenuItem.Click
        Form6.Show()
    End Sub

    Private Sub EfectosSonidoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EfectosSonidoToolStripMenuItem.Click
        Form5.Show()
    End Sub
    Private Sub ContadorRetrocesoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContadorRetrocesoToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub BaseDeDatosTitulosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BaseDeDatosTitulosToolStripMenuItem.Click
        Form10.ShowDialog()
    End Sub
    Private Sub CheckBox5_Click(sender As Object, e As EventArgs) Handles CheckBox5.Click
        If TextBox27.Text = "" Then
            MsgBox("INSERTE NUMERO DE PISTA")
            CheckBox5.Checked = False
            TextBox27.Select()
        Else
            CheckBox6.Checked = False
        End If
    End Sub
    Private Sub CheckBox6_Click(sender As Object, e As EventArgs) Handles CheckBox6.Click
        If TextBox27.Text = "" Then
            MsgBox("INSERTE NUMERO DE PISTA")
            CheckBox6.Checked = False
            TextBox27.Select()
        Else
            CheckBox5.Checked = False
        End If
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        If TextBox27.Text = "" Then
            MsgBox("INSERTE NUMERO DE PISTA")
            TextBox27.Select()
        Else
            CheckBox5.Checked = True
            CheckBox6.Checked = False
            Button29.BackColor = Color.Red
            Button51.BackColor = Color.Blue
            wc.DownloadString(IDEWEB + TextBox70.Text + TextBox72.Text)
        End If
    End Sub

    Private Sub Button51_Click(sender As Object, e As EventArgs) Handles Button51.Click
        If TextBox27.Text = "" Then
            MsgBox("INSERTE NUMERO DE PISTA")
            TextBox27.Select()
        Else
            CheckBox6.Checked = True
            CheckBox5.Checked = False
            Button29.BackColor = Color.Blue
            Button51.BackColor = Color.Red
            wc.DownloadString(IDEWEB + TextBox71.Text + TextBox72.Text)
        End If
    End Sub

    Private Sub Button53_Click_1(sender As Object, e As EventArgs) Handles Button53.Click
        If TextBox29.Text = "" Then
            MsgBox("INSERTE NUMERO DE PISTA")
            TextBox29.Select()
        Else
            CheckBox7.Checked = True
            CheckBox8.Checked = False
            Button53.BackColor = Color.Red
            Button59.BackColor = Color.Blue
            wc.DownloadString(IDEWEB + TextBox70.Text + TextBox73.Text)
        End If
    End Sub

    Private Sub Button59_Click(sender As Object, e As EventArgs) Handles Button59.Click
        If TextBox29.Text = "" Then
            MsgBox("INSERTE NUMERO DE PISTA")
            TextBox29.Select()
        Else
            CheckBox7.Checked = False
            CheckBox8.Checked = True
            Button59.BackColor = Color.Red
            Button53.BackColor = Color.Blue
            wc.DownloadString(IDEWEB + TextBox71.Text + TextBox73.Text)
        End If
    End Sub
    Private Sub CheckBox7_Click(sender As Object, e As EventArgs) Handles CheckBox7.Click
        If TextBox29.Text = "" Then
            MsgBox("INSERTE NUMERO DE PISTA")
            CheckBox7.Checked = False
            TextBox29.Select()
        Else
            CheckBox8.Checked = False
        End If
    End Sub
    Private Sub CheckBox8_Click(sender As Object, e As EventArgs) Handles CheckBox8.Click
        If TextBox29.Text = "" Then
            MsgBox("INSERTE NUMERO DE PISTA")
            CheckBox8.Checked = False
            TextBox29.Select()
        Else
            CheckBox7.Checked = False
        End If
    End Sub
    Private Sub audioONOF()
        If CheckBox5.Checked = True Then
            Button29.BackColor = Color.Red
            Button51.BackColor = Color.Blue
            wc.DownloadString(IDEWEB + TextBox70.Text + TextBox72.Text)
        End If
        If CheckBox6.Checked = True Then
            Button29.BackColor = Color.Blue
            Button51.BackColor = Color.Red
            wc.DownloadString(IDEWEB + TextBox71.Text + TextBox72.Text)
        End If
        If CheckBox7.Checked = True Then
            Button53.BackColor = Color.Red
            Button59.BackColor = Color.Blue
            wc.DownloadString(IDEWEB + TextBox70.Text + TextBox73.Text)
        End If
        If CheckBox8.Checked = True Then
            Button53.BackColor = Color.Blue
            Button59.BackColor = Color.Red
            wc.DownloadString(IDEWEB + TextBox71.Text + TextBox73.Text)
        End If
    End Sub

    Private Sub TextBox72_TextChanged(sender As Object, e As EventArgs) Handles TextBox72.TextChanged
        GroupBox18.Visible = False
        GroupBox16.Visible = True
        GroupBox16.Location = New Point(330, 407)
        TextBox27.Text = TextBox72.Text
    End Sub
    Private Sub TextBox73_TextChanged(sender As Object, e As EventArgs) Handles TextBox73.TextChanged
        GroupBox19.Visible = False
        GroupBox17.Visible = True
        GroupBox17.Location = New Point(330, 444)
        TextBox29.Text = TextBox73.Text
    End Sub
End Class