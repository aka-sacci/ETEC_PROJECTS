namespace Urna_Sacci
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.pbFotos2 = new System.Windows.Forms.PictureBox();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.lbnome = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbpartido = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.vice = new System.Windows.Forms.Label();
            this.lbvice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotos2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pbFotos2
            // 
            this.pbFotos2.Location = new System.Drawing.Point(265, 0);
            this.pbFotos2.Name = "pbFotos2";
            this.pbFotos2.Size = new System.Drawing.Size(169, 201);
            this.pbFotos2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFotos2.TabIndex = 15;
            this.pbFotos2.TabStop = false;
            // 
            // pbFoto
            // 
            this.pbFoto.Location = new System.Drawing.Point(-1, 0);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(269, 320);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 1;
            this.pbFoto.TabStop = false;
            // 
            // lbnome
            // 
            this.lbnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnome.Location = new System.Drawing.Point(13, 356);
            this.lbnome.Name = "lbnome";
            this.lbnome.Size = new System.Drawing.Size(401, 27);
            this.lbnome.TabIndex = 17;
            this.lbnome.Click += new System.EventHandler(this.lbnome_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 29);
            this.label7.TabIndex = 16;
            this.label7.Text = "Nome:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // lbpartido
            // 
            this.lbpartido.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpartido.Location = new System.Drawing.Point(13, 426);
            this.lbpartido.Name = "lbpartido";
            this.lbpartido.Size = new System.Drawing.Size(401, 27);
            this.lbpartido.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 29);
            this.label2.TabIndex = 18;
            this.label2.Text = "Partido";
            // 
            // vice
            // 
            this.vice.AutoSize = true;
            this.vice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vice.Location = new System.Drawing.Point(12, 464);
            this.vice.Name = "vice";
            this.vice.Size = new System.Drawing.Size(71, 29);
            this.vice.TabIndex = 20;
            this.vice.Text = "Vice:";
            // 
            // lbvice
            // 
            this.lbvice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbvice.Location = new System.Drawing.Point(12, 503);
            this.lbvice.Name = "lbvice";
            this.lbvice.Size = new System.Drawing.Size(401, 27);
            this.lbvice.TabIndex = 21;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 563);
            this.Controls.Add(this.lbvice);
            this.Controls.Add(this.vice);
            this.Controls.Add(this.lbpartido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbnome);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pbFotos2);
            this.Controls.Add(this.pbFoto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Candidato";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFotos2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.PictureBox pbFotos2;
        private System.Windows.Forms.Label lbnome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbpartido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label vice;
        private System.Windows.Forms.Label lbvice;
    }
}