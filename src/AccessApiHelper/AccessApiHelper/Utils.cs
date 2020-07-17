using System;

namespace CrownPeak.AccessApiHelper
{
	public static class Utils
	{
		public static string TidyForJson(string src)
		{
			if (src == null)
			{
				return "null";
			}
			if (string.IsNullOrWhiteSpace(src))
			{
				return "";
			}
			return src.Trim().Replace("\\", "\\\\").Replace("\n", "\\\n").Replace("\"", "\\\"");
		}
	}
}