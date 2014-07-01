Imports System.IO
Public Class frmPartiePerduNouveauMeilleurScore


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click

        EnregistrerMeilleurScore()

    End Sub

    Private Sub btnOK_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.MouseEnter
        btnOK.ForeColor = Color.Yellow
    End Sub

    Private Sub btnOK_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.MouseLeave
        btnOK.ForeColor = Color.White
    End Sub

    Private Sub txtNom_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNom.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            EnregistrerMeilleurScore()
        End If
    End Sub

    Private Sub EnregistrerMeilleurScore()
        Dim fichierEcriture As StreamWriter
        Const NOM_FICHIER_MEILLEURS_POINTAGES As String = "Meilleurs Pointage.txt"
        Const MESSAGE_ERREUR_NOM As String = "Veillez entrer au moins un caractère pour votre nom."
        Dim nomValide As Boolean = True


        If txtNom.Text.Length <= 0 Then
            nomValide = False
        End If

        If nomValide = True Then
            If File.Exists(NOM_FICHIER_MEILLEURS_POINTAGES) Then

                For i = 0 To numeroLigneLu
                    If pointDeScore > CInt(Split(tableauNomEtMeilleurScore(i), ";")(1)) Then
                        For j = 8 To i Step -1
                            tableauNomEtMeilleurScore(j + 1) = tableauNomEtMeilleurScore(j)
                        Next
                        tableauNomEtMeilleurScore(i) = txtNom.Text & ";" & pointDeScore
                        Exit For
                    End If
                Next

                fichierEcriture = File.CreateText(NOM_FICHIER_MEILLEURS_POINTAGES)
                For i = 0 To numeroLigneLu
                    fichierEcriture.WriteLine(tableauNomEtMeilleurScore(i))
                Next
                fichierEcriture.Close()
            Else
                fichierEcriture = File.CreateText(NOM_FICHIER_MEILLEURS_POINTAGES)
                fichierEcriture.WriteLine(txtNom.Text & ";" & pointDeScore)
                fichierEcriture.Close()
            End If
            ContenuMeilleurScore()
            frmMeilleursScores.Show()
            Me.Close()
        Else
            MessageBox.Show(MESSAGE_ERREUR_NOM)
        End If


    End Sub
End Class