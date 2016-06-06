using System;
using System.Collections.ObjectModel;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using WCFService;
using System.Text;

namespace WCFServiceHost
{
	static class Program
	{
		public static void Main(string[] args)
		{
            Uri[] uriArray = new Uri[] { 
                    new Uri(Properties.Settings.Default.HTTPS_URL) , 
                    new Uri(Properties.Settings.Default.HTTP_URL) 
                };

            try
			{
                ServiceHost serviceHost = new ServiceHost(typeof(ImportService), uriArray);

                var netHttps_bind = new NetHttpsBinding(BasicHttpsSecurityMode.Transport);
                netHttps_bind.Security.Transport.ClientCredentialType = HttpClientCredentialType.Windows;
                netHttps_bind.MessageEncoding = NetHttpMessageEncoding.Binary;
                netHttps_bind.MaxReceivedMessageSize = int.MaxValue;
                netHttps_bind.MaxBufferPoolSize = int.MaxValue;
                netHttps_bind.MaxBufferSize = int.MaxValue;

                var netHttp_bind = new NetHttpBinding(BasicHttpSecurityMode.None);
                //netHttp_bind.Security.Transport.ClientCredentialType = HttpClientCredentialType.Windows;
                netHttp_bind.MessageEncoding = NetHttpMessageEncoding.Binary;
                netHttp_bind.MaxReceivedMessageSize = int.MaxValue;
                netHttp_bind.MaxBufferPoolSize = int.MaxValue;
                netHttp_bind.MaxBufferSize = int.MaxValue;

                serviceHost.AddServiceEndpoint(typeof(IImport), netHttps_bind, "");
                serviceHost.AddServiceEndpoint(typeof(IImport), netHttp_bind, "");
                ServiceMetadataBehavior serviceMetadataBehavior = new ServiceMetadataBehavior()
                {
                    HttpGetEnabled = true,
                    HttpsGetEnabled = true
                };
                serviceHost.Description.Behaviors.Add(serviceMetadataBehavior);
                serviceHost.Open();
                                
                DateTime now = DateTime.Now;
				Console.WriteLine(string.Concat("Service is host at ", now.ToString()));
				Console.WriteLine("Host is running... Press <ESC> key to stop");
            Read:
                var key = Console.ReadKey();
                if (key.Key != ConsoleKey.Escape) goto Read;
                serviceHost.Close();

            }
			catch (Exception exception)
			{
				Console.WriteLine(exception.Message);
				Console.ReadLine();
			}
		}
	}
}