<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentProfile
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtFirst = New System.Windows.Forms.TextBox()
        Me.txtMiddle = New System.Windows.Forms.TextBox()
        Me.txtLast = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.chkGradStdnt = New System.Windows.Forms.CheckBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtTUID = New System.Windows.Forms.TextBox()
        Me.txtPhonenum = New System.Windows.Forms.TextBox()
        Me.lblFirstN = New System.Windows.Forms.Label()
        Me.lblMiddle = New System.Windows.Forms.Label()
        Me.lblLast = New System.Windows.Forms.Label()
        Me.PhonNum = New System.Windows.Forms.Label()
        Me.lblTUID = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMajor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtFirst
        '
        Me.txtFirst.Location = New System.Drawing.Point(117, 54)
        Me.txtFirst.Name = "txtFirst"
        Me.txtFirst.Size = New System.Drawing.Size(100, 20)
        Me.txtFirst.TabIndex = 0
        '
        'txtMiddle
        '
        Me.txtMiddle.Location = New System.Drawing.Point(239, 54)
        Me.txtMiddle.Name = "txtMiddle"
        Me.txtMiddle.Size = New System.Drawing.Size(100, 20)
        Me.txtMiddle.TabIndex = 1
        '
        'txtLast
        '
        Me.txtLast.Location = New System.Drawing.Point(361, 54)
        Me.txtLast.Name = "txtLast"
        Me.txtLast.Size = New System.Drawing.Size(100, 20)
        Me.txtLast.TabIndex = 2
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(116, 215)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 3
        '
        'chkGradStdnt
        '
        Me.chkGradStdnt.AutoSize = True
        Me.chkGradStdnt.Location = New System.Drawing.Point(119, 254)
        Me.chkGradStdnt.Name = "chkGradStdnt"
        Me.chkGradStdnt.Size = New System.Drawing.Size(124, 17)
        Me.chkGradStdnt.TabIndex = 4
        Me.chkGradStdnt.Text = "Check if gradstudent"
        Me.chkGradStdnt.UseVisualStyleBackColor = True
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(361, 141)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(100, 20)
        Me.txtEmail.TabIndex = 7
        '
        'txtTUID
        '
        Me.txtTUID.Location = New System.Drawing.Point(239, 141)
        Me.txtTUID.Name = "txtTUID"
        Me.txtTUID.Size = New System.Drawing.Size(100, 20)
        Me.txtTUID.TabIndex = 6
        '
        'txtPhonenum
        '
        Me.txtPhonenum.Location = New System.Drawing.Point(116, 141)
        Me.txtPhonenum.Name = "txtPhonenum"
        Me.txtPhonenum.Size = New System.Drawing.Size(100, 20)
        Me.txtPhonenum.TabIndex = 5
        '
        'lblFirstN
        '
        Me.lblFirstN.AutoSize = True
        Me.lblFirstN.Location = New System.Drawing.Point(116, 35)
        Me.lblFirstN.Name = "lblFirstN"
        Me.lblFirstN.Size = New System.Drawing.Size(57, 13)
        Me.lblFirstN.TabIndex = 8
        Me.lblFirstN.Text = "First Name"
        '
        'lblMiddle
        '
        Me.lblMiddle.AutoSize = True
        Me.lblMiddle.Location = New System.Drawing.Point(236, 38)
        Me.lblMiddle.Name = "lblMiddle"
        Me.lblMiddle.Size = New System.Drawing.Size(69, 13)
        Me.lblMiddle.TabIndex = 9
        Me.lblMiddle.Text = "Middle Name"
        '
        'lblLast
        '
        Me.lblLast.AutoSize = True
        Me.lblLast.Location = New System.Drawing.Point(358, 35)
        Me.lblLast.Name = "lblLast"
        Me.lblLast.Size = New System.Drawing.Size(58, 13)
        Me.lblLast.TabIndex = 10
        Me.lblLast.Text = "Last Name"
        '
        'PhonNum
        '
        Me.PhonNum.AutoSize = True
        Me.PhonNum.Location = New System.Drawing.Point(116, 110)
        Me.PhonNum.Name = "PhonNum"
        Me.PhonNum.Size = New System.Drawing.Size(78, 13)
        Me.PhonNum.TabIndex = 11
        Me.PhonNum.Text = "Phone Number"
        '
        'lblTUID
        '
        Me.lblTUID.AutoSize = True
        Me.lblTUID.Location = New System.Drawing.Point(236, 110)
        Me.lblTUID.Name = "lblTUID"
        Me.lblTUID.Size = New System.Drawing.Size(33, 13)
        Me.lblTUID.TabIndex = 12
        Me.lblTUID.Text = "TUID"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(368, 110)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(33, 13)
        Me.lblEmail.TabIndex = 13
        Me.lblEmail.Text = "EMail"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(119, 357)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(119, 23)
        Me.btnSave.TabIndex = 14
        Me.btnSave.Text = "Save Student"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(287, 357)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(141, 23)
        Me.btnPrint.TabIndex = 15
        Me.btnPrint.Text = "Save To File"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(475, 357)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 16
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(334, 215)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(116, 190)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Date of Birth"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(331, 190)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Expected Graduation Date"
        '
        'txtMajor
        '
        Me.txtMajor.Location = New System.Drawing.Point(525, 141)
        Me.txtMajor.Name = "txtMajor"
        Me.txtMajor.Size = New System.Drawing.Size(100, 20)
        Me.txtMajor.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(522, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Major"
        '
        'StudentProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtMajor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblTUID)
        Me.Controls.Add(Me.PhonNum)
        Me.Controls.Add(Me.lblLast)
        Me.Controls.Add(Me.lblMiddle)
        Me.Controls.Add(Me.lblFirstN)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtTUID)
        Me.Controls.Add(Me.txtPhonenum)
        Me.Controls.Add(Me.chkGradStdnt)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.txtLast)
        Me.Controls.Add(Me.txtMiddle)
        Me.Controls.Add(Me.txtFirst)
        Me.Name = "StudentProfile"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFirst As TextBox
    Friend WithEvents txtMiddle As TextBox
    Friend WithEvents txtLast As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents chkGradStdnt As CheckBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtTUID As TextBox
    Friend WithEvents txtPhonenum As TextBox
    Friend WithEvents lblFirstN As Label
    Friend WithEvents lblMiddle As Label
    Friend WithEvents lblLast As Label
    Friend WithEvents PhonNum As Label
    Friend WithEvents lblTUID As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMajor As TextBox
    Friend WithEvents Label3 As Label
End Class
