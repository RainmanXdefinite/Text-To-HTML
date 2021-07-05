<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Formularz przesłania metodę dispose, aby wyczyścić listę składników.
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

    'Wymagane przez Projektanta formularzy systemu Windows
    Private components As System.ComponentModel.IContainer

    'UWAGA: następująca procedura jest wymagana przez Projektanta formularzy systemu Windows
    'Możesz to modyfikować, używając Projektanta formularzy systemu Windows. 
    'Nie należy modyfikować za pomocą edytora kodu.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.rtbStdIn = New System.Windows.Forms.RichTextBox()
        Me.rtbStdOut = New System.Windows.Forms.RichTextBox()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.DocTypeHtml = New System.Windows.Forms.CheckBox()
        Me.Bold = New System.Windows.Forms.Button()
        Me.Italic = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'rtbStdIn
        '
        Me.rtbStdIn.BackColor = System.Drawing.Color.Gray
        Me.rtbStdIn.ForeColor = System.Drawing.Color.White
        Me.rtbStdIn.Location = New System.Drawing.Point(13, 29)
        Me.rtbStdIn.Name = "rtbStdIn"
        Me.rtbStdIn.Size = New System.Drawing.Size(528, 708)
        Me.rtbStdIn.TabIndex = 0
        Me.rtbStdIn.Text = ""
        '
        'rtbStdOut
        '
        Me.rtbStdOut.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.rtbStdOut.ForeColor = System.Drawing.Color.White
        Me.rtbStdOut.Location = New System.Drawing.Point(891, 13)
        Me.rtbStdOut.Name = "rtbStdOut"
        Me.rtbStdOut.ReadOnly = True
        Me.rtbStdOut.Size = New System.Drawing.Size(467, 724)
        Me.rtbStdOut.TabIndex = 1
        Me.rtbStdOut.Text = ""
        '
        'btnConvert
        '
        Me.btnConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConvert.Location = New System.Drawing.Point(657, 20)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(138, 36)
        Me.btnConvert.TabIndex = 2
        Me.btnConvert.Text = "Convert!"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoEllipsis = True
        Me.lblInstructions.Location = New System.Drawing.Point(547, 115)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(338, 341)
        Me.lblInstructions.TabIndex = 3
        Me.lblInstructions.Text = resources.GetString("lblInstructions.Text")
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(14, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(69, 13)
        Me.lblTitle.TabIndex = 4
        Me.lblTitle.Text = "Title of page:"
        '
        'txtTitle
        '
        Me.txtTitle.BackColor = System.Drawing.Color.Gray
        Me.txtTitle.ForeColor = System.Drawing.Color.White
        Me.txtTitle.Location = New System.Drawing.Point(89, 5)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(452, 20)
        Me.txtTitle.TabIndex = 5
        '
        'DocTypeHtml
        '
        Me.DocTypeHtml.AutoSize = True
        Me.DocTypeHtml.Checked = True
        Me.DocTypeHtml.CheckState = System.Windows.Forms.CheckState.Checked
        Me.DocTypeHtml.Location = New System.Drawing.Point(550, 95)
        Me.DocTypeHtml.Name = "DocTypeHtml"
        Me.DocTypeHtml.Size = New System.Drawing.Size(241, 17)
        Me.DocTypeHtml.TabIndex = 6
        Me.DocTypeHtml.Text = "HTML 5 Doctype Declaration (recommended)"
        Me.DocTypeHtml.UseVisualStyleBackColor = True
        '
        'Bold
        '
        Me.Bold.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bold.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Bold.Location = New System.Drawing.Point(550, 66)
        Me.Bold.Name = "Bold"
        Me.Bold.Size = New System.Drawing.Size(44, 23)
        Me.Bold.TabIndex = 7
        Me.Bold.Text = "Bold"
        Me.Bold.UseVisualStyleBackColor = True
        '
        'Italic
        '
        Me.Italic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Italic.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Italic.Location = New System.Drawing.Point(601, 66)
        Me.Italic.Name = "Italic"
        Me.Italic.Size = New System.Drawing.Size(40, 23)
        Me.Italic.TabIndex = 8
        Me.Italic.Text = "Italic"
        Me.Italic.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.Italic)
        Me.Controls.Add(Me.Bold)
        Me.Controls.Add(Me.DocTypeHtml)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.rtbStdOut)
        Me.Controls.Add(Me.rtbStdIn)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "Form1"
        Me.Text = "Text-To-HTML"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rtbStdIn As RichTextBox
    Friend WithEvents rtbStdOut As RichTextBox
    Friend WithEvents btnConvert As Button
    Friend WithEvents lblInstructions As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents DocTypeHtml As CheckBox
    Friend WithEvents Bold As Button
    Friend WithEvents Italic As Button
End Class
