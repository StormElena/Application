namespace Example
{
    partial class UserControlITimeRangeObjectEdit
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelToaUtc = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePickerGetStBegin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerGetStEnd = new System.Windows.Forms.DateTimePicker();
            this.textBoxEntityId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelToaUtc
            // 
            this.labelToaUtc.AutoSize = true;
            this.labelToaUtc.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelToaUtc.ForeColor = System.Drawing.Color.RosyBrown;
            this.labelToaUtc.Location = new System.Drawing.Point(3, 0);
            this.labelToaUtc.Name = "labelToaUtc";
            this.labelToaUtc.Size = new System.Drawing.Size(106, 16);
            this.labelToaUtc.TabIndex = 95;
            this.labelToaUtc.Text = "Редактирование ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.dateTimePickerGetStBegin);
            this.groupBox1.Controls.Add(this.buttonUpdate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTimePickerGetStEnd);
            this.groupBox1.Controls.Add(this.textBoxEntityId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.groupBox1.Location = new System.Drawing.Point(3, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 189);
            this.groupBox1.TabIndex = 94;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Интервал";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.textBox1.ForeColor = System.Drawing.Color.Crimson;
            this.textBox1.Location = new System.Drawing.Point(6, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 21);
            this.textBox1.TabIndex = 94;
            this.textBox1.Text = "Выбран элемент";
            // 
            // dateTimePickerGetStBegin
            // 
            this.dateTimePickerGetStBegin.CalendarFont = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerGetStBegin.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            this.dateTimePickerGetStBegin.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerGetStBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerGetStBegin.Location = new System.Drawing.Point(6, 47);
            this.dateTimePickerGetStBegin.Name = "dateTimePickerGetStBegin";
            this.dateTimePickerGetStBegin.Size = new System.Drawing.Size(144, 21);
            this.dateTimePickerGetStBegin.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label1.Location = new System.Drawing.Point(156, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Начало, UTC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label3.Location = new System.Drawing.Point(158, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Id";
            // 
            // dateTimePickerGetStEnd
            // 
            this.dateTimePickerGetStEnd.CalendarFont = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerGetStEnd.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            this.dateTimePickerGetStEnd.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerGetStEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerGetStEnd.Location = new System.Drawing.Point(6, 74);
            this.dateTimePickerGetStEnd.Name = "dateTimePickerGetStEnd";
            this.dateTimePickerGetStEnd.Size = new System.Drawing.Size(144, 21);
            this.dateTimePickerGetStEnd.TabIndex = 21;
            // 
            // textBoxEntityId
            // 
            this.textBoxEntityId.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.textBoxEntityId.Location = new System.Drawing.Point(6, 101);
            this.textBoxEntityId.Name = "textBoxEntityId";
            this.textBoxEntityId.Size = new System.Drawing.Size(144, 21);
            this.textBoxEntityId.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label2.Location = new System.Drawing.Point(158, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Конец, UTC";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.White;
            this.buttonUpdate.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpdate.Image = global::Example.Properties.Resources.IikTuningForm_1;
            this.buttonUpdate.Location = new System.Drawing.Point(68, 138);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(170, 38);
            this.buttonUpdate.TabIndex = 28;
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // UserControlITimeRangeObjectEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.labelToaUtc);
            this.Controls.Add(this.groupBox1);
            this.Name = "UserControlITimeRangeObjectEdit";
            this.Size = new System.Drawing.Size(255, 529);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelToaUtc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePickerGetStBegin;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerGetStEnd;
        private System.Windows.Forms.TextBox textBoxEntityId;
        private System.Windows.Forms.Label label2;
    }
}
