Imports System.IO
Public Class frmConsumo

#Region "Declaration de variable"
    Const LARGEUR_OBJET As Integer = 42
    Const HAUTEUR_OBJET As Integer = 42
    Dim nombreObjet As Integer
    Dim tableauObjet(50) As PictureBox
    Dim limiteDroiteZoneDeJeu As Integer
    Dim limiteGaucheZoneDeJeu As Integer
    Dim limiteHautZoneDeJeu As Integer
    Dim limiteBasZoneDeJeu As Integer
    Dim positionObjetApparitionX As Integer
    Dim positionObjetApparitionY As Integer
    Dim positionObjetTableau As Integer
    Dim pointDeVie As Integer = 9
    Dim toucheBas As Boolean
    Dim toucheDroite As Boolean
    Dim toucheHaut As Boolean
    Dim toucheGauche As Boolean
    Dim tableauVie(8) As PictureBox
    Dim estMauvais As Boolean
    Dim ajout As Integer
    Dim tableauAnimation(5) As PictureBox

#End Region


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Reinitialisation()

    End Sub



#Region "Creation d'objet"
    Private Sub timerCreationObjet_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerCreationObjet.Tick
        Dim creerObjet As Boolean
        creerObjet = ChanceCreationObjet(1, 12) 'CHANGER LES PROBABILITÉS
        If creerObjet = True Then
            tableauObjet(positionObjetTableau).Visible = True
            tableauObjet(positionObjetTableau).Width = LARGEUR_OBJET
            tableauObjet(positionObjetTableau).Height = HAUTEUR_OBJET
            tableauObjet(positionObjetTableau).Image = My.Resources.Bombe
            ChoisirBonMauvaisObjet()
            PositionDeDepartObjet()
            DeciderImageObjet()
            pnlZoneDeJeu.Controls.Add(tableauObjet(positionObjetTableau))
            positionObjetTableau += 1
            If positionObjetTableau = 50 Then
                positionObjetTableau = 0
            End If
            ajout += 1
        End If
    End Sub

    Private Sub ChoisirBonMauvaisObjet()
        Dim bonObjet As Boolean

        bonObjet = ChanceCreationBonObjet()
        If bonObjet = True Then
            tableauObjet(positionObjetTableau).Tag = "Bon"
        Else
            tableauObjet(positionObjetTableau).Tag = "Mauvais"
        End If
    End Sub

    Private Sub PositionDeDepartObjet()
        Dim coteEcranDepart As Integer
        'Top = 0
        'Right = 1
        'Buttom = 2
        'Left = 3
        coteEcranDepart = ChoisirCoteDepart()
        tableauObjet(positionObjetTableau).Tag = CStr(tableauObjet(positionObjetTableau).Tag) & ";" & coteEcranDepart

        Select Case coteEcranDepart
            Case 0
                PositionObjetApparitionTop()
            Case 1
                PositionObjetApparitionRight()
            Case 2
                PositionObjetApparitionButtom()
            Case 3
                PositionObjetApparitionLeft()
        End Select
        tableauObjet(positionObjetTableau).Top = positionObjetApparitionY
        tableauObjet(positionObjetTableau).Left = positionObjetApparitionX

    End Sub

    Private Sub DeciderImageObjet()
        Dim numeroImage As Integer
        numeroImage = choixImage(3)
        If Split(tableauObjet(positionObjetTableau).Tag.ToString, ";")(0) = "Bon" Then
            Select Case numeroImage
                Case 0
                    If CInt(Split(CStr(tableauObjet(positionObjetTableau).Tag), ";")(1)) = 3 Then
                        tableauObjet(positionObjetTableau).Image = My.Resources.Poisson_vers_droite_42x_42
                    Else
                        tableauObjet(positionObjetTableau).Image = My.Resources.Poisson_vers_gauche_42x_42
                    End If

                Case 1
                    If CInt(Split(CStr(tableauObjet(positionObjetTableau).Tag), ";")(1)) = 3 Then
                        tableauObjet(positionObjetTableau).Image = My.Resources.Souris_Vers_Droite_42x42
                    Else
                        tableauObjet(positionObjetTableau).Image = My.Resources.Souris_Vers_Gauche_42x42
                    End If

                Case 2
                    tableauObjet(positionObjetTableau).Image = My.Resources.Lait_42x42
            End Select
        Else
            Select Case numeroImage
                Case 0
                    tableauObjet(positionObjetTableau).Image = My.Resources.Bombe
                Case 1
                    tableauObjet(positionObjetTableau).Image = My.Resources.Arrosoire
                Case 2
                    tableauObjet(positionObjetTableau).Image = My.Resources.Chien
            End Select
        End If

    End Sub
    Private Sub PositionObjetApparitionLeft()
        positionObjetApparitionY = ChoisirPositionObjetApparition(limiteHautZoneDeJeu, limiteBasZoneDeJeu)
        positionObjetApparitionX = limiteGaucheZoneDeJeu
    End Sub

    Private Sub PositionObjetApparitionTop()
        positionObjetApparitionY = limiteHautZoneDeJeu
        positionObjetApparitionX = ChoisirPositionObjetApparition(limiteGaucheZoneDeJeu, limiteDroiteZoneDeJeu)
    End Sub

    Private Sub PositionObjetApparitionRight()
        positionObjetApparitionY = ChoisirPositionObjetApparition(limiteHautZoneDeJeu, limiteBasZoneDeJeu + LARGEUR_OBJET)
        positionObjetApparitionX = limiteDroiteZoneDeJeu
    End Sub

    Private Sub PositionObjetApparitionButtom()
        positionObjetApparitionY = limiteBasZoneDeJeu
        positionObjetApparitionX = ChoisirPositionObjetApparition(limiteGaucheZoneDeJeu, limiteDroiteZoneDeJeu + HAUTEUR_OBJET)

    End Sub
