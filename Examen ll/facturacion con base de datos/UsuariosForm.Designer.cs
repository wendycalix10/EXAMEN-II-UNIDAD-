namespace facturacion_con_base_de_datos
{
    partial class UsuariosForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.codigotextBox = new System.Windows.Forms.TextBox();
            this.nombretextBox = new System.Windows.Forms.TextBox();
            this.contraseñatextBox = new System.Windows.Forms.TextBox();
            this.correotextBox = new System.Windows.Forms.TextBox();
            this.rolcomboBox = new System.Windows.Forms.ComboBox();
            this.estaactivocheckBox = new System.Windows.Forms.CheckBox();
            this.buscarimagenbutton = new System.Windows.Forms.Button();
            this.fotopictureBox = new System.Windows.Forms.PictureBox();
            this.modificarbutton = new System.Windows.Forms.Button();
            this.guardarbutton = new System.Windows.Forms.Button();
            this.eliminarbutton = new System.Windows.Forms.Button();
            this.cancelarbutton = new System.Windows.Forms.Button();
            this.nuevobutton = new System.Windows.Forms.Button();
            this.usuariosdataGridView = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fotopictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Estado Activo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Rol:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Correo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Contraseña:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Codigo:";
            // 
            // codigotextBox
            // 
            this.codigotextBox.Enabled = false;
            this.codigotextBox.Location = new System.Drawing.Point(140, 23);
            this.codigotextBox.Name = "codigotextBox";
            this.codigotextBox.Size = new System.Drawing.Size(237, 22);
            this.codigotextBox.TabIndex = 1;
            // 
            // nombretextBox
            // 
            this.nombretextBox.Enabled = false;
            this.nombretextBox.Location = new System.Drawing.Point(140, 51);
            this.nombretextBox.Name = "nombretextBox";
            this.nombretextBox.Size = new System.Drawing.Size(237, 22);
            this.nombretextBox.TabIndex = 3;
            // 
            // contraseñatextBox
            // 
            this.contraseñatextBox.Enabled = false;
            this.contraseñatextBox.Location = new System.Drawing.Point(140, 79);
            this.contraseñatextBox.Name = "contraseñatextBox";
            this.contraseñatextBox.Size = new System.Drawing.Size(237, 22);
            this.contraseñatextBox.TabIndex = 5;
            // 
            // correotextBox
            // 
            this.correotextBox.Enabled = false;
            this.correotextBox.Location = new System.Drawing.Point(140, 107);
            this.correotextBox.Name = "correotextBox";
            this.correotextBox.Size = new System.Drawing.Size(237, 22);
            this.correotextBox.TabIndex = 7;
            // 
            // rolcomboBox
            // 
            this.rolcomboBox.Enabled = false;
            this.rolcomboBox.FormattingEnabled = true;
            this.rolcomboBox.Items.AddRange(new object[] {
            "Administrador",
            "Usuario"});
            this.rolcomboBox.Location = new System.Drawing.Point(140, 135);
            this.rolcomboBox.Name = "rolcomboBox";
            this.rolcomboBox.Size = new System.Drawing.Size(237, 24);
            this.rolcomboBox.TabIndex = 9;
            // 
            // estaactivocheckBox
            // 
            this.estaactivocheckBox.AutoSize = true;
            this.estaactivocheckBox.Enabled = false;
            this.estaactivocheckBox.Location = new System.Drawing.Point(140, 171);
            this.estaactivocheckBox.Name = "estaactivocheckBox";
            this.estaactivocheckBox.Size = new System.Drawing.Size(18, 17);
            this.estaactivocheckBox.TabIndex = 11;
            this.estaactivocheckBox.UseVisualStyleBackColor = true;
            // 
            // buscarimagenbutton
            // 
            this.buscarimagenbutton.Enabled = false;
            this.buscarimagenbutton.Location = new System.Drawing.Point(556, 121);
            this.buscarimagenbutton.Name = "buscarimagenbutton";
            this.buscarimagenbutton.Size = new System.Drawing.Size(34, 27);
            this.buscarimagenbutton.TabIndex = 18;
            this.buscarimagenbutton.Text = "...";
            this.buscarimagenbutton.UseVisualStyleBackColor = true;
            this.buscarimagenbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // fotopictureBox
            // 
            this.fotopictureBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.fotopictureBox.Enabled = false;
            this.fotopictureBox.Location = new System.Drawing.Point(400, 23);
            this.fotopictureBox.Name = "fotopictureBox";
            this.fotopictureBox.Size = new System.Drawing.Size(150, 125);
            this.fotopictureBox.TabIndex = 19;
            this.fotopictureBox.TabStop = false;
            // 
            // modificarbutton
            // 
            this.modificarbutton.Enabled = false;
            this.modificarbutton.Location = new System.Drawing.Point(236, 201);
            this.modificarbutton.Name = "modificarbutton";
            this.modificarbutton.Size = new System.Drawing.Size(90, 36);
            this.modificarbutton.TabIndex = 13;
            this.modificarbutton.Text = "Modificar";
            this.modificarbutton.UseVisualStyleBackColor = true;
            this.modificarbutton.Click += new System.EventHandler(this.modificarbutton_Click);
            // 
            // guardarbutton
            // 
            this.guardarbutton.Enabled = false;
            this.guardarbutton.Location = new System.Drawing.Point(333, 201);
            this.guardarbutton.Name = "guardarbutton";
            this.guardarbutton.Size = new System.Drawing.Size(90, 36);
            this.guardarbutton.TabIndex = 14;
            this.guardarbutton.Text = "Guardar";
            this.guardarbutton.UseVisualStyleBackColor = true;
            this.guardarbutton.Click += new System.EventHandler(this.guardarbutton_Click);
            // 
            // eliminarbutton
            // 
            this.eliminarbutton.Enabled = false;
            this.eliminarbutton.Location = new System.Drawing.Point(429, 201);
            this.eliminarbutton.Name = "eliminarbutton";
            this.eliminarbutton.Size = new System.Drawing.Size(90, 36);
            this.eliminarbutton.TabIndex = 15;
            this.eliminarbutton.Text = "Eliminar";
            this.eliminarbutton.UseVisualStyleBackColor = true;
            // 
            // cancelarbutton
            // 
            this.cancelarbutton.Enabled = false;
            this.cancelarbutton.Location = new System.Drawing.Point(525, 201);
            this.cancelarbutton.Name = "cancelarbutton";
            this.cancelarbutton.Size = new System.Drawing.Size(90, 36);
            this.cancelarbutton.TabIndex = 16;
            this.cancelarbutton.Text = "Cancelar";
            this.cancelarbutton.UseVisualStyleBackColor = true;
            this.cancelarbutton.Click += new System.EventHandler(this.cancelarbutton_Click);
            // 
            // nuevobutton
            // 
            this.nuevobutton.Location = new System.Drawing.Point(140, 201);
            this.nuevobutton.Name = "nuevobutton";
            this.nuevobutton.Size = new System.Drawing.Size(90, 36);
            this.nuevobutton.TabIndex = 12;
            this.nuevobutton.Text = "Nuevo";
            this.nuevobutton.UseVisualStyleBackColor = true;
            this.nuevobutton.Click += new System.EventHandler(this.nuevobutton_Click);
            // 
            // usuariosdataGridView
            // 
            this.usuariosdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usuariosdataGridView.Location = new System.Drawing.Point(15, 243);
            this.usuariosdataGridView.Name = "usuariosdataGridView";
            this.usuariosdataGridView.RowHeadersWidth = 51;
            this.usuariosdataGridView.RowTemplate.Height = 24;
            this.usuariosdataGridView.Size = new System.Drawing.Size(632, 170);
            this.usuariosdataGridView.TabIndex = 17;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UsuariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 422);
            this.Controls.Add(this.usuariosdataGridView);
            this.Controls.Add(this.nuevobutton);
            this.Controls.Add(this.cancelarbutton);
            this.Controls.Add(this.eliminarbutton);
            this.Controls.Add(this.guardarbutton);
            this.Controls.Add(this.modificarbutton);
            this.Controls.Add(this.buscarimagenbutton);
            this.Controls.Add(this.fotopictureBox);
            this.Controls.Add(this.estaactivocheckBox);
            this.Controls.Add(this.rolcomboBox);
            this.Controls.Add(this.correotextBox);
            this.Controls.Add(this.contraseñatextBox);
            this.Controls.Add(this.nombretextBox);
            this.Controls.Add(this.codigotextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Name = "UsuariosForm";
            this.Text = "UsuariosForm";
            this.Load += new System.EventHandler(this.UsuariosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fotopictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox codigotextBox;
        private System.Windows.Forms.TextBox nombretextBox;
        private System.Windows.Forms.TextBox contraseñatextBox;
        private System.Windows.Forms.TextBox correotextBox;
        private System.Windows.Forms.ComboBox rolcomboBox;
        private System.Windows.Forms.CheckBox estaactivocheckBox;
        private System.Windows.Forms.PictureBox fotopictureBox;
        private System.Windows.Forms.Button buscarimagenbutton;
        private System.Windows.Forms.Button modificarbutton;
        private System.Windows.Forms.Button guardarbutton;
        private System.Windows.Forms.Button eliminarbutton;
        private System.Windows.Forms.Button cancelarbutton;
        private System.Windows.Forms.Button nuevobutton;
        private System.Windows.Forms.DataGridView usuariosdataGridView;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}