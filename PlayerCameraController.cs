using System;
using System.Runtime.InteropServices;
using Cinemachine;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001A9 RID: 425
[Token(Token = "0x200014E")]
public class PlayerCameraController : CameraControllerBase
{
	// Token: 0x170001B0 RID: 432
	// (get) Token: 0x060008CF RID: 2255 RVA: 0x00004E00 File Offset: 0x00003000
	// (set) Token: 0x060008D0 RID: 2256 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000199")]
	public PlayerCameraController.PlayerCameraType CurrentCameraType
	{
		[Token(Token = "0x6000794")]
		[Address(RVA = "0x2145010", Offset = "0x2145111", VA = "0x2145010")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19AC50", Offset = "0x19AD51")]
		get
		{
			return PlayerCameraController.PlayerCameraType.Tracking;
		}
		[Token(Token = "0x6000795")]
		[Address(RVA = "0x2145020", Offset = "0x2145121", VA = "0x2145020")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19AC60", Offset = "0x19AD61")]
		protected set
		{
		}
	}

	// Token: 0x060008D1 RID: 2257 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000796")]
	[Address(RVA = "0x2145030", Offset = "0x2145131", VA = "0x2145030", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x060008D2 RID: 2258 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000797")]
	[Address(RVA = "0x21457C0", Offset = "0x21458C1", VA = "0x21457C0", Slot = "6")]
	public override void EnableCameraSetup(UseCameraType prevCameraType, [Optional] CinemachineVirtualCamera vcam)
	{
	}

	// Token: 0x060008D3 RID: 2259 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000798")]
	[Address(RVA = "0x21459B0", Offset = "0x2145AB1", VA = "0x21459B0", Slot = "8")]
	public override void PreFrameUpdate()
	{
	}

	// Token: 0x060008D4 RID: 2260 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000799")]
	[Address(RVA = "0x2145A70", Offset = "0x2145B71", VA = "0x2145A70", Slot = "9")]
	public override void FrameUpdate()
	{
	}

	// Token: 0x060008D5 RID: 2261 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600079A")]
	[Address(RVA = "0x2145DE0", Offset = "0x2145EE1", VA = "0x2145DE0", Slot = "10")]
	public override void TimeStepUpdate()
	{
	}

	// Token: 0x060008D6 RID: 2262 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600079B")]
	[Address(RVA = "0x2145450", Offset = "0x2145551", VA = "0x2145450")]
	public void ChangeCameraType(PlayerCameraController.PlayerCameraType cameraType, [Optional] Quaternion? rotation)
	{
	}

	// Token: 0x060008D7 RID: 2263 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600079C")]
	[Address(RVA = "0x2146080", Offset = "0x2146181", VA = "0x2146080")]
	private void VirtualCameraReset([Optional] Quaternion? resetRotation)
	{
	}

	// Token: 0x060008D8 RID: 2264 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600079D")]
	[Address(RVA = "0x2145910", Offset = "0x2145A11", VA = "0x2145910")]
	public void CameraReset([Optional] Quaternion? resetRotation)
	{
	}

	// Token: 0x060008D9 RID: 2265 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600079E")]
	[Address(RVA = "0x2145EB0", Offset = "0x2145FB1", VA = "0x2145EB0")]
	private void TargetPositionUpdate()
	{
	}

	// Token: 0x060008DA RID: 2266 RVA: 0x00004E18 File Offset: 0x00003018
	[Token(Token = "0x600079F")]
	[Address(RVA = "0x21461C0", Offset = "0x21462C1", VA = "0x21461C0")]
	public Vector3 GetCameraLockPos(float xzSpeed, float ySpeed)
	{
		return default(Vector3);
	}

	// Token: 0x060008DB RID: 2267 RVA: 0x00004E30 File Offset: 0x00003030
	[Token(Token = "0x60007A0")]
	[Address(RVA = "0x2146190", Offset = "0x2146291", VA = "0x2146190")]
	public Vector3 GetCameraLockPosReset()
	{
		return default(Vector3);
	}

	// Token: 0x060008DC RID: 2268 RVA: 0x00004E48 File Offset: 0x00003048
	[Token(Token = "0x60007A1")]
	[Address(RVA = "0x2146440", Offset = "0x2146541", VA = "0x2146440")]
	private Vector3 GetDefaultTargetPoistion()
	{
		return default(Vector3);
	}

	// Token: 0x060008DD RID: 2269 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007A2")]
	[Address(RVA = "0x2146730", Offset = "0x2146831", VA = "0x2146730")]
	public void Shake(Vector3 pos, float amplitudeGain, float frequencyGain, float impactRadius, float dissipationDistance, float attack = 0f, float sustainTime = 1f, float decay = 2f)
	{
	}

	// Token: 0x060008DE RID: 2270 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007A3")]
	[Address(RVA = "0x2146820", Offset = "0x2146921", VA = "0x2146820")]
	public void SetOptimalCamera()
	{
	}

	// Token: 0x060008DF RID: 2271 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007A4")]
	[Address(RVA = "0x2145CF0", Offset = "0x2145DF1", VA = "0x2145CF0")]
	public void StopFarmCamera()
	{
	}

	// Token: 0x060008E0 RID: 2272 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007A5")]
	[Address(RVA = "0x2146890", Offset = "0x2146991", VA = "0x2146890")]
	public PlayerCameraController()
	{
	}

	// Token: 0x04000530 RID: 1328
	[Token(Token = "0x40003FD")]
	private const float GROUND_RAY_LENGTH = 10f;

	// Token: 0x04000531 RID: 1329
	[Token(Token = "0x40003FE")]
	private const float GROUND_UP_OFFSET = 0.1f;

	// Token: 0x04000532 RID: 1330
	[Token(Token = "0x40003FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Animator m_Animator;

	// Token: 0x04000533 RID: 1331
	[Token(Token = "0x4000400")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15C920", Offset = "0x15CA21")]
	private PlayerCameraController.PlayerCameraType <CurrentCameraType>k__BackingField;

	// Token: 0x04000534 RID: 1332
	[Token(Token = "0x4000401")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private CinemachineStateDrivenCamera m_StateDrivenCamere;

	// Token: 0x04000535 RID: 1333
	[Token(Token = "0x4000402")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private IPlayerCamera m_CurrentCamera;

	// Token: 0x04000536 RID: 1334
	[Token(Token = "0x4000403")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private CinemachineImpulseSource CinemachineImpulseSource;

	// Token: 0x04000537 RID: 1335
	[Token(Token = "0x4000404")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private GameObject m_PlayerTarget;

	// Token: 0x04000538 RID: 1336
	[Token(Token = "0x4000405")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private GameObject m_LookonTarget;

	// Token: 0x04000539 RID: 1337
	[Token(Token = "0x4000406")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Vector3 PrevTargetPostion;

	// Token: 0x0400053A RID: 1338
	[Token(Token = "0x4000407")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private bool m_IsFarmCameraCancel;

	// Token: 0x0400053B RID: 1339
	[Token(Token = "0x4000408")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private float m_FarmStopDuration;

	// Token: 0x020001AA RID: 426
	[Token(Token = "0x2000FE4")]
	public enum PlayerCameraType
	{
		// Token: 0x0400053D RID: 1341
		[Token(Token = "0x4018DA7")]
		Default = -1,
		// Token: 0x0400053E RID: 1342
		[Token(Token = "0x4018DA8")]
		Tracking,
		// Token: 0x0400053F RID: 1343
		[Token(Token = "0x4018DA9")]
		Lockon,
		// Token: 0x04000540 RID: 1344
		[Token(Token = "0x4018DAA")]
		Farm
	}
}
