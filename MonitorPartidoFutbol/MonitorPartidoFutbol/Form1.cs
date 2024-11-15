﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonitorPartidoFutbol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Limpiar comboBox y descativar controles de marcador
            comboboxLocal.SelectedItem = null;
            comboBoxVisitante.SelectedItem = null;
            textBoxGolesLocal.Text = "";
            textBoxGolesVisitante.Text = "";
            labelLocal.Text = "Equipo Local";
            labelVisitante.Text = "Equipo Visitante";

            //Deshabilitar los controles del marcador
            textBoxGolesLocal.Enabled = false;
            textBoxGolesVisitante.Enabled = false;
            buttonSumarGolLocal.Enabled = false;
            buttonRestarGolLocal.Enabled = false;
            buttonSumarGolVisitante.Enabled = false;
            buttonRestarGolVisitante.Enabled = false;

        }

        private void Form1_Load(object sender, EventArgs e)

        {
            //Lista de equipos
            string[] equipos = { "Real Madrid", "FC Barcelona", "Atletico de Madrid", "Sevilla FC", "Valencia FC" };

            //Llenar ComboBox con los equipos
            comboboxLocal.Items.AddRange(equipos);
            comboBoxVisitante.Items.AddRange(equipos);

            //Deshabilitar los controles del marcador hasta que se inicie el partido
            textBoxGolesLocal.Enabled = false;
            textBoxGolesVisitante.Enabled = false;
            buttonSumarGolLocal.Enabled = false;
            buttonRestarGolLocal.Enabled = false;
            buttonSumarGolVisitante.Enabled = false;
            buttonRestarGolVisitante.Enabled = false;
        }

        private void buttonIniciar_Click(object sender, EventArgs e)
        {
            if(comboboxLocal.SelectedItem == null || comboBoxVisitante.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione los equipos locales y visitantes.");
                return;
            }

            //Mostrar los nombres de los equipos
            labelLocal.Text = comboboxLocal.SelectedItem.ToString();
            labelVisitante.Text = comboBoxVisitante.SelectedItem.ToString();

            //Iniciar los marcadores en 0
            textBoxGolesLocal.Text = "0";
            textBoxGolesVisitante.Text = "0";


            //Habilitar los controles del marcador
            textBoxGolesLocal.Enabled = true;
            textBoxGolesVisitante.Enabled = true;
            buttonSumarGolLocal.Enabled = true;
            buttonRestarGolLocal.Enabled = true;
            buttonSumarGolVisitante.Enabled = false;
            buttonRestarGolVisitante.Enabled = true;
        }

        private void buttonSumarGolLocal_Click(object sender, EventArgs e)
        {
            int golesLocal = int.Parse(textBoxGolesLocal.Text);
            golesLocal++;
            textBoxGolesLocal.Text = golesLocal.ToString();
        }

        private void buttonRestarGolLocal_Click(object sender, EventArgs e)
        {
            int golesLocal = int.Parse(textBoxGolesLocal.Text);
            if(golesLocal > 0)
            {
                golesLocal--;
            }
            textBoxGolesLocal.Text = textBoxGolesLocal.ToString();
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
            if (golesVisitante > 0)
            {
                golesVisitante--;
            }
            textBoxGolesVisitante.Text = golesVisitante.ToString();
        }

        private void labelVisitante_Click(object sender, EventArgs e)
        {

        }
    }
}
