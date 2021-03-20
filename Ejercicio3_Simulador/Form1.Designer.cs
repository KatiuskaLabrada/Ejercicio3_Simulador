namespace Ejercicio3_Simulador
{
    partial class Form1
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
            this.titulo = new System.Windows.Forms.Label();
            this.lblCorrectResp = new System.Windows.Forms.Label();
            this.lblIncorrectResp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.correctRes = new System.Windows.Forms.TextBox();
            this.incorrectRes = new System.Windows.Forms.TextBox();
            this.finalScore = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(239, 41);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(226, 24);
            this.titulo.TabIndex = 0;
            this.titulo.Text = "Calculadora de puntaje";
            // 
            // lblCorrectResp
            // 
            this.lblCorrectResp.AutoSize = true;
            this.lblCorrectResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrectResp.Location = new System.Drawing.Point(39, 107);
            this.lblCorrectResp.Name = "lblCorrectResp";
            this.lblCorrectResp.Size = new System.Drawing.Size(230, 18);
            this.lblCorrectResp.TabIndex = 1;
            this.lblCorrectResp.Text = "Número de respuestas correctas:";
            // 
            // lblIncorrectResp
            // 
            this.lblIncorrectResp.AutoSize = true;
            this.lblIncorrectResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncorrectResp.Location = new System.Drawing.Point(39, 156);
            this.lblIncorrectResp.Name = "lblIncorrectResp";
            this.lblIncorrectResp.Size = new System.Drawing.Size(241, 18);
            this.lblIncorrectResp.TabIndex = 2;
            this.lblIncorrectResp.Text = "Número de respuestas incorrectas:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "El punta final obtenido es:";
            // 
            // correctRes
            // 
            this.correctRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correctRes.Location = new System.Drawing.Point(298, 101);
            this.correctRes.Name = "correctRes";
            this.correctRes.Size = new System.Drawing.Size(90, 24);
            this.correctRes.TabIndex = 4;
            // 
            // incorrectRes
            // 
            this.incorrectRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incorrectRes.Location = new System.Drawing.Point(298, 150);
            this.incorrectRes.Name = "incorrectRes";
            this.incorrectRes.Size = new System.Drawing.Size(90, 24);
            this.incorrectRes.TabIndex = 5;
            // 
            // finalScore
            // 
            this.finalScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalScore.Location = new System.Drawing.Point(314, 253);
            this.finalScore.Name = "finalScore";
            this.finalScore.Size = new System.Drawing.Size(90, 29);
            this.finalScore.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(608, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 45);
            this.button1.TabIndex = 7;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(608, 168);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 45);
            this.button2.TabIndex = 8;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(608, 237);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 45);
            this.button3.TabIndex = 9;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 349);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.finalScore);
            this.Controls.Add(this.incorrectRes);
            this.Controls.Add(this.correctRes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblIncorrectResp);
            this.Controls.Add(this.lblCorrectResp);
            this.Controls.Add(this.titulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Label lblCorrectResp;
        private System.Windows.Forms.Label lblIncorrectResp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox correctRes;
        private System.Windows.Forms.TextBox incorrectRes;
        private System.Windows.Forms.TextBox finalScore;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

