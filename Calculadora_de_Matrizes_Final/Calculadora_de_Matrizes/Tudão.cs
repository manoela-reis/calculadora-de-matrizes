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
        private int espacoIntervaloY2 = 0;
        private int textBoxSize = 30;
        private int contadorDeColunas = 0;
        private bool checkboxMudou = true;
        private TextBox[,] textboxesResults;
        private TextBox[,] textBoxes2;
        int quantidade = 0;
        public Label label = new Label();
        

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
                            CreateResultado();
                            calcular.Enabled = true;

                        }

        }

        private void limpar_CheckedChanged(object sender, EventArgs e)
        {
            Clear();
        }

        private void calcular_CheckedChanged(object sender, EventArgs e)
        {
            calcular.Checked = false;
            calcular.Enabled = false;
            criar.Enabled = false;

            //Soma
            if (matrizSoma.Checked == true && criar.Checked == true)
            {
                for (int i = 0; i < linhas; i++)
                {
                    for (int j = 0; j < colunas; j++)
                    {
                        if (textBoxes[i, j].Text != "" | textBoxes2[i, j].Text != "")
                        {
                            Double tempres1 = Convert.ToDouble(textBoxes[i, j].Text) + Convert.ToDouble(textBoxes2[i, j].Text);

                            textboxesResults[i, j].Visible = true;
                            textboxesResults[i, j].Text = tempres1.ToString();
                        }

                        else
                        {
                            MessageBox.Show("Preencha todos os espaços da matriz.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            calcular.Checked = false;
                        }

                    }
                }
            }

            //Subtração
            if (matrizMenos.Checked == true && criar.Checked == true)
            {
                for (int i = 0; i < linhas; i++)
                {
                    for (int j = 0; j < colunas; j++)
                    {
                        if (textBoxes[i, j].Text != "" | textBoxes[i, j].Text != "")
                        {
                            Double tempres1 = Convert.ToDouble(textBoxes[i, j].Text) - Convert.ToDouble(textBoxes2[i, j].Text);

                            textboxesResults[i, j].Visible = true;
                            textboxesResults[i, j].Text = tempres1.ToString();
                        }

                        else
                        {
                            MessageBox.Show("Preencha todos os espaços da matriz.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            calcular.Checked = false;
                        }

                    }
                }

            }
            // Matriz x Matriz
            if (matrizVezes.Checked == true && criar.Checked == true)
            {
                /*                if (bt1.Text != "" && bt2.Text != "" && bt3.Text != "" && bt4.Text != "" && bt5.Text != "" && bt6.Text != "" && bt7.Text != "" && bt8.Text != "")
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
                                }*/
            }

            // Matriz . Numeral
            if (matrizNumeral.Checked == true && criar.Checked == true)
            {
                for (int i = 0; i < linhas; i++)
                {
                    for (int j = 0; j < colunas; j++)
                    {
                        if (textBoxes[i, j].Text != "" | bt10.Text != "")
                        {
                            Double tempres1 = Convert.ToDouble(textBoxes[i, j].Text) * Convert.ToDouble(bt10.Text);

                            textboxesResults[i, j].Visible = true;
                            textboxesResults[i, j].Text = tempres1.ToString();
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
                for (int i = 0; i < linhas; i++)
                {
                    for (int j = 0; j < colunas; j++)
                    {
                        if (textBoxes[i, j].Text != "")
                        {
                            Double tempres1 = Convert.ToDouble(textBoxes[i, j].Text);

                            textboxesResults[j, i].Visible = true;
                            textboxesResults[j, i].Text = tempres1.ToString();
                        }

                        else
                        {
                            MessageBox.Show("Preencha todos os espaços da matriz.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            calcular.Checked = false;
                        }

                    }
                }

            }

            // Oposta
            if (matrizOposta.Checked == true && criar.Checked == true)
            {
                for (int i = 0; i < linhas; i++)
                {
                    for (int j = 0; j < colunas; j++)
                    {
                        if (textBoxes[i, j].Text != "")
                        {
                            Double tempres1 = Convert.ToDouble(textBoxes[i, j].Text);

                            textboxesResults[i, j].Visible = true;
                            textboxesResults[i, j].Text = "-" + tempres1.ToString();
                        }

                        else
                        {
                            MessageBox.Show("Preencha todos os espaços da matriz.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            calcular.Checked = false;
                        }

                    }
                }

            }

            // Determinante
            if (Determinante.Checked == true) 
                //&& criar.Checked == true)
            {
                //deter2x2.Visible = true;
                //deter3x3.Visible = true;
             //     if (deter2x2.Checked == true && deter3x3.Checked == false)
              //    {
                     // Console.WriteLine("Entrou no determinante 2x2.");
                    //  bt1.Visible = true;
                   //   bt2.Visible = true;
                  //    bt3.Visible = true;
                 //     bt4.Visible = true;
                //
                      if (bt1.Text != "" && bt2.Text != "" && bt3.Text != "" && bt4.Text != "")
                      {
                          Double tempres1 = Convert.ToDouble(bt1.Text) * Convert.ToDouble(bt4.Text) - Convert.ToDouble(bt2.Text) * Convert.ToDouble(bt3.Text);

                          bt10.Visible = true;
                          igual2.Visible = true;
                          bt10.Text = tempres1.ToString();

                          bt1.Enabled = false;
                          bt2.Enabled = false;
                          bt3.Enabled = false;
                          bt4.Enabled = false;
                          bt10.Enabled = false;
                      }

                      else
                      {
                          MessageBox.Show("Preencha todos os espaços da matriz.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                          calcular.Checked = false;
                      }
                  }

                  if (deter2x2.Checked == false && deter3x3.Checked == true)
                  { 

                  }
            //}
        }

            //Inversa
      /*      if (matrizInversa.Checked == true && criar.Checked == true)
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
        }*/

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
                    textboxesResults[i, w].Text = "";
                    textboxesResults[i, w].Enabled = false;

                    //textBoxes[i, w].Visible = false; // não funciona, ou funciona 1 vez só'
                    Console.WriteLine("ENTROU NO LIMPAR");
                }
            }
            primeiro.Text = "";
            segundo.Text = "";
            bt10.Text = "";
            primeiro.Visible = false;
            segundo.Visible = false;
            criar.Checked = false;
            criar.Enabled = false;
            calcular.Enabled = false;
            calcular.Checked = false;

            menos.Visible = false;
            mais.Visible = false;
            multiplicacao.Visible = false;
            //igual.Visible = false;
            igual2.Visible = false;
            bt10.Visible = false;

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

       public void CreateMatriz(int quantidade, int posicaoMatriz1 , bool transposta, bool determinante)
       {
             this.quantidade = quantidade;

             if (determinante == false)
             {

                 linhas = Convert.ToInt32(primeiro.Text);
                 colunas = Convert.ToInt32(segundo.Text);
                 textBoxes = new TextBox[linhas, colunas];
                 textBoxes2 = new TextBox[linhas, colunas];
                 if (transposta == false)
                 {
                     textboxesResults = new TextBox[linhas, colunas];
                 }
                 else
                 {

                     textboxesResults = new TextBox[colunas, linhas];
                     Console.WriteLine("criou uma transposta");
                 }

                 for (int i = 0; i <= quantidade; i++)
                 {

                     Console.WriteLine("foii");
                     if (i == 1 && transposta == false)
                     {
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
                                 textBoxes[n, m].SetBounds(posicaoMatriz1 + espacoIntervaloX, 200 + espacoIntervaloY, textBoxSize, textBoxSize);
                                 textboxesResults[n, m] = new TextBox();
                                 textboxesResults[n, m].SetBounds(363 + espacoIntervaloX, 313 + espacoIntervaloY, textBoxSize, textBoxSize);

                                 textBoxes[n, m].TextChanged += new EventHandler(primeiro_TextChanged);
                                 Controls.Add(textBoxes[n, m]);
                                 textboxesResults[n, m].TextChanged += new EventHandler(primeiro_TextChanged);
                                 Controls.Add(textboxesResults[n, m]);

                                 textboxesResults[n, m].Visible = false;
                                 textboxesResults[n, m].Enabled = false;

                                 espacoIntervaloX += textBoxSize;
                                 contadorDeColunas++;
                             }

                         }
                         //mais.Left = posicaoMatriz1;
                         espacoIntervaloY = -30;
                     }
                     if (i == 1 && transposta == true)
                     {
                         for (int k = 0; k < linhas; k++)
                         {
                             for (int l = 0; l < colunas; l++)
                             {
                                 if (contadorDeColunas == colunas)
                                 {
                                     espacoIntervaloY += textBoxSize;
                                     espacoIntervaloX = 0;
                                     contadorDeColunas = 0;
                                 }


                                 textBoxes[k, l] = new TextBox();
                                 textBoxes[k, l].SetBounds(posicaoMatriz1 + espacoIntervaloX, 200 + espacoIntervaloY, textBoxSize, textBoxSize);

                                 textboxesResults[l, k] = new TextBox();
                                 textboxesResults[l, k].SetBounds(363 + textBoxSize * k, 313 + textBoxSize * l, textBoxSize, textBoxSize);

                                 textBoxes[k, l].TextChanged += new EventHandler(primeiro_TextChanged);
                                 Controls.Add(textBoxes[k, l]);

                                 //textboxesResults[k, l].TextChanged += new EventHandler(primeiro_TextChanged);
                                 Controls.Add(textboxesResults[l, k]);

                                 textboxesResults[l, k].Visible = true;
                                 textboxesResults[l, k].Enabled = true;

                                 espacoIntervaloX += textBoxSize;
                                 contadorDeColunas++;
                             }

                         }
                         espacoIntervaloY = -30;
                     }
                     if (i == 2)
                     {
                         for (int j = 0; j < linhas; j++)
                         {
                             for (int o = 0; o < colunas; o++)
                             {
                                 if (contadorDeColunas == colunas)
                                 {
                                     espacoIntervaloY += textBoxSize;
                                     espacoIntervaloX = 0;
                                     contadorDeColunas = 0;
                                 }

                                 textBoxes2[j, o] = new TextBox();
                                 textBoxes2[j, o].SetBounds(posicaoMatriz1 + 200 + espacoIntervaloX, 200 + espacoIntervaloY, textBoxSize, textBoxSize);

                                 textBoxes2[j, o].TextChanged += new EventHandler(primeiro_TextChanged);
                                 Controls.Add(textBoxes2[j, o]);
                                 textboxesResults[j, o].TextChanged += new EventHandler(primeiro_TextChanged);
                                 Controls.Add(textboxesResults[j, o]);

                                 textboxesResults[j, o].Visible = false;
                                 textboxesResults[j, o].Enabled = false;

                                 espacoIntervaloX += textBoxSize;
                                 contadorDeColunas++;
                             }

                         }
                         //else
                         //{
                         //    if(checkboxMudou)
                         //    textBoxes = new TextBox[0,0];
                         //    linhas = 0;
                         //    colunas = 0;
                         //}
                     }
                 }
             }
             else
             {

             }
              
                   Console.WriteLine("passou pelo criar matriz");
           
       }

        public void CreateResultado()
        {
            switch (Calculadora.currentMatriz)
            { 
                case MATRIZES.MATRIZ_SOMA:
                    // VAI RANDOMIZAR DUAS MATRIZES + O RESULTADO
                    //label.Text = "+";
                    //label.ForeColor = Color.DodgerBlue;
                    //label.Size.Width = 36;
                    //label.Size.Height = 37;
                    
                    CreateMatriz(2, 360, false,false);
                    
                    break;

                case MATRIZES.MATRIZ_MENOS:
                    // VAI RANDOMIZAR DUAS MATRIZES + O RESULTADO
                    CreateMatriz(2, 360, false, false);
                    break;

                case MATRIZES.MATRIZ_VEZES:
                    // VAI RANDOMIZAR DUAS MATRIZES + O RESULTADO

                    break;

                case MATRIZES.MATRIZ_NUMERAL:
                    // UMA SÓ + UM TEXTbOX + RESULTADO
                    CreateMatriz(1, 360, false,false);
                    break;

                case MATRIZES.MATRIZ_TRANSPOSTA:
                    // UMA E O RESULTADO
                    CreateMatriz(1, 360, true, false);

                    break;

                case MATRIZES.MATRIZ_OPOSTA:
                    // UMA E O RESULTADO
                    CreateMatriz(1, 360, false, false);

                    break;

                case MATRIZES.MATRIZ_INVERSA:
                    // UMA E O RESULTADO
                    CreateMatriz(1, 360, false, false);
                    break;

                case MATRIZES.MATRIZ_DETERMINANTE:
                    // 2X2 E 3X3 + RESULTADO
                 //   CreateMatriz(1, 360, false, true);
                    break;
            }

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
               // bt9.Enabled = false;

                matrizInversa.Enabled = false;

                bt10.Visible = true;

                primeiro.Visible = true;
                segundo.Visible = true;
                multiplicacao.Visible = true;

                primeiro.Enabled = true;
                segundo.Enabled = true;
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

                primeiro.Visible = true;
                segundo.Visible = true;
                mais.Visible = true;
             
                primeiro.Enabled = true;
                segundo.Enabled = true;

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

                           
                primeiro.Visible = true;
                segundo.Visible = true;
                menos.Visible = true;

                primeiro.Enabled = true;
                segundo.Enabled = true;
 
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


                
                primeiro.Visible = true;
                segundo.Visible = true;
                multiplicacao.Visible = true;

                primeiro.Enabled = true;
                segundo.Enabled = true;
                
                
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
               

                primeiro.Visible = true;
                segundo.Visible = true;
                
                primeiro.Enabled = true;
                segundo.Enabled = true;

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
            

                primeiro.Visible = true;
                segundo.Visible = true;

                primeiro.Enabled = true;
                segundo.Enabled = true;

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


                primeiro.Visible = true;
                segundo.Visible = true;

                primeiro.Enabled = true;
                segundo.Enabled = true;
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

        private void Determinante_CheckedChanged(object sender, EventArgs e)
        {
            Calculadora.currentMatriz = MATRIZES.MATRIZ_DETERMINANTE;
            matrizNumeral.Enabled = false;
            matrizMenos.Enabled = false;
            matrizSoma.Enabled = false;
            matrizOposta.Enabled = false;
            matrizTransposta.Enabled = false;
            matrizVezes.Enabled = false;
            Determinante.Enabled = false;
            criar.Enabled = true;
            matrizInversa.Enabled = false;
            
            
            
            deter2x2.Visible = true;
            deter3x3.Visible = true;

            if (deter2x2.Checked == true)
            {
                bt1.Visible = true;
            }
            //calcular.Enabled = true;

            //bt2.Visible = true;
            //bt4.Visible = true;
            //bt11.Visible = true;
            //bt10.Visible = true;

            /*bt1.Enabled = true;
            bt2.Enabled = true;
            bt3.Enabled = true;
            bt4.Enabled = true;
            bt5.Enabled = true;
            bt6.Enabled = true;
            bt7.Enabled = true;
            bt8.Enabled = true;*/
        }
    }        
}



    

