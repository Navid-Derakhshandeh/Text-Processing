
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
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textMain = new System.Windows.Forms.TextBox();
            this.txtP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.scraperDataSet1 = new textprocessingtest1.scraperDataSet1();
            this.pannelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scraperDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.button1.Location = new System.Drawing.Point(476, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDate
            // 
            this.txtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.txtDate.Location = new System.Drawing.Point(126, 35);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(341, 27);
            this.txtDate.TabIndex = 1;
            // 
            // listContain
            // 
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
            this.txtLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.txtLink.Location = new System.Drawing.Point(12, 107);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(409, 27);
            this.txtLink.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getSummaryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(755, 24);
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
            this.textMain.Location = new System.Drawing.Point(16, 159);
            this.textMain.Multiline = true;
            this.textMain.Name = "textMain";
            this.textMain.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textMain.Size = new System.Drawing.Size(359, 224);
            this.textMain.TabIndex = 7;
            // 
            // txtP
            // 
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
            // pannelToolStripMenuItem
            // 
            this.pannelToolStripMenuItem.Name = "pannelToolStripMenuItem";
            this.pannelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pannelToolStripMenuItem.Text = "Dashboard";
            this.pannelToolStripMenuItem.Click += new System.EventHandler(this.pannelToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 393);
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
            this.Text = "Scraper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scraperDataSet1)).EndInit();
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
    }
}

