using IronPython.Hosting;
using Microsoft.Scripting.Hosting;

namespace GoFly_web.TelegramBot
{
    public class TelegramBot
    {
        public TelegramBot()
        {
            ScriptEngine engine = Python.CreateEngine();
            engine.Execute("import telegram-send");
            engine.Execute("telegram_send.send(messages = ['Hey there!'])");
        }
        
    }
}
