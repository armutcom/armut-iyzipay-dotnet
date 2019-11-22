﻿using System.Threading.Tasks;
using Armut.Iyzipay.Request;

namespace Armut.Iyzipay.Model
{
    public class PaymentPostAuth : PaymentResource
    {
        private const string PaymentPostAuthUrl = "/payment/postauth";

        public static PaymentPostAuth Create(CreatePaymentPostAuthRequest request, Options options)
        {
            return RestHttpClient.Instance.Post<PaymentPostAuth>(options.BaseUrl + PaymentPostAuthUrl, GetHttpHeaders(request, options), request);
        }

        public static async Task<PaymentPostAuth> CreateAsync(CreatePaymentPostAuthRequest request, Options options)
        {
            return await RestHttpClient.Instance.PostAsync<PaymentPostAuth>(options.BaseUrl + PaymentPostAuthUrl, GetHttpHeaders(request, options), request);
        }
    }
}
