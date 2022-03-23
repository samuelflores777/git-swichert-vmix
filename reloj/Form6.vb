Imports System.IO
Imports System.Data.OleDb
Public Class Form6
    Public Shared _instancia As Form3
    Public wc As New Net.WebClient
    Public FUN1 As String = "/API/?Function=AudioBus&Input="
    Public FUN2_M As String = "&Value=M"
    Public FUN2_A As String = "&Value=A"
    Public FUN2_B As String = "&Value=B"

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

            If (keyData = Keys.F3) Then
                Label1.Visible = True
                Label2.Visible = True
                Label3.Visible = True
                Label4.Visible = True
                Label5.Visible = True
                Label6.Visible = True
                Label7.Visible = True
                Label8.Visible = True
                Label9.Visible = True
                Label10.Visible = True
                Label11.Visible = True
                Label12.Visible = True
                Label13.Visible = True
                Label14.Visible = True
                Label15.Visible = True
                Label16.Visible = True
                Label17.Visible = True
                Label18.Visible = True
                Label19.Visible = True
                Label20.Visible = True
                Label21.Visible = True
                Label22.Visible = True
                Label23.Visible = True
                Label24.Visible = True
                Label25.Visible = True
                Label26.Visible = True
                Label27.Visible = True
                Label28.Visible = True
                Label29.Visible = True
                Label30.Visible = True
                Label31.Visible = True
                Label32.Visible = True
                Label33.Visible = True
                Label34.Visible = True
                Label35.Visible = True
                Label36.Visible = True
                Label37.Visible = True
                Label38.Visible = True
                Label39.Visible = True
                Label40.Visible = True
                Label41.Visible = True
                Label42.Visible = True
                Label43.Visible = True
                Label44.Visible = True
                Label45.Visible = True
                Label46.Visible = True
                Label47.Visible = True
                Label48.Visible = True
                Label49.Visible = True
                Label50.Visible = True
                Label51.Visible = True

                Return True
            End If

            If (keyData = Keys.F4) Then
                Label1.Visible = False
                Label2.Visible = False
                Label3.Visible = False
                Label4.Visible = False
                Label5.Visible = False
                Label6.Visible = False
                Label7.Visible = False
                Label8.Visible = False
                Label9.Visible = False
                Label10.Visible = False
                Label11.Visible = False
                Label12.Visible = False
                Label13.Visible = False
                Label14.Visible = False
                Label15.Visible = False
                Label16.Visible = False
                Label17.Visible = False
                Label18.Visible = False
                Label19.Visible = False
                Label20.Visible = False
                Label21.Visible = False
                Label22.Visible = False
                Label23.Visible = False
                Label24.Visible = False
                Label25.Visible = False
                Label26.Visible = False
                Label27.Visible = False
                Label28.Visible = False
                Label29.Visible = False
                Label30.Visible = False
                Label31.Visible = False
                Label32.Visible = False
                Label33.Visible = False
                Label34.Visible = False
                Label35.Visible = False
                Label36.Visible = False
                Label37.Visible = False
                Label38.Visible = False
                Label39.Visible = False
                Label40.Visible = False
                Label41.Visible = False
                Label42.Visible = False
                Label43.Visible = False
                Label44.Visible = False
                Label45.Visible = False
                Label46.Visible = False
                Label47.Visible = False
                Label48.Visible = False
                Label49.Visible = False
                Label50.Visible = False
                Label51.Visible = False
                Return True
            End If



        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'ENVIO FACEBOOK
        Try
            If Button1.ForeColor = Color.White Then
                Button1.BackgroundImage = IMGboton(0)
                Button1.ForeColor = Color.Cyan
                wc.DownloadString(IDEWEB + FUN1 + TextBox2.Text + FUN2_M)
            Else
                Button1.ForeColor = Color.White
                Button1.BackgroundImage = IMGboton(1)
                wc.DownloadString(IDEWEB + FUN1 + TextBox2.Text + FUN2_M)
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'ENVIO MONITOR
        Try
            If Button2.ForeColor = Color.Cyan Then
                Button2.BackgroundImage = IMGboton(1)
                Button2.ForeColor = Color.White
                wc.DownloadString(IDEWEB + FUN1 + TextBox2.Text + FUN2_A)
            Else
                Button2.ForeColor = Color.Cyan
                Button2.BackgroundImage = IMGboton(0)
                wc.DownloadString(IDEWEB + FUN1 + TextBox2.Text + FUN2_A)
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'ENVIO ZOOM
        Try
            If Button3.ForeColor = Color.Cyan Then
                Button3.BackgroundImage = IMGboton(1)
                Button3.ForeColor = Color.White
                wc.DownloadString(IDEWEB + FUN1 + TextBox2.Text + FUN2_B)
            Else
                Button3.ForeColor = Color.Cyan
                Button3.BackgroundImage = IMGboton(0)
                wc.DownloadString(IDEWEB + FUN1 + TextBox2.Text + FUN2_B)
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'ENVIO FACEBOOK
        Try
            If Button4.ForeColor = Color.White Then
                Button4.BackgroundImage = IMGboton(0)
                Button4.ForeColor = Color.Cyan
                wc.DownloadString(IDEWEB + FUN1 + TextBox4.Text + FUN2_M)
            Else
                Button4.ForeColor = Color.White
                Button4.BackgroundImage = IMGboton(1)
                wc.DownloadString(IDEWEB + FUN1 + TextBox4.Text + FUN2_M)
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'ENVIO FACEBOOK
        Try
            If Button7.ForeColor = Color.White Then
                Button7.BackgroundImage = IMGboton(0)
                Button7.ForeColor = Color.Cyan
                wc.DownloadString(IDEWEB + FUN1 + TextBox6.Text + FUN2_M)
            Else
                Button7.ForeColor = Color.White
                Button7.BackgroundImage = IMGboton(1)
                wc.DownloadString(IDEWEB + FUN1 + TextBox6.Text + FUN2_M)
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        'ENVIO FACEBOOK
        Try
            If Button10.ForeColor = Color.White Then
                Button10.BackgroundImage = IMGboton(0)
                Button10.ForeColor = Color.Cyan
                wc.DownloadString(IDEWEB + FUN1 + TextBox8.Text + FUN2_M)
            Else
                Button10.ForeColor = Color.White
                Button10.BackgroundImage = IMGboton(1)
                wc.DownloadString(IDEWEB + FUN1 + TextBox8.Text + FUN2_M)
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        'ENVIO FACEBOOK
        Try
            If Button13.ForeColor = Color.White Then
                Button13.BackgroundImage = IMGboton(0)
                Button13.ForeColor = Color.Cyan
                wc.DownloadString(IDEWEB + FUN1 + TextBox10.Text + FUN2_M)
            Else
                Button13.ForeColor = Color.White
                Button13.BackgroundImage = IMGboton(1)
                wc.DownloadString(IDEWEB + FUN1 + TextBox10.Text + FUN2_M)
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        'ENVIO FACEBOOK
        Try
            If Button16.ForeColor = Color.White Then
                Button16.BackgroundImage = IMGboton(0)
                Button16.ForeColor = Color.Cyan
                wc.DownloadString(IDEWEB + FUN1 + TextBox12.Text + FUN2_M)
            Else
                Button16.ForeColor = Color.White
                Button16.BackgroundImage = IMGboton(1)
                wc.DownloadString(IDEWEB + FUN1 + TextBox12.Text + FUN2_M)
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        'ENVIO FACEBOOK
        Try
            If Button19.ForeColor = Color.White Then
                Button19.BackgroundImage = IMGboton(0)
                Button19.ForeColor = Color.Cyan
                wc.DownloadString(IDEWEB + FUN1 + TextBox14.Text + FUN2_M)
            Else
                Button19.ForeColor = Color.White
                Button19.BackgroundImage = IMGboton(1)
                wc.DownloadString(IDEWEB + FUN1 + TextBox14.Text + FUN2_M)
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        'ENVIO FACEBOOK
        Try
            If Button22.ForeColor = Color.White Then
                Button22.BackgroundImage = IMGboton(0)
                Button22.ForeColor = Color.Cyan
                wc.DownloadString(IDEWEB + FUN1 + TextBox16.Text + FUN2_M)
            Else
                Button22.ForeColor = Color.White
                Button22.BackgroundImage = IMGboton(1)
                wc.DownloadString(IDEWEB + FUN1 + TextBox16.Text + FUN2_M)
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        'ENVIO FACEBOOK
        Try
            If Button25.ForeColor = Color.White Then
                Button25.BackgroundImage = IMGboton(0)
                Button25.ForeColor = Color.Cyan
                wc.DownloadString(IDEWEB + FUN1 + TextBox18.Text + FUN2_M)
            Else
                Button25.ForeColor = Color.White
                Button25.BackgroundImage = IMGboton(1)
                wc.DownloadString(IDEWEB + FUN1 + TextBox18.Text + FUN2_M)
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        'ENVIO FACEBOOK
        Try
            If Button28.ForeColor = Color.White Then
                Button28.BackgroundImage = IMGboton(0)
                Button28.ForeColor = Color.Cyan
                wc.DownloadString(IDEWEB + FUN1 + TextBox20.Text + FUN2_M)
            Else
                Button28.ForeColor = Color.White
                Button28.BackgroundImage = IMGboton(1)
                wc.DownloadString(IDEWEB + FUN1 + TextBox20.Text + FUN2_M)
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        'ENVIO FACEBOOK
        Try
            If Button31.ForeColor = Color.White Then
                Button31.BackgroundImage = IMGboton(0)
                Button31.ForeColor = Color.Cyan
                wc.DownloadString(IDEWEB + FUN1 + TextBox22.Text + FUN2_M)
            Else
                Button31.ForeColor = Color.White
                Button31.BackgroundImage = IMGboton(1)
                wc.DownloadString(IDEWEB + FUN1 + TextBox22.Text + FUN2_M)
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        'ENVIO FACEBOOK
        Try
            If Button34.ForeColor = Color.White Then
                Button34.BackgroundImage = IMGboton(0)
                Button34.ForeColor = Color.Cyan
                wc.DownloadString(IDEWEB + FUN1 + TextBox24.Text + FUN2_M)
            Else
                Button34.ForeColor = Color.White
                Button34.BackgroundImage = IMGboton(1)
                wc.DownloadString(IDEWEB + FUN1 + TextBox24.Text + FUN2_M)
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button42_Click(sender As Object, e As EventArgs) Handles Button42.Click
        'ENVIO FACEBOOK

        Try
            If Button42.ForeColor = Color.White Then
                Button42.BackgroundImage = IMGboton(0)
                Button42.ForeColor = Color.Cyan
                wc.DownloadString(IDEWEB + FUN1 + TextBox28.Text + FUN2_M)
            Else
                Button42.ForeColor = Color.White
                Button42.BackgroundImage = IMGboton(1)
                wc.DownloadString(IDEWEB + FUN1 + TextBox28.Text + FUN2_M)
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button37_Click(sender As Object, e As EventArgs) Handles Button37.Click
        'ENVIO FACEBOOK
        Try
            If Button37.ForeColor = Color.White Then
                Button37.BackgroundImage = IMGboton(0)
                Button37.ForeColor = Color.Cyan
                wc.DownloadString(IDEWEB + FUN1 + TextBox26.Text + FUN2_M)
            Else
                Button37.ForeColor = Color.White
                Button37.BackgroundImage = IMGboton(1)
                wc.DownloadString(IDEWEB + FUN1 + TextBox26.Text + FUN2_M)
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button43_Click(sender As Object, e As EventArgs) Handles Button43.Click
        'ENVIO FACEBOOK
        Try
            If Button43.ForeColor = Color.White Then
                Button43.BackgroundImage = IMGboton(0)
                Button43.ForeColor = Color.Cyan
                wc.DownloadString(IDEWEB + FUN1 + TextBox30.Text + FUN2_M)
            Else
                Button43.ForeColor = Color.White
                Button43.BackgroundImage = IMGboton(1)
                wc.DownloadString(IDEWEB + FUN1 + TextBox30.Text + FUN2_M)
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button46_Click(sender As Object, e As EventArgs) Handles Button46.Click
        'ENVIO FACEBOOK
        Try
            If Button46.ForeColor = Color.White Then
                Button46.BackgroundImage = IMGboton(0)
                Button46.ForeColor = Color.Cyan
                wc.DownloadString(IDEWEB + FUN1 + TextBox32.Text + FUN2_M)
            Else
                Button46.ForeColor = Color.White
                Button46.BackgroundImage = IMGboton(1)
                wc.DownloadString(IDEWEB + FUN1 + TextBox32.Text + FUN2_M)
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button49_Click(sender As Object, e As EventArgs) Handles Button49.Click
        'ENVIO FACEBOOK
        Try
            If Button49.ForeColor = Color.White Then
                Button49.BackgroundImage = IMGboton(0)
                Button49.ForeColor = Color.Cyan
                wc.DownloadString(IDEWEB + FUN1 + TextBox34.Text + FUN2_M)
            Else
                Button49.ForeColor = Color.White
                Button49.BackgroundImage = IMGboton(1)
                wc.DownloadString(IDEWEB + FUN1 + TextBox34.Text + FUN2_M)
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'ENVIO MONITOR
        Try
            If Button5.ForeColor = Color.Cyan Then
                Button5.BackgroundImage = IMGboton(1)
                Button5.ForeColor = Color.White
                wc.DownloadString(IDEWEB + FUN1 + TextBox4.Text + FUN2_A)
            Else
                Button5.ForeColor = Color.Cyan
                Button5.BackgroundImage = IMGboton(0)
                wc.DownloadString(IDEWEB + FUN1 + TextBox4.Text + FUN2_A)
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'ENVIO ZOOM
        Try
            If Button6.ForeColor = Color.Cyan Then
                Button6.BackgroundImage = IMGboton(1)
                Button6.ForeColor = Color.White
                wc.DownloadString(IDEWEB + FUN1 + TextBox4.Text + FUN2_B)
            Else
                Button6.ForeColor = Color.Cyan
                Button6.BackgroundImage = IMGboton(0)
                wc.DownloadString(IDEWEB + FUN1 + TextBox4.Text + FUN2_B)
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        'ENVIO MONITOR

        Try
            If Button8.ForeColor = Color.Cyan Then
                Button8.BackgroundImage = IMGboton(1)
                Button8.ForeColor = Color.White
                wc.DownloadString(IDEWEB + FUN1 + TextBox6.Text + FUN2_A)
            Else
                Button8.ForeColor = Color.Cyan
                Button8.BackgroundImage = IMGboton(0)
                wc.DownloadString(IDEWEB + FUN1 + TextBox6.Text + FUN2_A)
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        'ENVIO ZOOM
        Try
            If Button9.ForeColor = Color.Cyan Then
                Button9.BackgroundImage = IMGboton(1)
                Button9.ForeColor = Color.White
                wc.DownloadString(IDEWEB + FUN1 + TextBox6.Text + FUN2_B)
            Else
                Button9.ForeColor = Color.Cyan
                Button9.BackgroundImage = IMGboton(0)
                wc.DownloadString(IDEWEB + FUN1 + TextBox6.Text + FUN2_B)
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        'ENVIO MONITOR

        Try
            If Button11.ForeColor = Color.Cyan Then
                Button11.BackgroundImage = IMGboton(1)
                Button11.ForeColor = Color.White
                wc.DownloadString(IDEWEB + FUN1 + TextBox8.Text + FUN2_A)
            Else
                Button11.ForeColor = Color.Cyan
                Button11.BackgroundImage = IMGboton(0)
                wc.DownloadString(IDEWEB + FUN1 + TextBox8.Text + FUN2_A)
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        'ENVIO ZOOM
        Try
            If Button12.ForeColor = Color.Cyan Then
                Button12.BackgroundImage = IMGboton(1)
                Button12.ForeColor = Color.White
                wc.DownloadString(IDEWEB + FUN1 + TextBox8.Text + FUN2_B)
            Else
                Button12.ForeColor = Color.Cyan
                Button12.BackgroundImage = IMGboton(0)
                wc.DownloadString(IDEWEB + FUN1 + TextBox8.Text + FUN2_B)
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        'ENVIO MONITOR

        Try
            If Button14.ForeColor = Color.Cyan Then
                Button14.BackgroundImage = IMGboton(1)
                Button14.ForeColor = Color.White
                wc.DownloadString(IDEWEB + FUN1 + TextBox10.Text + FUN2_A)
            Else
                Button14.ForeColor = Color.Cyan
                Button14.BackgroundImage = IMGboton(0)
                wc.DownloadString(IDEWEB + FUN1 + TextBox10.Text + FUN2_A)
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        'ENVIO ZOOM
        Try
            If Button15.ForeColor = Color.Cyan Then
                Button15.BackgroundImage = IMGboton(1)
                Button15.ForeColor = Color.White
                wc.DownloadString(IDEWEB + FUN1 + TextBox10.Text + FUN2_B)
            Else
                Button15.ForeColor = Color.Cyan
                Button15.BackgroundImage = IMGboton(0)
                wc.DownloadString(IDEWEB + FUN1 + TextBox10.Text + FUN2_B)
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        'ENVIO MONITOR
        Try
            If Button17.ForeColor = Color.Cyan Then
                Button17.BackgroundImage = IMGboton(1)
                Button17.ForeColor = Color.White
                wc.DownloadString(IDEWEB + FUN1 + TextBox12.Text + FUN2_A)
            Else
                Button17.ForeColor = Color.Cyan
                Button17.BackgroundImage = IMGboton(0)
                wc.DownloadString(IDEWEB + FUN1 + TextBox12.Text + FUN2_A)
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        'ENVIO ZOOM
        Try
            If Button18.ForeColor = Color.Cyan Then
                Button18.BackgroundImage = IMGboton(1)
                Button18.ForeColor = Color.White
                wc.DownloadString(IDEWEB + FUN1 + TextBox12.Text + FUN2_B)
            Else
                Button18.ForeColor = Color.Cyan
                Button18.BackgroundImage = IMGboton(0)
                wc.DownloadString(IDEWEB + FUN1 + TextBox12.Text + FUN2_B)
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        'ENVIO MONITOR

        Try
            If Button20.ForeColor = Color.Cyan Then
                Button20.BackgroundImage = IMGboton(1)
                Button20.ForeColor = Color.White
                wc.DownloadString(IDEWEB + FUN1 + TextBox14.Text + FUN2_A)
            Else
                Button20.ForeColor = Color.Cyan
                Button20.BackgroundImage = IMGboton(0)
                wc.DownloadString(IDEWEB + FUN1 + TextBox14.Text + FUN2_A)
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        'ENVIO ZOOM
        Try
            If Button21.ForeColor = Color.Cyan Then
                Button21.BackgroundImage = IMGboton(1)
                Button21.ForeColor = Color.White
                wc.DownloadString(IDEWEB + FUN1 + TextBox14.Text + FUN2_B)
            Else
                Button21.ForeColor = Color.Cyan
                Button21.BackgroundImage = IMGboton(0)
                wc.DownloadString(IDEWEB + FUN1 + TextBox14.Text + FUN2_B)
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        'ENVIO MONITOR

        Try
            If Button23.ForeColor = Color.Cyan Then
                Button23.BackgroundImage = IMGboton(1)
                Button23.ForeColor = Color.White
                wc.DownloadString(IDEWEB + FUN1 + TextBox16.Text + FUN2_A)
            Else
                Button23.ForeColor = Color.Cyan
                Button23.BackgroundImage = IMGboton(0)
                wc.DownloadString(IDEWEB + FUN1 + TextBox16.Text + FUN2_A)
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        'ENVIO ZOOM
        Try
            If Button24.ForeColor = Color.Cyan Then
                Button24.BackgroundImage = IMGboton(1)
                Button24.ForeColor = Color.White
                wc.DownloadString(IDEWEB + FUN1 + TextBox16.Text + FUN2_B)
            Else
                Button24.ForeColor = Color.Cyan
                Button24.BackgroundImage = IMGboton(0)
                wc.DownloadString(IDEWEB + FUN1 + TextBox16.Text + FUN2_B)
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        'ENVIO MONITOR
        Try
            If Button26.ForeColor = Color.Cyan Then
                Button26.BackgroundImage = IMGboton(1)
                Button26.ForeColor = Color.White
                wc.DownloadString(IDEWEB + FUN1 + TextBox18.Text + FUN2_A)
            Else
                Button26.ForeColor = Color.Cyan
                Button26.BackgroundImage = IMGboton(0)
                wc.DownloadString(IDEWEB + FUN1 + TextBox18.Text + FUN2_A)
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        'ENVIO ZOOM
        Try
            If Button27.ForeColor = Color.Cyan Then
                Button27.BackgroundImage = IMGboton(1)
                Button27.ForeColor = Color.White
                wc.DownloadString(IDEWEB + FUN1 + TextBox18.Text + FUN2_B)
            Else
                Button27.ForeColor = Color.Cyan
                Button27.BackgroundImage = IMGboton(0)
                wc.DownloadString(IDEWEB + FUN1 + TextBox18.Text + FUN2_B)
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        'ENVIO MONITOR
        Try
            If Button29.ForeColor = Color.Cyan Then
                Button29.BackgroundImage = IMGboton(1)
                Button29.ForeColor = Color.White
                wc.DownloadString(IDEWEB + FUN1 + TextBox20.Text + FUN2_A)
            Else
                Button29.ForeColor = Color.Cyan
                Button29.BackgroundImage = IMGboton(0)
                wc.DownloadString(IDEWEB + FUN1 + TextBox20.Text + FUN2_A)
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        'ENVIO ZOOM
        Try
            If Button30.ForeColor = Color.Cyan Then
                Button30.BackgroundImage = IMGboton(1)
                Button30.ForeColor = Color.White
                wc.DownloadString(IDEWEB + FUN1 + TextBox20.Text + FUN2_B)
            Else
                Button30.ForeColor = Color.Cyan
                Button30.BackgroundImage = IMGboton(0)
                wc.DownloadString(IDEWEB + FUN1 + TextBox20.Text + FUN2_B)
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        'ENVIO MONITOR

        Try
            If Button32.ForeColor = Color.Cyan Then
                Button32.BackgroundImage = IMGboton(1)
                Button32.ForeColor = Color.White
                wc.DownloadString(IDEWEB + FUN1 + TextBox22.Text + FUN2_A)
            Else
                Button32.ForeColor = Color.Cyan
                Button32.BackgroundImage = IMGboton(0)
                wc.DownloadString(IDEWEB + FUN1 + TextBox22.Text + FUN2_A)
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        'ENVIO ZOOM
        Try
            If Button33.ForeColor = Color.Cyan Then
                Button33.BackgroundImage = IMGboton(1)
                Button33.ForeColor = Color.White
                wc.DownloadString(IDEWEB + FUN1 + TextBox22.Text + FUN2_B)
            Else
                Button33.ForeColor = Color.Cyan
                Button33.BackgroundImage = IMGboton(0)
                wc.DownloadString(IDEWEB + FUN1 + TextBox22.Text + FUN2_B)
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click
        'ENVIO MONITOR
        Try
            If Button35.ForeColor = Color.Cyan Then
                Button35.BackgroundImage = IMGboton(1)
                Button35.ForeColor = Color.White
                wc.DownloadString(IDEWEB + FUN1 + TextBox24.Text + FUN2_A)
            Else
                Button35.ForeColor = Color.Cyan
                Button35.BackgroundImage = IMGboton(0)
                wc.DownloadString(IDEWEB + FUN1 + TextBox24.Text + FUN2_A)
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button36_Click(sender As Object, e As EventArgs) Handles Button36.Click
        'ENVIO ZOOM
        Try
            If Button36.ForeColor = Color.Cyan Then
                Button36.BackgroundImage = IMGboton(1)
                Button36.ForeColor = Color.White
                wc.DownloadString(IDEWEB + FUN1 + TextBox24.Text + FUN2_B)
            Else
                Button36.ForeColor = Color.Cyan
                Button36.BackgroundImage = IMGboton(0)
                wc.DownloadString(IDEWEB + FUN1 + TextBox24.Text + FUN2_B)
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button38_Click(sender As Object, e As EventArgs) Handles Button38.Click
        'ENVIO MONTIOR

        Try
            If Button38.ForeColor = Color.Cyan Then
                Button38.BackgroundImage = IMGboton(1)
                Button38.ForeColor = Color.White
                wc.DownloadString(IDEWEB + FUN1 + TextBox26.Text + FUN2_A)
            Else
                Button38.ForeColor = Color.Cyan
                Button38.BackgroundImage = IMGboton(0)
                wc.DownloadString(IDEWEB + FUN1 + TextBox26.Text + FUN2_A)
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button39_Click(sender As Object, e As EventArgs) Handles Button39.Click
        'ENVIO ZOOM
        Try
            If Button39.ForeColor = Color.Cyan Then
                Button39.BackgroundImage = IMGboton(1)
                Button39.ForeColor = Color.White
                wc.DownloadString(IDEWEB + FUN1 + TextBox26.Text + FUN2_B)
            Else
                Button39.ForeColor = Color.Cyan
                Button39.BackgroundImage = IMGboton(0)
                wc.DownloadString(IDEWEB + FUN1 + TextBox26.Text + FUN2_B)
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button41_Click(sender As Object, e As EventArgs) Handles Button41.Click
        'ENVIO MONITOR

        Try
            If Button41.ForeColor = Color.Cyan Then
                Button41.BackgroundImage = IMGboton(1)
                Button41.ForeColor = Color.White
                wc.DownloadString(IDEWEB + FUN1 + TextBox28.Text + FUN2_A)
            Else
                Button41.ForeColor = Color.Cyan
                Button41.BackgroundImage = IMGboton(0)
                wc.DownloadString(IDEWEB + FUN1 + TextBox28.Text + FUN2_A)
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button40_Click(sender As Object, e As EventArgs) Handles Button40.Click
        'ENVIO ZOOM
        Try
            If Button40.ForeColor = Color.Cyan Then
                Button40.BackgroundImage = IMGboton(1)
                Button40.ForeColor = Color.White
                wc.DownloadString(IDEWEB + FUN1 + TextBox28.Text + FUN2_B)
            Else
                Button40.ForeColor = Color.Cyan
                Button40.BackgroundImage = IMGboton(0)
                wc.DownloadString(IDEWEB + FUN1 + TextBox28.Text + FUN2_B)
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button44_Click(sender As Object, e As EventArgs) Handles Button44.Click
        'ENVIO MONITOR
        Try
            If Button44.ForeColor = Color.Cyan Then
                Button44.BackgroundImage = IMGboton(1)
                Button44.ForeColor = Color.White
                wc.DownloadString(IDEWEB + FUN1 + TextBox30.Text + FUN2_A)
            Else
                Button44.ForeColor = Color.Cyan
                Button44.BackgroundImage = IMGboton(0)
                wc.DownloadString(IDEWEB + FUN1 + TextBox30.Text + FUN2_A)
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button45_Click(sender As Object, e As EventArgs) Handles Button45.Click
        'ENVIO ZOOM
        Try
            If Button45.ForeColor = Color.Cyan Then
                Button45.BackgroundImage = IMGboton(1)
                Button45.ForeColor = Color.White
                wc.DownloadString(IDEWEB + FUN1 + TextBox30.Text + FUN2_B)
            Else
                Button45.ForeColor = Color.Cyan
                Button45.BackgroundImage = IMGboton(0)
                wc.DownloadString(IDEWEB + FUN1 + TextBox30.Text + FUN2_B)
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button47_Click(sender As Object, e As EventArgs) Handles Button47.Click
        'ENVIO MONITOR

        Try
            If Button47.ForeColor = Color.Cyan Then
                Button47.BackgroundImage = IMGboton(1)
                Button47.ForeColor = Color.White
                wc.DownloadString(IDEWEB + FUN1 + TextBox32.Text + FUN2_A)
            Else
                Button47.ForeColor = Color.Cyan
                Button47.BackgroundImage = IMGboton(0)
                wc.DownloadString(IDEWEB + FUN1 + TextBox32.Text + FUN2_A)
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button48_Click(sender As Object, e As EventArgs) Handles Button48.Click
        'ENVIO ZOOM
        Try
            If Button48.ForeColor = Color.Cyan Then
                Button48.BackgroundImage = IMGboton(1)
                Button48.ForeColor = Color.White
                wc.DownloadString(IDEWEB + FUN1 + TextBox32.Text + FUN2_B)
            Else
                Button48.ForeColor = Color.Cyan
                Button48.BackgroundImage = IMGboton(0)
                wc.DownloadString(IDEWEB + FUN1 + TextBox32.Text + FUN2_B)
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button50_Click(sender As Object, e As EventArgs) Handles Button50.Click
        'ENVIO MONITOR
        Try
            If Button50.ForeColor = Color.Cyan Then
                Button50.BackgroundImage = IMGboton(1)
                Button50.ForeColor = Color.White
                wc.DownloadString(IDEWEB + FUN1 + TextBox34.Text + FUN2_A)
            Else
                Button50.ForeColor = Color.Cyan
                Button50.BackgroundImage = IMGboton(0)
                wc.DownloadString(IDEWEB + FUN1 + TextBox34.Text + FUN2_A)
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button51_Click(sender As Object, e As EventArgs) Handles Button51.Click
        'ENVIO ZOOM
        Try
            If Button51.ForeColor = Color.Cyan Then
                Button51.BackgroundImage = IMGboton(1)
                Button51.ForeColor = Color.White
                wc.DownloadString(IDEWEB + FUN1 + TextBox34.Text + FUN2_B)
            Else
                Button51.ForeColor = Color.Cyan
                Button51.BackgroundImage = IMGboton(0)
                wc.DownloadString(IDEWEB + FUN1 + TextBox34.Text + FUN2_B)
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button52_Click(sender As Object, e As EventArgs) Handles Button52.Click
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
TextBox12.Text & vbCrLf &
TextBox13.Text & vbCrLf &
TextBox14.Text & vbCrLf &
TextBox15.Text & vbCrLf &
TextBox16.Text & vbCrLf &
TextBox17.Text & vbCrLf &
TextBox18.Text & vbCrLf &
TextBox19.Text & vbCrLf &
TextBox20.Text & vbCrLf &
TextBox21.Text & vbCrLf &
TextBox22.Text & vbCrLf &
TextBox23.Text & vbCrLf &
TextBox24.Text & vbCrLf &
TextBox25.Text & vbCrLf &
TextBox26.Text & vbCrLf &
TextBox27.Text & vbCrLf &
TextBox28.Text & vbCrLf &
TextBox29.Text & vbCrLf &
TextBox30.Text & vbCrLf &
TextBox31.Text & vbCrLf &
TextBox33.Text & vbCrLf &
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
Label11.Text & vbCrLf &
Label12.Text & vbCrLf &
Label13.Text & vbCrLf &
Label14.Text & vbCrLf &
Label15.Text & vbCrLf &
Label16.Text & vbCrLf &
Label17.Text & vbCrLf &
Label18.Text & vbCrLf &
Label19.Text & vbCrLf &
Label20.Text & vbCrLf &
Label21.Text & vbCrLf &
Label22.Text & vbCrLf &
Label23.Text & vbCrLf &
Label24.Text & vbCrLf &
Label25.Text & vbCrLf &
Label26.Text & vbCrLf &
Label27.Text & vbCrLf &
Label28.Text & vbCrLf &
Label29.Text & vbCrLf &
Label30.Text & vbCrLf &
Label31.Text & vbCrLf &
Label32.Text & vbCrLf &
Label33.Text & vbCrLf &
Label34.Text & vbCrLf &
Label35.Text & vbCrLf &
Label36.Text & vbCrLf &
Label37.Text & vbCrLf &
Label38.Text & vbCrLf &
Label39.Text & vbCrLf &
Label40.Text & vbCrLf &
Label41.Text & vbCrLf &
Label42.Text & vbCrLf &
Label43.Text & vbCrLf &
Label44.Text & vbCrLf &
Label45.Text & vbCrLf &
Label46.Text & vbCrLf &
Label47.Text & vbCrLf &
Label48.Text & vbCrLf &
Label49.Text & vbCrLf &
Label50.Text & vbCrLf &
Label51.Text & vbCrLf & vbCrLf, False)
    End Sub

    Private Sub Button53_Click(sender As Object, e As EventArgs) Handles Button53.Click
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
            TextBox12.Text = File.ReadLines(resultadoOFD)(11)
            TextBox13.Text = File.ReadLines(resultadoOFD)(12)
            TextBox14.Text = File.ReadLines(resultadoOFD)(13)
            TextBox15.Text = File.ReadLines(resultadoOFD)(14)
            TextBox16.Text = File.ReadLines(resultadoOFD)(15)
            TextBox17.Text = File.ReadLines(resultadoOFD)(16)
            TextBox18.Text = File.ReadLines(resultadoOFD)(17)
            TextBox19.Text = File.ReadLines(resultadoOFD)(18)
            TextBox20.Text = File.ReadLines(resultadoOFD)(19)
            TextBox21.Text = File.ReadLines(resultadoOFD)(20)
            TextBox22.Text = File.ReadLines(resultadoOFD)(21)
            TextBox23.Text = File.ReadLines(resultadoOFD)(22)
            TextBox24.Text = File.ReadLines(resultadoOFD)(23)
            TextBox25.Text = File.ReadLines(resultadoOFD)(24)
            TextBox26.Text = File.ReadLines(resultadoOFD)(25)
            TextBox27.Text = File.ReadLines(resultadoOFD)(26)
            TextBox28.Text = File.ReadLines(resultadoOFD)(27)
            TextBox29.Text = File.ReadLines(resultadoOFD)(27)
            TextBox30.Text = File.ReadLines(resultadoOFD)(29)
            TextBox31.Text = File.ReadLines(resultadoOFD)(30)
            TextBox32.Text = File.ReadLines(resultadoOFD)(31)
            TextBox33.Text = File.ReadLines(resultadoOFD)(32)
            TextBox34.Text = File.ReadLines(resultadoOFD)(33)
            Label1.Text = File.ReadLines(resultadoOFD)(34)
            Label2.Text = File.ReadLines(resultadoOFD)(35)
            Label3.Text = File.ReadLines(resultadoOFD)(36)
            Label4.Text = File.ReadLines(resultadoOFD)(37)
            Label5.Text = File.ReadLines(resultadoOFD)(38)
            Label6.Text = File.ReadLines(resultadoOFD)(39)
            Label7.Text = File.ReadLines(resultadoOFD)(40)
            Label8.Text = File.ReadLines(resultadoOFD)(41)
            Label9.Text = File.ReadLines(resultadoOFD)(42)
            Label10.Text = File.ReadLines(resultadoOFD)(43)
            Label11.Text = File.ReadLines(resultadoOFD)(44)
            Label12.Text = File.ReadLines(resultadoOFD)(45)
            Label13.Text = File.ReadLines(resultadoOFD)(46)
            Label14.Text = File.ReadLines(resultadoOFD)(47)
            Label15.Text = File.ReadLines(resultadoOFD)(48)
            Label16.Text = File.ReadLines(resultadoOFD)(49)
            Label17.Text = File.ReadLines(resultadoOFD)(50)
            Label18.Text = File.ReadLines(resultadoOFD)(51)
            Label19.Text = File.ReadLines(resultadoOFD)(52)
            Label20.Text = File.ReadLines(resultadoOFD)(53)
            Label21.Text = File.ReadLines(resultadoOFD)(54)
            Label22.Text = File.ReadLines(resultadoOFD)(55)
            Label23.Text = File.ReadLines(resultadoOFD)(56)
            Label24.Text = File.ReadLines(resultadoOFD)(57)
            Label25.Text = File.ReadLines(resultadoOFD)(58)
            Label26.Text = File.ReadLines(resultadoOFD)(59)
            Label27.Text = File.ReadLines(resultadoOFD)(60)
            Label28.Text = File.ReadLines(resultadoOFD)(61)
            Label29.Text = File.ReadLines(resultadoOFD)(62)
            Label30.Text = File.ReadLines(resultadoOFD)(63)
            Label31.Text = File.ReadLines(resultadoOFD)(64)
            Label32.Text = File.ReadLines(resultadoOFD)(65)
            Label33.Text = File.ReadLines(resultadoOFD)(66)
            Label34.Text = File.ReadLines(resultadoOFD)(67)
            Label35.Text = File.ReadLines(resultadoOFD)(68)
            Label36.Text = File.ReadLines(resultadoOFD)(69)
            Label37.Text = File.ReadLines(resultadoOFD)(70)
            Label38.Text = File.ReadLines(resultadoOFD)(71)
            Label39.Text = File.ReadLines(resultadoOFD)(72)
            Label40.Text = File.ReadLines(resultadoOFD)(73)
            Label41.Text = File.ReadLines(resultadoOFD)(74)
            Label42.Text = File.ReadLines(resultadoOFD)(75)
            Label43.Text = File.ReadLines(resultadoOFD)(76)
            Label44.Text = File.ReadLines(resultadoOFD)(77)
            Label45.Text = File.ReadLines(resultadoOFD)(78)
            Label46.Text = File.ReadLines(resultadoOFD)(79)
            Label47.Text = File.ReadLines(resultadoOFD)(80)
            Label48.Text = File.ReadLines(resultadoOFD)(81)
            Label49.Text = File.ReadLines(resultadoOFD)(82)
            Label50.Text = File.ReadLines(resultadoOFD)(83)
            Label51.Text = File.ReadLines(resultadoOFD)(84)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button54_Click(sender As Object, e As EventArgs) Handles Button54.Click
        Me.Hide()
        Form3.SonidoEnvioToolStripMenuItem.Checked = True
    End Sub
    Private Sub TextBox35_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox35.KeyPress
        'MessageBox.Show(e.KeyChar)
        'Label1.Text = e.KeyChar
    End Sub

    Private Sub TextBox35_TextChanged(sender As Object, e As EventArgs) Handles TextBox35.TextChanged
        Call TECLAS()
        TextBox35.Text = ""
    End Sub
    Private Sub TECLAS()
        If TextBox35.Text = Label1.Text Then
            Call Button1.PerformClick()
        End If

        If TextBox35.Text = Label2.Text Then
            Call Button2.PerformClick()
        End If

        If TextBox35.Text = Label3.Text Then
            Call Button3.PerformClick()
        End If

        If TextBox35.Text = Label4.Text Then
            Call Button4.PerformClick()
        End If

        If TextBox35.Text = Label5.Text Then
            Call Button5.PerformClick()
        End If

        If TextBox35.Text = Label6.Text Then
            Call Button6.PerformClick()
        End If

        If TextBox35.Text = Label7.Text Then
            Call Button7.PerformClick()
        End If

        If TextBox35.Text = Label8.Text Then
            Call Button8.PerformClick()
        End If

        If TextBox35.Text = Label9.Text Then
            Call Button9.PerformClick()
        End If

        If TextBox35.Text = Label10.Text Then
            Call Button10.PerformClick()
        End If

        If TextBox35.Text = Label11.Text Then
            Call Button11.PerformClick()
        End If

        If TextBox35.Text = Label12.Text Then
            Call Button12.PerformClick()
        End If

        If TextBox35.Text = Label13.Text Then
            Call Button13.PerformClick()
        End If

        If TextBox35.Text = Label14.Text Then
            Call Button14.PerformClick()
        End If

        If TextBox35.Text = Label15.Text Then
            Call Button15.PerformClick()
        End If

        If TextBox35.Text = Label16.Text Then
            Call Button16.PerformClick()
        End If

        If TextBox35.Text = Label17.Text Then
            Call Button17.PerformClick()
        End If

        If TextBox35.Text = Label18.Text Then
            Call Button18.PerformClick()
        End If

        If TextBox35.Text = Label19.Text Then
            Call Button19.PerformClick()
        End If

        If TextBox35.Text = Label20.Text Then
            Call Button20.PerformClick()
        End If

        If TextBox35.Text = Label21.Text Then
            Call Button21.PerformClick()
        End If

        If TextBox35.Text = Label22.Text Then
            Call Button22.PerformClick()
        End If

        If TextBox35.Text = Label23.Text Then
            Call Button23.PerformClick()
        End If

        If TextBox35.Text = Label24.Text Then
            Call Button24.PerformClick()
        End If

        If TextBox35.Text = Label25.Text Then
            Call Button25.PerformClick()
        End If

        If TextBox35.Text = Label26.Text Then
            Call Button26.PerformClick()
        End If

        If TextBox35.Text = Label27.Text Then
            Call Button27.PerformClick()
        End If

        If TextBox35.Text = Label28.Text Then
            Call Button28.PerformClick()
        End If

        If TextBox35.Text = Label29.Text Then
            Call Button29.PerformClick()
        End If

        If TextBox35.Text = Label30.Text Then
            Call Button30.PerformClick()
        End If

        If TextBox35.Text = Label31.Text Then
            Call Button31.PerformClick()
        End If

        If TextBox35.Text = Label32.Text Then
            Call Button32.PerformClick()
        End If

        If TextBox35.Text = Label33.Text Then
            Call Button33.PerformClick()
        End If

        If TextBox35.Text = Label34.Text Then
            Call Button34.PerformClick()
        End If

        If TextBox35.Text = Label35.Text Then
            Call Button35.PerformClick()
        End If

        If TextBox35.Text = Label36.Text Then
            Call Button36.PerformClick()
        End If

        If TextBox35.Text = Label37.Text Then
            Call Button37.PerformClick()
        End If

        If TextBox35.Text = Label38.Text Then
            Call Button38.PerformClick()
        End If

        If TextBox35.Text = Label39.Text Then
            Call Button39.PerformClick()
        End If

        If TextBox35.Text = Label40.Text Then
            Call Button40.PerformClick()
        End If

        If TextBox35.Text = Label41.Text Then
            Call Button41.PerformClick()
        End If

        If TextBox35.Text = Label42.Text Then
            Call Button42.PerformClick()
        End If

        If TextBox35.Text = Label43.Text Then
            Call Button43.PerformClick()
        End If

        If TextBox35.Text = Label44.Text Then
            Call Button44.PerformClick()
        End If

        If TextBox35.Text = Label45.Text Then
            Call Button45.PerformClick()
        End If

        If TextBox35.Text = Label46.Text Then
            Call Button46.PerformClick()
        End If

        If TextBox35.Text = Label47.Text Then
            Call Button47.PerformClick()
        End If

        If TextBox35.Text = Label48.Text Then
            Call Button48.PerformClick()
        End If

        If TextBox35.Text = Label49.Text Then
            Call Button49.PerformClick()
        End If

        If TextBox35.Text = Label50.Text Then
            Call Button50.PerformClick()
        End If

        If TextBox35.Text = Label51.Text Then
            Call Button51.PerformClick()
        End If
    End Sub

    Private Sub ASIGNARTECLASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ASIGNARTECLASToolStripMenuItem.Click
        Form12.ShowDialog()
    End Sub

    Private Sub Button1_MouseDown(sender As Object, e As MouseEventArgs) Handles Button1.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "S_BTN01"
        End If
    End Sub

    Private Sub Button2_MouseDown(sender As Object, e As MouseEventArgs) Handles Button2.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "S_BTN02"
        End If
    End Sub

    Private Sub Button3_MouseDown(sender As Object, e As MouseEventArgs) Handles Button3.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "S_BTN03"
        End If
    End Sub

    Private Sub Button4_MouseDown(sender As Object, e As MouseEventArgs) Handles Button4.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "S_BTN04"
        End If
    End Sub

    Private Sub Button5_MouseDown(sender As Object, e As MouseEventArgs) Handles Button5.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "S_BTN05"
        End If
    End Sub

    Private Sub Button6_MouseDown(sender As Object, e As MouseEventArgs) Handles Button6.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "S_BTN06"
        End If
    End Sub

    Private Sub Button7_MouseDown(sender As Object, e As MouseEventArgs) Handles Button7.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "S_BTN07"
        End If
    End Sub

    Private Sub Button8_MouseDown(sender As Object, e As MouseEventArgs) Handles Button8.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "S_BTN08"
        End If
    End Sub

    Private Sub Button9_MouseDown(sender As Object, e As MouseEventArgs) Handles Button9.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "S_BTN09"
        End If
    End Sub

    Private Sub Button10_MouseDown(sender As Object, e As MouseEventArgs) Handles Button10.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "S_BTN10"
        End If
    End Sub

    Private Sub Button11_MouseDown(sender As Object, e As MouseEventArgs) Handles Button11.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "S_BTN11"
        End If
    End Sub

    Private Sub Button12_MouseDown(sender As Object, e As MouseEventArgs) Handles Button12.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "S_BTN12"
        End If
    End Sub

    Private Sub Button13_MouseDown(sender As Object, e As MouseEventArgs) Handles Button13.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "S_BTN13"
        End If
    End Sub

    Private Sub Button14_MouseDown(sender As Object, e As MouseEventArgs) Handles Button14.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "S_BTN14"
        End If
    End Sub

    Private Sub Button15_MouseDown(sender As Object, e As MouseEventArgs) Handles Button15.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "S_BTN15"
        End If
    End Sub

    Private Sub Button16_MouseDown(sender As Object, e As MouseEventArgs) Handles Button16.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "S_BTN16"
        End If
    End Sub

    Private Sub Button17_MouseDown(sender As Object, e As MouseEventArgs) Handles Button17.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "S_BTN17"
        End If
    End Sub

    Private Sub Button18_MouseDown(sender As Object, e As MouseEventArgs) Handles Button18.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "S_BTN18"
        End If
    End Sub

    Private Sub Button19_MouseDown(sender As Object, e As MouseEventArgs) Handles Button19.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "S_BTN19"
        End If
    End Sub

    Private Sub Button20_MouseDown(sender As Object, e As MouseEventArgs) Handles Button20.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "S_BTN20"
        End If
    End Sub

    Private Sub Button21_MouseDown(sender As Object, e As MouseEventArgs) Handles Button21.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "S_BTN21"
        End If
    End Sub

    Private Sub Button22_MouseDown(sender As Object, e As MouseEventArgs) Handles Button22.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "S_BTN22"
        End If
    End Sub

    Private Sub Button23_MouseDown(sender As Object, e As MouseEventArgs) Handles Button23.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "S_BTN23"
        End If
    End Sub

    Private Sub Button24_MouseDown(sender As Object, e As MouseEventArgs) Handles Button24.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "S_BTN24"
        End If
    End Sub

    Private Sub Button25_MouseDown(sender As Object, e As MouseEventArgs) Handles Button25.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "S_BTN25"
        End If
    End Sub

    Private Sub Button26_MouseDown(sender As Object, e As MouseEventArgs) Handles Button26.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "S_BTN26"
        End If
    End Sub

    Private Sub Button27_MouseDown(sender As Object, e As MouseEventArgs) Handles Button27.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "S_BTN27"
        End If
    End Sub

    Private Sub Button28_MouseDown(sender As Object, e As MouseEventArgs) Handles Button28.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "S_BTN28"
        End If
    End Sub

    Private Sub Button29_MouseDown(sender As Object, e As MouseEventArgs) Handles Button29.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "S_BTN29"
        End If
    End Sub

    Private Sub Button30_MouseDown(sender As Object, e As MouseEventArgs) Handles Button30.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "S_BTN30"
        End If
    End Sub

    Private Sub Button31_MouseDown(sender As Object, e As MouseEventArgs) Handles Button31.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "S_BTN31"
        End If
    End Sub

    Private Sub Button32_MouseDown(sender As Object, e As MouseEventArgs) Handles Button32.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "S_BTN32"
        End If
    End Sub

    Private Sub Button33_MouseDown(sender As Object, e As MouseEventArgs) Handles Button33.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "S_BTN33"
        End If
    End Sub

    Private Sub Button34_MouseDown(sender As Object, e As MouseEventArgs) Handles Button34.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "S_BTN34"
        End If
    End Sub

    Private Sub Button35_MouseDown(sender As Object, e As MouseEventArgs) Handles Button35.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "S_BTN35"
        End If
    End Sub

    Private Sub Button36_MouseDown(sender As Object, e As MouseEventArgs) Handles Button36.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "S_BTN36"
        End If
    End Sub

    Private Sub Button37_MouseDown(sender As Object, e As MouseEventArgs) Handles Button37.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "S_BTN37"
        End If
    End Sub

    Private Sub Button38_MouseDown(sender As Object, e As MouseEventArgs) Handles Button38.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "S_BTN38"
        End If
    End Sub

    Private Sub Button39_MouseDown(sender As Object, e As MouseEventArgs) Handles Button39.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "S_BTN39"
        End If
    End Sub

    Private Sub Button42_MouseDown(sender As Object, e As MouseEventArgs) Handles Button42.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "S_BTN42"
        End If
    End Sub

    Private Sub Button41_MouseDown(sender As Object, e As MouseEventArgs) Handles Button41.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "S_BTN41"
        End If
    End Sub

    Private Sub Button40_MouseDown(sender As Object, e As MouseEventArgs) Handles Button40.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "S_BTN40"
        End If
    End Sub

    Private Sub Button43_MouseDown(sender As Object, e As MouseEventArgs) Handles Button43.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "S_BTN43"
        End If
    End Sub

    Private Sub Button44_MouseDown(sender As Object, e As MouseEventArgs) Handles Button44.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "S_BTN44"
        End If
    End Sub

    Private Sub Button45_MouseDown(sender As Object, e As MouseEventArgs) Handles Button45.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "S_BTN45"
        End If
    End Sub

    Private Sub Button46_MouseDown(sender As Object, e As MouseEventArgs) Handles Button46.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "S_BTN46"
        End If
    End Sub

    Private Sub Button47_MouseDown(sender As Object, e As MouseEventArgs) Handles Button47.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "S_BTN47"
        End If
    End Sub

    Private Sub Button48_MouseDown(sender As Object, e As MouseEventArgs) Handles Button48.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "S_BTN48"
        End If
    End Sub

    Private Sub Button49_MouseDown(sender As Object, e As MouseEventArgs) Handles Button49.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "S_BTN49"
        End If
    End Sub

    Private Sub Button50_MouseDown(sender As Object, e As MouseEventArgs) Handles Button50.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "S_BTN50"
        End If
    End Sub

    Private Sub Button51_MouseDown(sender As Object, e As MouseEventArgs) Handles Button51.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            BOK = "S_BTN51"
        End If
    End Sub

    Private Sub Button55_Click(sender As Object, e As EventArgs) Handles Button55.Click
        Form3.SonidoEnvioToolStripMenuItem.Checked = False
        Me.Close()
    End Sub
End Class