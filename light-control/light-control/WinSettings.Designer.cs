using System.Windows.Forms;
using System.Xml;

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
            this.txtHueIP = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNoSave = new System.Windows.Forms.Button();
            this.tableSettings = new System.Windows.Forms.TableLayoutPanel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtGoveeAPI = new System.Windows.Forms.TextBox();
            this.txtElgatoIP = new System.Windows.Forms.TextBox();
            this.lblHue = new System.Windows.Forms.Label();
            this.lblElgato = new System.Windows.Forms.Label();
            this.lblGovee = new System.Windows.Forms.Label();
            this.lblPH1 = new System.Windows.Forms.Label();
            this.lblPH2 = new System.Windows.Forms.Label();
            this.tableSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtHueIP
            // 
            this.txtHueIP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHueIP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtHueIP.Font = new System.Drawing.Font("Roboto Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHueIP.ForeColor = System.Drawing.Color.White;
            this.txtHueIP.Location = new System.Drawing.Point(214, 18);
            this.txtHueIP.Name = "txtHueIP";
            this.txtHueIP.Size = new System.Drawing.Size(515, 33);
            this.txtHueIP.TabIndex = 1;
            this.txtHueIP.Text = "192.168.X.X";
            this.txtHueIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHueIP.TextChanged += new System.EventHandler(this.txtHueIP_TextChanged);
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
            // tableSettings
            // 
            this.tableSettings.ColumnCount = 2;
            this.tableSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableSettings.Controls.Add(this.textBox4, 1, 4);
            this.tableSettings.Controls.Add(this.textBox3, 1, 3);
            this.tableSettings.Controls.Add(this.txtGoveeAPI, 1, 2);
            this.tableSettings.Controls.Add(this.txtElgatoIP, 1, 1);
            this.tableSettings.Controls.Add(this.lblHue, 0, 0);
            this.tableSettings.Controls.Add(this.txtHueIP, 1, 0);
            this.tableSettings.Controls.Add(this.lblElgato, 0, 1);
            this.tableSettings.Controls.Add(this.lblGovee, 0, 2);
            this.tableSettings.Controls.Add(this.lblPH1, 0, 3);
            this.tableSettings.Controls.Add(this.lblPH2, 0, 4);
            this.tableSettings.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.tableSettings.ForeColor = System.Drawing.Color.Snow;
            this.tableSettings.Location = new System.Drawing.Point(26, 26);
            this.tableSettings.Name = "tableSettings";
            this.tableSettings.RowCount = 5;
            this.tableSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableSettings.Size = new System.Drawing.Size(755, 349);
            this.tableSettings.TabIndex = 4;
            this.tableSettings.Paint += new System.Windows.Forms.PaintEventHandler(this.tableSettings_Paint);
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox4.Font = new System.Drawing.Font("Roboto Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(214, 296);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(515, 33);
            this.textBox4.TabIndex = 5;
            this.textBox4.Text = "192.168.X.X";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox3.Font = new System.Drawing.Font("Roboto Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(214, 225);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(515, 33);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "192.168.X.X";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGoveeAPI
            // 
            this.txtGoveeAPI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGoveeAPI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtGoveeAPI.Font = new System.Drawing.Font("Roboto Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGoveeAPI.ForeColor = System.Drawing.Color.White;
            this.txtGoveeAPI.Location = new System.Drawing.Point(214, 156);
            this.txtGoveeAPI.Name = "txtGoveeAPI";
            this.txtGoveeAPI.Size = new System.Drawing.Size(515, 33);
            this.txtGoveeAPI.TabIndex = 3;
            this.txtGoveeAPI.Text = "192.168.X.X";
            this.txtGoveeAPI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGoveeAPI.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtElgatoIP
            // 
            this.txtElgatoIP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtElgatoIP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtElgatoIP.Font = new System.Drawing.Font("Roboto Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtElgatoIP.ForeColor = System.Drawing.Color.White;
            this.txtElgatoIP.Location = new System.Drawing.Point(214, 87);
            this.txtElgatoIP.Name = "txtElgatoIP";
            this.txtElgatoIP.Size = new System.Drawing.Size(515, 33);
            this.txtElgatoIP.TabIndex = 2;
            this.txtElgatoIP.Text = "192.168.X.X";
            this.txtElgatoIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblHue
            // 
            this.lblHue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHue.AutoSize = true;
            this.lblHue.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHue.Location = new System.Drawing.Point(24, 22);
            this.lblHue.Name = "lblHue";
            this.lblHue.Size = new System.Drawing.Size(139, 25);
            this.lblHue.TabIndex = 0;
            this.lblHue.Text = "Hue Bridge IP";
            this.lblHue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHue.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblElgato
            // 
            this.lblElgato.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblElgato.AutoSize = true;
            this.lblElgato.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElgato.Location = new System.Drawing.Point(6, 91);
            this.lblElgato.Name = "lblElgato";
            this.lblElgato.Size = new System.Drawing.Size(175, 25);
            this.lblElgato.TabIndex = 0;
            this.lblElgato.Text = "Elgato Keylight IP";
            this.lblElgato.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblElgato.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblGovee
            // 
            this.lblGovee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGovee.AutoSize = true;
            this.lblGovee.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGovee.Location = new System.Drawing.Point(40, 160);
            this.lblGovee.Name = "lblGovee";
            this.lblGovee.Size = new System.Drawing.Size(108, 25);
            this.lblGovee.TabIndex = 0;
            this.lblGovee.Text = "Govee API";
            this.lblGovee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGovee.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPH1
            // 
            this.lblPH1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPH1.AutoSize = true;
            this.lblPH1.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPH1.Location = new System.Drawing.Point(24, 229);
            this.lblPH1.Name = "lblPH1";
            this.lblPH1.Size = new System.Drawing.Size(139, 25);
            this.lblPH1.TabIndex = 0;
            this.lblPH1.Text = "Placeholder";
            this.lblPH1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPH1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPH2
            // 
            this.lblPH2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPH2.AutoSize = true;
            this.lblPH2.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPH2.Location = new System.Drawing.Point(24, 300);
            this.lblPH2.Name = "lblPH2";
            this.lblPH2.Size = new System.Drawing.Size(139, 25);
            this.lblPH2.TabIndex = 0;
            this.lblPH2.Text = "Placeholder";
            this.lblPH2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPH2.Click += new System.EventHandler(this.label1_Click);
            // 
            // WinSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableSettings);
            this.Controls.Add(this.btnNoSave);
            this.Controls.Add(this.btnSave);
            this.Name = "WinSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Einstellungen";
            this.Load += new System.EventHandler(this.WinSettings_Load);
            this.tableSettings.ResumeLayout(false);
            this.tableSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtHueIP;
        private System.Windows.Forms.Button btnSave;
        private Button btnNoSave;
        private TableLayoutPanel tableSettings;
        private Label lblHue;
        private Label lblElgato;
        private Label lblGovee;
        private Label lblPH1;
        private Label lblPH2;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox txtGoveeAPI;
        private TextBox txtElgatoIP;
    }
}