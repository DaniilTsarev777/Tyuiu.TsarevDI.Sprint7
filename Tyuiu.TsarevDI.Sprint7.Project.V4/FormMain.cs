using System;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.TsarevDI.Sprint7.Project.V4.Lib;
namespace Tyuiu.TsarevDI.Sprint7.Project.V4
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        public FormMain()
        {
            InitializeComponent();
            openFileDialog_TDI.Filter = "Значения, разделенные запятыми (*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialog_TDI.Filter = "Значения, разделенные запятыми (*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        static string openFilePath;

        DataTable dataTable = new DataTable();
        private void GetTable(string openFilePath)
        {


            using (StreamReader sr = new StreamReader(openFilePath))
            {

                string[] headers = sr.ReadLine().Split(';');
                foreach (string header in headers)
                {
                    dataTable.Columns.Add(header);
                }

                while (!sr.EndOfStream)
                {
                    string[] rows = sr.ReadLine().Split(';');
                    dataTable.Rows.Add(rows);
                }
            }
            dataGridView_TDI.DataSource = dataTable;
            dataGridView_TDI.Columns[0].Width = 30;
            dataGridView_TDI.Columns[1].Width = 100;
            dataGridView_TDI.Columns[2].Width = 150;
            dataGridView_TDI.Columns[3].Width = 60;
            dataGridView_TDI.Columns[4].Width = 70;
            dataGridView_TDI.Columns[5].Width = 100;
            dataGridView_TDI.Columns[6].Width = 349;
        }


        private void buttonLoadFromDataFile_TDI_Click(object sender, EventArgs e)
        {
            openFileDialog_TDI.ShowDialog();
            openFilePath = openFileDialog_TDI.FileName;
            GetTable(openFilePath);
        }

        
        private void buttonSaveBooksToCsv_TDI_Click(object sender, EventArgs e)
        {
            saveFileDialog_TDI.FileName = "DataBase.csv";
            saveFileDialog_TDI.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_TDI.ShowDialog();

            string path = saveFileDialog_TDI.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }
            int rows = dataGridView_TDI.RowCount;
            int columns = dataGridView_TDI.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridView_TDI.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridView_TDI.Rows[i].Cells[j].Value;
                    }
                }

                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }


        private void buttonRefresh_TDI_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)dataGridView_TDI.DataSource;
            if (dt != null)
                dt.Clear();
        }



        private void buttonAboutProgram_TDI_Click(Object sender, EventArgs e)
        {
            var formAboutProgarm = new FormAboutProgram();
            formAboutProgarm.Show();
        }
        private void buttonGuide_TDI_Click(Object sender, EventArgs e)
        {
            var formGuide = new FormGuide();
            formGuide.Show();
        }
        private void buttonAddBooks_TDI_Click(Object sender, EventArgs e)
        {
            var AddBook = new AddBook(this);
            AddBook.Show();
        }


        private void buttonAboutProgram_TDI_Click_1(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridViewTEST_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void saveFileDialog_TDI_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void buttonLoadFromDataFile_TDI_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonSaveTip_TDI_Popup(object sender, PopupEventArgs e)
        {

        }


        public void DeleteRow()
        {
            foreach (DataGridViewRow item in this.dataGridView_TDI.SelectedRows)
            {
                dataGridView_TDI.Rows.RemoveAt(item.Index);
            }
        }
        private void buttonDelete_TDI_Click(object sender, EventArgs e)
        {
            DeleteRow();
        }


        private void buttonSearch_TDI_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)dataGridView_TDI.DataSource;
            bool anyMatchFound = false;
            if (dt != null)
            {

                foreach (DataGridViewRow row in dataGridView_TDI.Rows)
                {
                    bool isMatch = row.Cells.Cast<DataGridViewCell>()
                        .Any(cell => cell.Value != null && cell.Value.ToString().ToLower().Contains((search_TDI.Text).ToLower()));

                    if (isMatch)
                    {
                        row.Selected = true;
                        anyMatchFound = true;
                    }
                }
                if (!anyMatchFound)
                {
                    MessageBox.Show("Кажется этого здесь нет", "Упс...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }



        private void GetChart()
        {

            books_price_chart_TDI.Dock = DockStyle.Bottom;
            books_price_chart_TDI.Height = 1000;

            
            ChartArea chartArea = new ChartArea();
            books_price_chart_TDI.ChartAreas.Add(chartArea);

            
            if (books_price_chart_TDI.Series.FindByName("Книга и её стоймость") == null)
            {
                Series series = new Series
                {
                    Name = "Книга и её стоймость",
                    Color = System.Drawing.Color.Gray,
                    ChartType = SeriesChartType.Line 
                };
                books_price_chart_TDI.Series.Add(series);
            }
            
            books_price_chart_TDI.ChartAreas[0].AxisX.Title = "книга"; 
            books_price_chart_TDI.ChartAreas[4].AxisY.Title = "цена";

            

            books_price_chart_TDI.ChartAreas[4].AxisY.Minimum = 0; 
            books_price_chart_TDI.ChartAreas[4].AxisY.Maximum = 1000; 

            
            
            books_price_chart_TDI.ChartAreas[4].AxisY.Interval = 100; 
        }
        private void button_result_chart_TDI_Click(object sender, EventArgs e)
        {
            if (dataGridView_TDI.DataSource is DataTable dataTable)
            {
                
                books_price_chart_TDI.Series["Книга и её стоймость"].Points.Clear();

                


                foreach (DataGridViewRow row in dataGridView_TDI.Rows)
                {
                    if (row.IsNewRow) continue;
                    double xValue = Convert.ToDouble(row.Cells[0].Value);
                    double yValue = Convert.ToDouble(row.Cells[4].Value);
                    ///books_price_chart_TDI.Series["Книга и её стоймость"].Points.AddXY(row.Cells[2].Value, row.Cells[4].Value);
                    books_price_chart_TDI.Series["Книга и её стоймость"].Points.AddXY(xValue, yValue);
                }
            }
        }    

        

        private void searchTip_TDI_Popup(object sender, PopupEventArgs e)
        {

        }
    }

}


