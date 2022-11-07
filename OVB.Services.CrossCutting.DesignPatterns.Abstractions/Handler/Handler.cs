namespace OVB.Services.CrossCutting.DesignPatterns.Abstractions.Handler;

public abstract class Handler<Response, Request> where Response : HandleResponse where Request : HandleRequest
{
    public abstract Task<Response> Handle(in Request request);
}