<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnSunrio = New System.Windows.Forms.Button()
        Me.btnDistri = New System.Windows.Forms.Button()
        Me.btnNegocios = New System.Windows.Forms.Button()
        Me.btnQualidy = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSunrio
        '
        Me.btnSunrio.Location = New System.Drawing.Point(40, 143)
        Me.btnSunrio.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnSunrio.Name = "btnSunrio"
        Me.btnSunrio.Size = New System.Drawing.Size(206, 40)
        Me.btnSunrio.TabIndex = 4
        Me.btnSunrio.Text = "Sunrio"
        Me.btnSunrio.UseVisualStyleBackColor = True
        '
        'btnDistri
        '
        Me.btnDistri.Location = New System.Drawing.Point(38, 52)
        Me.btnDistri.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnDistri.Name = "btnDistri"
        Me.btnDistri.Size = New System.Drawing.Size(206, 39)
        Me.btnDistri.TabIndex = 3
        Me.btnDistri.Text = "Scapol Distribuidora"
        Me.btnDistri.UseVisualStyleBackColor = True
        '
        'btnNegocios
        '
        Me.btnNegocios.Location = New System.Drawing.Point(38, 97)
        Me.btnNegocios.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnNegocios.Name = "btnNegocios"
        Me.btnNegocios.Size = New System.Drawing.Size(206, 40)
        Me.btnNegocios.TabIndex = 6
        Me.btnNegocios.Text = "Scapol Negócios"
        Me.btnNegocios.UseVisualStyleBackColor = True
        '
        'btnQualidy
        '
        Me.btnQualidy.Location = New System.Drawing.Point(40, 189)
        Me.btnQualidy.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnQualidy.Name = "btnQualidy"
        Me.btnQualidy.Size = New System.Drawing.Size(206, 39)
        Me.btnQualidy.TabIndex = 5
        Me.btnQualidy.Text = "Qualidy"
        Me.btnQualidy.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 19)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Label1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(40, 234)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(206, 39)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Armazém"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(308, 302)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnNegocios)
        Me.Controls.Add(Me.btnQualidy)
        Me.Controls.Add(Me.btnSunrio)
        Me.Controls.Add(Me.btnDistri)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "Form1"
        Me.Text = "Atualizar DREs - 09/04/2021"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSunrio As Button
    Friend WithEvents btnDistri As Button
    Friend WithEvents btnNegocios As Button
    Friend WithEvents btnQualidy As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
