using System;
using Il2CppDummyDll;

// Token: 0x0200007F RID: 127
[Token(Token = "0x2000061")]
public class SetDamageInformation : ActionCommandBase
{
	// Token: 0x17000065 RID: 101
	// (get) Token: 0x0600024A RID: 586 RVA: 0x00002B20 File Offset: 0x00000D20
	[Token(Token = "0x17000062")]
	public int DamageInfoIndex
	{
		[Token(Token = "0x6000207")]
		[Address(RVA = "0x1E33600", Offset = "0x1E33701", VA = "0x1E33600")]
		get
		{
			return 0;
		}
	}

	// Token: 0x0600024B RID: 587 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000208")]
	[Address(RVA = "0x1E33620", Offset = "0x1E33721", VA = "0x1E33620")]
	public SetDamageInformation(ActionCommandDataTable actionCommandData, ActionScriptControllerBase controller)
	{
	}

	// Token: 0x0600024C RID: 588 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000209")]
	[Address(RVA = "0x1E33680", Offset = "0x1E33781", VA = "0x1E33680", Slot = "8")]
	public override void DoAction()
	{
	}
}
