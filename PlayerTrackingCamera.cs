using System;
using Cinemachine;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001AE RID: 430
[Token(Token = "0x2000152")]
public class PlayerTrackingCamera : SingletonMonoBehaviour<PlayerTrackingCamera>, IPlayerCamera
{
	// Token: 0x170001B5 RID: 437
	// (get) Token: 0x060008FA RID: 2298 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700019E")]
	public CinemachineTransposer Transposer
	{
		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x249CB50", Offset = "0x249CC51", VA = "0x249CB50")]
		get
		{
			return null;
		}
	}

	// Token: 0x170001B6 RID: 438
	// (get) Token: 0x060008FB RID: 2299 RVA: 0x00004E90 File Offset: 0x00003090
	// (set) Token: 0x060008FC RID: 2300 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700019F")]
	public float DistanceOffset
	{
		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x249CB60", Offset = "0x249CC61", VA = "0x249CB60", Slot = "9")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19ACB0", Offset = "0x19ADB1")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60007C1")]
		[Address(RVA = "0x249CB70", Offset = "0x249CC71", VA = "0x249CB70", Slot = "10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19ACC0", Offset = "0x19ADC1")]
		set
		{
		}
	}

	// Token: 0x170001B7 RID: 439
	// (get) Token: 0x060008FD RID: 2301 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001A0")]
	private Character CtrlCharacter
	{
		[Token(Token = "0x60007C2")]
		[Address(RVA = "0x249CB80", Offset = "0x249CC81", VA = "0x249CB80")]
		get
		{
			return null;
		}
	}

	// Token: 0x170001B8 RID: 440
	// (get) Token: 0x060008FE RID: 2302 RVA: 0x00004EA8 File Offset: 0x000030A8
	[Token(Token = "0x170001A1")]
	private bool IsInput
	{
		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x249CBE0", Offset = "0x249CCE1", VA = "0x249CBE0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060008FF RID: 2303 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007C4")]
	[Address(RVA = "0x249CC10", Offset = "0x249CD11", VA = "0x249CC10", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x06000900 RID: 2304 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007C5")]
	[Address(RVA = "0x249CD60", Offset = "0x249CE61", VA = "0x249CD60")]
	protected void Start()
	{
	}

	// Token: 0x06000901 RID: 2305 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007C6")]
	[Address(RVA = "0x249CE00", Offset = "0x249CF01", VA = "0x249CE00", Slot = "5")]
	public void PreUpdate()
	{
	}

	// Token: 0x06000902 RID: 2306 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007C7")]
	[Address(RVA = "0x249CE20", Offset = "0x249CF21", VA = "0x249CE20", Slot = "6")]
	public void FrameUpdate()
	{
	}

	// Token: 0x06000903 RID: 2307 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007C8")]
	[Address(RVA = "0x249D7E0", Offset = "0x249D8E1", VA = "0x249D7E0", Slot = "7")]
	public void TimeStepUpdate()
	{
	}

	// Token: 0x06000904 RID: 2308 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007C9")]
	[Address(RVA = "0x249D010", Offset = "0x249D111", VA = "0x249D010")]
	private void UpdateInputAxis()
	{
	}

	// Token: 0x06000905 RID: 2309 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007CA")]
	[Address(RVA = "0x249E040", Offset = "0x249E141", VA = "0x249E040")]
	private void AutoRotateTimeReset()
	{
	}

	// Token: 0x06000906 RID: 2310 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007CB")]
	[Address(RVA = "0x249D140", Offset = "0x249D241", VA = "0x249D140")]
	private void UpdateAutoRotateState()
	{
	}

	// Token: 0x06000907 RID: 2311 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007CC")]
	[Address(RVA = "0x249DE70", Offset = "0x249DF71", VA = "0x249DE70")]
	private void UpdateAutoRotateAxis()
	{
	}

	// Token: 0x06000908 RID: 2312 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007CD")]
	[Address(RVA = "0x249DB50", Offset = "0x249DC51", VA = "0x249DB50")]
	private void UpdateDeadZone()
	{
	}

	// Token: 0x06000909 RID: 2313 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007CE")]
	[Address(RVA = "0x249E050", Offset = "0x249E151", VA = "0x249E050", Slot = "8")]
	public void CameraReset(Quaternion? resetRotation)
	{
	}

	// Token: 0x0600090A RID: 2314 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007CF")]
	[Address(RVA = "0x249CEE0", Offset = "0x249CFE1", VA = "0x249CEE0")]
	public TrackingCameraSetting GetSetting()
	{
		return null;
	}

	// Token: 0x0600090B RID: 2315 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007D0")]
	[Address(RVA = "0x249E5C0", Offset = "0x249E6C1", VA = "0x249E5C0")]
	public TrackingCameraSetting GetSetting(TrackinCameraType type)
	{
		return null;
	}

	// Token: 0x0600090C RID: 2316 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007D1")]
	[Address(RVA = "0x249E5E0", Offset = "0x249E6E1", VA = "0x249E5E0")]
	public PlayerTrackingCamera()
	{
	}

	// Token: 0x04000550 RID: 1360
	[Token(Token = "0x4000418")]
	private const float LERP_DISTANCE_SPEED = 10f;

	// Token: 0x04000551 RID: 1361
	[Token(Token = "0x4000419")]
	private const float LERP_FOV_SPEED = 15f;

	// Token: 0x04000552 RID: 1362
	[Token(Token = "0x400041A")]
	private const float LERP_DEADZONE_SPEED_X = 1.5f;

	// Token: 0x04000553 RID: 1363
	[Token(Token = "0x400041B")]
	private const float LERP_DEADZONE_SPEED_Y = 2f;

	// Token: 0x04000554 RID: 1364
	[Token(Token = "0x400041C")]
	private const float LERP_DEADZONE_ACTION_SPEED = 15f;

	// Token: 0x04000555 RID: 1365
	[Token(Token = "0x400041D")]
	private const float LERP_DEADZONE_INPUT_SPEED = 10f;

	// Token: 0x04000556 RID: 1366
	[Token(Token = "0x400041E")]
	private const float STOP_THRESHOLD = 0.01f;

	// Token: 0x04000557 RID: 1367
	[Token(Token = "0x400041F")]
	private const float DOT_THERSHOLD = 0.9f;

	// Token: 0x04000558 RID: 1368
	[Token(Token = "0x4000420")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private CinemachineVirtualCamera m_VirtualCamera;

	// Token: 0x04000559 RID: 1369
	[Token(Token = "0x4000421")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private TrackingCameraSetting m_Setting;

	// Token: 0x0400055A RID: 1370
	[Token(Token = "0x4000422")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private TrackingCameraSettingTable m_SettingTable;

	// Token: 0x0400055B RID: 1371
	[Token(Token = "0x4000423")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float m_RotateXAxisMax;

	// Token: 0x0400055C RID: 1372
	[Token(Token = "0x4000424")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private float m_RotateXAxisMin;

	// Token: 0x0400055D RID: 1373
	[Token(Token = "0x4000425")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	public float m_AutoRotateSpeed;

	// Token: 0x0400055E RID: 1374
	[Token(Token = "0x4000426")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	public float m_AutoRotateStartTime;

	// Token: 0x0400055F RID: 1375
	[Token(Token = "0x4000427")]
	[FieldOffset(Offset = "0x40")]
	public float m_AutoRotateInSpeed;

	// Token: 0x04000560 RID: 1376
	[Token(Token = "0x4000428")]
	[FieldOffset(Offset = "0x44")]
	public float m_AutoRotateOutSpeed;

	// Token: 0x04000561 RID: 1377
	[Token(Token = "0x4000429")]
	[FieldOffset(Offset = "0x48")]
	public float m_DeadZoneWidth;

	// Token: 0x04000562 RID: 1378
	[Token(Token = "0x400042A")]
	[FieldOffset(Offset = "0x4C")]
	private float m_DeadZoneHeight;

	// Token: 0x04000563 RID: 1379
	[Token(Token = "0x400042B")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private AnimationCurve m_AutoRotateCurve;

	// Token: 0x04000564 RID: 1380
	[Token(Token = "0x400042C")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private AnimationCurve m_FOVRateCurve;

	// Token: 0x04000565 RID: 1381
	[Token(Token = "0x400042D")]
	[FieldOffset(Offset = "0x60")]
	private float m_SpeedYAxis;

	// Token: 0x04000566 RID: 1382
	[Token(Token = "0x400042E")]
	[FieldOffset(Offset = "0x64")]
	private float m_PrevSpeedYAxis;

	// Token: 0x04000567 RID: 1383
	[Token(Token = "0x400042F")]
	[FieldOffset(Offset = "0x68")]
	private float m_SpeedXAxis;

	// Token: 0x04000568 RID: 1384
	[Token(Token = "0x4000430")]
	[FieldOffset(Offset = "0x6C")]
	private float m_PrevSpeedXAxis;

	// Token: 0x04000569 RID: 1385
	[Token(Token = "0x4000431")]
	[FieldOffset(Offset = "0x70")]
	private float m_RotateYAxis;

	// Token: 0x0400056A RID: 1386
	[Token(Token = "0x4000432")]
	[FieldOffset(Offset = "0x74")]
	private float m_RotateXAxis;

	// Token: 0x0400056B RID: 1387
	[Token(Token = "0x4000433")]
	[FieldOffset(Offset = "0x78")]
	private CinemachineTransposer m_Transposer;

	// Token: 0x0400056C RID: 1388
	[Token(Token = "0x4000434")]
	[FieldOffset(Offset = "0x80")]
	private CinemachineComposer m_Composer;

	// Token: 0x0400056D RID: 1389
	[Token(Token = "0x4000435")]
	[FieldOffset(Offset = "0x88")]
	private float m_MoveElapsed;

	// Token: 0x0400056E RID: 1390
	[Token(Token = "0x4000436")]
	[FieldOffset(Offset = "0x8C")]
	private Vector3 m_FollowTargetPosition;

	// Token: 0x0400056F RID: 1391
	[Token(Token = "0x4000437")]
	[FieldOffset(Offset = "0x98")]
	private float m_CurrentDistance;

	// Token: 0x04000570 RID: 1392
	[Token(Token = "0x4000438")]
	[FieldOffset(Offset = "0x9C")]
	private PlayerTrackingCamera.AutoRotateState m_AutoRotateState;

	// Token: 0x04000571 RID: 1393
	[Token(Token = "0x4000439")]
	[FieldOffset(Offset = "0xA0")]
	private float m_AutoRotateElapasedTime;

	// Token: 0x04000572 RID: 1394
	[Token(Token = "0x400043A")]
	[FieldOffset(Offset = "0xA4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15CA10", Offset = "0x15CB11")]
	private float <DistanceOffset>k__BackingField;

	// Token: 0x020001AF RID: 431
	[Token(Token = "0x2000FE5")]
	public enum AutoRotateState
	{
		// Token: 0x04000574 RID: 1396
		[Token(Token = "0x4018DAC")]
		Wait,
		// Token: 0x04000575 RID: 1397
		[Token(Token = "0x4018DAD")]
		Input,
		// Token: 0x04000576 RID: 1398
		[Token(Token = "0x4018DAE")]
		Loop
	}
}
