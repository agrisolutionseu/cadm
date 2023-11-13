namespace AS.FoodPass.CADM.Core.Definitions
{
    public interface IDomain
    {
        string DomainName { get; }
        bool HasStaticData { get; }
        bool HasAggregatedData { get; }
    }
}