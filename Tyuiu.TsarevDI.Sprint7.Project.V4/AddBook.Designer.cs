namespace Tyuiu.TsarevDI.Sprint7.Project.V4
{
    partial class AddBook
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBook));
            authorColumn_TDI = new TextBox();
            annotationColumn_TDI = new TextBox();
            newORoldColumn_TDI = new TextBox();
            PriceColumn_TDI = new TextBox();
            YearColumn_TDI = new TextBox();
            nameColumn_TDI = new TextBox();
            buttonAddBook_TDI = new Button();
            buttonRefresh_TDI = new Button();
            authorAdd_TDI = new Label();
            newORoldAdd_TDI = new Label();
            yearAdd_TDI = new Label();
            nameAdd_TDI = new Label();
            priceAdd_TDI = new Label();
            annotationAdd_TDI = new Label();
            labelAddBook_TDI = new Label();
            addTip_TDI = new ToolTip(components);
            refreshTip_TDI = new ToolTip(components);
            NumberOfBook_TDI = new TextBox();
            labelNumberOfBook_TDI = new Label();
            SuspendLayout();
            // 
            // authorColumn_TDI
            // 
            authorColumn_TDI.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            authorColumn_TDI.ForeColor = SystemColors.WindowText;
            authorColumn_TDI.Location = new Point(360, 116);
            authorColumn_TDI.Margin = new Padding(4);
            authorColumn_TDI.Multiline = true;
            authorColumn_TDI.Name = "authorColumn_TDI";
            authorColumn_TDI.Size = new Size(316, 32);
            authorColumn_TDI.TabIndex = 0;
            // 
            // annotationColumn_TDI
            // 
            annotationColumn_TDI.Location = new Point(360, 369);
            annotationColumn_TDI.Margin = new Padding(4);
            annotationColumn_TDI.Multiline = true;
            annotationColumn_TDI.Name = "annotationColumn_TDI";
            annotationColumn_TDI.Size = new Size(316, 77);
            annotationColumn_TDI.TabIndex = 1;
            // 
            // newORoldColumn_TDI
            // 
            newORoldColumn_TDI.Location = new Point(360, 319);
            newORoldColumn_TDI.Margin = new Padding(4);
            newORoldColumn_TDI.Multiline = true;
            newORoldColumn_TDI.Name = "newORoldColumn_TDI";
            newORoldColumn_TDI.Size = new Size(316, 32);
            newORoldColumn_TDI.TabIndex = 2;
            // 
            // PriceColumn_TDI
            // 
            PriceColumn_TDI.Location = new Point(360, 270);
            PriceColumn_TDI.Margin = new Padding(4);
            PriceColumn_TDI.Multiline = true;
            PriceColumn_TDI.Name = "PriceColumn_TDI";
            PriceColumn_TDI.Size = new Size(316, 32);
            PriceColumn_TDI.TabIndex = 3;
            // 
            // YearColumn_TDI
            // 
            YearColumn_TDI.Location = new Point(360, 216);
            YearColumn_TDI.Margin = new Padding(4);
            YearColumn_TDI.Multiline = true;
            YearColumn_TDI.Name = "YearColumn_TDI";
            YearColumn_TDI.Size = new Size(316, 32);
            YearColumn_TDI.TabIndex = 4;
            // 
            // nameColumn_TDI
            // 
            nameColumn_TDI.Location = new Point(360, 166);
            nameColumn_TDI.Margin = new Padding(4);
            nameColumn_TDI.Multiline = true;
            nameColumn_TDI.Name = "nameColumn_TDI";
            nameColumn_TDI.Size = new Size(316, 32);
            nameColumn_TDI.TabIndex = 5;
            // 
            // buttonAddBook_TDI
            // 
            buttonAddBook_TDI.Image = (Image)resources.GetObject("buttonAddBook_TDI.Image");
            buttonAddBook_TDI.Location = new Point(613, 454);
            buttonAddBook_TDI.Margin = new Padding(4);
            buttonAddBook_TDI.Name = "buttonAddBook_TDI";
            buttonAddBook_TDI.Size = new Size(63, 52);
            buttonAddBook_TDI.TabIndex = 6;
            addTip_TDI.SetToolTip(buttonAddBook_TDI, "Добавить книгу в таблицу");
            buttonAddBook_TDI.UseVisualStyleBackColor = true;
            buttonAddBook_TDI.Enter += buttonAddBook_TDI_Click;
            // 
            // buttonRefresh_TDI
            // 
            buttonRefresh_TDI.Image = (Image)resources.GetObject("buttonRefresh_TDI.Image");
            buttonRefresh_TDI.Location = new Point(360, 454);
            buttonRefresh_TDI.Margin = new Padding(4);
            buttonRefresh_TDI.Name = "buttonRefresh_TDI";
            buttonRefresh_TDI.Size = new Size(63, 52);
            buttonRefresh_TDI.TabIndex = 7;
            refreshTip_TDI.SetToolTip(buttonRefresh_TDI, "Сбросить строки");
            buttonRefresh_TDI.UseVisualStyleBackColor = true;
            buttonRefresh_TDI.Enter += buttonRefresh_TDI_Click;
            // 
            // authorAdd_TDI
            // 
            authorAdd_TDI.AutoSize = true;
            authorAdd_TDI.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            authorAdd_TDI.Location = new Point(247, 116);
            authorAdd_TDI.Margin = new Padding(4, 0, 4, 0);
            authorAdd_TDI.Name = "authorAdd_TDI";
            authorAdd_TDI.Size = new Size(74, 25);
            authorAdd_TDI.TabIndex = 8;
            authorAdd_TDI.Text = "Автор:";
            // 
            // newORoldAdd_TDI
            // 
            newORoldAdd_TDI.AutoSize = true;
            newORoldAdd_TDI.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            newORoldAdd_TDI.Location = new Point(224, 319);
            newORoldAdd_TDI.Margin = new Padding(4, 0, 4, 0);
            newORoldAdd_TDI.Name = "newORoldAdd_TDI";
            newORoldAdd_TDI.Size = new Size(97, 25);
            newORoldAdd_TDI.TabIndex = 9;
            newORoldAdd_TDI.Text = "Издание:";
            // 
            // yearAdd_TDI
            // 
            yearAdd_TDI.AutoSize = true;
            yearAdd_TDI.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            yearAdd_TDI.Location = new Point(186, 216);
            yearAdd_TDI.Margin = new Padding(4, 0, 4, 0);
            yearAdd_TDI.Name = "yearAdd_TDI";
            yearAdd_TDI.Size = new Size(135, 25);
            yearAdd_TDI.TabIndex = 10;
            yearAdd_TDI.Text = "Год Издания:";
            // 
            // nameAdd_TDI
            // 
            nameAdd_TDI.AutoSize = true;
            nameAdd_TDI.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            nameAdd_TDI.Location = new Point(224, 166);
            nameAdd_TDI.Margin = new Padding(4, 0, 4, 0);
            nameAdd_TDI.Name = "nameAdd_TDI";
            nameAdd_TDI.Size = new Size(106, 25);
            nameAdd_TDI.TabIndex = 11;
            nameAdd_TDI.Text = "Название:";
            // 
            // priceAdd_TDI
            // 
            priceAdd_TDI.AutoSize = true;
            priceAdd_TDI.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            priceAdd_TDI.Location = new Point(256, 270);
            priceAdd_TDI.Margin = new Padding(4, 0, 4, 0);
            priceAdd_TDI.Name = "priceAdd_TDI";
            priceAdd_TDI.Size = new Size(65, 25);
            priceAdd_TDI.TabIndex = 12;
            priceAdd_TDI.Text = "Цена:";
            // 
            // annotationAdd_TDI
            // 
            annotationAdd_TDI.AutoSize = true;
            annotationAdd_TDI.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            annotationAdd_TDI.Location = new Point(201, 369);
            annotationAdd_TDI.Margin = new Padding(4, 0, 4, 0);
            annotationAdd_TDI.Name = "annotationAdd_TDI";
            annotationAdd_TDI.Size = new Size(120, 25);
            annotationAdd_TDI.TabIndex = 13;
            annotationAdd_TDI.Text = "Аннотация:";
            // 
            // labelAddBook_TDI
            // 
            labelAddBook_TDI.AutoSize = true;
            labelAddBook_TDI.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelAddBook_TDI.Location = new Point(71, 9);
            labelAddBook_TDI.Name = "labelAddBook_TDI";
            labelAddBook_TDI.Size = new Size(640, 30);
            labelAddBook_TDI.TabIndex = 14;
            labelAddBook_TDI.Text = "Укажите необходимую информацию для добавления книги";
            // 
            // NumberOfBook_TDI
            // 
            NumberOfBook_TDI.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            NumberOfBook_TDI.ForeColor = SystemColors.WindowText;
            NumberOfBook_TDI.Location = new Point(360, 76);
            NumberOfBook_TDI.Margin = new Padding(4);
            NumberOfBook_TDI.Multiline = true;
            NumberOfBook_TDI.Name = "NumberOfBook_TDI";
            NumberOfBook_TDI.Size = new Size(316, 32);
            NumberOfBook_TDI.TabIndex = 16;
            // 
            // labelNumberOfBook_TDI
            // 
            labelNumberOfBook_TDI.AutoSize = true;
            labelNumberOfBook_TDI.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelNumberOfBook_TDI.Location = new Point(66, 76);
            labelNumberOfBook_TDI.Margin = new Padding(4, 0, 4, 0);
            labelNumberOfBook_TDI.Name = "labelNumberOfBook_TDI";
            labelNumberOfBook_TDI.Size = new Size(255, 25);
            labelNumberOfBook_TDI.TabIndex = 17;
            labelNumberOfBook_TDI.Text = "Номер книги по порядку:";
            // 
            // AddBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(783, 553);
            Controls.Add(labelNumberOfBook_TDI);
            Controls.Add(NumberOfBook_TDI);
            Controls.Add(labelAddBook_TDI);
            Controls.Add(annotationAdd_TDI);
            Controls.Add(priceAdd_TDI);
            Controls.Add(nameAdd_TDI);
            Controls.Add(yearAdd_TDI);
            Controls.Add(newORoldAdd_TDI);
            Controls.Add(authorAdd_TDI);
            Controls.Add(buttonRefresh_TDI);
            Controls.Add(buttonAddBook_TDI);
            Controls.Add(nameColumn_TDI);
            Controls.Add(YearColumn_TDI);
            Controls.Add(PriceColumn_TDI);
            Controls.Add(newORoldColumn_TDI);
            Controls.Add(annotationColumn_TDI);
            Controls.Add(authorColumn_TDI);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "AddBook";
            Text = "Добавить Книгу";
            Load += AddBook_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox authorColumn_TDI;
        private TextBox annotationColumn_TDI;
        private TextBox newORoldColumn_TDI;
        private TextBox PriceColumn_TDI;
        private TextBox YearColumn_TDI;
        private TextBox nameColumn_TDI;
        private Button buttonAddBook_TDI;
        private Button buttonRefresh_TDI;
        private Label authorAdd_TDI;
        private Label newORoldAdd_TDI;
        private Label yearAdd_TDI;
        private Label nameAdd_TDI;
        private Label priceAdd_TDI;
        private Label annotationAdd_TDI;
        private Label labelAddBook_TDI;
        private ToolTip addTip_TDI;
        private ToolTip refreshTip_TDI;
        private TextBox NumberOfBook_TDI;
        private Label labelNumberOfBook_TDI;
    }
}