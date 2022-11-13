using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec3_Delegate
{
	/// <summary>
	/// 利用委派達成篩選的目的
	/// </summary>
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int> list = GetRandomNum(100);

			List<int> evenList = GetEvenItems(list, i => i % 2 == 0); //在此給委派方法

			foreach (var item in evenList)
			{
				Console.WriteLine(item);
			}
		}

		/// <summary>
		/// 取得列表中的所有偶數數字
		/// </summary>
		/// <param name="source">傳入想要判斷的整數列表</param>
		/// <param name="func">傳入值為整數，回傳值為bool的委派</param>
		/// <returns></returns>
		static List<int> GetEvenItems(List<int> source, Func<int, bool> func)
		{
			var result = new List<int>();

			for (int i = 0; i < source.Count; i++)
			{
				if (func(source[i]))
					result.Add(source[i]);
			}
			return result;

		}

		/// <summary>
		/// 生成一串整數列表
		/// </summary>
		/// <param name="num">想要取得數字的個數</param>
		/// <returns>隨機數字的列表</returns>
		static List<int> GetRandomNum(int num)
		{
			Random random = new Random(Guid.NewGuid().GetHashCode());
			var numList = new List<int>();

			for (int i = 0; i < num -1; i++)
			{
				numList.Add(random.Next(1,101));	
			}

			return numList;
		}
	}
}
