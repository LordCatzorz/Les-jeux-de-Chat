<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPause
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
        Me.picRetourJeu = New System.Windows.Forms.PictureBox()
        Me.picRetourMenu = New System.Windows.Forms.PictureBox()
        Me.picInstructions = New System.Windows.Forms.PictureBox()
        Me.picQuitterJeu = New System.Windows.Forms.PictureBox()
        Me.btnRetourJeu = New System.Windows.Forms.Button()
        Me.btnRetourMenu = New System.Windows.Forms.Button()
        Me.btnInstructions = New System.Windows.Forms.Button()
        Me.btnQuitterJeu = New System.Windows.Forms.Button()
        CType(Me.picRetourJeu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRetourMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picInstructions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picQuitterJeu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picRetourJeu
        '
        Me.picRetourJeu.BackColor = System.Drawing.Color.Transparent
        Me.picRetourJeu.Location = New System.Drawing.Point(23, 25)
        Me.picRetourJeu.Name = "picRetourJeu"
        Me.picRetourJeu.Size = New System.Drawing.Size(42, 42)
        Me.picRetourJeu.TabIndex = 4
        Me.picRetourJeu.TabStop = False
        '
        'picRetourMenu
        '
        Me.picRetourMenu.BackColor = System.Drawing.Color.Transparent
        Me.picRetourMenu.Location = New System.Drawing.Point(25, 93)
        Me.picRetourMenu.Name = "picRetourMenu"
        Me.picRetourMenu.Size = New System.Drawing.Size(42, 42)
        Me.picRetourMenu.TabIndex = 5
        Me.picRetourMenu.TabStop = False
        '
        'picInstructions
        '
        Me.picInstructions.BackColor = System.Drawing.Color.Transparent
        Me.picInstructions.Location = New System.Drawing.Point(52, 155)
        Me.picInstructions.Name = "picInstructions"
        Me.picInstructions.Size = New System.Drawing.Size(42, 42)
        Me.picInstructions.TabIndex = 6
        Me.picInstructions.TabStop = False
        '
        'picQuitterJeu
        '
        Me.picQuitterJeu.BackColor = System.Drawing.Color.Transparent
        Me.picQuitterJeu.Location = New System.Drawing.Point(48, 234)
        Me.picQuitterJeu.Name = "picQuitterJeu"
        Me.picQuitterJeu.Size = New System.Drawing.Size(42, 42)
        Me.picQuitterJeu.TabIndex = 7
        Me.picQuitterJeu.TabStop = False
        '
        'btnRetourJeu
        '
        Me.btnRetourJeu.BackgroundImage = Global.JeuxDeChat.My.Resources.Resources.Real_Wall128x1281
        Me.btnRetourJeu.FlatAppearance.BorderSize = 0
        Me.btnRetourJeu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRetourJeu.Font = New System.Drawing.Font("Viner Hand ITC", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRetourJeu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnRetourJeu.Location = New System.Drawing.Point(63, 21)
        Me.btnRetourJeu.Name = "btnRetourJeu"
        Me.btnRetourJeu.Size = New System.Drawing.Size(220, 62)
        Me.btnRetourJeu.TabIndex = 8
        Me.btnRetourJeu.Text = "Retour au jeu"
        Me.btnRetourJeu.UseVisualStyleBackColor = True
        '
        'btnRetourMenu
        '
        Me.btnRetourMenu.BackgroundImage = Global.JeuxDeChat.My.Resources.Resources.Real_Wall128x1281
        Me.btnRetourMenu.FlatAppearance.BorderSize = 0
        Me.btnRetourMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRetourMenu.Font = New System.Drawing.Font("Viner Hand ITC", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRetourMenu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnRetourMenu.Location = New System.Drawing.Point(85, 84)
        Me.btnRetourMenu.Name = "btnRetourMenu"
        Me.btnRetourMenu.Size = New System.Drawing.Size(239, 62)
        Me.btnRetourMenu.TabIndex = 9
        Me.btnRetourMenu.Text = "Retour au menu"
        Me.btnRetourMenu.UseVisualStyleBackColor = True
        '
        'btnInstructions
        '
        Me.btnInstructions.BackgroundImage = Global.JeuxDeChat.My.Resources.Resources.Real_Wall128x1281
        Me.btnInstructions.FlatAppearance.BorderSize = 0
        Me.btnInstructions.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInstructions.Font = New System.Drawing.Font("Viner Hand ITC", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInstructions.ForeColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnInstructions.Location = New System.Drawing.Point(96, 149)
        Me.btnInstructions.Name = "btnInstructions"
        Me.btnInstructions.Size = New System.Drawing.Size(220, 62)
        Me.btnInstructions.TabIndex = 10
        Me.btnInstructions.Text = "Instructions"
        Me.btnInstructions.UseVisualStyleBackColor = True
        '
        'btnQuitterJeu
        '
        Me.btnQuitterJeu.BackgroundImage = Global.JeuxDeChat.My.Resources.Resources.Real_Wall128x1281
        Me.btnQuitterJeu.FlatAppearance.BorderSize = 0
        Me.btnQuitterJeu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuitterJeu.Font = New System.Drawing.Font("Viner Hand ITC", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitterJeu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnQuitterJeu.Location = New System.Drawing.Point(97, 234)
        Me.btnQuitterJeu.Name = "btnQuitterJeu"
        Me.btnQuitterJeu.Size = New System.Drawing.Size(220, 62)
        Me.btnQuitterJeu.TabIndex = 11
        Me.btnQuitterJeu.Text = "Quitter le jeu"
        Me.btnQuitterJeu.UseVisualStyleBackColor = True
        '
        'frmPause
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.JeuxDeChat.My.Resources.Resources.pause7
        Me.ClientSize = New System.Drawing.Size(320, 420)
        Me.Controls.Add(Me.btnQuitterJeu)
        Me.Controls.Add(Me.btnInstructions)
        Me.Controls.Add(Me.btnRetourMenu)
        Me.Controls.Add(Me.btnRetourJeu)
        Me.Controls.Add(Me.picQuitterJeu)
        Me.Controls.Add(Me.picInstructions)
        Me.Controls.Add(Me.picRetourMenu)
        Me.Controls.Add(Me.picRetourJeu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPause"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form1"
        CType(Me.picRetourJeu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRetourMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picInstructions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picQuitterJeu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picRetourJeu As System.Windows.Forms.PictureBox
    Friend WithEvents picRetourMenu As System.Windows.Forms.PictureBox
    Friend WithEvents picInstructions As System.Windows.Forms.PictureBox
    Friend WithEvents picQuitterJeu As System.Windows.Forms.PictureBox
    Friend WithEvents btnRetourJeu As System.Windows.Forms.Button
    Friend WithEvents btnRetourMenu As System.Windows.Forms.Button
    Friend WithEvents btnInstructions As System.Windows.Forms.Button
    Friend WithEvents btnQuitterJeu As System.Windows.Forms.Button
End Class