#End Region

#Region "DeplacementObjet"
    Private Sub timerBougerObjet_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerBougerObjet.Tick


        timerBougerObjet.Stop()
        BougerPersonnage()
        BougerObjetEtVerifierCollision(tableauObjet)
        timerBougerObjet.Start()

    End Sub

    Private Sub BougerObjetEtVerifierCollision(ByRef tableauADeplacer() As PictureBox)
        Dim vitesseObjet As Integer
        Dim direction As Integer
        If CStr(frmOuverture.cboDifficulte.SelectedItem) = "Difficulté:Gladiateur" Then
            vitesseObjet = 6
        Else
            vitesseObjet = 5
        End If

        For Each pic As PictureBox In tableauADeplacer
            If pic.Visible = True Then
                direction = CInt(Split(CStr(pic.Tag), ";")(1))
                If Split(CStr(pic.Tag), ";")(0) = "Mauvais" Then
                    estMauvais = True
                Else
                    estMauvais = False
                End If

                Select Case direction
                    Case 0
                        pic.Top += vitesseObjet
                        If pic.Top > pnlZoneDeJeu.Bottom Then
                            pic.Visible = False

                        End If
                    Case 1
                        pic.Left -= vitesseObjet
                        If pic.Right < 0 Then 'limite du panel
                            pic.Visible = False
                        End If
                    Case 2
                        pic.Top -= vitesseObjet
                        If pic.Bottom < 0 Then 'limite du panel
                            pic.Visible = False
                        End If
                    Case 3
                        pic.Left += vitesseObjet
                        If pic.Left > pnlZoneDeJeu.Right Then
                            pic.Visible = False
                        End If
                End Select
                If pic.Bounds.IntersectsWith(picPersonnageJoueur.Bounds) Then
                    ResultatCollision()
                    pic.Visible = False
                End If

            End If
        Next

    End Sub

    Private Sub ResultatCollision()
        Dim sonChat As New Media.SoundPlayer(My.Resources.Cat_Scream)

        If estMauvais Then
            pointDeVie -= 1
            sonChat.Play()
            picPersonnageJoueur.Image = My.Resources.Chat_50x_50_heurté
            timerChatMassacrer.Start()
            tableauVie(pointDeVie).Image = Nothing
            If pointDeVie = 0 Then
                timerBougerObjet.Stop()
                timerCreationObjet.Stop()
                frmOuverture.chkPasserIntroduction.Checked = True
                Me.Hide()
                If File.Exists("Meilleurs Pointage.txt") Then
                    lecturePrecedentScore()

                    If PartieDesMeilleurs(pointDeScore) = True Then
                        frmPartiePerduNouveauMeilleurScore.ShowDialog()
                    Else
                        frmVousAvezPerdu.Show()
                    End If

                Else
                    frmPartiePerduNouveauMeilleurScore.ShowDialog()
                End If

                Reinitialisation()
            End If

        Else
            pointDeScore += 10
            lblPointActuel.Text = CStr(CInt(lblPointActuel.Text) + 10)
        End If

    End Sub


