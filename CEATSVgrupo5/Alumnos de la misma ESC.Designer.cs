namespace CEATSVgrupo5
{
    partial class Alumnos_de_la_misma_ESC
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CNumerodeOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CFechaAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDistrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CProvincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNación = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPrivada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CGrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgrAlum = new System.Windows.Forms.Button();
            this.btnEliminarReg = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CNumerodeOrden,
            this.CAlumno,
            this.CFechaAd,
            this.CDistrito,
            this.CProvincia,
            this.CNación,
            this.CPrivada,
            this.CGrado});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(699, 577);
            this.dataGridView1.TabIndex = 0;
            // 
            // CNumerodeOrden
            // 
            this.CNumerodeOrden.HeaderText = "Nº de Orden";
            this.CNumerodeOrden.Name = "CNumerodeOrden";
            // 
            // CAlumno
            // 
            this.CAlumno.HeaderText = "Alumno";
            this.CAlumno.Name = "CAlumno";
            // 
            // CFechaAd
            // 
            this.CFechaAd.HeaderText = "Fecha de Admición";
            this.CFechaAd.Name = "CFechaAd";
            // 
            // CDistrito
            // 
            this.CDistrito.HeaderText = "Distrito";
            this.CDistrito.Name = "CDistrito";
            // 
            // CProvincia
            // 
            this.CProvincia.HeaderText = "Provincia";
            this.CProvincia.Name = "CProvincia";
            // 
            // CNación
            // 
            this.CNación.HeaderText = "Nación";
            this.CNación.Name = "CNación";
            // 
            // CPrivada
            // 
            this.CPrivada.HeaderText = "Privada";
            this.CPrivada.Name = "CPrivada";
            // 
            // CGrado
            // 
            this.CGrado.HeaderText = "Grado";
            this.CGrado.Name = "CGrado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inscripciones de Alumnos ";
            // 
            // btnAgrAlum
            // 
            this.btnAgrAlum.BackColor = System.Drawing.Color.White;
            this.btnAgrAlum.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgrAlum.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgrAlum.Location = new System.Drawing.Point(107, 83);
            this.btnAgrAlum.Name = "btnAgrAlum";
            this.btnAgrAlum.Size = new System.Drawing.Size(160, 28);
            this.btnAgrAlum.TabIndex = 2;
            this.btnAgrAlum.Text = "AGREGAR";
            this.btnAgrAlum.UseVisualStyleBackColor = false;
            this.btnAgrAlum.Click += new System.EventHandler(this.btnAgrAlum_Click);
            // 
            // btnEliminarReg
            // 
            this.btnEliminarReg.BackColor = System.Drawing.Color.White;
            this.btnEliminarReg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarReg.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarReg.Location = new System.Drawing.Point(107, 134);
            this.btnEliminarReg.Name = "btnEliminarReg";
            this.btnEliminarReg.Size = new System.Drawing.Size(160, 28);
            this.btnEliminarReg.TabIndex = 3;
            this.btnEliminarReg.Text = "ELIMINAR";
            this.btnEliminarReg.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pictureBox1.Location = new System.Drawing.Point(0, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1054, 60);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 54);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.comboBox1);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.btnEliminarReg);
            this.splitContainer1.Panel1.Controls.Add(this.btnAgrAlum);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(1054, 577);
            this.splitContainer1.SplitterDistance = 351;
            this.splitContainer1.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "CUIT",
            "CATEGORÍA"});
            this.comboBox1.Location = new System.Drawing.Point(107, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(201, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Buscar por";
            // 
            // Alumnos_de_la_misma_ESC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 631);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Alumnos_de_la_misma_ESC";
            this.Text = "Alumnos_de_la_misma_ESC";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNumerodeOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFechaAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDistrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn CProvincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNación;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPrivada;
        private System.Windows.Forms.DataGridViewTextBoxColumn CGrado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgrAlum;
        private System.Windows.Forms.Button btnEliminarReg;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
    }
}