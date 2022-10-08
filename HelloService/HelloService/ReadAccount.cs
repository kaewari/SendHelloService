using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloService
{
    class ReadAccount
    {
        public AccountModel Read()
        {
            string Path = "D:\\Account.txt";
            List<AccountModel> accounts = new List<AccountModel>(10);
            AccountModel accountModel = new AccountModel();
            using (StreamReader streamReader = new StreamReader(new FileStream(Path, FileMode.Open, FileAccess.Read), Encoding.UTF8))
            {
                string line;
                string[] sep = null;
                while ((line = streamReader.ReadLine()) != null)
                {
                    sep = line.Split(',');
                }
                accountModel.account = sep[0];
                accountModel.password = sep[1];
            }
            return accountModel;
        }
    }
}
