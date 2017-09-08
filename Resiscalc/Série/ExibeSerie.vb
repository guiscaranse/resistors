Public Class ExibeSerie

    Private Sub ExibeSerie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabControl1.Appearance = TabAppearance.FlatButtons
        TabControl1.ItemSize = New Size(0, 1)
        TabControl1.SizeMode = TabSizeMode.Fixed



    End Sub
End Class