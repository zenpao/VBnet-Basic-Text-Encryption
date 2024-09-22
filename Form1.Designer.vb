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
        Me.txt_String = New System.Windows.Forms.TextBox()
        Me.btn_Encrypt = New System.Windows.Forms.Button()
        Me.btn_Decrypt = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_String
        '
        Me.txt_String.Location = New System.Drawing.Point(24, 32)
        Me.txt_String.Multiline = True
        Me.txt_String.Name = "txt_String"
        Me.txt_String.Size = New System.Drawing.Size(232, 128)
        Me.txt_String.TabIndex = 0
        '
        'btn_Encrypt
        '
        Me.btn_Encrypt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Encrypt.Location = New System.Drawing.Point(35, 175)
        Me.btn_Encrypt.Name = "btn_Encrypt"
        Me.btn_Encrypt.Size = New System.Drawing.Size(90, 32)
        Me.btn_Encrypt.TabIndex = 1
        Me.btn_Encrypt.Text = "Encrypt"
        Me.btn_Encrypt.UseVisualStyleBackColor = True
        '
        'btn_Decrypt
        '
        Me.btn_Decrypt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Decrypt.Location = New System.Drawing.Point(143, 175)
        Me.btn_Decrypt.Name = "btn_Decrypt"
        Me.btn_Decrypt.Size = New System.Drawing.Size(90, 32)
        Me.btn_Decrypt.TabIndex = 2
        Me.btn_Decrypt.Text = "Decrypt"
        Me.btn_Decrypt.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(278, 219)
        Me.Controls.Add(Me.btn_Decrypt)
        Me.Controls.Add(Me.btn_Encrypt)
        Me.Controls.Add(Me.txt_String)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Basic Encryption"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_String As System.Windows.Forms.TextBox
    Friend WithEvents btn_Encrypt As System.Windows.Forms.Button
    Friend WithEvents btn_Decrypt As System.Windows.Forms.Button

End Class
