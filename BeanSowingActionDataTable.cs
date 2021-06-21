using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004F4 RID: 1268
[Token(Token = "0x200039F")]
public class BeanSowingActionDataTable : ScriptableObject
{
	// Token: 0x170004FF RID: 1279
	// (get) Token: 0x06001F0C RID: 7948 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001F0D RID: 7949 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700041F")]
	public List<BeanSowingActionTerm> DataTable
	{
		[Token(Token = "0x6001A94")]
		[Address(RVA = "0x2208AE0", Offset = "0x2208BE1", VA = "0x2208AE0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19F970", Offset = "0x19FA71")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001A95")]
		[Address(RVA = "0x2208AF0", Offset = "0x2208BF1", VA = "0x2208AF0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19F980", Offset = "0x19FA81")]
		private set
		{
		}
	}

	// Token: 0x06001F0E RID: 7950 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A96")]
	[Address(RVA = "0x2208B00", Offset = "0x2208C01", VA = "0x2208B00")]
	public void Setup()
	{
	}

	// Token: 0x06001F0F RID: 7951 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A97")]
	[Address(RVA = "0x2208B80", Offset = "0x2208C81", VA = "0x2208B80")]
	public void Clear()
	{
	}

	// Token: 0x06001F10 RID: 7952 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A98")]
	[Address(RVA = "0x2208BF0", Offset = "0x2208CF1", VA = "0x2208BF0")]
	public BeanSowingActionDataTable()
	{
	}

	// Token: 0x040065EF RID: 26095
	[Token(Token = "0x4006068")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public List<BeanSowingActionTerm> ActionTermList;

	// Token: 0x040065F0 RID: 26096
	[Token(Token = "0x4006069")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x165660", Offset = "0x165761")]
	private List<BeanSowingActionTerm> <DataTable>k__BackingField;
}
