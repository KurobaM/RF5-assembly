using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000554 RID: 1364
[Token(Token = "0x20003DE")]
public class SoundPlayTime : MonoBehaviour
{
	// Token: 0x06002110 RID: 8464 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C15")]
	[Address(RVA = "0x225D120", Offset = "0x225D221", VA = "0x225D120")]
	private void Start()
	{
	}

	// Token: 0x06002111 RID: 8465 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C16")]
	[Address(RVA = "0x225D220", Offset = "0x225D321", VA = "0x225D220")]
	private void Update()
	{
	}

	// Token: 0x06002112 RID: 8466 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C17")]
	[Address(RVA = "0x225D360", Offset = "0x225D461", VA = "0x225D360")]
	public SoundPlayTime()
	{
	}

	// Token: 0x040067D0 RID: 26576
	[Token(Token = "0x40061B8")]
	[FieldOffset(Offset = "0x18")]
	public bool playOnAwake;

	// Token: 0x040067D1 RID: 26577
	[Token(Token = "0x40061B9")]
	[FieldOffset(Offset = "0x19")]
	public bool loopCheck;

	// Token: 0x040067D2 RID: 26578
	[Token(Token = "0x40061BA")]
	[FieldOffset(Offset = "0x1C")]
	private float timer;

	// Token: 0x040067D3 RID: 26579
	[Token(Token = "0x40061BB")]
	[FieldOffset(Offset = "0x20")]
	public float waitTime;

	// Token: 0x040067D4 RID: 26580
	[Token(Token = "0x40061BC")]
	[FieldOffset(Offset = "0x24")]
	private float loopTime;

	// Token: 0x040067D5 RID: 26581
	[Token(Token = "0x40061BD")]
	[FieldOffset(Offset = "0x28")]
	public float loopWaitTime;

	// Token: 0x040067D6 RID: 26582
	[Token(Token = "0x40061BE")]
	[FieldOffset(Offset = "0x2C")]
	private bool flag;

	// Token: 0x040067D7 RID: 26583
	[Token(Token = "0x40061BF")]
	[FieldOffset(Offset = "0x30")]
	public float volume;

	// Token: 0x040067D8 RID: 26584
	[Token(Token = "0x40061C0")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private SoundID SoundID;
}
