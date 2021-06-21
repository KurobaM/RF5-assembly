using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000B73 RID: 2931
[Token(Token = "0x200079F")]
public class LogicCollidingSphere : MonoBehaviour
{
	// Token: 0x06004B52 RID: 19282 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F1D")]
	[Address(RVA = "0x1F0CC20", Offset = "0x1F0CD21", VA = "0x1F0CC20")]
	private void Start()
	{
	}

	// Token: 0x06004B53 RID: 19283 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F1E")]
	[Address(RVA = "0x1F0CC30", Offset = "0x1F0CD31", VA = "0x1F0CC30")]
	private void Update()
	{
	}

	// Token: 0x06004B54 RID: 19284 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F1F")]
	[Address(RVA = "0x1F0CCA0", Offset = "0x1F0CDA1", VA = "0x1F0CCA0")]
	private void OnGUI()
	{
	}

	// Token: 0x06004B55 RID: 19285 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F20")]
	[Address(RVA = "0x1F0D5C0", Offset = "0x1F0D6C1", VA = "0x1F0D5C0")]
	private void OnChunkDetach(FracturedChunk.CollisionInfo info)
	{
	}

	// Token: 0x06004B56 RID: 19286 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F21")]
	[Address(RVA = "0x1F0D5F0", Offset = "0x1F0D6F1", VA = "0x1F0D5F0")]
	private void OnFreeChunkCollision(FracturedChunk.CollisionInfo info)
	{
	}

	// Token: 0x06004B57 RID: 19287 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F22")]
	[Address(RVA = "0x1F0D620", Offset = "0x1F0D721", VA = "0x1F0D620")]
	public LogicCollidingSphere()
	{
	}

	// Token: 0x0400ABF4 RID: 44020
	[Token(Token = "0x40081B3")]
	[FieldOffset(Offset = "0x18")]
	public Rigidbody ObjectToDrop;

	// Token: 0x0400ABF5 RID: 44021
	[Token(Token = "0x40081B4")]
	[FieldOffset(Offset = "0x20")]
	private bool bDropped;

	// Token: 0x0400ABF6 RID: 44022
	[Token(Token = "0x40081B5")]
	[FieldOffset(Offset = "0x24")]
	private int nChunksDetached;

	// Token: 0x0400ABF7 RID: 44023
	[Token(Token = "0x40081B6")]
	[FieldOffset(Offset = "0x28")]
	private int nChunkCollisions;
}
