using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000A89 RID: 2697
[Token(Token = "0x2000710")]
public class MovieRoomDataTable : ScriptableObject
{
	// Token: 0x17000972 RID: 2418
	// (get) Token: 0x0600464A RID: 17994 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600464B RID: 17995 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000794")]
	public List<MovieRoomData> DataTable
	{
		[Token(Token = "0x6003ACE")]
		[Address(RVA = "0x1E16F80", Offset = "0x1E17081", VA = "0x1E16F80")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7E60", Offset = "0x1A7F61")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003ACF")]
		[Address(RVA = "0x1E16F90", Offset = "0x1E17091", VA = "0x1E16F90")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7E70", Offset = "0x1A7F71")]
		private set
		{
		}
	}

	// Token: 0x0600464C RID: 17996 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003AD0")]
	[Address(RVA = "0x1E13680", Offset = "0x1E13781", VA = "0x1E13680")]
	public void Setup()
	{
	}

	// Token: 0x0600464D RID: 17997 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003AD1")]
	[Address(RVA = "0x1E16FA0", Offset = "0x1E170A1", VA = "0x1E16FA0")]
	public MovieRoomDataTable()
	{
	}

	// Token: 0x0400A54B RID: 42315
	[Token(Token = "0x4007CDD")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public List<MovieRoomData> MovieRoomDataList;

	// Token: 0x0400A54C RID: 42316
	[Token(Token = "0x4007CDE")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x173090", Offset = "0x173191")]
	private List<MovieRoomData> <DataTable>k__BackingField;
}
