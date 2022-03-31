
namespace cours_2
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
            this.textBox_mot = new System.Windows.Forms.TextBox();
            this.label_mot = new System.Windows.Forms.Label();
            this.button_trouverMot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_mot
            // 
            this.textBox_mot.Location = new System.Drawing.Point(86, 51);
            this.textBox_mot.Name = "textBox_mot";
            this.textBox_mot.Size = new System.Drawing.Size(126, 22);
            this.textBox_mot.TabIndex = 0;
            // 
            // label_mot
            // 
            this.label_mot.AutoSize = true;
            this.label_mot.Location = new System.Drawing.Point(45, 54);
            this.label_mot.Name = "label_mot";
            this.label_mot.Size = new System.Drawing.Size(35, 17);
            this.label_mot.TabIndex = 1;
            this.label_mot.Text = "Mot:";
            // 
            // button_trouverMot
            // 
            this.button_trouverMot.Location = new System.Drawing.Point(220, 49);
            this.button_trouverMot.Name = "button_trouverMot";
            this.button_trouverMot.Size = new System.Drawing.Size(222, 26);
            this.button_trouverMot.TabIndex = 2;
            this.button_trouverMot.Text = "Trouver le mot le plus proche";
            this.button_trouverMot.UseVisualStyleBackColor = true;
            this.button_trouverMot.Click += new System.EventHandler(this.button_trouverMot_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 125);
            this.Controls.Add(this.button_trouverMot);
            this.Controls.Add(this.label_mot);
            this.Controls.Add(this.textBox_mot);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_mot;
        private System.Windows.Forms.Label label_mot;
        private System.Windows.Forms.Button button_trouverMot;
    }
}

