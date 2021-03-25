namespace DNState
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.senha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.senha2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.endereco = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.lbconfirm = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tipo = new System.Windows.Forms.CheckBox();
            this.tipo3 = new System.Windows.Forms.CheckBox();
            this.tipo2 = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.desc = new System.Windows.Forms.TextBox();
            this.tipo4 = new System.Windows.Forms.CheckBox();
            this.tipo5 = new System.Windows.Forms.CheckBox();
            this.tipo6 = new System.Windows.Forms.CheckBox();
            this.tipo7 = new System.Windows.Forms.CheckBox();
            this.tipo8 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.p1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.cnpj = new System.Windows.Forms.TextBox();
            this.telefone = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.p1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "CNPJ (Só números):";
            // 
            // senha
            // 
            this.senha.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senha.Location = new System.Drawing.Point(365, 189);
            this.senha.Name = "senha";
            this.senha.PasswordChar = '*';
            this.senha.Size = new System.Drawing.Size(252, 20);
            this.senha.TabIndex = 4;
            this.senha.TextChanged += new System.EventHandler(this.senha_TextChanged);
            this.senha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(397, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Senha:";
            // 
            // senha2
            // 
            this.senha2.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senha2.Location = new System.Drawing.Point(367, 279);
            this.senha2.Name = "senha2";
            this.senha2.PasswordChar = '*';
            this.senha2.Size = new System.Drawing.Size(252, 20);
            this.senha2.TabIndex = 5;
            this.senha2.TextChanged += new System.EventHandler(this.senha2_TextChanged);
            this.senha2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            this.senha2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.senha2_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(363, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Confirmação da Senha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(120, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "DDD e Telefone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(120, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Endereço:";
            // 
            // endereco
            // 
            this.endereco.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endereco.Location = new System.Drawing.Point(64, 279);
            this.endereco.Name = "endereco";
            this.endereco.Size = new System.Drawing.Size(254, 20);
            this.endereco.TabIndex = 6;
            this.endereco.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(399, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "Nome da ONG:";
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(367, 107);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(254, 20);
            this.name.TabIndex = 2;
            this.name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            // 
            // lbconfirm
            // 
            this.lbconfirm.BackColor = System.Drawing.Color.White;
            this.lbconfirm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbconfirm.Location = new System.Drawing.Point(367, 627);
            this.lbconfirm.Name = "lbconfirm";
            this.lbconfirm.Size = new System.Drawing.Size(254, 23);
            this.lbconfirm.TabIndex = 17;
            this.lbconfirm.Click += new System.EventHandler(this.lbconfirm_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(61, 393);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(278, 18);
            this.label7.TabIndex = 19;
            this.label7.Text = "Tipo(s) de doações aceitas:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(150, 587);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Cadastra&r";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            // 
            // tipo
            // 
            this.tipo.AutoSize = true;
            this.tipo.BackColor = System.Drawing.Color.White;
            this.tipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tipo.Location = new System.Drawing.Point(65, 428);
            this.tipo.Name = "tipo";
            this.tipo.Size = new System.Drawing.Size(55, 17);
            this.tipo.TabIndex = 8;
            this.tipo.Text = "Roupa";
            this.tipo.UseVisualStyleBackColor = false;
            this.tipo.CheckedChanged += new System.EventHandler(this.tipo_CheckedChanged);
            // 
            // tipo3
            // 
            this.tipo3.AutoSize = true;
            this.tipo3.BackColor = System.Drawing.Color.White;
            this.tipo3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tipo3.Location = new System.Drawing.Point(65, 474);
            this.tipo3.Name = "tipo3";
            this.tipo3.Size = new System.Drawing.Size(62, 17);
            this.tipo3.TabIndex = 10;
            this.tipo3.Text = "Dinheiro";
            this.tipo3.UseVisualStyleBackColor = false;
            this.tipo3.CheckedChanged += new System.EventHandler(this.tipo3_CheckedChanged);
            // 
            // tipo2
            // 
            this.tipo2.AutoSize = true;
            this.tipo2.BackColor = System.Drawing.Color.White;
            this.tipo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tipo2.Location = new System.Drawing.Point(65, 451);
            this.tipo2.Name = "tipo2";
            this.tipo2.Size = new System.Drawing.Size(63, 17);
            this.tipo2.TabIndex = 9;
            this.tipo2.Text = "Alimento";
            this.tipo2.UseVisualStyleBackColor = false;
            this.tipo2.CheckedChanged += new System.EventHandler(this.tipo2_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(361, 422);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(193, 24);
            this.label8.TabIndex = 24;
            this.label8.Text = "Descrição da ONG:";
            // 
            // desc
            // 
            this.desc.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc.Location = new System.Drawing.Point(365, 474);
            this.desc.Multiline = true;
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(252, 100);
            this.desc.TabIndex = 9;
            this.desc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            // 
            // tipo4
            // 
            this.tipo4.AutoSize = true;
            this.tipo4.BackColor = System.Drawing.Color.White;
            this.tipo4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tipo4.Location = new System.Drawing.Point(65, 497);
            this.tipo4.Name = "tipo4";
            this.tipo4.Size = new System.Drawing.Size(55, 17);
            this.tipo4.TabIndex = 11;
            this.tipo4.Text = "Ração";
            this.tipo4.UseVisualStyleBackColor = false;
            this.tipo4.CheckedChanged += new System.EventHandler(this.tipo4_CheckedChanged);
            // 
            // tipo5
            // 
            this.tipo5.AutoSize = true;
            this.tipo5.BackColor = System.Drawing.Color.White;
            this.tipo5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tipo5.Location = new System.Drawing.Point(164, 426);
            this.tipo5.Name = "tipo5";
            this.tipo5.Size = new System.Drawing.Size(70, 17);
            this.tipo5.TabIndex = 12;
            this.tipo5.Text = "Remédios";
            this.tipo5.UseVisualStyleBackColor = false;
            this.tipo5.CheckedChanged += new System.EventHandler(this.tipo5_CheckedChanged);
            // 
            // tipo6
            // 
            this.tipo6.AutoSize = true;
            this.tipo6.BackColor = System.Drawing.Color.White;
            this.tipo6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tipo6.Location = new System.Drawing.Point(164, 451);
            this.tipo6.Name = "tipo6";
            this.tipo6.Size = new System.Drawing.Size(119, 17);
            this.tipo6.TabIndex = 13;
            this.tipo6.Text = "Produtos de Higiêne";
            this.tipo6.UseVisualStyleBackColor = false;
            this.tipo6.CheckedChanged += new System.EventHandler(this.tipo6_CheckedChanged);
            // 
            // tipo7
            // 
            this.tipo7.AutoSize = true;
            this.tipo7.BackColor = System.Drawing.Color.White;
            this.tipo7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tipo7.Location = new System.Drawing.Point(164, 474);
            this.tipo7.Name = "tipo7";
            this.tipo7.Size = new System.Drawing.Size(146, 17);
            this.tipo7.TabIndex = 14;
            this.tipo7.Text = "Cobertores e Travesseiros";
            this.tipo7.UseVisualStyleBackColor = false;
            this.tipo7.CheckedChanged += new System.EventHandler(this.tipo7_CheckedChanged);
            // 
            // tipo8
            // 
            this.tipo8.AutoSize = true;
            this.tipo8.BackColor = System.Drawing.Color.White;
            this.tipo8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tipo8.Location = new System.Drawing.Point(164, 497);
            this.tipo8.Name = "tipo8";
            this.tipo8.Size = new System.Drawing.Size(115, 17);
            this.tipo8.TabIndex = 15;
            this.tipo8.Text = "Agasalhos em geral";
            this.tipo8.UseVisualStyleBackColor = false;
            this.tipo8.CheckedChanged += new System.EventHandler(this.tipo8_CheckedChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(150, 558);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 23);
            this.button2.TabIndex = 25;
            this.button2.Text = "Seleciona&r Logo";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // p1
            // 
            this.p1.Location = new System.Drawing.Point(36, 558);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(108, 107);
            this.p1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p1.TabIndex = 27;
            this.p1.TabStop = false;
            this.p1.Click += new System.EventHandler(this.p1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(71, 324);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 24);
            this.label9.TabIndex = 28;
            this.label9.Text = "Bairro:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Alpes Atibaia",
            "Alto Boa Vista",
            "Alvinópolis",
            "Atibaia Belvedere",
            "Atibaia Jardim",
            "Atibaia Vista da Montanha",
            "Bocaina",
            "Brotas",
            "Caetetuba",
            "Campos de Atibaia",
            "Casas Populares",
            "Centro",
            "Chácara da Colina",
            "Chácara Fernão Dias",
            "Chácara Maringá",
            "Chácara Parque São Pedro",
            "Chanceler Nova Ruhr",
            "Chs Fernão Dias",
            "Chs Maringá",
            "Cidade Satélite",
            "Condomínio Parque das Garças I",
            "Condomínio Residencial Pedra Grande",
            "Conjunto Habitacional José Barnet Y Vives",
            "Conjunto Habitacional São José",
            "Ctb",
            "Estância Lituanika",
            "Estância Parque de Atibaia",
            "Estância San Remo",
            "Estância Santa Maria do Laranjal",
            "Estância Santa Maria do Portão",
            "Estância Santa Maria Laranjal",
            "Estância Santa Maria Portão",
            "Guaxinduva",
            "Itapetinga",
            "Itapetininga",
            "Jardim Alvinópolis",
            "Jardim Alvinópolis II",
            "Jardim América",
            "Jardim Brasil",
            "Jardim Brogota",
            "Jardim Centenário",
            "Jardim Cerejeiras",
            "Jardim Colonial",
            "Jardim das Cerejeiras",
            "Jardim das Flores",
            "Jardim do Lago",
            "Jardim do Trevo",
            "Jardim dos Pinheiros",
            "Jardim Eneide",
            "Jardim Estância Brasil",
            "Jardim Flamboyant-b",
            "Jardim Floresta",
            "Jardim Imperador",
            "Jardim Imperial",
            "Jardim Itaperi",
            "Jardim Jaraguá",
            "Jardim Kanimar",
            "Jardim Lago",
            "Jardim Maracanã",
            "Jardim Maristela",
            "Jardim Maristela II",
            "Jardim Pacaembu",
            "Jardim Paraíso da Usina",
            "Jardim Paraíso do Tanque",
            "Jardim Paraíso Tanque",
            "Jardim Parque Real Atibaia",
            "Jardim Paulista",
            "Jardim Pinheiros",
            "Jardim Planalto do Tanque",
            "Jardim Residencial Santa Luíza",
            "Jardim Roseli",
            "Jardim Santa Bárbara",
            "Jardim Santo Antônio",
            "Jardim São Bento do Tanque",
            "Jardim São Felipe",
            "Jardim Shangri-lá",
            "Jardim Siriema",
            "Jardim Sueli",
            "Jardim Suely",
            "Jardim Suíça",
            "Jardim Tapajós",
            "Jardim Terceiro Centenário",
            "Jardim Trevo",
            "Loteamento Loanda",
            "Loteamento Retiro Recanto Tranquilo",
            "Loteamento Vale das Flores",
            "Maracanã",
            "Marmeleiro",
            "Nova Cerejeira",
            "Nova Gardênia",
            "Panorama Parque Residencial",
            "Parque Arco Íris",
            "Parque das Nações",
            "Parque dos Coqueiros",
            "Parque Fernão Dias",
            "Parque Garças",
            "Parque Nações",
            "Parque Residencial Itaguaçu",
            "Parque Rio Abaixo",
            "Pinheiral I",
            "Pinheiral II",
            "Planalto Atibaia",
            "Ponte",
            "Ponte Alta",
            "Portão",
            "Recanto Palmares",
            "Recreio Estoril",
            "Recreio Maristela",
            "Recreio São Vicente",
            "Refúgio",
            "Ressaca",
            "Retiro das Fontes",
            "Ribeirão dos Porcos",
            "Ribeirão Porcos",
            "Rio Abaixo",
            "Rio Acima",
            "Rosário",
            "Samambaia Parque Residencial",
            "San Fernando Valley",
            "Sul Brasil",
            "Tanque",
            "Vila Boa Esperança",
            "Vila Carvalho",
            "Vila Dom Pedro",
            "Vila dos Netos",
            "Vila Esperança",
            "Vila Esperia Ou Giglio",
            "Vila Gardênia",
            "Vila Helena",
            "Vila Imperial Dom Pedro",
            "Vila Junqueira",
            "Vila Loanda",
            "Vila Maria",
            "Vila Mira",
            "Vila Petrópolis",
            "Vila Rica",
            "Vila Salles",
            "Vila Santa Clara",
            "Vila Santa Helena",
            "Vila Santista",
            "Vila Santo Antônio",
            "Vila Silva",
            "Vila Thaís",
            "Vitória Régia"});
            this.comboBox1.Location = new System.Drawing.Point(167, 326);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.maskedTextBox1);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(691, 234);
            this.panel1.TabIndex = 30;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(74, 107);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(246, 20);
            this.maskedTextBox1.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(27, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(619, 646);
            this.label10.TabIndex = 31;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(492, 31);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 33;
            this.button3.Text = "--";
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(570, 31);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 32;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(365, 326);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 24);
            this.label11.TabIndex = 34;
            this.label11.Text = "E-mail:";
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(369, 366);
            this.email.MaxLength = 50;
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(252, 20);
            this.email.TabIndex = 8;
            // 
            // cnpj
            // 
            this.cnpj.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnpj.Location = new System.Drawing.Point(64, 107);
            this.cnpj.Name = "cnpj";
            this.cnpj.Size = new System.Drawing.Size(254, 20);
            this.cnpj.TabIndex = 1;
            this.cnpj.TextChanged += new System.EventHandler(this.cnpj_TextChanged);
            this.cnpj.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            this.cnpj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form2_KeyPress);
            // 
            // telefone
            // 
            this.telefone.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefone.Location = new System.Drawing.Point(64, 189);
            this.telefone.Name = "telefone";
            this.telefone.Size = new System.Drawing.Size(254, 20);
            this.telefone.TabIndex = 3;
            this.telefone.TextChanged += new System.EventHandler(this.telefone_TextChanged);
            this.telefone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            this.telefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form2_KeyPress);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(676, 700);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tipo8);
            this.Controls.Add(this.tipo7);
            this.Controls.Add(this.tipo6);
            this.Controls.Add(this.tipo5);
            this.Controls.Add(this.tipo4);
            this.Controls.Add(this.desc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tipo2);
            this.Controls.Add(this.tipo3);
            this.Controls.Add(this.tipo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbconfirm);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.endereco);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.telefone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.senha2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.senha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cnpj);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form2_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.p1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox senha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox senha2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox endereco;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label lbconfirm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox tipo;
        private System.Windows.Forms.CheckBox tipo3;
        private System.Windows.Forms.CheckBox tipo2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox desc;
        private System.Windows.Forms.CheckBox tipo4;
        private System.Windows.Forms.CheckBox tipo5;
        private System.Windows.Forms.CheckBox tipo6;
        private System.Windows.Forms.CheckBox tipo7;
        private System.Windows.Forms.CheckBox tipo8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox p1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox cnpj;
        private System.Windows.Forms.TextBox telefone;
    }
}