using BusinessObjects;

namespace Services
{
    public interface IAccountService
    {
        AccountMember GetAccountById(String accountID);
    }
}
