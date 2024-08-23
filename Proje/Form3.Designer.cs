namespace Proje
{
    partial class Form3
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
            this.btn_anasayfa = new System.Windows.Forms.Button();
            this.btn_istatistik = new System.Windows.Forms.Button();
            this.dateTimePickerReminder = new System.Windows.Forms.DateTimePicker();
            this.txtReminderMessage = new System.Windows.Forms.TextBox();
            this.btnAddReminder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.btn_istatistik);
            this.panel1.Controls.Add(this.btn_anasayfa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 357);
            this.panel1.TabIndex = 1;
            // 
            // btn_anasayfa
            // 
            this.btn_anasayfa.BackColor = System.Drawing.Color.Linen;
            this.btn_anasayfa.Location = new System.Drawing.Point(12, 22);
            this.btn_anasayfa.Name = "btn_anasayfa";
            this.btn_anasayfa.Size = new System.Drawing.Size(159, 50);
            this.btn_anasayfa.TabIndex = 17;
            this.btn_anasayfa.Text = "Anasayfaya Dön";
            this.btn_anasayfa.UseVisualStyleBackColor = false;
            this.btn_anasayfa.Click += new System.EventHandler(this.btn_anasayfa_Click);
            // 
            // btn_istatistik
            // 
            this.btn_istatistik.BackColor = System.Drawing.Color.Linen;
            this.btn_istatistik.Location = new System.Drawing.Point(12, 96);
            this.btn_istatistik.Name = "btn_istatistik";
            this.btn_istatistik.Size = new System.Drawing.Size(159, 50);
            this.btn_istatistik.TabIndex = 18;
            this.btn_istatistik.Text = "İstatistik Sayfasına Dön";
            this.btn_istatistik.UseVisualStyleBackColor = false;
            this.btn_istatistik.Click += new System.EventHandler(this.btn_istatistik_Click);
            // 
            // dateTimePickerReminder
            // 
            this.dateTimePickerReminder.Location = new System.Drawing.Point(412, 50);
            this.dateTimePickerReminder.Name = "dateTimePickerReminder";
            this.dateTimePickerReminder.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerReminder.TabIndex = 2;
            // 
            // txtReminderMessage
            // 
            this.txtReminderMessage.Location = new System.Drawing.Point(412, 96);
            this.txtReminderMessage.Multiline = true;
            this.txtReminderMessage.Name = "txtReminderMessage";
            this.txtReminderMessage.Size = new System.Drawing.Size(200, 89);
            this.txtReminderMessage.TabIndex = 3;
            // 
            // btnAddReminder
            // 
            this.btnAddReminder.BackColor = System.Drawing.Color.Tan;
            this.btnAddReminder.Location = new System.Drawing.Point(412, 214);
            this.btnAddReminder.Name = "btnAddReminder";
            this.btnAddReminder.Size = new System.Drawing.Size(152, 54);
            this.btnAddReminder.TabIndex = 4;
            this.btnAddReminder.Text = "Hatırlatıcı Ekle";
            this.btnAddReminder.UseVisualStyleBackColor = false;
            this.btnAddReminder.Click += new System.EventHandler(this.btnAddReminder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(329, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tarih:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(225, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hatırlatıcı Bildirimi:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(839, 357);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddReminder);
            this.Controls.Add(this.txtReminderMessage);
            this.Controls.Add(this.dateTimePickerReminder);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Otomatik Bildirimler ve Hatırlatıcılar";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_istatistik;
        private System.Windows.Forms.Button btn_anasayfa;
        private System.Windows.Forms.DateTimePicker dateTimePickerReminder;
        private System.Windows.Forms.TextBox txtReminderMessage;
        private System.Windows.Forms.Button btnAddReminder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}