using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace TobiiEyexArrangeTool
{
    class Program
    {
        static void Main(string[] args)
        {
            TobiiEyexArrangeController controller = new TobiiEyexArrangeController();
            controller.StartTobiiEyex();
            SerialPort serial = new SerialPort("COM4", 9600);   // COM3のポートを通信速度9600bpsで使う
            serial.Open();                                      // ポートを開く

            while (true)
            {
                // Console.WriteLine(controller.x + "," + controller.y);

                if (controller.x > 300 && controller.x < 700 && controller.y > 300 && controller.y < 800)
                {
                    serial.WriteLine("A");
                    Console.WriteLine("A");
                }
                else if (controller.x > 700 && controller.x < 900 && controller.y > 300 && controller.y < 800)
                {
                    serial.WriteLine("B");
                    Console.WriteLine("B");
                }
                else if (controller.x > 900 && controller.x < 1400 && controller.y > 300 && controller.y < 800)
                { 
                    serial.WriteLine("C");
                    Console.WriteLine("C");
                }
                else
                {
                    serial.WriteLine("D");
                    Console.WriteLine("D");
                }




                System.Threading.Thread.Sleep(100);
            }
        }
    }
}
