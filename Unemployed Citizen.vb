' *****************************************************************
' Team Number: 11
' Team Member 1 Details: Masunyane PS (221109535)
' Team Member 2 Details: Bekiswa, I (201709725)
' Team Member 3 Details: Zwane, ME (201412234)
' Team Member 4 Details: Kgomo, LP (218086329)
' Practical: Team Project
' Class name: Unemployed_Citizen
' *****************************************************************

'Option statements 
Option Strict On
Option Explicit On
Option Infer Off

'a derived class
<Serializable()> Public Class Unemployed_Citizen

    Inherits Citizen

    'attributes 
    Private _QualificationLevel As Integer
    Private _Opportunity As Integer 'what would the citizen like to do moving forward? doing something or staying unemployed?

    'constructor
    Public Sub New(n As String, a As Integer, g As Integer)
        MyBase.New(n, a, g)

    End Sub
    'property methods 
    Public Property QualiLevel As Integer
        Get
            Return _QualificationLevel
        End Get
        Set(value As Integer)
            _QualificationLevel = ValidateInt(value)
        End Set
    End Property

    Public Property Opp As Integer
        Get
            Return _Opportunity
        End Get
        Set(value As Integer)
            _Opportunity = ValidateInt(value)
        End Set
    End Property

    'other methods 
    Public Overrides Function Placement() As String

        Dim stat As String = ""
        Select Case _QualificationLevel
            Case 1 'If citizen has highest qualification of : Lower than Matric
                If _Opportunity = 0 Then 'Citizen doesn't want to be apart of a learnership
                    stat = "No placement. Citizen doesn't need assistance."
                ElseIf _Opportunity = 1 Then 'Citizen would like to be apart of a learnership
                    stat = "Learnship Application pending"
                End If
            Case 2 'If citizen has highest qualification of : Matric 
                If _Opportunity = 0 Then 'Citizen doesn't want funding from us for further studies
                    stat = "No placement. Citizen doesn't need assistance."
                ElseIf _Opportunity = 1 Then 'Citizen would like to receive funding from us for further studies
                    stat = "Tertiary Studies Funding Application pending"
                End If
            Case 3 To 4 'If citizen has highest qualification of : Diploma/Degree
                If _Opportunity = 0 Then 'Citizen doesn't want to be apart of a internship
                    stat = "No placement. Citizen doesn't need assistance."
                ElseIf _Opportunity = 1 Then 'Citizen would like to be apart of a internship
                    stat = "Internship Application pending"
                End If
        End Select

        Return stat
    End Function

    Public Overrides Function Display() As String
        Dim text As String = ""
        Dim quali As String = ""
        text = "Employment Status : Unemployed" & Environment.NewLine
        text &= MyBase.Display
        If _QualificationLevel = 1 Then
            quali = "Before Matric"
        ElseIf _QualificationLevel = 2 Then
            quali = "Matric"
        ElseIf _QualificationLevel = 3 Then
            quali = "Diploma or degree"
        ElseIf _QualificationLevel = 4 Then
            quali = "Post-Graduate"
        End If
        text &= "Qualification Level : " & quali & Environment.NewLine
        text &= "Placement Status : " & Placement() & Environment.NewLine
        Return text
    End Function
End Class
