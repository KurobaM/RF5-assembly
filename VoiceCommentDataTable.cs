using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000AFF RID: 2815
[Token(Token = "0x2000754")]
public class VoiceCommentDataTable : ScriptableObject
{
	// Token: 0x170009A7 RID: 2471
	// (get) Token: 0x060048EB RID: 18667 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060048EC RID: 18668 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170007B1")]
	public List<VoiceCommentData> DataTable
	{
		[Token(Token = "0x6003CF5")]
		[Address(RVA = "0x1E4A690", Offset = "0x1E4A791", VA = "0x1E4A690")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A86E0", Offset = "0x1A87E1")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003CF6")]
		[Address(RVA = "0x1E4A6A0", Offset = "0x1E4A7A1", VA = "0x1E4A6A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A86F0", Offset = "0x1A87F1")]
		private set
		{
		}
	}

	// Token: 0x060048ED RID: 18669 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003CF7")]
	[Address(RVA = "0x1E484C0", Offset = "0x1E485C1", VA = "0x1E484C0")]
	public void Setup()
	{
	}

	// Token: 0x060048EE RID: 18670 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003CF8")]
	[Address(RVA = "0x1E48890", Offset = "0x1E48991", VA = "0x1E48890")]
	public void Clear()
	{
	}

	// Token: 0x060048EF RID: 18671 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003CF9")]
	[Address(RVA = "0x1E4A6B0", Offset = "0x1E4A7B1", VA = "0x1E4A6B0")]
	public VoiceCommentDataTable()
	{
	}

	// Token: 0x0400A8CD RID: 43213
	[Token(Token = "0x4007F33")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public List<VoiceCommentData> VoiceCommentDataList;

	// Token: 0x0400A8CE RID: 43214
	[Token(Token = "0x4007F34")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x174300", Offset = "0x174401")]
	private List<VoiceCommentData> <DataTable>k__BackingField;
}
