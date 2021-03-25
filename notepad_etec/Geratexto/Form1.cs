using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;

namespace Geratexto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String name = "";
        String textoanterior = "";
        int truesize = 10;
        String html;
        public void Pegatxt()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Arquivo de Texto |*.txt";
            ofd.ShowDialog();
            if (string.IsNullOrEmpty(ofd.FileName) == false)
            {

                texto.Text = System.IO.File.ReadAllText(ofd.FileName);
                textoanterior = System.IO.File.ReadAllText(ofd.FileName);
              
                name = ofd.FileName;

            }
        }


        public void Salva(String txt) {
            string end = System.IO.Path.Combine(name);
            SaveFileDialog sfd = new SaveFileDialog();
            if (name != "" && textoanterior != txt)
            {

                if (MessageBox.Show("Deseja sobreescrever o arquivo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    System.IO.FileStream fs = new System.IO.FileStream(name, System.IO.FileMode.Create);
                    System.IO.StreamWriter gv = new System.IO.StreamWriter(fs);
                    gv.Write(txt);
                    gv.Close();
                    fs.Close();
                    textoanterior = txt;
                }
              
            }
            else
            {
                if (textoanterior == texto.Text)
                {
                    //não acontece nada
                }
                else
                {

                    sfd.Filter = "Arquivo de Texto | *.txt";
                    sfd.FilterIndex = 0;
                    sfd.RestoreDirectory = true;
                    if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        if (sfd.FileName != "")
                        {
                            System.IO.FileStream fs = new System.IO.FileStream(sfd.FileName, System.IO.FileMode.OpenOrCreate);
                            System.IO.StreamWriter gv = new System.IO.StreamWriter(fs);
                            gv.Write(txt);
                            gv.Close();
                            fs.Close();
                        }
                        else
                        {
                            MessageBox.Show("Digite um nome válido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                    }
                }
            }
            
        }



        public void Novo(String txt) {
            if (texto.Text != "") {
                Salva(texto.Text);
            }
           
            texto.Text = "";
        }



        public void fecha() {

            if (texto.Text != "")
            {
                Salva(texto.Text);
            }
            this.Close();
        }



        public void Imprime() {

    
            String size = Microsoft.VisualBasic.Interaction.InputBox("Qual tamanho da fonte na impressão? ", "10", "10", 150, 150);
            truesize = int.Parse(size);

            using (PrintDocument print = new PrintDocument())
            using (PrintPreviewDialog dialog = new PrintPreviewDialog())
            {
                print.PrintPage += Print_PrintPage;
                dialog.Document = print;
                dialog.ShowDialog();
            }

        }


        private void Print_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;

                        Font font = new Font("Baskerville Old Face", truesize, FontStyle.Bold);     
                       
                        Color minhaCor = Color.FromArgb(0, 0, 0);
                        SolidBrush brush = new SolidBrush(minhaCor);
          
                        g.DrawString(texto.Text, font, brush, 0, 0);
                       

                    

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            fecha();
        }

        private void novoToolStripButton_Click(object sender, EventArgs e)
        {
            Novo(texto.Text);
        }

        private void abrirToolStripButton_Click(object sender, EventArgs e)
        {
            Pegatxt();
        }

        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {
            Salva(texto.Text);
        }

        private void imprimirToolStripButton_Click(object sender, EventArgs e)
        {
            Imprime();
        }

        private void recortarToolStripButton_Click(object sender, EventArgs e)
        {
            texto.Cut();
        }

        private void copiarToolStripButton_Click(object sender, EventArgs e)
        {
            texto.Copy();
        }

        private void colarToolStripButton_Click(object sender, EventArgs e)
        {
            texto.Paste();
        }

        private void ajudaToolStripButton_Click(object sender, EventArgs e)
        {
            string letra = System.AppDomain.CurrentDomain.BaseDirectory.ToString().Substring(0, 2);
            using (System.IO.StreamReader file = new System.IO.StreamReader(Application.StartupPath + @"/arquivos/Ajuyda.txt", true))
            {

                MessageBox.Show(file.ReadToEnd(), "Ajuda");
                file.Close();
            }
        }

        private void texto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2) {

                if (texto.Text == "")
                {

                }
                else
                {

                    Form2 fmr = new Form2("http://" + texto.Text);
                    fmr.Show();
                }
            }

            if (e.KeyCode == Keys.F1)
            {
                string letra = System.AppDomain.CurrentDomain.BaseDirectory.ToString().Substring(0, 2);
               
                    html = "<Doctype HTML5>";
                    html += " <head>";
                    html += "<title>PAG NOVA</title>";
                    html += "</head>";
                    html += " <body>";
                    html += "<center><H1>ESSE MANO DISSE:</H1></center>";
                    html += "<br>";
                    html += "<p align='center'>" +texto.Text+ "</p>";
                    html += " </body>";

                    System.IO.FileStream fs = new System.IO.FileStream(Application.StartupPath + @"/arquivos/index.html", System.IO.FileMode.Create);
                    System.IO.StreamWriter gv = new System.IO.StreamWriter(fs);
                    gv.Write(html);
                    gv.Close();
                    fs.Close();

                    Form2 fmr = new Form2(Application.StartupPath + @"/arquivos/index.html");
                    fmr.Show();
                

            }

            if (e.KeyCode == Keys.F3)
            {
                if (name != "" && textoanterior != texto.Text)
                {

                    if (MessageBox.Show("Deseja mesmo carregar o arquivo básico de HTML sem salvar o conteúdo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //carrega
                        string letra = System.AppDomain.CurrentDomain.BaseDirectory.ToString().Substring(0, 2);
                        using (System.IO.StreamReader file = new System.IO.StreamReader(Application.StartupPath + @"/arquivos/base.html", true))
                        {

                            texto.Text = file.ReadToEnd();
                            file.Close();
                        }

                    }
                    else
                    {
                        Salva(texto.Text);
                        //carrega
                        string letra = System.AppDomain.CurrentDomain.BaseDirectory.ToString().Substring(0, 2);
                        using (System.IO.StreamReader file = new System.IO.StreamReader(Application.StartupPath + @"/arquivos/base.html", true))
                        {

                            texto.Text = file.ReadToEnd();
                            file.Close();
                        }
                    }
                }
                else {

                    //carrega
                    string letra = System.AppDomain.CurrentDomain.BaseDirectory.ToString().Substring(0, 2);
                    using (System.IO.StreamReader file = new System.IO.StreamReader(Application.StartupPath + @"/arquivos/base.html", true))
                    {

                        texto.Text = file.ReadToEnd();
                        file.Close();
                    }

                }

            }

            if (e.KeyCode == Keys.F6)
            {


                string end = System.IO.Path.Combine(name);
                SaveFileDialog sfd = new SaveFileDialog();
                if (name != "" && textoanterior != texto.Text)
                {

                  
                        System.IO.FileStream fs = new System.IO.FileStream(name, System.IO.FileMode.Create);
                        System.IO.StreamWriter gv = new System.IO.StreamWriter(fs);
                        gv.Write(texto.Text);
                        gv.Close();
                        fs.Close();
                        textoanterior = texto.Text;
                  
                    Form2 fmr = new Form2(name);
                    fmr.Show();

                }
                else
                {
                    if (textoanterior == texto.Text)
                    {
                        //não acontece nada
                    }
                    else
                    {

                        sfd.Filter = "Arquivo HTML | *.html";
                        sfd.FilterIndex = 0;
                        sfd.RestoreDirectory = true;
                        if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            if (sfd.FileName != "")
                            {
                                System.IO.FileStream fs = new System.IO.FileStream(sfd.FileName, System.IO.FileMode.OpenOrCreate);
                                System.IO.StreamWriter gv = new System.IO.StreamWriter(fs);
                                gv.Write(texto.Text);
                                name = sfd.FileName;
                                gv.Close();
                                fs.Close();
                                Form2 fmr = new Form2(name);
                                fmr.Show();
                            }
                            else
                            {
                                MessageBox.Show("Digite um nome válido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return;
                            }
                        }
                    }
                }


            }


            }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
