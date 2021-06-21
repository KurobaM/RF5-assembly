using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime
{
	// Token: 0x020012AE RID: 4782
	[Token(Token = "0x2000C7B")]
	[Serializable]
	public class SharedInt : SharedVariable<int>
	{
		// Token: 0x060071A5 RID: 29093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E59")]
		[Address(RVA = "0x220D2B0", Offset = "0x220D3B1", VA = "0x220D2B0")]
		public static implicit operator SharedInt(int value)
		{
			return null;
		}

		// Token: 0x060071A6 RID: 29094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E5A")]
		[Address(RVA = "0x220D360", Offset = "0x220D461", VA = "0x220D360")]
		public SharedInt()
		{
		}
	}
}
