using System;
using BehaviorDesigner.Runtime;
using Define;
using Il2CppDummyDll;

// Token: 0x0200016D RID: 365
[Token(Token = "0x200011B")]
[Serializable]
public class SharedAlliance : SharedVariable<Alliance>
{
	// Token: 0x0600079A RID: 1946 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000671")]
	[Address(RVA = "0x1E363A0", Offset = "0x1E364A1", VA = "0x1E363A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x0600079B RID: 1947 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000672")]
	[Address(RVA = "0x1E36430", Offset = "0x1E36531", VA = "0x1E36430")]
	public static implicit operator SharedAlliance(Alliance value)
	{
		return null;
	}

	// Token: 0x0600079C RID: 1948 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000673")]
	[Address(RVA = "0x1E364E0", Offset = "0x1E365E1", VA = "0x1E364E0")]
	public SharedAlliance()
	{
	}
}
