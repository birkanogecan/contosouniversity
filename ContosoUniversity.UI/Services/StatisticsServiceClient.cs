using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Statistic;

namespace ContosoUniversity.UI.Services
{
    public class StatisticsServiceClient
    {
        public async Task<StatisticsReply> Get()
        {
            var channel = new Channel("localhost:" + "50051", ChannelCredentials.Insecure);
            var client = new Statistics.StatisticsClient(channel);
            var reply = await client.GetStatisticsAsync(new StatisticsRequest { Name = "StatisticsClient" });
            await channel.ShutdownAsync();
            return await Task.FromResult(reply);
        }

        //public async Task<List<EnrollmentDateGroupDto>> GetEnrollmentStats()
        //{
        //    var url = $"{_baseUrl}/enrollments";
        //    return await _client.GetJsonAsync<List<EnrollmentDateGroupDto>>(url);
        //}
    }
}
