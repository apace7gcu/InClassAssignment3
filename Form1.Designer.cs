namespace InClassAssignment3
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textearthWeight = new System.Windows.Forms.TextBox();
            this.textmarsWeight = new System.Windows.Forms.TextBox();
            this.bttnConvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Enter your weight on Earth:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(95, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Your weight on Mars:";
            // 
            // textearthWeight
            // 
            this.textearthWeight.Location = new System.Drawing.Point(307, 50);
            this.textearthWeight.Name = "textearthWeight";
            this.textearthWeight.Size = new System.Drawing.Size(151, 20);
            this.textearthWeight.TabIndex = 2;
            // 
            // textmarsWeight
            // 
            this.textmarsWeight.Location = new System.Drawing.Point(307, 123);
            this.textmarsWeight.Name = "textmarsWeight";
            this.textmarsWeight.Size = new System.Drawing.Size(151, 20);
            this.textmarsWeight.TabIndex = 3;
            // 
            // bttnConvert
            // 
            this.bttnConvert.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttnConvert.Location = new System.Drawing.Point(418, 202);
            this.bttnConvert.Name = "bttnConvert";
            this.bttnConvert.Size = new System.Drawing.Size(75, 23);
            this.bttnConvert.TabIndex = 4;
            this.bttnConvert.Text = "Convert";
            this.bttnConvert.UseVisualStyleBackColor = false;
            this.bttnConvert.Click += new System.EventHandler(this.bttnConvert_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(575, 261);
            this.Controls.Add(this.bttnConvert);
            this.Controls.Add(this.textmarsWeight);
            this.Controls.Add(this.textearthWeight);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button convert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtearthWeight;
        private System.Windows.Forms.TextBox txtmarsWeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textearthWeight;
        private System.Windows.Forms.TextBox textmarsWeight;
        private System.Windows.Forms.Button bttnConvert;
    }
}

