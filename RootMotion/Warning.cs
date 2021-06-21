using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x02000CA5 RID: 3237
	[Token(Token = "0x200084B")]
	public static class Warning
	{
		// Token: 0x06005376 RID: 21366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004594")]
		[Address(RVA = "0x27DB000", Offset = "0x27DB101", VA = "0x27DB000")]
		public static void Log(string message, Warning.Logger logger, bool logInEditMode = false)
		{
		}

		// Token: 0x06005377 RID: 21367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004595")]
		[Address(RVA = "0x27C3390", Offset = "0x27C3491", VA = "0x27C3390")]
		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
		}

		// Token: 0x0400B224 RID: 45604
		[Token(Token = "0x40085A9")]
		[FieldOffset(Offset = "0x0")]
		public static bool logged;

		// Token: 0x02000CA6 RID: 3238
		// (Invoke) Token: 0x06005379 RID: 21369
		[Token(Token = "0x20013D3")]
		public delegate void Logger(string message);
	}
}
