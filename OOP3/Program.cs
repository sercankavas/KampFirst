using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
           /* NecessityCredit necessity = new NecessityCredit();
            necessity.Count();

            VehicleCredit vehicle = new VehicleCredit();
            vehicle.Count();

            MorgageCredit morgage = new MorgageCredit();
            morgage.Count();

            //---------------OR-------------

            ICreditBaseManager necessity = new NecessityCredit();
            necessity.Count();

            ICreditBaseManager vehicle = new VehicleCredit();
            vehicle.Count();

            ICreditBaseManager morgage = new MorgageCredit();
            morgage.Count();*/

            //interfaceler de extend edildigi clasin referansini tutabilirler. ayni sonucu verir

            NecessityCredit necessity = new NecessityCredit();           
            VehicleCredit vehicle = new VehicleCredit();          
            MorgageCredit morgage = new MorgageCredit();

            ILoggerService databaseloggerservice = new DataBaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            ApplicationManager application = new ApplicationManager();
            application.Apply(necessity,databaseloggerservice);//-->bunun ciktisi : Necessity credit is accounted ve Logged on the database
                                                               //surdurulebilirligi saglar bu yontem
            ICreditBaseManager merchantCredit = new MerchantCredit();
            ILoggerService smsLogger = new SmsLoggerService();

            application.Apply(merchantCredit, smsLogger);
            //List ile hem sms hem database e loglayabilirsin. video 2.44 den itibaren gorebilirsin ya da githubdan bulabilisin


            // bu kisim mulakatta cikacaktir ve seni ise sokacak hamle budur soyutlamada


            List<ICreditBaseManager> credits = new List<ICreditBaseManager>() {necessity,morgage };
            //application.KrediOnBilgilendirmesiYap(credits);

            
        }
    }
}
