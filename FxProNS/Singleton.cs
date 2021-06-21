using System;
using Il2CppDummyDll;

namespace FxProNS
{
	// Token: 0x020015F7 RID: 5623
	[Token(Token = "0x2000F7A")]
	public abstract class Singleton<T> where T : class, new()
	{
		// Token: 0x0600802B RID: 32811 RVA: 0x0002E080 File Offset: 0x0002C280
		[Token(Token = "0x6006A69")]
		private static bool Compare<U>(U x, U y) where U : class
		{
			return default(bool);
		}

		// Token: 0x17000F85 RID: 3973
		// (get) Token: 0x0600802C RID: 32812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BB9")]
		public static T Instance
		{
			[Token(Token = "0x6006A6A")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600802D RID: 32813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A6B")]
		protected Singleton()
		{
		}

		// Token: 0x0401C1A4 RID: 115108
		[Token(Token = "0x40189D5")]
		[FieldOffset(Offset = "0x0")]
		private static T instance;
	}
}
