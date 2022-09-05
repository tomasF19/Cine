using CineFarma.Models.Request;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TMDbLib.Client;
using TMDbLib.Objects.Collections;
using TMDbLib.Objects.General;
using TMDbLib.Objects.Movies;
using TMDbLib.Objects.Search;

namespace CineFarma
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }

        



        private async void Ejecutar_Click(object sender, EventArgs e)
        {

            SearchMovie();           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ComboBox.SelectedIndex = 0;
            
        }
        public async void SearchMovie()
        {
            try
            {
                TMDbClient client = new TMDbClient("06b9b8fba1f05ee09c47920d96f1cf12");
                SearchContainer<SearchMovie> results = client.SearchMovieAsync(txtNombre.Text).Result;              
                if (results.Results.Count==0)
                {
                    MessageBox.Show("No se encontro ninguna pelicula con el nombre ingresado.");
                }
                //MessageBox.Show(($"Se encontraron: {results.Results.Count:N0} of {results.TotalResults:N0} results"));
                foreach (SearchMovie result in results.Results)
                    checkedListBox1.Items.Add(result.Title);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
        }

        private void btnClearListBox_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox.SelectedIndex == 0)
            {
                checkedListBox2.Visible = false;
                checkedListBox1.Visible = true;
                btnVotar.Visible = false;
                btnClearListBox.Visible = true;
                btnClearListBox.Enabled = true;
                btnAgregarPeliculas.Visible = true;
            }
            if (ComboBox.SelectedIndex == 1)
            {
                checkedListBox1.Visible = false;
                checkedListBox2.Visible = true;
                btnVotar.Visible = true;
                //btnClearListBox.Visible= false;
                btnAgregarPeliculas.Visible = false;
                btnClearListBox.Enabled = false;
            }

        }

        private void btnAgregarPeliculas_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {                
                checkedListBox2.Items.Add(checkedListBox1.CheckedItems[i]);
            }
        }

        private void btnVotar_Click(object sender, EventArgs e)
        {
            
            
            for (int i = 0; i < checkedListBox2.CheckedItems.Count; i++)
            {

                var var1 = checkedListBox2.CheckedItems[i];
                
                listboxVotaciones.Items.Add(var1);
         
            }
            

        }

        private void btnResultadoVotacion_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarInfo_Click(object sender, EventArgs e)
        {
            TMDbClient client = new TMDbClient("06b9b8fba1f05ee09c47920d96f1cf12");
            SearchContainer<SearchMovie> results = client.SearchMovieAsync(txtNombre.Text).Result;

            foreach (SearchMovie result in results.Results)
                MessageBox.Show("Id de la pelicula: " + result.Id + "\n"

                                 + "" + "Esta pelicula tuvo una popularidad de: " + result.Popularity + " me gusta");

        }
    }
}

