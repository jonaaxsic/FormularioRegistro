Imports MySql.Data.MySqlClient

Public Class Form1
    Dim connectionString As String = "Server=localhost;Database=registropersonas;User ID='root';Password='';"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        Me.MaximizeBox = False

        ' Cargar comunas en el ComboBox
        cboComuna.Items.Add("Santiago")
        cboComuna.Items.Add("Cerrillos")
        cboComuna.Items.Add("Cerro Navia")
        cboComuna.Items.Add("Conchalí")
        cboComuna.Items.Add("El Bosque")
        cboComuna.Items.Add("Estación Central")
        cboComuna.Items.Add("Huechuraba")
        cboComuna.Items.Add("Independencia")
        cboComuna.Items.Add("La Cisterna")
        cboComuna.Items.Add("La Florida")
        cboComuna.Items.Add("La Granja")
        cboComuna.Items.Add("La Pintana")
        cboComuna.Items.Add("La Reina")
        cboComuna.Items.Add("Las Condes")
        cboComuna.Items.Add("Lo Barnechea")
        cboComuna.Items.Add("Lo Espejo")
        cboComuna.Items.Add("Lo Prado")
        cboComuna.Items.Add("Macul")
        cboComuna.Items.Add("Maipú")
        cboComuna.Items.Add("Ñuñoa")
        cboComuna.Items.Add("Pedro Aguirre Cerda")
        cboComuna.Items.Add("Peñalolén")
        cboComuna.Items.Add("Providencia")
        cboComuna.Items.Add("Pudahuel")
        cboComuna.Items.Add("Quilicura")
        cboComuna.Items.Add("Quinta Normal")
        cboComuna.Items.Add("Recoleta")
        cboComuna.Items.Add("Renca")
        cboComuna.Items.Add("San Joaquín")
        cboComuna.Items.Add("San Miguel")
        cboComuna.Items.Add("San Ramón")
        cboComuna.Items.Add("Vitacura")
        cboComuna.Items.Add("Puente Alto")
        cboComuna.Items.Add("Pirque")
        cboComuna.Items.Add("San José de Maipo")
        cboComuna.Items.Add("Colina")
        cboComuna.Items.Add("Lampa")
        cboComuna.Items.Add("Tiltil")
        cboComuna.Items.Add("San Bernardo")
        cboComuna.Items.Add("Buin")
        cboComuna.Items.Add("Calera de Tango")
        cboComuna.Items.Add("Paine")
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim rut As String = txtRut.Text
        Dim nombre As String = txtNombre.Text
        Dim apellido As String = txtApellido.Text
        Dim sexo As String

        ' Validar la selección del sexo
        If rbtnMasculino.Checked Then
            sexo = "Masculino"
        ElseIf rbtnFemenino.Checked Then
            sexo = "Femenino"
        ElseIf rbtnNoEspecifica.Checked Then
            sexo = "No especifica"
        Else
            MessageBox.Show("Por favor, seleccione el sexo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Obtener otros campos
        Dim comuna As String = If(cboComuna.SelectedItem IsNot Nothing, cboComuna.SelectedItem.ToString(), "")
        Dim ciudad As String = txtCiudad.Text
        Dim observacion As String = txtObservacion.Text

        ' Validar campos obligatorios
        If String.IsNullOrWhiteSpace(rut) Or String.IsNullOrWhiteSpace(nombre) Or String.IsNullOrWhiteSpace(apellido) Or String.IsNullOrWhiteSpace(comuna) Then
            MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Guardar los datos en la base de datos
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()

                Dim sql As String = "INSERT INTO Personas (RUT, Nombre, Apellido, Sexo, Comuna, Ciudad, Observacion) " &
                                    "VALUES (@rut, @nombre, @apellido, @sexo, @comuna, @ciudad, @observacion)"

                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@rut", rut)
                    cmd.Parameters.AddWithValue("@nombre", nombre)
                    cmd.Parameters.AddWithValue("@apellido", apellido)
                    cmd.Parameters.AddWithValue("@sexo", sexo)
                    cmd.Parameters.AddWithValue("@comuna", comuna)
                    cmd.Parameters.AddWithValue("@ciudad", ciudad)
                    cmd.Parameters.AddWithValue("@observacion", observacion)

                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Datos guardados exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Limpiar el formulario después de guardar
                    LimpiarFormulario()
                End Using

            Catch ex As Exception
                MessageBox.Show("Error al guardar los datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim rut As String = txtRut.Text.Trim()
        If String.IsNullOrWhiteSpace(rut) Then
            MessageBox.Show("Por favor, ingrese el RUT a buscar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtRut.Focus()
            Return
        End If

        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Dim sql As String = "SELECT Nombre, Apellido, Sexo, Comuna, Ciudad, Observacion FROM Personas WHERE RUT = @rut"
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@rut", rut)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            txtNombre.Text = reader("Nombre").ToString()
                            txtApellido.Text = reader("Apellido").ToString()
                            txtCiudad.Text = reader("Ciudad").ToString()
                            txtObservacion.Text = reader("Observacion").ToString()
                            cboComuna.SelectedItem = reader("Comuna").ToString()
                            Dim sexo As String = reader("Sexo").ToString()
                            rbtnMasculino.Checked = (sexo = "Masculino")
                            rbtnFemenino.Checked = (sexo = "Femenino")
                            rbtnNoEspecifica.Checked = (sexo = "No especifica")
                        Else
                            MessageBox.Show("RUT no encontrado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            LimpiarFormulario()
                            txtRut.Text = rut
                            txtRut.Focus()
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al buscar el RUT: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' Método para limpiar el formulario
    Private Sub LimpiarFormulario()
        txtRut.Clear()
        txtNombre.Clear()
        txtApellido.Clear()
        txtCiudad.Clear()
        txtObservacion.Clear()
        rbtnMasculino.Checked = False
        rbtnFemenino.Checked = False
        rbtnNoEspecifica.Checked = False
        cboComuna.SelectedIndex = -1
        txtRut.Focus() ' Colocar el foco en el campo RUT
    End Sub
End Class
