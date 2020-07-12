using System;
using System.Collections.Generic;

namespace ToolkitForms
{
	/// <summary>
	/// 本地化字符串类
	/// </summary>
	static partial class Localization
	{
		/// <summary>
		/// 根据操作系统语种获取字符串的本地化值
		/// </summary>
		/// <param name="key">字符串</param>
		/// <returns>获取成功返回本地化字符串，否则返回原字符串</returns>
		public static string Get(string key)
		{
			Dictionary<string, string> map = GetLanguagePack();
			if (map == null)
			{
				return key;
			}

			if (map.ContainsKey(key))
			{
				return map[key];
			}

			return key;
		}		

		// 当前系统语言
		static readonly string Language = System.Globalization.CultureInfo.InstalledUICulture.Name;

		// 根据系统语言获取相应的词典
		static Dictionary<string, string> GetLanguagePack()
		{
			Dictionary<string, string> map = null;

			switch (Language)
			{
				case "zh-CN":
				case "zh-Hans":
				case "zh-SG":
					map = ChineseSimplified;
					break;

				case "zh-HK":
				case "zh-MO":
				case "zh-TW":
				case "zh-Hant":
					map = ChineseTraditional;
					break;

				default:
					break;
			}

			return map;
		}		
	}
}
