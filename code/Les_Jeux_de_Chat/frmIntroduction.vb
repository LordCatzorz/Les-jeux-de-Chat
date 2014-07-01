Public Class frmIntroduction

    Const MESSAGE_BOUTON_SUIVANT As String = "Suivant"
    Const MESSAGE_BOUTON_COMMENCER As String = "Commencer!"
    Const MESSAGE_INTRODUCTION_DEBUT As String = "Tout a commencé lorsque la communauté internet a réalisée que les chats prenaient de plus en plus de place. Le monde fut alors séparé en deux clans, ceux qui aiment les chats et les autres, la communauté internet, bien plus nombreuse."
    Const MESSAGE_INTRODUCTION_SUITE As String = "Les tensions ont alors monté entre les deux clans, mais la bataille fut rapidement gagnée par la communauté internaute. Pour montrer aux amateurs de chats que cet animal n'avait qu'un seul moyen de se couvrir de gloire, le Colisée fut reconstruit!"
    Const MESSAGE_INTRODUCTION_FINAL As String = "Maintenant, les chats sont envoyés dans une lutte épique dont la seule fin possible est leur mort.Pour s'assurer que les chats ne puissent s'enfuir, des blessures leurs sont faites avant le début des Jeux. Cette fois, c'est vous le chat! Que les Jeux commencent!!"

    Private Sub frmIntroduction_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        btnSuivant.Text = MESSAGE_BOUTON_SUIVANT
        lblIntroduction.Text = MESSAGE_INTRODUCTION_DEBUT
    End Sub

    Private Sub btnSuivant_Click(sender As System.Object, e As System.EventArgs) Handles btnSuivant.Click
        If lblIntroduction.Text = MESSAGE_INTRODUCTION_DEBUT Then
            lblIntroduction.Text = MESSAGE_INTRODUCTION_SUITE
        ElseIf lblIntroduction.Text = MESSAGE_INTRODUCTION_SUITE Then
            lblIntroduction.Text = MESSAGE_INTRODUCTION_FINAL
            btnSuivant.Text = MESSAGE_BOUTON_COMMENCER
        ElseIf lblIntroduction.Text = MESSAGE_INTRODUCTION_FINAL Then
            Me.Close()
            frmConsumo.Show()
        End If
    End Sub
End Class