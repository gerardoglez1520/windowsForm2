using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Win32;
using MySql.Data.MySqlClient;


namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Indica el fondo oscuro y ejecuta las pruebas y cargas iniciales mediante su respectivo metodos
            this.BackColor =
Color.FromArgb(15, 15, 15);
            ProbarConexion();
            CargarMotores();
        }

        //Verifica que la base de datos hace conexion exitosa con el programa
        //Muestra un mensaje si se conecta y otro si falla la conexion a la Base de Datos en phpadmin
        private void ProbarConexion()
        {
            try
            {
                Conexion conexion = new Conexion();

                using (var conn = conexion.ObtenerConexion())
                {
                    conn.Open();

                    MessageBox.Show(
                        "¡Conexión exitosa con MySQL!",
                        "Apex Motorsport Engines",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error de conexión: " + ex.Message,
                    "Error de MySQL",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Método para consultar la base de datos y refrescar los registros
        // //mostrados en el DataGridView

        private void CargarMotores()
        {
            try
            {
                Conexion conexion = new Conexion();

                using (MySqlConnection conn = conexion.ObtenerConexion())
                {
                    conn.Open();

                    string sql = "SELECT * FROM motores ORDER BY id_motor DESC";

                    using (MySqlDataAdapter adaptador =
                           new MySqlDataAdapter(sql, conn))
                    {
                        DataTable tabla = new DataTable();
                        adaptador.Fill(tabla);

                        dgvMotores.DataSource = tabla;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar motores: " + ex.Message);
            }
        }
        //Lineas de codigo por cada elemento de la interfaz grafica que se uso,
        //como los textbox,label,etc.
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cmbVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtExistencias_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtFabricante_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtTipoMotor_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtPotencia_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }


        //Boton agregar el cual valida campos, comprueba  tipos numéricos y registra un nuevo motor en la base de datos
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Valida que los campos de texto obligatorios y el combobox no estén vacíos
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) ||
    string.IsNullOrWhiteSpace(txtFabricante.Text) ||
    string.IsNullOrWhiteSpace(txtNombre.Text) ||
    string.IsNullOrWhiteSpace(txtTipoMotor.Text) ||
    cmbVehiculo.SelectedIndex == -1)
            {
                MessageBox.Show("Completa los campos obligatorios.");
                return;
            }
            // Valida que las entradas numéricas tengan el formato correcto
            if (!decimal.TryParse(txtCilindrad.Text, out decimal cilindrada) ||
                !int.TryParse(txtPotencia.Text, out int potencia) ||
                !decimal.TryParse(txtPrecio.Text, out decimal precio) ||
                !int.TryParse(txtExistencias.Text, out int existencias))
            {
                MessageBox.Show("Comprueba los valores numéricos.");
                return;
            }
            // Valida que no se ingresen valores negativos

            if (cilindrada < 0 || potencia < 0 ||
                precio < 0 || existencias < 0)
            {
                MessageBox.Show("Los valores no pueden ser negativos.");
                return;
            }

            try
            {
                Conexion conexion = new Conexion();

                using (MySqlConnection conn = conexion.ObtenerConexion())
                {
                    conn.Open();

                    string sql = @"INSERT INTO motores
                (codigo, fabricante, nombre, tipo_motor,
                 cilindrada, potencia_hp, tipo_vehiculo,
                 precio, existencias)
                VALUES
                (@codigo, @fabricante, @nombre, @tipo,
                 @cilindrada, @potencia, @vehiculo,
                 @precio, @existencias)";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        // Asigna los parámetros de forma segura
                        cmd.Parameters.AddWithValue("@codigo", txtCodigo.Text.Trim());
                        cmd.Parameters.AddWithValue("@fabricante", txtFabricante.Text.Trim());
                        cmd.Parameters.AddWithValue("@nombre", txtNombre.Text.Trim());
                        cmd.Parameters.AddWithValue("@tipo", txtTipoMotor.Text.Trim());
                        cmd.Parameters.AddWithValue("@cilindrada", cilindrada);
                        cmd.Parameters.AddWithValue("@potencia", potencia);
                        cmd.Parameters.AddWithValue("@vehiculo", cmbVehiculo.Text);
                        cmd.Parameters.AddWithValue("@precio", precio);
                        cmd.Parameters.AddWithValue("@existencias", existencias);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("¡Motor registrado correctamente!");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al guardar en MySQL: " + ex.Message);
            }
        }

        //Boton modificar
        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Comprueba que haya una fila válida seleccionada en la tabla
            if (dgvMotores.CurrentRow == null ||
    dgvMotores.CurrentRow.Cells["id_motor"].Value == null)
            {
                MessageBox.Show("Selecciona un motor de la tabla.");
                return;
            }
            // Validaciones de campos vacíos, formatos y números negativos (igual que en agregar)
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) ||
                string.IsNullOrWhiteSpace(txtFabricante.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtTipoMotor.Text) ||
                cmbVehiculo.SelectedIndex == -1)
            {
                MessageBox.Show("Completa los campos obligatorios.");
                return;
            }

            if (!decimal.TryParse(txtCilindrad.Text, out decimal cilindrada) ||
                !int.TryParse(txtPotencia.Text, out int potencia) ||
                !decimal.TryParse(txtPrecio.Text, out decimal precio) ||
                !int.TryParse(txtExistencias.Text, out int existencias))
            {
                MessageBox.Show("Comprueba los valores numéricos.");
                return;
            }

            if (cilindrada < 0 || potencia < 0 || precio < 0 || existencias < 0)
            {
                MessageBox.Show("Los valores no pueden ser negativos.");
                return;
            }

            int idMotor = Convert.ToInt32(
                dgvMotores.CurrentRow.Cells["id_motor"].Value);

            try
            {
                Conexion conexion = new Conexion();

                using (MySqlConnection conn = conexion.ObtenerConexion())
                {
                    conn.Open();

                    string sql = @"UPDATE motores SET
            codigo = @codigo,
            fabricante = @fabricante,
            nombre = @nombre,
            tipo_motor = @tipo,
            cilindrada = @cilindrada,
            potencia_hp = @potencia,
            tipo_vehiculo = @vehiculo,
            precio = @precio,
            existencias = @existencias
            WHERE id_motor = @id";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@codigo", txtCodigo.Text.Trim());
                        cmd.Parameters.AddWithValue("@fabricante", txtFabricante.Text.Trim());
                        cmd.Parameters.AddWithValue("@nombre", txtNombre.Text.Trim());
                        cmd.Parameters.AddWithValue("@tipo", txtTipoMotor.Text.Trim());
                        cmd.Parameters.AddWithValue("@cilindrada", cilindrada);
                        cmd.Parameters.AddWithValue("@potencia", potencia);
                        cmd.Parameters.AddWithValue("@vehiculo", cmbVehiculo.Text);
                        cmd.Parameters.AddWithValue("@precio", precio);
                        cmd.Parameters.AddWithValue("@existencias", existencias);
                        cmd.Parameters.AddWithValue("@id", idMotor);

                        int filas = cmd.ExecuteNonQuery();

                        if (filas == 0)
                        {
                            MessageBox.Show("No se modificó ningún registro.");
                            return;
                        }
                    }
                }

                CargarMotores();
                MessageBox.Show("¡Motor modificado correctamente!");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message);
            }
        }

        //Botón Eliminar solicita confirmación SI/NO y borra de la base de datos el registro seleccionado
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvMotores.CurrentRow == null ||
    dgvMotores.CurrentRow.Cells["id_motor"].Value == null)
            {
                MessageBox.Show("Selecciona un motor para eliminar.");
                return;
            }

            int idMotor = Convert.ToInt32(
                dgvMotores.CurrentRow.Cells["id_motor"].Value);

            string nombreMotor = Convert.ToString(
                dgvMotores.CurrentRow.Cells["nombre"].Value);
            //Ventana emergente de confirmacion para evitar eliminacion de informacion por accidente
            DialogResult respuesta = MessageBox.Show(
                "¿Estás seguro de eliminar el motor " + nombreMotor + "?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (respuesta != DialogResult.Yes)
            {
                return;
            }

            try
            {
                Conexion conexion = new Conexion();

                using (MySqlConnection conn = conexion.ObtenerConexion())
                {
                    conn.Open();

                    string sql = "DELETE FROM motores WHERE id_motor = @id";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idMotor);

                        int filas = cmd.ExecuteNonQuery();

                        if (filas == 0)
                        {
                            MessageBox.Show("El motor ya no existe en la base de datos.");
                            CargarMotores();
                            return;
                        }
                    }
                }

                CargarMotores();
                MessageBox.Show("Motor eliminado correctamente.");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }
        //Botón Buscar: filtra los registros en tiempo real 
        //Usa el comando Like que en base de datos es para buscar algo por similitud,
        //en este caso busca en la base datos motores por nombre,fabricante o codigo
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string busqueda = txtCodigo.Text.Trim();

            if (string.IsNullOrWhiteSpace(busqueda))
            {
                MessageBox.Show("Escribe un código, fabricante o nombre para buscar.");
                return;
            }

            try
            {
                Conexion conexion = new Conexion();

                using (MySqlConnection conn = conexion.ObtenerConexion())
                {
                    conn.Open();

                    string sql = @"SELECT * FROM motores
                       WHERE codigo LIKE @busqueda
                       OR fabricante LIKE @busqueda
                       OR nombre LIKE @busqueda
                       ORDER BY id_motor DESC";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@busqueda", "%" + busqueda + "%");

                        using (MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd))
                        {
                            DataTable tabla = new DataTable();
                            adaptador.Fill(tabla);

                            dgvMotores.DataSource = tabla;

                            if (tabla.Rows.Count == 0)
                            {
                                MessageBox.Show("No se encontraron motores.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtFabricante.Clear();
            txtNombre.Clear();
            txtTipoMotor.Clear();
            txtCilindrad.Clear();
            txtPotencia.Clear();
            txtPrecio.Clear();
            txtExistencias.Clear();

            cmbVehiculo.SelectedIndex = -1;

            dgvMotores.ClearSelection();
            dgvMotores.CurrentCell = null;

            txtCodigo.Focus();
        }

        private void dgvMotores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow fila = dgvMotores.Rows[e.RowIndex];

            txtCodigo.Text = Convert.ToString(fila.Cells["codigo"].Value);
            txtFabricante.Text = Convert.ToString(fila.Cells["fabricante"].Value);
            txtNombre.Text = Convert.ToString(fila.Cells["nombre"].Value);
            txtTipoMotor.Text = Convert.ToString(fila.Cells["tipo_motor"].Value);
            txtCilindrad.Text = Convert.ToString(fila.Cells["cilindrada"].Value);
            txtPotencia.Text = Convert.ToString(fila.Cells["potencia_hp"].Value);
            cmbVehiculo.SelectedItem = Convert.ToString(fila.Cells["tipo_vehiculo"].Value);
            txtPrecio.Text = Convert.ToString(fila.Cells["precio"].Value);
            txtExistencias.Text = Convert.ToString(fila.Cells["existencias"].Value);
        }

        //El boton actualizar ayuda a mostrar en el grid los motores agregados pero que aun no aparecen,
        //es decir ,actualiza la informacion para mostrarla
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarMotores();
            MessageBox.Show("Inventario actualizado correctamente.");
        }

        private void pnlHealer1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlRegistro_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pnlRegistro2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void IblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}