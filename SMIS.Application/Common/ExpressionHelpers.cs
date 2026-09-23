using System.Linq.Expressions;
using System.Reflection;

namespace SMIS.Application.Common;

public class ExpressionHelpers
{
    public static MemberInfo? GetMember<T, TType>(
        Expression<Func<T, TType?>> property
    )
    {
        var member = property.Body switch
        {
            MemberExpression m => m,
            UnaryExpression u => (u.Operand as MemberExpression),
            _ => throw new ArgumentException("Not a member expression")
        };
        return member.Member;
    }
}