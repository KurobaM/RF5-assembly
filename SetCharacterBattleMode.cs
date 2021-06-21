using System;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;

// Token: 0x0200014B RID: 331
[Token(Token = "0x20000FF")]
[Attribute(Name = "TaskCategoryAttribute", RVA = "0x145340", Offset = "0x145441")]
public class SetCharacterBattleMode : BehaviorDesigner.Runtime.Tasks.Action
{
	// Token: 0x1700017B RID: 379
	// (get) Token: 0x0600070C RID: 1804 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000167")]
	private Character Character
	{
		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x1E330E0", Offset = "0x1E331E1", VA = "0x1E330E0")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700017C RID: 380
	// (get) Token: 0x0600070D RID: 1805 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000168")]
	private HateController HateController
	{
		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x1E33100", Offset = "0x1E33201", VA = "0x1E33100")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600070E RID: 1806 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005ED")]
	[Address(RVA = "0x1E331A0", Offset = "0x1E332A1", VA = "0x1E331A0", Slot = "4")]
	public override void OnAwake()
	{
	}

	// Token: 0x0600070F RID: 1807 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005EE")]
	[Address(RVA = "0x1E33200", Offset = "0x1E33301", VA = "0x1E33200", Slot = "5")]
	public override void OnStart()
	{
	}

	// Token: 0x06000710 RID: 1808 RVA: 0x00004818 File Offset: 0x00002A18
	[Token(Token = "0x60005EF")]
	[Address(RVA = "0x1E33210", Offset = "0x1E33311", VA = "0x1E33210", Slot = "6")]
	public override TaskStatus OnUpdate()
	{
		return TaskStatus.Inactive;
	}

	// Token: 0x06000711 RID: 1809 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005F0")]
	[Address(RVA = "0x1E333F0", Offset = "0x1E334F1", VA = "0x1E333F0")]
	public SetCharacterBattleMode()
	{
	}

	// Token: 0x04000406 RID: 1030
	[Token(Token = "0x4000311")]
	[FieldOffset(Offset = "0x50")]
	private AIInput AIInput;

	// Token: 0x04000407 RID: 1031
	[Token(Token = "0x4000312")]
	[FieldOffset(Offset = "0x58")]
	public SharedBool IsBattleMode;
}
