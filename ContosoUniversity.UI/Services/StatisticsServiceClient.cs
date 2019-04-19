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
       
        public StatisticsReply GetStatistics()
        {
            Channel channel = new Channel("localhost:" + "50051", ChannelCredentials.Insecure);
            var client = new Statistics.StatisticsClient(channel);
            var reply = client.GetStatistics(new StatisticsRequest { Name = "StatisticsClient" });
            
            return reply;
        }

        public EnrollmentsListReply GetEnrollments()
        {
            Channel channel = new Channel("localhost:" + "50051", ChannelCredentials.Insecure);
            var client = new Statistics.StatisticsClient(channel);
            var reply = client.GetEnrollments(new EnrollmentsRequest { Name = "EnrollmentsClient" });
            
            return reply;
        }
    }
}
