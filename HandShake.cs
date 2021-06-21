using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000BC2 RID: 3010
[Token(Token = "0x20007D2")]
public class HandShake : MonoBehaviour
{
	// Token: 0x06004CE5 RID: 19685 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600407C")]
	[Address(RVA = "0x24E68A0", Offset = "0x24E69A1", VA = "0x24E68A0")]
	private void Start()
	{
	}

	// Token: 0x06004CE6 RID: 19686 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600407D")]
	[Address(RVA = "0x24E69B0", Offset = "0x24E6AB1", VA = "0x24E69B0")]
	private void Update()
	{
	}

	// Token: 0x06004CE7 RID: 19687 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600407E")]
	[Address(RVA = "0x24E6A60", Offset = "0x24E6B61", VA = "0x24E6A60")]
	private void AutoShake()
	{
	}

	// Token: 0x06004CE8 RID: 19688 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600407F")]
	[Address(RVA = "0x24E6B50", Offset = "0x24E6C51", VA = "0x24E6B50")]
	private void FixedUpdate()
	{
	}

	// Token: 0x06004CE9 RID: 19689 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6004080")]
	[Address(RVA = "0x24E6C80", Offset = "0x24E6D81", VA = "0x24E6C80")]
	public HandShake()
	{
	}

	// Token: 0x0400AE7A RID: 44666
	[Token(Token = "0x4008397")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private bool Active;

	// Token: 0x0400AE7B RID: 44667
	[Token(Token = "0x4008398")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float RandomRate;

	// Token: 0x0400AE7C RID: 44668
	[Token(Token = "0x4008399")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float OneShakeStopTime;

	// Token: 0x0400AE7D RID: 44669
	[Token(Token = "0x400839A")]
	[FieldOffset(Offset = "0x24")]
	private float OneShakeStopTimeCount;

	// Token: 0x0400AE7E RID: 44670
	[Token(Token = "0x400839B")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Attribute(Name = "RangeAttribute", RVA = "0x176C00", Offset = "0x176D01")]
	private float TimeRandom;

	// Token: 0x0400AE7F RID: 44671
	[Token(Token = "0x400839C")]
	[FieldOffset(Offset = "0x2C")]
	private float NextTimeRandom;

	// Token: 0x0400AE80 RID: 44672
	[Token(Token = "0x400839D")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float ChaseTime;

	// Token: 0x0400AE81 RID: 44673
	[Token(Token = "0x400839E")]
	[FieldOffset(Offset = "0x38")]
	private GameObject TargetObj;

	// Token: 0x0400AE82 RID: 44674
	[Token(Token = "0x400839F")]
	[FieldOffset(Offset = "0x40")]
	private Vector3 velocity;
}
