using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200088B RID: 2187
[Token(Token = "0x20005A6")]
public class StampDataTable : ScriptableObject
{
	// Token: 0x170007FF RID: 2047
	// (get) Token: 0x060039AD RID: 14765 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060039AE RID: 14766 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000644")]
	public List<StampData> DataTable
	{
		[Token(Token = "0x6003020")]
		[Address(RVA = "0x23885D0", Offset = "0x23886D1", VA = "0x23885D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5E90", Offset = "0x1A5F91")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003021")]
		[Address(RVA = "0x23885E0", Offset = "0x23886E1", VA = "0x23885E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5EA0", Offset = "0x1A5FA1")]
		private set
		{
		}
	}

	// Token: 0x060039AF RID: 14767 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003022")]
	[Address(RVA = "0x23885F0", Offset = "0x23886F1", VA = "0x23885F0")]
	public void Setup()
	{
	}

	// Token: 0x060039B0 RID: 14768 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003023")]
	[Address(RVA = "0x2388670", Offset = "0x2388771", VA = "0x2388670")]
	public void Clear()
	{
	}

	// Token: 0x060039B1 RID: 14769 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003024")]
	[Address(RVA = "0x23886E0", Offset = "0x23887E1", VA = "0x23886E0")]
	public StampDataTable()
	{
	}

	// Token: 0x04007CEB RID: 31979
	[Token(Token = "0x40070E9")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public List<StampData> StampDataList;

	// Token: 0x04007CEC RID: 31980
	[Token(Token = "0x40070EA")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16E370", Offset = "0x16E471")]
	private List<StampData> <DataTable>k__BackingField;
}
