using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000B91 RID: 2961
[Token(Token = "0x20007AF")]
public class LogicBreakableRopes : MonoBehaviour
{
	// Token: 0x06004C02 RID: 19458 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003FB5")]
	[Address(RVA = "0x1F0C5A0", Offset = "0x1F0C6A1", VA = "0x1F0C5A0")]
	private void Start()
	{
	}

	// Token: 0x06004C03 RID: 19459 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003FB6")]
	[Address(RVA = "0x1F0C5B0", Offset = "0x1F0C6B1", VA = "0x1F0C5B0")]
	private void OnGUI()
	{
	}

	// Token: 0x06004C04 RID: 19460 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003FB7")]
	[Address(RVA = "0x1F0CB30", Offset = "0x1F0CC31", VA = "0x1F0CB30")]
	private void OnRopeBreak(UltimateRope.RopeBreakEventInfo breakInfo)
	{
	}

	// Token: 0x06004C05 RID: 19461 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003FB8")]
	[Address(RVA = "0x1F0CC10", Offset = "0x1F0CD11", VA = "0x1F0CC10")]
	public LogicBreakableRopes()
	{
	}

	// Token: 0x0400AD09 RID: 44297
	[Token(Token = "0x4008287")]
	[FieldOffset(Offset = "0x18")]
	public UltimateRope Rope1;

	// Token: 0x0400AD0A RID: 44298
	[Token(Token = "0x4008288")]
	[FieldOffset(Offset = "0x20")]
	public UltimateRope Rope2;

	// Token: 0x0400AD0B RID: 44299
	[Token(Token = "0x4008289")]
	[FieldOffset(Offset = "0x28")]
	private bool bBroken1;

	// Token: 0x0400AD0C RID: 44300
	[Token(Token = "0x400828A")]
	[FieldOffset(Offset = "0x29")]
	private bool bBroken2;
}
