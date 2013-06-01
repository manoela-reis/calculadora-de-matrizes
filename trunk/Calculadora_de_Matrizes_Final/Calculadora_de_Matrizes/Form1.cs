using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Jogo_Hamilton
{
    public partial class Calculadora : Form
    {
        bool[] listaTesteMatriz = new bool[7];
        public int linhas;
        public int colunas;

        public Calculadora()
        {
            InitializeComponent();

        }

        private void criar_CheckedChanged(object sender, EventArgs e)
        {
                    listaTesteMatriz[0] = matrizOposta.Checked;
                    listaTesteMatriz[1] = matrizTransposta.Checked;
                    listaTesteMatriz[2] = matrizSoma.Checked;
                    listaTesteMatriz[3] = matrizMenos.Checked;
                    listaTesteMatriz[4] = matrizNumeral.Checked;
                    listaTesteMatriz[5] = matrizVezes.Checked;
                    listaTesteMatriz[6] = Determinante.Checked;
                              
                        if (listaTesteMatriz[1] == true && listaTesteMatriz[2] == true || listaTesteMatriz[1] == true && listaTesteMatriz[3] == true || listaTesteMatriz[1] == true && listaTesteMatriz[4] == true
                        || listaTesteMatriz[1] == true && listaTesteMatriz[5] == true || listaTesteMatriz[1] == true && listaTesteMatriz[6] == true || listaTesteMatriz[2] == true && listaTesteMatriz[1] == true
                        || listaTesteMatriz[2] == true && listaTesteMatriz[3] == true || listaTesteMatriz[2] == true && listaTesteMatriz[4] == true || listaTesteMatriz[2] == true && listaTesteMatriz[5] == true
                        || listaTesteMatriz[2] == true && listaTesteMatriz[6] == true || listaTesteMatriz[3] == true && listaTesteMatriz[1] == true || listaTesteMatriz[3] == true && listaTesteMatriz[2] == true
                        || listaTesteMatriz[3] == true && listaTesteMatriz[4] == true || listaTesteMatriz[3] == true && listaTesteMatriz[5] == true || listaTesteMatriz[3] == true && listaTesteMatriz[6] == true
                        || listaTesteMatriz[4] == true && listaTesteMatriz[1] == true || listaTesteMatriz[4] == true && listaTesteMatriz[2] == true || listaTesteMatriz[4] == true && listaTesteMatriz[3] == true
                        || listaTesteMatriz[4] == true && listaTesteMatriz[5] == true || listaTesteMatriz[4] == true && listaTesteMatriz[6] == true || listaTesteMatriz[5] == true && listaTesteMatriz[1] == true
                        || listaTesteMatriz[5] == true && listaTesteMatriz[2] == true || listaTesteMatriz[5] == true && listaTesteMatriz[3] == true || listaTesteMatriz[5] == true && listaTesteMatriz[4] == true
                        || listaTesteMatriz[5] == true && listaTesteMatriz[6] == true || listaTesteMatriz[6] == true && listaTesteMatriz[1] == true || listaTesteMatriz[6] == true && listaTesteMatriz[2] == true
                        || listaTesteMatriz[6] == true && listaTesteMatriz[3] == true || listaTesteMatriz[6] == true && listaTesteMatriz[4] == true || listaTesteMatriz[6] == true && listaTesteMatriz[5] == true)
                       
                //matriz.Checked == true && Determinante.Checked == true  )
                {

                    MessageBox.Show("Você não pode selecionar mais de uma matriz ao mesmo tempo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    criar.Checked = false;
                    calcular.Checked = false;
                    matrizSoma.Checked = false;
                    matrizMenos.Checked = false;
                    matrizVezes.Checked = false;
                    matrizNumeral.Checked = false;
                    matrizTransposta.Checked = false;
                    Determinante.Checked = false;
                    matrizOposta.Checked = false;

                }

            // matriz + matriz
            if (matrizSoma.Checked == true)
            {
                matrizNumeral.Enabled = false;
                matrizMenos.Enabled = false;
                matrizOposta.Enabled = false;
                matrizSoma.Enabled = false;
                matrizTransposta.Enabled = false;
                matrizVezes.Enabled = false;
                Determinante.Enabled = false;
                criar.Enabled = false;

                bt1.Enabled = true;
                bt2.Enabled = true;
                bt3.Enabled = true;
                bt4.Enabled = true;
                bt5.Enabled = true;
                bt6.Enabled = true;
                bt7.Enabled = true;
                bt8.Enabled = true;

                bt1.Visible = true;
                bt2.Visible = true;
                bt3.Visible = true;
                bt4.Visible = true;
                bt5.Visible = true;
                bt6.Visible = true;
                bt7.Visible = true;
                bt8.Visible = true;
                bt9.Visible = false;
                bt10.Visible = false;
                bt11.Visible = false;
                mais.Visible = true;
            }


            // matriz - matriz
            if (matrizMenos.Checked == true)
            {

                matrizNumeral.Enabled = false;
                matrizMenos.Enabled = false;
                matrizSoma.Enabled = false;
                matrizTransposta.Enabled = false;
                matrizVezes.Enabled = false;
                matrizOposta.Enabled = false;
                Determinante.Enabled = false;
                criar.Enabled = false;

                bt1.Visible = true;
                bt2.Visible = true;
                bt3.Visible = true;
                bt4.Visible = true;
                bt5.Visible = true;
                bt6.Visible = true;
                bt7.Visible = true;
                bt8.Visible = true;
                bt9.Visible = false;
                bt10.Visible = false;
                bt11.Visible = false;
                menos.Visible = true;

                bt1.Enabled = true;
                bt2.Enabled = true;
                bt3.Enabled = true;
                bt4.Enabled = true;
                bt5.Enabled = true;
                bt6.Enabled = true;
                bt7.Enabled = true;
                bt8.Enabled = true;



            }

            // matriz x matriz
            if (matrizVezes.Checked == true)
            {
                matrizNumeral.Enabled = false;
                matrizMenos.Enabled = false;
                matrizSoma.Enabled = false;
                matrizOposta.Enabled = false;
                matrizTransposta.Enabled = false;
                matrizVezes.Enabled = false;
                Determinante.Enabled = false;
                criar.Enabled = false;


                bt1.Visible = true;
                bt2.Visible = true;
                bt3.Visible = true;
                bt4.Visible = true;
                bt5.Visible = true;
                bt6.Visible = true;
                bt7.Visible = true;
                bt8.Visible = true;
                bt9.Visible = false;
                bt10.Visible = false;
                bt11.Visible = false;

                multiplicacao.Visible = true;

                bt1.Enabled = true;
                bt2.Enabled = true;
                bt3.Enabled = true;
                bt4.Enabled = true;
                bt5.Enabled = true;
                bt6.Enabled = true;
                bt7.Enabled = true;
                bt8.Enabled = true;

            }
            //matriz x numeral

            if (matrizNumeral.Checked == true)
            {
                matrizNumeral.Enabled = false;
                matrizMenos.Enabled = false;
                matrizSoma.Enabled = false;
                matrizTransposta.Enabled = false;
                matrizOposta.Enabled = false;
                matrizVezes.Enabled = false;
                Determinante.Enabled = false;
                criar.Enabled = false;

                bt1.Visible = true;
                bt2.Visible = true;
                bt3.Visible = true;
                bt4.Visible = true;
                bt9.Visible = true;
                multiplicacao.Visible = true;

                bt1.Enabled = true;
                bt2.Enabled = true;
                bt3.Enabled = true;
                bt4.Enabled = true;
                bt5.Enabled = true;
                bt6.Enabled = true;
                bt7.Enabled = true;
                bt8.Enabled = true;

            }

            // Transposta
            if (matrizTransposta.Checked == true)
            {
                matrizNumeral.Enabled = false;
                matrizMenos.Enabled = false;
                matrizSoma.Enabled = false;
                matrizOposta.Enabled = false;
                matrizTransposta.Enabled = false;
                matrizVezes.Enabled = false;
                Determinante.Enabled = false;
                criar.Enabled = false;

                bt1.Visible = true;
                bt2.Visible = true;
                bt3.Visible = true;
                bt4.Visible = true;

                bt1.Enabled = true;
                bt2.Enabled = true;
                bt3.Enabled = true;
                bt4.Enabled = true;
                bt5.Enabled = true;
                bt6.Enabled = true;
                bt7.Enabled = true;
                bt8.Enabled = true;

            }

            // Determinante
            if (Determinante.Checked == true)
            {
                matrizNumeral.Enabled = false;
                matrizMenos.Enabled = false;
                matrizSoma.Enabled = false;
                matrizOposta.Enabled = false;
                matrizTransposta.Enabled = false;
                matrizVezes.Enabled = false;
                Determinante.Enabled = false;
                criar.Enabled = false;

                bt2.Visible = true;
                bt4.Visible = true;
                bt11.Visible = true;
                bt10.Visible = true;

                bt1.Enabled = true;
                bt2.Enabled = true;
                bt3.Enabled = true;
                bt4.Enabled = true;
                bt5.Enabled = true;
                bt6.Enabled = true;
                bt7.Enabled = true;
                bt8.Enabled = true;
            }

            if (matrizOposta.Checked == true)
            {
                matrizNumeral.Enabled = false;
                matrizMenos.Enabled = false;
                matrizSoma.Enabled = false;
                matrizOposta.Enabled = false;
                matrizTransposta.Enabled = false;
                matrizVezes.Enabled = false;
                Determinante.Enabled = false;
                criar.Enabled = false;

                bt1.Visible = true;
                bt2.Visible = true;
                bt3.Visible = true;
                bt4.Visible = true;

                bt1.Enabled = true;
                bt2.Enabled = true;
                bt3.Enabled = true;
                bt4.Enabled = true;
                bt5.Enabled = true;
                bt6.Enabled = true;
                bt7.Enabled = true;
                bt8.Enabled = true;

            }





        }

        private void limpar_CheckedChanged(object sender, EventArgs e)
        {

            bt1.Visible = false;
            bt2.Visible = false;
            bt3.Visible = false;
            bt4.Visible = false;
            bt5.Visible = false;
            bt6.Visible = false;
            bt7.Visible = false;
            bt8.Visible = false;
            bt9.Visible = false;
            bt10.Visible = false;
            bt11.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox9.Visible = false;
            textBox8.Visible = false;
            textBox7.Visible = false;
            textBox6.Visible = false;

            bt1.Text = "";
            bt2.Text = "";
            bt3.Text = "";
            bt4.Text = "";
            bt5.Text = "";
            bt6.Text = "";
            bt7.Text = "";
            bt8.Text = "";
            bt9.Text = "";
            bt10.Text = "";
            bt11.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox9.Text = "";
            textBox8.Text = "";
            textBox7.Text = "";
            textBox6.Text = "";

            res1.Visible = false;
            res2.Visible = false;
            res3.Visible = false;
            res4.Visible = false;
            res5.Visible = false;

            res1.Text = "";
            res2.Text = "";
            res3.Text = "";
            res4.Text = "";
            res5.Text = "";

            matrizSoma.Checked = false;
            matrizMenos.Checked = false;
            matrizNumeral.Checked = false;
            matrizTransposta.Checked = false;
            matrizVezes.Checked = false;
            matrizOposta.Checked = false;
            Determinante.Checked = false;
            matrizInversa.Checked = false;

            matrizVezes.Enabled = true;
            matrizNumeral.Enabled = true;
            matrizSoma.Enabled = true;
            matrizOposta.Enabled = true;
            matrizInversa.Enabled = true;
            matrizTransposta.Enabled = true;
            matrizMenos.Enabled = true;
            Determinante.Enabled = true;
            
            menos.Visible = false;
            mais.Visible = false;
            multiplicacao.Visible = false;
            igual.Visible = false;
            igual2.Visible = false;

            limpar.Checked = false;
            criar.Checked = false;
            calcular.Checked = false;

            criar.Enabled = true;
        }

        private void calcular_CheckedChanged(object sender, EventArgs e)
        {
            //Soma
            if (matrizSoma.Checked == true && criar.Checked == true)
            {
                if (bt1.Text != "" && bt2.Text != "" && bt3.Text != "" && bt4.Text != "" && bt5.Text != "" && bt6.Text != "" && bt7.Text != "" && bt8.Text != "")
                {

                    Double tempres1 = Convert.ToDouble(bt1.Text) + Convert.ToDouble(bt5.Text);
                    Double tempres2 = Convert.ToDouble(bt2.Text) + Convert.ToDouble(bt6.Text);
                    Double tempres3 = Convert.ToDouble(bt3.Text) + Convert.ToDouble(bt7.Text);
                    Double tempres4 = Convert.ToDouble(bt4.Text) + Convert.ToDouble(bt8.Text);

                    res1.Visible = true;
                    res2.Visible = true;
                    res3.Visible = true;
                    res4.Visible = true;

                    res1.Text = tempres1.ToString();
                    res2.Text = tempres2.ToString();
                    res3.Text = tempres3.ToString();
                    res4.Text = tempres4.ToString();


                    bt1.Enabled = false;
                    bt2.Enabled = false;
                    bt3.Enabled = false;
                    bt4.Enabled = false;
                    bt5.Enabled = false;
                    bt6.Enabled = false;
                    bt7.Enabled = false;
                    bt8.Enabled = false;
                    
                    res1.Enabled = false;
                    res2.Enabled = false;
                    res3.Enabled = false;
                    res4.Enabled = false;

                }
                if (bt1.Text == "" || bt2.Text == "" || bt3.Text == "" || bt4.Text == "" || bt5.Text == "" || bt6.Text == "" || bt7.Text == "" || bt8.Text == "")
                {
                    MessageBox.Show("Preencha todos os espaços da matriz.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    calcular.Checked = false;
                }
                    
                
            }

            //Subtração
            if (matrizMenos.Checked == true && criar.Checked == true)
            {
                if (bt1.Text != "" && bt2.Text != "" && bt3.Text != "" && bt4.Text != "" && bt5.Text != "" && bt6.Text != "" && bt7.Text != "" && bt8.Text != "")
                {

                    Double tempres1 = Convert.ToDouble(bt1.Text) - Convert.ToDouble(bt5.Text);
                    Double tempres2 = Convert.ToDouble(bt2.Text) - Convert.ToDouble(bt6.Text);
                    Double tempres3 = Convert.ToDouble(bt3.Text) - Convert.ToDouble(bt7.Text);
                    Double tempres4 = Convert.ToDouble(bt4.Text) - Convert.ToDouble(bt8.Text);

                    textBox9.Visible = true;
                    textBox8.Visible = true;
                    textBox7.Visible = true;
                    textBox6.Visible = true;

                    textBox9.Text = tempres1.ToString();
                    textBox7.Text = tempres2.ToString();
                    textBox8.Text = tempres3.ToString();
                    textBox6.Text = tempres4.ToString();

                    bt1.Enabled = false;
                    bt2.Enabled = false;
                    bt3.Enabled = false;
                    bt4.Enabled = false;
                    bt5.Enabled = false;
                    bt6.Enabled = false;
                    bt7.Enabled = false;
                    bt8.Enabled = false;

                    textBox9.Enabled = false;
                    textBox8.Enabled = false;
                    textBox7.Enabled = false;
                    textBox6.Enabled = false;


                }

                else
                {
                    MessageBox.Show("Preencha todos os espaços da matriz.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    calcular.Checked = false;

                }


            }
            // Matriz x Matriz
            if (matrizVezes.Checked == true && criar.Checked == true)
            {
                if (bt1.Text != "" && bt2.Text != "" && bt3.Text != "" && bt4.Text != "" && bt5.Text != "" && bt6.Text != "" && bt7.Text != "" && bt8.Text != "")
                {

                    Double tempres1 = Convert.ToDouble(bt1.Text) * Convert.ToDouble(bt5.Text) + Convert.ToDouble(bt2.Text) * Convert.ToDouble(bt7.Text);
                    Double tempres2 = Convert.ToDouble(bt1.Text) * Convert.ToDouble(bt6.Text) + Convert.ToDouble(bt2.Text) * Convert.ToDouble(bt8.Text);
                    Double tempres3 = Convert.ToDouble(bt3.Text) * Convert.ToDouble(bt5.Text) + Convert.ToDouble(bt4.Text) * Convert.ToDouble(bt7.Text);
                    Double tempres4 = Convert.ToDouble(bt3.Text) * Convert.ToDouble(bt6.Text) + Convert.ToDouble(bt4.Text) * Convert.ToDouble(bt8.Text);

                    res1.Visible = true;
                    res2.Visible = true;
                    res3.Visible = true;
                    res4.Visible = true;

                    res1.Text = tempres1.ToString();
                    res2.Text = tempres2.ToString();
                    res3.Text = tempres3.ToString();
                    res4.Text = tempres4.ToString();

                    bt1.Enabled = false;
                    bt2.Enabled = false;
                    bt3.Enabled = false;
                    bt4.Enabled = false;
                    bt5.Enabled = false;
                    bt6.Enabled = false;
                    bt7.Enabled = false;
                    bt8.Enabled = false;


                    res1.Enabled = false;
                    res2.Enabled = false;
                    res3.Enabled = false;
                    res4.Enabled = false;


                }

                else
                {
                    MessageBox.Show("Preencha todos os espaços da matriz.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    calcular.Checked = false;
                }
            }

            // Matriz . Numeral
            if (matrizNumeral.Checked == true && criar.Checked == true)
            {
                if (bt1.Text != "" && bt2.Text != "" && bt3.Text != "" && bt4.Text != "" && bt9.Text != "")
                {

                    Double tempres1 = Convert.ToDouble(bt1.Text) * Convert.ToDouble(bt9.Text);
                    Double tempres2 = Convert.ToDouble(bt2.Text) * Convert.ToDouble(bt9.Text);
                    Double tempres3 = Convert.ToDouble(bt3.Text) * Convert.ToDouble(bt9.Text);
                    Double tempres4 = Convert.ToDouble(bt4.Text) * Convert.ToDouble(bt9.Text);

                    res1.Visible = true;
                    res2.Visible = true;
                    res3.Visible = true;
                    res4.Visible = true;

                    res1.Text = tempres1.ToString();
                    res2.Text = tempres2.ToString();
                    res3.Text = tempres3.ToString();
                    res4.Text = tempres4.ToString();

                    bt1.Enabled = false;
                    bt2.Enabled = false;
                    bt3.Enabled = false;
                    bt4.Enabled = false;
                    bt9.Enabled = false;

                    res1.Enabled = false;
                    res2.Enabled = false;
                    res3.Enabled = false;
                    res4.Enabled = false;


                }

                else
                {
                    MessageBox.Show("Preencha todos os espaços da matriz.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    calcular.Checked = false;
                }
            }

            // Transposta
            if (matrizTransposta.Checked == true && criar.Checked == true)
            {
                if (bt1.Text != "" && bt2.Text != "" && bt3.Text != "" && bt4.Text != "")
                {
                    bt5.Visible = true;
                    bt6.Visible = true;
                    bt7.Visible = true;
                    bt8.Visible = true;
                    igual2.Visible = true;

                    Double tempres1 = Convert.ToDouble(bt1.Text);
                    Double tempres2 = Convert.ToDouble(bt2.Text);
                    Double tempres3 = Convert.ToDouble(bt3.Text);
                    Double tempres4 = Convert.ToDouble(bt4.Text);

                    bt5.Text = tempres1.ToString();
                    bt6.Text = tempres3.ToString();
                    bt7.Text = tempres2.ToString();
                    bt8.Text = tempres4.ToString();
                    calcular.Checked = false;

                    bt5.Enabled = false;
                    bt6.Enabled = false;
                    bt7.Enabled = false;
                    bt8.Enabled = false;

                    res1.Enabled = false;
                    res2.Enabled = false;
                    res3.Enabled = false;
                    res4.Enabled = false;

                }

                else
                {
                    MessageBox.Show("Preencha todos os espaços da matriz.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    calcular.Checked = false;
                }


            }

            // Oposta
            if (matrizOposta.Checked == true && criar.Checked == true)
            {
                if (bt1.Text != "" && bt2.Text != "" && bt3.Text != "" && bt4.Text != "")
                {
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = true;
                    igual2.Visible = true;

                    Double tempres1 = -Convert.ToDouble(bt1.Text);
                    Double tempres2 = -Convert.ToDouble(bt2.Text);
                    Double tempres3 = -Convert.ToDouble(bt3.Text);
                    Double tempres4 = -Convert.ToDouble(bt4.Text);

                   textBox2.Text = tempres1.ToString();
                   textBox3.Text = tempres3.ToString();
                   textBox4.Text = tempres2.ToString();
                   textBox5.Text = tempres4.ToString();
                   calcular.Checked = false;

                    textBox2.Enabled = false;
                    textBox3.Enabled = false;
                    textBox4.Enabled = false;
                    textBox5.Enabled = false;

                   
                }

                else
                {
                    MessageBox.Show("Preencha todos os espaços da matriz.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    calcular.Checked = false;
                }


            }

            // Determinante
            if (Determinante.Checked == true && criar.Checked == true)
            {
                if (bt2.Text != "" && bt4.Text != "" && bt10.Text != "" && bt11.Text != "")
                {

                    Double tempres1 = Convert.ToDouble(bt2.Text) * Convert.ToDouble(bt11.Text) - Convert.ToDouble(bt4.Text) * Convert.ToDouble(bt10.Text);
                    
                        res5.Visible = true;
                        igual.Visible = true;
                        res5.Text = tempres1.ToString();

                        bt2.Enabled = false;
                        bt4.Enabled = false;
                        bt10.Enabled = false;
                        bt11.Enabled = false;
                    
                        res5.Enabled = false;
                    }
                   
                }

                else
                {
                    MessageBox.Show("Preencha todos os espaços da matriz.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    calcular.Checked = false;
                }

            //Inversa
            if (matrizInversa.Checked == true && criar.Checked == true)
            {
                bt1.Visible = true;
                bt2.Visible = true;
                bt3.Visible = true;
                bt4.Visible = true;

                if (bt2.Text != "" && bt4.Text != "" && bt3.Text != "" && bt1.Text != "")
                {
                   
                    Double tempres1 = Convert.ToDouble(bt1.Text) * Convert.ToDouble(bt4.Text) - Convert.ToDouble(bt2.Text) * Convert.ToDouble(bt3.Text);

                    if (tempres1 != 0)
                    {
                        //matriz dos cofatores... lembrando COF= (-1)i+j.mc
                        //os co fatores são:
                        //bt1 -bt2
                        //-bt3 bt4

                        textBox2.Visible = true;
                        textBox3.Visible = true;
                        textBox4.Visible = true;
                        textBox5.Visible = true;
                        igual2.Visible = true;

                        Double tempres2 = Convert.ToDouble(bt1.Text) / tempres1;
                        Double tempres3 = -Convert.ToDouble(bt2.Text) / tempres1;
                        Double tempres4 = -Convert.ToDouble(bt3.Text) / tempres1;
                        Double tempres5 = Convert.ToDouble(bt4.Text) / tempres1;


                        textBox2.Text = tempres2.ToString();
                        textBox4.Text = tempres3.ToString();
                        textBox3.Text = tempres5.ToString();
                        textBox5.Text = tempres4.ToString();

                        igual.Visible = true;
                        calcular.Checked = false;

                        textBox2.Enabled = false;
                        textBox3.Enabled = false;
                        textBox4.Enabled = false;
                        textBox5.Enabled = false;

                        bt2.Enabled = false;
                        bt1.Enabled = false;
                        bt3.Enabled = false;
                        bt4.Enabled = false;
                    }

                    else
                    {

                        MessageBox.Show("Não é possível obter uma matriz inversa. Favor Utilizar outros números.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        calcular.Checked = false;

                    }



                }



            }
            else
            {
                MessageBox.Show("Preencha todos os espaços da matriz.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                calcular.Checked = false;
            }

        }

        }



        
    }



    

