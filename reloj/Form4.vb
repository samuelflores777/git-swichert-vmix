Imports System.ComponentModel

Public Class Form4
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Then
            If BOK = "BTN16" Then
                Form3.TextBox49.Text = ""
                Form3.RadioButton1.Checked = True
                BOK = ""
                Me.Close()
            End If
            If BOK = "BTN17" Then
                Form3.TextBox50.Text = ""
                Form3.RadioButton3.Checked = True
                BOK = ""
                Me.Close()
            End If
            If BOK = "BTN18" Then
                Form3.TextBox51.Text = ""
                Form3.RadioButton5.Checked = True
                BOK = ""
                Me.Close()
            End If
            If BOK = "BTN19" Then
                Form3.TextBox52.Text = ""
                Form3.RadioButton7.Checked = True
                BOK = ""
                Me.Close()
            End If
            If BOK = "BTN20" Then
                Form3.TextBox53.Text = ""
                Form3.RadioButton9.Checked = True
                BOK = ""
                Me.Close()
            End If
            If BOK = "BTN21" Then
                Form3.TextBox54.Text = ""
                Form3.RadioButton11.Checked = True
                BOK = ""
                Me.Close()
            End If
            If BOK = "BTN22" Then
                Form3.TextBox55.Text = ""
                Form3.RadioButton13.Checked = True
                BOK = ""
                Me.Close()
            End If
            If BOK = "BTN23" Then
                Form3.TextBox56.Text = ""
                Form3.RadioButton15.Checked = True
                BOK = ""
                Me.Close()
            End If
            If BOK = "BTN24" Then
                Form3.TextBox57.Text = ""
                Form3.RadioButton17.Checked = True
                BOK = ""
                Me.Close()
            End If
            If BOK = "BTN25" Then
                Form3.TextBox58.Text = ""
                Form3.RadioButton19.Checked = True
                BOK = ""
                Me.Close()
            End If
            If BOK = "BTN54" Then
                Form3.TextBox64.Text = ""
                Form3.RadioButton31.Checked = True
                BOK = ""
                Me.Close()
            End If
            If BOK = "BTN55" Then
                Form3.TextBox65.Text = ""
                Form3.RadioButton34.Checked = True
                BOK = ""
                Me.Close()
            End If
            If BOK = "BTN56" Then
                Form3.TextBox66.Text = ""
                Form3.RadioButton37.Checked = True
                BOK = ""
                Me.Close()
            End If
            If BOK = "BTN57" Then
                Form3.TextBox67.Text = ""
                Form3.RadioButton40.Checked = True
                BOK = ""
                Me.Close()
            End If
            If BOK = "BTN58" Then
                Form3.TextBox68.Text = ""
                Form3.RadioButton43.Checked = True
                BOK = ""
                Me.Close()
            End If
        Else
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If BOK = "BTN16" Then
            Form3.TextBox49.Text = TextBox1.Text
            Form3.RadioButton2.Checked = True
            BOK = ""
            Me.Close()
        End If
        If BOK = "BTN17" Then
            Form3.TextBox50.Text = TextBox1.Text
            Form3.RadioButton4.Checked = True
            BOK = ""
            Me.Close()
        End If
        If BOK = "BTN18" Then
            Form3.TextBox51.Text = TextBox1.Text
            Form3.RadioButton6.Checked = True
            BOK = ""
            Me.Close()
        End If
        If BOK = "BTN19" Then
            Form3.TextBox52.Text = TextBox1.Text
            Form3.RadioButton8.Checked = True
            BOK = ""
            Me.Close()
        End If
        If BOK = "BTN20" Then
            Form3.TextBox53.Text = TextBox1.Text
            Form3.RadioButton10.Checked = True
            BOK = ""
            Me.Close()
        End If
        If BOK = "BTN21" Then
            Form3.TextBox54.Text = TextBox1.Text
            Form3.RadioButton12.Checked = True
            BOK = ""
            Me.Close()
        End If
        If BOK = "BTN22" Then
            Form3.TextBox55.Text = TextBox1.Text
            Form3.RadioButton14.Checked = True
            BOK = ""
            Me.Close()
        End If
        If BOK = "BTN23" Then
            Form3.TextBox56.Text = TextBox1.Text
            Form3.RadioButton16.Checked = True
            BOK = ""
            Me.Close()
        End If
        If BOK = "BTN24" Then
            Form3.TextBox57.Text = TextBox1.Text
            Form3.RadioButton18.Checked = True
            BOK = ""
            Me.Close()
        End If
        If BOK = "BTN25" Then
            Form3.TextBox58.Text = TextBox1.Text
            Form3.RadioButton20.Checked = True
            BOK = ""
            Me.Close()
        End If
        If BOK = "BTN31" Then
            Form3.TextBox70.Text = TextBox1.Text
            Form3.RadioButton47.Checked = True
            Form3.GroupBox16.Visible = True
            Form3.GroupBox16.Location = New Point(330, 407)
            BOK = ""
            Me.Close()
        End If
        If BOK = "BTN32" Then
            Form3.TextBox71.Text = TextBox1.Text
            Form3.RadioButton49.Checked = True
            Form3.GroupBox17.Visible = True
            Form3.GroupBox17.Location = New Point(330, 444)
            BOK = ""
            Me.Close()
        End If
        If BOK = "BTN54" Then
            Form3.TextBox64.Text = TextBox1.Text
            Form3.RadioButton32.Checked = True
            BOK = ""
            Me.Close()
        End If
        If BOK = "BTN55" Then
            Form3.TextBox65.Text = TextBox1.Text
            Form3.RadioButton35.Checked = True
            BOK = ""
            Me.Close()
        End If
        If BOK = "BTN56" Then
            Form3.TextBox66.Text = TextBox1.Text
            Form3.RadioButton38.Checked = True
            BOK = ""
            Me.Close()
        End If
        If BOK = "BTN57" Then
            Form3.TextBox67.Text = TextBox1.Text
            Form3.RadioButton41.Checked = True
            BOK = ""
            Me.Close()
        End If
        If BOK = "BTN58" Then
            Form3.TextBox68.Text = TextBox1.Text
            Form3.RadioButton44.Checked = True
            BOK = ""
            Me.Close()
        End If
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If BOK = "BTN16" Then
            TextBox1.Text = Form3.TextBox49.Text
        Else
            'TextBox1.Text = ""
        End If
        If BOK = "BTN17" Then
            TextBox1.Text = Form3.TextBox50.Text
        Else
            'TextBox1.Text = ""
        End If
        If BOK = "BTN18" Then
            TextBox1.Text = Form3.TextBox51.Text
        Else
            'TextBox1.Text = ""
        End If
        If BOK = "BTN19" Then
            TextBox1.Text = Form3.TextBox52.Text
        Else
            'TextBox1.Text = ""
        End If
        If BOK = "BTN20" Then
            TextBox1.Text = Form3.TextBox53.Text
        Else
            'TextBox1.Text = ""
        End If
        If BOK = "BTN21" Then
            TextBox1.Text = Form3.TextBox54.Text
        Else
            'TextBox1.Text = ""
        End If
        If BOK = "BTN22" Then
            TextBox1.Text = Form3.TextBox55.Text
        Else
            'TextBox1.Text = ""
        End If
        If BOK = "BTN23" Then
            TextBox1.Text = Form3.TextBox56.Text
        Else
            'TextBox1.Text = ""
        End If
        If BOK = "BTN24" Then
            TextBox1.Text = Form3.TextBox57.Text
        Else
            'TextBox1.Text = ""
        End If
        If BOK = "BTN25" Then
            TextBox1.Text = Form3.TextBox58.Text
        Else
            'TextBox1.Text = ""
        End If
        If BOK = "BTN31" Then
            TextBox1.Text = Form3.TextBox70.Text
            TextBox1.ForeColor = Color.White
            TextBox1.BackColor = Color.Red
        Else
            'TextBox1.Text = ""
        End If
        If BOK = "BTN32" Then
            TextBox1.Text = Form3.TextBox71.Text
            TextBox1.ForeColor = Color.White
            TextBox1.BackColor = Color.Red
        Else
            'TextBox1.Text = ""
        End If
        If BOK = "BTN54" Then
            TextBox1.Text = Form3.TextBox64.Text
        Else
            'TextBox1.Text = ""
        End If
        If BOK = "BTN55" Then
            TextBox1.Text = Form3.TextBox65.Text
        Else
            'TextBox1.Text = ""
        End If
        If BOK = "BTN56" Then
            TextBox1.Text = Form3.TextBox66.Text
        Else
            'TextBox1.Text = ""
        End If
        If BOK = "BTN57" Then
            TextBox1.Text = Form3.TextBox67.Text
        Else
            'TextBox1.Text = ""
        End If
        If BOK = "BTN58" Then
            TextBox1.Text = Form3.TextBox68.Text
        Else
            'TextBox1.Text = ""
        End If



    End Sub
End Class