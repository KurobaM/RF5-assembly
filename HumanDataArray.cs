using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;
using Loader.ID;
using UnityEngine;

// Token: 0x0200037F RID: 895
[Token(Token = "0x20002A9")]
[Serializable]
public class HumanDataArray
{
	// Token: 0x17000413 RID: 1043
	// (get) Token: 0x060016DB RID: 5851 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060016DC RID: 5852 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170003A9")]
	public Dictionary<HairType, Dictionary<VariationNo, HumanData>> DataTables
	{
		[Token(Token = "0x600144B")]
		[Address(RVA = "0x20A1B00", Offset = "0x20A1C01", VA = "0x20A1B00")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D490", Offset = "0x19D591")]
		get
		{
			return null;
		}
		[Token(Token = "0x600144C")]
		[Address(RVA = "0x20A1B10", Offset = "0x20A1C11", VA = "0x20A1B10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D4A0", Offset = "0x19D5A1")]
		private set
		{
		}
	}

	// Token: 0x060016DD RID: 5853 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600144D")]
	[Address(RVA = "0x20A1B20", Offset = "0x20A1C21", VA = "0x20A1B20")]
	public void Setup()
	{
	}

	// Token: 0x060016DE RID: 5854 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600144E")]
	[Address(RVA = "0x20A1E30", Offset = "0x20A1F31", VA = "0x20A1E30")]
	public void Clear()
	{
	}

	// Token: 0x060016DF RID: 5855 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600144F")]
	[Address(RVA = "0x20A1EA0", Offset = "0x20A1FA1", VA = "0x20A1EA0")]
	public HumanDataArray()
	{
	}

	// Token: 0x04000F5E RID: 3934
	[Token(Token = "0x4000C16")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public CharID CharId;

	// Token: 0x04000F5F RID: 3935
	[Token(Token = "0x4000C17")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public List<HumanData> HumanDatas;

	// Token: 0x04000F60 RID: 3936
	[Token(Token = "0x4000C18")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public Loader.ID.Character[] BaseId;

	// Token: 0x04000F61 RID: 3937
	[Token(Token = "0x4000C19")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x161B80", Offset = "0x161C81")]
	private Dictionary<HairType, Dictionary<VariationNo, HumanData>> <DataTables>k__BackingField;
}
