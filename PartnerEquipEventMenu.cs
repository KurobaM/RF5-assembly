using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000A23 RID: 2595
[Token(Token = "0x20006CE")]
public class PartnerEquipEventMenu : CursorEvent
{
	// Token: 0x1700093A RID: 2362
	// (get) Token: 0x060043EC RID: 17388 RVA: 0x00016A88 File Offset: 0x00014C88
	[Token(Token = "0x17000766")]
	public override bool UseCANCEL
	{
		[Token(Token = "0x60038D8")]
		[Address(RVA = "0x2320900", Offset = "0x2320A01", VA = "0x2320900", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060043ED RID: 17389 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60038D9")]
	[Address(RVA = "0x2320910", Offset = "0x2320A11", VA = "0x2320910")]
	public void OpenWindows(UIEquipSlot.SlotOwner _owner, CursorLinker parameterMenu, FriendsMenuController _friendsMenuController)
	{
	}

	// Token: 0x060043EE RID: 17390 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60038DA")]
	[Address(RVA = "0x2320A40", Offset = "0x2320B41", VA = "0x2320A40")]
	public void Close()
	{
	}

	// Token: 0x060043EF RID: 17391 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60038DB")]
	[Address(RVA = "0x2320AB0", Offset = "0x2320BB1", VA = "0x2320AB0")]
	public PartnerEquipEventMenu()
	{
	}

	// Token: 0x0400A2E5 RID: 41701
	[Token(Token = "0x4007B1A")]
	[FieldOffset(Offset = "0x18")]
	private FriendsMenuController friendsMenuController;

	// Token: 0x0400A2E6 RID: 41702
	[Token(Token = "0x4007B1B")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private CursorLinker ParameterMenu;

	// Token: 0x0400A2E7 RID: 41703
	[Token(Token = "0x4007B1C")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private UIEquipSlot.SlotOwner owner;

	// Token: 0x0400A2E8 RID: 41704
	[Token(Token = "0x4007B1D")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private UIEquipSlot[] EquipSlots;
}
