using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000A88 RID: 2696
[Token(Token = "0x200070F")]
[Serializable]
public class MovieRoomData
{
	// Token: 0x06004649 RID: 17993 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003ACD")]
	[Address(RVA = "0x1E16F70", Offset = "0x1E17071", VA = "0x1E16F70")]
	public MovieRoomData()
	{
	}

	// Token: 0x0400A542 RID: 42306
	[Token(Token = "0x4007CD4")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public MovieID MovieID;

	// Token: 0x0400A543 RID: 42307
	[Token(Token = "0x4007CD5")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public string ScriptName;

	// Token: 0x0400A544 RID: 42308
	[Token(Token = "0x4007CD6")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public string StaffRollScript;

	// Token: 0x0400A545 RID: 42309
	[Token(Token = "0x4007CD7")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public string MoviePath;

	// Token: 0x0400A546 RID: 42310
	[Token(Token = "0x4007CD8")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	public SoundID MovieBGM;

	// Token: 0x0400A547 RID: 42311
	[Token(Token = "0x4007CD9")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	public SoundID MovieVoice;

	// Token: 0x0400A548 RID: 42312
	[Token(Token = "0x4007CDA")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	public string MovieNameText;

	// Token: 0x0400A549 RID: 42313
	[Token(Token = "0x4007CDB")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	public string MovieContentText;

	// Token: 0x0400A54A RID: 42314
	[Token(Token = "0x4007CDC")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	public string MoviePreviewImage;
}
