<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.btnPower = New System.Windows.Forms.Button()
        Me.btnPick = New System.Windows.Forms.Button()
        Me.btnMega = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnPower
        '
        Me.btnPower.Location = New System.Drawing.Point(39, 29)
        Me.btnPower.Name = "btnPower"
        Me.btnPower.Size = New System.Drawing.Size(111, 61)
        Me.btnPower.TabIndex = 0
        Me.btnPower.Text = "Power Ball"
        Me.btnPower.UseVisualStyleBackColor = True
        '
        'btnPick
        '
        Me.btnPick.Location = New System.Drawing.Point(181, 30)
        Me.btnPick.Name = "btnPick"
        Me.btnPick.Size = New System.Drawing.Size(111, 61)
        Me.btnPick.TabIndex = 1
        Me.btnPick.Text = "The Pick"
        Me.btnPick.UseVisualStyleBackColor = True
        '
        'btnMega
        '
        Me.btnMega.Location = New System.Drawing.Point(321, 30)
        Me.btnMega.Name = "btnMega"
        Me.btnMega.Size = New System.Drawing.Size(111, 61)
        Me.btnMega.TabIndex = 2
        Me.btnMega.Text = "Mega Millions"
        Me.btnMega.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(473, 121)
        Me.Controls.Add(Me.btnMega)
        Me.Controls.Add(Me.btnPick)
        Me.Controls.Add(Me.btnPower)
        Me.Name = "MainForm"
        Me.Text = "Lottery Number Generator"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnPower As System.Windows.Forms.Button
    Friend WithEvents btnPick As System.Windows.Forms.Button
    Friend WithEvents btnMega As System.Windows.Forms.Button

End Class
