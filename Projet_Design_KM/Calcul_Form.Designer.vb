<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calcul_Form
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.B_Calculer = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox_fiabilite = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox_FSdesire = New System.Windows.Forms.TextBox()
        Me.CheckBox_DeterminerN = New System.Windows.Forms.CheckBox()
        Me.CheckBox_DeterminerFS = New System.Windows.Forms.CheckBox()
        Me.Label_FStag = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button_Valider = New System.Windows.Forms.Button()
        Me.Label_Fiabilité = New System.Windows.Forms.Label()
        Me.Label_Temp = New System.Windows.Forms.Label()
        Me.Label_FiniSurf = New System.Windows.Forms.Label()
        Me.Label_AppContrainte = New System.Windows.Forms.Label()
        Me.Label_Contrainte = New System.Windows.Forms.Label()
        Me.Label_NatureMat = New System.Windows.Forms.Label()
        Me.Label_TypeMat = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox_Donnees = New System.Windows.Forms.GroupBox()
        Me.TextBox_kf = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label_Sy = New System.Windows.Forms.Label()
        Me.Label_Suc = New System.Windows.Forms.Label()
        Me.Label_Sut = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label_ka = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label_kb = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label_kc = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label_kd = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label_ke = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label_kf = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Panel_stat = New System.Windows.Forms.Panel()
        Me.Label_stat_FS = New System.Windows.Forms.Label()
        Me.Label_stat_sigma = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Panel_FATIGUE = New System.Windows.Forms.Panel()
        Me.Label_fs_fat = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label_fs_stat = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label_stat_N = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label_fat_sigmaM = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label_fat_FS = New System.Windows.Forms.Label()
        Me.Label_fat_sigmaA = New System.Windows.Forms.Label()
        Me.Label_FSfat = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label_q = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label_kt_deKe = New System.Windows.Forms.Label()
        Me.Panel_test = New System.Windows.Forms.Panel()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label_kt_axiale = New System.Windows.Forms.Label()
        Me.Label_kt_flexion = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label_d_w = New System.Windows.Forms.Label()
        Me.Label_d_h = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label_D_d = New System.Windows.Forms.Label()
        Me.Label_w_d = New System.Windows.Forms.Label()
        Me.Label_r_d = New System.Windows.Forms.Label()
        Me.Label_55 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label_se = New System.Windows.Forms.Label()
        Me.Label_se_prime = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox_Donnees.SuspendLayout()
        Me.Panel_stat.SuspendLayout()
        Me.Panel_FATIGUE.SuspendLayout()
        Me.SuspendLayout()
        '
        'B_Calculer
        '
        Me.B_Calculer.Location = New System.Drawing.Point(1136, 563)
        Me.B_Calculer.Name = "B_Calculer"
        Me.B_Calculer.Size = New System.Drawing.Size(122, 54)
        Me.B_Calculer.TabIndex = 1
        Me.B_Calculer.Text = "Calculer"
        Me.B_Calculer.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(533, 658)
        Me.Panel1.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox_fiabilite)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.TextBox_FSdesire)
        Me.GroupBox2.Controls.Add(Me.CheckBox_DeterminerN)
        Me.GroupBox2.Controls.Add(Me.CheckBox_DeterminerFS)
        Me.GroupBox2.Controls.Add(Me.Label_FStag)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(501, 174)
        Me.GroupBox2.TabIndex = 32
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Objectifs de calcul"
        '
        'TextBox_fiabilite
        '
        Me.TextBox_fiabilite.Location = New System.Drawing.Point(154, 132)
        Me.TextBox_fiabilite.Name = "TextBox_fiabilite"
        Me.TextBox_fiabilite.Size = New System.Drawing.Size(125, 27)
        Me.TextBox_fiabilite.TabIndex = 8
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(31, 135)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(117, 20)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Fiabilité requise:"
        '
        'TextBox_FSdesire
        '
        Me.TextBox_FSdesire.Location = New System.Drawing.Point(329, 72)
        Me.TextBox_FSdesire.Name = "TextBox_FSdesire"
        Me.TextBox_FSdesire.Size = New System.Drawing.Size(125, 27)
        Me.TextBox_FSdesire.TabIndex = 6
        '
        'CheckBox_DeterminerN
        '
        Me.CheckBox_DeterminerN.AutoSize = True
        Me.CheckBox_DeterminerN.Location = New System.Drawing.Point(252, 33)
        Me.CheckBox_DeterminerN.Name = "CheckBox_DeterminerN"
        Me.CheckBox_DeterminerN.Size = New System.Drawing.Size(174, 24)
        Me.CheckBox_DeterminerN.TabIndex = 5
        Me.CheckBox_DeterminerN.Text = "Déterminer N (cycles)"
        Me.CheckBox_DeterminerN.UseVisualStyleBackColor = True
        '
        'CheckBox_DeterminerFS
        '
        Me.CheckBox_DeterminerFS.AutoSize = True
        Me.CheckBox_DeterminerFS.Location = New System.Drawing.Point(74, 33)
        Me.CheckBox_DeterminerFS.Name = "CheckBox_DeterminerFS"
        Me.CheckBox_DeterminerFS.Size = New System.Drawing.Size(125, 24)
        Me.CheckBox_DeterminerFS.TabIndex = 4
        Me.CheckBox_DeterminerFS.Text = "Déterminer FS"
        Me.CheckBox_DeterminerFS.UseVisualStyleBackColor = True
        '
        'Label_FStag
        '
        Me.Label_FStag.AutoSize = True
        Me.Label_FStag.Location = New System.Drawing.Point(252, 75)
        Me.Label_FStag.Name = "Label_FStag"
        Me.Label_FStag.Size = New System.Drawing.Size(71, 20)
        Me.Label_FStag.TabIndex = 3
        Me.Label_FStag.Text = "FS désiré:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button_Valider)
        Me.GroupBox1.Controls.Add(Me.Label_Fiabilité)
        Me.GroupBox1.Controls.Add(Me.Label_Temp)
        Me.GroupBox1.Controls.Add(Me.Label_FiniSurf)
        Me.GroupBox1.Controls.Add(Me.Label_AppContrainte)
        Me.GroupBox1.Controls.Add(Me.Label_Contrainte)
        Me.GroupBox1.Controls.Add(Me.Label_NatureMat)
        Me.GroupBox1.Controls.Add(Me.Label_TypeMat)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 183)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(501, 434)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Paramètres sélectionnés"
        '
        'Button_Valider
        '
        Me.Button_Valider.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button_Valider.Location = New System.Drawing.Point(3, 377)
        Me.Button_Valider.Name = "Button_Valider"
        Me.Button_Valider.Size = New System.Drawing.Size(495, 54)
        Me.Button_Valider.TabIndex = 3
        Me.Button_Valider.Text = "Valider"
        Me.Button_Valider.UseVisualStyleBackColor = True
        '
        'Label_Fiabilité
        '
        Me.Label_Fiabilité.AutoSize = True
        Me.Label_Fiabilité.Location = New System.Drawing.Point(206, 290)
        Me.Label_Fiabilité.Name = "Label_Fiabilité"
        Me.Label_Fiabilité.Size = New System.Drawing.Size(62, 20)
        Me.Label_Fiabilité.TabIndex = 15
        Me.Label_Fiabilité.Text = "Fiabilité"
        '
        'Label_Temp
        '
        Me.Label_Temp.AutoSize = True
        Me.Label_Temp.Location = New System.Drawing.Point(206, 247)
        Me.Label_Temp.Name = "Label_Temp"
        Me.Label_Temp.Size = New System.Drawing.Size(93, 20)
        Me.Label_Temp.TabIndex = 14
        Me.Label_Temp.Text = "Température"
        '
        'Label_FiniSurf
        '
        Me.Label_FiniSurf.AutoSize = True
        Me.Label_FiniSurf.Location = New System.Drawing.Point(206, 206)
        Me.Label_FiniSurf.Name = "Label_FiniSurf"
        Me.Label_FiniSurf.Size = New System.Drawing.Size(104, 20)
        Me.Label_FiniSurf.TabIndex = 13
        Me.Label_FiniSurf.Text = "Fini de surface"
        '
        'Label_AppContrainte
        '
        Me.Label_AppContrainte.AutoSize = True
        Me.Label_AppContrainte.Location = New System.Drawing.Point(206, 160)
        Me.Label_AppContrainte.Name = "Label_AppContrainte"
        Me.Label_AppContrainte.Size = New System.Drawing.Size(190, 20)
        Me.Label_AppContrainte.TabIndex = 12
        Me.Label_AppContrainte.Text = "Application des contraintes"
        '
        'Label_Contrainte
        '
        Me.Label_Contrainte.AutoSize = True
        Me.Label_Contrainte.Location = New System.Drawing.Point(206, 118)
        Me.Label_Contrainte.Name = "Label_Contrainte"
        Me.Label_Contrainte.Size = New System.Drawing.Size(138, 20)
        Me.Label_Contrainte.TabIndex = 11
        Me.Label_Contrainte.Text = "Type de contraintes"
        '
        'Label_NatureMat
        '
        Me.Label_NatureMat.AutoSize = True
        Me.Label_NatureMat.Location = New System.Drawing.Point(206, 76)
        Me.Label_NatureMat.Name = "Label_NatureMat"
        Me.Label_NatureMat.Size = New System.Drawing.Size(138, 20)
        Me.Label_NatureMat.TabIndex = 10
        Me.Label_NatureMat.Text = "Nature du matériau"
        '
        'Label_TypeMat
        '
        Me.Label_TypeMat.AutoSize = True
        Me.Label_TypeMat.Location = New System.Drawing.Point(206, 36)
        Me.Label_TypeMat.Name = "Label_TypeMat"
        Me.Label_TypeMat.Size = New System.Drawing.Size(124, 20)
        Me.Label_TypeMat.TabIndex = 9
        Me.Label_TypeMat.Text = "Type de matériau"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 290)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 20)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Fiabilité désirée:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 247)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 20)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Température:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 206)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 20)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Fini de surface:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(193, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Application des contraintes:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Type de contraintes:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nature du matériau:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Type de matériau:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel2.Controls.Add(Me.GroupBox_Donnees)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(533, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(767, 98)
        Me.Panel2.TabIndex = 3
        '
        'GroupBox_Donnees
        '
        Me.GroupBox_Donnees.Controls.Add(Me.TextBox_kf)
        Me.GroupBox_Donnees.Controls.Add(Me.Label1)
        Me.GroupBox_Donnees.Controls.Add(Me.Label_Sy)
        Me.GroupBox_Donnees.Controls.Add(Me.Label_Suc)
        Me.GroupBox_Donnees.Controls.Add(Me.Label_Sut)
        Me.GroupBox_Donnees.Controls.Add(Me.Label11)
        Me.GroupBox_Donnees.Controls.Add(Me.Label10)
        Me.GroupBox_Donnees.Controls.Add(Me.Label9)
        Me.GroupBox_Donnees.Location = New System.Drawing.Point(6, 3)
        Me.GroupBox_Donnees.Name = "GroupBox_Donnees"
        Me.GroupBox_Donnees.Size = New System.Drawing.Size(749, 87)
        Me.GroupBox_Donnees.TabIndex = 0
        Me.GroupBox_Donnees.TabStop = False
        Me.GroupBox_Donnees.Text = "Données entrées"
        '
        'TextBox_kf
        '
        Me.TextBox_kf.Location = New System.Drawing.Point(575, 51)
        Me.TextBox_kf.Name = "TextBox_kf"
        Me.TextBox_kf.Size = New System.Drawing.Size(125, 27)
        Me.TextBox_kf.TabIndex = 32
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(502, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 20)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Entrer kf:"
        '
        'Label_Sy
        '
        Me.Label_Sy.AutoSize = True
        Me.Label_Sy.Location = New System.Drawing.Point(170, 23)
        Me.Label_Sy.Name = "Label_Sy"
        Me.Label_Sy.Size = New System.Drawing.Size(48, 20)
        Me.Label_Sy.TabIndex = 21
        Me.Label_Sy.Text = "x MPa"
        '
        'Label_Suc
        '
        Me.Label_Suc.AutoSize = True
        Me.Label_Suc.Location = New System.Drawing.Point(42, 50)
        Me.Label_Suc.Name = "Label_Suc"
        Me.Label_Suc.Size = New System.Drawing.Size(48, 20)
        Me.Label_Suc.TabIndex = 20
        Me.Label_Suc.Text = "x MPa"
        '
        'Label_Sut
        '
        Me.Label_Sut.AutoSize = True
        Me.Label_Sut.Location = New System.Drawing.Point(42, 23)
        Me.Label_Sut.Name = "Label_Sut"
        Me.Label_Sut.Size = New System.Drawing.Size(48, 20)
        Me.Label_Sut.TabIndex = 19
        Me.Label_Sut.Text = "x MPa"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(140, 23)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 20)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Sy="
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 50)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 20)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Suc="
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 20)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Sut="
        '
        'Label_ka
        '
        Me.Label_ka.AutoSize = True
        Me.Label_ka.Location = New System.Drawing.Point(571, 106)
        Me.Label_ka.Name = "Label_ka"
        Me.Label_ka.Size = New System.Drawing.Size(16, 20)
        Me.Label_ka.TabIndex = 23
        Me.Label_ka.Text = "x"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(541, 106)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(34, 20)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "ka="
        '
        'Label_kb
        '
        Me.Label_kb.AutoSize = True
        Me.Label_kb.Location = New System.Drawing.Point(698, 106)
        Me.Label_kb.Name = "Label_kb"
        Me.Label_kb.Size = New System.Drawing.Size(16, 20)
        Me.Label_kb.TabIndex = 25
        Me.Label_kb.Text = "x"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(668, 106)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(35, 20)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "kb="
        '
        'Label_kc
        '
        Me.Label_kc.AutoSize = True
        Me.Label_kc.Location = New System.Drawing.Point(837, 106)
        Me.Label_kc.Name = "Label_kc"
        Me.Label_kc.Size = New System.Drawing.Size(16, 20)
        Me.Label_kc.TabIndex = 25
        Me.Label_kc.Text = "x"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(807, 106)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(33, 20)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "kc="
        '
        'Label_kd
        '
        Me.Label_kd.AutoSize = True
        Me.Label_kd.Location = New System.Drawing.Point(982, 106)
        Me.Label_kd.Name = "Label_kd"
        Me.Label_kd.Size = New System.Drawing.Size(16, 20)
        Me.Label_kd.TabIndex = 27
        Me.Label_kd.Text = "x"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(952, 106)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(35, 20)
        Me.Label17.TabIndex = 26
        Me.Label17.Text = "kd="
        '
        'Label_ke
        '
        Me.Label_ke.AutoSize = True
        Me.Label_ke.Location = New System.Drawing.Point(1104, 106)
        Me.Label_ke.Name = "Label_ke"
        Me.Label_ke.Size = New System.Drawing.Size(16, 20)
        Me.Label_ke.TabIndex = 29
        Me.Label_ke.Text = "x"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(1074, 106)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(34, 20)
        Me.Label19.TabIndex = 28
        Me.Label19.Text = "ke="
        '
        'Label_kf
        '
        Me.Label_kf.AutoSize = True
        Me.Label_kf.Location = New System.Drawing.Point(1210, 106)
        Me.Label_kf.Name = "Label_kf"
        Me.Label_kf.Size = New System.Drawing.Size(16, 20)
        Me.Label_kf.TabIndex = 31
        Me.Label_kf.Text = "x"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(1180, 106)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(31, 20)
        Me.Label21.TabIndex = 30
        Me.Label21.Text = "kf="
        '
        'Panel_stat
        '
        Me.Panel_stat.Controls.Add(Me.Label_stat_FS)
        Me.Panel_stat.Controls.Add(Me.Label_stat_sigma)
        Me.Panel_stat.Controls.Add(Me.Label20)
        Me.Panel_stat.Controls.Add(Me.Label18)
        Me.Panel_stat.Controls.Add(Me.Label16)
        Me.Panel_stat.Location = New System.Drawing.Point(558, 164)
        Me.Panel_stat.Name = "Panel_stat"
        Me.Panel_stat.Size = New System.Drawing.Size(334, 186)
        Me.Panel_stat.TabIndex = 32
        '
        'Label_stat_FS
        '
        Me.Label_stat_FS.AutoSize = True
        Me.Label_stat_FS.Location = New System.Drawing.Point(75, 95)
        Me.Label_stat_FS.Name = "Label_stat_FS"
        Me.Label_stat_FS.Size = New System.Drawing.Size(24, 20)
        Me.Label_stat_FS.TabIndex = 4
        Me.Label_stat_FS.Text = "FS"
        '
        'Label_stat_sigma
        '
        Me.Label_stat_sigma.AutoSize = True
        Me.Label_stat_sigma.Location = New System.Drawing.Point(75, 55)
        Me.Label_stat_sigma.Name = "Label_stat_sigma"
        Me.Label_stat_sigma.Size = New System.Drawing.Size(51, 20)
        Me.Label_stat_sigma.TabIndex = 3
        Me.Label_stat_sigma.Text = "Sigma"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(15, 95)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(27, 20)
        Me.Label20.TabIndex = 2
        Me.Label20.Text = "FS:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(15, 55)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(54, 20)
        Me.Label18.TabIndex = 1
        Me.Label18.Text = "Sigma:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(15, 17)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(74, 20)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "STATIQUE"
        '
        'Panel_FATIGUE
        '
        Me.Panel_FATIGUE.Controls.Add(Me.Label_fs_fat)
        Me.Panel_FATIGUE.Controls.Add(Me.Label28)
        Me.Panel_FATIGUE.Controls.Add(Me.Label_fs_stat)
        Me.Panel_FATIGUE.Controls.Add(Me.Label27)
        Me.Panel_FATIGUE.Controls.Add(Me.Label_stat_N)
        Me.Panel_FATIGUE.Controls.Add(Me.Label23)
        Me.Panel_FATIGUE.Controls.Add(Me.Label_fat_sigmaM)
        Me.Panel_FATIGUE.Controls.Add(Me.Label22)
        Me.Panel_FATIGUE.Controls.Add(Me.Label_fat_FS)
        Me.Panel_FATIGUE.Controls.Add(Me.Label_fat_sigmaA)
        Me.Panel_FATIGUE.Controls.Add(Me.Label_FSfat)
        Me.Panel_FATIGUE.Controls.Add(Me.Label25)
        Me.Panel_FATIGUE.Controls.Add(Me.Label26)
        Me.Panel_FATIGUE.Location = New System.Drawing.Point(558, 368)
        Me.Panel_FATIGUE.Name = "Panel_FATIGUE"
        Me.Panel_FATIGUE.Size = New System.Drawing.Size(334, 224)
        Me.Panel_FATIGUE.TabIndex = 33
        '
        'Label_fs_fat
        '
        Me.Label_fs_fat.AutoSize = True
        Me.Label_fs_fat.Location = New System.Drawing.Point(90, 144)
        Me.Label_fs_fat.Name = "Label_fs_fat"
        Me.Label_fs_fat.Size = New System.Drawing.Size(42, 20)
        Me.Label_fs_fat.TabIndex = 38
        Me.Label_fs_fat.Text = "FSfat"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(16, 144)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(45, 20)
        Me.Label28.TabIndex = 37
        Me.Label28.Text = "FSfat:"
        '
        'Label_fs_stat
        '
        Me.Label_fs_stat.AutoSize = True
        Me.Label_fs_stat.Location = New System.Drawing.Point(90, 114)
        Me.Label_fs_stat.Name = "Label_fs_stat"
        Me.Label_fs_stat.Size = New System.Drawing.Size(48, 20)
        Me.Label_fs_stat.TabIndex = 36
        Me.Label_fs_stat.Text = "FSstat"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(16, 114)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(51, 20)
        Me.Label27.TabIndex = 35
        Me.Label27.Text = "FSstat:"
        '
        'Label_stat_N
        '
        Me.Label_stat_N.AutoSize = True
        Me.Label_stat_N.Location = New System.Drawing.Point(90, 192)
        Me.Label_stat_N.Name = "Label_stat_N"
        Me.Label_stat_N.Size = New System.Drawing.Size(20, 20)
        Me.Label_stat_N.TabIndex = 34
        Me.Label_stat_N.Text = "N"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(16, 192)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(23, 20)
        Me.Label23.TabIndex = 34
        Me.Label23.Text = "N:"
        '
        'Label_fat_sigmaM
        '
        Me.Label_fat_sigmaM.AutoSize = True
        Me.Label_fat_sigmaM.Location = New System.Drawing.Point(89, 85)
        Me.Label_fat_sigmaM.Name = "Label_fat_sigmaM"
        Me.Label_fat_sigmaM.Size = New System.Drawing.Size(70, 20)
        Me.Label_fat_sigmaM.TabIndex = 34
        Me.Label_fat_sigmaM.Text = "Sigma_M"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(16, 85)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(71, 20)
        Me.Label22.TabIndex = 5
        Me.Label22.Text = "Sigma M:"
        '
        'Label_fat_FS
        '
        Me.Label_fat_FS.AutoSize = True
        Me.Label_fat_FS.Location = New System.Drawing.Point(279, 17)
        Me.Label_fat_FS.Name = "Label_fat_FS"
        Me.Label_fat_FS.Size = New System.Drawing.Size(24, 20)
        Me.Label_fat_FS.TabIndex = 4
        Me.Label_fat_FS.Text = "FS"
        Me.Label_fat_FS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_fat_sigmaA
        '
        Me.Label_fat_sigmaA.AutoSize = True
        Me.Label_fat_sigmaA.Location = New System.Drawing.Point(89, 55)
        Me.Label_fat_sigmaA.Name = "Label_fat_sigmaA"
        Me.Label_fat_sigmaA.Size = New System.Drawing.Size(67, 20)
        Me.Label_fat_sigmaA.TabIndex = 3
        Me.Label_fat_sigmaA.Text = "Sigma_A"
        '
        'Label_FSfat
        '
        Me.Label_FSfat.AutoSize = True
        Me.Label_FSfat.Location = New System.Drawing.Point(208, 17)
        Me.Label_FSfat.Name = "Label_FSfat"
        Me.Label_FSfat.Size = New System.Drawing.Size(52, 20)
        Me.Label_FSfat.TabIndex = 2
        Me.Label_FSfat.Text = "FSmin:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(15, 55)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(68, 20)
        Me.Label25.TabIndex = 1
        Me.Label25.Text = "Sigma A:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(15, 17)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(64, 20)
        Me.Label26.TabIndex = 0
        Me.Label26.Text = "FATIGUE"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(1074, 126)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(28, 20)
        Me.Label24.TabIndex = 34
        Me.Label24.Text = "q="
        '
        'Label_q
        '
        Me.Label_q.AutoSize = True
        Me.Label_q.Location = New System.Drawing.Point(1104, 126)
        Me.Label_q.Name = "Label_q"
        Me.Label_q.Size = New System.Drawing.Size(16, 20)
        Me.Label_q.TabIndex = 35
        Me.Label_q.Text = "x"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(1074, 146)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(31, 20)
        Me.Label29.TabIndex = 36
        Me.Label29.Text = "kt="
        '
        'Label_kt_deKe
        '
        Me.Label_kt_deKe.AutoSize = True
        Me.Label_kt_deKe.Location = New System.Drawing.Point(1104, 146)
        Me.Label_kt_deKe.Name = "Label_kt_deKe"
        Me.Label_kt_deKe.Size = New System.Drawing.Size(16, 20)
        Me.Label_kt_deKe.TabIndex = 37
        Me.Label_kt_deKe.Text = "x"
        '
        'Panel_test
        '
        Me.Panel_test.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel_test.Location = New System.Drawing.Point(1038, 205)
        Me.Panel_test.Name = "Panel_test"
        Me.Panel_test.Size = New System.Drawing.Size(250, 125)
        Me.Panel_test.TabIndex = 38
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(898, 525)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(76, 20)
        Me.Label30.TabIndex = 39
        Me.Label30.Text = "kt Axiale="
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(898, 563)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(82, 20)
        Me.Label31.TabIndex = 40
        Me.Label31.Text = "kt Flexion="
        '
        'Label_kt_axiale
        '
        Me.Label_kt_axiale.AutoSize = True
        Me.Label_kt_axiale.Location = New System.Drawing.Point(982, 525)
        Me.Label_kt_axiale.Name = "Label_kt_axiale"
        Me.Label_kt_axiale.Size = New System.Drawing.Size(16, 20)
        Me.Label_kt_axiale.TabIndex = 41
        Me.Label_kt_axiale.Text = "x"
        '
        'Label_kt_flexion
        '
        Me.Label_kt_flexion.AutoSize = True
        Me.Label_kt_flexion.Location = New System.Drawing.Point(982, 563)
        Me.Label_kt_flexion.Name = "Label_kt_flexion"
        Me.Label_kt_flexion.Size = New System.Drawing.Size(16, 20)
        Me.Label_kt_flexion.TabIndex = 42
        Me.Label_kt_flexion.Text = "x"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(898, 494)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(45, 20)
        Me.Label32.TabIndex = 43
        Me.Label32.Text = "d/w="
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(898, 464)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(42, 20)
        Me.Label33.TabIndex = 44
        Me.Label33.Text = "d/h="
        '
        'Label_d_w
        '
        Me.Label_d_w.AutoSize = True
        Me.Label_d_w.Location = New System.Drawing.Point(982, 494)
        Me.Label_d_w.Name = "Label_d_w"
        Me.Label_d_w.Size = New System.Drawing.Size(16, 20)
        Me.Label_d_w.TabIndex = 45
        Me.Label_d_w.Text = "x"
        '
        'Label_d_h
        '
        Me.Label_d_h.AutoSize = True
        Me.Label_d_h.Location = New System.Drawing.Point(982, 464)
        Me.Label_d_h.Name = "Label_d_h"
        Me.Label_d_h.Size = New System.Drawing.Size(16, 20)
        Me.Label_d_h.TabIndex = 46
        Me.Label_d_h.Text = "x"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(901, 368)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(45, 20)
        Me.Label34.TabIndex = 47
        Me.Label34.Text = "D/d="
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(904, 430)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(39, 20)
        Me.Label35.TabIndex = 48
        Me.Label35.Text = "r/d="
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(901, 402)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(45, 20)
        Me.Label36.TabIndex = 49
        Me.Label36.Text = "w/d="
        '
        'Label_D_d
        '
        Me.Label_D_d.AutoSize = True
        Me.Label_D_d.Location = New System.Drawing.Point(982, 368)
        Me.Label_D_d.Name = "Label_D_d"
        Me.Label_D_d.Size = New System.Drawing.Size(16, 20)
        Me.Label_D_d.TabIndex = 50
        Me.Label_D_d.Text = "x"
        '
        'Label_w_d
        '
        Me.Label_w_d.AutoSize = True
        Me.Label_w_d.Location = New System.Drawing.Point(982, 402)
        Me.Label_w_d.Name = "Label_w_d"
        Me.Label_w_d.Size = New System.Drawing.Size(16, 20)
        Me.Label_w_d.TabIndex = 51
        Me.Label_w_d.Text = "x"
        '
        'Label_r_d
        '
        Me.Label_r_d.AutoSize = True
        Me.Label_r_d.Location = New System.Drawing.Point(982, 430)
        Me.Label_r_d.Name = "Label_r_d"
        Me.Label_r_d.Size = New System.Drawing.Size(16, 20)
        Me.Label_r_d.TabIndex = 52
        Me.Label_r_d.Text = "x"
        '
        'Label_55
        '
        Me.Label_55.AutoSize = True
        Me.Label_55.Location = New System.Drawing.Point(668, 138)
        Me.Label_55.Name = "Label_55"
        Me.Label_55.Size = New System.Drawing.Size(38, 20)
        Me.Label_55.TabIndex = 53
        Me.Label_55.Text = "Se'="
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(541, 138)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(35, 20)
        Me.Label38.TabIndex = 54
        Me.Label38.Text = "Se="
        '
        'Label_se
        '
        Me.Label_se.AutoSize = True
        Me.Label_se.Location = New System.Drawing.Point(571, 138)
        Me.Label_se.Name = "Label_se"
        Me.Label_se.Size = New System.Drawing.Size(16, 20)
        Me.Label_se.TabIndex = 55
        Me.Label_se.Text = "x"
        '
        'Label_se_prime
        '
        Me.Label_se_prime.AutoSize = True
        Me.Label_se_prime.Location = New System.Drawing.Point(701, 138)
        Me.Label_se_prime.Name = "Label_se_prime"
        Me.Label_se_prime.Size = New System.Drawing.Size(16, 20)
        Me.Label_se_prime.TabIndex = 56
        Me.Label_se_prime.Text = "x"
        '
        'Calcul_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1300, 658)
        Me.Controls.Add(Me.Label_se_prime)
        Me.Controls.Add(Me.Label_se)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.Label_55)
        Me.Controls.Add(Me.Label_r_d)
        Me.Controls.Add(Me.Label_w_d)
        Me.Controls.Add(Me.Label_D_d)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.Label_d_h)
        Me.Controls.Add(Me.Label_d_w)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Label_kt_flexion)
        Me.Controls.Add(Me.Label_kt_axiale)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Panel_test)
        Me.Controls.Add(Me.Label_kt_deKe)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label_q)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Panel_FATIGUE)
        Me.Controls.Add(Me.Panel_stat)
        Me.Controls.Add(Me.Label_kf)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label_ke)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.B_Calculer)
        Me.Controls.Add(Me.Label_kd)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label_ka)
        Me.Controls.Add(Me.Label_kc)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label_kb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Calcul_Form"
        Me.Text = "Calcul_Form"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox_Donnees.ResumeLayout(False)
        Me.GroupBox_Donnees.PerformLayout()
        Me.Panel_stat.ResumeLayout(False)
        Me.Panel_stat.PerformLayout()
        Me.Panel_FATIGUE.ResumeLayout(False)
        Me.Panel_FATIGUE.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents B_Calculer As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label_Fiabilité As Label
    Friend WithEvents Label_Temp As Label
    Friend WithEvents Label_FiniSurf As Label
    Friend WithEvents Label_AppContrainte As Label
    Friend WithEvents Label_Contrainte As Label
    Friend WithEvents Label_NatureMat As Label
    Friend WithEvents Label_TypeMat As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button_Valider As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox_Donnees As GroupBox
    Friend WithEvents Label_Sy As Label
    Friend WithEvents Label_Suc As Label
    Friend WithEvents Label_Sut As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label_kf As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label_ke As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label_kd As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label_kc As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label_kb As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label_ka As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBox_FSdesire As TextBox
    Friend WithEvents CheckBox_DeterminerN As CheckBox
    Friend WithEvents CheckBox_DeterminerFS As CheckBox
    Friend WithEvents Label_FStag As Label
    Friend WithEvents TextBox_fiabilite As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox_kf As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel_stat As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents Label_stat_FS As Label
    Friend WithEvents Label_stat_sigma As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Panel_FATIGUE As Panel
    Friend WithEvents Label_fat_FS As Label
    Friend WithEvents Label_fat_sigmaA As Label
    Friend WithEvents Label_FSfat As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label_fat_sigmaM As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label_stat_N As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label_fs_fat As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label_fs_stat As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label_q As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label_kt_deKe As Label
    Friend WithEvents Panel_test As Panel
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label_kt_axiale As Label
    Friend WithEvents Label_kt_flexion As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label_d_w As Label
    Friend WithEvents Label_d_h As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label_D_d As Label
    Friend WithEvents Label_w_d As Label
    Friend WithEvents Label_r_d As Label
    Friend WithEvents Label_55 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label_se As Label
    Friend WithEvents Label_se_prime As Label
End Class
