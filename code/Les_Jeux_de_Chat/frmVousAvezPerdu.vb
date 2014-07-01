Public Class frmVousAvezPerdu


    Private Sub btnRejouer_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRejouer.MouseEnter, btnRejouer.GotFocus
        ChangementCouleurEtBombe(btnRejouer, picRejouer)
    End Sub
    Private Sub btnRetourAuMenu_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetourAuMenu.MouseEnter, btnRetourAuMenu.GotFocus
        ChangementCouleurEtBombe(btnRetourAuMenu, picRetourMenu)
    End Sub
    Private Sub btnQuitter_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitter.MouseEnter, btnQuitter.GotFocus
        ChangementCouleurEtBombe(btnQuitter, picQuitter)
    End Sub

    Private Sub btnRejouer_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRejouer.MouseLeave, btnRejouer.LostFocus
        CouleurNormal(btnRejouer, picRejouer)
    End Sub

    Private Sub btnRetourAuMenu_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetourAuMenu.MouseLeave, btnRetourAuMenu.LostFocus
        CouleurNormal(btnRetourAuMenu, picRetourMenu)
    End Sub

    Private Sub btnQuitter_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitter.MouseLeave, btnQuitter.LostFocus
        CouleurNormal(btnQuitter, picQuitter)
    End Sub

    Private Sub btnRetourAuMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetourAuMenu.Click
        Me.Close()
        frmOuverture.Show()
    End Sub

    Private Sub btnQuitter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitter.Click
        frmOuverture.Close()
    End Sub

    Private Sub btnRejouer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRejouer.Click
        Me.Close()
        frmConsumo.Hide()
        frmConsumo.timerAnimation.Stop()
        frmConsumo.timerBougerObjet.Stop()
        frmConsumo.timerCreationObjet.Stop()
        frmConsumo.Reinitialisation()
        frmConsumo.Show()
    End Sub
End Class