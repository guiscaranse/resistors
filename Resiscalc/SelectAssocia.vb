Public Class SelectAssocia

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
                    If ComboBox2.SelectedItem < 2 Then
                        MessageBox.Show("Para associações em paralelo, é necessário escolher no mínimo 2 resistores.", _
                        "Erro!", _
                        MessageBoxButtons.OK, _
                        MessageBoxIcon.Exclamation, _
                        MessageBoxDefaultButton.Button1)
                    Else
                        ConfigResistor2.Show()
                        Me.Close()
                    End If

                Case "Mista"
                    If ComboBox2.SelectedItem < 3 Then
                        MessageBox.Show("Para associações mistas, é necessário escolher no mínimo 3 resistores.", _
                        "Erro!", _
                        MessageBoxButtons.OK, _
                        MessageBoxIcon.Exclamation, _
                        MessageBoxDefaultButton.Button1)
                    Else
                        ConfigResistor3.Show()
                        Me.Close()
                    End If

            End Select
        End If

    End Sub

    Private Sub SelectAssocia_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
