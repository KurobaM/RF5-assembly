using System;
using Il2CppDummyDll;
using Loader;
using UnityEngine;

// Token: 0x020005DF RID: 1503
[Token(Token = "0x200043C")]
public class GimmickMagicArrow : GimmickBase
{
	// Token: 0x060024F2 RID: 9458 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F2C")]
	[Address(RVA = "0x1FE5210", Offset = "0x1FE5311", VA = "0x1FE5210", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	// Token: 0x060024F3 RID: 9459 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F2D")]
	[Address(RVA = "0x1FE52E0", Offset = "0x1FE53E1", VA = "0x1FE52E0", Slot = "6")]
	protected override void Start()
	{
	}

	// Token: 0x060024F4 RID: 9460 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F2E")]
	[Address(RVA = "0x1FE54F0", Offset = "0x1FE55F1", VA = "0x1FE54F0")]
	private void Update()
	{
	}

	// Token: 0x060024F5 RID: 9461 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F2F")]
	[Address(RVA = "0x1FE5550", Offset = "0x1FE5651", VA = "0x1FE5550")]
	private void SpawnArrow()
	{
	}

	// Token: 0x060024F6 RID: 9462 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F30")]
	[Address(RVA = "0x1FE5650", Offset = "0x1FE5751", VA = "0x1FE5650")]
	private void SpawnGimmickObject(GameObject baseObj)
	{
	}

	// Token: 0x060024F7 RID: 9463 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F31")]
	[Address(RVA = "0x1FE58C0", Offset = "0x1FE59C1", VA = "0x1FE58C0", Slot = "11")]
	protected virtual void OnEnterEvent(Collider fromCollider, Collider toCollider)
	{
	}

	// Token: 0x060024F8 RID: 9464 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F32")]
	[Address(RVA = "0x1FE59D0", Offset = "0x1FE5AD1", VA = "0x1FE59D0", Slot = "12")]
	protected virtual void OnStayEvent(Collider fromCollider, Collider toCollider)
	{
	}

	// Token: 0x060024F9 RID: 9465 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F33")]
	[Address(RVA = "0x1FE59E0", Offset = "0x1FE5AE1", VA = "0x1FE59E0")]
	private void OnExitEvent(Collider fromCollider, Collider toCollider)
	{
	}

	// Token: 0x060024FA RID: 9466 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F34")]
	[Address(RVA = "0x1FE5AF0", Offset = "0x1FE5BF1", VA = "0x1FE5AF0")]
	protected void OnChangeSwitchState(bool newState, bool immediate)
	{
	}

	// Token: 0x060024FB RID: 9467 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F35")]
	[Address(RVA = "0x1FE5B00", Offset = "0x1FE5C01", VA = "0x1FE5B00")]
	public GimmickMagicArrow()
	{
	}

	// Token: 0x060024FC RID: 9468 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F36")]
	[Address(RVA = "0x1FE5B30", Offset = "0x1FE5C31", VA = "0x1FE5B30")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1520", Offset = "0x1A1621")]
	private void <SpawnArrow>b__20_0(AssetHandle<GameObject> handle)
	{
	}

	// Token: 0x04006C45 RID: 27717
	[Token(Token = "0x4006585")]
	private const int loaderId = 16332;

	// Token: 0x04006C46 RID: 27718
	[Token(Token = "0x4006586")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	protected float Interval;

	// Token: 0x04006C47 RID: 27719
	[Token(Token = "0x4006587")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	protected float ArrowDamage;

	// Token: 0x04006C48 RID: 27720
	[Token(Token = "0x4006588")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float AttackKnockbackPower;

	// Token: 0x04006C49 RID: 27721
	[Token(Token = "0x4006589")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	protected float ArrowSpeed;

	// Token: 0x04006C4A RID: 27722
	[Token(Token = "0x400658A")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	protected GimmickMagicArrow.MagicCircleType Type;

	// Token: 0x04006C4B RID: 27723
	[Token(Token = "0x400658B")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private float ColliderStartTime;

	// Token: 0x04006C4C RID: 27724
	[Token(Token = "0x400658C")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float FadeOutTime;

	// Token: 0x04006C4D RID: 27725
	[Token(Token = "0x400658D")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private float ShotEffectStopTime;

	// Token: 0x04006C4E RID: 27726
	[Token(Token = "0x400658E")]
	[FieldOffset(Offset = "0x40")]
	protected Transform MagicCircle;

	// Token: 0x04006C4F RID: 27727
	[Token(Token = "0x400658F")]
	[FieldOffset(Offset = "0x48")]
	protected SimpleTriggerEventDispatcher SimpleTriggerEventDispatcher;

	// Token: 0x04006C50 RID: 27728
	[Token(Token = "0x4006590")]
	[FieldOffset(Offset = "0x50")]
	protected bool stayRoom;

	// Token: 0x04006C51 RID: 27729
	[Token(Token = "0x4006591")]
	[FieldOffset(Offset = "0x51")]
	protected bool stopFlg;

	// Token: 0x04006C52 RID: 27730
	[Token(Token = "0x4006592")]
	[FieldOffset(Offset = "0x54")]
	protected float CurrentTime;

	// Token: 0x04006C53 RID: 27731
	[Token(Token = "0x4006593")]
	[FieldOffset(Offset = "0x58")]
	private int arrow_id;

	// Token: 0x04006C54 RID: 27732
	[Token(Token = "0x4006594")]
	[FieldOffset(Offset = "0x60")]
	private GameObject LoadPrefab;

	// Token: 0x020005E0 RID: 1504
	[Token(Token = "0x200112C")]
	public enum MagicCircleType
	{
		// Token: 0x04006C56 RID: 27734
		[Token(Token = "0x4019334")]
		White,
		// Token: 0x04006C57 RID: 27735
		[Token(Token = "0x4019335")]
		Yellow,
		// Token: 0x04006C58 RID: 27736
		[Token(Token = "0x4019336")]
		Red,
		// Token: 0x04006C59 RID: 27737
		[Token(Token = "0x4019337")]
		Green,
		// Token: 0x04006C5A RID: 27738
		[Token(Token = "0x4019338")]
		Blue
	}
}
