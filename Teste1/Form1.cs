// PROFESSOR, OS CANDIDATOS SÃO: 10, 20 , 30  E 40 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste1
{
    public partial class Form1 : Form
    {
        Double valor_final=0;
        Double C_votos = 0;
        String X;
        Double rogerio;
        Double marcos;
        Double fabio;
        Double dida;


        public Form1()
        {
            InitializeComponent();
            }
        private void CONFIRMA(object sender, EventArgs e)
        {
            X = VOTO.Text;
            if (VOTO.Text.Length == 2)
            {
                switch (X)
                {
                    case "10":
                        rogerio = rogerio + 1;

                        break;
                    case "20":
                        marcos = marcos + 1;
                        break;
                    case "30":
                        fabio = fabio + 1;
                        break;
                    case "40":
                        dida = dida + 1;
                        break;
                }
                
                C_votos = C_votos + 1;
                MessageBox.Show("Voto computado");
                VOTO.Text = "";
                numero.Text = "";
                partido.Text = "";
                nome.Text = "";
                picturebox_1.Image = Properties.Resources.branco;
            }
        }
        private void NUMEROVOTO(object sender, EventArgs e)
        {
            X = VOTO.Text;
           
                if (VOTO.Text.Length == 2)
                {
                if(X == "10"|| X == "20" || X == "30" || X == "40")
                {
                    switch (X)
                    {

                        case "10":
                            picturebox_1.Image = Properties.Resources.rogerio;
                            numero.Text = "10";
                            partido.Text = "SPFC";
                            nome.Text = "ROGERIO CENI";
                            break;
                        case "20":
                            picturebox_1.Image = Properties.Resources.marcos;
                            numero.Text = "20";
                            partido.Text = "SEP";
                            nome.Text = "MARCOS";
                            break;
                        case "30":
                            picturebox_1.Image = Properties.Resources.fabio;
                            numero.Text = "30";
                            partido.Text = "SFC";
                            nome.Text = "FABIO COSTA";
                            break;
                        case "40":
                            picturebox_1.Image = Properties.Resources.dida;
                            numero.Text = "40";
                            partido.Text = "SCCP";
                            nome.Text = "DIDA";
                            break;
                    }
                        
                    }
                else
                {
                    MessageBox.Show("Candidato Inexistente");
                   

                }

                }

            }
        private void CORRIGE(object sender, EventArgs e)
        {
            VOTO.Text = "";
            numero.Text = "";
            partido.Text = "";
            nome.Text = "";
            picturebox_1.Image = Properties.Resources.branco;

        }
        private void BRANCO(object sender, EventArgs e)
        {
            C_votos = C_votos + 1;
            MessageBox.Show("Voto computado");
        }
        private void B_NUMERO(object sender, EventArgs e)
        {
            if (valor_final == 0)
            {
                VOTO.Text = (sender as Button).Text;
            }
            else
            {
                VOTO.Text = VOTO.Text + (sender as Button).Text;
            }
            valor_final = Convert.ToDouble(VOTO.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("Fim da votação!!!");
            MessageBox.Show("Total de votos: " + Convert.ToString(C_votos));
            MessageBox.Show("E o vencedor é...");
            if (rogerio >= marcos && rogerio >= fabio && rogerio >= dida)
            {
                MessageBox.Show("ROGERIO CENI do SPFC é o vencedor com " + Convert.ToString(rogerio) + " voto(s)");
            }
            if (marcos >= rogerio && marcos >= fabio && marcos >= dida)
            {
                MessageBox.Show("MARCOS do SEP é o vencedor com " + Convert.ToString(marcos) + " voto(s)");
            }
            if (fabio >= marcos && fabio >= rogerio && fabio >= dida)
            {
                MessageBox.Show("FABIO COSTA do SFC é o vencedor com " + Convert.ToString(fabio) + " voto(s)");
            }
            if (dida >= marcos && dida >= fabio && dida >= rogerio)
            {
                MessageBox.Show("DIDA do SSCP é o vencedor com " + Convert.ToString(dida) + " voto(s)");
            }
   
        }
    }
}
