Public Class frmOuverture

    Private Sub btnInstructions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInstructions.Click
        Me.Hide()
        frmInstructions.ShowDialog()
    End Sub

    Private Sub btnTop10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMeilleursScores.Click
        Me.Hide()
        frmMeilleursScores.ShowDialog()

    End Sub

    Private Sub btnQuitter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitter.Click
        Me.Close()
    End Sub

    Private Sub btnJouer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJouer.Click
        Const MESSAGE_DIFFICULTE As String = "Veuillez choisir un niveau de difficulté dans la liste déroulante"
        Const TITRE_MESSAGE As String = "Erreur de selection"

        If cboDifficulte.SelectedIndex <> -1 Then
            If chkPasserIntroduction.Checked = True Then
                frmConsumo.Show()
                Me.Hide()
            Else
                frmIntroduction.ShowDialog()
                Me.Hide()
            End If
        Else
            MessageBox.Show(MESSAGE_DIFFICULTE, TITRE_MESSAGE, MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

    End Sub

    Private Sub cboDifficulte_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboDifficulte.KeyPress
        e.Handled = True
    End Sub

#Region "apparitionBombe et changement de couleur"
    Private Sub btnJouer_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJouer.MouseEnter, btnJouer.GotFocus
        ChangementCouleurEtBombe(btnJouer, picJouer)
    End Sub

    Private Sub btnJouer_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJouer.MouseLeave, btnJouer.LostFocus
        CouleurNormal(btnJouer, picJouer)
    End Sub

    Private Sub btnInstructions_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInstructions.MouseEnter, btnInstructions.GotFocus
        ChangementCouleurEtBombe(btnInstructions, picInstruction)
    End Sub

    Private Sub btnInstructions_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInstructions.MouseLeave, btnInstructions.LostFocus
        CouleurNormal(btnInstructions, picInstruction)
    End Sub

    Private Sub btnTop10_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMeilleursScores.MouseEnter, btnMeilleursScores.GotFocus
        ChangementCouleurEtBombe(btnMeilleursScores, picMeilleursScores)
    End Sub

    Private Sub btnTop10_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMeilleursScores.MouseLeave, btnMeilleursScores.LostFocus
        CouleurNormal(btnMeilleursScores, picMeilleursScores)
    End Sub


    Private Sub btnQuitter_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitter.MouseEnter, btnQuitter.GotFocus
        ChangementCouleurEtBombe(btnQuitter, picQuitter)
    End Sub

    Private Sub btnQuitter_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitter.MouseLeave, btnQuitter.LostFocus
        CouleurNormal(btnQuitter, picQuitter)
    End Sub
#End Region

    Private Sub frmOuverture_VisibleChanged(sender As System.Object, e As System.EventArgs) Handles MyBase.VisibleChanged
        Me.cboDifficulte.Select()
    End Sub
End Class