namespace WebApiFrankLiu.Filters
{
    using Microsoft.AspNetCore.Mvc.Filters;
    using System;

    public class DebugResourceFilter : Attribute, IResourceFilter, IOrderedFilter
    {
        public int Order => 3;

        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            Console.WriteLine($"[Resource 1] { context.ActionDescriptor.DisplayName} is executed");
        }

        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            Console.WriteLine($"[Resource 1] { context.ActionDescriptor.DisplayName} is executing");
        }
    }
}