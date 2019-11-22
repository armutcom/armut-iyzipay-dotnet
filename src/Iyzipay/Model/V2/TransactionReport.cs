﻿using Armut.Iyzipay.Request.V2;
using System.Threading.Tasks;

namespace Armut.Iyzipay.Model.V2
{
    public class TransactionReport : TransactionReportResource
    {
        public static TransactionReport Retrieve(RetrieveTransactionReportRequest request, Options options)
        {
            string url = options.BaseUrl
                            + "/v2/reporting/payment/transactions?transactionDate="
                            + request.TransactionDate
                            + "&page="
                            + request.Page;

            return RestHttpClient.Instance.Get<TransactionReport>(url, GetHttpHeadersWithUrlParams(request, url, options));
        }

        public static async Task<TransactionReport> RetrieveAsync(RetrieveTransactionReportRequest request, Options options)
        {
            string url = options.BaseUrl
                            + "/v2/reporting/payment/transactions?transactionDate="
                            + request.TransactionDate
                            + "&page="
                            + request.Page;

            return await RestHttpClient.Instance.GetAsync<TransactionReport>(url, GetHttpHeadersWithUrlParams(request, url, options));
        }
    }
}