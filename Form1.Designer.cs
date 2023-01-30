namespace LAB04
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbBirthYear = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbGrade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelNameMinGrade = new System.Windows.Forms.Label();
            this.labelNameMaxGrade = new System.Windows.Forms.Label();
            this.labelPersonList = new System.Windows.Forms.Label();
            this.totalAge = new System.Windows.Forms.Label();
            this.labelGradeAvg = new System.Windows.Forms.Label();
            this.labelGradeMin = new System.Windows.Forms.Label();
            this.labelGradeMax = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ชื่อ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ปีเกิด";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "รายชื่อ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(68, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 71);
            this.button1.TabIndex = 3;
            this.button1.Text = "เพิ่มข้อมูล";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbName.Location = new System.Drawing.Point(68, 32);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(218, 27);
            this.tbName.TabIndex = 4;
            // 
            // tbBirthYear
            // 
            this.tbBirthYear.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbBirthYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbBirthYear.Location = new System.Drawing.Point(68, 65);
            this.tbBirthYear.Name = "tbBirthYear";
            this.tbBirthYear.Size = new System.Drawing.Size(218, 27);
            this.tbBirthYear.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "อายุรวม";
            // 
            // tbGrade
            // 
            this.tbGrade.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbGrade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbGrade.Location = new System.Drawing.Point(68, 98);
            this.tbGrade.Name = "tbGrade";
            this.tbGrade.Size = new System.Drawing.Size(218, 27);
            this.tbGrade.TabIndex = 10;
            this.tbGrade.TextChanged += new System.EventHandler(this.tbGrade_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "GPA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "GPA Max";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "GPA Min";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(280, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "ชื่อ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(280, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "ชื่อ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelNameMinGrade);
            this.groupBox1.Controls.Add(this.labelNameMaxGrade);
            this.groupBox1.Controls.Add(this.labelPersonList);
            this.groupBox1.Controls.Add(this.totalAge);
            this.groupBox1.Controls.Add(this.labelGradeAvg);
            this.groupBox1.Controls.Add(this.labelGradeMin);
            this.groupBox1.Controls.Add(this.labelGradeMax);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(319, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 445);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "รายชื่อ";
            // 
            // labelNameMinGrade
            // 
            this.labelNameMinGrade.AutoSize = true;
            this.labelNameMinGrade.Location = new System.Drawing.Point(312, 83);
            this.labelNameMinGrade.Name = "labelNameMinGrade";
            this.labelNameMinGrade.Size = new System.Drawing.Size(0, 20);
            this.labelNameMinGrade.TabIndex = 26;
            // 
            // labelNameMaxGrade
            // 
            this.labelNameMaxGrade.AutoSize = true;
            this.labelNameMaxGrade.Location = new System.Drawing.Point(312, 50);
            this.labelNameMaxGrade.Name = "labelNameMaxGrade";
            this.labelNameMaxGrade.Size = new System.Drawing.Size(0, 20);
            this.labelNameMaxGrade.TabIndex = 25;
            // 
            // labelPersonList
            // 
            this.labelPersonList.AutoSize = true;
            this.labelPersonList.Location = new System.Drawing.Point(97, 182);
            this.labelPersonList.Name = "labelPersonList";
            this.labelPersonList.Size = new System.Drawing.Size(17, 20);
            this.labelPersonList.TabIndex = 24;
            this.labelPersonList.Text = "0";
            // 
            // totalAge
            // 
            this.totalAge.AccessibleDescription = "totalAge";
            this.totalAge.AutoSize = true;
            this.totalAge.Location = new System.Drawing.Point(97, 149);
            this.totalAge.Name = "totalAge";
            this.totalAge.Size = new System.Drawing.Size(17, 20);
            this.totalAge.TabIndex = 23;
            this.totalAge.Text = "0";
            // 
            // labelGradeAvg
            // 
            this.labelGradeAvg.AutoSize = true;
            this.labelGradeAvg.Location = new System.Drawing.Point(97, 116);
            this.labelGradeAvg.Name = "labelGradeAvg";
            this.labelGradeAvg.Size = new System.Drawing.Size(17, 20);
            this.labelGradeAvg.TabIndex = 22;
            this.labelGradeAvg.Text = "0";
            // 
            // labelGradeMin
            // 
            this.labelGradeMin.AutoSize = true;
            this.labelGradeMin.Location = new System.Drawing.Point(97, 83);
            this.labelGradeMin.Name = "labelGradeMin";
            this.labelGradeMin.Size = new System.Drawing.Size(17, 20);
            this.labelGradeMin.TabIndex = 21;
            this.labelGradeMin.Text = "0";
            // 
            // labelGradeMax
            // 
            this.labelGradeMax.AutoSize = true;
            this.labelGradeMax.Location = new System.Drawing.Point(97, 50);
            this.labelGradeMax.Name = "labelGradeMax";
            this.labelGradeMax.Size = new System.Drawing.Size(17, 20);
            this.labelGradeMax.TabIndex = 20;
            this.labelGradeMax.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "GPA Avg";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(857, 469);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbGrade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbBirthYear);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private TextBox tbName;
        private TextBox tbBirthYear;
        private Label label4;
        private TextBox tbGrade;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label9;
        private Label label10;
        private GroupBox groupBox1;
        private Label labelNameMinGrade;
        private Label labelNameMaxGrade;
        private Label labelPersonList;
        private Label totalAge;
        private Label labelGradeMin;
        private Label labelGradeMax;
        private Label labelGradeAvg;
        private Label label8;
    }
}