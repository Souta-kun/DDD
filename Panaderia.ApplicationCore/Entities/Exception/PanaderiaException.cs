using System.Net;

namespace Panaderia.ApplicationCore.Entities.Exception
{
    public class PanaderiaException : System.Exception
    {
        public HttpStatusCode CodeStatus { get; set; }
        public PanaderiaException(string message) : base(message) { }
    }
}