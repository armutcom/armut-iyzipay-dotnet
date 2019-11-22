﻿using System.Threading.Tasks;
using Armut.Iyzipay.Request;

namespace Armut.Iyzipay.Model
{
    public class CrossBookingToSubMerchant : IyzipayResource
    {
        private const string CrossBookingToSubMerchantUrl = "/crossbooking/send";

        public static CrossBookingToSubMerchant Create(CreateCrossBookingRequest request, Options options)
        {
            return RestHttpClient.Instance.Post<CrossBookingToSubMerchant>(options.BaseUrl + CrossBookingToSubMerchantUrl, GetHttpHeaders(request, options), request);
        }

        public static async Task<CrossBookingToSubMerchant> CreateAsync(CreateCrossBookingRequest request, Options options)
        {
            return await RestHttpClient.Instance.PostAsync<CrossBookingToSubMerchant>(options.BaseUrl + CrossBookingToSubMerchantUrl, GetHttpHeaders(request, options), request);
        }
    }
}
