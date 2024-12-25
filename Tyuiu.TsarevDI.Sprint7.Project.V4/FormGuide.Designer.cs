namespace Tyuiu.TsarevDI.Sprint7.Project.V4
{
    partial class FormGuide
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGuide));
            pictureBox1 = new PictureBox();
            programName_TDI = new Label();
            programGuide_TDI = new Label();
            buttonExitAGuide_TDI = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(32, 56);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(397, 383);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // programName_TDI
            // 
            programName_TDI.AutoSize = true;
            programName_TDI.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            programName_TDI.Location = new Point(694, 56);
            programName_TDI.Name = "programName_TDI";
            programName_TDI.Size = new Size(155, 25);
            programName_TDI.TabIndex = 3;
            programName_TDI.Text = "Библиотека!++";
            // 
            // programGuide_TDI
            // 
            programGuide_TDI.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            programGuide_TDI.Location = new Point(475, 121);
            programGuide_TDI.Name = "programGuide_TDI";
            programGuide_TDI.Size = new Size(603, 281);
            programGuide_TDI.TabIndex = 4;
            programGuide_TDI.Text = resources.GetString("programGuide_TDI.Text");
            programGuide_TDI.Click += programGuide_TDI_Click;
            // 
            // buttonExitAGuide_TDI
            // 
            buttonExitAGuide_TDI.BackColor = SystemColors.ButtonHighlight;
            buttonExitAGuide_TDI.ForeColor = SystemColors.ControlText;
            buttonExitAGuide_TDI.Location = new Point(1001, 405);
            buttonExitAGuide_TDI.Name = "buttonExitAGuide_TDI";
            buttonExitAGuide_TDI.Size = new Size(77, 34);
            buttonExitAGuide_TDI.TabIndex = 6;
            buttonExitAGuide_TDI.Text = "OK";
            buttonExitAGuide_TDI.UseVisualStyleBackColor = false;
            buttonExitAGuide_TDI.Click += programGuide_TDI_Click;
            // 
            // FormGuide
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1108, 474);
            Controls.Add(buttonExitAGuide_TDI);
            Controls.Add(programGuide_TDI);
            Controls.Add(programName_TDI);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormGuide";
            Text = "Краткое руководство пользователя";
            Load += FormGuide_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label programName_TDI;
        private Label programGuide_TDI;
        private Button buttonExitAGuide_TDI;
    }
}