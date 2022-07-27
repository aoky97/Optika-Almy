Imports System.Data
Imports System.Data.OleDb

Public Class Kupac
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then TextBox1.Focus() : Exit Sub
        If TextBox2.Text = "" Then TextBox2.Focus() : Exit Sub
        If TextBox3.Text = "" Then TextBox3.Focus() : Exit Sub
        If TextBox4.Text = "" Then TextBox4.Focus() : Exit Sub

        Try
            con.Open()
            cmd = New OleDbCommand("Insert into Kupac([ImeIPrezime],[AdresaStanovanja],[Telefon/Fax],[Stanje-Oči]) values ('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "')", con)
            Dim i As Integer = cmd.ExecuteNonQuery()
            If (i > 0) Then
                con.Close()
                MsgBox("Evidencija uspješno spremljena.", MsgBoxStyle.Information, "Optika")
                SearchID()

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

    Public Sub SearchID()
        con.Close()
        con.Open()
        cmd = New OleDbCommand("Select MAX(KupacID) from Kupac", con)
        Dim dr As OleDbDataReader
        Try
            dr = cmd.ExecuteReader()
            While dr.Read
                Dim KupID As String = dr.GetValue(0).ToString()
                MessageBox.Show("Vaša registracija je uspješno završena." & vbCrLf & "Vaš ID = " & KupID & "", "Optika")

            End While
        Catch ex As Exception
            MsgBox("Greška", ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Kupac_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class