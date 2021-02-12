Imports System.IO

Public Class StudentProfile
    Dim students As ArrayList = New ArrayList
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        Dim file As StreamWriter
        Dim docpath As String
        docpath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        file = New StreamWriter(Path.Combine(docpath, "StudentProfilesVB.txt"))
        For Each newStudent As Student In students
            Dim output As String
            output = newStudent.ToString()
            file.WriteLine(output + "\r\n")
        Next
        file.Close()






    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'novalidation
        Dim newStudent As New Student()
        newStudent.fullname = txtFirst.Text + " " + txtMiddle.Text + " " + txtLast.Text
        newStudent.age = getAge(DateTimePicker1.Value)
        newStudent.phonenum = txtPhonenum.Text
        newStudent.major = txtMajor.Text
        newStudent.gradDate = DateTimePicker2.Value
        newStudent.isUnderGrad = chkGradStdnt.Checked
        newStudent.tuid = txtTUID.Text
        newStudent.email = txtEmail.Text
        students.Add(newStudent)




    End Sub

    Public Function getAge(ByVal DOB As DateTime) As Integer
        Return DateTime.Now.Year - DateTimePicker1.Value.Year - If(DateTime.Now.DayOfYear < DateTimePicker1.Value.DayOfYear, 0, 1)
    End Function

    Private Sub StudentProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
