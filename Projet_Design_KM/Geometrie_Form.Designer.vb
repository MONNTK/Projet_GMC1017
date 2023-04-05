<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Geometrie_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Geometrie_Form))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CheckBox_PEpaulement = New System.Windows.Forms.CheckBox()
        Me.CheckBox_PEncoche = New System.Windows.Forms.CheckBox()
        Me.CheckBox_PTrou = New System.Windows.Forms.CheckBox()
        Me.Button_Valider = New System.Windows.Forms.Button()
        Me.GroupBox_Dimensions = New System.Windows.Forms.GroupBox()
        Me.TextBox_r = New System.Windows.Forms.TextBox()
        Me.TextBox_D = New System.Windows.Forms.TextBox()
        Me.TextBox_Plarg = New System.Windows.Forms.TextBox()
        Me.TextBox_e = New System.Windows.Forms.TextBox()
        Me.TextBox_L = New System.Windows.Forms.TextBox()
        Me.Label_r = New System.Windows.Forms.Label()
        Me.Label_D = New System.Windows.Forms.Label()
        Me.Label_plarg = New System.Windows.Forms.Label()
        Me.Label_e = New System.Windows.Forms.Label()
        Me.Label_L = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label_inertie2 = New System.Windows.Forms.Label()
        Me.Label_Inertie1 = New System.Windows.Forms.Label()
        Me.Label_surface = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label_Surf = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox_Dimensions.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(376, 40)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(361, 209)
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 53)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(337, 196)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(778, 53)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(314, 209)
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.Controls.Add(Me.CheckBox_PEpaulement)
        Me.Panel1.Controls.Add(Me.CheckBox_PEncoche)
        Me.Panel1.Controls.Add(Me.CheckBox_PTrou)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Location = New System.Drawing.Point(78, 44)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1116, 284)
        Me.Panel1.TabIndex = 6
        '
        'CheckBox_PEpaulement
        '
        Me.CheckBox_PEpaulement.AutoSize = True
        Me.CheckBox_PEpaulement.Location = New System.Drawing.Point(846, 14)
        Me.CheckBox_PEpaulement.Name = "CheckBox_PEpaulement"
        Me.CheckBox_PEpaulement.Size = New System.Drawing.Size(193, 24)
        Me.CheckBox_PEpaulement.TabIndex = 9
        Me.CheckBox_PEpaulement.Text = "Plaque avec épaulement"
        Me.CheckBox_PEpaulement.UseVisualStyleBackColor = True
        '
        'CheckBox_PEncoche
        '
        Me.CheckBox_PEncoche.AutoSize = True
        Me.CheckBox_PEncoche.Location = New System.Drawing.Point(463, 14)
        Me.CheckBox_PEncoche.Name = "CheckBox_PEncoche"
        Me.CheckBox_PEncoche.Size = New System.Drawing.Size(175, 24)
        Me.CheckBox_PEncoche.TabIndex = 8
        Me.CheckBox_PEncoche.Text = "Plaque avec encoches"
        Me.CheckBox_PEncoche.UseVisualStyleBackColor = True
        '
        'CheckBox_PTrou
        '
        Me.CheckBox_PTrou.AutoSize = True
        Me.CheckBox_PTrou.Location = New System.Drawing.Point(110, 14)
        Me.CheckBox_PTrou.Name = "CheckBox_PTrou"
        Me.CheckBox_PTrou.Size = New System.Drawing.Size(141, 24)
        Me.CheckBox_PTrou.TabIndex = 7
        Me.CheckBox_PTrou.Text = "Plaque avec trou"
        Me.CheckBox_PTrou.UseVisualStyleBackColor = True
        '
        'Button_Valider
        '
        Me.Button_Valider.Location = New System.Drawing.Point(1098, 556)
        Me.Button_Valider.Name = "Button_Valider"
        Me.Button_Valider.Size = New System.Drawing.Size(190, 72)
        Me.Button_Valider.TabIndex = 7
        Me.Button_Valider.Text = "Valider"
        Me.Button_Valider.UseVisualStyleBackColor = True
        '
        'GroupBox_Dimensions
        '
        Me.GroupBox_Dimensions.Controls.Add(Me.TextBox_r)
        Me.GroupBox_Dimensions.Controls.Add(Me.TextBox_D)
        Me.GroupBox_Dimensions.Controls.Add(Me.TextBox_Plarg)
        Me.GroupBox_Dimensions.Controls.Add(Me.TextBox_e)
        Me.GroupBox_Dimensions.Controls.Add(Me.TextBox_L)
        Me.GroupBox_Dimensions.Controls.Add(Me.Label_r)
        Me.GroupBox_Dimensions.Controls.Add(Me.Label_D)
        Me.GroupBox_Dimensions.Controls.Add(Me.Label_plarg)
        Me.GroupBox_Dimensions.Controls.Add(Me.Label_e)
        Me.GroupBox_Dimensions.Controls.Add(Me.Label_L)
        Me.GroupBox_Dimensions.Location = New System.Drawing.Point(79, 358)
        Me.GroupBox_Dimensions.Name = "GroupBox_Dimensions"
        Me.GroupBox_Dimensions.Size = New System.Drawing.Size(317, 206)
        Me.GroupBox_Dimensions.TabIndex = 8
        Me.GroupBox_Dimensions.TabStop = False
        Me.GroupBox_Dimensions.Text = "Dimensions (mm)"
        '
        'TextBox_r
        '
        Me.TextBox_r.Location = New System.Drawing.Point(149, 162)
        Me.TextBox_r.Name = "TextBox_r"
        Me.TextBox_r.Size = New System.Drawing.Size(125, 27)
        Me.TextBox_r.TabIndex = 9
        '
        'TextBox_D
        '
        Me.TextBox_D.Location = New System.Drawing.Point(149, 129)
        Me.TextBox_D.Name = "TextBox_D"
        Me.TextBox_D.Size = New System.Drawing.Size(125, 27)
        Me.TextBox_D.TabIndex = 8
        '
        'TextBox_Plarg
        '
        Me.TextBox_Plarg.Location = New System.Drawing.Point(149, 96)
        Me.TextBox_Plarg.Name = "TextBox_Plarg"
        Me.TextBox_Plarg.Size = New System.Drawing.Size(125, 27)
        Me.TextBox_Plarg.TabIndex = 7
        '
        'TextBox_e
        '
        Me.TextBox_e.Location = New System.Drawing.Point(149, 63)
        Me.TextBox_e.Name = "TextBox_e"
        Me.TextBox_e.Size = New System.Drawing.Size(125, 27)
        Me.TextBox_e.TabIndex = 6
        '
        'TextBox_L
        '
        Me.TextBox_L.Location = New System.Drawing.Point(149, 30)
        Me.TextBox_L.Name = "TextBox_L"
        Me.TextBox_L.Size = New System.Drawing.Size(125, 27)
        Me.TextBox_L.TabIndex = 5
        '
        'Label_r
        '
        Me.Label_r.AutoSize = True
        Me.Label_r.Location = New System.Drawing.Point(16, 165)
        Me.Label_r.Name = "Label_r"
        Me.Label_r.Size = New System.Drawing.Size(72, 20)
        Me.Label_r.TabIndex = 4
        Me.Label_r.Text = "Rayon (r):"
        '
        'Label_D
        '
        Me.Label_D.AutoSize = True
        Me.Label_D.Location = New System.Drawing.Point(16, 132)
        Me.Label_D.Name = "Label_D"
        Me.Label_D.Size = New System.Drawing.Size(99, 20)
        Me.Label_D.TabIndex = 3
        Me.Label_D.Text = "Diamètre (D):"
        '
        'Label_plarg
        '
        Me.Label_plarg.AutoSize = True
        Me.Label_plarg.Location = New System.Drawing.Point(15, 99)
        Me.Label_plarg.Name = "Label_plarg"
        Me.Label_plarg.Size = New System.Drawing.Size(118, 20)
        Me.Label_plarg.TabIndex = 2
        Me.Label_plarg.Text = "Petite largeur (l):"
        '
        'Label_e
        '
        Me.Label_e.AutoSize = True
        Me.Label_e.Location = New System.Drawing.Point(16, 66)
        Me.Label_e.Name = "Label_e"
        Me.Label_e.Size = New System.Drawing.Size(96, 20)
        Me.Label_e.TabIndex = 1
        Me.Label_e.Text = "Épaisseur (e):"
        '
        'Label_L
        '
        Me.Label_L.AutoSize = True
        Me.Label_L.Location = New System.Drawing.Point(16, 33)
        Me.Label_L.Name = "Label_L"
        Me.Label_L.Size = New System.Drawing.Size(83, 20)
        Me.Label_L.TabIndex = 0
        Me.Label_L.Text = "Largeur (L):"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel2.Location = New System.Drawing.Point(75, 40)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1123, 292)
        Me.Panel2.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label_inertie2)
        Me.GroupBox1.Controls.Add(Me.Label_Inertie1)
        Me.GroupBox1.Controls.Add(Me.Label_surface)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label_Surf)
        Me.GroupBox1.Location = New System.Drawing.Point(648, 358)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(431, 138)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Paramètres de calculs"
        '
        'Label_inertie2
        '
        Me.Label_inertie2.AutoSize = True
        Me.Label_inertie2.Location = New System.Drawing.Point(270, 99)
        Me.Label_inertie2.Name = "Label_inertie2"
        Me.Label_inertie2.Size = New System.Drawing.Size(64, 20)
        Me.Label_inertie2.TabIndex = 16
        Me.Label_inertie2.Text = "x mm^4"
        '
        'Label_Inertie1
        '
        Me.Label_Inertie1.AutoSize = True
        Me.Label_Inertie1.Location = New System.Drawing.Point(270, 66)
        Me.Label_Inertie1.Name = "Label_Inertie1"
        Me.Label_Inertie1.Size = New System.Drawing.Size(64, 20)
        Me.Label_Inertie1.TabIndex = 15
        Me.Label_Inertie1.Text = "x mm^4"
        '
        'Label_surface
        '
        Me.Label_surface.AutoSize = True
        Me.Label_surface.Location = New System.Drawing.Point(270, 33)
        Me.Label_surface.Name = "Label_surface"
        Me.Label_surface.Size = New System.Drawing.Size(64, 20)
        Me.Label_surface.TabIndex = 14
        Me.Label_surface.Text = "x mm^2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(251, 20)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Moment d'inertie (plaque avec trou):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Moment d'inertie:"
        '
        'Label_Surf
        '
        Me.Label_Surf.AutoSize = True
        Me.Label_Surf.Location = New System.Drawing.Point(15, 33)
        Me.Label_Surf.Name = "Label_Surf"
        Me.Label_Surf.Size = New System.Drawing.Size(155, 20)
        Me.Label_Surf.TabIndex = 10
        Me.Label_Surf.Text = "Surface de section (S):"
        '
        'Geometrie_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1300, 658)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox_Dimensions)
        Me.Controls.Add(Me.Button_Valider)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Geometrie_Form"
        Me.Text = "Geometrie_Form"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox_Dimensions.ResumeLayout(False)
        Me.GroupBox_Dimensions.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CheckBox_PEpaulement As CheckBox
    Friend WithEvents CheckBox_PEncoche As CheckBox
    Friend WithEvents CheckBox_PTrou As CheckBox
    Friend WithEvents Button_Valider As Button
    Friend WithEvents GroupBox_Dimensions As GroupBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox_L As TextBox
    Friend WithEvents Label_r As Label
    Friend WithEvents Label_D As Label
    Friend WithEvents Label_plarg As Label
    Friend WithEvents Label_e As Label
    Friend WithEvents Label_L As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox_r As TextBox
    Friend WithEvents TextBox_D As TextBox
    Friend WithEvents TextBox_Plarg As TextBox
    Friend WithEvents TextBox_e As TextBox
    Friend WithEvents Label_inertie2 As Label
    Friend WithEvents Label_Inertie1 As Label
    Friend WithEvents Label_surface As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label_Surf As Label
End Class
