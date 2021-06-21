using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200096C RID: 2412
[Token(Token = "0x2000652")]
public class MonsterUIData : ScriptableObject
{
	// Token: 0x06003F8E RID: 16270 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60034E3")]
	[Address(RVA = "0x1E72FA0", Offset = "0x1E730A1", VA = "0x1E72FA0")]
	public MonsterUIData()
	{
	}

	// Token: 0x04008276 RID: 33398
	[Token(Token = "0x400756B")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public MonsterUIData.Data[] datas;

	// Token: 0x0200096D RID: 2413
	[Token(Token = "0x200129C")]
	[Serializable]
	public struct Data
	{
		// Token: 0x04008277 RID: 33399
		[Token(Token = "0x401996E")]
		[FieldOffset(Offset = "0x0")]
		public string DataName;

		// Token: 0x04008278 RID: 33400
		[Token(Token = "0x401996F")]
		[FieldOffset(Offset = "0x8")]
		public int sizeScale;

		// Token: 0x04008279 RID: 33401
		[Token(Token = "0x4019970")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x0400827A RID: 33402
		[Token(Token = "0x4019971")]
		[FieldOffset(Offset = "0x18")]
		public List<string> nickNameList;

		// Token: 0x0400827B RID: 33403
		[Token(Token = "0x4019972")]
		[FieldOffset(Offset = "0x20")]
		public string discript;
	}
}
