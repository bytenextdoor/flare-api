using Carter;
using Flare.Api.Endpoints.Application;

namespace Flare.Api.Endpoints;

public sealed class ApplicationEndpoints : ICarterModule
{
	public void AddRoutes(IEndpointRouteBuilder app)
	{
		var group = app.MapGroup("/Application");

		group.MapGet("/Information", GetInformation.Handle)
			.WithName("GetApplicationInformation")
			.WithSummary("Returns the information of the application.")
			.WithDescription("Returns the information of the application.")
			.WithOpenApi();
	}
}