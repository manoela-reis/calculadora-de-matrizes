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
        bool[] listaTesteMatriz = new bool[8];
        public int linhas;
        public int colunas;
        public TextBox[,] textBoxes;
        private int espacoIntervaloX = 0;
        private int espacoIntervaloY = 0;
        private int textBoxSize = 30;
        private int contadorDeColunas = 0;
        private bool checkboxMudou = true;
        private int[,] textboxesResults;

         static private MATRIZES currentMatriz;

        public Calculadora()
        {
            InitializeComponent();

            criar.Enabled = false;
            calcular.Enabled = false;
            limpar.Enabled = false;
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
                    listaTesteMatriz[7] = matrizInversa.Checked;

                              
                        if (listaTesteMatriz[1] == true && listaTesteMatriz[2] == true || listaTesteMatriz[1] == true && listaTesteMatriz[3] == true || listaTesteMatriz[1] == true && listaTesteMatriz[4] == true
                        || listaTesteMatriz[1] == true && listaTesteMatriz[5] == true || listaTesteMatriz[1] == true && listaTesteMatriz[6] == true || listaTesteMatriz[2] == true && listaTesteMatriz[1] == true
                        || listaTesteMatriz[2] == true && listaTesteMatriz[3] == true || listaTesteMatriz[2] == true && listaTesteMatriz[4] == true || listaTesteMatriz[2] == true && listaTesteMatriz[5] == true
                        || listaTesteMatriz[2] == true && listaTesteMatriz[6] == true || listaTesteMatriz[3] == true && listaTesteMatriz[1] == true || listaTesteMatriz[3] == true && listaTesteMatriz[2] == true
                        || listaTesteMatriz[3] == true && listaTesteMatriz[4] == true || listaTesteMatriz[3] == true && listaTesteMatriz[5] == true || listaTesteMatriz[3] == true && listaTesteMatriz[6] == true
                        || listaTesteMatriz[4] == true && listaTesteMatriz[1] == true || listaTesteMatriz[4] == true && listaTesteMatriz[2] == true || listaTesteMatriz[4] == true && listaTesteMatriz[3] == true
                        || listaTesteMatriz[4] == true && listaTesteMatriz[5] == true || listaTesteMatriz[4] == true && listaTesteMatriz[6] == true || listaTesteMatriz[5] == true && listaTesteMatriz[1] == true
                        || listaTesteMatriz[5] == true && listaTesteMatriz[2] == true || listaTesteMatriz[5] == true && listaTesteMatriz[3] == true || listaTesteMatriz[5] == true && listaTesteMatriz[4] == true
                        || listaTesteMatriz[5] == true && listaTesteMatriz[6] == true || listaTesteMatriz[6] == true && listaTesteMatriz[1] == true || listaTesteMatriz[6] == true && listaTesteMatriz[2] == true
                        || listaTesteMatriz[6] == true && listaTesteMatriz[3] == true || listaTesteMatriz[6] == true && listaTesteMatriz[4] == true || listaTesteMatriz[6] == true && listaTesteMatriz[5] == true
                        || listaTesteMatriz[7] == true && listaTesteMatriz[0] == true || listaTesteMatriz[7] == true && listaTesteMatriz[1] == true || listaTesteMatriz[7] == true && listaTesteMatriz[2] == true
                        || listaTesteMatriz[7] == true && listaTesteMatriz[3] == true || listaTesteMatriz[7] == true && listaTesteMatriz[4] == true || listaTesteMatriz[7] == true && listaTesteMatriz[5] == true
                        || listaTesteMatriz[7] == true && listaTesteMatriz[6] == true || listaTesteMatriz[0] == true && listaTesteMatriz[1] == true || listaTesteMatriz[0] == true && listaTesteMatriz[2] == true
                        || listaTesteMatriz[0] == true && listaTesteMatriz[3] == true || listaTesteMatriz[0] == true && listaTesteMatriz[4] == true || listaTesteMatriz[0] == true && listaTesteMatriz[5] == true
                        || listaTesteMatriz[0] == true && listaTesteMatriz[6] == true)
                        
      
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
                    matrizInversa.Checked = false;

                    }

                        if (checkboxMudou == true)
                        {
                            checkboxMudou = false;
                            CreateMatriz();
                            calcular.Enabled = true;

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
                matrizInversa.Enabled = false;

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
            
        }

        private void limpar_CheckedChanged(object sender, EventArgs e)
        {
            Clear();

            //bt1.Visible = false;
            //bt2.Visible = false;
            //bt3.Visible = false;
            //bt4.Visible = false;
            //bt5.Visible = false;
            //bt6.Visible = false;
            //bt7.Visible = false;
            //bt8.Visible = false;
            bt9.Visible = false;
            //bt10.Visible = false;
            //bt11.Visible = false;
            //textBox2.Visible = false;
            //textBox4.Visible = false;
            //textBox3.Visible = false;
            //bt8.Visible = false;
            //textBox9.Visible = false;
            //textBox8.Visible = false;
            //textBox7.Visible = false;
            //textBox6.Visible = false;

            //bt1.Text = "";
            //bt2.Text = "";
            //bt3.Text = "";
            //bt4.Text = "";
            //bt5.Text = "";
            //bt6.Text = "";
            //bt7.Text = "";
            //bt8.Text = "";
            bt9.Text = "";
            //bt10.Text = "";
            //bt11.Text = "";
            //textBox2.Text = "";
            //textBox4.Text = "";
            //textBox3.Text = "";
            //bt8.Text = "";
            //textBox9.Text = "";
            //textBox8.Text = "";
            //textBox7.Text = "";
            //textBox6.Text = "";

            //res1.Visible = false;
            //res2.Visible = false;
            //res3.Visible = false;
            //res4.Visible = false;
            //res5.Visible = false;

            //res1.Text = "";
            //res2.Text = "";
            //res3.Text = "";
            //res4.Text = "";
            //res5.Text = "";

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
                if (bt1.Text == "" | bt2.Text == "" | bt3.Text == "" | bt4.Text == "" | bt5.Text == "" | bt6.Text == "" | bt7.Text == "" | bt8.Text == "")
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
                for (int i = 0; i < linhas; i++)
                {
                    for (int j = 0; j < colunas; j++)
                    {
                        if (textBoxes[i, j].Text != "")
                        {

                            Double tempres1 = Convert.ToDouble(textBoxes[i,j].Text) * Convert.ToDouble(bt9.Text);
                            //Double tempres2 = Convert.ToDouble(bt2.Text) * Convert.ToDouble(bt9.Text);
                            //Double tempres3 = Convert.ToDouble(bt3.Text) * Convert.ToDouble(bt9.Text);
                            //Double tempres4 = Convert.ToDouble(bt4.Text) * Convert.ToDouble(bt9.Text);

                            res1.Visible = true;
                            res2.Visible = true;
                            res3.Visible = true;
                            res4.Visible = true;

                            res1.Text = tempres1.ToString();
                            //res2.Text = tempres2.ToString();
                            //res3.Text = tempres3.ToString();
                            //res4.Text = tempres4.ToString();

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
                    textBox4.Visible = true;
                    textBox3.Visible = true;
                    bt8.Visible = true;
                    igual2.Visible = true;

                    Double tempres1 = -Convert.ToDouble(bt1.Text);
                    Double tempres2 = -Convert.ToDouble(bt2.Text);
                    Double tempres3 = -Convert.ToDouble(bt3.Text);
                    Double tempres4 = -Convert.ToDouble(bt4.Text);

                   textBox2.Text = tempres1.ToString();
                   textBox4.Text = tempres3.ToString();
                   textBox3.Text = tempres2.ToString();
                   bt8.Text = tempres4.ToString();
                   calcular.Checked = false;

                    textBox2.Enabled = false;
                    textBox4.Enabled = false;
                    textBox3.Enabled = false;
                    bt8.Enabled = false;

                   
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

                else
                {
                    MessageBox.Show("Preencha todos os espaços da matriz.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    calcular.Checked = false;
                }
            }

            //Inversa
            if (matrizInversa.Checked == true && criar.Checked == true)
            {

                if (bt2.Text != "" && bt4.Text != "" && bt3.Text != "" && bt1.Text != "")
                {
                    bt1.Visible = true;
                    bt2.Visible = true;
                    bt3.Visible = true;
                    bt4.Visible = true;

                    Double tempres1 = Convert.ToDouble(bt1.Text) * Convert.ToDouble(bt4.Text) - Convert.ToDouble(bt2.Text) * Convert.ToDouble(bt3.Text);

                    if (tempres1 != 0)
                    {
                        //matriz dos cofatores... lembrando COF= (-1)i+j.mc
                        //os co fatores são:
                        //bt4 -bt3
                        //-bt3 bt1

                        textBox2.Visible = true;
                        textBox4.Visible = true;
                        textBox3.Visible = true;
                        bt8.Visible = true;
                        igual2.Visible = true;

                        Double tempres2 = Convert.ToDouble(bt1.Text) / tempres1;
                        Double tempres3 = -Convert.ToDouble(bt2.Text) / tempres1;
                        Double tempres4 = -Convert.ToDouble(bt3.Text) / tempres1;
                        Double tempres5 = Convert.ToDouble(bt4.Text) / tempres1;


                        textBox2.Text = tempres5.ToString();
                        textBox3.Text = tempres4.ToString();
                        textBox4.Text = tempres3.ToString();
                        bt8.Text = tempres2.ToString();


                        calcular.Checked = false;

                        textBox2.Enabled = false;
                        textBox4.Enabled = false;
                        textBox3.Enabled = false;
                        bt8.Enabled = false;

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
                else
                {
                    MessageBox.Show("Preencha todos os espaços da matriz.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    calcular.Checked = false;
                }
            }
        }

        private void primeiro_TextChanged(object sender, EventArgs e)
        {

        }

       public void Clear()
        {
            for (int i = 0; i < linhas; i++)
            {
                for (int w = 0; w < colunas; w++)
                {
                    textBoxes[i, w].Text = "";
                    textBoxes[i, w].Enabled = false;
                    //textBoxes[i, w].Visible = false; // não funciona, ou funciona 1 vez só'
                    Console.WriteLine("ENTROU NO LIMPAR");
                }
            }
            primeiro.Text = "";
            segundo.Text = "";
            primeiro.Visible = false;
            segundo.Visible = false;
            criar.Checked = false;
            criar.Enabled = false;
            calcular.Enabled = false;
            calcular.Checked = false;

            menos.Visible = false;
            mais.Visible = false;
            multiplicacao.Visible = false;
            igual.Visible = false;
            igual2.Visible = false;

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

            limpar.Enabled = false;
            limpar.Checked = false;
        }

        public void CreateMatriz() {
                           
            linhas = Convert.ToInt32(primeiro.Text);
            colunas = Convert.ToInt32(segundo.Text);
            textBoxes = new TextBox[linhas, colunas]; 

                for (int n = 0; n < linhas; n++)
                {

                    for (int m = 0; m < colunas; m++)
                    {
                        if (contadorDeColunas == colunas)
                        {
                            espacoIntervaloY += textBoxSize;
                            espacoIntervaloX = 0;
                            contadorDeColunas = 0;
                        }

                        textBoxes[n, m] = new TextBox();
                        textBoxes[n, m].SetBounds(0 + espacoIntervaloX, 0 + espacoIntervaloY, textBoxSize, textBoxSize);


                        textBoxes[n, m].TextChanged += new EventHandler(primeiro_TextChanged);
                        Controls.Add(textBoxes[n, m]);
                        espacoIntervaloX += textBoxSize;
                        contadorDeColunas++;

                       
                    }
                    //else
                    //{
                    //    if(checkboxMudou)
                    //    textBoxes = new TextBox[0,0];
                    //    linhas = 0;
                    //    colunas = 0;
                    //}
                }
                Console.WriteLine("passou pelo criar matriz");
               
        }

        public void CreateResultado(int liness, int columnss)
        {

            switch (Calculadora.currentMatriz)
            { 
                case MATRIZES.MATRIZ_SOMA:
                    // VAI RANDOMIZAR DUAS MATRIZES + O RESULTADO

                    break;

                case MATRIZES.MATRIZ_MENOS:
                    // VAI RANDOMIZAR DUAS MATRIZES + O RESULTADO

                    break;

                case MATRIZES.MATRIZ_VEZES:
                    // VAI RANDOMIZAR DUAS MATRIZES + O RESULTADO

                    break;

                case MATRIZES.MATRIZ_NUMERAL:
                    // UMA SÓ + UM TEXTbOX + RESULTADO
                    break;

                case MATRIZES.MATRIZ_TRANSPOSTA:
                    // UMA E O RESULTADO

                    break;

                case MATRIZES.MATRIZ_OPOSTA:
                    // UMA E O RESULTADO

                    break;

                case MATRIZES.MATRIZ_INVERSA:
                    // UMA E O RESULTADO

                    break;

                case MATRIZES.MATRIZ_DETERMINANTE:
                    // 2X2 E 3X3 + RESULTADO

                    break;
            }


        }

        
        public int quantidadeDeMatrizes(int quantidade) {

            return quantidade;
        }

        private void matrizNumeral_CheckedChanged(object sender, EventArgs e)
        {
            //matriz x numeral

            Calculadora.currentMatriz = MATRIZES.MATRIZ_NUMERAL;
                matrizNumeral.Enabled = false;
                matrizMenos.Enabled = false;
                matrizSoma.Enabled = false;
                matrizTransposta.Enabled = false;
                matrizOposta.Enabled = false;
                matrizVezes.Enabled = false;
                Determinante.Enabled = false;
                criar.Enabled = true;
                limpar.Enabled = true;

                matrizInversa.Enabled = false;

                //bt1.Visible = true;
                //bt2.Visible = true;
                //bt3.Visible = true;
                //bt4.Visible = true;
                bt9.Visible = true;

                primeiro.Visible = true;
                segundo.Visible = true;
                multiplicacao.Visible = true;

                primeiro.Enabled = true;
                segundo.Enabled = true;
                //bt1.Enabled = true;
                //bt2.Enabled = true;
                //bt3.Enabled = true;
                //bt4.Enabled = true;
                //bt5.Enabled = true;
                //bt6.Enabled = true;
                //bt7.Enabled = true;
                //bt8.Enabled = true;

        }

        private void matrizSoma_CheckedChanged(object sender, EventArgs e)
        {
            // matriz + matriz

            Calculadora.currentMatriz = MATRIZES.MATRIZ_SOMA;
                matrizNumeral.Enabled = false;
                matrizMenos.Enabled = false;
                matrizOposta.Enabled = false;
                matrizSoma.Enabled = false;
                matrizTransposta.Enabled = false;
                matrizVezes.Enabled = false;
                Determinante.Enabled = false;
                criar.Enabled = true;
                limpar.Enabled = true;
                
                matrizInversa.Enabled = false;

                //bt1.Enabled = true;
                //bt2.Enabled = true;
                //bt3.Enabled = true;
                //bt4.Enabled = true;
                //bt5.Enabled = true;
                //bt6.Enabled = true;
                //bt7.Enabled = true;
                primeiro.Visible = true;
                segundo.Visible = true;
                mais.Visible = true;
             
                primeiro.Enabled = true;
                segundo.Enabled = true;


                //bt1.Visible = true;
                //bt2.Visible = true;
                //bt3.Visible = true;
                //bt4.Visible = true;
                //bt5.Visible = true;
                //bt6.Visible = true;
                //bt7.Visible = true;
                //bt8.Visible = true;
                //bt9.Visible = false;
                //bt10.Visible = false;
                //bt11.Visible = false;
            
            
        }

        private void matrizMenos_CheckedChanged(object sender, EventArgs e)
        {
            // matriz - matriz

            Calculadora.currentMatriz = MATRIZES.MATRIZ_MENOS;
                matrizNumeral.Enabled = false;
                matrizMenos.Enabled = false;
                matrizSoma.Enabled = false;
                matrizTransposta.Enabled = false;
                matrizVezes.Enabled = false;
                matrizOposta.Enabled = false;
                Determinante.Enabled = false;
                criar.Enabled = true;
                matrizInversa.Enabled = false;
                limpar.Enabled = true;

                //bt1.Visible = true;
                //bt2.Visible = true;
                //bt3.Visible = true;
                //bt4.Visible = true;
                //bt5.Visible = true;
                //bt6.Visible = true;
                //bt7.Visible = true;
                //bt8.Visible = true;
                //bt9.Visible = false;
                //bt10.Visible = false;
                //bt11.Visible = false;               
                primeiro.Visible = true;
                segundo.Visible = true;
                menos.Visible = true;

                primeiro.Enabled = true;
                segundo.Enabled = true;

                //bt1.Enabled = true;
                //bt2.Enabled = true;
                //bt3.Enabled = true;
                //bt4.Enabled = true;
                //bt5.Enabled = true;
                //bt6.Enabled = true;
                //bt7.Enabled = true;
                //bt8.Enabled = true;

        }

        private void matrizVezes_CheckedChanged(object sender, EventArgs e)
        {
            // matriz x matriz

            Calculadora.currentMatriz = MATRIZES.MATRIZ_VEZES;
                matrizNumeral.Enabled = false;
                matrizMenos.Enabled = false;
                matrizSoma.Enabled = false;
                matrizOposta.Enabled = false;
                matrizTransposta.Enabled = false;
                matrizVezes.Enabled = false;
                Determinante.Enabled = false;
                criar.Enabled = true;
                matrizInversa.Enabled = false;
                limpar.Enabled = true;


                //bt1.Visible = true;
                //bt2.Visible = true;
                //bt3.Visible = true;
                //bt4.Visible = true;
                //bt5.Visible = true;
                //bt6.Visible = true;
                //bt7.Visible = true;
                //bt8.Visible = true;
                //bt9.Visible = false;
                //bt10.Visible = false;
                //bt11.Visible = false;
                primeiro.Visible = true;
                segundo.Visible = true;
                multiplicacao.Visible = true;

                primeiro.Enabled = true;
                segundo.Enabled = true;
                
                //bt1.Enabled = true;
                //bt2.Enabled = true;
                //bt3.Enabled = true;
                //bt4.Enabled = true;
                //bt5.Enabled = true;
                //bt6.Enabled = true;
                //bt7.Enabled = true;
                //bt8.Enabled = true;
        }

        private void matrizTransposta_CheckedChanged(object sender, EventArgs e)
        {
            // Transposta

            Calculadora.currentMatriz = MATRIZES.MATRIZ_TRANSPOSTA;
                matrizNumeral.Enabled = false;
                matrizMenos.Enabled = false;
                matrizSoma.Enabled = false;
                matrizOposta.Enabled = false;
                matrizTransposta.Enabled = false;
                matrizVezes.Enabled = false;
                Determinante.Enabled = false;
                criar.Enabled = true;
                matrizInversa.Enabled = false;
                limpar.Enabled = true;
                //bt1.Visible = true;
                //bt2.Visible = true;
                //bt3.Visible = true;
                //bt4.Visible = true;

                primeiro.Visible = true;
                segundo.Visible = true;
                
                primeiro.Enabled = true;
                segundo.Enabled = true;

                //bt1.Enabled = true;
                //bt2.Enabled = true;
                //bt3.Enabled = true;
                //bt4.Enabled = true;
                //bt5.Enabled = true;
                //bt6.Enabled = true;
                //bt7.Enabled = true;
                //bt8.Enabled = true;
        }

        private void matrizOposta_CheckedChanged(object sender, EventArgs e)
        {
            //Oposta

                Calculadora.currentMatriz = MATRIZES.MATRIZ_OPOSTA;
                matrizNumeral.Enabled = false;
                matrizMenos.Enabled = false;
                matrizSoma.Enabled = false;
                matrizOposta.Enabled = false;
                matrizTransposta.Enabled = false;
                matrizVezes.Enabled = false;
                Determinante.Enabled = false;
                criar.Enabled = true;
                matrizInversa.Enabled = false;
                limpar.Enabled = true;
                //bt1.Visible = true;
                //bt2.Visible = true;
                //bt3.Visible = true;
                //bt4.Visible = true;



                primeiro.Visible = true;
                segundo.Visible = true;

                primeiro.Enabled = true;
                segundo.Enabled = true;

                //bt1.Enabled = true;
                //bt2.Enabled = true;
                //bt3.Enabled = true;
                //bt4.Enabled = true;
                //bt5.Enabled = true;
                //bt6.Enabled = true;
                //bt7.Enabled = true;
                //bt8.Enabled = true;
        }

        private void matrizInversa_CheckedChanged(object sender, EventArgs e)
        {
            //Inversa
                Calculadora.currentMatriz = MATRIZES.MATRIZ_INVERSA;
                matrizNumeral.Enabled = false;
                matrizMenos.Enabled = false;
                matrizSoma.Enabled = false;
                matrizOposta.Enabled = false;
                matrizTransposta.Enabled = false;
                matrizVezes.Enabled = false;
                Determinante.Enabled = false;
                criar.Enabled = true;
                limpar.Enabled = true;
                matrizInversa.Enabled = false;

                //bt1.Visible = true;
                //bt2.Visible = true;
                //bt3.Visible = true;
                //bt4.Visible = true;

                primeiro.Visible = true;
                segundo.Visible = true;

                primeiro.Enabled = true;
                segundo.Enabled = true;

                //bt1.Enabled = true;
                //bt2.Enabled = true;
                //bt3.Enabled = true;
                //bt4.Enabled = true;
        }

        public enum MATRIZES { 
        
            MATRIZ_VEZES,
            MATRIZ_NUMERAL,
            MATRIZ_SOMA,
            MATRIZ_MENOS,
            MATRIZ_TRANSPOSTA,
            MATRIZ_OPOSTA,
            MATRIZ_DETERMINANTE,
            MATRIZ_INVERSA
        }
    }        
}



    

