using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatedString
{
	class Program
	{
		static void Main(string[] args)
		{
			string aString = Console.ReadLine();
			string aNumber = Console.ReadLine();
			long aCount = Convert.ToInt64(aNumber);
			long aRepeatedString = repeatedString(aString, aCount);
			Console.WriteLine(aRepeatedString);
		}

		static long repeatedString(string s, long n)
		{
			var acount = 0L;
			acount = s.Count(f => f == 'a');
			var aStringRepeats = n / s.Length;
			acount *= aStringRepeats;
			var aStringLength = n % s.Length;

			for (int i = 0; i < aStringLength; i++)
			{
				if (s[i] == 'a')
					acount++;
			}
			return acount;
		}
	}
}
