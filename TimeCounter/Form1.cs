using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeCounter
{
    public partial class Form1 : Form
    {
        string desktopPath=Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string filePath;

        //Time
        int time = 10;

        public Form1()
        {
            InitializeComponent();

            //位置, 名稱
            this.filePath = Path.Combine(desktopPath, "LogData.csv");
        }

        private async void Time_Click(object sender, EventArgs e)
        {
            this.time = 10;

            while (time > 0) 
            {
                Time.Text = time.ToString();
                await Task.Delay(TimeSpan.FromSeconds(1f));
                time--;
            }

            //最後歸0
            Time.Text = 0.ToString();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            //存儲一個東西
            InitializeCsv(this.filePath, this.time.ToString());
        }

        private void InitializeCsv(string filePath, string time)
        {
            File.WriteAllText(filePath, time);

            //存檔後打開位置檔案(確認真的有存到)
            if (File.Exists(filePath))
            {
                string folderPath = Path.GetDirectoryName(filePath);
                Process.Start("explorer.exe", folderPath);
            }
        }

        /// <summary>
        /// 讀取檔案
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Load_Btn_Click(object sender, EventArgs e)
        {
            string LoadText = File.ReadAllText(this.filePath);

            Load.Text = LoadText;
        }
    }
}
