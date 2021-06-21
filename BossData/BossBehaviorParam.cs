using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BossData
{
	// Token: 0x02000F28 RID: 3880
	[Token(Token = "0x20009E1")]
	[Serializable]
	public class BossBehaviorParam
	{
		// Token: 0x06006521 RID: 25889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005402")]
		[Address(RVA = "0x245AC00", Offset = "0x245AD01", VA = "0x245AC00")]
		public BossBehaviorParam()
		{
		}

		// Token: 0x0400C500 RID: 50432
		[Token(Token = "0x400933A")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		public int Index;

		// Token: 0x0400C501 RID: 50433
		[Token(Token = "0x400933B")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		public CompareType _CompareType;

		// Token: 0x0400C502 RID: 50434
		[Token(Token = "0x400933C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public int CompareParam;
	}
}
