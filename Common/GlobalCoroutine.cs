using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace Common
{
	// Token: 0x020011C1 RID: 4545
	[Token(Token = "0x2000B96")]
	public class GlobalCoroutine : MonoBehaviour
	{
		// Token: 0x17000E4D RID: 3661
		// (get) Token: 0x0600710B RID: 28939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B29")]
		public static GlobalCoroutine instance
		{
			[Token(Token = "0x6005DC7")]
			[Address(RVA = "0x20DB6D0", Offset = "0x20DB7D1", VA = "0x20DB6D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600710C RID: 28940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DC8")]
		[Address(RVA = "0x20DB7F0", Offset = "0x20DB8F1", VA = "0x20DB7F0")]
		public void OnDisable()
		{
		}

		// Token: 0x0600710D RID: 28941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005DC9")]
		[Address(RVA = "0x20DB8E0", Offset = "0x20DB9E1", VA = "0x20DB8E0")]
		public static Coroutine StartStaticCoroutine(IEnumerator coroutine)
		{
			return null;
		}

		// Token: 0x0600710E RID: 28942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DCA")]
		[Address(RVA = "0x20DB910", Offset = "0x20DBA11", VA = "0x20DB910")]
		public static void StopStaticCoroutine(IEnumerator coroutine)
		{
		}

		// Token: 0x0600710F RID: 28943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DCB")]
		[Address(RVA = "0x20DB940", Offset = "0x20DBA41", VA = "0x20DB940")]
		public GlobalCoroutine()
		{
		}

		// Token: 0x040182F1 RID: 99057
		[Token(Token = "0x4014D5D")]
		[FieldOffset(Offset = "0x0")]
		protected static GlobalCoroutine m_Instance;
	}
}
