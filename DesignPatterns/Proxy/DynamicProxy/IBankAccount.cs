using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Proxy.DynamicProxy
{
    public interface IBankAccount
    {
        void Deposit(int amount);
        bool Withdraw(int amount);
        string ToString();
    }
}
