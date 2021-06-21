using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200095F RID: 2399
[Token(Token = "0x200064A")]
public class CharaCallTable : ScriptableObject
{
	// Token: 0x06003F87 RID: 16263 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60034DC")]
	[Address(RVA = "0x1E82B10", Offset = "0x1E82C11", VA = "0x1E82B10")]
	public CharaCallTable()
	{
	}

	// Token: 0x04008120 RID: 33056
	[Token(Token = "0x4007428")]
	[FieldOffset(Offset = "0x18")]
	public List<CharaCallTable.BustupTable> bustupTables;

	// Token: 0x04008121 RID: 33057
	[Token(Token = "0x4007429")]
	[FieldOffset(Offset = "0x20")]
	public List<CharaCallTable.CharaFaceIconTable> charaFaceIconTables;

	// Token: 0x02000960 RID: 2400
	[Token(Token = "0x2001297")]
	public struct BustupTable
	{
		// Token: 0x04008122 RID: 33058
		[Token(Token = "0x401995B")]
		[FieldOffset(Offset = "0x0")]
		private int CharaNo;

		// Token: 0x04008123 RID: 33059
		[Token(Token = "0x401995C")]
		[FieldOffset(Offset = "0x4")]
		private int PostNo;

		// Token: 0x04008124 RID: 33060
		[Token(Token = "0x401995D")]
		[FieldOffset(Offset = "0x8")]
		private int SubVarNo;

		// Token: 0x04008125 RID: 33061
		[Token(Token = "0x401995E")]
		[FieldOffset(Offset = "0xC")]
		private int DataNo;
	}

	// Token: 0x02000961 RID: 2401
	[Token(Token = "0x2001298")]
	public struct CharaFaceIconTable
	{
		// Token: 0x04008126 RID: 33062
		[Token(Token = "0x401995F")]
		[FieldOffset(Offset = "0x0")]
		private int CharaNo;

		// Token: 0x04008127 RID: 33063
		[Token(Token = "0x4019960")]
		[FieldOffset(Offset = "0x4")]
		private int SubVarNo;

		// Token: 0x04008128 RID: 33064
		[Token(Token = "0x4019961")]
		[FieldOffset(Offset = "0x8")]
		private int DataNo;
	}
}
