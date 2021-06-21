using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000CEC RID: 3308
	[Token(Token = "0x2000884")]
	public class CharacterThirdPerson : CharacterBase
	{
		// Token: 0x17000ADD RID: 2781
		// (get) Token: 0x0600548F RID: 21647 RVA: 0x0001BDB0 File Offset: 0x00019FB0
		// (set) Token: 0x06005490 RID: 21648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700089D")]
		public bool onGround
		{
			[Token(Token = "0x6004679")]
			[Address(RVA = "0x29AFCB0", Offset = "0x29AFDB1", VA = "0x29AFCB0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A9890", Offset = "0x1A9991")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600467A")]
			[Address(RVA = "0x29AFCC0", Offset = "0x29AFDC1", VA = "0x29AFCC0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A98A0", Offset = "0x1A99A1")]
			private set
			{
			}
		}

		// Token: 0x06005491 RID: 21649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600467B")]
		[Address(RVA = "0x29AFCD0", Offset = "0x29AFDD1", VA = "0x29AFCD0", Slot = "5")]
		protected override void Start()
		{
		}

		// Token: 0x06005492 RID: 21650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600467C")]
		[Address(RVA = "0x29AFE80", Offset = "0x29AFF81", VA = "0x29AFE80")]
		private void OnAnimatorMove()
		{
		}

		// Token: 0x06005493 RID: 21651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600467D")]
		[Address(RVA = "0x29AFF20", Offset = "0x29B0021", VA = "0x29AFF20", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		// Token: 0x06005494 RID: 21652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600467E")]
		[Address(RVA = "0x29B0060", Offset = "0x29B0161", VA = "0x29B0060")]
		private void FixedUpdate()
		{
		}

		// Token: 0x06005495 RID: 21653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600467F")]
		[Address(RVA = "0x29B0FF0", Offset = "0x29B10F1", VA = "0x29B0FF0", Slot = "7")]
		protected virtual void Update()
		{
		}

		// Token: 0x06005496 RID: 21654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004680")]
		[Address(RVA = "0x29B1390", Offset = "0x29B1491", VA = "0x29B1390", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		// Token: 0x06005497 RID: 21655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004681")]
		[Address(RVA = "0x29B06A0", Offset = "0x29B07A1", VA = "0x29B06A0")]
		private void MoveFixed(Vector3 deltaPosition)
		{
		}

		// Token: 0x06005498 RID: 21656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004682")]
		[Address(RVA = "0x29B1470", Offset = "0x29B1571", VA = "0x29B1470")]
		private void WallRun()
		{
		}

		// Token: 0x06005499 RID: 21657 RVA: 0x0001BDC8 File Offset: 0x00019FC8
		[Token(Token = "0x6004683")]
		[Address(RVA = "0x29B1AD0", Offset = "0x29B1BD1", VA = "0x29B1AD0")]
		private bool CanWallRun()
		{
			return default(bool);
		}

		// Token: 0x0600549A RID: 21658 RVA: 0x0001BDE0 File Offset: 0x00019FE0
		[Token(Token = "0x6004684")]
		[Address(RVA = "0x29B10D0", Offset = "0x29B11D1", VA = "0x29B10D0")]
		private Vector3 GetMoveDirection()
		{
			return default(Vector3);
		}

		// Token: 0x0600549B RID: 21659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004685")]
		[Address(RVA = "0x29B1B80", Offset = "0x29B1C81", VA = "0x29B1B80", Slot = "9")]
		protected virtual void Rotate()
		{
		}

		// Token: 0x0600549C RID: 21660 RVA: 0x0001BDF8 File Offset: 0x00019FF8
		[Token(Token = "0x6004686")]
		[Address(RVA = "0x29B1FF0", Offset = "0x29B20F1", VA = "0x29B1FF0")]
		private Vector3 GetForwardDirection()
		{
			return default(Vector3);
		}

		// Token: 0x0600549D RID: 21661 RVA: 0x0001BE10 File Offset: 0x0001A010
		[Token(Token = "0x6004687")]
		[Address(RVA = "0x29B2180", Offset = "0x29B2281", VA = "0x29B2180", Slot = "10")]
		protected virtual bool Jump()
		{
			return default(bool);
		}

		// Token: 0x0600549E RID: 21662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004688")]
		[Address(RVA = "0x29B2400", Offset = "0x29B2501", VA = "0x29B2400")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A98B0", Offset = "0x1A99B1")]
		private IEnumerator JumpSmooth(Vector3 jumpVelocity)
		{
			return null;
		}

		// Token: 0x0600549F RID: 21663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004689")]
		[Address(RVA = "0x29B0BB0", Offset = "0x29B0CB1", VA = "0x29B0BB0")]
		private void GroundCheck()
		{
		}

		// Token: 0x060054A0 RID: 21664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600468A")]
		[Address(RVA = "0x29B24D0", Offset = "0x29B25D1", VA = "0x29B24D0")]
		public CharacterThirdPerson()
		{
		}

		// Token: 0x0400B3CF RID: 46031
		[Token(Token = "0x400870D")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x178360", Offset = "0x178461")]
		public CharacterAnimationBase characterAnimation;

		// Token: 0x0400B3D0 RID: 46032
		[Token(Token = "0x400870E")]
		[FieldOffset(Offset = "0x70")]
		public UserControlThirdPerson userControl;

		// Token: 0x0400B3D1 RID: 46033
		[Token(Token = "0x400870F")]
		[FieldOffset(Offset = "0x78")]
		public CameraController cam;

		// Token: 0x0400B3D2 RID: 46034
		[Token(Token = "0x4008710")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x1783A0", Offset = "0x1784A1")]
		public CharacterThirdPerson.MoveMode moveMode;

		// Token: 0x0400B3D3 RID: 46035
		[Token(Token = "0x4008711")]
		[FieldOffset(Offset = "0x84")]
		public bool smoothPhysics;

		// Token: 0x0400B3D4 RID: 46036
		[Token(Token = "0x4008712")]
		[FieldOffset(Offset = "0x88")]
		public float smoothAccelerationTime;

		// Token: 0x0400B3D5 RID: 46037
		[Token(Token = "0x4008713")]
		[FieldOffset(Offset = "0x8C")]
		public float linearAccelerationSpeed;

		// Token: 0x0400B3D6 RID: 46038
		[Token(Token = "0x4008714")]
		[FieldOffset(Offset = "0x90")]
		public float platformFriction;

		// Token: 0x0400B3D7 RID: 46039
		[Token(Token = "0x4008715")]
		[FieldOffset(Offset = "0x94")]
		public float groundStickyEffect;

		// Token: 0x0400B3D8 RID: 46040
		[Token(Token = "0x4008716")]
		[FieldOffset(Offset = "0x98")]
		public float maxVerticalVelocityOnGround;

		// Token: 0x0400B3D9 RID: 46041
		[Token(Token = "0x4008717")]
		[FieldOffset(Offset = "0x9C")]
		public float velocityToGroundTangentWeight;

		// Token: 0x0400B3DA RID: 46042
		[Token(Token = "0x4008718")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x1783E0", Offset = "0x1784E1")]
		public bool lookInCameraDirection;

		// Token: 0x0400B3DB RID: 46043
		[Token(Token = "0x4008719")]
		[FieldOffset(Offset = "0xA4")]
		public float turnSpeed;

		// Token: 0x0400B3DC RID: 46044
		[Token(Token = "0x400871A")]
		[FieldOffset(Offset = "0xA8")]
		public float stationaryTurnSpeedMlp;

		// Token: 0x0400B3DD RID: 46045
		[Token(Token = "0x400871B")]
		[FieldOffset(Offset = "0xAC")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x178420", Offset = "0x178521")]
		public bool smoothJump;

		// Token: 0x0400B3DE RID: 46046
		[Token(Token = "0x400871C")]
		[FieldOffset(Offset = "0xB0")]
		public float airSpeed;

		// Token: 0x0400B3DF RID: 46047
		[Token(Token = "0x400871D")]
		[FieldOffset(Offset = "0xB4")]
		public float airControl;

		// Token: 0x0400B3E0 RID: 46048
		[Token(Token = "0x400871E")]
		[FieldOffset(Offset = "0xB8")]
		public float jumpPower;

		// Token: 0x0400B3E1 RID: 46049
		[Token(Token = "0x400871F")]
		[FieldOffset(Offset = "0xBC")]
		public float jumpRepeatDelayTime;

		// Token: 0x0400B3E2 RID: 46050
		[Token(Token = "0x4008720")]
		[FieldOffset(Offset = "0xC0")]
		public bool doubleJumpEnabled;

		// Token: 0x0400B3E3 RID: 46051
		[Token(Token = "0x4008721")]
		[FieldOffset(Offset = "0xC4")]
		public float doubleJumpPowerMlp;

		// Token: 0x0400B3E4 RID: 46052
		[Token(Token = "0x4008722")]
		[FieldOffset(Offset = "0xC8")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x178460", Offset = "0x178561")]
		public LayerMask wallRunLayers;

		// Token: 0x0400B3E5 RID: 46053
		[Token(Token = "0x4008723")]
		[FieldOffset(Offset = "0xCC")]
		public float wallRunMaxLength;

		// Token: 0x0400B3E6 RID: 46054
		[Token(Token = "0x4008724")]
		[FieldOffset(Offset = "0xD0")]
		public float wallRunMinMoveMag;

		// Token: 0x0400B3E7 RID: 46055
		[Token(Token = "0x4008725")]
		[FieldOffset(Offset = "0xD4")]
		public float wallRunMinVelocityY;

		// Token: 0x0400B3E8 RID: 46056
		[Token(Token = "0x4008726")]
		[FieldOffset(Offset = "0xD8")]
		public float wallRunRotationSpeed;

		// Token: 0x0400B3E9 RID: 46057
		[Token(Token = "0x4008727")]
		[FieldOffset(Offset = "0xDC")]
		public float wallRunMaxRotationAngle;

		// Token: 0x0400B3EA RID: 46058
		[Token(Token = "0x4008728")]
		[FieldOffset(Offset = "0xE0")]
		public float wallRunWeightSpeed;

		// Token: 0x0400B3EB RID: 46059
		[Token(Token = "0x4008729")]
		[FieldOffset(Offset = "0xE4")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x1784A0", Offset = "0x1785A1")]
		public float crouchCapsuleScaleMlp;

		// Token: 0x0400B3EC RID: 46060
		[Token(Token = "0x400872A")]
		[FieldOffset(Offset = "0xE8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1784E0", Offset = "0x1785E1")]
		private bool <onGround>k__BackingField;

		// Token: 0x0400B3ED RID: 46061
		[Token(Token = "0x400872B")]
		[FieldOffset(Offset = "0xEC")]
		public CharacterThirdPerson.AnimState animState;

		// Token: 0x0400B3EE RID: 46062
		[Token(Token = "0x400872C")]
		[FieldOffset(Offset = "0x104")]
		protected Vector3 moveDirection;

		// Token: 0x0400B3EF RID: 46063
		[Token(Token = "0x400872D")]
		[FieldOffset(Offset = "0x110")]
		private Animator animator;

		// Token: 0x0400B3F0 RID: 46064
		[Token(Token = "0x400872E")]
		[FieldOffset(Offset = "0x118")]
		private Vector3 normal;

		// Token: 0x0400B3F1 RID: 46065
		[Token(Token = "0x400872F")]
		[FieldOffset(Offset = "0x124")]
		private Vector3 platformVelocity;

		// Token: 0x0400B3F2 RID: 46066
		[Token(Token = "0x4008730")]
		[FieldOffset(Offset = "0x130")]
		private Vector3 platformAngularVelocity;

		// Token: 0x0400B3F3 RID: 46067
		[Token(Token = "0x4008731")]
		[FieldOffset(Offset = "0x13C")]
		private RaycastHit hit;

		// Token: 0x0400B3F4 RID: 46068
		[Token(Token = "0x4008732")]
		[FieldOffset(Offset = "0x168")]
		private float jumpLeg;

		// Token: 0x0400B3F5 RID: 46069
		[Token(Token = "0x4008733")]
		[FieldOffset(Offset = "0x16C")]
		private float jumpEndTime;

		// Token: 0x0400B3F6 RID: 46070
		[Token(Token = "0x4008734")]
		[FieldOffset(Offset = "0x170")]
		private float forwardMlp;

		// Token: 0x0400B3F7 RID: 46071
		[Token(Token = "0x4008735")]
		[FieldOffset(Offset = "0x174")]
		private float groundDistance;

		// Token: 0x0400B3F8 RID: 46072
		[Token(Token = "0x4008736")]
		[FieldOffset(Offset = "0x178")]
		private float lastAirTime;

		// Token: 0x0400B3F9 RID: 46073
		[Token(Token = "0x4008737")]
		[FieldOffset(Offset = "0x17C")]
		private float stickyForce;

		// Token: 0x0400B3FA RID: 46074
		[Token(Token = "0x4008738")]
		[FieldOffset(Offset = "0x180")]
		private Vector3 wallNormal;

		// Token: 0x0400B3FB RID: 46075
		[Token(Token = "0x4008739")]
		[FieldOffset(Offset = "0x18C")]
		private Vector3 moveDirectionVelocity;

		// Token: 0x0400B3FC RID: 46076
		[Token(Token = "0x400873A")]
		[FieldOffset(Offset = "0x198")]
		private float wallRunWeight;

		// Token: 0x0400B3FD RID: 46077
		[Token(Token = "0x400873B")]
		[FieldOffset(Offset = "0x19C")]
		private float lastWallRunWeight;

		// Token: 0x0400B3FE RID: 46078
		[Token(Token = "0x400873C")]
		[FieldOffset(Offset = "0x1A0")]
		private Vector3 fixedDeltaPosition;

		// Token: 0x0400B3FF RID: 46079
		[Token(Token = "0x400873D")]
		[FieldOffset(Offset = "0x1AC")]
		private Quaternion fixedDeltaRotation;

		// Token: 0x0400B400 RID: 46080
		[Token(Token = "0x400873E")]
		[FieldOffset(Offset = "0x1BC")]
		private bool fixedFrame;

		// Token: 0x0400B401 RID: 46081
		[Token(Token = "0x400873F")]
		[FieldOffset(Offset = "0x1C0")]
		private float wallRunEndTime;

		// Token: 0x0400B402 RID: 46082
		[Token(Token = "0x4008740")]
		[FieldOffset(Offset = "0x1C4")]
		private Vector3 gravity;

		// Token: 0x0400B403 RID: 46083
		[Token(Token = "0x4008741")]
		[FieldOffset(Offset = "0x1D0")]
		private Vector3 verticalVelocity;

		// Token: 0x0400B404 RID: 46084
		[Token(Token = "0x4008742")]
		[FieldOffset(Offset = "0x1DC")]
		private float velocityY;

		// Token: 0x0400B405 RID: 46085
		[Token(Token = "0x4008743")]
		[FieldOffset(Offset = "0x1E0")]
		private bool doubleJumped;

		// Token: 0x0400B406 RID: 46086
		[Token(Token = "0x4008744")]
		[FieldOffset(Offset = "0x1E1")]
		private bool jumpReleased;

		// Token: 0x02000CED RID: 3309
		[Token(Token = "0x20013E1")]
		[Serializable]
		public enum MoveMode
		{
			// Token: 0x0400B408 RID: 46088
			[Token(Token = "0x401B907")]
			Directional,
			// Token: 0x0400B409 RID: 46089
			[Token(Token = "0x401B908")]
			Strafe
		}

		// Token: 0x02000CEE RID: 3310
		[Token(Token = "0x20013E2")]
		public struct AnimState
		{
			// Token: 0x0400B40A RID: 46090
			[Token(Token = "0x401B909")]
			[FieldOffset(Offset = "0x0")]
			public Vector3 moveDirection;

			// Token: 0x0400B40B RID: 46091
			[Token(Token = "0x401B90A")]
			[FieldOffset(Offset = "0xC")]
			public bool jump;

			// Token: 0x0400B40C RID: 46092
			[Token(Token = "0x401B90B")]
			[FieldOffset(Offset = "0xD")]
			public bool crouch;

			// Token: 0x0400B40D RID: 46093
			[Token(Token = "0x401B90C")]
			[FieldOffset(Offset = "0xE")]
			public bool onGround;

			// Token: 0x0400B40E RID: 46094
			[Token(Token = "0x401B90D")]
			[FieldOffset(Offset = "0xF")]
			public bool isStrafing;

			// Token: 0x0400B40F RID: 46095
			[Token(Token = "0x401B90E")]
			[FieldOffset(Offset = "0x10")]
			public float yVelocity;

			// Token: 0x0400B410 RID: 46096
			[Token(Token = "0x401B90F")]
			[FieldOffset(Offset = "0x14")]
			public bool doubleJump;
		}

		// Token: 0x02000CEF RID: 3311
		[Token(Token = "0x20013E3")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159770", Offset = "0x159871")]
		private sealed class <JumpSmooth>d__74 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x060054A1 RID: 21665 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60078E0")]
			[Address(RVA = "0x29B24A0", Offset = "0x29B25A1", VA = "0x29B24A0")]
			[DebuggerHidden]
			public <JumpSmooth>d__74(int <>1__state)
			{
			}

			// Token: 0x060054A2 RID: 21666 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60078E1")]
			[Address(RVA = "0x29B2630", Offset = "0x29B2731", VA = "0x29B2630", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x060054A3 RID: 21667 RVA: 0x0001BE28 File Offset: 0x0001A028
			[Token(Token = "0x60078E2")]
			[Address(RVA = "0x29B2640", Offset = "0x29B2741", VA = "0x29B2640", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000ADE RID: 2782
			// (get) Token: 0x060054A4 RID: 21668 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000DFD")]
			private object Current
			{
				[Token(Token = "0x60078E3")]
				[Address(RVA = "0x29B2790", Offset = "0x29B2891", VA = "0x29B2790", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x060054A5 RID: 21669 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60078E4")]
			[Address(RVA = "0x29B27A0", Offset = "0x29B28A1", VA = "0x29B27A0", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000ADF RID: 2783
			// (get) Token: 0x060054A6 RID: 21670 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000DFE")]
			private object Current
			{
				[Token(Token = "0x60078E5")]
				[Address(RVA = "0x29B2800", Offset = "0x29B2901", VA = "0x29B2800", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400B411 RID: 46097
			[Token(Token = "0x401B910")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400B412 RID: 46098
			[Token(Token = "0x401B911")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0400B413 RID: 46099
			[Token(Token = "0x401B912")]
			[FieldOffset(Offset = "0x20")]
			public CharacterThirdPerson <>4__this;

			// Token: 0x0400B414 RID: 46100
			[Token(Token = "0x401B913")]
			[FieldOffset(Offset = "0x28")]
			public Vector3 jumpVelocity;

			// Token: 0x0400B415 RID: 46101
			[Token(Token = "0x401B914")]
			[FieldOffset(Offset = "0x34")]
			private int <steps>5__2;

			// Token: 0x0400B416 RID: 46102
			[Token(Token = "0x401B915")]
			[FieldOffset(Offset = "0x38")]
			private int <stepsToTake>5__3;
		}
	}
}
