using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tyuiu.TsarevDI.Sprint7.Project.V4
{
    public partial class AddBook : Form
    {
        public AddBook(FormMain fm)
        {
            InitializeComponent();
            this.fm = fm;


        }

        FormMain fm = new FormMain();



        private void buttonAddBook_TDI_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)fm.dataGridView_TDI.DataSource;

            if (dt != null)
            {
                DataRow row = dt.NewRow();
                row[0] = NumberOfBook_TDI.Text;
                row[1] = authorColumn_TDI.Text;
                row[2] = nameColumn_TDI.Text;
                row[3] = YearColumn_TDI.Text;
                row[4] = PriceColumn_TDI.Text;
                row[5] = newORoldColumn_TDI.Text;
                row[6] = annotationColumn_TDI.Text;

                dt.Rows.Add(row);
            }
        }






        private void buttonRefresh_TDI_Click(object sender, EventArgs e)
        {
            NumberOfBook_TDI.Clear();
            authorColumn_TDI.Clear();
            nameColumn_TDI.Clear();
            YearColumn_TDI.Clear();
            PriceColumn_TDI.Clear();
            annotationColumn_TDI.Clear();
            newORoldColumn_TDI.Clear();
        }

        private void AddBook_Load(object sender, EventArgs e)
        {

        }
    }
}