#End Region


    Private Sub frmConsumo_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frmOuverture.Close()
    End Sub

#Region "Deplacement du personnage"
    Private Sub frmConsumo_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        Select Case e.KeyCode
            Case Keys.Left, Keys.A
                toucheGauche = False
            Case Keys.Up, Keys.W
                toucheHaut = False
            Case Keys.Right, Keys.D
                toucheDroite = False
            Case Keys.Down, Keys.S
                toucheBas = False
        End Select
    End Sub

    Private Sub frmConsumo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.Left, Keys.A
                toucheGauche = True
            Case Keys.Up, Keys.W
                toucheHaut = True
            Case Keys.Right, Keys.D
                toucheDroite = True
            Case Keys.Down, Keys.S
                toucheBas = True
        End Select
    End Sub

    Private Sub BougerPersonnage()
        Dim vitesse As Integer = 0
        Dim vitesseOblique As Integer = 0

        If pointDeVie <= 3 Then
            vitesse = 6
            vitesseOblique = 4
        End If

        'Bouger le personnage et prends en considérant les mouvements obliques pour qu'ils soient plus lent

        If toucheBas = True AndAlso toucheDroite = False AndAlso toucheGauche = False AndAlso toucheHaut = False Then 'Bas

            VerifierLimiteBasEtBouger(vitesse)

        ElseIf toucheHaut = True AndAlso toucheBas = False AndAlso toucheDroite = False AndAlso toucheGauche = False Then 'Haut

            VerifierLimiteHautEtBouger(vitesse)

        ElseIf toucheGauche = True AndAlso toucheBas = False AndAlso toucheDroite = False AndAlso toucheHaut = False Then 'Gauche

            VerifierLimiteGaucheEtBouger(vitesse)


        ElseIf toucheDroite = True AndAlso toucheBas = False AndAlso toucheGauche = False AndAlso toucheHaut = False Then 'Droite

            VerifierLimiteDroiteEtBouger(vitesse)

        ElseIf toucheDroite = True AndAlso toucheHaut = True AndAlso toucheBas = False AndAlso toucheGauche = False Then 'Droite et Haut

            VerifierLimiteDroiteEtBouger(vitesseOblique)
            VerifierLimiteHautEtBouger(vitesseOblique)

        ElseIf toucheDroite = True AndAlso toucheBas = True AndAlso toucheGauche = False AndAlso toucheHaut = False Then 'Droite et Bas

            VerifierLimiteDroiteEtBouger(vitesseOblique)
            VerifierLimiteBasEtBouger(vitesseOblique)

        ElseIf toucheGauche = True AndAlso toucheHaut = True AndAlso toucheBas = False AndAlso toucheDroite = False Then 'Gauche et Haut

            VerifierLimiteGaucheEtBouger(vitesseOblique)
            VerifierLimiteHautEtBouger(vitesseOblique)

        ElseIf toucheGauche = True AndAlso toucheBas = True AndAlso toucheDroite = False AndAlso toucheHaut = False Then 'Gauche et Bas

            VerifierLimiteGaucheEtBouger(vitesseOblique)
            VerifierLimiteBasEtBouger(vitesseOblique)

        End If

    End Sub
    Private Sub VerifierLimiteDroiteEtBouger(ByVal vitesse As Integer)
        If picPersonnageJoueur.Left + picPersonnageJoueur.Width + vitesse < limiteDroiteZoneDeJeu Then
            picPersonnageJoueur.Left += vitesse
        Else
            picPersonnageJoueur.Left = limiteDroiteZoneDeJeu - picPersonnageJoueur.Width
        End If
    End Sub
    Private Sub VerifierLimiteGaucheEtBouger(ByVal vitesse As Integer)
        If picPersonnageJoueur.Left - vitesse > limiteGaucheZoneDeJeu Then

            picPersonnageJoueur.Left -= vitesse
        Else
            picPersonnageJoueur.Left = limiteGaucheZoneDeJeu
        End If
    End Sub
    Private Sub VerifierLimiteHautEtBouger(ByVal vitesse As Integer)
        If picPersonnageJoueur.Top - vitesse > limiteHautZoneDeJeu Then

            picPersonnageJoueur.Top -= vitesse
        Else
            picPersonnageJoueur.Top = limiteHautZoneDeJeu
        End If

    End Sub
    Private Sub VerifierLimiteBasEtBouger(ByVal vitesse As Integer)
        If picPersonnageJoueur.Top + picPersonnageJoueur.Height + vitesse < limiteBasZoneDeJeu Then
            picPersonnageJoueur.Top += vitesse
        Else
            picPersonnageJoueur.Top = limiteBasZoneDeJeu - picPersonnageJoueur.Height
        End If

    End Sub


    Private Sub limiteZoneDeJeu()
        limiteDroiteZoneDeJeu = CInt(pnlZoneDeJeu.Width)
        limiteGaucheZoneDeJeu = 0
        limiteHautZoneDeJeu = 0
        limiteBasZoneDeJeu = CInt(pnlZoneDeJeu.Height)
    End Sub
