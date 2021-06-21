using System;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;

// Token: 0x02000146 RID: 326
[Token(Token = "0x20000FA")]
[Attribute(Name = "TaskCategoryAttribute", RVA = "0x145200", Offset = "0x145301")]
public class CharacterEmotion : BehaviorDesigner.Runtime.Tasks.Action
{
	// Token: 0x060006F8 RID: 1784 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005D7")]
	[Address(RVA = "0x1E8D860", Offset = "0x1E8D961", VA = "0x1E8D860", Slot = "4")]
	public override void OnAwake()
	{
	}

	// Token: 0x060006F9 RID: 1785 RVA: 0x00004788 File Offset: 0x00002988
	[Token(Token = "0x60005D8")]
	[Address(RVA = "0x1E8D930", Offset = "0x1E8DA31", VA = "0x1E8D930", Slot = "6")]
	public override TaskStatus OnUpdate()
	{
		return TaskStatus.Inactive;
	}

	// Token: 0x060006FA RID: 1786 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005D9")]
	[Address(RVA = "0x1E8DA20", Offset = "0x1E8DB21", VA = "0x1E8DA20")]
	public CharacterEmotion()
	{
	}

	// Token: 0x040003F4 RID: 1012
	[Token(Token = "0x40002FF")]
	[FieldOffset(Offset = "0x50")]
	public SharedEmotionType EmotionType;

	// Token: 0x040003F5 RID: 1013
	[Token(Token = "0x4000300")]
	[FieldOffset(Offset = "0x58")]
	public SharedFloat DispTime;

	// Token: 0x040003F6 RID: 1014
	[Token(Token = "0x4000301")]
	[FieldOffset(Offset = "0x60")]
	private AIInput AIInput;
}
