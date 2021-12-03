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

namespace BrazoRobóticoApp
{
    public partial class FormCrearRutina : Form
    {        
        TextBox[] txtAngulos = new TextBox[16];
        ComboBox[] cmbServos = new ComboBox[16];
        public string auxTexto = null;
        public string raiz = @"E:\Uni\5to Semestre\Arquitectura de Computadoras\Proyecto\BrazoRobóticoApp\BrazoRobóticoApp\Rutinas\";       

        #region Carga y Cierre
        public FormCrearRutina()
        {
            InitializeComponent();
        }

        private void FormCrearRutina_Load(object sender, EventArgs e)
        {
            CargarArreglos();
        }

        private void FormCrearRutina_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
        #endregion       

        #region Botones
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (File.Exists(raiz + txtNombre.Text + ".txt"))
            {
                errorProvider.SetError(txtNombre, "La rutina ya existe!");
            }
            else if (RutinaVacia())
            {
                errorProvider.SetError(cPanel1, "No se ingresaron datos!");
            }
            else
            {
                errorProvider.Clear();
                CrearLineaComandos();

                MessageBox.Show("La rutina se creó con éxito", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void toggle5_Click(object sender, EventArgs e)
        {
            if (toggle5.BackgroundColor == Color.Brown)
            {
                cPanel5.Enabled = true;
                toggle5.BackgroundColor = Color.FromArgb(36, 36, 36);
            }
            else
            {
                cPanel5.Enabled = false;
                toggle5.BackgroundColor = Color.Brown;
            }
        }

        private void toggle6_Click(object sender, EventArgs e)
        {
            if (toggle6.BackgroundColor == Color.Brown)
            {
                cPanel6.Enabled = true;
                toggle6.BackgroundColor = Color.FromArgb(36, 36, 36);
            }
            else
            {
                cPanel6.Enabled = false;
                toggle6.BackgroundColor = Color.Brown;
            }
        }

        private void toggle7_Click(object sender, EventArgs e)
        {
            if (toggle7.BackgroundColor == Color.Brown)
            {
                cPanel7.Enabled = true;
                toggle7.BackgroundColor = Color.FromArgb(36, 36, 36);
            }
            else
            {
                cPanel7.Enabled = false;
                toggle7.BackgroundColor = Color.Brown;
            }
        }

        private void toggle8_Click(object sender, EventArgs e)
        {
            if (toggle8.BackgroundColor == Color.Brown)
            {
                cPanel8.Enabled = true;
                toggle8.BackgroundColor = Color.FromArgb(36, 36, 36);
            }
            else
            {
                cPanel8.Enabled = false;
                toggle8.BackgroundColor = Color.Brown;
            }
        }
        #endregion

        #region Validaciones Text Boxes

        #region Keypress
        private void ang1_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtCmbKeyPress(sender, e, 0);
        }

        private void ang2_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtCmbKeyPress(sender, e, 1);
        }

        private void ang3_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtCmbKeyPress(sender, e, 2);
        }

