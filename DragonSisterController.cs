using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020006E5 RID: 1765
[Token(Token = "0x20004DF")]
public class DragonSisterController : BossMonsterContoroller
{
	// Token: 0x06002B67 RID: 11111 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002494")]
	[Address(RVA = "0x1E00D10", Offset = "0x1E00E11", VA = "0x1E00D10", Slot = "12")]
	protected override void Start()
	{
	}

	// Token: 0x06002B68 RID: 11112 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002495")]
	[Address(RVA = "0x1E00EE0", Offset = "0x1E00FE1", VA = "0x1E00EE0", Slot = "19")]
	protected override void OnDestroy()
	{
	}

	// Token: 0x06002B69 RID: 11113 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002496")]
	[Address(RVA = "0x1E01000", Offset = "0x1E01101", VA = "0x1E01000", Slot = "126")]
	protected override void OnSetup()
	{
	}

	// Token: 0x06002B6A RID: 11114 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002497")]
	[Address(RVA = "0x1E01120", Offset = "0x1E01221", VA = "0x1E01120", Slot = "125")]
	protected override void OnSetModelObject(GameObject model)
	{
	}

	// Token: 0x06002B6B RID: 11115 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002498")]
	[Address(RVA = "0x1E011D0", Offset = "0x1E012D1", VA = "0x1E011D0", Slot = "39")]
	protected override void Update()
	{
	}

	// Token: 0x06002B6C RID: 11116 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002499")]
	[Address(RVA = "0x1E012D0", Offset = "0x1E013D1", VA = "0x1E012D0")]
	private void CreateProjectileEvent(MonsterProjectileActionScriptsController projectileActionScriptsController, int attackIndex)
	{
	}

	// Token: 0x06002B6D RID: 11117 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600249A")]
	[Address(RVA = "0x1E01690", Offset = "0x1E01791", VA = "0x1E01690", Slot = "132")]
	public override void OnUniqueActionCommandInternal(MonsterActionCommandBase monsterActionCommandBase, ActionCommandDataTable actionCommandData)
	{
	}

	// Token: 0x06002B6E RID: 11118 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600249B")]
	[Address(RVA = "0x1E01960", Offset = "0x1E01A61", VA = "0x1E01960")]
	private void CheckMeteors(string repeatAction, string endAction)
	{
	}

	// Token: 0x06002B6F RID: 11119 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600249C")]
	[Address(RVA = "0x1E01B60", Offset = "0x1E01C61", VA = "0x1E01B60", Slot = "128")]
	protected override void OnDeadEvent()
	{
	}

	// Token: 0x06002B70 RID: 11120 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600249D")]
	[Address(RVA = "0x1E01C60", Offset = "0x1E01D61", VA = "0x1E01C60", Slot = "134")]
	public override void OnRestraint()
	{
	}

	// Token: 0x06002B71 RID: 11121 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600249E")]
	[Address(RVA = "0x1E00560", Offset = "0x1E00661", VA = "0x1E00560")]
	public void PlaySE(SoundID se_id)
	{
	}

	// Token: 0x06002B72 RID: 11122 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600249F")]
	[Address(RVA = "0x1E01CA0", Offset = "0x1E01DA1", VA = "0x1E01CA0")]
	public DragonSisterController()
	{
	}

	// Token: 0x06002B74 RID: 11124 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60024A1")]
	[Address(RVA = "0x1E01D40", Offset = "0x1E01E41", VA = "0x1E01D40")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2AB0", Offset = "0x1A2BB1")]
	private void <OnSetup>b__9_0(ParticleSystem particle)
	{
	}

	// Token: 0x040072D4 RID: 29396
	[Token(Token = "0x4006A38")]
	[FieldOffset(Offset = "0x0")]
	private static readonly Vector3 MEGAFIRE_OMEN_SCALE;

	// Token: 0x040072D5 RID: 29397
	[Token(Token = "0x4006A39")]
	[FieldOffset(Offset = "0x508")]
	private GameObject Chest;

	// Token: 0x040072D6 RID: 29398
	[Token(Token = "0x4006A3A")]
	[FieldOffset(Offset = "0x510")]
	private GameObject Jaw;

	// Token: 0x040072D7 RID: 29399
	[Token(Token = "0x4006A3B")]
	[FieldOffset(Offset = "0x518")]
	private DragonSisterEffect FlameBreath;

	// Token: 0x040072D8 RID: 29400
	[Token(Token = "0x4006A3C")]
	[FieldOffset(Offset = "0x520")]
	private ParticleSystem OmenParticleSystem;

	// Token: 0x040072D9 RID: 29401
	[Token(Token = "0x4006A3D")]
	[FieldOffset(Offset = "0x528")]
	private int MeteorCounter;

	// Token: 0x040072DA RID: 29402
	[Token(Token = "0x4006A3E")]
	[FieldOffset(Offset = "0x52C")]
	private int MaxMeteor;
}
