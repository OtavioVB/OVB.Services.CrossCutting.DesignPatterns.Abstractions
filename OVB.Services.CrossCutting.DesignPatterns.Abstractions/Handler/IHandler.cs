namespace OVB.Services.CrossCutting.DesignPatterns.Abstractions.Handler;

public abstract class IHandler<Response, Request> where Response : IHandleResponse where Request : IHandleRequest
{
    public abstract Task<Response> Handle(in Request request);
}