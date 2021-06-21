using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200006B RID: 107
[Token(Token = "0x200004E")]
public class EffectCommand : ActionCommandBase
{
	// Token: 0x1700003F RID: 63
	// (get) Token: 0x060001EE RID: 494 RVA: 0x00002898 File Offset: 0x00000A98
	[Token(Token = "0x1700003C")]
	private EffectID EffectID
	{
		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x22AB560", Offset = "0x22AB661", VA = "0x22AB560")]
		get
		{
			return EffectID.EFFECT_EMPTY;
		}
	}

	// Token: 0x17000040 RID: 64
	// (get) Token: 0x060001EF RID: 495 RVA: 0x000028B0 File Offset: 0x00000AB0
	[Token(Token = "0x1700003D")]
	public bool IsAutoDestroy
	{
		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x22AB5E0", Offset = "0x22AB6E1", VA = "0x22AB5E0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000041 RID: 65
	// (get) Token: 0x060001F0 RID: 496 RVA: 0x000028C8 File Offset: 0x00000AC8
	[Token(Token = "0x1700003E")]
	public bool IsAttach
	{
		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x22AB600", Offset = "0x22AB701", VA = "0x22AB600")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060001F1 RID: 497 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001AE")]
	[Address(RVA = "0x22AB620", Offset = "0x22AB721", VA = "0x22AB620")]
	public EffectCommand(ActionCommandDataTable actionCommandData, ActionScriptControllerBase controller)
	{
	}

	// Token: 0x17000042 RID: 66
	// (get) Token: 0x060001F2 RID: 498 RVA: 0x000028E0 File Offset: 0x00000AE0
	[Token(Token = "0x1700003F")]
	public override float Duration
	{
		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x22AB720", Offset = "0x22AB821", VA = "0x22AB720", Slot = "4")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000043 RID: 67
	// (get) Token: 0x060001F3 RID: 499 RVA: 0x000028F8 File Offset: 0x00000AF8
	[Token(Token = "0x17000040")]
	public bool IsDestroyImmediate
	{
		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x22AB740", Offset = "0x22AB841", VA = "0x22AB740")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000044 RID: 68
	// (get) Token: 0x060001F4 RID: 500 RVA: 0x00002910 File Offset: 0x00000B10
	[Token(Token = "0x17000041")]
	public bool IsAutoVelocity
	{
		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x22AB760", Offset = "0x22AB861", VA = "0x22AB760")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000045 RID: 69
	// (get) Token: 0x060001F5 RID: 501 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060001F6 RID: 502 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000042")]
	private ParticleDestroy ParticleDestroy
	{
		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x22AB790", Offset = "0x22AB891", VA = "0x22AB790")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x199F60", Offset = "0x19A061")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x22AB7A0", Offset = "0x22AB8A1", VA = "0x22AB7A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x199F70", Offset = "0x19A071")]
		set
		{
		}
	}

	// Token: 0x17000046 RID: 70
	// (get) Token: 0x060001F7 RID: 503 RVA: 0x00002928 File Offset: 0x00000B28
	// (set) Token: 0x060001F8 RID: 504 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000043")]
	private float FinishTime
	{
		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x22AB7B0", Offset = "0x22AB8B1", VA = "0x22AB7B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x199F80", Offset = "0x19A081")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x22AB7C0", Offset = "0x22AB8C1", VA = "0x22AB7C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x199F90", Offset = "0x19A091")]
		set
		{
		}
	}

