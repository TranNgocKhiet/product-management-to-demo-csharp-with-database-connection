using BusinessObjects;
using DataAccessLayer;

namespace Repositories
{
    public class AccountRepository : IAccountRepository
    {
        public AccountMember GetAccountById(String accountID)
            => AccountDAO.GetAccountById(accountID);
    }
}