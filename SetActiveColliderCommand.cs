using System;
using Define;
using Il2CppDummyDll;

// Token: 0x020000A6 RID: 166
[Token(Token = "0x2000080")]
public class SetActiveColliderCommand : MonsterActionCommandBase
{
	// Token: 0x1700008C RID: 140
	// (get) Token: 0x06000334 RID: 820 RVA: 0x00003030 File Offset: 0x00001230
	[Token(Token = "0x17000089")]
	private EffectID EffectName
	{
		[Token(Token = "0x600027C")]
		[Address(RVA = "0x1E317E0", Offset = "0x1E318E1", VA = "0x1E317E0")]
		get
		{
			return EffectID.EFFECT_EMPTY;
		}
	}

	// Token: 0x06000335 RID: 821 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600027D")]
	[Address(RVA = "0x1E31880", Offset = "0x1E31981", VA = "0x1E31880")]
	public SetActiveColliderCommand(ActionCommandDataTable actionCommandData, MonsterActionScriptsController controller)
	{
	}

	// Token: 0x1700008D RID: 141
	// (get) Token: 0x06000336 RID: 822 RVA: 0x00003048 File Offset: 0x00001248
	[Token(Token = "0x1700008A")]
	public override float Duration
	{
		[Token(Token = "0x600027E")]
		[Address(RVA = "0x1E318E0", Offset = "0x1E319E1", VA = "0x1E318E0", Slot = "4")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x06000337 RID: 823 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600027F")]
	[Address(RVA = "0x1E31900", Offset = "0x1E31A01", VA = "0x1E31900", Slot = "8")]
	public override void DoAction()
	{
	}

	// Token: 0x06000338 RID: 824 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000280")]
	[Address(RVA = "0x1E31AB0", Offset = "0x1E31BB1", VA = "0x1E31AB0", Slot = "10")]
	public override void EndAction()
	{
	}

	// Token: 0x06000339 RID: 825 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000281")]
	[Address(RVA = "0x1E31AC0", Offset = "0x1E31BC1", VA = "0x1E31AC0", Slot = "11")]
	public override void ActionFinal()
	{
	}

	// Token: 0x0600033A RID: 826 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000282")]
	[Address(RVA = "0x1E31BE0", Offset = "0x1E31CE1", VA = "0x1E31BE0")]
	private void StopCollision()
	{
	}

	// Token: 0x04000225 RID: 549
	[Token(Token = "0x40001B8")]
	[FieldOffset(Offset = "0x88")]
	private AttackCollider AttackCollider;
}
