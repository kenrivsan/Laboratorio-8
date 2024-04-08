using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace UsoArchivosJson
{
    public partial class Form1 : Form
    {
        List<clsNotas> nota = new List<clsNotas>();
        List<int> notaTemporal = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int nota =  int.Parse(txtNota.Text);
            notaTemporal.Add(nota);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clsNotas datosAlumno = new clsNotas();
            datosAlumno.Nombre = txtNombre.Text;
            datosAlumno.Notas = notaTemporal.GetRange(0,notaTemporal.Count);

            nota.Add(datosAlumno);
            guardarDatos();
            notaTemporal.Clear();
           
        }
        void guardarDatos()
        {
            string json = JsonConvert.SerializeObject(nota);
            string archivo = "Datos.json";
            System.IO.File.WriteAllText(archivo, json);
        }
    }
}
