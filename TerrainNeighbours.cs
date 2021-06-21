using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000BB8 RID: 3000
[Token(Token = "0x20007C9")]
public class TerrainNeighbours : MonoBehaviour
{
	// Token: 0x06004CBF RID: 19647 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600405C")]
	[Address(RVA = "0x1F6B4F0", Offset = "0x1F6B5F1", VA = "0x1F6B4F0")]
	private void Start()
	{
	}

	// Token: 0x06004CC0 RID: 19648 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600405D")]
	[Address(RVA = "0x1F6B500", Offset = "0x1F6B601", VA = "0x1F6B500")]
	public void CreateNeighbours()
	{
	}

	// Token: 0x06004CC1 RID: 19649 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600405E")]
	[Address(RVA = "0x1F6CA80", Offset = "0x1F6CB81", VA = "0x1F6CA80")]
	public TerrainNeighbours()
	{
	}

	// Token: 0x0400AE54 RID: 44628
	[Token(Token = "0x4008374")]
	[FieldOffset(Offset = "0x18")]
	public List<Terrain> terrainsToOmit;

	// Token: 0x0400AE55 RID: 44629
	[Token(Token = "0x4008375")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x176850", Offset = "0x176951")]
	public WorldMover worldMover;

	// Token: 0x0400AE56 RID: 44630
	[Token(Token = "0x4008376")]
	[FieldOffset(Offset = "0x28")]
	public List<Terrain> _terrains;

	// Token: 0x0400AE57 RID: 44631
	[Token(Token = "0x4008377")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<int[], Terrain> _terrainDict;

	// Token: 0x0400AE58 RID: 44632
	[Token(Token = "0x4008378")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x176890", Offset = "0x176991")]
	private Vector2 firstPosition;

	// Token: 0x0400AE59 RID: 44633
	[Token(Token = "0x4008379")]
	[FieldOffset(Offset = "0x40")]
	private int sizeX;

	// Token: 0x0400AE5A RID: 44634
	[Token(Token = "0x400837A")]
	[FieldOffset(Offset = "0x44")]
	private int sizeZ;

	// Token: 0x0400AE5B RID: 44635
	[Token(Token = "0x400837B")]
	[FieldOffset(Offset = "0x48")]
	private bool firstPositonSet;
}
