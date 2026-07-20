using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace FirstWebApi.Filters
{
    public class CustomExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            string filePath = "ErrorLog.txt";

            File.AppendAllText(
                filePath,
                DateTime.Now + " : " + context.Exception.Message + Environment.NewLine);

            context.Result = new ObjectResult("Internal Server Error")
            {
                StatusCode = StatusCodes.Status500InternalServerError
            };

            context.ExceptionHandled = true;
        }
    }
}