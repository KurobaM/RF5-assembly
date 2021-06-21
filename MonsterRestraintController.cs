using System;
using Il2CppDummyDll;

// Token: 0x020002A2 RID: 674
[Token(Token = "0x2000216")]
public class MonsterRestraintController : CharaRestraintController<MonsterControllerBase>
{
	// Token: 0x06001149 RID: 4425 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FBA")]
	[Address(RVA = "0x1E6FC40", Offset = "0x1E6FD41", VA = "0x1E6FC40", Slot = "6")]
	public override void Setup()
	{
	}

	// Token: 0x0600114A RID: 4426 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FBB")]
	[Address(RVA = "0x1E6FC60", Offset = "0x1E6FD61", VA = "0x1E6FC60", Slot = "8")]
	public override void OnRestraint()
	{
	}

	// Token: 0x0600114B RID: 4427 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FBC")]
	[Address(RVA = "0x1E6FD00", Offset = "0x1E6FE01", VA = "0x1E6FD00", Slot = "9")]
	public override void OnRelease()
	{
	}

	// Token: 0x0600114C RID: 4428 RVA: 0x00007F38 File Offset: 0x00006138
	[Token(Token = "0x6000FBD")]
	[Address(RVA = "0x1E6FD40", Offset = "0x1E6FE41", VA = "0x1E6FD40", Slot = "11")]
	protected override bool ReleaseCondition()
	{
		return default(bool);
	}

	// Token: 0x0600114D RID: 4429 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FBE")]
	[Address(RVA = "0x1E6FE60", Offset = "0x1E6FF61", VA = "0x1E6FE60")]
	public MonsterRestraintController()
	{
	}
}
