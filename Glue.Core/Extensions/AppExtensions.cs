using Microsoft.AspNetCore.Builder;

namespace Glue.Core.Extensions;

public static class AppExtensions {
    public static IApplicationBuilder UseGlueFile(this IApplicationBuilder app) {
        return app;
    }
}
