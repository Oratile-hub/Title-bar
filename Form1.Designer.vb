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
        btnChangeTitleBar = New Button()
        Label1 = New Label()
        txtTitleBar = New TextBox()
        SuspendLayout()
        ' 
        ' btnChangeTitleBar
        ' 
        btnChangeTitleBar.BackColor = SystemColors.ControlLightLight
        btnChangeTitleBar.Location = New Point(380, 335)
        btnChangeTitleBar.Name = "btnChangeTitleBar"
        btnChangeTitleBar.Size = New Size(179, 55)
        btnChangeTitleBar.TabIndex = 0
        btnChangeTitleBar.Text = "Change Title Bar"
        btnChangeTitleBar.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(259, 169)
        Label1.Name = "Label1"
        Label1.Size = New Size(109, 25)
        Label1.TabIndex = 1
        Label1.Text = "Title Bar Text"
        ' 
        ' txtTitleBar
        ' 
        txtTitleBar.Location = New Point(380, 169)
        txtTitleBar.Name = "txtTitleBar"
        txtTitleBar.Size = New Size(179, 31)
        txtTitleBar.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtTitleBar)
        Controls.Add(Label1)
        Controls.Add(btnChangeTitleBar)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnChangeTitleBar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTitleBar As TextBox
End Class
