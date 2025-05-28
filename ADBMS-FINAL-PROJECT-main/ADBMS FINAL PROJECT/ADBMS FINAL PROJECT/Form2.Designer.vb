<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnadminlogin = New System.Windows.Forms.Button()
        Me.txtadminpass = New System.Windows.Forms.TextBox()
        Me.txtadminuser = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.cbremember = New System.Windows.Forms.CheckBox()
        Me.btnadback1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(176, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 24)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "ADMIN LOGIN"
        '
        'btnadminlogin
        '
        Me.btnadminlogin.Location = New System.Drawing.Point(46, 220)
        Me.btnadminlogin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnadminlogin.Name = "btnadminlogin"
        Me.btnadminlogin.Size = New System.Drawing.Size(363, 48)
        Me.btnadminlogin.TabIndex = 17
        Me.btnadminlogin.Text = "LOGIN"
        Me.btnadminlogin.UseVisualStyleBackColor = True
        '
        'txtadminpass
        '
        Me.txtadminpass.Location = New System.Drawing.Point(155, 154)
        Me.txtadminpass.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtadminpass.Name = "txtadminpass"
        Me.txtadminpass.Size = New System.Drawing.Size(252, 26)
        Me.txtadminpass.TabIndex = 16
        '
        'txtadminuser
        '
        Me.txtadminuser.Location = New System.Drawing.Point(155, 104)
        Me.txtadminuser.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtadminuser.Name = "txtadminuser"
        Me.txtadminuser.Size = New System.Drawing.Size(252, 26)
        Me.txtadminuser.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 24)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "PASSWORD:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 24)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "USERNAME:"
        '
        'cbremember
        '
        Me.cbremember.AutoSize = True
        Me.cbremember.Location = New System.Drawing.Point(155, 188)
        Me.cbremember.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbremember.Name = "cbremember"
        Me.cbremember.Size = New System.Drawing.Size(183, 24)
        Me.cbremember.TabIndex = 19
        Me.cbremember.Text = "SHOW PASSOWRD"
        Me.cbremember.UseVisualStyleBackColor = True
        '
        'btnadback1
        '
        Me.btnadback1.Location = New System.Drawing.Point(12, 22)
        Me.btnadback1.Name = "btnadback1"
        Me.btnadback1.Size = New System.Drawing.Size(81, 32)
        Me.btnadback1.TabIndex = 21
        Me.btnadback1.Text = "BACK"
        Me.btnadback1.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 332)
        Me.Controls.Add(Me.btnadback1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnadminlogin)
        Me.Controls.Add(Me.txtadminpass)
        Me.Controls.Add(Me.txtadminuser)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbremember)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents btnadminlogin As Button
    Friend WithEvents txtadminpass As TextBox
    Friend WithEvents txtadminuser As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents cbremember As CheckBox
    Friend WithEvents btnadback1 As Button
End Class
