namespace Tyuiu.ZainetdinovRA.Sprint6.Task2.V22
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
            buttonCalculate = new Button();
            buttonInformation_RA = new Button();
            labelConditions_RA = new Label();
            labelInput_RA = new Label();
            labelResults_RA = new Label();
            labelStop = new Label();
            textBoxStart = new TextBox();
            textBoxStop = new TextBox();
            textBoxStart_RA = new TextBox();
            dataGridViewResults_RA = new DataGridView();
            Value = new DataGridViewTextBoxColumn();
            Y = new DataGridViewTextBoxColumn();
            textBoxTask2Conditions = new TextBox();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResults_RA).BeginInit();
            SuspendLayout();
            // 
            // buttonCalculate
            // 
            buttonCalculate.BackColor = SystemColors.Desktop;
            buttonCalculate.Location = new Point(377, 380);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(115, 60);
            buttonCalculate.TabIndex = 3;
            buttonCalculate.Text = "Выполнить";
            buttonCalculate.UseVisualStyleBackColor = false;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // buttonInformation_RA
            // 
            buttonInformation_RA.BackColor = SystemColors.ActiveCaption;
            buttonInformation_RA.Location = new Point(286, 380);
            buttonInformation_RA.Name = "buttonInformation_RA";
            buttonInformation_RA.Size = new Size(85, 60);
            buttonInformation_RA.TabIndex = 20;
            buttonInformation_RA.Text = "Справка";
            buttonInformation_RA.UseVisualStyleBackColor = false;
            buttonInformation_RA.Click += buttonInformation_RA_Click_1;
            // 
            // labelConditions_RA
            // 
            labelConditions_RA.AutoSize = true;
            labelConditions_RA.Location = new Point(12, 10);
            labelConditions_RA.Name = "labelConditions_RA";
            labelConditions_RA.Size = new Size(70, 20);
            labelConditions_RA.TabIndex = 19;
            labelConditions_RA.Text = "Условия:";
            // 
            // labelInput_RA
            // 
            labelInput_RA.AutoSize = true;
            labelInput_RA.Location = new Point(13, 349);
            labelInput_RA.Name = "labelInput_RA";
            labelInput_RA.Size = new Size(102, 20);
            labelInput_RA.TabIndex = 18;
            labelInput_RA.Text = "Ввод данных:";
            // 
            // labelResults_RA
            // 
            labelResults_RA.AutoSize = true;
            labelResults_RA.Location = new Point(528, 9);
            labelResults_RA.Name = "labelResults_RA";
            labelResults_RA.Size = new Size(113, 20);
            labelResults_RA.TabIndex = 16;
            labelResults_RA.Text = "Вывод данных:";
            // 
            // labelStop
            // 
            labelStop.AutoSize = true;
            labelStop.Location = new Point(139, 375);
            labelStop.Name = "labelStop";
            labelStop.Size = new Size(96, 20);
            labelStop.TabIndex = 13;
            labelStop.Text = "Конец Шага:";
            // 
            // textBoxStart
            // 
            textBoxStart.BackColor = SystemColors.Control;
            textBoxStart.Location = new Point(17, 397);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(116, 27);
            textBoxStart.TabIndex = 11;
            // 
            // textBoxStop
            // 
            textBoxStop.BackColor = SystemColors.Control;
            textBoxStop.Location = new Point(139, 397);
            textBoxStop.Name = "textBoxStop";
            textBoxStop.Size = new Size(125, 27);
            textBoxStop.TabIndex = 12;
            // 
            // textBoxStart_RA
            // 
            textBoxStart_RA.BackColor = SystemColors.Control;
            textBoxStart_RA.Location = new Point(12, 372);
            textBoxStart_RA.Multiline = true;
            textBoxStart_RA.Name = "textBoxStart_RA";
            textBoxStart_RA.ReadOnly = true;
            textBoxStart_RA.Size = new Size(268, 67);
            textBoxStart_RA.TabIndex = 17;
            textBoxStart_RA.Text = "Старт Шага:";
            // 
            // dataGridViewResults_RA
            // 
            dataGridViewResults_RA.AllowUserToAddRows = false;
            dataGridViewResults_RA.AllowUserToDeleteRows = false;
            dataGridViewResults_RA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResults_RA.Columns.AddRange(new DataGridViewColumn[] { Value, Y });
            dataGridViewResults_RA.Location = new Point(528, 45);
            dataGridViewResults_RA.Name = "dataGridViewResults_RA";
            dataGridViewResults_RA.ReadOnly = true;
            dataGridViewResults_RA.RowHeadersVisible = false;
            dataGridViewResults_RA.RowHeadersWidth = 51;
            dataGridViewResults_RA.Size = new Size(260, 379);
            dataGridViewResults_RA.TabIndex = 21;
            // 
            // Value
            // 
            Value.HeaderText = "X";
            Value.MinimumWidth = 6;
            Value.Name = "Value";
            Value.ReadOnly = true;
            Value.Width = 125;
            // 
            // Y
            // 
            Y.HeaderText = "F(X)";
            Y.MinimumWidth = 6;
            Y.Name = "Y";
            Y.ReadOnly = true;
            Y.Width = 125;
            // 
            // textBoxTask2Conditions
            // 
            textBoxTask2Conditions.BackColor = SystemColors.Control;
            textBoxTask2Conditions.Location = new Point(5, 33);
            textBoxTask2Conditions.Multiline = true;
            textBoxTask2Conditions.Name = "textBoxTask2Conditions";
            textBoxTask2Conditions.Size = new Size(490, 313);
            textBoxTask2Conditions.TabIndex = 22;
            textBoxTask2Conditions.Text = "Произвести табулирование значений функции. Произвести проверку деления на 0. Значения округлить до двух знаков после запятой. ";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.Location = new Point(507, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(289, 427);
            textBox1.TabIndex = 23;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewResults_RA);
            Controls.Add(buttonInformation_RA);
            Controls.Add(labelConditions_RA);
            Controls.Add(labelInput_RA);
            Controls.Add(labelResults_RA);
            Controls.Add(labelStop);
            Controls.Add(textBoxStart);
            Controls.Add(textBoxStop);
            Controls.Add(textBoxStart_RA);
            Controls.Add(buttonCalculate);
            Controls.Add(textBoxTask2Conditions);
            Controls.Add(textBox1);
            Name = "FormMain";
            Text = "Спринт 6 | Такс 2 | Вариант 22 | Зайнетдинов Р. А.";
            ((System.ComponentModel.ISupportInitialize)dataGridViewResults_RA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCalculate;
        private Button buttonInformation_RA;
        private Label labelConditions_RA;
        private Label labelInput_RA;
        private Label labelResults_RA;
        private Label labelStop;
        private TextBox textBoxStart;
        private TextBox textBoxStop;
        private TextBox textBoxStart_RA;
        private DataGridView dataGridViewResults_RA;
        private DataGridViewTextBoxColumn Value;
        private DataGridViewTextBoxColumn Y;
        private TextBox textBoxTask2Conditions;
        private TextBox textBox1;
    }
}
