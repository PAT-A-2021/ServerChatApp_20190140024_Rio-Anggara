using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCFService_2Way_024;

namespace ServerChatApp_20190140024_Rio_Anggara
{
	class Program
	{
		static void Main(string[] args)
		{
            ServiceHost hostObj = null;
            try
            {
                hostObj = new ServiceHost(typeof(ServiceCallback));
                hostObj.Open();

                Console.WriteLine("Server ON, Ready to use");
                Console.ReadLine();

                hostObj.Close();
            }
            catch (Exception ex)
            {
                hostObj = null;
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
	}
}