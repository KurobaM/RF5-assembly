using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200054D RID: 1357
[Token(Token = "0x20003D7")]
public class AreaFogAdjustTrigger : MonoBehaviour
{
	// Token: 0x060020EC RID: 8428 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BF1")]
	[Address(RVA = "0x243E490", Offset = "0x243E591", VA = "0x243E490")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x060020ED RID: 8429 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BF2")]
	[Address(RVA = "0x243E5A0", Offset = "0x243E6A1", VA = "0x243E5A0")]
	private void OnTriggerStay(Collider other)
	{
	}

	// Token: 0x060020EE RID: 8430 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BF3")]
	[Address(RVA = "0x243E8E0", Offset = "0x243E9E1", VA = "0x243E8E0")]
	private void OnTriggerExit(Collider other)
	{
	}

	// Token: 0x060020EF RID: 8431 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BF4")]
	[Address(RVA = "0x243E9F0", Offset = "0x243EAF1", VA = "0x243E9F0")]
	public AreaFogAdjustTrigger()
	{
	}

	// Token: 0x040067C0 RID: 26560
	[Token(Token = "0x40061A8")]
	[FieldOffset(Offset = "0x18")]
	public AdjustAreaFog AdjustAreaFog;

	// Token: 0x040067C1 RID: 26561
	[Token(Token = "0x40061A9")]
	[FieldOffset(Offset = "0x20")]
	public BoxCollider Collider;

	// Token: 0x040067C2 RID: 26562
	[Token(Token = "0x40061AA")]
	[FieldOffset(Offset = "0x28")]
	public float AdjustRate;
}
