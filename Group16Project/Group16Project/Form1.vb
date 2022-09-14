Option Strict On
Option Explicit On
Option Infer Off
' *****************************************************************
' Team Number: 16
' Team Member 1 Details: Kuwandira, A (222062566)
' Team Member 2 Details: Mkhabela, PL (222072645)
' Team Member 3 Details: Phalane, CK (222008253)
' Team Member 4 Details: Donnaghie, JB (222098397)
' Practical: Team Project
' *****************************************************************
Public Class FrmGDP
    Private Sub DisplayIG(ByVal r As Integer, ByVal c As Integer, ByRef t As String)
        grdDisplay.Rows = r
        grdDisplay.Cols = c
        grdDisplay.Text = t
    End Sub

    Private Cntry1() As Country1
    Private Cntry2() As Country2
    Private iCompare As Integer

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        iCompare = CInt(InputBox("How many pair would you like to compare"))

        For i As Integer = 1 To iCompare

            Dim sName As String
            Dim iPop, iInfDeaths, iEducated As Integer
            Dim dCons, dInvest, dNetIncm, dRange As Double

            sName = InputBox("Enter Country1 Name")
            iPop = CInt(InputBox("Enter " + sName + "'s population"))
            iInfDeaths = CInt(InputBox("Enter number of Infant deaths"))
            iEducated = CInt(InputBox("Enter number of Educated people"))
            dCons = CDbl(InputBox("Enter Consumption"))
            dInvest = CDbl(InputBox("Enter Invesntment"))
            dNetIncm = CDbl(InputBox("Enter net Income"))
            dRange = CDbl(InputBox("Enter Range"))

            Cntry1(i) = New Country1(sName, iPop, dCons, dInvest, dNetIncm, dRange, iInfDeaths, iEducated)

            Dim contName As String
            Dim contPop, contCountries As Integer

            contName = InputBox("Name of Continent")
            contPop = CInt(InputBox("Continent's Population"))
            contCountries = CInt(InputBox("Number of Countries"))

            Cntry1(i).Continent = New Continent(contName, contCountries, contPop)


            Dim iDeaths, iBirths, iUnemployed As Integer

            sName = InputBox("Enter Country2 Name")
            iPop = CInt(InputBox("Enter " + sName + "'s population"))
            iDeaths = CInt(InputBox("Enter Number of Deaths"))
            iBirths = CInt(InputBox("Enter number of Births"))
            iUnemployed = CInt(InputBox("Enter Number of Unemployed"))

            dCons = CDbl(InputBox("Enter Consumption"))
            dInvest = CDbl(InputBox("Enter Invesntment"))

            Cntry2(i) = New Country2(sName, iPop, dCons, dInvest, iDeaths, iBirths, iUnemployed)

        Next

    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim iPair As Integer
        iPair = CInt(InputBox("Which pair of countries do you want to compare"))

    End Sub
End Class