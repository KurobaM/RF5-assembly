using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000089 RID: 137
[Token(Token = "0x2000069")]
[Serializable]
public class CommandArgument
{
	// Token: 0x0600026F RID: 623 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000219")]
	public T GetEnum<T>() where T : struct
	{
		return null;
	}

	// Token: 0x1700006A RID: 106
	// (get) Token: 0x06000270 RID: 624 RVA: 0x00002D48 File Offset: 0x00000F48
	[Token(Token = "0x17000067")]
	public Vector3 Vector3
	{
		[Token(Token = "0x600021A")]
		[Address(RVA = "0x20DAF10", Offset = "0x20DB011", VA = "0x20DAF10")]
		get
		{
			return default(Vector3);
		}
	}

	// Token: 0x1700006B RID: 107
	// (get) Token: 0x06000271 RID: 625 RVA: 0x00002D60 File Offset: 0x00000F60
	[Token(Token = "0x17000068")]
	public Vector2 Vector2
	{
		[Token(Token = "0x600021B")]
		[Address(RVA = "0x20DB0D0", Offset = "0x20DB1D1", VA = "0x20DB0D0")]
		get
		{
			return default(Vector2);
		}
	}

	// Token: 0x06000272 RID: 626 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600021C")]
	public static T GetEnum<T>(CommandArgument commandArgument) where T : struct
	{
		return null;
	}

	// Token: 0x06000273 RID: 627 RVA: 0x00002D78 File Offset: 0x00000F78
	[Token(Token = "0x600021D")]
	[Address(RVA = "0x20DAF20", Offset = "0x20DB021", VA = "0x20DAF20")]
	public static Vector3 ParseVector3(CommandArgument commandArgument)
	{
		return default(Vector3);
	}

	// Token: 0x06000274 RID: 628 RVA: 0x00002D90 File Offset: 0x00000F90
	[Token(Token = "0x600021E")]
	[Address(RVA = "0x20DB0E0", Offset = "0x20DB1E1", VA = "0x20DB0E0")]
	public static Vector2 ParseVector2(CommandArgument commandArgument)
	{
		return default(Vector2);
	}

	// Token: 0x06000275 RID: 629 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600021F")]
	[Address(RVA = "0x20DB2A0", Offset = "0x20DB3A1", VA = "0x20DB2A0")]
	public CommandArgument()
	{
	}

	// Token: 0x040001FF RID: 511
	[Token(Token = "0x4000195")]
	[FieldOffset(Offset = "0x10")]
	public string String;

	// Token: 0x04000200 RID: 512
	[Token(Token = "0x4000196")]
	[FieldOffset(Offset = "0x18")]
	public float Float;

	// Token: 0x04000201 RID: 513
	[Token(Token = "0x4000197")]
	[FieldOffset(Offset = "0x1C")]
	public bool Bool;
}
