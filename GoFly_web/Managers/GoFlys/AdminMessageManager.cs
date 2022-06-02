using System.Diagnostics;

namespace GoFly_web.Managers.GoFlys
{
    public class AdminMessageManager : IAdminMessageManager
    {
        public void SendMessage(string path, string message)
        {
            try
            {

                //if (!File.Exists(path))
                //{

                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine(message);

                    }

                    Process myProcess = new Process();
                    myProcess.StartInfo.UseShellExecute = false;
                    myProcess.StartInfo.FileName = @"C:\Users\taiwa\source\repos\GoFly_web\GoFly_web\bin\Debug\TelegramBotCode\Code.exe";
                    myProcess.StartInfo.CreateNoWindow = true;
                    myProcess.Start();

               // }
            }
            catch (Exception ex) { }

            
        }
    }
}
