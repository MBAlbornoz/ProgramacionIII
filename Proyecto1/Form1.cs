using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            MessageBox.Show("Bienvenidos!!");

        }
        //CREO UN METODO INDIVIDUAL QUE VOY A LLAMAR DESPUES
        private void otroMetodo()
        {
            MessageBox.Show("Cancelar");
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        
        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

       
        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desea guardar cambios?");
        }
        ///
        private void Button2_Click(object sender, EventArgs e)
        {
         
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            otroMetodo();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Hasta pronto");
        }
    }
}
