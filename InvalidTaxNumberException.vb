Public Class InvalidTaxNumberException

    Inherits Exception
    Public Sub New()
        MyBase.New("Invalid Tax Number")
    End Sub
End Class

