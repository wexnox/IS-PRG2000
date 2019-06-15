namespace Obligatorisk1
{
    partial class LagreScore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LagreScore));
            this.lblNick = new System.Windows.Forms.Label();
            this.Nick = new System.Windows.Forms.TextBox();
            this.btnAvslutt = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNick
            // 
            this.lblNick.AutoSize = true;
            this.lblNick.BackColor = System.Drawing.Color.Transparent;
            this.lblNick.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNick.Location = new System.Drawing.Point(45, 11);
            this.lblNick.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNick.Name = "lblNick";
            this.lblNick.Size = new System.Drawing.Size(344, 42);
            this.lblNick.TabIndex = 2;
            this.lblNick.Text = "Skriv inn ditt navn";
            // 
            // Nick
            // 
            this.Nick.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nick.Location = new System.Drawing.Point(87, 100);
            this.Nick.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Nick.Name = "Nick";
            this.Nick.Size = new System.Drawing.Size(241, 42);
            this.Nick.TabIndex = 3;
            this.Nick.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAvslutt
            // 
            this.btnAvslutt.BackColor = System.Drawing.SystemColors.Control;
            this.btnAvslutt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAvslutt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAvslutt.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvslutt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAvslutt.Location = new System.Drawing.Point(15, 172);
            this.btnAvslutt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAvslutt.Name = "btnAvslutt";
            this.btnAvslutt.Size = new System.Drawing.Size(112, 52);
            this.btnAvslutt.TabIndex = 6;
            this.btnAvslutt.Text = "Avslutt";
            this.btnAvslutt.UseVisualStyleBackColor = false;
            this.btnAvslutt.Click += new System.EventHandler(this.btnAvslutt_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(296, 172);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 52);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(242, 304);
            this.lblScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(42, 42);
            this.lblScore.TabIndex = 8;
            this.lblScore.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 304);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 42);
            this.label1.TabIndex = 9;
            this.label1.Text = "Din Score:";
            // 
            // LagreScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(430, 441);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAvslutt);
            this.Controls.Add(this.Nick);
            this.Controls.Add(this.lblNick);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LagreScore";
            this.Text = "LagreScore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNick;
        private System.Windows.Forms.TextBox Nick;
        private System.Windows.Forms.Button btnAvslutt;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label label1;
    }
}