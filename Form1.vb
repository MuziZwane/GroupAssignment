' *****************************************************************
' Team Number: 11
' Team Member 1 Details: Masunyane, PS (221109535)
' Team Member 2 Details: Bekiswa, I (20109725)
' Team Member 3 Details: Zwane, ME (201412234)
' Team Member 4 Details: Kgomo, LP (218086329)
' Practical: Team Project
' Class name: frmPoverty
' *****************************************************************
Option Strict On
Option Infer Off
Option Explicit On

Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Public Class frmPoverty
    Private citizens() As Citizen
    Private numcitizens As Integer = 3
    Private FS As FileStream
    Private Bf As BinaryFormatter
    Private filename As String = "PovertyAlleviation.GP"

    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        ReDim citizens(numcitizens)
        For a As Integer = 1 To numcitizens
            Dim choice As Integer = CInt(InputBox("1-Employed, 2-Unemployed, 3-Student", "Citizen Type"))
            Select Case choice
                Case 1 ' Employed
                    Dim objEmployed As Employed_Citizen
                    Dim age As Integer
                    Dim name As String
                    Dim gender As Integer

                    name = InputBox("Enter name of the employed person", "Name")
                    age = CInt(InputBox("How old is the person", "Person's age"))
                    gender = CInt(InputBox("Select the gender of the employed person:" & Environment.NewLine & "1- Male" & Environment.NewLine & "2- Female" & Environment.NewLine & "3- Prefer not to say", "Gender"))

                    Dim taxN As Integer
                    Try
                        taxN = CInt(InputBox("Enter the employed person's tax number", "Tax Number"))
                        If taxN > 100000 Then
                            Throw New InvalidTaxNumberException
                        End If
                    Catch ex As invalidTaxNumberException
                        MsgBox("Please enter a valid tax number. i.e. 12345")
                    Finally
                        taxN = CInt(InputBox("Enter the employed person's tax number", "Tax Number"))
                    End Try

                    objEmployed = New Employed_Citizen(name, age, gender, taxN)
                    objEmployed.Employer = InputBox("Enter the name of your employer", "Employer's Name")
                    objEmployed.Salary = CInt(InputBox("How much do you earn per month", "Salary"))
                    objEmployed.CalcAnnualIncome()
                    objEmployed.DetermineTaxPaid()
                    objEmployed.Placement()
                    objEmployed.display()
                    citizens(a) = objEmployed
                    txtDisplay.Text &= citizens(a).Display & Environment.NewLine
                Case 2 'Unemployed
                    Dim objUnemployed As Unemployed_Citizen
                    Dim name As String
                    Dim gender As Integer
                    Dim age As Integer
                    name = InputBox("Enter name of the unemployed person", "Name")
                    gender = CInt(InputBox("Select the gender of the employed person:" & Environment.NewLine & "1- Male" & Environment.NewLine & "2- Female" & Environment.NewLine & "3- Prefer not to say", "Gender"))
                    age = CInt(InputBox("How old is the person", "Person's age"))
                    objUnemployed = New Unemployed_Citizen(name, age, gender)
                    objUnemployed.QualiLevel = CInt(InputBox("Please select your highest qualification level" & Environment.NewLine & "1- Before Matric " & Environment.NewLine & "2- Matric" & Environment.NewLine & "3- Diploma or Degree" & Environment.NewLine & "4- Post-Graduate", "Highest Qualification"))
                    objUnemployed.Opp = CInt(InputBox("Would you like to be placed in the waiting list for an opportunity: " & Environment.NewLine & "0- No" & Environment.NewLine & "1- Yes", "Opportunity"))
                    objUnemployed.Placement()
                    objUnemployed.Display()
                    citizens(a) = objUnemployed
                    txtDisplay.Text &= citizens(a).Display & Environment.NewLine
                Case 3 'Student      
                    Dim ObjStudent As Student
                    Dim name As String
                    Dim gender As Integer
                    Dim age As Integer
                    name = InputBox("Enter name of the Student", "Name")
                    gender = CInt(InputBox("Select the gender of the employed person:" & Environment.NewLine & "1- Male" & Environment.NewLine & "2- Female" & Environment.NewLine & "3- Prefer not to say", "Gender"))
                    age = CInt(InputBox("How old is the student", "Student's age"))
                    ObjStudent = New Student(name, age, gender)
                    ObjStudent.school = InputBox("What is the name of your learning institution", "Institution Name")
                    ObjStudent.feepayment = CInt(InputBox("What method do you use to pay your learning fees: " & Environment.NewLine & "1- Private funding" & Environment.NewLine & "2- Government funding" & Environment.NewLine & "3- Bursary or Scholarship" & Environment.NewLine & "4- Other"))

                    Dim avemark As Integer
                    Try
                        avemark = CInt(InputBox("Please enter your latest average mark", "Average"))
                        If avemark > 100 Then
                            Throw New InvalidMarkException
                        End If
                    Catch ex As InvalidMarkException
                        MsgBox("Please enter a valid tax mark that is less or equal to 100")
                    Finally
                        avemark = CInt(InputBox("Please enter your latest average mark", "Average"))
                    End Try
                    ObjStudent.Placement()
                    ObjStudent.Display()
                    citizens(a) = ObjStudent
                    txtDisplay.Text &= citizens(a).Display & Environment.NewLine
            End Select
        Next a
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        FS = New FileStream(filename, FileMode.Create, FileAccess.Write)
        Bf = New BinaryFormatter
        For c As Integer = 1 To numcitizens
            Bf.Serialize(FS, citizens(c))
        Next c
        MessageBox.Show("All data saved to file", "Saved")
        FS.Close()

    End Sub

    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        FS = New FileStream(filename, FileMode.Open, FileAccess.Read)
        Bf = New BinaryFormatter
        While FS.Position < FS.Length
            Dim citizens As Citizen
            citizens = DirectCast(Bf.Deserialize(FS), Citizen)
            MessageBox.Show(citizens.Display() & Environment.NewLine)
        End While

        FS.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles txtClear.Click
        txtDisplay.Clear()
    End Sub
End Class