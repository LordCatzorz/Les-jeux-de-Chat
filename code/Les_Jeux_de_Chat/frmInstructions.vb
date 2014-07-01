Public Class frmInstructions

    Dim appartirDuJeu As Boolean = False

    Private Sub btnRetour_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetour.Click
        If appartirDuJeu Then
            frmPause.Show()
        Else
            frmOuverture.Show()
        End If

        appartirDuJeu = False
        Me.Close()
    End Sub

    Private Sub VsbInstruction_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles VsbInstruction.Scroll
        picInstruction.Top = (0 - VsbInstruction.Value * 4)
    End Sub

    Public Sub chargerDepuisJeu()
        appartirDuJeu = True
        Me.Show()

    End Sub

    Private Sub btnRetour_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetour.MouseEnter
        btnRetour.ForeColor = Color.Yellow
    End Sub
    Private Sub btnRetour_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetour.MouseLeave
        btnRetour.ForeColor = Color.White
    End Sub
End Class