using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000BC0 RID: 3008
[Token(Token = "0x20007D0")]
public class WorldMover : MonoBehaviour
{
	// Token: 0x06004CD9 RID: 19673 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6004070")]
	[Address(RVA = "0x1E55B30", Offset = "0x1E55C31", VA = "0x1E55B30")]
	public void Start()
	{
	}

	// Token: 0x06004CDA RID: 19674 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6004071")]
	[Address(RVA = "0x1E55C90", Offset = "0x1E55D91", VA = "0x1E55C90")]
	public void Update()
	{
	}

	// Token: 0x06004CDB RID: 19675 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6004072")]
	[Address(RVA = "0x1E55FC0", Offset = "0x1E560C1", VA = "0x1E55FC0")]
	public void CheckMoverDistance(int xPosCurrent, int yPosCurrent, int zPosCurrent)
	{
	}

	// Token: 0x06004CDC RID: 19676 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6004073")]
	[Address(RVA = "0x1E560F0", Offset = "0x1E561F1", VA = "0x1E560F0")]
	private void MoveWorld(int xPosCurrent, int yPosCurrent, int zPosCurrent)
	{
	}

	// Token: 0x06004CDD RID: 19677 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6004074")]
	[Address(RVA = "0x1E56870", Offset = "0x1E56971", VA = "0x1E56870")]
	public void MoveObject(Transform objectTransform)
	{
	}

	// Token: 0x06004CDE RID: 19678 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6004075")]
	[Address(RVA = "0x1E56950", Offset = "0x1E56A51", VA = "0x1E56950")]
	public void AddObjectToMove(Transform objectToMove)
	{
	}

	// Token: 0x06004CDF RID: 19679 RVA: 0x000186A8 File Offset: 0x000168A8
	[Token(Token = "0x6004076")]
	[Address(RVA = "0x1E55F90", Offset = "0x1E56091", VA = "0x1E55F90")]
	private float modf(float x, float m)
	{
		return 0f;
	}

	// Token: 0x06004CE0 RID: 19680 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6004077")]
	[Address(RVA = "0x1E56A50", Offset = "0x1E56B51", VA = "0x1E56A50")]
	public WorldMover()
	{
	}

	// Token: 0x0400AE68 RID: 44648
	[Token(Token = "0x4008385")]
	[FieldOffset(Offset = "0x0")]
	public static string WORLDMOVERTAG;

	// Token: 0x0400AE69 RID: 44649
	[Token(Token = "0x4008386")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x1769D0", Offset = "0x176AD1")]
	public float xTileRange;

	// Token: 0x0400AE6A RID: 44650
	[Token(Token = "0x4008387")]
	[FieldOffset(Offset = "0x1C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x176A10", Offset = "0x176B11")]
	public float yTileRange;

	// Token: 0x0400AE6B RID: 44651
	[Token(Token = "0x4008388")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x176A50", Offset = "0x176B51")]
	public float zTileRange;

	// Token: 0x0400AE6C RID: 44652
	[Token(Token = "0x4008389")]
	[FieldOffset(Offset = "0x24")]
	[Attribute(Name = "HideInInspector", RVA = "0x176A90", Offset = "0x176B91")]
	public float xCurrentTile;

	// Token: 0x0400AE6D RID: 44653
	[Token(Token = "0x400838A")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "HideInInspector", RVA = "0x176AA0", Offset = "0x176BA1")]
	public float yCurrentTile;

	// Token: 0x0400AE6E RID: 44654
	[Token(Token = "0x400838B")]
	[FieldOffset(Offset = "0x2C")]
	[Attribute(Name = "HideInInspector", RVA = "0x176AB0", Offset = "0x176BB1")]
	public float zCurrentTile;

	// Token: 0x0400AE6F RID: 44655
	[Token(Token = "0x400838C")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x176AC0", Offset = "0x176BC1")]
	public Streamer streamerMajor;

	// Token: 0x0400AE70 RID: 44656
	[Token(Token = "0x400838D")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x176B00", Offset = "0x176C01")]
	public Streamer[] streamerMinors;

	// Token: 0x0400AE71 RID: 44657
	[Token(Token = "0x400838E")]
	[FieldOffset(Offset = "0x40")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x176B40", Offset = "0x176C41")]
	public Vector3 currentMove;

	// Token: 0x0400AE72 RID: 44658
	[Token(Token = "0x400838F")]
	[FieldOffset(Offset = "0x50")]
	[Attribute(Name = "HideInInspector", RVA = "0x176B80", Offset = "0x176C81")]
	public List<Transform> objectsToMove;

	// Token: 0x0400AE73 RID: 44659
	[Token(Token = "0x4008390")]
	[FieldOffset(Offset = "0x58")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x176B90", Offset = "0x176C91")]
	public Vector3 playerPositionMovedLooped;

	// Token: 0x0400AE74 RID: 44660
	[Token(Token = "0x4008391")]
	[FieldOffset(Offset = "0x64")]
	private Vector3 worldSize;
}
