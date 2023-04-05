Imports System.Math
Public Class Dimensionnement
    Public d As Single
    Public w As Single
    Public h As Single
    Public r As Single
    Public DD As Single 'diamètre
    Public FAM As Double = 0
    Public AFA As Double = 0
    Public FFM As Double = 0
    Public AFF As Double = 0
    Public DistanceFlex As Double
    Public ContrainteMoyenne As Double
    Public AmplitudeContrainte As Double
    Public Vie As String
    Public FS As Single
    Public N As String
    Public Materiau As String
    Public Fiabilite As Decimal
    Public Temperature As Single
    Public FiniSurface As String
    Public ka As Decimal
    Public kb As Decimal
    Public kc As Decimal
    Public kd As Decimal
    Public keE As Decimal
    Public kf As Decimal
    Public Se_prime As Double
    Public Se As Double
    Public Su As Double
    Public Sy As Double
    Public cas As Integer
    Public kt As Single
    Public Parametre_i As Double = 0
    Public FS_i As Double = 0
    Public FS_i_Fat As Double
    Public FS_i_Stat As Double
    Public FS_r As Double
    Public Charge_A As Integer = 0
    Public Charge_F As Integer = 0
    Public Chargement As String
    Public Kta_g As Single = 1
    Public Ktf_g As Single = 1
    Public Kt_g As Single = 1
    Public Surface As Double
    Public Inertie As Double
    Public Sf As Double = 0




    Private Sub Button_Calculer_Click(sender As Object, e As EventArgs) Handles Button_Calculer.Click
        Dim cas As Integer = RechercheCas()
        AssignationDimensions() 'assigne les dimensions sauf celui à trouver
        AssignationCharges() 'assigne la force ou les contraintes (si force, contraintes = 0 )
        AssignationParametres() 'assigne R, Materiau, FS , T , Fini , kf

        FS_i = 0
        Parametre_i = 0

        While FS_i < FS
            Dim increment = 0.00001
            Parametre_i = Parametre_i + increment

            RechercheParametre_i()
            Calcul_Kt()

            If Kta_g > Ktf_g Then 'Plus grand kt pour calcul Se
                Kt_g = Kta_g
            Else
                Kt_g = Ktf_g
            End If

            Calcul_Se()
            Calcul_Contraintes()
            Calcul_FSi()
            'allo
            If FS_i > FS Then
                FS_r = FS_i.ToString(".00")
                Label_FS.Text = FS_r.ToString(".00")
                Parametre_i = Parametre_i * 1000
                AffichageParametre_i()
                Exit While
            End If

        End While

        Panel_resultats.Visible = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Panel_resultats.Visible = False

        CheckBox_FAM.Visible = False
        TextBox_FAM.Visible = False

        CheckBox_AFM.Visible = False
        TextBox_AFA.Visible = False

        CheckBox_FFM.Visible = False
        TextBox_FFM.Visible = False

        CheckBox_AFF.Visible = False
        TextBox_AFF.Visible = False

        CheckBox_CM.Visible = False
        TextBox_CM.Visible = False

        CheckBox_AC.Visible = False
        TextBox_AC.Visible = False

        TextBox_DistanceFlex.Visible = False
        Label_dist_flex.Visible = False

        Label_N.Visible = False
        TextBox_N.Visible = False

        Panel_Image.Visible = False
    End Sub

    Function RechercheCas() As Integer
        cas = 0

        If CheckBox_cas1.Checked = True Then
            cas = 1
        ElseIf CheckBox_cas2.Checked = True Then
            cas = 2
        ElseIf CheckBox_cas3.Checked = True Then
            cas = 3
        End If

        Return cas
    End Function
    Function AssignationDimensions() As Integer

        If CheckBox_d.Checked = True Then
            If cas = 1 Then
                r = 0
                w = TextBox_w.Text
                h = TextBox_h.Text
                DD = TextBox_DD.Text
                d = 0
            ElseIf cas = 2 Then
                DD = 0
                w = TextBox_w.Text
                h = TextBox_h.Text
                r = TextBox_r.Text
                d = 0
            ElseIf cas = 3 Then
                DD = 0
                w = TextBox_w.Text
                h = TextBox_h.Text
                r = TextBox_r.Text
                d = 0
            End If


        ElseIf CheckBox_w.Checked = True Then
            If cas = 1 Then
                r = 0
                w = 0
                h = TextBox_h.Text
                DD = TextBox_DD.Text
                d = 0
            ElseIf cas = 2 Then
                DD = 0
                w = 0
                h = TextBox_h.Text
                r = TextBox_r.Text
                d = TextBox_d.Text
            ElseIf cas = 3 Then
                DD = 0
                w = 0
                h = TextBox_h.Text
                r = TextBox_r.Text
                d = TextBox_d.Text
            End If

        ElseIf CheckBox_h.Checked = True Then
            If cas = 1 Then
                r = 0
                w = TextBox_w.Text
                h = 0
                DD = TextBox_DD.Text
                d = 0
            ElseIf cas = 2 Then
                DD = 0
                w = TextBox_w.Text
                h = 0
                r = TextBox_r.Text
                d = TextBox_d.Text
            ElseIf cas = 3 Then
                DD = 0
                w = TextBox_w.Text
                h = 0
                r = TextBox_r.Text
                d = TextBox_d.Text
            End If


        ElseIf CheckBox_r.Checked = True Then
            If cas = 1 Then
                r = 0
                w = TextBox_w.Text
                h = TextBox_h.Text
                DD = TextBox_DD.Text
                d = 0
            ElseIf cas = 2 Then
                DD = 0
                w = TextBox_w.Text
                h = TextBox_h.Text
                r = 0
                d = TextBox_d.Text
            ElseIf cas = 3 Then
                DD = 0
                w = TextBox_w.Text
                h = TextBox_h.Text
                r = 0
                d = TextBox_d.Text
            End If

        ElseIf CheckBox_DD.Checked = True Then
            If cas = 1 Then
                r = 0
                w = TextBox_w.Text
                h = TextBox_h.Text
                DD = 0
                d = 0
            ElseIf cas = 2 Then
                DD = 0
                w = TextBox_w.Text
                h = TextBox_h.Text
                r = TextBox_r.Text
                d = TextBox_d.Text
            ElseIf cas = 3 Then
                DD = 0
                w = TextBox_w.Text
                h = TextBox_h.Text
                r = TextBox_r.Text
                d = TextBox_d.Text
            End If
        End If

        Return 0
    End Function
    Function AssignationCharges() As Integer
        FAM = 0
        AFA = 0
        FFM = 0
        AFF = 0
        AmplitudeContrainte = 0
        ContrainteMoyenne = 0

        If CheckBox_Forces.Checked = True Then
            If CheckBox_FAM.Checked = True Then
                FAM = TextBox_FAM.Text
                Charge_A = 1
            End If
            If CheckBox_AFM.Checked = True Then
                AFA = TextBox_AFA.Text
                Charge_A = 1
            End If
            If CheckBox_FFM.Checked = True Then
                FFM = TextBox_FFM.Text
                Charge_F = 1
                DistanceFlex = TextBox_DistanceFlex.Text
            End If
            If CheckBox_AFF.Checked = True Then
                AFF = TextBox_AFF.Text
                Charge_F = 1
                DistanceFlex = TextBox_DistanceFlex.Text
            End If
        End If

        If CheckBox_Contraintes.Checked = True Then
            If CheckBox_AC.Checked = True Then
                Charge_A = 1
                AmplitudeContrainte = TextBox_AC.Text
            ElseIf CheckBox_CM.Checked = True Then
                ContrainteMoyenne = TextBox_CM.Text
                Charge_F = 1
            End If
        End If

        If Charge_A = 1 And Charge_F = 0 Then
            Chargement = "Axial"
        End If
        If Charge_F = 1 And Charge_A = 0 Then
            Chargement = "Flexion"
        End If
        If Charge_F = 1 And Charge_A = 1 Then
            Chargement = "Axial et flexion"
        End If

        Return 0
    End Function
    Function AssignationParametres() As Integer
        'FS
        If CheckBox_VieFinie.Checked = True Then
            Vie = "Finie"
            N = TextBox_N.Text

        ElseIf CheckBox_VieInfinie.Checked = True Then
            Vie = "Infinie"
            N = 100000
        End If
        FS = TextBox_FS.Text
        'Materiau
        If CheckBox_acier.Checked = True Then
            Materiau = "Acier"
        ElseIf CheckBox_Alliage.Checked = True Then
            Materiau = "Alliage"
        ElseIf CheckBox_fonte.Checked = True Then
            Materiau = "Fonte"
        End If
        Su = TextBox_Su.Text
        Sy = TextBox_Sy.Text

        'Fiabilité
        Fiabilite = TextBox_Fiabilite.Text
        'Temperature
        Temperature = TextBox_Temperature.Text

        'fini Surface
        FiniSurface = ComboBox_Finisurface.Text
        'Kf
        kf = TextBox_kf.Text

        Return 0
    End Function
    Function Calcul_Se() As Integer
        CalculSe_prime()
        Calcul_ka()
        Calcul_kb()
        Calcul_kc()
        Calcul_kd()
        Calcul_ke()
        'kf deja assigner 
        Se = Se_prime * ka * kb * kc * kd * keE * kf

        Return 0
    End Function
    Function CalculSe_prime() As Integer
        If Materiau = "Acier" Then
            If Su <= 1400 Then
                Se_prime = 0.5 * Su
            Else
                Se_prime = 700
            End If
        ElseIf Materiau = "Alliage" Then
            If FiniSurface = "Laminé à chaud" Or FiniSurface = "Forgé" Then
                Se_prime = 0.4 * Su
            Else
                Se_prime = 0.3 * Su
            End If
        ElseIf Materiau = "Fonte" Then
            Se_prime = 0.4 * Su
        End If
        Return 0
    End Function
    Function Calcul_ka() As Integer
        If FiniSurface = "Poli" Then
            ka = 1
        End If

        If FiniSurface = "Meulé" Then
            ka = 0.9
        End If

        If FiniSurface = "Usiné ou écrouit" Then
            ka = (-2 * 10 ^ -10) * (Su ^ 3) + (9 * 10 ^ -7) * (Su ^ 2) - (0.0012 * Su) + 1.1991
        End If

        If FiniSurface = "Laminé à chaud" Then
            ka = (-9 * 10 ^ -11) * (Su ^ 3) + (5 * 10 ^ -7) * (Su ^ 2) - 0.001 * Su + 1.0378
        End If

        If FiniSurface = "Forgé" Then
            ka = (-1 * 10 ^ -10) * (Su ^ 3) + (6 * 10 ^ -7) * (Su ^ 2) - (0.001 * Su) + 0.8637
        End If

        Return 0
    End Function
    Function Calcul_kb() As Integer
        If cas = 1 Then
            If w - DD <= 7.6 Then
                kb = 1
            ElseIf w - DD > 7.6 And w - DD <= 50 Then
                kb = 0.85
            ElseIf w - DD > 50 Then
                kb = 0.75
            End If

        ElseIf cas = 2 Or cas = 3 Then
            If d <= 7.6 Then
                kb = 1
            ElseIf d > 7.6 And d <= 50 Then
                kb = 0.85
            ElseIf d > 50 Then
                kb = 0.75
            End If
        End If

        Return 0
    End Function
    Function Calcul_kc() As Integer
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

        If Fiabilite >= Donnees(10, 0) Then
            kc = 1

        End If

        If Fiabilite <= Donnees(0, 0) Then
            kc = 0.5
        End If

        For i As Integer = 0 To 10
            If Fiabilite = Donnees(i, 0) Then
                kc = Donnees(i, 1)
            End If

            If Fiabilite > Donnees(i, 0) And Fiabilite < Donnees((i + 1), 0) Then
                kc = ((Donnees((i + 1), 1) - Donnees(i, 1)) * (Fiabilite - Donnees(i, 0))) / (Donnees(i + 1, 0) - Donnees(i, 0)) + Donnees(i, 1)
            End If
        Next

        Return 0
    End Function
    Function Calcul_kd() As Integer

        If Temperature > 71 Then
            kd = (344 / (273 + Temperature))

        ElseIf Temperature <= 71 Then
            kd = 1

        End If

        Return 0
    End Function
    Function Calcul_ke() As Integer
        Dim ke As Double = 0.1234
        Dim rayonEntaille As Double = 0.1234

        If cas = 2 Or cas = 3 Then
            rayonEntaille = r
        Else
            rayonEntaille = 1
        End If

        Dim q As Double = 0.1234
        Dim kt2 As Double = 0.1234
        Dim kf2 As Double = 0.1234
        kt2 = Kt_g

        If Materiau = "Alliage" Then
            q = 0.28 * Log(rayonEntaille) + 0.5562

            If rayonEntaille > 5 Then
                q = 1
            End If

            kf2 = q * (kt2 - 1) + 1

        ElseIf Materiau = "Acier" Then
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
            Dim ratio = Su
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

            If rayonEntaille > 5 Then 'page 62
                q = 1
            End If

            kf2 = q * (kt2 - 1) + 1

        ElseIf Materiau = "Fonte" Then 'pire des cas avec ASTM n50
            kf2 = 1.25

        Else
            kf2 = 1
        End If

        If cas = 1 Then
            q = 1
            kf2 = q * (kt2 - 1) + 1
        End If

        keE = 1 / kf2

        Return 0
    End Function
    Function RechercheParametre_i() As Integer

        If CheckBox_d.Checked = True Then
            d = Parametre_i

        ElseIf CheckBox_w.Checked = True Then
            w = Parametre_i

        ElseIf CheckBox_h.Checked = True Then
            h = Parametre_i

        ElseIf CheckBox_r.Checked = True Then
            r = Parametre_i

        ElseIf CheckBox_DD.Checked = True Then
            DD = Parametre_i

        End If

        Return 0
    End Function
    Function Calcul_Kt() As Double
        Dim kta As Double = 1
        Dim ktf As Double = 1
        If cas = 1 Then
            Dim d_w = d / w
            Dim d_h = d / h

            If Chargement = "Axial" Then 'cas 1

                kta = 1.7262 * (d_w) ^ 2 - 2.4493 * d_w + 2.954

            ElseIf Chargement = "Flexion" Then 'cas 2
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

            ElseIf Chargement = "Axial et flexion" Then 'cas 1 et 2
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

        ElseIf cas = 2 Then
            Dim w_d = w / d
            Dim r_d = r / d


            If Chargement = "Axial" Then 'cas 3
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

            ElseIf Chargement = "Flexion" Then 'cas 4
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
            ElseIf Chargement = "Axial et flexion" Then 'cas 5 et 6
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

        ElseIf cas = 3 Then
            Dim D_d = DD / d
            Dim r_d = r / d

            If Chargement = "Axial" Then 'cas 5
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

            ElseIf Chargement = "Flexion" Then 'cas 6
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

            ElseIf Chargement = "Axial et flexion" Then 'cas 5 et 6
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

        Kta_g = kta
        Ktf_g = ktf

        Return 0
    End Function
    Function Calcul_Contraintes() As Integer
        Dim sigma_Am As Double = 0
        Dim sigma_Aa As Double = 0
        Dim sigma_Fm As Double = 0
        Dim sigma_Fa As Double = 0
        Dim sigma_A As Double = 0
        Dim sigma_M As Double = 0
        Dim c As Double = 0

        If cas = 1 Then
            Surface = (w - DD) * h
            Inertie = ((w - DD) * h ^ 3) / 12
            c = h / 2
        ElseIf cas = 2 Then
            Surface = d * h
            Inertie = (h * d ^ 3) / 12
            c = d / 2
        ElseIf cas = 3 Then
            Surface = d * h
            Inertie = (h * d ^ 3) / 12
            c = d / 2
        End If

        If CheckBox_Forces.Checked = True Then
            If Chargement = "Axial" Then
                sigma_Aa = AFA / Surface
                sigma_Am = FAM / Surface
            ElseIf Chargement = "Flexion" Then
                sigma_Fa = ((AFF * DistanceFlex) * c) / Inertie
                sigma_Fm = ((FFM * DistanceFlex) * c) / Inertie
            ElseIf Chargement = "Axial et flexion" Then
                sigma_Aa = AFA / Surface
                sigma_Am = FAM / Surface
                sigma_Fa = ((AFF * DistanceFlex) * c) / Inertie
                sigma_Fm = ((FFM * DistanceFlex) * c) / Inertie
            End If

            sigma_A = sigma_Aa + sigma_Fa
            sigma_M = sigma_Am + sigma_Fm

        ElseIf CheckBox_contraintes.Checked = True Then
            sigma_A = AmplitudeContrainte
            sigma_M = ContrainteMoyenne

        End If

        AmplitudeContrainte = sigma_A
        ContrainteMoyenne = sigma_M
        Return 0
    End Function
    Function Calcul_Sf() As Integer
        Sf = 0.9 * Su * (Se / (0.9 * Su)) ^ ((1 / 3) * (Log10(N) - 3))
        Return 0
    End Function
    Function Calcul_FSi() As Integer
        Dim S As Double = 0

        If Vie = "Finie" Then
            Calcul_Sf()
            S = Sf
        ElseIf Vie = "Infinie" Then
            S = Se
        End If

        FS_i_Fat = 1 / ((AmplitudeContrainte / S) + (ContrainteMoyenne / Su))

        FS_i_Stat = Sy / (AmplitudeContrainte + ContrainteMoyenne)

        If FS_i_Fat < FS_i_Stat Then
            FS_i = FS_i_Fat
        Else
            FS_i = FS_i_Stat
        End If

        Return 0
    End Function
    Function AffichageParametre_i() As Integer

        If CheckBox_d.Checked = True Then
            Label_Dim_manquant.Text = "d:"
        ElseIf CheckBox_w.Checked = True Then
            Label_Dim_manquant.Text = "w:"
        ElseIf CheckBox_h.Checked = True Then
            Label_Dim_manquant.Text = "h:"
        ElseIf CheckBox_r.Checked = True Then
            Label_Dim_manquant.Text = "r:"
        ElseIf CheckBox_DD.Checked = True Then
            Label_Dim_manquant.Text = "D:"
        End If

        Label_parametre_i.Text = Parametre_i.ToString(".000000")
        Return 0
    End Function
    Private Sub CheckBox_cas1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_cas1.CheckedChanged
        If CheckBox_cas1.Checked = True Then
            PictureBox_cas1.BringToFront()
            Panel_Image.Visible = True
            CheckBox_cas2.Checked = False
            CheckBox_cas3.Checked = False

            CheckBox_d.Visible = False
            TextBox_d.Visible = False
            CheckBox_r.Visible = False
            TextBox_r.Visible = False

            CheckBox_w.Visible = True
            TextBox_w.Visible = True
            CheckBox_h.Visible = True
            TextBox_h.Visible = True
            CheckBox_DD.Visible = True
            TextBox_DD.Visible = True
        End If
    End Sub
    Private Sub CheckBox_cas2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_cas2.CheckedChanged
        If CheckBox_cas2.Checked = True Then
            PictureBox_cas2.BringToFront()
            Panel_Image.Visible = True
            CheckBox_cas1.Checked = False
            CheckBox_cas3.Checked = False

            CheckBox_DD.Visible = False
            TextBox_DD.Visible = False

            CheckBox_d.Visible = True
            TextBox_d.Visible = True
            CheckBox_r.Visible = True
            TextBox_r.Visible = True
            CheckBox_w.Visible = True
            TextBox_w.Visible = True
            CheckBox_h.Visible = True
            TextBox_h.Visible = True

        End If
    End Sub
    Private Sub CheckBox_cas3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_cas3.CheckedChanged
        If CheckBox_cas3.Checked = True Then
            PictureBox_cas3.BringToFront()
            Panel_Image.Visible = True
            CheckBox_cas1.Checked = False
            CheckBox_cas2.Checked = False

            CheckBox_DD.Visible = False
            TextBox_DD.Visible = False
            CheckBox_d.Visible = True
            TextBox_d.Visible = True
            CheckBox_r.Visible = True
            TextBox_r.Visible = True
            CheckBox_w.Visible = True
            TextBox_w.Visible = True
            CheckBox_h.Visible = True
            TextBox_h.Visible = True
        End If
    End Sub
    Private Sub CheckBox_w_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_w.CheckedChanged
        If CheckBox_w.Checked = True Then
            CheckBox_d.Checked = False
            CheckBox_DD.Checked = False
            CheckBox_r.Checked = False
            CheckBox_h.Checked = False

            TextBox_w.Visible = False
        End If
    End Sub
    Private Sub CheckBox_d_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_d.CheckedChanged
        If CheckBox_d.Checked = True Then
            CheckBox_w.Checked = False
            CheckBox_DD.Checked = False
            CheckBox_r.Checked = False
            CheckBox_h.Checked = False

            TextBox_d.Visible = False
        End If
    End Sub
    Private Sub CheckBox_DD_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_DD.CheckedChanged
        If CheckBox_DD.Checked = True Then
            CheckBox_w.Checked = False
            CheckBox_d.Checked = False
            CheckBox_r.Checked = False
            CheckBox_h.Checked = False

            TextBox_DD.Visible = False
        End If
    End Sub
    Private Sub CheckBox_r_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_r.CheckedChanged
        If CheckBox_r.Checked = True Then
            CheckBox_w.Checked = False
            CheckBox_d.Checked = False
            CheckBox_DD.Checked = False
            CheckBox_h.Checked = False

            TextBox_r.Visible = False
        End If
    End Sub
    Private Sub CheckBox_h_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_h.CheckedChanged
        If CheckBox_h.Checked = True Then
            CheckBox_w.Checked = False
            CheckBox_d.Checked = False
            CheckBox_DD.Checked = False
            CheckBox_r.Checked = False

            TextBox_h.Visible = False
        End If
    End Sub
    Private Sub CheckBox_Forces_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_Forces.CheckedChanged
        If CheckBox_Forces.Checked = True Then
            CheckBox_Contraintes.Checked = False

            CheckBox_FAM.Visible = True
            CheckBox_AFM.Visible = True
            CheckBox_FFM.Visible = True
            CheckBox_AFF.Visible = True
            CheckBox_CM.Visible = False
            CheckBox_AC.Visible = False
        End If
    End Sub
    Private Sub CheckBox_Contraintes_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_Contraintes.CheckedChanged
        If CheckBox_Contraintes.Checked = True Then
            CheckBox_Forces.Checked = False
            CheckBox_FAM.Visible = False
            CheckBox_AFM.Visible = False
            CheckBox_FFM.Visible = False
            CheckBox_AFF.Visible = False
            CheckBox_CM.Visible = True
            CheckBox_AC.Visible = True
        End If
    End Sub
    Private Sub CheckBox_FAM_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_FAM.CheckedChanged
        If CheckBox_FAM.Checked = True Then
            TextBox_FAM.Visible = True
        End If


    End Sub
    Private Sub CheckBox_AFM_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_AFM.CheckedChanged
        If CheckBox_AFM.Checked = True Then
            TextBox_AFA.Visible = True
        End If


    End Sub
    Private Sub CheckBox_FFM_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_FFM.CheckedChanged
        If CheckBox_FFM.Checked = True Then
            TextBox_FFM.Visible = True
            Label_dist_flex.Visible = True
            TextBox_DistanceFlex.Visible = True
        End If

    End Sub
    Private Sub CheckBox_AFF_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_AFF.CheckedChanged
        If CheckBox_AFF.Checked = True Then
            TextBox_AFF.Visible = True
            Label_dist_flex.Visible = True
            TextBox_DistanceFlex.Visible = True
        End If
    End Sub
    Private Sub CheckBox_CM_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_CM.CheckedChanged
        If CheckBox_CM.Checked = True Then
            TextBox_CM.Visible = True
        End If
    End Sub
    Private Sub CheckBox_AC_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_AC.CheckedChanged
        If CheckBox_AC.Checked = True Then
            TextBox_AC.Visible = True
        End If
    End Sub
    Private Sub CheckBox_VieFinie_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_VieFinie.CheckedChanged
        If CheckBox_VieFinie.Checked = True Then
            CheckBox_VieInfinie.Checked = False
            Label_N.Visible = True
            TextBox_N.Visible = True
        End If
    End Sub
    Private Sub CheckBox_VieInFinie_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_VieInfinie.CheckedChanged
        If CheckBox_VieInfinie.Checked = True Then
            CheckBox_VieFinie.Checked = False
            Label_N.Visible = False
            TextBox_N.Visible = False
        End If
    End Sub
    Private Sub CheckBox_acier_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_acier.CheckedChanged
        If CheckBox_acier.Checked = True Then
            CheckBox_fonte.Checked = False
            CheckBox_Alliage.Checked = False
        End If
    End Sub
    Private Sub CheckBox_fonte_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_fonte.CheckedChanged
        If CheckBox_fonte.Checked = True Then
            CheckBox_acier.Checked = False
            CheckBox_Alliage.Checked = False
        End If
    End Sub
    Private Sub CheckBox_alliage_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_Alliage.CheckedChanged
        If CheckBox_Alliage.Checked = True Then
            CheckBox_acier.Checked = False
            CheckBox_fonte.Checked = False
        End If
    End Sub
    Private Sub TextBox_Fiabilité_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox_Fiabilite.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ",")
        End If
    End Sub
    Private Sub TextBox_kf_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox_kf.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ",")
        End If
    End Sub
    Private Sub TextBox_temperature_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox_Temperature.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ",")
        End If
    End Sub
    Private Sub TextBox_Su_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox_Su.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ",")
        End If
    End Sub
    Private Sub TextBox_Sy_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox_Sy.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ",")
        End If
    End Sub
    Private Sub TextBox_N_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox_N.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ",")
        End If
    End Sub
    Private Sub TextBox_FS_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox_FS.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ",")
        End If
    End Sub
    Private Sub TextBox_w_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox_w.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ",")
        End If
    End Sub
    Private Sub TextBox_d_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox_d.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ",")
        End If
    End Sub
    Private Sub TextBox_h_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox_h.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ",")
        End If
    End Sub
    Private Sub TextBox_DD_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox_DD.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ",")
        End If
    End Sub
    Private Sub TextBox_r_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox_r.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ",")
        End If
    End Sub
    Private Sub TextBox_FAM_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox_FAM.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ",")
        End If
    End Sub
    Private Sub TextBox_FFM_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox_FFM.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ",")
        End If
    End Sub
    Private Sub TextBox_AFA_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox_AFA.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ",")
        End If
    End Sub
    Private Sub TextBox_AFF_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox_AFF.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ",")
        End If
    End Sub
    Private Sub TextBox_CM_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox_CM.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ",")
        End If
    End Sub
    Private Sub TextBox_AC_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox_AC.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ",")
        End If
    End Sub
End Class



