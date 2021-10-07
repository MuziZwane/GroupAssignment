' *****************************************************************
' Team Number: 11
' Team Member 1 Details: Masunyane PS (221109535)
' Team Member 2 Details: Bekiswa, I (201709725)
' Team Member 3 Details: Zwane, ME (201412234)
' Team Member 4 Details: Kgomo, LP (218086329)
' Practical: Team Project
' Class name: Employed_Citizen
' *****************************************************************

'Option statements 
Option Strict On
Option Explicit On
Option Infer Off

'a derived class
<Serializable()> Public Class Employed_Citizen
    Inherits Citizen

    'attributes 
    Private _Employer As String
    Private _MonthlyIncome As Double
    Private _TaxNum As Integer

    'constructor 
    'n= name of the citizen ; a= age of the citizen ; g = gender of the citizen
    'taxnum= tax number of the citizen

    Public Sub New(n As String, a As Integer, g As Integer, taxnum As Integer)
        MyBase.New(n, a, g)
        _TaxNum = taxnum 'a person's tax number is a constant in the system hence it is needed in the construction of the object
    End Sub

    'property methods 
    Public Property Employer As String
        Get
            Return _Employer
        End Get
        Set(value As String)
            _Employer = value
        End Set
    End Property

    Public Property Salary As Double
        Get
            Return _MonthlyIncome
        End Get
        Set(value As Double)
            _MonthlyIncome = value
        End Set
    End Property

    'a readonly because tax number is a constant in ones lifetime
    Public ReadOnly Property Taxno As Integer
        Get
            Return _TaxNum
        End Get

    End Property

    'other methods 
    Public Function CalcAnnualIncome() As Double
        Return Salary * 12
    End Function


    'this function returns annual tax payable by citizen based on tax brackets
    Public Function DetermineTaxPaid() As Double
        Dim payable As Double
        Dim annual As Double
        annual = CalcAnnualIncome()

        Select Case annual
            Case 1 To 216200 '18% of annual income is taxable
                payable = annual * 0.18

            Case 216201 To 337800 '26% of annual income is taxable 
                payable = annual * 0.26
            Case 337801 To 467500 '31% of annual income is taxable
                payable = annual * 0.31
            Case 467501 To 613600 '36% of annual income is taxable
                payable = annual * 0.36
            Case 613601 To 782200 '39% of annual income is taxable
                payable = annual * 0.39
            Case 782201 To 1626600 '41% of annual income is taxable
                payable = annual * 0.41
            Case > 1626600 '45% of annual income is taxable
                payable = annual * 0.45

        End Select

        Return payable

    End Function

    Public Overrides Function Placement() As String
        If CalcAnnualIncome() > 42000 Then
            Return "Citizen doesn't qualify for Monthly financial assistance"
        Else
            Return "Citizen qualifies for Monthly financial assitance"
        End If
    End Function

    Public Overrides Function display() As String
        Dim text As String = ""
        text = "Employment Status : Employed " & Environment.NewLine
        text &= MyBase.Display
        text &= "Employed by : " & _Employer & Environment.NewLine
        text &= "Tax Number : T" & _TaxNum & Environment.NewLine
        text &= "Annual Tax Paid : " & DetermineTaxPaid() & Environment.NewLine
        text &= "Placement Status : " & Placement() & Environment.NewLine
        Return text
    End Function

End Class
