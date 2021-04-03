<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Temas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TemasComboBox = New System.Windows.Forms.ComboBox()
        Me.AplicarTemaBTT = New System.Windows.Forms.Button()
        Me.VistaTemasPBox = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SkinEngine1 = New Sunisoft.IrisSkin.SkinEngine(CType(Me, System.ComponentModel.Component))
        CType(Me.VistaTemasPBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TemasComboBox
        '
        Me.TemasComboBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TemasComboBox.FormattingEnabled = True
        Me.TemasComboBox.Items.AddRange(New Object() {"calmness", "calmnesscolor1", "calmnesscolor2", "deepcyan", "deepgreen", "deeporange", "diamondblue", "diamondgreen", "eighteen", "eighteencolor1", "eighteencolor2", "emerald", "emeraldcolor1", "emeraldcolor2", "emeraldcolor3", "glassbrown", "glassgreen", "glassorange", "longhorn", "macos", "midsummer", "midsummercolor1", "midsummercolor2", "midsummercolor3", "mp10", "msn", "office2007", "oneblue", "onecyan", "onegreen", "oneorange", "page", "pagecolor1", "pagecolor2", "realone", "silver", "silvercolor1", "silvercolor2", "sportsblack", "sportsblue", "sportscyan", "sportsgreen", "sportsorange", "steelblack", "steelblue", "vista1", "vista1_green", "vista2_color1", "vista2_color2", "vista2_color3", "vista2_color4", "vista2_color5", "vista2_color6", "vista2_color7", "warm", "warmcolor1", "warmcolor2", "warmcolor3", "wave", "wavecolor1", "wavecolor2", "xpblue", "xpgreen", "xporange", "xpsilver"})
        Me.TemasComboBox.Location = New System.Drawing.Point(43, 482)
        Me.TemasComboBox.Name = "TemasComboBox"
        Me.TemasComboBox.Size = New System.Drawing.Size(196, 23)
        Me.TemasComboBox.TabIndex = 0
        '
        'AplicarTemaBTT
        '
        Me.AplicarTemaBTT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AplicarTemaBTT.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AplicarTemaBTT.Location = New System.Drawing.Point(492, 443)
        Me.AplicarTemaBTT.Name = "AplicarTemaBTT"
        Me.AplicarTemaBTT.Size = New System.Drawing.Size(126, 62)
        Me.AplicarTemaBTT.TabIndex = 1
        Me.AplicarTemaBTT.Text = "Aplicar"
        Me.AplicarTemaBTT.UseVisualStyleBackColor = True
        '
        'VistaTemasPBox
        '
        Me.VistaTemasPBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.VistaTemasPBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.VistaTemasPBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.VistaTemasPBox.Location = New System.Drawing.Point(44, 58)
        Me.VistaTemasPBox.Name = "VistaTemasPBox"
        Me.VistaTemasPBox.Size = New System.Drawing.Size(574, 353)
        Me.VistaTemasPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.VistaTemasPBox.TabIndex = 2
        Me.VistaTemasPBox.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 450)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Elige un tema"
        '
        'SkinEngine1
        '
        Me.SkinEngine1.SerialNumber = ""
        Me.SkinEngine1.SkinFile = Nothing
        '
        'Temas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(676, 557)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.VistaTemasPBox)
        Me.Controls.Add(Me.AplicarTemaBTT)
        Me.Controls.Add(Me.TemasComboBox)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Temas"
        Me.Text = "Temas"
        CType(Me.VistaTemasPBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TemasComboBox As ComboBox
    Friend WithEvents AplicarTemaBTT As Button
    Friend WithEvents VistaTemasPBox As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents SkinEngine1 As Sunisoft.IrisSkin.SkinEngine
End Class