#End Region

#Region "Pause/Continuer"
    Private Sub frmConsumo_Deactivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Deactivate
        timerBougerObjet.Stop()
        timerCreationObjet.Stop()
        timerAnimation.Stop()
        toucheBas = False
        toucheHaut = False
        toucheDroite = False
        toucheGauche = False
    End Sub

    Private Sub frmConsumo_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        timerBougerObjet.Start()
        timerCreationObjet.Start()
        timerAnimation.Start()
    End Sub
#End Region

    Public Sub Reinitialisation()
        Dim tableauTemporaireVie() = {picNeuviemeVie, picHuitiemeVie, picSeptiemeVie, picSixiemeVie, picCinquiemeVie, picQuatriemeVie, picTroisiemeVie, picDeuxiemeVie, picPremiereVie}
        Dim tableauAnimationTemporaire() As PictureBox = {picBombeAnimation1, picBombeAnimation2, picBombeAnimation3, picBombeAnimation4, picBombeAnimation5, picBombeAnimation6}
        tableauAnimation = tableauAnimationTemporaire
        tableauVie = tableauTemporaireVie
        pointDeVie = 9
        pointDeScore = 0
        lblPointActuel.Text = CStr(pointDeScore)
        tableauObjet.Initialize()

        For i = 0 To tableauTemporaireVie.Count - 1
            tableauTemporaireVie(i).Image = My.Resources.Coeur19x19
        Next
        For i = 0 To tableauAnimation.Count - 1
            tableauAnimation(i).Image = My.Resources.Bombe
            tableauAnimation(i).Visible = True
        Next

        picBombeAnimation1.Location = New Point(320, 121)
        picBombeAnimation2.Location = New Point(377, 121)
        picBombeAnimation3.Location = New Point(223, 234)
        picBombeAnimation4.Location = New Point(471, 234)
        picBombeAnimation5.Location = New Point(320, 365)
        picBombeAnimation6.Location = New Point(377, 365)

        For Each pic In tableauObjet
            Me.Controls.Remove(pic)
            pnlZoneDeJeu.Controls.Remove(pic)
        Next
        picPersonnageJoueur.Location = New Point(343, 232)
        limiteZoneDeJeu()
        For i = 0 To 50
            tableauObjet(i) = New PictureBox
            tableauObjet(i).Visible = False
        Next

    End Sub


    Private Sub frmConsumo_VisibleChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
        timerAnimation.Start()
        timerCreationObjet.Start()
        timerBougerObjet.Start()
    End Sub

    Private Sub timerAnimation_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerAnimation.Tick
        Dim imageVide As Boolean
        Dim compteurImage As Integer

        compteurImage = 0
        imageVide = False
        For i = 0 To tableauAnimation.Count - 1
            If tableauAnimation(i).Visible = True Then
                compteurImage += 1

            End If
        Next
        If compteurImage = 0 Then
            imageVide = True
        End If

        If imageVide = False Then
            BougerObjetEtVerifierCollision(tableauAnimation)
        Else
            timerAnimation.Stop()
        End If
    End Sub

    Private Sub frmConsumo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Escape) Then
            frmPause.ShowDialog()
        End If
    End Sub

    Private Sub timerChatMassacrer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerChatMassacrer.Tick
        picPersonnageJoueur.Image = My.Resources.Chat_50x_50
        timerChatMassacrer.Stop()
    End Sub
End Class
