using BusinessObjects;

namespace Repositories
{
    public interface IAccountRepository
    {
        AccountMember GetAccountById(String accountID);
    }
}