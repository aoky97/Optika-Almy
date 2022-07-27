Imports System.Data.OleDb
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Printing

Public Class IzvještajProdaje

    Private Sub IzvještajProdaje_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dgv()
    End Sub
    Public Sub Dgv()
        ds.Clear()
        con.Close()
        con.Open()
        str = "Select * From tblProdaja"
        Dim Adpt As New OleDbDataAdapter(str, con)
        Adpt.Fill(ds, "tblProdaja")
        DataGridView1.DataSource = ds.Tables(0)
        con.Close()

    End Sub
    

    Private Sub Otkazi_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Print_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        ReportProdaje.Show()
    End Sub
End Class