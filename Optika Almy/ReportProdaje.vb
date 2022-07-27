Public Class ReportProdaje

    Private Sub ReportProdaje_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OptikaAlmyDataSet1.tblProdaja' table. You can move, or remove it, as needed.
        Me.tblProdajaTableAdapter.Fill(Me.OptikaAlmyDataSet1.tblProdaja)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class