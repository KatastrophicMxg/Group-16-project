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
Public Class Continent
    Private _Name As String
    Private _NumCountries As Integer
    Private _Population As Integer

    Public Property Name As String
        Get
            Return _Name
        End Get
        Set(value As String)
            _Name = value
        End Set
    End Property

    Public Property Numcountries As Integer
        Get
            Return _NumCountries
        End Get
        Set(value As Integer)
            _NumCountries = value
        End Set
    End Property

    Public Property Population As Integer
        Get
            Return _Population
        End Get
        Set(value As Integer)
            _Population = value
        End Set
    End Property

    Public Sub New(Nam As String, numCoun As Integer, Pop As Integer)
        _Name = Nam
        _NumCountries = numCoun
        _Population = Pop
    End Sub
End Class
