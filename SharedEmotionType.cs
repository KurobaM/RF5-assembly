using System;
using BehaviorDesigner.Runtime;
using Define;
using Il2CppDummyDll;

// Token: 0x0200016F RID: 367
[Token(Token = "0x200011D")]
[Serializable]
public class SharedEmotionType : SharedVariable<EmotionType>
{
	// Token: 0x060007A0 RID: 1952 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000677")]
	[Address(RVA = "0x1E366C0", Offset = "0x1E367C1", VA = "0x1E366C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x060007A1 RID: 1953 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000678")]
	[Address(RVA = "0x1E36750", Offset = "0x1E36851", VA = "0x1E36750")]
	public static implicit operator SharedEmotionType(EmotionType value)
	{
		return null;
	}

	// Token: 0x060007A2 RID: 1954 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000679")]
	[Address(RVA = "0x1E36800", Offset = "0x1E36901", VA = "0x1E36800")]
	public SharedEmotionType()
	{
	}
}
