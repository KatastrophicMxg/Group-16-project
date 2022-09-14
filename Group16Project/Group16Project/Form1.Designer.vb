<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmGDP
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
        Me.grdDisplay = New UJGrid.UJGrid()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'grdDisplay
        '
        Me.grdDisplay.FixedCols = 1
        Me.grdDisplay.FixedRows = 1
        Me.grdDisplay.Location = New System.Drawing.Point(43, 13)
        Me.grdDisplay.Margin = New System.Windows.Forms.Padding(4)
        Me.grdDisplay.Name = "grdDisplay"
        Me.grdDisplay.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.grdDisplay.Size = New System.Drawing.Size(701, 282)
        Me.grdDisplay.TabIndex = 0
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(141, 331)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(120, 50)
        Me.btnEnter.TabIndex = 1
        Me.btnEnter.Text = "Enter Data"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(326, 331)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(120, 50)
        Me.btnDisplay.TabIndex = 2
        Me.btnDisplay.Text = "Display Data"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'FrmGDP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.grdDisplay)
        Me.Name = "FrmGDP"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grdDisplay As UJGrid.UJGrid
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnDisplay As Button
End Class
