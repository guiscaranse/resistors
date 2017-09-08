﻿Public Class SelectAssocia

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (ComboBox1.SelectedItem = Nothing Or ComboBox2.SelectedItem = Nothing) Then
            MessageBox.Show("Certifique-se que você marcou as duas opções.", _
            "Erro!", _
            MessageBoxButtons.OK, _
            MessageBoxIcon.Exclamation, _
            MessageBoxDefaultButton.Button1)
        Else
            My.Settings.nResistors = ComboBox2.SelectedItem
            Select Case ComboBox1.SelectedItem
                Case "Série"
                    ConfigResistor1.Show()
                    Me.Close()
                Case "Paralela"
                    ConfigResistor2.Show()
                    Me.Close()
            End Select
        End If

    End Sub


    Private Sub SelectAssocia_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
