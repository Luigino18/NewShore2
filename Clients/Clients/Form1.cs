using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Clients
{
    public partial class NewShore : Form
    {

        StreamReader Document = new StreamReader(@"C:\Users\Alejandra\Desktop\REGISTRADOS.txt");
        string Line;
        public NewShore()
        {
            InitializeComponent();
        }
        string cadena, cadena1 = "";
        private void BtnLoad_Click(object sender, EventArgs e)

        {
            try
            {
                Line = Document.ReadLine();
                while (Line != null)
                {
                    RtbClients.AppendText(Line + "\n");
                    Line = Document.ReadLine();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            StreamReader ReadLetters = new StreamReader(@"C:\Users\Alejandra\Desktop\CONTENIDO.txt");
            string Line;
            try
            {
                Line = ReadLetters.ReadLine();
                while (Line != null)
                {
                    RtbLetters.AppendText(Line + "\n");
                    Line = ReadLetters.ReadLine();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void BtnResults_Click(object sender, EventArgs e)
        {
            cadena = RtbClients.Text.Trim();
            string cadena1 = RtbLetters.Text;

            for (int i = 0; i < cadena.Length; i++)
            {
                for (int z = 0; z < cadena1.Length; z++)
                {
                    if (cadena[0].Equals(cadena1[0]))
                    {
                        cadena = Convert.ToString(cadena);
                    }
                    else
                    {
                        string writeText = cadena;
                        File.WriteAllText(@"C:\Users\Alejandra\Desktop\RESULTADOS.txt", writeText);
                    }
                }
            }
        }
    }
}