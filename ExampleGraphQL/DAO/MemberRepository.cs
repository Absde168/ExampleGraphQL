using ExampleGraphQL.Models;
using Microsoft.EntityFrameworkCore;
namespace ExampleGraphQL.DAO
{
    public class MemberRepository : IMemberRepository
    {
        private readonly BlogDbContext _context;

        public MemberRepository(BlogDbContext context)
        {
            _context = context;
        }

        public async Task<Member> GetMemberByIdAsync(int id)
        {
            return await _context.Members.FindAsync(id);
        }

        public async Task<IEnumerable<Member>> GetMembersByTeamIdAsync(int teamId)
        {
            return await _context.Members.Where(m => m.TeamId == teamId).ToListAsync();
        }

        public async Task<Member> AddMemberAsync(Member member)
        {
            _context.Members.Add(member);
            await _context.SaveChangesAsync();
            return member;
        }

        public async Task<Member> UpdateMemberAsync(Member member)
        {
            _context.Members.Update(member);
            await _context.SaveChangesAsync();
            return member;
        }

        public async Task<bool> DeleteMemberAsync(int id)
        {
            var member = await GetMemberByIdAsync(id);
            if (member != null)
            {
                _context.Members.Remove(member);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }
        public async Task<IQueryable<Member>> GetAllMembersAsync()
        {
            return _context.Members.AsQueryable();
        }

        
        }
    }
