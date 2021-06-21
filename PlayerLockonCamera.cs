using System;
using Cinemachine;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001AD RID: 429
[Token(Token = "0x2000151")]
public class PlayerLockonCamera : SingletonMonoBehaviour<PlayerLockonCamera>, IPlayerCamera
{
	// Token: 0x170001B4 RID: 436
	// (get) Token: 0x060008F1 RID: 2289 RVA: 0x00004E78 File Offset: 0x00003078
	// (set) Token: 0x060008F2 RID: 2290 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700019D")]
	public float DistanceOffset
	{
		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x2494610", Offset = "0x2494711", VA = "0x2494610", Slot = "9")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19AC90", Offset = "0x19AD91")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x2494620", Offset = "0x2494721", VA = "0x2494620", Slot = "10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19ACA0", Offset = "0x19ADA1")]
		set
		{
		}
	}

	// Token: 0x060008F3 RID: 2291 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007B8")]
	[Address(RVA = "0x2494630", Offset = "0x2494731", VA = "0x2494630")]
	private void Start()
	{
	}

	// Token: 0x060008F4 RID: 2292 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007B9")]
	[Address(RVA = "0x2494750", Offset = "0x2494851", VA = "0x2494750")]
	private void Update()
	{
	}

	// Token: 0x060008F5 RID: 2293 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007BA")]
	[Address(RVA = "0x2494980", Offset = "0x2494A81", VA = "0x2494980", Slot = "5")]
	public void PreUpdate()
	{
	}

	// Token: 0x060008F6 RID: 2294 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007BB")]
	[Address(RVA = "0x2494990", Offset = "0x2494A91", VA = "0x2494990", Slot = "6")]
	public void FrameUpdate()
	{
	}

	// Token: 0x060008F7 RID: 2295 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007BC")]
	[Address(RVA = "0x24949A0", Offset = "0x2494AA1", VA = "0x24949A0", Slot = "7")]
	public void TimeStepUpdate()
	{
	}

	// Token: 0x060008F8 RID: 2296 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007BD")]
	[Address(RVA = "0x2494F00", Offset = "0x2495001", VA = "0x2494F00", Slot = "8")]
	public void CameraReset(Quaternion? resetRotation)
	{
	}

	// Token: 0x060008F9 RID: 2297 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007BE")]
	[Address(RVA = "0x2495040", Offset = "0x2495141", VA = "0x2495040")]
	public PlayerLockonCamera()
	{
	}

	// Token: 0x04000545 RID: 1349
	[Token(Token = "0x400040D")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15C950", Offset = "0x15CA51")]
	private float <DistanceOffset>k__BackingField;

	// Token: 0x04000546 RID: 1350
	[Token(Token = "0x400040E")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private CinemachineVirtualCamera m_VirtualCamera;

	// Token: 0x04000547 RID: 1351
	[Token(Token = "0x400040F")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private CinemachineFramingTransposer m_CinemachineFramingTransposer;

	// Token: 0x04000548 RID: 1352
	[Token(Token = "0x4000410")]
	[FieldOffset(Offset = "0x30")]
	private Transform LookAtTransform;

	// Token: 0x04000549 RID: 1353
	[Token(Token = "0x4000411")]
	[FieldOffset(Offset = "0x38")]
	public float DefaultDistance;

	// Token: 0x0400054A RID: 1354
	[Token(Token = "0x4000412")]
	[FieldOffset(Offset = "0x3C")]
	public float m_FollowDuration;

	// Token: 0x0400054B RID: 1355
	[Token(Token = "0x4000413")]
	[FieldOffset(Offset = "0x40")]
	public float m_LookPosAdjustmentRange;

	// Token: 0x0400054C RID: 1356
	[Token(Token = "0x4000414")]
	[FieldOffset(Offset = "0x44")]
	public float AngleXMin;

	// Token: 0x0400054D RID: 1357
	[Token(Token = "0x4000415")]
	[FieldOffset(Offset = "0x48")]
	public float AngleXMax;

	// Token: 0x0400054E RID: 1358
	[Token(Token = "0x4000416")]
	[FieldOffset(Offset = "0x4C")]
	public float AngleXMin_DN18_01;

	// Token: 0x0400054F RID: 1359
	[Token(Token = "0x4000417")]
	[FieldOffset(Offset = "0x50")]
	public float AngleXMax_DN18_01;
}
