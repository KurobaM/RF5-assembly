using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x02000CA1 RID: 3233
	[Token(Token = "0x2000847")]
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		// Token: 0x17000AC9 RID: 2761
		// (get) Token: 0x06005354 RID: 21332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000892")]
		public static T instance
		{
			[Token(Token = "0x6004572")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005355 RID: 21333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004573")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06005356 RID: 21334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004574")]
		protected Singleton()
		{
		}

		// Token: 0x0400B21C RID: 45596
		[Token(Token = "0x40085A1")]
		[FieldOffset(Offset = "0x0")]
		private static T sInstance;
	}
}
