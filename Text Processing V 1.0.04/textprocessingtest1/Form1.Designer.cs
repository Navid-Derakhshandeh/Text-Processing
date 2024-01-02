
namespace textprocessingtest1
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.listContain = new System.Windows.Forms.ListBox();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.getSummaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pannelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textMain = new System.Windows.Forms.TextBox();
            this.txtP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.scraperDataSet1 = new textprocessingtest1.scraperDataSet1();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFIW = new System.Windows.Forms.TextBox();
            this.txtSW = new System.Windows.Forms.TextBox();
            this.txtTW = new System.Windows.Forms.TextBox();
            this.txtFOW = new System.Windows.Forms.TextBox();
            this.txtFIW1 = new System.Windows.Forms.TextBox();
            this.txtSW1 = new System.Windows.Forms.TextBox();
            this.txtTW1 = new System.Windows.Forms.TextBox();
            this.txtFOW1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scraperDataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Cornsilk;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.button1.Location = new System.Drawing.Point(476, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.Color.Lavender;
            this.txtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.txtDate.Location = new System.Drawing.Point(126, 35);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(341, 27);
            this.txtDate.TabIndex = 1;
            // 
            // listContain
            // 
            this.listContain.BackColor = System.Drawing.Color.Linen;
            this.listContain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.listContain.FormattingEnabled = true;
            this.listContain.ItemHeight = 20;
            this.listContain.Location = new System.Drawing.Point(381, 159);
            this.listContain.Name = "listContain";
            this.listContain.ScrollAlwaysVisible = true;
            this.listContain.Size = new System.Drawing.Size(341, 224);
            this.listContain.TabIndex = 2;
            // 
            // txtLink
            // 
            this.txtLink.BackColor = System.Drawing.Color.Lavender;
            this.txtLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.txtLink.Location = new System.Drawing.Point(58, 107);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(409, 27);
            this.txtLink.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getSummaryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(753, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // getSummaryToolStripMenuItem
            // 
            this.getSummaryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pannelToolStripMenuItem});
            this.getSummaryToolStripMenuItem.Name = "getSummaryToolStripMenuItem";
            this.getSummaryToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.getSummaryToolStripMenuItem.Text = "Get Summary";
            // 
            // pannelToolStripMenuItem
            // 
            this.pannelToolStripMenuItem.Name = "pannelToolStripMenuItem";
            this.pannelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pannelToolStripMenuItem.Text = "Dashboard";
            this.pannelToolStripMenuItem.Click += new System.EventHandler(this.pannelToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Date/Time:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textMain
            // 
            this.textMain.BackColor = System.Drawing.Color.Linen;
            this.textMain.Location = new System.Drawing.Point(16, 159);
            this.textMain.Multiline = true;
            this.textMain.Name = "textMain";
            this.textMain.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textMain.Size = new System.Drawing.Size(359, 224);
            this.textMain.TabIndex = 7;
            // 
            // txtP
            // 
            this.txtP.BackColor = System.Drawing.Color.Lavender;
            this.txtP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.txtP.Location = new System.Drawing.Point(643, 35);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(100, 27);
            this.txtP.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(487, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Number of Paragraph:";
            // 
            // bindingSource1
            // 
            this.bindingSource1.AllowNew = true;
            this.bindingSource1.DataSource = this.scraperDataSet1;
            this.bindingSource1.Position = 0;
            // 
            // scraperDataSet1
            // 
            this.scraperDataSet1.DataSetName = "scraperDataSet1";
            this.scraperDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label3.Location = new System.Drawing.Point(4, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Link:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label4.Location = new System.Drawing.Point(12, 419);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "First Word: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label5.Location = new System.Drawing.Point(12, 476);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Second Word: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label6.Location = new System.Drawing.Point(12, 532);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 22);
            this.label6.TabIndex = 13;
            this.label6.Text = "Third Word: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label7.Location = new System.Drawing.Point(12, 584);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 22);
            this.label7.TabIndex = 14;
            this.label7.Text = "Fourth Word: ";
            // 
            // txtFIW
            // 
            this.txtFIW.BackColor = System.Drawing.Color.Pink;
            this.txtFIW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.txtFIW.Location = new System.Drawing.Point(160, 419);
            this.txtFIW.Name = "txtFIW";
            this.txtFIW.Size = new System.Drawing.Size(100, 27);
            this.txtFIW.TabIndex = 15;
            // 
            // txtSW
            // 
            this.txtSW.BackColor = System.Drawing.Color.Pink;
            this.txtSW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.txtSW.Location = new System.Drawing.Point(160, 476);
            this.txtSW.Name = "txtSW";
            this.txtSW.Size = new System.Drawing.Size(100, 27);
            this.txtSW.TabIndex = 16;
            // 
            // txtTW
            // 
            this.txtTW.BackColor = System.Drawing.Color.Pink;
            this.txtTW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.txtTW.Location = new System.Drawing.Point(160, 532);
            this.txtTW.Name = "txtTW";
            this.txtTW.Size = new System.Drawing.Size(100, 27);
            this.txtTW.TabIndex = 17;
            // 
            // txtFOW
            // 
            this.txtFOW.BackColor = System.Drawing.Color.Pink;
            this.txtFOW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.txtFOW.Location = new System.Drawing.Point(160, 584);
            this.txtFOW.Name = "txtFOW";
            this.txtFOW.Size = new System.Drawing.Size(100, 27);
            this.txtFOW.TabIndex = 18;
            // 
            // txtFIW1
            // 
            this.txtFIW1.BackColor = System.Drawing.Color.Thistle;
            this.txtFIW1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.txtFIW1.Location = new System.Drawing.Point(21, 30);
            this.txtFIW1.Name = "txtFIW1";
            this.txtFIW1.Size = new System.Drawing.Size(435, 27);
            this.txtFIW1.TabIndex = 19;
            // 
            // txtSW1
            // 
            this.txtSW1.BackColor = System.Drawing.Color.Thistle;
            this.txtSW1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.txtSW1.Location = new System.Drawing.Point(21, 87);
            this.txtSW1.Name = "txtSW1";
            this.txtSW1.Size = new System.Drawing.Size(435, 27);
            this.txtSW1.TabIndex = 20;
            this.txtSW1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtTW1
            // 
            this.txtTW1.BackColor = System.Drawing.Color.Thistle;
            this.txtTW1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.txtTW1.Location = new System.Drawing.Point(21, 143);
            this.txtTW1.Name = "txtTW1";
            this.txtTW1.Size = new System.Drawing.Size(435, 27);
            this.txtTW1.TabIndex = 21;
            // 
            // txtFOW1
            // 
            this.txtFOW1.BackColor = System.Drawing.Color.Thistle;
            this.txtFOW1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.txtFOW1.Location = new System.Drawing.Point(21, 195);
            this.txtFOW1.Name = "txtFOW1";
            this.txtFOW1.Size = new System.Drawing.Size(435, 27);
            this.txtFOW1.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.txtFIW1);
            this.groupBox1.Controls.Add(this.txtFOW1);
            this.groupBox1.Controls.Add(this.txtSW1);
            this.groupBox1.Controls.Add(this.txtTW1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.groupBox1.Location = new System.Drawing.Point(266, 389);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 237);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Description";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(753, 631);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtFOW);
            this.Controls.Add(this.txtTW);
            this.Controls.Add(this.txtSW);
            this.Controls.Add(this.txtFIW);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtP);
            this.Controls.Add(this.textMain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.listContain);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Tag = "description";
            this.Text = "Scraper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scraperDataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.ListBox listContain;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem getSummaryToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textMain;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private scraperDataSet1 scraperDataSet1;
        private System.Windows.Forms.ToolStripMenuItem pannelToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFIW;
        private System.Windows.Forms.TextBox txtSW;
        private System.Windows.Forms.TextBox txtTW;
        private System.Windows.Forms.TextBox txtFOW;
        private System.Windows.Forms.TextBox txtFIW1;
        private System.Windows.Forms.TextBox txtSW1;
        private System.Windows.Forms.TextBox txtTW1;
        private System.Windows.Forms.TextBox txtFOW1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

