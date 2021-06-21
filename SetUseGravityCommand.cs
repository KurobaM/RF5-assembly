using System;
using Il2CppDummyDll;

// Token: 0x020000AD RID: 173
[Token(Token = "0x2000086")]
public class SetUseGravityCommand : MonsterProjectileActionCommandBase
{
	// Token: 0x17000093 RID: 147
	// (get) Token: 0x0600035C RID: 860 RVA: 0x000030C0 File Offset: 0x000012C0
	[Token(Token = "0x17000090")]
	public bool UseGravity
	{
		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x1E35D30", Offset = "0x1E35E31", VA = "0x1E35D30")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x0600035D RID: 861 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002A3")]
	[Address(RVA = "0x1E35D50", Offset = "0x1E35E51", VA = "0x1E35D50")]
	public SetUseGravityCommand(ActionCommandDataTable actionCommandData, MonsterProjectileActionScriptsController controller)
	{
	}

	// Token: 0x0600035E RID: 862 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002A4")]
	[Address(RVA = "0x1E35DB0", Offset = "0x1E35EB1", VA = "0x1E35DB0", Slot = "8")]
	public override void DoAction()
	{
	}
}
