
namespace BrazoRobóticoApp
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.cPanelControl = new BrazoRobóticoApp.CustomControls.CustomPanel();
            this.cPanelNav = new BrazoRobóticoApp.CustomControls.CustomPanel();
            this.btnRutina = new BrazoRobóticoApp.CustomControls.CustomBtn();
            this.btnManual = new BrazoRobóticoApp.CustomControls.CustomBtn();
            this.cTabControlModo = new BrazoRobóticoApp.CustomControls.CustomTabControl();
            this.tabManual = new System.Windows.Forms.TabPage();
            this.cPanelManualA = new BrazoRobóticoApp.CustomControls.CustomPanel();
            this.lblServoA = new System.Windows.Forms.Label();
            this.tbServoA = new System.Windows.Forms.TrackBar();
            this.txtAnguloA = new System.Windows.Forms.TextBox();
            this.cPanelManualR = new BrazoRobóticoApp.CustomControls.CustomPanel();
            this.txtAnguloR = new System.Windows.Forms.TextBox();
            this.lblServoR = new System.Windows.Forms.Label();
            this.tbServoR = new System.Windows.Forms.TrackBar();
            this.cPanelManualM = new BrazoRobóticoApp.CustomControls.CustomPanel();
            this.lblServoM = new System.Windows.Forms.Label();
            this.tbServoM = new System.Windows.Forms.TrackBar();
            this.txtAnguloM = new System.Windows.Forms.TextBox();
            this.cPanelManualC = new BrazoRobóticoApp.CustomControls.CustomPanel();
            this.lblServoC = new System.Windows.Forms.Label();
            this.txtAnguloC = new System.Windows.Forms.TextBox();
            this.tbServoC = new System.Windows.Forms.TrackBar();
            this.cPanelManualH = new BrazoRobóticoApp.CustomControls.CustomPanel();
            this.lblServoH = new System.Windows.Forms.Label();
            this.txtAnguloH = new System.Windows.Forms.TextBox();
            this.tbServoH = new System.Windows.Forms.TrackBar();
            this.tabRutina = new System.Windows.Forms.TabPage();
            this.cmbRutinas = new BrazoRobóticoApp.CustomControls.CustomCmb();
            this.cPanelA = new BrazoRobóticoApp.CustomControls.CustomPanel();
            this.lblAnguloA = new System.Windows.Forms.Label();
            this.lblAgarre = new System.Windows.Forms.Label();
            this.cPanel_Led = new BrazoRobóticoApp.CustomControls.CustomPanel();
            this.pbLed = new System.Windows.Forms.PictureBox();
            this.btnEncender = new BrazoRobóticoApp.CustomControls.CustomBtn();
            this.lbl_Led = new System.Windows.Forms.Label();
            this.lblSecuencia = new System.Windows.Forms.Label();
            this.cPanelM = new BrazoRobóticoApp.CustomControls.CustomPanel();
            this.lblAnguloM = new System.Windows.Forms.Label();
            this.lblMuñeca = new System.Windows.Forms.Label();
            this.cPanelEjecutar = new BrazoRobóticoApp.CustomControls.CustomPanel();
            this.lblEstadoEjecucion = new System.Windows.Forms.Label();
            this.pbEjecucion = new System.Windows.Forms.ProgressBar();
            this.btnEjecutar = new BrazoRobóticoApp.CustomControls.CustomBtn();
            this.lblProgreso = new System.Windows.Forms.Label();
            this.cPanelC = new BrazoRobóticoApp.CustomControls.CustomPanel();
            this.lblAnguloC = new System.Windows.Forms.Label();
            this.lblCodo = new System.Windows.Forms.Label();
            this.cPanelH = new BrazoRobóticoApp.CustomControls.CustomPanel();
            this.lblAnguloH = new System.Windows.Forms.Label();
            this.lblHombro = new System.Windows.Forms.Label();
            this.cPanelR = new BrazoRobóticoApp.CustomControls.CustomPanel();
            this.lblAnguloR = new System.Windows.Forms.Label();
            this.lblRotacion = new System.Windows.Forms.Label();
            this.btnEliminar = new BrazoRobóticoApp.CustomControls.CustomBtn();
            this.btnCrearRutina = new BrazoRobóticoApp.CustomControls.CustomBtn();
            this.cPanelConexion = new BrazoRobóticoApp.CustomControls.CustomPanel();
            this.cPanelNavConexion = new BrazoRobóticoApp.CustomControls.CustomPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBaud = new BrazoRobóticoApp.CustomControls.CustomCmb();
            this.cmbPuerto = new BrazoRobóticoApp.CustomControls.CustomCmb();
            this.lblBaudRate = new System.Windows.Forms.Label();
            this.lblPuerto = new System.Windows.Forms.Label();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.btnConectar = new BrazoRobóticoApp.CustomControls.CustomBtn();
            this.pbConexion = new System.Windows.Forms.ProgressBar();
            this.btnRefrescar = new BrazoRobóticoApp.CustomControls.CustomBtn();
            this.lblEstado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.cPanelControl.SuspendLayout();
            this.cPanelNav.SuspendLayout();
            this.cTabControlModo.SuspendLayout();
            this.tabManual.SuspendLayout();
            this.cPanelManualA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbServoA)).BeginInit();
            this.cPanelManualR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbServoR)).BeginInit();
            this.cPanelManualM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbServoM)).BeginInit();
            this.cPanelManualC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbServoC)).BeginInit();
            this.cPanelManualH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbServoH)).BeginInit();
            this.tabRutina.SuspendLayout();
            this.cPanelA.SuspendLayout();
            this.cPanel_Led.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLed)).BeginInit();
            this.cPanelM.SuspendLayout();
            this.cPanelEjecutar.SuspendLayout();
            this.cPanelC.SuspendLayout();
            this.cPanelH.SuspendLayout();
            this.cPanelR.SuspendLayout();
            this.cPanelConexion.SuspendLayout();
            this.cPanelNavConexion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // cPanelControl
            // 
            this.cPanelControl.Back = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.cPanelControl.BackColor = System.Drawing.Color.Transparent;
            this.cPanelControl.Controls.Add(this.cPanelNav);
            this.cPanelControl.Controls.Add(this.cTabControlModo);
            this.cPanelControl.Location = new System.Drawing.Point(253, 12);
            this.cPanelControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cPanelControl.MatrixRound = 40;
            this.cPanelControl.Name = "cPanelControl";
            this.cPanelControl.Size = new System.Drawing.Size(731, 494);
            this.cPanelControl.TabIndex = 2;
            // 
            // cPanelNav
            // 
            this.cPanelNav.Back = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.cPanelNav.Controls.Add(this.btnRutina);
            this.cPanelNav.Controls.Add(this.btnManual);
            this.cPanelNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.cPanelNav.Location = new System.Drawing.Point(0, 0);
            this.cPanelNav.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cPanelNav.MatrixRound = 40;
            this.cPanelNav.Name = "cPanelNav";
            this.cPanelNav.Size = new System.Drawing.Size(731, 49);
            this.cPanelNav.TabIndex = 6;
            // 
            // btnRutina
            // 
            this.btnRutina.BackColor = System.Drawing.Color.Transparent;
            this.btnRutina.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnRutina.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(84)))), ((int)(((byte)(255)))));
            this.btnRutina.BorderRadius = 30;
            this.btnRutina.BorderSize = 3;
            this.btnRutina.FlatAppearance.BorderSize = 0;
            this.btnRutina.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumBlue;
            this.btnRutina.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnRutina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRutina.Font = new System.Drawing.Font("Open Sans Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRutina.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRutina.Location = new System.Drawing.Point(367, 6);
            this.btnRutina.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRutina.Name = "btnRutina";
            this.btnRutina.Size = new System.Drawing.Size(155, 34);
            this.btnRutina.TabIndex = 2;
            this.btnRutina.TabStop = false;
            this.btnRutina.Text = "Rutina";
            this.btnRutina.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnRutina.UseVisualStyleBackColor = false;
            this.btnRutina.Click += new System.EventHandler(this.btnRutina_Click);
            // 
            // btnManual
            // 
            this.btnManual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(84)))), ((int)(((byte)(255)))));
            this.btnManual.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(84)))), ((int)(((byte)(255)))));
            this.btnManual.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(84)))), ((int)(((byte)(255)))));
            this.btnManual.BorderRadius = 30;
            this.btnManual.BorderSize = 0;
            this.btnManual.FlatAppearance.BorderSize = 0;
            this.btnManual.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumBlue;
            this.btnManual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnManual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManual.Font = new System.Drawing.Font("Open Sans Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManual.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnManual.Location = new System.Drawing.Point(207, 6);
            this.btnManual.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnManual.Name = "btnManual";
            this.btnManual.Size = new System.Drawing.Size(155, 34);
            this.btnManual.TabIndex = 1;
            this.btnManual.TabStop = false;
            this.btnManual.Text = "Manual";
            this.btnManual.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnManual.UseVisualStyleBackColor = false;
            this.btnManual.Click += new System.EventHandler(this.btnManual_Click);
            // 
            // cTabControlModo
            // 
            this.cTabControlModo.Controls.Add(this.tabManual);
            this.cTabControlModo.Controls.Add(this.tabRutina);
            this.cTabControlModo.Location = new System.Drawing.Point(23, 21);
            this.cTabControlModo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cTabControlModo.Multiline = true;
            this.cTabControlModo.Name = "cTabControlModo";
            this.cTabControlModo.SelectedIndex = 0;
            this.cTabControlModo.Size = new System.Drawing.Size(684, 473);
            this.cTabControlModo.TabIndex = 76;
            // 
            // tabManual
            // 
            this.tabManual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.tabManual.Controls.Add(this.cPanelManualA);
            this.tabManual.Controls.Add(this.cPanelManualR);
            this.tabManual.Controls.Add(this.cPanelManualM);
            this.tabManual.Controls.Add(this.cPanelManualC);
            this.tabManual.Controls.Add(this.cPanelManualH);
            this.tabManual.Location = new System.Drawing.Point(4, 25);
            this.tabManual.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabManual.Name = "tabManual";
            this.tabManual.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabManual.Size = new System.Drawing.Size(676, 444);
            this.tabManual.TabIndex = 0;
            this.tabManual.Text = "tabPage1";
            // 
            // cPanelManualA
            // 
            this.cPanelManualA.Back = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.cPanelManualA.BackColor = System.Drawing.Color.Transparent;
            this.cPanelManualA.Controls.Add(this.lblServoA);
            this.cPanelManualA.Controls.Add(this.tbServoA);
            this.cPanelManualA.Controls.Add(this.txtAnguloA);
            this.cPanelManualA.Location = new System.Drawing.Point(6, 374);
            this.cPanelManualA.MatrixRound = 30;
            this.cPanelManualA.Name = "cPanelManualA";
            this.cPanelManualA.Size = new System.Drawing.Size(670, 69);
            this.cPanelManualA.TabIndex = 5;
            // 
            // lblServoA
            // 
            this.lblServoA.AutoSize = true;
            this.lblServoA.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServoA.ForeColor = System.Drawing.Color.LightGray;
            this.lblServoA.Location = new System.Drawing.Point(26, 21);
            this.lblServoA.Name = "lblServoA";
            this.lblServoA.Size = new System.Drawing.Size(120, 23);
            this.lblServoA.TabIndex = 1;
            this.lblServoA.Text = "Servo Agarre";
            this.lblServoA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbServoA
            // 
            this.tbServoA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.tbServoA.Location = new System.Drawing.Point(154, 10);
            this.tbServoA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbServoA.Maximum = 70;
            this.tbServoA.Name = "tbServoA";
            this.tbServoA.Size = new System.Drawing.Size(455, 56);
            this.tbServoA.TabIndex = 2;
            this.tbServoA.TabStop = false;
            this.tbServoA.TickFrequency = 5;
            this.tbServoA.Scroll += new System.EventHandler(this.tbServoA_Scroll);
            // 
            // txtAnguloA
            // 
            this.txtAnguloA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.txtAnguloA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAnguloA.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnguloA.ForeColor = System.Drawing.Color.LightGray;
            this.txtAnguloA.Location = new System.Drawing.Point(610, 18);
            this.txtAnguloA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAnguloA.MaxLength = 4;
            this.txtAnguloA.Name = "txtAnguloA";
            this.txtAnguloA.ShortcutsEnabled = false;
            this.txtAnguloA.Size = new System.Drawing.Size(40, 24);
            this.txtAnguloA.TabIndex = 3;
            this.txtAnguloA.Text = "0°";
            this.txtAnguloA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAnguloA.Enter += new System.EventHandler(this.txtAnguloA_Enter);
            this.txtAnguloA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnguloA_KeyPress);
            this.txtAnguloA.Leave += new System.EventHandler(this.txtAnguloA_Leave);
            // 
            // cPanelManualR
            // 
            this.cPanelManualR.Back = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.cPanelManualR.BackColor = System.Drawing.Color.Transparent;
            this.cPanelManualR.Controls.Add(this.txtAnguloR);
            this.cPanelManualR.Controls.Add(this.lblServoR);
            this.cPanelManualR.Controls.Add(this.tbServoR);
            this.cPanelManualR.Location = new System.Drawing.Point(6, 54);
            this.cPanelManualR.MatrixRound = 30;
            this.cPanelManualR.Name = "cPanelManualR";
            this.cPanelManualR.Size = new System.Drawing.Size(670, 69);
            this.cPanelManualR.TabIndex = 1;
            // 
            // txtAnguloR
            // 
            this.txtAnguloR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.txtAnguloR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAnguloR.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnguloR.ForeColor = System.Drawing.Color.LightGray;
            this.txtAnguloR.Location = new System.Drawing.Point(610, 18);
            this.txtAnguloR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAnguloR.MaxLength = 4;
            this.txtAnguloR.Name = "txtAnguloR";
            this.txtAnguloR.ShortcutsEnabled = false;
            this.txtAnguloR.Size = new System.Drawing.Size(40, 24);
            this.txtAnguloR.TabIndex = 3;
            this.txtAnguloR.Text = "0°";
            this.txtAnguloR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAnguloR.Enter += new System.EventHandler(this.txtAnguloR_Enter);
            this.txtAnguloR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnguloR_KeyPress);
            this.txtAnguloR.Leave += new System.EventHandler(this.txtAnguloR_Leave);
            // 
            // lblServoR
            // 
            this.lblServoR.AutoSize = true;
            this.lblServoR.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServoR.ForeColor = System.Drawing.Color.LightGray;
            this.lblServoR.Location = new System.Drawing.Point(9, 21);
            this.lblServoR.Name = "lblServoR";
            this.lblServoR.Size = new System.Drawing.Size(137, 23);
            this.lblServoR.TabIndex = 1;
            this.lblServoR.Text = "Servo Rotación";
            this.lblServoR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbServoR
            // 
            this.tbServoR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.tbServoR.Location = new System.Drawing.Point(154, 10);
            this.tbServoR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbServoR.Maximum = 180;
            this.tbServoR.Name = "tbServoR";
            this.tbServoR.Size = new System.Drawing.Size(455, 56);
            this.tbServoR.TabIndex = 2;
            this.tbServoR.TabStop = false;
            this.tbServoR.TickFrequency = 5;
            this.tbServoR.Scroll += new System.EventHandler(this.tbServoR_Scroll);
            // 
            // cPanelManualM
            // 
            this.cPanelManualM.Back = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.cPanelManualM.BackColor = System.Drawing.Color.Transparent;
            this.cPanelManualM.Controls.Add(this.lblServoM);
            this.cPanelManualM.Controls.Add(this.tbServoM);
            this.cPanelManualM.Controls.Add(this.txtAnguloM);
            this.cPanelManualM.Location = new System.Drawing.Point(6, 294);
            this.cPanelManualM.MatrixRound = 30;
            this.cPanelManualM.Name = "cPanelManualM";
            this.cPanelManualM.Size = new System.Drawing.Size(670, 69);
            this.cPanelManualM.TabIndex = 4;
            // 
            // lblServoM
            // 
            this.lblServoM.AutoSize = true;
            this.lblServoM.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServoM.ForeColor = System.Drawing.Color.LightGray;
            this.lblServoM.Location = new System.Drawing.Point(17, 21);
            this.lblServoM.Name = "lblServoM";
            this.lblServoM.Size = new System.Drawing.Size(129, 23);
            this.lblServoM.TabIndex = 1;
            this.lblServoM.Text = "Servo Muñeca";
            this.lblServoM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbServoM
            // 
            this.tbServoM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.tbServoM.Location = new System.Drawing.Point(154, 10);
            this.tbServoM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbServoM.Maximum = 180;
            this.tbServoM.Name = "tbServoM";
            this.tbServoM.Size = new System.Drawing.Size(455, 56);
            this.tbServoM.TabIndex = 2;
            this.tbServoM.TabStop = false;
            this.tbServoM.TickFrequency = 5;
            this.tbServoM.Scroll += new System.EventHandler(this.tbServoM_Scroll);
            // 
            // txtAnguloM
            // 
            this.txtAnguloM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.txtAnguloM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAnguloM.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnguloM.ForeColor = System.Drawing.Color.LightGray;
            this.txtAnguloM.Location = new System.Drawing.Point(610, 18);
            this.txtAnguloM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAnguloM.MaxLength = 4;
            this.txtAnguloM.Name = "txtAnguloM";
            this.txtAnguloM.ShortcutsEnabled = false;
            this.txtAnguloM.Size = new System.Drawing.Size(40, 24);
            this.txtAnguloM.TabIndex = 3;
            this.txtAnguloM.Text = "0°";
            this.txtAnguloM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAnguloM.Enter += new System.EventHandler(this.txtAnguloM_Enter);
            this.txtAnguloM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnguloM_KeyPress);
            this.txtAnguloM.Leave += new System.EventHandler(this.txtAnguloM_Leave);
            // 
            // cPanelManualC
            // 
            this.cPanelManualC.Back = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.cPanelManualC.BackColor = System.Drawing.Color.Transparent;
            this.cPanelManualC.Controls.Add(this.lblServoC);
            this.cPanelManualC.Controls.Add(this.txtAnguloC);
            this.cPanelManualC.Controls.Add(this.tbServoC);
            this.cPanelManualC.Location = new System.Drawing.Point(6, 214);
            this.cPanelManualC.MatrixRound = 30;
            this.cPanelManualC.Name = "cPanelManualC";
            this.cPanelManualC.Size = new System.Drawing.Size(670, 69);
            this.cPanelManualC.TabIndex = 3;
            // 
            // lblServoC
            // 
            this.lblServoC.AutoSize = true;
            this.lblServoC.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServoC.ForeColor = System.Drawing.Color.LightGray;
            this.lblServoC.Location = new System.Drawing.Point(40, 21);
            this.lblServoC.Name = "lblServoC";
            this.lblServoC.Size = new System.Drawing.Size(106, 23);
            this.lblServoC.TabIndex = 1;
            this.lblServoC.Text = "Servo Codo";
            this.lblServoC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAnguloC
            // 
            this.txtAnguloC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.txtAnguloC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAnguloC.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnguloC.ForeColor = System.Drawing.Color.LightGray;
            this.txtAnguloC.Location = new System.Drawing.Point(610, 18);
            this.txtAnguloC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAnguloC.MaxLength = 4;
            this.txtAnguloC.Name = "txtAnguloC";
            this.txtAnguloC.ShortcutsEnabled = false;
            this.txtAnguloC.Size = new System.Drawing.Size(40, 24);
            this.txtAnguloC.TabIndex = 3;
            this.txtAnguloC.Text = "0°";
            this.txtAnguloC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAnguloC.Enter += new System.EventHandler(this.txtAnguloC_Enter);
            this.txtAnguloC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnguloC_KeyPress);
            this.txtAnguloC.Leave += new System.EventHandler(this.txtAnguloC_Leave);
            // 
            // tbServoC
            // 
            this.tbServoC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.tbServoC.Location = new System.Drawing.Point(154, 10);
            this.tbServoC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbServoC.Maximum = 110;
            this.tbServoC.Name = "tbServoC";
            this.tbServoC.Size = new System.Drawing.Size(455, 56);
            this.tbServoC.TabIndex = 2;
            this.tbServoC.TabStop = false;
            this.tbServoC.TickFrequency = 5;
            this.tbServoC.Scroll += new System.EventHandler(this.tbServoC_Scroll);
            // 
            // cPanelManualH
            // 
            this.cPanelManualH.Back = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.cPanelManualH.BackColor = System.Drawing.Color.Transparent;
            this.cPanelManualH.Controls.Add(this.lblServoH);
            this.cPanelManualH.Controls.Add(this.txtAnguloH);
            this.cPanelManualH.Controls.Add(this.tbServoH);
            this.cPanelManualH.Location = new System.Drawing.Point(6, 134);
            this.cPanelManualH.MatrixRound = 30;
            this.cPanelManualH.Name = "cPanelManualH";
            this.cPanelManualH.Size = new System.Drawing.Size(670, 69);
            this.cPanelManualH.TabIndex = 2;
            // 
            // lblServoH
            // 
            this.lblServoH.AutoSize = true;
            this.lblServoH.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServoH.ForeColor = System.Drawing.Color.LightGray;
            this.lblServoH.Location = new System.Drawing.Point(13, 21);
            this.lblServoH.Name = "lblServoH";
            this.lblServoH.Size = new System.Drawing.Size(133, 23);
            this.lblServoH.TabIndex = 1;
            this.lblServoH.Text = "Servo Hombro";
            this.lblServoH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAnguloH
            // 
            this.txtAnguloH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.txtAnguloH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAnguloH.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnguloH.ForeColor = System.Drawing.Color.LightGray;
            this.txtAnguloH.Location = new System.Drawing.Point(610, 18);
            this.txtAnguloH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAnguloH.MaxLength = 4;
            this.txtAnguloH.Name = "txtAnguloH";
            this.txtAnguloH.ShortcutsEnabled = false;
            this.txtAnguloH.Size = new System.Drawing.Size(40, 24);
            this.txtAnguloH.TabIndex = 3;
            this.txtAnguloH.Text = "0°";
            this.txtAnguloH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAnguloH.Enter += new System.EventHandler(this.txtAnguloH_Enter);
            this.txtAnguloH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnguloH_KeyPress);
            this.txtAnguloH.Leave += new System.EventHandler(this.txtAnguloH_Leave);
            // 
            // tbServoH
            // 
            this.tbServoH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.tbServoH.Location = new System.Drawing.Point(154, 10);
            this.tbServoH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbServoH.Maximum = 100;
            this.tbServoH.Name = "tbServoH";
            this.tbServoH.Size = new System.Drawing.Size(455, 56);
            this.tbServoH.TabIndex = 2;
            this.tbServoH.TabStop = false;
            this.tbServoH.TickFrequency = 5;
            this.tbServoH.Scroll += new System.EventHandler(this.tbServoH_Scroll);
            // 
            // tabRutina
            // 
            this.tabRutina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.tabRutina.Controls.Add(this.cmbRutinas);
            this.tabRutina.Controls.Add(this.cPanelA);
            this.tabRutina.Controls.Add(this.cPanel_Led);
            this.tabRutina.Controls.Add(this.lblSecuencia);
            this.tabRutina.Controls.Add(this.cPanelM);
            this.tabRutina.Controls.Add(this.cPanelEjecutar);
            this.tabRutina.Controls.Add(this.cPanelC);
            this.tabRutina.Controls.Add(this.cPanelH);
            this.tabRutina.Controls.Add(this.cPanelR);
            this.tabRutina.Controls.Add(this.btnEliminar);
            this.tabRutina.Controls.Add(this.btnCrearRutina);
            this.tabRutina.Location = new System.Drawing.Point(4, 25);
            this.tabRutina.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabRutina.Name = "tabRutina";
            this.tabRutina.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabRutina.Size = new System.Drawing.Size(676, 444);
            this.tabRutina.TabIndex = 1;
            this.tabRutina.Text = "tabPage2";
            // 
            // cmbRutinas
            // 
            this.cmbRutinas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.cmbRutinas.BorderColor = System.Drawing.Color.SeaGreen;
            this.cmbRutinas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRutinas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbRutinas.Font = new System.Drawing.Font("Open Sans Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRutinas.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cmbRutinas.FormattingEnabled = true;
            this.cmbRutinas.Location = new System.Drawing.Point(13, 55);
            this.cmbRutinas.Name = "cmbRutinas";
            this.cmbRutinas.Size = new System.Drawing.Size(349, 31);
            this.cmbRutinas.TabIndex = 7;
            this.cmbRutinas.TabStop = false;
            // 
            // cPanelA
            // 
            this.cPanelA.Back = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.cPanelA.BackColor = System.Drawing.Color.Transparent;
            this.cPanelA.Controls.Add(this.lblAnguloA);
            this.cPanelA.Controls.Add(this.lblAgarre);
            this.cPanelA.Location = new System.Drawing.Point(13, 390);
            this.cPanelA.MatrixRound = 30;
            this.cPanelA.Name = "cPanelA";
            this.cPanelA.Size = new System.Drawing.Size(278, 46);
            this.cPanelA.TabIndex = 19;
            // 
            // lblAnguloA
            // 
            this.lblAnguloA.AutoSize = true;
            this.lblAnguloA.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnguloA.ForeColor = System.Drawing.Color.LightGray;
            this.lblAnguloA.Location = new System.Drawing.Point(186, 10);
            this.lblAnguloA.Name = "lblAnguloA";
            this.lblAnguloA.Size = new System.Drawing.Size(47, 23);
            this.lblAnguloA.TabIndex = 2;
            this.lblAnguloA.Text = "180°";
            this.lblAnguloA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAgarre
            // 
            this.lblAgarre.AutoSize = true;
            this.lblAgarre.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgarre.ForeColor = System.Drawing.Color.LightGray;
            this.lblAgarre.Location = new System.Drawing.Point(36, 10);
            this.lblAgarre.Name = "lblAgarre";
            this.lblAgarre.Size = new System.Drawing.Size(63, 23);
            this.lblAgarre.TabIndex = 1;
            this.lblAgarre.Text = "Agarre";
            this.lblAgarre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cPanel_Led
            // 
            this.cPanel_Led.Back = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.cPanel_Led.BackColor = System.Drawing.Color.Transparent;
            this.cPanel_Led.Controls.Add(this.pbLed);
            this.cPanel_Led.Controls.Add(this.btnEncender);
            this.cPanel_Led.Controls.Add(this.lbl_Led);
            this.cPanel_Led.Location = new System.Drawing.Point(315, 330);
            this.cPanel_Led.Margin = new System.Windows.Forms.Padding(4);
            this.cPanel_Led.MatrixRound = 30;
            this.cPanel_Led.Name = "cPanel_Led";
            this.cPanel_Led.Size = new System.Drawing.Size(354, 106);
            this.cPanel_Led.TabIndex = 14;
            // 
            // pbLed
            // 
            this.pbLed.Image = global::BrazoRobóticoApp.Properties.Resources.led1;
            this.pbLed.Location = new System.Drawing.Point(241, 13);
            this.pbLed.Name = "pbLed";
            this.pbLed.Size = new System.Drawing.Size(88, 80);
            this.pbLed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLed.TabIndex = 21;
            this.pbLed.TabStop = false;
            // 
            // btnEncender
            // 
            this.btnEncender.BackColor = System.Drawing.Color.Transparent;
            this.btnEncender.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnEncender.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnEncender.BorderRadius = 30;
            this.btnEncender.BorderSize = 3;
            this.btnEncender.FlatAppearance.BorderSize = 0;
            this.btnEncender.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.btnEncender.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnEncender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncender.Font = new System.Drawing.Font("Open Sans Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncender.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEncender.Location = new System.Drawing.Point(20, 55);
            this.btnEncender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEncender.Name = "btnEncender";
            this.btnEncender.Size = new System.Drawing.Size(154, 34);
            this.btnEncender.TabIndex = 20;
            this.btnEncender.TabStop = false;
            this.btnEncender.Text = "Encender";
            this.btnEncender.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnEncender.UseVisualStyleBackColor = false;
            this.btnEncender.Click += new System.EventHandler(this.btnEncender_Click);
            // 
            // lbl_Led
            // 
            this.lbl_Led.AutoSize = true;
            this.lbl_Led.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Led.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Led.ForeColor = System.Drawing.Color.LightGray;
            this.lbl_Led.Location = new System.Drawing.Point(16, 14);
            this.lbl_Led.Name = "lbl_Led";
            this.lbl_Led.Size = new System.Drawing.Size(43, 23);
            this.lbl_Led.TabIndex = 1;
            this.lbl_Led.Text = "LED";
            // 
            // lblSecuencia
            // 
            this.lblSecuencia.AutoSize = true;
            this.lblSecuencia.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecuencia.ForeColor = System.Drawing.Color.LightGray;
            this.lblSecuencia.Location = new System.Drawing.Point(62, 115);
            this.lblSecuencia.Name = "lblSecuencia";
            this.lblSecuencia.Size = new System.Drawing.Size(179, 23);
            this.lblSecuencia.TabIndex = 11;
            this.lblSecuencia.Text = "Secuencia de Servos";
            this.lblSecuencia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cPanelM
            // 
            this.cPanelM.Back = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.cPanelM.BackColor = System.Drawing.Color.Transparent;
            this.cPanelM.Controls.Add(this.lblAnguloM);
            this.cPanelM.Controls.Add(this.lblMuñeca);
            this.cPanelM.Location = new System.Drawing.Point(13, 330);
            this.cPanelM.MatrixRound = 30;
            this.cPanelM.Name = "cPanelM";
            this.cPanelM.Size = new System.Drawing.Size(278, 46);
            this.cPanelM.TabIndex = 18;
            // 
            // lblAnguloM
            // 
            this.lblAnguloM.AutoSize = true;
            this.lblAnguloM.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnguloM.ForeColor = System.Drawing.Color.LightGray;
            this.lblAnguloM.Location = new System.Drawing.Point(186, 9);
            this.lblAnguloM.Name = "lblAnguloM";
            this.lblAnguloM.Size = new System.Drawing.Size(47, 23);
            this.lblAnguloM.TabIndex = 2;
            this.lblAnguloM.Text = "180°";
            this.lblAnguloM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMuñeca
            // 
            this.lblMuñeca.AutoSize = true;
            this.lblMuñeca.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMuñeca.ForeColor = System.Drawing.Color.LightGray;
            this.lblMuñeca.Location = new System.Drawing.Point(33, 9);
            this.lblMuñeca.Name = "lblMuñeca";
            this.lblMuñeca.Size = new System.Drawing.Size(72, 23);
            this.lblMuñeca.TabIndex = 1;
            this.lblMuñeca.Text = "Muñeca";
            this.lblMuñeca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cPanelEjecutar
            // 
            this.cPanelEjecutar.Back = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.cPanelEjecutar.BackColor = System.Drawing.Color.Transparent;
            this.cPanelEjecutar.Controls.Add(this.lblEstadoEjecucion);
            this.cPanelEjecutar.Controls.Add(this.pbEjecucion);
            this.cPanelEjecutar.Controls.Add(this.btnEjecutar);
            this.cPanelEjecutar.Controls.Add(this.lblProgreso);
            this.cPanelEjecutar.Location = new System.Drawing.Point(315, 150);
            this.cPanelEjecutar.Margin = new System.Windows.Forms.Padding(4);
            this.cPanelEjecutar.MatrixRound = 30;
            this.cPanelEjecutar.Name = "cPanelEjecutar";
            this.cPanelEjecutar.Size = new System.Drawing.Size(354, 166);
            this.cPanelEjecutar.TabIndex = 13;
            // 
            // lblEstadoEjecucion
            // 
            this.lblEstadoEjecucion.AutoSize = true;
            this.lblEstadoEjecucion.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoEjecucion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblEstadoEjecucion.Location = new System.Drawing.Point(23, 69);
            this.lblEstadoEjecucion.Name = "lblEstadoEjecucion";
            this.lblEstadoEjecucion.Size = new System.Drawing.Size(0, 23);
            this.lblEstadoEjecucion.TabIndex = 4;
            // 
            // pbEjecucion
            // 
            this.pbEjecucion.Location = new System.Drawing.Point(20, 125);
            this.pbEjecucion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbEjecucion.Name = "pbEjecucion";
            this.pbEjecucion.Size = new System.Drawing.Size(190, 11);
            this.pbEjecucion.Step = 1;
            this.pbEjecucion.TabIndex = 3;
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnEjecutar.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.btnEjecutar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(84)))), ((int)(((byte)(255)))));
            this.btnEjecutar.BorderRadius = 30;
            this.btnEjecutar.BorderSize = 0;
            this.btnEjecutar.FlatAppearance.BorderSize = 0;
            this.btnEjecutar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.btnEjecutar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnEjecutar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEjecutar.Font = new System.Drawing.Font("Open Sans Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjecutar.ForeColor = System.Drawing.Color.White;
            this.btnEjecutar.Location = new System.Drawing.Point(231, 112);
            this.btnEjecutar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(103, 34);
            this.btnEjecutar.TabIndex = 2;
            this.btnEjecutar.TabStop = false;
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.TextColor = System.Drawing.Color.White;
            this.btnEjecutar.UseVisualStyleBackColor = false;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // lblProgreso
            // 
            this.lblProgreso.AutoSize = true;
            this.lblProgreso.BackColor = System.Drawing.Color.Transparent;
            this.lblProgreso.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgreso.ForeColor = System.Drawing.Color.LightGray;
            this.lblProgreso.Location = new System.Drawing.Point(16, 16);
            this.lblProgreso.Name = "lblProgreso";
            this.lblProgreso.Size = new System.Drawing.Size(158, 23);
            this.lblProgreso.TabIndex = 1;
            this.lblProgreso.Text = "Control de Rutina";
            // 
            // cPanelC
            // 
            this.cPanelC.Back = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.cPanelC.BackColor = System.Drawing.Color.Transparent;
            this.cPanelC.Controls.Add(this.lblAnguloC);
            this.cPanelC.Controls.Add(this.lblCodo);
            this.cPanelC.Location = new System.Drawing.Point(13, 270);
            this.cPanelC.MatrixRound = 30;
            this.cPanelC.Name = "cPanelC";
            this.cPanelC.Size = new System.Drawing.Size(278, 46);
            this.cPanelC.TabIndex = 17;
            // 
            // lblAnguloC
            // 
            this.lblAnguloC.AutoSize = true;
            this.lblAnguloC.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnguloC.ForeColor = System.Drawing.Color.LightGray;
            this.lblAnguloC.Location = new System.Drawing.Point(186, 10);
            this.lblAnguloC.Name = "lblAnguloC";
            this.lblAnguloC.Size = new System.Drawing.Size(47, 23);
            this.lblAnguloC.TabIndex = 2;
            this.lblAnguloC.Text = "180°";
            this.lblAnguloC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCodo
            // 
            this.lblCodo.AutoSize = true;
            this.lblCodo.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodo.ForeColor = System.Drawing.Color.LightGray;
            this.lblCodo.Location = new System.Drawing.Point(41, 10);
            this.lblCodo.Name = "lblCodo";
            this.lblCodo.Size = new System.Drawing.Size(51, 23);
            this.lblCodo.TabIndex = 1;
            this.lblCodo.Text = "Codo";
            this.lblCodo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cPanelH
            // 
            this.cPanelH.Back = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.cPanelH.BackColor = System.Drawing.Color.Transparent;
            this.cPanelH.Controls.Add(this.lblAnguloH);
            this.cPanelH.Controls.Add(this.lblHombro);
            this.cPanelH.Location = new System.Drawing.Point(13, 210);
            this.cPanelH.MatrixRound = 30;
            this.cPanelH.Name = "cPanelH";
            this.cPanelH.Size = new System.Drawing.Size(278, 46);
            this.cPanelH.TabIndex = 16;
            // 
            // lblAnguloH
            // 
            this.lblAnguloH.AutoSize = true;
            this.lblAnguloH.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnguloH.ForeColor = System.Drawing.Color.LightGray;
            this.lblAnguloH.Location = new System.Drawing.Point(186, 10);
            this.lblAnguloH.Name = "lblAnguloH";
            this.lblAnguloH.Size = new System.Drawing.Size(47, 23);
            this.lblAnguloH.TabIndex = 2;
            this.lblAnguloH.Text = "180°";
            this.lblAnguloH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHombro
            // 
            this.lblHombro.AutoSize = true;
            this.lblHombro.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHombro.ForeColor = System.Drawing.Color.LightGray;
            this.lblHombro.Location = new System.Drawing.Point(31, 9);
            this.lblHombro.Name = "lblHombro";
            this.lblHombro.Size = new System.Drawing.Size(76, 23);
            this.lblHombro.TabIndex = 1;
            this.lblHombro.Text = "Hombro";
            this.lblHombro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cPanelR
            // 
            this.cPanelR.Back = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.cPanelR.BackColor = System.Drawing.Color.Transparent;
            this.cPanelR.Controls.Add(this.lblAnguloR);
            this.cPanelR.Controls.Add(this.lblRotacion);
            this.cPanelR.Location = new System.Drawing.Point(13, 150);
            this.cPanelR.MatrixRound = 30;
            this.cPanelR.Name = "cPanelR";
            this.cPanelR.Size = new System.Drawing.Size(278, 46);
            this.cPanelR.TabIndex = 15;
            // 
            // lblAnguloR
            // 
            this.lblAnguloR.AutoSize = true;
            this.lblAnguloR.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnguloR.ForeColor = System.Drawing.Color.LightGray;
            this.lblAnguloR.Location = new System.Drawing.Point(186, 10);
            this.lblAnguloR.Name = "lblAnguloR";
            this.lblAnguloR.Size = new System.Drawing.Size(47, 23);
            this.lblAnguloR.TabIndex = 2;
            this.lblAnguloR.Text = "180°";
            this.lblAnguloR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRotacion
            // 
            this.lblRotacion.AutoSize = true;
            this.lblRotacion.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRotacion.ForeColor = System.Drawing.Color.LightGray;
            this.lblRotacion.Location = new System.Drawing.Point(31, 10);
            this.lblRotacion.Name = "lblRotacion";
            this.lblRotacion.Size = new System.Drawing.Size(78, 23);
            this.lblRotacion.TabIndex = 1;
            this.lblRotacion.Text = "Rotación";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnEliminar.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.btnEliminar.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnEliminar.BorderRadius = 30;
            this.btnEliminar.BorderSize = 0;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Open Sans Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEliminar.Location = new System.Drawing.Point(390, 53);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(103, 34);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.TabStop = false;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCrearRutina
            // 
            this.btnCrearRutina.BackColor = System.Drawing.Color.Brown;
            this.btnCrearRutina.BackgroundColor = System.Drawing.Color.Brown;
            this.btnCrearRutina.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(84)))), ((int)(((byte)(255)))));
            this.btnCrearRutina.BorderRadius = 30;
            this.btnCrearRutina.BorderSize = 0;
            this.btnCrearRutina.FlatAppearance.BorderSize = 0;
            this.btnCrearRutina.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnCrearRutina.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnCrearRutina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearRutina.Font = new System.Drawing.Font("Open Sans Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearRutina.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCrearRutina.Location = new System.Drawing.Point(499, 53);
            this.btnCrearRutina.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCrearRutina.Name = "btnCrearRutina";
            this.btnCrearRutina.Size = new System.Drawing.Size(171, 34);
            this.btnCrearRutina.TabIndex = 8;
            this.btnCrearRutina.TabStop = false;
            this.btnCrearRutina.Text = "+ Crear Rutina";
            this.btnCrearRutina.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnCrearRutina.UseVisualStyleBackColor = false;
            this.btnCrearRutina.Click += new System.EventHandler(this.btnCrearRutina_Click);
            // 
            // cPanelConexion
            // 
            this.cPanelConexion.Back = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.cPanelConexion.BackColor = System.Drawing.Color.Transparent;
            this.cPanelConexion.Controls.Add(this.cPanelNavConexion);
            this.cPanelConexion.Controls.Add(this.cmbBaud);
            this.cPanelConexion.Controls.Add(this.cmbPuerto);
            this.cPanelConexion.Controls.Add(this.lblBaudRate);
            this.cPanelConexion.Controls.Add(this.lblPuerto);
            this.cPanelConexion.Controls.Add(this.picBoxLogo);
            this.cPanelConexion.Controls.Add(this.btnConectar);
            this.cPanelConexion.Controls.Add(this.pbConexion);
            this.cPanelConexion.Controls.Add(this.btnRefrescar);
            this.cPanelConexion.Controls.Add(this.lblEstado);
            this.cPanelConexion.Location = new System.Drawing.Point(12, 12);
            this.cPanelConexion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cPanelConexion.MatrixRound = 40;
            this.cPanelConexion.Name = "cPanelConexion";
            this.cPanelConexion.Size = new System.Drawing.Size(221, 494);
            this.cPanelConexion.TabIndex = 1;
            // 
            // cPanelNavConexion
            // 
            this.cPanelNavConexion.Back = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.cPanelNavConexion.BackColor = System.Drawing.Color.Transparent;
            this.cPanelNavConexion.Controls.Add(this.label2);
            this.cPanelNavConexion.Dock = System.Windows.Forms.DockStyle.Top;
            this.cPanelNavConexion.Location = new System.Drawing.Point(0, 0);
            this.cPanelNavConexion.MatrixRound = 40;
            this.cPanelNavConexion.Name = "cPanelNavConexion";
            this.cPanelNavConexion.Size = new System.Drawing.Size(221, 49);
            this.cPanelNavConexion.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(63, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Conexión";
            // 
            // cmbBaud
            // 
            this.cmbBaud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.cmbBaud.BorderColor = System.Drawing.Color.SeaGreen;
            this.cmbBaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBaud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBaud.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBaud.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cmbBaud.FormattingEnabled = true;
            this.cmbBaud.Location = new System.Drawing.Point(28, 167);
            this.cmbBaud.Name = "cmbBaud";
            this.cmbBaud.Size = new System.Drawing.Size(167, 28);
            this.cmbBaud.TabIndex = 43;
            // 
            // cmbPuerto
            // 
            this.cmbPuerto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.cmbPuerto.BorderColor = System.Drawing.Color.SeaGreen;
            this.cmbPuerto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPuerto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPuerto.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPuerto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cmbPuerto.FormattingEnabled = true;
            this.cmbPuerto.Location = new System.Drawing.Point(28, 95);
            this.cmbPuerto.Name = "cmbPuerto";
            this.cmbPuerto.Size = new System.Drawing.Size(167, 28);
            this.cmbPuerto.TabIndex = 42;
            // 
            // lblBaudRate
            // 
            this.lblBaudRate.AutoSize = true;
            this.lblBaudRate.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaudRate.ForeColor = System.Drawing.Color.LightGray;
            this.lblBaudRate.Location = new System.Drawing.Point(25, 144);
            this.lblBaudRate.Name = "lblBaudRate";
            this.lblBaudRate.Size = new System.Drawing.Size(86, 20);
            this.lblBaudRate.TabIndex = 4;
            this.lblBaudRate.Text = "Baud Rate";
            // 
            // lblPuerto
            // 
            this.lblPuerto.AutoSize = true;
            this.lblPuerto.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuerto.ForeColor = System.Drawing.Color.LightGray;
            this.lblPuerto.Location = new System.Drawing.Point(25, 72);
            this.lblPuerto.Name = "lblPuerto";
            this.lblPuerto.Size = new System.Drawing.Size(100, 20);
            this.lblPuerto.TabIndex = 2;
            this.lblPuerto.Text = "Puerto COM";
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.Image = global::BrazoRobóticoApp.Properties.Resources.brazoRb;
            this.picBoxLogo.Location = new System.Drawing.Point(67, 330);
            this.picBoxLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(95, 95);
            this.picBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxLogo.TabIndex = 41;
            this.picBoxLogo.TabStop = false;
            // 
            // btnConectar
            // 
            this.btnConectar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnConectar.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.btnConectar.BorderColor = System.Drawing.Color.Chartreuse;
            this.btnConectar.BorderRadius = 30;
            this.btnConectar.BorderSize = 0;
            this.btnConectar.FlatAppearance.BorderSize = 0;
            this.btnConectar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.btnConectar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnConectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConectar.Font = new System.Drawing.Font("Open Sans Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConectar.ForeColor = System.Drawing.Color.White;
            this.btnConectar.Location = new System.Drawing.Point(28, 223);
            this.btnConectar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(167, 34);
            this.btnConectar.TabIndex = 6;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.TextColor = System.Drawing.Color.White;
            this.btnConectar.UseVisualStyleBackColor = false;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // pbConexion
            // 
            this.pbConexion.Location = new System.Drawing.Point(29, 451);
            this.pbConexion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbConexion.Name = "pbConexion";
            this.pbConexion.Size = new System.Drawing.Size(167, 10);
            this.pbConexion.TabIndex = 8;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(84)))), ((int)(((byte)(255)))));
            this.btnRefrescar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(84)))), ((int)(((byte)(255)))));
            this.btnRefrescar.BorderColor = System.Drawing.Color.Chartreuse;
            this.btnRefrescar.BorderRadius = 30;
            this.btnRefrescar.BorderSize = 0;
            this.btnRefrescar.FlatAppearance.BorderSize = 0;
            this.btnRefrescar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumBlue;
            this.btnRefrescar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefrescar.Font = new System.Drawing.Font("Open Sans Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefrescar.ForeColor = System.Drawing.Color.White;
            this.btnRefrescar.Location = new System.Drawing.Point(28, 264);
            this.btnRefrescar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(167, 34);
            this.btnRefrescar.TabIndex = 7;
            this.btnRefrescar.Text = "Refrescar Puertos";
            this.btnRefrescar.TextColor = System.Drawing.Color.White;
            this.btnRefrescar.UseVisualStyleBackColor = false;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Open Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.LightGray;
            this.lblEstado.Location = new System.Drawing.Point(35, 471);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(156, 19);
            this.lblEstado.TabIndex = 9;
            this.lblEstado.Text = "Estado: Desconectado";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(995, 518);
            this.Controls.Add(this.cPanelControl);
            this.Controls.Add(this.cPanelConexion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de Brazo Robótico";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.cPanelControl.ResumeLayout(false);
            this.cPanelNav.ResumeLayout(false);
            this.cTabControlModo.ResumeLayout(false);
            this.tabManual.ResumeLayout(false);
            this.cPanelManualA.ResumeLayout(false);
            this.cPanelManualA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbServoA)).EndInit();
            this.cPanelManualR.ResumeLayout(false);
            this.cPanelManualR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbServoR)).EndInit();
            this.cPanelManualM.ResumeLayout(false);
            this.cPanelManualM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbServoM)).EndInit();
            this.cPanelManualC.ResumeLayout(false);
            this.cPanelManualC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbServoC)).EndInit();
            this.cPanelManualH.ResumeLayout(false);
            this.cPanelManualH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbServoH)).EndInit();
            this.tabRutina.ResumeLayout(false);
            this.tabRutina.PerformLayout();
            this.cPanelA.ResumeLayout(false);
            this.cPanelA.PerformLayout();
            this.cPanel_Led.ResumeLayout(false);
            this.cPanel_Led.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLed)).EndInit();
            this.cPanelM.ResumeLayout(false);
            this.cPanelM.PerformLayout();
            this.cPanelEjecutar.ResumeLayout(false);
            this.cPanelEjecutar.PerformLayout();
            this.cPanelC.ResumeLayout(false);
            this.cPanelC.PerformLayout();
            this.cPanelH.ResumeLayout(false);
            this.cPanelH.PerformLayout();
            this.cPanelR.ResumeLayout(false);
            this.cPanelR.PerformLayout();
            this.cPanelConexion.ResumeLayout(false);
            this.cPanelConexion.PerformLayout();
            this.cPanelNavConexion.ResumeLayout(false);
            this.cPanelNavConexion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label lblPuerto;
        private System.Windows.Forms.Label lblBaudRate;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label lblAgarre;
        private System.Windows.Forms.Label lblMuñeca;
        private System.Windows.Forms.Label lblCodo;
        private System.Windows.Forms.Label lblHombro;
        private System.Windows.Forms.Label lblRotacion;
        private System.Windows.Forms.PictureBox picBoxLogo;
        private System.Windows.Forms.Label lblSecuencia;
        private System.Windows.Forms.Label lblProgreso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Led;
        public System.Windows.Forms.ProgressBar pbConexion;
        public System.Windows.Forms.TrackBar tbServoR;
        public System.Windows.Forms.Label lblServoR;
        public System.Windows.Forms.TrackBar tbServoH;
        public System.Windows.Forms.Label lblServoH;
        public System.Windows.Forms.TrackBar tbServoA;
        public System.Windows.Forms.Label lblServoA;
        public System.Windows.Forms.TrackBar tbServoM;
        public System.Windows.Forms.Label lblServoM;
        public System.Windows.Forms.TrackBar tbServoC;
        public System.Windows.Forms.Label lblServoC;
        public System.Windows.Forms.TextBox txtAnguloA;
        public System.Windows.Forms.TextBox txtAnguloM;
        public System.Windows.Forms.TextBox txtAnguloC;
        public CustomControls.CustomBtn btnConectar;
        public CustomControls.CustomBtn btnRefrescar;
        public System.Windows.Forms.Label lblEstado;
        public CustomControls.CustomBtn btnRutina;
        public CustomControls.CustomBtn btnManual;
        public System.Windows.Forms.TextBox txtAnguloR;
        public System.Windows.Forms.TextBox txtAnguloH;
        public CustomControls.CustomBtn btnCrearRutina;
        public CustomControls.CustomBtn btnEjecutar;
        public System.Windows.Forms.ProgressBar pbEjecucion;
        private System.Windows.Forms.Label lblAnguloA;
        private System.Windows.Forms.Label lblAnguloM;
        private System.Windows.Forms.Label lblAnguloC;
        private System.Windows.Forms.Label lblAnguloH;
        private System.Windows.Forms.Label lblAnguloR;
        public CustomControls.CustomBtn btnEliminar;
        private CustomControls.CustomPanel cPanelConexion;
        private CustomControls.CustomPanel cPanelControl;
        private CustomControls.CustomPanel cPanelNav;
        private CustomControls.CustomTabControl cTabControlModo;
        private System.Windows.Forms.TabPage tabManual;
        private System.Windows.Forms.TabPage tabRutina;
        private CustomControls.CustomPanel cPanelEjecutar;
        private CustomControls.CustomPanel cPanel_Led;
        private CustomControls.CustomPanel cPanelManualR;
        private CustomControls.CustomCmb cmbBaud;
        private CustomControls.CustomCmb cmbPuerto;
        private CustomControls.CustomPanel cPanelManualA;
        private CustomControls.CustomPanel cPanelManualM;
        private CustomControls.CustomPanel cPanelManualC;
        private CustomControls.CustomPanel cPanelManualH;
        private CustomControls.CustomPanel cPanelA;
        private CustomControls.CustomPanel cPanelM;
        private CustomControls.CustomPanel cPanelC;
        private CustomControls.CustomPanel cPanelH;
        private CustomControls.CustomPanel cPanelR;
        private CustomControls.CustomPanel cPanelNavConexion;
        public CustomControls.CustomCmb cmbRutinas;
        private System.Windows.Forms.Label lblEstadoEjecucion;
        public CustomControls.CustomBtn btnEncender;
        private System.Windows.Forms.PictureBox pbLed;
    }
}

