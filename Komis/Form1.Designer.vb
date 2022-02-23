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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Klasyczny = New System.Windows.Forms.RadioButton()
        Me.Metalic = New System.Windows.Forms.RadioButton()
        Me.Marka = New System.Windows.Forms.ComboBox()
        Me.Model = New System.Windows.Forms.ComboBox()
        Me.Silnik = New System.Windows.Forms.ComboBox()
        Me.Lakier = New System.Windows.Forms.ComboBox()
        Me.Zatwierdz = New System.Windows.Forms.Button()
        Me.Wyczysc = New System.Windows.Forms.Button()
        Me.Miniaturka = New System.Windows.Forms.PictureBox()
        Me.ComboBoxKomis = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtStatus = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.OpcjeTak = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.OpcjeBox = New System.Windows.Forms.ComboBox()
        Me.OpcjeNie = New System.Windows.Forms.RadioButton()
        Me.lblLastRated = New System.Windows.Forms.Label()
        Me.Gwiazdki1 = New Gwiazdki.Gwiazdki()
        Me.DataGridViewOceny = New System.Windows.Forms.DataGridView()
        CType(Me.Miniaturka, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridViewOceny, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 58)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Marka"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 98)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Model"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 138)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Silnik"
        '
        'Klasyczny
        '
        Me.Klasyczny.AutoSize = True
        Me.Klasyczny.Location = New System.Drawing.Point(28, 15)
        Me.Klasyczny.Margin = New System.Windows.Forms.Padding(2)
        Me.Klasyczny.Name = "Klasyczny"
        Me.Klasyczny.Size = New System.Drawing.Size(72, 17)
        Me.Klasyczny.TabIndex = 4
        Me.Klasyczny.Text = "Klasyczny"
        Me.Klasyczny.UseVisualStyleBackColor = True
        '
        'Metalic
        '
        Me.Metalic.AutoSize = True
        Me.Metalic.Location = New System.Drawing.Point(104, 15)
        Me.Metalic.Margin = New System.Windows.Forms.Padding(2)
        Me.Metalic.Name = "Metalic"
        Me.Metalic.Size = New System.Drawing.Size(59, 17)
        Me.Metalic.TabIndex = 5
        Me.Metalic.Text = "Metalic"
        Me.Metalic.UseVisualStyleBackColor = True
        '
        'Marka
        '
        Me.Marka.FormattingEnabled = True
        Me.Marka.Location = New System.Drawing.Point(55, 55)
        Me.Marka.Margin = New System.Windows.Forms.Padding(2)
        Me.Marka.Name = "Marka"
        Me.Marka.Size = New System.Drawing.Size(193, 21)
        Me.Marka.TabIndex = 6
        '
        'Model
        '
        Me.Model.FormattingEnabled = True
        Me.Model.Location = New System.Drawing.Point(55, 95)
        Me.Model.Margin = New System.Windows.Forms.Padding(2)
        Me.Model.Name = "Model"
        Me.Model.Size = New System.Drawing.Size(193, 21)
        Me.Model.TabIndex = 7
        '
        'Silnik
        '
        Me.Silnik.FormattingEnabled = True
        Me.Silnik.Location = New System.Drawing.Point(55, 135)
        Me.Silnik.Margin = New System.Windows.Forms.Padding(2)
        Me.Silnik.Name = "Silnik"
        Me.Silnik.Size = New System.Drawing.Size(193, 21)
        Me.Silnik.TabIndex = 8
        '
        'Lakier
        '
        Me.Lakier.FormattingEnabled = True
        Me.Lakier.Location = New System.Drawing.Point(5, 36)
        Me.Lakier.Margin = New System.Windows.Forms.Padding(2)
        Me.Lakier.Name = "Lakier"
        Me.Lakier.Size = New System.Drawing.Size(193, 21)
        Me.Lakier.TabIndex = 9
        '
        'Zatwierdz
        '
        Me.Zatwierdz.Location = New System.Drawing.Point(50, 407)
        Me.Zatwierdz.Margin = New System.Windows.Forms.Padding(2)
        Me.Zatwierdz.Name = "Zatwierdz"
        Me.Zatwierdz.Size = New System.Drawing.Size(92, 23)
        Me.Zatwierdz.TabIndex = 10
        Me.Zatwierdz.Text = "Zatwierdź"
        Me.Zatwierdz.UseVisualStyleBackColor = True
        '
        'Wyczysc
        '
        Me.Wyczysc.Location = New System.Drawing.Point(159, 407)
        Me.Wyczysc.Margin = New System.Windows.Forms.Padding(2)
        Me.Wyczysc.Name = "Wyczysc"
        Me.Wyczysc.Size = New System.Drawing.Size(92, 23)
        Me.Wyczysc.TabIndex = 11
        Me.Wyczysc.Text = "Wyczyść"
        Me.Wyczysc.UseVisualStyleBackColor = True
        '
        'Miniaturka
        '
        Me.Miniaturka.Image = CType(resources.GetObject("Miniaturka.Image"), System.Drawing.Image)
        Me.Miniaturka.Location = New System.Drawing.Point(343, 11)
        Me.Miniaturka.Margin = New System.Windows.Forms.Padding(2)
        Me.Miniaturka.Name = "Miniaturka"
        Me.Miniaturka.Size = New System.Drawing.Size(304, 184)
        Me.Miniaturka.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Miniaturka.TabIndex = 12
        Me.Miniaturka.TabStop = False
        Me.Miniaturka.Visible = False
        '
        'ComboBoxKomis
        '
        Me.ComboBoxKomis.FormattingEnabled = True
        Me.ComboBoxKomis.Items.AddRange(New Object() {"Komis1", "Komis2"})
        Me.ComboBoxKomis.Location = New System.Drawing.Point(55, 15)
        Me.ComboBoxKomis.Name = "ComboBoxKomis"
        Me.ComboBoxKomis.Size = New System.Drawing.Size(193, 21)
        Me.ComboBoxKomis.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Komis"
        '
        'txtStatus
        '
        Me.txtStatus.AutoSize = True
        Me.txtStatus.Location = New System.Drawing.Point(11, 267)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(0, 13)
        Me.txtStatus.TabIndex = 16
        Me.txtStatus.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Lakier)
        Me.GroupBox1.Controls.Add(Me.Klasyczny)
        Me.GroupBox1.Controls.Add(Me.Metalic)
        Me.GroupBox1.Location = New System.Drawing.Point(50, 199)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(201, 67)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lakier"
        '
        'OpcjeTak
        '
        Me.OpcjeTak.AutoSize = True
        Me.OpcjeTak.Location = New System.Drawing.Point(28, 13)
        Me.OpcjeTak.Margin = New System.Windows.Forms.Padding(2)
        Me.OpcjeTak.Name = "OpcjeTak"
        Me.OpcjeTak.Size = New System.Drawing.Size(44, 17)
        Me.OpcjeTak.TabIndex = 18
        Me.OpcjeTak.Text = "Tak"
        Me.OpcjeTak.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.OpcjeBox)
        Me.GroupBox2.Controls.Add(Me.OpcjeTak)
        Me.GroupBox2.Controls.Add(Me.OpcjeNie)
        Me.GroupBox2.Location = New System.Drawing.Point(50, 312)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(201, 67)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Opcje_Dodatkowe"
        '
        'OpcjeBox
        '
        Me.OpcjeBox.FormattingEnabled = True
        Me.OpcjeBox.Location = New System.Drawing.Point(5, 34)
        Me.OpcjeBox.Margin = New System.Windows.Forms.Padding(2)
        Me.OpcjeBox.Name = "OpcjeBox"
        Me.OpcjeBox.Size = New System.Drawing.Size(194, 21)
        Me.OpcjeBox.TabIndex = 19
        Me.OpcjeBox.Visible = False
        '
        'OpcjeNie
        '
        Me.OpcjeNie.AutoSize = True
        Me.OpcjeNie.Checked = True
        Me.OpcjeNie.Location = New System.Drawing.Point(104, 13)
        Me.OpcjeNie.Margin = New System.Windows.Forms.Padding(2)
        Me.OpcjeNie.Name = "OpcjeNie"
        Me.OpcjeNie.Size = New System.Drawing.Size(41, 17)
        Me.OpcjeNie.TabIndex = 21
        Me.OpcjeNie.TabStop = True
        Me.OpcjeNie.Text = "Nie"
        Me.OpcjeNie.UseVisualStyleBackColor = True
        '
        'lblLastRated
        '
        Me.lblLastRated.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblLastRated.Location = New System.Drawing.Point(271, 431)
        Me.lblLastRated.Name = "lblLastRated"
        Me.lblLastRated.Size = New System.Drawing.Size(461, 23)
        Me.lblLastRated.TabIndex = 24
        Me.lblLastRated.Text = "Ostatnio oceniony samochód to Renault Clio z oceną 5"
        Me.lblLastRated.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Gwiazdki1
        '
        Me.Gwiazdki1.Location = New System.Drawing.Point(343, 199)
        Me.Gwiazdki1.Margin = New System.Windows.Forms.Padding(2)
        Me.Gwiazdki1.Name = "Gwiazdki1"
        Me.Gwiazdki1.Size = New System.Drawing.Size(304, 95)
        Me.Gwiazdki1.TabIndex = 25
        Me.Gwiazdki1.Visible = False
        '
        'DataGridViewOceny
        '
        Me.DataGridViewOceny.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewOceny.Location = New System.Drawing.Point(274, 312)
        Me.DataGridViewOceny.Name = "DataGridViewOceny"
        Me.DataGridViewOceny.Size = New System.Drawing.Size(458, 116)
        Me.DataGridViewOceny.TabIndex = 26
        Me.DataGridViewOceny.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(753, 457)
        Me.Controls.Add(Me.DataGridViewOceny)
        Me.Controls.Add(Me.Gwiazdki1)
        Me.Controls.Add(Me.lblLastRated)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtStatus)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ComboBoxKomis)
        Me.Controls.Add(Me.Miniaturka)
        Me.Controls.Add(Me.Wyczysc)
        Me.Controls.Add(Me.Zatwierdz)
        Me.Controls.Add(Me.Silnik)
        Me.Controls.Add(Me.Model)
        Me.Controls.Add(Me.Marka)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Komis Samochodowy"
        CType(Me.Miniaturka, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridViewOceny, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Klasyczny As RadioButton
    Friend WithEvents Metalic As RadioButton
    Friend WithEvents Marka As ComboBox
    Friend WithEvents Model As ComboBox
    Friend WithEvents Silnik As ComboBox
    Friend WithEvents Lakier As ComboBox
    Friend WithEvents Zatwierdz As Button
    Friend WithEvents Wyczysc As Button
    Friend WithEvents Miniaturka As PictureBox
    Friend WithEvents ComboBoxKomis As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtStatus As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents OpcjeTak As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents OpcjeBox As ComboBox
    Friend WithEvents OpcjeNie As RadioButton
    Friend WithEvents lblLastRated As Label
    Friend WithEvents Gwiazdki1 As Gwiazdki.Gwiazdki
    Friend WithEvents DataGridViewOceny As DataGridView
End Class
