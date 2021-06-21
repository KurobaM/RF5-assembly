using System;
using Il2CppDummyDll;

// Token: 0x020000A2 RID: 162
[Token(Token = "0x200007C")]
public class MonsterUniqueActionCommand : MonsterActionCommandBase
{
	// Token: 0x06000322 RID: 802 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600026A")]
	[Address(RVA = "0x1E72FB0", Offset = "0x1E730B1", VA = "0x1E72FB0")]
	public MonsterUniqueActionCommand(ActionCommandDataTable actionCommandData, MonsterActionScriptsController controller)
	{
	}

	// Token: 0x17000086 RID: 134
	// (get) Token: 0x06000323 RID: 803 RVA: 0x00002FA0 File Offset: 0x000011A0
	[Token(Token = "0x17000083")]
	public override float Duration
	{
		[Token(Token = "0x600026B")]
		[Address(RVA = "0x1E73010", Offset = "0x1E73111", VA = "0x1E73010", Slot = "4")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x06000324 RID: 804 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600026C")]
	[Address(RVA = "0x1E73020", Offset = "0x1E73121", VA = "0x1E73020", Slot = "8")]
	public override void DoAction()
	{
	}
}
