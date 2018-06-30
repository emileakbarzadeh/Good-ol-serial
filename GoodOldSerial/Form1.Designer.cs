namespace GoodOldSerial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.normalRadioButton = new System.Windows.Forms.RadioButton();
            this.displayRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputTxtbox = new System.Windows.Forms.TextBox();
            this.inputTxtbox = new System.Windows.Forms.TextBox();
            this.baudTxtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.goButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.normalRadioButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.displayRadioButton, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.outputTxtbox, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.inputTxtbox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.baudTxtbox, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.goButton, 0, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(452, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // normalRadioButton
            // 
            this.normalRadioButton.AutoSize = true;
            this.normalRadioButton.Checked = true;
            this.normalRadioButton.Location = new System.Drawing.Point(3, 63);
            this.normalRadioButton.Name = "normalRadioButton";
            this.normalRadioButton.Size = new System.Drawing.Size(74, 21);
            this.normalRadioButton.TabIndex = 1;
            this.normalRadioButton.TabStop = true;
            this.normalRadioButton.Tag = "norm";
            this.normalRadioButton.Text = "Normal";
            this.normalRadioButton.UseVisualStyleBackColor = true;
            this.normalRadioButton.CheckedChanged += new System.EventHandler(this.serialType_CheckedChanged);
            // 
            // displayRadioButton
            // 
            this.displayRadioButton.AutoSize = true;
            this.displayRadioButton.Location = new System.Drawing.Point(229, 63);
            this.displayRadioButton.Name = "displayRadioButton";
            this.displayRadioButton.Size = new System.Drawing.Size(158, 21);
            this.displayRadioButton.TabIndex = 2;
            this.displayRadioButton.TabStop = true;
            this.displayRadioButton.Tag = "disp";
            this.displayRadioButton.Text = "Display and Forward";
            this.displayRadioButton.UseVisualStyleBackColor = true;
            this.displayRadioButton.CheckedChanged += new System.EventHandler(this.serialType_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Serial Mode";
            // 
            // toolStrip1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.toolStrip1, 2);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(452, 27);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(55, 24);
            this.toolStripDropDownButton1.Text = "Help";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // outputTxtbox
            // 
            this.outputTxtbox.Location = new System.Drawing.Point(3, 103);
            this.outputTxtbox.Name = "outputTxtbox";
            this.outputTxtbox.Size = new System.Drawing.Size(100, 22);
            this.outputTxtbox.TabIndex = 4;
            this.outputTxtbox.Tag = "Output Port";
            this.outputTxtbox.Text = "Output Port";
            this.outputTxtbox.Enter += new System.EventHandler(this.txtBox_Focus);
            this.outputTxtbox.Leave += new System.EventHandler(this.txtBox_Unfocus);
            // 
            // inputTxtbox
            // 
            this.inputTxtbox.Enabled = false;
            this.inputTxtbox.Location = new System.Drawing.Point(229, 103);
            this.inputTxtbox.Name = "inputTxtbox";
            this.inputTxtbox.Size = new System.Drawing.Size(100, 22);
            this.inputTxtbox.TabIndex = 5;
            this.inputTxtbox.Tag = "Input Port";
            this.inputTxtbox.Text = "Input Port";
            this.inputTxtbox.Enter += new System.EventHandler(this.txtBox_Focus);
            this.inputTxtbox.Leave += new System.EventHandler(this.txtBox_Unfocus);
            // 
            // baudTxtbox
            // 
            this.baudTxtbox.Location = new System.Drawing.Point(3, 133);
            this.baudTxtbox.Name = "baudTxtbox";
            this.baudTxtbox.Size = new System.Drawing.Size(100, 22);
            this.baudTxtbox.TabIndex = 6;
            this.baudTxtbox.Tag = "Baud Rate";
            this.baudTxtbox.Text = "Baud Rate";
            this.baudTxtbox.Enter += new System.EventHandler(this.txtBox_Focus);
            this.baudTxtbox.Leave += new System.EventHandler(this.txtBox_Unfocus);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(229, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "eg. COM5";
            // 
            // goButton
            // 
            this.goButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tableLayoutPanel1.SetColumnSpan(this.goButton, 2);
            this.goButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.goButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goButton.ForeColor = System.Drawing.Color.Lime;
            this.goButton.Location = new System.Drawing.Point(3, 163);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(446, 284);
            this.goButton.TabIndex = 8;
            this.goButton.Text = "Start!";
            this.goButton.UseVisualStyleBackColor = false;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Good ol\' Serial configuration";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton normalRadioButton;
        private System.Windows.Forms.RadioButton displayRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox outputTxtbox;
        private System.Windows.Forms.TextBox inputTxtbox;
        private System.Windows.Forms.TextBox baudTxtbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button goButton;
    }
}

