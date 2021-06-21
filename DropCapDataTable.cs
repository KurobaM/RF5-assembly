using System;
using DataTable;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000363 RID: 867
[Token(Token = "0x2000291")]
[Serializable]
public class DropCapDataTable
{
	// Token: 0x1700040B RID: 1035
	// (get) Token: 0x06001694 RID: 5780 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001695 RID: 5781 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170003A1")]
	private static DropCapDataTableArray _Instance
	{
		[Token(Token = "0x6001405")]
		[Address(RVA = "0x1E03330", Offset = "0x1E03431", VA = "0x1E03330")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D470", Offset = "0x19D571")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001406")]
		[Address(RVA = "0x1E033A0", Offset = "0x1E034A1", VA = "0x1E033A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D480", Offset = "0x19D581")]
		set
		{
		}
	}

	// Token: 0x1700040C RID: 1036
	// (get) Token: 0x06001696 RID: 5782 RVA: 0x0000A020 File Offset: 0x00008220
	[Token(Token = "0x170003A2")]
	public static int NoDropTresureCap
	{
		[Token(Token = "0x6001407")]
		[Address(RVA = "0x1E03410", Offset = "0x1E03511", VA = "0x1E03410")]
		get
		{
			return 0;
		}
	}

	// Token: 0x1700040D RID: 1037
	// (get) Token: 0x06001697 RID: 5783 RVA: 0x0000A038 File Offset: 0x00008238
	[Token(Token = "0x170003A3")]
	public static int HiDropCap
	{
		[Token(Token = "0x6001408")]
		[Address(RVA = "0x1E034F0", Offset = "0x1E035F1", VA = "0x1E034F0")]
		get
		{
			return 0;
		}
	}

	// Token: 0x1700040E RID: 1038
	// (get) Token: 0x06001698 RID: 5784 RVA: 0x0000A050 File Offset: 0x00008250
	[Token(Token = "0x170003A4")]
	public static int Legendary
	{
		[Token(Token = "0x6001409")]
		[Address(RVA = "0x1E035D0", Offset = "0x1E036D1", VA = "0x1E035D0")]
		get
		{
			return 0;
		}
	}

	// Token: 0x1700040F RID: 1039
	// (get) Token: 0x06001699 RID: 5785 RVA: 0x0000A068 File Offset: 0x00008268
	[Token(Token = "0x170003A5")]
	public static int NoDropCap
	{
		[Token(Token = "0x600140A")]
		[Address(RVA = "0x1E036B0", Offset = "0x1E037B1", VA = "0x1E036B0")]
		get
		{
			return 0;
		}
	}

	// Token: 0x0600169A RID: 5786 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600140B")]
	[Address(RVA = "0x1E03790", Offset = "0x1E03891", VA = "0x1E03790")]
	public static void Init()
	{
	}

	// Token: 0x0600169B RID: 5787 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600140C")]
	[Address(RVA = "0x1E039A0", Offset = "0x1E03AA1", VA = "0x1E039A0")]
	public static DropCapDataTable GetDataTable(DropCapID id)
	{
		return null;
	}

	// Token: 0x0600169C RID: 5788 RVA: 0x0000A080 File Offset: 0x00008280
	[Token(Token = "0x600140D")]
	[Address(RVA = "0x1E03B80", Offset = "0x1E03C81", VA = "0x1E03B80")]
	public static int CalcNowCap()
	{
		return 0;
	}

	// Token: 0x0600169D RID: 5789 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600140E")]
	[Address(RVA = "0x1E03E90", Offset = "0x1E03F91", VA = "0x1E03E90")]
	public DropCapDataTable()
	{
	}

	// Token: 0x04000E9A RID: 3738
	[Token(Token = "0x4000B79")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public GameFlagData GameFlagData;

	// Token: 0x04000E9B RID: 3739
	[Token(Token = "0x4000B7A")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	public int DropCap;

	// Token: 0x04000E9C RID: 3740
	[Token(Token = "0x4000B7B")]
	[FieldOffset(Offset = "0x0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x161480", Offset = "0x161581")]
	private static DropCapDataTableArray <_Instance>k__BackingField;
}
