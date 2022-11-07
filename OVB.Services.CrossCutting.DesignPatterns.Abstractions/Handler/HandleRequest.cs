namespace OVB.Services.CrossCutting.DesignPatterns.Abstractions.Handler;

public abstract class HandleRequest
{
    public Guid Identifier { get; private set; }
    public DateTime Time { get; private set; }

    protected HandleRequest(Guid identifier, DateTime time)
    {
        Identifier = identifier;
        Time = time;
    }
}
