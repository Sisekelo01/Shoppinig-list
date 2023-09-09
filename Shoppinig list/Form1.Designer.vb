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
        addBtn = New Button()
        shoppinglistLabel1 = New Label()
        txtadd = New TextBox()
        ListBox1 = New ListBox()
        SuspendLayout()
        ' 
        ' addBtn
        ' 
        addBtn.Location = New Point(497, 87)
        addBtn.Name = "addBtn"
        addBtn.Size = New Size(75, 23)
        addBtn.TabIndex = 0
        addBtn.Text = "Add"
        addBtn.UseVisualStyleBackColor = True
        ' 
        ' shoppinglistLabel1
        ' 
        shoppinglistLabel1.AutoSize = True
        shoppinglistLabel1.Location = New Point(418, 47)
        shoppinglistLabel1.Name = "shoppinglistLabel1"
        shoppinglistLabel1.Size = New Size(76, 15)
        shoppinglistLabel1.TabIndex = 2
        shoppinglistLabel1.Text = "Shopping list"
        ' 
        ' txtadd
        ' 
        txtadd.Location = New Point(318, 87)
        txtadd.Name = "txtadd"
        txtadd.Size = New Size(100, 23)
        txtadd.TabIndex = 3
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(318, 154)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(254, 94)
        ListBox1.TabIndex = 4
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ListBox1)
        Controls.Add(txtadd)
        Controls.Add(shoppinglistLabel1)
        Controls.Add(addBtn)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents addBtn As Button
    Friend WithEvents shoppinglistLabel1 As Label
    Friend WithEvents txtadd As TextBox
    Friend WithEvents ListBox1 As ListBox
End Class
