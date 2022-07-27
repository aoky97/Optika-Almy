Imports System.Data.OleDb
Imports System.Data

Public Class Prodaja

    Dim Lastno As Integer
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection

    Public br, ip, np, uc, k, tp, d As String

    Private Sub Prodaja_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Racun()
        KupacIme()
        Proizvod()
        Doktor()
        TextBox11.Text = DateTime.Now
        con.Close()
    End Sub

    Public Sub Racun()
        con.Close()
        con.Open()
        str = "Select * From tblProdaja"
        cmd = New OleDbCommand(str, con)
        da.SelectCommand = cmd
        da.Fill(ds, "tblProdaja")

        'For Generating broj racuna
        Lastno = ds.Tables("tblProdaja").Rows.Count + 1
        If Lastno >= 0 Then
            TextBox1.Text = "Račun" & Lastno
        Else
            TextBox1.Text = "Račun" & 0
        End If
        con.Close()
    End Sub
    Private Sub KupacIme()
        ComboBox1.Items.Clear()
        ds.Clear()
        con.Close()
        con.Open()
        str = "Select * From Kupac"
        cmd = New OleDbCommand(str, con)
        da.SelectCommand = cmd
        da.Fill(ds, "Kupac")
        Dim a As Integer = ds.Tables("Kupac").Rows.Count - 1
        For i As Integer = 0 To a
            ComboBox1.Items.Add(ds.Tables("Kupac").Rows(i)(0).ToString())
        Next
    End Sub
    Private Sub Proizvod()
        ComboBox2.Items.Clear()
        ds.Clear()
        con.Close()
        con.Open()
        str = "Select * From Proizvod"
        cmd = New OleDbCommand(str, con)
        da.SelectCommand = cmd
        da.Fill(ds, "Proizvod")
        Dim a As Integer = ds.Tables("Proizvod").Rows.Count - 1
        For i As Integer = 0 To a
            ComboBox2.Items.Add(ds.Tables("Proizvod").Rows(i)(0).ToString())
        Next
    End Sub
    Private Sub Doktor()
        ComboBox3.Items.Clear()
        ds.Clear()
        con.Close()
        con.Open()
        str = "Select * From Doktor"
        cmd = New OleDbCommand(str, con)
        da.SelectCommand = cmd
        da.Fill(ds, "Doktor")
        Dim a As Integer = ds.Tables("Doktor").Rows.Count - 1
        For i As Integer = 0 To a
            ComboBox3.Items.Add(ds.Tables("Doktor").Rows(i)(0).ToString())
        Next
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        con.Close()
        con.Open()
        cmd = New OleDbCommand(str, con)
        If IsNumeric(ComboBox1.Text) Then
            cmd.CommandText = "SELECT * from Kupac where KupacID=@kid"
            cmd.Prepare()
            cmd.Parameters.AddWithValue("@kid", ComboBox1.Text)
            Dim dr As OleDbDataReader = cmd.ExecuteReader()
            Try
                If dr.Read() Then
                    TextBox17.Text = dr.GetValue(1)
                    TextBox2.Text = dr.GetValue(2)
                    TextBox3.Text = dr.GetValue(3)
                    TextBox4.Text = dr.GetValue(4)
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

    Private Sub ComboBox2_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        con.Close()
        con.Open()
        cmd = New OleDbCommand(str, con)
        If IsNumeric(ComboBox2.Text) Then
            cmd.CommandText = "SELECT * from Proizvod where ProizvodID=@pid"
            cmd.Prepare()
            cmd.Parameters.AddWithValue("@pid", ComboBox2.Text)
            Dim dr As OleDbDataReader = cmd.ExecuteReader()
            Try
                If dr.Read() Then
                    TextBox10.Text = dr.GetValue(1)
                    TextBox9.Text = dr.GetValue(2)
                    TextBox8.Text = dr.GetValue(3)
                    TextBox7.Text = dr.GetValue(4)
                    TextBox6.Text = dr.GetValue(5)
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

    Private Sub ComboBox3_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        con.Close()
        con.Open()
        cmd = New OleDbCommand(str, con)
        If IsNumeric(ComboBox3.Text) Then
            cmd.CommandText = "SELECT * from Doktor where DoktorID=@did"
            cmd.Prepare()
            cmd.Parameters.AddWithValue("@did", ComboBox3.Text)
            Dim dr As OleDbDataReader = cmd.ExecuteReader()
            Try
                If dr.Read() Then
                    TextBox18.Text = dr.GetValue(1)
                    TextBox15.Text = dr.GetValue(2)
                    TextBox14.Text = dr.GetValue(3)
                    TextBox13.Text = dr.GetValue(4)
                    TextBox12.Text = dr.GetValue(5)
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

    Private Sub ComboBox4_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox4.SelectedIndexChanged
        Dim tot As Integer
        tot = Val(TextBox6.Text) * Val(ComboBox4.Text)

        TextBox16.Text = FormatCurrency(Convert.ToString(tot))

    End Sub

    Private Sub Sacuvaj_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        con.Close()
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;"
        dataFile = "Data Source=C:\Users\almao\Documents\OptikaAlmy.accdb"
        connString = provider + dataFile
        myConnection.ConnectionString = connString
        myConnection.Open()
        Dim str As String
        str = "INSERT INTO tblProdaja ([KupacID],[ImeIPrezime],[AdresaStanovanja],[Telefon/Fax],[Stanje-Oči],[ProizvodID],[NazivProizvoda],[TipProizvoda],[TipStakla],[TipOkvira],[Cijena],[DoktorID],[ImePrezime],[Titula],[MjestoRada],[TelefonFax],[Email],[DatumProdaje],[Količina],[UkupnaCijena]) values ('" & ComboBox1.Text & "','" & TextBox17.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & ComboBox2.Text & "','" & TextBox10.Text & "','" & TextBox9.Text & "','" & TextBox8.Text & "','" & TextBox7.Text & "','" & TextBox6.Text & "','" & ComboBox3.Text & "','" & TextBox18.Text & "','" & TextBox15.Text & "','" & TextBox14.Text & "','" & TextBox13.Text & "','" & TextBox12.Text & "','" & TextBox11.Text & "','" & ComboBox4.Text & "','" & TextBox16.Text & "')"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myConnection.Close()

            MsgBox("Podaci uspješno sačuvani.", MsgBoxStyle.OkOnly, "Optika")

            br = TextBox1.Text
            ip = TextBox17.Text
            np = TextBox10.Text
            uc = TextBox16.Text
            d = TextBox11.Text
            Me.Hide()
            Račun.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Otkazi_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

End Class