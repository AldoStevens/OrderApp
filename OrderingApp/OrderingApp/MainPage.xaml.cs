using Banking;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace OrderingApp
{
    public partial class MainPage : ContentPage
    {
        private BankAccount _account;
        public MainPage()
        {
            InitializeComponent();

            Bank fnb = new Bank("First National Bank", 4324, "Kenilworth");
            Customer myNewCustomer = new Customer("7766445424", "10 me at home", "Bob", "The Builder");
            fnb.AddCustomer(myNewCustomer);

            _account = myNewCustomer.ApplyForBankAccount();
        }

        private void OrderButton_Clicked(object sender, EventArgs e)
        {
            _account.DepositMoney(1500, DateTime.Now, "Stipend");
        }
    }
}
