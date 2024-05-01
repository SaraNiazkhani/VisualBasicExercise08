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
        NumberLabel = New Label()
        OutputLabel = New Label()
        NumberTextBox = New TextBox()
        RunButton = New Button()
        ExitButton = New Button()
        SuspendLayout()
        ' 
        ' NumberLabel
        ' 
        NumberLabel.AutoSize = True
        NumberLabel.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        NumberLabel.Location = New Point(54, 78)
        NumberLabel.Name = "NumberLabel"
        NumberLabel.Size = New Size(85, 21)
        NumberLabel.TabIndex = 0
        NumberLabel.Text = "Number  :"
        ' 
        ' OutputLabel
        ' 
        OutputLabel.AutoSize = True
        OutputLabel.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point)
        OutputLabel.Location = New Point(83, 243)
        OutputLabel.Name = "OutputLabel"
        OutputLabel.Size = New Size(0, 19)
        OutputLabel.TabIndex = 1
        ' 
        ' NumberTextBox
        ' 
        NumberTextBox.Location = New Point(145, 69)
        NumberTextBox.Multiline = True
        NumberTextBox.Name = "NumberTextBox"
        NumberTextBox.Size = New Size(122, 40)
        NumberTextBox.TabIndex = 2
        ' 
        ' RunButton
        ' 
        RunButton.BackColor = Color.Peru
        RunButton.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        RunButton.Location = New Point(145, 131)
        RunButton.Name = "RunButton"
        RunButton.Size = New Size(141, 42)
        RunButton.TabIndex = 3
        RunButton.Text = "Run"
        RunButton.UseVisualStyleBackColor = False
        ' 
        ' ExitButton
        ' 
        ExitButton.BackColor = Color.OrangeRed
        ExitButton.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ExitButton.Location = New Point(388, 203)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(101, 55)
        ExitButton.TabIndex = 4
        ExitButton.Text = "EXIT"
        ExitButton.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PeachPuff
        ClientSize = New Size(532, 402)
        Controls.Add(ExitButton)
        Controls.Add(RunButton)
        Controls.Add(NumberTextBox)
        Controls.Add(OutputLabel)
        Controls.Add(NumberLabel)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents NumberLabel As Label
    Friend WithEvents OutputLabel As Label
    Friend WithEvents NumberTextBox As TextBox
    Friend WithEvents RunButton As Button
    Friend WithEvents ExitButton As Button
End Class
