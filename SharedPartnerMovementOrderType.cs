using System;
using BehaviorDesigner.Runtime;
using Il2CppDummyDll;

// Token: 0x02000172 RID: 370
[Token(Token = "0x2000120")]
[Serializable]
public class SharedPartnerMovementOrderType : SharedVariable<PartnerMovementOrderType>
{
	// Token: 0x060007A9 RID: 1961 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000680")]
	[Address(RVA = "0x1E37360", Offset = "0x1E37461", VA = "0x1E37360", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x060007AA RID: 1962 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000681")]
	[Address(RVA = "0x1E373F0", Offset = "0x1E374F1", VA = "0x1E373F0")]
	public static implicit operator SharedPartnerMovementOrderType(PartnerMovementOrderType value)
	{
		return null;
	}

	// Token: 0x060007AB RID: 1963 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000682")]
	[Address(RVA = "0x1E374A0", Offset = "0x1E375A1", VA = "0x1E374A0")]
	public SharedPartnerMovementOrderType()
	{
	}
}
