Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports VBStudentProfileForm

<TestClass()> Public Class UnitTest1
    'Basic unit tests
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
    <TestMethod()> Public Sub ageCHeck()
        Dim dates As DateTime
        Dim age = Date.Now.Year - 1998 - If(Date.Now.DayOfYear < 161, 1, 0)
        Assert.IsTrue(Date.Now.Year - 1998 > age)
    End Sub
    <TestMethod()> Public Sub ageCHeckSameDate()
        Dim dates As DateTime
        Dim age = Date.Now.Year - 1998 - If(Date.Now.DayOfYear < Date.Now.DayOfYear, 1, 0)
        Assert.IsTrue((Date.Now.Year - 1998) = age)
    End Sub




End Class