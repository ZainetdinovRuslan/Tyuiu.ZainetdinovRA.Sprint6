namespace Tyuiu.ZainetdinovRA.Sprint6.Task1.V22
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
            textBoxStop = new TextBox();
            textBoxStart = new TextBox();
            labelStop = new Label();
            buttonCalculate = new Button();
            textBoxResults = new TextBox();
            textBoxResult_RA = new TextBox();
            labelResults_RA = new Label();
            textBoxConditions_RA = new TextBox();
            textBoxStart_RA = new TextBox();
            labelInput_RA = new Label();
            labelConditions_RA = new Label();
            buttonInformation_RA = new Button();
            SuspendLayout();
            // 
            // textBoxStop
            // 
            textBoxStop.BackColor = SystemColors.Control;
            textBoxStop.Location = new Point(138, 396);
            textBoxStop.Name = "textBoxStop";
            textBoxStop.Size = new Size(125, 27);
            textBoxStop.TabIndex = 0;
            //textBoxStop.TextChanged += this.textBoxStop_TextChanged;
            // 
            // textBoxStart
            // 
            textBoxStart.BackColor = SystemColors.Control;
            textBoxStart.Location = new Point(16, 396);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(116, 27);
            textBoxStart.TabIndex = 0;
            //textBoxStart.TextChanged += this.textBoxStart_TextChanged;
            // 
            // labelStop
            // 
            labelStop.AutoSize = true;
            labelStop.Location = new Point(138, 374);
            labelStop.Name = "labelStop";
            labelStop.Size = new Size(96, 20);
            labelStop.TabIndex = 1;
            labelStop.Text = "Конец Шага:";
            //labelStop.Click += this.labelStop_Click;
            // 
            // buttonCalculate
            // 
            buttonCalculate.BackColor = SystemColors.Desktop;
            buttonCalculate.Location = new Point(376, 379);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(115, 60);
            buttonCalculate.TabIndex = 2;
            buttonCalculate.Text = "Выполнить";
            buttonCalculate.UseVisualStyleBackColor = false;
            buttonCalculate.Click += buttonCalculate_Click_1;
            // 
            // textBoxResults
            // 
            textBoxResults.BackColor = SystemColors.Control;
            textBoxResults.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxResults.Location = new Point(520, 58);
            textBoxResults.Multiline = true;
            textBoxResults.Name = "textBoxResults";
            textBoxResults.ReadOnly = true;
            textBoxResults.Size = new Size(253, 348);
            textBoxResults.TabIndex = 3;
            textBoxResults.TextChanged += textBoxResults_TextChanged;
            // 
            // textBoxResult_RA
            // 
            textBoxResult_RA.BackColor = SystemColors.Control;
            textBoxResult_RA.Location = new Point(500, 32);
            textBoxResult_RA.Margin = new Padding(3, 4, 3, 3);
            textBoxResult_RA.Multiline = true;
            textBoxResult_RA.Name = "textBoxResult_RA";
            textBoxResult_RA.ReadOnly = true;
            textBoxResult_RA.Size = new Size(288, 406);
            textBoxResult_RA.TabIndex = 4;
            textBoxResult_RA.Text = "Результат:";
            // 
            // labelResults_RA
            // 
            labelResults_RA.AutoSize = true;
            labelResults_RA.Location = new Point(500, 9);
            labelResults_RA.Name = "labelResults_RA";
            labelResults_RA.Size = new Size(113, 20);
            labelResults_RA.TabIndex = 5;
            labelResults_RA.Text = "Вывод данных:";
            // 
            // textBoxConditions_RA
            // 
            textBoxConditions_RA.BackColor = SystemColors.Control;
            textBoxConditions_RA.Location = new Point(12, 32);
            textBoxConditions_RA.Multiline = true;
            textBoxConditions_RA.Name = "textBoxConditions_RA";
            textBoxConditions_RA.ReadOnly = true;
            textBoxConditions_RA.Size = new Size(479, 284);
            textBoxConditions_RA.TabIndex = 6;
            textBoxConditions_RA.Text = "Произвести табуляцию на заданном диапазоне. Произвести проверку деления на ноль.";
            // 
            // textBoxStart_RA
            // 
            textBoxStart_RA.BackColor = SystemColors.Control;
            textBoxStart_RA.Location = new Point(11, 371);
            textBoxStart_RA.Multiline = true;
            textBoxStart_RA.Name = "textBoxStart_RA";
            textBoxStart_RA.ReadOnly = true;
            textBoxStart_RA.Size = new Size(268, 67);
            textBoxStart_RA.TabIndex = 7;
            textBoxStart_RA.Text = "Старт Шага:";
            //textBoxStart_RA.TextChanged += this.textBoxStart_RA_TextChanged;
            // 
            // labelInput_RA
            // 
            labelInput_RA.AutoSize = true;
            labelInput_RA.Location = new Point(12, 348);
            labelInput_RA.Name = "labelInput_RA";
            labelInput_RA.Size = new Size(102, 20);
            labelInput_RA.TabIndex = 8;
            labelInput_RA.Text = "Ввод данных:";
            //labelInput_RA.Click += this.labelInput_RA_Click;
            // 
            // labelConditions_RA
            // 
            labelConditions_RA.AutoSize = true;
            labelConditions_RA.Location = new Point(11, 9);
            labelConditions_RA.Name = "labelConditions_RA";
            labelConditions_RA.Size = new Size(70, 20);
            labelConditions_RA.TabIndex = 9;
            labelConditions_RA.Text = "Условия:";
            // 
            // buttonInformation_RA
            // 
            buttonInformation_RA.BackColor = SystemColors.ActiveCaption;
            buttonInformation_RA.Location = new Point(285, 379);
            buttonInformation_RA.Name = "buttonInformation_RA";
            buttonInformation_RA.Size = new Size(85, 60);
            buttonInformation_RA.TabIndex = 10;
            buttonInformation_RA.Text = "Справка";
            buttonInformation_RA.UseVisualStyleBackColor = false;
            buttonInformation_RA.Click += buttonInformation_RA_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonInformation_RA);
            Controls.Add(labelConditions_RA);
            Controls.Add(labelInput_RA);
            Controls.Add(labelResults_RA);
            Controls.Add(textBoxResults);
            Controls.Add(buttonCalculate);
            Controls.Add(labelStop);
            Controls.Add(textBoxStart);
            Controls.Add(textBoxStop);
            Controls.Add(textBoxResult_RA);
            Controls.Add(textBoxConditions_RA);
            Controls.Add(textBoxStart_RA);
            Name = "FormMain";
            Text = "Спринт 6 | Такс 1 | Вариант 22 | Зайнетдинов Р. А.";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxStop;
        private TextBox textBoxStart;
        private Label labelStop;
        private Button buttonCalculate;
        private TextBox textBoxResults;
        private TextBox textBoxResult_RA;
        private Label labelResults_RA;
        private TextBox textBoxConditions_RA;
        private TextBox textBoxStart_RA;
        private Label labelInput_RA;
        private Label labelConditions_RA;
        private Button buttonInformation_RA;
    }
}
