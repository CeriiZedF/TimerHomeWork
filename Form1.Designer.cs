namespace Timer
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.startProgramm = new System.Windows.Forms.Timer(this.components);
            this.clickerButton = new System.Windows.Forms.Button();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.secondsButton = new System.Windows.Forms.Label();
            this.timerButtonActive = new System.Windows.Forms.Timer(this.components);
            this.recordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 421);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Новий рік  через - ";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // clickerButton
            // 
            this.clickerButton.Location = new System.Drawing.Point(297, 163);
            this.clickerButton.Name = "clickerButton";
            this.clickerButton.Size = new System.Drawing.Size(178, 109);
            this.clickerButton.TabIndex = 1;
            this.clickerButton.Text = "Click";
            this.clickerButton.UseVisualStyleBackColor = true;
            this.clickerButton.Click += new System.EventHandler(this.clickerButton_Click);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(12, 9);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(49, 20);
            this.scoreLabel.TabIndex = 2;
            this.scoreLabel.Text = "Score:";
            // 
            // secondsButton
            // 
            this.secondsButton.AutoSize = true;
            this.secondsButton.Location = new System.Drawing.Point(354, 140);
            this.secondsButton.Name = "secondsButton";
            this.secondsButton.Size = new System.Drawing.Size(67, 20);
            this.secondsButton.TabIndex = 3;
            this.secondsButton.Text = "Seconds:";
            // 
            // timerButtonActive
            // 
            this.timerButtonActive.Interval = 1000;
            this.timerButtonActive.Tick += new System.EventHandler(this.timerButtonActive_Tick);
            // 
            // recordLabel
            // 
            this.recordLabel.AutoSize = true;
            this.recordLabel.Location = new System.Drawing.Point(738, 9);
            this.recordLabel.Name = "recordLabel";
            this.recordLabel.Size = new System.Drawing.Size(56, 20);
            this.recordLabel.TabIndex = 4;
            this.recordLabel.Text = "Record";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.recordLabel);
            this.Controls.Add(this.secondsButton);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.clickerButton);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer startProgramm;
        private Button clickerButton;
        private Label scoreLabel;
        private Label secondsButton;
        private System.Windows.Forms.Timer timerButtonActive;
        private Label recordLabel;
    }
}