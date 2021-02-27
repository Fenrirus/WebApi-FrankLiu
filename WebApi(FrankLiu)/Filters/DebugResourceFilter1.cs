using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace WebApiFrankLiu.Filters
{
    public class DebugResourceFilter1 : Attribute, IResourceFilter, IOrderedFilter
    {
        public int Order => 2;

        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            Console.WriteLine($"[Resource 2] { context.ActionDescriptor.DisplayName} is executed");
        }

        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            Console.WriteLine($"[Resource 2] { context.ActionDescriptor.DisplayName} is executing");
        }
    }
}