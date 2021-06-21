using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000BA8 RID: 2984
[Token(Token = "0x20007BD")]
public class LocalAreaSettings : ScriptableObject
{
	// Token: 0x06004C64 RID: 19556 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6004011")]
	[Address(RVA = "0x1F0B670", Offset = "0x1F0B771", VA = "0x1F0B670")]
	public LocalAreaSettings()
	{
	}

	// Token: 0x0400ADCD RID: 44493
	[Token(Token = "0x40082F6")]
	[FieldOffset(Offset = "0x18")]
	public bool collectionsCollapsed;

	// Token: 0x0400ADCE RID: 44494
	[Token(Token = "0x40082F7")]
	[FieldOffset(Offset = "0x1C")]
	public int listSizeCollections;

	// Token: 0x0400ADCF RID: 44495
	[Token(Token = "0x40082F8")]
	[FieldOffset(Offset = "0x20")]
	public List<SceneCollection> currentCollections;

	// Token: 0x0400ADD0 RID: 44496
	[Token(Token = "0x40082F9")]
	[FieldOffset(Offset = "0x28")]
	public bool showLoadingPoint;

	// Token: 0x0400ADD1 RID: 44497
	[Token(Token = "0x40082FA")]
	[FieldOffset(Offset = "0x2C")]
	public int distanceFromCenter;

	// Token: 0x0400ADD2 RID: 44498
	[Token(Token = "0x40082FB")]
	[FieldOffset(Offset = "0x30")]
	public bool tiles;

	// Token: 0x0400ADD3 RID: 44499
	[Token(Token = "0x40082FC")]
	[FieldOffset(Offset = "0x34")]
	public Vector3 CenterPoint;
}
