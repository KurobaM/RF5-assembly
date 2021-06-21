using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime
{
	// Token: 0x020012A8 RID: 4776
	[Token(Token = "0x2000C75")]
	[Serializable]
	public class SharedBool : SharedVariable<bool>
	{
		// Token: 0x06007199 RID: 29081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E4D")]
		[Address(RVA = "0x220CA70", Offset = "0x220CB71", VA = "0x220CA70")]
		public static implicit operator SharedBool(bool value)
		{
			return null;
		}

		// Token: 0x0600719A RID: 29082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E4E")]
		[Address(RVA = "0x220CB20", Offset = "0x220CC21", VA = "0x220CB20")]
		public SharedBool()
		{
		}
	}
}
