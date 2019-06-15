namespace Obligatorisk1
{
    partial class ShipShooter
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShipShooter));
            this.Ship = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scoreboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ScoreCount = new System.Windows.Forms.Label();
            this.pbShip = new System.Windows.Forms.PictureBox();
            this.pbRowboat = new System.Windows.Forms.PictureBox();
            this.pbSailboat = new System.Windows.Forms.PictureBox();
            this.pbTorpedo = new System.Windows.Forms.PictureBox();
            this.pbSubmarine = new System.Windows.Forms.PictureBox();
            this.torpedotimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbShip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRowboat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSailboat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTorpedo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSubmarine)).BeginInit();
            this.SuspendLayout();
            // 
            // Ship
            // 
            this.Ship.Tick += new System.EventHandler(this.ShipTimer_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.scoreboardToolStripMenuItem,
            this.endGameToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1092, 31);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.restartToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(60, 29);
            this.startToolStripMenuItem.Text = "Start";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(182, 30);
            this.newGameToolStripMenuItem.Text = "New game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(182, 30);
            this.restartToolStripMenuItem.Text = "Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(182, 30);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // scoreboardToolStripMenuItem
            // 
            this.scoreboardToolStripMenuItem.Name = "scoreboardToolStripMenuItem";
            this.scoreboardToolStripMenuItem.Size = new System.Drawing.Size(116, 29);
            this.scoreboardToolStripMenuItem.Text = "Scoreboard";
            this.scoreboardToolStripMenuItem.Click += new System.EventHandler(this.scoreboardToolStripMenuItem_Click);
            // 
            // endGameToolStripMenuItem
            // 
            this.endGameToolStripMenuItem.Name = "endGameToolStripMenuItem";
            this.endGameToolStripMenuItem.Size = new System.Drawing.Size(105, 29);
            this.endGameToolStripMenuItem.Text = "End Game";
            this.endGameToolStripMenuItem.Click += new System.EventHandler(this.endGameToolStripMenuItem_Click);
            // 
            // ScoreCount
            // 
            this.ScoreCount.AutoSize = true;
            this.ScoreCount.BackColor = System.Drawing.Color.Transparent;
            this.ScoreCount.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreCount.Location = new System.Drawing.Point(12, 46);
            this.ScoreCount.Name = "ScoreCount";
            this.ScoreCount.Size = new System.Drawing.Size(126, 42);
            this.ScoreCount.TabIndex = 7;
            this.ScoreCount.Text = "Score:";
            // 
            // pbShip
            // 
            this.pbShip.BackColor = System.Drawing.Color.Transparent;
            this.pbShip.Image = ((System.Drawing.Image)(resources.GetObject("pbShip.Image")));
            this.pbShip.Location = new System.Drawing.Point(19, 72);
            this.pbShip.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pbShip.Name = "pbShip";
            this.pbShip.Size = new System.Drawing.Size(171, 185);
            this.pbShip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbShip.TabIndex = 2;
            this.pbShip.TabStop = false;
            // 
            // pbRowboat
            // 
            this.pbRowboat.BackColor = System.Drawing.Color.Transparent;
            this.pbRowboat.Image = ((System.Drawing.Image)(resources.GetObject("pbRowboat.Image")));
            this.pbRowboat.Location = new System.Drawing.Point(497, 437);
            this.pbRowboat.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pbRowboat.Name = "pbRowboat";
            this.pbRowboat.Size = new System.Drawing.Size(98, 75);
            this.pbRowboat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRowboat.TabIndex = 4;
            this.pbRowboat.TabStop = false;
            // 
            // pbSailboat
            // 
            this.pbSailboat.BackColor = System.Drawing.Color.Transparent;
            this.pbSailboat.Image = ((System.Drawing.Image)(resources.GetObject("pbSailboat.Image")));
            this.pbSailboat.Location = new System.Drawing.Point(263, 292);
            this.pbSailboat.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pbSailboat.Name = "pbSailboat";
            this.pbSailboat.Size = new System.Drawing.Size(112, 108);
            this.pbSailboat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSailboat.TabIndex = 3;
            this.pbSailboat.TabStop = false;
            // 
            // pbTorpedo
            // 
            this.pbTorpedo.BackColor = System.Drawing.Color.Transparent;
            this.pbTorpedo.Image = ((System.Drawing.Image)(resources.GetObject("pbTorpedo.Image")));
            this.pbTorpedo.Location = new System.Drawing.Point(510, 750);
            this.pbTorpedo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pbTorpedo.Name = "pbTorpedo";
            this.pbTorpedo.Size = new System.Drawing.Size(28, 62);
            this.pbTorpedo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTorpedo.TabIndex = 1;
            this.pbTorpedo.TabStop = false;
            // 
            // pbSubmarine
            // 
            this.pbSubmarine.BackColor = System.Drawing.Color.Transparent;
            this.pbSubmarine.Image = ((System.Drawing.Image)(resources.GetObject("pbSubmarine.Image")));
            this.pbSubmarine.Location = new System.Drawing.Point(425, 822);
            this.pbSubmarine.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pbSubmarine.Name = "pbSubmarine";
            this.pbSubmarine.Size = new System.Drawing.Size(186, 125);
            this.pbSubmarine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSubmarine.TabIndex = 0;
            this.pbSubmarine.TabStop = false;
            // 
            // torpedotimer
            // 
            this.torpedotimer.Interval = 5;
            this.torpedotimer.Tick += new System.EventHandler(this.torpedotimer_Tick);
            // 
            // ShipShooter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1092, 941);
            this.Controls.Add(this.pbSubmarine);
            this.Controls.Add(this.pbRowboat);
            this.Controls.Add(this.pbTorpedo);
            this.Controls.Add(this.ScoreCount);
            this.Controls.Add(this.pbSailboat);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pbShip);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "ShipShooter";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbShip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRowboat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSailboat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTorpedo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSubmarine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer Ship;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Label ScoreCount;
        private System.Windows.Forms.PictureBox pbShip;
        private System.Windows.Forms.PictureBox pbRowboat;
        private System.Windows.Forms.PictureBox pbSailboat;
        private System.Windows.Forms.PictureBox pbTorpedo;
        private System.Windows.Forms.PictureBox pbSubmarine;
        private System.Windows.Forms.Timer torpedotimer;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scoreboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem endGameToolStripMenuItem;
    }
}

