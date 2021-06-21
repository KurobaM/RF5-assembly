using System;
using Il2CppDummyDll;
using Loader;
using SplineMesh;
using UnityEngine;

// Token: 0x020005FC RID: 1532
[Token(Token = "0x200044E")]
public class RollingRockSpawner : GimmickBase
{
	// Token: 0x060025E7 RID: 9703 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001FF1")]
	[Address(RVA = "0x29A10F0", Offset = "0x29A11F1", VA = "0x29A10F0", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	// Token: 0x060025E8 RID: 9704 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001FF2")]
	[Address(RVA = "0x29A11C0", Offset = "0x29A12C1", VA = "0x29A11C0")]
	private void Awake()
	{
	}

	// Token: 0x060025E9 RID: 9705 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001FF3")]
	[Address(RVA = "0x29A1220", Offset = "0x29A1321", VA = "0x29A1220", Slot = "6")]
	protected override void Start()
	{
	}

	// Token: 0x060025EA RID: 9706 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001FF4")]
	[Address(RVA = "0x29A1250", Offset = "0x29A1351", VA = "0x29A1250")]
	private void Update()
	{
	}

	// Token: 0x060025EB RID: 9707 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001FF5")]
	[Address(RVA = "0x29A12C0", Offset = "0x29A13C1", VA = "0x29A12C0")]
	private void SpawnRollingRock()
	{
	}

	// Token: 0x060025EC RID: 9708 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001FF6")]
	[Address(RVA = "0x29A13E0", Offset = "0x29A14E1", VA = "0x29A13E0")]
	private void SpawnGimmickObject(GameObject baseObj)
	{
	}

	// Token: 0x060025ED RID: 9709 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001FF7")]
	[Address(RVA = "0x29A15C0", Offset = "0x29A16C1", VA = "0x29A15C0")]
	public RollingRockSpawner()
	{
	}

	// Token: 0x060025EE RID: 9710 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001FF8")]
	[Address(RVA = "0x29A15F0", Offset = "0x29A16F1", VA = "0x29A15F0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A19C0", Offset = "0x1A1AC1")]
	private void <SpawnRollingRock>b__17_0(AssetHandle<GameObject> handle)
	{
	}

	// Token: 0x04006D2E RID: 27950
	[Token(Token = "0x400663A")]
	private const int loaderId = 16341;

	// Token: 0x04006D2F RID: 27951
	[Token(Token = "0x400663B")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float MoveSpeed;

	// Token: 0x04006D30 RID: 27952
	[Token(Token = "0x400663C")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float Damage;

	// Token: 0x04006D31 RID: 27953
	[Token(Token = "0x400663D")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float AttackKnockbackPower;

	// Token: 0x04006D32 RID: 27954
	[Token(Token = "0x400663E")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float Interval;

	// Token: 0x04006D33 RID: 27955
	[Token(Token = "0x400663F")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float Scale;

	// Token: 0x04006D34 RID: 27956
	[Token(Token = "0x4006640")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private float FadeInTime;

	// Token: 0x04006D35 RID: 27957
	[Token(Token = "0x4006641")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float FadeOutTime;

	// Token: 0x04006D36 RID: 27958
	[Token(Token = "0x4006642")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private float FadeOutStartTime;

	// Token: 0x04006D37 RID: 27959
	[Token(Token = "0x4006643")]
	[FieldOffset(Offset = "0x40")]
	private Spline Spline;

	// Token: 0x04006D38 RID: 27960
	[Token(Token = "0x4006644")]
	[FieldOffset(Offset = "0x48")]
	private float CurrentTime;

	// Token: 0x04006D39 RID: 27961
	[Token(Token = "0x4006645")]
	[FieldOffset(Offset = "0x4C")]
	private bool isSpawn;

	// Token: 0x04006D3A RID: 27962
	[Token(Token = "0x4006646")]
	[FieldOffset(Offset = "0x50")]
	private GameObject LoadPrefab;
}
