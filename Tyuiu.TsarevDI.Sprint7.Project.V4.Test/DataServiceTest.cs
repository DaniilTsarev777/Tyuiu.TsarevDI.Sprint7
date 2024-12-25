using Tyuiu.TsarevDI.Sprint7.Project.V4.Lib;
namespace Tyuiu.TsarevDI.Sprint7.Project.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            DataService ds = new DataService();
            string path = @"D:\repos\Tyuiu.TsarevDI.Sprint7\Data\DataBase.csv";
            FileInfo fileInfo = new FileInfo(path);
            
            bool fileExist = fileInfo.Exists;
            
            Assert.AreEqual(true, fileExist);

        }
    }
}