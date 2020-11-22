namespace C_alculator__Sharp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.mod = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.subtraction = new System.Windows.Forms.Button();
            this.addition = new System.Windows.Forms.Button();
            this.multiplication = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Button();
            this.fraction = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.changeSign = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.factorial = new System.Windows.Forms.Button();
            this.absolute = new System.Windows.Forms.Button();
            this.e = new System.Windows.Forms.Button();
            this.pi = new System.Windows.Forms.Button();
            this.sqrt = new System.Windows.Forms.Button();
            this.xPower2 = new System.Windows.Forms.Button();
            this.division1X = new System.Windows.Forms.Button();
            this.naturalLog = new System.Windows.Forms.Button();
            this.logXY = new System.Windows.Forms.Button();
            this.xDegreeY = new System.Windows.Forms.Button();
            this.arbitraryRoot = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.resultLabel);
            this.groupBox1.Location = new System.Drawing.Point(8, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(624, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultLabel.Location = new System.Drawing.Point(582, 16);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(39, 42);
            this.resultLabel.TabIndex = 0;
            this.resultLabel.Text = "0";
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete.Location = new System.Drawing.Point(512, 93);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(120, 60);
            this.delete.TabIndex = 1;
            this.delete.Text = "CE";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // mod
            // 
            this.mod.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mod.Location = new System.Drawing.Point(386, 93);
            this.mod.Name = "mod";
            this.mod.Size = new System.Drawing.Size(120, 60);
            this.mod.TabIndex = 2;
            this.mod.Text = "mod";
            this.mod.UseVisualStyleBackColor = true;
            this.mod.Click += new System.EventHandler(this.mod_Click);
            // 
            // division
            // 
            this.division.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.division.Location = new System.Drawing.Point(512, 159);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(120, 60);
            this.division.TabIndex = 3;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.division_Click);
            // 
            // subtraction
            // 
            this.subtraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subtraction.Location = new System.Drawing.Point(512, 357);
            this.subtraction.Name = "subtraction";
            this.subtraction.Size = new System.Drawing.Size(120, 60);
            this.subtraction.TabIndex = 4;
            this.subtraction.Text = "-";
            this.subtraction.UseVisualStyleBackColor = true;
            this.subtraction.Click += new System.EventHandler(this.subtraction_Click);
            // 
            // addition
            // 
            this.addition.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addition.Location = new System.Drawing.Point(512, 291);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(120, 60);
            this.addition.TabIndex = 5;
            this.addition.Text = "+";
            this.addition.UseVisualStyleBackColor = true;
            this.addition.Click += new System.EventHandler(this.addition_Click);
            // 
            // multiplication
            // 
            this.multiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.multiplication.Location = new System.Drawing.Point(512, 225);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(120, 60);
            this.multiplication.TabIndex = 6;
            this.multiplication.Text = "*";
            this.multiplication.UseVisualStyleBackColor = true;
            this.multiplication.Click += new System.EventHandler(this.multiplication_Click);
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.Color.LightSeaGreen;
            this.result.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.result.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.result.FlatAppearance.BorderSize = 0;
            this.result.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result.ForeColor = System.Drawing.Color.White;
            this.result.Location = new System.Drawing.Point(512, 423);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(120, 60);
            this.result.TabIndex = 7;
            this.result.Text = "=";
            this.result.UseVisualStyleBackColor = false;
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // fraction
            // 
            this.fraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fraction.Location = new System.Drawing.Point(386, 423);
            this.fraction.Name = "fraction";
            this.fraction.Size = new System.Drawing.Size(120, 60);
            this.fraction.TabIndex = 8;
            this.fraction.Text = ",";
            this.fraction.UseVisualStyleBackColor = true;
            this.fraction.Click += new System.EventHandler(this.fraction_Click);
            // 
            // button0
            // 
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button0.Location = new System.Drawing.Point(260, 423);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(120, 60);
            this.button0.TabIndex = 9;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // changeSign
            // 
            this.changeSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeSign.Location = new System.Drawing.Point(134, 423);
            this.changeSign.Name = "changeSign";
            this.changeSign.Size = new System.Drawing.Size(120, 60);
            this.changeSign.TabIndex = 10;
            this.changeSign.Text = "+/-";
            this.changeSign.UseVisualStyleBackColor = true;
            this.changeSign.Click += new System.EventHandler(this.changeSign_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(134, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 60);
            this.button1.TabIndex = 13;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(260, 357);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 60);
            this.button2.TabIndex = 12;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(386, 357);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 60);
            this.button3.TabIndex = 11;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(134, 291);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 60);
            this.button4.TabIndex = 16;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(260, 291);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 60);
            this.button5.TabIndex = 15;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(386, 291);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(120, 60);
            this.button6.TabIndex = 14;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(134, 225);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(120, 60);
            this.button7.TabIndex = 19;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(260, 225);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(120, 60);
            this.button8.TabIndex = 18;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.Location = new System.Drawing.Point(386, 225);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(120, 60);
            this.button9.TabIndex = 17;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // factorial
            // 
            this.factorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.factorial.Location = new System.Drawing.Point(386, 159);
            this.factorial.Name = "factorial";
            this.factorial.Size = new System.Drawing.Size(120, 60);
            this.factorial.TabIndex = 20;
            this.factorial.Text = "n!";
            this.factorial.UseVisualStyleBackColor = true;
            this.factorial.Click += new System.EventHandler(this.factorial_Click);
            // 
            // absolute
            // 
            this.absolute.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.absolute.Location = new System.Drawing.Point(260, 93);
            this.absolute.Name = "absolute";
            this.absolute.Size = new System.Drawing.Size(120, 60);
            this.absolute.TabIndex = 21;
            this.absolute.Text = "|x|";
            this.absolute.UseVisualStyleBackColor = true;
            this.absolute.Click += new System.EventHandler(this.absolute_Click);
            // 
            // e
            // 
            this.e.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.e.Location = new System.Drawing.Point(260, 159);
            this.e.Name = "e";
            this.e.Size = new System.Drawing.Size(120, 60);
            this.e.TabIndex = 22;
            this.e.Text = "e";
            this.e.UseVisualStyleBackColor = true;
            this.e.Click += new System.EventHandler(this.e_Click);
            // 
            // pi
            // 
            this.pi.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pi.Location = new System.Drawing.Point(134, 159);
            this.pi.Name = "pi";
            this.pi.Size = new System.Drawing.Size(120, 60);
            this.pi.TabIndex = 23;
            this.pi.Text = "Pi";
            this.pi.UseVisualStyleBackColor = true;
            this.pi.Click += new System.EventHandler(this.pi_Click);
            // 
            // sqrt
            // 
            this.sqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sqrt.Location = new System.Drawing.Point(134, 93);
            this.sqrt.Name = "sqrt";
            this.sqrt.Size = new System.Drawing.Size(120, 60);
            this.sqrt.TabIndex = 24;
            this.sqrt.Text = "sqrt(x)";
            this.sqrt.UseVisualStyleBackColor = true;
            this.sqrt.Click += new System.EventHandler(this.sqrt_Click);
            // 
            // xPower2
            // 
            this.xPower2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xPower2.Location = new System.Drawing.Point(8, 225);
            this.xPower2.Name = "xPower2";
            this.xPower2.Size = new System.Drawing.Size(120, 60);
            this.xPower2.TabIndex = 25;
            this.xPower2.Text = "x^2";
            this.xPower2.UseVisualStyleBackColor = true;
            this.xPower2.Click += new System.EventHandler(this.xPower2_Click);
            // 
            // division1X
            // 
            this.division1X.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.division1X.Location = new System.Drawing.Point(8, 159);
            this.division1X.Name = "division1X";
            this.division1X.Size = new System.Drawing.Size(120, 60);
            this.division1X.TabIndex = 26;
            this.division1X.Text = "1/x";
            this.division1X.UseVisualStyleBackColor = true;
            this.division1X.Click += new System.EventHandler(this.division1X_Click);
            // 
            // naturalLog
            // 
            this.naturalLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.naturalLog.Location = new System.Drawing.Point(8, 423);
            this.naturalLog.Name = "naturalLog";
            this.naturalLog.Size = new System.Drawing.Size(120, 60);
            this.naturalLog.TabIndex = 27;
            this.naturalLog.Text = "ln(x)";
            this.naturalLog.UseVisualStyleBackColor = true;
            this.naturalLog.Click += new System.EventHandler(this.naturalLog_Click);
            // 
            // logXY
            // 
            this.logXY.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logXY.Location = new System.Drawing.Point(8, 357);
            this.logXY.Name = "logXY";
            this.logXY.Size = new System.Drawing.Size(120, 60);
            this.logXY.TabIndex = 28;
            this.logXY.Text = "log(x, y)";
            this.logXY.UseVisualStyleBackColor = true;
            this.logXY.Click += new System.EventHandler(this.logXY_Click);
            // 
            // xDegreeY
            // 
            this.xDegreeY.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xDegreeY.Location = new System.Drawing.Point(8, 291);
            this.xDegreeY.Name = "xDegreeY";
            this.xDegreeY.Size = new System.Drawing.Size(120, 60);
            this.xDegreeY.TabIndex = 29;
            this.xDegreeY.Text = "x^y";
            this.xDegreeY.UseVisualStyleBackColor = true;
            this.xDegreeY.Click += new System.EventHandler(this.xDegreeY_Click);
            // 
            // arbitraryRoot
            // 
            this.arbitraryRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.arbitraryRoot.Location = new System.Drawing.Point(8, 93);
            this.arbitraryRoot.Name = "arbitraryRoot";
            this.arbitraryRoot.Size = new System.Drawing.Size(120, 60);
            this.arbitraryRoot.TabIndex = 30;
            this.arbitraryRoot.Text = "rt(x,y)";
            this.arbitraryRoot.UseVisualStyleBackColor = true;
            this.arbitraryRoot.Click += new System.EventHandler(this.arbitraryRoot_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(644, 491);
            this.Controls.Add(this.arbitraryRoot);
            this.Controls.Add(this.division1X);
            this.Controls.Add(this.xDegreeY);
            this.Controls.Add(this.logXY);
            this.Controls.Add(this.naturalLog);
            this.Controls.Add(this.xPower2);
            this.Controls.Add(this.sqrt);
            this.Controls.Add(this.pi);
            this.Controls.Add(this.e);
            this.Controls.Add(this.absolute);
            this.Controls.Add(this.factorial);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.changeSign);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.fraction);
            this.Controls.Add(this.result);
            this.Controls.Add(this.multiplication);
            this.Controls.Add(this.addition);
            this.Controls.Add(this.subtraction);
            this.Controls.Add(this.division);
            this.Controls.Add(this.mod);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(660, 530);
            this.MinimumSize = new System.Drawing.Size(660, 530);
            this.Name = "Form1";
            this.Text = "Хочу PlayStation 5";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button mod;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button subtraction;
        private System.Windows.Forms.Button addition;
        private System.Windows.Forms.Button multiplication;
        private System.Windows.Forms.Button result;
        private System.Windows.Forms.Button fraction;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button changeSign;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button factorial;
        private System.Windows.Forms.Button absolute;
        private System.Windows.Forms.Button e;
        private System.Windows.Forms.Button pi;
        private System.Windows.Forms.Button sqrt;
        private System.Windows.Forms.Button xPower2;
        private System.Windows.Forms.Button division1X;
        private System.Windows.Forms.Button naturalLog;
        private System.Windows.Forms.Button logXY;
        private System.Windows.Forms.Button xDegreeY;
        private System.Windows.Forms.Button arbitraryRoot;
        private System.Windows.Forms.Label resultLabel;
    }
}

