﻿using System;
using System.Net.Http;
using TFLStatusLibrary;

namespace TFLStatus
{
    class Program
    {
        public HttpClient httpClient;


        public void callTfl()
        {
            httpClient = new HttpClient();
            IHttpClient httpclient = new HttpClientWrapper(httpClient);
            TFLApiClient tflApiClient = new TFLApiClient(httpclient);
            var lines = tflApiClient.SetupAndMakeApiCallAndReturnFormattedData();
            lines.ForEach(line => Console.WriteLine(line.lineId + "--" + line.lineName + "--" + line.lineStatus + "___" + "---" + line.statusReason));

        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.callTfl();
            
    }
    }
}
