using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace stub
{
    class main
    {

        static void Main()
        {

            //Auto Leitura
            byte[] byteArr = File.ReadAllBytes(Application.ExecutablePath);
            string textoArquivo = Encoding.UTF8.GetString(byteArr);

            //Secciona o código
            string delimitador = "[D]";
            string[] dados = textoArquivo.Split(new string[] { delimitador }, StringSplitOptions.None);
            
            //MessageBox
            MessageBox.Show(dados[1]);

        }

    }
}
