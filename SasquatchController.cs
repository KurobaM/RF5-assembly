using System;
using Il2CppDummyDll;

// Token: 0x02000762 RID: 1890
[Token(Token = "0x2000514")]
public class SasquatchController : BossMonsterContoroller
{
	// Token: 0x170006DF RID: 1759
	// (get) Token: 0x060030A6 RID: 12454 RVA: 0x00011070 File Offset: 0x0000F270
	// (set) Token: 0x060030A7 RID: 12455 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000571")]
	public float RestraintDamageRate
	{
		[Token(Token = "0x60028DD")]
		[Address(RVA = "0x1EFAE50", Offset = "0x1EFAF51", VA = "0x1EFAE50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A43A0", Offset = "0x1A44A1")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60028DE")]
		[Address(RVA = "0x1EFAE60", Offset = "0x1EFAF61", VA = "0x1EFAE60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A43B0", Offset = "0x1A44B1")]
		set
		{
		}
	}

	// Token: 0x060030A8 RID: 12456 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60028DF")]
	[Address(RVA = "0x1EFAE70", Offset = "0x1EFAF71", VA = "0x1EFAE70", Slot = "134")]
	public override void OnRestraint()
	{
	}

	// Token: 0x060030A9 RID: 12457 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60028E0")]
	[Address(RVA = "0x1EFAEC0", Offset = "0x1EFAFC1", VA = "0x1EFAEC0", Slot = "135")]
	public override void OnRelease()
	{
	}

	// Token: 0x060030AA RID: 12458 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60028E1")]
	[Address(RVA = "0x1EFAF10", Offset = "0x1EFB011", VA = "0x1EFAF10", Slot = "126")]
	protected override void OnSetup()
	{
	}

	// Token: 0x060030AB RID: 12459 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60028E2")]
	[Address(RVA = "0x1EFAF20", Offset = "0x1EFB021", VA = "0x1EFAF20", Slot = "132")]
	public override void OnUniqueActionCommandInternal(MonsterActionCommandBase monsterActionCommandBase, ActionCommandDataTable actionCommandData)
	{
	}

	// Token: 0x060030AC RID: 12460 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60028E3")]
	[Address(RVA = "0x1EFB2A0", Offset = "0x1EFB3A1", VA = "0x1EFB2A0")]
	public SasquatchController()
	{
	}

	// Token: 0x040075E4 RID: 30180
	[Token(Token = "0x4006C0B")]
	[FieldOffset(Offset = "0x508")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x169910", Offset = "0x169A11")]
	private float <RestraintDamageRate>k__BackingField;
}
