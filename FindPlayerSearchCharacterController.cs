using System;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;

// Token: 0x0200014D RID: 333
[Token(Token = "0x2000101")]
[Attribute(Name = "TaskCategoryAttribute", RVA = "0x145380", Offset = "0x145481")]
public class FindPlayerSearchCharacterController : Conditional
{
	// Token: 0x1700017E RID: 382
	// (get) Token: 0x06000716 RID: 1814 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700016A")]
	private SearchCharacterController SearchCharacterController
	{
		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x2033720", Offset = "0x2033821", VA = "0x2033720")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700017F RID: 383
	// (get) Token: 0x06000717 RID: 1815 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700016B")]
	private Character Player
	{
		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x2033740", Offset = "0x2033841", VA = "0x2033740")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000718 RID: 1816 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005F7")]
	[Address(RVA = "0x20337A0", Offset = "0x20338A1", VA = "0x20337A0", Slot = "4")]
	public override void OnAwake()
	{
	}

	// Token: 0x06000719 RID: 1817 RVA: 0x00004848 File Offset: 0x00002A48
	[Token(Token = "0x60005F8")]
	[Address(RVA = "0x2033810", Offset = "0x2033911", VA = "0x2033810", Slot = "6")]
	public override TaskStatus OnUpdate()
	{
		return TaskStatus.Inactive;
	}

	// Token: 0x0600071A RID: 1818 RVA: 0x00004860 File Offset: 0x00002A60
	[Token(Token = "0x60005F9")]
	[Address(RVA = "0x2033AA0", Offset = "0x2033BA1", VA = "0x2033AA0")]
	public int GetSearchCharacterType()
	{
		return 0;
	}

	// Token: 0x0600071B RID: 1819 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005FA")]
	[Address(RVA = "0x2033B40", Offset = "0x2033C41", VA = "0x2033B40")]
	public FindPlayerSearchCharacterController()
	{
	}

	// Token: 0x0400040A RID: 1034
	[Token(Token = "0x4000315")]
	[FieldOffset(Offset = "0x50")]
	public SharedInt SearchRangeType;

	// Token: 0x0400040B RID: 1035
	[Token(Token = "0x4000316")]
	[FieldOffset(Offset = "0x58")]
	public SharedBool UseMaxRange;

	// Token: 0x0400040C RID: 1036
	[Token(Token = "0x4000317")]
	[FieldOffset(Offset = "0x60")]
	private AIInput AIInput;
}
