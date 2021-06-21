using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime
{
	// Token: 0x020012A0 RID: 4768
	[Token(Token = "0x2000C6D")]
	[Serializable]
	public class SharedMonsterBehaviorState : SharedVariable<EnemyBehaviorTreeState>
	{
		// Token: 0x0600718B RID: 29067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E3F")]
		[Address(RVA = "0x220D7E0", Offset = "0x220D8E1", VA = "0x220D7E0")]
		public static implicit operator SharedMonsterBehaviorState(EnemyBehaviorTreeState value)
		{
			return null;
		}

		// Token: 0x0600718C RID: 29068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E40")]
		[Address(RVA = "0x220D8A0", Offset = "0x220D9A1", VA = "0x220D8A0")]
		public SharedMonsterBehaviorState()
		{
		}
	}
}
