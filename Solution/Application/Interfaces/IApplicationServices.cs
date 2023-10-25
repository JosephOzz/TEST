namespace Application.Interfaces
{
    public interface IApplicationServices
    {
        IEntityOfCase1Service Case1Service { get; }
        IEntityOfCase2Service Case2Service { get; }
    }
}
