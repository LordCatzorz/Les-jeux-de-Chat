<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVousAvezPerdu
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRetourAuMenu = New System.Windows.Forms.Button()
        Me.btnQuitter = New System.Windows.Forms.Button()
        Me.btnRejouer = New System.Windows.Forms.Button()
        Me.picRejouer = New System.Windows.Forms.PictureBox()
        Me.picRetourMenu = New System.Windows.Forms.PictureBox()
        Me.picQuitter = New System.Windows.Forms.PictureBox()
        CType(Me.picRejouer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRetourMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picQuitter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Viner Hand ITC", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(19, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(253, 52)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Vous êtes mort!"
        '
        'btnRetourAuMenu
        '
        Me.btnRetourAuMenu.BackColor = System.Drawing.Color.Transparent
        Me.btnRetourAuMenu.FlatAppearance.BorderSize = 0
        Me.btnRetourAuMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnRetourAuMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnRetourAuMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRetourAuMenu.Font = New System.Drawing.Font("Viner Hand ITC", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRetourAuMenu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnRetourAuMenu.Location = New System.Drawing.Point(50, 108)
        Me.btnRetourAuMenu.Name = "btnRetourAuMenu"
        Me.btnRetourAuMenu.Size = New System.Drawing.Size(188, 45)
        Me.btnRetourAuMenu.TabIndex = 2
        Me.btnRetourAuMenu.Text = "Retour au menu"
        Me.btnRetourAuMenu.UseVisualStyleBackColor = False
        '
        'btnQuitter
        '
        Me.btnQuitter.BackColor = System.Drawing.Color.Transparent
        Me.btnQuitter.FlatAppearance.BorderSize = 0
        Me.btnQuitter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnQuitter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuitter.Font = New System.Drawing.Font("Viner Hand ITC", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnQuitter.Location = New System.Drawing.Point(86, 147)
        Me.btnQuitter.Name = "btnQuitter"
        Me.btnQuitter.Size = New System.Drawing.Size(115, 39)
        Me.btnQuitter.TabIndex = 3
        Me.btnQuitter.Text = "Quitter"
        Me.btnQuitter.UseVisualStyleBackColor = False
        '
        'btnRejouer
        '
        Me.btnRejouer.BackColor = System.Drawing.Color.Transparent
        Me.btnRejouer.FlatAppearance.BorderSize = 0
        Me.btnRejouer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnRejouer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnRejouer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRejouer.Font = New System.Drawing.Font("Viner Hand ITC", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRejouer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnRejouer.Location = New System.Drawing.Point(88, 64)
        Me.btnRejouer.Name = "btnRejouer"
        Me.btnRejouer.Size = New System.Drawing.Size(116, 50)
        Me.btnRejouer.TabIndex = 1
        Me.btnRejouer.Text = "Rejouer"
        Me.btnRejouer.UseVisualStyleBackColor = False
        '
        'picRejouer
        '
        Me.picRejouer.BackColor = System.Drawing.Color.Transparent
        Me.picRejouer.Location = New System.Drawing.Point(39, 67)
        Me.picRejouer.Name = "picRejouer"
        Me.picRejouer.Size = New System.Drawing.Size(42, 42)
        Me.picRejouer.TabIndex = 4
        Me.picRejouer.TabStop = False
        '
        'picRetourMenu
        '
        Me.picRetourMenu.BackColor = System.Drawing.Color.Transparent
        Me.picRetourMenu.Location = New System.Drawing.Point(3, 108)
        Me.picRetourMenu.Name = "picRetourMenu"
        Me.picRetourMenu.Size = New System.Drawing.Size(42, 42)
        Me.picRetourMenu.TabIndex = 5
        Me.picRetourMenu.TabStop = False
        '
        'picQuitter
        '
        Me.picQuitter.BackColor = System.Drawing.Color.Transparent
        Me.picQuitter.Location = New System.Drawing.Point(39, 147)
        Me.picQuitter.Name = "picQuitter"
        Me.picQuitter.Size = New System.Drawing.Size(42, 42)
        Me.picQuitter.TabIndex = 6
        Me.picQuitter.TabStop = False
        '
        'frmVousAvezPerdu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.JeuxDeChat.My.Resources.Resources.Real_Wall128x1281
        Me.ClientSize = New System.Drawing.Size(288, 198)
        Me.Controls.Add(Me.picQuitter)
        Me.Controls.Add(Me.picRetourMenu)
        Me.Controls.Add(Me.picRejouer)
        Me.Controls.Add(Me.btnQuitter)
        Me.Controls.Add(Me.btnRetourAuMenu)
        Me.Controls.Add(Me.btnRejouer)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmVousAvezPerdu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmVousAvezPerdu"
        CType(Me.picRejouer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRetourMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picQuitter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnRetourAuMenu As System.Windows.Forms.Button
    Friend WithEvents btnQuitter As System.Windows.Forms.Button
    Friend WithEvents btnRejouer As System.Windows.Forms.Button
    Friend WithEvents picRejouer As System.Windows.Forms.PictureBox
    Friend WithEvents picRetourMenu As System.Windows.Forms.PictureBox
    Friend WithEvents picQuitter As System.Windows.Forms.PictureBox
End Class
