
using GraphQL.Common.Request;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLClient
{
    public class TodoItemsConsumer
    {
        private readonly GraphQL.Client.GraphQLClient _client;

        public TodoItemsConsumer(GraphQL.Client.GraphQLClient client)
        {
            _client = client;
        }


        public async Task<List<TodoItem>> GetAllToDos()
        {
            var query = new GraphQLRequest
            {
                Query = @"
                        query todosQuery{
                        todos {
                            id
                            title
                        }
                        }"
            };

            var response = await _client.PostAsync(query);
            return response.GetDataFieldAs<List<TodoItem>>("todos");
        }
    }
}