using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andafa.Mes.Common.Extensions
{
    /// <summary>
    /// enumrable extension
    /// </summary>
    public static class EnumrableExtension
    {
        /// <summary>
        /// enumrable minus
        /// </summary>
        /// <typeparam name="T">type</typeparam>
        /// <param name="toBeCalc">to be calculated</param>
        /// <param name="calc">calculate</param>
        /// <returns>result</returns>
        public static IEnumerable<T> Minus<T>(this IEnumerable<T> toBeCalc, IEnumerable<T> calc = null)
        {
            if (toBeCalc == null)
            {
                return new List<T>();
            }
            if (calc == null)
            {
                return toBeCalc;
            }
            return toBeCalc.Where(a => !calc.Contains(a));
        }

        /// <summary>
        /// enumrable inter section
        /// </summary>
        /// <typeparam name="T">type</typeparam>
        /// <param name="toBeCalc">to be calculated</param>
        /// <param name="calc">calculate</param>
        /// <returns>result</returns>
        public static IEnumerable<T> InterSection<T>(this IEnumerable<T> toBeCalc, IEnumerable<T> calc = null)
        {
            if (toBeCalc == null || calc == null)
            {
                return new List<T>();
            }
            return toBeCalc.Intersect(calc);
        }

        /// <summary>
        /// enumrable inter section
        /// </summary>
        /// <typeparam name="T">type</typeparam>
        /// <param name="toBeCalc">to be calculated</param>
        /// <param name="calc">calculate</param>
        /// <returns>result</returns>
        public static IEnumerable<T> UnionAll<T>(this IEnumerable<T> toBeCalc, IEnumerable<T> calc = null)
        {
            if (toBeCalc == null && calc == null)
            {
                return new List<T>();
            }
            else if (toBeCalc != null && calc == null)
            {
                return toBeCalc;
            }
            else if (toBeCalc == null && calc != null)
            {
                return calc;
            }
            else
            {
                return toBeCalc.Union(calc);
            }
        }
    }
}
