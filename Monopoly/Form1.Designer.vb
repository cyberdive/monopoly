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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblDes = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbljoueur1 = New System.Windows.Forms.Label()
        Me.lbljoueur2 = New System.Windows.Forms.Label()
        Me.lblaquiletour = New System.Windows.Forms.Label()
        Me.pctjoueur1 = New System.Windows.Forms.PictureBox()
        Me.pctjoueur2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctjoueur1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctjoueur2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(2, 34)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "Joueur 1"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(2, 60)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.Text = "Joueur2"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(5, 86)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Lancer le dés"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(5, 196)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(90, 17)
        Me.ListBox1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(2, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nom des joueurs"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.ImageLocation = ""
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(256, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(672, 500)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.WaitOnLoad = True
        '
        'lblDes
        '
        Me.lblDes.AutoSize = True
        Me.lblDes.Location = New System.Drawing.Point(5, 114)
        Me.lblDes.Name = "lblDes"
        Me.lblDes.Size = New System.Drawing.Size(39, 13)
        Me.lblDes.TabIndex = 6
        Me.lblDes.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(2, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Nombre de joueurs"
        '
        'lbljoueur1
        '
        Me.lbljoueur1.AutoSize = True
        Me.lbljoueur1.Location = New System.Drawing.Point(109, 40)
        Me.lbljoueur1.Name = "lbljoueur1"
        Me.lbljoueur1.Size = New System.Drawing.Size(39, 13)
        Me.lbljoueur1.TabIndex = 8
        Me.lbljoueur1.Text = "Label2"
        '
        'lbljoueur2
        '
        Me.lbljoueur2.AutoSize = True
        Me.lbljoueur2.Location = New System.Drawing.Point(112, 66)
        Me.lbljoueur2.Name = "lbljoueur2"
        Me.lbljoueur2.Size = New System.Drawing.Size(39, 13)
        Me.lbljoueur2.TabIndex = 9
        Me.lbljoueur2.Text = "Label4"
        '
        'lblaquiletour
        '
        Me.lblaquiletour.AutoSize = True
        Me.lblaquiletour.Location = New System.Drawing.Point(13, 249)
        Me.lblaquiletour.Name = "lblaquiletour"
        Me.lblaquiletour.Size = New System.Drawing.Size(39, 13)
        Me.lblaquiletour.TabIndex = 10
        Me.lblaquiletour.Text = "Label2"
        '
        'pctjoueur1
        '
        Me.pctjoueur1.ImageLocation = "C:\Users\patrick\Documents\Visual Studio 2017\Projects\Monopoly\bateau.jpg"
        Me.pctjoueur1.Location = New System.Drawing.Point(849, 439)
        Me.pctjoueur1.Name = "pctjoueur1"
        Me.pctjoueur1.Size = New System.Drawing.Size(59, 44)
        Me.pctjoueur1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctjoueur1.TabIndex = 11
        Me.pctjoueur1.TabStop = False
        '
        'pctjoueur2
        '
        Me.pctjoueur2.ImageLocation = "C:\Users\patrick\Documents\Visual Studio 2017\Projects\Monopoly\voiture.jpg"
        Me.pctjoueur2.Location = New System.Drawing.Point(849, 440)
        Me.pctjoueur2.Name = "pctjoueur2"
        Me.pctjoueur2.Size = New System.Drawing.Size(59, 43)
        Me.pctjoueur2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctjoueur2.TabIndex = 12
        Me.pctjoueur2.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(112, 299)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(19, 20)
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(16, 143)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(145, 143)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(940, 513)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.pctjoueur2)
        Me.Controls.Add(Me.pctjoueur1)
        Me.Controls.Add(Me.lblaquiletour)
        Me.Controls.Add(Me.lbljoueur2)
        Me.Controls.Add(Me.lbljoueur1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblDes)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.Text = "Monopoly"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctjoueur1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctjoueur2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblDes As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbljoueur1 As Label
    Friend WithEvents lbljoueur2 As Label
    Friend WithEvents lblaquiletour As Label
    Friend WithEvents pctjoueur1 As PictureBox
    Friend WithEvents pctjoueur2 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
