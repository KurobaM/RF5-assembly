using System;
using Define;
using Il2CppDummyDll;

// Token: 0x020000D6 RID: 214
[Token(Token = "0x20000AC")]
public class OnCollisionToolCommand : ToolActionCommandBase
{
	// Token: 0x170000DF RID: 223
	// (get) Token: 0x06000412 RID: 1042 RVA: 0x00003708 File Offset: 0x00001908
	[Token(Token = "0x170000DC")]
	internal AttachHand AttachHand
	{
		[Token(Token = "0x6000354")]
		[Address(RVA = "0x1F58770", Offset = "0x1F58871", VA = "0x1F58770")]
		get
		{
			return AttachHand.Right;
		}
	}

	// Token: 0x170000E0 RID: 224
	// (get) Token: 0x06000413 RID: 1043 RVA: 0x00003720 File Offset: 0x00001920
	[Token(Token = "0x170000DD")]
	public float MotionPower
	{
		[Token(Token = "0x6000355")]
		[Address(RVA = "0x1F58780", Offset = "0x1F58881", VA = "0x1F58780")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x170000E1 RID: 225
	// (get) Token: 0x06000414 RID: 1044 RVA: 0x00003738 File Offset: 0x00001938
	[Token(Token = "0x170000DE")]
	public override float Duration
	{
		[Token(Token = "0x6000356")]
		[Address(RVA = "0x1F587A0", Offset = "0x1F588A1", VA = "0x1F587A0", Slot = "4")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x170000E2 RID: 226
	// (get) Token: 0x06000415 RID: 1045 RVA: 0x00003750 File Offset: 0x00001950
	[Token(Token = "0x170000DF")]
	public AttackType AttackType
	{
		[Token(Token = "0x6000357")]
		[Address(RVA = "0x1F587C0", Offset = "0x1F588C1", VA = "0x1F587C0")]
		get
		{
			return AttackType.Physical;
		}
	}

	// Token: 0x170000E3 RID: 227
	// (get) Token: 0x06000416 RID: 1046 RVA: 0x00003768 File Offset: 0x00001968
	[Token(Token = "0x170000E0")]
	public EquipToolDamageAction DamageAction
	{
		[Token(Token = "0x6000358")]
		[Address(RVA = "0x1F588B0", Offset = "0x1F589B1", VA = "0x1F588B0")]
		get
		{
			return EquipToolDamageAction.None;
		}
	}

	// Token: 0x170000E4 RID: 228
	// (get) Token: 0x06000417 RID: 1047 RVA: 0x00003780 File Offset: 0x00001980
	[Token(Token = "0x170000E1")]
	public EffectID EffectName
	{
		[Token(Token = "0x6000359")]
		[Address(RVA = "0x1F589A0", Offset = "0x1F58AA1", VA = "0x1F589A0")]
		get
		{
			return EffectID.EFFECT_EMPTY;
		}
	}

	// Token: 0x170000E5 RID: 229
	// (get) Token: 0x06000418 RID: 1048 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000E2")]
	public string HitStopName
	{
		[Token(Token = "0x600035A")]
		[Address(RVA = "0x1F58A40", Offset = "0x1F58B41", VA = "0x1F58A40")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000419 RID: 1049 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600035B")]
	[Address(RVA = "0x1F58A60", Offset = "0x1F58B61", VA = "0x1F58A60")]
	public OnCollisionToolCommand(ActionCommandDataTable actionCommandData, AS_ToolController controller)
	{
	}

	// Token: 0x0600041A RID: 1050 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600035C")]
	[Address(RVA = "0x1F58AC0", Offset = "0x1F58BC1", VA = "0x1F58AC0", Slot = "8")]
	public override void DoAction()
	{
	}

	// Token: 0x0600041B RID: 1051 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600035D")]
	[Address(RVA = "0x1F58AE0", Offset = "0x1F58BE1", VA = "0x1F58AE0", Slot = "10")]
	public override void EndAction()
	{
	}
}
