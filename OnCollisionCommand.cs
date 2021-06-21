using System;
using Define;
using Il2CppDummyDll;

// Token: 0x020000B0 RID: 176
[Token(Token = "0x2000088")]
public class OnCollisionCommand : MonsterProjectileActionCommandBase
{
	// Token: 0x17000098 RID: 152
	// (get) Token: 0x06000367 RID: 871 RVA: 0x00003138 File Offset: 0x00001338
	[Token(Token = "0x17000095")]
	public override float Duration
	{
		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x1F57D40", Offset = "0x1F57E41", VA = "0x1F57D40", Slot = "4")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000099 RID: 153
	// (get) Token: 0x06000368 RID: 872 RVA: 0x00003150 File Offset: 0x00001350
	[Token(Token = "0x17000096")]
	public bool IsEndHit
	{
		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x1F57D60", Offset = "0x1F57E61", VA = "0x1F57D60")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700009A RID: 154
	// (get) Token: 0x06000369 RID: 873 RVA: 0x00003168 File Offset: 0x00001368
	[Token(Token = "0x17000097")]
	public bool IsEndHitOther
	{
		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x1F57D80", Offset = "0x1F57E81", VA = "0x1F57D80")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700009B RID: 155
	// (get) Token: 0x0600036A RID: 874 RVA: 0x00003180 File Offset: 0x00001380
	[Token(Token = "0x17000098")]
	public EffectID EffectName
	{
		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x1F57DA0", Offset = "0x1F57EA1", VA = "0x1F57DA0")]
		get
		{
			return EffectID.EFFECT_EMPTY;
		}
	}

	// Token: 0x0600036B RID: 875 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002B1")]
	[Address(RVA = "0x1F57E40", Offset = "0x1F57F41", VA = "0x1F57E40")]
	public OnCollisionCommand(ActionCommandDataTable actionCommandData, MonsterProjectileActionScriptsController controller)
	{
	}

	// Token: 0x0600036C RID: 876 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002B2")]
	[Address(RVA = "0x1F57EA0", Offset = "0x1F57FA1", VA = "0x1F57EA0", Slot = "8")]
	public override void DoAction()
	{
	}

	// Token: 0x0600036D RID: 877 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002B3")]
	[Address(RVA = "0x1F581A0", Offset = "0x1F582A1", VA = "0x1F581A0", Slot = "10")]
	public override void EndAction()
	{
	}

	// Token: 0x0600036E RID: 878 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002B4")]
	[Address(RVA = "0x1F581B0", Offset = "0x1F582B1", VA = "0x1F581B0", Slot = "11")]
	public override void ActionFinal()
	{
	}

	// Token: 0x0600036F RID: 879 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002B5")]
	[Address(RVA = "0x1F58370", Offset = "0x1F58471", VA = "0x1F58370")]
	private void OnHitCollision(CharacterBase characterBase, MonsterProjectileActionScriptsController controller, int index)
	{
	}

	// Token: 0x06000370 RID: 880 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002B6")]
	[Address(RVA = "0x1F583A0", Offset = "0x1F584A1", VA = "0x1F583A0")]
	private void OnHitCollisionGround(MonsterProjectileActionScriptsController controller, int index)
	{
	}
}