        private void ang4_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtCmbKeyPress(sender, e, 3);
        }

        private void ang5_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtCmbKeyPress(sender, e, 4);
        }

        private void ang6_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtCmbKeyPress(sender, e, 5);
        }

        private void ang7_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtCmbKeyPress(sender, e, 6);
        }

        private void ang8_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtCmbKeyPress(sender, e, 7);
        }

        private void ang9_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtCmbKeyPress(sender, e, 8);
        }

        private void ang10_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtCmbKeyPress(sender, e, 9);
        }

        private void ang11_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtCmbKeyPress(sender, e, 10);
        }

        private void ang12_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtCmbKeyPress(sender, e, 11);
        }

        private void ang13_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtCmbKeyPress(sender, e, 12);
        }

        private void ang14_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtCmbKeyPress(sender, e, 13);
        }

        private void ang15_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtCmbKeyPress(sender, e, 14);
        }

        private void ang16_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtCmbKeyPress(sender, e, 15);
        }


        private void cmb1_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtCmbKeyPress(sender, e, 0);
        }
        private void cmb2_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtCmbKeyPress(sender, e, 1);
        }
        private void cmb3_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtCmbKeyPress(sender, e, 2);
        }
        private void cmb4_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtCmbKeyPress(sender, e, 3);
        }
        private void cmb5_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtCmbKeyPress(sender, e, 4);
        }
        private void cmb6_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtCmbKeyPress(sender, e, 5);
        }

        private void cmb7_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtCmbKeyPress(sender, e, 6);
        }
        private void cmb8_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtCmbKeyPress(sender, e, 7);
        }
        private void cmb9_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtCmbKeyPress(sender, e, 8);
        }
        private void cmb10_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtCmbKeyPress(sender, e, 9);
        }
        private void cmb11_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtCmbKeyPress(sender, e, 10);
        }
        private void cmb12_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtCmbKeyPress(sender, e, 11);
        }
        private void cmb13_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtCmbKeyPress(sender, e, 12);
        }
        private void cmb14_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtCmbKeyPress(sender, e, 13);
        }
        private void cmb15_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtCmbKeyPress(sender, e, 14);
        }
        private void cmb16_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtCmbKeyPress(sender, e, 15);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Formato
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back || Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == 13)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }
        #endregion

        #region Enter
        private void ang1_Enter(object sender, EventArgs e)
        {
            TextBoxEnter(0);
        }
        private void ang2_Enter(object sender, EventArgs e)
        {
            TextBoxEnter(1);
        }
        private void ang3_Enter(object sender, EventArgs e)
        {
            TextBoxEnter(2);
        }
        private void ang4_Enter(object sender, EventArgs e)
        {
            TextBoxEnter(3);
        }
        private void ang5_Enter(object sender, EventArgs e)
        {
            TextBoxEnter(4);
        }
        private void ang6_Enter(object sender, EventArgs e)
        {
            TextBoxEnter(5);
        }
        private void ang7_Enter(object sender, EventArgs e)
        {
            TextBoxEnter(6);
        }
        private void ang8_Enter(object sender, EventArgs e)
        {
            TextBoxEnter(7);
        }
        private void ang9_Enter(object sender, EventArgs e)
        {
            TextBoxEnter(8);
        }
        private void ang10_Enter(object sender, EventArgs e)
        {
            TextBoxEnter(9);
        }
        private void ang11_Enter(object sender, EventArgs e)
        {
            TextBoxEnter(10);
        }
        private void ang12_Enter(object sender, EventArgs e)
        {
            TextBoxEnter(11);
        }
        private void ang13_Enter(object sender, EventArgs e)
        {
            TextBoxEnter(12);
        }
        private void ang14_Enter(object sender, EventArgs e)
        {
            TextBoxEnter(13);
        }
        private void ang15_Enter(object sender, EventArgs e)
        {
            TextBoxEnter(14);
        }
        private void ang16_Enter(object sender, EventArgs e)
        {
            TextBoxEnter(15);
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Nombre")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.WhiteSmoke;
            }
        }
        #endregion

        #region Leave
        private void ang1_Leave(object sender, EventArgs e)
        {
            TextBoxLeave(0);
        }
        private void ang2_Leave(object sender, EventArgs e)
        {
            TextBoxLeave(1);
        }
        private void ang3_Leave(object sender, EventArgs e)
        {
            TextBoxLeave(2);
        }
        private void ang4_Leave(object sender, EventArgs e)
        {
            TextBoxLeave(3);
        }
        private void ang5_Leave(object sender, EventArgs e)
        {
            TextBoxLeave(4);
        }
        private void ang6_Leave(object sender, EventArgs e)
        {
            TextBoxLeave(5);
        }
        private void ang7_Leave(object sender, EventArgs e)
        {
            TextBoxLeave(6);
        }
        private void ang8_Leave(object sender, EventArgs e)
        {
            TextBoxLeave(7);
        }
        private void ang9_Leave(object sender, EventArgs e)
        {
            TextBoxLeave(8);
        }
        private void ang10_Leave(object sender, EventArgs e)
        {
            TextBoxLeave(9);
        }
        private void ang11_Leave(object sender, EventArgs e)
        {
            TextBoxLeave(10);
        }
        private void ang12_Leave(object sender, EventArgs e)
        {
            TextBoxLeave(11);
        }
        private void ang13_Leave(object sender, EventArgs e)
        {
            TextBoxLeave(12);
        }
        private void ang14_Leave(object sender, EventArgs e)
        {
            TextBoxLeave(13);
        }
        private void ang15_Leave(object sender, EventArgs e)
        {
            TextBoxLeave(14);
        }
        private void ang16_Leave(object sender, EventArgs e)
        {
            TextBoxLeave(15);
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if(txtNombre.Text.Length == 0)
            {
                txtNombre.Text = "Nombre";
                txtNombre.ForeColor = Color.DimGray;
            }
        }
        #endregion

        #endregion

        #region Métodos Auxiliares
        private void CargarArreglos()
        {          
            txtAngulos[0] = ang1;
            txtAngulos[1] = ang2;
            txtAngulos[2] = ang3;
            txtAngulos[3] = ang4;
            txtAngulos[4] = ang5;
            txtAngulos[5] = ang6;
            txtAngulos[6] = ang7;
            txtAngulos[7] = ang8;
            txtAngulos[8] = ang9;
            txtAngulos[9] = ang10;
            txtAngulos[10] = ang11;
            txtAngulos[11] = ang12;
            txtAngulos[12] = ang13;
            txtAngulos[13] = ang14;
            txtAngulos[14] = ang15;
            txtAngulos[15] = ang16;

            cmbServos[0] = cmb1;
            cmbServos[1] = cmb2;
            cmbServos[2] = cmb3;
            cmbServos[3] = cmb4;
            cmbServos[4] = cmb5;
            cmbServos[5] = cmb6;
            cmbServos[6] = cmb7;
            cmbServos[7] = cmb8;
            cmbServos[8] = cmb9;
            cmbServos[9] = cmb10;
            cmbServos[10] = cmb11;
            cmbServos[11] = cmb12;
            cmbServos[12] = cmb13;
            cmbServos[13] = cmb14;
            cmbServos[14] = cmb15;
            cmbServos[15] = cmb16;
        }

        private void txtCmbKeyPress(object sender, KeyPressEventArgs e, int i)
        {
            //Formato
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == 13)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                
                if(ActiveControl is ComboBox)
                {
                    cmbServos[i + 1].DroppedDown = true;                   
                }

                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TextBoxEnter(int i)
        {
            if (txtAngulos[i].Text == "NA")
            {
                auxTexto = "NA";
                txtAngulos[i].Text = "";
            }
            else
            {
                auxTexto = txtAngulos[i].Text;
                txtAngulos[i].Text = txtAngulos[i].Text.Replace("°", string.Empty);
                txtAngulos[i].MaxLength = 3;
            }           
        }

        private void TextBoxLeave(int i)
        {
            txtAngulos[i].MaxLength = 4;

            if (txtAngulos[i].Text.Length == 0 || int.Parse(txtAngulos[i].Text) > 180)
            {
                txtAngulos[i].Text = auxTexto;
            }
            else
            {
                txtAngulos[i].Text += "°";
            }
        }

        public void CrearLineaComandos()
        {
            string lineaComandos = null;
            char auxServo;

            StreamWriter escribirRutina = new StreamWriter(raiz + txtNombre.Text + ".txt");

            for (int i = 0; i < 16; i++)
            {
                //Se ingresa un simbolo de > para indicar esa parte de la iteración es nula
                if (cmbServos[i].SelectedItem == null || txtAngulos[i].Text == "NA")
                {
                    if (cmbServos[i].Parent.Enabled == true)
                    {
                        if ((i % 2) != 0) //es impar
                        {
                            lineaComandos += ">&";
                        }
                        else
                        {
                            lineaComandos += ">";
                        }

                        cmbServos[i].SelectedItem = null;
                        txtAngulos[i].Text = "NA";
                    }                  
                }
                else
                {
                    //Sí el combobox/textbox es el segundo de su iteración (su índice es impar)
                    //Se ingresa el comando a la linea con un simbolo para indicar un delay en la ejecución de la rutina
                    if ((i % 2) != 0) 
                    {
                        auxServo = CmdServo(i);
                        lineaComandos += "$" + auxServo + txtAngulos[i].Text + "&";
                    }
                    //Sí el combobox/textbox es el primero de la iteración (su índice es par)
                    //Se ingresa el comando a la linea
                    else
                    {
                        auxServo = CmdServo(i);
                        lineaComandos += "$" + auxServo + txtAngulos[i].Text;
                    }
                }                                        
            }

            escribirRutina.Write(lineaComandos);
            escribirRutina.Close();
        }

        //Calcúla que servomotor se seleccionó en el combobox
        private char CmdServo(int i)
        {
            char aux1 = 'T';

            switch (cmbServos[i].Text)
            {
                case "Rotación":

                    aux1 = 'R';
                    break;

                case "Hombro":

                    aux1 = 'H';
                    break;

                case "Codo":

                    aux1 = 'C';
                    break;

                case "Muñeca":

                    aux1 = 'M';
                    break;

                case "Agarre":

                    aux1 = 'A';
                    break;
            }

            return aux1;
        }

        private bool RutinaVacia()
        {
            int pos = 0;
          
            for (int i = 0; i < 16; i++)
            {
                if (cmbServos[i].SelectedItem == null || txtAngulos[i].Text == "NA")
                {
                    pos += 1;
                }
            }

            if (pos == 16) return true;
            else return false;
        }




        #endregion       
    }
}
