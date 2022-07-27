Imports System.Data.OleDb
Imports System.Drawing
Imports System.Drawing.Printing

Public Class Račun

    Dim WithEvents mPrintDocument As New PrintDocument
    Dim mPrintBitMap As Bitmap

    Private Sub Račun_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Label7.Text = My.Forms.Prodaja.br
        Label8.Text = My.Forms.Prodaja.ip
        Label9.Text = My.Forms.Prodaja.np
        Label10.Text = My.Forms.Prodaja.uc
        Label13.Text = My.Forms.Prodaja.d

        Label11.Text = "Hvala Vam na kupovini u Našoj Optici."

    End Sub

    Private Sub Print_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Text = "Print Račun."

        Dim Preview As New PrintPreviewDialog
        Dim pd As New System.Drawing.Printing.PrintDocument
        pd.DefaultPageSettings.Landscape = True
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        AddHandler pd.PrintPage, AddressOf OnPrintPage
        Preview.Document = pd
        Preview.ShowDialog()

    End Sub
    Private Sub OnPrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        Using bmp As Bitmap = New Bitmap(Me.Width, Me.Height)
            Me.DrawToBitmap(bmp, New Rectangle(0, 80, Me.Width, Me.Height))
            Dim ratio As Single = CSng(bmp.Width / bmp.Height)
            If ratio > e.MarginBounds.Width / e.MarginBounds.Height Then
                e.Graphics.DrawImage(bmp,
                e.MarginBounds.Left,
                CInt(e.MarginBounds.Top + (e.MarginBounds.Height / 2) - ((e.MarginBounds.Width / ratio))),
                e.MarginBounds.Width,
                CInt(e.MarginBounds.Width / ratio))

            Else
                e.Graphics.DrawImage(bmp,
                e.MarginBounds.Top,
                CInt(e.MarginBounds.Left + (e.MarginBounds.Width / 4) - ((e.MarginBounds.Height * ratio) / 2)),
                e.MarginBounds.Height,
                CInt(e.MarginBounds.Height * ratio))

            End If
        End Using

    End Sub
    Private Sub PrintDocument1_BeginPrint(sender As System.Object, e As System.Drawing.Printing.PrintEventArgs) Handles PrintDocument1.BeginPrint
        MsgBox("Printanje dokumenta je započeto.")
    End Sub

    Private Sub PrintDocument1_EndPrint(sender As System.Object, e As System.Drawing.Printing.PrintEventArgs) Handles PrintDocument1.EndPrint
        MsgBox("Račun je isprintan.")
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        MsgBox("Printanje dokumenta je započeto.")
    End Sub
    Private Sub m_PrintDocument1_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles mPrintDocument.PrintPage
        Dim lWidth As Integer = e.MarginBounds.X + (e.MarginBounds.Width - mPrintBitMap.Width) / 1

        Dim lHeight As Integer = e.MarginBounds.Y + (e.MarginBounds.Height - mPrintBitMap.Height) / 1
        e.Graphics.DrawImage(mPrintBitMap, lWidth, lHeight)
        e.HasMorePages = False

    End Sub

    Private Sub Otkaži_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

  
    Private Sub PrintPreviewDialog1_Load(sender As System.Object, e As System.EventArgs) Handles PrintPreviewDialog1.Load
    End Sub
End Class