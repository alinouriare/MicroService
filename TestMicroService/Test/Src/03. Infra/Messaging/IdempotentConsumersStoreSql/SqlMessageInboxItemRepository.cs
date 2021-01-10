﻿using Dapper;
using IdempotentConsumers;
using System;
using System.Data.SqlClient;
using System.Linq;
using Utilitie.Configurations;

namespace IdempotentConsumersStoreSql
{
    public class SqlMessageInboxItemRepository : IMessageInboxItemRepository
    {
        readonly string _connectionString;
        public SqlMessageInboxItemRepository(ZaminConfigurations configurations)
        {
            _connectionString = configurations.Messageconsumer.SqlMessageInboxStore.ConnectionString;
        }

        public bool AllowReceive(string messageId, string fromService)
        {
            using var connection = new SqlConnection(_connectionString);
            string query = "Select Id from [MessageInbox] Where [OwnerService] = @OwnerService and [MessageId] = @MessageId";
            var result = connection.Query<long>(query, new
            {
                OwnerService = fromService,
                MessageId = messageId
            }).FirstOrDefault();
            return result < 1;
        }

        public void Receive(string messageId, string fromService)
        {
            using var connection = new SqlConnection(_connectionString);
            string query = "Insert Into [MessageInbox] ([OwnerService] ,[MessageId] ) values(@OwnerService,@MessageId)";
            var result = connection.Query<long>(query, new
            {
                OwnerService = fromService,
                MessageId = messageId
            }).FirstOrDefault();
        }
    }
}
