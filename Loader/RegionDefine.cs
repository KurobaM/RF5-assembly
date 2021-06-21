using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Loader
{
	// Token: 0x02001024 RID: 4132
	[Token(Token = "0x2000A75")]
	public static class RegionDefine
	{
		// Token: 0x06006847 RID: 26695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056CB")]
		[Address(RVA = "0x1F0B430", Offset = "0x1F0B531", VA = "0x1F0B430")]
		public static string RootKey(bool region, SystemLanguage lang)
		{
			return null;
		}

		// Token: 0x0400C786 RID: 51078
		[Token(Token = "0x4009410")]
		[FieldOffset(Offset = "0x0")]
		public static readonly RegionDefine.Region CurrentRegion;

		// Token: 0x0400C787 RID: 51079
		[Token(Token = "0x4009411")]
		[FieldOffset(Offset = "0x8")]
		public static readonly SystemLanguage[] RegionLanguages;

		// Token: 0x0400C788 RID: 51080
		[Token(Token = "0x4009412")]
		public const SystemLanguage DefaultLanguage = SystemLanguage.Japanese;

		// Token: 0x0400C789 RID: 51081
		[Token(Token = "0x4009413")]
		private const string RegionFreeKey = "All/";

		// Token: 0x0400C78A RID: 51082
		[Token(Token = "0x4009414")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Dictionary<SystemLanguage, string> RegionKey;

		// Token: 0x02001025 RID: 4133
		[Token(Token = "0x200151B")]
		public enum Region
		{
			// Token: 0x0400C78C RID: 51084
			[Token(Token = "0x401BF83")]
			JPN,
			// Token: 0x0400C78D RID: 51085
			[Token(Token = "0x401BF84")]
			ASIA,
			// Token: 0x0400C78E RID: 51086
			[Token(Token = "0x401BF85")]
			NA,
			// Token: 0x0400C78F RID: 51087
			[Token(Token = "0x401BF86")]
			EU,
			// Token: 0x0400C790 RID: 51088
			[Token(Token = "0x401BF87")]
			STEAM,
			// Token: 0x0400C791 RID: 51089
			[Token(Token = "0x401BF88")]
			Length
		}
	}
}
