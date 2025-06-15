using BusinessObjects;
using Castle.Core.Resource;
using System.Linq;

namespace DataAccessLayer
{
    public class AccountDAO
    {
        public static AccountMember GetAccountById(String accountID)
        {
            try
            {
                using var db = new MyStoreContext();
                AccountMember account = db.AccountMembers.FirstOrDefault(c => c.MemberId.Equals(accountID));
                if (account != null)
                    return account;
                return null;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
