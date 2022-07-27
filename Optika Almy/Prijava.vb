Imports System.Data
Imports System.Data.OleDb

Public Class Prijava_Optika_Almy

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        con.Close()
        If UsernameTextBox.Text = "" Then
            MessageBox.Show("Molimo, unesite Vaše Korisničke podatke.", "Optika", MessageBoxButtons.OK, MessageBoxIcon.Error)
            UsernameTextBox.Focus()
        ElseIf PasswordTextBox.Text = "" Then
            MessageBox.Show("Molimo, unesite Vašu lozinku.", "Optika", MessageBoxButtons.OK, MessageBoxIcon.Error)
            PasswordTextBox.Focus()
        Else
            If UsernameTextBox.Text = "" Then UsernameTextBox.Focus() : Exit Sub
            If PasswordTextBox.Text = "" Then PasswordTextBox.Focus() : Exit Sub
            str = "Select * from Prijava where KorisničkoIme = '" + UsernameTextBox.Text + " 'and Lozinka='" + PasswordTextBox.Text + "'"
            cmd = New OleDbCommand(str, con)
            con.Open()
            Dim dr As OleDbDataReader = cmd.ExecuteReader()
            If dr.HasRows Then
                con.Close()
                My.Forms.Optika.Show()
                Me.Close()
            Else
                MsgBox("Korisničko ime ili Lozinka nisu tačni.", MsgBoxStyle.Critical, "Optika")
            End If
            con.Close()
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class
