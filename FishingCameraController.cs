using System;
using System.Runtime.InteropServices;
using Cinemachine;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001A4 RID: 420
[Token(Token = "0x200014A")]
public class FishingCameraController : CameraControllerBase
{
	// Token: 0x170001AD RID: 429
	// (get) Token: 0x060008B9 RID: 2233 RVA: 0x00004DE8 File Offset: 0x00002FE8
	// (set) Token: 0x060008BA RID: 2234 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000196")]
	public float RotateYAxis
	{
		[Token(Token = "0x600077F")]
		[Address(RVA = "0x1EC6DE0", Offset = "0x1EC6EE1", VA = "0x1EC6DE0")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000780")]
		[Address(RVA = "0x1EC6DF0", Offset = "0x1EC6EF1", VA = "0x1EC6DF0")]
		set
		{
		}
	}

	// Token: 0x060008BB RID: 2235 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000781")]
	[Address(RVA = "0x1EC6E00", Offset = "0x1EC6F01", VA = "0x1EC6E00", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x060008BC RID: 2236 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000782")]
	[Address(RVA = "0x1EC6FA0", Offset = "0x1EC70A1", VA = "0x1EC6FA0", Slot = "6")]
	public override void EnableCameraSetup(UseCameraType prevCameraType, [Optional] CinemachineVirtualCamera vcam)
	{
	}

	// Token: 0x060008BD RID: 2237 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000783")]
	[Address(RVA = "0x1EC7110", Offset = "0x1EC7211", VA = "0x1EC7110", Slot = "9")]
	public override void FrameUpdate()
	{
	}

	// Token: 0x060008BE RID: 2238 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000784")]
	[Address(RVA = "0x1EC7240", Offset = "0x1EC7341", VA = "0x1EC7240")]
	private void BlendRotUpdate()
	{
	}

	// Token: 0x060008BF RID: 2239 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000785")]
	[Address(RVA = "0x1EC73E0", Offset = "0x1EC74E1", VA = "0x1EC73E0")]
	private void TargetPositionUpdate()
	{
	}

	// Token: 0x060008C0 RID: 2240 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000786")]
	[Address(RVA = "0x1EC7200", Offset = "0x1EC7301", VA = "0x1EC7200")]
	private void UpdateInputAxis()
	{
	}

	// Token: 0x060008C1 RID: 2241 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000787")]
	[Address(RVA = "0x1EC72B0", Offset = "0x1EC73B1", VA = "0x1EC72B0")]
	public void PositionUpdate()
	{
	}

	// Token: 0x060008C2 RID: 2242 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000788")]
	[Address(RVA = "0x1EC7770", Offset = "0x1EC7871", VA = "0x1EC7770")]
	public FishingCameraController()
	{
	}

	// Token: 0x0400051F RID: 1311
	[Token(Token = "0x40003ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private FishingCameraController.InputAxisSetting m_InputYAxis;

	// Token: 0x04000520 RID: 1312
	[Token(Token = "0x40003EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private AxisSetting m_YAxisSetting;

	// Token: 0x04000521 RID: 1313
	[Token(Token = "0x40003EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Attribute(Name = "RangeAttribute", RVA = "0x15C840", Offset = "0x15C941")]
	public float m_PlayerAhedLookForwardRange;

	// Token: 0x04000522 RID: 1314
	[Token(Token = "0x40003F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[Attribute(Name = "RangeAttribute", RVA = "0x15C860", Offset = "0x15C961")]
	public float m_PlayerAheadLookForwardSpeed;

	// Token: 0x04000523 RID: 1315
	[Token(Token = "0x40003F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Attribute(Name = "RangeAttribute", RVA = "0x15C880", Offset = "0x15C981")]
	public float m_RotatingLookPlayerSpeed;

	// Token: 0x04000524 RID: 1316
	[Token(Token = "0x40003F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float m_CameraDistance;

	// Token: 0x04000525 RID: 1317
	[Token(Token = "0x40003F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float m_AngleX;

	// Token: 0x04000526 RID: 1318
	[Token(Token = "0x40003F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private float m_SpeedYAxis;

	// Token: 0x04000527 RID: 1319
	[Token(Token = "0x40003F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float m_RotateYAxis;

	// Token: 0x04000528 RID: 1320
	[Token(Token = "0x40003F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private CinemachineFramingTransposer m_FramingTransposer;

	// Token: 0x04000529 RID: 1321
	[Token(Token = "0x40003F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private GameObject m_PlayerTarget;

	// Token: 0x0400052A RID: 1322
	[Token(Token = "0x40003F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Vector3 m_FollowTargetPosition;

	// Token: 0x0400052B RID: 1323
	[Token(Token = "0x40003F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private Vector3 m_PrevAheadOffset;

	// Token: 0x020001A5 RID: 421
	[Token(Token = "0x2000FE3")]
	[Serializable]
	public class InputAxisSetting
	{
		// Token: 0x060008C3 RID: 2243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C25")]
		[Address(RVA = "0x1EC78E0", Offset = "0x1EC79E1", VA = "0x1EC78E0")]
		public InputAxisSetting(string name)
		{
		}

		// Token: 0x0400052C RID: 1324
		[Token(Token = "0x4018DA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string m_InputName;
	}
}
