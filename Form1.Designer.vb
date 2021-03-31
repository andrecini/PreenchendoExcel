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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtResponsible = New System.Windows.Forms.TextBox()
        Me.txtOperator = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.MaskedTextBox()
        Me.dteDate = New Syncfusion.WinForms.Input.SfDateTimeEdit()
        Me.cmbLocal = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCreateWS = New Syncfusion.WinForms.Controls.SfButton()
        Me.GroupBox1.SuspendLayout
        Me.SuspendLayout
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID da Tabela:"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(12, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Operador:"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(12, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Responsável:"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Location = New System.Drawing.Point(12, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Data de Emissão:"
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Location = New System.Drawing.Point(12, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Local:"
        '
        'txtResponsible
        '
        Me.txtResponsible.Location = New System.Drawing.Point(108, 64)
        Me.txtResponsible.Name = "txtResponsible"
        Me.txtResponsible.Size = New System.Drawing.Size(138, 20)
        Me.txtResponsible.TabIndex = 5
        Me.txtResponsible.Tag = "data"
        Me.txtResponsible.Text = "Ricardo Saat"
        '
        'txtOperator
        '
        Me.txtOperator.Location = New System.Drawing.Point(108, 39)
        Me.txtOperator.Name = "txtOperator"
        Me.txtOperator.Size = New System.Drawing.Size(138, 20)
        Me.txtOperator.TabIndex = 7
        Me.txtOperator.Tag = "data"
        Me.txtOperator.Text = "André Cini"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(108, 15)
        Me.txtID.Mask = "00"
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(24, 20)
        Me.txtID.TabIndex = 8
        Me.txtID.Tag = "data"
        Me.txtID.Text = "00"
        Me.txtID.ValidatingType = GetType(Integer)
        '
        'dteDate
        '
        Me.dteDate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.dteDate.Location = New System.Drawing.Point(108, 90)
        Me.dteDate.Name = "dteDate"
        Me.dteDate.Size = New System.Drawing.Size(100, 19)
        Me.dteDate.TabIndex = 9
        Me.dteDate.Tag = ""
        '
        'cmbLocal
        '
        Me.cmbLocal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLocal.FormattingEnabled = true
        Me.cmbLocal.Items.AddRange(New Object() {"AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"})
        Me.cmbLocal.Location = New System.Drawing.Point(108, 114)
        Me.cmbLocal.Name = "cmbLocal"
        Me.cmbLocal.Size = New System.Drawing.Size(100, 21)
        Me.cmbLocal.TabIndex = 10
        Me.cmbLocal.Tag = "data"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.cmbLocal)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dteDate)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtOperator)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtResponsible)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(265, 150)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "Dados"
        '
        'btnCreateWS
        '
        Me.btnCreateWS.AccessibleName = "Button"
        Me.btnCreateWS.BackColor = System.Drawing.Color.Silver
        Me.btnCreateWS.FocusRectangleVisible = true
        Me.btnCreateWS.Font = New System.Drawing.Font("Segoe UI Semibold", 9!)
        Me.btnCreateWS.ForeColor = System.Drawing.Color.Black
        Me.btnCreateWS.Location = New System.Drawing.Point(181, 168)
        Me.btnCreateWS.Name = "btnCreateWS"
        Me.btnCreateWS.Size = New System.Drawing.Size(96, 28)
        Me.btnCreateWS.Style.BackColor = System.Drawing.Color.Silver
        Me.btnCreateWS.Style.ForeColor = System.Drawing.Color.Black
        Me.btnCreateWS.Style.PressedBackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
        Me.btnCreateWS.TabIndex = 12
        Me.btnCreateWS.Text = "Criar Tabela"
        Me.btnCreateWS.UseVisualStyleBackColor = false
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(287, 206)
        Me.Controls.Add(Me.btnCreateWS)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtResponsible As TextBox
    Friend WithEvents txtOperator As TextBox
    Friend WithEvents txtID As MaskedTextBox
    Friend WithEvents dteDate As Syncfusion.WinForms.Input.SfDateTimeEdit
    Friend WithEvents cmbLocal As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnCreateWS As Syncfusion.WinForms.Controls.SfButton
End Class
