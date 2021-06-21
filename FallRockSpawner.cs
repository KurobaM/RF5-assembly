using System;
using Il2CppDummyDll;
using Loader;
using UnityEngine;

// Token: 0x020005C4 RID: 1476
[Token(Token = "0x2000426")]
public class FallRockSpawner : GimmickBase
{
	// Token: 0x06002437 RID: 9271 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E7D")]
	[Address(RVA = "0x21C9BF0", Offset = "0x21C9CF1", VA = "0x21C9BF0", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	// Token: 0x06002438 RID: 9272 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E7E")]
	[Address(RVA = "0x21C9CC0", Offset = "0x21C9DC1", VA = "0x21C9CC0")]
	private void Update()
	{
	}

	// Token: 0x06002439 RID: 9273 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E7F")]
	[Address(RVA = "0x21C9D20", Offset = "0x21C9E21", VA = "0x21C9D20")]
	private void SpawnFallRock()
	{
	}

	// Token: 0x0600243A RID: 9274 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E80")]
	[Address(RVA = "0x21C9E40", Offset = "0x21C9F41", VA = "0x21C9E40")]
	private void SpawnGimmickObject(GameObject baseObj)
	{
	}

	// Token: 0x0600243B RID: 9275 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E81")]
	[Address(RVA = "0x21C9F50", Offset = "0x21CA051", VA = "0x21C9F50", Slot = "7")]
	public override void SetGimmickState(bool newState)
	{
	}

	// Token: 0x0600243C RID: 9276 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E82")]
	[Address(RVA = "0x21C9F80", Offset = "0x21CA081", VA = "0x21C9F80")]
	public FallRockSpawner()
	{
	}

	// Token: 0x0600243D RID: 9277 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E83")]
	[Address(RVA = "0x21C9FA0", Offset = "0x21CA0A1", VA = "0x21C9FA0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1300", Offset = "0x1A1401")]
	private void <SpawnFallRock>b__9_0(AssetHandle<GameObject> handle)
	{
	}

	// Token: 0x04006BAC RID: 27564
	[Token(Token = "0x4006503")]
	private const int loaderId = 16331;

	// Token: 0x04006BAD RID: 27565
	[Token(Token = "0x4006504")]
	[FieldOffset(Offset = "0x20")]
	private float CurrentTime;

	// Token: 0x04006BAE RID: 27566
	[Token(Token = "0x4006505")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float Interval;

	// Token: 0x04006BAF RID: 27567
	[Token(Token = "0x4006506")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float DamagePercent;

	// Token: 0x04006BB0 RID: 27568
	[Token(Token = "0x4006507")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float FallAccelSpeed;

	// Token: 0x04006BB1 RID: 27569
	[Token(Token = "0x4006508")]
	[FieldOffset(Offset = "0x30")]
	private bool isSpawn;

	// Token: 0x04006BB2 RID: 27570
	[Token(Token = "0x4006509")]
	[FieldOffset(Offset = "0x38")]
	private GameObject LoadPrefab;
}
