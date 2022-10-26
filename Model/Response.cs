using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Response
    {
        public Response(string? message, bool success, object? element)
        {
            Message = message;
            Success = success;
            Element = element;
        }

        public Response() { }

        public string? Message { get; set; }
        public bool Success { get; set; }
        public object? Element { get; set; }
    }
}
