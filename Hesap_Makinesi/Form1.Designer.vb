<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
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

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button0 = New System.Windows.Forms.Button()
        Me.btn_hesapla = New System.Windows.Forms.Button()
        Me.btn_temizle = New System.Windows.Forms.Button()
        Me.btn_arti = New System.Windows.Forms.Button()
        Me.btn_eksi = New System.Windows.Forms.Button()
        Me.btn_carpi = New System.Windows.Forms.Button()
        Me.btn_bolum = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(119, 166)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 78)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(251, 166)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(97, 78)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(383, 166)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(97, 78)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(119, 268)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(97, 78)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(251, 268)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(97, 78)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(383, 268)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(97, 78)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "6"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(119, 371)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(97, 78)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "7"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(251, 371)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(97, 78)
        Me.Button8.TabIndex = 7
        Me.Button8.Text = "8"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(383, 371)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(97, 78)
        Me.Button9.TabIndex = 8
        Me.Button9.Text = "9"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button0
        '
        Me.Button0.Location = New System.Drawing.Point(251, 476)
        Me.Button0.Name = "Button0"
        Me.Button0.Size = New System.Drawing.Size(97, 78)
        Me.Button0.TabIndex = 9
        Me.Button0.Text = "0"
        Me.Button0.UseVisualStyleBackColor = True
        '
        'btn_hesapla
        '
        Me.btn_hesapla.Location = New System.Drawing.Point(383, 476)
        Me.btn_hesapla.Name = "btn_hesapla"
        Me.btn_hesapla.Size = New System.Drawing.Size(97, 78)
        Me.btn_hesapla.TabIndex = 10
        Me.btn_hesapla.Text = "="
        Me.btn_hesapla.UseVisualStyleBackColor = True
        '
        'btn_temizle
        '
        Me.btn_temizle.Location = New System.Drawing.Point(119, 476)
        Me.btn_temizle.Name = "btn_temizle"
        Me.btn_temizle.Size = New System.Drawing.Size(97, 78)
        Me.btn_temizle.TabIndex = 11
        Me.btn_temizle.Text = "Temizle"
        Me.btn_temizle.UseVisualStyleBackColor = True
        '
        'btn_arti
        '
        Me.btn_arti.Location = New System.Drawing.Point(514, 166)
        Me.btn_arti.Name = "btn_arti"
        Me.btn_arti.Size = New System.Drawing.Size(97, 78)
        Me.btn_arti.TabIndex = 12
        Me.btn_arti.Text = "+"
        Me.btn_arti.UseVisualStyleBackColor = True
        '
        'btn_eksi
        '
        Me.btn_eksi.Location = New System.Drawing.Point(514, 268)
        Me.btn_eksi.Name = "btn_eksi"
        Me.btn_eksi.Size = New System.Drawing.Size(97, 78)
        Me.btn_eksi.TabIndex = 13
        Me.btn_eksi.Text = "-"
        Me.btn_eksi.UseVisualStyleBackColor = True
        '
        'btn_carpi
        '
        Me.btn_carpi.Location = New System.Drawing.Point(514, 371)
        Me.btn_carpi.Name = "btn_carpi"
        Me.btn_carpi.Size = New System.Drawing.Size(97, 78)
        Me.btn_carpi.TabIndex = 14
        Me.btn_carpi.Text = "*"
        Me.btn_carpi.UseVisualStyleBackColor = True
        '
        'btn_bolum
        '
        Me.btn_bolum.Location = New System.Drawing.Point(514, 476)
        Me.btn_bolum.Name = "btn_bolum"
        Me.btn_bolum.Size = New System.Drawing.Size(97, 78)
        Me.btn_bolum.TabIndex = 15
        Me.btn_bolum.Text = "/"
        Me.btn_bolum.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(706, 326)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(320, 45)
        Me.TextBox1.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(112, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(270, 42)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "CALCULATOR"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1262, 673)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btn_bolum)
        Me.Controls.Add(Me.btn_carpi)
        Me.Controls.Add(Me.btn_eksi)
        Me.Controls.Add(Me.btn_arti)
        Me.Controls.Add(Me.btn_temizle)
        Me.Controls.Add(Me.btn_hesapla)
        Me.Controls.Add(Me.Button0)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button0 As Button
    Friend WithEvents btn_hesapla As Button
    Friend WithEvents btn_temizle As Button
    Friend WithEvents btn_arti As Button
    Friend WithEvents btn_eksi As Button
    Friend WithEvents btn_carpi As Button
    Friend WithEvents btn_bolum As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
End Class
