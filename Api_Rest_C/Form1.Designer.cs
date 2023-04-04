namespace Api_Rest_C
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.txt_Hum = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.txt_temp = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.txt_presion = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txt_lon = new System.Windows.Forms.TextBox();
            this.txt_lat = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(594, 294);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(41, 40);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 26;
            this.PictureBox1.TabStop = false;
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Panel2.Location = new System.Drawing.Point(1, 357);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(673, 23);
            this.Panel2.TabIndex = 25;
            // 
            // btn_consultar
            // 
            this.btn_consultar.Location = new System.Drawing.Point(475, 294);
            this.btn_consultar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(112, 35);
            this.btn_consultar.TabIndex = 24;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click_1);
            // 
            // txt_Hum
            // 
            this.txt_Hum.Enabled = false;
            this.txt_Hum.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Hum.Location = new System.Drawing.Point(475, 244);
            this.txt_Hum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Hum.Name = "txt_Hum";
            this.txt_Hum.Size = new System.Drawing.Size(148, 27);
            this.txt_Hum.TabIndex = 23;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(296, 244);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(85, 18);
            this.Label5.TabIndex = 22;
            this.Label5.Text = "Humedad";
            // 
            // txt_temp
            // 
            this.txt_temp.Enabled = false;
            this.txt_temp.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_temp.Location = new System.Drawing.Point(475, 204);
            this.txt_temp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_temp.Name = "txt_temp";
            this.txt_temp.Size = new System.Drawing.Size(148, 27);
            this.txt_temp.TabIndex = 21;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(296, 204);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(110, 18);
            this.Label4.TabIndex = 20;
            this.Label4.Text = "Temperatura";
            // 
            // txt_presion
            // 
            this.txt_presion.Enabled = false;
            this.txt_presion.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_presion.Location = new System.Drawing.Point(475, 159);
            this.txt_presion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_presion.Name = "txt_presion";
            this.txt_presion.Size = new System.Drawing.Size(148, 27);
            this.txt_presion.TabIndex = 19;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(296, 168);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(171, 18);
            this.Label3.TabIndex = 18;
            this.Label3.Text = "Presion Atmosferica";
            // 
            // txt_lon
            // 
            this.txt_lon.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lon.Location = new System.Drawing.Point(112, 204);
            this.txt_lon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_lon.Name = "txt_lon";
            this.txt_lon.Size = new System.Drawing.Size(148, 27);
            this.txt_lon.TabIndex = 17;
            // 
            // txt_lat
            // 
            this.txt_lat.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lat.Location = new System.Drawing.Point(112, 159);
            this.txt_lat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_lat.Name = "txt_lat";
            this.txt_lat.Size = new System.Drawing.Size(148, 27);
            this.txt_lat.TabIndex = 16;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(25, 207);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(79, 18);
            this.Label2.TabIndex = 15;
            this.Label2.Text = "Longitud";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(29, 162);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(66, 18);
            this.Label1.TabIndex = 14;
            this.Label1.Text = "Latitud";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(673, 23);
            this.panel1.TabIndex = 26;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(220, 41);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(307, 110);
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(671, 380);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.txt_Hum);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.txt_temp);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.txt_presion);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txt_lon);
            this.Controls.Add(this.txt_lat);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Button btn_consultar;
        internal System.Windows.Forms.TextBox txt_Hum;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txt_temp;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txt_presion;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txt_lon;
        internal System.Windows.Forms.TextBox txt_lat;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

