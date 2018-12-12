namespace Example
{
    partial class FormExample
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.userControlITimeRangeObjectTuning1 = new Example.UserControlITimeRangeObjectTuning();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonSchedule = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.71116F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.28884F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(883, 665);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.userControlITimeRangeObjectTuning1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(877, 497);
            this.panel1.TabIndex = 0;
            // 
            // userControlITimeRangeObjectTuning1
            // 
            this.userControlITimeRangeObjectTuning1.BackColor = System.Drawing.Color.AliceBlue;
            this.userControlITimeRangeObjectTuning1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlITimeRangeObjectTuning1.Location = new System.Drawing.Point(0, 0);
            this.userControlITimeRangeObjectTuning1.Name = "userControlITimeRangeObjectTuning1";
            this.userControlITimeRangeObjectTuning1.Size = new System.Drawing.Size(877, 497);
            this.userControlITimeRangeObjectTuning1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.Controls.Add(this.buttonSchedule);
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 506);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(877, 156);
            this.panel2.TabIndex = 1;
            // 
            // buttonSchedule
            // 
            this.buttonSchedule.BackColor = System.Drawing.Color.White;
            this.buttonSchedule.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSchedule.Location = new System.Drawing.Point(22, 15);
            this.buttonSchedule.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSchedule.Name = "buttonSchedule";
            this.buttonSchedule.Size = new System.Drawing.Size(156, 38);
            this.buttonSchedule.TabIndex = 29;
            this.buttonSchedule.Text = "График";
            this.buttonSchedule.UseVisualStyleBackColor = false;
            this.buttonSchedule.Click += new System.EventHandler(this.ButtonClick);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(198, 15);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(577, 82);
            this.listBox1.TabIndex = 3;
            // 
            // FormExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 665);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormExample";
            this.Text = "FormExample";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox listBox1;
        private UserControlITimeRangeObjectTuning userControlITimeRangeObjectTuning1;
        private System.Windows.Forms.Button buttonSchedule;
    }
}