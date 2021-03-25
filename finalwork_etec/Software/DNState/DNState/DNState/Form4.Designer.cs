namespace DNState
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dt1 = new System.Windows.Forms.DataGridView();
            this.user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mensagens = new System.Windows.Forms.Timer(this.components);
            this.txt_texto = new System.Windows.Forms.TextBox();
            this.enviar = new System.Windows.Forms.Button();
            this.lb_mensagens = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dt1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Conversas:";
            // 
            // dt1
            // 
            this.dt1.AllowUserToAddRows = false;
            this.dt1.AllowUserToDeleteRows = false;
            this.dt1.AllowUserToResizeColumns = false;
            this.dt1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dt1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dt1.BackgroundColor = System.Drawing.Color.White;
            this.dt1.CausesValidation = false;
            this.dt1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dt1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dt1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.user,
            this.cod,
            this.qtde});
            this.dt1.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dt1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dt1.Location = new System.Drawing.Point(12, 30);
            this.dt1.MultiSelect = false;
            this.dt1.Name = "dt1";
            this.dt1.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt1.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dt1.RowHeadersVisible = false;
            this.dt1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dt1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dt1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dt1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dt1.ShowEditingIcon = false;
            this.dt1.Size = new System.Drawing.Size(205, 379);
            this.dt1.StandardTab = true;
            this.dt1.TabIndex = 210;
            this.dt1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt1_CellContentClick_1);
            this.dt1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt1_CellClick);
            this.dt1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt1_CellClick);
            this.dt1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt1_CellClick);
            // 
            // user
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.DefaultCellStyle = dataGridViewCellStyle3;
            this.user.FillWeight = 200F;
            this.user.HeaderText = "Nome:";
            this.user.Name = "user";
            this.user.ReadOnly = true;
            this.user.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.user.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.user.ToolTipText = "Nome";
            this.user.Width = 200;
            // 
            // cod
            // 
            this.cod.HeaderText = "codigo";
            this.cod.Name = "cod";
            this.cod.ReadOnly = true;
            this.cod.Visible = false;
            // 
            // qtde
            // 
            this.qtde.HeaderText = "qtde";
            this.qtde.Name = "qtde";
            this.qtde.ReadOnly = true;
            this.qtde.Visible = false;
            // 
            // mensagens
            // 
            this.mensagens.Enabled = true;
            this.mensagens.Interval = 2000;
            this.mensagens.Tick += new System.EventHandler(this.mensagens_Tick);
            // 
            // txt_texto
            // 
            this.txt_texto.BackColor = System.Drawing.Color.White;
            this.txt_texto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_texto.Location = new System.Drawing.Point(248, 305);
            this.txt_texto.Multiline = true;
            this.txt_texto.Name = "txt_texto";
            this.txt_texto.Size = new System.Drawing.Size(293, 104);
            this.txt_texto.TabIndex = 1;
            this.txt_texto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button1_KeyDown);
            // 
            // enviar
            // 
            this.enviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enviar.Location = new System.Drawing.Point(547, 305);
            this.enviar.Name = "enviar";
            this.enviar.Size = new System.Drawing.Size(75, 104);
            this.enviar.TabIndex = 5;
            this.enviar.Text = "Enviar";
            this.enviar.UseVisualStyleBackColor = true;
            this.enviar.Click += new System.EventHandler(this.button1_Click);
            this.enviar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button1_KeyDown);
            // 
            // lb_mensagens
            // 
            this.lb_mensagens.FormattingEnabled = true;
            this.lb_mensagens.Location = new System.Drawing.Point(248, 30);
            this.lb_mensagens.Name = "lb_mensagens";
            this.lb_mensagens.Size = new System.Drawing.Size(372, 264);
            this.lb_mensagens.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 211;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(376, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 212;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 421);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_mensagens);
            this.Controls.Add(this.enviar);
            this.Controls.Add(this.txt_texto);
            this.Controls.Add(this.dt1);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dt1;
        private System.Windows.Forms.Timer mensagens;
        private System.Windows.Forms.TextBox txt_texto;
        private System.Windows.Forms.Button enviar;
        private System.Windows.Forms.DataGridViewTextBoxColumn user;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtde;
        private System.Windows.Forms.ListBox lb_mensagens;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}