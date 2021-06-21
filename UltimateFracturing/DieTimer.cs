using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UltimateFracturing
{
	// Token: 0x02000C43 RID: 3139
	[Token(Token = "0x20007FD")]
	public class DieTimer : MonoBehaviour
	{
		// Token: 0x06004FB7 RID: 20407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041FC")]
		[Address(RVA = "0x23B9770", Offset = "0x23B9871", VA = "0x23B9770")]
		private void Start()
		{
		}

		// Token: 0x06004FB8 RID: 20408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041FD")]
		[Address(RVA = "0x23B9780", Offset = "0x23B9881", VA = "0x23B9780")]
		private void Update()
		{
		}

		// Token: 0x06004FB9 RID: 20409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041FE")]
		[Address(RVA = "0x23B9830", Offset = "0x23B9931", VA = "0x23B9830")]
		public DieTimer()
		{
		}

		// Token: 0x0400B077 RID: 45175
		[Token(Token = "0x400844D")]
		[FieldOffset(Offset = "0x18")]
		public float SecondsToDie;

		// Token: 0x0400B078 RID: 45176
		[Token(Token = "0x400844E")]
		[FieldOffset(Offset = "0x1C")]
		public float OffscreenLifeTime;

		// Token: 0x0400B079 RID: 45177
		[Token(Token = "0x400844F")]
		[FieldOffset(Offset = "0x20")]
		private float m_fTimer;
	}
}
