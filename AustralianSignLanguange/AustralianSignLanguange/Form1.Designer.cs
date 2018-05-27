namespace AustralianSignLanguange
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
            this.buttonInit = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonTrain = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkedListBoxOrang = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxAllKata = new System.Windows.Forms.CheckedListBox();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonOrangSelectAll = new System.Windows.Forms.Button();
            this.buttonOrangUnselectAll = new System.Windows.Forms.Button();
            this.buttonKataSelectAll = new System.Windows.Forms.Button();
            this.buttonKataUnselectAll = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonInit
            // 
            this.buttonInit.Location = new System.Drawing.Point(3, 23);
            this.buttonInit.Name = "buttonInit";
            this.buttonInit.Size = new System.Drawing.Size(81, 23);
            this.buttonInit.TabIndex = 1;
            this.buttonInit.Text = "Initialize";
            this.buttonInit.UseVisualStyleBackColor = true;
            this.buttonInit.Click += new System.EventHandler(this.buttonInit_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(830, 449);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(822, 423);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.buttonTrain, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonInit, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkedListBoxOrang, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.checkedListBoxAllKata, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxLog, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonOrangSelectAll, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.buttonOrangUnselectAll, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.buttonKataSelectAll, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.buttonKataUnselectAll, 4, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(816, 417);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // buttonTrain
            // 
            this.buttonTrain.Location = new System.Drawing.Point(3, 52);
            this.buttonTrain.Name = "buttonTrain";
            this.buttonTrain.Size = new System.Drawing.Size(81, 23);
            this.buttonTrain.TabIndex = 4;
            this.buttonTrain.Text = "Train";
            this.buttonTrain.UseVisualStyleBackColor = true;
            this.buttonTrain.Click += new System.EventHandler(this.buttonTrain_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Orang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kata";
            // 
            // checkedListBoxOrang
            // 
            this.checkedListBoxOrang.CheckOnClick = true;
            this.tableLayoutPanel1.SetColumnSpan(this.checkedListBoxOrang, 2);
            this.checkedListBoxOrang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBoxOrang.FormattingEnabled = true;
            this.checkedListBoxOrang.Location = new System.Drawing.Point(90, 23);
            this.checkedListBoxOrang.Name = "checkedListBoxOrang";
            this.tableLayoutPanel1.SetRowSpan(this.checkedListBoxOrang, 4);
            this.checkedListBoxOrang.Size = new System.Drawing.Size(236, 362);
            this.checkedListBoxOrang.TabIndex = 8;
            // 
            // checkedListBoxAllKata
            // 
            this.checkedListBoxAllKata.CheckOnClick = true;
            this.tableLayoutPanel1.SetColumnSpan(this.checkedListBoxAllKata, 2);
            this.checkedListBoxAllKata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBoxAllKata.FormattingEnabled = true;
            this.checkedListBoxAllKata.Location = new System.Drawing.Point(332, 23);
            this.checkedListBoxAllKata.Name = "checkedListBoxAllKata";
            this.tableLayoutPanel1.SetRowSpan(this.checkedListBoxAllKata, 4);
            this.checkedListBoxAllKata.Size = new System.Drawing.Size(236, 362);
            this.checkedListBoxAllKata.TabIndex = 9;
            // 
            // textBoxLog
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBoxLog, 2);
            this.textBoxLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLog.Location = new System.Drawing.Point(574, 23);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.tableLayoutPanel1.SetRowSpan(this.textBoxLog, 5);
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxLog.Size = new System.Drawing.Size(239, 391);
            this.textBoxLog.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(574, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Log";
            // 
            // buttonOrangSelectAll
            // 
            this.buttonOrangSelectAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonOrangSelectAll.Location = new System.Drawing.Point(90, 391);
            this.buttonOrangSelectAll.Name = "buttonOrangSelectAll";
            this.buttonOrangSelectAll.Size = new System.Drawing.Size(115, 23);
            this.buttonOrangSelectAll.TabIndex = 12;
            this.buttonOrangSelectAll.Text = "Select All";
            this.buttonOrangSelectAll.UseVisualStyleBackColor = true;
            this.buttonOrangSelectAll.Click += new System.EventHandler(this.buttonOrangSelectAll_Click);
            // 
            // buttonOrangUnselectAll
            // 
            this.buttonOrangUnselectAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonOrangUnselectAll.Location = new System.Drawing.Point(211, 391);
            this.buttonOrangUnselectAll.Name = "buttonOrangUnselectAll";
            this.buttonOrangUnselectAll.Size = new System.Drawing.Size(115, 23);
            this.buttonOrangUnselectAll.TabIndex = 13;
            this.buttonOrangUnselectAll.Text = "Unselect All";
            this.buttonOrangUnselectAll.UseVisualStyleBackColor = true;
            this.buttonOrangUnselectAll.Click += new System.EventHandler(this.buttonOrangUnselectAll_Click);
            // 
            // buttonKataSelectAll
            // 
            this.buttonKataSelectAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonKataSelectAll.Location = new System.Drawing.Point(332, 391);
            this.buttonKataSelectAll.Name = "buttonKataSelectAll";
            this.buttonKataSelectAll.Size = new System.Drawing.Size(115, 23);
            this.buttonKataSelectAll.TabIndex = 14;
            this.buttonKataSelectAll.Text = "Select All";
            this.buttonKataSelectAll.UseVisualStyleBackColor = true;
            this.buttonKataSelectAll.Click += new System.EventHandler(this.buttonKataSelectAll_Click);
            // 
            // buttonKataUnselectAll
            // 
            this.buttonKataUnselectAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonKataUnselectAll.Location = new System.Drawing.Point(453, 391);
            this.buttonKataUnselectAll.Name = "buttonKataUnselectAll";
            this.buttonKataUnselectAll.Size = new System.Drawing.Size(115, 23);
            this.buttonKataUnselectAll.TabIndex = 15;
            this.buttonKataUnselectAll.Text = "Unselect All";
            this.buttonKataUnselectAll.UseVisualStyleBackColor = true;
            this.buttonKataUnselectAll.Click += new System.EventHandler(this.buttonKataUnselectAll_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(822, 423);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 449);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonInit;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonTrain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox checkedListBoxOrang;
        private System.Windows.Forms.CheckedListBox checkedListBoxAllKata;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonOrangSelectAll;
        private System.Windows.Forms.Button buttonOrangUnselectAll;
        private System.Windows.Forms.Button buttonKataSelectAll;
        private System.Windows.Forms.Button buttonKataUnselectAll;
    }
}

