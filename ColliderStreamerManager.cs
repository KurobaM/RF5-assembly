using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000BA7 RID: 2983
[Token(Token = "0x20007BC")]
public class ColliderStreamerManager : MonoBehaviour
{
	// Token: 0x06004C5F RID: 19551 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600400C")]
	[Address(RVA = "0x1EA2810", Offset = "0x1EA2911", VA = "0x1EA2810")]
	public void AddColliderStreamer(ColliderStreamer colliderStreamer)
	{
	}

	// Token: 0x06004C60 RID: 19552 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600400D")]
	[Address(RVA = "0x1EA2420", Offset = "0x1EA2521", VA = "0x1EA2420")]
	public void AddColliderScene(ColliderScene colliderScene)
	{
	}

	// Token: 0x06004C61 RID: 19553 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600400E")]
	[Address(RVA = "0x1EA2B90", Offset = "0x1EA2C91", VA = "0x1EA2B90")]
	public void Update()
	{
	}

	// Token: 0x06004C62 RID: 19554 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600400F")]
	[Address(RVA = "0x1EA2CA0", Offset = "0x1EA2DA1", VA = "0x1EA2CA0")]
	public ColliderStreamerManager()
	{
	}

	// Token: 0x0400ADC8 RID: 44488
	[Token(Token = "0x40082F1")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x175FC0", Offset = "0x1760C1")]
	public Transform player;

	// Token: 0x0400ADC9 RID: 44489
	[Token(Token = "0x40082F2")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x176000", Offset = "0x176101")]
	public bool spawnedPlayer;

	// Token: 0x0400ADCA RID: 44490
	[Token(Token = "0x40082F3")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "HideInInspector", RVA = "0x176040", Offset = "0x176141")]
	public string playerTag;

	// Token: 0x0400ADCB RID: 44491
	[Token(Token = "0x40082F4")]
	[FieldOffset(Offset = "0x0")]
	public static string COLLIDERSTREAMERMANAGERTAG;

	// Token: 0x0400ADCC RID: 44492
	[Token(Token = "0x40082F5")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "HideInInspector", RVA = "0x176050", Offset = "0x176151")]
	public List<ColliderStreamer> colliderStreamers;
}
