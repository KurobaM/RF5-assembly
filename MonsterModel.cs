using System;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

// Token: 0x020007DD RID: 2013
[Token(Token = "0x2000536")]
public class MonsterModel : CharacterModel
{
	// Token: 0x1700073F RID: 1855
	// (get) Token: 0x060034A1 RID: 13473 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170005A8")]
	public override Transform LookPoint
	{
		[Token(Token = "0x6002BC3")]
		[Address(RVA = "0x1E6DBA0", Offset = "0x1E6DCA1", VA = "0x1E6DBA0", Slot = "4")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000740 RID: 1856
	// (get) Token: 0x060034A2 RID: 13474 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170005A9")]
	public Transform Center
	{
		[Token(Token = "0x6002BC4")]
		[Address(RVA = "0x1E6DBB0", Offset = "0x1E6DCB1", VA = "0x1E6DBB0")]
		get
		{
			return null;
		}
	}

	// Token: 0x060034A3 RID: 13475 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002BC5")]
	[Address(RVA = "0x1E6DBC0", Offset = "0x1E6DCC1", VA = "0x1E6DBC0", Slot = "5")]
	protected override void Awake()
	{
	}

	// Token: 0x060034A4 RID: 13476 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002BC6")]
	[Address(RVA = "0x1E6DD40", Offset = "0x1E6DE41", VA = "0x1E6DD40")]
	public void SetupFootStepEventData(MonsterFootStepEventDataTable monsterFootStepEventDataTable)
	{
	}

	// Token: 0x060034A5 RID: 13477 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002BC7")]
	[Address(RVA = "0x1E6DEB0", Offset = "0x1E6DFB1", VA = "0x1E6DEB0")]
	public MonsterModel()
	{
	}

	// Token: 0x04007859 RID: 30809
	[Token(Token = "0x4006D46")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	protected LookAtIK LookAtIK;

	// Token: 0x0400785A RID: 30810
	[Token(Token = "0x4006D47")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Transform HeadTransform;

	// Token: 0x0400785B RID: 30811
	[Token(Token = "0x4006D48")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Transform CenterTransform;

	// Token: 0x0400785C RID: 30812
	[Token(Token = "0x4006D49")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private HumanRideSaddle HumanRideSaddle;

	// Token: 0x0400785D RID: 30813
	[Token(Token = "0x4006D4A")]
	[FieldOffset(Offset = "0x88")]
	public Transform[] FootStepLegTransforms;

	// Token: 0x0400785E RID: 30814
	[Token(Token = "0x4006D4B")]
	[FieldOffset(Offset = "0x90")]
	public MonsterFootStepEventDataTable MonsterFootStepEventDataTable;
}
