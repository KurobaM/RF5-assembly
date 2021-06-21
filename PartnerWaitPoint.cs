using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200083C RID: 2108
[Token(Token = "0x2000566")]
public class PartnerWaitPoint
{
	// Token: 0x170007C4 RID: 1988
	// (get) Token: 0x0600381D RID: 14365 RVA: 0x000134B8 File Offset: 0x000116B8
	[Token(Token = "0x1700060B")]
	public PartnerMovementOrderType Type
	{
		[Token(Token = "0x6002EAD")]
		[Address(RVA = "0x213A680", Offset = "0x213A781", VA = "0x213A680")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5C90", Offset = "0x1A5D91")]
		get
		{
			return PartnerMovementOrderType.None;
		}
	}

	// Token: 0x170007C5 RID: 1989
	// (get) Token: 0x0600381E RID: 14366 RVA: 0x000134D0 File Offset: 0x000116D0
	// (set) Token: 0x0600381F RID: 14367 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700060C")]
	public Vector3 Position
	{
		[Token(Token = "0x6002EAE")]
		[Address(RVA = "0x213A690", Offset = "0x213A791", VA = "0x213A690")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5CA0", Offset = "0x1A5DA1")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6002EAF")]
		[Address(RVA = "0x213A6A0", Offset = "0x213A7A1", VA = "0x213A6A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5CB0", Offset = "0x1A5DB1")]
		private set
		{
		}
	}

	// Token: 0x06003820 RID: 14368 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002EB0")]
	[Address(RVA = "0x213A6B0", Offset = "0x213A7B1", VA = "0x213A6B0")]
	public PartnerWaitPoint(PartnerMovementOrderType type, Vector3 localPosition)
	{
	}

	// Token: 0x06003821 RID: 14369 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002EB1")]
	[Address(RVA = "0x213A720", Offset = "0x213A821", VA = "0x213A720")]
	public void UpdatePosition(Transform transform)
	{
	}

	// Token: 0x06003822 RID: 14370 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002EB2")]
	[Address(RVA = "0x213A800", Offset = "0x213A901", VA = "0x213A800")]
	public void UpdateCameraForwardValue(GameObject cameraObj)
	{
	}

	// Token: 0x06003823 RID: 14371 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002EB3")]
	[Address(RVA = "0x213A990", Offset = "0x213AA91", VA = "0x213A990")]
	public void OnDrawGizmos()
	{
	}

	// Token: 0x04007B2E RID: 31534
	[Token(Token = "0x4006F61")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16B210", Offset = "0x16B311")]
	private readonly PartnerMovementOrderType <Type>k__BackingField;

	// Token: 0x04007B2F RID: 31535
	[Token(Token = "0x4006F62")]
	[FieldOffset(Offset = "0x14")]
	private Vector3 LocalPosition;

	// Token: 0x04007B30 RID: 31536
	[Token(Token = "0x4006F63")]
	[FieldOffset(Offset = "0x20")]
	private float CenterSqrMagnitude;

	// Token: 0x04007B31 RID: 31537
	[Token(Token = "0x4006F64")]
	[FieldOffset(Offset = "0x24")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16B220", Offset = "0x16B321")]
	private Vector3 <Position>k__BackingField;

	// Token: 0x04007B32 RID: 31538
	[Token(Token = "0x4006F65")]
	[FieldOffset(Offset = "0x30")]
	public float CameraValue;
}
