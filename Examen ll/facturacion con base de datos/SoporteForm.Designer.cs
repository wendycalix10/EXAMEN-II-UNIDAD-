using System;

namespace facturacion_con_base_de_datos
{
    partial class RevisarTicketForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.usuariotextBox = new System.Windows.Forms.TextBox();
            this.clientetextBox = new System.Windows.Forms.TextBox();
            this.tiposoportecomboBox = new System.Windows.Forms.ComboBox();
            this.modificarbutton = new System.Windows.Forms.Button();
            this.guardarbutton = new System.Windows.Forms.Button();
            this.eliminarbutton = new System.Windows.Forms.Button();
            this.cancelarbutton = new System.Windows.Forms.Button();
            this.nuevobutton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.respuestatextBox = new System.Windows.Forms.TextBox();
            this.solicitudtextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.impuestotextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.totaltextBox = new System.Windows.Forms.TextBox();
            this.descuentotextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.preciotextBox = new System.Windows.Forms.TextBox();
            this.fotopictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotopictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1, 162);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tipo de soporte:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Usuario:";
            // 
            // usuariotextBox
            // 
            this.usuariotextBox.Enabled = false;
            this.usuariotextBox.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuariotextBox.Location = new System.Drawing.Point(224, 84);
            this.usuariotextBox.Margin = new System.Windows.Forms.Padding(4);
            this.usuariotextBox.Name = "usuariotextBox";
            this.usuariotextBox.Size = new System.Drawing.Size(398, 30);
            this.usuariotextBox.TabIndex = 1;
            this.usuariotextBox.TextChanged += new System.EventHandler(this.usuariotextBox_TextChanged);
            // 
            // clientetextBox
            // 
            this.clientetextBox.Enabled = false;
            this.clientetextBox.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientetextBox.Location = new System.Drawing.Point(224, 124);
            this.clientetextBox.Margin = new System.Windows.Forms.Padding(4);
            this.clientetextBox.Name = "clientetextBox";
            this.clientetextBox.Size = new System.Drawing.Size(398, 30);
            this.clientetextBox.TabIndex = 3;
            // 
            // tiposoportecomboBox
            // 
            this.tiposoportecomboBox.Enabled = false;
            this.tiposoportecomboBox.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiposoportecomboBox.FormattingEnabled = true;
            this.tiposoportecomboBox.Items.AddRange(new object[] {
            "Soporte de nivel 1",
            "Soporte de nivel 2 ",
            "Soporte de nivel 3"});
            this.tiposoportecomboBox.Location = new System.Drawing.Point(224, 164);
            this.tiposoportecomboBox.Margin = new System.Windows.Forms.Padding(4);
            this.tiposoportecomboBox.Name = "tiposoportecomboBox";
            this.tiposoportecomboBox.Size = new System.Drawing.Size(398, 32);
            this.tiposoportecomboBox.TabIndex = 9;
            // 
            // modificarbutton
            // 
            this.modificarbutton.Enabled = false;
            this.modificarbutton.Location = new System.Drawing.Point(709, 263);
            this.modificarbutton.Margin = new System.Windows.Forms.Padding(4);
            this.modificarbutton.Name = "modificarbutton";
            this.modificarbutton.Size = new System.Drawing.Size(123, 27);
            this.modificarbutton.TabIndex = 13;
            this.modificarbutton.Text = "Modificar";
            this.modificarbutton.UseVisualStyleBackColor = true;
            this.modificarbutton.Click += new System.EventHandler(this.modificarbutton_Click);
            // 
            // guardarbutton
            // 
            this.guardarbutton.Enabled = false;
            this.guardarbutton.Location = new System.Drawing.Point(709, 353);
            this.guardarbutton.Margin = new System.Windows.Forms.Padding(4);
            this.guardarbutton.Name = "guardarbutton";
            this.guardarbutton.Size = new System.Drawing.Size(123, 27);
            this.guardarbutton.TabIndex = 14;
            this.guardarbutton.Text = "Guardar";
            this.guardarbutton.UseVisualStyleBackColor = true;
            this.guardarbutton.Click += new System.EventHandler(this.guardarbutton_Click);
            // 
            // eliminarbutton
            // 
            this.eliminarbutton.Enabled = false;
            this.eliminarbutton.Location = new System.Drawing.Point(709, 307);
            this.eliminarbutton.Margin = new System.Windows.Forms.Padding(4);
            this.eliminarbutton.Name = "eliminarbutton";
            this.eliminarbutton.Size = new System.Drawing.Size(123, 27);
            this.eliminarbutton.TabIndex = 15;
            this.eliminarbutton.Text = "Eliminar";
            this.eliminarbutton.UseVisualStyleBackColor = true;
            // 
            // cancelarbutton
            // 
            this.cancelarbutton.Enabled = false;
            this.cancelarbutton.Location = new System.Drawing.Point(709, 402);
            this.cancelarbutton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelarbutton.Name = "cancelarbutton";
            this.cancelarbutton.Size = new System.Drawing.Size(123, 27);
            this.cancelarbutton.TabIndex = 16;
            this.cancelarbutton.Text = "Cancelar";
            this.cancelarbutton.UseVisualStyleBackColor = true;
            this.cancelarbutton.Click += new System.EventHandler(this.cancelarbutton_Click);
            // 
            // nuevobutton
            // 
            this.nuevobutton.Location = new System.Drawing.Point(709, 217);
            this.nuevobutton.Margin = new System.Windows.Forms.Padding(4);
            this.nuevobutton.Name = "nuevobutton";
            this.nuevobutton.Size = new System.Drawing.Size(123, 27);
            this.nuevobutton.TabIndex = 12;
            this.nuevobutton.Text = "Nuevo";
            this.nuevobutton.UseVisualStyleBackColor = true;
            this.nuevobutton.Click += new System.EventHandler(this.nuevobutton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(224, 38);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(398, 30);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 23);
            this.label1.TabIndex = 21;
            this.label1.Text = "Fecha:";
            // 
            // respuestatextBox
            // 
            this.respuestatextBox.Enabled = false;
            this.respuestatextBox.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.respuestatextBox.Location = new System.Drawing.Point(224, 248);
            this.respuestatextBox.Margin = new System.Windows.Forms.Padding(4);
            this.respuestatextBox.Name = "respuestatextBox";
            this.respuestatextBox.Size = new System.Drawing.Size(398, 30);
            this.respuestatextBox.TabIndex = 25;
            // 
            // solicitudtextBox
            // 
            this.solicitudtextBox.Enabled = false;
            this.solicitudtextBox.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solicitudtextBox.Location = new System.Drawing.Point(224, 208);
            this.solicitudtextBox.Margin = new System.Windows.Forms.Padding(4);
            this.solicitudtextBox.Name = "solicitudtextBox";
            this.solicitudtextBox.Size = new System.Drawing.Size(398, 30);
            this.solicitudtextBox.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1, 245);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 23);
            this.label4.TabIndex = 24;
            this.label4.Text = "Descripción de Respuesta:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1, 205);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(210, 23);
            this.label8.TabIndex = 22;
            this.label8.Text = "Descripción de solicitud:";
            // 
            // impuestotextBox
            // 
            this.impuestotextBox.Enabled = false;
            this.impuestotextBox.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.impuestotextBox.Location = new System.Drawing.Point(224, 329);
            this.impuestotextBox.Margin = new System.Windows.Forms.Padding(4);
            this.impuestotextBox.Name = "impuestotextBox";
            this.impuestotextBox.Size = new System.Drawing.Size(398, 30);
            this.impuestotextBox.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1, 329);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 23);
            this.label5.TabIndex = 28;
            this.label5.Text = "Impuesto:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1, 285);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 23);
            this.label9.TabIndex = 26;
            this.label9.Text = "Precio:";
            // 
            // totaltextBox
            // 
            this.totaltextBox.Enabled = false;
            this.totaltextBox.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totaltextBox.Location = new System.Drawing.Point(224, 409);
            this.totaltextBox.Margin = new System.Windows.Forms.Padding(4);
            this.totaltextBox.Name = "totaltextBox";
            this.totaltextBox.Size = new System.Drawing.Size(398, 30);
            this.totaltextBox.TabIndex = 33;
            // 
            // descuentotextBox
            // 
            this.descuentotextBox.Enabled = false;
            this.descuentotextBox.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descuentotextBox.Location = new System.Drawing.Point(224, 369);
            this.descuentotextBox.Margin = new System.Windows.Forms.Padding(4);
            this.descuentotextBox.Name = "descuentotextBox";
            this.descuentotextBox.Size = new System.Drawing.Size(398, 30);
            this.descuentotextBox.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1, 409);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 23);
            this.label10.TabIndex = 32;
            this.label10.Text = "Total:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1, 369);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 23);
            this.label11.TabIndex = 30;
            this.label11.Text = "Descuento:";
            // 
            // preciotextBox
            // 
            this.preciotextBox.Enabled = false;
            this.preciotextBox.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preciotextBox.Location = new System.Drawing.Point(224, 286);
            this.preciotextBox.Margin = new System.Windows.Forms.Padding(4);
            this.preciotextBox.Name = "preciotextBox";
            this.preciotextBox.Size = new System.Drawing.Size(398, 30);
            this.preciotextBox.TabIndex = 34;
            this.preciotextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.preciotextBox_KeyPress_1);
            // 
            // fotopictureBox
            // 
            this.fotopictureBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.fotopictureBox.Enabled = false;
            this.fotopictureBox.Image = global::facturacion_con_base_de_datos.Properties.Resources.ticket;
            this.fotopictureBox.Location = new System.Drawing.Point(640, 40);
            this.fotopictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.fotopictureBox.Name = "fotopictureBox";
            this.fotopictureBox.Size = new System.Drawing.Size(207, 156);
            this.fotopictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fotopictureBox.TabIndex = 19;
            this.fotopictureBox.TabStop = false;
            // 
            // RevisarTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(923, 476);
            this.Controls.Add(this.preciotextBox);
            this.Controls.Add(this.totaltextBox);
            this.Controls.Add(this.descuentotextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.impuestotextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.respuestatextBox);
            this.Controls.Add(this.solicitudtextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.nuevobutton);
            this.Controls.Add(this.cancelarbutton);
            this.Controls.Add(this.eliminarbutton);
            this.Controls.Add(this.guardarbutton);
            this.Controls.Add(this.modificarbutton);
            this.Controls.Add(this.fotopictureBox);
            this.Controls.Add(this.tiposoportecomboBox);
            this.Controls.Add(this.clientetextBox);
            this.Controls.Add(this.usuariotextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RevisarTicketForm";
            this.Text = "Revisión de Ticket";
            this.Load += new System.EventHandler(this.UsuariosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotopictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox usuariotextBox;
        private System.Windows.Forms.TextBox clientetextBox;
        private System.Windows.Forms.TextBox contraseñatextBox;
        private System.Windows.Forms.TextBox correotextBox;
        private System.Windows.Forms.ComboBox tiposoportecomboBox;
        private System.Windows.Forms.PictureBox fotopictureBox;
        private System.Windows.Forms.Button modificarbutton;
        private System.Windows.Forms.Button guardarbutton;
        private System.Windows.Forms.Button eliminarbutton;
        private System.Windows.Forms.Button cancelarbutton;
        private System.Windows.Forms.Button nuevobutton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox respuestatextBox;
        private System.Windows.Forms.TextBox solicitudtextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox totaltextBox;
        private System.Windows.Forms.TextBox descuentotextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox impuestotextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private EventHandler preciotextBox_TextChanged;
        private System.Windows.Forms.TextBox preciotextBox;
    }
}