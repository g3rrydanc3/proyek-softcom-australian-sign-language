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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.x1 = new System.Windows.Forms.TextBox();
            this.x2 = new System.Windows.Forms.TextBox();
            this.x3 = new System.Windows.Forms.TextBox();
            this.x4 = new System.Windows.Forms.TextBox();
            this.x5 = new System.Windows.Forms.TextBox();
            this.x6 = new System.Windows.Forms.TextBox();
            this.x7 = new System.Windows.Forms.TextBox();
            this.x8 = new System.Windows.Forms.TextBox();
            this.x9 = new System.Windows.Forms.TextBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
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
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.Calculate);
            this.tabPage2.Controls.Add(this.x9);
            this.tabPage2.Controls.Add(this.x8);
            this.tabPage2.Controls.Add(this.x7);
            this.tabPage2.Controls.Add(this.x6);
            this.tabPage2.Controls.Add(this.x5);
            this.tabPage2.Controls.Add(this.x4);
            this.tabPage2.Controls.Add(this.x3);
            this.tabPage2.Controls.Add(this.x2);
            this.tabPage2.Controls.Add(this.x1);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(822, 423);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "X1 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "X2 :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "X3 :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(143, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "X4 :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(143, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "X5 :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(143, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "X6 :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(299, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "X7 :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(299, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "X8 :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(299, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "X9 :";
            // 
            // x1
            // 
            this.x1.Location = new System.Drawing.Point(37, 4);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(64, 20);
            this.x1.TabIndex = 9;
            // 
            // x2
            // 
            this.x2.Location = new System.Drawing.Point(37, 29);
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(64, 20);
            this.x2.TabIndex = 10;
            // 
            // x3
            // 
            this.x3.Location = new System.Drawing.Point(37, 59);
            this.x3.Name = "x3";
            this.x3.Size = new System.Drawing.Size(64, 20);
            this.x3.TabIndex = 11;
            // 
            // x4
            // 
            this.x4.Location = new System.Drawing.Point(175, 4);
            this.x4.Name = "x4";
            this.x4.Size = new System.Drawing.Size(64, 20);
            this.x4.TabIndex = 12;
            // 
            // x5
            // 
            this.x5.Location = new System.Drawing.Point(175, 29);
            this.x5.Name = "x5";
            this.x5.Size = new System.Drawing.Size(64, 20);
            this.x5.TabIndex = 13;
            // 
            // x6
            // 
            this.x6.Location = new System.Drawing.Point(175, 59);
            this.x6.Name = "x6";
            this.x6.Size = new System.Drawing.Size(64, 20);
            this.x6.TabIndex = 14;
            // 
            // x7
            // 
            this.x7.Location = new System.Drawing.Point(331, 4);
            this.x7.Name = "x7";
            this.x7.Size = new System.Drawing.Size(64, 20);
            this.x7.TabIndex = 15;
            // 
            // x8
            // 
            this.x8.Location = new System.Drawing.Point(331, 29);
            this.x8.Name = "x8";
            this.x8.Size = new System.Drawing.Size(64, 20);
            this.x8.TabIndex = 16;
            // 
            // x9
            // 
            this.x9.Location = new System.Drawing.Point(331, 59);
            this.x9.Name = "x9";
            this.x9.Size = new System.Drawing.Size(64, 20);
            this.x9.TabIndex = 17;
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(12, 92);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(75, 23);
            this.Calculate.TabIndex = 18;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(9, 133);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 24);
            this.label13.TabIndex = 19;
            this.label13.Text = "label13";
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
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
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
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.TextBox x9;
        private System.Windows.Forms.TextBox x8;
        private System.Windows.Forms.TextBox x7;
        private System.Windows.Forms.TextBox x6;
        private System.Windows.Forms.TextBox x5;
        private System.Windows.Forms.TextBox x4;
        private System.Windows.Forms.TextBox x3;
        private System.Windows.Forms.TextBox x2;
        private System.Windows.Forms.TextBox x1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

