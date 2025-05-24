<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PROFESSOR_DASHBOARD
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnprofsave = New System.Windows.Forms.Button()
        Me.btnprofback = New System.Windows.Forms.Button()
        Me.btnprofbatch = New System.Windows.Forms.Button()
        Me.txtprofuser = New System.Windows.Forms.TextBox()
        Me.txtprofpass = New System.Windows.Forms.TextBox()
        Me.txtprofemail = New System.Windows.Forms.TextBox()
        Me.txtprofcon = New System.Windows.Forms.TextBox()
        Me.txtprofsec = New System.Windows.Forms.TextBox()
        Me.cboprofyear = New System.Windows.Forms.ComboBox()
        Me.txtprofsubj = New System.Windows.Forms.TextBox()
        Me.txtprofprof = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtprofcourse = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtprofid = New System.Windows.Forms.TextBox()
        Me.txtprofgpa = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(69, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "USERNAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(71, 286)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "YEAR LEVEL"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(69, 242)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "SECTION"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(71, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "CONTACT"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(71, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "EMAIL"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(69, 101)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "PASSWORD"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(624, 59)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "SUBJECT"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(624, 101)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 20)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "PROFESSOR"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(624, 146)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 20)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "GRADE ID"
        '
        'btnprofsave
        '
        Me.btnprofsave.Location = New System.Drawing.Point(755, 267)
        Me.btnprofsave.Name = "btnprofsave"
        Me.btnprofsave.Size = New System.Drawing.Size(181, 58)
        Me.btnprofsave.TabIndex = 9
        Me.btnprofsave.Text = "SAVE"
        Me.btnprofsave.UseVisualStyleBackColor = True
        '
        'btnprofback
        '
        Me.btnprofback.Location = New System.Drawing.Point(755, 352)
        Me.btnprofback.Name = "btnprofback"
        Me.btnprofback.Size = New System.Drawing.Size(181, 52)
        Me.btnprofback.TabIndex = 10
        Me.btnprofback.Text = "BACK"
        Me.btnprofback.UseVisualStyleBackColor = True
        '
        'btnprofbatch
        '
        Me.btnprofbatch.Location = New System.Drawing.Point(44, 435)
        Me.btnprofbatch.Name = "btnprofbatch"
        Me.btnprofbatch.Size = New System.Drawing.Size(181, 58)
        Me.btnprofbatch.TabIndex = 12
        Me.btnprofbatch.Text = "BATCH UPLOAD"
        Me.btnprofbatch.UseVisualStyleBackColor = True
        '
        'txtprofuser
        '
        Me.txtprofuser.Location = New System.Drawing.Point(203, 59)
        Me.txtprofuser.Name = "txtprofuser"
        Me.txtprofuser.Size = New System.Drawing.Size(233, 26)
        Me.txtprofuser.TabIndex = 13
        '
        'txtprofpass
        '
        Me.txtprofpass.Location = New System.Drawing.Point(203, 98)
        Me.txtprofpass.Name = "txtprofpass"
        Me.txtprofpass.Size = New System.Drawing.Size(233, 26)
        Me.txtprofpass.TabIndex = 14
        '
        'txtprofemail
        '
        Me.txtprofemail.Location = New System.Drawing.Point(203, 140)
        Me.txtprofemail.Name = "txtprofemail"
        Me.txtprofemail.Size = New System.Drawing.Size(233, 26)
        Me.txtprofemail.TabIndex = 15
        '
        'txtprofcon
        '
        Me.txtprofcon.Location = New System.Drawing.Point(203, 190)
        Me.txtprofcon.Name = "txtprofcon"
        Me.txtprofcon.Size = New System.Drawing.Size(233, 26)
        Me.txtprofcon.TabIndex = 16
        '
        'txtprofsec
        '
        Me.txtprofsec.Location = New System.Drawing.Point(203, 239)
        Me.txtprofsec.Name = "txtprofsec"
        Me.txtprofsec.Size = New System.Drawing.Size(233, 26)
        Me.txtprofsec.TabIndex = 17
        '
        'cboprofyear
        '
        Me.cboprofyear.FormattingEnabled = True
        Me.cboprofyear.Location = New System.Drawing.Point(203, 283)
        Me.cboprofyear.Name = "cboprofyear"
        Me.cboprofyear.Size = New System.Drawing.Size(225, 28)
        Me.cboprofyear.TabIndex = 18
        '
        'txtprofsubj
        '
        Me.txtprofsubj.Location = New System.Drawing.Point(740, 53)
        Me.txtprofsubj.Name = "txtprofsubj"
        Me.txtprofsubj.Size = New System.Drawing.Size(233, 26)
        Me.txtprofsubj.TabIndex = 19
        '
        'txtprofprof
        '
        Me.txtprofprof.Location = New System.Drawing.Point(740, 101)
        Me.txtprofprof.Name = "txtprofprof"
        Me.txtprofprof.Size = New System.Drawing.Size(233, 26)
        Me.txtprofprof.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(71, 327)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 20)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "COURSE"
        '
        'txtprofcourse
        '
        Me.txtprofcourse.Location = New System.Drawing.Point(203, 327)
        Me.txtprofcourse.Name = "txtprofcourse"
        Me.txtprofcourse.Size = New System.Drawing.Size(233, 26)
        Me.txtprofcourse.TabIndex = 23
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(624, 193)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 20)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "GRADE ID"
        '
        'txtprofid
        '
        Me.txtprofid.Location = New System.Drawing.Point(740, 146)
        Me.txtprofid.Name = "txtprofid"
        Me.txtprofid.Size = New System.Drawing.Size(233, 26)
        Me.txtprofid.TabIndex = 21
        '
        'txtprofgpa
        '
        Me.txtprofgpa.Location = New System.Drawing.Point(740, 193)
        Me.txtprofgpa.Name = "txtprofgpa"
        Me.txtprofgpa.Size = New System.Drawing.Size(233, 26)
        Me.txtprofgpa.TabIndex = 25
        '
        'PROFESSOR_DASHBOARD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1182, 591)
        Me.Controls.Add(Me.txtprofgpa)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtprofcourse)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtprofid)
        Me.Controls.Add(Me.txtprofprof)
        Me.Controls.Add(Me.txtprofsubj)
        Me.Controls.Add(Me.cboprofyear)
        Me.Controls.Add(Me.txtprofsec)
        Me.Controls.Add(Me.txtprofcon)
        Me.Controls.Add(Me.txtprofemail)
        Me.Controls.Add(Me.txtprofpass)
        Me.Controls.Add(Me.txtprofuser)
        Me.Controls.Add(Me.btnprofbatch)
        Me.Controls.Add(Me.btnprofback)
        Me.Controls.Add(Me.btnprofsave)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PROFESSOR_DASHBOARD"
        Me.Text = "PROFESSOR_DASHBOARD"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnprofsave As Button
    Friend WithEvents btnprofback As Button
    Friend WithEvents btnprofbatch As Button
    Friend WithEvents txtprofuser As TextBox
    Friend WithEvents txtprofpass As TextBox
    Friend WithEvents txtprofemail As TextBox
    Friend WithEvents txtprofcon As TextBox
    Friend WithEvents txtprofsec As TextBox
    Friend WithEvents cboprofyear As ComboBox
    Friend WithEvents txtprofsubj As TextBox
    Friend WithEvents txtprofprof As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtprofcourse As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtprofid As TextBox
    Friend WithEvents txtprofgpa As TextBox
End Class
