using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Cinemachine;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001B6 RID: 438
[Token(Token = "0x2000159")]
public class ShortPlayCameraController : CameraControllerBase
{
	// Token: 0x06000914 RID: 2324 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007D9")]
	[Address(RVA = "0x1E38110", Offset = "0x1E38211", VA = "0x1E38110", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x06000915 RID: 2325 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007DA")]
	[Address(RVA = "0x1E381D0", Offset = "0x1E382D1", VA = "0x1E381D0", Slot = "5")]
	protected override void Start()
	{
	}

	// Token: 0x06000916 RID: 2326 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007DB")]
	[Address(RVA = "0x1E381E0", Offset = "0x1E382E1", VA = "0x1E381E0")]
	private void OnDisable()
	{
	}

	// Token: 0x06000917 RID: 2327 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007DC")]
	[Address(RVA = "0x1E38340", Offset = "0x1E38441", VA = "0x1E38340", Slot = "6")]
	public override void EnableCameraSetup(UseCameraType prevCameraType, [Optional] CinemachineVirtualCamera vcam)
	{
	}

	// Token: 0x06000918 RID: 2328 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007DD")]
	[Address(RVA = "0x1E384E0", Offset = "0x1E385E1", VA = "0x1E384E0")]
	public void SetPosition(Vector3 position, Quaternion rotation)
	{
	}

	// Token: 0x06000919 RID: 2329 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007DE")]
	[Address(RVA = "0x1E385B0", Offset = "0x1E386B1", VA = "0x1E385B0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19ACD0", Offset = "0x19ADD1")]
	public IEnumerator SetPosition(float wait, float posX, float posY, float posZ, float rotX, float rotY, float rotZ)
	{
		return null;
	}

	// Token: 0x0600091A RID: 2330 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007DF")]
	[Address(RVA = "0x1E386C0", Offset = "0x1E387C1", VA = "0x1E386C0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19AD40", Offset = "0x19AE41")]
	public IEnumerator SetTargetPosition(float wait, float posX, float posY, float posZ, float rotX, float rotY, float rotZ, float moveSpeed)
	{
		return null;
	}

	// Token: 0x0600091B RID: 2331 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007E0")]
	[Address(RVA = "0x1E387D0", Offset = "0x1E388D1", VA = "0x1E387D0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19ADB0", Offset = "0x19AEB1")]
	private IEnumerator StartCameraReset()
	{
		return null;
	}

	// Token: 0x0600091C RID: 2332 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007E1")]
	[Address(RVA = "0x1E38860", Offset = "0x1E38961", VA = "0x1E38860")]
	public void CameraReset()
	{
	}

	// Token: 0x0600091D RID: 2333 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007E2")]
	[Address(RVA = "0x1E38BF0", Offset = "0x1E38CF1", VA = "0x1E38BF0")]
	public void CameraResetRotateX()
	{
	}

	// Token: 0x0600091E RID: 2334 RVA: 0x00004EC0 File Offset: 0x000030C0
	[Token(Token = "0x60007E3")]
	[Address(RVA = "0x1E388C0", Offset = "0x1E389C1", VA = "0x1E388C0")]
	public Vector3 GetOwnerPosition()
	{
		return default(Vector3);
	}

	// Token: 0x0600091F RID: 2335 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007E4")]
	[Address(RVA = "0x1E38E40", Offset = "0x1E38F41", VA = "0x1E38E40")]
	private void UpdateCameraPosition()
	{
	}

	// Token: 0x06000920 RID: 2336 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007E5")]
	[Address(RVA = "0x1E392B0", Offset = "0x1E393B1", VA = "0x1E392B0")]
	private void UpdateShortPlayCameraPosition()
	{
	}

	// Token: 0x06000921 RID: 2337 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007E6")]
	[Address(RVA = "0x1E39660", Offset = "0x1E39761", VA = "0x1E39660", Slot = "9")]
	public override void FrameUpdate()
	{
	}

	// Token: 0x06000922 RID: 2338 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007E7")]
	[Address(RVA = "0x1E39670", Offset = "0x1E39771", VA = "0x1E39670", Slot = "10")]
	public override void TimeStepUpdate()
	{
	}

	// Token: 0x06000923 RID: 2339 RVA: 0x00004ED8 File Offset: 0x000030D8
	[Token(Token = "0x60007E8")]
	[Address(RVA = "0x1E39290", Offset = "0x1E39391", VA = "0x1E39290")]
	private static float Recal360to180(float val)
	{
		return 0f;
	}

	// Token: 0x06000924 RID: 2340 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007E9")]
	[Address(RVA = "0x1E39680", Offset = "0x1E39781", VA = "0x1E39680")]
	public void AnimationStart(string motionId, float posX, float posY, float posZ, float rotX, float rotY, float rotZ)
	{
	}

	// Token: 0x06000925 RID: 2341 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007EA")]
	[Address(RVA = "0x1E39760", Offset = "0x1E39861", VA = "0x1E39760")]
	public void Shake(float amplitudeGain, float frequencyGain, float attackTime, float sutainTime, float decayTime)
	{
	}

	// Token: 0x06000926 RID: 2342 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007EB")]
	[Address(RVA = "0x1E38290", Offset = "0x1E38391", VA = "0x1E38290")]
	public void SetAnimatorEnable(bool enable)
	{
	}

	// Token: 0x06000927 RID: 2343 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007EC")]
	[Address(RVA = "0x1E39820", Offset = "0x1E39921", VA = "0x1E39820")]
	public void ForceUpdateMainCameraTransform()
	{
	}

	// Token: 0x06000928 RID: 2344 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007ED")]
	[Address(RVA = "0x1E398F0", Offset = "0x1E399F1", VA = "0x1E398F0")]
	public ShortPlayCameraController()
	{
	}

	// Token: 0x04000584 RID: 1412
	[Token(Token = "0x4000448")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Transform TargetPoint;

	// Token: 0x04000585 RID: 1413
	[Token(Token = "0x4000449")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float m_Elapsed;

	// Token: 0x04000586 RID: 1414
	[Token(Token = "0x400044A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private CinemachineImpulseSource CinemachineImpulseSource;

	// Token: 0x04000587 RID: 1415
	[Token(Token = "0x400044B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Animator Animator;

	// Token: 0x04000588 RID: 1416
	[Token(Token = "0x400044C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private float boomLengthBase;

	// Token: 0x04000589 RID: 1417
	[Token(Token = "0x400044D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[SerializeField]
	private float boolHight;

	// Token: 0x0400058A RID: 1418
	[Token(Token = "0x400044E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private float smooth;

	// Token: 0x0400058B RID: 1419
	[Token(Token = "0x400044F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[SerializeField]
	private float PositionLag;

	// Token: 0x0400058C RID: 1420
	[Token(Token = "0x4000450")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private float HighAngleLength;

	// Token: 0x0400058D RID: 1421
	[Token(Token = "0x4000451")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	[SerializeField]
	private float BoomHorizontal;

	// Token: 0x0400058E RID: 1422
	[Token(Token = "0x4000452")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private float PitchAngleMin;

	// Token: 0x0400058F RID: 1423
	[Token(Token = "0x4000453")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[SerializeField]
	private float PitchAngleMax;

	// Token: 0x04000590 RID: 1424
	[Token(Token = "0x4000454")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private float IndoorBoomHeight;

	// Token: 0x04000591 RID: 1425
	[Token(Token = "0x4000455")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	[SerializeField]
	private float IndoorBoomHorizontal;

	// Token: 0x04000592 RID: 1426
	[Token(Token = "0x4000456")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public bool EnptyLockOn;

	// Token: 0x04000593 RID: 1427
	[Token(Token = "0x4000457")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public float shake_decay;

	// Token: 0x04000594 RID: 1428
	[Token(Token = "0x4000458")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public float coef_shake_intensity;

	// Token: 0x04000595 RID: 1429
	[Token(Token = "0x4000459")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private Vector3 originPosition;

	// Token: 0x04000596 RID: 1430
	[Token(Token = "0x400045A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Quaternion originRotation;

	// Token: 0x04000597 RID: 1431
	[Token(Token = "0x400045B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private float shake_intensity;

	// Token: 0x04000598 RID: 1432
	[Token(Token = "0x400045C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private Quaternion boomAngle;

	// Token: 0x04000599 RID: 1433
	[Token(Token = "0x400045D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	private Quaternion targetBoomAngle;

	// Token: 0x0400059A RID: 1434
	[Token(Token = "0x400045E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	private RaycastHit cameraHit;

	// Token: 0x0400059B RID: 1435
	[Token(Token = "0x400045F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private Vector3 ownerPosition;

	// Token: 0x0400059C RID: 1436
	[Token(Token = "0x4000460")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	private Vector3 pos;

	// Token: 0x0400059D RID: 1437
	[Token(Token = "0x4000461")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	[SerializeField]
	private Vector3 TargetPosition;

	// Token: 0x0400059E RID: 1438
	[Token(Token = "0x4000462")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
	private Vector3 TargetRotation;

	// Token: 0x0400059F RID: 1439
	[Token(Token = "0x4000463")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private float MoveSpeed;

	// Token: 0x040005A0 RID: 1440
	[Token(Token = "0x4000464")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
	private Vector3 velocity;

	// Token: 0x040005A1 RID: 1441
	[Token(Token = "0x4000465")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public bool IsReach;

	// Token: 0x020001B7 RID: 439
	[Token(Token = "0x2000FE6")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157210", Offset = "0x157311")]
	private sealed class <SetPosition>d__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000929 RID: 2345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C26")]
		[Address(RVA = "0x1E38690", Offset = "0x1E38791", VA = "0x1E38690")]
		[DebuggerHidden]
		public <SetPosition>d__35(int <>1__state)
		{
		}

		// Token: 0x0600092A RID: 2346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C27")]
		[Address(RVA = "0x1E399B0", Offset = "0x1E39AB1", VA = "0x1E399B0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600092B RID: 2347 RVA: 0x00004EF0 File Offset: 0x000030F0
		[Token(Token = "0x6006C28")]
		[Address(RVA = "0x1E399C0", Offset = "0x1E39AC1", VA = "0x1E399C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x0600092C RID: 2348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BD4")]
		private object Current
		{
			[Token(Token = "0x6006C29")]
			[Address(RVA = "0x1E39BB0", Offset = "0x1E39CB1", VA = "0x1E39BB0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600092D RID: 2349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C2A")]
		[Address(RVA = "0x1E39BC0", Offset = "0x1E39CC1", VA = "0x1E39BC0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x0600092E RID: 2350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BD5")]
		private object Current
		{
			[Token(Token = "0x6006C2B")]
			[Address(RVA = "0x1E39C20", Offset = "0x1E39D21", VA = "0x1E39C20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040005A2 RID: 1442
		[Token(Token = "0x4018DAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040005A3 RID: 1443
		[Token(Token = "0x4018DB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040005A4 RID: 1444
		[Token(Token = "0x4018DB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float wait;

		// Token: 0x040005A5 RID: 1445
		[Token(Token = "0x4018DB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ShortPlayCameraController <>4__this;

		// Token: 0x040005A6 RID: 1446
		[Token(Token = "0x4018DB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float posX;

		// Token: 0x040005A7 RID: 1447
		[Token(Token = "0x4018DB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float posY;

		// Token: 0x040005A8 RID: 1448
		[Token(Token = "0x4018DB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float posZ;

		// Token: 0x040005A9 RID: 1449
		[Token(Token = "0x4018DB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float rotX;

		// Token: 0x040005AA RID: 1450
		[Token(Token = "0x4018DB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float rotY;

		// Token: 0x040005AB RID: 1451
		[Token(Token = "0x4018DB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float rotZ;
	}

	// Token: 0x020001B8 RID: 440
	[Token(Token = "0x2000FE7")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157220", Offset = "0x157321")]
	private sealed class <SetTargetPosition>d__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600092F RID: 2351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C2C")]
		[Address(RVA = "0x1E387A0", Offset = "0x1E388A1", VA = "0x1E387A0")]
		[DebuggerHidden]
		public <SetTargetPosition>d__36(int <>1__state)
		{
		}

		// Token: 0x06000930 RID: 2352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C2D")]
		[Address(RVA = "0x1E39C30", Offset = "0x1E39D31", VA = "0x1E39C30", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000931 RID: 2353 RVA: 0x00004F08 File Offset: 0x00003108
		[Token(Token = "0x6006C2E")]
		[Address(RVA = "0x1E39C40", Offset = "0x1E39D41", VA = "0x1E39C40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06000932 RID: 2354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BD6")]
		private object Current
		{
			[Token(Token = "0x6006C2F")]
			[Address(RVA = "0x1E39DE0", Offset = "0x1E39EE1", VA = "0x1E39DE0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000933 RID: 2355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C30")]
		[Address(RVA = "0x1E39DF0", Offset = "0x1E39EF1", VA = "0x1E39DF0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x06000934 RID: 2356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BD7")]
		private object Current
		{
			[Token(Token = "0x6006C31")]
			[Address(RVA = "0x1E39E50", Offset = "0x1E39F51", VA = "0x1E39E50", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040005AC RID: 1452
		[Token(Token = "0x4018DB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040005AD RID: 1453
		[Token(Token = "0x4018DBA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040005AE RID: 1454
		[Token(Token = "0x4018DBB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float wait;

		// Token: 0x040005AF RID: 1455
		[Token(Token = "0x4018DBC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ShortPlayCameraController <>4__this;

		// Token: 0x040005B0 RID: 1456
		[Token(Token = "0x4018DBD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float posX;

		// Token: 0x040005B1 RID: 1457
		[Token(Token = "0x4018DBE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float posY;

		// Token: 0x040005B2 RID: 1458
		[Token(Token = "0x4018DBF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float posZ;

		// Token: 0x040005B3 RID: 1459
		[Token(Token = "0x4018DC0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float rotX;

		// Token: 0x040005B4 RID: 1460
		[Token(Token = "0x4018DC1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float rotY;

		// Token: 0x040005B5 RID: 1461
		[Token(Token = "0x4018DC2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float rotZ;

		// Token: 0x040005B6 RID: 1462
		[Token(Token = "0x4018DC3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float moveSpeed;
	}

	// Token: 0x020001B9 RID: 441
	[Token(Token = "0x2000FE8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157230", Offset = "0x157331")]
	private sealed class <StartCameraReset>d__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000935 RID: 2357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C32")]
		[Address(RVA = "0x1E38830", Offset = "0x1E38931", VA = "0x1E38830")]
		[DebuggerHidden]
		public <StartCameraReset>d__37(int <>1__state)
		{
		}

		// Token: 0x06000936 RID: 2358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C33")]
		[Address(RVA = "0x1E39E60", Offset = "0x1E39F61", VA = "0x1E39E60", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000937 RID: 2359 RVA: 0x00004F20 File Offset: 0x00003120
		[Token(Token = "0x6006C34")]
		[Address(RVA = "0x1E39E70", Offset = "0x1E39F71", VA = "0x1E39E70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x06000938 RID: 2360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BD8")]
		private object Current
		{
			[Token(Token = "0x6006C35")]
			[Address(RVA = "0x1E39ED0", Offset = "0x1E39FD1", VA = "0x1E39ED0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000939 RID: 2361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C36")]
		[Address(RVA = "0x1E39EE0", Offset = "0x1E39FE1", VA = "0x1E39EE0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x0600093A RID: 2362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BD9")]
		private object Current
		{
			[Token(Token = "0x6006C37")]
			[Address(RVA = "0x1E39F40", Offset = "0x1E3A041", VA = "0x1E39F40", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040005B7 RID: 1463
		[Token(Token = "0x4018DC4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040005B8 RID: 1464
		[Token(Token = "0x4018DC5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;
	}
}
