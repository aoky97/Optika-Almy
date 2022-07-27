<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Optika
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
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.KupacToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DODAJKupacToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UREDIKupacToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProizvodToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DODAJProizvodToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UREDIProizvodToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DoktorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DODAJDoktorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UREDIDoktorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProdajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IzvještajiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IzvještajOProdajiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IzvještajKorisnikDoktorProizvodToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IzlazToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KupacToolStripMenuItem, Me.ProizvodToolStripMenuItem, Me.DoktorToolStripMenuItem, Me.ProdajaToolStripMenuItem, Me.IzvještajiToolStripMenuItem, Me.IzlazToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(632, 25)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'KupacToolStripMenuItem
        '
        Me.KupacToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DODAJKupacToolStripMenuItem, Me.UREDIKupacToolStripMenuItem})
        Me.KupacToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.KupacToolStripMenuItem.ForeColor = System.Drawing.Color.Green
        Me.KupacToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert
        Me.KupacToolStripMenuItem.Name = "KupacToolStripMenuItem"
        Me.KupacToolStripMenuItem.Size = New System.Drawing.Size(57, 21)
        Me.KupacToolStripMenuItem.Text = "Kupac"
        '
        'DODAJKupacToolStripMenuItem
        '
        Me.DODAJKupacToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.DODAJKupacToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DODAJKupacToolStripMenuItem.Name = "DODAJKupacToolStripMenuItem"
        Me.DODAJKupacToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DODAJKupacToolStripMenuItem.Text = "DODAJ Kupac"
        '
        'UREDIKupacToolStripMenuItem
        '
        Me.UREDIKupacToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.UREDIKupacToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.UREDIKupacToolStripMenuItem.Name = "UREDIKupacToolStripMenuItem"
        Me.UREDIKupacToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.UREDIKupacToolStripMenuItem.Text = "UREDI Kupac"
        '
        'ProizvodToolStripMenuItem
        '
        Me.ProizvodToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DODAJProizvodToolStripMenuItem, Me.UREDIProizvodToolStripMenuItem})
        Me.ProizvodToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.ProizvodToolStripMenuItem.ForeColor = System.Drawing.Color.Green
        Me.ProizvodToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert
        Me.ProizvodToolStripMenuItem.Name = "ProizvodToolStripMenuItem"
        Me.ProizvodToolStripMenuItem.Size = New System.Drawing.Size(74, 21)
        Me.ProizvodToolStripMenuItem.Text = "Proizvod"
        '
        'DODAJProizvodToolStripMenuItem
        '
        Me.DODAJProizvodToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.DODAJProizvodToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DODAJProizvodToolStripMenuItem.Name = "DODAJProizvodToolStripMenuItem"
        Me.DODAJProizvodToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.DODAJProizvodToolStripMenuItem.Text = "DODAJ Proizvod"
        '
        'UREDIProizvodToolStripMenuItem
        '
        Me.UREDIProizvodToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.UREDIProizvodToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.UREDIProizvodToolStripMenuItem.Name = "UREDIProizvodToolStripMenuItem"
        Me.UREDIProizvodToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.UREDIProizvodToolStripMenuItem.Text = "UREDI Proizvod"
        '
        'DoktorToolStripMenuItem
        '
        Me.DoktorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DODAJDoktorToolStripMenuItem, Me.UREDIDoktorToolStripMenuItem})
        Me.DoktorToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.DoktorToolStripMenuItem.ForeColor = System.Drawing.Color.Green
        Me.DoktorToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert
        Me.DoktorToolStripMenuItem.Name = "DoktorToolStripMenuItem"
        Me.DoktorToolStripMenuItem.Size = New System.Drawing.Size(63, 21)
        Me.DoktorToolStripMenuItem.Text = "Doktor"
        '
        'DODAJDoktorToolStripMenuItem
        '
        Me.DODAJDoktorToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.DODAJDoktorToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DODAJDoktorToolStripMenuItem.Name = "DODAJDoktorToolStripMenuItem"
        Me.DODAJDoktorToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.DODAJDoktorToolStripMenuItem.Text = "DODAJ Doktor"
        '
        'UREDIDoktorToolStripMenuItem
        '
        Me.UREDIDoktorToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.UREDIDoktorToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.UREDIDoktorToolStripMenuItem.Name = "UREDIDoktorToolStripMenuItem"
        Me.UREDIDoktorToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.UREDIDoktorToolStripMenuItem.Text = "UREDI Doktor"
        '
        'ProdajaToolStripMenuItem
        '
        Me.ProdajaToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.ProdajaToolStripMenuItem.ForeColor = System.Drawing.Color.Green
        Me.ProdajaToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert
        Me.ProdajaToolStripMenuItem.Name = "ProdajaToolStripMenuItem"
        Me.ProdajaToolStripMenuItem.Size = New System.Drawing.Size(67, 21)
        Me.ProdajaToolStripMenuItem.Text = "Prodaja"
        '
        'IzvještajiToolStripMenuItem
        '
        Me.IzvještajiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IzvještajOProdajiToolStripMenuItem, Me.IzvještajKorisnikDoktorProizvodToolStripMenuItem})
        Me.IzvještajiToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.IzvještajiToolStripMenuItem.ForeColor = System.Drawing.Color.Green
        Me.IzvještajiToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert
        Me.IzvještajiToolStripMenuItem.Name = "IzvještajiToolStripMenuItem"
        Me.IzvještajiToolStripMenuItem.Size = New System.Drawing.Size(74, 21)
        Me.IzvještajiToolStripMenuItem.Text = "Izvještaji"
        '
        'IzvještajOProdajiToolStripMenuItem
        '
        Me.IzvještajOProdajiToolStripMenuItem.Name = "IzvještajOProdajiToolStripMenuItem"
        Me.IzvještajOProdajiToolStripMenuItem.Size = New System.Drawing.Size(276, 22)
        Me.IzvještajOProdajiToolStripMenuItem.Text = "Izvještaj o prodaji"
        '
        'IzvještajKorisnikDoktorProizvodToolStripMenuItem
        '
        Me.IzvještajKorisnikDoktorProizvodToolStripMenuItem.Name = "IzvještajKorisnikDoktorProizvodToolStripMenuItem"
        Me.IzvještajKorisnikDoktorProizvodToolStripMenuItem.Size = New System.Drawing.Size(276, 22)
        Me.IzvještajKorisnikDoktorProizvodToolStripMenuItem.Text = "Izvještaj kupac, doktor, proizvod"
        '
        'IzlazToolStripMenuItem
        '
        Me.IzlazToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.IzlazToolStripMenuItem.ForeColor = System.Drawing.Color.Red
        Me.IzlazToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert
        Me.IzlazToolStripMenuItem.Name = "IzlazToolStripMenuItem"
        Me.IzlazToolStripMenuItem.Size = New System.Drawing.Size(47, 21)
        Me.IzlazToolStripMenuItem.Text = "Izlaz"
        '
        'StatusStrip
        '
        Me.StatusStrip.Location = New System.Drawing.Point(0, 431)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(632, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'Optika
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "Optika"
        Me.Text = "Optika"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents KupacToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DODAJKupacToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UREDIKupacToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProizvodToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DODAJProizvodToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UREDIProizvodToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DoktorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DODAJDoktorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UREDIDoktorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProdajaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IzlazToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IzvještajiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IzvještajOProdajiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IzvještajKorisnikDoktorProizvodToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
