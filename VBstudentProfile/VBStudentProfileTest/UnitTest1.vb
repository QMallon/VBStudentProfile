Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports VBStudentProfileForm

<TestClass()> Public Class UnitTest1

    <TestMethod()> Public Sub toStringTest()
        Dim testStudent As New Student("q", 20, "123456789", "testemail", "123456789", "testmajor", Convert.ToDateTime("12/5/2020"), True)
        Assert.IsNotNull(testStudent.ToString())

    End Sub
    <TestMethod()> Public Sub UnderGradtest()
        Dim testStudent As New Student("q", 20, "123456789", "testemail", "123456789", "testmajor", Convert.ToDateTime("12/5/2020"), True)
        Assert.IsTrue(testStudent.ToString.Contains("Undergrad"))
    End Sub
    <TestMethod()> Public Sub GraduateTest()
        Dim testStudent As New Student("q", 20, "123456789", "testemail", "123456789", "testmajor", Convert.ToDateTime("12/5/2020"), False)
        Assert.IsTrue(testStudent.ToString.Contains("Graduate"))
    End Sub



End Class