Imports System.Data.OleDb

Public Class Doktor

    Private Sub Dodaj_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then TextBox1.Focus() : Exit Sub
        If TextBox2.Text = "" Then TextBox2.Focus() : Exit Sub
        If TextBox3.Text = "" Then TextBox3.Focus() : Exit Sub
        If TextBox4.Text = "" Then TextBox4.Focus() : Exit Sub
        If TextBox5.Text = "" Then TextBox5.Focus() : Exit Sub

        Try
            con.Open()
            cmd = New OleDbCommand("Insert into Doktor([ImeIPrezime],[Titula],[MjestoRada],[Telefon/Fax],[Email]) values ('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "')", con)
            Dim i As Integer = cmd.ExecuteNonQuery()
            If (i > 0) Then
                con.Close()
                MsgBox("Evidencija uspješno spremljena.", MsgBoxStyle.Information, "Optika")
                clr()

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

    Public Sub clr()
        ds.Clear()
        TextBox1.Clear()
        TextBox2.Text = ""
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
    End Sub

    Private Sub Otkazi_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

End Class
