
namespace HW_18._01
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.СhoiceTable_Button = new System.Windows.Forms.Button();
            this.SaveChange_Button = new System.Windows.Forms.Button();
            this.Sort_Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(449, 363);
            this.dataGridView1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "table Studets",
            "table Groups",
            "table Subjects",
            "table Marks",
            "table SubjectStudents"});
            this.comboBox1.Location = new System.Drawing.Point(574, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(234, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(571, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = " Выберите таблицу:";
            // 
            // СhoiceTable_Button
            // 
            this.СhoiceTable_Button.Location = new System.Drawing.Point(574, 93);
            this.СhoiceTable_Button.Name = "СhoiceTable_Button";
            this.СhoiceTable_Button.Size = new System.Drawing.Size(230, 39);
            this.СhoiceTable_Button.TabIndex = 3;
            this.СhoiceTable_Button.Text = "Выбрать";
            this.СhoiceTable_Button.UseVisualStyleBackColor = true;
            this.СhoiceTable_Button.Click += new System.EventHandler(this.СhoiceTable_Button_Click);
            // 
            // SaveChange_Button
            // 
            this.SaveChange_Button.Location = new System.Drawing.Point(574, 159);
            this.SaveChange_Button.Name = "SaveChange_Button";
            this.SaveChange_Button.Size = new System.Drawing.Size(229, 48);
            this.SaveChange_Button.TabIndex = 4;
            this.SaveChange_Button.Text = "Сохранить изменения";
            this.SaveChange_Button.UseVisualStyleBackColor = true;
            this.SaveChange_Button.Click += new System.EventHandler(this.SaveChange_Button_Click);
            // 
            // Sort_Button
            // 
            this.Sort_Button.Location = new System.Drawing.Point(668, 343);
            this.Sort_Button.Name = "Sort_Button";
            this.Sort_Button.Size = new System.Drawing.Size(91, 24);
            this.Sort_Button.TabIndex = 6;
            this.Sort_Button.Text = "Показать";
            this.Sort_Button.UseVisualStyleBackColor = true;
            this.Sort_Button.Click += new System.EventHandler(this.Sort_Button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(556, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "*Для сортировки нажмите на название столбца";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Студенты с именем:",
            "Студенты группы:",
            "Предметы и студенты с оценкой:"});
            this.comboBox2.Location = new System.Drawing.Point(507, 295);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(235, 21);
            this.comboBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(760, 295);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(62, 20);
            this.textBox1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 496);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Sort_Button);
            this.Controls.Add(this.SaveChange_Button);
            this.Controls.Add(this.СhoiceTable_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button СhoiceTable_Button;
        private System.Windows.Forms.Button SaveChange_Button;
        private System.Windows.Forms.Button Sort_Button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

