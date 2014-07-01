<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPartiePerduNouveauMeilleurScore
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
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.lblNouveauScore = New System.Windows.Forms.Label()
        Me.lblInscrireNom = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(51, 67)
        Me.txtNom.MaxLength = 8
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(165, 20)
        Me.txtNom.TabIndex = 0
        '
        'lblNouveauScore
        '
        Me.lblNouveauScore.AutoSize = True
        Me.lblNouveauScore.BackColor = System.Drawing.Color.Transparent
        Me.lblNouveauScore.Font = New System.Drawing.Font("Viner Hand ITC", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNouveauScore.ForeColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblNouveauScore.Location = New System.Drawing.Point(27, 1)
        Me.lblNouveauScore.Name = "lblNouveauScore"
        Me.lblNouveauScore.Size = New System.Drawing.Size(162, 29)
        Me.lblNouveauScore.TabIndex = 1
        Me.lblNouveauScore.Text = "Nouveau Top 10!"
        '
        'lblInscrireNom
        '
        Me.lblInscrireNom.AutoSize = True
        Me.lblInscrireNom.BackColor = System.Drawing.Color.Transparent
        Me.lblInscrireNom.Font = New System.Drawing.Font("Viner Hand ITC", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInscrireNom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblInscrireNom.Location = New System.Drawing.Point(39, 41)
        Me.lblInscrireNom.Name = "lblInscrireNom"
        Me.lblInscrireNom.Size = New System.Drawing.Size(209, 29)
        Me.lblInscrireNom.TabIndex = 2
        Me.lblInscrireNom.Text = "Inscrivez votre nom : "
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.Transparent
        Me.btnOK.FlatAppearance.BorderSize = 0
        Me.btnOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOK.Font = New System.Drawing.Font("Viner Hand ITC", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.ForeColor = System.Drawing.Color.White
        Me.btnOK.Location = New System.Drawing.Point(86, 93)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(103, 28)
        Me.btnOK.TabIndex = 3
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'frmGameLostNewHighScore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.JeuxDeChat.My.Resources.Resources.Real_Wall128x1281
        Me.ClientSize = New System.Drawing.Size(284, 125)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.lblInscrireNom)
        Me.Controls.Add(Me.lblNouveauScore)
        Me.Controls.Add(Me.txtNom)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmGameLostNewHighScore"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmGameLostNewHighScore"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNom As System.Windows.Forms.TextBox
    Friend WithEvents lblNouveauScore As System.Windows.Forms.Label
    Friend WithEvents lblInscrireNom As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
End Class
