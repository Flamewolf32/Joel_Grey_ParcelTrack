using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ParcelTrack.Filters
{
    public class RequireClientAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            string client = context.HttpContext.Request.Headers["X-Client"].ToString();
            string? action = context.ActionDescriptor.RouteValues["action"];

            if (string.IsNullOrEmpty(client))
            {
                context.Result = new BadRequestObjectResult(new
                {
                    message = "Say which program is calling: add an X-Client header"
                });
                return;
            }

            Console.WriteLine($"X-Client: {client} -> {action}");
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            string? action = context.ActionDescriptor.RouteValues["action"];
            Console.WriteLine($"{action} finished");
        }
    }
}
