<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInstructions
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
        Me.btnRetour = New System.Windows.Forms.Button()
        Me.VsbInstruction = New System.Windows.Forms.VScrollBar()
        Me.picInstruction = New System.Windows.Forms.PictureBox()
        Me.picContourBouton = New System.Windows.Forms.PictureBox()
        CType(Me.picInstruction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picContourBouton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRetour
        '
        Me.btnRetour.BackgroundImage = Global.JeuxDeChat.My.Resources.Resources.Real_Wall128x1281
        Me.btnRetour.FlatAppearance.BorderSize = 0
        Me.btnRetour.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnRetour.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnRetour.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRetour.Font = New System.Drawing.Font("Viner Hand ITC", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRetour.ForeColor = System.Drawing.Color.White
        Me.btnRetour.Location = New System.Drawing.Point(42, 384)
        Me.btnRetour.Name = "btnRetour"
        Me.btnRetour.Size = New System.Drawing.Size(162, 38)
        Me.btnRetour.TabIndex = 0
        Me.btnRetour.Text = "Retour"
        Me.btnRetour.UseVisualStyleBackColor = True
        '
        'VsbInstruction
        '
        Me.VsbInstruction.Location = New System.Drawing.Point(256, 0)
        Me.VsbInstruction.Name = "VsbInstruction"
        Me.VsbInstruction.Size = New System.Drawing.Size(20, 438)
        Me.VsbInstruction.TabIndex = 1
        Me.VsbInstruction.TabStop = True
        '
        'picInstruction
        '
        Me.picInstruction.BackColor = System.Drawing.Color.Transparent
        Me.picInstruction.Image = Global.JeuxDeChat.My.Resources.Resources.frmInstructionFW_2
        Me.picInstruction.Location = New System.Drawing.Point(0, 0)
        Me.picInstruction.Name = "picInstruction"
        Me.picInstruction.Size = New System.Drawing.Size(256, 710)
        Me.picInstruction.TabIndex = 2
        Me.picInstruction.TabStop = False
        '
        'picContourBouton
        '
        Me.picContourBouton.BackgroundImage = Global.JeuxDeChat.My.Resources.Resources.Real_Wall128x1281
        Me.picContourBouton.Location = New System.Drawing.Point(0, 384)
        Me.picContourBouton.Name = "picContourBouton"
        Me.picContourBouton.Size = New System.Drawing.Size(256, 54)
        Me.picContourBouton.TabIndex = 3
        Me.picContourBouton.TabStop = False
        '
        'frmInstructions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.BackgroundImage = Global.JeuxDeChat.My.Resources.Resources.Real_Wall128x1281
        Me.ClientSize = New System.Drawing.Size(276, 436)
        Me.Controls.Add(Me.btnRetour)
        Me.Controls.Add(Me.VsbInstruction)
        Me.Controls.Add(Me.picContourBouton)
        Me.Controls.Add(Me.picInstruction)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInstructions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Instructions"
        CType(Me.picInstruction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picContourBouton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnRetour As System.Windows.Forms.Button
    Friend WithEvents VsbInstruction As System.Windows.Forms.VScrollBar
    Friend WithEvents picInstruction As System.Windows.Forms.PictureBox
    Friend WithEvents picContourBouton As System.Windows.Forms.PictureBox
End Class
