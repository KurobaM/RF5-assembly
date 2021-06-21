using System;
using Define;
using Field;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200058C RID: 1420
[Token(Token = "0x20003FC")]
public class SnowmanBox : CharacterBase, FocusInterface
{
	// Token: 0x1700058E RID: 1422
	// (get) Token: 0x0600224C RID: 8780 RVA: 0x0000DF68 File Offset: 0x0000C168
	// (set) Token: 0x0600224D RID: 8781 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000472")]
	public ItemLotteryID ItemLotteryID
	{
		[Token(Token = "0x6001CE5")]
		[Address(RVA = "0x2253410", Offset = "0x2253511", VA = "0x2253410")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A0C70", Offset = "0x1A0D71")]
		get
		{
			return ItemLotteryID.WoodenBox_Debug;
		}
		[Token(Token = "0x6001CE6")]
		[Address(RVA = "0x2253420", Offset = "0x2253521", VA = "0x2253420")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A0C80", Offset = "0x1A0D81")]
		set
		{
		}
	}

	// Token: 0x0600224E RID: 8782 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001CE7")]
	[Address(RVA = "0x2253430", Offset = "0x2253531", VA = "0x2253430")]
	public void SetDataID(FieldWoodBoxSpawnID boxSpawnID)
	{
	}

	// Token: 0x0600224F RID: 8783 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001CE8")]
	[Address(RVA = "0x2253440", Offset = "0x2253541", VA = "0x2253440")]
	private void OnDestroy()
	{
	}

	// Token: 0x1700058F RID: 1423
	// (get) Token: 0x06002250 RID: 8784 RVA: 0x0000DF80 File Offset: 0x0000C180
	[Token(Token = "0x17000473")]
	public bool Focusable
	{
		[Token(Token = "0x6001CE9")]
		[Address(RVA = "0x2253510", Offset = "0x2253611", VA = "0x2253510", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000590 RID: 1424
	// (get) Token: 0x06002251 RID: 8785 RVA: 0x0000DF98 File Offset: 0x0000C198
	[Token(Token = "0x17000474")]
	public FocusObjectType FocusObjectType
	{
		[Token(Token = "0x6001CEA")]
		[Address(RVA = "0x22535A0", Offset = "0x22536A1", VA = "0x22535A0", Slot = "19")]
		get
		{
			return FocusObjectType.Default;
		}
	}

	// Token: 0x17000591 RID: 1425
	// (get) Token: 0x06002252 RID: 8786 RVA: 0x0000DFB0 File Offset: 0x0000C1B0
	[Token(Token = "0x17000475")]
	public int FocusPriority
	{
		[Token(Token = "0x6001CEB")]
		[Address(RVA = "0x22535B0", Offset = "0x22536B1", VA = "0x22535B0", Slot = "20")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000592 RID: 1426
	// (get) Token: 0x06002253 RID: 8787 RVA: 0x0000DFC8 File Offset: 0x0000C1C8
	[Token(Token = "0x17000476")]
	public FocusPointType FocusPointType
	{
		[Token(Token = "0x6001CEC")]
		[Address(RVA = "0x22535C0", Offset = "0x22536C1", VA = "0x22535C0", Slot = "21")]
		get
		{
			return FocusPointType.HitPoint;
		}
	}

	// Token: 0x06002254 RID: 8788 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CED")]
	[Address(RVA = "0x22535D0", Offset = "0x22536D1", VA = "0x22535D0", Slot = "15")]
	public string GetFocusName()
	{
		return null;
	}

	// Token: 0x06002255 RID: 8789 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CEE")]
	[Address(RVA = "0x22536C0", Offset = "0x22537C1", VA = "0x22536C0")]
	public string GetInteractionButtonHint()
	{
		return null;
	}

	// Token: 0x06002256 RID: 8790 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001CEF")]
	[Address(RVA = "0x2253710", Offset = "0x2253811", VA = "0x2253710", Slot = "18")]
	public void OffFocus()
	{
	}

	// Token: 0x06002257 RID: 8791 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001CF0")]
	[Address(RVA = "0x2253720", Offset = "0x2253821", VA = "0x2253720", Slot = "17")]
	public void OnFocus()
	{
	}

	// Token: 0x06002258 RID: 8792 RVA: 0x0000DFE0 File Offset: 0x0000C1E0
	[Token(Token = "0x6001CF1")]
	[Address(RVA = "0x2253730", Offset = "0x2253831", VA = "0x2253730", Slot = "22")]
	public ushort GetInteractionType()
	{
		return 0;
	}

	// Token: 0x06002259 RID: 8793 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001CF2")]
	[Address(RVA = "0x2253740", Offset = "0x2253841", VA = "0x2253740")]
	private void OnBroken()
	{
	}

	// Token: 0x0600225A RID: 8794 RVA: 0x0000DFF8 File Offset: 0x0000C1F8
	[Token(Token = "0x6001CF3")]
	[Address(RVA = "0x2253980", Offset = "0x2253A81", VA = "0x2253980", Slot = "7")]
	public override bool TakeDamage(DamageInfo damageInfo, out DamageResult totalDamage)
	{
		return default(bool);
	}

	// Token: 0x0600225B RID: 8795 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001CF4")]
	[Address(RVA = "0x2253A40", Offset = "0x2253B41", VA = "0x2253A40")]
	public SnowmanBox()
	{
	}

	// Token: 0x0600225C RID: 8796 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CF5")]
	[Address(RVA = "0x2253A50", Offset = "0x2253B51", VA = "0x2253A50", Slot = "23")]
	private GameObject get_gameObject()
	{
		return null;
	}

	// Token: 0x0600225D RID: 8797 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CF6")]
	[Address(RVA = "0x2253A60", Offset = "0x2253B61", VA = "0x2253A60", Slot = "24")]
	private Transform get_transform()
	{
		return null;
	}

	// Token: 0x04006A8C RID: 27276
	[Token(Token = "0x400641F")]
	private const string FoucsNameTextID = "FIELD_LAYOUT_OBJECT_NAME_00007";

	// Token: 0x04006A8D RID: 27277
	[Token(Token = "0x4006420")]
	[FieldOffset(Offset = "0x64")]
	private FieldWoodBoxSpawnID BoxSpawnID;

	// Token: 0x04006A8E RID: 27278
	[Token(Token = "0x4006421")]
	[FieldOffset(Offset = "0x68")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x166670", Offset = "0x166771")]
	private ItemLotteryID <ItemLotteryID>k__BackingField;

	// Token: 0x04006A8F RID: 27279
	[Token(Token = "0x4006422")]
	[FieldOffset(Offset = "0x6C")]
	private bool DoneBroken;

	// Token: 0x04006A90 RID: 27280
	[Token(Token = "0x4006423")]
	[FieldOffset(Offset = "0x6D")]
	private bool IsDamaged;
}
