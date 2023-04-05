Public Class Geometrie_Form
    Private Sub Geometrie_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox_Dimensions.Visible = False
        GroupBox1.Visible = False
        Label_L.Visible = False
        Label_D.Visible = False
        Label_e.Visible = False
        Label_r.Visible = False
        Label_plarg.Visible = False
        TextBox_L.Visible = False
        TextBox_D.Visible = False
        TextBox_e.Visible = False
        TextBox_Plarg.Visible = False
        TextBox_r.Visible = False
    End Sub

    Private Sub CheckBox_PTrou_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_PTrou.CheckedChanged
        GroupBox_Dimensions.Visible = True
        GlobalVariables.Geometrie = "Plaque avec trou"
        If CheckBox_PTrou.Checked = True Then
            CheckBox_PEncoche.Checked = False
            CheckBox_PEpaulement.Checked = False

            Label_L.Visible = True
            Label_D.Visible = True
            Label_e.Visible = True

            Label_r.Visible = False
            Label_plarg.Visible = False

            TextBox_L.Visible = True
            TextBox_D.Visible = True
            TextBox_e.Visible = True

            TextBox_Plarg.Visible = False
            TextBox_r.Visible = False

        End If

    End Sub

    Private Sub CheckBox_PEncoche_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_PEncoche.CheckedChanged

        GroupBox_Dimensions.Visible = True
        GlobalVariables.Geometrie = "Plaque avec encoche"
        If CheckBox_PEncoche.Checked = True Then
            CheckBox_PTrou.Checked = False
            CheckBox_PEpaulement.Checked = False

            Label_L.Visible = True
            Label_D.Visible = False
            Label_e.Visible = True
            Label_r.Visible = True
            Label_plarg.Visible = True
            TextBox_L.Visible = True
            TextBox_D.Visible = False
            TextBox_e.Visible = True
            TextBox_Plarg.Visible = True
            TextBox_r.Visible = True
        End If

    End Sub

    Private Sub CheckBox_PEpaulement_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_PEpaulement.CheckedChanged

        GlobalVariables.Geometrie = "Plaque avec épaulement"
        GroupBox_Dimensions.Visible = True
        If CheckBox_PEpaulement.Checked = True Then
            CheckBox_PEncoche.Checked = False
            CheckBox_PTrou.Checked = False
            Label_L.Visible = True
            Label_D.Visible = False
            Label_e.Visible = True
            Label_r.Visible = True
            Label_plarg.Visible = True
            TextBox_L.Visible = True
            TextBox_D.Visible = False
            TextBox_e.Visible = True
            TextBox_Plarg.Visible = True
            TextBox_r.Visible = True
        End If
    End Sub

    Private Sub Button_Valider_Click(sender As Object, e As EventArgs) Handles Button_Valider.Click
        If CheckBox_PTrou.Checked = True Then
            Dim L = TextBox_L.Text
            Dim D = TextBox_D.Text

            GlobalVariables.d = (L - D)
        End If

        If CheckBox_PEncoche.Checked = True Then
            GlobalVariables.d = TextBox_Plarg.Text
            GlobalVariables.rayonEntaille = TextBox_r.Text
        End If

        If CheckBox_PEpaulement.Checked = True Then
            GlobalVariables.d = TextBox_Plarg.Text
            GlobalVariables.rayonEntaille = TextBox_r.Text
        End If

        Calcul_Geo()

        GroupBox1.Visible = True
    End Sub
    Private Sub TextBox_r_f(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox_r.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ",")
        End If
    End Sub
    Function Calcul_Geo() As Double

        Dim L As Single = 0
        Dim plarg As Single = 0
        Dim e As Single = 0
        Dim r As Single = 0
        Dim D As Single = 0

        Dim surface As Single = 0
        Dim inertie1 As Double = 0
        Dim inertie2 As Double = 0
        Dim ktFlex As Single = 0
        Dim ktAxiale As Single = 0

        L = TextBox_L.Text
        e = TextBox_e.Text

        If CheckBox_PTrou.Checked = True Then
            D = TextBox_D.Text

            Dim ratioDL = D / L
            Dim ratioDe = D / e

            surface = (L - D) * e
            inertie2 = ((L - D) * (e * e * e)) / 12
            Label_inertie2.Text = inertie2.ToString(".00")
            Label_Inertie1.Text = "inutile"

            GlobalVariables.d_w = ratioDL
            GlobalVariables.d_h = ratioDe
            GlobalVariables.c = e / 2
            GlobalVariables.Inertie = inertie2
        End If

        If CheckBox_PEncoche.Checked = True Then
            r = TextBox_r.Text
            plarg = TextBox_Plarg.Text

            Dim ratiorplarg = r / plarg
            Dim ratiorLplarg = L / plarg

            surface = plarg * e
            inertie1 = (e * (plarg * plarg * plarg)) / 12
            Label_Inertie1.Text = inertie1.ToString(".00")
            Label_inertie2.Text = "inutile"

            GlobalVariables.w_d = ratiorLplarg
            GlobalVariables.r_d = ratiorplarg
            GlobalVariables.c = L / 2
            GlobalVariables.Inertie = inertie1
        End If

        If CheckBox_PEpaulement.Checked = True Then
            r = TextBox_r.Text
            plarg = TextBox_Plarg.Text

            Dim ratioLplarg = L / plarg
            Dim ratiorL = r / plarg

            surface = plarg * e
            inertie1 = (e * (plarg * plarg * plarg)) / 12
            Label_Inertie1.Text = inertie1.ToString(".00")
            Label_inertie2.Text = "inutile"

            GlobalVariables.D_d = ratioLplarg
            GlobalVariables.r_d = ratiorL
            GlobalVariables.c = plarg / 2
            GlobalVariables.Inertie = inertie1
        End If

        GlobalVariables.surface = surface

        Label_surface.Text = surface.ToString(".00")

        Return 0
    End Function

End Class