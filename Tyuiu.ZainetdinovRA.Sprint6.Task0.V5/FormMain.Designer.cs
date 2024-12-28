namespace Tyuiu.ZainetdinovRA.Sprint6.Task0.V5
{
    partial class FormMain
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
            labelXValue_RA = new Label();
            textBoxXValue_RA = new TextBox();
            buttonCalculate_RA = new Button();
            labelResult_RA = new Label();
            textBoxResult_RA = new TextBox();
            pictureBoxFormula = new PictureBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            labelXValue = new Label();
            label2 = new Label();
            groupBoxTask = new TextBox();
            btnInfo_RA = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // labelXValue_RA
            // 
            labelXValue_RA.AutoSize = true;
            labelXValue_RA.Location = new Point(43, 303);
            labelXValue_RA.Name = "labelXValue_RA";
            labelXValue_RA.Size = new Size(102, 20);
            labelXValue_RA.TabIndex = 0;
            labelXValue_RA.Text = "Ввод данных:";
            // 
            // textBoxXValue_RA
            // 
            textBoxXValue_RA.Location = new Point(43, 371);
            textBoxXValue_RA.Name = "textBoxXValue_RA";
            textBoxXValue_RA.Size = new Size(145, 27);
            textBoxXValue_RA.TabIndex = 1;
            // 
            // buttonCalculate_RA
            // 
            buttonCalculate_RA.BackColor = Color.Silver;
            buttonCalculate_RA.Cursor = Cursors.Hand;
            buttonCalculate_RA.Location = new Point(645, 366);
            buttonCalculate_RA.Name = "buttonCalculate_RA";
            buttonCalculate_RA.Size = new Size(134, 36);
            buttonCalculate_RA.TabIndex = 2;
            buttonCalculate_RA.Text = "Выполнить";
            buttonCalculate_RA.UseVisualStyleBackColor = false;
            buttonCalculate_RA.Click += button1_Click;
            // 
            // labelResult_RA
            // 
            labelResult_RA.AutoSize = true;
            labelResult_RA.Location = new Point(645, 303);
            labelResult_RA.Name = "labelResult_RA";
            labelResult_RA.Size = new Size(78, 20);
            labelResult_RA.TabIndex = 3;
            labelResult_RA.Text = "Результат:";
            // 
            // textBoxResult_RA
            // 
            textBoxResult_RA.Location = new Point(645, 333);
            textBoxResult_RA.Name = "textBoxResult_RA";
            textBoxResult_RA.ReadOnly = true;
            textBoxResult_RA.Size = new Size(134, 27);
            textBoxResult_RA.TabIndex = 4;
            // 
            // pictureBoxFormula
            // 
            pictureBoxFormula.Image = Properties.Resources.Screenshot_2024_12_28_034924;
            pictureBoxFormula.Location = new Point(374, 94);
            pictureBoxFormula.Name = "pictureBoxFormula";
            pictureBoxFormula.Size = new Size(405, 62);
            pictureBoxFormula.TabIndex = 5;
            pictureBoxFormula.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(116, 26);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // labelXValue
            // 
            labelXValue.AutoSize = true;
            labelXValue.Location = new Point(43, 348);
            labelXValue.Name = "labelXValue";
            labelXValue.Size = new Size(114, 20);
            labelXValue.TabIndex = 7;
            labelXValue.Text = "Переменная X:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(24, 50);
            label2.Name = "label2";
            label2.Size = new Size(93, 28);
            label2.TabIndex = 8;
            label2.Text = "Условие";
            // 
            // groupBoxTask
            // 
            groupBoxTask.BackColor = SystemColors.Control;
            groupBoxTask.Location = new Point(12, 72);
            groupBoxTask.Multiline = true;
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(776, 219);
            groupBoxTask.TabIndex = 9;
            groupBoxTask.Text = "Округлить до трёх знаков после запятой.";
            // 
            // btnInfo_RA
            // 
            btnInfo_RA.BackColor = SystemColors.ButtonHighlight;
            btnInfo_RA.FlatStyle = FlatStyle.Flat;
            btnInfo_RA.Location = new Point(606, 370);
            btnInfo_RA.Name = "btnInfo_RA";
            btnInfo_RA.Size = new Size(33, 32);
            btnInfo_RA.TabIndex = 10;
            btnInfo_RA.Text = "?";
            btnInfo_RA.UseVisualStyleBackColor = false;
            btnInfo_RA.Click += btnInfo_RA_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.Location = new Point(12, 310);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(245, 108);
            textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Control;
            textBox2.Location = new Point(592, 310);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(196, 108);
            textBox2.TabIndex = 11;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 430);
            Controls.Add(btnInfo_RA);
            Controls.Add(label2);
            Controls.Add(labelXValue);
            Controls.Add(pictureBoxFormula);
            Controls.Add(textBoxResult_RA);
            Controls.Add(labelResult_RA);
            Controls.Add(buttonCalculate_RA);
            Controls.Add(textBoxXValue_RA);
            Controls.Add(labelXValue_RA);
            Controls.Add(menuStrip1);
            Controls.Add(groupBoxTask);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Такс 0 | Вариант 5 | Зайнетдинов Р. А.";
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelXValue_RA;
        private TextBox textBoxXValue_RA;
        private Button buttonCalculate_RA;
        private Label labelResult_RA;
        private TextBox textBoxResult_RA;
        private PictureBox pictureBoxFormula;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Label labelXValue;
        private Label label2;
        private TextBox groupBoxTask;
        private Button btnInfo_RA;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}
