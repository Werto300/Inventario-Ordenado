namespace Inventario
{
    partial class Form1
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.txtEliminar = new System.Windows.Forms.TextBox();
            this.txtCodigoAg = new System.Windows.Forms.TextBox();
            this.txtNombreAg = new System.Windows.Forms.TextBox();
            this.txtCantidadAg = new System.Windows.Forms.TextBox();
            this.txtPrecioAg = new System.Windows.Forms.TextBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.txtInsertar = new System.Windows.Forms.TextBox();
            this.txtReporte = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(13, 13);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(13, 42);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.Location = new System.Drawing.Point(12, 97);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(75, 23);
            this.btnBusqueda.TabIndex = 2;
            this.btnBusqueda.Text = "Busqueda";
            this.btnBusqueda.UseVisualStyleBackColor = true;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(12, 152);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(75, 23);
            this.btnReporte.TabIndex = 3;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(13, 181);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 4;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // txtEliminar
            // 
            this.txtEliminar.Location = new System.Drawing.Point(13, 71);
            this.txtEliminar.Name = "txtEliminar";
            this.txtEliminar.Size = new System.Drawing.Size(74, 20);
            this.txtEliminar.TabIndex = 7;
            // 
            // txtCodigoAg
            // 
            this.txtCodigoAg.Location = new System.Drawing.Point(95, 13);
            this.txtCodigoAg.Name = "txtCodigoAg";
            this.txtCodigoAg.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoAg.TabIndex = 8;
            // 
            // txtNombreAg
            // 
            this.txtNombreAg.Location = new System.Drawing.Point(201, 12);
            this.txtNombreAg.Name = "txtNombreAg";
            this.txtNombreAg.Size = new System.Drawing.Size(100, 20);
            this.txtNombreAg.TabIndex = 9;
            // 
            // txtCantidadAg
            // 
            this.txtCantidadAg.Location = new System.Drawing.Point(307, 12);
            this.txtCantidadAg.Name = "txtCantidadAg";
            this.txtCantidadAg.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadAg.TabIndex = 10;
            // 
            // txtPrecioAg
            // 
            this.txtPrecioAg.Location = new System.Drawing.Point(413, 12);
            this.txtPrecioAg.Name = "txtPrecioAg";
            this.txtPrecioAg.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioAg.TabIndex = 11;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(12, 126);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(75, 20);
            this.txtBusqueda.TabIndex = 12;
            // 
            // txtInsertar
            // 
            this.txtInsertar.Location = new System.Drawing.Point(13, 210);
            this.txtInsertar.Name = "txtInsertar";
            this.txtInsertar.Size = new System.Drawing.Size(75, 20);
            this.txtInsertar.TabIndex = 13;
            // 
            // txtReporte
            // 
            this.txtReporte.Location = new System.Drawing.Point(95, 42);
            this.txtReporte.Multiline = true;
            this.txtReporte.Name = "txtReporte";
            this.txtReporte.Size = new System.Drawing.Size(420, 188);
            this.txtReporte.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 246);
            this.Controls.Add(this.txtReporte);
            this.Controls.Add(this.txtInsertar);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.txtPrecioAg);
            this.Controls.Add(this.txtCantidadAg);
            this.Controls.Add(this.txtNombreAg);
            this.Controls.Add(this.txtCodigoAg);
            this.Controls.Add(this.txtEliminar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnBusqueda);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Name = "Form1";
            this.Text = "Inventario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.TextBox txtEliminar;
        private System.Windows.Forms.TextBox txtCodigoAg;
        private System.Windows.Forms.TextBox txtNombreAg;
        private System.Windows.Forms.TextBox txtCantidadAg;
        private System.Windows.Forms.TextBox txtPrecioAg;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.TextBox txtInsertar;
        private System.Windows.Forms.TextBox txtReporte;
    }
}

