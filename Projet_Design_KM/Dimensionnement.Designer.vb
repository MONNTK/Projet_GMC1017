<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dimensionnement
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dimensionnement))
        Me.CheckBox_cas1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox_cas2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox_cas3 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBox_DD = New System.Windows.Forms.CheckBox()
        Me.CheckBox_w = New System.Windows.Forms.CheckBox()
        Me.CheckBox_r = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CheckBox_h = New System.Windows.Forms.CheckBox()
        Me.TextBox_DD = New System.Windows.Forms.TextBox()
        Me.CheckBox_d = New System.Windows.Forms.CheckBox()
        Me.TextBox_r = New System.Windows.Forms.TextBox()
        Me.TextBox_h = New System.Windows.Forms.TextBox()
        Me.TextBox_d = New System.Windows.Forms.TextBox()
        Me.TextBox_w = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox_DistanceFlex = New System.Windows.Forms.TextBox()
        Me.Label_dist_flex = New System.Windows.Forms.Label()
        Me.TextBox_CM = New System.Windows.Forms.TextBox()
        Me.TextBox_AC = New System.Windows.Forms.TextBox()
        Me.CheckBox_AC = New System.Windows.Forms.CheckBox()
        Me.CheckBox_CM = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Contraintes = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Forces = New System.Windows.Forms.CheckBox()
        Me.TextBox_FAM = New System.Windows.Forms.TextBox()
        Me.TextBox_AFA = New System.Windows.Forms.TextBox()
        Me.TextBox_FFM = New System.Windows.Forms.TextBox()
        Me.TextBox_AFF = New System.Windows.Forms.TextBox()
        Me.CheckBox_AFF = New System.Windows.Forms.CheckBox()
        Me.CheckBox_FFM = New System.Windows.Forms.CheckBox()
        Me.CheckBox_AFM = New System.Windows.Forms.CheckBox()
        Me.CheckBox_FAM = New System.Windows.Forms.CheckBox()
        Me.GroupBox_FS = New System.Windows.Forms.GroupBox()
        Me.TextBox_FS = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label_N = New System.Windows.Forms.Label()
        Me.TextBox_N = New System.Windows.Forms.TextBox()
        Me.CheckBox_VieInfinie = New System.Windows.Forms.CheckBox()
        Me.CheckBox_VieFinie = New System.Windows.Forms.CheckBox()
        Me.GroupBox_Materiau = New System.Windows.Forms.GroupBox()
        Me.TextBox_Su = New System.Windows.Forms.TextBox()
        Me.TextBox_Sy = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CheckBox_fonte = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Alliage = New System.Windows.Forms.CheckBox()
        Me.CheckBox_acier = New System.Windows.Forms.CheckBox()
        Me.GroupBox_autre = New System.Windows.Forms.GroupBox()
        Me.ComboBox_Finisurface = New System.Windows.Forms.ComboBox()
        Me.TextBox_kf = New System.Windows.Forms.TextBox()
        Me.TextBox_Temperature = New System.Windows.Forms.TextBox()
        Me.TextBox_Fiabilite = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button_Calculer = New System.Windows.Forms.Button()
        Me.Panel_resultats = New System.Windows.Forms.Panel()
        Me.Label_FS = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label_parametre_i = New System.Windows.Forms.Label()
        Me.Label_Dim_manquant = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox_cas1 = New System.Windows.Forms.PictureBox()
        Me.Panel_Image = New System.Windows.Forms.Panel()
        Me.PictureBox_cas3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox_cas2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox_FS.SuspendLayout()
        Me.GroupBox_Materiau.SuspendLayout()
        Me.GroupBox_autre.SuspendLayout()
        Me.Panel_resultats.SuspendLayout()
        CType(Me.PictureBox_cas1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Image.SuspendLayout()
        CType(Me.PictureBox_cas3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_cas2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CheckBox_cas1
        '
        Me.CheckBox_cas1.AutoSize = True
        Me.CheckBox_cas1.Location = New System.Drawing.Point(29, 30)
        Me.CheckBox_cas1.Name = "CheckBox_cas1"
        Me.CheckBox_cas1.Size = New System.Drawing.Size(187, 24)
        Me.CheckBox_cas1.TabIndex = 0
        Me.CheckBox_cas1.Text = "Cas 1 : Plaque avec trou"
        Me.CheckBox_cas1.UseVisualStyleBackColor = True
        '
        'CheckBox_cas2
        '
        Me.CheckBox_cas2.AutoSize = True
        Me.CheckBox_cas2.Location = New System.Drawing.Point(243, 30)
        Me.CheckBox_cas2.Name = "CheckBox_cas2"
        Me.CheckBox_cas2.Size = New System.Drawing.Size(215, 24)
        Me.CheckBox_cas2.TabIndex = 1
        Me.CheckBox_cas2.Text = "Cas 2 : Plaque avec encoche"
        Me.CheckBox_cas2.UseVisualStyleBackColor = True
        '
        'CheckBox_cas3
        '
        Me.CheckBox_cas3.AutoSize = True
        Me.CheckBox_cas3.Location = New System.Drawing.Point(493, 30)
        Me.CheckBox_cas3.Name = "CheckBox_cas3"
        Me.CheckBox_cas3.Size = New System.Drawing.Size(239, 24)
        Me.CheckBox_cas3.TabIndex = 2
        Me.CheckBox_cas3.Text = "Cas 3 : Plaque avec épaulement"
        Me.CheckBox_cas3.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox_DD)
        Me.GroupBox1.Controls.Add(Me.CheckBox_w)
        Me.GroupBox1.Controls.Add(Me.CheckBox_r)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.CheckBox_h)
        Me.GroupBox1.Controls.Add(Me.TextBox_DD)
        Me.GroupBox1.Controls.Add(Me.CheckBox_d)
        Me.GroupBox1.Controls.Add(Me.TextBox_r)
        Me.GroupBox1.Controls.Add(Me.TextBox_h)
        Me.GroupBox1.Controls.Add(Me.TextBox_d)
        Me.GroupBox1.Controls.Add(Me.TextBox_w)
        Me.GroupBox1.Location = New System.Drawing.Point(29, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(234, 224)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dimensions (mm)"
        '
        'CheckBox_DD
        '
        Me.CheckBox_DD.AutoSize = True
        Me.CheckBox_DD.Location = New System.Drawing.Point(37, 193)
        Me.CheckBox_DD.Name = "CheckBox_DD"
        Me.CheckBox_DD.Size = New System.Drawing.Size(45, 24)
        Me.CheckBox_DD.TabIndex = 17
        Me.CheckBox_DD.Text = "D:"
        Me.CheckBox_DD.UseVisualStyleBackColor = True
        '
        'CheckBox_w
        '
        Me.CheckBox_w.AutoSize = True
        Me.CheckBox_w.Location = New System.Drawing.Point(37, 61)
        Me.CheckBox_w.Name = "CheckBox_w"
        Me.CheckBox_w.Size = New System.Drawing.Size(45, 24)
        Me.CheckBox_w.TabIndex = 13
        Me.CheckBox_w.Text = "w:"
        Me.CheckBox_w.UseVisualStyleBackColor = True
        '
        'CheckBox_r
        '
        Me.CheckBox_r.AutoSize = True
        Me.CheckBox_r.Location = New System.Drawing.Point(37, 160)
        Me.CheckBox_r.Name = "CheckBox_r"
        Me.CheckBox_r.Size = New System.Drawing.Size(39, 24)
        Me.CheckBox_r.TabIndex = 16
        Me.CheckBox_r.Text = "r:"
        Me.CheckBox_r.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "À déterminer"
        '
        'CheckBox_h
        '
        Me.CheckBox_h.AutoSize = True
        Me.CheckBox_h.Location = New System.Drawing.Point(37, 127)
        Me.CheckBox_h.Name = "CheckBox_h"
        Me.CheckBox_h.Size = New System.Drawing.Size(42, 24)
        Me.CheckBox_h.TabIndex = 15
        Me.CheckBox_h.Text = "h:"
        Me.CheckBox_h.UseVisualStyleBackColor = True
        '
        'TextBox_DD
        '
        Me.TextBox_DD.Location = New System.Drawing.Point(88, 191)
        Me.TextBox_DD.Name = "TextBox_DD"
        Me.TextBox_DD.Size = New System.Drawing.Size(125, 27)
        Me.TextBox_DD.TabIndex = 12
        '
        'CheckBox_d
        '
        Me.CheckBox_d.AutoSize = True
        Me.CheckBox_d.Location = New System.Drawing.Point(37, 95)
        Me.CheckBox_d.Name = "CheckBox_d"
        Me.CheckBox_d.Size = New System.Drawing.Size(43, 24)
        Me.CheckBox_d.TabIndex = 14
        Me.CheckBox_d.Text = "d:"
        Me.CheckBox_d.UseVisualStyleBackColor = True
        '
        'TextBox_r
        '
        Me.TextBox_r.Location = New System.Drawing.Point(88, 158)
        Me.TextBox_r.Name = "TextBox_r"
        Me.TextBox_r.Size = New System.Drawing.Size(125, 27)
        Me.TextBox_r.TabIndex = 11
        '
        'TextBox_h
        '
        Me.TextBox_h.Location = New System.Drawing.Point(88, 125)
        Me.TextBox_h.Name = "TextBox_h"
        Me.TextBox_h.Size = New System.Drawing.Size(125, 27)
        Me.TextBox_h.TabIndex = 10
        '
        'TextBox_d
        '
        Me.TextBox_d.Location = New System.Drawing.Point(88, 92)
        Me.TextBox_d.Name = "TextBox_d"
        Me.TextBox_d.Size = New System.Drawing.Size(125, 27)
        Me.TextBox_d.TabIndex = 9
        '
        'TextBox_w
        '
        Me.TextBox_w.Location = New System.Drawing.Point(88, 59)
        Me.TextBox_w.Name = "TextBox_w"
        Me.TextBox_w.Size = New System.Drawing.Size(125, 27)
        Me.TextBox_w.TabIndex = 4
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.TextBox_DistanceFlex)
        Me.GroupBox2.Controls.Add(Me.Label_dist_flex)
        Me.GroupBox2.Controls.Add(Me.TextBox_CM)
        Me.GroupBox2.Controls.Add(Me.TextBox_AC)
        Me.GroupBox2.Controls.Add(Me.CheckBox_AC)
        Me.GroupBox2.Controls.Add(Me.CheckBox_CM)
        Me.GroupBox2.Controls.Add(Me.CheckBox_Contraintes)
        Me.GroupBox2.Controls.Add(Me.CheckBox_Forces)
        Me.GroupBox2.Controls.Add(Me.TextBox_FAM)
        Me.GroupBox2.Controls.Add(Me.TextBox_AFA)
        Me.GroupBox2.Controls.Add(Me.TextBox_FFM)
        Me.GroupBox2.Controls.Add(Me.TextBox_AFF)
        Me.GroupBox2.Controls.Add(Me.CheckBox_AFF)
        Me.GroupBox2.Controls.Add(Me.CheckBox_FFM)
        Me.GroupBox2.Controls.Add(Me.CheckBox_AFM)
        Me.GroupBox2.Controls.Add(Me.CheckBox_FAM)
        Me.GroupBox2.Location = New System.Drawing.Point(286, 61)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(860, 223)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Charge (N) ou contrainte (MPa)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(417, 192)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(22, 20)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "m"
        '
        'TextBox_DistanceFlex
        '
        Me.TextBox_DistanceFlex.Location = New System.Drawing.Point(286, 189)
        Me.TextBox_DistanceFlex.Name = "TextBox_DistanceFlex"
        Me.TextBox_DistanceFlex.Size = New System.Drawing.Size(125, 27)
        Me.TextBox_DistanceFlex.TabIndex = 27
        '
        'Label_dist_flex
        '
        Me.Label_dist_flex.AutoSize = True
        Me.Label_dist_flex.Location = New System.Drawing.Point(141, 192)
        Me.Label_dist_flex.Name = "Label_dist_flex"
        Me.Label_dist_flex.Size = New System.Drawing.Size(139, 20)
        Me.Label_dist_flex.TabIndex = 18
        Me.Label_dist_flex.Text = "Distance de flexion:"
        '
        'TextBox_CM
        '
        Me.TextBox_CM.Location = New System.Drawing.Point(685, 56)
        Me.TextBox_CM.Name = "TextBox_CM"
        Me.TextBox_CM.Size = New System.Drawing.Size(125, 27)
        Me.TextBox_CM.TabIndex = 26
        '
        'TextBox_AC
        '
        Me.TextBox_AC.Location = New System.Drawing.Point(685, 91)
        Me.TextBox_AC.Name = "TextBox_AC"
        Me.TextBox_AC.Size = New System.Drawing.Size(125, 27)
        Me.TextBox_AC.TabIndex = 25
        '
        'CheckBox_AC
        '
        Me.CheckBox_AC.AutoSize = True
        Me.CheckBox_AC.Location = New System.Drawing.Point(467, 94)
        Me.CheckBox_AC.Name = "CheckBox_AC"
        Me.CheckBox_AC.Size = New System.Drawing.Size(212, 24)
        Me.CheckBox_AC.TabIndex = 24
        Me.CheckBox_AC.Text = "Amplitude de la contrainte:"
        Me.CheckBox_AC.UseVisualStyleBackColor = True
        '
        'CheckBox_CM
        '
        Me.CheckBox_CM.AutoSize = True
        Me.CheckBox_CM.Location = New System.Drawing.Point(467, 58)
        Me.CheckBox_CM.Name = "CheckBox_CM"
        Me.CheckBox_CM.Size = New System.Drawing.Size(168, 24)
        Me.CheckBox_CM.TabIndex = 23
        Me.CheckBox_CM.Text = "Contrainte moyenne:"
        Me.CheckBox_CM.UseVisualStyleBackColor = True
        '
        'CheckBox_Contraintes
        '
        Me.CheckBox_Contraintes.AutoSize = True
        Me.CheckBox_Contraintes.Location = New System.Drawing.Point(599, 30)
        Me.CheckBox_Contraintes.Name = "CheckBox_Contraintes"
        Me.CheckBox_Contraintes.Size = New System.Drawing.Size(106, 24)
        Me.CheckBox_Contraintes.TabIndex = 22
        Me.CheckBox_Contraintes.Text = "Contraintes"
        Me.CheckBox_Contraintes.UseVisualStyleBackColor = True
        '
        'CheckBox_Forces
        '
        Me.CheckBox_Forces.AutoSize = True
        Me.CheckBox_Forces.Location = New System.Drawing.Point(180, 30)
        Me.CheckBox_Forces.Name = "CheckBox_Forces"
        Me.CheckBox_Forces.Size = New System.Drawing.Size(73, 24)
        Me.CheckBox_Forces.TabIndex = 21
        Me.CheckBox_Forces.Text = "Forces"
        Me.CheckBox_Forces.UseVisualStyleBackColor = True
        '
        'TextBox_FAM
        '
        Me.TextBox_FAM.Location = New System.Drawing.Point(286, 58)
        Me.TextBox_FAM.Name = "TextBox_FAM"
        Me.TextBox_FAM.Size = New System.Drawing.Size(125, 27)
        Me.TextBox_FAM.TabIndex = 20
        '
        'TextBox_AFA
        '
        Me.TextBox_AFA.Location = New System.Drawing.Point(286, 91)
        Me.TextBox_AFA.Name = "TextBox_AFA"
        Me.TextBox_AFA.Size = New System.Drawing.Size(125, 27)
        Me.TextBox_AFA.TabIndex = 19
        '
        'TextBox_FFM
        '
        Me.TextBox_FFM.Location = New System.Drawing.Point(286, 124)
        Me.TextBox_FFM.Name = "TextBox_FFM"
        Me.TextBox_FFM.Size = New System.Drawing.Size(125, 27)
        Me.TextBox_FFM.TabIndex = 18
        '
        'TextBox_AFF
        '
        Me.TextBox_AFF.Location = New System.Drawing.Point(286, 157)
        Me.TextBox_AFF.Name = "TextBox_AFF"
        Me.TextBox_AFF.Size = New System.Drawing.Size(125, 27)
        Me.TextBox_AFF.TabIndex = 18
        '
        'CheckBox_AFF
        '
        Me.CheckBox_AFF.AutoSize = True
        Me.CheckBox_AFF.Location = New System.Drawing.Point(31, 159)
        Me.CheckBox_AFF.Name = "CheckBox_AFF"
        Me.CheckBox_AFF.Size = New System.Drawing.Size(249, 24)
        Me.CheckBox_AFF.TabIndex = 17
        Me.CheckBox_AFF.Text = "Amplitude de la force de flexion:"
        Me.CheckBox_AFF.UseVisualStyleBackColor = True
        '
        'CheckBox_FFM
        '
        Me.CheckBox_FFM.AutoSize = True
        Me.CheckBox_FFM.Location = New System.Drawing.Point(31, 126)
        Me.CheckBox_FFM.Name = "CheckBox_FFM"
        Me.CheckBox_FFM.Size = New System.Drawing.Size(205, 24)
        Me.CheckBox_FFM.TabIndex = 16
        Me.CheckBox_FFM.Text = "Force de flexion moyenne:"
        Me.CheckBox_FFM.UseVisualStyleBackColor = True
        '
        'CheckBox_AFM
        '
        Me.CheckBox_AFM.AutoSize = True
        Me.CheckBox_AFM.Location = New System.Drawing.Point(31, 94)
        Me.CheckBox_AFM.Name = "CheckBox_AFM"
        Me.CheckBox_AFM.Size = New System.Drawing.Size(222, 24)
        Me.CheckBox_AFM.TabIndex = 15
        Me.CheckBox_AFM.Text = "Amplitude de la force axiale:"
        Me.CheckBox_AFM.UseVisualStyleBackColor = True
        '
        'CheckBox_FAM
        '
        Me.CheckBox_FAM.AutoSize = True
        Me.CheckBox_FAM.Location = New System.Drawing.Point(31, 60)
        Me.CheckBox_FAM.Name = "CheckBox_FAM"
        Me.CheckBox_FAM.Size = New System.Drawing.Size(178, 24)
        Me.CheckBox_FAM.TabIndex = 14
        Me.CheckBox_FAM.Text = "Force axiale moyenne:"
        Me.CheckBox_FAM.UseVisualStyleBackColor = True
        '
        'GroupBox_FS
        '
        Me.GroupBox_FS.Controls.Add(Me.TextBox_FS)
        Me.GroupBox_FS.Controls.Add(Me.Label1)
        Me.GroupBox_FS.Controls.Add(Me.Label_N)
        Me.GroupBox_FS.Controls.Add(Me.TextBox_N)
        Me.GroupBox_FS.Controls.Add(Me.CheckBox_VieInfinie)
        Me.GroupBox_FS.Controls.Add(Me.CheckBox_VieFinie)
        Me.GroupBox_FS.Location = New System.Drawing.Point(29, 300)
        Me.GroupBox_FS.Name = "GroupBox_FS"
        Me.GroupBox_FS.Size = New System.Drawing.Size(356, 131)
        Me.GroupBox_FS.TabIndex = 5
        Me.GroupBox_FS.TabStop = False
        Me.GroupBox_FS.Text = "Facteur de sécurité"
        '
        'TextBox_FS
        '
        Me.TextBox_FS.Location = New System.Drawing.Point(94, 91)
        Me.TextBox_FS.Name = "TextBox_FS"
        Me.TextBox_FS.Size = New System.Drawing.Size(125, 27)
        Me.TextBox_FS.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 20)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "FS requis:"
        '
        'Label_N
        '
        Me.Label_N.AutoSize = True
        Me.Label_N.Location = New System.Drawing.Point(151, 29)
        Me.Label_N.Name = "Label_N"
        Me.Label_N.Size = New System.Drawing.Size(67, 20)
        Me.Label_N.TabIndex = 20
        Me.Label_N.Text = "N requis:"
        '
        'TextBox_N
        '
        Me.TextBox_N.Location = New System.Drawing.Point(224, 26)
        Me.TextBox_N.Name = "TextBox_N"
        Me.TextBox_N.Size = New System.Drawing.Size(125, 27)
        Me.TextBox_N.TabIndex = 18
        '
        'CheckBox_VieInfinie
        '
        Me.CheckBox_VieInfinie.AutoSize = True
        Me.CheckBox_VieInfinie.Location = New System.Drawing.Point(17, 56)
        Me.CheckBox_VieInfinie.Name = "CheckBox_VieInfinie"
        Me.CheckBox_VieInfinie.Size = New System.Drawing.Size(97, 24)
        Me.CheckBox_VieInfinie.TabIndex = 19
        Me.CheckBox_VieInfinie.Text = "Vie infinie"
        Me.CheckBox_VieInfinie.UseVisualStyleBackColor = True
        '
        'CheckBox_VieFinie
        '
        Me.CheckBox_VieFinie.AutoSize = True
        Me.CheckBox_VieFinie.Location = New System.Drawing.Point(17, 26)
        Me.CheckBox_VieFinie.Name = "CheckBox_VieFinie"
        Me.CheckBox_VieFinie.Size = New System.Drawing.Size(85, 24)
        Me.CheckBox_VieFinie.TabIndex = 18
        Me.CheckBox_VieFinie.Text = "Vie finie"
        Me.CheckBox_VieFinie.UseVisualStyleBackColor = True
        '
        'GroupBox_Materiau
        '
        Me.GroupBox_Materiau.Controls.Add(Me.TextBox_Su)
        Me.GroupBox_Materiau.Controls.Add(Me.TextBox_Sy)
        Me.GroupBox_Materiau.Controls.Add(Me.Label4)
        Me.GroupBox_Materiau.Controls.Add(Me.Label2)
        Me.GroupBox_Materiau.Controls.Add(Me.CheckBox_fonte)
        Me.GroupBox_Materiau.Controls.Add(Me.CheckBox_Alliage)
        Me.GroupBox_Materiau.Controls.Add(Me.CheckBox_acier)
        Me.GroupBox_Materiau.Location = New System.Drawing.Point(402, 306)
        Me.GroupBox_Materiau.Name = "GroupBox_Materiau"
        Me.GroupBox_Materiau.Size = New System.Drawing.Size(415, 125)
        Me.GroupBox_Materiau.TabIndex = 6
        Me.GroupBox_Materiau.TabStop = False
        Me.GroupBox_Materiau.Text = "Matériau"
        '
        'TextBox_Su
        '
        Me.TextBox_Su.Location = New System.Drawing.Point(267, 24)
        Me.TextBox_Su.Name = "TextBox_Su"
        Me.TextBox_Su.Size = New System.Drawing.Size(125, 27)
        Me.TextBox_Su.TabIndex = 24
        '
        'TextBox_Sy
        '
        Me.TextBox_Sy.Location = New System.Drawing.Point(267, 54)
        Me.TextBox_Sy.Name = "TextBox_Sy"
        Me.TextBox_Sy.Size = New System.Drawing.Size(125, 27)
        Me.TextBox_Sy.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(132, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 20)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Limite élastique Sy:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(132, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 20)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Limite ultime Su:"
        '
        'CheckBox_fonte
        '
        Me.CheckBox_fonte.AutoSize = True
        Me.CheckBox_fonte.Location = New System.Drawing.Point(16, 86)
        Me.CheckBox_fonte.Name = "CheckBox_fonte"
        Me.CheckBox_fonte.Size = New System.Drawing.Size(68, 24)
        Me.CheckBox_fonte.TabIndex = 25
        Me.CheckBox_fonte.Text = "Fonte"
        Me.CheckBox_fonte.UseVisualStyleBackColor = True
        '
        'CheckBox_Alliage
        '
        Me.CheckBox_Alliage.AutoSize = True
        Me.CheckBox_Alliage.Location = New System.Drawing.Point(16, 56)
        Me.CheckBox_Alliage.Name = "CheckBox_Alliage"
        Me.CheckBox_Alliage.Size = New System.Drawing.Size(78, 24)
        Me.CheckBox_Alliage.TabIndex = 24
        Me.CheckBox_Alliage.Text = "Alliage"
        Me.CheckBox_Alliage.UseVisualStyleBackColor = True
        '
        'CheckBox_acier
        '
        Me.CheckBox_acier.AutoSize = True
        Me.CheckBox_acier.Location = New System.Drawing.Point(16, 26)
        Me.CheckBox_acier.Name = "CheckBox_acier"
        Me.CheckBox_acier.Size = New System.Drawing.Size(65, 24)
        Me.CheckBox_acier.TabIndex = 23
        Me.CheckBox_acier.Text = "Acier"
        Me.CheckBox_acier.UseVisualStyleBackColor = True
        '
        'GroupBox_autre
        '
        Me.GroupBox_autre.Controls.Add(Me.ComboBox_Finisurface)
        Me.GroupBox_autre.Controls.Add(Me.TextBox_kf)
        Me.GroupBox_autre.Controls.Add(Me.TextBox_Temperature)
        Me.GroupBox_autre.Controls.Add(Me.TextBox_Fiabilite)
        Me.GroupBox_autre.Controls.Add(Me.Label8)
        Me.GroupBox_autre.Controls.Add(Me.Label7)
        Me.GroupBox_autre.Controls.Add(Me.Label6)
        Me.GroupBox_autre.Controls.Add(Me.Label5)
        Me.GroupBox_autre.Location = New System.Drawing.Point(835, 307)
        Me.GroupBox_autre.Name = "GroupBox_autre"
        Me.GroupBox_autre.Size = New System.Drawing.Size(311, 165)
        Me.GroupBox_autre.TabIndex = 7
        Me.GroupBox_autre.TabStop = False
        Me.GroupBox_autre.Text = "Autres paramètres"
        '
        'ComboBox_Finisurface
        '
        Me.ComboBox_Finisurface.FormattingEnabled = True
        Me.ComboBox_Finisurface.Items.AddRange(New Object() {"Poli", "Meulé", "Usiné ou écrouit", "Laminé à chaud", "Forgé"})
        Me.ComboBox_Finisurface.Location = New System.Drawing.Point(138, 89)
        Me.ComboBox_Finisurface.Name = "ComboBox_Finisurface"
        Me.ComboBox_Finisurface.Size = New System.Drawing.Size(151, 28)
        Me.ComboBox_Finisurface.TabIndex = 31
        '
        'TextBox_kf
        '
        Me.TextBox_kf.Location = New System.Drawing.Point(138, 122)
        Me.TextBox_kf.Name = "TextBox_kf"
        Me.TextBox_kf.Size = New System.Drawing.Size(125, 27)
        Me.TextBox_kf.TabIndex = 30
        '
        'TextBox_Temperature
        '
        Me.TextBox_Temperature.Location = New System.Drawing.Point(138, 56)
        Me.TextBox_Temperature.Name = "TextBox_Temperature"
        Me.TextBox_Temperature.Size = New System.Drawing.Size(125, 27)
        Me.TextBox_Temperature.TabIndex = 28
        '
        'TextBox_Fiabilite
        '
        Me.TextBox_Fiabilite.Location = New System.Drawing.Point(138, 23)
        Me.TextBox_Fiabilite.Name = "TextBox_Fiabilite"
        Me.TextBox_Fiabilite.Size = New System.Drawing.Size(125, 27)
        Me.TextBox_Fiabilite.TabIndex = 27
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 125)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 20)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Autre (kf):"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 92)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 20)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Fini de surface:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 20)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Température:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 20)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Fiabilité requise:"
        '
        'Button_Calculer
        '
        Me.Button_Calculer.Location = New System.Drawing.Point(1121, 534)
        Me.Button_Calculer.Name = "Button_Calculer"
        Me.Button_Calculer.Size = New System.Drawing.Size(144, 49)
        Me.Button_Calculer.TabIndex = 8
        Me.Button_Calculer.Text = "Calculer"
        Me.Button_Calculer.UseVisualStyleBackColor = True
        '
        'Panel_resultats
        '
        Me.Panel_resultats.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel_resultats.Controls.Add(Me.Label_FS)
        Me.Panel_resultats.Controls.Add(Me.Label12)
        Me.Panel_resultats.Controls.Add(Me.Label11)
        Me.Panel_resultats.Controls.Add(Me.Label_parametre_i)
        Me.Panel_resultats.Controls.Add(Me.Label_Dim_manquant)
        Me.Panel_resultats.Controls.Add(Me.Label10)
        Me.Panel_resultats.Location = New System.Drawing.Point(29, 437)
        Me.Panel_resultats.Name = "Panel_resultats"
        Me.Panel_resultats.Size = New System.Drawing.Size(356, 146)
        Me.Panel_resultats.TabIndex = 9
        '
        'Label_FS
        '
        Me.Label_FS.AutoSize = True
        Me.Label_FS.Location = New System.Drawing.Point(151, 72)
        Me.Label_FS.Name = "Label_FS"
        Me.Label_FS.Size = New System.Drawing.Size(24, 20)
        Me.Label_FS.TabIndex = 5
        Me.Label_FS.Text = "FS"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 72)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(135, 20)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Facteur de sécurité:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(151, 34)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 20)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "mm"
        '
        'Label_parametre_i
        '
        Me.Label_parametre_i.AutoSize = True
        Me.Label_parametre_i.Location = New System.Drawing.Point(62, 34)
        Me.Label_parametre_i.Name = "Label_parametre_i"
        Me.Label_parametre_i.Size = New System.Drawing.Size(78, 20)
        Me.Label_parametre_i.TabIndex = 2
        Me.Label_parametre_i.Text = "parametre"
        '
        'Label_Dim_manquant
        '
        Me.Label_Dim_manquant.AutoSize = True
        Me.Label_Dim_manquant.Location = New System.Drawing.Point(6, 34)
        Me.Label_Dim_manquant.Name = "Label_Dim_manquant"
        Me.Label_Dim_manquant.Size = New System.Drawing.Size(40, 20)
        Me.Label_Dim_manquant.TabIndex = 1
        Me.Label_Dim_manquant.Text = "Dim:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(6, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 20)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Résultats"
        '
        'PictureBox_cas1
        '
        Me.PictureBox_cas1.Image = CType(resources.GetObject("PictureBox_cas1.Image"), System.Drawing.Image)
        Me.PictureBox_cas1.Location = New System.Drawing.Point(0, -5)
        Me.PictureBox_cas1.Name = "PictureBox_cas1"
        Me.PictureBox_cas1.Size = New System.Drawing.Size(432, 269)
        Me.PictureBox_cas1.TabIndex = 10
        Me.PictureBox_cas1.TabStop = False
        '
        'Panel_Image
        '
        Me.Panel_Image.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel_Image.Controls.Add(Me.PictureBox_cas3)
        Me.Panel_Image.Controls.Add(Me.PictureBox_cas2)
        Me.Panel_Image.Controls.Add(Me.PictureBox_cas1)
        Me.Panel_Image.Location = New System.Drawing.Point(753, 20)
        Me.Panel_Image.Name = "Panel_Image"
        Me.Panel_Image.Size = New System.Drawing.Size(426, 257)
        Me.Panel_Image.TabIndex = 10
        '
        'PictureBox_cas3
        '
        Me.PictureBox_cas3.Image = CType(resources.GetObject("PictureBox_cas3.Image"), System.Drawing.Image)
        Me.PictureBox_cas3.Location = New System.Drawing.Point(17, -25)
        Me.PictureBox_cas3.Name = "PictureBox_cas3"
        Me.PictureBox_cas3.Size = New System.Drawing.Size(432, 269)
        Me.PictureBox_cas3.TabIndex = 12
        Me.PictureBox_cas3.TabStop = False
        '
        'PictureBox_cas2
        '
        Me.PictureBox_cas2.Image = CType(resources.GetObject("PictureBox_cas2.Image"), System.Drawing.Image)
        Me.PictureBox_cas2.Location = New System.Drawing.Point(3, -5)
        Me.PictureBox_cas2.Name = "PictureBox_cas2"
        Me.PictureBox_cas2.Size = New System.Drawing.Size(432, 269)
        Me.PictureBox_cas2.TabIndex = 11
        Me.PictureBox_cas2.TabStop = False
        '
        'Dimensionnement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1300, 658)
        Me.Controls.Add(Me.Panel_Image)
        Me.Controls.Add(Me.Panel_resultats)
        Me.Controls.Add(Me.Button_Calculer)
        Me.Controls.Add(Me.GroupBox_autre)
        Me.Controls.Add(Me.GroupBox_Materiau)
        Me.Controls.Add(Me.GroupBox_FS)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CheckBox_cas3)
        Me.Controls.Add(Me.CheckBox_cas2)
        Me.Controls.Add(Me.CheckBox_cas1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Dimensionnement"
        Me.Text = "Calculateur pour dimensionnement"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox_FS.ResumeLayout(False)
        Me.GroupBox_FS.PerformLayout()
        Me.GroupBox_Materiau.ResumeLayout(False)
        Me.GroupBox_Materiau.PerformLayout()
        Me.GroupBox_autre.ResumeLayout(False)
        Me.GroupBox_autre.PerformLayout()
        Me.Panel_resultats.ResumeLayout(False)
        Me.Panel_resultats.PerformLayout()
        CType(Me.PictureBox_cas1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Image.ResumeLayout(False)
        CType(Me.PictureBox_cas3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_cas2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CheckBox_cas1 As CheckBox
    Friend WithEvents CheckBox_cas2 As CheckBox
    Friend WithEvents CheckBox_cas3 As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox_DD As TextBox
    Friend WithEvents TextBox_r As TextBox
    Friend WithEvents TextBox_h As TextBox
    Friend WithEvents TextBox_d As TextBox
    Friend WithEvents TextBox_w As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CheckBox_DD As CheckBox
    Friend WithEvents CheckBox_w As CheckBox
    Friend WithEvents CheckBox_r As CheckBox
    Friend WithEvents CheckBox_h As CheckBox
    Friend WithEvents CheckBox_d As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CheckBox_AFF As CheckBox
    Friend WithEvents CheckBox_FFM As CheckBox
    Friend WithEvents CheckBox_AFM As CheckBox
    Friend WithEvents CheckBox_FAM As CheckBox
    Friend WithEvents TextBox_FAM As TextBox
    Friend WithEvents TextBox_AFA As TextBox
    Friend WithEvents TextBox_FFM As TextBox
    Friend WithEvents TextBox_AFF As TextBox
    Friend WithEvents CheckBox_Contraintes As CheckBox
    Friend WithEvents CheckBox_Forces As CheckBox
    Friend WithEvents CheckBox_AC As CheckBox
    Friend WithEvents CheckBox_CM As CheckBox
    Friend WithEvents TextBox_CM As TextBox
    Friend WithEvents TextBox_AC As TextBox
    Friend WithEvents GroupBox_FS As GroupBox
    Friend WithEvents CheckBox_VieInfinie As CheckBox
    Friend WithEvents CheckBox_VieFinie As CheckBox
    Friend WithEvents Label_N As Label
    Friend WithEvents TextBox_N As TextBox
    Friend WithEvents TextBox_FS As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox_Materiau As GroupBox
    Friend WithEvents CheckBox_fonte As CheckBox
    Friend WithEvents CheckBox_Alliage As CheckBox
    Friend WithEvents CheckBox_acier As CheckBox
    Friend WithEvents TextBox_Su As TextBox
    Friend WithEvents TextBox_Sy As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox_autre As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox_Temperature As TextBox
    Friend WithEvents TextBox_Fiabilite As TextBox
    Friend WithEvents TextBox_kf As TextBox
    Friend WithEvents Button_Calculer As Button
    Friend WithEvents TextBox_DistanceFlex As TextBox
    Friend WithEvents Label_dist_flex As Label
    Friend WithEvents ComboBox_Finisurface As ComboBox
    Friend WithEvents Panel_resultats As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Label_FS As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label_parametre_i As Label
    Friend WithEvents Label_Dim_manquant As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox_cas1 As PictureBox
    Friend WithEvents Panel_Image As Panel
    Friend WithEvents PictureBox_cas2 As PictureBox
    Friend WithEvents PictureBox_cas3 As PictureBox
End Class
