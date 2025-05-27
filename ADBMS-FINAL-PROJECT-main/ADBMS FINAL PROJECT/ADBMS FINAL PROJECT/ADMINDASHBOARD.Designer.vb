<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ADMINDASHBOARD
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.txtzip = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtprov = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtmunicity = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtbrgy = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtstreet = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txthome = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cln_username = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cln_firstname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cln_middlename = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ADM_LAST = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cln_email = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cln_address = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cbofilter = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lvadmin = New System.Windows.Forms.ListView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpbirth = New System.Windows.Forms.DateTimePicker()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.btndele = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtadfirst = New System.Windows.Forms.TextBox()
        Me.txtadmid = New System.Windows.Forms.TextBox()
        Me.txtadlast = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtadcon = New System.Windows.Forms.TextBox()
        Me.txtademail = New System.Windows.Forms.TextBox()
        Me.txtadpass = New System.Windows.Forms.TextBox()
        Me.txtaduser = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbShowPass = New System.Windows.Forms.CheckBox()
        Me.btnadclear = New System.Windows.Forms.Button()
        Me.btnadupdate = New System.Windows.Forms.Button()
        Me.btnadback = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtsearch
        '
        Me.txtsearch.Location = New System.Drawing.Point(477, 508)
        Me.txtsearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(263, 26)
        Me.txtsearch.TabIndex = 58
        '
        'txtzip
        '
        Me.txtzip.Location = New System.Drawing.Point(115, 204)
        Me.txtzip.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtzip.Name = "txtzip"
        Me.txtzip.Size = New System.Drawing.Size(263, 26)
        Me.txtzip.TabIndex = 27
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(8, 202)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(93, 24)
        Me.Label17.TabIndex = 26
        Me.Label17.Text = "ZIP CODE:"
        '
        'txtprov
        '
        Me.txtprov.Location = New System.Drawing.Point(115, 162)
        Me.txtprov.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtprov.Name = "txtprov"
        Me.txtprov.Size = New System.Drawing.Size(263, 26)
        Me.txtprov.TabIndex = 16
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(10, 162)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(101, 24)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "PROVINCE:"
        '
        'txtmunicity
        '
        Me.txtmunicity.Location = New System.Drawing.Point(173, 122)
        Me.txtmunicity.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtmunicity.Name = "txtmunicity"
        Me.txtmunicity.Size = New System.Drawing.Size(263, 26)
        Me.txtmunicity.TabIndex = 14
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(9, 122)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(170, 24)
        Me.Label15.TabIndex = 13
        Me.Label15.Text = "MUNICIPALITY/CITY:"
        '
        'txtbrgy
        '
        Me.txtbrgy.Location = New System.Drawing.Point(124, 90)
        Me.txtbrgy.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtbrgy.Name = "txtbrgy"
        Me.txtbrgy.Size = New System.Drawing.Size(263, 26)
        Me.txtbrgy.TabIndex = 12
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(9, 90)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(107, 24)
        Me.Label14.TabIndex = 11
        Me.Label14.Text = "BARANGAY:"
        '
        'txtstreet
        '
        Me.txtstreet.Location = New System.Drawing.Point(124, 58)
        Me.txtstreet.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtstreet.Name = "txtstreet"
        Me.txtstreet.Size = New System.Drawing.Size(263, 26)
        Me.txtstreet.TabIndex = 10
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(9, 58)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 24)
        Me.Label13.TabIndex = 9
        Me.Label13.Text = "STREET:"
        '
        'txthome
        '
        Me.txthome.Location = New System.Drawing.Point(124, 25)
        Me.txthome.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txthome.Name = "txthome"
        Me.txthome.Size = New System.Drawing.Size(263, 26)
        Me.txthome.TabIndex = 8
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(9, 25)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 24)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "HOME:"
        '
        'cln_username
        '
        Me.cln_username.Text = "USER NAME"
        Me.cln_username.Width = 181
        '
        'cln_firstname
        '
        Me.cln_firstname.Text = "FIRST NAME"
        Me.cln_firstname.Width = 175
        '
        'cln_middlename
        '
        Me.cln_middlename.Text = "MIDDLE NAME"
        Me.cln_middlename.Width = 144
        '
        'ADM_LAST
        '
        Me.ADM_LAST.Text = "LAST NAME"
        Me.ADM_LAST.Width = 158
        '
        'cln_email
        '
        Me.cln_email.Text = "EMAIL"
        Me.cln_email.Width = 201
        '
        'cln_address
        '
        Me.cln_address.Text = "ADDRESS"
        Me.cln_address.Width = 459
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(411, 508)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(69, 24)
        Me.Label19.TabIndex = 57
        Me.Label19.Text = "Search:"
        '
        'cbofilter
        '
        Me.cbofilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.cbofilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbofilter.FormattingEnabled = True
        Me.cbofilter.Items.AddRange(New Object() {"USER NAME", "FIRST NAME", "MIDDLE NAME", "LAST NAME", "EMAIL", "ADDRESS"})
        Me.cbofilter.Location = New System.Drawing.Point(153, 508)
        Me.cbofilter.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbofilter.Name = "cbofilter"
        Me.cbofilter.Size = New System.Drawing.Size(230, 28)
        Me.cbofilter.TabIndex = 56
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(64, 508)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(79, 24)
        Me.Label18.TabIndex = 55
        Me.Label18.Text = "Filter By:"
        '
        'lvadmin
        '
        Me.lvadmin.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cln_username, Me.cln_firstname, Me.cln_middlename, Me.ADM_LAST, Me.cln_email, Me.cln_address})
        Me.lvadmin.FullRowSelect = True
        Me.lvadmin.Location = New System.Drawing.Point(65, 541)
        Me.lvadmin.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lvadmin.Name = "lvadmin"
        Me.lvadmin.Size = New System.Drawing.Size(1309, 170)
        Me.lvadmin.TabIndex = 54
        Me.lvadmin.UseCompatibleStateImageBehavior = False
        Me.lvadmin.View = System.Windows.Forms.View.Details
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtzip)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.txtprov)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txtmunicity)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtbrgy)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtstreet)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txthome)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Location = New System.Drawing.Point(520, 126)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(662, 256)
        Me.GroupBox1.TabIndex = 53
        Me.GroupBox1.TabStop = False
        '
        'dtpbirth
        '
        Me.dtpbirth.Location = New System.Drawing.Point(202, 422)
        Me.dtpbirth.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpbirth.Name = "dtpbirth"
        Me.dtpbirth.Size = New System.Drawing.Size(263, 26)
        Me.dtpbirth.TabIndex = 52
        '
        'btnexit
        '
        Me.btnexit.Location = New System.Drawing.Point(1187, 355)
        Me.btnexit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(176, 61)
        Me.btnexit.TabIndex = 51
        Me.btnexit.Text = "EXIT"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'btndele
        '
        Me.btndele.Location = New System.Drawing.Point(1187, 422)
        Me.btndele.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btndele.Name = "btndele"
        Me.btndele.Size = New System.Drawing.Size(176, 55)
        Me.btndele.TabIndex = 50
        Me.btndele.Text = "DELETE"
        Me.btndele.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(1188, 138)
        Me.btnsave.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(176, 58)
        Me.btnsave.TabIndex = 49
        Me.btnsave.Text = "SAVE"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(513, 76)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(162, 42)
        Me.Label11.TabIndex = 48
        Me.Label11.Text = "ADDRESS"
        '
        'txtadfirst
        '
        Me.txtadfirst.Location = New System.Drawing.Point(202, 290)
        Me.txtadfirst.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtadfirst.Name = "txtadfirst"
        Me.txtadfirst.Size = New System.Drawing.Size(263, 26)
        Me.txtadfirst.TabIndex = 47
        '
        'txtadmid
        '
        Me.txtadmid.Location = New System.Drawing.Point(202, 330)
        Me.txtadmid.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtadmid.Name = "txtadmid"
        Me.txtadmid.Size = New System.Drawing.Size(263, 26)
        Me.txtadmid.TabIndex = 46
        '
        'txtadlast
        '
        Me.txtadlast.Location = New System.Drawing.Point(202, 372)
        Me.txtadlast.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtadlast.Name = "txtadlast"
        Me.txtadlast.Size = New System.Drawing.Size(263, 26)
        Me.txtadlast.TabIndex = 45
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(64, 332)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(138, 24)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = "MIDDILE INITAL:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(64, 372)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 24)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "LASTNAME:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(65, 411)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 24)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "BIRTHDAY:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(64, 290)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 24)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "FIRSTNAME:"
        '
        'txtadcon
        '
        Me.txtadcon.Location = New System.Drawing.Point(179, 182)
        Me.txtadcon.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtadcon.Name = "txtadcon"
        Me.txtadcon.Size = New System.Drawing.Size(263, 26)
        Me.txtadcon.TabIndex = 40
        '
        'txtademail
        '
        Me.txtademail.Location = New System.Drawing.Point(181, 149)
        Me.txtademail.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtademail.Name = "txtademail"
        Me.txtademail.Size = New System.Drawing.Size(263, 26)
        Me.txtademail.TabIndex = 39
        '
        'txtadpass
        '
        Me.txtadpass.Location = New System.Drawing.Point(181, 94)
        Me.txtadpass.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtadpass.Name = "txtadpass"
        Me.txtadpass.Size = New System.Drawing.Size(263, 26)
        Me.txtadpass.TabIndex = 38
        '
        'txtaduser
        '
        Me.txtaduser.Location = New System.Drawing.Point(179, 60)
        Me.txtaduser.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtaduser.Name = "txtaduser"
        Me.txtaduser.Size = New System.Drawing.Size(263, 26)
        Me.txtaduser.TabIndex = 37
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(64, 151)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 24)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "EMAIL:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(65, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 24)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "CONTACT"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(64, 239)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 24)
        Me.Label4.TabIndex = 34
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(64, 279)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 24)
        Me.Label3.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(64, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 24)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "PASSWORD:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(64, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 24)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "USERNAME:"
        '
        'cbShowPass
        '
        Me.cbShowPass.AutoSize = True
        Me.cbShowPass.Location = New System.Drawing.Point(181, 120)
        Me.cbShowPass.Name = "cbShowPass"
        Me.cbShowPass.Size = New System.Drawing.Size(183, 24)
        Me.cbShowPass.TabIndex = 62
        Me.cbShowPass.Text = "SHOW PASSWORD"
        Me.cbShowPass.UseVisualStyleBackColor = True
        '
        'btnadclear
        '
        Me.btnadclear.Location = New System.Drawing.Point(1186, 288)
        Me.btnadclear.Name = "btnadclear"
        Me.btnadclear.Size = New System.Drawing.Size(177, 59)
        Me.btnadclear.TabIndex = 63
        Me.btnadclear.Text = "CLEAR"
        Me.btnadclear.UseVisualStyleBackColor = True
        '
        'btnadupdate
        '
        Me.btnadupdate.Location = New System.Drawing.Point(1187, 213)
        Me.btnadupdate.Name = "btnadupdate"
        Me.btnadupdate.Size = New System.Drawing.Size(177, 59)
        Me.btnadupdate.TabIndex = 64
        Me.btnadupdate.Text = "UPDATE"
        Me.btnadupdate.UseVisualStyleBackColor = True
        '
        'btnadback
        '
        Me.btnadback.Location = New System.Drawing.Point(930, 388)
        Me.btnadback.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnadback.Name = "btnadback"
        Me.btnadback.Size = New System.Drawing.Size(176, 55)
        Me.btnadback.TabIndex = 65
        Me.btnadback.Text = "BACK"
        Me.btnadback.UseVisualStyleBackColor = True
        '
        'ADMINDASHBOARD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1447, 842)
        Me.Controls.Add(Me.btnadback)
        Me.Controls.Add(Me.btnadupdate)
        Me.Controls.Add(Me.btnadclear)
        Me.Controls.Add(Me.cbShowPass)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.cbofilter)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.lvadmin)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dtpbirth)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btndele)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtadfirst)
        Me.Controls.Add(Me.txtadmid)
        Me.Controls.Add(Me.txtadlast)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtadcon)
        Me.Controls.Add(Me.txtademail)
        Me.Controls.Add(Me.txtadpass)
        Me.Controls.Add(Me.txtaduser)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ADMINDASHBOARD"
        Me.Text = "ADMINDASHBOARD"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtsearch As TextBox
    Friend WithEvents txtzip As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtprov As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtmunicity As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtbrgy As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtstreet As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txthome As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents cln_username As ColumnHeader
    Friend WithEvents cln_firstname As ColumnHeader
    Friend WithEvents cln_middlename As ColumnHeader
    Friend WithEvents ADM_LAST As ColumnHeader
    Friend WithEvents cln_email As ColumnHeader
    Friend WithEvents cln_address As ColumnHeader
    Friend WithEvents Label19 As Label
    Friend WithEvents cbofilter As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents lvadmin As ListView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtpbirth As DateTimePicker
    Friend WithEvents btnexit As Button
    Friend WithEvents btndele As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents txtadfirst As TextBox
    Friend WithEvents txtadmid As TextBox
    Friend WithEvents txtadlast As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtadcon As TextBox
    Friend WithEvents txtademail As TextBox
    Friend WithEvents txtadpass As TextBox
    Friend WithEvents txtaduser As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label1 As Label
    Friend WithEvents cbShowPass As CheckBox
    Friend WithEvents btnadclear As Button
    Friend WithEvents btnadupdate As Button
    Friend WithEvents btnadback As Button
End Class
