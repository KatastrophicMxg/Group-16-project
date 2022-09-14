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
Public MustInherit Class Country

    Protected _Name As String
    Protected _Population As Integer
    Protected _Consumption As Double
    Protected _Investment As Double

    Public Property Name As String
        Get
            Return _Name
        End Get
        Set(value As String)
            _Name = value
        End Set
    End Property

    Public Property Population As Integer
        Get

            Return _Population
        End Get
        Set(value As Integer)
            If _Population <= 0 Then
            Else
                _Population = value
            End If
        End Set
    End Property

    Public Property Consumption As Double
        Get
            Return _Consumption
        End Get
        Set(value As Double)
            _Consumption = value
        End Set
    End Property

    Public Property Investment As Double
        Get
            Return _Investment
        End Get
        Set(value As Double)
            _Investment = value
        End Set
    End Property
    Public Sub New(Nam As String, Pop As Integer, Consump As Double, Invest As Double)
        _Name = Nam
        _Population = Pop
        _Consumption = Consump
        _Investment = Invest

    End Sub

    Public MustOverride Function CalcGPD() As Double


End Class
