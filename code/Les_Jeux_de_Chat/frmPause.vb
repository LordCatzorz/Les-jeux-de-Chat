Public Class frmPause

#Region "Apparition bombe et changement"
    Private Sub btnRetourJeu_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetourJeu.MouseEnter, btnRetourJeu.GotFocus
        ChangementCouleurEtBombe(btnRetourJeu, picRetourJeu)
    End Sub

    Private Sub btnRetourJeu_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetourJeu.MouseLeave, btnRetourJeu.LostFocus
        CouleurNormal(btnRetourJeu, picRetourJeu)
    End Sub


    Private Sub btnRetourMenu_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetourMenu.MouseEnter, btnRetourMenu.GotFocus
        ChangementCouleurEtBombe(btnRetourMenu, picRetourMenu)
    End Sub


    Private Sub btnRetourMenu_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetourMenu.MouseLeave, btnRetourMenu.LostFocus
        CouleurNormal(btnRetourMenu, picRetourMenu)
    End Sub

    Private Sub btnInstructions_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInstructions.MouseEnter, btnInstructions.GotFocus
        ChangementCouleurEtBombe(btnInstructions, picInstructions)
    End Sub

    Private Sub btnInstructions_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInstructions.MouseLeave, btnInstructions.LostFocus
        CouleurNormal(btnInstructions, picInstructions)
    End Sub

    Private Sub btnQuitterJeu_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitterJeu.MouseEnter, btnQuitterJeu.GotFocus
        ChangementCouleurEtBombe(btnQuitterJeu, picQuitterJeu)
    End Sub

    Private Sub btnQuitterJeu_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitterJeu.MouseLeave, btnQuitterJeu.LostFocus
        CouleurNormal(btnQuitterJeu, picQuitterJeu)
    End Sub
#End Region

    Private Sub btnRetourJeu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetourJeu.Click
        Me.Close()
    End Sub

    Private Sub btnRetourMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetourMenu.Click
        Me.Close()
        frmConsumo.Hide()
        frmConsumo.timerAnimation.Stop()
        frmConsumo.timerBougerObjet.Stop()
        frmConsumo.timerCreationObjet.Stop()
        frmConsumo.Reinitialisation()
        frmOuverture.Show()
    End Sub

    Private Sub btnQuitterJeu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitterJeu.Click
        frmOuverture.Close()
    End Sub

    Private Sub btnInstructions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInstructions.Click
        frmInstructions.chargerDepuisJeu()
    End Sub
End Class