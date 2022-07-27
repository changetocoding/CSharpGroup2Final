using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimcardApp
{
    public class SimcardAccount
    {
        private double simbalance;

        public SimcardAccount()
        {

        }

        public SimcardAccount(double balance)
        {
            this.simbalance = balance;
        }

        public double Balance
        {
            get { return simbalance; }
        }

        public void RechargeSim(double recamount)
        {
            if (recamount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(recamount));

            }
            simbalance += recamount;
        }

        public void BuyData(double data_amount)
        {
            //if (data_amount < simbalance)
            //{
            //    throw new ArgumentOutOfRangeException(nameof(data_amount));
            //}
            if (data_amount > simbalance)
            {
                throw new ArgumentOutOfRangeException(nameof(data_amount));
            }
            simbalance -= data_amount;
        }

        public void BorrowAirtime(double amount)
        {
            if (simbalance > 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }

            simbalance += amount;
        }

        public void TransferAirtime(SimcardAccount othersim, double amount)
        {
            if (othersim is null)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }
            simbalance -= amount;
            othersim.RechargeSim(amount);
        }

        public bool LowAccountBalance()
        {
            if (Balance < 20)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
