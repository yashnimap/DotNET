
using System.Security.Cryptography;
using System.Text;

namespace BasicAuthentication.Middleware
{
    public class AuthMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            if (!context.Request.Headers.ContainsKey("Authorization"))
            {
                context.Response.StatusCode = 401;
                await context.Response.WriteAsync("Unauthorized");
                return;
            }
          
            var headers = context.Request.Headers["Authorization"].ToString();
            var creds = headers.Substring(6);
            var encodedString = Encoding.UTF8.GetString(Convert.FromBase64String(creds));
            string[] credentialString = encodedString.Split(':');
            string userName = credentialString[0];
            string password = credentialString[1];

            if(userName != "Yash" && password != "Yash@123"  ) 
            {
                context.Response.StatusCode = 401;
                await context.Response.WriteAsync("Unauthorized");
                return;
            }
            await next(context);    
        }
    }
}
