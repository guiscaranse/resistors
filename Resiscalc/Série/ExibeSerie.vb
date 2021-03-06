﻿Public Class ExibeSerie
    Dim aLabels() As Label = {}
    Dim aResis As Double() = {}
    Dim rEq As Double = 0
    Private Sub ExibeSerie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabControl1.Appearance = TabAppearance.FlatButtons
        TabControl1.ItemSize = New Size(0, 1)
        TabControl1.SizeMode = TabSizeMode.Fixed
        TabControl1.SelectedIndex = (My.Settings.nResistors - 1)
        Select Case My.Settings.nResistors
            Case 1
                aLabels = {resis11}
            Case 2
                aLabels = {resis21, resis22}
            Case 3
                aLabels = {resis31, resis32, resis33}
            Case 4
                aLabels = {resis41, resis42, resis43, resis44}
            Case 5
                aLabels = {resis51, resis52, resis53, resis54, resis55}
        End Select
        Dim index As Integer = 0
        ' Navega por cada resistor
        For Each TabCntrol As Control In ConfigResistor1.TabControl1.Controls
            ' Navega por objetos dentro da página do resistor
            For Each ChildCntrol As Control In TabCntrol.Controls
                ' Pega o objeto que é do tipo numérico
                If TypeOf ChildCntrol Is NumericUpDown Then
                    Dim nUpDown As NumericUpDown = DirectCast(ChildCntrol, NumericUpDown)
                    Dim l As Label = aLabels(index)
                    l.Text = "R" & index + 1 & " = " & nUpDown.Value & " Ω"
                    ReDim Preserve aResis(index + 1)
                    aResis(index) = nUpDown.Value
                End If
            Next
            index += 1
        Next
        ' Calcula Resistência Equivalente
        For Each x In aResis
            rEq += x
        Next
        resistEqValueLabel1.Text = rEq & " Ω"
        resistEqValueLabel2.Text = rEq & " Ω"
        resistEqValueLabel3.Text = rEq & " Ω"
        resistEqValueLabel4.Text = rEq & " Ω"
        resistEqValueLabel5.Text = rEq & " Ω"
    End Sub
End Class