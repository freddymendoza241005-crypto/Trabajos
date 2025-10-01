using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visor_de_imagenes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string[] archivos;
        private int indiceActual = 0;
        private Image imagenOriginal;
        private bool actualizandoEstado = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(@"C:\IMAGENES");

            if (di.Exists)
            {

                archivos = Directory.GetFiles(di.FullName, "*.jpg");

                comboBoxImagenes.Items.Clear();

                foreach (string archivo in archivos)
                    comboBoxImagenes.Items.Add(Path.GetFileName(archivo));

                if (archivos.Length > 0)
                {
                    indiceActual = 0;
                    MostrarImagen(); // Muestra la primera imagen
                }
            }
        }
        private void MostrarImagen()
        {
            if (archivos.Length == 0) return;

            Image img = Image.FromFile(archivos[indiceActual]);
            imagenOriginal = (Image)img.Clone();

            if (chkEscalaGrises.Checked)
            {
                pictureBox.Image = ConvertirEscalaGrises(new Bitmap(imagenOriginal));
            }
            else
            {
                pictureBox.Image = (Image)imagenOriginal.Clone();
            }

            actualizandoEstado = true;
            comboBoxImagenes.SelectedIndex = indiceActual;
            lblEstado.Text = archivos[indiceActual];
            actualizandoEstado = false;
        }

        private Bitmap ConvertirEscalaGrises(Bitmap original)
        {
            if (original == null)
                return null;


            Bitmap gris = new Bitmap(original.Width, original.Height);

            for (int y = 0; y < original.Height; y++)
            {
                for (int x = 0; x < original.Width; x++)
                {
                    Color pixel = original.GetPixel(x, y);
                    int escala = (int)(pixel.R * 0.3 + pixel.G * 0.59 + pixel.B * 0.11);
                    gris.SetPixel(x, y, Color.FromArgb(escala, escala, escala));
                }
            }

            toolStripButtonEscalaGrises.Checked = true;
            chkEscalaGrises.Checked = true;
            toolStripButtonNormal.Checked = false;
            chkNormal.Checked = false;
            return gris;

        }
        private void btnNegrita_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image != null)
            {
                Bitmap bmp = new Bitmap(pictureBox.Image);
                pictureBox.Image = ConvertirEscalaGrises(bmp);
            }
        }
        private void btnPrimero_Click(object sender, EventArgs e)
        {
            indiceActual = 0;
            MostrarImagen();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (indiceActual > 0) indiceActual--;
            MostrarImagen();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (indiceActual < archivos.Length - 1) indiceActual++;
            MostrarImagen();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            indiceActual = archivos.Length - 1;
            MostrarImagen();
        }

        private void comboBoxImagenes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (actualizandoEstado) return;

            indiceActual = comboBoxImagenes.SelectedIndex;
            MostrarImagen();
        }
        private void rbCentrada_CheckedChanged(object sender, EventArgs e)
        {
            if (actualizandoEstado) return;
            actualizandoEstado = true;

            pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            toolStripButtonCentrada.Checked = true;
            centradaToolStripMenuItem.Checked = true;
            rbCentrada.Checked = true;
            toolStripButtonAjustada.Checked = false;
            toolStripButtonZoom.Checked = false;
            rbAjustar.Checked = false;
            rbZoom.Checked = false;
            ajustadaToolStripMenuItem.Checked = false;
            zoomToolStripMenuItem.Checked = false;

            actualizandoEstado = false;
        }

        private void rbAjustar_CheckedChanged(object sender, EventArgs e)
        {
            if (actualizandoEstado) return;
            actualizandoEstado = true;

            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            rbCentrada.Checked = false;
            rbZoom.Checked = false;
            rbAjustar.Checked = true;
            toolStripButtonAjustada.Checked = true;
            ajustadaToolStripMenuItem.Checked = true;
            toolStripButtonCentrada.Checked = false;
            toolStripButtonZoom.Checked = false;
            centradaToolStripMenuItem.Checked = false;
            zoomToolStripMenuItem.Checked = false;

            actualizandoEstado = false;
        }

        private void rbZoom_CheckedChanged(object sender, EventArgs e)
        {
            if (actualizandoEstado) return;
            actualizandoEstado = true;

            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            rbZoom.Checked = true;
            toolStripButtonZoom.Checked = true;
            zoomToolStripMenuItem.Checked = true;
            toolStripButtonAjustada.Checked = false;
            toolStripButtonCentrada.Checked = false;
            ajustadaToolStripMenuItem.Checked = false;
            centradaToolStripMenuItem.Checked = false;
            rbCentrada.Checked = false;
            rbAjustar.Checked = false;

            actualizandoEstado = false;
        }
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Imagen JPG|*.jpg";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image.Save(sfd.FileName);
            }
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void rotarIzquierdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image != null)
            {
                pictureBox.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                pictureBox.Refresh();
            }
        }

        private void rotarDerechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image != null)
            {
                pictureBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox.Refresh();
            }
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image != null)
                Clipboard.SetImage(pictureBox.Image);
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (archivos.Length > 0)
            {
                pictureBox.Image = Image.FromFile(archivos[indiceActual]);
            }
            chkNormal.Checked = true;
            chkEscalaGrises.Checked = false;
            ActivarEscalaGrises(false);
            toolStripButtonNormal.Checked = true;
            toolStripButtonEscalaGrises.Checked = false;

        }

        private void escalaDeGrisesToolStripMenuItem_Click(object sender, EventArgs e)
        {


            chkEscalaGrises.Checked = true;
            toolStripButtonEscalaGrises.Checked = true;
            ActivarEscalaGrises(true);
            chkNormal.Checked = false;
            toolStripButtonNormal.Checked = false;

        }

        private void chkNormal_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNormal.Checked)
            {
                chkEscalaGrises.Checked = false;
                if (imagenOriginal != null)
                    pictureBox.Image = (Image)imagenOriginal.Clone();
            }
        }

        private void chkEscalaGrises_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEscalaGrises.Checked)
                ActivarEscalaGrises(true);
            else
                ActivarEscalaGrises(false);

        }
        private void toolStripButtonNormal_Click(object sender, EventArgs e)
        {
            if (imagenOriginal != null)
            {
                pictureBox.Image = (Image)imagenOriginal.Clone();
                chkNormal.Checked = true;
                chkEscalaGrises.Checked = false;
            }
        }

        private void toolStripButtonCentrada_Click(object sender, EventArgs e)
        {
            if (actualizandoEstado) return;
            actualizandoEstado = true;

            pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            toolStripButtonCentrada.Checked = true;
            centradaToolStripMenuItem.Checked = true;
            rbCentrada.Checked = true;
            toolStripButtonAjustada.Checked = false;
            toolStripButtonZoom.Checked = false;
            rbAjustar.Checked = false;
            rbZoom.Checked = false;
            ajustadaToolStripMenuItem.Checked = false;
            zoomToolStripMenuItem.Checked = false;

            actualizandoEstado = false;
        }

        private void toolStripButtonAjustada_Click(object sender, EventArgs e)
        {

            if (actualizandoEstado) return;
            actualizandoEstado = true;

            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            rbCentrada.Checked = false;
            rbZoom.Checked = false;
            rbAjustar.Checked = true;
            toolStripButtonAjustada.Checked = true;
            ajustadaToolStripMenuItem.Checked = true;
            toolStripButtonCentrada.Checked = false;
            toolStripButtonZoom.Checked = false;
            centradaToolStripMenuItem.Checked = false;
            zoomToolStripMenuItem.Checked = false;

            actualizandoEstado = false;
        }

        private void toolStripButtonZoom_Click(object sender, EventArgs e)
        {
            if (actualizandoEstado) return;
            actualizandoEstado = true;

            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            rbZoom.Checked = true;
            toolStripButtonZoom.Checked = true;
            zoomToolStripMenuItem.Checked = true;
            toolStripButtonAjustada.Checked = false;
            toolStripButtonCentrada.Checked = false;
            ajustadaToolStripMenuItem.Checked = false;
            centradaToolStripMenuItem.Checked = false;
            rbCentrada.Checked = false;
            rbAjustar.Checked = false;

            actualizandoEstado = false;
        }

        private void ActivarEscalaGrises(bool activar)
        {
            actualizandoEstado = true;
            if (activar)
            {
                if (imagenOriginal != null)
                    pictureBox.Image = ConvertirEscalaGrises(new Bitmap(imagenOriginal));
                chkEscalaGrises.Checked = true;
                chkNormal.Checked = false;
                toolStripButtonEscalaGrises.Checked = true;
                toolStripButtonNormal.Checked = false;
                escalaDeGrisesToolStripMenuItem.Checked = true;
                normalToolStripMenuItem.Checked = false;
            }
            else
            {
                if (imagenOriginal != null)
                    pictureBox.Image = (Image)imagenOriginal.Clone();
                chkEscalaGrises.Checked = false;
                chkNormal.Checked = true;
                toolStripButtonEscalaGrises.Checked = false;
                toolStripButtonNormal.Checked = true;
                escalaDeGrisesToolStripMenuItem.Checked = false;
                normalToolStripMenuItem.Checked = true;
            }
            actualizandoEstado = false;
        }

        private void toolStripButtonEscalaGrises_Click(object sender, EventArgs e)
        {
            this.btnNegrita_Click(sender, e);


        }
    }
}