<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Browser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Browser))
        Me.ControlPanel = New System.Windows.Forms.Panel()
        Me.UrlCb = New System.Windows.Forms.CheckBox()
        Me.ReloadBt = New System.Windows.Forms.Button()
        Me.HomeBt = New System.Windows.Forms.Button()
        Me.SearchTb = New System.Windows.Forms.TextBox()
        Me.GoBt = New System.Windows.Forms.Button()
        Me.ForwordBt = New System.Windows.Forms.Button()
        Me.BackBt = New System.Windows.Forms.Button()
        Me.BrowserPanel = New System.Windows.Forms.Panel()
        Me.WebBrowser = New System.Windows.Forms.WebBrowser()
        Me.ControlPanel.SuspendLayout()
        Me.BrowserPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'ControlPanel
        '
        Me.ControlPanel.Controls.Add(Me.UrlCb)
        Me.ControlPanel.Controls.Add(Me.ReloadBt)
        Me.ControlPanel.Controls.Add(Me.HomeBt)
        Me.ControlPanel.Controls.Add(Me.SearchTb)
        Me.ControlPanel.Controls.Add(Me.GoBt)
        Me.ControlPanel.Controls.Add(Me.ForwordBt)
        Me.ControlPanel.Controls.Add(Me.BackBt)
        Me.ControlPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.ControlPanel.Location = New System.Drawing.Point(0, 0)
        Me.ControlPanel.Name = "ControlPanel"
        Me.ControlPanel.Size = New System.Drawing.Size(1044, 33)
        Me.ControlPanel.TabIndex = 0
        '
        'UrlCb
        '
        Me.UrlCb.AutoSize = True
        Me.UrlCb.BackColor = System.Drawing.Color.Transparent
        Me.UrlCb.Location = New System.Drawing.Point(984, 9)
        Me.UrlCb.Name = "UrlCb"
        Me.UrlCb.Size = New System.Drawing.Size(85, 17)
        Me.UrlCb.TabIndex = 2
        Me.UrlCb.Text = "URL Search"
        Me.UrlCb.UseVisualStyleBackColor = False
        '
        'ReloadBt
        '
        Me.ReloadBt.BackColor = System.Drawing.Color.White
        Me.ReloadBt.BackgroundImage = CType(resources.GetObject("ReloadBt.BackgroundImage"), System.Drawing.Image)
        Me.ReloadBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ReloadBt.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ReloadBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ReloadBt.Location = New System.Drawing.Point(133, 4)
        Me.ReloadBt.Name = "ReloadBt"
        Me.ReloadBt.Size = New System.Drawing.Size(26, 26)
        Me.ReloadBt.TabIndex = 5
        Me.ReloadBt.UseVisualStyleBackColor = False
        '
        'HomeBt
        '
        Me.HomeBt.BackColor = System.Drawing.Color.White
        Me.HomeBt.BackgroundImage = CType(resources.GetObject("HomeBt.BackgroundImage"), System.Drawing.Image)
        Me.HomeBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HomeBt.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.HomeBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HomeBt.Location = New System.Drawing.Point(88, 4)
        Me.HomeBt.Name = "HomeBt"
        Me.HomeBt.Size = New System.Drawing.Size(27, 26)
        Me.HomeBt.TabIndex = 4
        Me.HomeBt.UseVisualStyleBackColor = False
        '
        'SearchTb
        '
        Me.SearchTb.Location = New System.Drawing.Point(165, 7)
        Me.SearchTb.Name = "SearchTb"
        Me.SearchTb.Size = New System.Drawing.Size(777, 20)
        Me.SearchTb.TabIndex = 3
        '
        'GoBt
        '
        Me.GoBt.BackColor = System.Drawing.Color.White
        Me.GoBt.BackgroundImage = CType(resources.GetObject("GoBt.BackgroundImage"), System.Drawing.Image)
        Me.GoBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GoBt.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.GoBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GoBt.Location = New System.Drawing.Point(948, 3)
        Me.GoBt.Name = "GoBt"
        Me.GoBt.Size = New System.Drawing.Size(30, 29)
        Me.GoBt.TabIndex = 2
        Me.GoBt.UseVisualStyleBackColor = False
        '
        'ForwordBt
        '
        Me.ForwordBt.BackColor = System.Drawing.Color.White
        Me.ForwordBt.BackgroundImage = CType(resources.GetObject("ForwordBt.BackgroundImage"), System.Drawing.Image)
        Me.ForwordBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ForwordBt.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ForwordBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ForwordBt.Location = New System.Drawing.Point(45, 4)
        Me.ForwordBt.Name = "ForwordBt"
        Me.ForwordBt.Size = New System.Drawing.Size(27, 26)
        Me.ForwordBt.TabIndex = 1
        Me.ForwordBt.UseVisualStyleBackColor = False
        '
        'BackBt
        '
        Me.BackBt.BackColor = System.Drawing.Color.White
        Me.BackBt.BackgroundImage = CType(resources.GetObject("BackBt.BackgroundImage"), System.Drawing.Image)
        Me.BackBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BackBt.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BackBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackBt.Location = New System.Drawing.Point(12, 4)
        Me.BackBt.Name = "BackBt"
        Me.BackBt.Size = New System.Drawing.Size(27, 26)
        Me.BackBt.TabIndex = 0
        Me.BackBt.UseVisualStyleBackColor = False
        '
        'BrowserPanel
        '
        Me.BrowserPanel.Controls.Add(Me.WebBrowser)
        Me.BrowserPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BrowserPanel.Location = New System.Drawing.Point(0, 33)
        Me.BrowserPanel.Name = "BrowserPanel"
        Me.BrowserPanel.Size = New System.Drawing.Size(1044, 290)
        Me.BrowserPanel.TabIndex = 1
        '
        'WebBrowser
        '
        Me.WebBrowser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser.Name = "WebBrowser"
        Me.WebBrowser.Size = New System.Drawing.Size(1044, 290)
        Me.WebBrowser.TabIndex = 0
        Me.WebBrowser.Url = New System.Uri("https://www.google.com/", System.UriKind.Absolute)
        '
        'Browser
        '
        Me.AcceptButton = Me.GoBt
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1044, 323)
        Me.Controls.Add(Me.BrowserPanel)
        Me.Controls.Add(Me.ControlPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Browser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Web Browser"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ControlPanel.ResumeLayout(False)
        Me.ControlPanel.PerformLayout()
        Me.BrowserPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ControlPanel As Panel
    Friend WithEvents BrowserPanel As Panel
    Friend WithEvents HomeBt As Button
    Friend WithEvents SearchTb As TextBox
    Friend WithEvents GoBt As Button
    Friend WithEvents ForwordBt As Button
    Friend WithEvents BackBt As Button
    Friend WithEvents WebBrowser As WebBrowser
    Friend WithEvents ReloadBt As Button
    Friend WithEvents UrlCb As CheckBox
End Class
