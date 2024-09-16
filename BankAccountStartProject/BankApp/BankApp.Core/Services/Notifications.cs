using BankApp.Core.DataAccess;
using BankApp.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Core.Services
{
    public class Notifications 
    {
        private string path = @"C:\Users\WINDOWS 10 PRO\source\repos\BankAccountStartProject\BankApp\Notifications.txt";

        public void WriteNotification(string message,string email,int id)
        {
            File.AppendAllText(path, $"{id}, {email}, {message}" + Environment.NewLine);
        }
        public void GetAll(Notification notification)
        {
            var notify = new Notification();

            var allnot = File.ReadAllLines(path).ToList();


        }



    }
}
