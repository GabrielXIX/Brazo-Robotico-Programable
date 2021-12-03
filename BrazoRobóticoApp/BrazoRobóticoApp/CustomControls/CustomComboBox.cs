using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using System.Drawing.Design;

namespace BrazoRobóticoApp.CustomControls
{
    [DefaultEvent("OnSelectedIndexChanged")]
    class CustomComboBox : UserControl
    {
        //Variables globales para apariencia
        private Color backColor = Color.WhiteSmoke;
        private Color iconColor = Color.MediumSlateBlue;
        private Color listBackColor = Color.FromArgb(230, 228, 245);
        private Color listTextColor = Color.DimGray;
        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 1;

        //Elementos del comboBoxx personalizado
        private ComboBox cmbList;
        private Label lblText;
        private Button btnIcon;

        //Propiedades
        //Apariencia
        [Category("Custom Controls - Apariencia")]
        public new Color BackColor 
        {
            get 
            { 
                return backColor;
            }
            set 
            {
                backColor = value;
                lblText.BackColor = backColor;
                btnIcon.BackColor = backColor;
            }
        }

        [Category("Custom Controls - Apariencia")]
        public Color IconColor 
        {             
            get
            {
                return iconColor;
            }
            set
            {
                iconColor = value;
                btnIcon.Invalidate(); //Redibujar icono
            }
        }

        [Category("Custom Controls - Apariencia")]
        public Color ListBackColor 
        { 
            get
            {
                return listBackColor;
            }
            set
            {
                listBackColor = value;
                cmbList.BackColor = listBackColor;
            }
        }

        [Category("Custom Controls - Apariencia")]
        public Color ListTextColor 
        { 
            get
            {
                return listTextColor;
            }
            set
            {
                listTextColor = value;
                cmbList.ForeColor = listTextColor;
            }
        }

        [Category("Custom Controls - Apariencia")]
        public Color BorderColor 
        { 
            get
            {
                return borderColor;
            }
            set
            {
                borderColor = value;
                base.BackColor = borderColor; //Color de borde
            }
        }

        [Category("Custom Controls - Apariencia")]
        public int BorderSize 
        { 
            get
            {
                return borderSize;
            }
            set
            {
                borderSize = value;
                this.Padding = new Padding(borderSize); //Tamaño de borde
                AdjustComboBoxDimensions(); 
            }
        }

        //Se anula la propiedad ForeColor
        [Category("Custom Controls - Apariencia")]
        public override Color ForeColor 
        {
            get 
            {
                return base.ForeColor;
            }
            set 
            {
                base.ForeColor = value;
                lblText.ForeColor = value;
            }
        }

        //Se anula la propiedad Font
        [Category("Custom Controls - Apariencia")]
        public override Font Font
        {
            get
            {
                return base.Font;
            }
            set
            {
                base.Font = value;
                lblText.Font = value;
                cmbList.Font = value; //opcional
            }
        }

        //Propiedad de texto
        [Category("Custom Controls - Apariencia")]
        public string Texts
        {
            get { return lblText.Text; }
            set { lblText.Text = value; }
        }

        //Propiedad para cambiar el estio despleable
        [Category("Custom Controls - Apariencia")]
        public ComboBoxStyle DropDownStyle
        {
            get { return cmbList.DropDownStyle; }
            set 
            { 
                if(cmbList.DropDownStyle != ComboBoxStyle.Simple)
                    cmbList.DropDownStyle = value;
            }
        }

