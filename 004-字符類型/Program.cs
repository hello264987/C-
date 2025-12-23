using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //設定路徑
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);  //設定成桌面
            string filePath = Path.Combine(desktopPath, "LogData.csv"); //把多段路徑組合成正確、可跨平台的完整路徑

            //1.初始化 CSV
            InitializeCsv(filePath);

            //2.測試寫入Log
            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine($"第二排,第二格");
                sw.WriteLine($"第三排,第二格");
            }
        }

        private static void InitializeCsv(string path)
        {
            //建立新的檔案，將指定字串寫入檔案
            File.WriteAllText(path, "第一排,第二格" + Environment.NewLine);  //Environment.NewLine換行，確保下一格換行
            Console.WriteLine("存了一個檔案");
        }
    }
}