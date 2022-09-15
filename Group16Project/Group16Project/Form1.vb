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
    Private Sub DisplayC1(ByVal r As Integer, ByVal c As Integer, ByRef t As String)
        grdCountry1.Row = r
        grdCountry1.Col = c
        grdCountry1.Text = t
    End Sub
    Private Sub DisplayC2(ByVal r As Integer, ByVal c As Integer, ByRef t As String)
        grdCountry2.Row = r
        grdCountry2.Col = c
        grdCountry2.Text = t
    End Sub



    Private Cont(2) As Country
    Private NUmCont As Integer
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        Dim NumC As Integer
        Dim Nam As String
        Dim Pop As Integer
        Dim Consump As Double
        Dim Invest As Double
        NumC = CInt(InputBox("Which country do you want to enter details for: "))
        Select Case NumC
            Case 1

                Dim NI As Double
                Dim Range As Double
                Dim NID As Integer
                Dim NEP As Integer

                Nam = InputBox("What is the name of country1?")
                Pop = CInt(InputBox("What is the population of the country " & Nam))
                Consump = CDbl(InputBox("What is the consumption of the country " & Nam))
                Invest = CDbl(InputBox("What is the investment of the country per annum? " & Nam))
                NI = CDbl(InputBox("What is the net income of the country per anuum " & Nam))
                Range = CDbl(InputBox("What is the range of the country " & Nam))
                NID = CInt(InputBox("What is the number of infant death? " & Nam))
                NEP = CInt(InputBox("What is the number of educated people? " & Nam))


                Cont(1) = New Country1(Nam, Pop, Consump, Invest, NI, Range, NID, NEP)

            Case 2

                Dim ND As Integer
                Dim NB As Integer
                Dim NU As Integer

                Nam = InputBox("What is the name of country2?")
                Pop = CInt(InputBox("What is the population of the country " & Nam))
                Consump = CDbl(InputBox("What is the consumption of the country " & Nam))
                Invest = CDbl(InputBox("What is the investment of the country per annum? " & Nam))
                ND = CInt(InputBox("What is the number of deaths for the country " & Nam))
                NB = CInt(InputBox("What is the number of births for the country " & Nam))
                NU = CInt(InputBox("What is the number of unemployed for the country " & Nam))

                Cont(2) = New Country2(Nam, Pop, Consump, Invest, ND, NB, NU)


        End Select







    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnCountry1.Click
        Dim c1 As Country1
        c1 = TryCast(Cont(1), Country1)
        DisplayC1(1, 1, c1.Name)
        DisplayC1(2, 1, CStr(c1.Population))
        DisplayC1(3, 1, CStr(c1.CalcGDP))
        DisplayC1(4, 1, CStr(c1.IMR))
        DisplayC1(5, 1, CStr(c1.Literacy))
        DisplayC1(6, 1, CStr(c1.GNP))

    End Sub

    Private Sub FrmGDP_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        grdCountry1.Rows = 7
        grdCountry1.Cols = 2

        DisplayC1(0, 0, " Details")
        DisplayC1(1, 0, " Country Name")
        DisplayC1(2, 0, " Population")
        DisplayC1(3, 0, "GDP")
        DisplayC1(4, 0, "IMRC")
        DisplayC1(5, 0, "Literacy")
        DisplayC1(6, 0, "GNPC")
        DisplayC1(0, 1, "Value")

        grdCountry2.Rows = 7
        grdCountry2.Cols = 2

        DisplayC2(0, 0, " Details")
        DisplayC2(1, 0, " Country Name")
        DisplayC2(2, 0, " Population")
        DisplayC2(3, 0, "GDP")
        DisplayC2(4, 0, "Number Births")
        DisplayC2(5, 0, "Number Deaths")
        DisplayC2(6, 0, "Number Of Unemployed")
        DisplayC2(0, 1, "Value")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCountry2.Click
        Dim c2 As Country2
        c2 = TryCast(Cont(2), Country2)
        DisplayC2(1, 1, c2.Name)
        DisplayC2(2, 1, CStr(c2.Population))
        DisplayC2(3, 1, CStr(c2.CalcGDP))
        DisplayC2(4, 1, CStr(c2.Birthrates))
        DisplayC2(5, 1, CStr(c2.DeathRates))
        DisplayC2(6, 1, CStr(c2.UnemployedRates))
    End Sub
End Class