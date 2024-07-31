using Command_Pattern.Command;
using Command_Pattern.Interfaces;

namespace Command_Pattern.Invoker
{
    public class Invoker
    {
        ITV tV = null;
        public ITV GetCommand(string action)
        {
            switch (action) 
            {
                case "Start":
                    tV = new StartCommand();
                    break;

                case "Stop":
                    tV = new StopCommand();
                    break;

                default:
                    break;
            }
            return tV;
        }
    }
}
