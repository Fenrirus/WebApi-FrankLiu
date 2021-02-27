﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Linq;
using WebApiFrankLiu.TokenAuthentication;

namespace WebApiFrankLiu.Filters
{
    public class TokenAuthenticationFilter : Attribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            // lepiej tego sposobu nie używać. Jak twórca stwierdził jest nielegancki, ale działa :)
            var tokenManager = (ITokenManager)context.HttpContext.RequestServices.GetService(typeof(ITokenManager));

            var result = true;
            if (!context.HttpContext.Request.Headers.ContainsKey("Autorization"))
            {
                result = false;
            }
            string token = string.Empty;

            if (result)
            {
                token = context.HttpContext.Request.Headers.First(x => x.Key == "Autorization").Value;
                if (!tokenManager.Verify(token))
                {
                    result = false;
                }
            }

            if (!result)
            {
                context.ModelState.AddModelError("Unauthorized", "You are not ahuthorized");
                context.Result = new UnauthorizedObjectResult(context.ModelState);
            }
        }
    }
}