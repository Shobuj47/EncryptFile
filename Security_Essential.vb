Imports System
Imports System.IO
Imports System.Security
Imports System.Security.Cryptography

Public Class frmMain
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtDestinationEncrypt As System.Windows.Forms.TextBox
    Friend WithEvents txtConPassEncrypt As System.Windows.Forms.TextBox
    Friend WithEvents txtPassEncrypt As System.Windows.Forms.TextBox
    Friend WithEvents txtFileToEncrypt As System.Windows.Forms.TextBox
    Friend WithEvents pbStatus As System.Windows.Forms.ProgressBar
    Friend WithEvents txtDestinationDecrypt As System.Windows.Forms.TextBox
    Friend WithEvents txtConPassDecrypt As System.Windows.Forms.TextBox
    Friend WithEvents txtPassDecrypt As System.Windows.Forms.TextBox
    Friend WithEvents txtFileToDecrypt As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnEncryptFolder As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator27 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator28 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnBrowseDecrypt As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator21 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator22 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnChangeDecrypt As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator23 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator24 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnDecrypt As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator25 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator26 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator12 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator13 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator14 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator15 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator16 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton7 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator17 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator18 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton8 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator19 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator20 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents ToolStrip4 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator29 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator30 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnBrowseEncrypt As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator31 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator32 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnChangeEncrypt As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator33 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator34 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnEncrypt As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator35 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator36 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents FolderBrowserDialog As System.Windows.Forms.FolderBrowserDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ToolStrip4 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator29 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator30 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnBrowseEncrypt = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator31 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator32 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnChangeEncrypt = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator33 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator34 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnEncrypt = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator35 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator36 = New System.Windows.Forms.ToolStripSeparator()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFileToEncrypt = New System.Windows.Forms.TextBox()
        Me.txtDestinationEncrypt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtConPassEncrypt = New System.Windows.Forms.TextBox()
        Me.txtPassEncrypt = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnEncryptFolder = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator27 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator28 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnBrowseDecrypt = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator21 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator22 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnChangeDecrypt = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator23 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator24 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnDecrypt = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator25 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator26 = New System.Windows.Forms.ToolStripSeparator()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtFileToDecrypt = New System.Windows.Forms.TextBox()
        Me.txtDestinationDecrypt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtConPassDecrypt = New System.Windows.Forms.TextBox()
        Me.txtPassDecrypt = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator14 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator15 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator16 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator17 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator18 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton8 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator19 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator20 = New System.Windows.Forms.ToolStripSeparator()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.pbStatus = New System.Windows.Forms.ProgressBar()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.ToolStrip4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.ToolStrip3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(658, 208)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(650, 182)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Encrypt File"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ToolStrip4)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.txtFileToEncrypt)
        Me.GroupBox3.Controls.Add(Me.txtDestinationEncrypt)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txtConPassEncrypt)
        Me.GroupBox3.Controls.Add(Me.txtPassEncrypt)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(288, 178)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Encrypt Single File"
        '
        'ToolStrip4
        '
        Me.ToolStrip4.AutoSize = False
        Me.ToolStrip4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator29, Me.ToolStripSeparator30, Me.btnBrowseEncrypt, Me.ToolStripSeparator31, Me.ToolStripSeparator32, Me.btnChangeEncrypt, Me.ToolStripSeparator33, Me.ToolStripSeparator34, Me.btnEncrypt, Me.ToolStripSeparator35, Me.ToolStripSeparator36})
        Me.ToolStrip4.Location = New System.Drawing.Point(3, 135)
        Me.ToolStrip4.Name = "ToolStrip4"
        Me.ToolStrip4.Size = New System.Drawing.Size(282, 40)
        Me.ToolStrip4.TabIndex = 23
        Me.ToolStrip4.Text = "ToolStrip4"
        '
        'ToolStripSeparator29
        '
        Me.ToolStripSeparator29.Name = "ToolStripSeparator29"
        Me.ToolStripSeparator29.Size = New System.Drawing.Size(6, 40)
        '
        'ToolStripSeparator30
        '
        Me.ToolStripSeparator30.Name = "ToolStripSeparator30"
        Me.ToolStripSeparator30.Size = New System.Drawing.Size(6, 40)
        '
        'btnBrowseEncrypt
        '
        Me.btnBrowseEncrypt.AutoSize = False
        Me.btnBrowseEncrypt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnBrowseEncrypt.Image = Global.EncryptFile.My.Resources.Resources.Add_File
        Me.btnBrowseEncrypt.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBrowseEncrypt.Name = "btnBrowseEncrypt"
        Me.btnBrowseEncrypt.Size = New System.Drawing.Size(45, 32)
        Me.btnBrowseEncrypt.Text = "Add File"
        '
        'ToolStripSeparator31
        '
        Me.ToolStripSeparator31.Name = "ToolStripSeparator31"
        Me.ToolStripSeparator31.Size = New System.Drawing.Size(6, 40)
        '
        'ToolStripSeparator32
        '
        Me.ToolStripSeparator32.Name = "ToolStripSeparator32"
        Me.ToolStripSeparator32.Size = New System.Drawing.Size(6, 40)
        '
        'btnChangeEncrypt
        '
        Me.btnChangeEncrypt.AutoSize = False
        Me.btnChangeEncrypt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnChangeEncrypt.Enabled = False
        Me.btnChangeEncrypt.Image = Global.EncryptFile.My.Resources.Resources.change_folder_icons_2_jpg
        Me.btnChangeEncrypt.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnChangeEncrypt.Name = "btnChangeEncrypt"
        Me.btnChangeEncrypt.Size = New System.Drawing.Size(45, 32)
        Me.btnChangeEncrypt.Text = "Change Destination"
        '
        'ToolStripSeparator33
        '
        Me.ToolStripSeparator33.Name = "ToolStripSeparator33"
        Me.ToolStripSeparator33.Size = New System.Drawing.Size(6, 40)
        '
        'ToolStripSeparator34
        '
        Me.ToolStripSeparator34.Name = "ToolStripSeparator34"
        Me.ToolStripSeparator34.Size = New System.Drawing.Size(6, 40)
        '
        'btnEncrypt
        '
        Me.btnEncrypt.AutoSize = False
        Me.btnEncrypt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnEncrypt.Enabled = False
        Me.btnEncrypt.Image = Global.EncryptFile.My.Resources.Resources.encrypt
        Me.btnEncrypt.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEncrypt.Name = "btnEncrypt"
        Me.btnEncrypt.Size = New System.Drawing.Size(45, 32)
        Me.btnEncrypt.Text = "Encrypt File"
        '
        'ToolStripSeparator35
        '
        Me.ToolStripSeparator35.Name = "ToolStripSeparator35"
        Me.ToolStripSeparator35.Size = New System.Drawing.Size(6, 40)
        '
        'ToolStripSeparator36
        '
        Me.ToolStripSeparator36.Name = "ToolStripSeparator36"
        Me.ToolStripSeparator36.Size = New System.Drawing.Size(6, 40)
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(0, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "File to encrypt:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFileToEncrypt
        '
        Me.txtFileToEncrypt.Location = New System.Drawing.Point(99, 16)
        Me.txtFileToEncrypt.Name = "txtFileToEncrypt"
        Me.txtFileToEncrypt.ReadOnly = True
        Me.txtFileToEncrypt.Size = New System.Drawing.Size(184, 20)
        Me.txtFileToEncrypt.TabIndex = 1
        Me.txtFileToEncrypt.Text = "Click Add file to Add"
        '
        'txtDestinationEncrypt
        '
        Me.txtDestinationEncrypt.Location = New System.Drawing.Point(99, 40)
        Me.txtDestinationEncrypt.Name = "txtDestinationEncrypt"
        Me.txtDestinationEncrypt.ReadOnly = True
        Me.txtDestinationEncrypt.Size = New System.Drawing.Size(184, 20)
        Me.txtDestinationEncrypt.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(-4, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "File destination:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(-3, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Type password:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(-7, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Confirm password:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtConPassEncrypt
        '
        Me.txtConPassEncrypt.Location = New System.Drawing.Point(99, 96)
        Me.txtConPassEncrypt.Name = "txtConPassEncrypt"
        Me.txtConPassEncrypt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConPassEncrypt.Size = New System.Drawing.Size(184, 20)
        Me.txtConPassEncrypt.TabIndex = 7
        '
        'txtPassEncrypt
        '
        Me.txtPassEncrypt.Location = New System.Drawing.Point(99, 66)
        Me.txtPassEncrypt.Name = "txtPassEncrypt"
        Me.txtPassEncrypt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassEncrypt.Size = New System.Drawing.Size(184, 20)
        Me.txtPassEncrypt.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ToolStrip1)
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox1.Location = New System.Drawing.Point(292, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(354, 178)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add Directory to Encrypt All :"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(18, 18)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator7, Me.ToolStripSeparator5, Me.ToolStripButton4, Me.ToolStripSeparator3, Me.ToolStripSeparator2, Me.ToolStripButton3, Me.ToolStripSeparator6, Me.ToolStripSeparator9, Me.ToolStripButton2, Me.ToolStripSeparator1, Me.ToolStripSeparator8, Me.btnEncryptFolder, Me.ToolStripSeparator4, Me.ToolStripSeparator10})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 135)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ToolStrip1.Size = New System.Drawing.Size(348, 40)
        Me.ToolStrip1.Stretch = True
        Me.ToolStrip1.TabIndex = 10
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 40)
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 40)
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.AutoSize = False
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = Global.EncryptFile.My.Resources.Resources.stop_sign_icon_0
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(45, 32)
        Me.ToolStripButton4.Text = "Stop Encryption"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 40)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 40)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.AutoSize = False
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = Global.EncryptFile.My.Resources.Resources.start
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(45, 32)
        Me.ToolStripButton3.Text = "Start Encryption"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 40)
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 40)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.AutoSize = False
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = Global.EncryptFile.My.Resources.Resources.delete_icon
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(45, 32)
        Me.ToolStripButton2.Text = "Remove Items From List"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 40)
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 40)
        '
        'btnEncryptFolder
        '
        Me.btnEncryptFolder.AutoSize = False
        Me.btnEncryptFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnEncryptFolder.Image = Global.EncryptFile.My.Resources.Resources.select_folder
        Me.btnEncryptFolder.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEncryptFolder.Name = "btnEncryptFolder"
        Me.btnEncryptFolder.Size = New System.Drawing.Size(45, 32)
        Me.btnEncryptFolder.Text = "Select Folder"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 40)
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 40)
        '
        'ListBox1
        '
        Me.ListBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.HorizontalScrollbar = True
        Me.ListBox1.Location = New System.Drawing.Point(3, 16)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(348, 95)
        Me.ListBox1.TabIndex = 2
        '
        'TabPage2
        '
        Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(650, 174)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Decrypt File"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.ToolStrip3)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.txtFileToDecrypt)
        Me.GroupBox4.Controls.Add(Me.txtDestinationDecrypt)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.txtConPassDecrypt)
        Me.GroupBox4.Controls.Add(Me.txtPassDecrypt)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox4.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(290, 170)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Decrypt Single File"
        '
        'ToolStrip3
        '
        Me.ToolStrip3.AutoSize = False
        Me.ToolStrip3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator27, Me.ToolStripSeparator28, Me.btnBrowseDecrypt, Me.ToolStripSeparator21, Me.ToolStripSeparator22, Me.btnChangeDecrypt, Me.ToolStripSeparator23, Me.ToolStripSeparator24, Me.btnDecrypt, Me.ToolStripSeparator25, Me.ToolStripSeparator26})
        Me.ToolStrip3.Location = New System.Drawing.Point(3, 127)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(284, 40)
        Me.ToolStrip3.TabIndex = 22
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'ToolStripSeparator27
        '
        Me.ToolStripSeparator27.Name = "ToolStripSeparator27"
        Me.ToolStripSeparator27.Size = New System.Drawing.Size(6, 40)
        '
        'ToolStripSeparator28
        '
        Me.ToolStripSeparator28.Name = "ToolStripSeparator28"
        Me.ToolStripSeparator28.Size = New System.Drawing.Size(6, 40)
        '
        'btnBrowseDecrypt
        '
        Me.btnBrowseDecrypt.AutoSize = False
        Me.btnBrowseDecrypt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnBrowseDecrypt.Image = Global.EncryptFile.My.Resources.Resources.Add_File
        Me.btnBrowseDecrypt.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBrowseDecrypt.Name = "btnBrowseDecrypt"
        Me.btnBrowseDecrypt.Size = New System.Drawing.Size(45, 32)
        Me.btnBrowseDecrypt.Text = "Add File"
        '
        'ToolStripSeparator21
        '
        Me.ToolStripSeparator21.Name = "ToolStripSeparator21"
        Me.ToolStripSeparator21.Size = New System.Drawing.Size(6, 40)
        '
        'ToolStripSeparator22
        '
        Me.ToolStripSeparator22.Name = "ToolStripSeparator22"
        Me.ToolStripSeparator22.Size = New System.Drawing.Size(6, 40)
        '
        'btnChangeDecrypt
        '
        Me.btnChangeDecrypt.AutoSize = False
        Me.btnChangeDecrypt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnChangeDecrypt.Enabled = False
        Me.btnChangeDecrypt.Image = Global.EncryptFile.My.Resources.Resources.change_folder_icons_2_jpg
        Me.btnChangeDecrypt.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnChangeDecrypt.Name = "btnChangeDecrypt"
        Me.btnChangeDecrypt.Size = New System.Drawing.Size(45, 32)
        Me.btnChangeDecrypt.Text = "Change Destination"
        '
        'ToolStripSeparator23
        '
        Me.ToolStripSeparator23.Name = "ToolStripSeparator23"
        Me.ToolStripSeparator23.Size = New System.Drawing.Size(6, 40)
        '
        'ToolStripSeparator24
        '
        Me.ToolStripSeparator24.Name = "ToolStripSeparator24"
        Me.ToolStripSeparator24.Size = New System.Drawing.Size(6, 40)
        '
        'btnDecrypt
        '
        Me.btnDecrypt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnDecrypt.Enabled = False
        Me.btnDecrypt.Image = Global.EncryptFile.My.Resources.Resources.Decrypted
        Me.btnDecrypt.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDecrypt.Name = "btnDecrypt"
        Me.btnDecrypt.Size = New System.Drawing.Size(23, 37)
        Me.btnDecrypt.Text = "Decrypt File"
        '
        'ToolStripSeparator25
        '
        Me.ToolStripSeparator25.Name = "ToolStripSeparator25"
        Me.ToolStripSeparator25.Size = New System.Drawing.Size(6, 40)
        '
        'ToolStripSeparator26
        '
        Me.ToolStripSeparator26.Name = "ToolStripSeparator26"
        Me.ToolStripSeparator26.Size = New System.Drawing.Size(6, 40)
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(2, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 16)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "File to decrypt:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFileToDecrypt
        '
        Me.txtFileToDecrypt.Location = New System.Drawing.Point(102, 16)
        Me.txtFileToDecrypt.Name = "txtFileToDecrypt"
        Me.txtFileToDecrypt.ReadOnly = True
        Me.txtFileToDecrypt.Size = New System.Drawing.Size(184, 20)
        Me.txtFileToDecrypt.TabIndex = 12
        Me.txtFileToDecrypt.Text = "Click Add file to Add"
        '
        'txtDestinationDecrypt
        '
        Me.txtDestinationDecrypt.Location = New System.Drawing.Point(100, 44)
        Me.txtDestinationDecrypt.Name = "txtDestinationDecrypt"
        Me.txtDestinationDecrypt.ReadOnly = True
        Me.txtDestinationDecrypt.Size = New System.Drawing.Size(184, 20)
        Me.txtDestinationDecrypt.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(-3, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 16)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "File destination:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(-2, 74)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 16)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Type password:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(-6, 100)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 16)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Confirm password:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtConPassDecrypt
        '
        Me.txtConPassDecrypt.Location = New System.Drawing.Point(102, 96)
        Me.txtConPassDecrypt.Name = "txtConPassDecrypt"
        Me.txtConPassDecrypt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConPassDecrypt.Size = New System.Drawing.Size(184, 20)
        Me.txtConPassDecrypt.TabIndex = 18
        '
        'txtPassDecrypt
        '
        Me.txtPassDecrypt.Location = New System.Drawing.Point(100, 70)
        Me.txtPassDecrypt.Name = "txtPassDecrypt"
        Me.txtPassDecrypt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassDecrypt.Size = New System.Drawing.Size(184, 20)
        Me.txtPassDecrypt.TabIndex = 17
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ToolStrip2)
        Me.GroupBox2.Controls.Add(Me.ListBox2)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox2.Location = New System.Drawing.Point(292, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(354, 170)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Add Directory to Decrypt All :"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.AutoSize = False
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(18, 18)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator11, Me.ToolStripSeparator12, Me.ToolStripButton5, Me.ToolStripSeparator13, Me.ToolStripSeparator14, Me.ToolStripButton6, Me.ToolStripSeparator15, Me.ToolStripSeparator16, Me.ToolStripButton7, Me.ToolStripSeparator17, Me.ToolStripSeparator18, Me.ToolStripButton8, Me.ToolStripSeparator19, Me.ToolStripSeparator20})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 127)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ToolStrip2.Size = New System.Drawing.Size(348, 40)
        Me.ToolStrip2.Stretch = True
        Me.ToolStrip2.TabIndex = 10
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(6, 40)
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(6, 40)
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.AutoSize = False
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = Global.EncryptFile.My.Resources.Resources.stop_sign_icon_0
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(45, 32)
        Me.ToolStripButton5.Text = "Stop Encryption"
        '
        'ToolStripSeparator13
        '
        Me.ToolStripSeparator13.Name = "ToolStripSeparator13"
        Me.ToolStripSeparator13.Size = New System.Drawing.Size(6, 40)
        '
        'ToolStripSeparator14
        '
        Me.ToolStripSeparator14.Name = "ToolStripSeparator14"
        Me.ToolStripSeparator14.Size = New System.Drawing.Size(6, 40)
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.AutoSize = False
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Image = Global.EncryptFile.My.Resources.Resources.start
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(45, 32)
        Me.ToolStripButton6.Text = "Start Encryption"
        '
        'ToolStripSeparator15
        '
        Me.ToolStripSeparator15.Name = "ToolStripSeparator15"
        Me.ToolStripSeparator15.Size = New System.Drawing.Size(6, 40)
        '
        'ToolStripSeparator16
        '
        Me.ToolStripSeparator16.Name = "ToolStripSeparator16"
        Me.ToolStripSeparator16.Size = New System.Drawing.Size(6, 40)
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.AutoSize = False
        Me.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton7.Image = Global.EncryptFile.My.Resources.Resources.delete_icon
        Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(45, 32)
        Me.ToolStripButton7.Text = "Remove Items From List"
        '
        'ToolStripSeparator17
        '
        Me.ToolStripSeparator17.Name = "ToolStripSeparator17"
        Me.ToolStripSeparator17.Size = New System.Drawing.Size(6, 40)
        '
        'ToolStripSeparator18
        '
        Me.ToolStripSeparator18.Name = "ToolStripSeparator18"
        Me.ToolStripSeparator18.Size = New System.Drawing.Size(6, 40)
        '
        'ToolStripButton8
        '
        Me.ToolStripButton8.AutoSize = False
        Me.ToolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton8.Image = Global.EncryptFile.My.Resources.Resources.select_folder
        Me.ToolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton8.Name = "ToolStripButton8"
        Me.ToolStripButton8.Size = New System.Drawing.Size(45, 32)
        Me.ToolStripButton8.Text = "Select Folder"
        '
        'ToolStripSeparator19
        '
        Me.ToolStripSeparator19.Name = "ToolStripSeparator19"
        Me.ToolStripSeparator19.Size = New System.Drawing.Size(6, 40)
        '
        'ToolStripSeparator20
        '
        Me.ToolStripSeparator20.Name = "ToolStripSeparator20"
        Me.ToolStripSeparator20.Size = New System.Drawing.Size(6, 40)
        '
        'ListBox2
        '
        Me.ListBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.HorizontalScrollbar = True
        Me.ListBox2.Location = New System.Drawing.Point(3, 16)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(348, 95)
        Me.ListBox2.TabIndex = 2
        '
        'pbStatus
        '
        Me.pbStatus.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pbStatus.Location = New System.Drawing.Point(0, 214)
        Me.pbStatus.Name = "pbStatus"
        Me.pbStatus.Size = New System.Drawing.Size(658, 20)
        Me.pbStatus.TabIndex = 1
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'frmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(658, 234)
        Me.Controls.Add(Me.pbStatus)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MinimumSize = New System.Drawing.Size(658, 234)
        Me.Name = "frmMain"
        Me.Text = "Encrypt / Decrypt File (Using Rijndael)"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ToolStrip4.ResumeLayout(False)
        Me.ToolStrip4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
    End Sub

