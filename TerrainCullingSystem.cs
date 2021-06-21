using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000BB7 RID: 2999
[Token(Token = "0x20007C8")]
public class TerrainCullingSystem : MonoBehaviour
{
	// Token: 0x06004CB7 RID: 19639 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6004054")]
	[Address(RVA = "0x1F6A8C0", Offset = "0x1F6A9C1", VA = "0x1F6A8C0")]
	private void Start()
	{
	}

	// Token: 0x06004CB8 RID: 19640 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6004055")]
	[Address(RVA = "0x1F6B030", Offset = "0x1F6B131", VA = "0x1F6B030")]
	private void OnDrawGizmosSelected()
	{
	}

	// Token: 0x06004CB9 RID: 19641 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6004056")]
	[Address(RVA = "0x1F6B180", Offset = "0x1F6B281", VA = "0x1F6B180")]
	private void CheckVisibility()
	{
	}

	// Token: 0x06004CBA RID: 19642 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6004057")]
	[Address(RVA = "0x1F6B210", Offset = "0x1F6B311", VA = "0x1F6B210")]
	private void StateChangedMethod(CullingGroupEvent evt)
	{
	}

	// Token: 0x06004CBB RID: 19643 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6004058")]
	[Address(RVA = "0x1F6B2F0", Offset = "0x1F6B3F1", VA = "0x1F6B2F0")]
	private void SetTerrainVisible(bool visible)
	{
	}

	// Token: 0x06004CBC RID: 19644 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6004059")]
	[Address(RVA = "0x1F6B350", Offset = "0x1F6B451", VA = "0x1F6B350")]
	private void OnDestroy()
	{
	}

	// Token: 0x06004CBD RID: 19645 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600405A")]
	[Address(RVA = "0x1F6AF00", Offset = "0x1F6B001", VA = "0x1F6AF00")]
	private void OnChangeActiveCamara(Camera camera)
	{
	}

	// Token: 0x06004CBE RID: 19646 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600405B")]
	[Address(RVA = "0x1F6B470", Offset = "0x1F6B571", VA = "0x1F6B470")]
	public TerrainCullingSystem()
	{
	}

	// Token: 0x0400AE4A RID: 44618
	[Token(Token = "0x400836A")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x176800", Offset = "0x176901")]
	public float renderingDistance;

	// Token: 0x0400AE4B RID: 44619
	[Token(Token = "0x400836B")]
	[FieldOffset(Offset = "0x1C")]
	private float sphereSize;

	// Token: 0x0400AE4C RID: 44620
	[Token(Token = "0x400836C")]
	[FieldOffset(Offset = "0x20")]
	private Terrain terrain;

	// Token: 0x0400AE4D RID: 44621
	[Token(Token = "0x400836D")]
	[FieldOffset(Offset = "0x28")]
	private CullingGroup group;

	// Token: 0x0400AE4E RID: 44622
	[Token(Token = "0x400836E")]
	[FieldOffset(Offset = "0x30")]
	private BoundingSphere[] spheres;

	// Token: 0x0400AE4F RID: 44623
	[Token(Token = "0x400836F")]
	[FieldOffset(Offset = "0x38")]
	private Vector3 offsetVector;

	// Token: 0x0400AE50 RID: 44624
	[Token(Token = "0x4008370")]
	[FieldOffset(Offset = "0x44")]
	private Vector3 offsetVectorUp;

	// Token: 0x0400AE51 RID: 44625
	[Token(Token = "0x4008371")]
	[FieldOffset(Offset = "0x50")]
	private Camera mainCamera;

	// Token: 0x0400AE52 RID: 44626
	[Token(Token = "0x4008372")]
	[FieldOffset(Offset = "0x58")]
	private int heightSphereNumber;

	// Token: 0x0400AE53 RID: 44627
	[Token(Token = "0x4008373")]
	[FieldOffset(Offset = "0x5C")]
	[Attribute(Name = "HideInInspector", RVA = "0x176840", Offset = "0x176941")]
	public bool disableTrees;
}
