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
            _NumBirths = value
        End Set
    End Property

    Public Property NumDeaths As Integer
        Get
            Return _Numdeaths
        End Get
        Set(value As Integer)
            _Numdeaths = value
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

    Public Sub New(ND As Integer, NB As Integer)
        _Numdeaths = ND
        _NumBirths = NB
    End Sub
    Public Sub New(ND As Integer, NB As Integer, NU As Integer)
        _Numdeaths = ND
        _NumBirths = NB
        _NumUnemployed = NU
    End Sub


End Class

