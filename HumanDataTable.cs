using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;
using Loader.ID;
using UnityEngine;

// Token: 0x02000380 RID: 896
[Token(Token = "0x20002AA")]
[Serializable]
public class HumanDataTable : ScriptableObject
{
	// Token: 0x17000414 RID: 1044
	// (get) Token: 0x060016E0 RID: 5856 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060016E1 RID: 5857 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170003AA")]
	public Dictionary<CharID, HumanDataArray> DataTables
	{
		[Token(Token = "0x6001450")]
		[Address(RVA = "0x20A1F10", Offset = "0x20A2011", VA = "0x20A1F10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D4B0", Offset = "0x19D5B1")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001451")]
		[Address(RVA = "0x20A1F20", Offset = "0x20A2021", VA = "0x20A1F20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D4C0", Offset = "0x19D5C1")]
		private set
		{
		}
	}

	// Token: 0x060016E2 RID: 5858 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001452")]
	[Address(RVA = "0x20A1F30", Offset = "0x20A2031", VA = "0x20A1F30")]
	public void Setup()
	{
	}

	// Token: 0x060016E3 RID: 5859 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001453")]
	[Address(RVA = "0x20A2100", Offset = "0x20A2201", VA = "0x20A2100")]
	public void Clear()
	{
	}

	// Token: 0x060016E4 RID: 5860 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001454")]
	[Address(RVA = "0x20A2160", Offset = "0x20A2261", VA = "0x20A2160")]
	public HumanData GetHumanData(CharID char_id, VariationNo variation_no, HairType hair_type)
	{
		return null;
	}

	// Token: 0x060016E5 RID: 5861 RVA: 0x0000A158 File Offset: 0x00008358
	[Token(Token = "0x6001455")]
	[Address(RVA = "0x20A2280", Offset = "0x20A2381", VA = "0x20A2280")]
	public Loader.ID.Character GetBaseLoaderId(ActorType actor_type, CharID char_id)
	{
		return Loader.ID.Character.NONE;
	}

	// Token: 0x060016E6 RID: 5862 RVA: 0x0000A170 File Offset: 0x00008370
	[Token(Token = "0x6001456")]
	[Address(RVA = "0x20A2350", Offset = "0x20A2451", VA = "0x20A2350")]
	public Loader.ID.Character GetCharacterLoaderId(CharID char_id, VariationNo variation_no, HairType hair_type)
	{
		return Loader.ID.Character.NONE;
	}

	// Token: 0x060016E7 RID: 5863 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001457")]
	[Address(RVA = "0x20A2370", Offset = "0x20A2471", VA = "0x20A2370")]
	public HumanDataTable()
	{
	}

	// Token: 0x04000F62 RID: 3938
	[Token(Token = "0x4000C1A")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public List<HumanDataArray> HumanDatas;

	// Token: 0x04000F63 RID: 3939
	[Token(Token = "0x4000C1B")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x161BA0", Offset = "0x161CA1")]
	private Dictionary<CharID, HumanDataArray> <DataTables>k__BackingField;
}
