using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports; //Libreria para obtener el nombre de los puertos de la PC
using System.Threading; //Hilos
using System.Drawing.Drawing2D;
using System.IO;


namespace BrazoRobóticoApp
{ 
    public partial class FormPrincipal : Form
    {
        //Variables globales
        public string auxTexto = null;
        public char auxCmd;
        public TextBox[] txtBoxes = new TextBox[5];
        public TrackBar[] trackBars = new TrackBar[5];
        public string lineaComandos = null;
        public string raiz = @"E:\Uni\5to Semestre\Arquitectura de Computadoras\Proyecto\BrazoRobóticoApp\BrazoRobóticoApp\Rutinas";
        public int angR = 0, angH = 0, angC = 0, angM = 0, angA = 0;

        #region Carga y Cierre del Programa
        public FormPrincipal()
        {
            InitializeComponent();           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //metodo desechable en evento
                ComponentesSinConexión();
                ObtenerRutinas();

                //Baud Rate
                string[] listaBaud = { "9600", "38400", "57600", "115200" };
                cmbBaud.DataSource = listaBaud;

                //Lista de Puertos COM habilitados
                string[] listaPuertos = SerialPort.GetPortNames();
                cmbPuerto.DataSource = listaPuertos;

                txtBoxes[0] = txtAnguloR;
                txtBoxes[1] = txtAnguloH;
                txtBoxes[2] = txtAnguloC;
                txtBoxes[3] = txtAnguloM;
                txtBoxes[4] = txtAnguloA;

                trackBars[0] = tbServoR;
                trackBars[1] = tbServoH;
                trackBars[2] = tbServoC;
                trackBars[3] = tbServoM;
                trackBars[4] = tbServoA;              

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                Close();
            }
        }

        //Cierre del programa
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.WriteLine($"$F");
                    serialPort1.Close();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        #endregion

