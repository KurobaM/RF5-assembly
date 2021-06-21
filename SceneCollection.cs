using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000BB0 RID: 2992
[Token(Token = "0x20007C3")]
[Attribute(Name = "ExecuteInEditMode", RVA = "0x147570", Offset = "0x147671")]
[Serializable]
public class SceneCollection : MonoBehaviour
{
	// Token: 0x06004C8E RID: 19598 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6004037")]
	[Address(RVA = "0x21D4470", Offset = "0x21D4571", VA = "0x21D4470")]
	public SceneCollection()
	{
	}

	// Token: 0x0400ADF1 RID: 44529
	[Token(Token = "0x4008318")]
	[FieldOffset(Offset = "0x18")]
	public string prefixName;

	// Token: 0x0400ADF2 RID: 44530
	[Token(Token = "0x4008319")]
	[FieldOffset(Offset = "0x20")]
	public string prefixScene;

	// Token: 0x0400ADF3 RID: 44531
	[Token(Token = "0x400831A")]
	[FieldOffset(Offset = "0x28")]
	public string path;

	// Token: 0x0400ADF4 RID: 44532
	[Token(Token = "0x400831B")]
	[FieldOffset(Offset = "0x30")]
	public string[] names;

	// Token: 0x0400ADF5 RID: 44533
	[Token(Token = "0x400831C")]
	[FieldOffset(Offset = "0x38")]
	public bool xSplitIs;

	// Token: 0x0400ADF6 RID: 44534
	[Token(Token = "0x400831D")]
	[FieldOffset(Offset = "0x39")]
	public bool ySplitIs;

	// Token: 0x0400ADF7 RID: 44535
	[Token(Token = "0x400831E")]
	[FieldOffset(Offset = "0x3A")]
	public bool zSplitIs;

	// Token: 0x0400ADF8 RID: 44536
	[Token(Token = "0x400831F")]
	[FieldOffset(Offset = "0x3C")]
	public int xSize;

	// Token: 0x0400ADF9 RID: 44537
	[Token(Token = "0x4008320")]
	[FieldOffset(Offset = "0x40")]
	public int ySize;

	// Token: 0x0400ADFA RID: 44538
	[Token(Token = "0x4008321")]
	[FieldOffset(Offset = "0x44")]
	public int zSize;

	// Token: 0x0400ADFB RID: 44539
	[Token(Token = "0x4008322")]
	[FieldOffset(Offset = "0x48")]
	public int xLimitsx;

	// Token: 0x0400ADFC RID: 44540
	[Token(Token = "0x4008323")]
	[FieldOffset(Offset = "0x4C")]
	public int xLimitsy;

	// Token: 0x0400ADFD RID: 44541
	[Token(Token = "0x4008324")]
	[FieldOffset(Offset = "0x50")]
	public int yLimitsx;

	// Token: 0x0400ADFE RID: 44542
	[Token(Token = "0x4008325")]
	[FieldOffset(Offset = "0x54")]
	public int yLimitsy;

	// Token: 0x0400ADFF RID: 44543
	[Token(Token = "0x4008326")]
	[FieldOffset(Offset = "0x58")]
	public int zLimitsx;

	// Token: 0x0400AE00 RID: 44544
	[Token(Token = "0x4008327")]
	[FieldOffset(Offset = "0x5C")]
	public int zLimitsy;

	// Token: 0x0400AE01 RID: 44545
	[Token(Token = "0x4008328")]
	[FieldOffset(Offset = "0x60")]
	[Attribute(Name = "HideInInspector", RVA = "0x1762F0", Offset = "0x1763F1")]
	public bool collapsed;

	// Token: 0x0400AE02 RID: 44546
	[Token(Token = "0x4008329")]
	[FieldOffset(Offset = "0x64")]
	[Attribute(Name = "HideInInspector", RVA = "0x176300", Offset = "0x176401")]
	public int layerNumber;

	// Token: 0x0400AE03 RID: 44547
	[Token(Token = "0x400832A")]
	[FieldOffset(Offset = "0x68")]
	public Color color;
}
