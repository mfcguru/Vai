using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.Threading.Tasks;

namespace Vai.Backend.Api.Helpers
{
    public static class JwtAuthenticationExtension
	{
		public static AuthenticationBuilder AddJwtAuthentication(this IServiceCollection services, string secret)
		{
			var key = Encoding.ASCII.GetBytes(secret);
			return services.AddAuthentication(x =>
			{
				x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
				x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
			})
			.AddJwtBearer(x =>
			{
				x.Events = new JwtBearerEvents
				{
					OnTokenValidated = context =>
					{
						//var mediator = context.HttpContext.RequestServices.GetRequiredService<IMediator>();
						//var user = Task.Run(async () => await mediator.Send(new GetDomainUserCommand(context.Principal.Identity.Name))).Result;
						//if (user == null)
						//{
						//	// return unauthorized if user no longer exists
						//	context.Fail("Unauthorized");
						//}
						return Task.CompletedTask;
					}
				};
				x.RequireHttpsMetadata = false;
				x.SaveToken = true;
				x.TokenValidationParameters = new TokenValidationParameters
				{
					ValidateIssuerSigningKey = true,
					IssuerSigningKey = new SymmetricSecurityKey(key),
					ValidateIssuer = false,
					ValidateAudience = false
				};
			});
		}
	}
}
