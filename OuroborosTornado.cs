using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000756 RID: 1878
[Token(Token = "0x200050D")]
public class OuroborosTornado : MonoBehaviour
{
	// Token: 0x06003028 RID: 12328 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600287C")]
	[Address(RVA = "0x2318F90", Offset = "0x2319091", VA = "0x2318F90")]
	public void Setup(float radius, float sweepPower, Transform target, float speed)
	{
	}

	// Token: 0x06003029 RID: 12329 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600287D")]
	[Address(RVA = "0x23191F0", Offset = "0x23192F1", VA = "0x23191F0")]
	private void Update()
	{
	}

	// Token: 0x0600302A RID: 12330 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600287E")]
	[Address(RVA = "0x2319420", Offset = "0x2319521", VA = "0x2319420")]
	public OuroborosTornado()
	{
	}

	// Token: 0x040075A0 RID: 30112
	[Token(Token = "0x4006BDE")]
	[FieldOffset(Offset = "0x18")]
	private Transform Target;

	// Token: 0x040075A1 RID: 30113
	[Token(Token = "0x4006BDF")]
	[FieldOffset(Offset = "0x20")]
	private bool IsSetup;

	// Token: 0x040075A2 RID: 30114
	[Token(Token = "0x4006BE0")]
	[FieldOffset(Offset = "0x24")]
	private float Radius;

	// Token: 0x040075A3 RID: 30115
	[Token(Token = "0x4006BE1")]
	[FieldOffset(Offset = "0x28")]
	private float SweepPower;

	// Token: 0x040075A4 RID: 30116
	[Token(Token = "0x4006BE2")]
	[FieldOffset(Offset = "0x2C")]
	private float Speed;
}
