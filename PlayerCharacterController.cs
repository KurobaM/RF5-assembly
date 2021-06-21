using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002BD RID: 701
[Token(Token = "0x2000224")]
[Attribute(Name = "DefaultExecutionOrder", RVA = "0x1459E0", Offset = "0x145AE1")]
public class PlayerCharacterController : HumanController, ItemInteractionInterface, FocusInterface
{
	// Token: 0x17000340 RID: 832
	// (get) Token: 0x06001257 RID: 4695 RVA: 0x000085F8 File Offset: 0x000067F8
	[Token(Token = "0x17000316")]
	protected override bool UseGravityOnNavMeshEnabled
	{
		[Token(Token = "0x60010B8")]
		[Address(RVA = "0x2146910", Offset = "0x2146A11", VA = "0x2146910", Slot = "38")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000341 RID: 833
	// (get) Token: 0x06001258 RID: 4696 RVA: 0x00008610 File Offset: 0x00006810
	[Token(Token = "0x17000317")]
	public float HandcuffsCoolTime
	{
		[Token(Token = "0x60010B9")]
		[Address(RVA = "0x2146920", Offset = "0x2146A21", VA = "0x2146920")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000342 RID: 834
	// (get) Token: 0x06001259 RID: 4697 RVA: 0x00008628 File Offset: 0x00006828
	[Token(Token = "0x17000318")]
	public float HandcuffsCoolTimePer
	{
		[Token(Token = "0x60010BA")]
		[Address(RVA = "0x21469F0", Offset = "0x2146AF1", VA = "0x21469F0")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000343 RID: 835
	// (get) Token: 0x0600125A RID: 4698 RVA: 0x00008640 File Offset: 0x00006840
	[Token(Token = "0x17000319")]
	public bool Focusable
	{
		[Token(Token = "0x60010BB")]
		[Address(RVA = "0x2146AC0", Offset = "0x2146BC1", VA = "0x2146AC0", Slot = "98")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000344 RID: 836
	// (get) Token: 0x0600125B RID: 4699 RVA: 0x00008658 File Offset: 0x00006858
	[Token(Token = "0x1700031A")]
	public FocusObjectType FocusObjectType
	{
		[Token(Token = "0x60010BC")]
		[Address(RVA = "0x2146AD0", Offset = "0x2146BD1", VA = "0x2146AD0", Slot = "101")]
		get
		{
			return FocusObjectType.Default;
		}
	}

	// Token: 0x17000345 RID: 837
	// (get) Token: 0x0600125C RID: 4700 RVA: 0x00008670 File Offset: 0x00006870
	[Token(Token = "0x1700031B")]
	public int FocusPriority
	{
		[Token(Token = "0x60010BD")]
		[Address(RVA = "0x2146AE0", Offset = "0x2146BE1", VA = "0x2146AE0", Slot = "102")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000346 RID: 838
	// (get) Token: 0x0600125D RID: 4701 RVA: 0x00008688 File Offset: 0x00006888
	[Token(Token = "0x1700031C")]
	public FocusPointType FocusPointType
	{
		[Token(Token = "0x60010BE")]
		[Address(RVA = "0x2146AF0", Offset = "0x2146BF1", VA = "0x2146AF0", Slot = "103")]
		get
		{
			return FocusPointType.HitPoint;
		}
	}

	// Token: 0x0600125E RID: 4702 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010BF")]
	[Address(RVA = "0x2146B00", Offset = "0x2146C01", VA = "0x2146B00")]
	public void HandcuffsStart()
	{
	}

	// Token: 0x0600125F RID: 4703 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010C0")]
	[Address(RVA = "0x2146BE0", Offset = "0x2146CE1", VA = "0x2146BE0")]
	public void HandcuffsEnd()
	{
	}

	// Token: 0x06001260 RID: 4704 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010C1")]
	[Address(RVA = "0x2146CD0", Offset = "0x2146DD1", VA = "0x2146CD0", Slot = "17")]
	public override void OnSwitchActorBase(bool on)
	{
	}

	// Token: 0x06001261 RID: 4705 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010C2")]
	[Address(RVA = "0x2146FB0", Offset = "0x21470B1", VA = "0x2146FB0")]
	public void SpcToPlayerResetMovement()
	{
	}

	// Token: 0x06001262 RID: 4706 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010C3")]
	[Address(RVA = "0x2146FC0", Offset = "0x21470C1", VA = "0x2146FC0", Slot = "49")]
	protected override void ResetMovement()
	{
	}

	// Token: 0x06001263 RID: 4707 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010C4")]
	[Address(RVA = "0x21470C0", Offset = "0x21471C1", VA = "0x21470C0", Slot = "11")]
	protected override void Awake()
	{
	}

	// Token: 0x06001264 RID: 4708 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010C5")]
	[Address(RVA = "0x2147160", Offset = "0x2147261", VA = "0x2147160", Slot = "12")]
	protected override void Start()
	{
	}

	// Token: 0x06001265 RID: 4709 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010C6")]
	[Address(RVA = "0x21472A0", Offset = "0x21473A1", VA = "0x21472A0", Slot = "39")]
	protected override void Update()
	{
	}

	// Token: 0x06001266 RID: 4710 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010C7")]
	[Address(RVA = "0x2147320", Offset = "0x2147421", VA = "0x2147320")]
	private void DoAction_WalkSkill(GroundType groundType)
	{
	}

	// Token: 0x06001267 RID: 4711 RVA: 0x000086A0 File Offset: 0x000068A0
	[Token(Token = "0x60010C8")]
	[Address(RVA = "0x2147420", Offset = "0x2147521", VA = "0x2147420", Slot = "7")]
	public override bool TakeDamage(DamageInfo damageInfo, out DamageResult damageResult)
	{
		return default(bool);
	}

	// Token: 0x06001268 RID: 4712 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010C9")]
	[Address(RVA = "0x2147710", Offset = "0x2147811", VA = "0x2147710", Slot = "93")]
	public override void AddDamagedPost(DamageInfo damageInfo, DamageResult result, ItemData itemData)
	{
	}

	// Token: 0x06001269 RID: 4713 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010CA")]
	[Address(RVA = "0x2147840", Offset = "0x2147941", VA = "0x2147840", Slot = "94")]
	public void DoItemInteraction(HumanController character, ItemData itemData, bool isThrow)
	{
	}

	// Token: 0x0600126A RID: 4714 RVA: 0x000086B8 File Offset: 0x000068B8
	[Token(Token = "0x60010CB")]
	[Address(RVA = "0x2147900", Offset = "0x2147A01", VA = "0x2147900", Slot = "95")]
	public bool CanItemInteraction(HumanController character, ItemData itemData, bool isThrow)
	{
		return default(bool);
	}

	// Token: 0x0600126B RID: 4715 RVA: 0x000086D0 File Offset: 0x000068D0
	[Token(Token = "0x60010CC")]
	[Address(RVA = "0x21479F0", Offset = "0x2147AF1", VA = "0x21479F0", Slot = "96")]
	public bool CanRapidItemInteraction(HumanController character, ItemData itemData)
	{
		return default(bool);
	}

	// Token: 0x0600126C RID: 4716 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010CD")]
	[Address(RVA = "0x2147A00", Offset = "0x2147B01", VA = "0x2147A00", Slot = "97")]
	public string GetFocusName()
	{
		return null;
	}

	// Token: 0x0600126D RID: 4717 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010CE")]
	[Address(RVA = "0x2147A50", Offset = "0x2147B51", VA = "0x2147A50", Slot = "99")]
	public void OnFocus()
	{
	}

	// Token: 0x0600126E RID: 4718 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010CF")]
	[Address(RVA = "0x2147A60", Offset = "0x2147B61", VA = "0x2147A60", Slot = "100")]
	public void OffFocus()
	{
	}

	// Token: 0x0600126F RID: 4719 RVA: 0x000086E8 File Offset: 0x000068E8
	[Token(Token = "0x60010D0")]
	[Address(RVA = "0x2147A70", Offset = "0x2147B71", VA = "0x2147A70", Slot = "104")]
	public ushort GetInteractionType()
	{
		return 0;
	}

	// Token: 0x06001270 RID: 4720 RVA: 0x00008700 File Offset: 0x00006900
	[Token(Token = "0x60010D1")]
	[Address(RVA = "0x2147A80", Offset = "0x2147B81", VA = "0x2147A80", Slot = "48")]
	public override bool InputMove(Vector3 vector)
	{
		return default(bool);
	}

	// Token: 0x06001271 RID: 4721 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010D2")]
	[Address(RVA = "0x2147AE0", Offset = "0x2147BE1", VA = "0x2147AE0", Slot = "92")]
	public override void Avoid()
	{
	}

	// Token: 0x06001272 RID: 4722 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010D3")]
	[Address(RVA = "0x2147DA0", Offset = "0x2147EA1", VA = "0x2147DA0")]
	public PlayerCharacterController()
	{
	}

	// Token: 0x06001273 RID: 4723 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010D4")]
	[Address(RVA = "0x2147E20", Offset = "0x2147F21", VA = "0x2147E20", Slot = "105")]
	private GameObject get_gameObject()
	{
		return null;
	}

	// Token: 0x06001274 RID: 4724 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010D5")]
	[Address(RVA = "0x2147E30", Offset = "0x2147F31", VA = "0x2147E30", Slot = "106")]
	private Transform get_transform()
	{
		return null;
	}

	// Token: 0x06001275 RID: 4725 RVA: 0x00008718 File Offset: 0x00006918
	[Token(Token = "0x60010D6")]
	[Address(RVA = "0x2147E40", Offset = "0x2147F41", VA = "0x2147E40")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C730", Offset = "0x19C831")]
	private bool <Awake>b__21_0()
	{
		return default(bool);
	}

	// Token: 0x04000A5C RID: 2652
	[Token(Token = "0x4000823")]
	[FieldOffset(Offset = "0x238")]
	private Vector3 InputVector;

	// Token: 0x04000A5D RID: 2653
	[Token(Token = "0x4000824")]
	[FieldOffset(Offset = "0x244")]
	private int CurrentWalkSkillCount;

	// Token: 0x020002BE RID: 702
	[Token(Token = "0x2001022")]
	public enum Action
	{
		// Token: 0x04000A5F RID: 2655
		[Token(Token = "0x4018EAD")]
		AVOID,
		// Token: 0x04000A60 RID: 2656
		[Token(Token = "0x4018EAE")]
		ATTACK,
		// Token: 0x04000A61 RID: 2657
		[Token(Token = "0x4018EAF")]
		CHARGE_START,
		// Token: 0x04000A62 RID: 2658
		[Token(Token = "0x4018EB0")]
		CHARGE_END,
		// Token: 0x04000A63 RID: 2659
		[Token(Token = "0x4018EB1")]
		ITEM_PUTON,
		// Token: 0x04000A64 RID: 2660
		[Token(Token = "0x4018EB2")]
		ITEM_PUTIN,
		// Token: 0x04000A65 RID: 2661
		[Token(Token = "0x4018EB3")]
		ITEM_THROW,
		// Token: 0x04000A66 RID: 2662
		[Token(Token = "0x4018EB4")]
		ITEM_USE,
		// Token: 0x04000A67 RID: 2663
		[Token(Token = "0x4018EB5")]
		RUNEABILITY_1,
		// Token: 0x04000A68 RID: 2664
		[Token(Token = "0x4018EB6")]
		RUNEABILITY_2,
		// Token: 0x04000A69 RID: 2665
		[Token(Token = "0x4018EB7")]
		RUNEABILITY_3,
		// Token: 0x04000A6A RID: 2666
		[Token(Token = "0x4018EB8")]
		RUNEABILITY_4,
		// Token: 0x04000A6B RID: 2667
		[Token(Token = "0x4018EB9")]
		RUNEABILITY_5,
		// Token: 0x04000A6C RID: 2668
		[Token(Token = "0x4018EBA")]
		RUNEABILITY_6,
		// Token: 0x04000A6D RID: 2669
		[Token(Token = "0x4018EBB")]
		HANDCUFFS_START,
		// Token: 0x04000A6E RID: 2670
		[Token(Token = "0x4018EBC")]
		HANDCUFFS_CHARGE,
		// Token: 0x04000A6F RID: 2671
		[Token(Token = "0x4018EBD")]
		HANDCUFFS_END,
		// Token: 0x04000A70 RID: 2672
		[Token(Token = "0x4018EBE")]
		Length
	}
}
