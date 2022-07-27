Imports System.Data.OleDb
Imports System.Data

Public Class Izvještaji

    Private Sub Izvještaji_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Visible = True
        Button4.Visible = True
        Label4.Visible = True

    End Sub
    Public Sub Dgv()
        ds.Clear()
        con.Close()
        con.Open()
        str = "Select * From Kupac"
        Dim Adpt As New OleDbDataAdapter(str, con)
        Adpt.Fill(ds, "Kupac")
        DataGridView1.DataSource = ds.Tables(0)
        con.Close()
        sum()
    End Sub
    Public Sub Dgv3()
        ds.Clear()
        con.Close()
        con.Open()
        str = "Select * From Proizvod"
        Dim Adpt As New OleDbDataAdapter(str, con)
        Dim ds3 As DataSet = New DataSet
        Adpt.Fill(ds3, "Proizvod")
        DataGridView1.DataSource = ds3.Tables(0)
        con.Close()
        sum()
    End Sub
    Public Sub Dgv2()
        ds.Clear()
        con.Close()
        con.Open()
        str = "Select * From Doktor"
        Dim Adpt As New OleDbDataAdapter(str, con)
        Dim ds2 As DataSet = New DataSet
        Adpt.Fill(ds2, "Doktor")
        DataGridView1.DataSource = ds2.Tables(0)
        con.Close()
        sum()
    End Sub
  
    Public Sub sum()
    End Sub

    Private Sub TextBox1_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        Label4.Visible = True
        ComboBox1.Visible = True

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Button4.Visible = True
    End Sub

    Private Sub Trazi_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click

        If ComboBox1.Text = "Kupac" Then
            trazi()
        ElseIf ComboBox1.Text = "Proizvod" Then
            trazi3()
        ElseIf ComboBox1.Text = "Doktor" Then
            trazi2()
        End If
    End Sub
    Public Sub trazi()
        con.Close()
        con.Open()
        Using cmd As New OleDbCommand()
            cmd.CommandText = "Select * from Kupac where KupacID LIKE @ID + '%' "
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@ID", TextBox1.Text.Trim())
            Dim dt As New DataTable()
            Using da As New OleDbDataAdapter(cmd)
                da.Fill(dt)
                If (dt.Rows.Count > 0) Then
                    DataGridView1.DataSource = dt
                Else
                    MsgBox("Traženi podaci nisu pronađeni", MsgBoxStyle.Exclamation, "Optika")
                End If
            End Using
        End Using
    End Sub
    Public Sub trazi3()
        con.Close()
        con.Open()
        Using cmd As New OleDbCommand()
            cmd.CommandText = "Select * from Proizvod where ProizvodID LIKE @ID + '%' "
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@ID", TextBox1.Text.Trim())
            Dim dt As New DataTable()
            Using da As New OleDbDataAdapter(cmd)
                da.Fill(dt)
                If (dt.Rows.Count > 0) Then
                    DataGridView1.DataSource = dt
                Else
                    MsgBox("Traženi podaci nisu pronađeni", MsgBoxStyle.Exclamation, "Optika")
                End If
            End Using
        End Using
    End Sub
    Public Sub trazi2()
        con.Close()
        con.Open()
        Using cmd As New OleDbCommand()
            cmd.CommandText = "Select * from Doktor where DoktorID LIKE @ID + '%' "
            cmd.Connection = con
            cmd.Parameters.AddWithValue("DID", TextBox1.Text.Trim())
            Dim dt As New DataTable()
            Using da As New OleDbDataAdapter(cmd)
                da.Fill(dt)
                If (dt.Rows.Count > 0) Then
                    DataGridView1.DataSource = dt
                Else
                    MsgBox("Traženi podaci nisu pronađeni", MsgBoxStyle.Exclamation, "Optika")
                End If
            End Using
        End Using
    End Sub
    Private Sub Otkazi_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

  
End Class