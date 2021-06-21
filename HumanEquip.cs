using System;
using Il2CppDummyDll;

// Token: 0x0200085F RID: 2143
[Token(Token = "0x2000583")]
[Attribute(Name = "DefaultMemberAttribute", RVA = "0x146690", Offset = "0x146791")]
[Attribute(Name = "MessagePackObjectAttribute", RVA = "0x146690", Offset = "0x146791")]
public class HumanEquip
{
	// Token: 0x170007EC RID: 2028
	// (get) Token: 0x060038B6 RID: 14518 RVA: 0x00013AA0 File Offset: 0x00011CA0
	// (set) Token: 0x060038B7 RID: 14519 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000631")]
	[Attribute(Name = "IgnoreMemberAttribute", RVA = "0x1B87D0", Offset = "0x1B88D1")]
	public EquipSlotType CurrentWeaponSlot
	{
		[Token(Token = "0x6002F3A")]
		[Address(RVA = "0x20A2650", Offset = "0x20A2751", VA = "0x20A2650")]
		get
		{
			return EquipSlotType.RuneRX;
		}
		[Token(Token = "0x6002F3B")]
		[Address(RVA = "0x209D620", Offset = "0x209D721", VA = "0x209D620")]
		set
		{
		}
	}

	// Token: 0x170007ED RID: 2029
	// (get) Token: 0x060038B8 RID: 14520 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060038B9 RID: 14521 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000632")]
	[Attribute(Name = "IgnoreMemberAttribute", RVA = "0x1B87E0", Offset = "0x1B88E1")]
	public ItemData Item
	{
		[Token(Token = "0x6002F3C")]
		[Address(RVA = "0x20A2660", Offset = "0x20A2761", VA = "0x20A2660")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002F3D")]
		[Address(RVA = "0x209D250", Offset = "0x209D351", VA = "0x209D250")]
		set
		{
		}
	}

	// Token: 0x170007EE RID: 2030
	// (get) Token: 0x060038BA RID: 14522 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060038BB RID: 14523 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000633")]
	[Attribute(Name = "IgnoreMemberAttribute", RVA = "0x1B87F0", Offset = "0x1B88F1")]
	public ItemData Item
	{
		[Token(Token = "0x6002F3E")]
		[Address(RVA = "0x20A26A0", Offset = "0x20A27A1", VA = "0x20A26A0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002F3F")]
		[Address(RVA = "0x20A26E0", Offset = "0x20A27E1", VA = "0x20A26E0")]
		set
		{
		}
	}

	// Token: 0x060038BC RID: 14524 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002F40")]
	[Address(RVA = "0x20959E0", Offset = "0x2095AE1", VA = "0x20959E0")]
	public ItemData GetCurrentWeapon()
	{
		return null;
	}

	// Token: 0x170007EF RID: 2031
	// (get) Token: 0x060038BD RID: 14525 RVA: 0x00013AB8 File Offset: 0x00011CB8
	[Token(Token = "0x17000634")]
	[Attribute(Name = "IgnoreMemberAttribute", RVA = "0x1B8800", Offset = "0x1B8901")]
	public int Length
	{
		[Token(Token = "0x6002F41")]
		[Address(RVA = "0x20A2760", Offset = "0x20A2861", VA = "0x20A2760")]
		get
		{
			return 0;
		}
	}

	// Token: 0x060038BE RID: 14526 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002F42")]
	[Address(RVA = "0x20A2780", Offset = "0x20A2881", VA = "0x20A2780")]
	[Attribute(Name = "SerializationConstructorAttribute", RVA = "0x1A5D50", Offset = "0x1A5E51")]
	public HumanEquip()
	{
	}

	// Token: 0x060038BF RID: 14527 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002F43")]
	[Address(RVA = "0x20A2800", Offset = "0x20A2901", VA = "0x20A2800")]
	public HumanEquip GetClone()
	{
		return null;
	}

	// Token: 0x060038C0 RID: 14528 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002F44")]
	[Address(RVA = "0x209D020", Offset = "0x209D121", VA = "0x209D020")]
	public ItemData Pop(EquipSlotType slotType)
	{
		return null;
	}

	// Token: 0x060038C1 RID: 14529 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002F45")]
	[Address(RVA = "0x209D200", Offset = "0x209D301", VA = "0x209D200")]
	public ItemData Set(EquipSlotType slotType, ItemData pushData)
	{
		return null;
	}

	// Token: 0x04007BE5 RID: 31717
	[Token(Token = "0x4006FF8")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16C670", Offset = "0x16C771")]
	public ItemData[] EquipItems;

	// Token: 0x04007BE6 RID: 31718
	[Token(Token = "0x4006FF9")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "IgnoreMemberAttribute", RVA = "0x16C6B0", Offset = "0x16C7B1")]
	private EquipSlotType _CurrentWeaponSlot;
}
