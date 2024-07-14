using Microsoft.AspNetCore.Builder;
using System.Net;

namespace Source.ExtendMethods {
    public static class AppExtends {
        public static void AddStatusCodePages(this IApplicationBuilder app) {
            app.UseStatusCodePages(appError => {
                appError.Run(async context => {
                    HttpResponse response = context.Response;
                    int statusCode = response.StatusCode;

                    var content = $@"
                    <html>
                        <head>
                            <meta charset='UTF-8'/>
                            <title>Error: {statusCode}</title>
                        </head>
                        <body>
                            <p>
                                Error message: {statusCode} - {(HttpStatusCode)statusCode}
                            </p>
                        </body>
                    </html>";

                    await response.WriteAsync(content);
                });
            });
        }
    }
}
