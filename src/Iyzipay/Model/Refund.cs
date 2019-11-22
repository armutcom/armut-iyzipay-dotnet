﻿using System.Threading.Tasks;
using Armut.Iyzipay.Request;

namespace Armut.Iyzipay.Model
{
    public class Refund : IyzipayResource
    {
        private const string RefundUrl = "/payment/refund";

        public string PaymentId { get; set; }
        public string PaymentTransactionId { get; set; }
        public string Price { get; set; }
        public string Currency { get; set; }
        public string ConnectorName { get; set; }
        public string AuthCode { get; set; }
        public string HostReference { get; set; }

        public static Refund Create(CreateRefundRequest request, Options options)
        {
            return RestHttpClient.Instance.Post<Refund>(options.BaseUrl + RefundUrl, GetHttpHeaders(request, options), request);
        }

        public static async Task<Refund> CreateAsync(CreateRefundRequest request, Options options)
        {
            return await RestHttpClient.Instance.PostAsync<Refund>(options.BaseUrl + RefundUrl, GetHttpHeaders(request, options), request);
        }
    }
}
