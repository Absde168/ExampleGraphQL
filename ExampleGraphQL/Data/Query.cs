using ExampleGraphQL.DAO;
using ExampleGraphQL.Models;
using Microsoft.EntityFrameworkCore;
namespace ExampleGraphQL.GraphQL
{
    public class Query
    {
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        [GraphQLDescription("Method used to get list of all Clients")]
        public async Task<IQueryable<Client>> GetClients([Service] IClientRepository clientRepository)
        {
            var clients = await clientRepository.GetAllClientsAsync();
            return clients.AsQueryable();
        }

        [UseProjection]
        public async Task<Client> GetClientById([Service] IClientRepository clientRepository, int id)
        {
            var client = await clientRepository.GetClientByIdAsync(id);
            return client;
        }
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        [GraphQLDescription("Method used to get list of all Orders")]
        public async Task<IQueryable<Order>> GetOrders([Service] IOrderRepository orderRepository)
        {
            var orders = await orderRepository.GetAllOrdersAsync();
            return orders.AsQueryable();
        }


        [UseProjection]
        [GraphQLDescription("Method used to get Order by Id")]
        public async Task<Order> GetOrderById([Service] IOrderRepository orderRepository, int id)
        {
            var order = await orderRepository.GetOrderByIdAsync(id);
            return order;
        }


        [UseProjection]
        [UseFiltering]
        [UseSorting]
        [GraphQLDescription("Method used to get Orders ending next month")]
        public async Task<IQueryable<Order>> GetOrdersEndingNextMonth([Service] IOrderRepository orderRepository)
        {
            var orders = await orderRepository.GetOrdersEndingNextMonthAsync();
            return orders.AsQueryable();
        }


        [UseProjection]
        [UseFiltering]
        [UseSorting]
        [GraphQLDescription("Method used to get list of all Teams")]
        public async Task<IQueryable<Team>> GetTeams([Service] ITeamRepository teamRepository)
        {
            var teams = await teamRepository.GetAllTeamsAsync();
            return teams.AsQueryable();
        }

        [UseProjection]
        [GraphQLDescription("Method used to get Team by Id")]
        public async Task<Team> GetTeamById([Service] ITeamRepository teamRepository, int id)
        {
            var team = await teamRepository.GetTeamByIdAsync(id);
            return team;
        }

 
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        [GraphQLDescription("Method used to get list of all Team Members")]
        public async Task<IQueryable<Member>> GetMembers([Service] IMemberRepository memberRepository)
        {
            var members = await memberRepository.GetAllMembersAsync();
            return members.AsQueryable();
        }

        [UseProjection]
        [GraphQLDescription("Method used to get Team Member by Id")]
        public async Task<Member> GetMemberById([Service] IMemberRepository memberRepository, int id)
        {
            var member = await memberRepository.GetMemberByIdAsync(id);
            return member;
        }

        [UseProjection]
        [GraphQLDescription("Method used to get list of Works by Order Id")]
        public async Task<IQueryable<Work>> GetWorksByOrderId([Service] IWorkRepository workRepository, int orderId)
        {
            var works = await workRepository.GetWorksByOrderIdAsync(orderId);
            return works.AsQueryable(); 
        }

        [UseProjection]
        [GraphQLDescription("Method used to get Work by Id")]
        public async Task<Work> GetWorkById([Service] IWorkRepository workRepository, int id)
        {
            var work = await workRepository.GetWorkByIdAsync(id);
            return work;
        }
    }
}