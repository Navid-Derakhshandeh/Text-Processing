﻿
namespace textprocessingtest1
{
    partial class Summary
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.scraperDataSet2 = new textprocessingtest1.scraperDataSet2();
            this.mWSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mWSTableAdapter = new textprocessingtest1.scraperDataSet2TableAdapters.MWSTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAddedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lInkAddedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboSearch = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnEE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scraperDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mWSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.dateAddedDataGridViewTextBoxColumn,
            this.lInkAddedDataGridViewTextBoxColumn,
            this.matchDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mWSBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(9, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // bindingSource4
            // 
            this.bindingSource4.DataSource = this.scraperDataSet2;
            this.bindingSource4.Position = 0;
            // 
            // scraperDataSet2
            // 
            this.scraperDataSet2.DataSetName = "scraperDataSet2";
            this.scraperDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mWSBindingSource
            // 
            this.mWSBindingSource.DataMember = "MWS";
            this.mWSBindingSource.DataSource = this.bindingSource4;
            // 
            // mWSTableAdapter
            // 
            this.mWSTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateAddedDataGridViewTextBoxColumn
            // 
            this.dateAddedDataGridViewTextBoxColumn.DataPropertyName = "Date_Added";
            this.dateAddedDataGridViewTextBoxColumn.HeaderText = "Date_Added";
            this.dateAddedDataGridViewTextBoxColumn.Name = "dateAddedDataGridViewTextBoxColumn";
            // 
            // lInkAddedDataGridViewTextBoxColumn
            // 
            this.lInkAddedDataGridViewTextBoxColumn.DataPropertyName = "LInk_Added";
            this.lInkAddedDataGridViewTextBoxColumn.HeaderText = "LInk_Added";
            this.lInkAddedDataGridViewTextBoxColumn.Name = "lInkAddedDataGridViewTextBoxColumn";
            // 
            // matchDataGridViewTextBoxColumn
            // 
            this.matchDataGridViewTextBoxColumn.DataPropertyName = "Match";
            this.matchDataGridViewTextBoxColumn.HeaderText = "Match";
            this.matchDataGridViewTextBoxColumn.Name = "matchDataGridViewTextBoxColumn";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "Scraper List";
            this.saveFileDialog1.Filter = "(*.xlsx)|*.xlsx|(*.txt)|*.txt|(*.docx)|*.docx";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSearch.Location = new System.Drawing.Point(26, 109);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(93, 33);
            this.btnSearch.TabIndex = 141;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cboSearch
            // 
            this.cboSearch.FormattingEnabled = true;
            this.cboSearch.Items.AddRange(new object[] {
            "Link_Added",
            "Match",
            "Date_Added"});
            this.cboSearch.Location = new System.Drawing.Point(16, 72);
            this.cboSearch.Name = "cboSearch";
            this.cboSearch.Size = new System.Drawing.Size(121, 21);
            this.cboSearch.TabIndex = 140;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(82, 25);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(230, 20);
            this.txtSearch.TabIndex = 139;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(12, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 20);
            this.label10.TabIndex = 138;
            this.label10.Text = "Search:";
            // 
            // btnEE
            // 
            this.btnEE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnEE.Location = new System.Drawing.Point(170, 105);
            this.btnEE.Name = "btnEE";
            this.btnEE.Size = new System.Drawing.Size(192, 40);
            this.btnEE.TabIndex = 142;
            this.btnEE.Text = "Export As Excel File";
            this.btnEE.UseVisualStyleBackColor = true;
            this.btnEE.Click += new System.EventHandler(this.btnEE_Click);
            // 
            // Summary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 319);
            this.Controls.Add(this.btnEE);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cboSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Summary";
            this.Text = "Summary";
            this.Load += new System.EventHandler(this.Summary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scraperDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mWSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource4;
        private scraperDataSet2 scraperDataSet2;
        private System.Windows.Forms.BindingSource mWSBindingSource;
        private scraperDataSet2TableAdapters.MWSTableAdapter mWSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAddedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lInkAddedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matchDataGridViewTextBoxColumn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cboSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnEE;
    }
}