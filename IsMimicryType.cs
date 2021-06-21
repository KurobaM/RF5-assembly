using System;
using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;

// Token: 0x02000155 RID: 341
[Token(Token = "0x2000109")]
[Attribute(Name = "TaskCategoryAttribute", RVA = "0x145480", Offset = "0x145581")]
public class IsMimicryType : Conditional
{
	// Token: 0x06000735 RID: 1845 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000614")]
	[Address(RVA = "0x2235CA0", Offset = "0x2235DA1", VA = "0x2235CA0", Slot = "4")]
	public override void OnAwake()
	{
	}

	// Token: 0x06000736 RID: 1846 RVA: 0x00004920 File Offset: 0x00002B20
	[Token(Token = "0x6000615")]
	[Address(RVA = "0x2235D60", Offset = "0x2235E61", VA = "0x2235D60", Slot = "6")]
	public override TaskStatus OnUpdate()
	{
		return TaskStatus.Inactive;
	}

	// Token: 0x06000737 RID: 1847 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000616")]
	[Address(RVA = "0x2235D90", Offset = "0x2235E91", VA = "0x2235D90")]
	public IsMimicryType()
	{
	}

	// Token: 0x04000420 RID: 1056
	[Token(Token = "0x400032B")]
	[FieldOffset(Offset = "0x50")]
	private MonsterBehaviorController Controller;
}
