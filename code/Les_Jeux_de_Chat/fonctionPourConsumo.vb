Module fonctionPourConsumo
    Function ChanceCreationObjet() As Boolean
        Dim nombreRandom As Integer
        Randomize()
        nombreRandom = CInt(12 * Rnd())
        If nombreRandom < 12 Then
            Return True
        Else
            Return False
        End If
    End Function
End Module
