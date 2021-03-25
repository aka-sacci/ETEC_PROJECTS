namespace Urna_Sacci
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dt1 = new System.Windows.Forms.DataGridView();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.votos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.dt2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dt3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.lbvalidos = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbnulos = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbbrancos = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(759, 108);
            this.panel2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Image = global::Urna_Sacci.Properties.Resources.sees;
            this.label4.Location = new System.Drawing.Point(652, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 93);
            this.label4.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(363, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 73);
            this.label3.TabIndex = 3;
            this.label3.Text = "Eleitoral";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(136, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 73);
            this.label2.TabIndex = 2;
            this.label2.Text = "Justiça";
            // 
            // label1
            // 
            this.label1.Image = global::Urna_Sacci.Properties.Resources.sees;
            this.label1.Location = new System.Drawing.Point(-3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 93);
            this.label1.TabIndex = 2;
            // 
            // dt1
            // 
            this.dt1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome,
            this.partido,
            this.votos,
            this.nro});
            this.dt1.Location = new System.Drawing.Point(42, 156);
            this.dt1.Name = "dt1";
            this.dt1.Size = new System.Drawing.Size(655, 100);
            this.dt1.TabIndex = 3;
            this.dt1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt1_CellClick);
            this.dt1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt1_CellContentClick);
            this.dt1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form3_KeyDown);
            // 
            // nome
            // 
            this.nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            // 
            // partido
            // 
            this.partido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.partido.HeaderText = "Partido";
            this.partido.Name = "partido";
            // 
            // votos
            // 
            this.votos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.votos.HeaderText = "Votos:";
            this.votos.Name = "votos";
            // 
            // nro
            // 
            this.nro.HeaderText = "cod";
            this.nro.Name = "nro";
            this.nro.ReadOnly = true;
            this.nro.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(236, 42);
            this.label5.TabIndex = 5;
            this.label5.Text = "Presidência:";
            // 
            // dt2
            // 
            this.dt2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dt2.Location = new System.Drawing.Point(42, 314);
            this.dt2.Name = "dt2";
            this.dt2.Size = new System.Drawing.Size(655, 176);
            this.dt2.TabIndex = 6;
            this.dt2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt2_CellClick);
            this.dt2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form3_KeyDown);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Partido";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "Votos:";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(220, 42);
            this.label6.TabIndex = 7;
            this.label6.Text = "Senadores:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 505);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(237, 42);
            this.label7.TabIndex = 8;
            this.label7.Text = "Governador:";
            // 
            // dt3
            // 
            this.dt3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn4,
            this.codd});
            this.dt3.Location = new System.Drawing.Point(42, 550);
            this.dt3.Name = "dt3";
            this.dt3.Size = new System.Drawing.Size(655, 100);
            this.dt3.TabIndex = 9;
            this.dt3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt3_CellClick);
            this.dt3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form3_KeyDown);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.HeaderText = "Partido";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.HeaderText = "Votos:";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // codd
            // 
            this.codd.HeaderText = "codd";
            this.codd.Name = "codd";
            this.codd.ReadOnly = true;
            this.codd.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(35, 688);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 29);
            this.label8.TabIndex = 10;
            this.label8.Text = "Validos:";
            // 
            // lbvalidos
            // 
            this.lbvalidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbvalidos.Location = new System.Drawing.Point(143, 688);
            this.lbvalidos.Name = "lbvalidos";
            this.lbvalidos.Size = new System.Drawing.Size(57, 29);
            this.lbvalidos.TabIndex = 11;
            this.lbvalidos.Click += new System.EventHandler(this.label9_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(206, 688);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 29);
            this.label9.TabIndex = 12;
            this.label9.Text = "Nulos:";
            // 
            // lbnulos
            // 
            this.lbnulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnulos.Location = new System.Drawing.Point(291, 688);
            this.lbnulos.Name = "lbnulos";
            this.lbnulos.Size = new System.Drawing.Size(57, 29);
            this.lbnulos.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(354, 688);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 29);
            this.label11.TabIndex = 14;
            this.label11.Text = "Brancos:";
            // 
            // lbbrancos
            // 
            this.lbbrancos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbbrancos.Location = new System.Drawing.Point(464, 688);
            this.lbbrancos.Name = "lbbrancos";
            this.lbbrancos.Size = new System.Drawing.Size(57, 29);
            this.lbbrancos.TabIndex = 15;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(758, 755);
            this.Controls.Add(this.lbbrancos);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbnulos);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbvalidos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dt3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dt2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dt1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UVB - Apuração";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form3_KeyDown);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dt1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dt2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dt3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbvalidos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbnulos;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbbrancos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn codd;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn partido;
        private System.Windows.Forms.DataGridViewTextBoxColumn votos;
        private System.Windows.Forms.DataGridViewTextBoxColumn nro;
    }
}