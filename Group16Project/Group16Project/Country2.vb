Option Strict On
Option Explicit On
Option Infer Off
' *****************************************************************
' Team Number: 16
' Team Member 1 Details: Kuwandira, A (222062566)
' Team Member 2 Details: Mkhabela, PL (222072645)
' Team Member 3 Details: Phalane CK (222008253)
' Team Member 4 Details: Donnaghie, JB (222098397)
' Practical: Team Project
' *****************************************************************
Public Class Country2

    Inherits Country

    Private _NumBirths As Integer
    Private _Numdeaths As Integer
    Private _NumUnemployed As Integer

    ''Property Methods
    Public Property NumBirths As Integer
        Get
            Return _NumBirths
        End Get
        Set(value As Integer)
            If value < Population Then
                _NumBirths = value
            Else
                _NumBirths = Population
            End If
        End Set
    End Property

    Public Property NumDeaths As Integer
        Get
            Return _Numdeaths
        End Get
        Set(value As Integer)
            If value < _Population Then
                _Numdeaths = value
            Else
                _Numdeaths = _Population
            End If
        End Set
    End Property

    Public Property NumUnemployed As Integer
        Get
            Return _NumUnemployed
        End Get
        Set(value As Integer)
            _NumUnemployed = value
        End Set
    End Property

    ''constructors



    Public Sub New(nam As String, Pop As Integer, Conspt As Double, Inve As Double, ND As Integer, NB As Integer, NU As Integer)
        MyBase.New(nam, Pop, Conspt, Inve)
        _Numdeaths = ND
        _NumBirths = NB
        _NumUnemployed = NU
    End Sub
    Public Overrides Function CalcGDP() As Double
        Dim Value As Double
        Value = Math.Round(NumUnemployed * Consumption / Population, 2)

        Return Value

    End Function
    Public Function DeathRates() As Double
        Dim Rate As Double
        Rate = Math.Round(_Numdeaths / _Population, 2)

        Return Rate
    End Function

    Public Function Birthrates() As Double
        Dim Rate As Double
        Rate = Math.Round(_NumBirths / _Population, 2)

        Return Rate
    End Function

    Public Function UnemployedRates() As Double
        Dim Rate As Double
        Rate = Math.Round(NumUnemployed / Population, 2)

        Return Rate

    End Function

End Class

