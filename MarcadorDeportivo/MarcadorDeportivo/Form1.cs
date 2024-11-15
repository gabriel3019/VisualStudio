using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarcadorDeportivo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            segundos = 0;
            timerPartido.Start();
            // Lista de equipos
            string[] equipos = { "Real madrid", "FC Barcelona", "Atletico de madrid", "Sevilla FC", "Valencia FC" };

            //Llenar ComboBox con los equipos
            comboBoxLocal.Items.AddRange(equipos);
            comboBoxVisitante.Items.AddRange(equipos);


            //Deshabilitar los controles del marcador hasta que se inicie el partido
            textBoxGolesLocal.Enabled = false;
            textBoxGolesVisitante.Enabled = false;
            buttonSumarGolLocal.Enabled = false;
            buttonRestarGolLocal.Enabled = false;
            buttonSumarGolVisitante.Enabled = false;
            buttonRestarGolVisitante.Enabled = false;        }

        private void buttonIniciar_Click(object sender, EventArgs e)
        {
            if(comboBoxLocal.SelectedItem == null || comboBoxVisitante.SelectedItem == null)
            {
                MessageBox.Show("Por favor,seleccione los equipos locales y visitantes");
                return;
            }

            //Mostrar los nombres de los equipos
            labelLocal.Text = comboBoxLocal.SelectedItem.ToString();
            labelVisitante.Text = comboBoxVisitante.SelectedItem.ToString();

            //Inicializar los marcadores en 0
            textBoxGolesLocal.Text = "0";
            textBoxGolesVisitante.Text= "0";

            //Habilitar los controles del marcador
            textBoxGolesLocal.Enabled = true;
            textBoxGolesVisitante.Enabled = true;
            buttonSumarGolLocal.Enabled = true;
            buttonRestarGolLocal.Enabled = true;
            buttonSumarGolVisitante.Enabled = true;
            buttonRestarGolVisitante.Enabled = true;
            
        }

        private void buttonSumarGolLocal_Click(object sender, EventArgs e)
        {
            int golesLocal = int.Parse(textBoxGolesLocal.Text);

            golesLocal++;

            textBoxGolesLocal.Text= golesLocal.ToString();
        }

        private void buttonRestarGolLocal_Click(object sender, EventArgs e)
        {
            int golesLocal = int.Parse(textBoxGolesLocal.Text);

            if(golesLocal > 0)
            {
                golesLocal--;
            }
            textBoxGolesLocal.Text = golesLocal.ToString();

        }

        private void buttonSumarGolVisitante_Click(object sender, EventArgs e)
        {
            int golesVisitante = int.Parse(textBoxGolesVisitante.Text);

            golesVisitante++;

            textBoxGolesVisitante.Text = golesVisitante.ToString();
        }

        private void buttonRestarGolVisitante_Click(object sender, EventArgs e)
        {
            int golesVisitante = int.Parse(textBoxGolesVisitante.Text);
            if(golesVisitante > 0)
            {
                golesVisitante--;
            }

            textBoxGolesVisitante.Text= golesVisitante.ToString();
        }

        private void buttonReiniciar_Click(object sender, EventArgs e)
        {
            //Limpiar comBoBox y desactivar controles de marcador
            comboBoxLocal.SelectedItem = null;
            comboBoxVisitante.SelectedItem = null;
            textBoxGolesLocal.Text = "";
            textBoxGolesVisitante.Text = "";
            labelLocal.Text = "Equipo Local";
            labelVisitante.Text = "Equipo visitante";


            //Deshabilitar los controladores del marcador
            textBoxGolesLocal.Enabled = false;
            textBoxGolesVisitante.Enabled = false;
            buttonSumarGolLocal.Enabled = false;
            buttonRestarGolLocal.Enabled = false;
            buttonSumarGolVisitante.Enabled = false;
            buttonRestarGolVisitante.Enabled = false;
        }



        int segundos = 0;
        private void timerPartido_Tick(object sender, EventArgs e)
        {
            //Incrementar el tiempo en segundos
            segundos++;

            //Calcular los minutos y segundos para mostrarlos en el label
            int minutos = segundos / 60;
            int segundosRestantes = segundos % 60;

            //Actualizar el label del cronometro
            lblCronometro.Text = minutos.ToString("00 ") + ":" + segundosRestantes.ToString("00");
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            //Reiniciar el partido y el cronometro y los segundos
            segundos = 0;
            lblCronometro.Text = "00:00";

            //Detener y reiniciar el timer
            timerPartido.Stop();
            timerPartido.Start();

            //Limpiar la lista de goles
            lstGoles.Items.Clear();
        }

        private void btnGolLocal_Click(object sender, EventArgs e)
        {
            string tiempoGol = lblCronometro.Text;
            lstGoles.Items.Add("Gol Local - " + tiempoGol);
        }

        private void btnGolVisitante_Click(object sender, EventArgs e)
        {
            string tiempoGol = lblCronometro.Text;
            lstGoles.Items.Add("Gol visitante - " + tiempoGol);
        }

    }
}