#End Region

#Region "1. Global Variables "

    '*************************
    '** Global Variables
    '*************************

    Dim strFileToEncrypt As String
    Dim strFileToDecrypt As String
    Dim strOutputEncrypt As String
    Dim strOutputDecrypt As String
    Dim fsInput As System.IO.FileStream
    Dim fsOutput As System.IO.FileStream

#End Region

#Region "2. Create A Key "

    '*************************
    '** Create A Key
    '*************************

    Private Function CreateKey(ByVal strPassword As String) As Byte()
        'Convert strPassword to an array and store in chrData.
        Dim chrData() As Char = strPassword.ToCharArray
        'Use intLength to get strPassword size.
        Dim intLength As Integer = chrData.GetUpperBound(0)
        'Declare bytDataToHash and make it the same size as chrData.
        Dim bytDataToHash(intLength) As Byte

        'Use For Next to convert and store chrData into bytDataToHash.
        For i As Integer = 0 To chrData.GetUpperBound(0)
            bytDataToHash(i) = CByte(Asc(chrData(i)))
        Next

        'Declare what hash to use.
        Dim SHA512 As New System.Security.Cryptography.SHA512Managed
        'Declare bytResult, Hash bytDataToHash and store it in bytResult.
        Dim bytResult As Byte() = SHA512.ComputeHash(bytDataToHash)
        'Declare bytKey(31).  It will hold 256 bits.
        Dim bytKey(31) As Byte

        'Use For Next to put a specific size (256 bits) of 
        'bytResult into bytKey. The 0 To 31 will put the first 256 bits
        'of 512 bits into bytKey.
        For i As Integer = 0 To 31
            bytKey(i) = bytResult(i)
        Next

        Return bytKey 'Return the key.
    End Function

