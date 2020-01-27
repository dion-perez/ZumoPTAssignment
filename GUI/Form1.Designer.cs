namespace Zumo_GUI_Master_Controller
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnW = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnA = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnTask2 = new System.Windows.Forms.Button();
            this.boxUserInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.outputBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(11, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // btnW
            // 
            this.btnW.Location = new System.Drawing.Point(78, 249);
            this.btnW.Name = "btnW";
            this.btnW.Size = new System.Drawing.Size(75, 38);
            this.btnW.TabIndex = 1;
            this.btnW.Text = "W";
            this.btnW.UseVisualStyleBackColor = true;
            this.btnW.Click += new System.EventHandler(this.btnWClick);
            // 
            // btnS
            // 
            this.btnS.Location = new System.Drawing.Point(78, 335);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(75, 36);
            this.btnS.TabIndex = 2;
            this.btnS.Text = "S";
            this.btnS.UseVisualStyleBackColor = true;
            this.btnS.Click += new System.EventHandler(this.btnSClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Connection";
            // 
            // btnA
            // 
            this.btnA.Location = new System.Drawing.Point(16, 293);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(75, 38);
            this.btnA.TabIndex = 4;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnAClick);
            // 
            // btnD
            // 
            this.btnD.Location = new System.Drawing.Point(143, 293);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(75, 36);
            this.btnD.TabIndex = 5;
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.btnDClick);
            // 
            // btnTask2
            // 
            this.btnTask2.Location = new System.Drawing.Point(249, 291);
            this.btnTask2.Name = "btnTask2";
            this.btnTask2.Size = new System.Drawing.Size(75, 38);
            this.btnTask2.TabIndex = 6;
            this.btnTask2.Text = "2";
            this.btnTask2.UseVisualStyleBackColor = true;
            this.btnTask2.Click += new System.EventHandler(this.btnTask2_Click);
            // 
            // boxUserInput
            // 
            this.boxUserInput.Location = new System.Drawing.Point(138, 40);
            this.boxUserInput.Name = "boxUserInput";
            this.boxUserInput.Size = new System.Drawing.Size(60, 26);
            this.boxUserInput.TabIndex = 7;
            this.boxUserInput.TextChanged += new System.EventHandler(this.boxUserInput_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Input";
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(16, 186);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 38);
            this.btnLeft.TabIndex = 9;
            this.btnLeft.Text = "Left";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeftTurn);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(143, 186);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 38);
            this.btnRight.TabIndex = 10;
            this.btnRight.Text = "Right";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Output";
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(204, 40);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(202, 117);
            this.outputBox.TabIndex = 13;
            this.outputBox.Text = "";
            this.outputBox.TextChanged += new System.EventHandler(this.outputBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 429);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boxUserInput);
            this.Controls.Add(this.btnTask2);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnS);
            this.Controls.Add(this.btnW);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnW;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnTask2;
        private System.Windows.Forms.TextBox boxUserInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox outputBox;
    }
}

