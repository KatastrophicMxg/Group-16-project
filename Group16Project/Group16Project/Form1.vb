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
        grdDisplay.Row = r
        grdDisplay.Col = c
        grdDisplay.Text = t
    End Sub

    Private Cntry1() As Country1
    Private Cntry2() As Country2
    Private iCompare As Integer

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click


        iCompare = CInt(InputBox("How many pairs would you like to compare"))

        Dim sName, contName As String
        Dim iPop, iInfDeaths, iEducated, iDeaths, iBirths, iUnemployed, contPop, contCountries As Integer
        Dim dCons, dInvest, dNetIncm, dRange As Double

        ReDim Preserve Cntry1(iCompare)
        ReDim Preserve Cntry2(iCompare)

        For i As Integer = 1 To iCompare

            sName = InputBox("Enter Country1 Name")
            iPop = CInt(InputBox("Enter " + sName + "'s population"))
            iInfDeaths = CInt(InputBox("Enter number of Infant deaths"))
            iEducated = CInt(InputBox("Enter number of Educated people"))
            dCons = CDbl(InputBox("Enter Consumption"))
            dInvest = CDbl(InputBox("Enter Invesntment"))
            dNetIncm = CDbl(InputBox("Enter Net Income"))
            dRange = CDbl(InputBox("Enter Range"))
            Cntry1(i) = New Country1(sName, iPop, dCons, dInvest, dNetIncm, dRange, iInfDeaths, iEducated)

            contName = InputBox("Name of Continent")
            contPop = CInt(InputBox("Continent's Population"))
            contCountries = CInt(InputBox("Number of Countries"))
            Cntry1(i).Continent = New Continent(contName, contCountries, contPop)

            sName = InputBox("Enter Country2 Name")
            iPop = CInt(InputBox("Enter " + sName + "'s population"))
            iDeaths = CInt(InputBox("Enter Number of Deaths"))
            iBirths = CInt(InputBox("Enter number of Births"))
            iUnemployed = CInt(InputBox("Enter Number of Unemployed"))
            dCons = CDbl(InputBox("Enter Consumption"))
            dInvest = CDbl(InputBox("Enter Invesntment"))
            Cntry2(i) = New Country2(sName, iPop, dCons, dInvest, iDeaths, iBirths, iUnemployed)

            contName = InputBox("Name of Continent")
            contPop = CInt(InputBox("Continent's Population"))
            contCountries = CInt(InputBox("Number of Countries"))
            Cntry2(i).Continent = New Continent(contName, contCountries, contPop)

        Next

    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click

        Dim iPair As Integer

        iPair = CInt(InputBox("Which pair of countries do you want to display"))

        DisplayIG(1, 1, Cntry1(iPair).Name)
        DisplayIG(1, 2, CStr(Cntry1(iPair).Population))
        DisplayIG(1, 3, Cntry1(iPair).Continent.Name)

        DisplayIG(2, 1, Cntry2(iPair).Name)
        DisplayIG(2, 2, CStr(Cntry2(iPair).Population))
        DisplayIG(2, 3, Cntry2(iPair).Continent.Name)

    End Sub

    Private Sub FrmGDP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grdDisplay.Rows = 4
        grdDisplay.Cols = 6
        DisplayIG(1, 0, "Country #1")
        DisplayIG(2, 0, "Country #2")

        DisplayIG(0, 1, "Name")
        DisplayIG(0, 2, "Population")
        DisplayIG(0, 3, "Continent")


    End Sub
End Class