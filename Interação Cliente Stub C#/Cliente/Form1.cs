using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace Cliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Arquivo Esboço - Stub
            string fnStub = Path.GetDirectoryName(Application.ExecutablePath) + @"\Stub.exe";
                      
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "arquivo EXE|*.exe";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string fnSaida = sfd.FileName;

                //Copia stub para local selecionado
                File.Copy(fnStub, fnSaida);

                string d = "[D]";
                string saidaDados = "";

                //Todos os dados que serão passados
                string[] dados = new string[] { textBox1.Text };

                foreach (string dado in dados)
                {
                    saidaDados += d + dado;
                }

                //Acrescentar dados
                File.AppendAllText(fnSaida, saidaDados);
            }

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
