using ExampleGraphQL.DAO;
using ExampleGraphQL.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace ExampleGraphQL.Data
{
    public class Mutation
    {
        public async Task<Client> CreateClient(
            [Service] IClientRepository repository,
            string contactInformation, string name, string phone)
        {
            var newClient = new Client
            {
                Name = name,
                Address = contactInformation,
                PhoneNumber = phone,
            };

            return await repository.AddClientAsync(newClient);
        }

        public async Task<Client> UpdateClient(
            [Service] IClientRepository repository, Client client)
        {
            return await repository.UpdateClientAsync(client);
        }


        public async Task<bool> DeleteClient(
            [Service] IClientRepository clientRepository,
            int clientId)
        {
            return await clientRepository.DeleteClientAsync(clientId);
        }

        public async Task<Order> CreateOrder(
               [Service] IOrderRepository repository,
               int clientId,
               DateTime startDate,
               DateTime endDate,
               double totalCost,
               bool isPaid)
        {
            var newOrder = new Order
            {
                ClientId = clientId,
                StartDate = startDate,
                EndDate = endDate,
            };

            return await repository.AddOrderAsync(newOrder);
        }

        public async Task<Order> UpdateOrder(
            [Service] IOrderRepository repository,
            Order order)
        {
            return await repository.UpdateOrderAsync(order);
        }
        public async Task<bool> DeleteOrder(
            [Service] IOrderRepository orderRepository,
            int orderId)
        {
            return await orderRepository.DeleteOrderAsync(orderId);
        }
        public async Task<Work> CreateWork(
          [Service] IWorkRepository repository,
        int orderId,
        string description,
        decimal cost,
        DateTime date,
        int teamId)
        {
            var newWork = new Work
            {
                OrderId = orderId,
                Description = description,
                Cost = cost,
                Date = date,
                TeamId = teamId
            };

            return await repository.AddWorkAsync(newWork);
        }
        public async Task<Work> UpdateWork(
            [Service] IWorkRepository repository,
            Work work)
        {
            return await repository.UpdateWorkAsync(work);
        }
        public async Task<bool> DeleteWork(
            [Service] IWorkRepository repository,
            int workId)
        {
            return await repository.DeleteWorkAsync(workId);
        }
        public async Task<Team> CreateTeam(
               [Service] ITeamRepository repository,
               string name)
        {
            var newTeam = new Team
            {
                Name = name
            };

            return await repository.AddTeamAsync(newTeam);
        }
        public async Task<Team> UpdateTeam(
            [Service] ITeamRepository repository,
            Team team)
        {
            return await repository.UpdateTeamAsync(team);
        }
        public async Task<bool> DeleteTeam(
            [Service] ITeamRepository teamRepository,
            int teamId)
        {
            return await teamRepository.DeleteTeamAsync(teamId);
        }
        public async Task<Member> AddTeamMember(
       [Service] IMemberRepository repository,
       int teamId,
       string name,
       string role)
        {
            var newMember = new Member
            {
                TeamId = teamId,
                Name = name,
                Role = role,
            };

            return await repository.AddMemberAsync(newMember);
        }
        public async Task<Member> UpdateTeamMember(
            [Service] IMemberRepository repository,
            Member teamMember)
        {
            return await repository.UpdateMemberAsync(teamMember);
        }
        public async Task<bool> DeleteTeamMember(
            [Service] IMemberRepository repository,
            int teamMemberId)
        {
            return await repository.DeleteMemberAsync(teamMemberId);
        }
    }
}