	// Token: 0x17000047 RID: 71
	// (get) Token: 0x060001F9 RID: 505 RVA: 0x00002940 File Offset: 0x00000B40
	// (set) Token: 0x060001FA RID: 506 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000044")]
	private Vector3 OffsetPos
	{
		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x22AB7D0", Offset = "0x22AB8D1", VA = "0x22AB7D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x199FA0", Offset = "0x19A0A1")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x22AB7E0", Offset = "0x22AB8E1", VA = "0x22AB7E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x199FB0", Offset = "0x19A0B1")]
		set
		{
		}
	}

	// Token: 0x17000048 RID: 72
	// (get) Token: 0x060001FB RID: 507 RVA: 0x00002958 File Offset: 0x00000B58
	// (set) Token: 0x060001FC RID: 508 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000045")]
	private Vector3 OffsetRote
	{
		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x22AB7F0", Offset = "0x22AB8F1", VA = "0x22AB7F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x199FC0", Offset = "0x19A0C1")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x22AB800", Offset = "0x22AB901", VA = "0x22AB800")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x199FD0", Offset = "0x19A0D1")]
		set
		{
		}
	}

	// Token: 0x17000049 RID: 73
	// (get) Token: 0x060001FD RID: 509 RVA: 0x00002970 File Offset: 0x00000B70
	// (set) Token: 0x060001FE RID: 510 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000046")]
	private Vector3 OffsetScale
	{
		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x22AB810", Offset = "0x22AB911", VA = "0x22AB810")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x199FE0", Offset = "0x19A0E1")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x22AB820", Offset = "0x22AB921", VA = "0x22AB820")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x199FF0", Offset = "0x19A0F1")]
		set
		{
		}
	}

	// Token: 0x1700004A RID: 74
	// (get) Token: 0x060001FF RID: 511 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000200 RID: 512 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000047")]
	private Transform TargetTransform
	{
		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x22AB830", Offset = "0x22AB931", VA = "0x22AB830")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A000", Offset = "0x19A101")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x22AB840", Offset = "0x22AB941", VA = "0x22AB840")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A010", Offset = "0x19A111")]
		set
		{
		}
	}

	// Token: 0x06000201 RID: 513 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001BE")]
	[Address(RVA = "0x22AB850", Offset = "0x22AB951", VA = "0x22AB850", Slot = "8")]
	public override void DoAction()
	{
	}

	// Token: 0x06000202 RID: 514 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001BF")]
	[Address(RVA = "0x22ABB50", Offset = "0x22ABC51", VA = "0x22ABB50", Slot = "10")]
	public override void EndAction()
	{
	}

	// Token: 0x06000203 RID: 515 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001C0")]
	[Address(RVA = "0x22ABBA0", Offset = "0x22ABCA1", VA = "0x22ABBA0", Slot = "11")]
	public override void ActionFinal()
	{
	}

	// Token: 0x06000204 RID: 516 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001C1")]
	[Address(RVA = "0x22ABCE0", Offset = "0x22ABDE1", VA = "0x22ABCE0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A020", Offset = "0x19A121")]
	private void <DoAction>b__39_0(ParticleSystem prefab)
	{
	}

	// Token: 0x04000184 RID: 388
	[Token(Token = "0x4000123")]
	[FieldOffset(Offset = "0x80")]
	private EffectID _EffectID;

	// Token: 0x04000185 RID: 389
	[Token(Token = "0x4000124")]
	[FieldOffset(Offset = "0x84")]
	private bool IsParse;

	// Token: 0x04000186 RID: 390
	[Token(Token = "0x4000125")]
	[FieldOffset(Offset = "0x88")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15B640", Offset = "0x15B741")]
	private ParticleDestroy <ParticleDestroy>k__BackingField;

	// Token: 0x04000187 RID: 391
	[Token(Token = "0x4000126")]
	[FieldOffset(Offset = "0x90")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15B650", Offset = "0x15B751")]
	private float <FinishTime>k__BackingField;

	// Token: 0x04000188 RID: 392
	[Token(Token = "0x4000127")]
	[FieldOffset(Offset = "0x94")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15B660", Offset = "0x15B761")]
	private Vector3 <OffsetPos>k__BackingField;

	// Token: 0x04000189 RID: 393
	[Token(Token = "0x4000128")]
	[FieldOffset(Offset = "0xA0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15B670", Offset = "0x15B771")]
	private Vector3 <OffsetRote>k__BackingField;

	// Token: 0x0400018A RID: 394
	[Token(Token = "0x4000129")]
	[FieldOffset(Offset = "0xAC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15B680", Offset = "0x15B781")]
	private Vector3 <OffsetScale>k__BackingField;

	// Token: 0x0400018B RID: 395
	[Token(Token = "0x400012A")]
	[FieldOffset(Offset = "0xB8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15B690", Offset = "0x15B791")]
	private Transform <TargetTransform>k__BackingField;
}
