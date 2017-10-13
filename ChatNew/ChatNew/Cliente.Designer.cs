namespace ChatNew
{
    partial class Cliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPorta = new System.Windows.Forms.TextBox();
            this.btnCon = new System.Windows.Forms.Button();
            this.btnPar = new System.Windows.Forms.Button();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEnv = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(38, 20);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(135, 20);
            this.txtIP.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Porta:";
            // 
            // txtPorta
            // 
            this.txtPorta.Location = new System.Drawing.Point(53, 55);
            this.txtPorta.Name = "txtPorta";
            this.txtPorta.Size = new System.Drawing.Size(100, 20);
            this.txtPorta.TabIndex = 3;
            // 
            // btnCon
            // 
            this.btnCon.Location = new System.Drawing.Point(12, 90);
            this.btnCon.Name = "btnCon";
            this.btnCon.Size = new System.Drawing.Size(75, 23);
            this.btnCon.TabIndex = 4;
            this.btnCon.Text = "Conectar";
            this.btnCon.UseVisualStyleBackColor = true;
            this.btnCon.Click += new System.EventHandler(this.btnCon_Click);
            // 
            // btnPar
            // 
            this.btnPar.Location = new System.Drawing.Point(108, 90);
            this.btnPar.Name = "btnPar";
            this.btnPar.Size = new System.Drawing.Size(75, 23);
            this.btnPar.TabIndex = 5;
            this.btnPar.Text = "Parar";
            this.btnPar.UseVisualStyleBackColor = true;
            this.btnPar.Click += new System.EventHandler(this.btnPar_Click);
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(12, 284);
            this.txtCliente.Multiline = true;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(374, 53);
            this.txtCliente.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cliente:";
            // 
            // btnEnv
            // 
            this.btnEnv.Location = new System.Drawing.Point(12, 343);
            this.btnEnv.Name = "btnEnv";
            this.btnEnv.Size = new System.Drawing.Size(75, 23);
            this.btnEnv.TabIndex = 10;
            this.btnEnv.Text = "Enviar";
            this.btnEnv.UseVisualStyleBackColor = true;
            this.btnEnv.Click += new System.EventHandler(this.btnEnv_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Servidor:";
            // 
            // txtServidor
            // 
            this.txtServidor.Location = new System.Drawing.Point(12, 172);
            this.txtServidor.Multiline = true;
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(276, 57);
            this.txtServidor.TabIndex = 7;
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 396);
            this.Controls.Add(this.btnEnv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtServidor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPar);
            this.Controls.Add(this.btnCon);
            this.Controls.Add(this.txtPorta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.label1);
            this.Name = "Cliente";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPorta;
        private System.Windows.Forms.Button btnCon;
        private System.Windows.Forms.Button btnPar;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEnv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtServidor;
    }
}

