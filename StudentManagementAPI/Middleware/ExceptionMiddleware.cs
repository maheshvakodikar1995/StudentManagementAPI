namespace StudentManagementAPI.Middleware
{
    public class ExceptionMiddleware
    {
        #region Fields
        private readonly RequestDelegate _next;
        #endregion

        #region Ctor
        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        #endregion

        #region Methods
        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                context.Response.StatusCode = 500;
                await context.Response.WriteAsync(ex.Message);
            }
        }
        #endregion
    }
}
