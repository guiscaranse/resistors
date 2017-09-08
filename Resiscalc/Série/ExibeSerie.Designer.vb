<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExibeSerie
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ExibeSerie))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.resis11 = New System.Windows.Forms.Label()
        Me.resistEqValueLabel1 = New System.Windows.Forms.Label()
        Me.ResisEq1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.resis22 = New System.Windows.Forms.Label()
        Me.resis21 = New System.Windows.Forms.Label()
        Me.resistEqValueLabel2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(547, 387)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.resis11)
        Me.TabPage1.Controls.Add(Me.resistEqValueLabel1)
        Me.TabPage1.Controls.Add(Me.ResisEq1)
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(539, 361)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'resis11
        '
        Me.resis11.AutoSize = True
        Me.resis11.Location = New System.Drawing.Point(255, 199)
        Me.resis11.Name = "resis11"
        Me.resis11.Size = New System.Drawing.Size(39, 13)
        Me.resis11.TabIndex = 1
        Me.resis11.Text = "Label1"
        Me.resis11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'resistEqValueLabel1
        '
        Me.resistEqValueLabel1.AutoSize = True
        Me.resistEqValueLabel1.Location = New System.Drawing.Point(8, 343)
        Me.resistEqValueLabel1.Name = "resistEqValueLabel1"
        Me.resistEqValueLabel1.Size = New System.Drawing.Size(39, 13)
        Me.resistEqValueLabel1.TabIndex = 3
        Me.resistEqValueLabel1.Text = "Label3"
        '
        'ResisEq1
        '
        Me.ResisEq1.AutoSize = True
        Me.ResisEq1.Location = New System.Drawing.Point(8, 325)
        Me.ResisEq1.Name = "ResisEq1"
        Me.ResisEq1.Size = New System.Drawing.Size(124, 13)
        Me.ResisEq1.TabIndex = 2
        Me.ResisEq1.Text = "Resistência Equivalente:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.resis22)
        Me.TabPage2.Controls.Add(Me.resis21)
        Me.TabPage2.Controls.Add(Me.resistEqValueLabel2)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.PictureBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(539, 361)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'resis22
        '
        Me.resis22.AutoSize = True
        Me.resis22.Location = New System.Drawing.Point(244, 33)
        Me.resis22.Name = "resis22"
        Me.resis22.Size = New System.Drawing.Size(39, 13)
        Me.resis22.TabIndex = 8
        Me.resis22.Text = "Label1"
        Me.resis22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'resis21
        '
        Me.resis21.AutoSize = True
        Me.resis21.Location = New System.Drawing.Point(145, 95)
        Me.resis21.Name = "resis21"
        Me.resis21.Size = New System.Drawing.Size(39, 13)
        Me.resis21.TabIndex = 5
        Me.resis21.Text = "Label1"
        Me.resis21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'resistEqValueLabel2
        '
        Me.resistEqValueLabel2.AutoSize = True
        Me.resistEqValueLabel2.Location = New System.Drawing.Point(8, 340)
        Me.resistEqValueLabel2.Name = "resistEqValueLabel2"
        Me.resistEqValueLabel2.Size = New System.Drawing.Size(39, 13)
        Me.resistEqValueLabel2.TabIndex = 7
        Me.resistEqValueLabel2.Text = "Label3"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 322)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Resistência Equivalente:"
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(539, 361)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(539, 361)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "TabPage4"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(539, 361)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "TabPage5"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(86, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(368, 256)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(49, 21)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(395, 268)
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'ExibeSerie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(547, 387)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ExibeSerie"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Exibição"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents resistEqValueLabel1 As System.Windows.Forms.Label
    Friend WithEvents ResisEq1 As System.Windows.Forms.Label
    Friend WithEvents resis11 As System.Windows.Forms.Label
    Friend WithEvents resis21 As System.Windows.Forms.Label
    Friend WithEvents resistEqValueLabel2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents resis22 As System.Windows.Forms.Label
End Class
