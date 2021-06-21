using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000D4 RID: 212
[Token(Token = "0x20000AA")]
public class OnCollisionSphereCommand : ToolActionCommandBase
{
	// Token: 0x170000D7 RID: 215
	// (get) Token: 0x06000407 RID: 1031 RVA: 0x00003660 File Offset: 0x00001860
	[Token(Token = "0x170000D4")]
	public float MotionPower
	{
		[Token(Token = "0x6000349")]
		[Address(RVA = "0x1F583D0", Offset = "0x1F584D1", VA = "0x1F583D0")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x170000D8 RID: 216
	// (get) Token: 0x06000408 RID: 1032 RVA: 0x00003678 File Offset: 0x00001878
	[Token(Token = "0x170000D5")]
	public override float Duration
	{
		[Token(Token = "0x600034A")]
		[Address(RVA = "0x1F583F0", Offset = "0x1F584F1", VA = "0x1F583F0", Slot = "4")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x170000D9 RID: 217
	// (get) Token: 0x06000409 RID: 1033 RVA: 0x00003690 File Offset: 0x00001890
	[Token(Token = "0x170000D6")]
	public AttackType AttackType
	{
		[Token(Token = "0x600034B")]
		[Address(RVA = "0x1F58410", Offset = "0x1F58511", VA = "0x1F58410")]
		get
		{
			return AttackType.Physical;
		}
	}

	// Token: 0x170000DA RID: 218
	// (get) Token: 0x0600040A RID: 1034 RVA: 0x000036A8 File Offset: 0x000018A8
	[Token(Token = "0x170000D7")]
	public EquipToolDamageAction DamageAction
	{
		[Token(Token = "0x600034C")]
		[Address(RVA = "0x1F58500", Offset = "0x1F58601", VA = "0x1F58500")]
		get
		{
			return EquipToolDamageAction.None;
		}
	}

	// Token: 0x170000DB RID: 219
	// (get) Token: 0x0600040B RID: 1035 RVA: 0x000036C0 File Offset: 0x000018C0
	[Token(Token = "0x170000D8")]
	public EffectID EffectName
	{
		[Token(Token = "0x600034D")]
		[Address(RVA = "0x1F585D0", Offset = "0x1F586D1", VA = "0x1F585D0")]
		get
		{
			return EffectID.EFFECT_EMPTY;
		}
	}

	// Token: 0x170000DC RID: 220
	// (get) Token: 0x0600040C RID: 1036 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000D9")]
	public string HitStopName
	{
		[Token(Token = "0x600034E")]
		[Address(RVA = "0x1F58670", Offset = "0x1F58771", VA = "0x1F58670")]
		get
		{
			return null;
		}
	}

	// Token: 0x170000DD RID: 221
	// (get) Token: 0x0600040D RID: 1037 RVA: 0x000036D8 File Offset: 0x000018D8
	[Token(Token = "0x170000DA")]
	public Vector3 Offset
	{
		[Token(Token = "0x600034F")]
		[Address(RVA = "0x1F58690", Offset = "0x1F58791", VA = "0x1F58690")]
		get
		{
			return default(Vector3);
		}
	}

	// Token: 0x170000DE RID: 222
	// (get) Token: 0x0600040E RID: 1038 RVA: 0x000036F0 File Offset: 0x000018F0
	[Token(Token = "0x170000DB")]
	public float Radius
	{
		[Token(Token = "0x6000350")]
		[Address(RVA = "0x1F586B0", Offset = "0x1F587B1", VA = "0x1F586B0")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x0600040F RID: 1039 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000351")]
	[Address(RVA = "0x1F586D0", Offset = "0x1F587D1", VA = "0x1F586D0")]
	public OnCollisionSphereCommand(ActionCommandDataTable actionCommandData, AS_ToolController controller)
	{
	}

	// Token: 0x06000410 RID: 1040 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000352")]
	[Address(RVA = "0x1F58730", Offset = "0x1F58831", VA = "0x1F58730", Slot = "8")]
	public override void DoAction()
	{
	}

	// Token: 0x06000411 RID: 1041 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000353")]
	[Address(RVA = "0x1F58750", Offset = "0x1F58851", VA = "0x1F58750", Slot = "10")]
	public override void EndAction()
	{
	}
}
