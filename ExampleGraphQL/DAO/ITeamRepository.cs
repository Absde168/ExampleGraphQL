using ExampleGraphQL.Models;
using Microsoft.EntityFrameworkCore;
namespace ExampleGraphQL.DAO
{ 
     public interface ITeamRepository
{
    Task<Team> GetTeamByIdAsync(int id);
    Task<IEnumerable<Team>> GetAllTeamsAsync();
    Task<Team> AddTeamAsync(Team team);
    Task<Team> UpdateTeamAsync(Team team);
    Task<bool> DeleteTeamAsync(int id);
}
}