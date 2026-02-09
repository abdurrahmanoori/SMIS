namespace SMIS.Domain.Contracts;

public interface IDateTimeService
{
    DateTime Now { get; }
    DateTimeOffset NowOffSet {  get; }
}
