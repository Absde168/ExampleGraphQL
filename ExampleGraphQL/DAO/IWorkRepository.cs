using ExampleGraphQL.Models;
using Microsoft.EntityFrameworkCore;
namespace ExampleGraphQL.DAO
{
    public interface IWorkRepository
    {
        Task<Work> GetWorkByIdAsync(int id);
        Task<IEnumerable<Work>> GetWorksByOrderIdAsync(int orderId);
        Task<IEnumerable<Work>> GetWorksByTeamIdAsync(int teamId);
        Task<Work> AddWorkAsync(Work work);
        Task<Work> UpdateWorkAsync(Work work);
        Task<bool> DeleteWorkAsync(int id);
    }
}
