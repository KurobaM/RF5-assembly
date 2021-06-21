using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200070B RID: 1803
[Token(Token = "0x20004EF")]
internal class HasibirokouSonicStorm : MonoBehaviour
{
	// Token: 0x06002D4F RID: 11599 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002632")]
	[Address(RVA = "0x24EDDC0", Offset = "0x24EDEC1", VA = "0x24EDDC0")]
	public void Setup(HasibirokouController hasibirokouController, float minradius, float maxradius, float sweepPower, Transform target, float speed)
	{
	}

	// Token: 0x06002D50 RID: 11600 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002633")]
	[Address(RVA = "0x24EE270", Offset = "0x24EE371", VA = "0x24EE270")]
	private void Update()
	{
	}

	// Token: 0x06002D51 RID: 11601 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002634")]
	[Address(RVA = "0x24EE4A0", Offset = "0x24EE5A1", VA = "0x24EE4A0")]
	public HasibirokouSonicStorm()
	{
	}

	// Token: 0x040073DD RID: 29661
	[Token(Token = "0x4006AD4")]
	[FieldOffset(Offset = "0x18")]
	private bool IsSetup;

	// Token: 0x040073DE RID: 29662
	[Token(Token = "0x4006AD5")]
	[FieldOffset(Offset = "0x1C")]
	private float MinRadius;

	// Token: 0x040073DF RID: 29663
	[Token(Token = "0x4006AD6")]
	[FieldOffset(Offset = "0x20")]
	private float MaxRadius;

	// Token: 0x040073E0 RID: 29664
	[Token(Token = "0x4006AD7")]
	[FieldOffset(Offset = "0x24")]
	private float SweepPower;

	// Token: 0x040073E1 RID: 29665
	[Token(Token = "0x4006AD8")]
	[FieldOffset(Offset = "0x28")]
	private HasibirokouController HasibirokouController;

	// Token: 0x040073E2 RID: 29666
	[Token(Token = "0x4006AD9")]
	[FieldOffset(Offset = "0x30")]
	private Transform Target;

	// Token: 0x040073E3 RID: 29667
	[Token(Token = "0x4006ADA")]
	[FieldOffset(Offset = "0x38")]
	private float Speed;
}
