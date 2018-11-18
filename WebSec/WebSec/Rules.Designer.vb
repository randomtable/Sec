<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rules
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Rules))
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RichTextBox3 = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RichTextBox4 = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RichTextBox5 = New System.Windows.Forms.RichTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.RichTextBox6 = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 25)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(100, 96)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        Me.RichTextBox1.WordWrap = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Crea file di configurazione:"
        '
        'RichTextBox2
        '
        Me.RichTextBox2.Location = New System.Drawing.Point(152, 25)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(100, 96)
        Me.RichTextBox2.TabIndex = 2
        Me.RichTextBox2.Text = resources.GetString("RichTextBox2.Text")
        Me.RichTextBox2.WordWrap = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(149, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Regole già presenti:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(263, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Regole non presenti:"
        '
        'RichTextBox3
        '
        Me.RichTextBox3.Location = New System.Drawing.Point(258, 25)
        Me.RichTextBox3.Name = "RichTextBox3"
        Me.RichTextBox3.Size = New System.Drawing.Size(100, 96)
        Me.RichTextBox3.TabIndex = 5
        Me.RichTextBox3.Text = resources.GetString("RichTextBox3.Text")
        Me.RichTextBox3.WordWrap = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Presente solo security:"
        '
        'RichTextBox4
        '
        Me.RichTextBox4.Location = New System.Drawing.Point(12, 140)
        Me.RichTextBox4.Name = "RichTextBox4"
        Me.RichTextBox4.Size = New System.Drawing.Size(100, 96)
        Me.RichTextBox4.TabIndex = 7
        Me.RichTextBox4.Text = resources.GetString("RichTextBox4.Text")
        Me.RichTextBox4.WordWrap = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(131, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Presente system.webserver"
        '
        'RichTextBox5
        '
        Me.RichTextBox5.Location = New System.Drawing.Point(152, 140)
        Me.RichTextBox5.Name = "RichTextBox5"
        Me.RichTextBox5.Size = New System.Drawing.Size(100, 96)
        Me.RichTextBox5.TabIndex = 9
        Me.RichTextBox5.Text = resources.GetString("RichTextBox5.Text")
        Me.RichTextBox5.WordWrap = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(273, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(138, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Presente solo configuration:"
        '
        'RichTextBox6
        '
        Me.RichTextBox6.Location = New System.Drawing.Point(258, 140)
        Me.RichTextBox6.Name = "RichTextBox6"
        Me.RichTextBox6.Size = New System.Drawing.Size(100, 96)
        Me.RichTextBox6.TabIndex = 11
        Me.RichTextBox6.Text = resources.GetString("RichTextBox6.Text")
        Me.RichTextBox6.WordWrap = False
        '
        'Rules
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 462)
        Me.Controls.Add(Me.RichTextBox6)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.RichTextBox5)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.RichTextBox4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.RichTextBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RichTextBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Name = "Rules"
        Me.Text = "Rules"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RichTextBox2 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents RichTextBox3 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents RichTextBox4 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents RichTextBox5 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents RichTextBox6 As System.Windows.Forms.RichTextBox
End Class
