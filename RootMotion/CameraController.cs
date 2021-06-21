using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x02000C8C RID: 3212
	[Token(Token = "0x2000837")]
	public class CameraController : MonoBehaviour
	{
		// Token: 0x17000AC0 RID: 2752
		// (get) Token: 0x060052B6 RID: 21174 RVA: 0x0001B060 File Offset: 0x00019260
		// (set) Token: 0x060052B7 RID: 21175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700088A")]
		public float x
		{
			[Token(Token = "0x60044D7")]
			[Address(RVA = "0x29A9F50", Offset = "0x29AA051", VA = "0x29A9F50")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A9600", Offset = "0x1A9701")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60044D8")]
			[Address(RVA = "0x29A9F60", Offset = "0x29AA061", VA = "0x29A9F60")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A9610", Offset = "0x1A9711")]
			private set
			{
			}
		}

		// Token: 0x17000AC1 RID: 2753
		// (get) Token: 0x060052B8 RID: 21176 RVA: 0x0001B078 File Offset: 0x00019278
		// (set) Token: 0x060052B9 RID: 21177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700088B")]
		public float y
		{
			[Token(Token = "0x60044D9")]
			[Address(RVA = "0x29A9F70", Offset = "0x29AA071", VA = "0x29A9F70")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A9620", Offset = "0x1A9721")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60044DA")]
			[Address(RVA = "0x29A9F80", Offset = "0x29AA081", VA = "0x29A9F80")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A9630", Offset = "0x1A9731")]
			private set
			{
			}
		}

		// Token: 0x17000AC2 RID: 2754
		// (get) Token: 0x060052BA RID: 21178 RVA: 0x0001B090 File Offset: 0x00019290
		// (set) Token: 0x060052BB RID: 21179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700088C")]
		public float distanceTarget
		{
			[Token(Token = "0x60044DB")]
			[Address(RVA = "0x29A9F90", Offset = "0x29AA091", VA = "0x29A9F90")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A9640", Offset = "0x1A9741")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60044DC")]
			[Address(RVA = "0x29A9FA0", Offset = "0x29AA0A1", VA = "0x29A9FA0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A9650", Offset = "0x1A9751")]
			private set
			{
			}
		}

		// Token: 0x060052BC RID: 21180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044DD")]
		[Address(RVA = "0x29A9FB0", Offset = "0x29AA0B1", VA = "0x29A9FB0")]
		public void SetAngles(Quaternion rotation)
		{
		}

		// Token: 0x060052BD RID: 21181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044DE")]
		[Address(RVA = "0x29A9FF0", Offset = "0x29AA0F1", VA = "0x29A9FF0")]
		public void SetAngles(float yaw, float pitch)
		{
		}

		// Token: 0x060052BE RID: 21182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044DF")]
		[Address(RVA = "0x29AA000", Offset = "0x29AA101", VA = "0x29AA000", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x060052BF RID: 21183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044E0")]
		[Address(RVA = "0x29AA130", Offset = "0x29AA231", VA = "0x29AA130", Slot = "5")]
		protected virtual void Update()
		{
		}

		// Token: 0x060052C0 RID: 21184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044E1")]
		[Address(RVA = "0x29AA1A0", Offset = "0x29AA2A1", VA = "0x29AA1A0", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		// Token: 0x060052C1 RID: 21185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044E2")]
		[Address(RVA = "0x29AA210", Offset = "0x29AA311", VA = "0x29AA210", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		// Token: 0x060052C2 RID: 21186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044E3")]
		[Address(RVA = "0x29AA280", Offset = "0x29AA381", VA = "0x29AA280")]
		public void UpdateInput()
		{
		}

		// Token: 0x060052C3 RID: 21187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044E4")]
		[Address(RVA = "0x29AA170", Offset = "0x29AA271", VA = "0x29AA170")]
		public void UpdateTransform()
		{
		}

		// Token: 0x060052C4 RID: 21188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044E5")]
		[Address(RVA = "0x29AA4D0", Offset = "0x29AA5D1", VA = "0x29AA4D0")]
		public void UpdateTransform(float deltaTime)
		{
		}

		// Token: 0x17000AC3 RID: 2755
		// (get) Token: 0x060052C5 RID: 21189 RVA: 0x0001B0A8 File Offset: 0x000192A8
		[Token(Token = "0x1700088D")]
		private float zoomAdd
		{
			[Token(Token = "0x60044E6")]
			[Address(RVA = "0x29AAB80", Offset = "0x29AAC81", VA = "0x29AAB80")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060052C6 RID: 21190 RVA: 0x0001B0C0 File Offset: 0x000192C0
		[Token(Token = "0x60044E7")]
		[Address(RVA = "0x29AAAD0", Offset = "0x29AABD1", VA = "0x29AAAD0")]
		private float ClampAngle(float angle, float min, float max)
		{
			return 0f;
		}

		// Token: 0x060052C7 RID: 21191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044E8")]
		[Address(RVA = "0x29AAC10", Offset = "0x29AAD11", VA = "0x29AAC10")]
		public CameraController()
		{
		}

		// Token: 0x0400B18E RID: 45454
		[Token(Token = "0x4008529")]
		[FieldOffset(Offset = "0x18")]
		public Transform target;

		// Token: 0x0400B18F RID: 45455
		[Token(Token = "0x400852A")]
		[FieldOffset(Offset = "0x20")]
		public Transform rotationSpace;

		// Token: 0x0400B190 RID: 45456
		[Token(Token = "0x400852B")]
		[FieldOffset(Offset = "0x28")]
		public CameraController.UpdateMode updateMode;

		// Token: 0x0400B191 RID: 45457
		[Token(Token = "0x400852C")]
		[FieldOffset(Offset = "0x2C")]
		public bool lockCursor;

		// Token: 0x0400B192 RID: 45458
		[Token(Token = "0x400852D")]
		[FieldOffset(Offset = "0x2D")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x177310", Offset = "0x177411")]
		public bool smoothFollow;

		// Token: 0x0400B193 RID: 45459
		[Token(Token = "0x400852E")]
		[FieldOffset(Offset = "0x30")]
		public Vector3 offset;

		// Token: 0x0400B194 RID: 45460
		[Token(Token = "0x400852F")]
		[FieldOffset(Offset = "0x3C")]
		public float followSpeed;

		// Token: 0x0400B195 RID: 45461
		[Token(Token = "0x4008530")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x177350", Offset = "0x177451")]
		public float rotationSensitivity;

		// Token: 0x0400B196 RID: 45462
		[Token(Token = "0x4008531")]
		[FieldOffset(Offset = "0x44")]
		public float yMinLimit;

		// Token: 0x0400B197 RID: 45463
		[Token(Token = "0x4008532")]
		[FieldOffset(Offset = "0x48")]
		public float yMaxLimit;

		// Token: 0x0400B198 RID: 45464
		[Token(Token = "0x4008533")]
		[FieldOffset(Offset = "0x4C")]
		public bool rotateAlways;

		// Token: 0x0400B199 RID: 45465
		[Token(Token = "0x4008534")]
		[FieldOffset(Offset = "0x4D")]
		public bool rotateOnLeftButton;

		// Token: 0x0400B19A RID: 45466
		[Token(Token = "0x4008535")]
		[FieldOffset(Offset = "0x4E")]
		public bool rotateOnRightButton;

		// Token: 0x0400B19B RID: 45467
		[Token(Token = "0x4008536")]
		[FieldOffset(Offset = "0x4F")]
		public bool rotateOnMiddleButton;

		// Token: 0x0400B19C RID: 45468
		[Token(Token = "0x4008537")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x177390", Offset = "0x177491")]
		public float distance;

		// Token: 0x0400B19D RID: 45469
		[Token(Token = "0x4008538")]
		[FieldOffset(Offset = "0x54")]
		public float minDistance;

		// Token: 0x0400B19E RID: 45470
		[Token(Token = "0x4008539")]
		[FieldOffset(Offset = "0x58")]
		public float maxDistance;

		// Token: 0x0400B19F RID: 45471
		[Token(Token = "0x400853A")]
		[FieldOffset(Offset = "0x5C")]
		public float zoomSpeed;

		// Token: 0x0400B1A0 RID: 45472
		[Token(Token = "0x400853B")]
		[FieldOffset(Offset = "0x60")]
		public float zoomSensitivity;

		// Token: 0x0400B1A1 RID: 45473
		[Token(Token = "0x400853C")]
		[FieldOffset(Offset = "0x64")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x1773D0", Offset = "0x1774D1")]
		public LayerMask blockingLayers;

		// Token: 0x0400B1A2 RID: 45474
		[Token(Token = "0x400853D")]
		[FieldOffset(Offset = "0x68")]
		public float blockingRadius;

		// Token: 0x0400B1A3 RID: 45475
		[Token(Token = "0x400853E")]
		[FieldOffset(Offset = "0x6C")]
		public float blockingSmoothTime;

		// Token: 0x0400B1A4 RID: 45476
		[Token(Token = "0x400853F")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "RangeAttribute", RVA = "0x177410", Offset = "0x177511")]
		public float blockedOffset;

		// Token: 0x0400B1A5 RID: 45477
		[Token(Token = "0x4008540")]
		[FieldOffset(Offset = "0x74")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x177430", Offset = "0x177531")]
		private float <x>k__BackingField;

		// Token: 0x0400B1A6 RID: 45478
		[Token(Token = "0x4008541")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x177440", Offset = "0x177541")]
		private float <y>k__BackingField;

		// Token: 0x0400B1A7 RID: 45479
		[Token(Token = "0x4008542")]
		[FieldOffset(Offset = "0x7C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x177450", Offset = "0x177551")]
		private float <distanceTarget>k__BackingField;

		// Token: 0x0400B1A8 RID: 45480
		[Token(Token = "0x4008543")]
		[FieldOffset(Offset = "0x80")]
		private Vector3 targetDistance;

		// Token: 0x0400B1A9 RID: 45481
		[Token(Token = "0x4008544")]
		[FieldOffset(Offset = "0x8C")]
		private Vector3 position;

		// Token: 0x0400B1AA RID: 45482
		[Token(Token = "0x4008545")]
		[FieldOffset(Offset = "0x98")]
		private Quaternion rotation;

		// Token: 0x0400B1AB RID: 45483
		[Token(Token = "0x4008546")]
		[FieldOffset(Offset = "0xA8")]
		private Vector3 smoothPosition;

		// Token: 0x0400B1AC RID: 45484
		[Token(Token = "0x4008547")]
		[FieldOffset(Offset = "0xB8")]
		private Camera cam;

		// Token: 0x0400B1AD RID: 45485
		[Token(Token = "0x4008548")]
		[FieldOffset(Offset = "0xC0")]
		private bool fixedFrame;

		// Token: 0x0400B1AE RID: 45486
		[Token(Token = "0x4008549")]
		[FieldOffset(Offset = "0xC4")]
		private float fixedDeltaTime;

		// Token: 0x0400B1AF RID: 45487
		[Token(Token = "0x400854A")]
		[FieldOffset(Offset = "0xC8")]
		private Quaternion r;

		// Token: 0x0400B1B0 RID: 45488
		[Token(Token = "0x400854B")]
		[FieldOffset(Offset = "0xD8")]
		private Vector3 lastUp;

		// Token: 0x0400B1B1 RID: 45489
		[Token(Token = "0x400854C")]
		[FieldOffset(Offset = "0xE4")]
		private float blockedDistance;

		// Token: 0x0400B1B2 RID: 45490
		[Token(Token = "0x400854D")]
		[FieldOffset(Offset = "0xE8")]
		private float blockedDistanceV;

		// Token: 0x02000C8D RID: 3213
		[Token(Token = "0x20013CE")]
		[Serializable]
		public enum UpdateMode
		{
			// Token: 0x0400B1B4 RID: 45492
			[Token(Token = "0x401B8AA")]
			Update,
			// Token: 0x0400B1B5 RID: 45493
			[Token(Token = "0x401B8AB")]
			FixedUpdate,
			// Token: 0x0400B1B6 RID: 45494
			[Token(Token = "0x401B8AC")]
			LateUpdate,
			// Token: 0x0400B1B7 RID: 45495
			[Token(Token = "0x401B8AD")]
			FixedLateUpdate
		}
	}
}
