namespace Cms.Service.Exceptions;

public class MissingAccessTokenException : AppException
{
    public MissingAccessTokenException()
        : base("Unauthorized", 401, "MISSING_ACCESS_TOKEN", "Access token is missing.") { }
}

public class ExpiredAccessTokenException : AppException
{
    public ExpiredAccessTokenException()
        : base("Unauthorized", 401, "EXPIRED_ACCESS_TOKEN", "Access token has expired.") { }
}
