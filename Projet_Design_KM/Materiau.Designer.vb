<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Materiau
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
        Me.Group_Type_Mat = New System.Windows.Forms.GroupBox()
        Me.Check_Fragile = New System.Windows.Forms.CheckBox()
        Me.Check_Ductile = New System.Windows.Forms.CheckBox()
        Me.GroupBox_Ductile_Mat = New System.Windows.Forms.GroupBox()
        Me.CheckBox_Alliage = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Acier = New System.Windows.Forms.CheckBox()
        Me.GroupBox_Fragile = New System.Windows.Forms.GroupBox()
        Me.CheckBox_AutreFragile = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Fonte = New System.Windows.Forms.CheckBox()
        Me.GroupBox_ParametresMat = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox_Sy = New System.Windows.Forms.TextBox()
        Me.TextBox_Suc = New System.Windows.Forms.TextBox()
        Me.TextBox_Sut = New System.Windows.Forms.TextBox()
        Me.Label_Sy = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button_Confirmer = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBox_Fini = New System.Windows.Forms.ComboBox()
        Me.Group_Type_Mat.SuspendLayout()
        Me.GroupBox_Ductile_Mat.SuspendLayout()
        Me.GroupBox_Fragile.SuspendLayout()
        Me.GroupBox_ParametresMat.SuspendLayout()
        Me.SuspendLayout()
        '
        'Group_Type_Mat
        '
        Me.Group_Type_Mat.Controls.Add(Me.Check_Fragile)
        Me.Group_Type_Mat.Controls.Add(Me.Check_Ductile)
        Me.Group_Type_Mat.Location = New System.Drawing.Point(12, 32)
        Me.Group_Type_Mat.Name = "Group_Type_Mat"
        Me.Group_Type_Mat.Size = New System.Drawing.Size(165, 100)
        Me.Group_Type_Mat.TabIndex = 2
        Me.Group_Type_Mat.TabStop = False
        Me.Group_Type_Mat.Text = "Type de matériau"
        '
        'Check_Fragile
        '
        Me.Check_Fragile.AutoSize = True
        Me.Check_Fragile.Location = New System.Drawing.Point(10, 59)
        Me.Check_Fragile.Name = "Check_Fragile"
        Me.Check_Fragile.Size = New System.Drawing.Size(76, 24)
        Me.Check_Fragile.TabIndex = 3
        Me.Check_Fragile.Text = "Fragile"
        Me.Check_Fragile.UseVisualStyleBackColor = True
        '
        'Check_Ductile
        '
        Me.Check_Ductile.AutoSize = True
        Me.Check_Ductile.Location = New System.Drawing.Point(10, 29)
        Me.Check_Ductile.Name = "Check_Ductile"
        Me.Check_Ductile.Size = New System.Drawing.Size(78, 24)
        Me.Check_Ductile.TabIndex = 0
        Me.Check_Ductile.Text = "Ductile"
        Me.Check_Ductile.UseVisualStyleBackColor = True
        '
        'GroupBox_Ductile_Mat
        '
        Me.GroupBox_Ductile_Mat.Controls.Add(Me.CheckBox_Alliage)
        Me.GroupBox_Ductile_Mat.Controls.Add(Me.CheckBox_Acier)
        Me.GroupBox_Ductile_Mat.Location = New System.Drawing.Point(220, 32)
        Me.GroupBox_Ductile_Mat.Name = "GroupBox_Ductile_Mat"
        Me.GroupBox_Ductile_Mat.Size = New System.Drawing.Size(299, 100)
        Me.GroupBox_Ductile_Mat.TabIndex = 3
        Me.GroupBox_Ductile_Mat.TabStop = False
        Me.GroupBox_Ductile_Mat.Text = "Nature du matériau"
        '
        'CheckBox_Alliage
        '
        Me.CheckBox_Alliage.AutoSize = True
        Me.CheckBox_Alliage.Location = New System.Drawing.Point(10, 56)
        Me.CheckBox_Alliage.Name = "CheckBox_Alliage"
        Me.CheckBox_Alliage.Size = New System.Drawing.Size(287, 24)
        Me.CheckBox_Alliage.TabIndex = 1
        Me.CheckBox_Alliage.Text = "Alliage d'aluminium ou de magnésium"
        Me.CheckBox_Alliage.UseVisualStyleBackColor = True
        '
        'CheckBox_Acier
        '
        Me.CheckBox_Acier.AutoSize = True
        Me.CheckBox_Acier.Location = New System.Drawing.Point(10, 26)
        Me.CheckBox_Acier.Name = "CheckBox_Acier"
        Me.CheckBox_Acier.Size = New System.Drawing.Size(65, 24)
        Me.CheckBox_Acier.TabIndex = 0
        Me.CheckBox_Acier.Text = "Acier"
        Me.CheckBox_Acier.UseVisualStyleBackColor = True
        '
        'GroupBox_Fragile
        '
        Me.GroupBox_Fragile.Controls.Add(Me.CheckBox_AutreFragile)
        Me.GroupBox_Fragile.Controls.Add(Me.CheckBox_Fonte)
        Me.GroupBox_Fragile.Location = New System.Drawing.Point(566, 32)
        Me.GroupBox_Fragile.Name = "GroupBox_Fragile"
        Me.GroupBox_Fragile.Size = New System.Drawing.Size(299, 100)
        Me.GroupBox_Fragile.TabIndex = 4
        Me.GroupBox_Fragile.TabStop = False
        Me.GroupBox_Fragile.Text = "Nature du matériau"
        '
        'CheckBox_AutreFragile
        '
        Me.CheckBox_AutreFragile.AutoSize = True
        Me.CheckBox_AutreFragile.Location = New System.Drawing.Point(10, 56)
        Me.CheckBox_AutreFragile.Name = "CheckBox_AutreFragile"
        Me.CheckBox_AutreFragile.Size = New System.Drawing.Size(177, 24)
        Me.CheckBox_AutreFragile.TabIndex = 1
        Me.CheckBox_AutreFragile.Text = "Autre matériau fragile"
        Me.CheckBox_AutreFragile.UseVisualStyleBackColor = True
        '
        'CheckBox_Fonte
        '
        Me.CheckBox_Fonte.AutoSize = True
        Me.CheckBox_Fonte.Location = New System.Drawing.Point(10, 26)
        Me.CheckBox_Fonte.Name = "CheckBox_Fonte"
        Me.CheckBox_Fonte.Size = New System.Drawing.Size(68, 24)
        Me.CheckBox_Fonte.TabIndex = 0
        Me.CheckBox_Fonte.Text = "Fonte"
        Me.CheckBox_Fonte.UseVisualStyleBackColor = True
        '
        'GroupBox_ParametresMat
        '
        Me.GroupBox_ParametresMat.Controls.Add(Me.Label6)
        Me.GroupBox_ParametresMat.Controls.Add(Me.Label5)
        Me.GroupBox_ParametresMat.Controls.Add(Me.TextBox_Sy)
        Me.GroupBox_ParametresMat.Controls.Add(Me.TextBox_Suc)
        Me.GroupBox_ParametresMat.Controls.Add(Me.TextBox_Sut)
        Me.GroupBox_ParametresMat.Controls.Add(Me.Label_Sy)
        Me.GroupBox_ParametresMat.Controls.Add(Me.Label4)
        Me.GroupBox_ParametresMat.Controls.Add(Me.Label3)
        Me.GroupBox_ParametresMat.Controls.Add(Me.Label2)
        Me.GroupBox_ParametresMat.Location = New System.Drawing.Point(12, 152)
        Me.GroupBox_ParametresMat.Name = "GroupBox_ParametresMat"
        Me.GroupBox_ParametresMat.Size = New System.Drawing.Size(505, 150)
        Me.GroupBox_ParametresMat.TabIndex = 6
        Me.GroupBox_ParametresMat.TabStop = False
        Me.GroupBox_ParametresMat.Text = "Paramètres du matériau"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(411, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 20)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "MPa"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(411, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 20)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "MPa"
        '
        'TextBox_Sy
        '
        Me.TextBox_Sy.Location = New System.Drawing.Point(280, 93)
        Me.TextBox_Sy.Name = "TextBox_Sy"
        Me.TextBox_Sy.Size = New System.Drawing.Size(125, 27)
        Me.TextBox_Sy.TabIndex = 11
        '
        'TextBox_Suc
        '
        Me.TextBox_Suc.Location = New System.Drawing.Point(280, 60)
        Me.TextBox_Suc.Name = "TextBox_Suc"
        Me.TextBox_Suc.Size = New System.Drawing.Size(125, 27)
        Me.TextBox_Suc.TabIndex = 10
        '
        'TextBox_Sut
        '
        Me.TextBox_Sut.Location = New System.Drawing.Point(280, 27)
        Me.TextBox_Sut.Name = "TextBox_Sut"
        Me.TextBox_Sut.Size = New System.Drawing.Size(125, 27)
        Me.TextBox_Sut.TabIndex = 9
        '
        'Label_Sy
        '
        Me.Label_Sy.AutoSize = True
        Me.Label_Sy.Location = New System.Drawing.Point(411, 67)
        Me.Label_Sy.Name = "Label_Sy"
        Me.Label_Sy.Size = New System.Drawing.Size(37, 20)
        Me.Label_Sy.TabIndex = 8
        Me.Label_Sy.Text = "MPa"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(146, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Limite élastique (Sy):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(244, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Limite ultime en compression (Suc):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(206, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Limite ultime en tension (Sut):"
        '
        'Button_Confirmer
        '
        Me.Button_Confirmer.Location = New System.Drawing.Point(1020, 561)
        Me.Button_Confirmer.Name = "Button_Confirmer"
        Me.Button_Confirmer.Size = New System.Drawing.Size(255, 67)
        Me.Button_Confirmer.TabIndex = 7
        Me.Button_Confirmer.Text = "Confirmer les paramètres"
        Me.Button_Confirmer.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 326)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 20)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Fini de surface:"
        '
        'ComboBox_Fini
        '
        Me.ComboBox_Fini.FormattingEnabled = True
        Me.ComboBox_Fini.Items.AddRange(New Object() {"Poli", "Meulé", "Usiné ou écrouit", "Laminé à chaud", "Forgé"})
        Me.ComboBox_Fini.Location = New System.Drawing.Point(126, 323)
        Me.ComboBox_Fini.Name = "ComboBox_Fini"
        Me.ComboBox_Fini.Size = New System.Drawing.Size(151, 28)
        Me.ComboBox_Fini.TabIndex = 16
        '
        'Materiau
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1300, 658)
        Me.Controls.Add(Me.ComboBox_Fini)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button_Confirmer)
        Me.Controls.Add(Me.GroupBox_ParametresMat)
        Me.Controls.Add(Me.GroupBox_Fragile)
        Me.Controls.Add(Me.GroupBox_Ductile_Mat)
        Me.Controls.Add(Me.Group_Type_Mat)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Materiau"
        Me.Text = "Form2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Group_Type_Mat.ResumeLayout(False)
        Me.Group_Type_Mat.PerformLayout()
        Me.GroupBox_Ductile_Mat.ResumeLayout(False)
        Me.GroupBox_Ductile_Mat.PerformLayout()
        Me.GroupBox_Fragile.ResumeLayout(False)
        Me.GroupBox_Fragile.PerformLayout()
        Me.GroupBox_ParametresMat.ResumeLayout(False)
        Me.GroupBox_ParametresMat.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Group_Type_Mat As GroupBox
    Friend WithEvents Check_Fragile As CheckBox
    Friend WithEvents Check_Ductile As CheckBox
    Friend WithEvents GroupBox_Ductile_Mat As GroupBox
    Friend WithEvents CheckBox_Alliage As CheckBox
    Friend WithEvents CheckBox_Acier As CheckBox
    Friend WithEvents GroupBox_Fragile As GroupBox
    Friend WithEvents CheckBox_AutreFragile As CheckBox
    Friend WithEvents CheckBox_Fonte As CheckBox
    Friend WithEvents GroupBox_ParametresMat As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox_Sy As TextBox
    Friend WithEvents TextBox_Suc As TextBox
    Friend WithEvents TextBox_Sut As TextBox
    Friend WithEvents Label_Sy As Label
    Friend WithEvents Button_Confirmer As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBox_Fini As ComboBox
End Class