#End Region

#Region "3. Create An IV "

    '*************************
    '** Create An IV
    '*************************

    Private Function CreateIV(ByVal strPassword As String) As Byte()
        'Convert strPassword to an array and store in chrData.
        Dim chrData() As Char = strPassword.ToCharArray
        'Use intLength to get strPassword size.
        Dim intLength As Integer = chrData.GetUpperBound(0)
        'Declare bytDataToHash and make it the same size as chrData.
        Dim bytDataToHash(intLength) As Byte

        'Use For Next to convert and store chrData into bytDataToHash.
        For i As Integer = 0 To chrData.GetUpperBound(0)
            bytDataToHash(i) = CByte(Asc(chrData(i)))
        Next

        'Declare what hash to use.
        Dim SHA512 As New System.Security.Cryptography.SHA512Managed
        'Declare bytResult, Hash bytDataToHash and store it in bytResult.
        Dim bytResult As Byte() = SHA512.ComputeHash(bytDataToHash)
        'Declare bytIV(15).  It will hold 128 bits.
        Dim bytIV(15) As Byte

        'Use For Next to put a specific size (128 bits) of 
        'bytResult into bytIV. The 0 To 30 for bytKey used the first 256 bits.
        'of the hashed password. The 32 To 47 will put the next 128 bits into bytIV.
        For i As Integer = 32 To 47
            bytIV(i - 32) = bytResult(i)
        Next

        Return bytIV 'return the IV
    End Function

