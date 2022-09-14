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
Public Class Country1

    Inherits Country

    Private _NetIncome As Double
    Private _Range As Double
    Private _NumInfantsDeath As Integer
    Private _NumEducatedPeople As Integer

    'Property Methods
    Public Property NetIncome As Double
        Set(value As Double)
            _NetIncome = value
        End Set
        Get
            Return _NetIncome
        End Get
    End Property

    Public Property Range As Double
        Set(value As Double)
            _Range = value
        End Set
        Get
            Return _Range
        End Get
    End Property

    Public Property NumInfantsDeath As Integer
        Set(value As Integer)
            _NumInfantsDeath = value
        End Set
        Get
            Return _NumInfantsDeath
        End Get
    End Property

    Public Property NumEducatedPeople As Integer
        Set(value As Integer)
            _NumEducatedPeople = value
        End Set
        Get
            Return _NumEducatedPeople
        End Get
    End Property

    'Constructors
    Public Sub New(NI As Double, RANGE As Double, NID As Integer, NEP As Integer)
        _NetIncome = NI
        _Range = RANGE
        _NumInfantsDeath = NID
        _NumEducatedPeople = NEP
    End Sub

End Class
