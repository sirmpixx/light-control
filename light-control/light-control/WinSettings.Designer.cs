using System.Windows.Forms;

namespace light_control
{
    partial class WinSettings
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
            this.lblHUEIP = new System.Windows.Forms.Label();
            this.txtHueIP = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNoSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHUEIP
            // 
            this.lblHUEIP.AutoSize = true;
            this.lblHUEIP.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHUEIP.ForeColor = System.Drawing.Color.Snow;
            this.lblHUEIP.Location = new System.Drawing.Point(23, 38);
            this.lblHUEIP.Name = "lblHUEIP";
            this.lblHUEIP.Size = new System.Drawing.Size(139, 25);
            this.lblHUEIP.TabIndex = 0;
            this.lblHUEIP.Text = "Hue Bridge IP";
            this.lblHUEIP.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtHueIP
            // 
            this.txtHueIP.Font = new System.Drawing.Font("Roboto Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHueIP.Location = new System.Drawing.Point(323, 35);
            this.txtHueIP.Name = "txtHueIP";
            this.txtHueIP.Size = new System.Drawing.Size(185, 33);
            this.txtHueIP.TabIndex = 1;
            this.txtHueIP.Text = "192.168.X.X";
            this.txtHueIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(669, 381);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 43);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Speichern";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNoSave
            // 
            this.btnNoSave.BackColor = System.Drawing.Color.Maroon;
            this.btnNoSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNoSave.FlatAppearance.BorderSize = 0;
            this.btnNoSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoSave.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoSave.ForeColor = System.Drawing.Color.White;
            this.btnNoSave.Location = new System.Drawing.Point(551, 381);
            this.btnNoSave.Name = "btnNoSave";
            this.btnNoSave.Size = new System.Drawing.Size(112, 43);
            this.btnNoSave.TabIndex = 3;
            this.btnNoSave.Text = "Abbruch";
            this.btnNoSave.UseVisualStyleBackColor = false;
            this.btnNoSave.Click += new System.EventHandler(this.btnNoSave_Click);
            // 
            // WinSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNoSave);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtHueIP);
            this.Controls.Add(this.lblHUEIP);
            this.Name = "WinSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Einstellungen";
            this.Load += new System.EventHandler(this.WinSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHUEIP;
        private System.Windows.Forms.TextBox txtHueIP;
        private System.Windows.Forms.Button btnSave;
        private Button btnNoSave;
    }
}