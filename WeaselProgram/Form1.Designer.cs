namespace WeaselProgram
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPhrase = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelRunTime = new System.Windows.Forms.Label();
            this.checkBoxNoDupes = new System.Windows.Forms.CheckBox();
            this.buttonStop = new System.Windows.Forms.Button();
            this.listBoxResults = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.labelGuessCount = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxPhrase, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.labelRunTime, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.buttonStop, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.buttonStart, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxNoDupes, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.labelGuessCount, 1, 10);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 12;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(309, 556);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Target phrase:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxPhrase
            // 
            this.textBoxPhrase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxPhrase.Location = new System.Drawing.Point(89, 3);
            this.textBoxPhrase.Name = "textBoxPhrase";
            this.textBoxPhrase.Size = new System.Drawing.Size(217, 23);
            this.textBoxPhrase.TabIndex = 1;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(89, 67);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Run Time:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelRunTime
            // 
            this.labelRunTime.AutoSize = true;
            this.labelRunTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelRunTime.Location = new System.Drawing.Point(89, 132);
            this.labelRunTime.Name = "labelRunTime";
            this.labelRunTime.Size = new System.Drawing.Size(217, 15);
            this.labelRunTime.TabIndex = 5;
            this.labelRunTime.Text = "0:00:00.0000";
            this.labelRunTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkBoxNoDupes
            // 
            this.checkBoxNoDupes.AutoSize = true;
            this.checkBoxNoDupes.Location = new System.Drawing.Point(89, 37);
            this.checkBoxNoDupes.Name = "checkBoxNoDupes";
            this.checkBoxNoDupes.Size = new System.Drawing.Size(189, 19);
            this.checkBoxNoDupes.TabIndex = 6;
            this.checkBoxNoDupes.Text = "Do not allow duplicate guesses";
            this.checkBoxNoDupes.UseVisualStyleBackColor = true;
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(89, 101);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 7;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // listBoxResults
            // 
            this.listBoxResults.ContextMenuStrip = this.contextMenuStrip1;
            this.listBoxResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxResults.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxResults.FormattingEnabled = true;
            this.listBoxResults.ItemHeight = 16;
            this.listBoxResults.Location = new System.Drawing.Point(0, 0);
            this.listBoxResults.Name = "listBoxResults";
            this.listBoxResults.Size = new System.Drawing.Size(612, 556);
            this.listBoxResults.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemCopy});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(103, 26);
            // 
            // toolStripMenuItemCopy
            // 
            this.toolStripMenuItemCopy.Name = "toolStripMenuItemCopy";
            this.toolStripMenuItemCopy.Size = new System.Drawing.Size(102, 22);
            this.toolStripMenuItemCopy.Text = "Copy";
            this.toolStripMenuItemCopy.Click += new System.EventHandler(this.toolStripMenuItemCopy_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listBoxResults);
            this.splitContainer1.Panel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.splitContainer1.Size = new System.Drawing.Size(927, 556);
            this.splitContainer1.SplitterDistance = 309;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Guess count:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelGuessCount
            // 
            this.labelGuessCount.AutoSize = true;
            this.labelGuessCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelGuessCount.Location = new System.Drawing.Point(89, 152);
            this.labelGuessCount.Name = "labelGuessCount";
            this.labelGuessCount.Size = new System.Drawing.Size(217, 15);
            this.labelGuessCount.TabIndex = 9;
            this.labelGuessCount.Text = "0";
            this.labelGuessCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 556);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPhrase;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.ListBox listBoxResults;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelRunTime;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckBox checkBoxNoDupes;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCopy;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelGuessCount;
    }
}
