using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000926 RID: 2342
[Token(Token = "0x2000621")]
[Serializable]
public class BustupDataList : ScriptableObject
{
	// Token: 0x06003D54 RID: 15700 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600338C")]
	[Address(RVA = "0x219ACB0", Offset = "0x219ADB1", VA = "0x219ACB0")]
	public BustupDataList()
	{
	}

	// Token: 0x04007FA8 RID: 32680
	[Token(Token = "0x4007326")]
	[FieldOffset(Offset = "0x18")]
	public BustupDataList.DataTables[] Datas;

	// Token: 0x04007FA9 RID: 32681
	[Token(Token = "0x4007327")]
	[FieldOffset(Offset = "0x20")]
	public BustupDataList.MouthTable[] DefaultMouthTables;

	// Token: 0x02000927 RID: 2343
	[Token(Token = "0x2001287")]
	[Serializable]
	public class DataTable
	{
		// Token: 0x06003D55 RID: 15701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074AC")]
		[Address(RVA = "0x219AD50", Offset = "0x219AE51", VA = "0x219AD50")]
		public DataTable()
		{
		}

		// Token: 0x04007FAA RID: 32682
		[Token(Token = "0x40198E5")]
		[FieldOffset(Offset = "0x10")]
		public int Val1;

		// Token: 0x04007FAB RID: 32683
		[Token(Token = "0x40198E6")]
		[FieldOffset(Offset = "0x14")]
		public int Val2;

		// Token: 0x04007FAC RID: 32684
		[Token(Token = "0x40198E7")]
		[FieldOffset(Offset = "0x18")]
		public int PoseNo;

		// Token: 0x04007FAD RID: 32685
		[Token(Token = "0x40198E8")]
		[FieldOffset(Offset = "0x1C")]
		public int LoadID;
	}

	// Token: 0x02000928 RID: 2344
	[Token(Token = "0x2001288")]
	[Serializable]
	public class DataTables
	{
		// Token: 0x06003D56 RID: 15702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074AD")]
		[Address(RVA = "0x219AD60", Offset = "0x219AE61", VA = "0x219AD60")]
		public DataTables()
		{
		}

		// Token: 0x04007FAE RID: 32686
		[Token(Token = "0x40198E9")]
		[FieldOffset(Offset = "0x10")]
		public List<BustupDataList.DataTable> Data;
	}

	// Token: 0x02000929 RID: 2345
	[Token(Token = "0x2001289")]
	[Serializable]
	public class MouthTable
	{
		// Token: 0x06003D57 RID: 15703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074AE")]
		[Address(RVA = "0x219AD70", Offset = "0x219AE71", VA = "0x219AD70")]
		public MouthTable(List<int> varlist)
		{
		}

		// Token: 0x06003D58 RID: 15704 RVA: 0x00015420 File Offset: 0x00013620
		[Token(Token = "0x60074AF")]
		[Address(RVA = "0x219AFB0", Offset = "0x219B0B1", VA = "0x219AFB0")]
		public int GetVar(int faceVar, int poseVar)
		{
			return 0;
		}

		// Token: 0x04007FAF RID: 32687
		[Token(Token = "0x40198EA")]
		[FieldOffset(Offset = "0x10")]
		public int[] BaseFaces;

		// Token: 0x04007FB0 RID: 32688
		[Token(Token = "0x40198EB")]
		[FieldOffset(Offset = "0x18")]
		public int Spose1;

		// Token: 0x04007FB1 RID: 32689
		[Token(Token = "0x40198EC")]
		[FieldOffset(Offset = "0x1C")]
		public int Spose2;
	}
}
