using System;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;

// Token: 0x02000148 RID: 328
[Token(Token = "0x20000FC")]
[Attribute(Name = "TaskCategoryAttribute", RVA = "0x145280", Offset = "0x145381")]
public class CharacterWarp : BehaviorDesigner.Runtime.Tasks.Action
{
	// Token: 0x06000700 RID: 1792 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005DF")]
	[Address(RVA = "0x1E9D8A0", Offset = "0x1E9D9A1", VA = "0x1E9D8A0", Slot = "4")]
	public override void OnAwake()
	{
	}

	// Token: 0x06000701 RID: 1793 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005E0")]
	[Address(RVA = "0x1E9D970", Offset = "0x1E9DA71", VA = "0x1E9D970", Slot = "5")]
	public override void OnStart()
	{
	}

	// Token: 0x06000702 RID: 1794 RVA: 0x000047D0 File Offset: 0x000029D0
	[Token(Token = "0x60005E1")]
	[Address(RVA = "0x1E9D980", Offset = "0x1E9DA81", VA = "0x1E9D980", Slot = "6")]
	public override TaskStatus OnUpdate()
	{
		return TaskStatus.Inactive;
	}

	// Token: 0x06000703 RID: 1795 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005E2")]
	[Address(RVA = "0x1E9DA30", Offset = "0x1E9DB31", VA = "0x1E9DA30")]
	public CharacterWarp()
	{
	}

	// Token: 0x040003FD RID: 1021
	[Token(Token = "0x4000308")]
	[FieldOffset(Offset = "0x50")]
	public SharedVector3 newPosition;

	// Token: 0x040003FE RID: 1022
	[Token(Token = "0x4000309")]
	[FieldOffset(Offset = "0x58")]
	private AIInput AIInput;
}
