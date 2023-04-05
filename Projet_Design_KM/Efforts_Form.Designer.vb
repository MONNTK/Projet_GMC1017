<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Efforts_Form
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Efforts_Form))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox_TypeContrainte = New System.Windows.Forms.GroupBox()
        Me.CheckBox_Variable = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Constante = New System.Windows.Forms.CheckBox()
        Me.GroupBox_EffortsC = New System.Windows.Forms.GroupBox()
        Me.TextBox_ECF = New System.Windows.Forms.TextBox()
        Me.TextBox_ECA = New System.Windows.Forms.TextBox()
        Me.Label_ECF = New System.Windows.Forms.Label()
        Me.Label_ECA = New System.Windows.Forms.Label()
        Me.GroupBox_EffortsV = New System.Windows.Forms.GroupBox()
        Me.TextBox_EVFMax = New System.Windows.Forms.TextBox()
        Me.TextBox_EVAMax = New System.Windows.Forms.TextBox()
        Me.TextBox_EVFMin = New System.Windows.Forms.TextBox()
        Me.TextBox_EVAMin = New System.Windows.Forms.TextBox()
        Me.Label_Max = New System.Windows.Forms.Label()
        Me.Label_Min = New System.Windows.Forms.Label()
        Me.Label_EVF = New System.Windows.Forms.Label()
        Me.Label_EVA = New System.Windows.Forms.Label()
        Me.CheckBox_EAxial = New System.Windows.Forms.CheckBox()
        Me.CheckBox_EFlexion = New System.Windows.Forms.CheckBox()
        Me.CheckBox_EAxialeF = New System.Windows.Forms.CheckBox()
        Me.GroupBox_Efforts = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_temperature = New System.Windows.Forms.TextBox()
        Me.Button_valider = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label_fa = New System.Windows.Forms.Label()
        Me.Label_fm = New System.Windows.Forms.Label()
        Me.Label_ma = New System.Windows.Forms.Label()
        Me.Label_mm = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label_sigmaAF = New System.Windows.Forms.Label()
        Me.Label_sigmaMf = New System.Windows.Forms.Label()
        Me.Label_sigmaA = New System.Windows.Forms.Label()
        Me.Label_sigmaM = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_TypeContrainte.SuspendLayout()
        Me.GroupBox_EffortsC.SuspendLayout()
        Me.GroupBox_EffortsV.SuspendLayout()
        Me.GroupBox_Efforts.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(352, 149)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(560, 466)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'GroupBox_TypeContrainte
        '
        Me.GroupBox_TypeContrainte.Controls.Add(Me.CheckBox_Variable)
        Me.GroupBox_TypeContrainte.Controls.Add(Me.CheckBox_Constante)
        Me.GroupBox_TypeContrainte.Location = New System.Drawing.Point(13, 12)
        Me.GroupBox_TypeContrainte.Name = "GroupBox_TypeContrainte"
        Me.GroupBox_TypeContrainte.Size = New System.Drawing.Size(214, 131)
        Me.GroupBox_TypeContrainte.TabIndex = 2
        Me.GroupBox_TypeContrainte.TabStop = False
        Me.GroupBox_TypeContrainte.Text = "Application des contraintes"
        '
        'CheckBox_Variable
        '
        Me.CheckBox_Variable.AutoSize = True
        Me.CheckBox_Variable.Location = New System.Drawing.Point(6, 83)
        Me.CheckBox_Variable.Name = "CheckBox_Variable"
        Me.CheckBox_Variable.Size = New System.Drawing.Size(85, 24)
        Me.CheckBox_Variable.TabIndex = 1
        Me.CheckBox_Variable.Text = "Variable"
        Me.CheckBox_Variable.UseVisualStyleBackColor = True
        '
        'CheckBox_Constante
        '
        Me.CheckBox_Constante.AutoSize = True
        Me.CheckBox_Constante.Location = New System.Drawing.Point(6, 26)
        Me.CheckBox_Constante.Name = "CheckBox_Constante"
        Me.CheckBox_Constante.Size = New System.Drawing.Size(97, 24)
        Me.CheckBox_Constante.TabIndex = 0
        Me.CheckBox_Constante.Text = "Constante"
        Me.CheckBox_Constante.UseVisualStyleBackColor = True
        '
        'GroupBox_EffortsC
        '
        Me.GroupBox_EffortsC.Controls.Add(Me.TextBox_ECF)
        Me.GroupBox_EffortsC.Controls.Add(Me.TextBox_ECA)
        Me.GroupBox_EffortsC.Controls.Add(Me.Label_ECF)
        Me.GroupBox_EffortsC.Controls.Add(Me.Label_ECA)
        Me.GroupBox_EffortsC.Location = New System.Drawing.Point(252, 12)
        Me.GroupBox_EffortsC.Name = "GroupBox_EffortsC"
        Me.GroupBox_EffortsC.Size = New System.Drawing.Size(250, 131)
        Me.GroupBox_EffortsC.TabIndex = 3
        Me.GroupBox_EffortsC.TabStop = False
        Me.GroupBox_EffortsC.Text = "Efforts (N)"
        '
        'TextBox_ECF
        '
        Me.TextBox_ECF.Location = New System.Drawing.Point(75, 85)
        Me.TextBox_ECF.Name = "TextBox_ECF"
        Me.TextBox_ECF.Size = New System.Drawing.Size(125, 27)
        Me.TextBox_ECF.TabIndex = 3
        '
        'TextBox_ECA
        '
        Me.TextBox_ECA.Location = New System.Drawing.Point(75, 27)
        Me.TextBox_ECA.Name = "TextBox_ECA"
        Me.TextBox_ECA.Size = New System.Drawing.Size(125, 27)
        Me.TextBox_ECA.TabIndex = 2
        '
        'Label_ECF
        '
        Me.Label_ECF.AutoSize = True
        Me.Label_ECF.Location = New System.Drawing.Point(10, 87)
        Me.Label_ECF.Name = "Label_ECF"
        Me.Label_ECF.Size = New System.Drawing.Size(59, 20)
        Me.Label_ECF.TabIndex = 1
        Me.Label_ECF.Text = "Flexion:"
        '
        'Label_ECA
        '
        Me.Label_ECA.AutoSize = True
        Me.Label_ECA.Location = New System.Drawing.Point(10, 31)
        Me.Label_ECA.Name = "Label_ECA"
        Me.Label_ECA.Size = New System.Drawing.Size(45, 20)
        Me.Label_ECA.TabIndex = 0
        Me.Label_ECA.Text = "Axial:"
        '
        'GroupBox_EffortsV
        '
        Me.GroupBox_EffortsV.Controls.Add(Me.TextBox_EVFMax)
        Me.GroupBox_EffortsV.Controls.Add(Me.TextBox_EVAMax)
        Me.GroupBox_EffortsV.Controls.Add(Me.TextBox_EVFMin)
        Me.GroupBox_EffortsV.Controls.Add(Me.TextBox_EVAMin)
        Me.GroupBox_EffortsV.Controls.Add(Me.Label_Max)
        Me.GroupBox_EffortsV.Controls.Add(Me.Label_Min)
        Me.GroupBox_EffortsV.Controls.Add(Me.Label_EVF)
        Me.GroupBox_EffortsV.Controls.Add(Me.Label_EVA)
        Me.GroupBox_EffortsV.Location = New System.Drawing.Point(529, 12)
        Me.GroupBox_EffortsV.Name = "GroupBox_EffortsV"
        Me.GroupBox_EffortsV.Size = New System.Drawing.Size(383, 131)
        Me.GroupBox_EffortsV.TabIndex = 4
        Me.GroupBox_EffortsV.TabStop = False
        Me.GroupBox_EffortsV.Text = "Efforts (N ou N-mm)"
        '
        'TextBox_EVFMax
        '
        Me.TextBox_EVFMax.Location = New System.Drawing.Point(212, 87)
        Me.TextBox_EVFMax.Name = "TextBox_EVFMax"
        Me.TextBox_EVFMax.Size = New System.Drawing.Size(125, 27)
        Me.TextBox_EVFMax.TabIndex = 7
        '
        'TextBox_EVAMax
        '
        Me.TextBox_EVAMax.Location = New System.Drawing.Point(212, 54)
        Me.TextBox_EVAMax.Name = "TextBox_EVAMax"
        Me.TextBox_EVAMax.Size = New System.Drawing.Size(125, 27)
        Me.TextBox_EVAMax.TabIndex = 6
        '
        'TextBox_EVFMin
        '
        Me.TextBox_EVFMin.Location = New System.Drawing.Point(68, 87)
        Me.TextBox_EVFMin.Name = "TextBox_EVFMin"
        Me.TextBox_EVFMin.Size = New System.Drawing.Size(125, 27)
        Me.TextBox_EVFMin.TabIndex = 5
        '
        'TextBox_EVAMin
        '
        Me.TextBox_EVAMin.Location = New System.Drawing.Point(68, 54)
        Me.TextBox_EVAMin.Name = "TextBox_EVAMin"
        Me.TextBox_EVAMin.Size = New System.Drawing.Size(125, 27)
        Me.TextBox_EVAMin.TabIndex = 4
        '
        'Label_Max
        '
        Me.Label_Max.AutoSize = True
        Me.Label_Max.Location = New System.Drawing.Point(255, 27)
        Me.Label_Max.Name = "Label_Max"
        Me.Label_Max.Size = New System.Drawing.Size(37, 20)
        Me.Label_Max.TabIndex = 4
        Me.Label_Max.Text = "Max"
        '
        'Label_Min
        '
        Me.Label_Min.AutoSize = True
        Me.Label_Min.Location = New System.Drawing.Point(112, 27)
        Me.Label_Min.Name = "Label_Min"
        Me.Label_Min.Size = New System.Drawing.Size(34, 20)
        Me.Label_Min.TabIndex = 3
        Me.Label_Min.Text = "Min"
        '
        'Label_EVF
        '
        Me.Label_EVF.AutoSize = True
        Me.Label_EVF.Location = New System.Drawing.Point(6, 90)
        Me.Label_EVF.Name = "Label_EVF"
        Me.Label_EVF.Size = New System.Drawing.Size(59, 20)
        Me.Label_EVF.TabIndex = 2
        Me.Label_EVF.Text = "Flexion:"
        '
        'Label_EVA
        '
        Me.Label_EVA.AutoSize = True
        Me.Label_EVA.Location = New System.Drawing.Point(17, 60)
        Me.Label_EVA.Name = "Label_EVA"
        Me.Label_EVA.Size = New System.Drawing.Size(45, 20)
        Me.Label_EVA.TabIndex = 2
        Me.Label_EVA.Text = "Axial:"
        '
        'CheckBox_EAxial
        '
        Me.CheckBox_EAxial.AutoSize = True
        Me.CheckBox_EAxial.Location = New System.Drawing.Point(6, 28)
        Me.CheckBox_EAxial.Name = "CheckBox_EAxial"
        Me.CheckBox_EAxial.Size = New System.Drawing.Size(75, 24)
        Me.CheckBox_EAxial.TabIndex = 5
        Me.CheckBox_EAxial.Text = "Axiaux"
        Me.CheckBox_EAxial.UseVisualStyleBackColor = True
        '
        'CheckBox_EFlexion
        '
        Me.CheckBox_EFlexion.AutoSize = True
        Me.CheckBox_EFlexion.Location = New System.Drawing.Point(6, 58)
        Me.CheckBox_EFlexion.Name = "CheckBox_EFlexion"
        Me.CheckBox_EFlexion.Size = New System.Drawing.Size(78, 24)
        Me.CheckBox_EFlexion.TabIndex = 6
        Me.CheckBox_EFlexion.Text = "Flexion"
        Me.CheckBox_EFlexion.UseVisualStyleBackColor = True
        '
        'CheckBox_EAxialeF
        '
        Me.CheckBox_EAxialeF.AutoSize = True
        Me.CheckBox_EAxialeF.Location = New System.Drawing.Point(6, 88)
        Me.CheckBox_EAxialeF.Name = "CheckBox_EAxialeF"
        Me.CheckBox_EAxialeF.Size = New System.Drawing.Size(141, 24)
        Me.CheckBox_EAxialeF.TabIndex = 7
        Me.CheckBox_EAxialeF.Text = "Axiaux et flexion"
        Me.CheckBox_EAxialeF.UseVisualStyleBackColor = True
        '
        'GroupBox_Efforts
        '
        Me.GroupBox_Efforts.Controls.Add(Me.CheckBox_EAxialeF)
        Me.GroupBox_Efforts.Controls.Add(Me.CheckBox_EFlexion)
        Me.GroupBox_Efforts.Controls.Add(Me.CheckBox_EAxial)
        Me.GroupBox_Efforts.Location = New System.Drawing.Point(13, 148)
        Me.GroupBox_Efforts.Name = "GroupBox_Efforts"
        Me.GroupBox_Efforts.Size = New System.Drawing.Size(214, 118)
        Me.GroupBox_Efforts.TabIndex = 5
        Me.GroupBox_Efforts.TabStop = False
        Me.GroupBox_Efforts.Text = "Types d'efforts"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 293)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Température:"
        '
        'TextBox_temperature
        '
        Me.TextBox_temperature.Location = New System.Drawing.Point(115, 290)
        Me.TextBox_temperature.Name = "TextBox_temperature"
        Me.TextBox_temperature.Size = New System.Drawing.Size(72, 27)
        Me.TextBox_temperature.TabIndex = 4
        '
        'Button_valider
        '
        Me.Button_valider.Location = New System.Drawing.Point(1108, 566)
        Me.Button_valider.Name = "Button_valider"
        Me.Button_valider.Size = New System.Drawing.Size(180, 63)
        Me.Button_valider.TabIndex = 6
        Me.Button_valider.Text = "Valider"
        Me.Button_valider.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(193, 293)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "degrés Celsius"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Fa:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Fm:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Ma:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 126)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 20)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Mm:"
        '
        'Label_fa
        '
        Me.Label_fa.AutoSize = True
        Me.Label_fa.Location = New System.Drawing.Point(67, 26)
        Me.Label_fa.Name = "Label_fa"
        Me.Label_fa.Size = New System.Drawing.Size(23, 20)
        Me.Label_fa.TabIndex = 12
        Me.Label_fa.Text = "Fa"
        '
        'Label_fm
        '
        Me.Label_fm.AutoSize = True
        Me.Label_fm.Location = New System.Drawing.Point(67, 59)
        Me.Label_fm.Name = "Label_fm"
        Me.Label_fm.Size = New System.Drawing.Size(23, 20)
        Me.Label_fm.TabIndex = 13
        Me.Label_fm.Text = "Fa"
        '
        'Label_ma
        '
        Me.Label_ma.AutoSize = True
        Me.Label_ma.Location = New System.Drawing.Point(67, 91)
        Me.Label_ma.Name = "Label_ma"
        Me.Label_ma.Size = New System.Drawing.Size(23, 20)
        Me.Label_ma.TabIndex = 14
        Me.Label_ma.Text = "Fa"
        '
        'Label_mm
        '
        Me.Label_mm.AutoSize = True
        Me.Label_mm.Location = New System.Drawing.Point(67, 126)
        Me.Label_mm.Name = "Label_mm"
        Me.Label_mm.Size = New System.Drawing.Size(23, 20)
        Me.Label_mm.TabIndex = 15
        Me.Label_mm.Text = "Fa"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(Me.Label_mm)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label_ma)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label_fm)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label_fa)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Location = New System.Drawing.Point(918, 149)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(191, 179)
        Me.Panel2.TabIndex = 17
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label_sigmaAF)
        Me.Panel1.Controls.Add(Me.Label_sigmaMf)
        Me.Panel1.Controls.Add(Me.Label_sigmaA)
        Me.Panel1.Controls.Add(Me.Label_sigmaM)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(918, 368)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(242, 133)
        Me.Panel1.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(22, 105)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 20)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Sigma_Af:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(22, 77)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 20)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Sigma_Mf:"
        '
        'Label_sigmaAF
        '
        Me.Label_sigmaAF.AutoSize = True
        Me.Label_sigmaAF.Location = New System.Drawing.Point(98, 105)
        Me.Label_sigmaAF.Name = "Label_sigmaAF"
        Me.Label_sigmaAF.Size = New System.Drawing.Size(72, 20)
        Me.Label_sigmaAF.TabIndex = 20
        Me.Label_sigmaAF.Text = "Sigma_Af"
        '
        'Label_sigmaMf
        '
        Me.Label_sigmaMf.AutoSize = True
        Me.Label_sigmaMf.Location = New System.Drawing.Point(98, 77)
        Me.Label_sigmaMf.Name = "Label_sigmaMf"
        Me.Label_sigmaMf.Size = New System.Drawing.Size(75, 20)
        Me.Label_sigmaMf.TabIndex = 19
        Me.Label_sigmaMf.Text = "Sigma_Mf"
        '
        'Label_sigmaA
        '
        Me.Label_sigmaA.AutoSize = True
        Me.Label_sigmaA.Location = New System.Drawing.Point(98, 46)
        Me.Label_sigmaA.Name = "Label_sigmaA"
        Me.Label_sigmaA.Size = New System.Drawing.Size(67, 20)
        Me.Label_sigmaA.TabIndex = 3
        Me.Label_sigmaA.Text = "Sigma_A"
        '
        'Label_sigmaM
        '
        Me.Label_sigmaM.AutoSize = True
        Me.Label_sigmaM.Location = New System.Drawing.Point(98, 16)
        Me.Label_sigmaM.Name = "Label_sigmaM"
        Me.Label_sigmaM.Size = New System.Drawing.Size(70, 20)
        Me.Label_sigmaM.TabIndex = 2
        Me.Label_sigmaM.Text = "Sigma_M"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(22, 46)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 20)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Sigma_Aa:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sigma_Ma:"
        '
        'Efforts_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1300, 658)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button_valider)
        Me.Controls.Add(Me.TextBox_temperature)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox_Efforts)
        Me.Controls.Add(Me.GroupBox_EffortsV)
        Me.Controls.Add(Me.GroupBox_EffortsC)
        Me.Controls.Add(Me.GroupBox_TypeContrainte)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Efforts_Form"
        Me.Text = "Efforts_Form"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_TypeContrainte.ResumeLayout(False)
        Me.GroupBox_TypeContrainte.PerformLayout()
        Me.GroupBox_EffortsC.ResumeLayout(False)
        Me.GroupBox_EffortsC.PerformLayout()
        Me.GroupBox_EffortsV.ResumeLayout(False)
        Me.GroupBox_EffortsV.PerformLayout()
        Me.GroupBox_Efforts.ResumeLayout(False)
        Me.GroupBox_Efforts.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox_TypeContrainte As GroupBox
    Friend WithEvents CheckBox_Variable As CheckBox
    Friend WithEvents CheckBox_Constante As CheckBox
    Friend WithEvents GroupBox_EffortsC As GroupBox
    Friend WithEvents GroupBox_EffortsV As GroupBox
    Friend WithEvents CheckBox_EAxial As CheckBox
    Friend WithEvents CheckBox_EFlexion As CheckBox
    Friend WithEvents CheckBox_EAxialeF As CheckBox
    Friend WithEvents GroupBox_Efforts As GroupBox
    Friend WithEvents Label_ECF As Label
    Friend WithEvents Label_ECA As Label
    Friend WithEvents Label_Min As Label
    Friend WithEvents Label_EVF As Label
    Friend WithEvents Label_EVA As Label
    Friend WithEvents Label_Max As Label
    Friend WithEvents TextBox_ECF As TextBox
    Friend WithEvents TextBox_ECA As TextBox
    Friend WithEvents TextBox_EVFMax As TextBox
    Friend WithEvents TextBox_EVAMax As TextBox
    Friend WithEvents TextBox_EVFMin As TextBox
    Friend WithEvents TextBox_EVAMin As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox_temperature As TextBox
    Friend WithEvents Button_valider As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label_fa As Label
    Friend WithEvents Label_fm As Label
    Friend WithEvents Label_ma As Label
    Friend WithEvents Label_mm As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label_sigmaA As Label
    Friend WithEvents Label_sigmaM As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label_sigmaAF As Label
    Friend WithEvents Label_sigmaMf As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
End Class
