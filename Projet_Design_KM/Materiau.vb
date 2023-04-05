Public Class Materiau

    Private Sub Materiau_Load(sender As Object, e As EventArgs) Handles Me.Load
        GroupBox_Ductile_Mat.Visible = False
        GroupBox_Fragile.Visible = False
        GroupBox_ParametresMat.Visible = False
    End Sub

    Private Sub Check_Ductile_CheckedChanged(sender As Object, e As EventArgs) Handles Check_Ductile.CheckedChanged
        If Check_Ductile.Checked = True Then
            Check_Fragile.Checked = False
            GroupBox_Ductile_Mat.Visible = True
            GroupBox_Fragile.Visible = False
            GroupBox_ParametresMat.Visible = True

            GlobalVariables.TypeMateriau = Check_Ductile.Text
        End If
    End Sub
    Private Sub Check_Fragile_CheckedChanged(sender As Object, e As EventArgs) Handles Check_Fragile.CheckedChanged
        If Check_Fragile.Checked = True Then
            Check_Ductile.Checked = False
            GroupBox_Ductile_Mat.Visible = False
            GroupBox_Fragile.Visible = True
            GroupBox_ParametresMat.Visible = True

            GlobalVariables.TypeMateriau = Check_Fragile.Text
        End If
    End Sub

    Private Sub CheckBox_Fonte_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_Fonte.CheckedChanged
        If CheckBox_Fonte.Checked = True Then
            CheckBox_AutreFragile.Checked = False

            GlobalVariables.NatureMateriau = CheckBox_Fonte.Text

            GlobalVariables.kta = 1 'Fixe KT = 1 pour de la fonte
            GlobalVariables.ktf = 1 'Fixe KT = 1 pour de la fonte
        End If
    End Sub

    Private Sub CheckBox_AutreFragile_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_AutreFragile.CheckedChanged
        If CheckBox_AutreFragile.Checked = True Then
            CheckBox_Fonte.Checked = False
            GlobalVariables.NatureMateriau = CheckBox_AutreFragile.Text
        End If
    End Sub

    Private Sub CheckBox_Acier_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_Acier.CheckedChanged
        If CheckBox_Acier.Checked = True Then
            CheckBox_Alliage.Checked = False
            GlobalVariables.NatureMateriau = CheckBox_Acier.Text
        End If
    End Sub

    Private Sub CheckBox_Alliage_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_Alliage.CheckedChanged
        If CheckBox_Alliage.Checked = True Then
            CheckBox_Acier.Checked = False
            GlobalVariables.NatureMateriau = CheckBox_Alliage.Text
        End If
    End Sub

    '3 Sub suivantes empêches d'entrer des caracteres
    Private Sub TextBox_Suc_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox_Suc.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ",")
        End If
    End Sub
    Private Sub TextBox_Sut_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox_Sut.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ",")
        End If
    End Sub
    Private Sub TextBox_Sy_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox_Sy.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ",")
        End If
    End Sub

    Private Sub Button_Confirmer_Click(sender As Object, e As EventArgs) Handles Button_Confirmer.Click
        GlobalVariables.Suc = CSng(TextBox_Suc.Text)
        GlobalVariables.Sut = CSng(TextBox_Sut.Text)
        GlobalVariables.Sy = CSng(TextBox_Sy.Text)
        GlobalVariables.FiniSurface = ComboBox_Fini.Text
    End Sub
End Class