namespace Conversor
{
    partial class FrmCalculadora
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumeroArabico = new System.Windows.Forms.TextBox();
            this.txtNumeroRomano = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConverterParaRomano = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número Arábico:";
            // 
            // txtNumeroArabico
            // 
            this.txtNumeroArabico.Location = new System.Drawing.Point(199, 85);
            this.txtNumeroArabico.MaxLength = 6;
            this.txtNumeroArabico.Name = "txtNumeroArabico";
            this.txtNumeroArabico.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroArabico.TabIndex = 1;
            this.txtNumeroArabico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroArabico_KeyPress);
            // 
            // txtNumeroRomano
            // 
            this.txtNumeroRomano.Location = new System.Drawing.Point(199, 126);
            this.txtNumeroRomano.MaxLength = 20;
            this.txtNumeroRomano.Name = "txtNumeroRomano";
            this.txtNumeroRomano.ReadOnly = true;
            this.txtNumeroRomano.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroRomano.TabIndex = 3;
            this.txtNumeroRomano.TextChanged += new System.EventHandler(this.txtNumeroRomano_TextChanged);
            this.txtNumeroRomano.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroRomano_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Número Romano:";
            // 
            // btnConverterParaRomano
            // 
            this.btnConverterParaRomano.Location = new System.Drawing.Point(331, 85);
            this.btnConverterParaRomano.Name = "btnConverterParaRomano";
            this.btnConverterParaRomano.Size = new System.Drawing.Size(75, 23);
            this.btnConverterParaRomano.TabIndex = 4;
            this.btnConverterParaRomano.Text = "Converter";
            this.btnConverterParaRomano.UseVisualStyleBackColor = true;
            this.btnConverterParaRomano.Click += new System.EventHandler(this.btnConverterParaRomano_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(101, 187);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultado.Size = new System.Drawing.Size(521, 200);
            this.txtResultado.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(432, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Converter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnConverterParaRomano);
            this.Controls.Add(this.txtNumeroRomano);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumeroArabico);
            this.Controls.Add(this.label1);
            this.Name = "FrmCalculadora";
            this.Text = "Conversão Números Arábico x Romano";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumeroArabico;
        private System.Windows.Forms.TextBox txtNumeroRomano;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConverterParaRomano;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button button1;
    }
}

