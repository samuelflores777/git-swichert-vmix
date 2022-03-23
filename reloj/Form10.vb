Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Imaging
Public Class Form10
    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conectarse()
            cargargrid()
            limpiar()
            Button1.Enabled = False 'guardar
            Button2.Enabled = True 'eliminar
            Button3.Enabled = True 'nuevo
            Button4.Enabled = True 'actualizat
            DataGridView1.Columns.Item(0).Width = 150
            DataGridView1.Columns.Item(1).Width = 200
            DataGridView1.Columns.Item(2).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub cargargrid()
        Dim da As New OleDb.OleDbDataAdapter("SELECT nombre as NOMBRE, cargo as CARGO, cod as NRO from DATOS1", conn)
        Dim ds As New DataSet
        da.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            DataGridView1.DataSource = ds.Tables(0)
        Else
            DataGridView1.DataSource = Nothing
        End If
    End Sub
    Public Sub limpiar()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Button1.Enabled = False 'guardar
            Button2.Enabled = True 'eliminar
            Button3.Enabled = True 'nuevo
            Button4.Enabled = True 'actualizat

            instruccion = New OleDbCommand("INSERT INTO DATOS1(cod, nombre, cargo)" & Chr(13) &
                                           "VALUES (@cod, @nombre, @cargo)", conn)
            instruccion.Parameters.AddWithValue("@cod", TextBox3.Text)
            instruccion.Parameters.AddWithValue("@nombre", TextBox1.Text)
            instruccion.Parameters.AddWithValue("@cargo", TextBox2.Text)
            instruccion.ExecuteNonQuery()
            cargargrid()
            limpiar()
            DataGridView1.Columns.Item(0).Width = 150
            DataGridView1.Columns.Item(1).Width = 200
            DataGridView1.Columns.Item(2).Visible = False
            TextBox1.Focus()
        Catch ex As Exception
            MsgBox("error al guardar", vbCritical, "El registro no se guardo")
        End Try
    End Sub

    Private Sub Form10_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        conn.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim i As Integer = DataGridView1.CurrentRow.Index
        TextBox1.Text = DataGridView1.Item(0, i).Value.ToString()
        TextBox2.Text = DataGridView1.Item(1, i).Value.ToString()
        TextBox3.Text = DataGridView1.Item(2, i).Value.ToString()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox3.Text = "" Then
            MsgBox("NO HAY NADA SELECCIONADO")
            TextBox1.Focus()
        Else
            Dim sql As String
            sql = "DELETE FROM DATOS1 WHERE cod = @id"
            instruccion = New OleDbCommand(sql, conn)
            instruccion.Parameters.Add(New OleDbParameter("@id", TextBox3.Text))
            instruccion.ExecuteNonQuery()
            cargargrid()
            limpiar()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            limpiar()
            Button1.Enabled = True 'guardar
            Button2.Enabled = False 'eliminar
            Button3.Enabled = False 'nuevo
            Button4.Enabled = False 'actualizat

            Dim da As New OleDb.OleDbDataAdapter("select Id, nombre from DATOS1 order by Id desc", conn)
            Dim ds As New DataSet
            da.Fill(ds)
            If ds.Tables(0).Rows.Count > 0 Then
                DataGridView2.DataSource = ds.Tables(0)
            Else
                DataGridView2.DataSource = Nothing
            End If

            Dim suma As Integer
            suma = DataGridView2.Item(0, 0).Value.ToString() + 1
            TextBox3.Text = suma

            TextBox1.Focus()
        Catch ex As Exception
            TextBox3.Text = 1
        End Try





    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Button1.Enabled = False 'guardar
        Button2.Enabled = True 'eliminar
        Button3.Enabled = True 'nuevo
        Button4.Enabled = True 'actualizat
        Dim SQL As String
        SQL = "UPDATE DATOS1 SET cod = '" & TextBox3.Text & "',nombre = '" & TextBox1.Text & "',cargo= '" & TextBox2.Text & "' WHERE cod ='" & TextBox3.Text & "'"
        'SQL = "UPDATE DATOS1 SET nombre =@nombre, cargo=@cargo WHERE Id ='" & TextBox3.Text & "'"
        instruccion = New OleDbCommand(SQL, conn)
        '        instruccion.Parameters.Add(New OleDbParameter("@nombre", TextBox1.Text))
        '        instruccion.Parameters.Add(New OleDbParameter("@cargo", TextBox2.Text))
        instruccion.ExecuteNonQuery()
        cargargrid()
        limpiar()

    End Sub
End Class