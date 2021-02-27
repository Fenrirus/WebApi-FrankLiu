using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace WebApiFrankLiu.Filters
{
    public class DebugResourceFilter2 : Attribute, IResourceFilter, IOrderedFilter
    {
        public int Order => 1;

        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            Console.WriteLine($"[Resource 3] { context.ActionDescriptor.DisplayName} is executed");
        }

        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            Console.WriteLine($"[Resource 3] { context.ActionDescriptor.DisplayName} is executing");
        }
    }
}