#End Region

#Region "4. Encrypt / Decrypt File "

    '****************************
    '** Encrypt/Decrypt File
    '****************************

    Private Enum CryptoAction
        'Define the enumeration for CryptoAction.
        ActionEncrypt = 1
        ActionDecrypt = 2
    End Enum

    Private Sub EncryptOrDecryptFile(ByVal strInputFile As String, _
                                     ByVal strOutputFile As String, _
                                     ByVal bytKey() As Byte, _
                                     ByVal bytIV() As Byte, _
                                     ByVal Direction As CryptoAction)
        Try 'In case of errors.

            'Setup file streams to handle input and output.
            fsInput = New System.IO.FileStream(strInputFile, FileMode.Open, _
                                               FileAccess.Read)
            fsOutput = New System.IO.FileStream(strOutputFile, FileMode.OpenOrCreate, _
                                                FileAccess.Write)
            fsOutput.SetLength(0) 'make sure fsOutput is empty

            'Declare variables for encrypt/decrypt process.
            Dim bytBuffer(4096) As Byte 'holds a block of bytes for processing
            Dim lngBytesProcessed As Long = 0 'running count of bytes processed
            Dim lngFileLength As Long = fsInput.Length 'the input file's length
            Dim intBytesInCurrentBlock As Integer 'current bytes being processed
            Dim csCryptoStream As CryptoStream
            'Declare your CryptoServiceProvider.
            Dim cspRijndael As New System.Security.Cryptography.RijndaelManaged
            'Setup Progress Bar
            pbStatus.Value = 0
            pbStatus.Maximum = 100

            'Determine if ecryption or decryption and setup CryptoStream.
            Select Case Direction
                Case CryptoAction.ActionEncrypt
                    csCryptoStream = New CryptoStream(fsOutput, _
                    cspRijndael.CreateEncryptor(bytKey, bytIV), _
                    CryptoStreamMode.Write)

                Case CryptoAction.ActionDecrypt
                    csCryptoStream = New CryptoStream(fsOutput, _
                    cspRijndael.CreateDecryptor(bytKey, bytIV), _
                    CryptoStreamMode.Write)
            End Select

            'Use While to loop until all of the file is processed.
            While lngBytesProcessed < lngFileLength
                'Read file with the input filestream.
                intBytesInCurrentBlock = fsInput.Read(bytBuffer, 0, 4096)
                'Write output file with the cryptostream.
                csCryptoStream.Write(bytBuffer, 0, intBytesInCurrentBlock)
                'Update lngBytesProcessed
                lngBytesProcessed = lngBytesProcessed + CLng(intBytesInCurrentBlock)
                'Update Progress Bar
                pbStatus.Value = CInt((lngBytesProcessed / lngFileLength) * 100)
            End While

            'Close FileStreams and CryptoStream.
            csCryptoStream.Close()
            fsInput.Close()
            fsOutput.Close()

            'If encrypting then delete the original unencrypted file.
            If Direction = CryptoAction.ActionEncrypt Then
                Dim fileOriginal As New FileInfo(strFileToEncrypt)
                fileOriginal.Delete()
            End If

            'If decrypting then delete the encrypted file.
            If Direction = CryptoAction.ActionDecrypt Then
                Dim fileEncrypted As New FileInfo(strFileToDecrypt)
                fileEncrypted.Delete()
            End If

            'Update the user when the file is done.
            Dim Wrap As String = Chr(13) + Chr(10)
            If Direction = CryptoAction.ActionEncrypt Then
                ' MsgBox("Encryption Complete" + Wrap + Wrap + "Total bytes processed = " + lngBytesProcessed.ToString, MsgBoxStyle.Information, "Done")

                'Update the progress bar and textboxes.
                pbStatus.Value = 0
                txtFileToEncrypt.Text = "Click Browse to load file."
                'txtPassEncrypt.Text = ""
                'txtConPassEncrypt.Text = ""
                txtDestinationEncrypt.Text = ""
                btnChangeEncrypt.Enabled = False
                btnEncrypt.Enabled = False

            Else
                'Update the user when the file is done.
                'MsgBox("Decryption Complete" + Wrap + Wrap + "Total bytes processed = " + lngBytesProcessed.ToString, MsgBoxStyle.Information, "Done")

                'Update the progress bar and textboxes.
                pbStatus.Value = 0
                txtFileToDecrypt.Text = "Click Browse to load file."
                'txtPassDecrypt.Text = ""
                'txtConPassDecrypt.Text = ""
                txtDestinationDecrypt.Text = ""
                btnChangeDecrypt.Enabled = False
                btnDecrypt.Enabled = False
            End If


            'Catch file not found error.
        Catch When Err.Number = 53 'if file not found
            MsgBox("Please check to make sure the path and filename" + _
                    "are correct and if the file exists.", _
                     MsgBoxStyle.Exclamation, "Invalid Path or Filename")

            'Catch all other errors. And delete partial files.
        Catch
            fsInput.Close()
            fsOutput.Close()

            If Direction = CryptoAction.ActionDecrypt Then
                Dim fileDelete As New FileInfo(txtDestinationDecrypt.Text)
                fileDelete.Delete()
                pbStatus.Value = 0
                'txtPassDecrypt.Text = ""
                'txtConPassDecrypt.Text = ""

                MsgBox("Please check to make sure that you entered the correct" + _
                        "password.", MsgBoxStyle.Exclamation, "Invalid Password")
            Else
                Dim fileDelete As New FileInfo(txtDestinationEncrypt.Text)
                fileDelete.Delete()

                pbStatus.Value = 0
                'txtPassEncrypt.Text = ""
                'txtConPassEncrypt.Text = ""

                'MsgBox("This file cannot be encrypted.", MsgBoxStyle.Exclamation, "Invalid File")

            End If

        End Try
    End Sub

