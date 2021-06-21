using System;
using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;

// Token: 0x02000150 RID: 336
[Token(Token = "0x2000104")]
public class CompareSharedMonsterActionBehaviorType : Conditional
{
	// Token: 0x06000724 RID: 1828 RVA: 0x000048A8 File Offset: 0x00002AA8
	[Token(Token = "0x6000603")]
	[Address(RVA = "0x20DD1A0", Offset = "0x20DD2A1", VA = "0x20DD1A0", Slot = "6")]
	public override TaskStatus OnUpdate()
	{
		return TaskStatus.Inactive;
	}

	// Token: 0x06000725 RID: 1829 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000604")]
	[Address(RVA = "0x20DD280", Offset = "0x20DD381", VA = "0x20DD280", Slot = "16")]
	public override void OnReset()
	{
	}

	// Token: 0x06000726 RID: 1830 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000605")]
	[Address(RVA = "0x20DD2C0", Offset = "0x20DD3C1", VA = "0x20DD2C0")]
	public CompareSharedMonsterActionBehaviorType()
	{
	}

	// Token: 0x04000410 RID: 1040
	[Token(Token = "0x400031B")]
	[FieldOffset(Offset = "0x50")]
	public SharedMonsterActionBehaviorType variable;

	// Token: 0x04000411 RID: 1041
	[Token(Token = "0x400031C")]
	[FieldOffset(Offset = "0x58")]
	public SharedMonsterActionBehaviorType compareTo;
}
