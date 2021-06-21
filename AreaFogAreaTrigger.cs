using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200054E RID: 1358
[Token(Token = "0x20003D8")]
public class AreaFogAreaTrigger : MonoBehaviour
{
	// Token: 0x060020F0 RID: 8432 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BF5")]
	[Address(RVA = "0x243EA00", Offset = "0x243EB01", VA = "0x243EA00")]
	public void OnAreaEnter()
	{
	}

	// Token: 0x060020F1 RID: 8433 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BF6")]
	[Address(RVA = "0x243EA20", Offset = "0x243EB21", VA = "0x243EA20")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x060020F2 RID: 8434 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BF7")]
	[Address(RVA = "0x243EB30", Offset = "0x243EC31", VA = "0x243EB30")]
	private void OnTriggerStay(Collider other)
	{
	}

	// Token: 0x060020F3 RID: 8435 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BF8")]
	[Address(RVA = "0x243EC40", Offset = "0x243ED41", VA = "0x243EC40")]
	private void OnTriggerExit(Collider other)
	{
	}

	// Token: 0x060020F4 RID: 8436 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BF9")]
	[Address(RVA = "0x243ED50", Offset = "0x243EE51", VA = "0x243ED50")]
	public AreaFogAreaTrigger()
	{
	}

	// Token: 0x040067C3 RID: 26563
	[Token(Token = "0x40061AB")]
	[FieldOffset(Offset = "0x18")]
	public AdjustAreaFog AdjustAreaFog;

	// Token: 0x040067C4 RID: 26564
	[Token(Token = "0x40061AC")]
	[FieldOffset(Offset = "0x20")]
	public Collider Collider;
}
