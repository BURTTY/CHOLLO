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
        Me.txtprofgpa = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtprofcourse = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtprofid = New System.Windows.Forms.TextBox()
        Me.txtprofprof = New System.Windows.Forms.TextBox()
        Me.txtprofsubj = New System.Windows.Forms.TextBox()
        Me.cboprofyear = New System.Windows.Forms.ComboBox()
        Me.txtprofsec = New System.Windows.Forms.TextBox()
        Me.txtprofcon = New System.Windows.Forms.TextBox()
        Me.txtprofemail = New System.Windows.Forms.TextBox()
        Me.txtprofpass = New System.Windows.Forms.TextBox()
        Me.txtprofuser = New System.Windows.Forms.TextBox()
        Me.btnprofbatch = New System.Windows.Forms.Button()
        Me.btnprofback = New System.Windows.Forms.Button()
        Me.btnprofsave = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.btnprofdel = New System.Windows.Forms.Button()
        Me.btnprofexit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtprofgpa
        '
        Me.txtprofgpa.Location = New System.Drawing.Point(728, 183)
        Me.txtprofgpa.Name = "txtprofgpa"
        Me.txtprofgpa.Size = New System.Drawing.Size(233, 26)
        Me.txtprofgpa.TabIndex = 50
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(612, 183)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 20)
        Me.Label11.TabIndex = 49
        Me.Label11.Text = "GPA"
        '
        'txtprofcourse
        '
        Me.txtprofcourse.Location = New System.Drawing.Point(191, 317)
        Me.txtprofcourse.Name = "txtprofcourse"
        Me.txtprofcourse.Size = New System.Drawing.Size(233, 26)
        Me.txtprofcourse.TabIndex = 48
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(59, 317)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 20)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "COURSE"
        '
        'txtprofid
        '
        Me.txtprofid.Location = New System.Drawing.Point(728, 136)
        Me.txtprofid.Name = "txtprofid"
        Me.txtprofid.Size = New System.Drawing.Size(233, 26)
        Me.txtprofid.TabIndex = 46
        '
        'txtprofprof
        '
        Me.txtprofprof.Location = New System.Drawing.Point(728, 91)
        Me.txtprofprof.Name = "txtprofprof"
        Me.txtprofprof.Size = New System.Drawing.Size(233, 26)
        Me.txtprofprof.TabIndex = 45
        '
        'txtprofsubj
        '
        Me.txtprofsubj.Location = New System.Drawing.Point(728, 43)
        Me.txtprofsubj.Name = "txtprofsubj"
        Me.txtprofsubj.Size = New System.Drawing.Size(233, 26)
        Me.txtprofsubj.TabIndex = 44
        '
        'cboprofyear
        '
        Me.cboprofyear.FormattingEnabled = True
        Me.cboprofyear.Items.AddRange(New Object() {"1st", "2nd", "3rd", "4th"})
        Me.cboprofyear.Location = New System.Drawing.Point(191, 273)
        Me.cboprofyear.Name = "cboprofyear"
        Me.cboprofyear.Size = New System.Drawing.Size(225, 28)
        Me.cboprofyear.TabIndex = 43
        '
        'txtprofsec
        '
        Me.txtprofsec.Location = New System.Drawing.Point(191, 229)
        Me.txtprofsec.Name = "txtprofsec"
        Me.txtprofsec.Size = New System.Drawing.Size(233, 26)
        Me.txtprofsec.TabIndex = 42
        '
        'txtprofcon
        '
        Me.txtprofcon.Location = New System.Drawing.Point(191, 180)
        Me.txtprofcon.Name = "txtprofcon"
        Me.txtprofcon.Size = New System.Drawing.Size(233, 26)
        Me.txtprofcon.TabIndex = 41
        '
        'txtprofemail
        '
        Me.txtprofemail.Location = New System.Drawing.Point(191, 130)
        Me.txtprofemail.Name = "txtprofemail"
        Me.txtprofemail.Size = New System.Drawing.Size(233, 26)
        Me.txtprofemail.TabIndex = 40
        '
        'txtprofpass
        '
        Me.txtprofpass.Location = New System.Drawing.Point(191, 88)
        Me.txtprofpass.Name = "txtprofpass"
        Me.txtprofpass.Size = New System.Drawing.Size(233, 26)
        Me.txtprofpass.TabIndex = 39
        '
        'txtprofuser
        '
        Me.txtprofuser.Location = New System.Drawing.Point(191, 49)
        Me.txtprofuser.Name = "txtprofuser"
        Me.txtprofuser.Size = New System.Drawing.Size(233, 26)
        Me.txtprofuser.TabIndex = 38
        '
        'btnprofbatch
        '
        Me.btnprofbatch.Location = New System.Drawing.Point(32, 425)
        Me.btnprofbatch.Name = "btnprofbatch"
        Me.btnprofbatch.Size = New System.Drawing.Size(181, 58)
        Me.btnprofbatch.TabIndex = 37
        Me.btnprofbatch.Text = "BATCH UPLOAD"
        Me.btnprofbatch.UseVisualStyleBackColor = True
        '
        'btnprofback
        '
        Me.btnprofback.Location = New System.Drawing.Point(743, 342)
        Me.btnprofback.Name = "btnprofback"
        Me.btnprofback.Size = New System.Drawing.Size(181, 52)
        Me.btnprofback.TabIndex = 36
        Me.btnprofback.Text = "BACK"
        Me.btnprofback.UseVisualStyleBackColor = True
        '
        'btnprofsave
        '
        Me.btnprofsave.Location = New System.Drawing.Point(743, 257)
        Me.btnprofsave.Name = "btnprofsave"
        Me.btnprofsave.Size = New System.Drawing.Size(181, 58)
        Me.btnprofsave.TabIndex = 35
        Me.btnprofsave.Text = "SAVE"
        Me.btnprofsave.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(612, 136)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 20)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "GRADE ID"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(612, 91)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 20)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "PROFESSOR"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(612, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 20)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "SUBJECT"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(57, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 20)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "PASSWORD"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(59, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 20)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "EMAIL"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(59, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 20)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "CONTACT"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(57, 232)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 20)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "SECTION"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(59, 276)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 20)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "YEAR LEVEL"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 20)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "USERNAME"
        '
        'SaveFileDialog1
        '
        '
        'btnprofdel
        '
        Me.btnprofdel.Location = New System.Drawing.Point(743, 416)
        Me.btnprofdel.Name = "btnprofdel"
        Me.btnprofdel.Size = New System.Drawing.Size(181, 58)
        Me.btnprofdel.TabIndex = 51
        Me.btnprofdel.Text = "DELETE"
        Me.btnprofdel.UseVisualStyleBackColor = True
        '
        'btnprofexit
        '
        Me.btnprofexit.Location = New System.Drawing.Point(743, 500)
        Me.btnprofexit.Name = "btnprofexit"
        Me.btnprofexit.Size = New System.Drawing.Size(181, 58)
        Me.btnprofexit.TabIndex = 52
        Me.btnprofexit.Text = "EXIT"
        Me.btnprofexit.UseVisualStyleBackColor = True
        '
        'PROFESSOR_DASHBOARD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1101, 604)
        Me.Controls.Add(Me.btnprofexit)
        Me.Controls.Add(Me.btnprofdel)
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

    Friend WithEvents txtprofgpa As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtprofcourse As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtprofid As TextBox
    Friend WithEvents txtprofprof As TextBox
    Friend WithEvents txtprofsubj As TextBox
    Friend WithEvents cboprofyear As ComboBox
    Friend WithEvents txtprofsec As TextBox
    Friend WithEvents txtprofcon As TextBox
    Friend WithEvents txtprofemail As TextBox
    Friend WithEvents txtprofpass As TextBox
    Friend WithEvents txtprofuser As TextBox
    Friend WithEvents btnprofbatch As Button
    Friend WithEvents btnprofback As Button
    Friend WithEvents btnprofsave As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents btnprofdel As Button
    Friend WithEvents btnprofexit As Button
End Class
