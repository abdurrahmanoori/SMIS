using System.Linq.Expressions;

namespace SMIS.Application.Common;

public class EntityDropdown<T>
{
    public T Criteria { get; set; }
    public string[]? Columns { get; set; }
    public int? PageNumber { get; set; }
    public int? PageSize { get; set; }

    public int GetPageNumber()
    {
        return PageNumber ?? 1;
    }

    public int GetPageSize()
    {
        return PageSize ?? 10000;
    }

    public int GetSkipSize()
    {
        return (GetPageNumber() - 1) * GetPageSize();
    }

    public void SetDefaultColumns(params Expression<Func<T, object?>>[] properties)
    {
        if ((Columns == null || Columns.Length == 0) && properties.Length > 0)
        {
            Columns = properties.Select(property => ExpressionHelpers.GetMember(property).Name).ToArray();
        }
    }

    public bool PopCriteriaFor<TType>(Expression<Func<T, TType?>> property, out TType? value)
    {
        var member = ExpressionHelpers.GetMember(property);
        value = (TType?)this.Criteria.GetType().GetProperty(member.Name).GetValue(this, null);
        if (value == null) return false;
        this.GetType().GetProperty(member.Name).SetValue(this, null);
        return true;
    }

    public bool PopSelectFor<TType>(Expression<Func<T, TType?>> property, out string? value)
    {
        var member = ExpressionHelpers.GetMember(property);
        value = this.Columns?.FirstOrDefault(x => string.Equals(
                x,
                member.Name,
                StringComparison.CurrentCultureIgnoreCase
            )
        );
        if (value == null) return false;
        this.Columns = this.Columns?.Where(x => x.ToLower() != member.Name).ToArray();
        return true;
    }

    public bool HasCriteriaFor<TType>(Expression<Func<T, TType?>> property)
    {
        return (TType?)Criteria
            .GetType()
            .GetProperty(ExpressionHelpers.GetMember(property).Name)
            .GetValue(Criteria, null) != null;
    }

    public bool HasSelectFor<TType>(Expression<Func<T, TType?>> property)
    {
        return Columns?.FirstOrDefault(x => x.Equals(
                ExpressionHelpers.GetMember(property).Name,
                StringComparison.CurrentCultureIgnoreCase
            )
        ) != null;
    }

    public bool HasCriteriaOrSelectFor<TType>(Expression<Func<T, TType?>> property)
    {
        var member = ExpressionHelpers.GetMember(property);
        return (TType?)Criteria.GetType().GetProperty(member.Name).GetValue(Criteria, null) != null ||
               Columns?.FirstOrDefault(x =>
                   x.Equals(member.Name, StringComparison.CurrentCultureIgnoreCase)
               ) != null;
    }
}