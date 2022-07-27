Imports System.Data
Imports System.Data.OleDb


Public Class Proizvod
    Dim Lastno As Integer
    Private Sub Dodaj_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        con.Close()
        If ComboBox1.Text = "" Then ComboBox1.Focus() : Exit Sub
        If TextBox2.Text = "" Then TextBox2.Focus() : Exit Sub
        If TextBox3.Text = "" Then TextBox3.Focus() : Exit Sub
        If TextBox4.Text = "" Then TextBox4.Focus() : Exit Sub
        If TextBox5.Text = "" Then TextBox5.Focus() : Exit Sub
        If TextBox6.Text = "" Then TextBox6.Focus() : Exit Sub

        Try
            con.Open()
            cmd = New OleDbCommand("Insert into Proizvod([ProizvodID],[NazivProizvoda],[TipProizvoda],[TipStakla],[TipOkvira],[Cijena]) values ('" & ComboBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "')", con)
            Dim i As Integer = cmd.ExecuteNonQuery()
            If (i > 0) Then
                con.Close()
                MsgBox("Evidencija uspješno spremljena.", MsgBoxStyle.Information, "Optika")
                Dim result As Integer = MessageBox.Show("Novi proizvod je uspješno spremljen. Da li želite dodati novi?", "Optika", MessageBoxButtons.YesNo)

                If result = DialogResult.Yes Then
                    clr()
                    str = "SELECT * From Proizvod"
                    cmd = New OleDbCommand(str, con)
                    da.SelectCommand = cmd
                    da.Fill(ds, "Proizvod")
                    Lastno = ds.Tables("Proizvod").Rows.Count + 1
                    If Lastno >= 0 Then
                        ComboBox1.Text = "PID" & Lastno
                    Else
                        ComboBox1.Text = "PID" & 0
                        TextBox2.Focus()
                    End If

                End If

            Else
                MsgBox("Evidencija nije spremljena.", MsgBoxStyle.Critical, MsgBoxStyle.OkOnly)
            End If
        Catch ex As Exception
            MsgBox("Greška", ex.Message)
        Finally
            con.Close()
        End Try
        con.Close()

    End Sub

    Private Sub clr()
        ds.Clear()
        TextBox2.Text = ""
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()


    End Sub
    Private Sub Proizvod_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        con.Open()
        con.Close()
        str = "SELECT * From Proizvod"
        cmd = New OleDbCommand(str, con)
        da.SelectCommand = cmd
        da.Fill(ds, "Proizvod")

        'for ProizvodID Number

        Lastno = ds.Tables("Proizvod").Rows.Count + 1

        If Lastno >= 0 Then
            ComboBox1.Text = "PID" & Lastno
        Else
            ComboBox1.Text = "PID" & 0
        End If
    End Sub

    Private Sub Otkazi_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

End Class