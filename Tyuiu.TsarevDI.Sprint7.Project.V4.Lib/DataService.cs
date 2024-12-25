using System.Net.Mail;
using System.Text;
using static System.Reflection.Metadata.BlobBuilder;
namespace Tyuiu.TsarevDI.Sprint7.Project.V4.Lib
{
    public class DataService
    {
        public string[,] GetMatrix(string path)
        {
            string[] lines = File.ReadAllLines(path);

            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;

            string[,] matrix = new string[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] values = lines[i].Split(";");
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = values[j];
                }
            }

            return matrix;
        }

    }
}

