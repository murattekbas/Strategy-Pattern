using Strategy_Pattern_First_Look.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern_First_Look.Business.Strategies.Invoice
{
    public class PrintOnDemandInvoiceStrategy : InvoiceStrategy
    {

        public override void Generate(Order order)
        {
            using (var client = new HttpClient())
            {
                var content = JsonConvert.SerializeObject(order);

                client.BaseAddress = new Uri("https://pluralsight.com");

                client.PostAsync("/print-on-demand", new StringContent(content));
            }
        }
    }
}
