namespace OVB.Services.CrossCutting.DesignPatterns.Abstractions.Handler;

public abstract class IHandleRequest
{
    public Guid Identifier { get; private set; }
    public DateTime Time { get; private set; }

    protected IHandleRequest(Guid identifier, DateTime time)
    {
        Identifier = identifier;
        Time = time;
    }
}
