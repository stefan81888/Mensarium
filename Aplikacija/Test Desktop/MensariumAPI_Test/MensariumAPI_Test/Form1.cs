using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MensariumAPI.Podaci.DTO;

namespace MensariumAPI_Test
{
    public partial class Form1 : Form
    {
        static HttpClient client = new HttpClient();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RunAsync();
            GetProductAsync();
        }

        static async Task RunAsync()
        {
           
            client.BaseAddress = new Uri("http://localhost:2244/");
            client.DefaultRequestHeaders.Accept.Clear();

        }

        static async Task<KorisnikFullDto> GetProductAsync()
        {
            KorisnikFullDto product = null;
            HttpResponseMessage response = await client.GetAsync("http://localhost:2244/api/korisnici/1");
            if (response.IsSuccessStatusCode)
            {
                product = await response.Content.ReadAsAsync<KorisnikFullDto>();
            }
            MessageBox.Show(product.BrojIndeksa + " " + product.BrojTelefona + "\n" + product.Email);
            return product;
        }
    }
}
