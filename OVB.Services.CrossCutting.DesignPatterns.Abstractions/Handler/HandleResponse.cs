namespace OVB.Services.CrossCutting.DesignPatterns.Abstractions.Handler;

public abstract class HandleResponse
{
    public Guid Identifier { get; private set; }
    public int HttpStatusReturn { get; private set; }
    public string Message { get; private set; }

    protected HandleResponse(Guid identifier, int httpStatusReturn, string message)
    {
        Identifier = identifier;
        HttpStatusReturn = httpStatusReturn;
        Message = message;
    }

    public void ChangeHttpStatus(int httpStatusReturn)
    {
        HttpStatusReturn = httpStatusReturn;
    }

    public void ChangeMessage(string message)
    {
        Message = message;
    }
}
