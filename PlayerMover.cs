using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x02000BAA RID: 2986
[Token(Token = "0x20007BF")]
public class PlayerMover : MonoBehaviour
{
	// Token: 0x06004C6E RID: 19566 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600401B")]
	[Address(RVA = "0x2496F30", Offset = "0x2497031", VA = "0x2496F30")]
	private void Awake()
	{
	}

	// Token: 0x06004C6F RID: 19567 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600401C")]
	[Address(RVA = "0x2496F90", Offset = "0x2497091", VA = "0x2496F90")]
	private void Update()
	{
	}

	// Token: 0x06004C70 RID: 19568 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600401D")]
	[Address(RVA = "0x2497210", Offset = "0x2497311", VA = "0x2497210")]
	public void Done()
	{
	}

	// Token: 0x06004C71 RID: 19569 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600401E")]
	[Address(RVA = "0x24972E0", Offset = "0x24973E1", VA = "0x24972E0", Slot = "4")]
	public virtual void MovePlayer()
	{
	}

	// Token: 0x06004C72 RID: 19570 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600401F")]
	[Address(RVA = "0x2497350", Offset = "0x2497451", VA = "0x2497350")]
	public PlayerMover()
	{
	}

	// Token: 0x0400ADDD RID: 44509
	[Token(Token = "0x4008306")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x1760C0", Offset = "0x1761C1")]
	public Streamer[] streamers;

	// Token: 0x0400ADDE RID: 44510
	[Token(Token = "0x4008307")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "SpaceAttribute", RVA = "0x176100", Offset = "0x176201")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x176100", Offset = "0x176201")]
	public Transform player;

	// Token: 0x0400ADDF RID: 44511
	[Token(Token = "0x4008308")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x176150", Offset = "0x176251")]
	public Transform safePosition;

	// Token: 0x0400ADE0 RID: 44512
	[Token(Token = "0x4008309")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "SpaceAttribute", RVA = "0x176190", Offset = "0x176291")]
	public UnityEvent onDone;

	// Token: 0x0400ADE1 RID: 44513
	[Token(Token = "0x400830A")]
	[FieldOffset(Offset = "0x38")]
	protected Vector3 savePosition;

	// Token: 0x0400ADE2 RID: 44514
	[Token(Token = "0x400830B")]
	[FieldOffset(Offset = "0x44")]
	protected Quaternion saveRotation;

	// Token: 0x0400ADE3 RID: 44515
	[Token(Token = "0x400830C")]
	[FieldOffset(Offset = "0x54")]
	protected float progress;

	// Token: 0x0400ADE4 RID: 44516
	[Token(Token = "0x400830D")]
	[FieldOffset(Offset = "0x58")]
	protected bool waitForPlayer;

	// Token: 0x0400ADE5 RID: 44517
	[Token(Token = "0x400830E")]
	[FieldOffset(Offset = "0x59")]
	protected bool playerMoved;
}
