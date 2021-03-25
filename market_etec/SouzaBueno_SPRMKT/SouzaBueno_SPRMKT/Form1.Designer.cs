namespace SouzaBueno_SPRMKT
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.data = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.hora = new System.Windows.Forms.ToolStripLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CDBR = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTQTDE = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Quantidade = new System.Windows.Forms.Label();
            this.ValorUnitario = new System.Windows.Forms.Label();
            this.TXTVALORUNITARIO = new System.Windows.Forms.TextBox();
            this.Valor = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TXTVALOR = new System.Windows.Forms.TextBox();
            this.Total = new System.Windows.Forms.Label();
            this.TXTTOTAL = new System.Windows.Forms.TextBox();
            this.TXT_PROD = new System.Windows.Forms.TextBox();
            this.PB_foto = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgDados = new System.Windows.Forms.DataGridView();
            this.dtvalor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtdesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtqtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.Label();
            this.TXT_DESC = new System.Windows.Forms.TextBox();
            this.valorrecebido = new System.Windows.Forms.Label();
            this.TXT_VLRR = new System.Windows.Forms.TextBox();
            this.troco = new System.Windows.Forms.Label();
            this.TXT_TROCO = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_foto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDados)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AllowDrop = true;
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.data,
            this.toolStripSeparator3,
            this.hora});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1135, 73);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = " ";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 70);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 70);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 70);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 70);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 70);
            this.toolStripButton5.Text = "toolStripButton5";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.Color.Blue;
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.Blue;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 73);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(241, 70);
            this.toolStripLabel1.Text = "OPERADOR: LUCAS SACCI";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(50, 0, 48, 0);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 73);
            // 
            // data
            // 
            this.data.AutoSize = false;
            this.data.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(307, 70);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 73);
            // 
            // hora
            // 
            this.hora.AutoSize = false;
            this.hora.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.hora.Name = "hora";
            this.hora.Size = new System.Drawing.Size(131, 70);
            this.hora.Click += new System.EventHandler(this.hora_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CDBR
            // 
            this.CDBR.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CDBR.Location = new System.Drawing.Point(57, 551);
            this.CDBR.Name = "CDBR";
            this.CDBR.Size = new System.Drawing.Size(282, 31);
            this.CDBR.TabIndex = 3;
            this.CDBR.Click += new System.EventHandler(this.CDBR_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 603);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Código do produto:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TXTQTDE
            // 
            this.TXTQTDE.Location = new System.Drawing.Point(433, 212);
            this.TXTQTDE.Name = "TXTQTDE";
            this.TXTQTDE.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TXTQTDE.Size = new System.Drawing.Size(174, 30);
            this.TXTQTDE.TabIndex = 5;
            this.TXTQTDE.Text = "0";
            this.TXTQTDE.TextChanged += new System.EventHandler(this.CBCOD_TextChanged);
            this.TXTQTDE.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.TXTQTDE.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CBCOD_KeyUp);
            this.TXTQTDE.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CBCOD_MouseDown);
            this.TXTQTDE.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Form1_PreviewKeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(12, 709);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nova Compra - F5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(219, 709);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Finalizar Compra - F6";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(642, 709);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "Sair - ESC";
            // 
            // Quantidade
            // 
            this.Quantidade.AutoSize = true;
            this.Quantidade.Location = new System.Drawing.Point(372, 172);
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.Size = new System.Drawing.Size(161, 21);
            this.Quantidade.TabIndex = 10;
            this.Quantidade.Text = "Quantidade/Kg:";
            // 
            // ValorUnitario
            // 
            this.ValorUnitario.AutoSize = true;
            this.ValorUnitario.Location = new System.Drawing.Point(372, 275);
            this.ValorUnitario.Name = "ValorUnitario";
            this.ValorUnitario.Size = new System.Drawing.Size(238, 21);
            this.ValorUnitario.TabIndex = 11;
            this.ValorUnitario.Text = "Valor Unitário/Valor Kg:";
            // 
            // TXTVALORUNITARIO
            // 
            this.TXTVALORUNITARIO.BackColor = System.Drawing.SystemColors.Window;
            this.TXTVALORUNITARIO.Enabled = false;
            this.TXTVALORUNITARIO.Location = new System.Drawing.Point(427, 314);
            this.TXTVALORUNITARIO.Name = "TXTVALORUNITARIO";
            this.TXTVALORUNITARIO.ReadOnly = true;
            this.TXTVALORUNITARIO.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TXTVALORUNITARIO.Size = new System.Drawing.Size(174, 30);
            this.TXTVALORUNITARIO.TabIndex = 12;
            this.TXTVALORUNITARIO.TextChanged += new System.EventHandler(this.TXTVALORUNITARIO_TextChanged);
            // 
            // Valor
            // 
            this.Valor.AutoSize = true;
            this.Valor.Location = new System.Drawing.Point(372, 374);
            this.Valor.Name = "Valor";
            this.Valor.Size = new System.Drawing.Size(65, 21);
            this.Valor.TabIndex = 13;
            this.Valor.Text = "Valor:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(470, 709);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 21);
            this.label10.TabIndex = 15;
            this.label10.Text = "Cancelar - F7";
            // 
            // TXTVALOR
            // 
            this.TXTVALOR.Enabled = false;
            this.TXTVALOR.Location = new System.Drawing.Point(427, 408);
            this.TXTVALOR.Name = "TXTVALOR";
            this.TXTVALOR.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TXTVALOR.Size = new System.Drawing.Size(174, 30);
            this.TXTVALOR.TabIndex = 16;
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(372, 464);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(63, 21);
            this.Total.TabIndex = 17;
            this.Total.Text = "Total:";
            // 
            // TXTTOTAL
            // 
            this.TXTTOTAL.Enabled = false;
            this.TXTTOTAL.Location = new System.Drawing.Point(427, 488);
            this.TXTTOTAL.Name = "TXTTOTAL";
            this.TXTTOTAL.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TXTTOTAL.Size = new System.Drawing.Size(174, 30);
            this.TXTTOTAL.TabIndex = 18;
            this.TXTTOTAL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // TXT_PROD
            // 
            this.TXT_PROD.Location = new System.Drawing.Point(57, 641);
            this.TXT_PROD.Name = "TXT_PROD";
            this.TXT_PROD.Size = new System.Drawing.Size(263, 30);
            this.TXT_PROD.TabIndex = 19;
            this.TXT_PROD.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.TXT_PROD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // PB_foto
            // 
            this.PB_foto.Image = global::SouzaBueno_SPRMKT.Properties.Resources.CL1;
            this.PB_foto.Location = new System.Drawing.Point(57, 172);
            this.PB_foto.Name = "PB_foto";
            this.PB_foto.Size = new System.Drawing.Size(282, 355);
            this.PB_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_foto.TabIndex = 2;
            this.PB_foto.TabStop = false;
            this.PB_foto.Click += new System.EventHandler(this.PB_foto_Click);
            // 
            // label1
            // 
            this.label1.Image = global::SouzaBueno_SPRMKT.Properties.Resources.SB_SPRMKT_SF1;
            this.label1.Location = new System.Drawing.Point(-4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 129);
            this.label1.TabIndex = 0;
            // 
            // dgDados
            // 
            this.dgDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtvalor,
            this.dtdesc,
            this.dtqtde,
            this.dtcod});
            this.dgDados.Enabled = false;
            this.dgDados.Location = new System.Drawing.Point(646, 96);
            this.dgDados.Name = "dgDados";
            this.dgDados.Size = new System.Drawing.Size(477, 422);
            this.dgDados.TabIndex = 20;
            this.dgDados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDados_CellContentClick);
            // 
            // dtvalor
            // 
            this.dtvalor.HeaderText = "Valor";
            this.dtvalor.Name = "dtvalor";
            this.dtvalor.ReadOnly = true;
            // 
            // dtdesc
            // 
            this.dtdesc.FillWeight = 300F;
            this.dtdesc.HeaderText = "Descrição";
            this.dtdesc.Name = "dtdesc";
            this.dtdesc.ReadOnly = true;
            this.dtdesc.Width = 250;
            // 
            // dtqtde
            // 
            this.dtqtde.HeaderText = "QTDE";
            this.dtqtde.Name = "dtqtde";
            this.dtqtde.ReadOnly = true;
            this.dtqtde.Width = 75;
            // 
            // dtcod
            // 
            this.dtcod.HeaderText = "cod";
            this.dtcod.Name = "dtcod";
            this.dtcod.Visible = false;
            // 
            // Descricao
            // 
            this.Descricao.AutoSize = true;
            this.Descricao.Location = new System.Drawing.Point(391, 551);
            this.Descricao.Name = "Descricao";
            this.Descricao.Size = new System.Drawing.Size(107, 21);
            this.Descricao.TabIndex = 21;
            this.Descricao.Text = "Descrição:";
            // 
            // TXT_DESC
            // 
            this.TXT_DESC.Enabled = false;
            this.TXT_DESC.Location = new System.Drawing.Point(427, 575);
            this.TXT_DESC.Name = "TXT_DESC";
            this.TXT_DESC.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TXT_DESC.Size = new System.Drawing.Size(297, 30);
            this.TXT_DESC.TabIndex = 22;
            this.TXT_DESC.TextChanged += new System.EventHandler(this.TXT_DESC_TextChanged);
            // 
            // valorrecebido
            // 
            this.valorrecebido.AutoSize = true;
            this.valorrecebido.Location = new System.Drawing.Point(800, 578);
            this.valorrecebido.Name = "valorrecebido";
            this.valorrecebido.Size = new System.Drawing.Size(156, 21);
            this.valorrecebido.TabIndex = 23;
            this.valorrecebido.Text = "Valor Recebido:";
            // 
            // TXT_VLRR
            // 
            this.TXT_VLRR.Location = new System.Drawing.Point(860, 603);
            this.TXT_VLRR.Name = "TXT_VLRR";
            this.TXT_VLRR.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TXT_VLRR.Size = new System.Drawing.Size(174, 30);
            this.TXT_VLRR.TabIndex = 24;
            this.TXT_VLRR.Text = "R$ 0,00";
            this.TXT_VLRR.TextChanged += new System.EventHandler(this.TXT_VLRR_TextChanged);
            this.TXT_VLRR.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXT_VLRR_KeyDown);
            // 
            // troco
            // 
            this.troco.AutoSize = true;
            this.troco.Location = new System.Drawing.Point(800, 650);
            this.troco.Name = "troco";
            this.troco.Size = new System.Drawing.Size(68, 21);
            this.troco.TabIndex = 25;
            this.troco.Text = "Troco:";
            // 
            // TXT_TROCO
            // 
            this.TXT_TROCO.Enabled = false;
            this.TXT_TROCO.Location = new System.Drawing.Point(860, 674);
            this.TXT_TROCO.Name = "TXT_TROCO";
            this.TXT_TROCO.ReadOnly = true;
            this.TXT_TROCO.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TXT_TROCO.Size = new System.Drawing.Size(174, 30);
            this.TXT_TROCO.TabIndex = 26;
            this.TXT_TROCO.Text = "R$ 0,00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1135, 749);
            this.Controls.Add(this.TXT_TROCO);
            this.Controls.Add(this.troco);
            this.Controls.Add(this.TXT_VLRR);
            this.Controls.Add(this.valorrecebido);
            this.Controls.Add(this.TXT_DESC);
            this.Controls.Add(this.Descricao);
            this.Controls.Add(this.dgDados);
            this.Controls.Add(this.TXT_PROD);
            this.Controls.Add(this.TXTTOTAL);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.TXTVALOR);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Valor);
            this.Controls.Add(this.TXTVALORUNITARIO);
            this.Controls.Add(this.ValorUnitario);
            this.Controls.Add(this.Quantidade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TXTQTDE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CDBR);
            this.Controls.Add(this.PB_foto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximumSize = new System.Drawing.Size(2334, 888);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "aa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Form1_PreviewKeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_foto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel data;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel hora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox PB_foto;
        private System.Windows.Forms.Label CDBR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXTQTDE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Quantidade;
        private System.Windows.Forms.Label ValorUnitario;
        private System.Windows.Forms.TextBox TXTVALORUNITARIO;
        private System.Windows.Forms.Label Valor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TXTVALOR;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.TextBox TXTTOTAL;
        private System.Windows.Forms.TextBox TXT_PROD;
        private System.Windows.Forms.DataGridView dgDados;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtvalor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtdesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtqtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcod;
        private System.Windows.Forms.Label Descricao;
        private System.Windows.Forms.TextBox TXT_DESC;
        private System.Windows.Forms.Label valorrecebido;
        private System.Windows.Forms.Label troco;
        private System.Windows.Forms.TextBox TXT_TROCO;
        public System.Windows.Forms.TextBox TXT_VLRR;
    }
}

