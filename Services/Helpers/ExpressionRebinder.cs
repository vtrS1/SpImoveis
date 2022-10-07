using System.Linq.Expressions;

namespace Services.Helpers

{
    public class ExpressionRebinder : ExpressionVisitor
    {
        private readonly Dictionary<ParameterExpression, ParameterExpression> map;

        public ExpressionRebinder(Dictionary<ParameterExpression, ParameterExpression> map)
        {
            this.map = map ?? new Dictionary<ParameterExpression, ParameterExpression>();
            this.map = map;
        }
        public static Expression ReplacementExpression(Dictionary<ParameterExpression, ParameterExpression> map, Expression exp)
        {
            return new ExpressionRebinder(map).Visit(exp);
        }
        protected override Expression VisitParameter(ParameterExpression node)
        {
            ParameterExpression replacement;
            if (this.map.TryGetValue(node, out replacement))
            {
                node = replacement;
            }

            return base.VisitParameter(node);
        }
    }
}