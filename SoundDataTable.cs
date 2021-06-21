using System;
using DataTable;
using Il2CppDummyDll;
using Loader.ID;
using UnityEngine;

// Token: 0x020003C6 RID: 966
[Token(Token = "0x20002E9")]
[Serializable]
public class SoundDataTable
{
	// Token: 0x0600177B RID: 6011 RVA: 0x0000A3F8 File Offset: 0x000085F8
	[Token(Token = "0x60014DF")]
	[Address(RVA = "0x2257850", Offset = "0x2257951", VA = "0x2257850")]
	public Audio AudioID_Lang()
	{
		return Audio.NONE;
	}

	// Token: 0x0600177C RID: 6012 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60014E0")]
	[Address(RVA = "0x22578A0", Offset = "0x22579A1", VA = "0x22578A0")]
	public static SoundDataTable GetDataTable(SoundID soundID)
	{
		return null;
	}

	// Token: 0x0600177D RID: 6013 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014E1")]
	[Address(RVA = "0x2257A00", Offset = "0x2257B01", VA = "0x2257A00")]
	public SoundDataTable()
	{
	}

	// Token: 0x040010C6 RID: 4294
	[Token(Token = "0x4000D6A")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public Audio AudioID;

	// Token: 0x040010C7 RID: 4295
	[Token(Token = "0x4000D6B")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	public Audio AudioID_Eng;

	// Token: 0x040010C8 RID: 4296
	[Token(Token = "0x4000D6C")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public SoundType SoundType;

	// Token: 0x040010C9 RID: 4297
	[Token(Token = "0x4000D6D")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	public float MinDistance;

	// Token: 0x040010CA RID: 4298
	[Token(Token = "0x4000D6E")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public float MaxDistance;

	// Token: 0x040010CB RID: 4299
	[Token(Token = "0x4000D6F")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	public bool IsLoop;

	// Token: 0x040010CC RID: 4300
	[Token(Token = "0x4000D70")]
	[FieldOffset(Offset = "0x25")]
	[SerializeField]
	public bool IsConcurrent;

	// Token: 0x040010CD RID: 4301
	[Token(Token = "0x4000D71")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Attribute(Name = "RangeAttribute", RVA = "0x162540", Offset = "0x162641")]
	public float Volume;

	// Token: 0x040010CE RID: 4302
	[Token(Token = "0x4000D72")]
	[FieldOffset(Offset = "0x0")]
	private static SoundDataTableArray _SoundDataTableArray;

	// Token: 0x020003C7 RID: 967
	[Token(Token = "0x2001066")]
	public enum SampleRate
	{
		// Token: 0x040010D0 RID: 4304
		[Token(Token = "0x4018FD0")]
		Hz8000 = 8000,
		// Token: 0x040010D1 RID: 4305
		[Token(Token = "0x4018FD1")]
		Hz11025 = 11025,
		// Token: 0x040010D2 RID: 4306
		[Token(Token = "0x4018FD2")]
		Hz22050 = 22050,
		// Token: 0x040010D3 RID: 4307
		[Token(Token = "0x4018FD3")]
		Hz44100 = 44100,
		// Token: 0x040010D4 RID: 4308
		[Token(Token = "0x4018FD4")]
		Hz48000 = 48000,
		// Token: 0x040010D5 RID: 4309
		[Token(Token = "0x4018FD5")]
		Hz96000 = 96000,
		// Token: 0x040010D6 RID: 4310
		[Token(Token = "0x4018FD6")]
		Hz192000 = 192000
	}
}
