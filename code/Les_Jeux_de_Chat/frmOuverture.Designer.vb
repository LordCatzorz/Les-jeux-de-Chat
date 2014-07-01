<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOuverture
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
        Me.btnJouer = New System.Windows.Forms.Button()
        Me.btnMeilleursScores = New System.Windows.Forms.Button()
        Me.btnInstructions = New System.Windows.Forms.Button()
        Me.btnQuitter = New System.Windows.Forms.Button()
        Me.lblTitreJeu = New System.Windows.Forms.Label()
        Me.cboDifficulte = New System.Windows.Forms.ComboBox()
        Me.chkPasserIntroduction = New System.Windows.Forms.CheckBox()
        Me.picJouer = New System.Windows.Forms.PictureBox()
        Me.picInstruction = New System.Windows.Forms.PictureBox()
        Me.picMeilleursScores = New System.Windows.Forms.PictureBox()
        Me.picQuitter = New System.Windows.Forms.PictureBox()
        CType(Me.picJouer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picInstruction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMeilleursScores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picQuitter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnJouer
        '
        Me.btnJouer.BackColor = System.Drawing.Color.Transparent
        Me.btnJouer.BackgroundImage = Global.JeuxDeChat.My.Resources.Resources.castle_wall_texture
        Me.btnJouer.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnJouer.FlatAppearance.BorderSize = 0
        Me.btnJouer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJouer.Font = New System.Drawing.Font("Viner Hand ITC", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJouer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnJouer.Location = New System.Drawing.Point(87, 86)
        Me.btnJouer.Name = "btnJouer"
        Me.btnJouer.Size = New System.Drawing.Size(197, 98)
        Me.btnJouer.TabIndex = 0
        Me.btnJouer.Text = "Jouer"
        Me.btnJouer.UseVisualStyleBackColor = False
        '
        'btnMeilleursScores
        '
        Me.btnMeilleursScores.BackgroundImage = Global.JeuxDeChat.My.Resources.Resources.castle_wall_texture
        Me.btnMeilleursScores.FlatAppearance.BorderSize = 0
        Me.btnMeilleursScores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMeilleursScores.Font = New System.Drawing.Font("Viner Hand ITC", 19.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMeilleursScores.ForeColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnMeilleursScores.Location = New System.Drawing.Point(86, 256)
        Me.btnMeilleursScores.Name = "btnMeilleursScores"
        Me.btnMeilleursScores.Size = New System.Drawing.Size(239, 53)
        Me.btnMeilleursScores.TabIndex = 3
        Me.btnMeilleursScores.Text = "Meilleurs Scores"
        Me.btnMeilleursScores.UseVisualStyleBackColor = True
        '
        'btnInstructions
        '
        Me.btnInstructions.BackgroundImage = Global.JeuxDeChat.My.Resources.Resources.castle_wall_texture
        Me.btnInstructions.FlatAppearance.BorderSize = 0
        Me.btnInstructions.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInstructions.Font = New System.Drawing.Font("Viner Hand ITC", 20.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInstructions.ForeColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnInstructions.Location = New System.Drawing.Point(171, 205)
        Me.btnInstructions.Name = "btnInstructions"
        Me.btnInstructions.Size = New System.Drawing.Size(174, 45)
        Me.btnInstructions.TabIndex = 2
        Me.btnInstructions.Text = "Instructions"
        Me.btnInstructions.UseVisualStyleBackColor = True
        '
        'btnQuitter
        '
        Me.btnQuitter.BackgroundImage = Global.JeuxDeChat.My.Resources.Resources.castle_wall_texture
        Me.btnQuitter.FlatAppearance.BorderSize = 0
        Me.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuitter.Font = New System.Drawing.Font("Viner Hand ITC", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnQuitter.Location = New System.Drawing.Point(171, 339)
        Me.btnQuitter.Name = "btnQuitter"
        Me.btnQuitter.Size = New System.Drawing.Size(171, 54)
        Me.btnQuitter.TabIndex = 4
        Me.btnQuitter.Text = "Quitter"
        Me.btnQuitter.UseVisualStyleBackColor = True
        '
        'lblTitreJeu
        '
        Me.lblTitreJeu.AutoSize = True
        Me.lblTitreJeu.BackColor = System.Drawing.Color.Transparent
        Me.lblTitreJeu.Font = New System.Drawing.Font("Viner Hand ITC", 38.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitreJeu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.lblTitreJeu.Location = New System.Drawing.Point(-3, 0)
        Me.lblTitreJeu.Name = "lblTitreJeu"
        Me.lblTitreJeu.Size = New System.Drawing.Size(426, 82)
        Me.lblTitreJeu.TabIndex = 6
        Me.lblTitreJeu.Text = "Les Jeux de Chat"
        '
        'cboDifficulte
        '
        Me.cboDifficulte.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.cboDifficulte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboDifficulte.Font = New System.Drawing.Font("Viner Hand ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDifficulte.ForeColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.cboDifficulte.FormattingEnabled = True
        Me.cboDifficulte.Items.AddRange(New Object() {"Difficulté:Esclave", "Difficulté:Gladiateur"})
        Me.cboDifficulte.Location = New System.Drawing.Point(174, 175)
        Me.cboDifficulte.Name = "cboDifficulte"
        Me.cboDifficulte.Size = New System.Drawing.Size(179, 34)
        Me.cboDifficulte.TabIndex = 1
        Me.cboDifficulte.Text = "Niveau de difficulté"
        '
        'chkPasserIntroduction
        '
        Me.chkPasserIntroduction.AutoSize = True
        Me.chkPasserIntroduction.BackColor = System.Drawing.Color.Transparent
        Me.chkPasserIntroduction.Font = New System.Drawing.Font("Viner Hand ITC", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPasserIntroduction.ForeColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.chkPasserIntroduction.Location = New System.Drawing.Point(151, 388)
        Me.chkPasserIntroduction.Name = "chkPasserIntroduction"
        Me.chkPasserIntroduction.Size = New System.Drawing.Size(194, 31)
        Me.chkPasserIntroduction.TabIndex = 5
        Me.chkPasserIntroduction.Text = "Passer l'introduction"
        Me.chkPasserIntroduction.UseVisualStyleBackColor = False
        '
        'picJouer
        '
        Me.picJouer.BackColor = System.Drawing.Color.Transparent
        Me.picJouer.Location = New System.Drawing.Point(40, 116)
        Me.picJouer.Name = "picJouer"
        Me.picJouer.Size = New System.Drawing.Size(42, 42)
        Me.picJouer.TabIndex = 7
        Me.picJouer.TabStop = False
        '
        'picInstruction
        '
        Me.picInstruction.BackColor = System.Drawing.Color.Transparent
        Me.picInstruction.Location = New System.Drawing.Point(115, 197)
        Me.picInstruction.Name = "picInstruction"
        Me.picInstruction.Size = New System.Drawing.Size(42, 42)
        Me.picInstruction.TabIndex = 8
        Me.picInstruction.TabStop = False
        '
        'picTopDix
        '
        Me.picMeilleursScores.BackColor = System.Drawing.Color.Transparent
        Me.picMeilleursScores.Location = New System.Drawing.Point(65, 256)
        Me.picMeilleursScores.Name = "picTopDix"
        Me.picMeilleursScores.Size = New System.Drawing.Size(42, 42)
        Me.picMeilleursScores.TabIndex = 9
        Me.picMeilleursScores.TabStop = False
        '
        'picQuitter
        '
        Me.picQuitter.BackColor = System.Drawing.Color.Transparent
        Me.picQuitter.Location = New System.Drawing.Point(131, 332)
        Me.picQuitter.Name = "picQuitter"
        Me.picQuitter.Size = New System.Drawing.Size(42, 42)
        Me.picQuitter.TabIndex = 10
        Me.picQuitter.TabStop = False
        '
        'frmOuverture
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.JeuxDeChat.My.Resources.Resources.castle_wall_texture
        Me.ClientSize = New System.Drawing.Size(411, 426)
        Me.Controls.Add(Me.picQuitter)
        Me.Controls.Add(Me.picMeilleursScores)
        Me.Controls.Add(Me.picInstruction)
        Me.Controls.Add(Me.picJouer)
        Me.Controls.Add(Me.chkPasserIntroduction)
        Me.Controls.Add(Me.cboDifficulte)
        Me.Controls.Add(Me.lblTitreJeu)
        Me.Controls.Add(Me.btnQuitter)
        Me.Controls.Add(Me.btnInstructions)
        Me.Controls.Add(Me.btnMeilleursScores)
        Me.Controls.Add(Me.btnJouer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmOuverture"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormulaireOuverturevb"
        CType(Me.picJouer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picInstruction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMeilleursScores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picQuitter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnJouer As System.Windows.Forms.Button
    Friend WithEvents btnMeilleursScores As System.Windows.Forms.Button
    Friend WithEvents btnInstructions As System.Windows.Forms.Button
    Friend WithEvents btnQuitter As System.Windows.Forms.Button
    Friend WithEvents lblTitreJeu As System.Windows.Forms.Label
    Friend WithEvents cboDifficulte As System.Windows.Forms.ComboBox
    Friend WithEvents chkPasserIntroduction As System.Windows.Forms.CheckBox
    Friend WithEvents picJouer As System.Windows.Forms.PictureBox
    Friend WithEvents picInstruction As System.Windows.Forms.PictureBox
    Friend WithEvents picMeilleursScores As System.Windows.Forms.PictureBox
    Friend WithEvents picQuitter As System.Windows.Forms.PictureBox
End Class
