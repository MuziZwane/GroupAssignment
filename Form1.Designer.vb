<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPoverty
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
        Me.txtClear = New System.Windows.Forms.Button()
        Me.btnInput = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnRead = New System.Windows.Forms.Button()
        Me.txtDisplay = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtClear
        '
        Me.txtClear.BackColor = System.Drawing.SystemColors.Highlight
        Me.txtClear.Location = New System.Drawing.Point(12, 285)
        Me.txtClear.Name = "txtClear"
        Me.txtClear.Size = New System.Drawing.Size(124, 52)
        Me.txtClear.TabIndex = 0
        Me.txtClear.Text = "Clear TextBox"
        Me.txtClear.UseVisualStyleBackColor = False
        '
        'btnInput
        '
        Me.btnInput.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnInput.Location = New System.Drawing.Point(12, 47)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(124, 43)
        Me.btnInput.TabIndex = 1
        Me.btnInput.Text = "Enter Data"
        Me.btnInput.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnSave.Location = New System.Drawing.Point(12, 127)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(124, 46)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Save Data"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnRead
        '
        Me.btnRead.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnRead.Location = New System.Drawing.Point(12, 210)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(124, 48)
        Me.btnRead.TabIndex = 3
        Me.btnRead.Text = "Read Data"
        Me.btnRead.UseVisualStyleBackColor = False
        '
        'txtDisplay
        '
        Me.txtDisplay.Location = New System.Drawing.Point(153, 35)
        Me.txtDisplay.Multiline = True
        Me.txtDisplay.Name = "txtDisplay"
        Me.txtDisplay.ReadOnly = True
        Me.txtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtDisplay.Size = New System.Drawing.Size(238, 302)
        Me.txtDisplay.TabIndex = 4
        '
        'frmPoverty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(403, 374)
        Me.Controls.Add(Me.txtDisplay)
        Me.Controls.Add(Me.btnRead)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnInput)
        Me.Controls.Add(Me.txtClear)
        Me.Name = "frmPoverty"
        Me.Text = "The Citizen's App"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtClear As Button
    Friend WithEvents btnInput As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnRead As Button
    Friend WithEvents txtDisplay As TextBox
End Class
