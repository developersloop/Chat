namespace ServerNew
{
    partial class Server
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
            this.txtPor = new System.Windows.Forms.TextBox();
            this.txtPorta = new System.Windows.Forms.Label();
            this.btnCon = new System.Windows.Forms.Button();
            this.btnPar = new System.Windows.Forms.Button();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP:";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(51, 21);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(115, 20);
            this.txtIP.TabIndex = 1;
            // 
            // txtPor
            // 
            this.txtPor.Location = new System.Drawing.Point(67, 58);
            this.txtPor.Name = "txtPor";
            this.txtPor.Size = new System.Drawing.Size(111, 20);
            this.txtPor.TabIndex = 3;
            // 
            // txtPorta
            // 
            this.txtPorta.AutoSize = true;
            this.txtPorta.Location = new System.Drawing.Point(26, 58);
            this.txtPorta.Name = "txtPorta";
            this.txtPorta.Size = new System.Drawing.Size(35, 13);
            this.txtPorta.TabIndex = 2;
            this.txtPorta.Text = "Porta:";
            // 
            // btnCon
            // 
            this.btnCon.Location = new System.Drawing.Point(29, 104);
            this.btnCon.Name = "btnCon";
            this.btnCon.Size = new System.Drawing.Size(75, 23);
            this.btnCon.TabIndex = 4;
            this.btnCon.Text = "Conectar";
            this.btnCon.UseVisualStyleBackColor = true;
            this.btnCon.Click += new System.EventHandler(this.btnCon_Click);
            // 
            // btnPar
            // 
            this.btnPar.Location = new System.Drawing.Point(171, 104);
            this.btnPar.Name = "btnPar";
            this.btnPar.Size = new System.Drawing.Size(75, 23);
            this.btnPar.TabIndex = 5;
            this.btnPar.Text = "Parar";
            this.btnPar.UseVisualStyleBackColor = true;
            this.btnPar.Click += new System.EventHandler(this.btnPar_Click);
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(29, 171);
            this.txtServer.Multiline = true;
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(348, 127);
            this.txtServer.TabIndex = 6;
            // 
            // FormServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 362);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.btnPar);
            this.Controls.Add(this.btnCon);
            this.Controls.Add(this.txtPor);
            this.Controls.Add(this.txtPorta);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.label1);
            this.Name = "FormServer";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtPor;
        private System.Windows.Forms.Label txtPorta;
        private System.Windows.Forms.Button btnCon;
        private System.Windows.Forms.Button btnPar;
        private System.Windows.Forms.TextBox txtServer;
    }
}

