using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor_de_tareas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Tarea> listaTareas = new List<Tarea>();

        private void ActualizarGrid()
        {
            dgvTareas.DataSource = null;
            dgvTareas.DataSource = listaTareas;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Tarea nueva = new Tarea()
            {
                Codigo = txtCodigo.Text,
                Nombre = txtNombre.Text,
                Descripcion = txtDescripcion.Text,
                Fecha = datetpFecha.Value,
                Lugar = txtLugar.Text,
                Estado = cmbEstado.SelectedItem.ToString()
            };

            listaTareas.Add(nueva);
            ActualizarGrid();
            MessageBox.Show("Tarea agregada correctamente.");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvTareas.SelectedRows.Count > 0)
            {
                int index = dgvTareas.SelectedRows[0].Index;
                listaTareas[index].Codigo = txtCodigo.Text;
                listaTareas[index].Nombre = txtNombre.Text;
                listaTareas[index].Descripcion = txtDescripcion.Text;
                listaTareas[index].Fecha = datetpFecha.Value;
                listaTareas[index].Lugar = txtLugar.Text;
                listaTareas[index].Estado = cmbEstado.SelectedItem.ToString();

                ActualizarGrid();
                MessageBox.Show("Tarea editada correctamente.");
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvTareas.SelectedRows.Count > 0)
            {
                int index = dgvTareas.SelectedRows[0].Index;
                listaTareas.RemoveAt(index);
                ActualizarGrid();
                MessageBox.Show("Tarea eliminada correctamente.");
            }
        }
        
        private void dgvTareas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtCodigo.Text = dgvTareas.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNombre.Text = dgvTareas.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDescripcion.Text = dgvTareas.Rows[e.RowIndex].Cells[2].Value.ToString();
                datetpFecha.Value = (DateTime)dgvTareas.Rows[e.RowIndex].Cells[3].Value;
                txtLugar.Text = dgvTareas.Rows[e.RowIndex].Cells[4].Value.ToString();
                cmbEstado.SelectedItem = dgvTareas.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }

        private void btnBuscarCodigo_Click(object sender, EventArgs e)
        {
            string codigo = txtBuscarCodigo.Text.Trim();

            var filtradas = listaTareas
                .Where(t => t.Codigo.Equals(codigo, StringComparison.OrdinalIgnoreCase))
                .ToList();

            dgvTareas.DataSource = null;
            dgvTareas.DataSource = filtradas;

            if (filtradas.Count == 0)
                MessageBox.Show("No se encontraron tareas con ese código.");
        }

        private void btnBuscarEstado_Click(object sender, EventArgs e)
        {
            if (cmbBuscarEstado.SelectedItem != null)
            {
                string estado = cmbBuscarEstado.SelectedItem.ToString();

                var filtradas = listaTareas
                    .Where(t => t.Estado.Equals(estado, StringComparison.OrdinalIgnoreCase))
                    .ToList();

                dgvTareas.DataSource = null;
                dgvTareas.DataSource = filtradas;

                if (filtradas.Count == 0)
                    MessageBox.Show("No se encontraron tareas con ese estado.");
            }
            else
            {
                MessageBox.Show("Seleccione un estado para buscar.");
            }
        }

        private void btnBuscarFecha_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = dtpFechaInicio.Value.Date;
            DateTime fechaFin = dtpFechaFin.Value.Date;

            if (fechaInicio > fechaFin)
            {
                MessageBox.Show("La fecha de inicio no puede ser mayor que la fecha final.");
                return;
            }

            var filtradas = listaTareas
                .Where(t => t.Fecha.Date >= fechaInicio && t.Fecha.Date <= fechaFin)
                .ToList();

            dgvTareas.DataSource = null;
            dgvTareas.DataSource = filtradas;

            if (filtradas.Count == 0)
                MessageBox.Show("No se encontraron tareas en ese rango de fechas.");
        }

        private void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            txtBuscarCodigo.Clear();
            cmbBuscarEstado.SelectedIndex = -1;
            dtpFechaInicio.Value = DateTime.Now;
            dtpFechaFin.Value = DateTime.Now;

            ActualizarGrid();
        }
    }
}
