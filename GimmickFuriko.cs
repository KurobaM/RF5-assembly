using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020005DA RID: 1498
[Token(Token = "0x2000438")]
public class GimmickFuriko : GimmickBase
{
	// Token: 0x170005F5 RID: 1525
	// (get) Token: 0x060024D2 RID: 9426 RVA: 0x0000ED30 File Offset: 0x0000CF30
	// (set) Token: 0x060024D3 RID: 9427 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170004C3")]
	private bool Direction
	{
		[Token(Token = "0x6001F0C")]
		[Address(RVA = "0x1FE33C0", Offset = "0x1FE34C1", VA = "0x1FE33C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1480", Offset = "0x1A1581")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001F0D")]
		[Address(RVA = "0x1FE33D0", Offset = "0x1FE34D1", VA = "0x1FE33D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1490", Offset = "0x1A1591")]
		set
		{
		}
	}

	// Token: 0x170005F6 RID: 1526
	// (get) Token: 0x060024D4 RID: 9428 RVA: 0x0000ED48 File Offset: 0x0000CF48
	// (set) Token: 0x060024D5 RID: 9429 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170004C4")]
	private float ElapsedTime
	{
		[Token(Token = "0x6001F0E")]
		[Address(RVA = "0x1FE33E0", Offset = "0x1FE34E1", VA = "0x1FE33E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A14A0", Offset = "0x1A15A1")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6001F0F")]
		[Address(RVA = "0x1FE33F0", Offset = "0x1FE34F1", VA = "0x1FE33F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A14B0", Offset = "0x1A15B1")]
		set
		{
		}
	}

	// Token: 0x170005F7 RID: 1527
	// (get) Token: 0x060024D6 RID: 9430 RVA: 0x0000ED60 File Offset: 0x0000CF60
	// (set) Token: 0x060024D7 RID: 9431 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170004C5")]
	private float PrevT
	{
		[Token(Token = "0x6001F10")]
		[Address(RVA = "0x1FE3400", Offset = "0x1FE3501", VA = "0x1FE3400")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A14C0", Offset = "0x1A15C1")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6001F11")]
		[Address(RVA = "0x1FE3410", Offset = "0x1FE3511", VA = "0x1FE3410")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A14D0", Offset = "0x1A15D1")]
		set
		{
		}
	}

	// Token: 0x170005F8 RID: 1528
	// (get) Token: 0x060024D8 RID: 9432 RVA: 0x0000ED78 File Offset: 0x0000CF78
	// (set) Token: 0x060024D9 RID: 9433 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170004C6")]
	private Vector3 Velocity
	{
		[Token(Token = "0x6001F12")]
		[Address(RVA = "0x1FE3420", Offset = "0x1FE3521", VA = "0x1FE3420")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A14E0", Offset = "0x1A15E1")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6001F13")]
		[Address(RVA = "0x1FE3430", Offset = "0x1FE3531", VA = "0x1FE3430")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A14F0", Offset = "0x1A15F1")]
		set
		{
		}
	}

	// Token: 0x170005F9 RID: 1529
	// (get) Token: 0x060024DA RID: 9434 RVA: 0x0000ED90 File Offset: 0x0000CF90
	// (set) Token: 0x060024DB RID: 9435 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170004C7")]
	private Vector3 PrevPos
	{
		[Token(Token = "0x6001F14")]
		[Address(RVA = "0x1FE3440", Offset = "0x1FE3541", VA = "0x1FE3440")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1500", Offset = "0x1A1601")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6001F15")]
		[Address(RVA = "0x1FE3450", Offset = "0x1FE3551", VA = "0x1FE3450")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1510", Offset = "0x1A1611")]
		set
		{
		}
	}

	// Token: 0x060024DC RID: 9436 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F16")]
	[Address(RVA = "0x1FE3460", Offset = "0x1FE3561", VA = "0x1FE3460", Slot = "6")]
	protected override void Start()
	{
	}

	// Token: 0x060024DD RID: 9437 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F17")]
	[Address(RVA = "0x1FE3620", Offset = "0x1FE3721", VA = "0x1FE3620")]
	private void SetElapsedTimeAndUpdateRotate()
	{
	}

	// Token: 0x060024DE RID: 9438 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F18")]
	[Address(RVA = "0x1FE3900", Offset = "0x1FE3A01", VA = "0x1FE3900")]
	private void FixedUpdate()
	{
	}

	// Token: 0x060024DF RID: 9439 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F19")]
	[Address(RVA = "0x1FE3AE0", Offset = "0x1FE3BE1", VA = "0x1FE3AE0")]
	private void OnDrawGizmos()
	{
	}

	// Token: 0x060024E0 RID: 9440 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F1A")]
	[Address(RVA = "0x1FE3E60", Offset = "0x1FE3F61", VA = "0x1FE3E60")]
	private void OnDamageEnter(Collider fromCollider, Collider toCollider)
	{
	}

	// Token: 0x060024E1 RID: 9441 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F1B")]
	[Address(RVA = "0x1FE41F0", Offset = "0x1FE42F1", VA = "0x1FE41F0")]
	public GimmickFuriko()
	{
	}

	// Token: 0x04006C27 RID: 27687
	[Token(Token = "0x400656A")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float Interval;

	// Token: 0x04006C28 RID: 27688
	[Token(Token = "0x400656B")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	[Attribute(Name = "RangeAttribute", RVA = "0x167270", Offset = "0x167371")]
	private float MaxAngle;

	// Token: 0x04006C29 RID: 27689
	[Token(Token = "0x400656C")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private bool InitialDirection;

	// Token: 0x04006C2A RID: 27690
	[Token(Token = "0x400656D")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	[Attribute(Name = "RangeAttribute", RVA = "0x1672D0", Offset = "0x1673D1")]
	private float InitialAlpha;

	// Token: 0x04006C2B RID: 27691
	[Token(Token = "0x400656E")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float Damage;

	// Token: 0x04006C2C RID: 27692
	[Token(Token = "0x400656F")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	[Attribute(Name = "RangeAttribute", RVA = "0x167320", Offset = "0x167421")]
	private float KnockBackPower;

	// Token: 0x04006C2D RID: 27693
	[Token(Token = "0x4006570")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private AnimationCurve AnimationCurve;

	// Token: 0x04006C2E RID: 27694
	[Token(Token = "0x4006571")]
	[FieldOffset(Offset = "0x40")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x167370", Offset = "0x167471")]
	private bool <Direction>k__BackingField;

	// Token: 0x04006C2F RID: 27695
	[Token(Token = "0x4006572")]
	[FieldOffset(Offset = "0x44")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x167380", Offset = "0x167481")]
	private float <ElapsedTime>k__BackingField;

	// Token: 0x04006C30 RID: 27696
	[Token(Token = "0x4006573")]
	[FieldOffset(Offset = "0x48")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x167390", Offset = "0x167491")]
	private float <PrevT>k__BackingField;

	// Token: 0x04006C31 RID: 27697
	[Token(Token = "0x4006574")]
	[FieldOffset(Offset = "0x50")]
	private Transform Model;

	// Token: 0x04006C32 RID: 27698
	[Token(Token = "0x4006575")]
	[FieldOffset(Offset = "0x58")]
	private SimpleTriggerEventDispatcher SimpleTriggerEventDispatcher;

	// Token: 0x04006C33 RID: 27699
	[Token(Token = "0x4006576")]
	[FieldOffset(Offset = "0x60")]
	private Collider HitCollition;

	// Token: 0x04006C34 RID: 27700
	[Token(Token = "0x4006577")]
	[FieldOffset(Offset = "0x68")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1673A0", Offset = "0x1674A1")]
	private Vector3 <Velocity>k__BackingField;

	// Token: 0x04006C35 RID: 27701
	[Token(Token = "0x4006578")]
	[FieldOffset(Offset = "0x74")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1673B0", Offset = "0x1674B1")]
	private Vector3 <PrevPos>k__BackingField;
}
