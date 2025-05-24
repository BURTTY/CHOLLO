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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtadminuser = New System.Windows.Forms.TextBox()
        Me.txtadminpass = New System.Windows.Forms.TextBox()
        Me.btnadminlogin = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(43, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "USERNAME:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "PASSWORD:"
        '
        'txtadminuser
        '
        Me.txtadminuser.Location = New System.Drawing.Point(156, 73)
        Me.txtadminuser.Name = "txtadminuser"
        Me.txtadminuser.Size = New System.Drawing.Size(252, 26)
        Me.txtadminuser.TabIndex = 2
        '
        'txtadminpass
        '
        Me.txtadminpass.Location = New System.Drawing.Point(156, 123)
        Me.txtadminpass.Name = "txtadminpass"
        Me.txtadminpass.Size = New System.Drawing.Size(252, 26)
        Me.txtadminpass.TabIndex = 3
        '
        'btnadminlogin
        '
        Me.btnadminlogin.Location = New System.Drawing.Point(45, 173)
        Me.btnadminlogin.Name = "btnadminlogin"
        Me.btnadminlogin.Size = New System.Drawing.Size(363, 48)
        Me.btnadminlogin.TabIndex = 4
        Me.btnadminlogin.Text = "LOGIN"
        Me.btnadminlogin.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(177, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "ADMIN LOGIN"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 279)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnadminlogin)
        Me.Controls.Add(Me.txtadminpass)
        Me.Controls.Add(Me.txtadminuser)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "ADMIN-LOGIN"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtadminuser As TextBox
    Friend WithEvents txtadminpass As TextBox
    Friend WithEvents btnadminlogin As Button
    Friend WithEvents Label3 As Label
End Class
