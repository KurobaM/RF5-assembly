using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BossData
{
	// Token: 0x02000F29 RID: 3881
	[Token(Token = "0x20009E2")]
	[Serializable]
	public class BossBehaviorParams
	{
		// Token: 0x06006522 RID: 25890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005403")]
		[Address(RVA = "0x245AC10", Offset = "0x245AD11", VA = "0x245AC10")]
		public BossBehaviorParams()
		{
		}

		// Token: 0x0400C503 RID: 50435
		[Token(Token = "0x400933D")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		public BossBehaviorParam[] BehaviorParams;
	}
}
