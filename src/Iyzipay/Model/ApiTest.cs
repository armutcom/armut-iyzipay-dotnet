﻿using System.Threading.Tasks;

namespace Armut.Iyzipay.Model
{
    public class ApiTest : IyzipayResource
    {
        private const string ApiTestUrl = "/payment/test";

        public static IyzipayResource Retrieve(Options options)
        {
            return RestHttpClient.Instance.Get<IyzipayResource>(options.BaseUrl + ApiTestUrl);
        }

        public static async Task<IyzipayResource> RetrieveAsync(Options options)
        {
            return await RestHttpClient.Instance.GetAsync<IyzipayResource>(options.BaseUrl + ApiTestUrl);
        }
    }
}
