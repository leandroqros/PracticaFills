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

namespace PracticaFills
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void bntGenerarCodigo_Click(object sender, EventArgs e)
        {

            char[] vocales = { 'A', 'E', 'I', 'O', 'U' };
            string path = @"C:\Users\leand\source\PRJ04 PACS\Sprint3 - Fils\PracticaFills\PracticaFills\bin\Debug\archivo.txt";

            if (File.Exists(path))
            {
                File.Delete(path);
            }

            for (int y = 0; y < vocales.Length; y++)
            {
                string valor = generarNumAleat();
                using (StreamWriter writer = new StreamWriter(path, true))
                {
                    writer.WriteLine(vocales[y] + ":" + valor);
                }
            }
        }

        private string generarNumAleat()
        {
            string valor;
            int[] numeros = new int[10];
            Random rng = new Random();
            List<int> numerosGenerados = new List<int>();

            for (int i = 0; i < numeros.Length; i++)
            {
                int numeroGenerado;
                do
                {
                    numeroGenerado = rng.Next(0, 10);
                } while (numerosGenerados.Contains(numeroGenerado));

                numeros[i] = numeroGenerado;
                numerosGenerados.Add(numeroGenerado);
            }
            valor = string.Join("",numeros);
            return valor;
        }
    }

}
