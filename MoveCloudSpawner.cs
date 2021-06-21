using System;
using Define;
using Il2CppDummyDll;
using Loader;
using Loader.ID;
using SplineMesh;
using UnityEngine;

// Token: 0x020005F7 RID: 1527
[Token(Token = "0x200044B")]
public class MoveCloudSpawner : GimmickBase
{
	// Token: 0x17000617 RID: 1559
	// (get) Token: 0x060025BC RID: 9660 RVA: 0x0000F048 File Offset: 0x0000D248
	// (set) Token: 0x060025BD RID: 9661 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170004D9")]
	public Prefab CloudID
	{
		[Token(Token = "0x6001FD2")]
		[Address(RVA = "0x1E11110", Offset = "0x1E11211", VA = "0x1E11110")]
		get
		{
			return Prefab.NONE;
		}
		[Token(Token = "0x6001FD3")]
		[Address(RVA = "0x1E11120", Offset = "0x1E11221", VA = "0x1E11120")]
		set
		{
		}
	}

	// Token: 0x060025BE RID: 9662 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001FD4")]
	[Address(RVA = "0x1E11130", Offset = "0x1E11231", VA = "0x1E11130", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	// Token: 0x060025BF RID: 9663 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001FD5")]
	[Address(RVA = "0x1E11220", Offset = "0x1E11321", VA = "0x1E11220")]
	private void Awake()
	{
	}

	// Token: 0x060025C0 RID: 9664 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001FD6")]
	[Address(RVA = "0x1E11280", Offset = "0x1E11381", VA = "0x1E11280", Slot = "6")]
	protected override void Start()
	{
	}

	// Token: 0x060025C1 RID: 9665 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001FD7")]
	[Address(RVA = "0x1E112B0", Offset = "0x1E113B1", VA = "0x1E112B0")]
	private void Update()
	{
	}

	// Token: 0x060025C2 RID: 9666 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001FD8")]
	[Address(RVA = "0x1E11320", Offset = "0x1E11421", VA = "0x1E11320")]
	private void SpawnGimmickObject()
	{
	}

	// Token: 0x060025C3 RID: 9667 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001FD9")]
	[Address(RVA = "0x1E11430", Offset = "0x1E11531", VA = "0x1E11430")]
	private void SpawnGimmickObject(GameObject baseObj)
	{
	}

	// Token: 0x060025C4 RID: 9668 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001FDA")]
	[Address(RVA = "0x1E11670", Offset = "0x1E11771", VA = "0x1E11670")]
	public MoveCloudSpawner()
	{
	}

	// Token: 0x060025C5 RID: 9669 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001FDB")]
	[Address(RVA = "0x1E11720", Offset = "0x1E11821", VA = "0x1E11720")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A18C0", Offset = "0x1A19C1")]
	private void <SpawnGimmickObject>b__21_0(AssetHandle<GameObject> handle)
	{
	}

	// Token: 0x04006CF8 RID: 27896
	[Token(Token = "0x4006610")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Prefab _CloudID;

	// Token: 0x04006CF9 RID: 27897
	[Token(Token = "0x4006611")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	[Attribute(Name = "HeaderAttribute", RVA = "0x167CC0", Offset = "0x167DC1")]
	private int Hp;

	// Token: 0x04006CFA RID: 27898
	[Token(Token = "0x4006612")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private AttackType attackType;

	// Token: 0x04006CFB RID: 27899
	[Token(Token = "0x4006613")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private AttackAttribute[] attackAttribute;

	// Token: 0x04006CFC RID: 27900
	[Token(Token = "0x4006614")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Attribute(Name = "HeaderAttribute", RVA = "0x167D30", Offset = "0x167E31")]
	private float MoveSpeed;

	// Token: 0x04006CFD RID: 27901
	[Token(Token = "0x4006615")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	[Attribute(Name = "RangeAttribute", RVA = "0x167D80", Offset = "0x167E81")]
	private float LerpValue;

	// Token: 0x04006CFE RID: 27902
	[Token(Token = "0x4006616")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Vector3 Rotation;

	// Token: 0x04006CFF RID: 27903
	[Token(Token = "0x4006617")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	[Attribute(Name = "HeaderAttribute", RVA = "0x167DE0", Offset = "0x167EE1")]
	private float FadeInTime;

	// Token: 0x04006D00 RID: 27904
	[Token(Token = "0x4006618")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private float FadeOutTime;

	// Token: 0x04006D01 RID: 27905
	[Token(Token = "0x4006619")]
	[FieldOffset(Offset = "0x58")]
	private Spline Spline;

	// Token: 0x04006D02 RID: 27906
	[Token(Token = "0x400661A")]
	[FieldOffset(Offset = "0x60")]
	private float Interval;

	// Token: 0x04006D03 RID: 27907
	[Token(Token = "0x400661B")]
	[FieldOffset(Offset = "0x64")]
	private float CurrentTime;

	// Token: 0x04006D04 RID: 27908
	[Token(Token = "0x400661C")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private bool IsSpawn;

	// Token: 0x04006D05 RID: 27909
	[Token(Token = "0x400661D")]
	[FieldOffset(Offset = "0x70")]
	private GameObject LoadPrefab;
}
