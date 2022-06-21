using System;
using System.Net.Http;
using System.Threading.Tasks;
using App1.APIServices.Helpers;
using App1.Models.Requests;

namespace App1.APIServices.Services
{
    public class AdminService
    {
        private readonly string BaseAddress = $"{ApiConsts.BaseURL}{ApiConsts.Admin}";

        public async Task<string> GetUsersWithCars()
        {
            var response = await SendGetUsersWithCars();

            return ApiHelper.GetResponseContent(response);
        }

        private async Task<HttpResponseMessage> SendGetUsersWithCars()
        {
            using var client = new HttpClient();

            ApiHelper.AddAuthorizationHeader(client);

            var response = await client.GetAsync($"{BaseAddress}/users");

            return response;
        }
    }
}
