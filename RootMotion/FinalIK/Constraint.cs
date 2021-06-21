using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000CFB RID: 3323
	[Token(Token = "0x200088D")]
	[Serializable]
	public abstract class Constraint
	{
		// Token: 0x17000AE5 RID: 2789
		// (get) Token: 0x060054E6 RID: 21734 RVA: 0x0001BF60 File Offset: 0x0001A160
		[Token(Token = "0x170008A3")]
		public bool isValid
		{
			[Token(Token = "0x60046CA")]
			[Address(RVA = "0x2871A70", Offset = "0x2871B71", VA = "0x2871A70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060054E7 RID: 21735
		[Token(Token = "0x60046CB")]
		public abstract void UpdateConstraint();

		// Token: 0x060054E8 RID: 21736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046CC")]
		[Address(RVA = "0x2871AE0", Offset = "0x2871BE1", VA = "0x2871AE0")]
		protected Constraint()
		{
		}

		// Token: 0x0400B457 RID: 46167
		[Token(Token = "0x4008779")]
		[FieldOffset(Offset = "0x10")]
		public Transform transform;

		// Token: 0x0400B458 RID: 46168
		[Token(Token = "0x400877A")]
		[FieldOffset(Offset = "0x18")]
		public float weight;
	}
}
