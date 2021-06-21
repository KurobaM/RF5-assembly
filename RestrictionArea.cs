using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000553 RID: 1363
[Token(Token = "0x20003DD")]
public class RestrictionArea : MonoBehaviour
{
	// Token: 0x0600210E RID: 8462 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C13")]
	[Address(RVA = "0x248DBD0", Offset = "0x248DCD1", VA = "0x248DBD0")]
	private void OnTriggerStay(Collider other)
	{
	}

	// Token: 0x0600210F RID: 8463 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C14")]
	[Address(RVA = "0x248DCF0", Offset = "0x248DDF1", VA = "0x248DCF0")]
	public RestrictionArea()
	{
	}

	// Token: 0x040067CF RID: 26575
	[Token(Token = "0x40061B7")]
	[FieldOffset(Offset = "0x18")]
	public FieldRestrictionType FieldRestrictionType;
}
