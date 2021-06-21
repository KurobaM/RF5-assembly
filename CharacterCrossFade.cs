using System;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;

// Token: 0x02000145 RID: 325
[Token(Token = "0x20000F9")]
[Attribute(Name = "TaskCategoryAttribute", RVA = "0x1451C0", Offset = "0x1452C1")]
public class CharacterCrossFade : BehaviorDesigner.Runtime.Tasks.Action
{
	// Token: 0x060006F4 RID: 1780 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005D3")]
	[Address(RVA = "0x1E8D6C0", Offset = "0x1E8D7C1", VA = "0x1E8D6C0", Slot = "4")]
	public override void OnAwake()
	{
	}

	// Token: 0x060006F5 RID: 1781 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005D4")]
	[Address(RVA = "0x1E8D790", Offset = "0x1E8D891", VA = "0x1E8D790", Slot = "5")]
	public override void OnStart()
	{
	}

	// Token: 0x060006F6 RID: 1782 RVA: 0x00004770 File Offset: 0x00002970
	[Token(Token = "0x60005D5")]
	[Address(RVA = "0x1E8D7A0", Offset = "0x1E8D8A1", VA = "0x1E8D7A0", Slot = "6")]
	public override TaskStatus OnUpdate()
	{
		return TaskStatus.Inactive;
	}

	// Token: 0x060006F7 RID: 1783 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005D6")]
	[Address(RVA = "0x1E8D850", Offset = "0x1E8D951", VA = "0x1E8D850")]
	public CharacterCrossFade()
	{
	}

	// Token: 0x040003F1 RID: 1009
	[Token(Token = "0x40002FC")]
	[FieldOffset(Offset = "0x50")]
	private AIInput AIInput;

	// Token: 0x040003F2 RID: 1010
	[Token(Token = "0x40002FD")]
	[FieldOffset(Offset = "0x58")]
	public SharedString stateName;

	// Token: 0x040003F3 RID: 1011
	[Token(Token = "0x40002FE")]
	[FieldOffset(Offset = "0x60")]
	public SharedFloat transitionDuration;
}
