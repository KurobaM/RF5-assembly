using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000427 RID: 1063
[Token(Token = "0x2000333")]
public class DummyInteraction : MonoBehaviour, InteractionInterface, FocusInterface
{
	// Token: 0x060019CA RID: 6602 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016F0")]
	[Address(RVA = "0x1E0EE80", Offset = "0x1E0EF81", VA = "0x1E0EE80")]
	private void Start()
	{
	}

	// Token: 0x060019CB RID: 6603 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016F1")]
	[Address(RVA = "0x1E0EE90", Offset = "0x1E0EF91", VA = "0x1E0EE90")]
	private void Update()
	{
	}

	// Token: 0x060019CC RID: 6604 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016F2")]
	[Address(RVA = "0x1E0EEA0", Offset = "0x1E0EFA1", VA = "0x1E0EEA0", Slot = "4")]
	public void DoInteraction(HumanController character)
	{
	}

	// Token: 0x060019CD RID: 6605 RVA: 0x0000B250 File Offset: 0x00009450
	[Token(Token = "0x60016F3")]
	[Address(RVA = "0x1E0EF20", Offset = "0x1E0F021", VA = "0x1E0EF20", Slot = "5")]
	public bool CanInteraction(HumanController character)
	{
		return default(bool);
	}

	// Token: 0x060019CE RID: 6606 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60016F4")]
	[Address(RVA = "0x1E0EF30", Offset = "0x1E0F031", VA = "0x1E0EF30", Slot = "8")]
	public string GetInteractionButtonHint()
	{
		return null;
	}

	// Token: 0x060019CF RID: 6607 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60016F5")]
	[Address(RVA = "0x1E0EF80", Offset = "0x1E0F081", VA = "0x1E0EF80", Slot = "9")]
	public string GetFocusName()
	{
		return null;
	}

	// Token: 0x17000463 RID: 1123
	// (get) Token: 0x060019D0 RID: 6608 RVA: 0x0000B268 File Offset: 0x00009468
	[Token(Token = "0x170003F3")]
	public bool Focusable
	{
		[Token(Token = "0x60016F6")]
		[Address(RVA = "0x1E0EFD0", Offset = "0x1E0F0D1", VA = "0x1E0EFD0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000464 RID: 1124
	// (get) Token: 0x060019D1 RID: 6609 RVA: 0x0000B280 File Offset: 0x00009480
	[Token(Token = "0x170003F4")]
	public FocusObjectType FocusObjectType
	{
		[Token(Token = "0x60016F7")]
		[Address(RVA = "0x1E0EFE0", Offset = "0x1E0F0E1", VA = "0x1E0EFE0", Slot = "13")]
		get
		{
			return FocusObjectType.Default;
		}
	}

	// Token: 0x17000465 RID: 1125
	// (get) Token: 0x060019D2 RID: 6610 RVA: 0x0000B298 File Offset: 0x00009498
	[Token(Token = "0x170003F5")]
	public int FocusPriority
	{
		[Token(Token = "0x60016F8")]
		[Address(RVA = "0x1E0EFF0", Offset = "0x1E0F0F1", VA = "0x1E0EFF0", Slot = "14")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000466 RID: 1126
	// (get) Token: 0x060019D3 RID: 6611 RVA: 0x0000B2B0 File Offset: 0x000094B0
	[Token(Token = "0x170003F6")]
	public FocusPointType FocusPointType
	{
		[Token(Token = "0x60016F9")]
		[Address(RVA = "0x1E0F000", Offset = "0x1E0F101", VA = "0x1E0F000", Slot = "15")]
		get
		{
			return FocusPointType.HitPoint;
		}
	}

	// Token: 0x060019D4 RID: 6612 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016FA")]
	[Address(RVA = "0x1E0F010", Offset = "0x1E0F111", VA = "0x1E0F010", Slot = "11")]
	public void OnFocus()
	{
	}

	// Token: 0x060019D5 RID: 6613 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016FB")]
	[Address(RVA = "0x1E0F020", Offset = "0x1E0F121", VA = "0x1E0F020", Slot = "12")]
	public void OffFocus()
	{
	}

	// Token: 0x060019D6 RID: 6614 RVA: 0x0000B2C8 File Offset: 0x000094C8
	[Token(Token = "0x60016FC")]
	[Address(RVA = "0x1E0F030", Offset = "0x1E0F131", VA = "0x1E0F030", Slot = "16")]
	public ushort GetInteractionType()
	{
		return 0;
	}

	// Token: 0x060019D7 RID: 6615 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016FD")]
	[Address(RVA = "0x1E0F040", Offset = "0x1E0F141", VA = "0x1E0F040", Slot = "6")]
	public void DoInteraction(MonsterControllerBase character)
	{
	}

	// Token: 0x060019D8 RID: 6616 RVA: 0x0000B2E0 File Offset: 0x000094E0
	[Token(Token = "0x60016FE")]
	[Address(RVA = "0x1E0F050", Offset = "0x1E0F151", VA = "0x1E0F050", Slot = "7")]
	public bool CanInteraction(MonsterControllerBase character)
	{
		return default(bool);
	}

	// Token: 0x060019D9 RID: 6617 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016FF")]
	[Address(RVA = "0x1E0F060", Offset = "0x1E0F161", VA = "0x1E0F060")]
	public DummyInteraction()
	{
	}

	// Token: 0x060019DA RID: 6618 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001700")]
	[Address(RVA = "0x1E0F070", Offset = "0x1E0F171", VA = "0x1E0F070", Slot = "17")]
	private GameObject get_gameObject()
	{
		return null;
	}

	// Token: 0x060019DB RID: 6619 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001701")]
	[Address(RVA = "0x1E0F080", Offset = "0x1E0F181", VA = "0x1E0F080", Slot = "18")]
	private Transform get_transform()
	{
		return null;
	}
}
