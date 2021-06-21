using System;
using Il2CppDummyDll;
using Loader;
using Loader.ID;
using SplineMesh;
using UnityEngine;

// Token: 0x020005CA RID: 1482
[Token(Token = "0x200042A")]
[Attribute(Name = "ExecuteInEditMode", RVA = "0x146130", Offset = "0x146231")]
public class FlyingNimbusSpawner : GimmickBase
{
	// Token: 0x170005EA RID: 1514
	// (get) Token: 0x06002460 RID: 9312 RVA: 0x0000EB68 File Offset: 0x0000CD68
	// (set) Token: 0x06002461 RID: 9313 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170004BC")]
	public Prefab CloudID
	{
		[Token(Token = "0x6001EA6")]
		[Address(RVA = "0x1ECBA90", Offset = "0x1ECBB91", VA = "0x1ECBA90")]
		get
		{
			return Prefab.NONE;
		}
		[Token(Token = "0x6001EA7")]
		[Address(RVA = "0x1ECBAA0", Offset = "0x1ECBBA1", VA = "0x1ECBAA0")]
		set
		{
		}
	}

	// Token: 0x06002462 RID: 9314 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001EA8")]
	[Address(RVA = "0x1ECBAB0", Offset = "0x1ECBBB1", VA = "0x1ECBAB0", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	// Token: 0x06002463 RID: 9315 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001EA9")]
	[Address(RVA = "0x1ECBBA0", Offset = "0x1ECBCA1", VA = "0x1ECBBA0")]
	private void Awake()
	{
	}

	// Token: 0x06002464 RID: 9316 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001EAA")]
	[Address(RVA = "0x1ECBD20", Offset = "0x1ECBE21", VA = "0x1ECBD20", Slot = "6")]
	protected override void Start()
	{
	}

	// Token: 0x06002465 RID: 9317 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001EAB")]
	[Address(RVA = "0x1ECBC10", Offset = "0x1ECBD11", VA = "0x1ECBC10")]
	private void SpawnGimmickObject()
	{
	}

	// Token: 0x06002466 RID: 9318 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001EAC")]
	[Address(RVA = "0x1ECBD30", Offset = "0x1ECBE31", VA = "0x1ECBD30")]
	private void SpawnGimmickObject(GameObject baseObj)
	{
	}

	// Token: 0x06002467 RID: 9319 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001EAD")]
	[Address(RVA = "0x1ECBF40", Offset = "0x1ECC041", VA = "0x1ECBF40")]
	public FlyingNimbusSpawner()
	{
	}

	// Token: 0x06002468 RID: 9320 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001EAE")]
	[Address(RVA = "0x1ECC070", Offset = "0x1ECC171", VA = "0x1ECC070")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1310", Offset = "0x1A1411")]
	private void <SpawnGimmickObject>b__18_0(AssetHandle<GameObject> handle)
	{
	}

	// Token: 0x04006BD3 RID: 27603
	[Token(Token = "0x4006523")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Prefab _CloudID;

	// Token: 0x04006BD4 RID: 27604
	[Token(Token = "0x4006524")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Attribute(Name = "HeaderAttribute", RVA = "0x166E10", Offset = "0x166F11")]
	private Vector3[] SplineLength;

	// Token: 0x04006BD5 RID: 27605
	[Token(Token = "0x4006525")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Attribute(Name = "HeaderAttribute", RVA = "0x166E60", Offset = "0x166F61")]
	private AnimationCurve animationCurve;

	// Token: 0x04006BD6 RID: 27606
	[Token(Token = "0x4006526")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Attribute(Name = "RangeAttribute", RVA = "0x166EB0", Offset = "0x166FB1")]
	private float TotalTime;

	// Token: 0x04006BD7 RID: 27607
	[Token(Token = "0x4006527")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	[Attribute(Name = "RangeAttribute", RVA = "0x166F00", Offset = "0x167001")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x166F00", Offset = "0x167001")]
	private float LerpValue;

	// Token: 0x04006BD8 RID: 27608
	[Token(Token = "0x4006528")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Vector3 Rotation;

	// Token: 0x04006BD9 RID: 27609
	[Token(Token = "0x4006529")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	private FlyingNimbus.MoveType moveType;

	// Token: 0x04006BDA RID: 27610
	[Token(Token = "0x400652A")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Attribute(Name = "HeaderAttribute", RVA = "0x166F90", Offset = "0x167091")]
	private FlyingNimbusEnter In0;

	// Token: 0x04006BDB RID: 27611
	[Token(Token = "0x400652B")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private FlyingNimbusEnter In1;

	// Token: 0x04006BDC RID: 27612
	[Token(Token = "0x400652C")]
	[FieldOffset(Offset = "0x60")]
	private Spline Spline;

	// Token: 0x04006BDD RID: 27613
	[Token(Token = "0x400652D")]
	[FieldOffset(Offset = "0x68")]
	private GameObject LoadPrefab;

	// Token: 0x04006BDE RID: 27614
	[Token(Token = "0x400652E")]
	[FieldOffset(Offset = "0x70")]
	[Attribute(Name = "HideInInspector", RVA = "0x166FF0", Offset = "0x1670F1")]
	public FlyingNimbus flyingNimbus;
}
