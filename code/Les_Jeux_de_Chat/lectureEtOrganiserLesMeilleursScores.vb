Imports System.IO
Module Module1
    Public numeroLigneLu As Integer
    Public pointDeScore As Integer
    Public contenuLigneLu As String
    Public tableauNomEtMeilleurScore() As String = {" ;0", " ;0", " ;0", " ;0", " ;0", " ;0", " ;0", " ;0", " ;0", " ;0"}


    Public Sub lecturePrecedentScore()
        Dim fichierLecture As StreamReader
        numeroLigneLu = 0
        fichierLecture = File.OpenText("Meilleurs Pointage.txt")
        Do While Not fichierLecture.EndOfStream And numeroLigneLu <= 9
            contenuLigneLu = fichierLecture.ReadLine()
            If contenuLigneLu <> "" Then
                tableauNomEtMeilleurScore(numeroLigneLu) = contenuLigneLu
                numeroLigneLu += 1
            End If
        Loop
        If numeroLigneLu = 10 Then
            numeroLigneLu = 9
        End If
        fichierLecture.Close()
    End Sub

    Public Sub ContenuMeilleurScore()
        Dim tableauMeilleurScore() As Label = {frmMeilleursScores.lblScore1, frmMeilleursScores.lblScore2, frmMeilleursScores.lblScore3, frmMeilleursScores.lblScore4, frmMeilleursScores.lblScore5, frmMeilleursScores.lblScore6, frmMeilleursScores.lblScore7, frmMeilleursScores.lblScore8, frmMeilleursScores.lblScore9, frmMeilleursScores.lblScore10}
        Dim tableauNomJoueur() As Label = {frmMeilleursScores.lblNomJoueur1, frmMeilleursScores.lblNomJoueur2, frmMeilleursScores.lblNomJoueur3, frmMeilleursScores.lblNomJoueur4, frmMeilleursScores.lblNomJoueur5, frmMeilleursScores.lblNomJoueur6, frmMeilleursScores.lblNomJoueur7, frmMeilleursScores.lblNomJoueur8, frmMeilleursScores.lblNomJoueur9, frmMeilleursScores.lblNomJoueur10}
        Dim nombreScore As Integer
        If File.Exists("Meilleurs Pointage.txt") Then
            nombreScore = 0
            lecturePrecedentScore()
            While nombreScore <= 9 AndAlso CInt(Split(tableauNomEtMeilleurScore(nombreScore), ";")(1)) <> 0
                tableauMeilleurScore(nombreScore).Text = CStr(Split(tableauNomEtMeilleurScore(nombreScore), ";")(1))
                nombreScore += 1
            End While
            For i = 0 To nombreScore - 1
                tableauNomJoueur(i).Text = CStr(Split(tableauNomEtMeilleurScore(i), ";")(0))
            Next
        End If
    End Sub
End Module
