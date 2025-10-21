namespace Laboratorio14
{
    partial class frmProductos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductos));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtId = new TextBox();
            txtNombre = new TextBox();
            txtPrecio = new TextBox();
            txtStock = new TextBox();
            btnSalir = new Button();
            tstId = new TextBox();
            tsbBuscar = new PictureBox();
            tsbNuevo = new PictureBox();
            tsbGuardar = new PictureBox();
            tsbCancelar = new PictureBox();
            tsbEliminar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)tsbBuscar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tsbNuevo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tsbGuardar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tsbCancelar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tsbEliminar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(207, 8);
            label1.Name = "label1";
            label1.Size = new Size(113, 25);
            label1.TabIndex = 0;
            label1.Text = "Busca por ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 106);
            label2.Name = "label2";
            label2.Size = new Size(28, 25);
            label2.TabIndex = 1;
            label2.Text = "Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(242, 109);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 2;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 191);
            label4.Name = "label4";
            label4.Size = new Size(60, 25);
            label4.TabIndex = 3;
            label4.Text = "Precio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(242, 191);
            label5.Name = "label5";
            label5.Size = new Size(55, 25);
            label5.TabIndex = 4;
            label5.Text = "Stock";
            // 
            // txtId
            // 
            txtId.Location = new Point(28, 134);
            txtId.Name = "txtId";
            txtId.Size = new Size(118, 31);
            txtId.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(242, 137);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(499, 31);
            txtNombre.TabIndex = 6;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(28, 219);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(150, 31);
            txtPrecio.TabIndex = 7;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(242, 219);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(150, 31);
            txtStock.TabIndex = 8;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(28, 281);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(147, 50);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // tstId
            // 
            tstId.BorderStyle = BorderStyle.None;
            tstId.Location = new Point(326, 9);
            tstId.Name = "tstId";
            tstId.Size = new Size(150, 24);
            tstId.TabIndex = 10;
            // 
            // tsbBuscar
            // 
            tsbBuscar.Image = (Image)resources.GetObject("tsbBuscar.Image");
            tsbBuscar.Location = new Point(482, 8);
            tsbBuscar.Name = "tsbBuscar";
            tsbBuscar.Size = new Size(25, 25);
            tsbBuscar.SizeMode = PictureBoxSizeMode.Zoom;
            tsbBuscar.TabIndex = 11;
            tsbBuscar.TabStop = false;
            tsbBuscar.Click += tsbBuscar_Click;
            // 
            // tsbNuevo
            // 
            tsbNuevo.Image = (Image)resources.GetObject("tsbNuevo.Image");
            tsbNuevo.Location = new Point(28, 9);
            tsbNuevo.Name = "tsbNuevo";
            tsbNuevo.Size = new Size(25, 25);
            tsbNuevo.SizeMode = PictureBoxSizeMode.Zoom;
            tsbNuevo.TabIndex = 12;
            tsbNuevo.TabStop = false;
            tsbNuevo.Click += tsbNuevo_Click;
            // 
            // tsbGuardar
            // 
            tsbGuardar.Image = (Image)resources.GetObject("tsbGuardar.Image");
            tsbGuardar.Location = new Point(59, 9);
            tsbGuardar.Name = "tsbGuardar";
            tsbGuardar.Size = new Size(25, 25);
            tsbGuardar.SizeMode = PictureBoxSizeMode.Zoom;
            tsbGuardar.TabIndex = 13;
            tsbGuardar.TabStop = false;
            tsbGuardar.Click += tsbGuardar_Click;
            // 
            // tsbCancelar
            // 
            tsbCancelar.Image = (Image)resources.GetObject("tsbCancelar.Image");
            tsbCancelar.Location = new Point(90, 9);
            tsbCancelar.Name = "tsbCancelar";
            tsbCancelar.Size = new Size(25, 25);
            tsbCancelar.SizeMode = PictureBoxSizeMode.Zoom;
            tsbCancelar.TabIndex = 14;
            tsbCancelar.TabStop = false;
            tsbCancelar.Click += tsbCancelar_Click;
            // 
            // tsbEliminar
            // 
            tsbEliminar.Image = (Image)resources.GetObject("tsbEliminar.Image");
            tsbEliminar.Location = new Point(121, 9);
            tsbEliminar.Name = "tsbEliminar";
            tsbEliminar.Size = new Size(25, 25);
            tsbEliminar.SizeMode = PictureBoxSizeMode.Zoom;
            tsbEliminar.TabIndex = 15;
            tsbEliminar.TabStop = false;
            tsbEliminar.Click += tsbEliminar_Click;
            // 
            // frmProductos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tsbEliminar);
            Controls.Add(tsbCancelar);
            Controls.Add(tsbGuardar);
            Controls.Add(tsbNuevo);
            Controls.Add(tsbBuscar);
            Controls.Add(tstId);
            Controls.Add(btnSalir);
            Controls.Add(txtStock);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombre);
            Controls.Add(txtId);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmProductos";
            Text = "Productos";
            Load += frmProductos_Load;
            ((System.ComponentModel.ISupportInitialize)tsbBuscar).EndInit();
            ((System.ComponentModel.ISupportInitialize)tsbNuevo).EndInit();
            ((System.ComponentModel.ISupportInitialize)tsbGuardar).EndInit();
            ((System.ComponentModel.ISupportInitialize)tsbCancelar).EndInit();
            ((System.ComponentModel.ISupportInitialize)tsbEliminar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtId;
        private TextBox txtNombre;
        private TextBox txtPrecio;
        private TextBox txtStock;
        private Button btnSalir;
        private TextBox tstId;
        private PictureBox tsbBuscar;
        private PictureBox tsbNuevo;
        private PictureBox tsbGuardar;
        private PictureBox tsbCancelar;
        private PictureBox tsbEliminar;
    }
}
