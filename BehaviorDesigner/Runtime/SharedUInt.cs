using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime
{
	// Token: 0x020012B8 RID: 4792
	[Token(Token = "0x2000C85")]
	[Serializable]
	public class SharedUInt : SharedVariable<uint>
	{
		// Token: 0x060071B9 RID: 29113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E6D")]
		[Address(RVA = "0x220E230", Offset = "0x220E331", VA = "0x220E230")]
		public static implicit operator SharedUInt(uint value)
		{
			return null;
		}

		// Token: 0x060071BA RID: 29114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E6E")]
		[Address(RVA = "0x220E2E0", Offset = "0x220E3E1", VA = "0x220E2E0")]
		public SharedUInt()
		{
		}
	}
}
