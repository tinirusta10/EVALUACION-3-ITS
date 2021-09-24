using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            
                       
            
            string contraseña1 = System.Convert.ToString(txtcontra.Text);
            string contraseña2 = System.Convert.ToString(txtcontrarep.Text);



            //este if valida los textbox de la pestaña "registro"// 



            if (txtnombre.Text == "")
            
            {
                MessageBox.Show("ingrese un nombre");
            }

            else if (txtcontra.Text == "")

            {
                MessageBox.Show("ingrese una contraseña");
            }


            else if (txtcontrarep.Text == "")
            {
                MessageBox.Show("ingrese una contraseña");
            }

            else if (contraseña1 != contraseña2)
            {
                MessageBox.Show("las contraseñas no coinciden");
            }


            else
            {
                MessageBox.Show("registrado correctamente, vaya a la pestaña ingresar");
            }
            
           


        }

        private void button1_Click(object sender, EventArgs e)
        {
            


           
            //este if valida los textbox de la pestaña "ingresar"//


            if (txtnombre.Text == "")

            {
                MessageBox.Show("ingrese un nombre");
            }

            else if (txtcontra.Text == "")

            {
                MessageBox.Show("ingrese una contraseña");
            }

            else if (txtpass.Text== "")
            {
                MessageBox.Show("ingrese una contraseña");
            }

            else if (txtname.Text == txtnombre.Text && txtcontra.Text==txtpass.Text)
            {
                MessageBox.Show("Bienvenido");

            }

            else if(txtpass.Text == txtnueva.Text)

                MessageBox.Show("Bienvenido");
            else
            {
                MessageBox.Show("contraseña o nombre incorrecto, vaya a la ventana recuperar"); 
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            //Este if hace que muestre o no la contraseña//

            if (chkmostrar1.Checked == true)
            {
               
                txtpass.PasswordChar = '\0';
            }
            else
            {

                txtpass.PasswordChar = '*';
            }
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcontra_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcontrarep_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (txtnueva.Text == "")

            {
                MessageBox.Show("ingrese una contraseña");
            }

            else if (txtnuevados.Text == "")

            {
                MessageBox.Show("ingrese una contraseña");
            }
                


            else if (txtnueva.Text != txtnuevados.Text)
            {
                MessageBox.Show("las contraseñas no coinciden");
            }

            else
            {
                MessageBox.Show("la contraseña se ha cambiado");
            }
            
        }
      
        
       
        private void tmrreloj_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToLongTimeString();             //evento de reloj del timer
        }

        private void txtnueva_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            
        }

      
        
        private void btnsalir_Click_1(object sender, EventArgs e)
        {
            var eleccion = DialogResult;
            for (int i = 0; i < 3; i++)                                     /*esta estrutura repetitiva muestra un mensaje al apretar el boton salir*/
            {
               eleccion= MessageBox.Show("Desea salir? Presione 3 veces Si, si no lo desea presione No  / Aviso  :" + i , "Salir",MessageBoxButtons.YesNo);

                if (eleccion== DialogResult.No)                                                                     
                {
                    break;
                } 
            }

            if (eleccion== DialogResult.Yes)
            {
                Close();
            }
            














        }
    }
}
