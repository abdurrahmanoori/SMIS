namespace SMIS.Domain.Contracts;

public interface IDateTimeService
{
    DateTime Now { get; }
    DateTime NowOffSet {  get; }
}
