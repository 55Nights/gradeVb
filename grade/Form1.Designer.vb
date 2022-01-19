<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.mathScore = New System.Windows.Forms.TextBox()
        Me.artScore = New System.Windows.Forms.TextBox()
        Me.scieScore = New System.Windows.Forms.TextBox()
        Me.swascore = New System.Windows.Forms.TextBox()
        Me.engScore = New System.Windows.Forms.TextBox()
        Me.total = New System.Windows.Forms.Label()
        Me.average = New System.Windows.Forms.Label()
        Me.lockBtn = New System.Windows.Forms.Button()
        Me.editBtn = New System.Windows.Forms.Button()
        Me.extBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(69, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "English"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(69, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "kiswahili"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(69, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Mathematics"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(69, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Science"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(69, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Arts"
        '
        'mathScore
        '
        Me.mathScore.Location = New System.Drawing.Point(142, 80)
        Me.mathScore.Name = "mathScore"
        Me.mathScore.Size = New System.Drawing.Size(100, 20)
        Me.mathScore.TabIndex = 5
        '
        'artScore
        '
        Me.artScore.Location = New System.Drawing.Point(142, 137)
        Me.artScore.Name = "artScore"
        Me.artScore.Size = New System.Drawing.Size(100, 20)
        Me.artScore.TabIndex = 6
        '
        'scieScore
        '
        Me.scieScore.Location = New System.Drawing.Point(142, 106)
        Me.scieScore.Name = "scieScore"
        Me.scieScore.Size = New System.Drawing.Size(100, 20)
        Me.scieScore.TabIndex = 7
        '
        'swascore
        '
        Me.swascore.Location = New System.Drawing.Point(142, 54)
        Me.swascore.Name = "swascore"
        Me.swascore.Size = New System.Drawing.Size(100, 20)
        Me.swascore.TabIndex = 8
        '
        'engScore
        '
        Me.engScore.Location = New System.Drawing.Point(142, 28)
        Me.engScore.Name = "engScore"
        Me.engScore.Size = New System.Drawing.Size(100, 20)
        Me.engScore.TabIndex = 9
        '
        'total
        '
        Me.total.AutoSize = True
        Me.total.Location = New System.Drawing.Point(88, 213)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(34, 13)
        Me.total.TabIndex = 10
        Me.total.Text = "Total "
        '
        'average
        '
        Me.average.AutoSize = True
        Me.average.Location = New System.Drawing.Point(154, 213)
        Me.average.Name = "average"
        Me.average.Size = New System.Drawing.Size(47, 13)
        Me.average.TabIndex = 11
        Me.average.Text = "Average"
        '
        'lockBtn
        '
        Me.lockBtn.Location = New System.Drawing.Point(72, 291)
        Me.lockBtn.Name = "lockBtn"
        Me.lockBtn.Size = New System.Drawing.Size(75, 23)
        Me.lockBtn.TabIndex = 12
        Me.lockBtn.Text = "Lock"
        Me.lockBtn.UseVisualStyleBackColor = True
        '
        'editBtn
        '
        Me.editBtn.Location = New System.Drawing.Point(153, 291)
        Me.editBtn.Name = "editBtn"
        Me.editBtn.Size = New System.Drawing.Size(75, 23)
        Me.editBtn.TabIndex = 13
        Me.editBtn.Text = "edit"
        Me.editBtn.UseVisualStyleBackColor = True
        '
        'extBtn
        '
        Me.extBtn.Location = New System.Drawing.Point(255, 291)
        Me.extBtn.Name = "extBtn"
        Me.extBtn.Size = New System.Drawing.Size(75, 23)
        Me.extBtn.TabIndex = 14
        Me.extBtn.Text = "Exit"
        Me.extBtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.extBtn)
        Me.Controls.Add(Me.editBtn)
        Me.Controls.Add(Me.lockBtn)
        Me.Controls.Add(Me.average)
        Me.Controls.Add(Me.total)
        Me.Controls.Add(Me.engScore)
        Me.Controls.Add(Me.swascore)
        Me.Controls.Add(Me.scieScore)
        Me.Controls.Add(Me.artScore)
        Me.Controls.Add(Me.mathScore)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents mathScore As TextBox
    Friend WithEvents artScore As TextBox
    Friend WithEvents scieScore As TextBox
    Friend WithEvents swascore As TextBox
    Friend WithEvents engScore As TextBox
    Friend WithEvents total As Label
    Friend WithEvents average As Label
    Friend WithEvents lockBtn As Button
    Friend WithEvents editBtn As Button
    Friend WithEvents extBtn As Button
End Class
