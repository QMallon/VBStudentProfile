Public Class Student
    Public Property fullname As String
    Public Property age As Integer
    Public Property tuid As String
    Public Property email As String
    Public Property phonenum As String
    Public Property major As String
    Public Property gradDate As Date
    Public Property isUnderGrad As Boolean

    Public Sub New(name As String, iAge As Integer, iTuid As String, iemail As String, iphonenum As String, imajor As String, gdate As Date, check As Boolean)
        fullname = name
        age = iAge
        tuid = iTuid
        email = iemail
        phonenum = iphonenum
        major = imajor
        gradDate = gdate
        isUnderGrad = check




    End Sub
    Public Overloads Function ToString() As String
        Dim studentString As String
        studentString = "Name: " + fullname
        studentString += "Age: " + age.ToString
        studentString += "TUID: " + tuid.ToString
        studentString += "EMAIL: " + email.ToString
        studentString = "PhoneNum: " + phonenum.ToString
        studentString = "Major: " + major.ToString
        studentString = "GradDate: " + gradDate.ToString
        Dim ugradStatus As String
        If isUnderGrad = True Then
            ugradStatus = "Undergrad"
        Else
            ugradStatus = "Graduate"
        End If
        studentString = "GradStatus: " + ugradStatus



        Return studentString
    End Function






End Class