#End Region


#Region "5. Browse / Change Button "

    '******************************
    '** Browse/Change Buttons
    '******************************

    Private Sub btnBrowseEncrypt_Click()


    End Sub

    Private Sub btnBrowseDecrypt_Click(ByVal sender As System.Object, _
                                       ByVal e As System.EventArgs)


    End Sub

    Private Sub btnChangeEncrypt_Click()


    End Sub

    Private Sub btnChangeDecrypt_Click(ByVal sender As System.Object, _
                                       ByVal e As System.EventArgs)


    End Sub

#End Region


#Region "6. Encrypt / Decrypt Buttons "

    '******************************
    '** Encrypt/Decrypt Buttons
    '******************************

    Private Sub btnDecrypt_Click()


    End Sub

#End Region

    Private Sub frmMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

    Private Sub btnEncryptFolder_Click(sender As Object, e As EventArgs) Handles btnEncryptFolder.Click
        If FolderBrowserDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim selectedFolderPath As String = FolderBrowserDialog.SelectedPath.ToString
            'Dim thefiles() As String
            'thefiles = Directory.GetFiles(selectedFolderPath)
            Me.ListBox1.Items.AddRange(Directory.GetFiles(selectedFolderPath, "*.*", SearchOption.AllDirectories))
            ListBox1.SelectionMode = SelectionMode.MultiExtended
        End If
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        ListBox1.Items.Remove(ListBox1.SelectedItems)
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Timer1.Start()
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        Timer1.Stop()
    End Sub

    Private Sub ToolStripButton14_Click(ByVal sender As System.Object, _
                                 ByVal e As System.EventArgs) Handles btnEncrypt.Click
        'Make sure the password is correct.
        If txtConPassEncrypt.Text = txtPassEncrypt.Text Then
            'Declare variables for the key and iv.
            'The key needs to hold 256 bits and the iv 128 bits.
            Dim bytKey As Byte()
            Dim bytIV As Byte()
            'Send the password to the CreateKey function.
            bytKey = CreateKey(txtPassEncrypt.Text)
            'Send the password to the CreateIV function.
            bytIV = CreateIV(txtPassEncrypt.Text)
            'Start the encryption.
            EncryptOrDecryptFile(strFileToEncrypt, txtDestinationEncrypt.Text, _
                                 bytKey, bytIV, CryptoAction.ActionEncrypt)
        Else
            MsgBox("Please re-enter your password.", MsgBoxStyle.Exclamation)
            'txtPassEncrypt.Text = ""
            'txtConPassEncrypt.Text = ""
        End If
    End Sub

    Private Sub ToolStripButton13_Click(ByVal sender As System.Object, _
                                       ByVal e As System.EventArgs) Handles btnChangeEncrypt.Click
        'Setup up folder browser.
        FolderBrowserDialog.Description = "Select a folder to place the encrypted file in."
        'If the user selected a folder assign the path to txtDestinationEncrypt.
        If FolderBrowserDialog.ShowDialog = DialogResult.OK Then
            txtDestinationEncrypt.Text = FolderBrowserDialog.SelectedPath + _
                                         "\" + strOutputEncrypt + ".encrypt"
        End If
    End Sub

    Private Sub ToolStripButton12_Click(ByVal sender As System.Object, _
                                       ByVal e As System.EventArgs) Handles btnBrowseEncrypt.Click
        'Setup the open dialog.
        OpenFileDialog.FileName = ""
        OpenFileDialog.Title = "Choose a file to encrypt"
        OpenFileDialog.InitialDirectory = "C:\"
        OpenFileDialog.Filter = "All Files (*.*) | *.*"

        'Find out if the user chose a file.
        If OpenFileDialog.ShowDialog = DialogResult.OK Then
            strFileToEncrypt = OpenFileDialog.FileName
            txtFileToEncrypt.Text = strFileToEncrypt

            Dim iPosition As Integer = 0
            Dim i As Integer = 0

            'Get the position of the last "\" in the OpenFileDialog.FileName path.
            '-1 is when the character your searching for is not there.
            'IndexOf searches from left to right.
            While strFileToEncrypt.IndexOf("\"c, i) <> -1
                iPosition = strFileToEncrypt.IndexOf("\"c, i)
                i = iPosition + 1
            End While

            'Assign strOutputFile to the position after the last "\" in the path.
            'This position is the beginning of the file name.
            strOutputEncrypt = strFileToEncrypt.Substring(iPosition + 1)
            'Assign S the entire path, ending at the last "\".
            Dim S As String = strFileToEncrypt.Substring(0, iPosition + 1)
            'Replace the "." in the file extension with "_".
            strOutputEncrypt = strOutputEncrypt.Replace("."c, "_"c)
            'The final file name.  XXXXX.encrypt
            txtDestinationEncrypt.Text = S + strOutputEncrypt + ".encrypt"
            'Update buttons.
            btnEncrypt.Enabled = True
            btnChangeEncrypt.Enabled = True

        End If

    End Sub

    Private Sub ToolStripButton9_Click(sender As Object, e As EventArgs) Handles btnBrowseDecrypt.Click
        'Setup the open dialog.
        OpenFileDialog.FileName = ""
        OpenFileDialog.Title = "Choose a file to decrypt"
        OpenFileDialog.InitialDirectory = "C:\"
        OpenFileDialog.Filter = "Encrypted Files (*.encrypt) | *.encrypt"

        'Find out if the user chose a file.
        If OpenFileDialog.ShowDialog = DialogResult.OK Then
            strFileToDecrypt = OpenFileDialog.FileName
            txtFileToDecrypt.Text = strFileToDecrypt
            Dim iPosition As Integer = 0
            Dim i As Integer = 0
            'Get the position of the last "\" in the OpenFileDialog.FileName path.
            '-1 is when the character your searching for is not there.
            'IndexOf searches from left to right.

            While strFileToDecrypt.IndexOf("\"c, i) <> -1
                iPosition = strFileToDecrypt.IndexOf("\"c, i)
                i = iPosition + 1
            End While

            'strOutputFile = the file path minus the last 8 characters (.encrypt)
            strOutputDecrypt = strFileToDecrypt.Substring(0, strFileToDecrypt.Length - 8)
            'Assign S the entire path, ending at the last "\".
            Dim S As String = strFileToDecrypt.Substring(0, iPosition + 1)
            'Assign strOutputFile to the position after the last "\" in the path.
            strOutputDecrypt = strOutputDecrypt.Substring((iPosition + 1))
            'Replace "_" with "."
            txtDestinationDecrypt.Text = S + strOutputDecrypt.Replace("_"c, "."c)
            'Update buttons
            btnDecrypt.Enabled = True
            btnChangeDecrypt.Enabled = True

        End If
    End Sub

    Private Sub ToolStripButton10_Click(sender As Object, e As EventArgs) Handles btnChangeDecrypt.Click
        'Setup up folder browser.
        FolderBrowserDialog.Description = "Select a folder for to place the decrypted file in."
        'If the user selected a folder assign the path to txtDestinationDecrypt.
        If FolderBrowserDialog.ShowDialog = DialogResult.OK Then
            txtDestinationDecrypt.Text = FolderBrowserDialog.SelectedPath + _
                                         "\" + strOutputDecrypt.Replace("_"c, "."c)
        End If
    End Sub

    Private Sub ToolStripButton11_Click(ByVal sender As System.Object, _
                                 ByVal e As System.EventArgs) Handles btnDecrypt.Click
        'Make sure the password is correct.
        If txtConPassDecrypt.Text = txtPassDecrypt.Text Then
            'Declare variables for the key and iv.
            'The key needs to hold 256 bits and the iv 128 bits.
            Dim bytKey As Byte()
            Dim bytIV As Byte()
            'Send the password to the CreateKey function.
            bytKey = CreateKey(txtPassDecrypt.Text)
            'Send the password to the CreateIV function.
            bytIV = CreateIV(txtPassDecrypt.Text)
            'Start the decryption.
            EncryptOrDecryptFile(strFileToDecrypt, txtDestinationDecrypt.Text, bytKey, bytIV, CryptoAction.ActionDecrypt)
        Else
            MsgBox("Please re-enter your password.", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub ToolStripButton8_Click(sender As Object, e As EventArgs) Handles ToolStripButton8.Click
        If FolderBrowserDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim selectedFolderPath As String = FolderBrowserDialog.SelectedPath.ToString
            Me.ListBox2.Items.AddRange(Directory.GetFiles(selectedFolderPath, "*.encrypt", SearchOption.AllDirectories))
            ListBox2.SelectionMode = SelectionMode.MultiExtended
        End If
    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        ListBox1.Items.Remove(ListBox1.SelectedItems)
    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        Try

            If (Timer1.Enabled) Then
                Timer1.Stop()
            End If
            Timer2.Start()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            If ListBox1.Items.Count > 0 Then


                'txtPassEncrypt.Text = "Kingbob1234"
                'txtConPassEncrypt.Text = "Kingbob1234"
                strFileToEncrypt = ListBox1.Items(0).ToString
                txtFileToEncrypt.Text = strFileToEncrypt

                Dim iPosition As Integer = 0
                Dim i As Integer = 0

                'Get the position of the last "\" in the OpenFileDialog.FileName path.
                '-1 is when the character your searching for is not there.
                'IndexOf searches from left to right.
                While strFileToEncrypt.IndexOf("\"c, i) <> -1
                    iPosition = strFileToEncrypt.IndexOf("\"c, i)
                    i = iPosition + 1
                End While

                'Assign strOutputFile to the position after the last "\" in the path.
                'This position is the beginning of the file name.
                strOutputEncrypt = strFileToEncrypt.Substring(iPosition + 1)
                'Assign S the entire path, ending at the last "\".
                Dim S As String = strFileToEncrypt.Substring(0, iPosition + 1)
                'Replace the "." in the file extension with "_".
                strOutputEncrypt = strOutputEncrypt.Replace("."c, "_"c)
                'The final file name.  XXXXX.encrypt
                txtDestinationEncrypt.Text = S + strOutputEncrypt + ".encrypt"
                'Update buttons.

                btnEncrypt.Enabled = True
                btnChangeEncrypt.Enabled = True
                btnEncrypt.PerformClick()
                'Empty Parametars
                ListBox1.Items.RemoveAt(0)
            End If
        Catch ex As Exception
            Timer1.Stop()
            MsgBox(ErrorToString)
        End Try
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Try
            If ListBox2.Items.Count > 0 Then

                strFileToDecrypt = ListBox2.Items(0).ToString
                txtFileToDecrypt.Text = strFileToDecrypt

                Dim iPosition As Integer = 0
                Dim i As Integer = 0
                'Get the position of the last "\" in the OpenFileDialog.FileName path.
                '-1 is when the character your searching for is not there.
                'IndexOf searches from left to right.

                While strFileToDecrypt.IndexOf("\"c, i) <> -1
                    iPosition = strFileToDecrypt.IndexOf("\"c, i)
                    i = iPosition + 1
                End While

                'strOutputFile = the file path minus the last 8 characters (.encrypt)
                strOutputDecrypt = strFileToDecrypt.Substring(0, strFileToDecrypt.Length - 8)
                'Assign S the entire path, ending at the last "\".
                Dim S As String = strFileToDecrypt.Substring(0, iPosition + 1)
                'Assign strOutputFile to the position after the last "\" in the path.
                strOutputDecrypt = strOutputDecrypt.Substring((iPosition + 1))
                'Replace "_" with "."
                txtDestinationDecrypt.Text = S + strOutputDecrypt.Replace("_"c, "."c)
                'Update buttons
                btnDecrypt.Enabled = True
                btnChangeDecrypt.Enabled = True

                btnDecrypt.Enabled = True
                btnChangeDecrypt.Enabled = True
                ListBox2.Items.RemoveAt(0)
                btnDecrypt.PerformClick()
            Else
                'MsgBox("Check your password!")
            End If

        Catch ex As Exception
            Timer2.Stop()
            MsgBox(ErrorToString)
        End Try
    End Sub

End Class
