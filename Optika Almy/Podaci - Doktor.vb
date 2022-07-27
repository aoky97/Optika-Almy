Imports System.Data.OleDb

Public Class UrediPodatkeoDoktoru
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection
    Private Sub UrediPodatkeoDoktoru_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        con.Close()
        DoktorID()

    End Sub
    Public Sub DoktorID()
        ComboBox1.Items.Clear()
        ds.Clear()
        con.Close()
        con.Open()
        str = "SELECT * From Doktor"
        cmd = New OleDbCommand(str, con)
        da.SelectCommand = cmd
        da.Fill(ds, "Doktor")
        Dim a As Integer = ds.Tables("Doktor").Rows.Count - 1
        For i As Integer = 0 To a
            ComboBox1.Items.Add(ds.Tables("Doktor").Rows(i)(0).ToString())
        Next
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        con.Close()
        con.Open()
        cmd = New OleDbCommand(str, con)
        If IsNumeric(ComboBox1.Text) Then
            cmd.CommandText = "SELECT * from Doktor where DoktorID=@did"
            cmd.Prepare()
            cmd.Parameters.AddWithValue("@did", ComboBox1.Text)
            Dim dr As OleDbDataReader = cmd.ExecuteReader()
            Try
                If dr.Read() Then
                    TextBox1.Text = dr.GetValue(1)
                    TextBox2.Text = dr.GetValue(2)
                    TextBox3.Text = dr.GetValue(3)
                    TextBox4.Text = dr.GetValue(4)
                    TextBox5.Text = dr.GetValue(5)
                    dr.Close()

                End If
            Catch ex As Exception
                MsgBox(" ", ex.Message)
                dr.Close()
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Private Sub Uredi_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or ComboBox1.Text = "" Then
            MsgBox("Molimo, unesite podatke.")
            Exit Sub

        End If

        provider = "Provider=Microsoft.ACE.OLEDB.12.0;"
        dataFile = "Data Source=C:\Users\almao\Documents\OptikaAlmy.accdb"
        connString = provider + dataFile
        myConnection.ConnectionString = connString
        myConnection.Open()
        Dim str As String
        str = "Update [Doktor]set [ImeIPrezime]='" & TextBox1.Text & "', [Titula]='" & TextBox2.Text & "',[MjestoRada]='" & TextBox3.Text & "',[Telefon/Fax]='" & TextBox4.Text & "',[Email]='" & TextBox5.Text & "' where [DoktorID]=" & ComboBox1.Text & ""
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myConnection.Close()

            MsgBox("Podaci uspješno ažurirani.", MsgBoxStyle.OkOnly, "Optika")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Izbrisi_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or ComboBox1.Text = "" Then
            MsgBox("Molimo, unesite podatke.")
            Exit Sub
        End If

        Dim msg As Integer = MsgBox("Da li želite izbrisati podatke o doktoru? (Podaci će biti trajno izbrisani.)", MsgBoxStyle.YesNoCancel, "Optika")

        If msg = DialogResult.Yes Then
            Try
                con.Open()
                str = "DELETE from Doktor where DoktorID=@ID"
                cmd = New OleDbCommand(str, con)
                cmd.Parameters.AddWithValue("@ID", ComboBox1.Text)
                cmd.ExecuteNonQuery()
                MsgBox("Podaci su uspješno izbrisani.", MsgBoxStyle.OkOnly, "Optika")
                clr()

                Dim ctr As Integer
                'cn Open
                ComboBox1.Items.Clear()
                ds.Clear()
                str = "SELECT * from Doktor"
                cmd = New OleDbCommand(str, con)
                da.SelectCommand = cmd
                da.Fill(ds, "Doktor")
                ctr = ds.Tables("Doktor").Rows.Count - 1
                For i = 0 To ctr
                    ComboBox1.Items.Add(ds.Tables("Doktor").Rows(i)(0).ToString)
                Next

            Catch ex As Exception
                MsgBox("Podaci nisu izbrisani.")
            Finally
                con.Close()

            End Try
        End If

    End Sub

    Private Sub Otkazi_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub clr()
        TextBox1.Text = ""
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        ComboBox1.Items.Clear()


    End Sub
End Class