using System;
using Define;
using Field;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020005AB RID: 1451
[Token(Token = "0x200040D")]
public class WoodenBox : CharacterBase, InteractionInterface, FocusInterface, HoldableInterface
{
	// Token: 0x170005CD RID: 1485
	// (get) Token: 0x0600237F RID: 9087 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002380 RID: 9088 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700049F")]
	public Renderer[] ModelsMeshes
	{
		[Token(Token = "0x6001DC5")]
		[Address(RVA = "0x1E547C0", Offset = "0x1E548C1", VA = "0x1E547C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1210", Offset = "0x1A1311")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001DC6")]
		[Address(RVA = "0x1E547D0", Offset = "0x1E548D1", VA = "0x1E547D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1220", Offset = "0x1A1321")]
		private set
		{
		}
	}

	// Token: 0x170005CE RID: 1486
	// (get) Token: 0x06002381 RID: 9089 RVA: 0x0000E640 File Offset: 0x0000C840
	// (set) Token: 0x06002382 RID: 9090 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170004A0")]
	public ItemLotteryID ItemLotteryID
	{
		[Token(Token = "0x6001DC7")]
		[Address(RVA = "0x1E547E0", Offset = "0x1E548E1", VA = "0x1E547E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1230", Offset = "0x1A1331")]
		get
		{
			return ItemLotteryID.WoodenBox_Debug;
		}
		[Token(Token = "0x6001DC8")]
		[Address(RVA = "0x1E547F0", Offset = "0x1E548F1", VA = "0x1E547F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1240", Offset = "0x1A1341")]
		set
		{
		}
	}

	// Token: 0x170005CF RID: 1487
	// (get) Token: 0x06002383 RID: 9091 RVA: 0x0000E658 File Offset: 0x0000C858
	// (set) Token: 0x06002384 RID: 9092 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170004A1")]
	public int ModelID
	{
		[Token(Token = "0x6001DC9")]
		[Address(RVA = "0x1E54800", Offset = "0x1E54901", VA = "0x1E54800")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1250", Offset = "0x1A1351")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001DCA")]
		[Address(RVA = "0x1E54810", Offset = "0x1E54911", VA = "0x1E54810")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1260", Offset = "0x1A1361")]
		private set
		{
		}
	}

	// Token: 0x06002385 RID: 9093 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DCB")]
	[Address(RVA = "0x1E54820", Offset = "0x1E54921", VA = "0x1E54820")]
	public void SetModelID(int modelId)
	{
	}

	// Token: 0x06002386 RID: 9094 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DCC")]
	[Address(RVA = "0x1E54950", Offset = "0x1E54A51", VA = "0x1E54950")]
	public void SetDataID(FieldWoodBoxSpawnID boxSpawnID)
	{
	}

	// Token: 0x06002387 RID: 9095 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DCD")]
	[Address(RVA = "0x1E54960", Offset = "0x1E54A61", VA = "0x1E54960")]
	private void OnDestroy()
	{
	}

	// Token: 0x06002388 RID: 9096 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DCE")]
	[Address(RVA = "0x1E54A30", Offset = "0x1E54B31", VA = "0x1E54A30", Slot = "11")]
	protected override void Awake()
	{
	}

	// Token: 0x170005D0 RID: 1488
	// (get) Token: 0x06002389 RID: 9097 RVA: 0x0000E670 File Offset: 0x0000C870
	[Token(Token = "0x170004A2")]
	public bool Focusable
	{
		[Token(Token = "0x6001DCF")]
		[Address(RVA = "0x1E54B10", Offset = "0x1E54C11", VA = "0x1E54B10", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170005D1 RID: 1489
	// (get) Token: 0x0600238A RID: 9098 RVA: 0x0000E688 File Offset: 0x0000C888
	[Token(Token = "0x170004A3")]
	public HoldMotionType HoldMotionType
	{
		[Token(Token = "0x6001DD0")]
		[Address(RVA = "0x1E54BA0", Offset = "0x1E54CA1", VA = "0x1E54BA0", Slot = "37")]
		get
		{
			return HoldMotionType.Head;
		}
	}

	// Token: 0x170005D2 RID: 1490
	// (get) Token: 0x0600238B RID: 9099 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170004A4")]
	public ItemData ItemData
	{
		[Token(Token = "0x6001DD1")]
		[Address(RVA = "0x1E54BB0", Offset = "0x1E54CB1", VA = "0x1E54BB0")]
		get
		{
			return null;
		}
	}

	// Token: 0x170005D3 RID: 1491
	// (get) Token: 0x0600238C RID: 9100 RVA: 0x0000E6A0 File Offset: 0x0000C8A0
	[Token(Token = "0x170004A5")]
	public FocusObjectType FocusObjectType
	{
		[Token(Token = "0x6001DD2")]
		[Address(RVA = "0x1E54BC0", Offset = "0x1E54CC1", VA = "0x1E54BC0", Slot = "24")]
		get
		{
			return FocusObjectType.Default;
		}
	}

	// Token: 0x170005D4 RID: 1492
	// (get) Token: 0x0600238D RID: 9101 RVA: 0x0000E6B8 File Offset: 0x0000C8B8
	[Token(Token = "0x170004A6")]
	public int FocusPriority
	{
		[Token(Token = "0x6001DD3")]
		[Address(RVA = "0x1E54BD0", Offset = "0x1E54CD1", VA = "0x1E54BD0", Slot = "25")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170005D5 RID: 1493
	// (get) Token: 0x0600238E RID: 9102 RVA: 0x0000E6D0 File Offset: 0x0000C8D0
	[Token(Token = "0x170004A7")]
	public FocusPointType FocusPointType
	{
		[Token(Token = "0x6001DD4")]
		[Address(RVA = "0x1E54BE0", Offset = "0x1E54CE1", VA = "0x1E54BE0", Slot = "26")]
		get
		{
			return FocusPointType.HitPoint;
		}
	}

	// Token: 0x170005D6 RID: 1494
	// (get) Token: 0x0600238F RID: 9103 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002390 RID: 9104 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170004A8")]
	public ThrowController ThrowController
	{
		[Token(Token = "0x6001DD5")]
		[Address(RVA = "0x1E54BF0", Offset = "0x1E54CF1", VA = "0x1E54BF0", Slot = "32")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1270", Offset = "0x1A1371")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001DD6")]
		[Address(RVA = "0x1E54C00", Offset = "0x1E54D01", VA = "0x1E54C00")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1280", Offset = "0x1A1381")]
		private set
		{
		}
	}

	// Token: 0x06002391 RID: 9105 RVA: 0x0000E6E8 File Offset: 0x0000C8E8
	[Token(Token = "0x6001DD7")]
	[Address(RVA = "0x1E54C10", Offset = "0x1E54D11", VA = "0x1E54C10", Slot = "16")]
	public bool CanInteraction(HumanController character)
	{
		return default(bool);
	}

	// Token: 0x06002392 RID: 9106 RVA: 0x0000E700 File Offset: 0x0000C900
	[Token(Token = "0x6001DD8")]
	[Address(RVA = "0x1E54C60", Offset = "0x1E54D61", VA = "0x1E54C60", Slot = "39")]
	public bool CanRuckIn()
	{
		return default(bool);
	}

	// Token: 0x06002393 RID: 9107 RVA: 0x0000E718 File Offset: 0x0000C918
	[Token(Token = "0x6001DD9")]
	[Address(RVA = "0x1E54C70", Offset = "0x1E54D71", VA = "0x1E54C70", Slot = "38")]
	public bool CanPuton()
	{
		return default(bool);
	}

	// Token: 0x06002394 RID: 9108 RVA: 0x0000E730 File Offset: 0x0000C930
	[Token(Token = "0x6001DDA")]
	[Address(RVA = "0x1E54C80", Offset = "0x1E54D81", VA = "0x1E54C80", Slot = "33")]
	public bool CanThrow()
	{
		return default(bool);
	}

	// Token: 0x06002395 RID: 9109 RVA: 0x0000E748 File Offset: 0x0000C948
	[Token(Token = "0x6001DDB")]
	[Address(RVA = "0x1E54C90", Offset = "0x1E54D91", VA = "0x1E54C90", Slot = "40")]
	public bool OnTakeDamage(DamageResult result)
	{
		return default(bool);
	}

	// Token: 0x06002396 RID: 9110 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DDC")]
	[Address(RVA = "0x1E54CA0", Offset = "0x1E54DA1", VA = "0x1E54CA0", Slot = "15")]
	public void DoInteraction(HumanController character)
	{
	}

	// Token: 0x06002397 RID: 9111 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DDD")]
	[Address(RVA = "0x1E54CD0", Offset = "0x1E54DD1", VA = "0x1E54CD0", Slot = "20")]
	public string GetFocusName()
	{
		return null;
	}

	// Token: 0x06002398 RID: 9112 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DDE")]
	[Address(RVA = "0x1E54CE0", Offset = "0x1E54DE1", VA = "0x1E54CE0", Slot = "19")]
	public string GetInteractionButtonHint()
	{
		return null;
	}

	// Token: 0x06002399 RID: 9113 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DDF")]
	[Address(RVA = "0x1E54D30", Offset = "0x1E54E31", VA = "0x1E54D30", Slot = "23")]
	public void OffFocus()
	{
	}

	// Token: 0x0600239A RID: 9114 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DE0")]
	[Address(RVA = "0x1E54D40", Offset = "0x1E54E41", VA = "0x1E54D40", Slot = "22")]
	public void OnFocus()
	{
	}

	// Token: 0x0600239B RID: 9115 RVA: 0x0000E760 File Offset: 0x0000C960
	[Token(Token = "0x6001DE1")]
	[Address(RVA = "0x1E54D50", Offset = "0x1E54E51", VA = "0x1E54D50", Slot = "27")]
	public ushort GetInteractionType()
	{
		return 0;
	}

	// Token: 0x0600239C RID: 9116 RVA: 0x0000E778 File Offset: 0x0000C978
	[Token(Token = "0x6001DE2")]
	[Address(RVA = "0x1E54E00", Offset = "0x1E54F01", VA = "0x1E54E00", Slot = "41")]
	public ButtonInteractType GetInteractButtonType(FocusInterface focusInterface, ButtonInteractID buttonInteractID)
	{
		return ButtonInteractType.None;
	}

	// Token: 0x0600239D RID: 9117 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DE3")]
	[Address(RVA = "0x1E54FA0", Offset = "0x1E550A1", VA = "0x1E54FA0", Slot = "30")]
	public void OnHold()
	{
	}

	// Token: 0x0600239E RID: 9118 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DE4")]
	[Address(RVA = "0x1E55040", Offset = "0x1E55141", VA = "0x1E55040", Slot = "31")]
	public void OnPutOn()
	{
	}

	// Token: 0x0600239F RID: 9119 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DE5")]
	[Address(RVA = "0x1E550C0", Offset = "0x1E551C1", VA = "0x1E550C0")]
	private void OnBroken()
	{
	}

	// Token: 0x060023A0 RID: 9120 RVA: 0x0000E790 File Offset: 0x0000C990
	[Token(Token = "0x6001DE6")]
	[Address(RVA = "0x1E554C0", Offset = "0x1E555C1", VA = "0x1E554C0", Slot = "7")]
	public override bool TakeDamage(DamageInfo damageInfo, out DamageResult totalDamage)
	{
		return default(bool);
	}

	// Token: 0x060023A1 RID: 9121 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DE7")]
	[Address(RVA = "0x1E55580", Offset = "0x1E55681", VA = "0x1E55580", Slot = "34")]
	public void OnThrow()
	{
	}

	// Token: 0x060023A2 RID: 9122 RVA: 0x0000E7A8 File Offset: 0x0000C9A8
	[Token(Token = "0x6001DE8")]
	[Address(RVA = "0x1E55600", Offset = "0x1E55701", VA = "0x1E55600", Slot = "35")]
	public bool HitCheck(HitResult result, ThrowController throwController)
	{
		return default(bool);
	}

	// Token: 0x060023A3 RID: 9123 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DE9")]
	[Address(RVA = "0x1E559E0", Offset = "0x1E55AE1", VA = "0x1E559E0", Slot = "36")]
	public void OnPutOnByThrow()
	{
	}

	// Token: 0x060023A4 RID: 9124 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DEA")]
	[Address(RVA = "0x1E559F0", Offset = "0x1E55AF1", VA = "0x1E559F0", Slot = "17")]
	public void DoInteraction(MonsterControllerBase character)
	{
	}

	// Token: 0x060023A5 RID: 9125 RVA: 0x0000E7C0 File Offset: 0x0000C9C0
	[Token(Token = "0x6001DEB")]
	[Address(RVA = "0x1E55A00", Offset = "0x1E55B01", VA = "0x1E55A00", Slot = "18")]
	public bool CanInteraction(MonsterControllerBase character)
	{
		return default(bool);
	}

	// Token: 0x060023A6 RID: 9126 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DEC")]
	[Address(RVA = "0x1E550B0", Offset = "0x1E551B1", VA = "0x1E550B0", Slot = "42")]
	public void SetAlpha(float alpha)
	{
	}

	// Token: 0x060023A7 RID: 9127 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DED")]
	[Address(RVA = "0x1E55A10", Offset = "0x1E55B11", VA = "0x1E55A10")]
	public WoodenBox()
	{
	}

	// Token: 0x060023A9 RID: 9129 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DEF")]
	[Address(RVA = "0x1E55B10", Offset = "0x1E55C11", VA = "0x1E55B10", Slot = "28")]
	private GameObject get_gameObject()
	{
		return null;
	}

	// Token: 0x060023AA RID: 9130 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DF0")]
	[Address(RVA = "0x1E55B20", Offset = "0x1E55C21", VA = "0x1E55B20", Slot = "29")]
	private Transform get_transform()
	{
		return null;
	}

	// Token: 0x04006B32 RID: 27442
	[Token(Token = "0x4006489")]
	[FieldOffset(Offset = "0x0")]
	private static Vector3 ItemSpawnOffset;

	// Token: 0x04006B33 RID: 27443
	[Token(Token = "0x400648A")]
	private const string FoucsNameTextID = "FIELD_LAYOUT_OBJECT_NAME_00005";

	// Token: 0x04006B34 RID: 27444
	[Token(Token = "0x400648B")]
	[FieldOffset(Offset = "0x64")]
	private bool IsThrow;

	// Token: 0x04006B35 RID: 27445
	[Token(Token = "0x400648C")]
	[FieldOffset(Offset = "0x68")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1668F0", Offset = "0x1669F1")]
	private Renderer[] <ModelsMeshes>k__BackingField;

	// Token: 0x04006B36 RID: 27446
	[Token(Token = "0x400648D")]
	[FieldOffset(Offset = "0x70")]
	private MaterialPropertyBlock materialPropertyBlock;

	// Token: 0x04006B37 RID: 27447
	[Token(Token = "0x400648E")]
	[FieldOffset(Offset = "0x78")]
	private Collider[] Colliders;

	// Token: 0x04006B38 RID: 27448
	[Token(Token = "0x400648F")]
	[FieldOffset(Offset = "0x80")]
	private FieldWoodBoxSpawnID BoxSpawnID;

	// Token: 0x04006B39 RID: 27449
	[Token(Token = "0x4006490")]
	[FieldOffset(Offset = "0x84")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x166900", Offset = "0x166A01")]
	private ItemLotteryID <ItemLotteryID>k__BackingField;

	// Token: 0x04006B3A RID: 27450
	[Token(Token = "0x4006491")]
	[FieldOffset(Offset = "0x88")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x166910", Offset = "0x166A11")]
	private int <ModelID>k__BackingField;

	// Token: 0x04006B3B RID: 27451
	[Token(Token = "0x4006492")]
	[FieldOffset(Offset = "0x90")]
	protected string FocusName;

	// Token: 0x04006B3C RID: 27452
	[Token(Token = "0x4006493")]
	[FieldOffset(Offset = "0x98")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x166920", Offset = "0x166A21")]
	private ThrowController <ThrowController>k__BackingField;

	// Token: 0x04006B3D RID: 27453
	[Token(Token = "0x4006494")]
	[FieldOffset(Offset = "0xA0")]
	private bool DoneBroken;

	// Token: 0x04006B3E RID: 27454
	[Token(Token = "0x4006495")]
	[FieldOffset(Offset = "0xA1")]
	private bool IsDamaged;
}
