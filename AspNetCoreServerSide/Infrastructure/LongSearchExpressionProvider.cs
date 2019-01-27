using System;
using System.Linq.Expressions;

namespace AspNetCoreServerSide.Infrastructure
{
    public class LongSearchExpressionProvider : ComparableSearchExpressionProvider
    {
        public override ConstantExpression GetValue(string input)
        {
            if (!long.TryParse(input, out var value))
                throw new ArgumentException("Invalid search value.");

            return Expression.Constant(value);
        }
    }
}
