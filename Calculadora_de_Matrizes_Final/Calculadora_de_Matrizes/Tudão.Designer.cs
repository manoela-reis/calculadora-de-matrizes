namespace Jogo_Hamilton
{
    partial class Calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculadora));
            this.matrizMenos = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.matrizVezes = new System.Windows.Forms.CheckBox();
            this.matrizNumeral = new System.Windows.Forms.CheckBox();
            this.matrizSoma = new System.Windows.Forms.CheckBox();
            this.matrizTransposta = new System.Windows.Forms.CheckBox();
            this.Determinante = new System.Windows.Forms.CheckBox();
            this.criar = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.calcular = new System.Windows.Forms.CheckBox();
            this.mais = new System.Windows.Forms.Label();
            this.limpar = new System.Windows.Forms.CheckBox();
            this.menos = new System.Windows.Forms.Label();
            this.multiplicacao = new System.Windows.Forms.Label();
            this.igual = new System.Windows.Forms.Label();
            this.igual2 = new System.Windows.Forms.Label();
            this.matrizOposta = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.bt8 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.matrizInversa = new System.Windows.Forms.CheckBox();
            this.bt1 = new System.Windows.Forms.TextBox();
            this.bt3 = new System.Windows.Forms.TextBox();
            this.bt2 = new System.Windows.Forms.TextBox();
            this.bt4 = new System.Windows.Forms.TextBox();
            this.bt10 = new System.Windows.Forms.TextBox();
            this.bt11 = new System.Windows.Forms.TextBox();
            this.res1 = new System.Windows.Forms.TextBox();
            this.res2 = new System.Windows.Forms.TextBox();
            this.res3 = new System.Windows.Forms.TextBox();
            this.res4 = new System.Windows.Forms.TextBox();
            this.bt9 = new System.Windows.Forms.TextBox();
            this.bt7 = new System.Windows.Forms.TextBox();
            this.bt5 = new System.Windows.Forms.TextBox();
            this.bt6 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.res5 = new System.Windows.Forms.TextBox();
            this.primeiro = new System.Windows.Forms.MaskedTextBox();
            this.segundo = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // matrizMenos
            // 
            this.matrizMenos.AutoSize = true;
            this.matrizMenos.BackColor = System.Drawing.Color.Transparent;
            this.matrizMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matrizMenos.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.matrizMenos.Location = new System.Drawing.Point(12, 178);
            this.matrizMenos.Name = "matrizMenos";
            this.matrizMenos.Size = new System.Drawing.Size(180, 33);
            this.matrizMenos.TabIndex = 0;
            this.matrizMenos.Text = "Matriz - Matriz";
            this.matrizMenos.UseVisualStyleBackColor = false;
            this.matrizMenos.CheckedChanged += new System.EventHandler(this.matrizMenos_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(173, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(473, 91);
            this.label1.TabIndex = 5;
            this.label1.Text = "Calculadora";
            // 
            // matrizVezes
            // 
            this.matrizVezes.AutoSize = true;
            this.matrizVezes.BackColor = System.Drawing.Color.Transparent;
            this.matrizVezes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matrizVezes.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.matrizVezes.Location = new System.Drawing.Point(12, 217);
            this.matrizVezes.Name = "matrizVezes";
            this.matrizVezes.Size = new System.Drawing.Size(183, 33);
            this.matrizVezes.TabIndex = 6;
            this.matrizVezes.Text = "Matriz x Matriz";
            this.matrizVezes.UseVisualStyleBackColor = false;
            this.matrizVezes.CheckedChanged += new System.EventHandler(this.matrizVezes_CheckedChanged);
            // 
            // matrizNumeral
            // 
            this.matrizNumeral.AutoSize = true;
            this.matrizNumeral.BackColor = System.Drawing.Color.Transparent;
            this.matrizNumeral.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matrizNumeral.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.matrizNumeral.Location = new System.Drawing.Point(12, 256);
            this.matrizNumeral.Name = "matrizNumeral";
            this.matrizNumeral.Size = new System.Drawing.Size(211, 33);
            this.matrizNumeral.TabIndex = 7;
            this.matrizNumeral.Text = "Matriz x Numeral";
            this.matrizNumeral.UseVisualStyleBackColor = false;
            this.matrizNumeral.CheckedChanged += new System.EventHandler(this.matrizNumeral_CheckedChanged);
            // 
            // matrizSoma
            // 
            this.matrizSoma.AutoSize = true;
            this.matrizSoma.BackColor = System.Drawing.Color.Transparent;
            this.matrizSoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matrizSoma.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.matrizSoma.Location = new System.Drawing.Point(12, 139);
            this.matrizSoma.Name = "matrizSoma";
            this.matrizSoma.Size = new System.Drawing.Size(186, 33);
            this.matrizSoma.TabIndex = 9;
            this.matrizSoma.Text = "Matriz + Matriz";
            this.matrizSoma.UseVisualStyleBackColor = false;
            this.matrizSoma.CheckedChanged += new System.EventHandler(this.matrizSoma_CheckedChanged);
            // 
            // matrizTransposta
            // 
            this.matrizTransposta.AutoSize = true;
            this.matrizTransposta.BackColor = System.Drawing.Color.Transparent;
            this.matrizTransposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matrizTransposta.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.matrizTransposta.Location = new System.Drawing.Point(12, 295);
            this.matrizTransposta.Name = "matrizTransposta";
            this.matrizTransposta.Size = new System.Drawing.Size(223, 33);
            this.matrizTransposta.TabIndex = 10;
            this.matrizTransposta.Text = "Matriz Transposta";
            this.matrizTransposta.UseVisualStyleBackColor = false;
            this.matrizTransposta.CheckedChanged += new System.EventHandler(this.matrizTransposta_CheckedChanged);
            // 
            // Determinante
            // 
            this.Determinante.AutoSize = true;
            this.Determinante.BackColor = System.Drawing.Color.Transparent;
            this.Determinante.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Determinante.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Determinante.Location = new System.Drawing.Point(12, 334);
            this.Determinante.Name = "Determinante";
            this.Determinante.Size = new System.Drawing.Size(176, 33);
            this.Determinante.TabIndex = 11;
            this.Determinante.Text = "Determinante";
            this.Determinante.UseVisualStyleBackColor = false;
            // 
            // criar
            // 
            this.criar.AutoSize = true;
            this.criar.BackColor = System.Drawing.Color.Transparent;
            this.criar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.criar.ForeColor = System.Drawing.Color.DodgerBlue;
            this.criar.Location = new System.Drawing.Point(38, 451);
            this.criar.Name = "criar";
            this.criar.Size = new System.Drawing.Size(166, 33);
            this.criar.TabIndex = 14;
            this.criar.Text = "Criar Matriz";
            this.criar.UseVisualStyleBackColor = false;
            this.criar.CheckedChanged += new System.EventHandler(this.criar_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(8, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 40);
            this.label2.TabIndex = 15;
            this.label2.Text = "Selecione dentre as opções \r\nabaixo, a operação de sua escolha.";
            // 
            // calcular
            // 
            this.calcular.AutoSize = true;
            this.calcular.BackColor = System.Drawing.Color.Transparent;
            this.calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcular.ForeColor = System.Drawing.Color.DodgerBlue;
            this.calcular.Location = new System.Drawing.Point(285, 451);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(205, 33);
            this.calcular.TabIndex = 16;
            this.calcular.Text = "Calcular Matriz";
            this.calcular.UseVisualStyleBackColor = false;
            this.calcular.CheckedChanged += new System.EventHandler(this.calcular_CheckedChanged);
            // 
            // mais
            // 
            this.mais.AutoSize = true;
            this.mais.BackColor = System.Drawing.Color.Transparent;
            this.mais.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mais.ForeColor = System.Drawing.Color.DodgerBlue;
            this.mais.Location = new System.Drawing.Point(439, 202);
            this.mais.Name = "mais";
            this.mais.Size = new System.Drawing.Size(36, 37);
            this.mais.TabIndex = 33;
            this.mais.Text = "+";
            this.mais.Visible = false;
            // 
            // limpar
            // 
            this.limpar.AutoSize = true;
            this.limpar.BackColor = System.Drawing.Color.Transparent;
            this.limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpar.ForeColor = System.Drawing.Color.DodgerBlue;
            this.limpar.Location = new System.Drawing.Point(533, 451);
            this.limpar.Name = "limpar";
            this.limpar.Size = new System.Drawing.Size(112, 33);
            this.limpar.TabIndex = 35;
            this.limpar.Text = "Limpar";
            this.limpar.UseVisualStyleBackColor = false;
            this.limpar.CheckedChanged += new System.EventHandler(this.limpar_CheckedChanged);
            // 
            // menos
            // 
            this.menos.AutoSize = true;
            this.menos.BackColor = System.Drawing.Color.Transparent;
            this.menos.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menos.ForeColor = System.Drawing.Color.DodgerBlue;
            this.menos.Location = new System.Drawing.Point(439, 202);
            this.menos.Name = "menos";
            this.menos.Size = new System.Drawing.Size(27, 37);
            this.menos.TabIndex = 43;
            this.menos.Text = "-";
            this.menos.Visible = false;
            // 
            // multiplicacao
            // 
            this.multiplicacao.AutoSize = true;
            this.multiplicacao.BackColor = System.Drawing.Color.Transparent;
            this.multiplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplicacao.ForeColor = System.Drawing.Color.DodgerBlue;
            this.multiplicacao.Location = new System.Drawing.Point(439, 205);
            this.multiplicacao.Name = "multiplicacao";
            this.multiplicacao.Size = new System.Drawing.Size(32, 37);
            this.multiplicacao.TabIndex = 47;
            this.multiplicacao.Text = "x";
            this.multiplicacao.Visible = false;
            // 
            // igual
            // 
            this.igual.AutoSize = true;
            this.igual.BackColor = System.Drawing.Color.Transparent;
            this.igual.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igual.ForeColor = System.Drawing.Color.DodgerBlue;
            this.igual.Location = new System.Drawing.Point(495, 205);
            this.igual.Name = "igual";
            this.igual.Size = new System.Drawing.Size(36, 37);
            this.igual.TabIndex = 53;
            this.igual.Text = "=";
            this.igual.Visible = false;
            // 
            // igual2
            // 
            this.igual2.AutoSize = true;
            this.igual2.BackColor = System.Drawing.Color.Transparent;
            this.igual2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igual2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.igual2.Location = new System.Drawing.Point(435, 205);
            this.igual2.Name = "igual2";
            this.igual2.Size = new System.Drawing.Size(36, 37);
            this.igual2.TabIndex = 55;
            this.igual2.Text = "=";
            this.igual2.Visible = false;
            // 
            // matrizOposta
            // 
            this.matrizOposta.AutoSize = true;
            this.matrizOposta.BackColor = System.Drawing.Color.Transparent;
            this.matrizOposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matrizOposta.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.matrizOposta.Location = new System.Drawing.Point(12, 373);
            this.matrizOposta.Name = "matrizOposta";
            this.matrizOposta.Size = new System.Drawing.Size(180, 33);
            this.matrizOposta.TabIndex = 58;
            this.matrizOposta.Text = "Matriz Oposta";
            this.matrizOposta.UseVisualStyleBackColor = false;
            this.matrizOposta.CheckedChanged += new System.EventHandler(this.matrizOposta_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(484, 127);
            this.textBox1.MaximumSize = new System.Drawing.Size(4, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(0, 20);
            this.textBox1.TabIndex = 75;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(484, 182);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(60, 38);
            this.textBox2.TabIndex = 76;
            this.textBox2.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(484, 237);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(60, 38);
            this.textBox4.TabIndex = 77;
            this.textBox4.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(556, 182);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(60, 38);
            this.textBox3.TabIndex = 78;
            this.textBox3.Visible = false;
            // 
            // bt8
            // 
            this.bt8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt8.Location = new System.Drawing.Point(555, 237);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(60, 38);
            this.bt8.TabIndex = 79;
            this.bt8.Visible = false;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(442, 367);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(60, 38);
            this.textBox6.TabIndex = 83;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox6.Visible = false;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(442, 313);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(60, 38);
            this.textBox7.TabIndex = 82;
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox7.Visible = false;
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(370, 367);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(60, 38);
            this.textBox8.TabIndex = 81;
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox8.Visible = false;
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(370, 313);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(60, 38);
            this.textBox9.TabIndex = 80;
            this.textBox9.Visible = false;
            // 
            // matrizInversa
            // 
            this.matrizInversa.AutoSize = true;
            this.matrizInversa.BackColor = System.Drawing.Color.Transparent;
            this.matrizInversa.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matrizInversa.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.matrizInversa.Location = new System.Drawing.Point(13, 412);
            this.matrizInversa.Name = "matrizInversa";
            this.matrizInversa.Size = new System.Drawing.Size(179, 33);
            this.matrizInversa.TabIndex = 84;
            this.matrizInversa.Text = "Matriz Inversa";
            this.matrizInversa.UseVisualStyleBackColor = false;
            this.matrizInversa.CheckedChanged += new System.EventHandler(this.matrizInversa_CheckedChanged);
            // 
            // bt1
            // 
            this.bt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt1.Location = new System.Drawing.Point(287, 182);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(60, 38);
            this.bt1.TabIndex = 85;
            this.bt1.Visible = false;
            // 
            // bt3
            // 
            this.bt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt3.Location = new System.Drawing.Point(286, 236);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(60, 38);
            this.bt3.TabIndex = 86;
            this.bt3.Visible = false;
            // 
            // bt2
            // 
            this.bt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt2.Location = new System.Drawing.Point(363, 182);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(60, 38);
            this.bt2.TabIndex = 87;
            this.bt2.Visible = false;
            // 
            // bt4
            // 
            this.bt4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt4.Location = new System.Drawing.Point(363, 236);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(60, 38);
            this.bt4.TabIndex = 88;
            this.bt4.Visible = false;
            // 
            // bt10
            // 
            this.bt10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt10.Location = new System.Drawing.Point(429, 178);
            this.bt10.Name = "bt10";
            this.bt10.Size = new System.Drawing.Size(60, 38);
            this.bt10.TabIndex = 89;
            this.bt10.Visible = false;
            // 
            // bt11
            // 
            this.bt11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt11.Location = new System.Drawing.Point(429, 237);
            this.bt11.Name = "bt11";
            this.bt11.Size = new System.Drawing.Size(60, 38);
            this.bt11.TabIndex = 90;
            this.bt11.Visible = false;
            // 
            // res1
            // 
            this.res1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.res1.Location = new System.Drawing.Point(363, 313);
            this.res1.Name = "res1";
            this.res1.Size = new System.Drawing.Size(60, 38);
            this.res1.TabIndex = 91;
            this.res1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.res1.Visible = false;
            // 
            // res2
            // 
            this.res2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.res2.Location = new System.Drawing.Point(446, 313);
            this.res2.Name = "res2";
            this.res2.Size = new System.Drawing.Size(60, 38);
            this.res2.TabIndex = 92;
            this.res2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.res2.Visible = false;
            // 
            // res3
            // 
            this.res3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.res3.Location = new System.Drawing.Point(363, 360);
            this.res3.Name = "res3";
            this.res3.Size = new System.Drawing.Size(60, 38);
            this.res3.TabIndex = 93;
            this.res3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.res3.Visible = false;
            // 
            // res4
            // 
            this.res4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.res4.Location = new System.Drawing.Point(450, 360);
            this.res4.Name = "res4";
            this.res4.Size = new System.Drawing.Size(60, 38);
            this.res4.TabIndex = 94;
            this.res4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.res4.Visible = false;
            // 
            // bt9
            // 
            this.bt9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt9.Location = new System.Drawing.Point(485, 213);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(60, 38);
            this.bt9.TabIndex = 95;
            this.bt9.Visible = false;
            // 
            // bt7
            // 
            this.bt7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt7.Location = new System.Drawing.Point(485, 237);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(60, 38);
            this.bt7.TabIndex = 96;
            this.bt7.Visible = false;
            // 
            // bt5
            // 
            this.bt5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt5.Location = new System.Drawing.Point(481, 182);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(60, 38);
            this.bt5.TabIndex = 97;
            this.bt5.Visible = false;
            // 
            // bt6
            // 
            this.bt6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt6.Location = new System.Drawing.Point(549, 182);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(60, 38);
            this.bt6.TabIndex = 98;
            this.bt6.Visible = false;
            // 
            // textBox10
            // 
            this.textBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.Location = new System.Drawing.Point(550, 236);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(60, 38);
            this.textBox10.TabIndex = 99;
            this.textBox10.Visible = false;
            // 
            // res5
            // 
            this.res5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.res5.Location = new System.Drawing.Point(556, 212);
            this.res5.Name = "res5";
            this.res5.Size = new System.Drawing.Size(60, 38);
            this.res5.TabIndex = 100;
            this.res5.Visible = false;
            // 
            // primeiro
            // 
            this.primeiro.Location = new System.Drawing.Point(363, 139);
            this.primeiro.Name = "primeiro";
            this.primeiro.Size = new System.Drawing.Size(43, 20);
            this.primeiro.TabIndex = 101;
            this.primeiro.Visible = false;
            this.primeiro.TextChanged += new System.EventHandler(this.primeiro_TextChanged);
            // 
            // segundo
            // 
            this.segundo.Location = new System.Drawing.Point(442, 139);
            this.segundo.Name = "segundo";
            this.segundo.Size = new System.Drawing.Size(43, 20);
            this.segundo.TabIndex = 102;
            this.segundo.Visible = false;
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(682, 496);
            this.Controls.Add(this.segundo);
            this.Controls.Add(this.primeiro);
            this.Controls.Add(this.res5);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.bt6);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.bt7);
            this.Controls.Add(this.bt9);
            this.Controls.Add(this.res4);
            this.Controls.Add(this.res3);
            this.Controls.Add(this.res2);
            this.Controls.Add(this.res1);
            this.Controls.Add(this.bt11);
            this.Controls.Add(this.bt10);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.matrizInversa);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.bt8);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.matrizOposta);
            this.Controls.Add(this.igual2);
            this.Controls.Add(this.igual);
            this.Controls.Add(this.multiplicacao);
            this.Controls.Add(this.menos);
            this.Controls.Add(this.limpar);
            this.Controls.Add(this.mais);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.criar);
            this.Controls.Add(this.Determinante);
            this.Controls.Add(this.matrizTransposta);
            this.Controls.Add(this.matrizSoma);
            this.Controls.Add(this.matrizNumeral);
            this.Controls.Add(this.matrizVezes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.matrizMenos);
            this.Name = "Calculadora";
            this.Text = "Calculado de Matrizes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox matrizMenos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox matrizVezes;
        private System.Windows.Forms.CheckBox matrizNumeral;
        private System.Windows.Forms.CheckBox matrizSoma;
        private System.Windows.Forms.CheckBox matrizTransposta;
        private System.Windows.Forms.CheckBox Determinante;
        private System.Windows.Forms.CheckBox criar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox calcular;
        private System.Windows.Forms.Label mais;
        private System.Windows.Forms.CheckBox limpar;
        private System.Windows.Forms.Label menos;
        private System.Windows.Forms.Label multiplicacao;
        private System.Windows.Forms.Label igual;
        private System.Windows.Forms.Label igual2;
        private System.Windows.Forms.CheckBox matrizOposta;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox bt8;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.CheckBox matrizInversa;
        private System.Windows.Forms.TextBox bt1;
        private System.Windows.Forms.TextBox bt3;
        private System.Windows.Forms.TextBox bt2;
        private System.Windows.Forms.TextBox bt4;
        private System.Windows.Forms.TextBox bt10;
        private System.Windows.Forms.TextBox bt11;
        private System.Windows.Forms.TextBox res1;
        private System.Windows.Forms.TextBox res2;
        private System.Windows.Forms.TextBox res3;
        private System.Windows.Forms.TextBox res4;
        private System.Windows.Forms.TextBox bt9;
        private System.Windows.Forms.TextBox bt7;
        private System.Windows.Forms.TextBox bt5;
        private System.Windows.Forms.TextBox bt6;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox res5;
        private System.Windows.Forms.MaskedTextBox primeiro;
        private System.Windows.Forms.MaskedTextBox segundo;
    }
}

