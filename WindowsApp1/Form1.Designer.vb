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
        Me.txtWord = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.lstWords = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rbToUpper = New System.Windows.Forms.RadioButton()
        Me.rbToLower = New System.Windows.Forms.RadioButton()
        Me.rbPurple = New System.Windows.Forms.RadioButton()
        Me.rbBlue = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(307, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter a name"
        '
        'txtWord
        '
        Me.txtWord.Location = New System.Drawing.Point(295, 40)
        Me.txtWord.Name = "txtWord"
        Me.txtWord.Size = New System.Drawing.Size(100, 20)
        Me.txtWord.TabIndex = 1
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(310, 85)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblDisplay
        '
        Me.lblDisplay.AutoSize = True
        Me.lblDisplay.Location = New System.Drawing.Point(328, 177)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(0, 13)
        Me.lblDisplay.TabIndex = 3
        '
        'lstWords
        '
        Me.lstWords.FormattingEnabled = True
        Me.lstWords.Location = New System.Drawing.Point(457, 40)
        Me.lstWords.Name = "lstWords"
        Me.lstWords.Size = New System.Drawing.Size(120, 95)
        Me.lstWords.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(151, 275)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Case"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(412, 275)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Color"
        '
        'rbToUpper
        '
        Me.rbToUpper.AutoSize = True
        Me.rbToUpper.Location = New System.Drawing.Point(130, 321)
        Me.rbToUpper.Name = "rbToUpper"
        Me.rbToUpper.Size = New System.Drawing.Size(70, 17)
        Me.rbToUpper.TabIndex = 7
        Me.rbToUpper.TabStop = True
        Me.rbToUpper.Text = "To Upper"
        Me.rbToUpper.UseVisualStyleBackColor = True
        '
        'rbToLower
        '
        Me.rbToLower.AutoSize = True
        Me.rbToLower.Location = New System.Drawing.Point(130, 375)
        Me.rbToLower.Name = "rbToLower"
        Me.rbToLower.Size = New System.Drawing.Size(70, 17)
        Me.rbToLower.TabIndex = 8
        Me.rbToLower.TabStop = True
        Me.rbToLower.Text = "To Lower"
        Me.rbToLower.UseVisualStyleBackColor = True
        '
        'rbPurple
        '
        Me.rbPurple.AutoSize = True
        Me.rbPurple.Location = New System.Drawing.Point(405, 321)
        Me.rbPurple.Name = "rbPurple"
        Me.rbPurple.Size = New System.Drawing.Size(55, 17)
        Me.rbPurple.TabIndex = 9
        Me.rbPurple.TabStop = True
        Me.rbPurple.Text = "Purple"
        Me.rbPurple.UseVisualStyleBackColor = True
        '
        'rbBlue
        '
        Me.rbBlue.AutoSize = True
        Me.rbBlue.Location = New System.Drawing.Point(405, 375)
        Me.rbBlue.Name = "rbBlue"
        Me.rbBlue.Size = New System.Drawing.Size(46, 17)
        Me.rbBlue.TabIndex = 10
        Me.rbBlue.TabStop = True
        Me.rbBlue.Text = "Blue"
        Me.rbBlue.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.rbBlue)
        Me.Controls.Add(Me.rbPurple)
        Me.Controls.Add(Me.rbToLower)
        Me.Controls.Add(Me.rbToUpper)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lstWords)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtWord)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtWord As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents lblDisplay As Label
    Friend WithEvents lstWords As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents rbToUpper As RadioButton
    Friend WithEvents rbToLower As RadioButton
    Friend WithEvents rbPurple As RadioButton
    Friend WithEvents rbBlue As RadioButton
End Class
