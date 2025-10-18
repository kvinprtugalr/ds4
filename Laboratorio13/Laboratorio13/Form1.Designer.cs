namespace Laboratorio13
{
    partial class Form1
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
            btnConectarSQL = new Button();
            listProducts = new ListBox();
            SuspendLayout();
            // 
            // btnConectarSQL
            // 
            btnConectarSQL.Location = new Point(242, 74);
            btnConectarSQL.Name = "btnConectarSQL";
            btnConectarSQL.Size = new Size(255, 100);
            btnConectarSQL.TabIndex = 0;
            btnConectarSQL.Text = "Conectar y desconectar de SQL Server";
            btnConectarSQL.UseVisualStyleBackColor = true;
            btnConectarSQL.Click += btnConectarSQL_Click;
            // 
            // listProducts
            // 
            listProducts.FormattingEnabled = true;
            listProducts.ItemHeight = 25;
            listProducts.Location = new Point(242, 207);
            listProducts.Name = "listProducts";
            listProducts.Size = new Size(255, 129);
            listProducts.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listProducts);
            Controls.Add(btnConectarSQL);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnConectarSQL;
        private ListBox listProducts;
    }
}
