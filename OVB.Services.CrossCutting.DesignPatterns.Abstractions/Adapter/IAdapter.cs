namespace OVB.Services.CrossCutting.DesignPatterns.Abstractions.Adapter;

public interface IAdapter<out Adaptee, in NeedAdapt> where Adaptee : class where NeedAdapt : class
{
    public abstract Adaptee Adapt(NeedAdapt needAdapt);
}
