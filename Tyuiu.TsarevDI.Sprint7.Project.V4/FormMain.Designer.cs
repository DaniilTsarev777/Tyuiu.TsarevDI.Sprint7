namespace Tyuiu.TsarevDI.Sprint7.Project.V4
{
    partial class FormMain
    {

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
        public void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            labelInfoBook_TDI = new Label();
            search_TDI = new TextBox();
            labelSearch_TDI = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            buttonSearch_TDI = new Button();
            buttonAboutProgram_TDI = new Button();
            buttonGuide_TDI = new Button();
            buttonLoadFromDataFile_TDI = new Button();
            buttonSaveBooksToCsv_TDI = new Button();
            dataGridView_TDI = new DataGridView();
            openFileDialog_TDI = new OpenFileDialog();
            saveFileDialog_TDI = new SaveFileDialog();
            buttonRefresh_TDI = new Button();
            buttonAddBooks_TDI = new Button();
            buttonSaveTip_TDI = new ToolTip(components);
            buttonLoadTip_TDI = new ToolTip(components);
            buttonRefreshTip_TDI = new ToolTip(components);
            buttonAddTip_TDI = new ToolTip(components);
            buttonGuideTip_TDI = new ToolTip(components);
            buttonInfoTip_TDI = new ToolTip(components);
            searchTip_TDI = new ToolTip(components);
            buttonDelete_TDI = new Button();
            books_price_chart_TDI = new System.Windows.Forms.DataVisualization.Charting.Chart();
            deleteTip_TDI = new ToolTip(components);
            button_result_chart_TDI = new Button();
            buttonChartTip_TDI = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView_TDI).BeginInit();
            ((System.ComponentModel.ISupportInitialize)books_price_chart_TDI).BeginInit();
            SuspendLayout();
            // 
            // labelInfoBook_TDI
            // 
            labelInfoBook_TDI.Anchor = AnchorStyles.Right;
            labelInfoBook_TDI.AutoSize = true;
            labelInfoBook_TDI.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelInfoBook_TDI.Location = new Point(374, 92);
            labelInfoBook_TDI.Name = "labelInfoBook_TDI";
            labelInfoBook_TDI.Size = new Size(274, 21);
            labelInfoBook_TDI.TabIndex = 1;
            labelInfoBook_TDI.Text = "Подробная информация о книге:\r\n";
            // 
            // search_TDI
            // 
            search_TDI.Location = new Point(63, 53);
            search_TDI.Multiline = true;
            search_TDI.Name = "search_TDI";
            search_TDI.Size = new Size(255, 36);
            search_TDI.TabIndex = 2;
            // 
            // labelSearch_TDI
            // 
            labelSearch_TDI.AutoSize = true;
            labelSearch_TDI.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelSearch_TDI.Location = new Point(63, 29);
            labelSearch_TDI.Name = "labelSearch_TDI";
            labelSearch_TDI.Size = new Size(260, 21);
            labelSearch_TDI.TabIndex = 3;
            labelSearch_TDI.Text = "Введите ниже ключевое слово:";
            // 
            // buttonSearch_TDI
            // 
            buttonSearch_TDI.Image = (Image)resources.GetObject("buttonSearch_TDI.Image");
            buttonSearch_TDI.Location = new Point(315, 53);
            buttonSearch_TDI.Name = "buttonSearch_TDI";
            buttonSearch_TDI.Size = new Size(44, 36);
            buttonSearch_TDI.TabIndex = 4;
            searchTip_TDI.SetToolTip(buttonSearch_TDI, "Поиск");
            buttonSearch_TDI.UseVisualStyleBackColor = true;
            buttonSearch_TDI.Enter += buttonSearch_TDI_Click;
            // 
            // buttonAboutProgram_TDI
            // 
            buttonAboutProgram_TDI.Image = (Image)resources.GetObject("buttonAboutProgram_TDI.Image");
            buttonAboutProgram_TDI.Location = new Point(1368, 579);
            buttonAboutProgram_TDI.Name = "buttonAboutProgram_TDI";
            buttonAboutProgram_TDI.Size = new Size(50, 48);
            buttonAboutProgram_TDI.TabIndex = 5;
            buttonInfoTip_TDI.SetToolTip(buttonAboutProgram_TDI, "Посмотреть информацию о программе");
            buttonAboutProgram_TDI.UseVisualStyleBackColor = true;
            buttonAboutProgram_TDI.Enter += buttonAboutProgram_TDI_Click;
            // 
            // buttonGuide_TDI
            // 
            buttonGuide_TDI.Image = (Image)resources.GetObject("buttonGuide_TDI.Image");
            buttonGuide_TDI.Location = new Point(1356, 12);
            buttonGuide_TDI.Name = "buttonGuide_TDI";
            buttonGuide_TDI.Size = new Size(62, 59);
            buttonGuide_TDI.TabIndex = 6;
            buttonGuideTip_TDI.SetToolTip(buttonGuide_TDI, "Посмотреть краткое руководство пользователя");
            buttonGuide_TDI.UseVisualStyleBackColor = true;
            buttonGuide_TDI.Enter += buttonGuide_TDI_Click;
            // 
            // buttonLoadFromDataFile_TDI
            // 
            buttonLoadFromDataFile_TDI.Image = (Image)resources.GetObject("buttonLoadFromDataFile_TDI.Image");
            buttonLoadFromDataFile_TDI.Location = new Point(167, 568);
            buttonLoadFromDataFile_TDI.Name = "buttonLoadFromDataFile_TDI";
            buttonLoadFromDataFile_TDI.Size = new Size(64, 59);
            buttonLoadFromDataFile_TDI.TabIndex = 7;
            buttonLoadTip_TDI.SetToolTip(buttonLoadFromDataFile_TDI, "Загрузить .csv файл");
            buttonLoadFromDataFile_TDI.UseVisualStyleBackColor = true;
            buttonLoadFromDataFile_TDI.Click += buttonLoadFromDataFile_TDI_Click_1;
            buttonLoadFromDataFile_TDI.Enter += buttonLoadFromDataFile_TDI_Click;
            // 
            // buttonSaveBooksToCsv_TDI
            // 
            buttonSaveBooksToCsv_TDI.ForeColor = SystemColors.ControlText;
            buttonSaveBooksToCsv_TDI.Image = (Image)resources.GetObject("buttonSaveBooksToCsv_TDI.Image");
            buttonSaveBooksToCsv_TDI.Location = new Point(63, 568);
            buttonSaveBooksToCsv_TDI.Name = "buttonSaveBooksToCsv_TDI";
            buttonSaveBooksToCsv_TDI.Size = new Size(65, 59);
            buttonSaveBooksToCsv_TDI.TabIndex = 8;
            buttonSaveTip_TDI.SetToolTip(buttonSaveBooksToCsv_TDI, "Сохранить измененную таблицу");
            buttonSaveBooksToCsv_TDI.UseVisualStyleBackColor = true;
            buttonSaveBooksToCsv_TDI.Enter += buttonSaveBooksToCsv_TDI_Click;
            // 
            // dataGridView_TDI
            // 
            dataGridView_TDI.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_TDI.Location = new Point(63, 116);
            dataGridView_TDI.Name = "dataGridView_TDI";
            dataGridView_TDI.ReadOnly = true;
            dataGridView_TDI.Size = new Size(903, 446);
            dataGridView_TDI.TabIndex = 9;
            dataGridView_TDI.CellContentClick += dataGridView1_CellContentClick;
            // 
            // saveFileDialog_TDI
            // 
            saveFileDialog_TDI.FileOk += saveFileDialog_TDI_FileOk;
            // 
            // buttonRefresh_TDI
            // 
            buttonRefresh_TDI.Image = (Image)resources.GetObject("buttonRefresh_TDI.Image");
            buttonRefresh_TDI.Location = new Point(269, 568);
            buttonRefresh_TDI.Name = "buttonRefresh_TDI";
            buttonRefresh_TDI.Size = new Size(64, 59);
            buttonRefresh_TDI.TabIndex = 10;
            buttonRefreshTip_TDI.SetToolTip(buttonRefresh_TDI, "Сбросить таблицу");
            buttonRefresh_TDI.UseVisualStyleBackColor = true;
            buttonRefresh_TDI.Enter += buttonRefresh_TDI_Click;
            // 
            // buttonAddBooks_TDI
            // 
            buttonAddBooks_TDI.Image = (Image)resources.GetObject("buttonAddBooks_TDI.Image");
            buttonAddBooks_TDI.Location = new Point(902, 568);
            buttonAddBooks_TDI.Name = "buttonAddBooks_TDI";
            buttonAddBooks_TDI.Size = new Size(64, 59);
            buttonAddBooks_TDI.TabIndex = 11;
            buttonAddTip_TDI.SetToolTip(buttonAddBooks_TDI, "Добавить книгу");
            buttonAddBooks_TDI.UseVisualStyleBackColor = true;
            buttonAddBooks_TDI.Enter += buttonAddBooks_TDI_Click;
            // 
            // buttonSaveTip_TDI
            // 
            buttonSaveTip_TDI.Popup += buttonSaveTip_TDI_Popup;
            // 
            // searchTip_TDI
            // 
            searchTip_TDI.Popup += searchTip_TDI_Popup;
            // 
            // buttonDelete_TDI
            // 
            buttonDelete_TDI.Image = (Image)resources.GetObject("buttonDelete_TDI.Image");
            buttonDelete_TDI.Location = new Point(802, 568);
            buttonDelete_TDI.Name = "buttonDelete_TDI";
            buttonDelete_TDI.Size = new Size(64, 59);
            buttonDelete_TDI.TabIndex = 12;
            deleteTip_TDI.SetToolTip(buttonDelete_TDI, "Удалить строку");
            buttonDelete_TDI.UseVisualStyleBackColor = true;
            buttonDelete_TDI.Click += buttonDelete_TDI_Click;
            buttonDelete_TDI.Enter += buttonDelete_TDI_Click;
            // 
            // books_price_chart_TDI
            // 
            chartArea3.Name = "ChartArea1";
            books_price_chart_TDI.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            books_price_chart_TDI.Legends.Add(legend3);
            books_price_chart_TDI.Location = new Point(985, 116);
            books_price_chart_TDI.Name = "books_price_chart_TDI";
            books_price_chart_TDI.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Книга и её стоймость";
            books_price_chart_TDI.Series.Add(series3);
            books_price_chart_TDI.Size = new Size(433, 446);
            books_price_chart_TDI.TabIndex = 13;
            books_price_chart_TDI.Text = "books/price";
            books_price_chart_TDI.Enter += button_result_chart_TDI_Click;
            // 
            // button_result_chart_TDI
            // 
            button_result_chart_TDI.Image = (Image)resources.GetObject("button_result_chart_TDI.Image");
            button_result_chart_TDI.Location = new Point(985, 568);
            button_result_chart_TDI.Name = "button_result_chart_TDI";
            button_result_chart_TDI.Size = new Size(63, 59);
            button_result_chart_TDI.TabIndex = 14;
            buttonChartTip_TDI.SetToolTip(button_result_chart_TDI, "Построить диаграмму по данным из таблицы");
            button_result_chart_TDI.UseVisualStyleBackColor = true;
            button_result_chart_TDI.Enter += button_result_chart_TDI_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1430, 647);
            Controls.Add(button_result_chart_TDI);
            Controls.Add(books_price_chart_TDI);
            Controls.Add(buttonDelete_TDI);
            Controls.Add(buttonAddBooks_TDI);
            Controls.Add(buttonRefresh_TDI);
            Controls.Add(dataGridView_TDI);
            Controls.Add(buttonSaveBooksToCsv_TDI);
            Controls.Add(buttonLoadFromDataFile_TDI);
            Controls.Add(buttonGuide_TDI);
            Controls.Add(buttonAboutProgram_TDI);
            Controls.Add(buttonSearch_TDI);
            Controls.Add(labelSearch_TDI);
            Controls.Add(search_TDI);
            Controls.Add(labelInfoBook_TDI);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormMain";
            Text = "Библиотека!++";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_TDI).EndInit();
            ((System.ComponentModel.ISupportInitialize)books_price_chart_TDI).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Label labelInfoBook_TDI;
        public TextBox search_TDI;
        public Label labelSearch_TDI;
        public System.ComponentModel.BackgroundWorker backgroundWorker1;
        public Button buttonSearch_TDI;
        public Button buttonAboutProgram_TDI;
        public Button buttonGuide_TDI;
        public Button buttonLoadFromDataFile_TDI;
        public Button buttonSaveBooksToCsv_TDI;
        public DataGridView dataGridView_TDI;
        public OpenFileDialog openFileDialog_TDI;
        public SaveFileDialog saveFileDialog_TDI;
        public Button buttonRefresh_TDI;
        public Button buttonAddBooks_TDI;
        private ToolTip buttonSaveTip_TDI;
        private ToolTip buttonLoadTip_TDI;
        private ToolTip buttonRefreshTip_TDI;
        private ToolTip buttonAddTip_TDI;
        private ToolTip buttonGuideTip_TDI;
        private ToolTip buttonInfoTip_TDI;
        private System.ComponentModel.IContainer components;
        private ToolTip searchTip_TDI;
        public Button buttonDelete_TDI;
        private System.Windows.Forms.DataVisualization.Charting.Chart books_price_chart_TDI;
        private ToolTip deleteTip_TDI;
        public Button button_result_chart_TDI;
        private ToolTip buttonChartTip_TDI;
    }
}
