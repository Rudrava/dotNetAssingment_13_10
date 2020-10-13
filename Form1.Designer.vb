<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.input = New System.Windows.Forms.TextBox()
        Me.addArrBtn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ShowArrBtn = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SumBtn = New System.Windows.Forms.Button()
        Me.arrOpLbl = New System.Windows.Forms.Label()
        Me.SumOpLbl = New System.Windows.Forms.Label()
        Me.dimentionSwitch = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Fira Code", 24.0!)
        Me.Label1.Location = New System.Drawing.Point(171, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(397, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Array Sum Generator"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Fira Code", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(53, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Add Element"
        '
        'input
        '
        Me.input.AcceptsReturn = True
        Me.input.Font = New System.Drawing.Font("Fira Code", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.input.Location = New System.Drawing.Point(178, 101)
        Me.input.MinimumSize = New System.Drawing.Size(200, 40)
        Me.input.Name = "input"
        Me.input.Size = New System.Drawing.Size(200, 41)
        Me.input.TabIndex = 2
        '
        'addArrBtn
        '
        Me.addArrBtn.Font = New System.Drawing.Font("Fira Code", 12.0!)
        Me.addArrBtn.Location = New System.Drawing.Point(384, 104)
        Me.addArrBtn.Name = "addArrBtn"
        Me.addArrBtn.Size = New System.Drawing.Size(75, 35)
        Me.addArrBtn.TabIndex = 3
        Me.addArrBtn.Text = "Add"
        Me.addArrBtn.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Fira Code", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(53, 204)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "The Array "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Fira Code", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(53, 289)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "The Sum"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Fira Code", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(-153, 382)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 20)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "The Sum"
        '
        'ShowArrBtn
        '
        Me.ShowArrBtn.Font = New System.Drawing.Font("Fira Code", 12.0!)
        Me.ShowArrBtn.Location = New System.Drawing.Point(178, 197)
        Me.ShowArrBtn.Name = "ShowArrBtn"
        Me.ShowArrBtn.Size = New System.Drawing.Size(119, 35)
        Me.ShowArrBtn.TabIndex = 3
        Me.ShowArrBtn.Text = "Show"
        Me.ShowArrBtn.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Fira Code", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(-153, 467)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 20)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "The Sum"
        '
        'SumBtn
        '
        Me.SumBtn.Font = New System.Drawing.Font("Fira Code", 12.0!)
        Me.SumBtn.Location = New System.Drawing.Point(178, 282)
        Me.SumBtn.Name = "SumBtn"
        Me.SumBtn.Size = New System.Drawing.Size(119, 35)
        Me.SumBtn.TabIndex = 3
        Me.SumBtn.Text = "Sum"
        Me.SumBtn.UseVisualStyleBackColor = True
        '
        'arrOpLbl
        '
        Me.arrOpLbl.AutoSize = True
        Me.arrOpLbl.Font = New System.Drawing.Font("Fira Code", 12.0!)
        Me.arrOpLbl.Location = New System.Drawing.Point(421, 197)
        Me.arrOpLbl.Name = "arrOpLbl"
        Me.arrOpLbl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.arrOpLbl.Size = New System.Drawing.Size(59, 20)
        Me.arrOpLbl.TabIndex = 1
        Me.arrOpLbl.Text = "Arr: "
        Me.arrOpLbl.Visible = False
        '
        'SumOpLbl
        '
        Me.SumOpLbl.AutoSize = True
        Me.SumOpLbl.Font = New System.Drawing.Font("Fira Code", 12.0!)
        Me.SumOpLbl.Location = New System.Drawing.Point(333, 289)
        Me.SumOpLbl.Name = "SumOpLbl"
        Me.SumOpLbl.Size = New System.Drawing.Size(59, 20)
        Me.SumOpLbl.TabIndex = 1
        Me.SumOpLbl.Text = "Sum: "
        Me.SumOpLbl.Visible = False
        '
        'dimentionSwitch
        '
        Me.dimentionSwitch.Font = New System.Drawing.Font("Fira Code", 16.0!)
        Me.dimentionSwitch.Location = New System.Drawing.Point(525, 97)
        Me.dimentionSwitch.Name = "dimentionSwitch"
        Me.dimentionSwitch.Size = New System.Drawing.Size(101, 45)
        Me.dimentionSwitch.TabIndex = 4
        Me.dimentionSwitch.Text = "2d"
        Me.dimentionSwitch.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(737, 389)
        Me.Controls.Add(Me.dimentionSwitch)
        Me.Controls.Add(Me.SumBtn)
        Me.Controls.Add(Me.ShowArrBtn)
        Me.Controls.Add(Me.addArrBtn)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.input)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.SumOpLbl)
        Me.Controls.Add(Me.arrOpLbl)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Fira Code", 8.25!)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents input As TextBox
    Friend WithEvents addArrBtn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ShowArrBtn As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents SumBtn As Button
    Friend WithEvents arrOpLbl As Label
    Friend WithEvents SumOpLbl As Label
    Friend WithEvents dimentionSwitch As Button
End Class
