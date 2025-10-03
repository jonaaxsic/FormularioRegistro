<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Label1 = New Label()
        txtRut = New TextBox()
        LabelEjemplo = New Label()
        Label2 = New Label()
        txtNombre = New TextBox()
        Label3 = New Label()
        txtApellido = New TextBox()
        Label4 = New Label()
        GroupBoxSexo = New GroupBox()
        rbtnNoEspecifica = New RadioButton()
        rbtnFemenino = New RadioButton()
        rbtnMasculino = New RadioButton()
        Label5 = New Label()
        cboComuna = New ComboBox()
        Label6 = New Label()
        txtCiudad = New TextBox()
        Label7 = New Label()
        txtObservacion = New TextBox()
        btnGuardar = New Button()
        btnBuscar = New Button()
        GroupBoxSexo.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(26, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(28, 15)
        Label1.TabIndex = 0
        Label1.Text = "Rut:"
        ' 
        ' txtRut
        ' 
        txtRut.Location = New Point(132, 39)
        txtRut.Name = "txtRut"
        txtRut.Size = New Size(120, 23)
        txtRut.TabIndex = 1
        ' 
        ' LabelEjemplo
        ' 
        LabelEjemplo.AutoSize = True
        LabelEjemplo.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelEjemplo.Location = New Point(132, 9)
        LabelEjemplo.Name = "LabelEjemplo"
        LabelEjemplo.Size = New Size(101, 13)
        LabelEjemplo.TabIndex = 2
        LabelEjemplo.Text = "Ejemplo:123456789"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(26, 74)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 15)
        Label2.TabIndex = 3
        Label2.Text = "Nombres:"
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(132, 74)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(234, 23)
        txtNombre.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(26, 109)
        Label3.Name = "Label3"
        Label3.Size = New Size(59, 15)
        Label3.TabIndex = 5
        Label3.Text = "Apellidos:"
        ' 
        ' txtApellido
        ' 
        txtApellido.Location = New Point(132, 109)
        txtApellido.Name = "txtApellido"
        txtApellido.Size = New Size(234, 23)
        txtApellido.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(25, 143)
        Label4.Name = "Label4"
        Label4.Size = New Size(35, 15)
        Label4.TabIndex = 7
        Label4.Text = "Sexo:"
        ' 
        ' GroupBoxSexo
        ' 
        GroupBoxSexo.Controls.Add(rbtnNoEspecifica)
        GroupBoxSexo.Controls.Add(rbtnFemenino)
        GroupBoxSexo.Controls.Add(rbtnMasculino)
        GroupBoxSexo.Location = New Point(20, 161)
        GroupBoxSexo.Name = "GroupBoxSexo"
        GroupBoxSexo.Size = New Size(346, 40)
        GroupBoxSexo.TabIndex = 8
        GroupBoxSexo.TabStop = False
        ' 
        ' rbtnNoEspecifica
        ' 
        rbtnNoEspecifica.AutoSize = True
        rbtnNoEspecifica.Location = New Point(235, 15)
        rbtnNoEspecifica.Name = "rbtnNoEspecifica"
        rbtnNoEspecifica.Size = New Size(96, 19)
        rbtnNoEspecifica.TabIndex = 2
        rbtnNoEspecifica.TabStop = True
        rbtnNoEspecifica.Text = "No especifica"
        rbtnNoEspecifica.UseVisualStyleBackColor = True
        ' 
        ' rbtnFemenino
        ' 
        rbtnFemenino.AutoSize = True
        rbtnFemenino.Location = New Point(122, 15)
        rbtnFemenino.Name = "rbtnFemenino"
        rbtnFemenino.Size = New Size(78, 19)
        rbtnFemenino.TabIndex = 1
        rbtnFemenino.TabStop = True
        rbtnFemenino.Text = "Femenino"
        rbtnFemenino.UseVisualStyleBackColor = True
        ' 
        ' rbtnMasculino
        ' 
        rbtnMasculino.AutoSize = True
        rbtnMasculino.Location = New Point(6, 15)
        rbtnMasculino.Name = "rbtnMasculino"
        rbtnMasculino.Size = New Size(80, 19)
        rbtnMasculino.TabIndex = 0
        rbtnMasculino.TabStop = True
        rbtnMasculino.Text = "Masculino"
        rbtnMasculino.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(25, 225)
        Label5.Name = "Label5"
        Label5.Size = New Size(53, 15)
        Label5.TabIndex = 9
        Label5.Text = "Comuna"
        ' 
        ' cboComuna
        ' 
        cboComuna.DropDownStyle = ComboBoxStyle.DropDownList
        cboComuna.FormattingEnabled = True
        cboComuna.Location = New Point(132, 222)
        cboComuna.Name = "cboComuna"
        cboComuna.Size = New Size(234, 23)
        cboComuna.TabIndex = 10
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(25, 260)
        Label6.Name = "Label6"
        Label6.Size = New Size(45, 15)
        Label6.TabIndex = 11
        Label6.Text = "Ciudad"
        ' 
        ' txtCiudad
        ' 
        txtCiudad.Location = New Point(132, 257)
        txtCiudad.Name = "txtCiudad"
        txtCiudad.Size = New Size(234, 23)
        txtCiudad.TabIndex = 12
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(25, 295)
        Label7.Name = "Label7"
        Label7.Size = New Size(73, 15)
        Label7.TabIndex = 13
        Label7.Text = "Observacion"
        ' 
        ' txtObservacion
        ' 
        txtObservacion.Location = New Point(132, 292)
        txtObservacion.Name = "txtObservacion"
        txtObservacion.Size = New Size(234, 23)
        txtObservacion.TabIndex = 14
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Location = New Point(132, 342)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(155, 30)
        btnGuardar.TabIndex = 15
        btnGuardar.Text = "Guardar MySql"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnBuscar
        ' 
        btnBuscar.Location = New Point(283, 40)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(75, 23)
        btnBuscar.TabIndex = 16
        btnBuscar.Text = "Buscar"
        btnBuscar.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(387, 410)
        Controls.Add(btnBuscar)
        Controls.Add(btnGuardar)
        Controls.Add(txtObservacion)
        Controls.Add(Label7)
        Controls.Add(txtCiudad)
        Controls.Add(Label6)
        Controls.Add(cboComuna)
        Controls.Add(Label5)
        Controls.Add(GroupBoxSexo)
        Controls.Add(Label4)
        Controls.Add(txtApellido)
        Controls.Add(Label3)
        Controls.Add(txtNombre)
        Controls.Add(Label2)
        Controls.Add(LabelEjemplo)
        Controls.Add(txtRut)
        Controls.Add(Label1)
        Margin = New Padding(4, 3, 4, 3)
        Name = "Form1"
        Text = "Formulario Registro"
        GroupBoxSexo.ResumeLayout(False)
        GroupBoxSexo.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtRut As TextBox
    Friend WithEvents LabelEjemplo As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBoxSexo As GroupBox
    Friend WithEvents rbtnNoEspecifica As RadioButton
    Friend WithEvents rbtnFemenino As RadioButton
    Friend WithEvents rbtnMasculino As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents cboComuna As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCiudad As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtObservacion As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnBuscar As Button
End Class
