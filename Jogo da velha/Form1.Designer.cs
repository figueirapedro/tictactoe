namespace Jogo_da_velha
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
            this.btn11 = new System.Windows.Forms.Button();
            this.btn12 = new System.Windows.Forms.Button();
            this.btn21 = new System.Windows.Forms.Button();
            this.btn22 = new System.Windows.Forms.Button();
            this.btn13 = new System.Windows.Forms.Button();
            this.btn23 = new System.Windows.Forms.Button();
            this.btn31 = new System.Windows.Forms.Button();
            this.btn32 = new System.Windows.Forms.Button();
            this.btn33 = new System.Windows.Forms.Button();
            this.txtjogada = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn11
            // 
            this.btn11.Location = new System.Drawing.Point(167, 38);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(107, 103);
            this.btn11.TabIndex = 0;
            this.btn11.UseVisualStyleBackColor = true;
            this.btn11.Click += new System.EventHandler(this.btn11_Click);
            // 
            // btn12
            // 
            this.btn12.Location = new System.Drawing.Point(288, 38);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(107, 103);
            this.btn12.TabIndex = 1;
            this.btn12.UseVisualStyleBackColor = true;
            this.btn12.Click += new System.EventHandler(this.btn12_Click);
            // 
            // btn21
            // 
            this.btn21.Location = new System.Drawing.Point(167, 166);
            this.btn21.Name = "btn21";
            this.btn21.Size = new System.Drawing.Size(107, 103);
            this.btn21.TabIndex = 3;
            this.btn21.UseVisualStyleBackColor = true;
            this.btn21.Click += new System.EventHandler(this.btn21_Click);
            // 
            // btn22
            // 
            this.btn22.Location = new System.Drawing.Point(288, 166);
            this.btn22.Name = "btn22";
            this.btn22.Size = new System.Drawing.Size(107, 103);
            this.btn22.TabIndex = 4;
            this.btn22.UseVisualStyleBackColor = true;
            this.btn22.Click += new System.EventHandler(this.btn22_Click);
            // 
            // btn13
            // 
            this.btn13.Location = new System.Drawing.Point(411, 38);
            this.btn13.Name = "btn13";
            this.btn13.Size = new System.Drawing.Size(107, 103);
            this.btn13.TabIndex = 5;
            this.btn13.UseVisualStyleBackColor = true;
            this.btn13.Click += new System.EventHandler(this.btn13_Click);
            // 
            // btn23
            // 
            this.btn23.Location = new System.Drawing.Point(411, 166);
            this.btn23.Name = "btn23";
            this.btn23.Size = new System.Drawing.Size(107, 103);
            this.btn23.TabIndex = 6;
            this.btn23.UseVisualStyleBackColor = true;
            this.btn23.Click += new System.EventHandler(this.btn23_Click);
            // 
            // btn31
            // 
            this.btn31.Location = new System.Drawing.Point(167, 291);
            this.btn31.Name = "btn31";
            this.btn31.Size = new System.Drawing.Size(107, 103);
            this.btn31.TabIndex = 7;
            this.btn31.UseVisualStyleBackColor = true;
            this.btn31.Click += new System.EventHandler(this.btn31_Click);
            // 
            // btn32
            // 
            this.btn32.Location = new System.Drawing.Point(288, 291);
            this.btn32.Name = "btn32";
            this.btn32.Size = new System.Drawing.Size(107, 103);
            this.btn32.TabIndex = 8;
            this.btn32.UseVisualStyleBackColor = true;
            this.btn32.Click += new System.EventHandler(this.btn32_Click);
            // 
            // btn33
            // 
            this.btn33.Location = new System.Drawing.Point(411, 291);
            this.btn33.Name = "btn33";
            this.btn33.Size = new System.Drawing.Size(107, 103);
            this.btn33.TabIndex = 9;
            this.btn33.UseVisualStyleBackColor = true;
            this.btn33.Click += new System.EventHandler(this.btn33_Click);
            // 
            // txtjogada
            // 
            this.txtjogada.AutoSize = true;
            this.txtjogada.Location = new System.Drawing.Point(49, 211);
            this.txtjogada.Name = "txtjogada";
            this.txtjogada.Size = new System.Drawing.Size(62, 13);
            this.txtjogada.TabIndex = 10;
            this.txtjogada.Text = "Nada ainda";
            this.txtjogada.Click += new System.EventHandler(this.txtjogada_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 435);
            this.Controls.Add(this.txtjogada);
            this.Controls.Add(this.btn33);
            this.Controls.Add(this.btn32);
            this.Controls.Add(this.btn31);
            this.Controls.Add(this.btn23);
            this.Controls.Add(this.btn13);
            this.Controls.Add(this.btn22);
            this.Controls.Add(this.btn21);
            this.Controls.Add(this.btn12);
            this.Controls.Add(this.btn11);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn11;
        private System.Windows.Forms.Button btn12;
        private System.Windows.Forms.Button btn21;
        private System.Windows.Forms.Button btn22;
        private System.Windows.Forms.Button btn13;
        private System.Windows.Forms.Button btn23;
        private System.Windows.Forms.Button btn31;
        private System.Windows.Forms.Button btn32;
        private System.Windows.Forms.Button btn33;
        private System.Windows.Forms.Label txtjogada;
    }
}

