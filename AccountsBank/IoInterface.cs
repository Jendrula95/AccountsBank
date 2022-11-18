using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsBank
{
    internal interface IoInterface
    {
        List<string> GetAccountList();
        bool InsertAccountToList(Account elem);
        BankUser GetBankUser(String ID);
    }
}
