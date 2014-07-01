<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsumo
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
        Me.components = New System.ComponentModel.Container()
        Me.timerBougerObjet = New System.Windows.Forms.Timer(Me.components)
        Me.timerCreationObjet = New System.Windows.Forms.Timer(Me.components)
        Me.pnlZoneDeJeu = New System.Windows.Forms.Panel()
        Me.picBombeAnimation6 = New System.Windows.Forms.PictureBox()
        Me.picBombeAnimation4 = New System.Windows.Forms.PictureBox()
        Me.picBombeAnimation5 = New System.Windows.Forms.PictureBox()
        Me.picBombeAnimation3 = New System.Windows.Forms.PictureBox()
        Me.picBombeAnimation1 = New System.Windows.Forms.PictureBox()
        Me.picBombeAnimation2 = New System.Windows.Forms.PictureBox()
        Me.picPersonnageJoueur = New System.Windows.Forms.PictureBox()
        Me.lblNombreDeVie = New System.Windows.Forms.Label()
        Me.lblPointage = New System.Windows.Forms.Label()
        Me.lblPointActuel = New System.Windows.Forms.Label()
        Me.picPremiereVie = New System.Windows.Forms.PictureBox()
        Me.picDeuxiemeVie = New System.Windows.Forms.PictureBox()
        Me.picTroisiemeVie = New System.Windows.Forms.PictureBox()
        Me.picQuatriemeVie = New System.Windows.Forms.PictureBox()
        Me.picCinquiemeVie = New System.Windows.Forms.PictureBox()
        Me.picSixiemeVie = New System.Windows.Forms.PictureBox()
        Me.picSeptiemeVie = New System.Windows.Forms.PictureBox()
        Me.picHuitiemeVie = New System.Windows.Forms.PictureBox()
        Me.picNeuviemeVie = New System.Windows.Forms.PictureBox()
        Me.timerAnimation = New System.Windows.Forms.Timer(Me.components)
        Me.timerChatMassacrer = New System.Windows.Forms.Timer(Me.components)
        Me.pnlZoneDeJeu.SuspendLayout()
        CType(Me.picBombeAnimation6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBombeAnimation4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBombeAnimation5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBombeAnimation3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBombeAnimation1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBombeAnimation2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPersonnageJoueur, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPremiereVie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDeuxiemeVie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTroisiemeVie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picQuatriemeVie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCinquiemeVie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSixiemeVie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSeptiemeVie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHuitiemeVie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picNeuviemeVie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'timerBougerObjet
        '
        Me.timerBougerObjet.Interval = 25
        '
        'timerCreationObjet
        '
        '
        'pnlZoneDeJeu
        '
        Me.pnlZoneDeJeu.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.pnlZoneDeJeu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlZoneDeJeu.Controls.Add(Me.picBombeAnimation6)
        Me.pnlZoneDeJeu.Controls.Add(Me.picBombeAnimation4)
        Me.pnlZoneDeJeu.Controls.Add(Me.picBombeAnimation5)
        Me.pnlZoneDeJeu.Controls.Add(Me.picBombeAnimation3)
        Me.pnlZoneDeJeu.Controls.Add(Me.picBombeAnimation1)
        Me.pnlZoneDeJeu.Controls.Add(Me.picBombeAnimation2)
        Me.pnlZoneDeJeu.Controls.Add(Me.picPersonnageJoueur)
        Me.pnlZoneDeJeu.Location = New System.Drawing.Point(128, 109)
        Me.pnlZoneDeJeu.Name = "pnlZoneDeJeu"
        Me.pnlZoneDeJeu.Size = New System.Drawing.Size(736, 514)
        Me.pnlZoneDeJeu.TabIndex = 0
        '
        'picBombeAnimation6
        '
        Me.picBombeAnimation6.BackgroundImage = Global.JeuxDeChat.My.Resources.Resources.Bombe
        Me.picBombeAnimation6.Location = New System.Drawing.Point(377, 365)
        Me.picBombeAnimation6.Name = "picBombeAnimation6"
        Me.picBombeAnimation6.Size = New System.Drawing.Size(42, 42)
        Me.picBombeAnimation6.TabIndex = 11
        Me.picBombeAnimation6.TabStop = False
        Me.picBombeAnimation6.Tag = "Mauvais;2"
        '
        'picBombeAnimation4
        '
        Me.picBombeAnimation4.BackgroundImage = Global.JeuxDeChat.My.Resources.Resources.Bombe
        Me.picBombeAnimation4.Location = New System.Drawing.Point(471, 234)
        Me.picBombeAnimation4.Name = "picBombeAnimation4"
        Me.picBombeAnimation4.Size = New System.Drawing.Size(42, 42)
        Me.picBombeAnimation4.TabIndex = 10
        Me.picBombeAnimation4.TabStop = False
        Me.picBombeAnimation4.Tag = "Mauvais;1"
        '
        'picBombeAnimation5
        '
        Me.picBombeAnimation5.BackgroundImage = Global.JeuxDeChat.My.Resources.Resources.Bombe
        Me.picBombeAnimation5.Location = New System.Drawing.Point(320, 365)
        Me.picBombeAnimation5.Name = "picBombeAnimation5"
        Me.picBombeAnimation5.Size = New System.Drawing.Size(42, 42)
        Me.picBombeAnimation5.TabIndex = 9
        Me.picBombeAnimation5.TabStop = False
        Me.picBombeAnimation5.Tag = "Mauvais;2"
        '
        'picBombeAnimation3
        '
        Me.picBombeAnimation3.BackgroundImage = Global.JeuxDeChat.My.Resources.Resources.Bombe
        Me.picBombeAnimation3.Location = New System.Drawing.Point(223, 234)
        Me.picBombeAnimation3.Name = "picBombeAnimation3"
        Me.picBombeAnimation3.Size = New System.Drawing.Size(42, 42)
        Me.picBombeAnimation3.TabIndex = 8
        Me.picBombeAnimation3.TabStop = False
        Me.picBombeAnimation3.Tag = "Mauvais;3"
        '
        'picBombeAnimation1
        '
        Me.picBombeAnimation1.BackgroundImage = Global.JeuxDeChat.My.Resources.Resources.Bombe
        Me.picBombeAnimation1.Location = New System.Drawing.Point(320, 121)
        Me.picBombeAnimation1.Name = "picBombeAnimation1"
        Me.picBombeAnimation1.Size = New System.Drawing.Size(42, 42)
        Me.picBombeAnimation1.TabIndex = 2
        Me.picBombeAnimation1.TabStop = False
        Me.picBombeAnimation1.Tag = "Mauvais;0"
        '
        'picBombeAnimation2
        '
        Me.picBombeAnimation2.BackgroundImage = Global.JeuxDeChat.My.Resources.Resources.Bombe
        Me.picBombeAnimation2.Location = New System.Drawing.Point(377, 121)
        Me.picBombeAnimation2.Name = "picBombeAnimation2"
        Me.picBombeAnimation2.Size = New System.Drawing.Size(42, 42)
        Me.picBombeAnimation2.TabIndex = 1
        Me.picBombeAnimation2.TabStop = False
        Me.picBombeAnimation2.Tag = "Mauvais;0"
        '
        'picPersonnageJoueur
        '
        Me.picPersonnageJoueur.Image = Global.JeuxDeChat.My.Resources.Resources.Chat_50x_50
        Me.picPersonnageJoueur.Location = New System.Drawing.Point(343, 232)
        Me.picPersonnageJoueur.Name = "picPersonnageJoueur"
        Me.picPersonnageJoueur.Size = New System.Drawing.Size(50, 50)
        Me.picPersonnageJoueur.TabIndex = 0
        Me.picPersonnageJoueur.TabStop = False
        '
        'lblNombreDeVie
        '
        Me.lblNombreDeVie.AutoSize = True
        Me.lblNombreDeVie.BackColor = System.Drawing.Color.Transparent
        Me.lblNombreDeVie.Location = New System.Drawing.Point(136, 26)
        Me.lblNombreDeVie.Name = "lblNombreDeVie"
        Me.lblNombreDeVie.Size = New System.Drawing.Size(76, 13)
        Me.lblNombreDeVie.TabIndex = 1
        Me.lblNombreDeVie.Text = "Nombre de vie"
        '
        'lblPointage
        '
        Me.lblPointage.AutoSize = True
        Me.lblPointage.BackColor = System.Drawing.Color.Transparent
        Me.lblPointage.Location = New System.Drawing.Point(687, 24)
        Me.lblPointage.Name = "lblPointage"
        Me.lblPointage.Size = New System.Drawing.Size(36, 13)
        Me.lblPointage.TabIndex = 2
        Me.lblPointage.Text = "Points"
        '
        'lblPointActuel
        '
        Me.lblPointActuel.AutoSize = True
        Me.lblPointActuel.BackColor = System.Drawing.Color.Transparent
        Me.lblPointActuel.Location = New System.Drawing.Point(784, 27)
        Me.lblPointActuel.Name = "lblPointActuel"
        Me.lblPointActuel.Size = New System.Drawing.Size(13, 13)
        Me.lblPointActuel.TabIndex = 3
        Me.lblPointActuel.Text = "0"
        '
        'picPremiereVie
        '
        Me.picPremiereVie.BackColor = System.Drawing.Color.Transparent
        Me.picPremiereVie.Image = Global.JeuxDeChat.My.Resources.Resources.Coeur19x19
        Me.picPremiereVie.Location = New System.Drawing.Point(418, 24)
        Me.picPremiereVie.Name = "picPremiereVie"
        Me.picPremiereVie.Size = New System.Drawing.Size(19, 19)
        Me.picPremiereVie.TabIndex = 12
        Me.picPremiereVie.TabStop = False
        '
        'picDeuxiemeVie
        '
        Me.picDeuxiemeVie.BackColor = System.Drawing.Color.Transparent
        Me.picDeuxiemeVie.Image = Global.JeuxDeChat.My.Resources.Resources.Coeur19x19
        Me.picDeuxiemeVie.Location = New System.Drawing.Point(393, 24)
        Me.picDeuxiemeVie.Name = "picDeuxiemeVie"
        Me.picDeuxiemeVie.Size = New System.Drawing.Size(19, 19)
        Me.picDeuxiemeVie.TabIndex = 11
        Me.picDeuxiemeVie.TabStop = False
        '
        'picTroisiemeVie
        '
        Me.picTroisiemeVie.BackColor = System.Drawing.Color.Transparent
        Me.picTroisiemeVie.Image = Global.JeuxDeChat.My.Resources.Resources.Coeur19x19
        Me.picTroisiemeVie.Location = New System.Drawing.Point(368, 24)
        Me.picTroisiemeVie.Name = "picTroisiemeVie"
        Me.picTroisiemeVie.Size = New System.Drawing.Size(19, 19)
        Me.picTroisiemeVie.TabIndex = 10
        Me.picTroisiemeVie.TabStop = False
        '
        'picQuatriemeVie
        '
        Me.picQuatriemeVie.BackColor = System.Drawing.Color.Transparent
        Me.picQuatriemeVie.Image = Global.JeuxDeChat.My.Resources.Resources.Coeur19x19
        Me.picQuatriemeVie.Location = New System.Drawing.Point(343, 24)
        Me.picQuatriemeVie.Name = "picQuatriemeVie"
        Me.picQuatriemeVie.Size = New System.Drawing.Size(19, 19)
        Me.picQuatriemeVie.TabIndex = 9
        Me.picQuatriemeVie.TabStop = False
        '
        'picCinquiemeVie
        '
        Me.picCinquiemeVie.BackColor = System.Drawing.Color.Transparent
        Me.picCinquiemeVie.Image = Global.JeuxDeChat.My.Resources.Resources.Coeur19x19
        Me.picCinquiemeVie.Location = New System.Drawing.Point(318, 24)
        Me.picCinquiemeVie.Name = "picCinquiemeVie"
        Me.picCinquiemeVie.Size = New System.Drawing.Size(19, 19)
        Me.picCinquiemeVie.TabIndex = 8
        Me.picCinquiemeVie.TabStop = False
        '
        'picSixiemeVie
        '
        Me.picSixiemeVie.BackColor = System.Drawing.Color.Transparent
        Me.picSixiemeVie.Image = Global.JeuxDeChat.My.Resources.Resources.Coeur19x19
        Me.picSixiemeVie.Location = New System.Drawing.Point(293, 24)
        Me.picSixiemeVie.Name = "picSixiemeVie"
        Me.picSixiemeVie.Size = New System.Drawing.Size(19, 19)
        Me.picSixiemeVie.TabIndex = 7
        Me.picSixiemeVie.TabStop = False
        '
        'picSeptiemeVie
        '
        Me.picSeptiemeVie.BackColor = System.Drawing.Color.Transparent
        Me.picSeptiemeVie.Image = Global.JeuxDeChat.My.Resources.Resources.Coeur19x19
        Me.picSeptiemeVie.Location = New System.Drawing.Point(268, 24)
        Me.picSeptiemeVie.Name = "picSeptiemeVie"
        Me.picSeptiemeVie.Size = New System.Drawing.Size(19, 19)
        Me.picSeptiemeVie.TabIndex = 6
        Me.picSeptiemeVie.TabStop = False
        '
        'picHuitiemeVie
        '
        Me.picHuitiemeVie.BackColor = System.Drawing.Color.Transparent
        Me.picHuitiemeVie.Image = Global.JeuxDeChat.My.Resources.Resources.Coeur19x19
        Me.picHuitiemeVie.Location = New System.Drawing.Point(243, 24)
        Me.picHuitiemeVie.Name = "picHuitiemeVie"
        Me.picHuitiemeVie.Size = New System.Drawing.Size(19, 19)
        Me.picHuitiemeVie.TabIndex = 5
        Me.picHuitiemeVie.TabStop = False
        '
        'picNeuviemeVie
        '
        Me.picNeuviemeVie.BackColor = System.Drawing.Color.Transparent
        Me.picNeuviemeVie.Image = Global.JeuxDeChat.My.Resources.Resources.Coeur19x19
        Me.picNeuviemeVie.Location = New System.Drawing.Point(218, 24)
        Me.picNeuviemeVie.Name = "picNeuviemeVie"
        Me.picNeuviemeVie.Size = New System.Drawing.Size(19, 19)
        Me.picNeuviemeVie.TabIndex = 4
        Me.picNeuviemeVie.TabStop = False
        '
        'timerAnimation
        '
        Me.timerAnimation.Interval = 25
        '
        'timerChatMassacrer
        '
        Me.timerChatMassacrer.Interval = 1000
        '
        'frmConsumo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.JeuxDeChat.My.Resources.Resources.Background
        Me.ClientSize = New System.Drawing.Size(994, 668)
        Me.Controls.Add(Me.picPremiereVie)
        Me.Controls.Add(Me.picDeuxiemeVie)
        Me.Controls.Add(Me.picTroisiemeVie)
        Me.Controls.Add(Me.picQuatriemeVie)
        Me.Controls.Add(Me.picCinquiemeVie)
        Me.Controls.Add(Me.picSixiemeVie)
        Me.Controls.Add(Me.picSeptiemeVie)
        Me.Controls.Add(Me.picHuitiemeVie)
        Me.Controls.Add(Me.picNeuviemeVie)
        Me.Controls.Add(Me.lblPointActuel)
        Me.Controls.Add(Me.lblPointage)
        Me.Controls.Add(Me.lblNombreDeVie)
        Me.Controls.Add(Me.pnlZoneDeJeu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmConsumo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.pnlZoneDeJeu.ResumeLayout(False)
        CType(Me.picBombeAnimation6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBombeAnimation4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBombeAnimation5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBombeAnimation3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBombeAnimation1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBombeAnimation2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPersonnageJoueur, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPremiereVie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDeuxiemeVie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTroisiemeVie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picQuatriemeVie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCinquiemeVie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSixiemeVie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSeptiemeVie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHuitiemeVie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picNeuviemeVie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents timerBougerObjet As System.Windows.Forms.Timer
    Friend WithEvents timerCreationObjet As System.Windows.Forms.Timer
    Friend WithEvents pnlZoneDeJeu As System.Windows.Forms.Panel
    Friend WithEvents lblNombreDeVie As System.Windows.Forms.Label
    Friend WithEvents lblPointage As System.Windows.Forms.Label
    Friend WithEvents lblPointActuel As System.Windows.Forms.Label
    Friend WithEvents picNeuviemeVie As System.Windows.Forms.PictureBox
    Friend WithEvents picHuitiemeVie As System.Windows.Forms.PictureBox
    Friend WithEvents picSeptiemeVie As System.Windows.Forms.PictureBox
    Friend WithEvents picSixiemeVie As System.Windows.Forms.PictureBox
    Friend WithEvents picCinquiemeVie As System.Windows.Forms.PictureBox
    Friend WithEvents picQuatriemeVie As System.Windows.Forms.PictureBox
    Friend WithEvents picTroisiemeVie As System.Windows.Forms.PictureBox
    Friend WithEvents picDeuxiemeVie As System.Windows.Forms.PictureBox
    Friend WithEvents picPremiereVie As System.Windows.Forms.PictureBox
    Friend WithEvents picPersonnageJoueur As System.Windows.Forms.PictureBox
    Friend WithEvents picBombeAnimation1 As System.Windows.Forms.PictureBox
    Friend WithEvents picBombeAnimation2 As System.Windows.Forms.PictureBox
    Friend WithEvents picBombeAnimation6 As System.Windows.Forms.PictureBox
    Friend WithEvents picBombeAnimation4 As System.Windows.Forms.PictureBox
    Friend WithEvents picBombeAnimation5 As System.Windows.Forms.PictureBox
    Friend WithEvents picBombeAnimation3 As System.Windows.Forms.PictureBox
    Friend WithEvents timerAnimation As System.Windows.Forms.Timer
    Friend WithEvents timerChatMassacrer As System.Windows.Forms.Timer

End Class
