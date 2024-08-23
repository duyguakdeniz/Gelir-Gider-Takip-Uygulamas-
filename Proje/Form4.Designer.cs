namespace Proje
{
    partial class Form4
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_anasayfa = new System.Windows.Forms.Button();
            this.txt_gider_ekle = new System.Windows.Forms.TextBox();
            this.btn_gider_ekle = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.btn_anasayfa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(236, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Eklemek istediğiniz gider tipini yazınız:";
            // 
            // btn_anasayfa
            // 
            this.btn_anasayfa.BackColor = System.Drawing.Color.Linen;
            this.btn_anasayfa.Location = new System.Drawing.Point(12, 30);
            this.btn_anasayfa.Name = "btn_anasayfa";
            this.btn_anasayfa.Size = new System.Drawing.Size(159, 50);
            this.btn_anasayfa.TabIndex = 18;
            this.btn_anasayfa.Text = "Anasayfaya Dön";
            this.btn_anasayfa.UseVisualStyleBackColor = false;
            this.btn_anasayfa.Click += new System.EventHandler(this.btn_anasayfa_Click);
            // 
            // txt_gider_ekle
            // 
            this.txt_gider_ekle.Location = new System.Drawing.Point(241, 89);
            this.txt_gider_ekle.Multiline = true;
            this.txt_gider_ekle.Name = "txt_gider_ekle";
            this.txt_gider_ekle.Size = new System.Drawing.Size(218, 95);
            this.txt_gider_ekle.TabIndex = 7;
            // 
            // btn_gider_ekle
            // 
            this.btn_gider_ekle.BackColor = System.Drawing.Color.Tan;
            this.btn_gider_ekle.Location = new System.Drawing.Point(241, 203);
            this.btn_gider_ekle.Name = "btn_gider_ekle";
            this.btn_gider_ekle.Size = new System.Drawing.Size(159, 50);
            this.btn_gider_ekle.TabIndex = 19;
            this.btn_gider_ekle.Text = "Ekle";
            this.btn_gider_ekle.UseVisualStyleBackColor = false;
            this.btn_gider_ekle.Click += new System.EventHandler(this.btn_gider_ekle_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_gider_ekle);
            this.Controls.Add(this.txt_gider_ekle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gider Tipi Ekle";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_anasayfa;
        private System.Windows.Forms.TextBox txt_gider_ekle;
        private System.Windows.Forms.Button btn_gider_ekle;
    }
}