﻿using System;
using System.Net;
using System.Web;
using RestSharp;

namespace Monk.Utils
{
    public class RESTFul
    {
        public string BaseUrl { get; set; }

        public RESTFul() { }

        public RESTFul(string baseUrl, string http = "")
        {
            var _baseUrl = http + baseUrl;
            if (!_baseUrl.ToLower().StartsWith("http://") || !_baseUrl.ToLower().StartsWith("https://"))
            {
                _baseUrl = "http://" + _baseUrl;
            }
            this.BaseUrl = _baseUrl;
        }

        public T Get<T>(string resource, object parameter) where T : new()
        {
            return HttpExecute<T>(resource, parameter, Method.GET);
        }

        public T Post<T>(string resource, object parameter) where T : new()
        {
            return HttpExecute<T>(resource, parameter, Method.POST);
        }

        public T Delete<T>(string resource, object parameter) where T : new()
        {
            return HttpExecute<T>(resource, parameter, Method.DELETE);
        }

        public T Put<T>(string resource, object parameter) where T : new()
        {
            return HttpExecute<T>(resource, parameter, Method.PUT);
        }

        public T HttpExecute<T>(string resource, object parameter, Method method) where T : new()
        {
            var request = new RestRequest(resource, method);
            request.AddObject(parameter);
            return Execute<T>(request);
        }

        public string Execute(RestRequest request)
        {
            var client = new RestClient(this.BaseUrl);
            client.CookieContainer = new CookieContainer();
            var response = client.Execute(request);
            if (response.ErrorException != null)
            {
                const string message = "错误检索响应。检查更多信息的内部细节。";
                var httpException = new HttpException(message, response.ErrorException);
                throw httpException;
            }
            return response.Content;
        }

        public T Execute<T>(RestRequest request) where T : new()
        {
            var client = new RestClient(this.BaseUrl);
            client.CookieContainer = new CookieContainer();
            var response = client.Execute<T>(request);
            if (response.ErrorException != null)
            {
                const string message = "错误检索响应。检查更多信息的内部细节。";
                var httpException = new HttpException(message, response.ErrorException);
                throw httpException;
            }
            return response.Data;
        }
    }
}