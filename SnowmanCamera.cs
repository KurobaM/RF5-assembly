using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200053F RID: 1343
[Token(Token = "0x20003CF")]
public class SnowmanCamera : FestivalCamera
{
	// Token: 0x06002074 RID: 8308 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B91")]
	[Address(RVA = "0x2253A70", Offset = "0x2253B71", VA = "0x2253A70", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x06002075 RID: 8309 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B92")]
	[Address(RVA = "0x2253A80", Offset = "0x2253B81", VA = "0x2253A80")]
	private void FixedUpdate()
	{
	}

	// Token: 0x06002076 RID: 8310 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B93")]
	[Address(RVA = "0x2254090", Offset = "0x2254191", VA = "0x2254090")]
	public void Init()
	{
	}

	// Token: 0x06002077 RID: 8311 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B94")]
	[Address(RVA = "0x2253F60", Offset = "0x2254061", VA = "0x2253F60")]
	private void UpdateZoom()
	{
	}

	// Token: 0x06002078 RID: 8312 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B95")]
	[Address(RVA = "0x2254250", Offset = "0x2254351", VA = "0x2254250")]
	public void StartZoom()
	{
	}

	// Token: 0x06002079 RID: 8313 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B96")]
	[Address(RVA = "0x2254260", Offset = "0x2254361", VA = "0x2254260")]
	public SnowmanCamera()
	{
	}

	// Token: 0x04006758 RID: 26456
	[Token(Token = "0x400615A")]
	[FieldOffset(Offset = "0x40")]
	private float distance;

	// Token: 0x04006759 RID: 26457
	[Token(Token = "0x400615B")]
	[FieldOffset(Offset = "0x44")]
	private Vector3 lookAtAngle;

	// Token: 0x0400675A RID: 26458
	[Token(Token = "0x400615C")]
	[FieldOffset(Offset = "0x50")]
	private bool isZooming;

	// Token: 0x0400675B RID: 26459
	[Token(Token = "0x400615D")]
	[FieldOffset(Offset = "0x54")]
	private float zoomOutSpeed;

	// Token: 0x0400675C RID: 26460
	[Token(Token = "0x400615E")]
	[FieldOffset(Offset = "0x58")]
	private float zoomOutMax;

	// Token: 0x0400675D RID: 26461
	[Token(Token = "0x400615F")]
	[FieldOffset(Offset = "0x5C")]
	private float zoomOutMin;

	// Token: 0x0400675E RID: 26462
	[Token(Token = "0x4006160")]
	[FieldOffset(Offset = "0x60")]
	private float zoomRange;
}
