using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200070C RID: 1804
[Token(Token = "0x20004F0")]
public class HasibirokouSonicWind : MonoBehaviour
{
	// Token: 0x06002D52 RID: 11602 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002635")]
	[Address(RVA = "0x24ED210", Offset = "0x24ED311", VA = "0x24ED210")]
	public void Setup(ProjectileBulletBase projectileBulletBase, float sweepPower)
	{
	}

	// Token: 0x06002D53 RID: 11603 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002636")]
	[Address(RVA = "0x24EE130", Offset = "0x24EE231", VA = "0x24EE130")]
	public void SetMove(Transform Target)
	{
	}

	// Token: 0x06002D54 RID: 11604 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002637")]
	[Address(RVA = "0x24EE4C0", Offset = "0x24EE5C1", VA = "0x24EE4C0")]
	public HasibirokouSonicWind()
	{
	}

	// Token: 0x040073E4 RID: 29668
	[Token(Token = "0x4006ADB")]
	[FieldOffset(Offset = "0x18")]
	private float SweepPower;

	// Token: 0x040073E5 RID: 29669
	[Token(Token = "0x4006ADC")]
	[FieldOffset(Offset = "0x20")]
	private ProjectileBulletBase ProjectileBulletBase;

	// Token: 0x040073E6 RID: 29670
	[Token(Token = "0x4006ADD")]
	[FieldOffset(Offset = "0x28")]
	private bool IsSetup;
}
