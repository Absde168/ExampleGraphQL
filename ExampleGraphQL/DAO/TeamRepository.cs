using ExampleGraphQL.Models;
using Microsoft.EntityFrameworkCore;
namespace ExampleGraphQL.DAO
{
    public class TeamRepository : ITeamRepository
    {
        private readonly BlogDbContext _context;

        public TeamRepository(BlogDbContext context)
        {
            _context = context;
        }

        public async Task<Team> GetTeamByIdAsync(int id)
        {
            return await _context.Teams.FindAsync(id);
        }

        public async Task<IEnumerable<Team>> GetAllTeamsAsync()
        {
            return await _context.Teams.ToListAsync();
        }

        public async Task<Team> AddTeamAsync(Team team)
        {
            _context.Teams.Add(team);
            await _context.SaveChangesAsync();
            return team;
        }

        public async Task<Team> UpdateTeamAsync(Team team)
        {
            _context.Teams.Update(team);
            await _context.SaveChangesAsync();
            return team;
        }

        public async Task<bool> DeleteTeamAsync(int id)
        {
            var team = await GetTeamByIdAsync(id);
            if (team != null)
            {
                _context.Teams.Remove(team);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}
