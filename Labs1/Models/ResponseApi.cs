using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Labs1.Models
{
    public class ResponseApi
    {
        public bool IsSuccess { get; set; } = true;

        public string Notification {  get; set; }

        public object Data { get; set; }
    }
}
