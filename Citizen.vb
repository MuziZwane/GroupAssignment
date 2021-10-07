' *****************************************************************
' Team Number: 11
' Team Member 1 Details: Masunyane, PS (221109535)
' Team Member 2 Details: Bekiswa, I (201709725)
' Team Member 3 Details: Zwane, ME (201412234)
' Team Member 4 Details: Kgomo, LP (218086329)
' Practical: Team Project
' Class name: Citizen
' *****************************************************************
'option statements 
Option Strict On
Option Explicit On
Option Infer Off

'An abstract base class
<Serializable()> Public MustInherit Class Citizen
    'attributes
    Private _Name As String
    Private _Age As Integer
    Private _Gender As Integer

    'constructor 
    Public Sub New(n As String, a As Integer, g As Integer)
        _Name = n
        _Age = a
        _Gender = g

    End Sub

    Public Sub New()

    End Sub

    'property methods 
    Public Property name As String
        Get
            Return _Name
        End Get
        Set(value As String)
            _Name = value
        End Set
    End Property

    Public Property age As Integer
        Get
            Return _Age
        End Get
        Set(value As Integer)
            _Age = ValidateInt(value)
        End Set
    End Property

    Public Property gender As Integer
        Get
            Return _Gender
        End Get
        Set(value As Integer)
            _Gender = value
        End Set
    End Property

    'other methods

    'to validate all integer values to be positive 
    Protected Function ValidateInt(value As Integer) As Integer
        If value < 0 Then
            Return 0
        Else
            Return value
        End If
    End Function
    Public MustOverride Function Placement() As String


    Public Overridable Function Display() As String
        Dim text As String = ""
        Dim gen As String = ""
        text &= "Name : " & _Name & Environment.NewLine
        text &= "Age : " & _Age & Environment.NewLine
        If _Gender = 1 Then
            gen = "Male"
        ElseIf _Gender = 2 Then
            gen = "Female"
        ElseIf _Gender = 3 Then
            gen = "Prefer not to say"
        End If
        text &= "Gender : " & gen & Environment.NewLine
        Return text
    End Function
End Class
