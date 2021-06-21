using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001A6 RID: 422
[Token(Token = "0x200014B")]
public class LandscapeChangeArea : MonoBehaviour
{
	// Token: 0x060008C4 RID: 2244 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000789")]
	[Address(RVA = "0x2301150", Offset = "0x2301251", VA = "0x2301150")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x060008C5 RID: 2245 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600078A")]
	[Address(RVA = "0x2301300", Offset = "0x2301401", VA = "0x2301300")]
	private void OnTriggerExit(Collider other)
	{
	}

	// Token: 0x060008C6 RID: 2246 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600078B")]
	[Address(RVA = "0x2301450", Offset = "0x2301551", VA = "0x2301450")]
	public LandscapeChangeArea()
	{
	}

	// Token: 0x0400052D RID: 1325
	[Token(Token = "0x40003FA")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private LandscapeVcam LandscapeVcam;
}
