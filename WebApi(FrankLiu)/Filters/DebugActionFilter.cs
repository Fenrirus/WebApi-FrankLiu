namespace WebApiFrankLiu.Filters
{
    using Microsoft.AspNetCore.Mvc.Filters;
    using System;

    public class DebugActionFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);
            Console.WriteLine($"[Action] {context.ActionDescriptor.DisplayName} is executing");
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            base.OnActionExecuted(context);
            Console.WriteLine($"[Action] {context.ActionDescriptor.DisplayName} is executed");
        }
    }
}