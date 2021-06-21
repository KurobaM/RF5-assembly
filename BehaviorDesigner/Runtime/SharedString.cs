using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime
{
	// Token: 0x020012B5 RID: 4789
	[Token(Token = "0x2000C82")]
	[Serializable]
	public class SharedString : SharedVariable<string>
	{
		// Token: 0x060071B3 RID: 29107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E67")]
		[Address(RVA = "0x220DF30", Offset = "0x220E031", VA = "0x220DF30")]
		public static implicit operator SharedString(string value)
		{
			return null;
		}

		// Token: 0x060071B4 RID: 29108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E68")]
		[Address(RVA = "0x220DFE0", Offset = "0x220E0E1", VA = "0x220DFE0")]
		public SharedString()
		{
		}
	}
}
