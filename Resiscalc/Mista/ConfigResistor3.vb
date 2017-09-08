Public Class ConfigResistor3

    Private Sub ConfigResistor3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '' Quantos em paralelo sendo que da prioridade para os paralelos
        Dim hMany As Double = Math.Round(SelectAssocia.ComboBox2.SelectedItem / 2)
        For x As Integer = 1 To SelectAssocia.ComboBox2.SelectedItem
            Dim newPage As New TabPage()
            Dim resistValue As New NumericUpDown()
            Dim resistText As New Label()
            Dim resistIcon As New PictureBox()
            resistIcon.BackgroundImage = My.Resources.resistor
            resistIcon.BackgroundImageLayout = ImageLayout.Zoom
            resistIcon.Size = New System.Drawing.Size(100, 70)
            resistIcon.Location = New System.Drawing.Point((Me.DisplayRectangle.Width - resistIcon.Size.Width) / 2, newPage.Size.Height / 2)
            resistValue.Location = New System.Drawing.Point((Me.DisplayRectangle.Width - resistValue.Size.Width) / 2, resistIcon.Size.Height + resistIcon.Location.Y + 30)
            resistText.Text = "Qual a resistência do resistor (Em OHMs)?"
            resistText.AutoSize = True
            resistText.Location = New System.Drawing.Point((Me.DisplayRectangle.Width - resistText.Size.Width - 90) / 2, resistIcon.Size.Height + resistIcon.Location.Y + 5)
            newPage.Text = "Resistor " & x
            newPage.Controls.Add(resistIcon)
            newPage.Controls.Add(resistText)
            newPage.Controls.Add(resistValue)
            TabControl1.TabPages.Add(newPage)
        Next
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ExibeMista.Show()
        Me.Close()
    End Sub
End Class