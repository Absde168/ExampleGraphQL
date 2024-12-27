using ExampleGraphQL.Models;
using Microsoft.EntityFrameworkCore;
namespace ExampleGraphQL.DAO
{
    public class WorkRepository : IWorkRepository
    {
        private readonly BlogDbContext _context;

        public WorkRepository(BlogDbContext context)
        {
            _context = context;
        }

        public async Task<Work> GetWorkByIdAsync(int id)
        {
            return await _context.Works.FindAsync(id);
        }

        public async Task<IEnumerable<Work>> GetWorksByOrderIdAsync(int orderId)
        {
            return await _context.Works.Where(w => w.OrderId == orderId).ToListAsync();
        }

        public async Task<IEnumerable<Work>> GetWorksByTeamIdAsync(int teamId)
        {
            return await _context.Works.Where(w => w.TeamId == teamId).ToListAsync();
        }

        public async Task<Work> AddWorkAsync(Work work)
        {
            _context.Works.Add(work);
            await _context.SaveChangesAsync();
            return work;
        }

        public async Task<Work> UpdateWorkAsync(Work work)
        {
            _context.Works.Update(work);
            await _context.SaveChangesAsync();
            return work;
        }

        public async Task<bool> DeleteWorkAsync(int id)
        {
            var work = await GetWorkByIdAsync(id);
            if (work != null)
            {
                _context.Works.Remove(work);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}