using Exiled.API.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stamina
{
    public class Config : IConfig
    {
        [Description("Plugin etkinleştirilmeli mi?")]
        public bool IsEnabled { get; set; } = true;

        [Description("Debug gösterilsin mi?")]
        public bool Debug { get; set; } = false;
    }
}
