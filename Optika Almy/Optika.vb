Imports System.Windows.Forms

Public Class Optika

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub Optika_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub IzlazToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IzlazToolStripMenuItem.Click
        Dim res As Integer = MsgBox("Da li želite izaći iz aplikacije?", MsgBoxStyle.YesNo)
        If res = DialogResult.No Then
        ElseIf res = DialogResult.Yes Then
            Prijava_Optika_Almy.Show()
            Me.Hide()
        End If
    End Sub

    Private Function ToolStrip() As Object
        Throw New NotImplementedException
    End Function

    Private Function ToolBarToolStripMenuItem() As Object
        Throw New NotImplementedException
    End Function

    Private Function StatusBarToolStripMenuItem() As Object
        Throw New NotImplementedException
    End Function

    Private Sub DODAJKupacToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DODAJKupacToolStripMenuItem.Click
        Kupac.Show()

    End Sub

    Private Sub UREDIKupacToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles UREDIKupacToolStripMenuItem.Click
        Uredi_Podatke_o_Kupcu.Show()

    End Sub

    Private Sub DODAJProizvodToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DODAJProizvodToolStripMenuItem.Click
        Proizvod.Show()
    End Sub

    Private Sub UREDIProizvodToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles UREDIProizvodToolStripMenuItem.Click
        UrediPodatkeoProizvodu.Show()
    End Sub

    Private Sub DODAJDoktorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DODAJDoktorToolStripMenuItem.Click
        Doktor.Show()
    End Sub

    Private Sub UREDIDoktorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles UREDIDoktorToolStripMenuItem.Click
        UrediPodatkeoDoktoru.Show()
    End Sub

    Private Sub ProdajaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ProdajaToolStripMenuItem.Click
        Prodaja.Show()
    End Sub

    Private Sub IzvještajOProdajiToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles IzvještajOProdajiToolStripMenuItem.Click
        IzvještajProdaje.Show()
    End Sub

    Private Sub IzvještajKorisnikDoktorProizvodToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles IzvještajKorisnikDoktorProizvodToolStripMenuItem.Click
        Izvještaji.Show()
    End Sub

    Private Sub MenuStrip_ItemClicked(sender As System.Object, e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip.ItemClicked

    End Sub
End Class
