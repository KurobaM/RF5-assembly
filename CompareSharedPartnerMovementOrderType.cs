using System;
using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;

// Token: 0x02000151 RID: 337
[Token(Token = "0x2000105")]
public class CompareSharedPartnerMovementOrderType : Conditional
{
	// Token: 0x06000727 RID: 1831 RVA: 0x000048C0 File Offset: 0x00002AC0
	[Token(Token = "0x6000606")]
	[Address(RVA = "0x20DD2D0", Offset = "0x20DD3D1", VA = "0x20DD2D0", Slot = "6")]
	public override TaskStatus OnUpdate()
	{
		return TaskStatus.Inactive;
	}

	// Token: 0x06000728 RID: 1832 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000607")]
	[Address(RVA = "0x20DD3B0", Offset = "0x20DD4B1", VA = "0x20DD3B0", Slot = "16")]
	public override void OnReset()
	{
	}

	// Token: 0x06000729 RID: 1833 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000608")]
	[Address(RVA = "0x20DD3F0", Offset = "0x20DD4F1", VA = "0x20DD3F0")]
	public CompareSharedPartnerMovementOrderType()
	{
	}

	// Token: 0x04000412 RID: 1042
	[Token(Token = "0x400031D")]
	[FieldOffset(Offset = "0x50")]
	public SharedPartnerMovementOrderType variable;

	// Token: 0x04000413 RID: 1043
	[Token(Token = "0x400031E")]
	[FieldOffset(Offset = "0x58")]
	public SharedPartnerMovementOrderType compareTo;
}
