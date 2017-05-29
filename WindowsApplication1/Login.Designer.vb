<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm

    Inherits MetroFramework.Forms.MetroForm
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
        Me.UsernameTextB = New MetroFramework.Controls.MetroTextBox()
        Me.PasswordTextB = New MetroFramework.Controls.MetroTextBox()
        Me.LoginButton = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.ShowPassword = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'UsernameTextB
        '
        '
        '
        '
        Me.UsernameTextB.CustomButton.Image = Nothing
        Me.UsernameTextB.CustomButton.Location = New System.Drawing.Point(174, 2)
        Me.UsernameTextB.CustomButton.Name = ""
        Me.UsernameTextB.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.UsernameTextB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.UsernameTextB.CustomButton.TabIndex = 1
        Me.UsernameTextB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.UsernameTextB.CustomButton.UseSelectable = True
        Me.UsernameTextB.CustomButton.Visible = False
        Me.UsernameTextB.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.UsernameTextB.Lines = New String(-1) {}
        Me.UsernameTextB.Location = New System.Drawing.Point(54, 139)
        Me.UsernameTextB.MaxLength = 32767
        Me.UsernameTextB.Name = "UsernameTextB"
        Me.UsernameTextB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UsernameTextB.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.UsernameTextB.SelectedText = ""
        Me.UsernameTextB.SelectionLength = 0
        Me.UsernameTextB.SelectionStart = 0
        Me.UsernameTextB.ShortcutsEnabled = True
        Me.UsernameTextB.Size = New System.Drawing.Size(212, 40)
        Me.UsernameTextB.TabIndex = 0
        Me.UsernameTextB.UseSelectable = True
        Me.UsernameTextB.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.UsernameTextB.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'PasswordTextB
        '
        '
        '
        '
        Me.PasswordTextB.CustomButton.Image = Nothing
        Me.PasswordTextB.CustomButton.Location = New System.Drawing.Point(174, 2)
        Me.PasswordTextB.CustomButton.Name = ""
        Me.PasswordTextB.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.PasswordTextB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.PasswordTextB.CustomButton.TabIndex = 1
        Me.PasswordTextB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.PasswordTextB.CustomButton.UseSelectable = True
        Me.PasswordTextB.CustomButton.Visible = False
        Me.PasswordTextB.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.PasswordTextB.Lines = New String(-1) {}
        Me.PasswordTextB.Location = New System.Drawing.Point(54, 215)
        Me.PasswordTextB.MaxLength = 32767
        Me.PasswordTextB.Name = "PasswordTextB"
        Me.PasswordTextB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PasswordTextB.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.PasswordTextB.SelectedText = ""
        Me.PasswordTextB.SelectionLength = 0
        Me.PasswordTextB.SelectionStart = 0
        Me.PasswordTextB.ShortcutsEnabled = True
        Me.PasswordTextB.Size = New System.Drawing.Size(212, 40)
        Me.PasswordTextB.TabIndex = 1
        Me.PasswordTextB.UseSelectable = True
        Me.PasswordTextB.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.PasswordTextB.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'LoginButton
        '
        Me.LoginButton.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.LoginButton.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.LoginButton.Location = New System.Drawing.Point(54, 305)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(100, 40)
        Me.LoginButton.TabIndex = 2
        Me.LoginButton.Text = "Login"
        Me.LoginButton.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(54, 116)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(78, 19)
        Me.MetroLabel1.TabIndex = 3
        Me.MetroLabel1.Text = "Username *"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(54, 193)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(73, 19)
        Me.MetroLabel2.TabIndex = 4
        Me.MetroLabel2.Text = "Password *"
        '
        'MetroButton1
        '
        Me.MetroButton1.BackColor = System.Drawing.Color.Maroon
        Me.MetroButton1.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.MetroButton1.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.MetroButton1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.MetroButton1.Location = New System.Drawing.Point(166, 306)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(100, 40)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.White
        Me.MetroButton1.TabIndex = 5
        Me.MetroButton1.Text = "Keluar"
        Me.MetroButton1.UseCustomBackColor = True
        Me.MetroButton1.UseCustomForeColor = True
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'MetroButton2
        '
        Me.MetroButton2.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.MetroButton2.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.MetroButton2.Location = New System.Drawing.Point(54, 362)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(212, 40)
        Me.MetroButton2.TabIndex = 6
        Me.MetroButton2.Text = "Lupa Password?"
        Me.MetroButton2.UseSelectable = True
        '
        'ShowPassword
        '
        Me.ShowPassword.AutoSize = True
        Me.ShowPassword.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowPassword.Location = New System.Drawing.Point(54, 261)
        Me.ShowPassword.Name = "ShowPassword"
        Me.ShowPassword.Size = New System.Drawing.Size(107, 17)
        Me.ShowPassword.TabIndex = 7
        Me.ShowPassword.Text = "Show Password"
        Me.ShowPassword.UseVisualStyleBackColor = True
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.logo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BackImage = Global.WindowsApplication1.My.Resources.Resources.logo
        Me.ClientSize = New System.Drawing.Size(325, 461)
        Me.Controls.Add(Me.ShowPassword)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.LoginButton)
        Me.Controls.Add(Me.PasswordTextB)
        Me.Controls.Add(Me.UsernameTextB)
        Me.Name = "LoginForm"
        Me.Style = MetroFramework.MetroColorStyle.Red
        Me.Text = "Login"
        Me.Theme = MetroFramework.MetroThemeStyle.[Default]
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Red
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UsernameTextB As MetroFramework.Controls.MetroTextBox
    Friend WithEvents PasswordTextB As MetroFramework.Controls.MetroTextBox
    Friend WithEvents LoginButton As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents ShowPassword As CheckBox
End Class
