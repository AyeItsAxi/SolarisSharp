using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarisSharp.Common
{
    internal class Enums
    {
        public enum BotConnection
        {
            Initializing,
            Online,
            Offline
        }
        public enum ApiConnection
        {
            Online,
            Rough,
            Offline
        }
        public BotConnection BotStatus;
        public ApiConnection ApiStatus;
    }
}
