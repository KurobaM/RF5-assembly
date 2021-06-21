using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020009D9 RID: 2521
[Token(Token = "0x200069A")]
public class UIEquipSlot : UIItemSlot
{
	// Token: 0x060041F4 RID: 16884 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003718")]
	[Address(RVA = "0x200EFF0", Offset = "0x200F0F1", VA = "0x200EFF0")]
	public void SetOwner(UIEquipSlot.SlotOwner owner)
	{
	}

	// Token: 0x1700091A RID: 2330
	// (get) Token: 0x060041F5 RID: 16885 RVA: 0x00016380 File Offset: 0x00014580
	[Token(Token = "0x1700074A")]
	public override bool IsEquipItemSlot
	{
		[Token(Token = "0x6003719")]
		[Address(RVA = "0x200F210", Offset = "0x200F311", VA = "0x200F210", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700091B RID: 2331
	// (get) Token: 0x060041F6 RID: 16886 RVA: 0x00016398 File Offset: 0x00014598
	[Token(Token = "0x1700074B")]
	public override EquipSlotType EquipSlotType
	{
		[Token(Token = "0x600371A")]
		[Address(RVA = "0x200F220", Offset = "0x200F321", VA = "0x200F220", Slot = "18")]
		get
		{
			return EquipSlotType.RuneRX;
		}
	}

	// Token: 0x060041F7 RID: 16887 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600371B")]
	[Address(RVA = "0x200F230", Offset = "0x200F331", VA = "0x200F230", Slot = "23")]
	protected override ItemData GetItemData()
	{
		return null;
	}

	// Token: 0x060041F8 RID: 16888 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600371C")]
	[Address(RVA = "0x200F300", Offset = "0x200F401", VA = "0x200F300", Slot = "24")]
	protected override void SetItemData(ItemData itemData)
	{
	}

	// Token: 0x060041F9 RID: 16889 RVA: 0x000163B0 File Offset: 0x000145B0
	[Token(Token = "0x600371D")]
	[Address(RVA = "0x200F3E0", Offset = "0x200F4E1", VA = "0x200F3E0")]
	private bool HoldingNotStorable()
	{
		return default(bool);
	}

	// Token: 0x060041FA RID: 16890 RVA: 0x000163C8 File Offset: 0x000145C8
	[Token(Token = "0x600371E")]
	[Address(RVA = "0x200F440", Offset = "0x200F541", VA = "0x200F440", Slot = "26")]
	public override bool FilterCheck(ItemData itemData)
	{
		return default(bool);
	}

	// Token: 0x060041FB RID: 16891 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600371F")]
	[Address(RVA = "0x200F670", Offset = "0x200F771", VA = "0x200F670", Slot = "27")]
	protected override void OnEnable()
	{
	}

	// Token: 0x060041FC RID: 16892 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003720")]
	[Address(RVA = "0x200F6C0", Offset = "0x200F7C1", VA = "0x200F6C0", Slot = "28")]
	public override void DoEquipInput(ActorID actorID, StorageType storageType)
	{
	}

	// Token: 0x060041FD RID: 16893 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003721")]
	[Address(RVA = "0x200F910", Offset = "0x200FA11", VA = "0x200F910")]
	public UIEquipSlot()
	{
	}

	// Token: 0x0400A0D4 RID: 41172
	[Token(Token = "0x400795D")]
	[FieldOffset(Offset = "0xD4")]
	[SerializeField]
	public UIEquipSlot.SlotOwner slotOwner;

	// Token: 0x0400A0D5 RID: 41173
	[Token(Token = "0x400795E")]
	[FieldOffset(Offset = "0xD8")]
	public ActorID actorID;

	// Token: 0x0400A0D6 RID: 41174
	[Token(Token = "0x400795F")]
	[FieldOffset(Offset = "0xDC")]
	[SerializeField]
	public EquipSlotType MyType;

	// Token: 0x0400A0D7 RID: 41175
	[Token(Token = "0x4007960")]
	[FieldOffset(Offset = "0xE0")]
	public ItemData EquipItemData;

	// Token: 0x020009DA RID: 2522
	[Token(Token = "0x20012C1")]
	public enum SlotOwner
	{
		// Token: 0x0400A0D9 RID: 41177
		[Token(Token = "0x401B3DB")]
		Player,
		// Token: 0x0400A0DA RID: 41178
		[Token(Token = "0x401B3DC")]
		Partner1,
		// Token: 0x0400A0DB RID: 41179
		[Token(Token = "0x401B3DD")]
		Partner2,
		// Token: 0x0400A0DC RID: 41180
		[Token(Token = "0x401B3DE")]
		Partner3,
		// Token: 0x0400A0DD RID: 41181
		[Token(Token = "0x401B3DF")]
		NPC,
		// Token: 0x0400A0DE RID: 41182
		[Token(Token = "0x401B3E0")]
		Max
	}

	// Token: 0x020009DB RID: 2523
	[Token(Token = "0x20012C2")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158F70", Offset = "0x159071")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x060041FF RID: 16895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075C1")]
		[Address(RVA = "0x200F990", Offset = "0x200FA91", VA = "0x200F990")]
		public <>c()
		{
		}

		// Token: 0x06004200 RID: 16896 RVA: 0x000163E0 File Offset: 0x000145E0
		[Token(Token = "0x60075C2")]
		[Address(RVA = "0x200F9A0", Offset = "0x200FAA1", VA = "0x200F9A0")]
		internal bool <SetOwner>b__3_0(PartyBase a)
		{
			return default(bool);
		}

		// Token: 0x0400A0DF RID: 41183
		[Token(Token = "0x401B3E1")]
		[FieldOffset(Offset = "0x0")]
		public static readonly UIEquipSlot.<>c <>9;

		// Token: 0x0400A0E0 RID: 41184
		[Token(Token = "0x401B3E2")]
		[FieldOffset(Offset = "0x8")]
		public static Predicate<PartyBase> <>9__3_0;
	}
}
