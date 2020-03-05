namespace SimplePerceptonExample
{
    partial class SimplePerceptron
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.trainButton = new System.Windows.Forms.Button();
            this.logicalTestButton = new System.Windows.Forms.Button();
            this.trainingDataTextBox = new System.Windows.Forms.TextBox();
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.loaddataButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.initialiseButton = new System.Windows.Forms.Button();
            this.dataChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.userRadioButton = new System.Windows.Forms.RadioButton();
            this.orRadioButton = new System.Windows.Forms.RadioButton();
            this.andRadioButton = new System.Windows.Forms.RadioButton();
            this.typegroupBox = new System.Windows.Forms.GroupBox();
            this.typeBradioButton = new System.Windows.Forms.RadioButton();
            this.typeAradioButton = new System.Windows.Forms.RadioButton();
            this.X1TextBox = new System.Windows.Forms.TextBox();
            this.X2TextBox = new System.Windows.Forms.TextBox();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.decisionLineButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.alphaTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numberEpochsTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataChart)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.typegroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // trainButton
            // 
            this.trainButton.Enabled = false;
            this.trainButton.Location = new System.Drawing.Point(395, 52);
            this.trainButton.Name = "trainButton";
            this.trainButton.Size = new System.Drawing.Size(89, 34);
            this.trainButton.TabIndex = 0;
            this.trainButton.Text = "Train";
            this.trainButton.UseVisualStyleBackColor = true;
            this.trainButton.Click += new System.EventHandler(this.trainButton_Click);
            // 
            // logicalTestButton
            // 
            this.logicalTestButton.Location = new System.Drawing.Point(573, 456);
            this.logicalTestButton.Name = "logicalTestButton";
            this.logicalTestButton.Size = new System.Drawing.Size(110, 33);
            this.logicalTestButton.TabIndex = 1;
            this.logicalTestButton.Text = "Test Perceptron";
            this.logicalTestButton.UseVisualStyleBackColor = true;
            this.logicalTestButton.Click += new System.EventHandler(this.logicalTestButton_Click);
            // 
            // trainingDataTextBox
            // 
            this.trainingDataTextBox.Location = new System.Drawing.Point(541, 128);
            this.trainingDataTextBox.Multiline = true;
            this.trainingDataTextBox.Name = "trainingDataTextBox";
            this.trainingDataTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.trainingDataTextBox.Size = new System.Drawing.Size(192, 178);
            this.trainingDataTextBox.TabIndex = 2;
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.Enabled = false;
            this.fileNameTextBox.Location = new System.Drawing.Point(147, 69);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(93, 20);
            this.fileNameTextBox.TabIndex = 3;
            this.fileNameTextBox.Text = "AND";
            // 
            // loaddataButton
            // 
            this.loaddataButton.Location = new System.Drawing.Point(147, 15);
            this.loaddataButton.Name = "loaddataButton";
            this.loaddataButton.Size = new System.Drawing.Size(130, 34);
            this.loaddataButton.TabIndex = 4;
            this.loaddataButton.Text = "Load Training Data";
            this.loaddataButton.UseVisualStyleBackColor = true;
            this.loaddataButton.Click += new System.EventHandler(this.loaddataButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(579, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Training Data";
            // 
            // initialiseButton
            // 
            this.initialiseButton.Enabled = false;
            this.initialiseButton.Location = new System.Drawing.Point(395, 12);
            this.initialiseButton.Name = "initialiseButton";
            this.initialiseButton.Size = new System.Drawing.Size(89, 34);
            this.initialiseButton.TabIndex = 6;
            this.initialiseButton.Text = "Initialise weights";
            this.initialiseButton.UseVisualStyleBackColor = true;
            this.initialiseButton.Click += new System.EventHandler(this.initialiseButton_Click);
            // 
            // dataChart
            // 
            chartArea1.Name = "ChartArea";
            this.dataChart.ChartAreas.Add(chartArea1);
            this.dataChart.Location = new System.Drawing.Point(26, 112);
            this.dataChart.Name = "dataChart";
            this.dataChart.Size = new System.Drawing.Size(500, 500);
            this.dataChart.TabIndex = 7;
            this.dataChart.Text = "chart1";
            this.dataChart.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataChart_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.userRadioButton);
            this.groupBox1.Controls.Add(this.orRadioButton);
            this.groupBox1.Controls.Add(this.andRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(26, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(97, 94);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data set";
            // 
            // userRadioButton
            // 
            this.userRadioButton.AutoSize = true;
            this.userRadioButton.Location = new System.Drawing.Point(7, 71);
            this.userRadioButton.Name = "userRadioButton";
            this.userRadioButton.Size = new System.Drawing.Size(87, 17);
            this.userRadioButton.TabIndex = 2;
            this.userRadioButton.TabStop = true;
            this.userRadioButton.Text = "User Defined";
            this.userRadioButton.UseVisualStyleBackColor = true;
            this.userRadioButton.CheckedChanged += new System.EventHandler(this.andRadioButton_CheckedChanged);
            // 
            // orRadioButton
            // 
            this.orRadioButton.AutoSize = true;
            this.orRadioButton.Location = new System.Drawing.Point(7, 44);
            this.orRadioButton.Name = "orRadioButton";
            this.orRadioButton.Size = new System.Drawing.Size(41, 17);
            this.orRadioButton.TabIndex = 1;
            this.orRadioButton.Text = "OR";
            this.orRadioButton.UseVisualStyleBackColor = true;
            this.orRadioButton.CheckedChanged += new System.EventHandler(this.andRadioButton_CheckedChanged);
            // 
            // andRadioButton
            // 
            this.andRadioButton.AutoSize = true;
            this.andRadioButton.Checked = true;
            this.andRadioButton.Location = new System.Drawing.Point(7, 18);
            this.andRadioButton.Name = "andRadioButton";
            this.andRadioButton.Size = new System.Drawing.Size(48, 17);
            this.andRadioButton.TabIndex = 0;
            this.andRadioButton.TabStop = true;
            this.andRadioButton.Text = "AND";
            this.andRadioButton.UseVisualStyleBackColor = true;
            this.andRadioButton.CheckedChanged += new System.EventHandler(this.andRadioButton_CheckedChanged);
            // 
            // typegroupBox
            // 
            this.typegroupBox.Controls.Add(this.typeBradioButton);
            this.typegroupBox.Controls.Add(this.typeAradioButton);
            this.typegroupBox.Enabled = false;
            this.typegroupBox.Location = new System.Drawing.Point(117, 642);
            this.typegroupBox.Name = "typegroupBox";
            this.typegroupBox.Size = new System.Drawing.Size(220, 43);
            this.typegroupBox.TabIndex = 10;
            this.typegroupBox.TabStop = false;
            this.typegroupBox.Text = "Output type";
            // 
            // typeBradioButton
            // 
            this.typeBradioButton.AutoSize = true;
            this.typeBradioButton.Location = new System.Drawing.Point(135, 20);
            this.typeBradioButton.Name = "typeBradioButton";
            this.typeBradioButton.Size = new System.Drawing.Size(59, 17);
            this.typeBradioButton.TabIndex = 1;
            this.typeBradioButton.Text = "Type B";
            this.typeBradioButton.UseVisualStyleBackColor = true;
            // 
            // typeAradioButton
            // 
            this.typeAradioButton.AutoSize = true;
            this.typeAradioButton.Checked = true;
            this.typeAradioButton.Location = new System.Drawing.Point(16, 20);
            this.typeAradioButton.Name = "typeAradioButton";
            this.typeAradioButton.Size = new System.Drawing.Size(59, 17);
            this.typeAradioButton.TabIndex = 0;
            this.typeAradioButton.TabStop = true;
            this.typeAradioButton.Text = "Type A";
            this.typeAradioButton.UseVisualStyleBackColor = true;
            // 
            // X1TextBox
            // 
            this.X1TextBox.Location = new System.Drawing.Point(560, 363);
            this.X1TextBox.Name = "X1TextBox";
            this.X1TextBox.Size = new System.Drawing.Size(50, 20);
            this.X1TextBox.TabIndex = 11;
            this.X1TextBox.Text = "0";
            // 
            // X2TextBox
            // 
            this.X2TextBox.Location = new System.Drawing.Point(558, 416);
            this.X2TextBox.Name = "X2TextBox";
            this.X2TextBox.Size = new System.Drawing.Size(52, 20);
            this.X2TextBox.TabIndex = 12;
            this.X2TextBox.Text = "0";
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Enabled = false;
            this.OutputTextBox.Location = new System.Drawing.Point(648, 391);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.Size = new System.Drawing.Size(85, 20);
            this.OutputTextBox.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(532, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "X1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(532, 419);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "X2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(653, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Output";
            // 
            // decisionLineButton
            // 
            this.decisionLineButton.Location = new System.Drawing.Point(558, 562);
            this.decisionLineButton.Name = "decisionLineButton";
            this.decisionLineButton.Size = new System.Drawing.Size(137, 37);
            this.decisionLineButton.TabIndex = 17;
            this.decisionLineButton.Text = "Show Decision Line";
            this.decisionLineButton.UseVisualStyleBackColor = true;
            this.decisionLineButton.Click += new System.EventHandler(this.decisionLineButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(538, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Learning rate, alpha";
            // 
            // alphaTextBox
            // 
            this.alphaTextBox.Location = new System.Drawing.Point(666, 20);
            this.alphaTextBox.Name = "alphaTextBox";
            this.alphaTextBox.Size = new System.Drawing.Size(67, 20);
            this.alphaTextBox.TabIndex = 19;
            this.alphaTextBox.Text = "0.2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(538, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Number Epochs";
            // 
            // numberEpochsTextBox
            // 
            this.numberEpochsTextBox.Enabled = false;
            this.numberEpochsTextBox.Location = new System.Drawing.Point(666, 56);
            this.numberEpochsTextBox.Name = "numberEpochsTextBox";
            this.numberEpochsTextBox.Size = new System.Drawing.Size(67, 20);
            this.numberEpochsTextBox.TabIndex = 21;
            // 
            // SimplePerceptron
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 704);
            this.Controls.Add(this.numberEpochsTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.alphaTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.decisionLineButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.X2TextBox);
            this.Controls.Add(this.X1TextBox);
            this.Controls.Add(this.typegroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataChart);
            this.Controls.Add(this.logicalTestButton);
            this.Controls.Add(this.initialiseButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loaddataButton);
            this.Controls.Add(this.trainButton);
            this.Controls.Add(this.fileNameTextBox);
            this.Controls.Add(this.trainingDataTextBox);
            this.Name = "SimplePerceptron";
            this.Text = "Simple Perceptron";
            ((System.ComponentModel.ISupportInitialize)(this.dataChart)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.typegroupBox.ResumeLayout(false);
            this.typegroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button trainButton;
        private System.Windows.Forms.TextBox trainingDataTextBox;
        private System.Windows.Forms.TextBox fileNameTextBox;
        private System.Windows.Forms.Button loaddataButton;
        private System.Windows.Forms.Button logicalTestButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button initialiseButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart dataChart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton orRadioButton;
        private System.Windows.Forms.RadioButton andRadioButton;
        private System.Windows.Forms.GroupBox typegroupBox;
        private System.Windows.Forms.RadioButton typeBradioButton;
        private System.Windows.Forms.RadioButton typeAradioButton;
        private System.Windows.Forms.TextBox X1TextBox;
        private System.Windows.Forms.TextBox X2TextBox;
        private System.Windows.Forms.TextBox OutputTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button decisionLineButton;
        private System.Windows.Forms.RadioButton userRadioButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox alphaTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox numberEpochsTextBox;
    }
}