        //Datos
        [Category("Custom Controls - Datos")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [Localizable(true)]
        [MergableProperty(false)]
        public ComboBox.ObjectCollection Items 
        {
            get{ return cmbList.Items; }
        }

        [Category("Custom Controls - Datos")]
        [AttributeProvider(typeof(IListSource))]
        [DefaultValue(null)]
        [RefreshProperties(RefreshProperties.Repaint)]
        public object DataSource 
        {
            get { return cmbList.DataSource; }
            set { cmbList.DataSource = value; }
        }

        [Category("Custom Controls - Datos")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Localizable(true)]
        public AutoCompleteStringCollection AutoCompleteCustomSource 
        {
            get { return cmbList.AutoCompleteCustomSource; }
            set { cmbList.AutoCompleteCustomSource = value; }
        }

        [Category("Custom Controls - Datos")]
        [Browsable(true)]
        [DefaultValue(AutoCompleteSource.None)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteSource AutoCompleteSource 
        {
            get { return cmbList.AutoCompleteSource; }
            set { cmbList.AutoCompleteSource = value; } 
        }

        [Category("Custom Controls - Datos")]
        [Browsable(true)]
        [DefaultValue(AutoCompleteMode.None)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteMode AutoCompleteMode 
        {
            get { return cmbList.AutoCompleteMode; }
            set { cmbList.AutoCompleteMode = value; }
        }

        [Category("Custom Controls - Datos")]
        [Bindable(true)]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public object SelectedItem 
        {
            get { return cmbList.SelectedItem; }
            set { cmbList.SelectedItem = value; }
        }

        [Category("Custom Controls - Datos")]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int SelectedIndex 
        {
            get { return cmbList.SelectedIndex; }
            set { cmbList.SelectedIndex = value; }
        }

        //Campos de eventos
        public event EventHandler OnSelectedIndexChanged; //Evento predetermidado

        //Constructor
        public CustomComboBox()
        {
            cmbList = new ComboBox();
            lblText = new Label();
            btnIcon = new Button();
            this.SuspendLayout();

            //ComboBox: DropDown List
            cmbList.BackColor = listBackColor;
            cmbList.Font = new Font(this.Font.Name, 10F);
            cmbList.ForeColor = listTextColor;
            cmbList.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged); //Evento predeterminado
            cmbList.TextChanged += new EventHandler(ComboBox_TextChanged); //Refrescar Texto

            //Botón: Ícono
            btnIcon.Dock = DockStyle.Right;
            btnIcon.FlatStyle = FlatStyle.Flat;
            btnIcon.FlatAppearance.BorderSize = 0;
            btnIcon.BackColor = backColor;
            btnIcon.Size = new Size(30, 30);
            btnIcon.Cursor = Cursors.Hand;          
            btnIcon.Click += new EventHandler(Icon_Click); //Abrir dropdown list
            btnIcon.Paint += new PaintEventHandler(Icon_Paint); //Dibujar ícono

            //Label : Texto
            lblText.Dock = DockStyle.Fill;
            lblText.AutoSize = false;
            lblText.BackColor = backColor;
            lblText.TextAlign = ContentAlignment.MiddleLeft;
            lblText.Padding = new Padding(4, 0, 0, 0);
            lblText.Font = new Font(this.Font.Name, 10F);

            //Vinculación de eventos de label al evento de control de usuario
            lblText.Click += new EventHandler(Surface_Click); //Seleccionar Combo Box
            lblText.MouseEnter += new EventHandler(Surface_MouseEnter);
            lblText.MouseLeave += new EventHandler(Surface_MouseLeave);

            //Control de usuario
            this.Controls.Add(lblText); //2
            this.Controls.Add(btnIcon); //1
            this.Controls.Add(cmbList); //0
            this.MinimumSize = new Size(80, 30);
            this.Size = new Size(200, 30);
            this.ForeColor = Color.DimGray;
            this.Padding = new Padding(borderSize); //Tamaño de borde
            base.BackColor = borderColor; //Color de borde
            this.ResumeLayout();
            AdjustComboBoxDimensions();
        }        

        //Métodos privados
        private void AdjustComboBoxDimensions()
        {
            cmbList.Width = lblText.Width;
            cmbList.Location = new Point()
            {
                X = this.Width - this.Padding.Right - cmbList.Width,
                Y = lblText.Bottom - cmbList.Height
            };
        }

        //Métodos de evento

        //Evento Predeterminado
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OnSelectedIndexChanged != null)
                OnSelectedIndexChanged.Invoke(sender, e);

            //Refrescar texto
            lblText.Text = cmbList.Text;
        }

        //Dibujar ícono
        private void Icon_Paint(object sender, PaintEventArgs e)
        {
            //Campos
            int iconWidht = 14;
            int iconHeight = 6;
            var rectIcon = new Rectangle((btnIcon.Width - iconWidht) / 2, 
                (btnIcon.Height - iconHeight) / 2, iconWidht, iconHeight);
            Graphics graph = e.Graphics;

            //Dibujar ícono de flecha 
            using (GraphicsPath path = new GraphicsPath())
            using (Pen pen = new Pen(iconColor, 2))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                path.AddLine(rectIcon.X, rectIcon.Y, rectIcon.X + (iconWidht / 2), rectIcon.Bottom);
                path.AddLine(rectIcon.X + (iconWidht / 2), rectIcon.Bottom, rectIcon.Right, rectIcon.Y);
                graph.DrawPath(pen, path);
            } 
        }

        //Acciones del elemento
        private void Icon_Click(object sender, EventArgs e)
        {
            //Abrir dropdown list
            cmbList.Select();
            cmbList.DroppedDown = true;
        }
        private void Surface_Click(object sender, EventArgs e)
        {
            this.OnClick(e);

            //Selecciona combo box
            cmbList.Select();
            if (cmbList.DropDownStyle == ComboBoxStyle.DropDownList)
                cmbList.DroppedDown = true; //Abrir dropdown list
        }
        private void ComboBox_TextChanged(object sender, EventArgs e)
        {
            //Refrescar texto
            lblText.Text = cmbList.Text;
        }

        //Vinculación de eventos de label al evento de control de usuario
        private void Surface_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        private void Surface_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }
        //::::+

        //Métodos de evento redimensionado
        //protected override void OnResize(EventArgs e)
        //{
        //    base.OnResize(e);
        //    AdjustComboBoxDimensions();
        //}
    }
}
