Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Imaging
Public Class Form11
    Public wc As New Net.WebClient
    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarcombo()
    End Sub

    Private Sub cargarcombo()
        Dim tabla As New DataTable
        Dim sql As String = "SELECT id, nombre, cargo FROM DATOS1"
        'Dim sql As String = "SELECT id, nombre + '/' + cargo as NOMBRES FROM DATOS1"
        Dim adp As New OleDbDataAdapter(sql, conn)
        adp.Fill(tabla)
        ComboBox1.DataSource = tabla
        ComboBox1.DisplayMember = "nombre"
        ComboBox1.ValueMember = "id"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If BOK = "BTN01" Then
            Dim BTN As String
            BTN = Form3.Label1.Text 'numero pista
            Dim VAL As String = "&Value="
            wc.DownloadString(IDEWEB + T1ID + BTN + VAL + TextBox2.Text)
            wc.DownloadString(IDEWEB + T2ID + BTN + VAL + TextBox3.Text)
            Me.Close()
        End If

        If BOK = "BTN02" Then
            Dim BTN As String
            BTN = Form3.Label2.Text 'numero pista
            Dim VAL As String = "&Value="
            wc.DownloadString(IDEWEB + T1ID + BTN + VAL + TextBox2.Text)
            wc.DownloadString(IDEWEB + T2ID + BTN + VAL + TextBox3.Text)
            Me.Close()
        End If

        If BOK = "BTN03" Then
            Dim BTN As String
            BTN = Form3.Label3.Text 'numero pista
            Dim VAL As String = "&Value="
            wc.DownloadString(IDEWEB + T1ID + BTN + VAL + TextBox2.Text)
            wc.DownloadString(IDEWEB + T2ID + BTN + VAL + TextBox3.Text)
            Me.Close()
        End If

        If BOK = "BTN04" Then
            Dim BTN As String
            BTN = Form3.Label4.Text 'numero pista
            Dim VAL As String = "&Value="
            wc.DownloadString(IDEWEB + T1ID + BTN + VAL + TextBox2.Text)
            wc.DownloadString(IDEWEB + T2ID + BTN + VAL + TextBox3.Text)
            Me.Close()
        End If

        If BOK = "BTN05" Then
            Dim BTN As String
            BTN = Form3.Label5.Text 'numero pista
            Dim VAL As String = "&Value="
            wc.DownloadString(IDEWEB + T1ID + BTN + VAL + TextBox2.Text)
            wc.DownloadString(IDEWEB + T2ID + BTN + VAL + TextBox3.Text)
            Me.Close()
        End If

        If BOK = "BTN06" Then
            Dim BTN As String
            BTN = Form3.Label6.Text 'numero pista
            Dim VAL As String = "&Value="
            wc.DownloadString(IDEWEB + T1ID + BTN + VAL + TextBox2.Text)
            wc.DownloadString(IDEWEB + T2ID + BTN + VAL + TextBox3.Text)
            Me.Close()
        End If

        If BOK = "BTN07" Then
            Dim BTN As String
            BTN = Form3.Label7.Text 'numero pista
            Dim VAL As String = "&Value="
            wc.DownloadString(IDEWEB + T1ID + BTN + VAL + TextBox2.Text)
            wc.DownloadString(IDEWEB + T2ID + BTN + VAL + TextBox3.Text)
            Me.Close()
        End If

        If BOK = "BTN08" Then
            Dim BTN As String
            BTN = Form3.Label8.Text 'numero pista
            Dim VAL As String = "&Value="
            wc.DownloadString(IDEWEB + T1ID + BTN + VAL + TextBox2.Text)
            wc.DownloadString(IDEWEB + T2ID + BTN + VAL + TextBox3.Text)
            Me.Close()
        End If

        If BOK = "BTN09" Then
            Dim BTN As String
            BTN = Form3.Label9.Text 'numero pista
            Dim VAL As String = "&Value="
            wc.DownloadString(IDEWEB + T1ID + BTN + VAL + TextBox2.Text)
            wc.DownloadString(IDEWEB + T2ID + BTN + VAL + TextBox3.Text)
            Me.Close()
        End If

        If BOK = "BTN10" Then
            Dim BTN As String
            BTN = Form3.Label10.Text 'numero pista
            Dim VAL As String = "&Value="
            wc.DownloadString(IDEWEB + T1ID + BTN + VAL + TextBox2.Text)
            wc.DownloadString(IDEWEB + T2ID + BTN + VAL + TextBox3.Text)
            Me.Close()
        End If

        If BOK = "BTN11" Then
            Dim BTN As String
            BTN = Form3.Label11.Text 'numero pista
            Dim VAL As String = "&Value="
            wc.DownloadString(IDEWEB + T1ID + BTN + VAL + TextBox2.Text)
            wc.DownloadString(IDEWEB + T2ID + BTN + VAL + TextBox3.Text)
            Me.Close()
        End If

        If BOK = "BTN12" Then
            Dim BTN As String
            BTN = Form3.Label12.Text 'numero pista
            Dim VAL As String = "&Value="
            wc.DownloadString(IDEWEB + T1ID + BTN + VAL + TextBox2.Text)
            wc.DownloadString(IDEWEB + T2ID + BTN + VAL + TextBox3.Text)
            Me.Close()
        End If

        If BOK = "BTN13" Then
            Dim BTN As String
            BTN = Form3.Label13.Text 'numero pista
            Dim VAL As String = "&Value="
            wc.DownloadString(IDEWEB + T1ID + BTN + VAL + TextBox2.Text)
            wc.DownloadString(IDEWEB + T2ID + BTN + VAL + TextBox3.Text)
            Me.Close()
        End If

        If BOK = "BTN14" Then
            Dim BTN As String
            BTN = Form3.Label14.Text 'numero pista
            Dim VAL As String = "&Value="
            wc.DownloadString(IDEWEB + T1ID + BTN + VAL + TextBox2.Text)
            wc.DownloadString(IDEWEB + T2ID + BTN + VAL + TextBox3.Text)
            Me.Close()
        End If

        If BOK = "BTN15" Then
            Dim BTN As String
            BTN = Form3.Label15.Text 'numero pista
            Dim VAL As String = "&Value="
            wc.DownloadString(IDEWEB + T1ID + BTN + VAL + TextBox2.Text)
            wc.DownloadString(IDEWEB + T2ID + BTN + VAL + TextBox3.Text)
            Me.Close()
        End If

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If Not TypeOf ComboBox1.SelectedValue Is DataRowView Then
            ' Referenciando el objeto DataRowView correspondiente
            ' al elemento seleccionado en el control ComboBox.
            Dim row As DataRowView = DirectCast(ComboBox1.SelectedItem, DataRowView)
            TextBox1.Text = row.Item("id").ToString
            TextBox2.Text = row.Item("nombre").ToString
            TextBox3.Text = row.Item("cargo").ToString
        End If
    End Sub
End Class