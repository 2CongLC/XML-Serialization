﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Button1 = New Button()
        Button2 = New Button()
        OpenFileDialog1 = New OpenFileDialog()
        SaveFileDialog1 = New SaveFileDialog()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        Button7 = New Button()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Button8 = New Button()
        Button9 = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(198, 177)
        Button1.Name = "Button1"
        Button1.Size = New Size(120, 23)
        Button1.TabIndex = 0
        Button1.Text = "Encoder"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(198, 206)
        Button2.Name = "Button2"
        Button2.Size = New Size(120, 23)
        Button2.TabIndex = 1
        Button2.Text = "Decoder"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.Filter = "Xml File (*.xml|*.xml|All Files (*.*)|*.*"
        ' 
        ' SaveFileDialog1
        ' 
        SaveFileDialog1.Filter = "Xml File (*.xml|*.xml|All Files (*.*)|*.*"
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(34, 12)
        Button3.Name = "Button3"
        Button3.Size = New Size(173, 23)
        Button3.TabIndex = 2
        Button3.Text = "Write DataContract"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(12, 139)
        Button4.Name = "Button4"
        Button4.Size = New Size(222, 23)
        Button4.TabIndex = 3
        Button4.Text = "Read DataContract"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(12, 177)
        Button5.Name = "Button5"
        Button5.Size = New Size(156, 23)
        Button5.TabIndex = 4
        Button5.Text = "Write Element"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(12, 206)
        Button6.Name = "Button6"
        Button6.Size = New Size(156, 23)
        Button6.TabIndex = 5
        Button6.Text = "Write Node"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Location = New Point(12, 235)
        Button7.Name = "Button7"
        Button7.Size = New Size(156, 23)
        Button7.TabIndex = 6
        Button7.Text = "Write DataSet"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(12, 53)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(222, 23)
        TextBox1.TabIndex = 7
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(12, 92)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(222, 23)
        TextBox2.TabIndex = 8
        ' 
        ' Button8
        ' 
        Button8.Location = New Point(204, 241)
        Button8.Name = "Button8"
        Button8.Size = New Size(114, 23)
        Button8.TabIndex = 9
        Button8.Text = "Encoder1"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Button9
        ' 
        Button9.Location = New Point(214, 270)
        Button9.Name = "Button9"
        Button9.Size = New Size(104, 23)
        Button9.TabIndex = 10
        Button9.Text = "Decoder1"
        Button9.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(363, 346)
        Controls.Add(Button9)
        Controls.Add(Button8)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Button7)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button

End Class
