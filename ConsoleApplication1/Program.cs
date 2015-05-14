
using ConsoleApplication1.Authorize.NET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceSoapClient client = new ServiceSoapClient();
            var mat = new MerchantAuthenticationType();
            mat.transactionKey = "7GJ2MQ5z7b56Yh9S";
            mat.name = "3Hweb6q47dAG";
            var cpt = new CustomerProfileType();
            cpt.merchantCustomerId = "FSDFSDFSDF";
            var cppt = new CustomerPaymentProfileType();
            //cppt.customerType=CustomerTypeEnum.individual;
            var pt = new PaymentType();
            cppt.payment = pt;
            cppt.payment.Item = new CreditCardType() { cardCode = "1234", cardNumber = "4667961851875434", expirationDate = "2017-08" };

            //var response=client.CreateCustomerProfile(mat, cpt, ValidationModeEnum.none);
            //var response = client.CreateCustomerPaymentProfile(mat, 33413859, cppt, ValidationModeEnum.none);
            var ptt = new ProfileTransactionType();

            var response=client.CreateCustomerProfileTransaction(mat, new ProfileTransactionType() { Item = new ProfileTransAuthOnlyType() { amount = 12, customerPaymentProfileId = 30028842, customerProfileId = 33413859 } }, null);

        }
    }
}
