' *****************************************************************
' Team Number: 11
'Team Member 1 Details: Masunyane PS (221109535)
'Team Member 2 Details: Bekiswa, I (201709725)
'Team Member 3 Details: Zwane, ME (201412234)
' Team Member 4 Details: Kgomo, LP (218086329)
' Practical: Team Project
' Class name: Student
' *****************************************************************

'Option statements 
Option Strict On
Option Explicit On
Option Infer Off

' a derived class
<Serializable()> Public Class Student
    Inherits Citizen

    'attributes 
    Private _Institution As String
    Private _MethodofFeePayment As Integer
    Private _AverageMark As Integer

    'constructor 
    Public Sub New(n As String, a As Integer, g As Integer)
        MyBase.New(n, a, g)
    End Sub

    'property methods 
    Public Property school As String
        Get
            Return _Institution
        End Get
        Set(value As String)
            _Institution = value
        End Set
    End Property

    Public Property feepayment As Integer
        Get
            Return _MethodofFeePayment
        End Get
        Set(value As Integer)
            _MethodofFeePayment = ValidateInt(value)
        End Set
    End Property

    Public Property avemark As Integer
        Get
            Return _AverageMark
        End Get
        Set(value As Integer)
            _AverageMark = ValidateInt(value)
        End Set
    End Property

    'other methods 
    Public Overrides Function Placement() As String
        If _AverageMark > 75 Then
            Return "Granted Internship Position post Studies"
        Else
            Return "We suggest applying for Academic Mentorship"
        End If

    End Function

    Public Overrides Function Display() As String
        Dim text As String = ""
        Dim fee As String = ""
        text = "Employment Status : Student" & Environment.NewLine
        text &= MyBase.Display()
        text &= "Studying at : " & _Institution & Environment.NewLine
        text &= "Average Mark : " & _AverageMark & Environment.NewLine
        If _MethodofFeePayment = 1 Then
            fee = "Private Funding"
        ElseIf _MethodofFeePayment = 2 Then
            fee = "Government Funding"
        ElseIf _MethodofFeePayment = 3 Then
            fee = "Bursary or Scholarship"
        ElseIf _MethodofFeePayment = 4 Then
            fee = "Other"
        End If
        text &= "Fee Payment Method : " & fee & Environment.NewLine
        text &= "Placement Status : " & Placement() & Environment.NewLine
        Return text
    End Function
End Class
