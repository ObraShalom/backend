using System.Text;
using System.Text.Json;
using Microsoft.Extensions.Logging;

namespace ObraShalom.Interface.Helpers;

public static class LoggerExtensions
{
    public static void LogException(this ILogger logger, Exception ex)
    {
        var exceptionDetails = new
        {
            Exception = FlattenException(ex)
        };

        var jsonException = JsonSerializer.Serialize(exceptionDetails);

        logger.LogError(jsonException);
    }

    private static string FlattenException(Exception ex)
    {
        var messageSb = new StringBuilder();

        while (ex is not null)
        {
            messageSb
                .AppendLine($" Msg: {ex.Message}")
                .AppendLine($" Source: {ex.Source}")
                .AppendLine($" StackTrace: {ex.StackTrace}");

            ex = ex.InnerException;
        }

        return messageSb.ToString();
    }
}
