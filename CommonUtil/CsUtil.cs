using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonUtil
{
	public static class CsUtil
	{
		public static int ConStr_Int32(string input)
		{
			return ConStr_Int32(input, 0);
		}

		public static int ConStr_Int32(this string input, Int32 defValue)
		{
			Int32 iReturn = 0;

			if (!Int32.TryParse(input, out iReturn))
			{
				iReturn = defValue;
			}

			return iReturn;
		}

	}
}
