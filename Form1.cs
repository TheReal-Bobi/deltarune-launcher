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


namespace Deltarune_Chapter_1_and_2_Launcher
{

    public partial class Form1 : Form
    {
        private const string datafileenglish = "El archivo data.win no existe en la carpeta de la versión original. Por favor, reinstala este programa. /data.win file doesn't exist on the original game's folder. Please reinstall this program.";
        private const string exefileenglish = "El archivo DELTARUNE.exe no existe en la carpeta de la versión original. Por favor, reinstala este programa. /DELTARUNE.exe file doesn't exist on the original game's folder. Please reinstall this program.";
        private const string datafilespanish = "El archivo data.win no existe en la carpeta de la versión original. Por favor, reinstala este programa.";
        private const string exefilespanish = "El archivo DELTARUNE.exe no existe en la carpeta de la versión original. Por favor, reinstala este programa.";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Español_Click(object sender, EventArgs e)
        {
            string rutaeswin = @"C:\Program Files (x86)\Deltarune\es\data.win";
            if (File.Exists(rutaeswin))
            {
                string rutaesexe = @"C:\Program Files (x86)\Deltarune\es\DELTARUNE.exe";
                if (File.Exists(rutaesexe))
                {
                    System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Deltarune\es\DELTARUNE.exe");
                    Application.Exit();
                }
                else
                {
                    {
                        string exeesfilemissing = exefilespanish;
                        MessageBox.Show(exefilespanish);
                        Application.Exit();
                    }
                }
            }
            else
            {
                {
                    string dataesfilemissing = datafilespanish;
                    MessageBox.Show(dataesfilemissing);
                    Application.Exit();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string rutaenwin = @"C:\Program Files (x86)\Deltarune\en\data.win";
            if (File.Exists(rutaenwin))
            {
                string rutaenexe = @"C:\Program Files (x86)\Deltarune\en\DELTARUNE.exe";
                if (File.Exists(rutaenexe))
                {
                    System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Deltarune\en\DELTARUNE.exe");
                    Application.Exit();
                }
                else
                {
                    {
                        string exeenfilemissing = exefileenglish;
                        MessageBox.Show(exefileenglish);
                        Application.Exit();
                    }
                }
            }
            else
            {
                {
                    string dataenfilemissing = datafileenglish;
                    MessageBox.Show(dataenfilemissing);
                    Application.Exit();
                }
            }
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}