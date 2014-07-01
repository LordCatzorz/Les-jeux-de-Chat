Imports System.IO
Public Class frmMeilleursScores

    Private Sub btnRetour_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetour.Click
        Me.Close()
        frmOuverture.Show()
    End Sub

    Private Sub frmTop10_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ContenuMeilleurScore()
    End Sub

    Private Sub btnRetour_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetour.MouseEnter
        btnRetour.ForeColor = Color.Yellow
    End Sub

    Private Sub btnRetour_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetour.MouseLeave
        btnRetour.ForeColor = Color.White
    End Sub
End Class