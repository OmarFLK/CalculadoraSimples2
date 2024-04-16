namespace CalculadoraSimples
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
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonVezes = new System.Windows.Forms.Button();
            this.buttonSoma = new System.Windows.Forms.Button();
            this.buttonSubtrai = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonCancela = new System.Windows.Forms.Button();
            this.buttonVirgula = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.buttonapagar = new System.Windows.Forms.Button();
            this.textBoxDisplay = new System.Windows.Forms.TextBox();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonEnter
            // 
            this.buttonEnter.BackColor = System.Drawing.Color.Gray;
            this.buttonEnter.Location = new System.Drawing.Point(370, 438);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(82, 170);
            this.buttonEnter.TabIndex = 1;
            this.buttonEnter.Text = "Enter";
            this.buttonEnter.UseVisualStyleBackColor = false;
            this.buttonEnter.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonVezes
            // 
            this.buttonVezes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonVezes.Location = new System.Drawing.Point(106, 526);
            this.buttonVezes.Name = "buttonVezes";
            this.buttonVezes.Size = new System.Drawing.Size(82, 82);
            this.buttonVezes.TabIndex = 2;
            this.buttonVezes.Text = "x";
            this.buttonVezes.UseVisualStyleBackColor = false;
            this.buttonVezes.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buttonSoma
            // 
            this.buttonSoma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonSoma.Location = new System.Drawing.Point(18, 526);
            this.buttonSoma.Name = "buttonSoma";
            this.buttonSoma.Size = new System.Drawing.Size(82, 82);
            this.buttonSoma.TabIndex = 3;
            this.buttonSoma.Text = "+";
            this.buttonSoma.UseVisualStyleBackColor = false;
            this.buttonSoma.Click += new System.EventHandler(this.buttonSoma_Click);
            // 
            // buttonSubtrai
            // 
            this.buttonSubtrai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonSubtrai.Location = new System.Drawing.Point(18, 438);
            this.buttonSubtrai.Name = "buttonSubtrai";
            this.buttonSubtrai.Size = new System.Drawing.Size(82, 82);
            this.buttonSubtrai.TabIndex = 4;
            this.buttonSubtrai.Text = "-";
            this.buttonSubtrai.UseVisualStyleBackColor = false;
            this.buttonSubtrai.Click += new System.EventHandler(this.buttonSubtrai_Click);
            // 
            // buttonDivide
            // 
            this.buttonDivide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonDivide.Location = new System.Drawing.Point(194, 526);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(82, 82);
            this.buttonDivide.TabIndex = 5;
            this.buttonDivide.Text = "/";
            this.buttonDivide.UseVisualStyleBackColor = false;
            this.buttonDivide.Click += new System.EventHandler(this.buttonDivide_Click);
            // 
            // buttonCancela
            // 
            this.buttonCancela.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonCancela.Location = new System.Drawing.Point(370, 262);
            this.buttonCancela.Name = "buttonCancela";
            this.buttonCancela.Size = new System.Drawing.Size(82, 82);
            this.buttonCancela.TabIndex = 6;
            this.buttonCancela.Text = "Del";
            this.buttonCancela.UseVisualStyleBackColor = false;
            this.buttonCancela.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // buttonVirgula
            // 
            this.buttonVirgula.BackColor = System.Drawing.Color.Silver;
            this.buttonVirgula.Location = new System.Drawing.Point(282, 526);
            this.buttonVirgula.Name = "buttonVirgula";
            this.buttonVirgula.Size = new System.Drawing.Size(82, 82);
            this.buttonVirgula.TabIndex = 7;
            this.buttonVirgula.Text = ",";
            this.buttonVirgula.UseVisualStyleBackColor = false;
            this.buttonVirgula.Click += new System.EventHandler(this.button2_Click);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.SystemColors.GrayText;
            this.button0.Location = new System.Drawing.Point(18, 350);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(82, 82);
            this.button0.TabIndex = 8;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GrayText;
            this.button1.Location = new System.Drawing.Point(106, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 82);
            this.button1.TabIndex = 9;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GrayText;
            this.button2.Location = new System.Drawing.Point(194, 262);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 82);
            this.button2.TabIndex = 10;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.GrayText;
            this.button5.Location = new System.Drawing.Point(194, 350);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(82, 82);
            this.button5.TabIndex = 11;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.GrayText;
            this.button4.Location = new System.Drawing.Point(282, 350);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 82);
            this.button4.TabIndex = 12;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GrayText;
            this.button3.Location = new System.Drawing.Point(282, 262);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 82);
            this.button3.TabIndex = 13;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.GrayText;
            this.button6.Location = new System.Drawing.Point(106, 350);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(82, 82);
            this.button6.TabIndex = 14;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.GrayText;
            this.button7.Location = new System.Drawing.Point(282, 438);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(82, 82);
            this.button7.TabIndex = 15;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.e3);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.GrayText;
            this.button8.Location = new System.Drawing.Point(194, 438);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(82, 82);
            this.button8.TabIndex = 16;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.GrayText;
            this.button9.Location = new System.Drawing.Point(106, 438);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(82, 82);
            this.button9.TabIndex = 17;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // buttonapagar
            // 
            this.buttonapagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonapagar.Location = new System.Drawing.Point(18, 262);
            this.buttonapagar.Name = "buttonapagar";
            this.buttonapagar.Size = new System.Drawing.Size(82, 82);
            this.buttonapagar.TabIndex = 18;
            this.buttonapagar.Text = "Cancel";
            this.buttonapagar.UseVisualStyleBackColor = false;
            this.buttonapagar.Click += new System.EventHandler(this.buttonapagar_Click);
            // 
            // textBoxDisplay
            // 
            this.textBoxDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDisplay.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxDisplay.Location = new System.Drawing.Point(18, 12);
            this.textBoxDisplay.Multiline = true;
            this.textBoxDisplay.Name = "textBoxDisplay";
            this.textBoxDisplay.Size = new System.Drawing.Size(434, 244);
            this.textBoxDisplay.TabIndex = 19;
            // 
            // buttonCopy
            // 
            this.buttonCopy.BackColor = System.Drawing.Color.Silver;
            this.buttonCopy.Location = new System.Drawing.Point(370, 350);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(82, 82);
            this.buttonCopy.TabIndex = 20;
            this.buttonCopy.Text = "Copy";
            this.buttonCopy.UseVisualStyleBackColor = false;
            this.buttonCopy.Click += new System.EventHandler(this.button10_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(472, 620);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.textBoxDisplay);
            this.Controls.Add(this.buttonapagar);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.buttonVirgula);
            this.Controls.Add(this.buttonCancela);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.buttonSubtrai);
            this.Controls.Add(this.buttonSoma);
            this.Controls.Add(this.buttonVezes);
            this.Controls.Add(this.buttonEnter);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button buttonVezes;
        private System.Windows.Forms.Button buttonSoma;
        private System.Windows.Forms.Button buttonSubtrai;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button buttonCancela;
        private System.Windows.Forms.Button buttonVirgula;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button buttonapagar;
        private System.Windows.Forms.TextBox textBoxDisplay;
        private System.Windows.Forms.Button buttonCopy;
    }
}

