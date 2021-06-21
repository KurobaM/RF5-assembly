using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime
{
	// Token: 0x0200129C RID: 4764
	[Token(Token = "0x2000C69")]
	[Serializable]
	public class SharedCharacterControllerList : SharedVariable<List<CharacterBase>>
	{
		// Token: 0x06007183 RID: 29059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E37")]
		[Address(RVA = "0x220CB70", Offset = "0x220CC71", VA = "0x220CB70")]
		public static implicit operator SharedCharacterControllerList(List<CharacterBase> value)
		{
			return null;
		}

		// Token: 0x06007184 RID: 29060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E38")]
		[Address(RVA = "0x220CC30", Offset = "0x220CD31", VA = "0x220CC30")]
		public SharedCharacterControllerList()
		{
		}
	}
}
