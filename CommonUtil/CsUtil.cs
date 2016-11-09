using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonUtil
{
	/// <summary>
	/// 클래스 라이브러리 테스트 유틸 클래스
	/// <para> - CsUtil</para>
	/// </summary>
	public static class CsUtil
	{
		#region ▩ 형변환 메서드 정리

		/// <summary>
		/// <para> ▩ 형변환 - String을 Int32로 변환 및 리턴 한다.</para>
		/// </summary>
		/// <param name="input">입력 문자열</param>
		/// <returns>변환 리턴 값</returns>
		public static Int32 Con_Str_Int32(string input)
		{
			return Con_Str_Int32(input, 0);
		}

		/// <summary>
		/// <para> ▩ 형변환 - String을 Int32로 변환 및 리턴 한다.</para>
		/// </summary>
		/// <param name="input">입력 문자열</param>
		/// <param name="defValue">기본값: 없으면 0으로 셋팅</param>
		/// <returns>변환 리턴 값</returns>
		public static Int32 Con_Str_Int32(this string input, Int32 defValue = 0)
		{
			Int32 iReturn = 0;

			if (!Int32.TryParse(input, out iReturn))
			{
				iReturn = defValue;
			}

			return iReturn;
		}


		/// <summary>
		/// <para> ▩ 형변환 - String을 Int64로 변환 및 리턴 한다.</para>
		/// </summary>
		/// <param name="input">입력 문자열</param>
		/// <returns>변환 리턴 값</returns>
		public static Int64 Con_Str_Int64(string input)
		{
			return Con_Str_Int64(input, 0);
		}

		/// <summary>
		/// <para> ▩ 형변환 - String을 Int64로 변환 및 리턴 한다.</para>
		/// </summary>
		/// <param name="input">입력 문자열</param>
		/// <param name="defValue">기본값: 없으면 0으로 셋팅</param>
		/// <returns>변환 리턴 값</returns>
		public static Int64 Con_Str_Int64(this string input, Int64 defValue = 0)
		{
			Int64 iReturn = 0;

			if (!Int64.TryParse(input, out iReturn))
			{
				iReturn = defValue;
			}

			return iReturn;
		}
		

		/// <summary>
		/// <para> ▩ 형변환 - String을 DateTime로 변환 및 리턴 한다.</para>
		/// </summary>
		/// <param name="input">입력 문자열</param>
		/// <returns>변환 리턴 값</returns>
		public static DateTime Con_Str_DateTime(string input)
		{
			return Con_Str_DateTime(input, new DateTime());
		}

		/// <summary>
		/// <para> ▩ 형변환 - String을 DateTime로 변환 및 리턴 한다.</para>
		/// </summary>
		/// <param name="input">입력 문자열</param>
		/// <param name="defValue">기본값: 없으면 0으로 셋팅</param>
		/// <returns>변환 리턴 값</returns>
		public static DateTime Con_Str_DateTime(this string input, DateTime defValue = new DateTime())
		{
			DateTime iReturn = new DateTime();

			if (!DateTime.TryParse(input, out iReturn))
			{
				iReturn = defValue;
			}

			return iReturn;
		}

		#endregion

	}
}
