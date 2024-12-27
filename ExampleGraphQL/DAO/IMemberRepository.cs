using ExampleGraphQL.Models;
using Microsoft.EntityFrameworkCore;
namespace ExampleGraphQL.DAO
{
    public interface IMemberRepository
    {
        Task<Member> GetMemberByIdAsync(int id);
        Task<IEnumerable<Member>> GetMembersByTeamIdAsync(int teamId);
        Task<Member> AddMemberAsync(Member member);
        Task<Member> UpdateMemberAsync(Member member);
        Task<bool> DeleteMemberAsync(int id);
        Task<IQueryable<Member>> GetAllMembersAsync();
    }
}