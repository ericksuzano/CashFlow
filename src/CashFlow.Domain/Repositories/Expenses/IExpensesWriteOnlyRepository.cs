using CashFlow.Domain.Entities;

namespace CashFlow.Domain.Repositories.Expenses;
public interface IExpensesWriteOnlyRepository
{
    Task Add(Expense expense);
    /// <summary>
    /// Essa função retorna TRUE se o processo de remover uma despesa for um sucesso, se não, retorna FALSE
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<bool> Delete(long id);
}
