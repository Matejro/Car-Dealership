<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.components = New System.ComponentModel.Container()
        Me.Login = New System.Windows.Forms.Button()
        Me.Reset = New System.Windows.Forms.Button()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.Username = New System.Windows.Forms.TextBox()
        Me.LoginSystemDataSet = New Komis.LoginSystemDataSet()
        Me.LoginBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LoginTableAdapter = New Komis.LoginSystemDataSetTableAdapters.LoginTableAdapter()
        Me.TableAdapterManager = New Komis.LoginSystemDataSetTableAdapters.TableAdapterManager()
        CType(Me.LoginSystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Login
        '
        Me.Login.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Login.Location = New System.Drawing.Point(34, 198)
        Me.Login.Name = "Login"
        Me.Login.Size = New System.Drawing.Size(90, 35)
        Me.Login.TabIndex = 0
        Me.Login.Text = "Login"
        Me.Login.UseVisualStyleBackColor = True
        '
        'Reset
        '
        Me.Reset.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Reset.Location = New System.Drawing.Point(196, 198)
        Me.Reset.Name = "Reset"
        Me.Reset.Size = New System.Drawing.Size(90, 35)
        Me.Reset.TabIndex = 1
        Me.Reset.Text = "Reset"
        Me.Reset.UseVisualStyleBackColor = True
        '
        'ButtonExit
        '
        Me.ButtonExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ButtonExit.Location = New System.Drawing.Point(348, 198)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(90, 35)
        Me.ButtonExit.TabIndex = 2
        Me.ButtonExit.Text = "Exit"
        Me.ButtonExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(29, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(33, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Password"
        '
        'Password
        '
        Me.Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Password.Location = New System.Drawing.Point(157, 104)
        Me.Password.Multiline = True
        Me.Password.Name = "Password"
        Me.Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Password.Size = New System.Drawing.Size(281, 43)
        Me.Password.TabIndex = 5
        '
        'Username
        '
        Me.Username.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Username.Location = New System.Drawing.Point(157, 33)
        Me.Username.Multiline = True
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(281, 43)
        Me.Username.TabIndex = 6
        '
        'LoginSystemDataSet
        '
        Me.LoginSystemDataSet.DataSetName = "LoginSystemDataSet"
        Me.LoginSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LoginBindingSource
        '
        Me.LoginBindingSource.DataMember = "Login"
        Me.LoginBindingSource.DataSource = Me.LoginSystemDataSet
        '
        'LoginTableAdapter
        '
        Me.LoginTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.LoginTableAdapter = Me.LoginTableAdapter
        Me.TableAdapterManager.UpdateOrder = Komis.LoginSystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 253)
        Me.Controls.Add(Me.Username)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonExit)
        Me.Controls.Add(Me.Reset)
        Me.Controls.Add(Me.Login)
        Me.Name = "Form2"
        Me.Text = "Komis Login"
        CType(Me.LoginSystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoginBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Login As Button
    Friend WithEvents Reset As Button
    Friend WithEvents ButtonExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Password As TextBox
    Friend WithEvents Username As TextBox
    Friend WithEvents LoginSystemDataSet As LoginSystemDataSet
    Friend WithEvents LoginBindingSource As BindingSource
    Friend WithEvents LoginTableAdapter As LoginSystemDataSetTableAdapters.LoginTableAdapter
    Friend WithEvents TableAdapterManager As LoginSystemDataSetTableAdapters.TableAdapterManager
End Class
