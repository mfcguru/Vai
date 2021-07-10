using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Net;

namespace Vai.Backend.Api.Helpers
{
	using Vai.Backend.Core.BusinessRules;
	using Vai.Shared.Results;

	public static class GlobalExceptionHandler
	{
		public static void ConfigureExceptionHandler(this IApplicationBuilder app, ILogger logger)
		{
			app.UseExceptionHandler(appError =>
			{
				appError.Run(async context =>
				{
					context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
					context.Response.ContentType = "application/json";

					var contextFeature = context.Features.Get<IExceptionHandlerFeature>();
					if (contextFeature != null)
					{
						string errorJson;
						if (contextFeature.Error is BusinessRulesException)
						{
							var error = (BusinessRulesException)contextFeature.Error;
							context.Response.StatusCode = (int)error.StatusCode;
							errorJson = JsonConvert.SerializeObject(new CommandResult
							{
								Success = false,
								StatusCode = (int)error.StatusCode,
								Error = error.Message
							}); ;
							await context.Response.WriteAsync(errorJson);
						}
						else
						{
							errorJson = JsonConvert.SerializeObject(new CommandResult
							{
								Success = false,
								StatusCode = context.Response.StatusCode,
								Error = contextFeature.Error.ToString()
							});
							await context.Response.WriteAsync(errorJson);
						}
						logger.LogError(errorJson);
					}
				});
			});
		}
	}
}
