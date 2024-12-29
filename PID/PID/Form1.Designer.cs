namespace PID
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
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            textBox_value_p = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox_value_i = new TextBox();
            label3 = new Label();
            textBox_value_d = new TextBox();
            button_start = new Button();
            button_suspend = new Button();
            button_reset = new Button();
            label4 = new Label();
            textBox_value_set = new TextBox();
            button_modification = new Button();
            button_create = new Button();
            SuspendLayout();
            // 
            // formsPlot1
            // 
            formsPlot1.DisplayScale = 1F;
            formsPlot1.Location = new Point(1, -2);
            formsPlot1.Margin = new Padding(4, 4, 4, 4);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(1281, 982);
            formsPlot1.TabIndex = 0;
            // 
            // textBox_value_p
            // 
            textBox_value_p.Location = new Point(1394, 14);
            textBox_value_p.Margin = new Padding(4, 4, 4, 4);
            textBox_value_p.Name = "textBox_value_p";
            textBox_value_p.Size = new Size(127, 27);
            textBox_value_p.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(1317, 11);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(69, 35);
            label1.TabIndex = 2;
            label1.Text = "比例";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(1317, 59);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(69, 35);
            label2.TabIndex = 4;
            label2.Text = "积分";
            // 
            // textBox_value_i
            // 
            textBox_value_i.Location = new Point(1394, 62);
            textBox_value_i.Margin = new Padding(4, 4, 4, 4);
            textBox_value_i.Name = "textBox_value_i";
            textBox_value_i.Size = new Size(127, 27);
            textBox_value_i.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(1317, 107);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(69, 35);
            label3.TabIndex = 6;
            label3.Text = "微分";
            // 
            // textBox_value_d
            // 
            textBox_value_d.Location = new Point(1394, 111);
            textBox_value_d.Margin = new Padding(4, 4, 4, 4);
            textBox_value_d.Name = "textBox_value_d";
            textBox_value_d.Size = new Size(127, 27);
            textBox_value_d.TabIndex = 5;
            // 
            // button_start
            // 
            button_start.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button_start.Location = new Point(1317, 729);
            button_start.Margin = new Padding(4, 4, 4, 4);
            button_start.Name = "button_start";
            button_start.Size = new Size(206, 49);
            button_start.TabIndex = 7;
            button_start.Text = "开始运行";
            button_start.UseVisualStyleBackColor = true;
            button_start.Click += button_start_Click;
            // 
            // button_suspend
            // 
            button_suspend.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button_suspend.Location = new Point(1317, 786);
            button_suspend.Margin = new Padding(4, 4, 4, 4);
            button_suspend.Name = "button_suspend";
            button_suspend.Size = new Size(206, 49);
            button_suspend.TabIndex = 8;
            button_suspend.Text = "暂停运行";
            button_suspend.UseVisualStyleBackColor = true;
            button_suspend.Click += button_suspend_Click;
            // 
            // button_reset
            // 
            button_reset.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button_reset.Location = new Point(1317, 899);
            button_reset.Margin = new Padding(4, 4, 4, 4);
            button_reset.Name = "button_reset";
            button_reset.Size = new Size(206, 49);
            button_reset.TabIndex = 9;
            button_reset.Text = "初始化";
            button_reset.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(1290, 156);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(96, 35);
            label4.TabIndex = 11;
            label4.Text = "设定值";
            // 
            // textBox_value_set
            // 
            textBox_value_set.Location = new Point(1394, 162);
            textBox_value_set.Margin = new Padding(4, 4, 4, 4);
            textBox_value_set.Name = "textBox_value_set";
            textBox_value_set.Size = new Size(127, 27);
            textBox_value_set.TabIndex = 10;
            // 
            // button_modification
            // 
            button_modification.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button_modification.Location = new Point(1317, 842);
            button_modification.Margin = new Padding(4, 4, 4, 4);
            button_modification.Name = "button_modification";
            button_modification.Size = new Size(206, 49);
            button_modification.TabIndex = 12;
            button_modification.Text = "修改设定值";
            button_modification.UseVisualStyleBackColor = true;
            // 
            // button_create
            // 
            button_create.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button_create.Location = new Point(1317, 213);
            button_create.Margin = new Padding(4);
            button_create.Name = "button_create";
            button_create.Size = new Size(206, 49);
            button_create.TabIndex = 13;
            button_create.Text = "创建控制器实例";
            button_create.UseVisualStyleBackColor = true;
            button_create.Click += button_create_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1584, 994);
            Controls.Add(button_create);
            Controls.Add(button_modification);
            Controls.Add(label4);
            Controls.Add(textBox_value_set);
            Controls.Add(button_reset);
            Controls.Add(button_suspend);
            Controls.Add(button_start);
            Controls.Add(label3);
            Controls.Add(textBox_value_d);
            Controls.Add(label2);
            Controls.Add(textBox_value_i);
            Controls.Add(label1);
            Controls.Add(textBox_value_p);
            Controls.Add(formsPlot1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ScottPlot.WinForms.FormsPlot formsPlot1;
        private TextBox textBox_value_p;
        private Label label1;
        private Label label2;
        private TextBox textBox_value_i;
        private Label label3;
        private TextBox textBox_value_d;
        private Button button_start;
        private Button button_suspend;
        private Button button_reset;
        private Label label4;
        private TextBox textBox_value_set;
        private Button button_modification;
        private Button button_create;
    }
}
