using System;
using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;

// Token: 0x0200012C RID: 300
[Token(Token = "0x20000F0")]
[Attribute(Name = "TaskCategoryAttribute", RVA = "0x145000", Offset = "0x145101")]
public class PartnerNPCThrowItem : BehaviorDesigner.Runtime.Tasks.Action
{
	// Token: 0x0600065D RID: 1629 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000579")]
	[Address(RVA = "0x21397E0", Offset = "0x21398E1", VA = "0x21397E0", Slot = "4")]
	public override void OnAwake()
	{
	}

	// Token: 0x0600065E RID: 1630 RVA: 0x00004590 File Offset: 0x00002790
	[Token(Token = "0x600057A")]
	[Address(RVA = "0x21398A0", Offset = "0x21399A1", VA = "0x21398A0", Slot = "6")]
	public override TaskStatus OnUpdate()
	{
		return TaskStatus.Inactive;
	}

	// Token: 0x0600065F RID: 1631 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600057B")]
	[Address(RVA = "0x2139A40", Offset = "0x2139B41", VA = "0x2139A40", Slot = "9")]
	public override void OnEnd()
	{
	}

	// Token: 0x06000660 RID: 1632 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600057C")]
	[Address(RVA = "0x2139AA0", Offset = "0x2139BA1", VA = "0x2139AA0")]
	public PartnerNPCThrowItem()
	{
	}

	// Token: 0x04000394 RID: 916
	[Token(Token = "0x40002DD")]
	[FieldOffset(Offset = "0x50")]
	private PartnerNPCBehaviorController PartnerNPCBehaviorController;
}
