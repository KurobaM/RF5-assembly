using System;
using Il2CppDummyDll;

// Token: 0x020000AC RID: 172
[Token(Token = "0x2000085")]
public class SetSpeedCommand : MonsterProjectileActionCommandBase
{
	// Token: 0x17000092 RID: 146
	// (get) Token: 0x06000359 RID: 857 RVA: 0x000030A8 File Offset: 0x000012A8
	[Token(Token = "0x1700008F")]
	private float Speed
	{
		[Token(Token = "0x600029F")]
		[Address(RVA = "0x1E35C70", Offset = "0x1E35D71", VA = "0x1E35C70")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x0600035A RID: 858 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002A0")]
	[Address(RVA = "0x1E35C90", Offset = "0x1E35D91", VA = "0x1E35C90")]
	public SetSpeedCommand(ActionCommandDataTable actionCommandData, MonsterProjectileActionScriptsController controller)
	{
	}

	// Token: 0x0600035B RID: 859 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002A1")]
	[Address(RVA = "0x1E35CF0", Offset = "0x1E35DF1", VA = "0x1E35CF0", Slot = "8")]
	public override void DoAction()
	{
	}
}
