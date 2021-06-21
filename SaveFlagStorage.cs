using System;
using BinaryStream;
using Il2CppDummyDll;

// Token: 0x02000864 RID: 2148
[Token(Token = "0x2000588")]
public class SaveFlagStorage
{
	// Token: 0x170007F3 RID: 2035
	// (get) Token: 0x060038D5 RID: 14549 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060038D6 RID: 14550 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000638")]
	public byte[] Data
	{
		[Token(Token = "0x6002F59")]
		[Address(RVA = "0x21D3EF0", Offset = "0x21D3FF1", VA = "0x21D3EF0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5D70", Offset = "0x1A5E71")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002F5A")]
		[Address(RVA = "0x21D3F00", Offset = "0x21D4001", VA = "0x21D3F00")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5D80", Offset = "0x1A5E81")]
		private set
		{
		}
	}

	// Token: 0x170007F4 RID: 2036
	// (get) Token: 0x060038D7 RID: 14551 RVA: 0x00013B78 File Offset: 0x00011D78
	// (set) Token: 0x060038D8 RID: 14552 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000639")]
	public int Length
	{
		[Token(Token = "0x6002F5B")]
		[Address(RVA = "0x21D3F10", Offset = "0x21D4011", VA = "0x21D3F10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5D90", Offset = "0x1A5E91")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6002F5C")]
		[Address(RVA = "0x21D3F20", Offset = "0x21D4021", VA = "0x21D3F20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5DA0", Offset = "0x1A5EA1")]
		private set
		{
		}
	}

	// Token: 0x060038D9 RID: 14553 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002F5D")]
	[Address(RVA = "0x21D3F30", Offset = "0x21D4031", VA = "0x21D3F30")]
	public SaveFlagStorage(int length)
	{
	}

	// Token: 0x060038DA RID: 14554 RVA: 0x00013B90 File Offset: 0x00011D90
	[Token(Token = "0x6002F5E")]
	[Address(RVA = "0x21D4080", Offset = "0x21D4181", VA = "0x21D4080")]
	private int GetBitSize(int length)
	{
		return 0;
	}

	// Token: 0x060038DB RID: 14555 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002F5F")]
	[Address(RVA = "0x21D3F60", Offset = "0x21D4061", VA = "0x21D3F60")]
	public void Alloc(int length)
	{
	}

	// Token: 0x060038DC RID: 14556 RVA: 0x00013BA8 File Offset: 0x00011DA8
	[Token(Token = "0x6002F60")]
	[Address(RVA = "0x21D4090", Offset = "0x21D4191", VA = "0x21D4090")]
	public bool GetFlag(int id)
	{
		return default(bool);
	}

	// Token: 0x060038DD RID: 14557 RVA: 0x00013BC0 File Offset: 0x00011DC0
	[Token(Token = "0x6002F61")]
	[Address(RVA = "0x21D4100", Offset = "0x21D4201", VA = "0x21D4100")]
	public int SetFlag(int id, bool flag)
	{
		return 0;
	}

	// Token: 0x060038DE RID: 14558 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002F62")]
	[Address(RVA = "0x21D4180", Offset = "0x21D4281", VA = "0x21D4180")]
	public void SetZero()
	{
	}

	// Token: 0x060038DF RID: 14559 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002F63")]
	[Address(RVA = "0x21D41E0", Offset = "0x21D42E1", VA = "0x21D41E0")]
	public void Writer(BinaryWriter writer)
	{
	}

	// Token: 0x060038E0 RID: 14560 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002F64")]
	[Address(RVA = "0x21D4270", Offset = "0x21D4371", VA = "0x21D4270")]
	public void Reader(BinaryReader reader)
	{
	}

	// Token: 0x04007C34 RID: 31796
	[Token(Token = "0x4007047")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16D5A0", Offset = "0x16D6A1")]
	private byte[] <Data>k__BackingField;

	// Token: 0x04007C35 RID: 31797
	[Token(Token = "0x4007048")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16D5B0", Offset = "0x16D6B1")]
	private int <Length>k__BackingField;
}
