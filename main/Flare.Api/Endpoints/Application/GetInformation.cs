using System.Reflection;

namespace Flare.Api.Endpoints.Application;

public static class GetInformation
{
	public sealed class Response
	{
		public string MachineName { get; init; }
		
		public string Environment  { get; init; }
		
		public string Version { get; init; }
		
		public DateTimeOffset DateTimeUtc { get; init; }
	}

	public static Response Handle()
	{
		var assembly = Assembly.GetExecutingAssembly();
		var assemblyName = assembly.GetName();
		string environmentName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Unknown"; 
		return new()
		{
			MachineName = Environment.MachineName,
			Environment = environmentName,
			Version = assemblyName.Version?.ToString() ?? string.Empty,
			DateTimeUtc = DateTime.UtcNow
		};
	}
}