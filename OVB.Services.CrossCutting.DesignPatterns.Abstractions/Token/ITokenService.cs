namespace OVB.Services.CrossCutting.DesignPatterns.Abstractions.Token;

public interface ITokenService<T> where T : class
{
    public string CreateToken(T entityBase);
    public string RefreshToken(T entityBase);
}
