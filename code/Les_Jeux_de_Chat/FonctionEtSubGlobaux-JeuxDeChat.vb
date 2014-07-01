Imports System.Console

Module Fonction_Consumo_Retry
    Function ChanceCreationObjet(ByVal nombreNumerateur As Integer, ByVal nombreDenominateur As Integer) As Boolean
        Dim nombre As Integer
        Randomize()
        nombre = CInt(Int(nombreDenominateur * Rnd()))
        Select Case nombre
            Case 0 To nombreNumerateur
                Return True
            Case Else
                Return False
        End Select


    End Function

    Function ChanceCreationBonObjet() As Boolean
        Dim nombre As Integer
        Randomize()
        nombre = CInt(Int(2 * Rnd()) + 1)
        Select Case nombre
            Case 1
                Return True
            Case Else
                Return False
        End Select
    End Function

    Function ChoisirCoteDepart() As Integer
        Dim nombre As Integer
        'Top = 0
        'RIght = 1
        'Buttom = 2
        'Left = 3
        Randomize()
        nombre = CInt(Int(4 * Rnd()))
        Return nombre
    End Function


    Function ChoisirPositionObjetApparition(ByVal minimum As Integer, ByVal maximum As Integer) As Integer
        Dim positionRetourne As Integer
        Dim plageDeRandomization As Integer
        Randomize()
        plageDeRandomization = maximum - minimum
        positionRetourne = CInt((Int(plageDeRandomization * Rnd())))
        Return positionRetourne

    End Function

    Function choixImage(ByVal nombreImagePOssible As Integer) As Integer
        Dim numeroRetourne As Integer

        Randomize()
        numeroRetourne = CInt(Int(nombreImagePOssible * Rnd()))
        Return numeroRetourne

    End Function

    Function PartieDesMeilleurs(ByVal Score As Integer) As Boolean
        Dim dixMeilleurs As Boolean
        For i = 0 To 9
            If Score > CInt(Split(tableauNomEtMeilleurScore(i), ";")(1)) Then
                dixMeilleurs = True
            Else
                dixMeilleurs = False
            End If
        Next
        Return dixMeilleurs
    End Function

    Sub ChangementCouleurEtBombe(ByRef bouton As Button, ByRef pic As PictureBox)
        bouton.Focus()
        pic.Image = My.Resources.Bombe
        bouton.ForeColor = Color.Yellow
    End Sub

    Sub CouleurNormal(ByRef bouton As Button, ByRef pic As PictureBox)
        bouton.ForeColor = Color.FromArgb(159, 6, 6)
        pic.Image = Nothing
    End Sub

End Module
