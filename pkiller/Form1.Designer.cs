using System.Drawing;

namespace pkiller
{
    partial class Pkiller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pkiller));
            this.killer = new System.Windows.Forms.Button();
            this.lab = new System.Windows.Forms.Label();
            this.tb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // killer
            // 
            this.killer.BackColor = System.Drawing.Color.Gray;
            this.killer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.killer.ForeColor = System.Drawing.Color.Yellow;
            this.killer.Location = new System.Drawing.Point(335, 48);
            this.killer.Name = "killer";
            this.killer.Size = new System.Drawing.Size(88, 37);
            this.killer.TabIndex = 0;
            this.killer.Text = "Kill";
            this.killer.UseVisualStyleBackColor = false;
            this.killer.Click += new System.EventHandler(this.Killer_Click);
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(212)))), ((int)(((byte)(96)))));
            this.lab.Location = new System.Drawing.Point(6, 52);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(134, 24);
            this.lab.TabIndex = 1;
            this.lab.Text = "Process Name";
            // 
            // tb
            // 
            this.tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tb.Location = new System.Drawing.Point(146, 52);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(160, 29);
            this.tb.TabIndex = 2;
            // 
            // Pkiller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(8)))), ((int)(((byte)(124)))));
            this.ClientSize = new System.Drawing.Size(435, 129);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.lab);
            this.Controls.Add(this.killer);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pkiller";
            this.Text = "Process Killer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button killer;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.TextBox tb;
    }
}

