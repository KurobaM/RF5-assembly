using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BossData
{
	// Token: 0x02000F2A RID: 3882
	[Token(Token = "0x20009E3")]
	[Serializable]
	public class LotteryBossBehavior<T> where T : Enum
	{
		// Token: 0x06006523 RID: 25891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005404")]
		public BossBehaviorParam GetBossBehaviorParam()
		{
			return null;
		}

		// Token: 0x06006524 RID: 25892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005405")]
		public LotteryBossBehavior()
		{
		}

		// Token: 0x0400C504 RID: 50436
		[Token(Token = "0x400933E")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		public T Index;

		// Token: 0x0400C505 RID: 50437
		[Token(Token = "0x400933F")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		public CompareType _CompareType;

		// Token: 0x0400C506 RID: 50438
		[Token(Token = "0x4009340")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		public int CompareParam;
	}
}