        #region Botones
        //Botón conectar
        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                //Si la conexión esta cerrada
                if (!serialPort1.IsOpen)
                {
                    //Nombre del puerto, baud rate y apertura del puerto
                    serialPort1.PortName = cmbPuerto.Text;
                    serialPort1.BaudRate = Convert.ToInt32(cmbBaud.Text);
                    serialPort1.Open();

                    ComponentesConConexión();
                }
                else
                {
                    this.ControlBox = false;
                    ComponentesSinConexión();
                    Desconectar();
                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        //Botón Refrescar
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            try
            {
                //vuelve a verificar los puertos
                string[] listaPuertos = SerialPort.GetPortNames();
                cmbPuerto.DataSource = listaPuertos;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        //Botón Manual
        private void btnManual_Click(object sender, EventArgs e)
        {
            cTabControlModo.SelectedIndex = 0;

            btnManual.BorderSize = 0;
            btnRutina.BorderSize = 3;

            btnManual.BackgroundColor = Color.FromArgb(64, 84, 255);

            btnRutina.BackgroundColor = Color.Transparent;
        }

        //Botón Rutina
        private void btnRutina_Click(object sender, EventArgs e)
        {
            cTabControlModo.SelectedIndex = 1;

            btnManual.BorderSize = 3;
            btnRutina.BorderSize = 0;

            btnRutina.BackgroundColor = Color.FromArgb(64, 84, 255);

            btnManual.BackgroundColor = Color.Transparent;           
        }

        //Botón Crear Rutina
        private void btnCrearRutina_Click(object sender, EventArgs e)
        {
            FormCrearRutina v1 = new FormCrearRutina();
            v1.ShowDialog();

            ObtenerRutinas();

            errorProvider.Clear();
        }

        //Botón Ejecutar
        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbRutinas.Text == "")
                {
                    errorProvider.SetError(cmbRutinas, "No seleccionó ninguna rutina");
                }
                else
                {
                    if (btnEjecutar.Text == "Ejecutar")
                    {
                        errorProvider.Clear();
                       
                        BotonesEjecucion();

                        Thread t1 = new Thread(EjecutarRutina);
                        t1.Start();
                    }
                    else if (btnEjecutar.Text == "Detener")
                    {
                        lblEstadoEjecucion.ForeColor = Color.Brown;
                        lblEstadoEjecucion.Text = "Deteniendo...";

                        btnEjecutar.Text = "Ejecutar";
                        btnEjecutar.Enabled = false;
                        btnEjecutar.BackgroundColor = Color.SeaGreen;
                        btnEjecutar.FlatAppearance.MouseOverBackColor = Color.Blue;
                    }
                }
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }                                              
        }

        private void btnEncender_Click(object sender, EventArgs e)
        {
            if(btnEncender.Text == "Encender")
            {
                btnEncender.BackgroundColor = Color.SeaGreen;
                btnEncender.Text = "Apagar";
                pbLed.Image = BrazoRobóticoApp.Properties.Resources.led2;
                serialPort1.WriteLine($"$O");
            }
            else
            {
                btnEncender.BackgroundColor = Color.Transparent;
                btnEncender.Text = "Encender";
                pbLed.Image = BrazoRobóticoApp.Properties.Resources.led1;
                serialPort1.WriteLine($"$F");
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Eliminar rutina y actualizar rutinas
            if (cmbRutinas.Text == "")
            {
                errorProvider.SetError(cmbRutinas, "No seleccionó ninguna rutina");
            }
            else
            {
                File.Delete(raiz + @"\" + cmbRutinas.Text + ".txt");
                MessageBox.Show("Rutina " + cmbRutinas.Text + " eliminada!", "Alerta", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ObtenerRutinas();
            }
        }
        #endregion

        #region Track Bars Manual
        //Servo Rotación
        private void tbServoR_Scroll(object sender, EventArgs e)
        {
            try
            {
                txtAnguloR.Text = tbServoR.Value + "°";
                serialPort1.WriteLine($"$R{tbServoR.Value}");
                angR = tbServoR.Value;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        //Servo Hombro
        private void tbServoH_Scroll(object sender, EventArgs e)
        {
            try
            {
                txtAnguloH.Text = tbServoH.Value + "°";
                serialPort1.WriteLine($"$H{tbServoH.Value}");
                angH = tbServoH.Value;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        //Servo Codo
        private void tbServoC_Scroll(object sender, EventArgs e)
        {
            try
            {
                txtAnguloC.Text = tbServoC.Value + "°";
                serialPort1.WriteLine($"$C{tbServoC.Value}");
                angC = tbServoC.Value;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        //Servo Muñeca
        private void tbServoM_Scroll(object sender, EventArgs e)
        {
            try
            {
                txtAnguloM.Text = tbServoM.Value + "°";
                serialPort1.WriteLine($"$M{tbServoM.Value}");
                angM = tbServoM.Value;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        //Servo Agarre
        private void tbServoA_Scroll(object sender, EventArgs e)
        {
            try
            {
                txtAnguloA.Text = tbServoA.Value + "°";
                serialPort1.WriteLine($"$A{tbServoA.Value}");
                angA = tbServoA.Value;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        #endregion

        #region Validación Text Boxes

        #region Key Press
        private void txtAnguloR_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxKeyPress(sender, e);
        }
        private void txtAnguloH_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxKeyPress(sender, e);
        }
        private void txtAnguloC_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxKeyPress(sender, e);
        }
        private void txtAnguloM_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxKeyPress(sender, e);
        }
        private void txtAnguloA_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxKeyPress(sender, e);
        }
        #endregion

        #region Enter
        private void txtAnguloR_Enter(object sender, EventArgs e)
        {
            TextBoxEnter(0);
        }
        private void txtAnguloH_Enter(object sender, EventArgs e)
        {
            TextBoxEnter(1);
        }
        private void txtAnguloC_Enter(object sender, EventArgs e)
        {
            TextBoxEnter(2);
        }
        private void txtAnguloM_Enter(object sender, EventArgs e)
        {
            TextBoxEnter(3);
        }
        private void txtAnguloA_Enter(object sender, EventArgs e)
        {
            TextBoxEnter(4);
        }
        #endregion

        #region Leave
        private void txtAnguloR_Leave(object sender, EventArgs e)
        {
            if (txtBoxes[0].Text.Length == 0 || int.Parse(txtBoxes[0].Text) > 150)
            {
                txtBoxes[0].Text = auxTexto;
            }
            else
            {
                TextBoxLeave(0);
                MoverServo("R", txtBoxes[0].Text);
            }
        }
        private void txtAnguloH_Leave(object sender, EventArgs e)
        {
            if (txtBoxes[1].Text.Length == 0 || int.Parse(txtBoxes[1].Text) > 100)
            {
                txtBoxes[1].Text = auxTexto;
            }
            else
            {
                TextBoxLeave(1);
                MoverServo("H", txtBoxes[1].Text);
            }
        }
        private void txtAnguloC_Leave(object sender, EventArgs e)
        {
            if (txtBoxes[2].Text.Length == 0 || int.Parse(txtBoxes[2].Text) > 110)
            {
                txtBoxes[2].Text = auxTexto;
            }
            else
            {
                TextBoxLeave(2);
                MoverServo("C", txtBoxes[2].Text);
            }
        }
        private void txtAnguloM_Leave(object sender, EventArgs e)
        {
            if (txtBoxes[3].Text.Length == 0 || int.Parse(txtBoxes[3].Text) > 180)
            {
                txtBoxes[3].Text = auxTexto;
            }
            else
            {
                TextBoxLeave(3);
                MoverServo("M", txtBoxes[3].Text);               
            }
        }
        private void txtAnguloA_Leave(object sender, EventArgs e)
        {
            if (txtBoxes[4].Text.Length == 0 || int.Parse(txtBoxes[4].Text) > 70)
            {
                txtBoxes[4].Text = auxTexto;
            }
            else
            {
                TextBoxLeave(4);
                MoverServo("A", txtBoxes[4].Text);               
            }
        }
        #endregion

        #endregion

        #region Métodos Auxiliares
        private void ComponentesSinConexión()
        {
            btnConectar.Text = "Conectar";
            btnConectar.BackColor = Color.LimeGreen;
            btnRefrescar.Enabled = true;
            cmbBaud.Enabled = true;
            cmbPuerto.Enabled = true;
            pbConexion.Value = 0;

            cPanelControl.Enabled = false;

            tbServoR.Value = 0;
            tbServoH.Value = 0;
            tbServoC.Value = 0;
            tbServoM.Value = 0;
            tbServoA.Value = 0;

            txtAnguloR.Text = tbServoA.Value + "°";
            txtAnguloH.Text = tbServoA.Value + "°";
            txtAnguloC.Text = tbServoA.Value + "°";
            txtAnguloM.Text = tbServoA.Value + "°";
            txtAnguloA.Text = tbServoA.Value + "°";
        }
        private void ComponentesConConexión()
        {
            btnConectar.Text = "Desconectar";
            btnConectar.BackColor = Color.IndianRed;
            btnRefrescar.Enabled = false;
            cmbBaud.Enabled = false;
            cmbPuerto.Enabled = false;
            pbConexion.Value = 100;
            lblEstado.Text = "Estado: Conectado";

            cPanelControl.Enabled = true;
        }

        private async Task<bool> PuntoInicial()
        {
            await MoverServo("R", "0");
            await MoverServo("H", "0");
            await MoverServo("C", "0");
            await MoverServo("M", "0");
            await MoverServo("A", "0");
            return true;
        }

        private void TextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            //Formato
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back)
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

        private void TextBoxEnter(int i)
        {
            auxTexto = txtBoxes[i].Text;
            txtBoxes[i].Text = txtBoxes[i].Text.Replace("°", string.Empty);
            txtBoxes[i].MaxLength = 3;
        }

        private void TextBoxLeave(int i)
        {
            txtBoxes[i].MaxLength = 4;
            trackBars[i].Value = int.Parse(txtBoxes[i].Text);
            txtBoxes[i].Text += "°";
        }

        private void ObtenerRutinas()
        {
            //Remueve todos los items del combobox
            cmbRutinas.Items.Clear();

            //Obtiene los archivos de texto con las rutinas
            string[] archivos = Directory.GetFiles(raiz);

            //Añade el nombre de cada archivo al combobox
            foreach (string archivo in archivos)
            {
                string auxNom = Path.GetFileName(archivo);
                auxNom = auxNom.Substring(0, auxNom.Length - 4);
                cmbRutinas.Items.Add(auxNom);
            }
        }

        private async void EjecutarRutina()
        {
            try
            {
                if (cmbRutinas.InvokeRequired)
                {
                    cmbRutinas.Invoke(new Action(EjecutarRutina));
                    return;
                }

                await Task.Delay(1000);

                StreamReader leerRutina = new StreamReader(raiz + @"\" + cmbRutinas.Text + ".txt");
                lineaComandos = leerRutina.ReadLine();
                string cmd = null;
                string anguloActivo = null;
                string servoActivo = null;

                lineaComandos = lineaComandos.Replace(">", "");
                lineaComandos += " ";
                pbEjecucion.Maximum = lineaComandos.Length;

                while (btnEjecutar.Text == "Detener")
                {
                    //Lee cada uno de los simbolos de la linea de comandos
                    //para mandar cada uno por separado y esperar medio segundo tras
                    //cada iteración
                    foreach (char simbolo in lineaComandos)
                    {
                        pbEjecucion.PerformStep();

                        if (simbolo == '°')
                        {
                            cmd.Replace("°", "");

                            anguloActivo = cmd.Substring(2);
                            servoActivo = cmd.Substring(1, 1);

                            MostrarActivo(servoActivo, anguloActivo);
                            await MoverServo(servoActivo, anguloActivo);

                            cmd = null;
                        }
                        else if (simbolo == '&')
                        {
                            cmd = null;
                            //await Task.Delay(1500);
                            PanelesInactivos();
                        }
                        else if (simbolo == ' ')
                        {
                            await Task.Delay(2000);
                            pbEjecucion.Value = 0;
                            break;
                        }
                        else
                        {
                            cmd += simbolo;
                        }
                    }
                }

                BotonesNoEjecucion();
                leerRutina.Close();
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }            
        }

        private void BotonesEjecucion()
        {
            cmbRutinas.Enabled = false;
            btnEjecutar.Text = "Detener";
            btnEjecutar.BackgroundColor = Color.Brown;
            btnEjecutar.FlatAppearance.MouseOverBackColor = Color.Yellow;

            btnCrearRutina.Enabled = false;
            btnConectar.Enabled = false;
            btnEliminar.Enabled = false;
            btnManual.Enabled = false;
            btnRutina.Enabled = false;

            lblEstadoEjecucion.ForeColor = Color.SeaGreen;
            lblEstadoEjecucion.Text = "Corriendo...";
        }

        private void BotonesNoEjecucion()
        {
            cmbRutinas.Enabled = true;

            btnEjecutar.Enabled = true;

            btnCrearRutina.Enabled = true;
            btnConectar.Enabled = true;
            btnEliminar.Enabled = true;
            btnManual.Enabled = true;
            btnRutina.Enabled = true;

            lblEstadoEjecucion.Text = "";
        }

        private void MostrarActivo(string servo, string angulo)
        {
            switch (servo)
            {
                case "R":

                    cPanelR.Back = Color.SeaGreen;
                    lblAnguloR.Text = angulo + "°";

                    break;

                case "H":

                    cPanelH.Back = Color.SeaGreen;
                    lblAnguloH.Text = angulo + "°";

                    break;

                case "C":

                    cPanelC.Back = Color.SeaGreen;
                    lblAnguloC.Text = angulo + "°";

                    break;

                case "M":

                    cPanelM.Back = Color.SeaGreen;
                    lblAnguloM.Text = angulo + "°";

                    break;

                case "A":

                    cPanelA.Back = Color.SeaGreen;
                    lblAnguloA.Text = angulo + "°";

                    break;
            }
        }

        private void PanelesInactivos()
        {
            cPanelR.Back = Color.FromArgb(36, 36, 36);
            cPanelH.Back = Color.FromArgb(36, 36, 36);
            cPanelC.Back = Color.FromArgb(36, 36, 36);
            cPanelM.Back = Color.FromArgb(36, 36, 36);
            cPanelA.Back = Color.FromArgb(36, 36, 36);
        }

        private async void Desconectar()
        {
            lblEstado.Text = "Estado: Desconectando...";
            btnConectar.Enabled = false;
            await PuntoInicial();
            serialPort1.WriteLine($"$F");
            serialPort1.Close();
            btnConectar.Enabled = true;
            lblEstado.Text = "Estado: Desconectado";
            this.ControlBox = true;
        }

        private async Task<bool> MoverServo(string servo, string angulo)
        {
            int auxAng = Int32.Parse(angulo);

            switch (servo)
            {
                case "R":

                    if (auxAng > angR)
                    {
                        for (int i = angR; i <= auxAng; i++)
                        {
                            serialPort1.WriteLine($"$R" + i.ToString());
                            await Task.Delay(50);
                        }
                    }
                    else
                    {
                        for (int i = angR; i >= auxAng; i--)
                        {
                            serialPort1.WriteLine($"$R" + i.ToString());
                            await Task.Delay(50);
                        }
                    }
                    angR = Int32.Parse(angulo);

                    break;

                case "H":

                    if (auxAng > angH)
                    {
                        for (int i = angH; i <= auxAng; i++)
                        {
                            serialPort1.WriteLine($"$H" + i.ToString());
                            await Task.Delay(100);
                        }
                    }
                    else
                    {
                        for (int i = angH; i >= auxAng; i--)
                        {
                            serialPort1.WriteLine($"$H" + i.ToString());
                            await Task.Delay(100);
                        }
                    }
                    angH = Int32.Parse(angulo);


                    break;

                case "C":

                    if (auxAng > angC)
                    {
                        for (int i = angC; i <= auxAng; i++)
                        {
                            serialPort1.WriteLine($"$C" + i.ToString());
                            await Task.Delay(50);
                        }
                    }
                    else
                    {
                        for (int i = angC; i >= auxAng; i--)
                        {
                            serialPort1.WriteLine($"$C" + i.ToString());
                            await Task.Delay(50);
                        }
                    }
                    angC = Int32.Parse(angulo);

                    break;

                case "M":

                    if (auxAng > angM)
                    {
                        for (int i = angM; i <= auxAng; i++)
                        {
                            serialPort1.WriteLine($"$M" + i.ToString());
                            await Task.Delay(60);
                        }
                    }
                    else
                    {
                        for (int i = angM; i >= auxAng; i--)
                        {
                            serialPort1.WriteLine($"$M" + i.ToString());
                            await Task.Delay(60);
                        }
                    }
                    angM = Int32.Parse(angulo);

                    break;

                case "A":

                    if (auxAng > angA)
                    {
                        for (int i = angA; i <= auxAng; i++)
                        {
                            serialPort1.WriteLine("$A" + i.ToString());
                            await Task.Delay(50);
                        }
                    }
                    else
                    {
                        for (int i = angA; i >= auxAng; i--)
                        {
                            serialPort1.WriteLine($"$A" + i.ToString());
                            await Task.Delay(50);
                        }
                    }
                    angA = Int32.Parse(angulo);

                    break;
            }
            return true;
        }
        #endregion
    }
}
