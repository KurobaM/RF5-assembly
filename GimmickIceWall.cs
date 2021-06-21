using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020005DD RID: 1501
[Token(Token = "0x200043A")]
public class GimmickIceWall : GimmickBreakeObject
{
	// Token: 0x060024EA RID: 9450 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F24")]
	[Address(RVA = "0x1FE4A60", Offset = "0x1FE4B61", VA = "0x1FE4A60", Slot = "12")]
	protected override void Awake()
	{
	}

	// Token: 0x060024EB RID: 9451 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F25")]
	[Address(RVA = "0x1FE4D10", Offset = "0x1FE4E11", VA = "0x1FE4D10", Slot = "6")]
	protected override void Start()
	{
	}

	// Token: 0x060024EC RID: 9452 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F26")]
	[Address(RVA = "0x1FE4D20", Offset = "0x1FE4E21", VA = "0x1FE4D20", Slot = "7")]
	public override void SetGimmickState(bool newState)
	{
	}

	// Token: 0x060024ED RID: 9453 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F27")]
	[Address(RVA = "0x1FE5040", Offset = "0x1FE5141", VA = "0x1FE5040", Slot = "9")]
	public override void Init()
	{
	}

	// Token: 0x060024EE RID: 9454 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F28")]
	[Address(RVA = "0x1FE4DC0", Offset = "0x1FE4EC1", VA = "0x1FE4DC0")]
	private void SetWallActive(bool value)
	{
	}

	// Token: 0x060024EF RID: 9455 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F29")]
	[Address(RVA = "0x1FE5080", Offset = "0x1FE5181", VA = "0x1FE5080", Slot = "13")]
	public override void SetGimmickFlag(bool setValue)
	{
	}

	// Token: 0x060024F0 RID: 9456 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F2A")]
	[Address(RVA = "0x1FE5090", Offset = "0x1FE5191", VA = "0x1FE5090", Slot = "14")]
	public override void Breake(Vector3 hitPoint)
	{
	}

	// Token: 0x060024F1 RID: 9457 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F2B")]
	[Address(RVA = "0x1FE5110", Offset = "0x1FE5211", VA = "0x1FE5110")]
	public GimmickIceWall()
	{
	}

	// Token: 0x04006C3F RID: 27711
	[Token(Token = "0x400657F")]
	private const float BrokenDelay = 0.25f;

	// Token: 0x04006C40 RID: 27712
	[Token(Token = "0x4006580")]
	private const SoundID BreakSe = SoundID.RF5_SE_field_gimmick12;

	// Token: 0x04006C41 RID: 27713
	[Token(Token = "0x4006581")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private GameObject[] WallObjects;

	// Token: 0x04006C42 RID: 27714
	[Token(Token = "0x4006582")]
	[FieldOffset(Offset = "0x90")]
	private List<GameObject> WallObjectList;

	// Token: 0x04006C43 RID: 27715
	[Token(Token = "0x4006583")]
	[FieldOffset(Offset = "0x98")]
	private List<Collider> ColliderList;
}
