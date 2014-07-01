<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIntroduction
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIntroduction))
        Me.lblIntroduction = New System.Windows.Forms.Label()
        Me.btnSuivant = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblIntroduction
        '
        Me.lblIntroduction.AutoSize = True
        Me.lblIntroduction.BackColor = System.Drawing.Color.Transparent
        Me.lblIntroduction.Font = New System.Drawing.Font("Viner Hand ITC", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntroduction.ForeColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.lblIntroduction.Location = New System.Drawing.Point(18, 37)
        Me.lblIntroduction.MaximumSize = New System.Drawing.Size(340, 0)
        Me.lblIntroduction.Name = "lblIntroduction"
        Me.lblIntroduction.Size = New System.Drawing.Size(0, 31)
        Me.lblIntroduction.TabIndex = 0
        '
        'btnSuivant
        '
        Me.btnSuivant.Font = New System.Drawing.Font("Viner Hand ITC", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuivant.ForeColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnSuivant.Location = New System.Drawing.Point(127, 283)
        Me.btnSuivant.Name = "btnSuivant"
        Me.btnSuivant.Size = New System.Drawing.Size(75, 23)
        Me.btnSuivant.TabIndex = 1
        Me.btnSuivant.UseVisualStyleBackColor = True
        '
        'frmIntroduction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(355, 347)
        Me.Controls.Add(Me.btnSuivant)
        Me.Controls.Add(Me.lblIntroduction)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmIntroduction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblIntroduction As System.Windows.Forms.Label
    Friend WithEvents btnSuivant As System.Windows.Forms.Button
End Class
