using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CalculateService
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
                //int countLine = int.Parse(streamReader.ReadLine());
                //for (int i = 0; i < countLine; i++)
                //{
                //    AccountModel accountModel = new AccountModel();
                //    string[] sep = null;
                //    while ((line = streamReader.ReadLine()) != null)
                //    {
                //        sep = line.Split(", ");
                //    }
                //    if(sep != null)
                //    {
                //        accountModel.account = sep[0];
                //        accountModel.password = sep[1];
                //        accounts.Add(accountModel);

                //    }
                //    else
                //    {
                //        break;
                //    }
                //}
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
