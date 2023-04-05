Imports System.Math
Public Class Calcul_Form

    Private Sub Button_Valider_Click(sender As Object, e As EventArgs) Handles Button_Valider.Click
        Label_TypeMat.Text = GlobalVariables.TypeMateriau
        Label_NatureMat.Text = GlobalVariables.NatureMateriau
        Label_Contrainte.Text = GlobalVariables.TypeContrainte
        Label_AppContrainte.Text = GlobalVariables.AppContrainte
        Label_FiniSurf.Text = GlobalVariables.FiniSurface
        Label_Temp.Text = GlobalVariables.Temperature
        Label_Fiabilité.Text = GlobalVariables.Fiabilité
        Label_Sut.Text = GlobalVariables.Sut
        Label_Suc.Text = GlobalVariables.Suc
        Label_Sy.Text = GlobalVariables.Sy

        GlobalVariables.Fiabilité = TextBox_fiabilite.Text
        Label_Fiabilité.Text = GlobalVariables.Fiabilité

        If GlobalVariables.AppContrainte = "Constante" Then
            GroupBox2.Visible = False
        End If
        If GlobalVariables.AppContrainte = "Variable" Then
            GroupBox2.Visible = True
        End If

    End Sub

    Private Sub B_Calculer_Click(sender As Object, e As EventArgs) Handles B_Calculer.Click
        VerificationDonnees()
        Calcul_Kt()

        If GlobalVariables.AppContrainte = "Constante" Then 'calcul statique
            Dim sigmaM As Double = GlobalVariables.SigmaMoyen
            Dim sigmaMF As Double = GlobalVariables.SigmaMoyenFlex
            Dim sigma As Double = 0
            Dim FS As Double = 0

            If GlobalVariables.TypeMateriau = "Ductile" Then
                sigma = sigmaM + sigmaMF
                FS = GlobalVariables.Sy / sigma
            End If

            If GlobalVariables.TypeMateriau = "Fragile" Then
                sigma = sigmaM * GlobalVariables.kta + sigmaMF * GlobalVariables.ktf
                FS = GlobalVariables.Sut / sigma
            End If

            Label_stat_sigma.Text = sigma.ToString(".000")
            Label_stat_FS.Text = FS.ToString(".00")
            Panel_stat.Visible = True
        End If 'calcul statique

        If GlobalVariables.AppContrainte = "Variable" Then 'calcul en fatique

            If CheckBox_DeterminerFS.Checked = True Then 'calcul FS
                Dim FS As Double
                Dim FS_Fat As Double = Calcul_FSfat()
                Dim FS_Stat As Double = Calcul_FSstat()

                If FS_Fat < FS_Stat Then
                    FS = FS_Fat
                    Label_stat_N.Text = "inf"
                Else
                    FS = FS_Stat
                    Label_FSfat.Text = "FSstat:"
                    Label_stat_N.Text = "inf"
                End If
                Label_fat_FS.Text = FS.ToString(".00")

            End If

            If CheckBox_DeterminerN.Checked = True Then 'calcul de N
                Dim FS As Double = TextBox_FSdesire.Text
                Dim N As Double = Calcul_N(FS)
                Label_stat_N.Text = N.ToString(".00")
                Label_fat_FS.Text = FS
                Label_fs_fat.Text = FS
                Label_fs_stat.Text = "x"
            End If

            Panel_FATIGUE.Visible = True

        End If 'calcul fatigue pour FS ou N


    End Sub

    Private Sub Calcul_Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Label_FStag.Visible = False
        TextBox_FSdesire.Visible = False
        Panel_stat.Visible = False
        Panel_FATIGUE.Visible = False
        Panel_test.Visible = False
    End Sub

    Function Calcul_Ka() As Double
        Dim sut
        If GlobalVariables.FiniSurface = "Poli" Then
            GlobalVariables.ka = 1
        End If
        If GlobalVariables.FiniSurface = "Meulé" Then
            GlobalVariables.ka = 0.9
        End If

        If GlobalVariables.FiniSurface = "Usiné ou écrouit" Then
            sut = GlobalVariables.Sut
            GlobalVariables.ka = (-2 * 10 ^ -10) * (sut ^ 3) + (9 * 10 ^ -7) * (sut ^ 2) - (0.0012 * sut) + 1.1991
        End If

        If GlobalVariables.FiniSurface = "Laminé à chaud" Then
            sut = GlobalVariables.Sut
            GlobalVariables.ka = (-9 * 10 ^ -11) * (sut ^ 3) + (5 * 10 ^ -7) * (sut ^ 2) - 0.001 * sut + 1.0378
        End If

        If GlobalVariables.FiniSurface = "Forgé" Then
            sut = GlobalVariables.Sut
            GlobalVariables.ka = (-1 * 10 ^ -10) * (sut ^ 3) + (6 * 10 ^ -7) * (sut ^ 2) - (0.001 * sut) + 0.8637
        End If

        Label_ka.Text = GlobalVariables.ka.ToString(".000")
        Return 0
    End Function
    Function Calcul_Kb() As Double
        Dim d = 0
        If GlobalVariables.Geometrie = "Plaque avec trou" Then
            d = GlobalVariables.d
        End If
        If GlobalVariables.Geometrie = "Plaque avec encoche" Then
            d = GlobalVariables.d
        End If
        If GlobalVariables.Geometrie = "Plaque avec épaulement" Then
            d = GlobalVariables.d
        End If

        If d <= 7.6 Then
            GlobalVariables.kb = 1
        End If

        If d > 7.6 And d <= 50 Then
            GlobalVariables.kb = 0.85
        End If

        If d > 50 Then
            GlobalVariables.kb = 0.75
        End If

        Label_kb.Text = GlobalVariables.kb.ToString(".000")
        Return 0
    End Function
    Function Calcul_Kc() As Single
        If GlobalVariables.Fiabilité = "" Then
            GlobalVariables.Fiabilité = 1
        End If

        Dim Donnees(11, 2) As Single
        Donnees(0, 0) = 0.5 ' colonne 1 = fiablilité
        Donnees(1, 0) = 0.9
        Donnees(2, 0) = 0.95
        Donnees(3, 0) = 0.99
        Donnees(4, 0) = 0.999
        Donnees(5, 0) = 0.9999
        Donnees(6, 0) = 0.99999
        Donnees(7, 0) = 0.999999
        Donnees(8, 0) = 0.9999999
        Donnees(9, 0) = 0.99999999
        Donnees(10, 0) = 0.999999999
        Donnees(0, 1) = 1 ' colonne 2 = Kc
        Donnees(1, 1) = 0.897
        Donnees(2, 1) = 0.868
        Donnees(3, 1) = 0.814
        Donnees(4, 1) = 0.753
        Donnees(5, 1) = 0.702
        Donnees(6, 1) = 0.659
        Donnees(7, 1) = 0.62
        Donnees(8, 1) = 0.584
        Donnees(9, 1) = 0.551
        Donnees(10, 1) = 0.52

        If GlobalVariables.Fiabilité >= Donnees(10, 0) Then
            GlobalVariables.kc = 1

        End If

        If GlobalVariables.Fiabilité <= Donnees(0, 0) Then
            GlobalVariables.kc = 0.5
        End If

        For i As Integer = 0 To 10
            If GlobalVariables.Fiabilité = Donnees(i, 0) Then
                GlobalVariables.kc = Donnees(i, 1)
            End If

            If GlobalVariables.Fiabilité > Donnees(i, 0) And GlobalVariables.Fiabilité < Donnees((i + 1), 0) Then
                GlobalVariables.kc = ((Donnees((i + 1), 1) - Donnees(i, 1)) * (GlobalVariables.Fiabilité - Donnees(i, 0))) / (Donnees(i + 1, 0) - Donnees(i, 0)) + Donnees(i, 1)
            End If

        Next

        Label_kc.Text = GlobalVariables.kc.ToString(".000")
        Return 0
    End Function
    Function Calcul_Kd() As Double
        Dim Temp As Integer

        If Integer.TryParse(GlobalVariables.Temperature, Temp) Then
            Temp = GlobalVariables.Temperature
        Else
            Temp = 0
        End If

        If Temp > 71 Then
            GlobalVariables.kd = (344 / (273 + Temp))
        End If

        If Temp <= 71 Then
            GlobalVariables.kd = 1
        End If
        Label_kd.Text = GlobalVariables.kd.ToString(".000")

        Return 0
    End Function
    Function Calcul_Ke() As Double
        Dim ke As Double = 0.1234
        Dim r As Double = 0.1234

        If GlobalVariables.Geometrie = "Plaque avec encoche" Or GlobalVariables.Geometrie = "Plaque avec épaulement" Then
            r = GlobalVariables.rayonEntaille
        Else
            r = 1
        End If

        Dim q As Double = 0.1234
        Dim kt2 As Double = 0.1234
        Dim kf2 As Double = 0.1234

        If GlobalVariables.kta > GlobalVariables.ktf Then 'prise du plus grand kt pour facteur sécurité
            kt2 = GlobalVariables.kta
        Else
            kt2 = GlobalVariables.ktf
        End If

        If GlobalVariables.NatureMateriau = "Alliage d'aluminium ou de magnésium" Then
            q = 0.28 * Log(r) + 0.5562

            If r > 5 Then
                q = 1
            End If

            kf2 = q * (kt2 - 1) + 1

        ElseIf GlobalVariables.NatureMateriau = "Acier" Then
            Dim Matrice(8, 2)
            Matrice(0, 0) = 350 'sut
            Matrice(1, 0) = 400
            Matrice(2, 0) = 550
            Matrice(3, 0) = 700
            Matrice(4, 0) = 850
            Matrice(5, 0) = 950
            Matrice(6, 0) = 1100
            Matrice(7, 0) = 1400
            Matrice(0, 1) = -0.052 * r ^ 2 + 0.3135 * r + 0.2937
            Matrice(1, 1) = 0.1225 * Log(r) + 0.6483
            Matrice(2, 1) = 0.1183 * Log(r) + 0.6954
            Matrice(3, 1) = 0.1006 * Log(r) + 0.6954
            Matrice(4, 1) = 0.0889 * Log(r) + 0.7825
            Matrice(5, 1) = 0.0853 * Log(r) + 0.8153
            Matrice(6, 1) = 0.0381 * r ^ 2 + 0.2127 * r + 0.6653
            Matrice(7, 1) = -0.0313 * r ^ 2 + 0.1695 * r + 0.7622
            Dim donnees = Matrice
            Dim nbCourbes = 7
            Dim ratio = GlobalVariables.Sut
            If ratio > donnees(nbCourbes, 0) Then
                'extrapolation
                q = (donnees(nbCourbes, 1) - donnees(nbCourbes - 1, 1)) / (donnees(nbCourbes, 0) - donnees(nbCourbes - 1, 0)) * (ratio - donnees(nbCourbes - 1, 0)) + donnees(0, 1)

            End If
            If ratio < donnees(0, 0) Then
                'extrapolation
                q = (donnees(1, 1) - donnees(0, 1)) / (donnees(1, 0) - donnees(0, 0)) * (ratio - donnees(0, 0)) + donnees(0, 1)
            End If
            For i As Integer = 0 To nbCourbes
                'association directe
                If ratio = donnees(i, 0) Then
                    q = donnees(i, 1)
                End If
            Next
            For i As Integer = 0 To (nbCourbes - 1)
                'interpolation
                If (ratio > donnees(i, 0)) And (ratio < donnees((i + 1), 0)) Then
                    Dim position = (ratio - donnees(i, 0)) / (donnees(i + 1, 0) - donnees(i, 0)) 'position en ratio avec plus basse courbe
                    q = position * donnees(i + 1, 1) + (1 - position) * donnees(i, 1)
                End If
            Next

            If r > 5 Then 'page 62
                q = 1
            End If

            kf2 = q * (kt2 - 1) + 1

        ElseIf GlobalVariables.NatureMateriau = "Fonte" Then 'pire des cas avec ASTM n50
            kf2 = 1.25
        Else
            kf2 = 1
        End If

        If GlobalVariables.Geometrie = "Plaque avec trou" Then
            q = 1
            kf2 = q * (kt2 - 1) + 1
        End If

        ke = 1 / kf2

        Label_kt_deKe.Text = kt2.ToString(".000")
        Label_q.Text = q.ToString(".000")
        Label_ke.Text = ke.ToString(".000")
        GlobalVariables.ke = ke
        Return 0
    End Function
    Function Calcul_Kf() As Double
        If TextBox_kf.Text = "" Then
            GlobalVariables.kf = 1
        Else
            GlobalVariables.kf = TextBox_kf.Text
        End If

        Label_kf.Text = GlobalVariables.kf.ToString(".000")
        Return 0
    End Function
    Function VerificationDonnees() As Double
        If GlobalVariables.Temperature = "Aucun sélectionné" Or GlobalVariables.NatureMateriau = "Aucun sélectionné" Or GlobalVariables.Fiabilité = "Aucun sélectionné" Or GlobalVariables.TypeContrainte = "Aucun sélectionné" Or GlobalVariables.AppContrainte = "Aucun sélectionné" Or GlobalVariables.FiniSurface = "Aucun sélectionné" Or GlobalVariables.TypeMateriau = "Aucun sélectionné" Then
            MsgBox("Certains paramètres n'ont pas été sélectionnés." & vbCrLf & vbCrLf & "Veuillez entrer les paramètres manquants pour effectuer le calcul." & vbCrLf & vbCrLf & "Les résultats suivants ne sont pas valides.",, "Paramètres manquants")
        End If

        Return 0
    End Function
    Private Sub CheckBox_DeterminerN_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_DeterminerN.CheckedChanged
        If CheckBox_DeterminerN.Checked = True Then
            CheckBox_DeterminerFS.Checked = False
            Label_FStag.Visible = True
            TextBox_FSdesire.Visible = True
        End If
    End Sub
    Private Sub CheckBox_DeterminerFS_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_DeterminerFS.CheckedChanged
        If CheckBox_DeterminerFS.Checked = True Then
            CheckBox_DeterminerN.Checked = False
            Label_FStag.Visible = False
            TextBox_FSdesire.Visible = False
        End If
    End Sub
    Private Sub TextBox_Fiabilité_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox_fiabilite.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ",")
        End If
    End Sub
    Private Sub TextBox_FS_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox_FSdesire.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar))
        End If
    End Sub
    Private Sub TextBox_kf_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox_kf.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ",")
        End If
    End Sub
    Function Calcul_Kt() As Double
        Dim kta As Double = 1
        Dim ktf As Double = 1
        If GlobalVariables.Geometrie = "Plaque avec trou" Then
            Dim d_w = GlobalVariables.d_w
            Dim d_h = GlobalVariables.d_h
            Label_d_h.Text = d_h.ToString(".00")
            Label_d_w.Text = d_w.ToString(".00")

            If GlobalVariables.TypeContrainte = "Axiales" Then 'cas 1

                kta = 1.7262 * (d_w) ^ 2 - 2.4493 * d_w + 2.954

            ElseIf GlobalVariables.TypeContrainte = "Flexion" Then 'cas 2
                Dim d_h1 = 0
                Dim kt1 = 2.5 * d_w ^ 2 - 2.8929 * d_w + 2.9857
                Dim d_h2 = 0.25
                Dim kt2 = 3.75 * d_w ^ 2 - 2.975 * d_w + 2.7025
                Dim d_h3 = 0.5
                Dim kt3 = 3.65 * d_w ^ 2 - 2.775 * d_w + 2.4975
                Dim d_h4 = 1
                Dim kt4 = 2.5 * d_w ^ 2 - 2.45 * d_w + 2.255
                Dim d_h5 = 2
                Dim kt5 = 2.5 * d_w ^ 2 - 2.25 * d_w + 2.05
                Dim d_h6 = 1000
                Dim kt6 = 1.0119 * d_w ^ 2 - 1.5893 * d_w + 1.8292
                Dim Mat(6, 2)
                Mat(0, 0) = d_h1
                Mat(1, 0) = d_h2
                Mat(2, 0) = d_h3
                Mat(3, 0) = d_h4
                Mat(4, 0) = d_h5
                Mat(5, 0) = d_h6
                Mat(0, 1) = kt1
                Mat(1, 1) = kt2
                Mat(2, 1) = kt3
                Mat(3, 1) = kt4
                Mat(4, 1) = kt5
                Mat(5, 1) = kt6
                Dim donnees = Mat
                Dim nbCourbes = 5
                Dim ratio = d_h
                If ratio > donnees(nbCourbes, 0) Then
                    'extrapolation
                    ktf = (donnees(nbCourbes, 1) - donnees(nbCourbes - 1, 1)) / (donnees(nbCourbes, 0) - donnees(nbCourbes - 1, 0)) * (ratio - donnees(nbCourbes - 1, 0)) + donnees(0, 1)

                End If
                If ratio < donnees(0, 0) Then
                    'extrapolation
                    ktf = (donnees(1, 1) - donnees(0, 1)) / (donnees(1, 0) - donnees(0, 0)) * (ratio - donnees(0, 0)) + donnees(0, 1)
                End If
                For i As Integer = 0 To nbCourbes
                    'association directe
                    If ratio = donnees(i, 0) Then
                        ktf = donnees(i, 1)
                    End If
                Next
                For i As Integer = 0 To (nbCourbes - 1)
                    'interpolation
                    If (ratio > donnees(i, 0)) And (ratio < donnees((i + 1), 0)) Then
                        Dim position = (ratio - donnees(i, 0)) / (donnees(i + 1, 0) - donnees(i, 0)) 'position en ratio avec plus basse courbe
                        ktf = position * donnees(i + 1, 1) + (1 - position) * donnees(i, 1)
                    End If
                Next

            ElseIf GlobalVariables.TypeContrainte = "Axiales et flexion" Then 'cas 1 et 2
                kta = (1.7262 * (d_w) ^ 2) - (2.4493 * d_w) + 2.954

                Dim d_h1 = 0
                Dim kt1 = 2.5 * d_w ^ 2 - 2.8929 * d_w + 2.9857
                Dim d_h2 = 0.25
                Dim kt2 = 3.75 * d_w ^ 2 - 2.975 * d_w + 2.7025
                Dim d_h3 = 0.5
                Dim kt3 = 3.65 * d_w ^ 2 - 2.775 * d_w + 2.4975
                Dim d_h4 = 1
                Dim kt4 = 2.5 * d_w ^ 2 - 2.45 * d_w + 2.255
                Dim d_h5 = 2
                Dim kt5 = 2.5 * d_w ^ 2 - 2.25 * d_w + 2.05
                Dim d_h6 = 1000
                Dim kt6 = 1.0119 * d_w ^ 2 - 1.5893 * d_w + 1.8292
                Dim Mat(6, 2)
                Mat(0, 0) = d_h1
                Mat(1, 0) = d_h2
                Mat(2, 0) = d_h3
                Mat(3, 0) = d_h4
                Mat(4, 0) = d_h5
                Mat(5, 0) = d_h6
                Mat(0, 1) = kt1
                Mat(1, 1) = kt2
                Mat(2, 1) = kt3
                Mat(3, 1) = kt4
                Mat(4, 1) = kt5
                Mat(5, 1) = kt6
                Dim donnees = Mat
                Dim nbCourbes = 5
                Dim ratio = d_h
                If ratio > donnees(nbCourbes, 0) Then
                    'extrapolation
                    ktf = (donnees(nbCourbes, 1) - donnees(nbCourbes - 1, 1)) / (donnees(nbCourbes, 0) - donnees(nbCourbes - 1, 0)) * (ratio - donnees(nbCourbes - 1, 0)) + donnees(0, 1)

                End If
                If ratio < donnees(0, 0) Then
                    'extrapolation
                    ktf = (donnees(1, 1) - donnees(0, 1)) / (donnees(1, 0) - donnees(0, 0)) * (ratio - donnees(0, 0)) + donnees(0, 1)
                End If
                For i As Integer = 0 To nbCourbes
                    'association directe
                    If ratio = donnees(i, 0) Then
                        ktf = donnees(i, 1)
                    End If
                Next
                For i As Integer = 0 To (nbCourbes - 1)
                    'interpolation
                    If (ratio > donnees(i, 0)) And (ratio < donnees((i + 1), 0)) Then
                        Dim position = (ratio - donnees(i, 0)) / (donnees(i + 1, 0) - donnees(i, 0)) 'position en ratio avec plus basse courbe
                        ktf = position * donnees(i + 1, 1) + (1 - position) * donnees(i, 1)
                    End If
                Next
            End If

        ElseIf GlobalVariables.Geometrie = "Plaque avec encoche" Then
            Dim w_d = GlobalVariables.w_d
            Dim r_d = GlobalVariables.r_d
            Label_r_d.Text = r_d.ToString(".00")
            Label_w_d.Text = w_d.ToString(".00")

            If GlobalVariables.TypeContrainte = "Axiales" Then 'cas 3
                Dim w_d1 = 3
                Dim kt1 = 1.1586 * r_d ^ -0.388
                Dim w_d2 = 1.5
                Dim kt2 = 1.1964 * r_d ^ -0.335
                Dim w_d3 = 1.2
                Dim kt3 = 1.1057 * r_d ^ -0.335
                Dim w_d4 = 1.1
                Dim kt4 = 1.0747 * r_d ^ -0.302
                Dim w_d5 = 1.05
                Dim kt5 = 1.0546 * r_d ^ -0.261
                Dim Mat(5, 2)
                Mat(0, 0) = w_d1
                Mat(1, 0) = w_d2
                Mat(2, 0) = w_d3
                Mat(3, 0) = w_d4
                Mat(4, 0) = w_d5
                Mat(0, 1) = kt1
                Mat(1, 1) = kt2
                Mat(2, 1) = kt3
                Mat(3, 1) = kt4
                Mat(4, 1) = kt5
                Dim donnees = Mat
                Dim nbCourbes = 4
                Dim ratio = w_d
                If ratio > donnees(nbCourbes, 0) Then
                    'extrapolation
                    kta = (donnees(nbCourbes, 1) - donnees(nbCourbes - 1, 1)) / (donnees(nbCourbes, 0) - donnees(nbCourbes - 1, 0)) * (ratio - donnees(nbCourbes - 1, 0)) + donnees(0, 1)

                End If
                If ratio < donnees(0, 0) Then
                    'extrapolation
                    kta = (donnees(1, 1) - donnees(0, 1)) / (donnees(1, 0) - donnees(0, 0)) * (ratio - donnees(0, 0)) + donnees(0, 1)
                End If
                For i As Integer = 0 To nbCourbes
                    'association directe
                    If ratio = donnees(i, 0) Then
                        kta = donnees(i, 1)
                    End If
                Next
                For i As Integer = 0 To (nbCourbes - 1)
                    'interpolation
                    If (ratio > donnees(i, 0)) And (ratio < donnees((i + 1), 0)) Then
                        Dim position = (ratio - donnees(i, 0)) / (donnees(i + 1, 0) - donnees(i, 0)) 'position en ratio avec plus basse courbe
                        kta = position * donnees(i + 1, 1) + (1 - position) * donnees(i, 1)
                    End If
                Next

            ElseIf GlobalVariables.TypeContrainte = "Flexion" Then 'cas 4
                Dim w_d1 = 1000 ' pour infini
                Dim w_d2 = 1.5
                Dim w_d3 = 1.1
                Dim w_d4 = 1.05
                Dim w_d5 = 1.02
                Dim kt1 = 25.398 * r_d ^ 2 - 14.307 * r_d + 3.524
                Dim kt2 = 25.381 * r_d ^ 2 - 13.986 * r_d + 3.3939
                Dim kt3 = -154.63 * r_d ^ 3 + 107.95 * r_d ^ 2 - 25.434 * r_d + 3.5656
                Dim kt4 = -120.44 * r_d ^ 3 + 83.65 * r_d ^ 2 - 19.653 * r_d + 3.0333
                Dim kt5 = -77.787 * r_d ^ 3 + 56.468 * r_d ^ 2 - 13.541 * r_d + 2.4486
                Dim Mat(5, 2)
                Mat(0, 0) = w_d1
                Mat(1, 0) = w_d2
                Mat(2, 0) = w_d3
                Mat(3, 0) = w_d4
                Mat(4, 0) = w_d5
                Mat(0, 1) = kt1
                Mat(1, 1) = kt2
                Mat(2, 1) = kt3
                Mat(3, 1) = kt4
                Mat(4, 1) = kt5
                Dim donnees = Mat
                Dim nbCourbes = 4
                Dim ratio = w_d
                If ratio > donnees(nbCourbes, 0) Then
                    'extrapolation
                    ktf = (donnees(nbCourbes, 1) - donnees(nbCourbes - 1, 1)) / (donnees(nbCourbes, 0) - donnees(nbCourbes - 1, 0)) * (ratio - donnees(nbCourbes - 1, 0)) + donnees(0, 1)

                End If
                If ratio < donnees(0, 0) Then
                    'extrapolation
                    ktf = (donnees(1, 1) - donnees(0, 1)) / (donnees(1, 0) - donnees(0, 0)) * (ratio - donnees(0, 0)) + donnees(0, 1)
                End If
                For i As Integer = 0 To nbCourbes
                    'association directe
                    If ratio = donnees(i, 0) Then
                        ktf = donnees(i, 1)
                    End If
                Next
                For i As Integer = 0 To (nbCourbes - 1)
                    'interpolation
                    If (ratio > donnees(i, 0)) And (ratio < donnees((i + 1), 0)) Then
                        Dim position = (ratio - donnees(i, 0)) / (donnees(i + 1, 0) - donnees(i, 0)) 'position en ratio avec plus basse courbe
                        ktf = position * donnees(i + 1, 1) + (1 - position) * donnees(i, 1)
                    End If
                Next
            ElseIf GlobalVariables.TypeContrainte = "Axiales et flexion" Then 'cas 5 et 6
                Dim w_d1a = 3
                Dim kt1a = 1.1586 * r_d ^ -0.388
                Dim w_d2a = 1.5
                Dim kt2a = 1.1964 * r_d ^ -0.335
                Dim w_d3a = 1.2
                Dim kt3a = 1.1057 * r_d ^ -0.335
                Dim w_d4a = 1.1
                Dim kt4a = 1.0747 * r_d ^ -0.302
                Dim w_d5a = 1.05
                Dim kt5a = 1.0546 * r_d ^ -0.261
                Dim Mat(5, 2)
                Mat(0, 0) = w_d1a
                Mat(1, 0) = w_d2a
                Mat(2, 0) = w_d3a
                Mat(3, 0) = w_d4a
                Mat(4, 0) = w_d5a
                Mat(0, 1) = kt1a
                Mat(1, 1) = kt2a
                Mat(2, 1) = kt3a
                Mat(3, 1) = kt4a
                Mat(4, 1) = kt5a
                Dim donnees = Mat
                Dim nbCourbes = 4
                Dim ratio = w_d
                If ratio > donnees(nbCourbes, 0) Then
                    'extrapolation
                    kta = (donnees(nbCourbes, 1) - donnees(nbCourbes - 1, 1)) / (donnees(nbCourbes, 0) - donnees(nbCourbes - 1, 0)) * (ratio - donnees(nbCourbes - 1, 0)) + donnees(0, 1)

                End If
                If ratio < donnees(0, 0) Then
                    'extrapolation
                    kta = (donnees(1, 1) - donnees(0, 1)) / (donnees(1, 0) - donnees(0, 0)) * (ratio - donnees(0, 0)) + donnees(0, 1)
                End If
                For i As Integer = 0 To nbCourbes
                    'association directe
                    If ratio = donnees(i, 0) Then
                        kta = donnees(i, 1)
                    End If
                Next
                For i As Integer = 0 To (nbCourbes - 1)
                    'interpolation
                    If (ratio > donnees(i, 0)) And (ratio < donnees((i + 1), 0)) Then
                        Dim position = (ratio - donnees(i, 0)) / (donnees(i + 1, 0) - donnees(i, 0)) 'position en ratio avec plus basse courbe
                        kta = position * donnees(i + 1, 1) + (1 - position) * donnees(i, 1)
                    End If
                Next

                Dim w_d1 = 1000 ' pour infini
                Dim w_d2 = 1.5
                Dim w_d3 = 1.1
                Dim w_d4 = 1.05
                Dim w_d5 = 1.02
                Dim kt1 = 25.398 * r_d ^ 2 - 14.307 * r_d + 3.524
                Dim kt2 = 25.381 * r_d ^ 2 - 13.986 * r_d + 3.3939
                Dim kt3 = -154.63 * r_d ^ 3 + 107.95 * r_d ^ 2 - 25.434 * r_d + 3.5656
                Dim kt4 = -120.44 * r_d ^ 3 + 83.65 * r_d ^ 2 - 19.653 * r_d + 3.0333
                Dim kt5 = -77.787 * r_d ^ 3 + 56.468 * r_d ^ 2 - 13.541 * r_d + 2.4486
                Dim Matf(5, 2)
                Matf(0, 0) = w_d1
                Matf(1, 0) = w_d2
                Matf(2, 0) = w_d3
                Matf(3, 0) = w_d4
                Matf(4, 0) = w_d5
                Matf(0, 1) = kt1
                Matf(1, 1) = kt2
                Matf(2, 1) = kt3
                Matf(3, 1) = kt4
                Matf(4, 1) = kt5
                donnees = Matf
                nbCourbes = 4
                ratio = w_d
                If ratio > donnees(nbCourbes, 0) Then
                    'extrapolation
                    ktf = (donnees(nbCourbes, 1) - donnees(nbCourbes - 1, 1)) / (donnees(nbCourbes, 0) - donnees(nbCourbes - 1, 0)) * (ratio - donnees(nbCourbes - 1, 0)) + donnees(0, 1)

                End If
                If ratio < donnees(0, 0) Then
                    'extrapolation
                    ktf = (donnees(1, 1) - donnees(0, 1)) / (donnees(1, 0) - donnees(0, 0)) * (ratio - donnees(0, 0)) + donnees(0, 1)
                End If
                For i As Integer = 0 To nbCourbes
                    'association directe
                    If ratio = donnees(i, 0) Then
                        ktf = donnees(i, 1)
                    End If
                Next
                For i As Integer = 0 To (nbCourbes - 1)
                    'interpolation
                    If (ratio > donnees(i, 0)) And (ratio < donnees((i + 1), 0)) Then
                        Dim position = (ratio - donnees(i, 0)) / (donnees(i + 1, 0) - donnees(i, 0)) 'position en ratio avec plus basse courbe
                        ktf = position * donnees(i + 1, 1) + (1 - position) * donnees(i, 1)
                    End If
                Next
            End If

        ElseIf GlobalVariables.Geometrie = "Plaque avec épaulement" Then
            Dim D_d = GlobalVariables.D_d
            Dim r_d = GlobalVariables.r_d
            Label_r_d.Text = r_d.ToString(".00")
            Label_D_d.Text = D_d.ToString(".00")
            If GlobalVariables.TypeContrainte = "Axiales" Then 'cas 5
                Dim D_d1 = 1.5
                Dim D_d2 = 1.1
                Dim D_d3 = 1.05
                Dim D_d4 = 1.02
                Dim kt1 = 17.883 * r_d ^ 2 - 9.9719 * r_d + 2.9775
                Dim kt2 = -141.81 * r_d ^ 3 + 89.667 * r_d ^ 2 - 19.064 * r_d + 2.7831
                Dim kt3 = -131.28 * r_d ^ 3 + 81.351 * r_d ^ 2 - 16.558 * r_d + 2.44
                Dim kt4 = -81.554 * r_d ^ 3 + 51.841 * r_d ^ 2 - 11.031 * r_d + 2.0085
                Dim Mat(5, 2)
                Mat(0, 0) = D_d1
                Mat(1, 0) = D_d2
                Mat(2, 0) = D_d3
                Mat(3, 0) = D_d4
                Mat(0, 1) = kt1
                Mat(1, 1) = kt2
                Mat(2, 1) = kt3
                Mat(3, 1) = kt4
                Dim donnees = Mat
                Dim nbCourbes = 3
                Dim ratio = D_d
                If ratio > donnees(nbCourbes, 0) Then
                    'extrapolation
                    kta = (donnees(nbCourbes, 1) - donnees(nbCourbes - 1, 1)) / (donnees(nbCourbes, 0) - donnees(nbCourbes - 1, 0)) * (ratio - donnees(nbCourbes - 1, 0)) + donnees(0, 1)

                End If
                If ratio < donnees(0, 0) Then
                    'extrapolation
                    kta = (donnees(1, 1) - donnees(0, 1)) / (donnees(1, 0) - donnees(0, 0)) * (ratio - donnees(0, 0)) + donnees(0, 1)
                End If
                For i As Integer = 0 To nbCourbes
                    'association directe
                    If ratio = donnees(i, 0) Then
                        kta = donnees(i, 1)
                    End If
                Next
                For i As Integer = 0 To (nbCourbes - 1)
                    'interpolation
                    If (ratio > donnees(i, 0)) And (ratio < donnees((i + 1), 0)) Then
                        Dim position = (ratio - donnees(i, 0)) / (donnees(i + 1, 0) - donnees(i, 0)) 'position en ratio avec plus basse courbe
                        kta = position * donnees(i + 1, 1) + (1 - position) * donnees(i, 1)
                    End If
                Next

            ElseIf GlobalVariables.TypeContrainte = "Flexion" Then 'cas 6
                Dim D_d1 = 3
                Dim kt1 = 0.9014 * r_d ^ -0.337
                Dim D_d2 = 1.3
                Dim kt2 = 0.9362 * r_d ^ -0.285
                Dim D_d3 = 1.1
                Dim kt3 = 0.9619 * r_d ^ -0.238
                Dim D_d4 = 1.05
                Dim kt4 = 0.8792 * r_d ^ -0.211
                Dim D_d5 = 1.02
                Dim kt5 = 0.9697 * r_d ^ -0.185
                Dim Mat(5, 2)
                Mat(0, 0) = D_d1
                Mat(1, 0) = D_d2
                Mat(2, 0) = D_d3
                Mat(3, 0) = D_d4
                Mat(4, 0) = D_d5
                Mat(0, 1) = kt1
                Mat(1, 1) = kt2
                Mat(2, 1) = kt3
                Mat(3, 1) = kt4
                Mat(4, 1) = kt4
                Dim donnees = Mat
                Dim nbCourbes = 4
                Dim ratio = D_d
                If ratio > donnees(nbCourbes, 0) Then
                    'extrapolation
                    ktf = (donnees(nbCourbes, 1) - donnees(nbCourbes - 1, 1)) / (donnees(nbCourbes, 0) - donnees(nbCourbes - 1, 0)) * (ratio - donnees(nbCourbes - 1, 0)) + donnees(0, 1)

                End If
                If ratio < donnees(0, 0) Then
                    'extrapolation
                    ktf = (donnees(1, 1) - donnees(0, 1)) / (donnees(1, 0) - donnees(0, 0)) * (ratio - donnees(0, 0)) + donnees(0, 1)
                End If
                For i As Integer = 0 To nbCourbes
                    'association directe
                    If ratio = donnees(i, 0) Then
                        ktf = donnees(i, 1)
                    End If
                Next
                For i As Integer = 0 To (nbCourbes - 1)
                    'interpolation
                    If (ratio > donnees(i, 0)) And (ratio < donnees((i + 1), 0)) Then
                        Dim position = (ratio - donnees(i, 0)) / (donnees(i + 1, 0) - donnees(i, 0)) 'position en ratio avec plus basse courbe
                        ktf = position * donnees(i + 1, 1) + (1 - position) * donnees(i, 1)
                    End If
                Next

            ElseIf GlobalVariables.TypeContrainte = "Axiales et flexion" Then 'cas 5 et 6
                Dim D_d1a = 1.5
                Dim D_d2a = 1.1
                Dim D_d3a = 1.05
                Dim D_d4a = 1.02
                Dim kt1a = 17.883 * r_d ^ 2 - 9.9719 * r_d + 2.9775
                Dim kt2a = -141.81 * r_d ^ 3 + 89.667 * r_d ^ 2 - 19.064 * r_d + 2.7831
                Dim kt3a = -131.28 * r_d ^ 3 + 81.351 * r_d ^ 2 - 16.558 * r_d + 2.44
                Dim kt4a = -81.554 * r_d ^ 3 + 51.841 * r_d ^ 2 - 11.031 * r_d + 2.0085
                Dim Mat(5, 2)
                Mat(0, 0) = D_d1a
                Mat(1, 0) = D_d2a
                Mat(2, 0) = D_d3a
                Mat(3, 0) = D_d4a
                Mat(0, 1) = kt1a
                Mat(1, 1) = kt2a
                Mat(2, 1) = kt3a
                Mat(3, 1) = kt4a
                Dim donnees = Mat
                Dim nbCourbes = 3
                Dim ratio = D_d
                If ratio > donnees(nbCourbes, 0) Then
                    'extrapolation
                    kta = (donnees(nbCourbes, 1) - donnees(nbCourbes - 1, 1)) / (donnees(nbCourbes, 0) - donnees(nbCourbes - 1, 0)) * (ratio - donnees(nbCourbes - 1, 0)) + donnees(0, 1)

                End If
                If ratio < donnees(0, 0) Then
                    'extrapolation
                    kta = (donnees(1, 1) - donnees(0, 1)) / (donnees(1, 0) - donnees(0, 0)) * (ratio - donnees(0, 0)) + donnees(0, 1)
                End If
                For i As Integer = 0 To nbCourbes
                    'association directe
                    If ratio = donnees(i, 0) Then
                        kta = donnees(i, 1)
                    End If
                Next
                For i As Integer = 0 To (nbCourbes - 1)
                    'interpolation
                    If (ratio > donnees(i, 0)) And (ratio < donnees((i + 1), 0)) Then
                        Dim position = (ratio - donnees(i, 0)) / (donnees(i + 1, 0) - donnees(i, 0)) 'position en ratio avec plus basse courbe
                        kta = position * donnees(i + 1, 1) + (1 - position) * donnees(i, 1)
                    End If
                Next

                Dim D_d1f = 3
                Dim kt1f = 0.9014 * r_d ^ -0.337
                Dim D_d2f = 1.3
                Dim kt2f = 0.9362 * r_d ^ -0.285
                Dim D_d3f = 1.1
                Dim kt3f = 0.9619 * r_d ^ -0.238
                Dim D_d4f = 1.05
                Dim kt4f = 0.8792 * r_d ^ -0.211
                Dim D_d5f = 1.02
                Dim kt5f = 0.9697 * r_d ^ -0.185
                Dim Matf(5, 2)
                Matf(0, 0) = D_d1f
                Matf(1, 0) = D_d2f
                Matf(2, 0) = D_d3f
                Matf(3, 0) = D_d4f
                Matf(4, 0) = D_d5f
                Matf(0, 1) = kt1f
                Matf(1, 1) = kt2f
                Matf(2, 1) = kt3f
                Matf(3, 1) = kt4f
                Matf(4, 1) = kt4f
                donnees = Matf
                nbCourbes = 4
                ratio = D_d
                If ratio > donnees(nbCourbes, 0) Then
                    'extrapolation
                    ktf = (donnees(nbCourbes, 1) - donnees(nbCourbes - 1, 1)) / (donnees(nbCourbes, 0) - donnees(nbCourbes - 1, 0)) * (ratio - donnees(nbCourbes - 1, 0)) + donnees(0, 1)

                End If
                If ratio < donnees(0, 0) Then
                    'extrapolation
                    ktf = (donnees(1, 1) - donnees(0, 1)) / (donnees(1, 0) - donnees(0, 0)) * (ratio - donnees(0, 0)) + donnees(0, 1)
                End If
                For i As Integer = 0 To nbCourbes
                    'association directe
                    If ratio = donnees(i, 0) Then
                        ktf = donnees(i, 1)
                    End If
                Next
                For i As Integer = 0 To (nbCourbes - 1)
                    'interpolation
                    If (ratio > donnees(i, 0)) And (ratio < donnees((i + 1), 0)) Then
                        Dim position = (ratio - donnees(i, 0)) / (donnees(i + 1, 0) - donnees(i, 0)) 'position en ratio avec plus basse courbe
                        ktf = position * donnees(i + 1, 1) + (1 - position) * donnees(i, 1)
                    End If
                Next
            End If
        End If

        GlobalVariables.kta = kta
        GlobalVariables.ktf = ktf
        Label_kt_axiale.Text = kta.ToString(".00")
        Label_kt_flexion.Text = ktf.ToString(".00")
        Return 0
    End Function
    Function RecherchePosition(ratio, donnees(,), nbCourbes) As Double
        Dim kt = 0
        If ratio > donnees(nbCourbes, 0) Then
            'extrapolation
            kt = (donnees(nbCourbes, 1) - donnees(nbCourbes - 1, 1)) / (donnees(nbCourbes, 0) - donnees(nbCourbes - 1, 0)) * (ratio - donnees(nbCourbes - 1, 0)) + donnees(0, 1)

        End If

        If ratio < donnees(0, 0) Then
            'extrapolation
            kt = (donnees(1, 1) - donnees(0, 1)) / (donnees(1, 0) - donnees(0, 0)) * (ratio - donnees(0, 0)) + donnees(0, 1)
        End If

        For i As Integer = 0 To nbCourbes
            'association directe
            If ratio = donnees(i, 0) Then
                kt = donnees(i, 1)
            End If
        Next

        For i As Integer = 0 To (nbCourbes - 1)
            'interpolation
            If (ratio > donnees(i, 0)) And (ratio < donnees((i + 1), 0)) Then
                Dim position = (ratio - donnees(i, 0)) / (donnees(i + 1, 0) - donnees(i, 0)) 'position en ratio avec plus basse courbe
                kt = position * donnees(i + 1, 1) + (1 - position) * donnees(i, 1)
                If i = 0 Then
                    Panel_test.Visible = True 'pour test
                    Label_kt_flexion.Text = kt.ToString(".00")
                End If
            End If
        Next

        Return kt
    End Function
    Function Calcul_FSstat() As Double
        Dim fs_Calc As Double = 0
        Dim ktA = GlobalVariables.kta
        Dim ktF = GlobalVariables.ktf
        Dim sy = GlobalVariables.Sy
        Dim sigmaA = GlobalVariables.SigmaAmplitude
        Dim sigmaM = GlobalVariables.SigmaMoyen
        Dim sigmaAf = GlobalVariables.SigmaAmplitudeFlex
        Dim sigmaMf = GlobalVariables.SigmaMoyenFlex

        If GlobalVariables.TypeMateriau = "Ductile" Then
            fs_Calc = sy / (sigmaA + sigmaAf + sigmaM + sigmaMf) ' Pas de prise en compte des kt
        End If

        If GlobalVariables.TypeMateriau = "Fragile" Then
            If GlobalVariables.NatureMateriau = "Fonte" Then
                ktA = 1
                ktF = 1
            End If
            fs_Calc = sy / ((sigmaA * ktA) + (sigmaAf * ktF) + (sigmaM * ktA) + (sigmaMf * ktF))
        End If

        Label_fs_stat.Text = fs_Calc.ToString(".00")
        Return fs_Calc
    End Function
    Function Calcul_FSfat() As Double
        Dim sigmaAa = GlobalVariables.SigmaAmplitude
        Dim sigmaMa = GlobalVariables.SigmaMoyen
        Dim sigmaAf = GlobalVariables.SigmaAmplitudeFlex
        Dim sigmaMf = GlobalVariables.SigmaMoyenFlex
        Dim fs_Calc As Double = 0
        Calcul_SePrime()
        Calcul_Se()
        Dim se = GlobalVariables.Se

        If GlobalVariables.TypeMateriau = "Ductile" Then
            Dim sigmaA = sigmaAa + sigmaAf
            Dim sigmaM = sigmaMa + sigmaMf

            fs_Calc = 1 / ((sigmaA / se) + (sigmaM / GlobalVariables.Sut))
            Label_fat_sigmaA.Text = sigmaA.ToString(".000")
            Label_fat_sigmaM.Text = sigmaM.ToString(".000")
        End If

        If GlobalVariables.TypeMateriau = "Fragile" Then
            Dim sigmaA = sigmaAa * GlobalVariables.kta + sigmaAf * GlobalVariables.ktf
            Dim sigmaM = sigmaMa * GlobalVariables.kta + sigmaMf * GlobalVariables.ktf

            fs_Calc = 1 / ((sigmaA / se) + (sigmaM / GlobalVariables.Sut))
            Label_fat_sigmaA.Text = sigmaA.ToString(".000")
            Label_fat_sigmaM.Text = sigmaM.ToString(".000")
        End If

        Label_fs_fat.Text = fs_Calc.ToString(".00")
        Return fs_Calc
    End Function
    Function Calcul_N(FS) As Double

        Dim sigma_m As Double = 0
        Dim sigma_a As Double = 0
        If GlobalVariables.TypeMateriau = "Ductile" Then
            sigma_a = GlobalVariables.SigmaAmplitude + GlobalVariables.SigmaAmplitudeFlex
            sigma_m = GlobalVariables.SigmaMoyen + GlobalVariables.SigmaMoyenFlex
        End If

        If GlobalVariables.TypeMateriau = "Fragile" Then
            sigma_a = GlobalVariables.SigmaAmplitude * GlobalVariables.kta + GlobalVariables.SigmaAmplitudeFlex * GlobalVariables.ktf
            sigma_m = GlobalVariables.SigmaMoyen * GlobalVariables.kta + GlobalVariables.SigmaMoyenFlex * GlobalVariables.ktf
        End If

        Dim sf As Double = (sigma_a * FS * GlobalVariables.Sut) / (GlobalVariables.Sut - sigma_m * FS)

        Calcul_SePrime()
        Calcul_Se()
        Dim se As Double = GlobalVariables.Se

        Dim N As Double = 1000 * (sf / (0.9 * GlobalVariables.Sut)) ^ (3 / (Log10(se / (0.9 * GlobalVariables.Sut))))

        Return N
    End Function
    Function Calcul_SePrime() As Double
        Dim se_prime As Double = 0

        If GlobalVariables.NatureMateriau = "Acier" Then
            If GlobalVariables.Sut > 1400 Then
                se_prime = 700
            Else
                se_prime = 0.5 * (GlobalVariables.Sut)
            End If
        End If

        If GlobalVariables.NatureMateriau = "Fonte" Then
            se_prime = 0.4 * (GlobalVariables.Sut)
        End If

        If GlobalVariables.NatureMateriau = "Alliage d'alluminium ou de magnésium" Then
            se_prime = 0.4 * (GlobalVariables.Sut)
        End If

        If GlobalVariables.NatureMateriau = "Autre matériau fragile" Then
            se_prime = 0.3 * (GlobalVariables.Sut)
        End If
        Label_se_prime.Text = se_prime.ToString(".000")
        GlobalVariables.Se_prime = se_prime
        Return se_prime
    End Function
    Function Calcul_Se() As Double
        Dim se_prime = GlobalVariables.Se_prime
        Dim se As Double = 0
        Calcul_Ka()
        Calcul_Kb()
        Calcul_Kc()
        Calcul_Kd()
        Calcul_Ke()
        Calcul_Kf()
        Dim ka = GlobalVariables.ka
        Dim kb = GlobalVariables.kb
        Dim kc = GlobalVariables.kc
        Dim kd = GlobalVariables.kd
        Dim ke = GlobalVariables.ke
        Dim kf = GlobalVariables.kf

        se = se_prime * ka * kb * kc * kd * ke * kf
        GlobalVariables.Se = se
        Label_se.Text = se.ToString(".000")
        Return se
    End Function
    Function RecherchePosition2(ratio, sut, donnees(,), nbCourbes) As Double
        Dim kt = 0
        If sut > donnees(nbCourbes, 0) Then ' sup à 1400
            'extrapolation
            kt = (donnees(nbCourbes, 1) - donnees(nbCourbes - 1, 1)) / (donnees(nbCourbes, 0) - donnees(nbCourbes - 1, 0)) * (sut - donnees(nbCourbes - 1, 0)) + donnees(0, 1)

        End If

        If sut < donnees(0, 0) Then 'inf à 350
            'extrapolation
            kt = (donnees(1, 1) - donnees(0, 1)) / (donnees(1, 0) - donnees(0, 0)) * (sut - donnees(0, 0)) + donnees(0, 1)
        End If

        For i As Integer = 0 To (nbCourbes) 'entre 350 et 1400
            If sut = donnees(i, 0) Then
                kt = donnees(i, 1)
            End If
            'interpolation
            If sut > donnees(i, 0) And sut < donnees((i + 1), 0) Then
                kt = ((donnees((i + 1), 1) - donnees(i, 1)) * (sut - donnees(i, 0))) / (donnees(i + 1, 0) - donnees(i, 0)) + donnees(i, 1)
            End If
        Next

        Return kt
    End Function

End Class