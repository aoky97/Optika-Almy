Imports System.Data.OleDb

Public Class UrediPodatkeoProizvodu
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection

    Private Sub UrediPodatkeoProizvodu_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        getdata()
        con.Close()

    End Sub

    Public Sub getdata()
        con.Close()
        con.Open()
        Using cmd As New OleDbCommand()
            cmd.CommandText = "SELECT * from Proizvod"
            cmd.Connection = con
            Dim dt As New DataTable()
            Using da As New OleDbDataAdapter(cmd)
                da.Fill(dt)
                DataGridView1.DataSource = dt

            End Using

        End Using
    End Sub

    Private Sub Trazi_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        con.Close()
        con.Open()
        Using cmd As New OleDbCommand()
            cmd.CommandText = "SELECT * from Proizvod where ProizvodID LIKE @PID + '%' "
            cmd.Connection = con
            cmd.Parameters.AddWithValue("PID", TextBox1.Text.Trim())

            Dim dt As New DataTable()
            Using da As New OleDbDataAdapter(cmd)
                da.Fill(dt)
                If (dt.Rows.Count > 0) Then
                    DataGridView1.DataSource = dt
                    TextBox2.Text = dt.Rows(0)(0).ToString()
                    TextBox3.Text = dt.Rows(0)(1).ToString()
                    TextBox4.Text = dt.Rows(0)(2).ToString()
                    TextBox5.Text = dt.Rows(0)(3).ToString()
                    TextBox6.Text = dt.Rows(0)(4).ToString()
                    TextBox7.Text = dt.Rows(0)(5).ToString()

                Else
                    MsgBox("Podaci nisu pronađeni.", MsgBoxStyle.OkOnly, "Optika")
                End If
            End Using

        End Using
    End Sub

    Private Sub clr()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()

    End Sub


    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged
        getdata()
        clr()
    End Sub

    Private Sub DataGridView1_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        clr()
    End Sub

    Private Sub Uredi_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Then
            MsgBox("Molimo, unesite podatke.")
            Exit Sub
        End If

        provider = "Provider=Microsoft.ACE.OLEDB.12.0;"
        dataFile = "Data Source=C:\Users\almao\Documents\OptikaAlmy.accdb"
        connString = provider + dataFile
        myConnection.ConnectionString = connString
        myConnection.Open()
        Dim str As String
        str = "Update [Proizvod] set [NazivProizvoda]='" & TextBox3.Text & "',[TipProizvoda]='" & TextBox4.Text & "',[TipStakla]='" & TextBox5.Text & "',[TipOkvira]='" & TextBox6.Text & "',[Cijena]='" & TextBox7.Text & "' where [ProizvodID]=" & TextBox1.Text & ""
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myConnection.Close()

                MsgBox("Podaci uspješno ažurirani.", MsgBoxStyle.OkOnly, "Optika")
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
    End Sub

    Private Sub Izbrisi_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        con.Close()

        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Then
            MsgBox("Molimo, unesite podatke.")
            Exit Sub
        End If

        Dim msg As Integer = MsgBox("Da li želite izbrisati podatke o proizvodu? (Podaci će biti trajno izbrisani.)", MsgBoxStyle.YesNoCancel, "Optika")
        If msg = DialogResult.Yes Then
            Try
                con.Open()
                cmd = New OleDbCommand("DELETE from Proizvod where ProizvodID='" & TextBox2.Text & "'", con)
                cmd.ExecuteNonQuery()
                MsgBox("Podaci su uspješno izbrisani.", MsgBoxStyle.OkOnly, "Optika")
                clr()
            Catch ex As Exception
                MsgBox(ex.Message)

            Finally
                con.Close()
            End Try
        End If


    End Sub

    Private Sub Otkazi_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
End Class