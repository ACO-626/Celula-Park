namespace ElJuegoDelaVida
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.isla = new System.Windows.Forms.PictureBox();
            this.btnAzar = new System.Windows.Forms.Button();
            this.btnCreacion = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.comboTamaño = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExtincion = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboTipo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.isla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // isla
            // 
            this.isla.BackColor = System.Drawing.Color.White;
            this.isla.Location = new System.Drawing.Point(12, 12);
            this.isla.Name = "isla";
            this.isla.Size = new System.Drawing.Size(400, 400);
            this.isla.TabIndex = 0;
            this.isla.TabStop = false;
            // 
            // btnAzar
            // 
            this.btnAzar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAzar.Location = new System.Drawing.Point(12, 418);
            this.btnAzar.Name = "btnAzar";
            this.btnAzar.Size = new System.Drawing.Size(75, 58);
            this.btnAzar.TabIndex = 1;
            this.btnAzar.Text = "CAOS";
            this.btnAzar.UseVisualStyleBackColor = false;
            this.btnAzar.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnCreacion
            // 
            this.btnCreacion.BackColor = System.Drawing.Color.DarkGreen;
            this.btnCreacion.Enabled = false;
            this.btnCreacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreacion.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnCreacion.Location = new System.Drawing.Point(93, 418);
            this.btnCreacion.Name = "btnCreacion";
            this.btnCreacion.Size = new System.Drawing.Size(238, 58);
            this.btnCreacion.TabIndex = 2;
            this.btnCreacion.Text = "VIDA";
            this.btnCreacion.UseVisualStyleBackColor = false;
            this.btnCreacion.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnStop.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStop.Location = new System.Drawing.Point(337, 418);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 58);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // comboTamaño
            // 
            this.comboTamaño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTamaño.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTamaño.FormattingEnabled = true;
            this.comboTamaño.Location = new System.Drawing.Point(479, 202);
            this.comboTamaño.Name = "comboTamaño";
            this.comboTamaño.Size = new System.Drawing.Size(161, 33);
            this.comboTamaño.TabIndex = 4;
            this.comboTamaño.SelectedIndexChanged += new System.EventHandler(this.comboTamaño_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(474, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tamaño de células";
            // 
            // btnExtincion
            // 
            this.btnExtincion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtincion.Location = new System.Drawing.Point(478, 378);
            this.btnExtincion.Name = "btnExtincion";
            this.btnExtincion.Size = new System.Drawing.Size(162, 59);
            this.btnExtincion.TabIndex = 6;
            this.btnExtincion.Text = "¡EXTINCIÓN!";
            this.btnExtincion.UseVisualStyleBackColor = true;
            this.btnExtincion.Click += new System.EventHandler(this.btnExtincion_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(462, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // comboTipo
            // 
            this.comboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTipo.FormattingEnabled = true;
            this.comboTipo.Location = new System.Drawing.Point(478, 276);
            this.comboTipo.Name = "comboTipo";
            this.comboTipo.Size = new System.Drawing.Size(161, 33);
            this.comboTipo.TabIndex = 8;
            this.comboTipo.SelectedIndexChanged += new System.EventHandler(this.comboTipo_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(687, 480);
            this.Controls.Add(this.comboTipo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExtincion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboTamaño);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnCreacion);
            this.Controls.Add(this.btnAzar);
            this.Controls.Add(this.isla);
            this.Name = "MainForm";
            this.Text = "Celular Park";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.isla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox isla;
        private System.Windows.Forms.Button btnAzar;
        private System.Windows.Forms.Button btnCreacion;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox comboTamaño;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExtincion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboTipo;
    }
}

