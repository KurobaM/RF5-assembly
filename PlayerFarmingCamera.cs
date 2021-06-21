using System;
using Cinemachine;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001AC RID: 428
[Token(Token = "0x2000150")]
public class PlayerFarmingCamera : SingletonMonoBehaviour<PlayerFarmingCamera>, IPlayerCamera
{
	// Token: 0x170001B2 RID: 434
	// (get) Token: 0x060008E7 RID: 2279 RVA: 0x00004E60 File Offset: 0x00003060
	// (set) Token: 0x060008E8 RID: 2280 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700019B")]
	public float DistanceOffset
	{
		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x2147EB0", Offset = "0x2147FB1", VA = "0x2147EB0", Slot = "9")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19AC70", Offset = "0x19AD71")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x2147EC0", Offset = "0x2147FC1", VA = "0x2147EC0", Slot = "10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19AC80", Offset = "0x19AD81")]
		set
		{
		}
	}

	// Token: 0x170001B3 RID: 435
	// (get) Token: 0x060008E9 RID: 2281 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700019C")]
	private Character CtrlCharacter
	{
		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x2147ED0", Offset = "0x2147FD1", VA = "0x2147ED0")]
		get
		{
			return null;
		}
	}

	// Token: 0x060008EA RID: 2282 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007AF")]
	[Address(RVA = "0x2147F30", Offset = "0x2148031", VA = "0x2147F30", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x060008EB RID: 2283 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007B0")]
	[Address(RVA = "0x2147FE0", Offset = "0x21480E1", VA = "0x2147FE0")]
	protected void Start()
	{
	}

	// Token: 0x060008EC RID: 2284 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007B1")]
	[Address(RVA = "0x2147FF0", Offset = "0x21480F1", VA = "0x2147FF0", Slot = "5")]
	public void PreUpdate()
	{
	}

	// Token: 0x060008ED RID: 2285 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007B2")]
	[Address(RVA = "0x2148000", Offset = "0x2148101", VA = "0x2148000", Slot = "6")]
	public void FrameUpdate()
	{
	}

	// Token: 0x060008EE RID: 2286 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007B3")]
	[Address(RVA = "0x2148010", Offset = "0x2148111", VA = "0x2148010", Slot = "7")]
	public void TimeStepUpdate()
	{
	}

	// Token: 0x060008EF RID: 2287 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007B4")]
	[Address(RVA = "0x2148020", Offset = "0x2148121", VA = "0x2148020", Slot = "8")]
	public void CameraReset(Quaternion? resetRotation)
	{
	}

	// Token: 0x060008F0 RID: 2288 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007B5")]
	[Address(RVA = "0x21483B0", Offset = "0x21484B1", VA = "0x21483B0")]
	public PlayerFarmingCamera()
	{
	}

	// Token: 0x04000541 RID: 1345
	[Token(Token = "0x4000409")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private CinemachineVirtualCamera m_VirtualCamera;

	// Token: 0x04000542 RID: 1346
	[Token(Token = "0x400040A")]
	[FieldOffset(Offset = "0x20")]
	private CinemachineFramingTransposer m_Transposer;

	// Token: 0x04000543 RID: 1347
	[Token(Token = "0x400040B")]
	[FieldOffset(Offset = "0x28")]
	private Quaternion m_TargetRotation;

	// Token: 0x04000544 RID: 1348
	[Token(Token = "0x400040C")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15C940", Offset = "0x15CA41")]
	private float <DistanceOffset>k__BackingField;
}
