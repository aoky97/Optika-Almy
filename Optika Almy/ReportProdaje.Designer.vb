<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportProdaje
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.tblProdajaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OptikaAlmyDataSet1 = New Global.Optika_Almy.OptikaAlmyDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.tblProdajaTableAdapter = New Global.Optika_Almy.OptikaAlmyDataSetTableAdapters.tblProdajaTableAdapter()
        Me.OptikaAlmyDataSet = New Global.Optika_Almy.OptikaAlmyDataSet()
        CType(Me.tblProdajaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OptikaAlmyDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OptikaAlmyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tblProdajaBindingSource
        '
        Me.tblProdajaBindingSource.DataMember = "tblProdaja"
        Me.tblProdajaBindingSource.DataSource = Me.OptikaAlmyDataSet1
        '
        'OptikaAlmyDataSet1
        '
        Me.OptikaAlmyDataSet1.DataSetName = "OptikaAlmyDataSet1"
        Me.OptikaAlmyDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet"
        ReportDataSource1.Value = Me.tblProdajaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Optika_Almy.Report2.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(596, 392)
        Me.ReportViewer1.TabIndex = 0
        '
        'tblProdajaTableAdapter
        '
        Me.tblProdajaTableAdapter.ClearBeforeFill = True
        '
        'OptikaAlmyDataSet
        '
        Me.OptikaAlmyDataSet.DataSetName = "OptikaAlmyDataSet"
        Me.OptikaAlmyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportProdaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 392)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "ReportProdaje"
        Me.Text = "ReportProdaje"
        CType(Me.tblProdajaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OptikaAlmyDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OptikaAlmyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tblProdajaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OptikaAlmyDataSet1 As Global.Optika_Almy.OptikaAlmyDataSet
    Friend WithEvents tblProdajaTableAdapter As Global.Optika_Almy.OptikaAlmyDataSetTableAdapters.tblProdajaTableAdapter
    Friend WithEvents OptikaAlmyDataSet As Global.Optika_Almy.OptikaAlmyDataSet
End Class
