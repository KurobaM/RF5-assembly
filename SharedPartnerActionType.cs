using System;
using BehaviorDesigner.Runtime;
using Il2CppDummyDll;

// Token: 0x02000171 RID: 369
[Token(Token = "0x200011F")]
[Serializable]
public class SharedPartnerActionType : SharedVariable<AIInput.Action>
{
	// Token: 0x060007A6 RID: 1958 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600067D")]
	[Address(RVA = "0x1E37020", Offset = "0x1E37121", VA = "0x1E37020", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x060007A7 RID: 1959 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600067E")]
	[Address(RVA = "0x1E370B0", Offset = "0x1E371B1", VA = "0x1E370B0")]
	public static implicit operator SharedPartnerActionType(AIInput.Action value)
	{
		return null;
	}

	// Token: 0x060007A8 RID: 1960 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600067F")]
	[Address(RVA = "0x1E37160", Offset = "0x1E37261", VA = "0x1E37160")]
	public SharedPartnerActionType()
	{
	}
}
