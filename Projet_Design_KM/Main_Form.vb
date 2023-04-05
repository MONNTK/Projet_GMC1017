
Public Class Main_Form

    Private Sub Choix_Materiau_Click(sender As Object, e As EventArgs) Handles Choix_Materiau.Click
        Label_Fenetre.Text = "Matériau"
        With Materiau  'code pour pop la nouvelle fenêtre (form 2)
            .TopLevel = False
            MainPanel.Controls.Add(Materiau)
            .BringToFront()
            .Show()
        End With
        Panel_menu.Hide()
    End Sub
    Private Sub Geometrie_Click(sender As Object, e As EventArgs) Handles Geometrie.Click
        Label_Fenetre.Text = "Géométrie"
        With Geometrie_Form  'code pour pop la nouvelle fenêtre (form 2)
            .TopLevel = False
            MainPanel.Controls.Add(Geometrie_Form)
            .BringToFront()
            .Show()
        End With
        Panel_menu.Hide()
    End Sub
    Private Sub Efforts_Click(sender As Object, e As EventArgs) Handles Efforts.Click
        Label_Fenetre.Text = "Efforts"
        With Efforts_Form  'code pour pop la nouvelle fenêtre (form 2)
            .TopLevel = False
            MainPanel.Controls.Add(Efforts_Form)
            .BringToFront()
            .Show()
        End With
        Panel_menu.Hide()
    End Sub

    Private Sub Calcul_Click(sender As Object, e As EventArgs) Handles Calcul.Click
        Label_Fenetre.Text = "Calcul"
        With Calcul_Form  'code pour pop la nouvelle fenêtre (form 2)
            .TopLevel = False
            MainPanel.Controls.Add(Calcul_Form)
            .BringToFront()
            .Show()
        End With
        Panel_menu.Hide()
    End Sub

    Private Sub Sortie_Click(sender As Object, e As EventArgs) Handles Sortie.Click
        Application.Exit()
    End Sub

    Private Sub Button_Menu_Click(sender As Object, e As EventArgs) Handles Button_Menu.Click
        Label_Fenetre.Text = "Menu principal"
        Panel_menu.BringToFront()
        Panel_menu.Show()
    End Sub

    Private Sub Main_Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Label_Fenetre.Text = "Menu principal"
        Panel_menu.BringToFront()
        Panel_menu.Show()
    End Sub
    Public Sub Button_FS_N_Click(sender As Object, e As EventArgs) Handles Button_FS_N.Click
        Label_Fenetre.Text = "Matériau"
        With Materiau
            .TopLevel = False
            MainPanel.Controls.Add(Materiau)
            .BringToFront()
            .Show()
        End With
        Panel_menu.Hide()
    End Sub

    Private Sub ButtonDim_Click(sender As Object, e As EventArgs) Handles Button_dim.Click
        Label_Fenetre.Text = "Dimensionnement"
        With Dimensionnement
            .TopLevel = False
            MainPanel.Controls.Add(Dimensionnement)
            .BringToFront()
            .Show()
        End With

        Panel_menu.Hide()
    End Sub

    Private Sub Button_dimensionnement_Click(sender As Object, e As EventArgs) Handles Button_dimensionnement.Click
        Label_Fenetre.Text = "Dimensionnement"
        With Dimensionnement
            .TopLevel = False
            MainPanel.Controls.Add(Dimensionnement)
            .BringToFront()
            .Show()
        End With

        Panel_menu.Hide()
    End Sub
End Class

Public Class GlobalVariables

    Public Shared TypeMateriau As String = "Aucun sélectionné"
    Public Shared NatureMateriau As String = "Aucun sélectionné"
    Public Shared TypeContrainte As String = "Aucun sélectionné"
    Public Shared AppContrainte As String = "Aucun sélectionné"
    Public Shared FiniSurface As String = "Aucun sélectionné"
    Public Shared Temperature As String = "Aucun sélectionné"
    Public Shared Fiabilité As String = "Aucun sélectionné"

    Public Shared rayonEntaille As Double = 0
    Public Shared kta As Double = 0
    Public Shared ktf As Double = 0
    Public Shared ka As Double = 0
    Public Shared kb As Double = 0
    Public Shared kc As Double = 0
    Public Shared kd As Double = 0
    Public Shared ke As Double = 0
    Public Shared kf As Double = 0

    Public Shared Sy As Double = 0
    Public Shared Sut As Double = 0
    Public Shared Suc As Double = 0
    Public Shared SeEchantillon As Double = 0    'Se'
    Public Shared SePiece As Double = 0
    Public Shared SfEchantillon As Double = 0    'Sf'
    Public Shared SfPiece As Double = 0
    Public Shared Se_prime As Double = 0
    Public Shared Se As Double = 0
    Public Shared N As Double = 0 'NB de cycles

    Public Shared Fa As Double = 0
    Public Shared Fm As Double = 0
    Public Shared Ma As Double = 0
    Public Shared Mm As Double = 0

    Public Shared SigmaAmplitude As Double = 0 ' Amplitude de la contrainte
    Public Shared SigmaMoyen As Double = 0 ' Contrainte moyenne
    Public Shared SigmaAmplitudeFlex As Double = 0 ' Amplitude de la contrainte
    Public Shared SigmaMoyenFlex As Double = 0 ' Contrainte moyenne

    Public Shared Geometrie As String = "Aucun sélectionné"
    Public Shared d As Double = 0

    Public Shared d_w As Double = 0 'pour plaque trou
    Public Shared d_h As Double = 0
    Public Shared w_d As Double = 0
    Public Shared r_d As Double = 0
    Public Shared D_d As Double = 0

    Public Shared surface As Double = 0
    Public Shared Inertie As Double = 0
    Public Shared c As Double = 0

End Class