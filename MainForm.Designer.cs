namespace RDB_A04
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.name_TextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.D_button = new System.Windows.Forms.RadioButton();
            this.C_button = new System.Windows.Forms.RadioButton();
            this.B_button = new System.Windows.Forms.RadioButton();
            this.A_button = new System.Windows.Forms.RadioButton();
            this.next_Btn = new System.Windows.Forms.Button();
            this.countDown_Lable = new System.Windows.Forms.Label();
            this.question_Lable = new System.Windows.Forms.Label();
            this.questionNo_Lable = new System.Windows.Forms.Label();
            this.start_Btn = new System.Windows.Forms.Button();
            this.summary_Label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.showAnswer_Btn = new System.Windows.Forms.Button();
            this.answer_label = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // name_TextBox
            // 
            this.name_TextBox.Location = new System.Drawing.Point(61, 92);
            this.name_TextBox.Name = "name_TextBox";
            this.name_TextBox.Size = new System.Drawing.Size(100, 20);
            this.name_TextBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.answer_label);
            this.groupBox1.Controls.Add(this.D_button);
            this.groupBox1.Controls.Add(this.C_button);
            this.groupBox1.Controls.Add(this.B_button);
            this.groupBox1.Controls.Add(this.A_button);
            this.groupBox1.Controls.Add(this.next_Btn);
            this.groupBox1.Controls.Add(this.countDown_Lable);
            this.groupBox1.Controls.Add(this.question_Lable);
            this.groupBox1.Controls.Add(this.questionNo_Lable);
            this.groupBox1.Location = new System.Drawing.Point(15, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(773, 320);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.showAnswer_Btn);
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Location = new System.Drawing.Point(15, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(773, 319);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(5, 20);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(762, 270);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // D_button
            // 
            this.D_button.AutoSize = true;
            this.D_button.Location = new System.Drawing.Point(439, 252);
            this.D_button.Name = "D_button";
            this.D_button.Size = new System.Drawing.Size(33, 17);
            this.D_button.TabIndex = 10;
            this.D_button.TabStop = true;
            this.D_button.Text = "D";
            this.D_button.UseVisualStyleBackColor = true;
            // 
            // C_button
            // 
            this.C_button.AutoSize = true;
            this.C_button.Location = new System.Drawing.Point(13, 252);
            this.C_button.Name = "C_button";
            this.C_button.Size = new System.Drawing.Size(32, 17);
            this.C_button.TabIndex = 9;
            this.C_button.TabStop = true;
            this.C_button.Text = "C";
            this.C_button.UseVisualStyleBackColor = true;
            // 
            // B_button
            // 
            this.B_button.AutoSize = true;
            this.B_button.Location = new System.Drawing.Point(439, 210);
            this.B_button.Name = "B_button";
            this.B_button.Size = new System.Drawing.Size(32, 17);
            this.B_button.TabIndex = 8;
            this.B_button.TabStop = true;
            this.B_button.Text = "B";
            this.B_button.UseVisualStyleBackColor = true;
            // 
            // A_button
            // 
            this.A_button.AutoSize = true;
            this.A_button.Location = new System.Drawing.Point(13, 210);
            this.A_button.Name = "A_button";
            this.A_button.Size = new System.Drawing.Size(32, 17);
            this.A_button.TabIndex = 5;
            this.A_button.TabStop = true;
            this.A_button.Text = "A";
            this.A_button.UseVisualStyleBackColor = true;
            // 
            // next_Btn
            // 
            this.next_Btn.Location = new System.Drawing.Point(12, 291);
            this.next_Btn.Name = "next_Btn";
            this.next_Btn.Size = new System.Drawing.Size(75, 23);
            this.next_Btn.TabIndex = 7;
            this.next_Btn.Text = "Next";
            this.next_Btn.UseVisualStyleBackColor = true;
            this.next_Btn.Click += new System.EventHandler(this.next_Btn_Click);
            // 
            // countDown_Lable
            // 
            this.countDown_Lable.AutoSize = true;
            this.countDown_Lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countDown_Lable.Location = new System.Drawing.Point(653, 27);
            this.countDown_Lable.Name = "countDown_Lable";
            this.countDown_Lable.Size = new System.Drawing.Size(114, 16);
            this.countDown_Lable.TabIndex = 2;
            this.countDown_Lable.Text = "countDown_Lable";
            // 
            // question_Lable
            // 
            this.question_Lable.AutoSize = true;
            this.question_Lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question_Lable.Location = new System.Drawing.Point(9, 55);
            this.question_Lable.Name = "question_Lable";
            this.question_Lable.Size = new System.Drawing.Size(118, 20);
            this.question_Lable.TabIndex = 1;
            this.question_Lable.Text = "question_Lable";
            // 
            // questionNo_Lable
            // 
            this.questionNo_Lable.AutoSize = true;
            this.questionNo_Lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionNo_Lable.Location = new System.Drawing.Point(7, 20);
            this.questionNo_Lable.Name = "questionNo_Lable";
            this.questionNo_Lable.Size = new System.Drawing.Size(186, 25);
            this.questionNo_Lable.TabIndex = 0;
            this.questionNo_Lable.Text = "questionNo_Lable";
            // 
            // start_Btn
            // 
            this.start_Btn.Location = new System.Drawing.Point(167, 92);
            this.start_Btn.Name = "start_Btn";
            this.start_Btn.Size = new System.Drawing.Size(75, 21);
            this.start_Btn.TabIndex = 4;
            this.start_Btn.Text = "Start";
            this.start_Btn.UseVisualStyleBackColor = true;
            this.start_Btn.Click += new System.EventHandler(this.start_Btn_Click);
            // 
            // summary_Label
            // 
            this.summary_Label.AutoSize = true;
            this.summary_Label.Location = new System.Drawing.Point(248, 95);
            this.summary_Label.Name = "summary_Label";
            this.summary_Label.Size = new System.Drawing.Size(0, 13);
            this.summary_Label.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 37);
            this.label2.TabIndex = 13;
            this.label2.Text = "RDB_A04";
            // 
            // showAnswer_Btn
            // 
            this.showAnswer_Btn.Location = new System.Drawing.Point(5, 296);
            this.showAnswer_Btn.Name = "showAnswer_Btn";
            this.showAnswer_Btn.Size = new System.Drawing.Size(111, 23);
            this.showAnswer_Btn.TabIndex = 1;
            this.showAnswer_Btn.Text = "Show Answers";
            this.showAnswer_Btn.UseVisualStyleBackColor = true;
            this.showAnswer_Btn.Click += new System.EventHandler(this.showAnswer_Btn_Click);
            // 
            // answer_label
            // 
            this.answer_label.AutoSize = true;
            this.answer_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer_label.Location = new System.Drawing.Point(103, 294);
            this.answer_label.Name = "answer_label";
            this.answer_label.Size = new System.Drawing.Size(10, 16);
            this.answer_label.TabIndex = 11;
            this.answer_label.Text = " ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.summary_Label);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.start_Btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.name_TextBox);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "RDB_A04";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name_TextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button start_Btn;
        private System.Windows.Forms.Button next_Btn;
        private System.Windows.Forms.Label countDown_Lable;
        private System.Windows.Forms.Label question_Lable;
        private System.Windows.Forms.Label questionNo_Lable;
        private System.Windows.Forms.RadioButton D_button;
        private System.Windows.Forms.RadioButton C_button;
        private System.Windows.Forms.RadioButton B_button;
        private System.Windows.Forms.RadioButton A_button;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label summary_Label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button showAnswer_Btn;
        private System.Windows.Forms.Label answer_label;
    }
}

