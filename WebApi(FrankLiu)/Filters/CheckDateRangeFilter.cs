using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace WebApiFrankLiu.Filters
{
    public class CheckDateRangeFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);

            var startDate = (DateTime)context.ActionArguments["startDate"];
            var endDate = (DateTime)context.ActionArguments["endDate"];

            if (startDate > endDate)
            {
                context.ModelState.AddModelError("startDate", $"{startDate} is lower than end date");
                context.Result = new BadRequestObjectResult(context.ModelState);
            }
        }
    }
}