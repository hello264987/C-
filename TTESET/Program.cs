using System;
using static System.Net.Mime.MediaTypeNames;

namespace MyApp
{
    internal class Program
    {
        TrafficClass TrafficClass1 = new TrafficClass();
        TrafficClass TrafficClass2 = new TrafficClass();

        


        public object Traffic1;
        public object Traffic2;
        static void Main(string[] args)
        {
            TrafficClass1(Traffic1);
            TrafficClass2(Traffic2);
        }
    }

    class TrafficClass()
    {
        public bool isRunning;
        public bool isStop;

        public int remainingSeconds;
        public int redSeconds, greenSeconds, yellowSeconds;

        public object trafficLight;

        public string currentLight_1;

        public Text lb_Time;


        /// <summary>
        /// 主程式在跑的，兩個變量看你是放入哪一個紅綠燈
        /// </summary>
        /// <param name="_currentLight">看放入的紅綠燈，當前是甚麼顏色</param>
        /// <param name="trafficLight_Number">看是哪一個紅綠燈</param>
        /// <returns></returns>
        private async Task RunTrafficLight(string _currentLight)
        {
            while (isRunning)
            {
                // 紅燈
                _currentLight = "RED";
                remainingSeconds = redSeconds;
                SetLights(_currentLight);
                await CountDown();

                // 綠燈
                _currentLight = "GREEN";
                remainingSeconds = greenSeconds;
                SetLights(_currentLight);
                await CountDown();

                //  黃燈（放在回紅燈前）
                _currentLight = "YELLOW";
                remainingSeconds = yellowSeconds;
                SetLights(_currentLight);
                await CountDown();
                // 不要再做任何事，直接回 while
            }
        }
        private void SetLights(string _currentLight)
        {
            if (_currentLight == "RED")
            {
                trafficLight.SetRed();
            }
            else if (_currentLight == "GREEN")
            {
                trafficLight.SetGreen();
            }
            else
            {
                trafficLight.SetYellow();
            }
        }


        private async Task CountDown()
        {
            while (remainingSeconds > 0)
            {
                if (isStop)
                {
                    await Task.Delay(200);
                    continue;
                }

                lb_Time.Text = remainingSeconds.ToString();


                await Task.Delay(1000);
                remainingSeconds--;
            }
        }

    }

}