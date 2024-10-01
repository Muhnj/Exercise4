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
        lstBox = New ListBox()
        btnMultiplication = New Button()
        SuspendLayout()
        ' 
        ' lstBox
        ' 
        lstBox.FormattingEnabled = True
        lstBox.ItemHeight = 15
        lstBox.Location = New Point(24, 12)
        lstBox.Name = "lstBox"
        lstBox.Size = New Size(480, 274)
        lstBox.TabIndex = 0
        ' 
        ' btnMultiplication
        ' 
        btnMultiplication.Location = New Point(180, 306)
        btnMultiplication.Name = "btnMultiplication"
        btnMultiplication.Size = New Size(173, 27)
        btnMultiplication.TabIndex = 1
        btnMultiplication.Text = "Multiplication"
        btnMultiplication.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnMultiplication)
        Controls.Add(lstBox)
        Name = "Form1"
        Text = "Exercise4"
        ResumeLayout(False)
    End Sub

    Friend WithEvents lstBox As ListBox
    Friend WithEvents btnMultiplication As Button

End Class
