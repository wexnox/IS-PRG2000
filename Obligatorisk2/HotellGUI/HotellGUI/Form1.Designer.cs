namespace HotellGUI
{
    partial class Gui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gui));
            this.LblBjarumHotels = new System.Windows.Forms.Label();
            this.txtRefkey = new System.Windows.Forms.TextBox();
            this.lblRefkey = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.Departure = new System.Windows.Forms.Label();
            this.calDep = new System.Windows.Forms.MonthCalendar();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.Arrival = new System.Windows.Forms.Label();
            this.calArrival = new System.Windows.Forms.MonthCalendar();
            this.lblKundenavn = new System.Windows.Forms.Label();
            this.txtKundenavn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Rooms = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TabRooms = new System.Windows.Forms.TabControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.TabRooms.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblBjarumHotels
            // 
            this.LblBjarumHotels.AutoSize = true;
            this.LblBjarumHotels.BackColor = System.Drawing.Color.Transparent;
            this.LblBjarumHotels.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBjarumHotels.Location = new System.Drawing.Point(3, 11);
            this.LblBjarumHotels.Name = "LblBjarumHotels";
            this.LblBjarumHotels.Size = new System.Drawing.Size(514, 46);
            this.LblBjarumHotels.TabIndex = 0;
            this.LblBjarumHotels.Text = "Berntzen Bed N\' Breakfast";
            // 
            // txtRefkey
            // 
            this.txtRefkey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRefkey.Location = new System.Drawing.Point(44, 1054);
            this.txtRefkey.Name = "txtRefkey";
            this.txtRefkey.Size = new System.Drawing.Size(202, 35);
            this.txtRefkey.TabIndex = 39;
            // 
            // lblRefkey
            // 
            this.lblRefkey.AutoSize = true;
            this.lblRefkey.BackColor = System.Drawing.Color.Transparent;
            this.lblRefkey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefkey.Location = new System.Drawing.Point(42, 1020);
            this.lblRefkey.Name = "lblRefkey";
            this.lblRefkey.Size = new System.Drawing.Size(93, 29);
            this.lblRefkey.TabIndex = 38;
            this.lblRefkey.Text = "Refkey";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(1218, 1266);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Padding = new System.Windows.Forms.Padding(6);
            this.lblMessage.Size = new System.Drawing.Size(12, 49);
            this.lblMessage.TabIndex = 37;
            this.lblMessage.Visible = false;
            // 
            // Departure
            // 
            this.Departure.AutoSize = true;
            this.Departure.BackColor = System.Drawing.Color.Transparent;
            this.Departure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Departure.Location = new System.Drawing.Point(844, 945);
            this.Departure.Name = "Departure";
            this.Departure.Size = new System.Drawing.Size(129, 29);
            this.Departure.TabIndex = 36;
            this.Departure.Text = "Departure";
            // 
            // calDep
            // 
            this.calDep.Location = new System.Drawing.Point(737, 980);
            this.calDep.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.calDep.Name = "calDep";
            this.calDep.TabIndex = 35;
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubmit.Location = new System.Drawing.Point(1128, 980);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(154, 43);
            this.BtnSubmit.TabIndex = 34;
            this.BtnSubmit.Text = "Submit";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // Arrival
            // 
            this.Arrival.AutoSize = true;
            this.Arrival.BackColor = System.Drawing.Color.Transparent;
            this.Arrival.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Arrival.Location = new System.Drawing.Point(510, 945);
            this.Arrival.Name = "Arrival";
            this.Arrival.Size = new System.Drawing.Size(87, 29);
            this.Arrival.TabIndex = 33;
            this.Arrival.Text = "Arrival";
            // 
            // calArrival
            // 
            this.calArrival.Location = new System.Drawing.Point(374, 980);
            this.calArrival.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.calArrival.Name = "calArrival";
            this.calArrival.TabIndex = 32;
            // 
            // lblKundenavn
            // 
            this.lblKundenavn.AutoSize = true;
            this.lblKundenavn.BackColor = System.Drawing.Color.Transparent;
            this.lblKundenavn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKundenavn.Location = new System.Drawing.Point(42, 945);
            this.lblKundenavn.Name = "lblKundenavn";
            this.lblKundenavn.Size = new System.Drawing.Size(142, 29);
            this.lblKundenavn.TabIndex = 31;
            this.lblKundenavn.Text = "Kundenavn";
            // 
            // txtKundenavn
            // 
            this.txtKundenavn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKundenavn.Location = new System.Drawing.Point(44, 980);
            this.txtKundenavn.Name = "txtKundenavn";
            this.txtKundenavn.Size = new System.Drawing.Size(202, 35);
            this.txtKundenavn.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 47);
            this.label1.TabIndex = 40;
            this.label1.Text = "New Guest";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(560, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 29);
            this.label2.TabIndex = 43;
            this.label2.Text = "Arrival date";
            // 
            // Rooms
            // 
            this.Rooms.AutoSize = true;
            this.Rooms.BackColor = System.Drawing.Color.Transparent;
            this.Rooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rooms.Location = new System.Drawing.Point(1047, 114);
            this.Rooms.Name = "Rooms";
            this.Rooms.Size = new System.Drawing.Size(95, 29);
            this.Rooms.TabIndex = 42;
            this.Rooms.Text = "Rooms";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(472, 182);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(140, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 29);
            this.label3.TabIndex = 46;
            this.label3.Text = "Guests";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.LblBjarumHotels);
            this.panel1.Location = new System.Drawing.Point(14, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1400, 78);
            this.panel1.TabIndex = 47;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(40, 843);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1374, 78);
            this.panel2.TabIndex = 48;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(40, 148);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(362, 344);
            this.listBox1.TabIndex = 49;
            this.listBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDown);
            this.listBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseMove);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 667);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Etg2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 667);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Etg1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // TabRooms
            // 
            this.TabRooms.Controls.Add(this.tabPage1);
            this.TabRooms.Controls.Add(this.tabPage2);
            this.TabRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabRooms.Location = new System.Drawing.Point(849, 148);
            this.TabRooms.Margin = new System.Windows.Forms.Padding(2);
            this.TabRooms.Name = "TabRooms";
            this.TabRooms.SelectedIndex = 0;
            this.TabRooms.Size = new System.Drawing.Size(800, 700);
            this.TabRooms.TabIndex = 1;
            // 
            // Gui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(2032, 1322);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TabRooms);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Rooms);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.txtRefkey);
            this.Controls.Add(this.lblRefkey);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.Departure);
            this.Controls.Add(this.calDep);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.Arrival);
            this.Controls.Add(this.calArrival);
            this.Controls.Add(this.lblKundenavn);
            this.Controls.Add(this.txtKundenavn);
            this.Name = "Gui";
            this.Text = "Hotell Gui";
            this.Load += new System.EventHandler(this.GUI_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Gui_DragDrop);
            this.DragOver += new System.Windows.Forms.DragEventHandler(this.Gui_DragOver);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.TabRooms.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblBjarumHotels;
        private System.Windows.Forms.TextBox txtRefkey;
        private System.Windows.Forms.Label lblRefkey;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label Departure;
        private System.Windows.Forms.MonthCalendar calDep;
        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.Label Arrival;
        private System.Windows.Forms.MonthCalendar calArrival;
        private System.Windows.Forms.Label lblKundenavn;
        private System.Windows.Forms.TextBox txtKundenavn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Rooms;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl TabRooms;
    }
}

