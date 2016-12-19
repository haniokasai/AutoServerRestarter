using MiNET.Plugins;
using MiNET;
using MiNET.Net;
using MiNET.Plugins.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using System.Timers;

namespace AutoServerRestarter
{

    [Plugin(PluginName = "AutoServerRestart", Description = "AutoServerRestart", PluginVersion = "1.0", Author = "haniokasai")]
    public class AutoServerRestart :Plugin
    {
        protected static ILog _log = LogManager.GetLogger("AutoServerRestart");

        private Timer t;
        //private MiNetServer _server;
        protected override void OnEnable()
        {
            _log.Warn("Loaded");
            Task task = Task.Factory.StartNew(() =>
            {
                _server.StopServer();
            });
               /* Timer timer = new Timer();
            timer.Elapsed += new ElapsedEventHandler(MyClock);
            timer.Interval = 2000; // コンストラクタでも指定可
            timer.AutoReset = true; // デフォルト
            timer.Enabled = true; // timer.Start()と同じ*/

        }

        public void MyClock(object sender, ElapsedEventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
