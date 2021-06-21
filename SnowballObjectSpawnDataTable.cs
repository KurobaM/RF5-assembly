using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200053D RID: 1341
[Token(Token = "0x20003CE")]
public class SnowballObjectSpawnDataTable : ScriptableObject
{
	// Token: 0x17000542 RID: 1346
	// (get) Token: 0x0600206A RID: 8298 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600206B RID: 8299 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000443")]
	public List<SnowballObjectSpawnTerm> DataTable
	{
		[Token(Token = "0x6001B8B")]
		[Address(RVA = "0x2252F60", Offset = "0x2253061", VA = "0x2252F60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A03F0", Offset = "0x1A04F1")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001B8C")]
		[Address(RVA = "0x2252F70", Offset = "0x2253071", VA = "0x2252F70")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A0400", Offset = "0x1A0501")]
		private set
		{
		}
	}

	// Token: 0x0600206C RID: 8300 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B8D")]
	[Address(RVA = "0x2252F80", Offset = "0x2253081", VA = "0x2252F80")]
	public void Setup()
	{
	}

	// Token: 0x0600206D RID: 8301 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B8E")]
	[Address(RVA = "0x2253000", Offset = "0x2253101", VA = "0x2253000")]
	public void Clear()
	{
	}

	// Token: 0x0600206E RID: 8302 RVA: 0x0000D578 File Offset: 0x0000B778
	[Token(Token = "0x6001B8F")]
	[Address(RVA = "0x2253070", Offset = "0x2253171", VA = "0x2253070")]
	public SnowmanObjectID Lottery(int _term, int _no)
	{
		return SnowmanObjectID.None;
	}

	// Token: 0x0600206F RID: 8303 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B90")]
	[Address(RVA = "0x2253330", Offset = "0x2253431", VA = "0x2253330")]
	public SnowballObjectSpawnDataTable()
	{
	}

	// Token: 0x04006753 RID: 26451
	[Token(Token = "0x4006158")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public List<SnowballObjectSpawnTerm> SpawnTermList;

	// Token: 0x04006754 RID: 26452
	[Token(Token = "0x4006159")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x165DE0", Offset = "0x165EE1")]
	private List<SnowballObjectSpawnTerm> <DataTable>k__BackingField;

	// Token: 0x0200053E RID: 1342
	[Token(Token = "0x20010F8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157D80", Offset = "0x157E81")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06002071 RID: 8305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FCB")]
		[Address(RVA = "0x22533B0", Offset = "0x22534B1", VA = "0x22533B0")]
		public <>c()
		{
		}

		// Token: 0x06002072 RID: 8306 RVA: 0x0000D590 File Offset: 0x0000B790
		[Token(Token = "0x6006FCC")]
		[Address(RVA = "0x22533C0", Offset = "0x22534C1", VA = "0x22533C0")]
		internal int <Lottery>b__7_0(SnowballObject x)
		{
			return 0;
		}

		// Token: 0x06002073 RID: 8307 RVA: 0x0000D5A8 File Offset: 0x0000B7A8
		[Token(Token = "0x6006FCD")]
		[Address(RVA = "0x22533E0", Offset = "0x22534E1", VA = "0x22533E0")]
		internal int <Lottery>b__7_1(SnowballObject x)
		{
			return 0;
		}

		// Token: 0x04006755 RID: 26453
		[Token(Token = "0x401926E")]
		[FieldOffset(Offset = "0x0")]
		public static readonly SnowballObjectSpawnDataTable.<>c <>9;

		// Token: 0x04006756 RID: 26454
		[Token(Token = "0x401926F")]
		[FieldOffset(Offset = "0x8")]
		public static Func<SnowballObject, int> <>9__7_0;

		// Token: 0x04006757 RID: 26455
		[Token(Token = "0x4019270")]
		[FieldOffset(Offset = "0x10")]
		public static Func<SnowballObject, int> <>9__7_1;
	}
}
