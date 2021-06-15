using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace EstadioAAAWeb
{
    public class Program
    {

        public static RNGCryptoServiceProvider rngCrypto = new RNGCryptoServiceProvider();

        public static string UUIDGenerator(int length)
        //generar UIDs criptograficamente seguras
        {
            using (rngCrypto)
            {
                var bit_cnt = length * 6;
                var byte_cnt = ((bit_cnt + 7) / 8); //Aproximacion
                var bytes = new byte[byte_cnt];
                rngCrypto.GetBytes(bytes);
                return Convert.ToBase64String(bytes);
            }
        }
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
