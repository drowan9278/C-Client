using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Account
    {
        private double checking = 0;
        private double savings = 0;
        private string firstname;
        private string lastname;
        private int acctNum;
        /// <summary>
        /// getter and setter for checking
        /// </summary>
        public double Checking
        { get
            {
                return checking;
            }
          set
            {
                checking = value;
            }
        }
        /// <summary>
        /// getter and setter for savings
        /// </summary>
        public double Savings
        {
            get
            {
                return savings;
            }
            set
            {
                savings = value;
            }
        }
        ///<summary>
        ///Retrieve and set the account number
        ///</summary>
        public int AcctNum
        {
            get
            {
                return acctNum;
            }

            set
            {
                acctNum = value;
            }
        }

        /// <summary>
        /// Modifies Checking account balance,
        /// </summary>
        /// <param name="amount"></param>
        public void modifyBalanceChecking9(double amount)
        {
            checking += amount;
        }
        /// <summary>
        /// Modify the balance with a set amount
        /// </summary>
        /// <param name="amount"></param>
        public void modifyBalanceSavings(double amount)
        {
            savings += amount;
        }

        private List<String> transactionHistory = new List<String>();

        public void addToHistory(String entryToAdd)
        {
            transactionHistory.Add(entryToAdd);
        }
        public List<String> copyHistory()
        {
            List<String> copyHist = transactionHistory;

            return copyHist;
        }

        
    }
}
