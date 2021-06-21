using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200035C RID: 860
[Token(Token = "0x200028A")]
[Serializable]
public class CraftGenreDataTableArray : ScriptableObject
{
	// Token: 0x17000408 RID: 1032
	// (get) Token: 0x06001671 RID: 5745 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001672 RID: 5746 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700039E")]
	public Dictionary<int, ItemID[]> m_GenreToItemsDic
	{
		[Token(Token = "0x60013E2")]
		[Address(RVA = "0x20E2930", Offset = "0x20E2A31", VA = "0x20E2930")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D430", Offset = "0x19D531")]
		get
		{
			return null;
		}
		[Token(Token = "0x60013E3")]
		[Address(RVA = "0x20E2940", Offset = "0x20E2A41", VA = "0x20E2940")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D440", Offset = "0x19D541")]
		private set
		{
		}
	}

	// Token: 0x17000409 RID: 1033
	// (get) Token: 0x06001673 RID: 5747 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001674 RID: 5748 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700039F")]
	public Dictionary<ItemID, ItemID> m_ItemIdToGenre
	{
		[Token(Token = "0x60013E4")]
		[Address(RVA = "0x20E2950", Offset = "0x20E2A51", VA = "0x20E2950")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D450", Offset = "0x19D551")]
		get
		{
			return null;
		}
		[Token(Token = "0x60013E5")]
		[Address(RVA = "0x20E2960", Offset = "0x20E2A61", VA = "0x20E2960")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D460", Offset = "0x19D561")]
		private set
		{
		}
	}

	// Token: 0x06001675 RID: 5749 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013E6")]
	[Address(RVA = "0x20E2400", Offset = "0x20E2501", VA = "0x20E2400")]
	public void Setup()
	{
	}

	// Token: 0x06001676 RID: 5750 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013E7")]
	[Address(RVA = "0x20E2970", Offset = "0x20E2A71", VA = "0x20E2970")]
	public CraftGenreDataTableArray()
	{
	}

	// Token: 0x04000E77 RID: 3703
	[Token(Token = "0x4000B56")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public CraftGenreDataTable[] DataTables;

	// Token: 0x04000E78 RID: 3704
	[Token(Token = "0x4000B57")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1612E0", Offset = "0x1613E1")]
	private Dictionary<int, ItemID[]> <m_GenreToItemsDic>k__BackingField;

	// Token: 0x04000E79 RID: 3705
	[Token(Token = "0x4000B58")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1612F0", Offset = "0x1613F1")]
	private Dictionary<ItemID, ItemID> <m_ItemIdToGenre>k__BackingField;
}
