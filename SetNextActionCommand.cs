using System;
using Il2CppDummyDll;

// Token: 0x020000A8 RID: 168
[Token(Token = "0x2000082")]
public class SetNextActionCommand : MonsterActionCommandBase
{
	// Token: 0x1700008F RID: 143
	// (get) Token: 0x06000343 RID: 835 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700008C")]
	public string NextActionCode
	{
		[Token(Token = "0x600028B")]
		[Address(RVA = "0x1E34BF0", Offset = "0x1E34CF1", VA = "0x1E34BF0")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000090 RID: 144
	// (get) Token: 0x06000344 RID: 836 RVA: 0x00003078 File Offset: 0x00001278
	[Token(Token = "0x1700008D")]
	public bool IsGoNext
	{
		[Token(Token = "0x600028C")]
		[Address(RVA = "0x1E34C10", Offset = "0x1E34D11", VA = "0x1E34C10")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000345 RID: 837 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600028D")]
	[Address(RVA = "0x1E34C30", Offset = "0x1E34D31", VA = "0x1E34C30")]
	public SetNextActionCommand(ActionCommandDataTable actionCommandData, MonsterActionScriptsController controller)
	{
	}

	// Token: 0x06000346 RID: 838 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600028E")]
	[Address(RVA = "0x1E34CC0", Offset = "0x1E34DC1", VA = "0x1E34CC0", Slot = "7")]
	public override void ActionInitial()
	{
	}

	// Token: 0x06000347 RID: 839 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600028F")]
	[Address(RVA = "0x1E34CF0", Offset = "0x1E34DF1", VA = "0x1E34CF0", Slot = "8")]
	public override void DoAction()
	{
	}
}
