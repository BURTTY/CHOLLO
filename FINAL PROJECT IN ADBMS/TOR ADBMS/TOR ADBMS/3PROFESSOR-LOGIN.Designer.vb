<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _3PROFESSOR_LOGIN
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
        Me.btnproflogin = New System.Windows.Forms.Button()
        Me.txtprofpass = New System.Windows.Forms.TextBox()
        Me.txtprofuser = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(152, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(171, 24)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "PROFESSOR LOGIN"
        '
        'btnproflogin
        '
        Me.btnproflogin.Location = New System.Drawing.Point(45, 182)
        Me.btnproflogin.Name = "btnproflogin"
        Me.btnproflogin.Size = New System.Drawing.Size(363, 48)
        Me.btnproflogin.TabIndex = 10
        Me.btnproflogin.Text = "LOGIN"
        Me.btnproflogin.UseVisualStyleBackColor = True
        '
        'txtprofpass
        '
        Me.txtprofpass.Location = New System.Drawing.Point(156, 132)
        Me.txtprofpass.Name = "txtprofpass"
        Me.txtprofpass.Size = New System.Drawing.Size(252, 26)
        Me.txtprofpass.TabIndex = 9
        '
        'txtprofuser
        '
        Me.txtprofuser.Location = New System.Drawing.Point(158, 82)
        Me.txtprofuser.Name = "txtprofuser"
        Me.txtprofuser.Size = New System.Drawing.Size(252, 26)
        Me.txtprofuser.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 24)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "PASSWORD:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(43, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 24)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "USERNAME:"
        '
        '_3PROFESSOR_LOGIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 278)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnproflogin)
        Me.Controls.Add(Me.txtprofpass)
        Me.Controls.Add(Me.txtprofuser)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "_3PROFESSOR_LOGIN"
        Me.Text = "PROFESSOR-LOGIN "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents btnproflogin As Button
    Friend WithEvents txtprofpass As TextBox
    Friend WithEvents txtprofuser As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
