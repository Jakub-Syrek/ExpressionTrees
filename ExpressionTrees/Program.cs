using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionTrees
{
    class Program
    {
        static void Main(string[] args)
        {

            Expression<Func<int, int, int>> addTwoNumbersExpression = (x, y) => x + y;
            BinaryExpression body = (BinaryExpression)addTwoNumbersExpression.Body;
            Console.WriteLine(body);
            Console.ReadKey();
        }
    }
}
