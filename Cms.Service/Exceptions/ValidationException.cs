namespace Cms.Service.Exceptions;

public class ValidationExceptionError : AppException
{
    public ValidationExceptionError(string detail)
        : base("Unprocessable Entity", 422, "VALIDATION_ERROR", detail) { }
}
