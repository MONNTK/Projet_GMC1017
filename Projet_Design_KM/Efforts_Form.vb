Public Class Efforts_Form
    Private Sub Effort_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox_EffortsC.Visible = False
        GroupBox_EffortsV.Visible = False
        TextBox_ECA.Visible = False
        TextBox_ECF.Visible = False
        TextBox_EVAMax.Visible = False
        TextBox_EVAMin.Visible = False
        TextBox_EVFMin.Visible = False
        TextBox_EVFMax.Visible = False
        Label_ECA.Visible = False
        Label_ECF.Visible = False
        Label_EVA.Visible = False
        Label_EVF.Visible = False

    End Sub

    Private Sub CheckBox_Constante_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_Constante.CheckedChanged
        If CheckBox_Constante.Checked = True Then
            CheckBox_Variable.Checked = False
            GroupBox_EffortsC.Visible = True
            GroupBox_EffortsV.Visible = False

            GlobalVariables.AppContrainte = "Constante"
        End If
    End Sub
    Private Sub CheckBox_Variable_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_Variable.CheckedChanged
        If CheckBox_Variable.Checked = True Then
            CheckBox_Constante.Checked = False
            GroupBox_EffortsV.Visible = True
            GroupBox_EffortsC.Visible = False

            GlobalVariables.AppContrainte = "Variable"
        End If
    End Sub
    Private Sub CheckBox_EAxial_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_EAxial.CheckedChanged
        If CheckBox_EAxial.Checked = True Then
            CheckBox_EFlexion.Checked = False
            CheckBox_EAxialeF.Checked = False
            GlobalVariables.TypeContrainte = "Axiales"
            Label_ECA.Visible = True
            Label_EVA.Visible = True
            Label_ECF.Visible = False
            Label_EVF.Visible = False
            TextBox_ECA.Visible = True
            TextBox_ECF.Visible = False
            TextBox_EVAMax.Visible = True
            TextBox_EVAMin.Visible = True
            TextBox_EVFMin.Visible = False
            TextBox_EVFMax.Visible = False
        End If
    End Sub
    Private Sub CheckBox_EFlexion_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_EFlexion.CheckedChanged
        If CheckBox_EFlexion.Checked = True Then
            CheckBox_EAxial.Checked = False
            CheckBox_EAxialeF.Checked = False
            GlobalVariables.TypeContrainte = "Flexion"
            Label_ECF.Visible = True
            Label_EVF.Visible = True
            Label_ECA.Visible = False
            Label_EVA.Visible = False
            TextBox_ECA.Visible = False
            TextBox_ECF.Visible = True
            TextBox_EVAMax.Visible = False
            TextBox_EVAMin.Visible = False
            TextBox_EVFMin.Visible = True
            TextBox_EVFMax.Visible = True
        End If
    End Sub
    Private Sub CheckBox_EAxialeF_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_EAxialeF.CheckedChanged
        If CheckBox_EAxialeF.Checked = True Then
            CheckBox_EAxial.Checked = False
            CheckBox_EFlexion.Checked = False
            GlobalVariables.TypeContrainte = "Axiales et flexion"
            Label_ECF.Visible = True
            Label_EVF.Visible = True
            Label_ECA.Visible = True
            Label_EVA.Visible = True
            TextBox_ECA.Visible = True
            TextBox_ECF.Visible = True
            TextBox_EVAMax.Visible = True
            TextBox_EVAMin.Visible = True
            TextBox_EVFMin.Visible = True
            TextBox_EVFMax.Visible = True
        End If
    End Sub
    Private Sub TextBox_ECA_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox_ECA.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = "," Or e.KeyChar = "-")
        End If
    End Sub
    Private Sub TextBox_ECF_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox_ECF.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = "," Or e.KeyChar = "-")
        End If
    End Sub
    Private Sub TextBox_EVAMin_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox_EVAMin.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = "," Or e.KeyChar = "-")
        End If
    End Sub
    Private Sub TextBox_EVAMax_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox_EVAMax.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = "," Or e.KeyChar = "-")
        End If
    End Sub
    Private Sub TextBox_EVFMin_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox_EVFMin.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = "," Or e.KeyChar = "-")
        End If
    End Sub
    Private Sub TextBox_EVFMax_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox_EVFMax.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = "," Or e.KeyChar = "-")
        End If
    End Sub
    Private Sub TextBox_Temperature_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox_temperature.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = "," Or e.KeyChar = "-")
        End If
    End Sub

    Private Sub Button_valider_Click(sender As Object, e As EventArgs) Handles Button_valider.Click
        GlobalVariables.Temperature = TextBox_temperature.Text
        CalculForces() 'à faire

    End Sub
    Function CalculForces() As Double
        If CheckBox_Constante.Checked = True Then
            If CheckBox_EAxial.Checked = True Then
                GlobalVariables.Fm = TextBox_ECA.Text
                Label_fm.Text = TextBox_ECA.Text
            End If

            If CheckBox_EFlexion.Checked = True Then
                GlobalVariables.Mm = TextBox_ECF.Text
                Label_mm.Text = TextBox_ECF.Text
            End If

            If CheckBox_EAxialeF.Checked = True Then
                GlobalVariables.Fm = TextBox_ECA.Text
                GlobalVariables.Mm = TextBox_ECF.Text
                Label_fm.Text = TextBox_ECA.Text
                Label_mm.Text = TextBox_ECF.Text
            End If

        End If

        If CheckBox_Variable.Checked = True Then
            If CheckBox_EAxial.Checked = True Then
                Dim Fmin = TextBox_EVAMin.Text
                Dim Fmax = TextBox_EVAMax.Text

                Dim Fa = (Fmax - Fmin) / 2
                Dim Fm = Fa + Fmin

                GlobalVariables.Fm = Fm
                GlobalVariables.Fa = Fa

                Label_fa.Text = Fa
                Label_fm.Text = Fm
            End If

            If CheckBox_EFlexion.Checked = True Then
                Dim Mmin = TextBox_EVFMin.Text
                Dim Mmax = TextBox_EVFMax.Text
                Dim Ma = (Mmax - Mmin) / 2
                Dim Mm = Ma + Mmin

                GlobalVariables.Ma = Ma
                GlobalVariables.Mm = Mm
                Label_ma.Text = Ma.ToString("0000.000")
                Label_mm.Text = Mm.ToString("0000.000")
            End If

            If CheckBox_EAxialeF.Checked = True Then
                Dim Fmin = TextBox_EVAMin.Text
                Dim Fmax = TextBox_EVAMax.Text
                Dim Mmin = TextBox_EVFMin.Text
                Dim Mmax = TextBox_EVFMax.Text

                Dim Fa = (Fmax - Fmin) / 2
                Dim Fm = Fa + Fmin
                Dim Ma = (Mmax - Mmin) / 2
                Dim Mm = Ma + Mmin

                GlobalVariables.Fm = Fm
                GlobalVariables.Mm = Mm
                GlobalVariables.Fa = Fa
                GlobalVariables.Ma = Ma

                Label_fa.Text = Fa
                Label_fm.Text = Fm
                Label_ma.Text = Ma
                Label_mm.Text = Mm
            End If

        End If
        CalculContrainte()
        Return 0
    End Function
    Function CalculContrainte() As Double
        Dim surface = GlobalVariables.surface
        Dim fm = GlobalVariables.Fm
        Dim Mm = GlobalVariables.Mm
        Dim fa = GlobalVariables.Fa
        Dim Ma = GlobalVariables.Ma
        Dim c = GlobalVariables.c
        Dim I = GlobalVariables.Inertie
        Dim sigma_a As Double = 0
        Dim sigma_m As Double = 0
        Dim sigma_af As Double = 0
        Dim sigma_mf As Double = 0

        If CheckBox_Constante.Checked = True Then

            If CheckBox_EAxial.Checked = True Then
                sigma_m = fm / surface
            ElseIf CheckBox_EFlexion.Checked Then
                sigma_mf = Mm * c / I
            ElseIf CheckBox_EAxialeF.Checked Then
                sigma_m = fm / surface
                sigma_mf = Mm * c / I
            End If
            GlobalVariables.SigmaMoyen = sigma_m
            GlobalVariables.SigmaMoyenFlex = sigma_mf
        End If

        If CheckBox_Variable.Checked = True Then

            If CheckBox_EAxial.Checked = True Then
                sigma_a = fa / surface
                sigma_m = fm / surface
                GlobalVariables.SigmaAmplitude = sigma_a
                GlobalVariables.SigmaMoyen = sigma_m
            ElseIf CheckBox_EFlexion.Checked Then
                sigma_af = Ma * c / I
                sigma_mf = Mm * c / I
                GlobalVariables.SigmaAmplitudeFlex = sigma_af
                GlobalVariables.SigmaMoyenFlex = sigma_mf
            ElseIf CheckBox_EAxialeF.Checked Then
                sigma_a = (fa / surface)
                sigma_af = Ma * c / I
                sigma_m = (fm / surface)
                sigma_mf = Mm * c / I
                GlobalVariables.SigmaAmplitude = sigma_a
                GlobalVariables.SigmaMoyen = sigma_m
                GlobalVariables.SigmaAmplitudeFlex = sigma_af
                GlobalVariables.SigmaMoyenFlex = sigma_mf
            End If
        End If

        Label_sigmaA.Text = GlobalVariables.SigmaAmplitude.ToString(".000")
        Label_sigmaM.Text = GlobalVariables.SigmaMoyen.ToString(".000")
        Label_sigmaAF.Text = GlobalVariables.SigmaAmplitudeFlex.ToString(".000")
        Label_sigmaMf.Text = GlobalVariables.SigmaMoyenFlex.ToString(".000")
        Return 0
    End Function

End Class