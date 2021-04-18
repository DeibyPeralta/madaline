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

namespace madaline
{
    public partial class Form1 : Form
    {
        //Alamcena la ruta del archivo .txt
        public string archivos = "";        
        char[] dato = new char[10];
        char[] database = new char[10];
        int numero_capas;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_entradas_Click(object sender, EventArgs e)
        {
            cargarArchivo();
        }


        public void cargarArchivo()
        {
            try
            {
                this.openFileDialog1.ShowDialog();

                if (!string.IsNullOrEmpty(this.openFileDialog1.FileName))
                {
                    archivos = this.openFileDialog1.FileName;
                    datos(archivos);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }
        
        public void datos(string archivo)
        {
            StreamReader objReader = new StreamReader(archivo);
            string linea = "";

            while ((linea = objReader.ReadLine()) != null)
            {
               dato = linea.ToCharArray();
            } 
            objReader.Close();

            MessageBox.Show(linea);
                for (int i = 0; i < dato.Length; i++)
                {
                    if (dato[i] != ';')
                    {
                    //MessageBox.Show(Convert.ToString(dato[i]));   
                    listBox1.Items.Add(dato[i]);
                    }
                }
                
            

            MessageBox.Show("entradas cargadas");
        }

        private string[] Split(char caracter)
        {
            throw new NotImplementedException();
        }

        private void txbox_Ncapas_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             numero_capas = int.Parse(txbox_Ncapas.Text);

            for (int i = 1; i <= numero_capas; i++)
            {
                TotalCapas.Items.Add(i);
            }
        }

        private void oculta_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            oculta.Text = "";
        }
    }
}
