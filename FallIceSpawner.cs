using System;
using Il2CppDummyDll;
using Loader;
using UnityEngine;

// Token: 0x020005C2 RID: 1474
[Token(Token = "0x2000424")]
public class FallIceSpawner : GimmickBase
{
	// Token: 0x06002427 RID: 9255 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E6D")]
	[Address(RVA = "0x21C8B40", Offset = "0x21C8C41", VA = "0x21C8B40", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	// Token: 0x06002428 RID: 9256 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E6E")]
	[Address(RVA = "0x21C8C10", Offset = "0x21C8D11", VA = "0x21C8C10", Slot = "6")]
	protected override void Start()
	{
	}

	// Token: 0x06002429 RID: 9257 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E6F")]
	[Address(RVA = "0x21C8D50", Offset = "0x21C8E51", VA = "0x21C8D50")]
	private void Update()
	{
	}

	// Token: 0x0600242A RID: 9258 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E70")]
	[Address(RVA = "0x21C8DC0", Offset = "0x21C8EC1", VA = "0x21C8DC0")]
	private void SpawnFallIce()
	{
	}

	// Token: 0x0600242B RID: 9259 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E71")]
	[Address(RVA = "0x21C8EE0", Offset = "0x21C8FE1", VA = "0x21C8EE0")]
	private void SpawnGimmickObject(GameObject baseObj)
	{
	}

	// Token: 0x0600242C RID: 9260 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E72")]
	[Address(RVA = "0x21C9040", Offset = "0x21C9141", VA = "0x21C9040", Slot = "7")]
	public override void SetGimmickState(bool newState)
	{
	}

	// Token: 0x0600242D RID: 9261 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E73")]
	[Address(RVA = "0x21C9070", Offset = "0x21C9171", VA = "0x21C9070")]
	private void OnStayEvent(Collider fromCollider, Collider toCollider)
	{
	}

	// Token: 0x0600242E RID: 9262 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E74")]
	[Address(RVA = "0x21C9180", Offset = "0x21C9281", VA = "0x21C9180")]
	private void OnExitEvent(Collider fromCollider, Collider toCollider)
	{
	}

	// Token: 0x0600242F RID: 9263 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E75")]
	[Address(RVA = "0x21C9290", Offset = "0x21C9391", VA = "0x21C9290")]
	public FallIceSpawner()
	{
	}

	// Token: 0x06002430 RID: 9264 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E76")]
	[Address(RVA = "0x21C9340", Offset = "0x21C9441", VA = "0x21C9340")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A12F0", Offset = "0x1A13F1")]
	private void <SpawnFallIce>b__19_0(AssetHandle<GameObject> handle)
	{
	}

	// Token: 0x04006B93 RID: 27539
	[Token(Token = "0x40064EA")]
	private const int loaderId = 16330;

	// Token: 0x04006B94 RID: 27540
	[Token(Token = "0x40064EB")]
	[FieldOffset(Offset = "0x20")]
	private float CurrentTime;

	// Token: 0x04006B95 RID: 27541
	[Token(Token = "0x40064EC")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float Interval;

	// Token: 0x04006B96 RID: 27542
	[Token(Token = "0x40064ED")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float FallStartTime;

	// Token: 0x04006B97 RID: 27543
	[Token(Token = "0x40064EE")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float ColliderStartTime;

	// Token: 0x04006B98 RID: 27544
	[Token(Token = "0x40064EF")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Attribute(Name = "RangeAttribute", RVA = "0x166C30", Offset = "0x166D31")]
	private float DamagePercent;

	// Token: 0x04006B99 RID: 27545
	[Token(Token = "0x40064F0")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private float AttackKnockbackPower;

	// Token: 0x04006B9A RID: 27546
	[Token(Token = "0x40064F1")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float FallAccelSpeed;

	// Token: 0x04006B9B RID: 27547
	[Token(Token = "0x40064F2")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private Vector3 FallIceScale;

	// Token: 0x04006B9C RID: 27548
	[Token(Token = "0x40064F3")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private float ShadowScale5m;

	// Token: 0x04006B9D RID: 27549
	[Token(Token = "0x40064F4")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	private float ShadowScale0m;

	// Token: 0x04006B9E RID: 27550
	[Token(Token = "0x40064F5")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Transform SpawmPos;

	// Token: 0x04006B9F RID: 27551
	[Token(Token = "0x40064F6")]
	[FieldOffset(Offset = "0x58")]
	protected SimpleTriggerEventDispatcher SimpleTriggerEventDispatcher;

	// Token: 0x04006BA0 RID: 27552
	[Token(Token = "0x40064F7")]
	[FieldOffset(Offset = "0x60")]
	protected bool stayRoom;

	// Token: 0x04006BA1 RID: 27553
	[Token(Token = "0x40064F8")]
	[FieldOffset(Offset = "0x61")]
	private bool isSpawn;

	// Token: 0x04006BA2 RID: 27554
	[Token(Token = "0x40064F9")]
	[FieldOffset(Offset = "0x68")]
	private GameObject LoadPrefab;
}
