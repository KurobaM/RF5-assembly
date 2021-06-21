using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000D3 RID: 211
[Token(Token = "0x20000A9")]
public class OnCollisionBoxCommand : ToolActionCommandBase
{
	// Token: 0x170000CF RID: 207
	// (get) Token: 0x060003FC RID: 1020 RVA: 0x000035B8 File Offset: 0x000017B8
	[Token(Token = "0x170000CC")]
	public float MotionPower
	{
		[Token(Token = "0x600033E")]
		[Address(RVA = "0x1F57980", Offset = "0x1F57A81", VA = "0x1F57980")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x170000D0 RID: 208
	// (get) Token: 0x060003FD RID: 1021 RVA: 0x000035D0 File Offset: 0x000017D0
	[Token(Token = "0x170000CD")]
	public override float Duration
	{
		[Token(Token = "0x600033F")]
		[Address(RVA = "0x1F579A0", Offset = "0x1F57AA1", VA = "0x1F579A0", Slot = "4")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x170000D1 RID: 209
	// (get) Token: 0x060003FE RID: 1022 RVA: 0x000035E8 File Offset: 0x000017E8
	[Token(Token = "0x170000CE")]
	public AttackType AttackType
	{
		[Token(Token = "0x6000340")]
		[Address(RVA = "0x1F579C0", Offset = "0x1F57AC1", VA = "0x1F579C0")]
		get
		{
			return AttackType.Physical;
		}
	}

	// Token: 0x170000D2 RID: 210
	// (get) Token: 0x060003FF RID: 1023 RVA: 0x00003600 File Offset: 0x00001800
	[Token(Token = "0x170000CF")]
	public EquipToolDamageAction DamageAction
	{
		[Token(Token = "0x6000341")]
		[Address(RVA = "0x1F57AB0", Offset = "0x1F57BB1", VA = "0x1F57AB0")]
		get
		{
			return EquipToolDamageAction.None;
		}
	}

	// Token: 0x170000D3 RID: 211
	// (get) Token: 0x06000400 RID: 1024 RVA: 0x00003618 File Offset: 0x00001818
	[Token(Token = "0x170000D0")]
	public EffectID EffectName
	{
		[Token(Token = "0x6000342")]
		[Address(RVA = "0x1F57BA0", Offset = "0x1F57CA1", VA = "0x1F57BA0")]
		get
		{
			return EffectID.EFFECT_EMPTY;
		}
	}

	// Token: 0x170000D4 RID: 212
	// (get) Token: 0x06000401 RID: 1025 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000D1")]
	public string HitStopName
	{
		[Token(Token = "0x6000343")]
		[Address(RVA = "0x1F57C40", Offset = "0x1F57D41", VA = "0x1F57C40")]
		get
		{
			return null;
		}
	}

	// Token: 0x170000D5 RID: 213
	// (get) Token: 0x06000402 RID: 1026 RVA: 0x00003630 File Offset: 0x00001830
	[Token(Token = "0x170000D2")]
	public Vector3 Offset
	{
		[Token(Token = "0x6000344")]
		[Address(RVA = "0x1F57C60", Offset = "0x1F57D61", VA = "0x1F57C60")]
		get
		{
			return default(Vector3);
		}
	}

	// Token: 0x170000D6 RID: 214
	// (get) Token: 0x06000403 RID: 1027 RVA: 0x00003648 File Offset: 0x00001848
	[Token(Token = "0x170000D3")]
	public Vector3 Size
	{
		[Token(Token = "0x6000345")]
		[Address(RVA = "0x1F57C80", Offset = "0x1F57D81", VA = "0x1F57C80")]
		get
		{
			return default(Vector3);
		}
	}

	// Token: 0x06000404 RID: 1028 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000346")]
	[Address(RVA = "0x1F57CA0", Offset = "0x1F57DA1", VA = "0x1F57CA0")]
	public OnCollisionBoxCommand(ActionCommandDataTable actionCommandData, AS_ToolController controller)
	{
	}

	// Token: 0x06000405 RID: 1029 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000347")]
	[Address(RVA = "0x1F57D00", Offset = "0x1F57E01", VA = "0x1F57D00", Slot = "8")]
	public override void DoAction()
	{
	}

	// Token: 0x06000406 RID: 1030 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000348")]
	[Address(RVA = "0x1F57D20", Offset = "0x1F57E21", VA = "0x1F57D20", Slot = "10")]
	public override void EndAction()
	{
	}
}
