using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000BAB RID: 2987
[Token(Token = "0x20007C0")]
public class PlayerTeleport : MonoBehaviour
{
	// Token: 0x06004C73 RID: 19571 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6004020")]
	[Address(RVA = "0x2499DB0", Offset = "0x2499EB1", VA = "0x2499DB0")]
	public void Teleport(bool showLoadingScreen)
	{
	}

	// Token: 0x06004C74 RID: 19572 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6004021")]
	[Address(RVA = "0x249A140", Offset = "0x249A241", VA = "0x249A140")]
	private void OnDrawGizmosSelected()
	{
	}

	// Token: 0x06004C75 RID: 19573 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6004022")]
	[Address(RVA = "0x249A1D0", Offset = "0x249A2D1", VA = "0x249A1D0")]
	public PlayerTeleport()
	{
	}

	// Token: 0x0400ADE6 RID: 44518
	[Token(Token = "0x400830F")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x1761B0", Offset = "0x1762B1")]
	public UILoadingStreamer uiLoadingStreamer;

	// Token: 0x0400ADE7 RID: 44519
	[Token(Token = "0x4008310")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x1761F0", Offset = "0x1762F1")]
	public PlayerMover playerMover;

	// Token: 0x0400ADE8 RID: 44520
	[Token(Token = "0x4008311")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x176230", Offset = "0x176331")]
	public Streamer[] streamers;

	// Token: 0x0400ADE9 RID: 44521
	[Token(Token = "0x4008312")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x176270", Offset = "0x176371")]
	public Transform player;

	// Token: 0x0400ADEA RID: 44522
	[Token(Token = "0x4008313")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x1762B0", Offset = "0x1763B1")]
	public WorldMover worldMover;
}
