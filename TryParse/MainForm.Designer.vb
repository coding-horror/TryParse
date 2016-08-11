<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CloseButton = New System.Windows.Forms.Button
        Me.RunButton = New System.Windows.Forms.Button
        Me.SuccessRateNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.StringCountNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        CType(Me.SuccessRateNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StringCountNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CloseButton
        '
        Me.CloseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CloseButton.Location = New System.Drawing.Point(444, 358)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(75, 23)
        Me.CloseButton.TabIndex = 0
        Me.CloseButton.Text = "Close"
        '
        'RunButton
        '
        Me.RunButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RunButton.Location = New System.Drawing.Point(363, 358)
        Me.RunButton.Name = "RunButton"
        Me.RunButton.Size = New System.Drawing.Size(75, 23)
        Me.RunButton.TabIndex = 1
        Me.RunButton.Text = "Run"
        '
        'SuccessRateNumericUpDown
        '
        Me.SuccessRateNumericUpDown.Location = New System.Drawing.Point(346, 12)
        Me.SuccessRateNumericUpDown.Name = "SuccessRateNumericUpDown"
        Me.SuccessRateNumericUpDown.Size = New System.Drawing.Size(58, 20)
        Me.SuccessRateNumericUpDown.TabIndex = 5
        Me.SuccessRateNumericUpDown.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebBrowser1.Location = New System.Drawing.Point(13, 39)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(506, 313)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(410, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "percent"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Attempt to convert"
        '
        'StringCountNumericUpDown
        '
        Me.StringCountNumericUpDown.Location = New System.Drawing.Point(108, 12)
        Me.StringCountNumericUpDown.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.StringCountNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.StringCountNumericUpDown.Name = "StringCountNumericUpDown"
        Me.StringCountNumericUpDown.Size = New System.Drawing.Size(58, 20)
        Me.StringCountNumericUpDown.TabIndex = 12
        Me.StringCountNumericUpDown.Value = New Decimal(New Integer() {1000, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(164, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 0)
        Me.Label5.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(172, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(168, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "string values with a success rate of"
        '
        'MainForm
        '
        Me.AcceptButton = Me.RunButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CloseButton
        Me.ClientSize = New System.Drawing.Size(531, 387)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.StringCountNumericUpDown)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.SuccessRateNumericUpDown)
        Me.Controls.Add(Me.RunButton)
        Me.Controls.Add(Me.CloseButton)
        Me.Name = "MainForm"
        Me.Text = "TryParse Benchmark"
        CType(Me.SuccessRateNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StringCountNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CloseButton As System.Windows.Forms.Button
    Friend WithEvents RunButton As System.Windows.Forms.Button
    Friend WithEvents SuccessRateNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents StringCountNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
