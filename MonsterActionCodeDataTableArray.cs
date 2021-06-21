using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000094 RID: 148
[Token(Token = "0x2000072")]
public class MonsterActionCodeDataTableArray : ScriptableObject
{
	// Token: 0x060002DD RID: 733 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600022E")]
	[Address(RVA = "0x1D832B0", Offset = "0x1D833B1", VA = "0x1D832B0")]
	public MonsterActionCodeDataTable GetActionCodeDataTable(string name)
	{
		return null;
	}

	// Token: 0x060002DE RID: 734 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600022F")]
	[Address(RVA = "0x1D83390", Offset = "0x1D83491", VA = "0x1D83390")]
	public MonsterActionCodeDataTableArray()
	{
	}

	// Token: 0x04000212 RID: 530
	[Token(Token = "0x40001A7")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public MonsterActionCodeDataTable[] ActionCodeDataTables;

	// Token: 0x02000095 RID: 149
	[Token(Token = "0x2000FAC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157030", Offset = "0x157131")]
	private sealed class <>c__DisplayClass1_0
	{
		// Token: 0x060002DF RID: 735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B9A")]
		[Address(RVA = "0x1D83380", Offset = "0x1D83481", VA = "0x1D83380")]
		public <>c__DisplayClass1_0()
		{
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x00002E08 File Offset: 0x00001008
		[Token(Token = "0x6006B9B")]
		[Address(RVA = "0x1D833A0", Offset = "0x1D834A1", VA = "0x1D833A0")]
		internal bool <GetActionCodeDataTable>b__0(MonsterActionCodeDataTable data)
		{
			return default(bool);
		}

		// Token: 0x04000213 RID: 531
		[Token(Token = "0x4018CE3")]
		[FieldOffset(Offset = "0x10")]
		public string name;
	}
}
