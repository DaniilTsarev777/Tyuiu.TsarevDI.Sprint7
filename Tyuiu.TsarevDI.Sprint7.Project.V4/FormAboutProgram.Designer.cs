namespace Tyuiu.TsarevDI.Sprint7.Project.V4
{
    partial class FormAboutProgram
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAboutProgram));
            pictureBox1 = new PictureBox();
            aboutProgramHead = new Label();
            aboutProgramText = new Label();
            copyright = new Label();
            buttonExitAboutProgram_TDI = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 83);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(288, 235);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // aboutProgramHead
            // 
            aboutProgramHead.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            aboutProgramHead.Location = new Point(404, 27);
            aboutProgramHead.Name = "aboutProgramHead";
            aboutProgramHead.Size = new Size(136, 33);
            aboutProgramHead.TabIndex = 2;
            aboutProgramHead.Text = "Библиотека !++";
            aboutProgramHead.Click += aboutProgramHead_Click;
            // 
            // aboutProgramText
            // 
            aboutProgramText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            aboutProgramText.Location = new Point(306, 51);
            aboutProgramText.Name = "aboutProgramText";
            aboutProgramText.Size = new Size(338, 302);
            aboutProgramText.TabIndex = 3;
            aboutProgramText.Text = "\r\n\r\n\r\n\r\n\r\nпрограмму разработал студент Тюменского Индустриального Университета Высшей Школы Цифровых Технологии группы СМАРТб-24-1 Царёв Д.И. ";
            aboutProgramText.Click += aboutProgramText_Click;
            // 
            // copyright
            // 
            copyright.AutoSize = true;
            copyright.Location = new Point(296, 402);
            copyright.Name = "copyright";
            copyright.Size = new Size(47, 15);
            copyright.TabIndex = 4;
            copyright.Text = "2024(C)";
            // 
            // buttonExitAboutProgram_TDI
            // 
            buttonExitAboutProgram_TDI.BackColor = SystemColors.ButtonHighlight;
            buttonExitAboutProgram_TDI.ForeColor = SystemColors.ControlText;
            buttonExitAboutProgram_TDI.Location = new Point(536, 356);
            buttonExitAboutProgram_TDI.Name = "buttonExitAboutProgram_TDI";
            buttonExitAboutProgram_TDI.Size = new Size(77, 34);
            buttonExitAboutProgram_TDI.TabIndex = 5;
            buttonExitAboutProgram_TDI.Text = "OK";
            buttonExitAboutProgram_TDI.UseVisualStyleBackColor = false;
            buttonExitAboutProgram_TDI.Click += buttonExitAboutProgram_TDI_Click;
            // 
            // FormAboutProgram
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(656, 426);
            Controls.Add(buttonExitAboutProgram_TDI);
            Controls.Add(copyright);
            Controls.Add(aboutProgramText);
            Controls.Add(aboutProgramHead);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormAboutProgram";
            Text = "О программе";
            Load += FormAboutProgram_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label aboutProgramHead;
        private Label aboutProgramText;
        private Label copyright;
        private Button buttonExitAboutProgram_TDI;
    }
}