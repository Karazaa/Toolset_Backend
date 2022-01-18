using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Toolset_Backend
{
    public class Program
    {
        private static IHost m_host;

        public static async Task Main(string[] args)
        {
            await Startup(args);
        }

        public static async Task Startup(string[] args)
        {
            if (m_host == null)
            {
                m_host = CreateHostBuilder(args).Build();
                await m_host.StartAsync();
            }
        }

        public static async Task Shutdown()
        {
            if (m_host != null)
            {
                await m_host.StopAsync();
                m_host.Dispose();
                m_host = null;
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
