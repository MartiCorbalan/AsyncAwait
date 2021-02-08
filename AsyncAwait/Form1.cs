using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncAwait
{
    public partial class Form1 : Form
    {
        List<string> _llista;
        public Form1()
        {
            InitializeComponent();

            //metode per crear l'arxiu que analitzarem, per si no el tens creat es crea sol
            //crearArxiu();
        }

        private async Task llistaSequencial()
        {
            //creem una llista de string
            _llista = new List<string>();

            Stopwatch rellotge = new Stopwatch();
            rellotge.Restart();

            //afegim tots els fixers a la llista creada i un threed sleep per fer un espai de temps.
            foreach(string m in Directory.GetDirectories(@"C:\Users\CORBA\Documents\prova"))
            {
                
                foreach(string e in Directory.GetFiles(m))
                {
                    _llista.Add(e);
                    System.Threading.Thread.Sleep(1);
                }
            }
            //posem tot lo de la llista al listbox
            Llista.DataSource = _llista;
            rellotge.Stop();
            //temps que tarda en realitzar la tasca
            temps1.Text = rellotge.Elapsed.TotalSeconds.ToString() + "segons";
        }

        private async Task llistaAsync()
        {
            _llista = new List<string>();
            Stopwatch rellotge = new Stopwatch();
            rellotge.Restart();

            //utilitzem el paralel foreach
            Parallel.ForEach(Directory.GetDirectories(@"C:\Users\CORBA\Documents\prova"), i =>
            {
                foreach (string m in Directory.GetFiles(i))
                {
                    _llista.Add(m);
                    System.Threading.Thread.Sleep(1);
                }
            });

            llista2.DataSource = _llista;
            rellotge.Stop();
            temps2.Text = rellotge.Elapsed.TotalSeconds.ToString() + "segons";
        }

        //metode per comprovar si l'arxiu està creat. 
        /*public void crearArxiu()
        {
            if (!Directory.Exists(@"C:\Users\CORBA\Documents\prova"))
            {
                DirectoryInfo directori = Directory.CreateDirectory(@"C:\Users\CORBA\Documents\prova");
            }
        }*/

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void botoSequencial_click(object sender, EventArgs e)
        {
            llistaSequencial();
        }

        private void botoAsync_Click(object sender, EventArgs e)
        {
            llistaAsync();
        }
        //mostrem la hora local del nostre sistema.
        private void horaLocal_Click(object sender, EventArgs e)
        {
            textHora.Text = "Son les" + DateTime.Now.ToString("HH:mm:ss");
        }

        private void textHora_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
