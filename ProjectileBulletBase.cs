using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020008FE RID: 2302
[Token(Token = "0x2000608")]
public class ProjectileBulletBase : MonoBehaviour
{
	// Token: 0x170008B8 RID: 2232
	// (get) Token: 0x06003C69 RID: 15465 RVA: 0x00015168 File Offset: 0x00013368
	// (set) Token: 0x06003C6A RID: 15466 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170006F9")]
	public bool IsStartBehavior
	{
		[Token(Token = "0x60032BF")]
		[Address(RVA = "0x216DF80", Offset = "0x216E081", VA = "0x216DF80")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6AF0", Offset = "0x1A6BF1")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60032C0")]
		[Address(RVA = "0x216DF90", Offset = "0x216E091", VA = "0x216DF90")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6B00", Offset = "0x1A6C01")]
		private set
		{
		}
	}

	// Token: 0x170008B9 RID: 2233
	// (get) Token: 0x06003C6B RID: 15467 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170006FA")]
	public Collider Collider
	{
		[Token(Token = "0x60032C1")]
		[Address(RVA = "0x216DFA0", Offset = "0x216E0A1", VA = "0x216DFA0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06003C6C RID: 15468 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60032C2")]
	[Address(RVA = "0x216E050", Offset = "0x216E151", VA = "0x216E050")]
	private void Awake()
	{
	}

	// Token: 0x06003C6D RID: 15469 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60032C3")]
	[Address(RVA = "0x216E0D0", Offset = "0x216E1D1", VA = "0x216E0D0", Slot = "4")]
	public virtual void Setup()
	{
	}

	// Token: 0x06003C6E RID: 15470 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60032C4")]
	[Address(RVA = "0x216E270", Offset = "0x216E371", VA = "0x216E270", Slot = "5")]
	protected virtual void InitializeDirection()
	{
	}

	// Token: 0x06003C6F RID: 15471 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60032C5")]
	[Address(RVA = "0x216E5D0", Offset = "0x216E6D1", VA = "0x216E5D0")]
	public void SetupBehavior(ProjectileBulletBehaviorBase projectileBulletBehaviorBase)
	{
	}

	// Token: 0x06003C70 RID: 15472 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60032C6")]
	[Address(RVA = "0x216E650", Offset = "0x216E751", VA = "0x216E650")]
	public void StartBehavior()
	{
	}

	// Token: 0x06003C71 RID: 15473 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60032C7")]
	[Address(RVA = "0x216E670", Offset = "0x216E771", VA = "0x216E670")]
	public void SetColliderEnable(bool enable)
	{
	}

	// Token: 0x06003C72 RID: 15474 RVA: 0x00015180 File Offset: 0x00013380
	[Token(Token = "0x60032C8")]
	[Address(RVA = "0x216E820", Offset = "0x216E921", VA = "0x216E820")]
	private bool IsTarget(CharacterBase characterBase)
	{
		return default(bool);
	}

	// Token: 0x06003C73 RID: 15475 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60032C9")]
	[Address(RVA = "0x216E9C0", Offset = "0x216EAC1", VA = "0x216E9C0")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x06003C74 RID: 15476 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60032CA")]
	[Address(RVA = "0x216F160", Offset = "0x216F261", VA = "0x216F160")]
	private void Update()
	{
	}

	// Token: 0x06003C75 RID: 15477 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60032CB")]
	[Address(RVA = "0x216F210", Offset = "0x216F311", VA = "0x216F210")]
	public void SetClearHitListTime(float time)
	{
	}

	// Token: 0x06003C76 RID: 15478 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60032CC")]
	[Address(RVA = "0x216E200", Offset = "0x216E301", VA = "0x216E200")]
	public void ClearHitList()
	{
	}

	// Token: 0x06003C77 RID: 15479 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60032CD")]
	[Address(RVA = "0x216F220", Offset = "0x216F321", VA = "0x216F220")]
	private void UpdateClearHitList()
	{
	}

	// Token: 0x06003C78 RID: 15480 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60032CE")]
	[Address(RVA = "0x216F2D0", Offset = "0x216F3D1", VA = "0x216F2D0", Slot = "6")]
	protected virtual void UpdateBehavior()
	{
	}

	// Token: 0x06003C79 RID: 15481 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60032CF")]
	[Address(RVA = "0x216F4E0", Offset = "0x216F5E1", VA = "0x216F4E0")]
	public void SetRotationVelocity()
	{
	}

	// Token: 0x06003C7A RID: 15482 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60032D0")]
	[Address(RVA = "0x216F5C0", Offset = "0x216F6C1", VA = "0x216F5C0")]
	public void SetRotationDirection()
	{
	}

	// Token: 0x06003C7B RID: 15483 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60032D1")]
	[Address(RVA = "0x216F6A0", Offset = "0x216F7A1", VA = "0x216F6A0", Slot = "7")]
	protected virtual void UpdateVelocity()
	{
	}

	// Token: 0x06003C7C RID: 15484 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60032D2")]
	[Address(RVA = "0x216F740", Offset = "0x216F841", VA = "0x216F740", Slot = "8")]
	protected virtual void UpdatePosition()
	{
	}

	// Token: 0x06003C7D RID: 15485 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60032D3")]
	[Address(RVA = "0x216F840", Offset = "0x216F941", VA = "0x216F840", Slot = "9")]
	protected virtual void UpdateLifeTime()
	{
	}

	// Token: 0x06003C7E RID: 15486 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60032D4")]
	[Address(RVA = "0x216F470", Offset = "0x216F571", VA = "0x216F470")]
	protected void UpdateAddGravityVelocity()
	{
	}

	// Token: 0x06003C7F RID: 15487 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60032D5")]
	[Address(RVA = "0x216F8F0", Offset = "0x216F9F1", VA = "0x216F8F0")]
	protected void AddGravityAccel()
	{
	}

	// Token: 0x06003C80 RID: 15488 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60032D6")]
	[Address(RVA = "0x216F940", Offset = "0x216FA41", VA = "0x216F940")]
	private void OnDrawGizmos()
	{
	}

	// Token: 0x06003C81 RID: 15489 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60032D7")]
	[Address(RVA = "0x216FA60", Offset = "0x216FB61", VA = "0x216FA60")]
	public ProjectileBulletBase()
	{
	}

	// Token: 0x04007ED8 RID: 32472
	[Token(Token = "0x4007283")]
	private const float GravityAccel = -9.8f;

	// Token: 0x04007ED9 RID: 32473
	[Token(Token = "0x4007284")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public bool HitAndDestory;

	// Token: 0x04007EDA RID: 32474
	[Token(Token = "0x4007285")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "HideInInspector", RVA = "0x16EDD0", Offset = "0x16EED1")]
	public CharacterBase Owner;

	// Token: 0x04007EDB RID: 32475
	[Token(Token = "0x4007286")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "HideInInspector", RVA = "0x16EDE0", Offset = "0x16EEE1")]
	public DamageInfo DamageInfo;

	// Token: 0x04007EDC RID: 32476
	[Token(Token = "0x4007287")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	public EffectID HitEffectName;

	// Token: 0x04007EDD RID: 32477
	[Token(Token = "0x4007288")]
	[FieldOffset(Offset = "0xAC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16EE00", Offset = "0x16EF01")]
	private bool <IsStartBehavior>k__BackingField;

	// Token: 0x04007EDE RID: 32478
	[Token(Token = "0x4007289")]
	[FieldOffset(Offset = "0xB0")]
	public Vector3 Velocity;

	// Token: 0x04007EDF RID: 32479
	[Token(Token = "0x400728A")]
	[FieldOffset(Offset = "0xBC")]
	public Vector3 Direction;

	// Token: 0x04007EE0 RID: 32480
	[Token(Token = "0x400728B")]
	[FieldOffset(Offset = "0xC8")]
	public float Speed;

	// Token: 0x04007EE1 RID: 32481
	[Token(Token = "0x400728C")]
	[FieldOffset(Offset = "0xCC")]
	public float LifeTime;

	// Token: 0x04007EE2 RID: 32482
	[Token(Token = "0x400728D")]
	[FieldOffset(Offset = "0xD0")]
	public bool UseLifeTime;

	// Token: 0x04007EE3 RID: 32483
	[Token(Token = "0x400728E")]
	[FieldOffset(Offset = "0xD1")]
	public bool IsRandomDirection;

	// Token: 0x04007EE4 RID: 32484
	[Token(Token = "0x400728F")]
	[FieldOffset(Offset = "0xD4")]
	public Vector2 RandomAngle;

	// Token: 0x04007EE5 RID: 32485
	[Token(Token = "0x4007290")]
	[FieldOffset(Offset = "0xDC")]
	public bool UseGravity;

	// Token: 0x04007EE6 RID: 32486
	[Token(Token = "0x4007291")]
	[FieldOffset(Offset = "0xE0")]
	private Collider _Collider;

	// Token: 0x04007EE7 RID: 32487
	[Token(Token = "0x4007292")]
	[FieldOffset(Offset = "0xE8")]
	public ProjectileBulletBehaviorBase ProjectileBulletBehaviorBase;

	// Token: 0x04007EE8 RID: 32488
	[Token(Token = "0x4007293")]
	[FieldOffset(Offset = "0xF0")]
	public UnityEventMonsterActionHit OnHitEvent;

	// Token: 0x04007EE9 RID: 32489
	[Token(Token = "0x4007294")]
	[FieldOffset(Offset = "0xF8")]
	public UnityEventCollider OnHitGroundEvent;

	// Token: 0x04007EEA RID: 32490
	[Token(Token = "0x4007295")]
	[FieldOffset(Offset = "0x100")]
	private List<CharacterBase> HitList;

	// Token: 0x04007EEB RID: 32491
	[Token(Token = "0x4007296")]
	[FieldOffset(Offset = "0x108")]
	private float ClearHitListTime;

	// Token: 0x04007EEC RID: 32492
	[Token(Token = "0x4007297")]
	[FieldOffset(Offset = "0x10C")]
	private float ClearHitListTimer;
}
