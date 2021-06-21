using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace RootMotion.FinalIK
{
	// Token: 0x02000D4C RID: 3404
	[Token(Token = "0x20008C8")]
	[Serializable]
	public class IKSolverVR : IKSolver
	{
		// Token: 0x060057E3 RID: 22499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004944")]
		[Address(RVA = "0x2583660", Offset = "0x2583761", VA = "0x2583660")]
		public void SetToReferences(VRIK.References references)
		{
		}

		// Token: 0x060057E4 RID: 22500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004945")]
		[Address(RVA = "0x2583B20", Offset = "0x2583C21", VA = "0x2583B20")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		// Token: 0x060057E5 RID: 22501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004946")]
		[Address(RVA = "0x25839A0", Offset = "0x2583AA1", VA = "0x25839A0")]
		public void DefaultAnimationCurves()
		{
		}

		// Token: 0x060057E6 RID: 22502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004947")]
		[Address(RVA = "0x2584530", Offset = "0x2584631", VA = "0x2584530")]
		public void AddPositionOffset(IKSolverVR.PositionOffset positionOffset, Vector3 value)
		{
		}

		// Token: 0x060057E7 RID: 22503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004948")]
		[Address(RVA = "0x2584810", Offset = "0x2584911", VA = "0x2584810")]
		public void AddRotationOffset(IKSolverVR.RotationOffset rotationOffset, Vector3 value)
		{
		}

		// Token: 0x060057E8 RID: 22504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004949")]
		[Address(RVA = "0x25848C0", Offset = "0x25849C1", VA = "0x25848C0")]
		public void AddRotationOffset(IKSolverVR.RotationOffset rotationOffset, Quaternion value)
		{
		}

		// Token: 0x060057E9 RID: 22505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600494A")]
		[Address(RVA = "0x2584A60", Offset = "0x2584B61", VA = "0x2584A60")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		// Token: 0x060057EA RID: 22506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600494B")]
		[Address(RVA = "0x2584BF0", Offset = "0x2584CF1", VA = "0x2584BF0")]
		public void Reset()
		{
		}

		// Token: 0x060057EB RID: 22507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600494C")]
		[Address(RVA = "0x25854A0", Offset = "0x25855A1", VA = "0x25854A0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		// Token: 0x060057EC RID: 22508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600494D")]
		[Address(RVA = "0x2585620", Offset = "0x2585721", VA = "0x2585620", Slot = "8")]
		public override void FixTransforms()
		{
		}

		// Token: 0x060057ED RID: 22509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600494E")]
		[Address(RVA = "0x2585870", Offset = "0x2585971", VA = "0x2585870", Slot = "6")]
		public override IKSolver.Point[] GetPoints()
		{
			return null;
		}

		// Token: 0x060057EE RID: 22510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600494F")]
		[Address(RVA = "0x25858F0", Offset = "0x25859F1", VA = "0x25858F0", Slot = "7")]
		public override IKSolver.Point GetPoint(Transform transform)
		{
			return null;
		}

		// Token: 0x060057EF RID: 22511 RVA: 0x0001CE90 File Offset: 0x0001B090
		[Token(Token = "0x6004950")]
		[Address(RVA = "0x2585970", Offset = "0x2585A71", VA = "0x2585970", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		// Token: 0x060057F0 RID: 22512 RVA: 0x0001CEA8 File Offset: 0x0001B0A8
		[Token(Token = "0x6004951")]
		[Address(RVA = "0x2585B90", Offset = "0x2585C91", VA = "0x2585B90")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		// Token: 0x060057F1 RID: 22513 RVA: 0x0001CEC0 File Offset: 0x0001B0C0
		[Token(Token = "0x6004952")]
		[Address(RVA = "0x2583DC0", Offset = "0x2583EC1", VA = "0x2583DC0")]
		private Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		// Token: 0x060057F2 RID: 22514 RVA: 0x0001CED8 File Offset: 0x0001B0D8
		[Token(Token = "0x6004953")]
		[Address(RVA = "0x2583FA0", Offset = "0x25840A1", VA = "0x2583FA0")]
		private Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		// Token: 0x060057F3 RID: 22515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004954")]
		[Address(RVA = "0x2584400", Offset = "0x2584501", VA = "0x2584400")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		// Token: 0x060057F4 RID: 22516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004955")]
		[Address(RVA = "0x2584D70", Offset = "0x2584E71", VA = "0x2584D70")]
		private void UpdateSolverTransforms()
		{
		}

		// Token: 0x060057F5 RID: 22517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004956")]
		[Address(RVA = "0x2585E70", Offset = "0x2585F71", VA = "0x2585E70", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		// Token: 0x060057F6 RID: 22518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004957")]
		[Address(RVA = "0x2585EC0", Offset = "0x2585FC1", VA = "0x2585EC0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		// Token: 0x060057F7 RID: 22519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004958")]
		[Address(RVA = "0x25876D0", Offset = "0x25877D1", VA = "0x25876D0")]
		private void WriteTransforms()
		{
		}

		// Token: 0x060057F8 RID: 22520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004959")]
		[Address(RVA = "0x2584EE0", Offset = "0x2584FE1", VA = "0x2584EE0")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs)
		{
		}

		// Token: 0x060057F9 RID: 22521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600495A")]
		[Address(RVA = "0x2586390", Offset = "0x2586491", VA = "0x2586390")]
		private void Solve()
		{
		}

		// Token: 0x060057FA RID: 22522 RVA: 0x0001CEF0 File Offset: 0x0001B0F0
		[Token(Token = "0x600495B")]
		[Address(RVA = "0x2587AA0", Offset = "0x2587BA1", VA = "0x2587AA0")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		// Token: 0x060057FB RID: 22523 RVA: 0x0001CF08 File Offset: 0x0001B108
		[Token(Token = "0x600495C")]
		[Address(RVA = "0x2587AF0", Offset = "0x2587BF1", VA = "0x2587AF0")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		// Token: 0x17000B38 RID: 2872
		// (get) Token: 0x060057FC RID: 22524 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060057FD RID: 22525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008DF")]
		[Attribute(Name = "HideInInspector", RVA = "0x1B8840", Offset = "0x1B8941")]
		public IKSolverVR.VirtualBone rootBone
		{
			[Token(Token = "0x600495D")]
			[Address(RVA = "0x2588140", Offset = "0x2588241", VA = "0x2588140")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AAC00", Offset = "0x1AAD01")]
			get
			{
				return null;
			}
			[Token(Token = "0x600495E")]
			[Address(RVA = "0x2588150", Offset = "0x2588251", VA = "0x2588150")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AAC10", Offset = "0x1AAD11")]
			private set
			{
			}
		}

		// Token: 0x060057FE RID: 22526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600495F")]
		[Address(RVA = "0x2587570", Offset = "0x2587671", VA = "0x2587570")]
		private void Write()
		{
		}

		// Token: 0x060057FF RID: 22527 RVA: 0x0001CF20 File Offset: 0x0001B120
		[Token(Token = "0x6004960")]
		[Address(RVA = "0x2587B40", Offset = "0x2587C41", VA = "0x2587B40")]
		private Vector3 GetPelvisOffset()
		{
			return default(Vector3);
		}

		// Token: 0x06005800 RID: 22528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004961")]
		[Address(RVA = "0x2588160", Offset = "0x2588261", VA = "0x2588160")]
		public IKSolverVR()
		{
		}

		// Token: 0x0400B6F8 RID: 46840
		[Token(Token = "0x4008993")]
		[FieldOffset(Offset = "0x58")]
		private Transform[] solverTransforms;

		// Token: 0x0400B6F9 RID: 46841
		[Token(Token = "0x4008994")]
		[FieldOffset(Offset = "0x60")]
		private bool hasChest;

		// Token: 0x0400B6FA RID: 46842
		[Token(Token = "0x4008995")]
		[FieldOffset(Offset = "0x61")]
		private bool hasNeck;

		// Token: 0x0400B6FB RID: 46843
		[Token(Token = "0x4008996")]
		[FieldOffset(Offset = "0x62")]
		private bool hasShoulders;

		// Token: 0x0400B6FC RID: 46844
		[Token(Token = "0x4008997")]
		[FieldOffset(Offset = "0x63")]
		private bool hasToes;

		// Token: 0x0400B6FD RID: 46845
		[Token(Token = "0x4008998")]
		[FieldOffset(Offset = "0x64")]
		private bool hasLegs;

		// Token: 0x0400B6FE RID: 46846
		[Token(Token = "0x4008999")]
		[FieldOffset(Offset = "0x68")]
		private Vector3[] readPositions;

		// Token: 0x0400B6FF RID: 46847
		[Token(Token = "0x400899A")]
		[FieldOffset(Offset = "0x70")]
		private Quaternion[] readRotations;

		// Token: 0x0400B700 RID: 46848
		[Token(Token = "0x400899B")]
		[FieldOffset(Offset = "0x78")]
		private Vector3[] solvedPositions;

		// Token: 0x0400B701 RID: 46849
		[Token(Token = "0x400899C")]
		[FieldOffset(Offset = "0x80")]
		private Quaternion[] solvedRotations;

		// Token: 0x0400B702 RID: 46850
		[Token(Token = "0x400899D")]
		[FieldOffset(Offset = "0x88")]
		private Quaternion[] defaultLocalRotations;

		// Token: 0x0400B703 RID: 46851
		[Token(Token = "0x400899E")]
		[FieldOffset(Offset = "0x90")]
		private Vector3[] defaultLocalPositions;

		// Token: 0x0400B704 RID: 46852
		[Token(Token = "0x400899F")]
		[FieldOffset(Offset = "0x98")]
		private Vector3 rootV;

		// Token: 0x0400B705 RID: 46853
		[Token(Token = "0x40089A0")]
		[FieldOffset(Offset = "0xA4")]
		private Vector3 rootVelocity;

		// Token: 0x0400B706 RID: 46854
		[Token(Token = "0x40089A1")]
		[FieldOffset(Offset = "0xB0")]
		private Vector3 bodyOffset;

		// Token: 0x0400B707 RID: 46855
		[Token(Token = "0x40089A2")]
		[FieldOffset(Offset = "0xBC")]
		private int supportLegIndex;

		// Token: 0x0400B708 RID: 46856
		[Token(Token = "0x40089A3")]
		[FieldOffset(Offset = "0xC0")]
		private int lastLOD;

		// Token: 0x0400B709 RID: 46857
		[Token(Token = "0x40089A4")]
		[FieldOffset(Offset = "0xC4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17ACD0", Offset = "0x17ADD1")]
		[Attribute(Name = "RangeAttribute", RVA = "0x17ACD0", Offset = "0x17ADD1")]
		public int LOD;

		// Token: 0x0400B70A RID: 46858
		[Token(Token = "0x40089A5")]
		[FieldOffset(Offset = "0xC8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17AD30", Offset = "0x17AE31")]
		public bool plantFeet;

		// Token: 0x0400B70B RID: 46859
		[Token(Token = "0x40089A6")]
		[FieldOffset(Offset = "0xD0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17AD70", Offset = "0x17AE71")]
		private IKSolverVR.VirtualBone <rootBone>k__BackingField;

		// Token: 0x0400B70C RID: 46860
		[Token(Token = "0x40089A7")]
		[FieldOffset(Offset = "0xD8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17AD80", Offset = "0x17AE81")]
		public IKSolverVR.Spine spine;

		// Token: 0x0400B70D RID: 46861
		[Token(Token = "0x40089A8")]
		[FieldOffset(Offset = "0xE0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17ADC0", Offset = "0x17AEC1")]
		public IKSolverVR.Arm leftArm;

		// Token: 0x0400B70E RID: 46862
		[Token(Token = "0x40089A9")]
		[FieldOffset(Offset = "0xE8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17AE00", Offset = "0x17AF01")]
		public IKSolverVR.Arm rightArm;

		// Token: 0x0400B70F RID: 46863
		[Token(Token = "0x40089AA")]
		[FieldOffset(Offset = "0xF0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17AE40", Offset = "0x17AF41")]
		public IKSolverVR.Leg leftLeg;

		// Token: 0x0400B710 RID: 46864
		[Token(Token = "0x40089AB")]
		[FieldOffset(Offset = "0xF8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17AE80", Offset = "0x17AF81")]
		public IKSolverVR.Leg rightLeg;

		// Token: 0x0400B711 RID: 46865
		[Token(Token = "0x40089AC")]
		[FieldOffset(Offset = "0x100")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17AEC0", Offset = "0x17AFC1")]
		public IKSolverVR.Locomotion locomotion;

		// Token: 0x0400B712 RID: 46866
		[Token(Token = "0x40089AD")]
		[FieldOffset(Offset = "0x108")]
		private IKSolverVR.Leg[] legs;

		// Token: 0x0400B713 RID: 46867
		[Token(Token = "0x40089AE")]
		[FieldOffset(Offset = "0x110")]
		private IKSolverVR.Arm[] arms;

		// Token: 0x0400B714 RID: 46868
		[Token(Token = "0x40089AF")]
		[FieldOffset(Offset = "0x118")]
		private Vector3 headPosition;

		// Token: 0x0400B715 RID: 46869
		[Token(Token = "0x40089B0")]
		[FieldOffset(Offset = "0x124")]
		private Vector3 headDeltaPosition;

		// Token: 0x0400B716 RID: 46870
		[Token(Token = "0x40089B1")]
		[FieldOffset(Offset = "0x130")]
		private Vector3 raycastOriginPelvis;

		// Token: 0x0400B717 RID: 46871
		[Token(Token = "0x40089B2")]
		[FieldOffset(Offset = "0x13C")]
		private Vector3 lastOffset;

		// Token: 0x0400B718 RID: 46872
		[Token(Token = "0x40089B3")]
		[FieldOffset(Offset = "0x148")]
		private Vector3 debugPos1;

		// Token: 0x0400B719 RID: 46873
		[Token(Token = "0x40089B4")]
		[FieldOffset(Offset = "0x154")]
		private Vector3 debugPos2;

		// Token: 0x0400B71A RID: 46874
		[Token(Token = "0x40089B5")]
		[FieldOffset(Offset = "0x160")]
		private Vector3 debugPos3;

		// Token: 0x0400B71B RID: 46875
		[Token(Token = "0x40089B6")]
		[FieldOffset(Offset = "0x16C")]
		private Vector3 debugPos4;

		// Token: 0x02000D4D RID: 3405
		[Token(Token = "0x20013FD")]
		[Serializable]
		public class Arm : IKSolverVR.BodyPart
		{
			// Token: 0x17000B39 RID: 2873
			// (get) Token: 0x06005801 RID: 22529 RVA: 0x0001CF38 File Offset: 0x0001B138
			// (set) Token: 0x06005802 RID: 22530 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000E16")]
			public Vector3 position
			{
				[Token(Token = "0x6007969")]
				[Address(RVA = "0x2CC8FD0", Offset = "0x2CC90D1", VA = "0x2CC8FD0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4C90", Offset = "0x1B4D91")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600796A")]
				[Address(RVA = "0x2CC8FE0", Offset = "0x2CC90E1", VA = "0x2CC8FE0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4CA0", Offset = "0x1B4DA1")]
				private set
				{
				}
			}

			// Token: 0x17000B3A RID: 2874
			// (get) Token: 0x06005803 RID: 22531 RVA: 0x0001CF50 File Offset: 0x0001B150
			// (set) Token: 0x06005804 RID: 22532 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000E17")]
			public Quaternion rotation
			{
				[Token(Token = "0x600796B")]
				[Address(RVA = "0x2CC8FF0", Offset = "0x2CC90F1", VA = "0x2CC8FF0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4CB0", Offset = "0x1B4DB1")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x600796C")]
				[Address(RVA = "0x2CC9000", Offset = "0x2CC9101", VA = "0x2CC9000")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4CC0", Offset = "0x1B4DC1")]
				private set
				{
				}
			}

			// Token: 0x17000B3B RID: 2875
			// (get) Token: 0x06005805 RID: 22533 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E18")]
			private IKSolverVR.VirtualBone shoulder
			{
				[Token(Token = "0x600796D")]
				[Address(RVA = "0x2CC9020", Offset = "0x2CC9121", VA = "0x2CC9020")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000B3C RID: 2876
			// (get) Token: 0x06005806 RID: 22534 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E19")]
			private IKSolverVR.VirtualBone upperArm
			{
				[Token(Token = "0x600796E")]
				[Address(RVA = "0x2CC9060", Offset = "0x2CC9161", VA = "0x2CC9060")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000B3D RID: 2877
			// (get) Token: 0x06005807 RID: 22535 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E1A")]
			private IKSolverVR.VirtualBone forearm
			{
				[Token(Token = "0x600796F")]
				[Address(RVA = "0x2CC90A0", Offset = "0x2CC91A1", VA = "0x2CC90A0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000B3E RID: 2878
			// (get) Token: 0x06005808 RID: 22536 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E1B")]
			private IKSolverVR.VirtualBone hand
			{
				[Token(Token = "0x6007970")]
				[Address(RVA = "0x2CC90F0", Offset = "0x2CC91F1", VA = "0x2CC90F0")]
				get
				{
					return null;
				}
			}

			// Token: 0x06005809 RID: 22537 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007971")]
			[Address(RVA = "0x2CC9140", Offset = "0x2CC9241", VA = "0x2CC9140", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			// Token: 0x0600580A RID: 22538 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007972")]
			[Address(RVA = "0x2CC9C30", Offset = "0x2CC9D31", VA = "0x2CC9C30", Slot = "5")]
			public override void PreSolve()
			{
			}

			// Token: 0x0600580B RID: 22539 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007973")]
			[Address(RVA = "0x2CC9E90", Offset = "0x2CC9F91", VA = "0x2CC9E90", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			// Token: 0x0600580C RID: 22540 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007974")]
			[Address(RVA = "0x2CC9F40", Offset = "0x2CCA041", VA = "0x2CC9F40")]
			private void Stretching()
			{
			}

			// Token: 0x0600580D RID: 22541 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007975")]
			[Address(RVA = "0x2CCA4B0", Offset = "0x2CCA5B1", VA = "0x2CCA4B0")]
			public void Solve(bool isLeft)
			{
			}

			// Token: 0x0600580E RID: 22542 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007976")]
			[Address(RVA = "0x2CCCD80", Offset = "0x2CCCE81", VA = "0x2CCCD80", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			// Token: 0x0600580F RID: 22543 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007977")]
			[Address(RVA = "0x2CCCDF0", Offset = "0x2CCCEF1", VA = "0x2CCCDF0", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			// Token: 0x06005810 RID: 22544 RVA: 0x0001CF68 File Offset: 0x0001B168
			[Token(Token = "0x6007978")]
			[Address(RVA = "0x2CCBD90", Offset = "0x2CCBE91", VA = "0x2CCBD90")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return 0f;
			}

			// Token: 0x06005811 RID: 22545 RVA: 0x0001CF80 File Offset: 0x0001B180
			[Token(Token = "0x6007979")]
			[Address(RVA = "0x2CCC0A0", Offset = "0x2CCC1A1", VA = "0x2CCC0A0")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			// Token: 0x06005812 RID: 22546 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600797A")]
			[Address(RVA = "0x2CCD0F0", Offset = "0x2CCD1F1", VA = "0x2CCD0F0")]
			private void Visualize(IKSolverVR.VirtualBone bone1, IKSolverVR.VirtualBone bone2, IKSolverVR.VirtualBone bone3, Color color)
			{
			}

			// Token: 0x06005813 RID: 22547 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600797B")]
			[Address(RVA = "0x2CCD220", Offset = "0x2CCD321", VA = "0x2CCD220")]
			public Arm()
			{
			}

			// Token: 0x0400B71C RID: 46876
			[Token(Token = "0x401B9A9")]
			[FieldOffset(Offset = "0x48")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x196050", Offset = "0x196151")]
			public Transform target;

			// Token: 0x0400B71D RID: 46877
			[Token(Token = "0x401B9AA")]
			[FieldOffset(Offset = "0x50")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x196090", Offset = "0x196191")]
			public Transform bendGoal;

			// Token: 0x0400B71E RID: 46878
			[Token(Token = "0x401B9AB")]
			[FieldOffset(Offset = "0x58")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x1960D0", Offset = "0x1961D1")]
			[Attribute(Name = "RangeAttribute", RVA = "0x1960D0", Offset = "0x1961D1")]
			public float positionWeight;

			// Token: 0x0400B71F RID: 46879
			[Token(Token = "0x401B9AC")]
			[FieldOffset(Offset = "0x5C")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x196130", Offset = "0x196231")]
			[Attribute(Name = "RangeAttribute", RVA = "0x196130", Offset = "0x196231")]
			public float rotationWeight;

			// Token: 0x0400B720 RID: 46880
			[Token(Token = "0x401B9AD")]
			[FieldOffset(Offset = "0x60")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x196190", Offset = "0x196291")]
			public IKSolverVR.Arm.ShoulderRotationMode shoulderRotationMode;

			// Token: 0x0400B721 RID: 46881
			[Token(Token = "0x401B9AE")]
			[FieldOffset(Offset = "0x64")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x1961D0", Offset = "0x1962D1")]
			[Attribute(Name = "RangeAttribute", RVA = "0x1961D0", Offset = "0x1962D1")]
			public float shoulderRotationWeight;

			// Token: 0x0400B722 RID: 46882
			[Token(Token = "0x401B9AF")]
			[FieldOffset(Offset = "0x68")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x196230", Offset = "0x196331")]
			[Attribute(Name = "RangeAttribute", RVA = "0x196230", Offset = "0x196331")]
			public float shoulderTwistWeight;

			// Token: 0x0400B723 RID: 46883
			[Token(Token = "0x401B9B0")]
			[FieldOffset(Offset = "0x6C")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x196290", Offset = "0x196391")]
			[Attribute(Name = "RangeAttribute", RVA = "0x196290", Offset = "0x196391")]
			public float bendGoalWeight;

			// Token: 0x0400B724 RID: 46884
			[Token(Token = "0x401B9B1")]
			[FieldOffset(Offset = "0x70")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x1962F0", Offset = "0x1963F1")]
			[Attribute(Name = "RangeAttribute", RVA = "0x1962F0", Offset = "0x1963F1")]
			public float swivelOffset;

			// Token: 0x0400B725 RID: 46885
			[Token(Token = "0x401B9B2")]
			[FieldOffset(Offset = "0x74")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x196350", Offset = "0x196451")]
			public Vector3 wristToPalmAxis;

			// Token: 0x0400B726 RID: 46886
			[Token(Token = "0x401B9B3")]
			[FieldOffset(Offset = "0x80")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x196390", Offset = "0x196491")]
			public Vector3 palmToThumbAxis;

			// Token: 0x0400B727 RID: 46887
			[Token(Token = "0x401B9B4")]
			[FieldOffset(Offset = "0x8C")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x1963D0", Offset = "0x1964D1")]
			[Attribute(Name = "RangeAttribute", RVA = "0x1963D0", Offset = "0x1964D1")]
			public float armLengthMlp;

			// Token: 0x0400B728 RID: 46888
			[Token(Token = "0x401B9B5")]
			[FieldOffset(Offset = "0x90")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x196430", Offset = "0x196531")]
			public AnimationCurve stretchCurve;

			// Token: 0x0400B729 RID: 46889
			[Token(Token = "0x401B9B6")]
			[FieldOffset(Offset = "0x98")]
			[Attribute(Name = "HideInInspector", RVA = "0x196470", Offset = "0x196571")]
			[NonSerialized]
			public Vector3 IKPosition;

			// Token: 0x0400B72A RID: 46890
			[Token(Token = "0x401B9B7")]
			[FieldOffset(Offset = "0xA4")]
			[Attribute(Name = "HideInInspector", RVA = "0x196480", Offset = "0x196581")]
			[NonSerialized]
			public Quaternion IKRotation;

			// Token: 0x0400B72B RID: 46891
			[Token(Token = "0x401B9B8")]
			[FieldOffset(Offset = "0xB4")]
			[Attribute(Name = "HideInInspector", RVA = "0x196490", Offset = "0x196591")]
			[NonSerialized]
			public Vector3 bendDirection;

			// Token: 0x0400B72C RID: 46892
			[Token(Token = "0x401B9B9")]
			[FieldOffset(Offset = "0xC0")]
			[Attribute(Name = "HideInInspector", RVA = "0x1964A0", Offset = "0x1965A1")]
			[NonSerialized]
			public Vector3 handPositionOffset;

			// Token: 0x0400B72D RID: 46893
			[Token(Token = "0x401B9BA")]
			[FieldOffset(Offset = "0xCC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1964B0", Offset = "0x1965B1")]
			private Vector3 <position>k__BackingField;

			// Token: 0x0400B72E RID: 46894
			[Token(Token = "0x401B9BB")]
			[FieldOffset(Offset = "0xD8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1964C0", Offset = "0x1965C1")]
			private Quaternion <rotation>k__BackingField;

			// Token: 0x0400B72F RID: 46895
			[Token(Token = "0x401B9BC")]
			[FieldOffset(Offset = "0xE8")]
			private bool hasShoulder;

			// Token: 0x0400B730 RID: 46896
			[Token(Token = "0x401B9BD")]
			[FieldOffset(Offset = "0xEC")]
			private Vector3 chestForwardAxis;

			// Token: 0x0400B731 RID: 46897
			[Token(Token = "0x401B9BE")]
			[FieldOffset(Offset = "0xF8")]
			private Vector3 chestUpAxis;

			// Token: 0x0400B732 RID: 46898
			[Token(Token = "0x401B9BF")]
			[FieldOffset(Offset = "0x104")]
			private Quaternion chestRotation;

			// Token: 0x0400B733 RID: 46899
			[Token(Token = "0x401B9C0")]
			[FieldOffset(Offset = "0x114")]
			private Vector3 chestForward;

			// Token: 0x0400B734 RID: 46900
			[Token(Token = "0x401B9C1")]
			[FieldOffset(Offset = "0x120")]
			private Vector3 chestUp;

			// Token: 0x0400B735 RID: 46901
			[Token(Token = "0x401B9C2")]
			[FieldOffset(Offset = "0x12C")]
			private Quaternion forearmRelToUpperArm;

			// Token: 0x0400B736 RID: 46902
			[Token(Token = "0x401B9C3")]
			[FieldOffset(Offset = "0x13C")]
			private Vector3 upperArmBendAxis;

			// Token: 0x0400B737 RID: 46903
			[Token(Token = "0x401B9C4")]
			private const float yawOffsetAngle = 45f;

			// Token: 0x0400B738 RID: 46904
			[Token(Token = "0x401B9C5")]
			private const float pitchOffsetAngle = -30f;

			// Token: 0x02000D4E RID: 3406
			[Token(Token = "0x200165A")]
			[Serializable]
			public enum ShoulderRotationMode
			{
				// Token: 0x0400B73A RID: 46906
				[Token(Token = "0x401C420")]
				YawPitch,
				// Token: 0x0400B73B RID: 46907
				[Token(Token = "0x401C421")]
				FromTo
			}
		}

		// Token: 0x02000D4F RID: 3407
		[Token(Token = "0x20013FE")]
		[Serializable]
		public abstract class BodyPart
		{
			// Token: 0x06005814 RID: 22548
			[Token(Token = "0x600797C")]
			protected abstract void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index);

			// Token: 0x06005815 RID: 22549
			[Token(Token = "0x600797D")]
			public abstract void PreSolve();

			// Token: 0x06005816 RID: 22550
			[Token(Token = "0x600797E")]
			public abstract void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations);

			// Token: 0x06005817 RID: 22551
			[Token(Token = "0x600797F")]
			public abstract void ApplyOffsets();

			// Token: 0x06005818 RID: 22552
			[Token(Token = "0x6007980")]
			public abstract void ResetOffsets();

			// Token: 0x17000B3F RID: 2879
			// (get) Token: 0x06005819 RID: 22553 RVA: 0x0001CF98 File Offset: 0x0001B198
			// (set) Token: 0x0600581A RID: 22554 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000E1C")]
			public float sqrMag
			{
				[Token(Token = "0x6007981")]
				[Address(RVA = "0x2CCD420", Offset = "0x2CCD521", VA = "0x2CCD420")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4CD0", Offset = "0x1B4DD1")]
				get
				{
					return 0f;
				}
				[Token(Token = "0x6007982")]
				[Address(RVA = "0x2CCD430", Offset = "0x2CCD531", VA = "0x2CCD430")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4CE0", Offset = "0x1B4DE1")]
				private set
				{
				}
			}

			// Token: 0x17000B40 RID: 2880
			// (get) Token: 0x0600581B RID: 22555 RVA: 0x0001CFB0 File Offset: 0x0001B1B0
			// (set) Token: 0x0600581C RID: 22556 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000E1D")]
			public float mag
			{
				[Token(Token = "0x6007983")]
				[Address(RVA = "0x2CCD440", Offset = "0x2CCD541", VA = "0x2CCD440")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4CF0", Offset = "0x1B4DF1")]
				get
				{
					return 0f;
				}
				[Token(Token = "0x6007984")]
				[Address(RVA = "0x2CCD450", Offset = "0x2CCD551", VA = "0x2CCD450")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4D00", Offset = "0x1B4E01")]
				private set
				{
				}
			}

			// Token: 0x0600581D RID: 22557 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007985")]
			[Address(RVA = "0x2CCD460", Offset = "0x2CCD561", VA = "0x2CCD460")]
			public void SetLOD(int LOD)
			{
			}

			// Token: 0x0600581E RID: 22558 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007986")]
			[Address(RVA = "0x2CCD470", Offset = "0x2CCD571", VA = "0x2CCD470")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			// Token: 0x0600581F RID: 22559 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007987")]
			[Address(RVA = "0x2CCD860", Offset = "0x2CCD961", VA = "0x2CCD860")]
			public void MovePosition(Vector3 position)
			{
			}

			// Token: 0x06005820 RID: 22560 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007988")]
			[Address(RVA = "0x2CCD9D0", Offset = "0x2CCDAD1", VA = "0x2CCD9D0")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			// Token: 0x06005821 RID: 22561 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007989")]
			[Address(RVA = "0x2CCDC70", Offset = "0x2CCDD71", VA = "0x2CCDC70")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			// Token: 0x06005822 RID: 22562 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600798A")]
			[Address(RVA = "0x2CCDCD0", Offset = "0x2CCDDD1", VA = "0x2CCDCD0")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			// Token: 0x06005823 RID: 22563 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600798B")]
			[Address(RVA = "0x2CCCBE0", Offset = "0x2CCCCE1", VA = "0x2CCCBE0")]
			public void RotateTo(IKSolverVR.VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			// Token: 0x06005824 RID: 22564 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600798C")]
			[Address(RVA = "0x2CCDEC0", Offset = "0x2CCDFC1", VA = "0x2CCDEC0")]
			public void Visualize(Color color)
			{
			}

			// Token: 0x06005825 RID: 22565 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600798D")]
			[Address(RVA = "0x2CCE010", Offset = "0x2CCE111", VA = "0x2CCE010")]
			public void Visualize()
			{
			}

			// Token: 0x06005826 RID: 22566 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600798E")]
			[Address(RVA = "0x2CCD370", Offset = "0x2CCD471", VA = "0x2CCD370")]
			protected BodyPart()
			{
			}

			// Token: 0x0400B73C RID: 46908
			[Token(Token = "0x401B9C6")]
			[FieldOffset(Offset = "0x10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1964D0", Offset = "0x1965D1")]
			private float <sqrMag>k__BackingField;

			// Token: 0x0400B73D RID: 46909
			[Token(Token = "0x401B9C7")]
			[FieldOffset(Offset = "0x14")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1964E0", Offset = "0x1965E1")]
			private float <mag>k__BackingField;

			// Token: 0x0400B73E RID: 46910
			[Token(Token = "0x401B9C8")]
			[FieldOffset(Offset = "0x18")]
			[Attribute(Name = "HideInInspector", RVA = "0x1964F0", Offset = "0x1965F1")]
			public IKSolverVR.VirtualBone[] bones;

			// Token: 0x0400B73F RID: 46911
			[Token(Token = "0x401B9C9")]
			[FieldOffset(Offset = "0x20")]
			protected bool initiated;

			// Token: 0x0400B740 RID: 46912
			[Token(Token = "0x401B9CA")]
			[FieldOffset(Offset = "0x24")]
			protected Vector3 rootPosition;

			// Token: 0x0400B741 RID: 46913
			[Token(Token = "0x401B9CB")]
			[FieldOffset(Offset = "0x30")]
			protected Quaternion rootRotation;

			// Token: 0x0400B742 RID: 46914
			[Token(Token = "0x401B9CC")]
			[FieldOffset(Offset = "0x40")]
			protected int index;

			// Token: 0x0400B743 RID: 46915
			[Token(Token = "0x401B9CD")]
			[FieldOffset(Offset = "0x44")]
			protected int LOD;
		}

		// Token: 0x02000D50 RID: 3408
		[Token(Token = "0x20013FF")]
		[Serializable]
		public class Footstep
		{
			// Token: 0x17000B41 RID: 2881
			// (get) Token: 0x06005827 RID: 22567 RVA: 0x0001CFC8 File Offset: 0x0001B1C8
			[Token(Token = "0x17000E1E")]
			public bool isStepping
			{
				[Token(Token = "0x600798F")]
				[Address(RVA = "0x2CCE040", Offset = "0x2CCE141", VA = "0x2CCE040")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000B42 RID: 2882
			// (get) Token: 0x06005828 RID: 22568 RVA: 0x0001CFE0 File Offset: 0x0001B1E0
			// (set) Token: 0x06005829 RID: 22569 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000E1F")]
			public float stepProgress
			{
				[Token(Token = "0x6007990")]
				[Address(RVA = "0x2CCE060", Offset = "0x2CCE161", VA = "0x2CCE060")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4D10", Offset = "0x1B4E11")]
				get
				{
					return 0f;
				}
				[Token(Token = "0x6007991")]
				[Address(RVA = "0x2CCE070", Offset = "0x2CCE171", VA = "0x2CCE070")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4D20", Offset = "0x1B4E21")]
				private set
				{
				}
			}

			// Token: 0x0600582A RID: 22570 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007992")]
			[Address(RVA = "0x2CCE080", Offset = "0x2CCE181", VA = "0x2CCE080")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			// Token: 0x0600582B RID: 22571 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007993")]
			[Address(RVA = "0x2CCE290", Offset = "0x2CCE391", VA = "0x2CCE290")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			// Token: 0x0600582C RID: 22572 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007994")]
			[Address(RVA = "0x2CCE310", Offset = "0x2CCE411", VA = "0x2CCE310")]
			public void StepTo(Vector3 p, Quaternion rootRotation, float stepThreshold)
			{
			}

			// Token: 0x0600582D RID: 22573 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007995")]
			[Address(RVA = "0x2CCE4E0", Offset = "0x2CCE5E1", VA = "0x2CCE4E0")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed)
			{
			}

			// Token: 0x0600582E RID: 22574 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007996")]
			[Address(RVA = "0x2CCE6C0", Offset = "0x2CCE7C1", VA = "0x2CCE6C0")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed)
			{
			}

			// Token: 0x0600582F RID: 22575 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007997")]
			[Address(RVA = "0x2CCE8B0", Offset = "0x2CCE9B1", VA = "0x2CCE8B0")]
			public void Update(InterpolationMode interpolation, UnityEvent onStep)
			{
			}

			// Token: 0x0400B744 RID: 46916
			[Token(Token = "0x401B9CE")]
			[FieldOffset(Offset = "0x10")]
			public float stepSpeed;

			// Token: 0x0400B745 RID: 46917
			[Token(Token = "0x401B9CF")]
			[FieldOffset(Offset = "0x14")]
			public Vector3 characterSpaceOffset;

			// Token: 0x0400B746 RID: 46918
			[Token(Token = "0x401B9D0")]
			[FieldOffset(Offset = "0x20")]
			public Vector3 position;

			// Token: 0x0400B747 RID: 46919
			[Token(Token = "0x401B9D1")]
			[FieldOffset(Offset = "0x2C")]
			public Quaternion rotation;

			// Token: 0x0400B748 RID: 46920
			[Token(Token = "0x401B9D2")]
			[FieldOffset(Offset = "0x3C")]
			public Quaternion stepToRootRot;

			// Token: 0x0400B749 RID: 46921
			[Token(Token = "0x401B9D3")]
			[FieldOffset(Offset = "0x4C")]
			public bool isSupportLeg;

			// Token: 0x0400B74A RID: 46922
			[Token(Token = "0x401B9D4")]
			[FieldOffset(Offset = "0x50")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x196500", Offset = "0x196601")]
			private float <stepProgress>k__BackingField;

			// Token: 0x0400B74B RID: 46923
			[Token(Token = "0x401B9D5")]
			[FieldOffset(Offset = "0x54")]
			public Vector3 stepFrom;

			// Token: 0x0400B74C RID: 46924
			[Token(Token = "0x401B9D6")]
			[FieldOffset(Offset = "0x60")]
			public Vector3 stepTo;

			// Token: 0x0400B74D RID: 46925
			[Token(Token = "0x401B9D7")]
			[FieldOffset(Offset = "0x6C")]
			public Quaternion stepFromRot;

			// Token: 0x0400B74E RID: 46926
			[Token(Token = "0x401B9D8")]
			[FieldOffset(Offset = "0x7C")]
			public Quaternion stepToRot;

			// Token: 0x0400B74F RID: 46927
			[Token(Token = "0x401B9D9")]
			[FieldOffset(Offset = "0x8C")]
			private Quaternion footRelativeToRoot;

			// Token: 0x0400B750 RID: 46928
			[Token(Token = "0x401B9DA")]
			[FieldOffset(Offset = "0x9C")]
			private float supportLegW;

			// Token: 0x0400B751 RID: 46929
			[Token(Token = "0x401B9DB")]
			[FieldOffset(Offset = "0xA0")]
			private float supportLegWV;
		}

		// Token: 0x02000D51 RID: 3409
		[Token(Token = "0x2001400")]
		[Serializable]
		public class Leg : IKSolverVR.BodyPart
		{
			// Token: 0x17000B43 RID: 2883
			// (get) Token: 0x06005830 RID: 22576 RVA: 0x0001CFF8 File Offset: 0x0001B1F8
			// (set) Token: 0x06005831 RID: 22577 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000E20")]
			public Vector3 position
			{
				[Token(Token = "0x6007998")]
				[Address(RVA = "0x2CCEAD0", Offset = "0x2CCEBD1", VA = "0x2CCEAD0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4D30", Offset = "0x1B4E31")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6007999")]
				[Address(RVA = "0x2CCEAE0", Offset = "0x2CCEBE1", VA = "0x2CCEAE0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4D40", Offset = "0x1B4E41")]
				private set
				{
				}
			}

			// Token: 0x17000B44 RID: 2884
			// (get) Token: 0x06005832 RID: 22578 RVA: 0x0001D010 File Offset: 0x0001B210
			// (set) Token: 0x06005833 RID: 22579 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000E21")]
			public Quaternion rotation
			{
				[Token(Token = "0x600799A")]
				[Address(RVA = "0x2CCEAF0", Offset = "0x2CCEBF1", VA = "0x2CCEAF0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4D50", Offset = "0x1B4E51")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x600799B")]
				[Address(RVA = "0x2CCEB00", Offset = "0x2CCEC01", VA = "0x2CCEB00")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4D60", Offset = "0x1B4E61")]
				private set
				{
				}
			}

			// Token: 0x17000B45 RID: 2885
			// (get) Token: 0x06005834 RID: 22580 RVA: 0x0001D028 File Offset: 0x0001B228
			// (set) Token: 0x06005835 RID: 22581 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000E22")]
			public bool hasToes
			{
				[Token(Token = "0x600799C")]
				[Address(RVA = "0x2CCEB20", Offset = "0x2CCEC21", VA = "0x2CCEB20")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4D70", Offset = "0x1B4E71")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600799D")]
				[Address(RVA = "0x2CCEB30", Offset = "0x2CCEC31", VA = "0x2CCEB30")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4D80", Offset = "0x1B4E81")]
				private set
				{
				}
			}

			// Token: 0x17000B46 RID: 2886
			// (get) Token: 0x06005836 RID: 22582 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E23")]
			public IKSolverVR.VirtualBone thigh
			{
				[Token(Token = "0x600799E")]
				[Address(RVA = "0x2CCEB40", Offset = "0x2CCEC41", VA = "0x2CCEB40")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000B47 RID: 2887
			// (get) Token: 0x06005837 RID: 22583 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E24")]
			private IKSolverVR.VirtualBone calf
			{
				[Token(Token = "0x600799F")]
				[Address(RVA = "0x2CCEB80", Offset = "0x2CCEC81", VA = "0x2CCEB80")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000B48 RID: 2888
			// (get) Token: 0x06005838 RID: 22584 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E25")]
			private IKSolverVR.VirtualBone foot
			{
				[Token(Token = "0x60079A0")]
				[Address(RVA = "0x2CCEBC0", Offset = "0x2CCECC1", VA = "0x2CCEBC0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000B49 RID: 2889
			// (get) Token: 0x06005839 RID: 22585 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E26")]
			private IKSolverVR.VirtualBone toes
			{
				[Token(Token = "0x60079A1")]
				[Address(RVA = "0x2CCEC00", Offset = "0x2CCED01", VA = "0x2CCEC00")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000B4A RID: 2890
			// (get) Token: 0x0600583A RID: 22586 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E27")]
			public IKSolverVR.VirtualBone lastBone
			{
				[Token(Token = "0x60079A2")]
				[Address(RVA = "0x2CCEC40", Offset = "0x2CCED41", VA = "0x2CCEC40")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000B4B RID: 2891
			// (get) Token: 0x0600583B RID: 22587 RVA: 0x0001D040 File Offset: 0x0001B240
			// (set) Token: 0x0600583C RID: 22588 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000E28")]
			public Vector3 thighRelativeToPelvis
			{
				[Token(Token = "0x60079A3")]
				[Address(RVA = "0x2CCEC80", Offset = "0x2CCED81", VA = "0x2CCEC80")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4D90", Offset = "0x1B4E91")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60079A4")]
				[Address(RVA = "0x2CCEC90", Offset = "0x2CCED91", VA = "0x2CCEC90")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4DA0", Offset = "0x1B4EA1")]
				private set
				{
				}
			}

			// Token: 0x0600583D RID: 22589 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60079A5")]
			[Address(RVA = "0x2CCECA0", Offset = "0x2CCEDA1", VA = "0x2CCECA0", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			// Token: 0x0600583E RID: 22590 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60079A6")]
			[Address(RVA = "0x2CCF360", Offset = "0x2CCF461", VA = "0x2CCF360", Slot = "5")]
			public override void PreSolve()
			{
			}

			// Token: 0x0600583F RID: 22591 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60079A7")]
			[Address(RVA = "0x2CCFCB0", Offset = "0x2CCFDB1", VA = "0x2CCFCB0", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			// Token: 0x06005840 RID: 22592 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60079A8")]
			[Address(RVA = "0x2CCFBB0", Offset = "0x2CCFCB1", VA = "0x2CCFBB0")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			// Token: 0x06005841 RID: 22593 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60079A9")]
			[Address(RVA = "0x2CCF970", Offset = "0x2CCFA71", VA = "0x2CCF970")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			// Token: 0x06005842 RID: 22594 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60079AA")]
			[Address(RVA = "0x2CD0260", Offset = "0x2CD0361", VA = "0x2CD0260")]
			public void Solve(bool stretch)
			{
			}

			// Token: 0x06005843 RID: 22595 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60079AB")]
			[Address(RVA = "0x2CD0A40", Offset = "0x2CD0B41", VA = "0x2CD0A40")]
			private void FixTwistRotations()
			{
			}

			// Token: 0x06005844 RID: 22596 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60079AC")]
			[Address(RVA = "0x2CD04B0", Offset = "0x2CD05B1", VA = "0x2CD04B0")]
			private void Stretching()
			{
			}

			// Token: 0x06005845 RID: 22597 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60079AD")]
			[Address(RVA = "0x2CD0EA0", Offset = "0x2CD0FA1", VA = "0x2CD0EA0", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			// Token: 0x06005846 RID: 22598 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60079AE")]
			[Address(RVA = "0x2CD1140", Offset = "0x2CD1241", VA = "0x2CD1140", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			// Token: 0x06005847 RID: 22599 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60079AF")]
			[Address(RVA = "0x2CD1200", Offset = "0x2CD1301", VA = "0x2CD1200")]
			public Leg()
			{
			}

			// Token: 0x0400B752 RID: 46930
			[Token(Token = "0x401B9DC")]
			[FieldOffset(Offset = "0x48")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x196510", Offset = "0x196611")]
			public Transform target;

			// Token: 0x0400B753 RID: 46931
			[Token(Token = "0x401B9DD")]
			[FieldOffset(Offset = "0x50")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x196550", Offset = "0x196651")]
			public Transform bendGoal;

			// Token: 0x0400B754 RID: 46932
			[Token(Token = "0x401B9DE")]
			[FieldOffset(Offset = "0x58")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x196590", Offset = "0x196691")]
			[Attribute(Name = "RangeAttribute", RVA = "0x196590", Offset = "0x196691")]
			public float positionWeight;

			// Token: 0x0400B755 RID: 46933
			[Token(Token = "0x401B9DF")]
			[FieldOffset(Offset = "0x5C")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x1965F0", Offset = "0x1966F1")]
			[Attribute(Name = "RangeAttribute", RVA = "0x1965F0", Offset = "0x1966F1")]
			public float rotationWeight;

			// Token: 0x0400B756 RID: 46934
			[Token(Token = "0x401B9E0")]
			[FieldOffset(Offset = "0x60")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x196650", Offset = "0x196751")]
			[Attribute(Name = "RangeAttribute", RVA = "0x196650", Offset = "0x196751")]
			public float bendGoalWeight;

			// Token: 0x0400B757 RID: 46935
			[Token(Token = "0x401B9E1")]
			[FieldOffset(Offset = "0x64")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x1966B0", Offset = "0x1967B1")]
			[Attribute(Name = "RangeAttribute", RVA = "0x1966B0", Offset = "0x1967B1")]
			public float swivelOffset;

			// Token: 0x0400B758 RID: 46936
			[Token(Token = "0x401B9E2")]
			[FieldOffset(Offset = "0x68")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x196710", Offset = "0x196811")]
			[Attribute(Name = "RangeAttribute", RVA = "0x196710", Offset = "0x196811")]
			public float bendToTargetWeight;

			// Token: 0x0400B759 RID: 46937
			[Token(Token = "0x401B9E3")]
			[FieldOffset(Offset = "0x6C")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x196770", Offset = "0x196871")]
			[Attribute(Name = "RangeAttribute", RVA = "0x196770", Offset = "0x196871")]
			public float legLengthMlp;

			// Token: 0x0400B75A RID: 46938
			[Token(Token = "0x401B9E4")]
			[FieldOffset(Offset = "0x70")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x1967D0", Offset = "0x1968D1")]
			public AnimationCurve stretchCurve;

			// Token: 0x0400B75B RID: 46939
			[Token(Token = "0x401B9E5")]
			[FieldOffset(Offset = "0x78")]
			[Attribute(Name = "HideInInspector", RVA = "0x196810", Offset = "0x196911")]
			[NonSerialized]
			public Vector3 IKPosition;

			// Token: 0x0400B75C RID: 46940
			[Token(Token = "0x401B9E6")]
			[FieldOffset(Offset = "0x84")]
			[Attribute(Name = "HideInInspector", RVA = "0x196820", Offset = "0x196921")]
			[NonSerialized]
			public Quaternion IKRotation;

			// Token: 0x0400B75D RID: 46941
			[Token(Token = "0x401B9E7")]
			[FieldOffset(Offset = "0x94")]
			[Attribute(Name = "HideInInspector", RVA = "0x196830", Offset = "0x196931")]
			[NonSerialized]
			public Vector3 footPositionOffset;

			// Token: 0x0400B75E RID: 46942
			[Token(Token = "0x401B9E8")]
			[FieldOffset(Offset = "0xA0")]
			[Attribute(Name = "HideInInspector", RVA = "0x196840", Offset = "0x196941")]
			[NonSerialized]
			public Vector3 heelPositionOffset;

			// Token: 0x0400B75F RID: 46943
			[Token(Token = "0x401B9E9")]
			[FieldOffset(Offset = "0xAC")]
			[Attribute(Name = "HideInInspector", RVA = "0x196850", Offset = "0x196951")]
			[NonSerialized]
			public Quaternion footRotationOffset;

			// Token: 0x0400B760 RID: 46944
			[Token(Token = "0x401B9EA")]
			[FieldOffset(Offset = "0xBC")]
			[Attribute(Name = "HideInInspector", RVA = "0x196860", Offset = "0x196961")]
			[NonSerialized]
			public float currentMag;

			// Token: 0x0400B761 RID: 46945
			[Token(Token = "0x401B9EB")]
			[FieldOffset(Offset = "0xC0")]
			[Attribute(Name = "HideInInspector", RVA = "0x196870", Offset = "0x196971")]
			public bool useAnimatedBendNormal;

			// Token: 0x0400B762 RID: 46946
			[Token(Token = "0x401B9EC")]
			[FieldOffset(Offset = "0xC4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x196880", Offset = "0x196981")]
			private Vector3 <position>k__BackingField;

			// Token: 0x0400B763 RID: 46947
			[Token(Token = "0x401B9ED")]
			[FieldOffset(Offset = "0xD0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x196890", Offset = "0x196991")]
			private Quaternion <rotation>k__BackingField;

			// Token: 0x0400B764 RID: 46948
			[Token(Token = "0x401B9EE")]
			[FieldOffset(Offset = "0xE0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1968A0", Offset = "0x1969A1")]
			private bool <hasToes>k__BackingField;

			// Token: 0x0400B765 RID: 46949
			[Token(Token = "0x401B9EF")]
			[FieldOffset(Offset = "0xE4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1968B0", Offset = "0x1969B1")]
			private Vector3 <thighRelativeToPelvis>k__BackingField;

			// Token: 0x0400B766 RID: 46950
			[Token(Token = "0x401B9F0")]
			[FieldOffset(Offset = "0xF0")]
			private Vector3 footPosition;

			// Token: 0x0400B767 RID: 46951
			[Token(Token = "0x401B9F1")]
			[FieldOffset(Offset = "0xFC")]
			private Quaternion footRotation;

			// Token: 0x0400B768 RID: 46952
			[Token(Token = "0x401B9F2")]
			[FieldOffset(Offset = "0x10C")]
			private Vector3 bendNormal;

			// Token: 0x0400B769 RID: 46953
			[Token(Token = "0x401B9F3")]
			[FieldOffset(Offset = "0x118")]
			private Quaternion calfRelToThigh;

			// Token: 0x0400B76A RID: 46954
			[Token(Token = "0x401B9F4")]
			[FieldOffset(Offset = "0x128")]
			private Quaternion thighRelToFoot;

			// Token: 0x0400B76B RID: 46955
			[Token(Token = "0x401B9F5")]
			[FieldOffset(Offset = "0x138")]
			private Vector3 bendNormalRelToPelvis;

			// Token: 0x0400B76C RID: 46956
			[Token(Token = "0x401B9F6")]
			[FieldOffset(Offset = "0x144")]
			private Vector3 bendNormalRelToTarget;
		}

		// Token: 0x02000D52 RID: 3410
		[Token(Token = "0x2001401")]
		[Serializable]
		public class Locomotion
		{
			// Token: 0x17000B4C RID: 2892
			// (get) Token: 0x06005848 RID: 22600 RVA: 0x0001D058 File Offset: 0x0001B258
			// (set) Token: 0x06005849 RID: 22601 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000E29")]
			public Vector3 centerOfMass
			{
				[Token(Token = "0x60079B0")]
				[Address(RVA = "0x2CD1320", Offset = "0x2CD1421", VA = "0x2CD1320")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4DB0", Offset = "0x1B4EB1")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60079B1")]
				[Address(RVA = "0x2CD1330", Offset = "0x2CD1431", VA = "0x2CD1330")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4DC0", Offset = "0x1B4EC1")]
				private set
				{
				}
			}

			// Token: 0x0600584A RID: 22602 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60079B2")]
			[Address(RVA = "0x2CD1340", Offset = "0x2CD1441", VA = "0x2CD1340")]
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes)
			{
			}

			// Token: 0x0600584B RID: 22603 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60079B3")]
			[Address(RVA = "0x2CD1670", Offset = "0x2CD1771", VA = "0x2CD1670")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			// Token: 0x0600584C RID: 22604 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60079B4")]
			[Address(RVA = "0x2CD1940", Offset = "0x2CD1A41", VA = "0x2CD1940")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			// Token: 0x0600584D RID: 22605 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60079B5")]
			[Address(RVA = "0x2CD1D00", Offset = "0x2CD1E01", VA = "0x2CD1D00")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			// Token: 0x0600584E RID: 22606 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60079B6")]
			[Address(RVA = "0x2CD1EA0", Offset = "0x2CD1FA1", VA = "0x2CD1EA0")]
			public void Solve(IKSolverVR.VirtualBone rootBone, IKSolverVR.Spine spine, IKSolverVR.Leg leftLeg, IKSolverVR.Leg rightLeg, IKSolverVR.Arm leftArm, IKSolverVR.Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset)
			{
			}

			// Token: 0x17000B4D RID: 2893
			// (get) Token: 0x0600584F RID: 22607 RVA: 0x0001D070 File Offset: 0x0001B270
			[Token(Token = "0x17000E2A")]
			public Vector3 leftFootstepPosition
			{
				[Token(Token = "0x60079B7")]
				[Address(RVA = "0x2CD3A00", Offset = "0x2CD3B01", VA = "0x2CD3A00")]
				get
				{
					return default(Vector3);
				}
			}

			// Token: 0x17000B4E RID: 2894
			// (get) Token: 0x06005850 RID: 22608 RVA: 0x0001D088 File Offset: 0x0001B288
			[Token(Token = "0x17000E2B")]
			public Vector3 rightFootstepPosition
			{
				[Token(Token = "0x60079B8")]
				[Address(RVA = "0x2CD3A40", Offset = "0x2CD3B41", VA = "0x2CD3A40")]
				get
				{
					return default(Vector3);
				}
			}

			// Token: 0x17000B4F RID: 2895
			// (get) Token: 0x06005851 RID: 22609 RVA: 0x0001D0A0 File Offset: 0x0001B2A0
			[Token(Token = "0x17000E2C")]
			public Quaternion leftFootstepRotation
			{
				[Token(Token = "0x60079B9")]
				[Address(RVA = "0x2CD3A90", Offset = "0x2CD3B91", VA = "0x2CD3A90")]
				get
				{
					return default(Quaternion);
				}
			}

			// Token: 0x17000B50 RID: 2896
			// (get) Token: 0x06005852 RID: 22610 RVA: 0x0001D0B8 File Offset: 0x0001B2B8
			[Token(Token = "0x17000E2D")]
			public Quaternion rightFootstepRotation
			{
				[Token(Token = "0x60079BA")]
				[Address(RVA = "0x2CD3AD0", Offset = "0x2CD3BD1", VA = "0x2CD3AD0")]
				get
				{
					return default(Quaternion);
				}
			}

			// Token: 0x06005853 RID: 22611 RVA: 0x0001D0D0 File Offset: 0x0001B2D0
			[Token(Token = "0x60079BB")]
			[Address(RVA = "0x2CD3610", Offset = "0x2CD3711", VA = "0x2CD3610")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			// Token: 0x06005854 RID: 22612 RVA: 0x0001D0E8 File Offset: 0x0001B2E8
			[Token(Token = "0x60079BC")]
			[Address(RVA = "0x2CD37B0", Offset = "0x2CD38B1", VA = "0x2CD37B0")]
			private bool CanStep()
			{
				return default(bool);
			}

			// Token: 0x06005855 RID: 22613 RVA: 0x0001D100 File Offset: 0x0001B300
			[Token(Token = "0x60079BD")]
			[Address(RVA = "0x2CD3830", Offset = "0x2CD3931", VA = "0x2CD3830")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			// Token: 0x06005856 RID: 22614 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60079BE")]
			[Address(RVA = "0x2CD3B20", Offset = "0x2CD3C21", VA = "0x2CD3B20")]
			public Locomotion()
			{
			}

			// Token: 0x0400B76D RID: 46957
			[Token(Token = "0x401B9F7")]
			[FieldOffset(Offset = "0x10")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x1968C0", Offset = "0x1969C1")]
			[Attribute(Name = "RangeAttribute", RVA = "0x1968C0", Offset = "0x1969C1")]
			public float weight;

			// Token: 0x0400B76E RID: 46958
			[Token(Token = "0x401B9F8")]
			[FieldOffset(Offset = "0x14")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x196920", Offset = "0x196A21")]
			public float footDistance;

			// Token: 0x0400B76F RID: 46959
			[Token(Token = "0x401B9F9")]
			[FieldOffset(Offset = "0x18")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x196960", Offset = "0x196A61")]
			public float stepThreshold;

			// Token: 0x0400B770 RID: 46960
			[Token(Token = "0x401B9FA")]
			[FieldOffset(Offset = "0x1C")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x1969A0", Offset = "0x196AA1")]
			public float angleThreshold;

			// Token: 0x0400B771 RID: 46961
			[Token(Token = "0x401B9FB")]
			[FieldOffset(Offset = "0x20")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x1969E0", Offset = "0x196AE1")]
			public float comAngleMlp;

			// Token: 0x0400B772 RID: 46962
			[Token(Token = "0x401B9FC")]
			[FieldOffset(Offset = "0x24")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x196A20", Offset = "0x196B21")]
			public float maxVelocity;

			// Token: 0x0400B773 RID: 46963
			[Token(Token = "0x401B9FD")]
			[FieldOffset(Offset = "0x28")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x196A60", Offset = "0x196B61")]
			public float velocityFactor;

			// Token: 0x0400B774 RID: 46964
			[Token(Token = "0x401B9FE")]
			[FieldOffset(Offset = "0x2C")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x196AA0", Offset = "0x196BA1")]
			[Attribute(Name = "RangeAttribute", RVA = "0x196AA0", Offset = "0x196BA1")]
			public float maxLegStretch;

			// Token: 0x0400B775 RID: 46965
			[Token(Token = "0x401B9FF")]
			[FieldOffset(Offset = "0x30")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x196B00", Offset = "0x196C01")]
			public float rootSpeed;

			// Token: 0x0400B776 RID: 46966
			[Token(Token = "0x401BA00")]
			[FieldOffset(Offset = "0x34")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x196B40", Offset = "0x196C41")]
			public float stepSpeed;

			// Token: 0x0400B777 RID: 46967
			[Token(Token = "0x401BA01")]
			[FieldOffset(Offset = "0x38")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x196B80", Offset = "0x196C81")]
			public AnimationCurve stepHeight;

			// Token: 0x0400B778 RID: 46968
			[Token(Token = "0x401BA02")]
			[FieldOffset(Offset = "0x40")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x196BC0", Offset = "0x196CC1")]
			public AnimationCurve heelHeight;

			// Token: 0x0400B779 RID: 46969
			[Token(Token = "0x401BA03")]
			[FieldOffset(Offset = "0x48")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x196C00", Offset = "0x196D01")]
			[Attribute(Name = "RangeAttribute", RVA = "0x196C00", Offset = "0x196D01")]
			public float relaxLegTwistMinAngle;

			// Token: 0x0400B77A RID: 46970
			[Token(Token = "0x401BA04")]
			[FieldOffset(Offset = "0x4C")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x196C60", Offset = "0x196D61")]
			public float relaxLegTwistSpeed;

			// Token: 0x0400B77B RID: 46971
			[Token(Token = "0x401BA05")]
			[FieldOffset(Offset = "0x50")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x196CA0", Offset = "0x196DA1")]
			public InterpolationMode stepInterpolation;

			// Token: 0x0400B77C RID: 46972
			[Token(Token = "0x401BA06")]
			[FieldOffset(Offset = "0x54")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x196CE0", Offset = "0x196DE1")]
			public Vector3 offset;

			// Token: 0x0400B77D RID: 46973
			[Token(Token = "0x401BA07")]
			[FieldOffset(Offset = "0x60")]
			[Attribute(Name = "HideInInspector", RVA = "0x196D20", Offset = "0x196E21")]
			public bool blockingEnabled;

			// Token: 0x0400B77E RID: 46974
			[Token(Token = "0x401BA08")]
			[FieldOffset(Offset = "0x64")]
			[Attribute(Name = "HideInInspector", RVA = "0x196D30", Offset = "0x196E31")]
			public LayerMask blockingLayers;

			// Token: 0x0400B77F RID: 46975
			[Token(Token = "0x401BA09")]
			[FieldOffset(Offset = "0x68")]
			[Attribute(Name = "HideInInspector", RVA = "0x196D40", Offset = "0x196E41")]
			public float raycastRadius;

			// Token: 0x0400B780 RID: 46976
			[Token(Token = "0x401BA0A")]
			[FieldOffset(Offset = "0x6C")]
			[Attribute(Name = "HideInInspector", RVA = "0x196D50", Offset = "0x196E51")]
			public float raycastHeight;

			// Token: 0x0400B781 RID: 46977
			[Token(Token = "0x401BA0B")]
			[FieldOffset(Offset = "0x70")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x196D60", Offset = "0x196E61")]
			public UnityEvent onLeftFootstep;

			// Token: 0x0400B782 RID: 46978
			[Token(Token = "0x401BA0C")]
			[FieldOffset(Offset = "0x78")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x196DA0", Offset = "0x196EA1")]
			public UnityEvent onRightFootstep;

			// Token: 0x0400B783 RID: 46979
			[Token(Token = "0x401BA0D")]
			[FieldOffset(Offset = "0x80")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x196DE0", Offset = "0x196EE1")]
			private Vector3 <centerOfMass>k__BackingField;

			// Token: 0x0400B784 RID: 46980
			[Token(Token = "0x401BA0E")]
			[FieldOffset(Offset = "0x90")]
			private IKSolverVR.Footstep[] footsteps;

			// Token: 0x0400B785 RID: 46981
			[Token(Token = "0x401BA0F")]
			[FieldOffset(Offset = "0x98")]
			private Vector3 lastComPosition;

			// Token: 0x0400B786 RID: 46982
			[Token(Token = "0x401BA10")]
			[FieldOffset(Offset = "0xA4")]
			private Vector3 comVelocity;

			// Token: 0x0400B787 RID: 46983
			[Token(Token = "0x401BA11")]
			[FieldOffset(Offset = "0xB0")]
			private int leftFootIndex;

			// Token: 0x0400B788 RID: 46984
			[Token(Token = "0x401BA12")]
			[FieldOffset(Offset = "0xB4")]
			private int rightFootIndex;
		}

		// Token: 0x02000D53 RID: 3411
		[Token(Token = "0x2001402")]
		[Serializable]
		public class Spine : IKSolverVR.BodyPart
		{
			// Token: 0x17000B51 RID: 2897
			// (get) Token: 0x06005857 RID: 22615 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E2E")]
			public IKSolverVR.VirtualBone pelvis
			{
				[Token(Token = "0x60079BF")]
				[Address(RVA = "0x2CD3590", Offset = "0x2CD3691", VA = "0x2CD3590")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000B52 RID: 2898
			// (get) Token: 0x06005858 RID: 22616 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E2F")]
			public IKSolverVR.VirtualBone firstSpineBone
			{
				[Token(Token = "0x60079C0")]
				[Address(RVA = "0x2CD3C50", Offset = "0x2CD3D51", VA = "0x2CD3C50")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000B53 RID: 2899
			// (get) Token: 0x06005859 RID: 22617 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E30")]
			public IKSolverVR.VirtualBone chest
			{
				[Token(Token = "0x60079C1")]
				[Address(RVA = "0x2CD3C90", Offset = "0x2CD3D91", VA = "0x2CD3C90")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000B54 RID: 2900
			// (get) Token: 0x0600585A RID: 22618 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E31")]
			private IKSolverVR.VirtualBone neck
			{
				[Token(Token = "0x60079C2")]
				[Address(RVA = "0x2CD3CF0", Offset = "0x2CD3DF1", VA = "0x2CD3CF0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000B55 RID: 2901
			// (get) Token: 0x0600585B RID: 22619 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E32")]
			public IKSolverVR.VirtualBone head
			{
				[Token(Token = "0x60079C3")]
				[Address(RVA = "0x2CD35D0", Offset = "0x2CD36D1", VA = "0x2CD35D0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000B56 RID: 2902
			// (get) Token: 0x0600585C RID: 22620 RVA: 0x0001D118 File Offset: 0x0001B318
			// (set) Token: 0x0600585D RID: 22621 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000E33")]
			public Quaternion anchorRotation
			{
				[Token(Token = "0x60079C4")]
				[Address(RVA = "0x2CD3D30", Offset = "0x2CD3E31", VA = "0x2CD3D30")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4DD0", Offset = "0x1B4ED1")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x60079C5")]
				[Address(RVA = "0x2CD3D50", Offset = "0x2CD3E51", VA = "0x2CD3D50")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4DE0", Offset = "0x1B4EE1")]
				private set
				{
				}
			}

			// Token: 0x17000B57 RID: 2903
			// (get) Token: 0x0600585E RID: 22622 RVA: 0x0001D130 File Offset: 0x0001B330
			// (set) Token: 0x0600585F RID: 22623 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000E34")]
			public Quaternion anchorRelativeToHead
			{
				[Token(Token = "0x60079C6")]
				[Address(RVA = "0x2CD3D70", Offset = "0x2CD3E71", VA = "0x2CD3D70")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4DF0", Offset = "0x1B4EF1")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x60079C7")]
				[Address(RVA = "0x2CD3D90", Offset = "0x2CD3E91", VA = "0x2CD3D90")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4E00", Offset = "0x1B4F01")]
				private set
				{
				}
			}

			// Token: 0x06005860 RID: 22624 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60079C8")]
			[Address(RVA = "0x2CD3DB0", Offset = "0x2CD3EB1", VA = "0x2CD3DB0", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			// Token: 0x06005861 RID: 22625 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60079C9")]
			[Address(RVA = "0x2CD49A0", Offset = "0x2CD4AA1", VA = "0x2CD49A0", Slot = "5")]
			public override void PreSolve()
			{
			}

			// Token: 0x06005862 RID: 22626 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60079CA")]
			[Address(RVA = "0x2CD4C10", Offset = "0x2CD4D11", VA = "0x2CD4C10", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			// Token: 0x06005863 RID: 22627 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60079CB")]
			[Address(RVA = "0x2CD52C0", Offset = "0x2CD53C1", VA = "0x2CD52C0")]
			private void CalculateChestTargetRotation(IKSolverVR.VirtualBone rootBone, IKSolverVR.Arm[] arms)
			{
			}

			// Token: 0x06005864 RID: 22628 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60079CC")]
			[Address(RVA = "0x2CD5890", Offset = "0x2CD5991", VA = "0x2CD5890")]
			public void Solve(IKSolverVR.VirtualBone rootBone, IKSolverVR.Leg[] legs, IKSolverVR.Arm[] arms)
			{
			}

			// Token: 0x06005865 RID: 22629 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60079CD")]
			[Address(RVA = "0x2CD6330", Offset = "0x2CD6431", VA = "0x2CD6330")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp, float weight)
			{
			}

			// Token: 0x06005866 RID: 22630 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60079CE")]
			[Address(RVA = "0x2CD6D30", Offset = "0x2CD6E31", VA = "0x2CD6D30")]
			private void SolvePelvis()
			{
			}

			// Token: 0x06005867 RID: 22631 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60079CF")]
			[Address(RVA = "0x2CD7550", Offset = "0x2CD7651", VA = "0x2CD7550", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			// Token: 0x06005868 RID: 22632 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60079D0")]
			[Address(RVA = "0x2CD7770", Offset = "0x2CD7871", VA = "0x2CD7770", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			// Token: 0x06005869 RID: 22633 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60079D1")]
			[Address(RVA = "0x2CD54F0", Offset = "0x2CD55F1", VA = "0x2CD54F0")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, IKSolverVR.Arm[] arms)
			{
			}

			// Token: 0x0600586A RID: 22634 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60079D2")]
			[Address(RVA = "0x2CD6890", Offset = "0x2CD6991", VA = "0x2CD6890")]
			public void InverseTranslateToHead(IKSolverVR.Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			// Token: 0x0600586B RID: 22635 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60079D3")]
			[Address(RVA = "0x2CD5ED0", Offset = "0x2CD5FD1", VA = "0x2CD5ED0")]
			private void TranslatePelvis(IKSolverVR.Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation)
			{
			}

			// Token: 0x0600586C RID: 22636 RVA: 0x0001D148 File Offset: 0x0001B348
			[Token(Token = "0x60079D4")]
			[Address(RVA = "0x2CD7880", Offset = "0x2CD7981", VA = "0x2CD7880")]
			private Vector3 LimitPelvisPosition(IKSolverVR.Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			// Token: 0x0600586D RID: 22637 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60079D5")]
			[Address(RVA = "0x2CD6A20", Offset = "0x2CD6B21", VA = "0x2CD6A20")]
			private void Bend(IKSolverVR.VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			// Token: 0x0600586E RID: 22638 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60079D6")]
			[Address(RVA = "0x2CD6500", Offset = "0x2CD6601", VA = "0x2CD6500")]
			private void Bend(IKSolverVR.VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			// Token: 0x0600586F RID: 22639 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60079D7")]
			[Address(RVA = "0x2CD7BD0", Offset = "0x2CD7CD1", VA = "0x2CD7BD0")]
			public Spine()
			{
			}

			// Token: 0x0400B789 RID: 46985
			[Token(Token = "0x401BA13")]
			[FieldOffset(Offset = "0x48")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x196DF0", Offset = "0x196EF1")]
			public Transform headTarget;

			// Token: 0x0400B78A RID: 46986
			[Token(Token = "0x401BA14")]
			[FieldOffset(Offset = "0x50")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x196E30", Offset = "0x196F31")]
			public Transform pelvisTarget;

			// Token: 0x0400B78B RID: 46987
			[Token(Token = "0x401BA15")]
			[FieldOffset(Offset = "0x58")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x196E70", Offset = "0x196F71")]
			[Attribute(Name = "RangeAttribute", RVA = "0x196E70", Offset = "0x196F71")]
			public float positionWeight;

			// Token: 0x0400B78C RID: 46988
			[Token(Token = "0x401BA16")]
			[FieldOffset(Offset = "0x5C")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x196ED0", Offset = "0x196FD1")]
			[Attribute(Name = "RangeAttribute", RVA = "0x196ED0", Offset = "0x196FD1")]
			public float rotationWeight;

			// Token: 0x0400B78D RID: 46989
			[Token(Token = "0x401BA17")]
			[FieldOffset(Offset = "0x60")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x196F30", Offset = "0x197031")]
			[Attribute(Name = "RangeAttribute", RVA = "0x196F30", Offset = "0x197031")]
			public float pelvisPositionWeight;

			// Token: 0x0400B78E RID: 46990
			[Token(Token = "0x401BA18")]
			[FieldOffset(Offset = "0x64")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x196F90", Offset = "0x197091")]
			[Attribute(Name = "RangeAttribute", RVA = "0x196F90", Offset = "0x197091")]
			public float pelvisRotationWeight;

			// Token: 0x0400B78F RID: 46991
			[Token(Token = "0x401BA19")]
			[FieldOffset(Offset = "0x68")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x196FF0", Offset = "0x1970F1")]
			public Transform chestGoal;

			// Token: 0x0400B790 RID: 46992
			[Token(Token = "0x401BA1A")]
			[FieldOffset(Offset = "0x70")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x197030", Offset = "0x197131")]
			[Attribute(Name = "RangeAttribute", RVA = "0x197030", Offset = "0x197131")]
			public float chestGoalWeight;

			// Token: 0x0400B791 RID: 46993
			[Token(Token = "0x401BA1B")]
			[FieldOffset(Offset = "0x74")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x197090", Offset = "0x197191")]
			public float minHeadHeight;

			// Token: 0x0400B792 RID: 46994
			[Token(Token = "0x401BA1C")]
			[FieldOffset(Offset = "0x78")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x1970D0", Offset = "0x1971D1")]
			[Attribute(Name = "RangeAttribute", RVA = "0x1970D0", Offset = "0x1971D1")]
			public float bodyPosStiffness;

			// Token: 0x0400B793 RID: 46995
			[Token(Token = "0x401BA1D")]
			[FieldOffset(Offset = "0x7C")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x197130", Offset = "0x197231")]
			[Attribute(Name = "RangeAttribute", RVA = "0x197130", Offset = "0x197231")]
			public float bodyRotStiffness;

			// Token: 0x0400B794 RID: 46996
			[Token(Token = "0x401BA1E")]
			[FieldOffset(Offset = "0x80")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x197190", Offset = "0x197291")]
			[Attribute(Name = "FormerlySerializedAsAttribute", RVA = "0x197190", Offset = "0x197291")]
			[Attribute(Name = "RangeAttribute", RVA = "0x197190", Offset = "0x197291")]
			public float neckStiffness;

			// Token: 0x0400B795 RID: 46997
			[Token(Token = "0x401BA1F")]
			[FieldOffset(Offset = "0x84")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x197210", Offset = "0x197311")]
			[Attribute(Name = "RangeAttribute", RVA = "0x197210", Offset = "0x197311")]
			public float rotateChestByHands;

			// Token: 0x0400B796 RID: 46998
			[Token(Token = "0x401BA20")]
			[FieldOffset(Offset = "0x88")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x197270", Offset = "0x197371")]
			[Attribute(Name = "RangeAttribute", RVA = "0x197270", Offset = "0x197371")]
			public float chestClampWeight;

			// Token: 0x0400B797 RID: 46999
			[Token(Token = "0x401BA21")]
			[FieldOffset(Offset = "0x8C")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x1972D0", Offset = "0x1973D1")]
			[Attribute(Name = "RangeAttribute", RVA = "0x1972D0", Offset = "0x1973D1")]
			public float headClampWeight;

			// Token: 0x0400B798 RID: 47000
			[Token(Token = "0x401BA22")]
			[FieldOffset(Offset = "0x90")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x197330", Offset = "0x197431")]
			public float moveBodyBackWhenCrouching;

			// Token: 0x0400B799 RID: 47001
			[Token(Token = "0x401BA23")]
			[FieldOffset(Offset = "0x94")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x197370", Offset = "0x197471")]
			[Attribute(Name = "RangeAttribute", RVA = "0x197370", Offset = "0x197471")]
			public float maintainPelvisPosition;

			// Token: 0x0400B79A RID: 47002
			[Token(Token = "0x401BA24")]
			[FieldOffset(Offset = "0x98")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x1973D0", Offset = "0x1974D1")]
			[Attribute(Name = "RangeAttribute", RVA = "0x1973D0", Offset = "0x1974D1")]
			public float maxRootAngle;

			// Token: 0x0400B79B RID: 47003
			[Token(Token = "0x401BA25")]
			[FieldOffset(Offset = "0x9C")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x197430", Offset = "0x197531")]
			[Attribute(Name = "RangeAttribute", RVA = "0x197430", Offset = "0x197531")]
			public float rootHeadingOffset;

			// Token: 0x0400B79C RID: 47004
			[Token(Token = "0x401BA26")]
			[FieldOffset(Offset = "0xA0")]
			[Attribute(Name = "HideInInspector", RVA = "0x197490", Offset = "0x197591")]
			[NonSerialized]
			public Vector3 IKPositionHead;

			// Token: 0x0400B79D RID: 47005
			[Token(Token = "0x401BA27")]
			[FieldOffset(Offset = "0xAC")]
			[Attribute(Name = "HideInInspector", RVA = "0x1974A0", Offset = "0x1975A1")]
			[NonSerialized]
			public Quaternion IKRotationHead;

			// Token: 0x0400B79E RID: 47006
			[Token(Token = "0x401BA28")]
			[FieldOffset(Offset = "0xBC")]
			[Attribute(Name = "HideInInspector", RVA = "0x1974B0", Offset = "0x1975B1")]
			[NonSerialized]
			public Vector3 IKPositionPelvis;

			// Token: 0x0400B79F RID: 47007
			[Token(Token = "0x401BA29")]
			[FieldOffset(Offset = "0xC8")]
			[Attribute(Name = "HideInInspector", RVA = "0x1974C0", Offset = "0x1975C1")]
			[NonSerialized]
			public Quaternion IKRotationPelvis;

			// Token: 0x0400B7A0 RID: 47008
			[Token(Token = "0x401BA2A")]
			[FieldOffset(Offset = "0xD8")]
			[Attribute(Name = "HideInInspector", RVA = "0x1974D0", Offset = "0x1975D1")]
			[NonSerialized]
			public Vector3 goalPositionChest;

			// Token: 0x0400B7A1 RID: 47009
			[Token(Token = "0x401BA2B")]
			[FieldOffset(Offset = "0xE4")]
			[Attribute(Name = "HideInInspector", RVA = "0x1974E0", Offset = "0x1975E1")]
			[NonSerialized]
			public Vector3 pelvisPositionOffset;

			// Token: 0x0400B7A2 RID: 47010
			[Token(Token = "0x401BA2C")]
			[FieldOffset(Offset = "0xF0")]
			[Attribute(Name = "HideInInspector", RVA = "0x1974F0", Offset = "0x1975F1")]
			[NonSerialized]
			public Vector3 chestPositionOffset;

			// Token: 0x0400B7A3 RID: 47011
			[Token(Token = "0x401BA2D")]
			[FieldOffset(Offset = "0xFC")]
			[Attribute(Name = "HideInInspector", RVA = "0x197500", Offset = "0x197601")]
			[NonSerialized]
			public Vector3 headPositionOffset;

			// Token: 0x0400B7A4 RID: 47012
			[Token(Token = "0x401BA2E")]
			[FieldOffset(Offset = "0x108")]
			[Attribute(Name = "HideInInspector", RVA = "0x197510", Offset = "0x197611")]
			[NonSerialized]
			public Quaternion pelvisRotationOffset;

			// Token: 0x0400B7A5 RID: 47013
			[Token(Token = "0x401BA2F")]
			[FieldOffset(Offset = "0x118")]
			[Attribute(Name = "HideInInspector", RVA = "0x197520", Offset = "0x197621")]
			[NonSerialized]
			public Quaternion chestRotationOffset;

			// Token: 0x0400B7A6 RID: 47014
			[Token(Token = "0x401BA30")]
			[FieldOffset(Offset = "0x128")]
			[Attribute(Name = "HideInInspector", RVA = "0x197530", Offset = "0x197631")]
			[NonSerialized]
			public Quaternion headRotationOffset;

			// Token: 0x0400B7A7 RID: 47015
			[Token(Token = "0x401BA31")]
			[FieldOffset(Offset = "0x138")]
			[Attribute(Name = "HideInInspector", RVA = "0x197540", Offset = "0x197641")]
			[NonSerialized]
			public Vector3 faceDirection;

			// Token: 0x0400B7A8 RID: 47016
			[Token(Token = "0x401BA32")]
			[FieldOffset(Offset = "0x144")]
			[Attribute(Name = "HideInInspector", RVA = "0x197550", Offset = "0x197651")]
			[NonSerialized]
			public Vector3 locomotionHeadPositionOffset;

			// Token: 0x0400B7A9 RID: 47017
			[Token(Token = "0x401BA33")]
			[FieldOffset(Offset = "0x150")]
			[Attribute(Name = "HideInInspector", RVA = "0x197560", Offset = "0x197661")]
			[NonSerialized]
			public Vector3 headPosition;

			// Token: 0x0400B7AA RID: 47018
			[Token(Token = "0x401BA34")]
			[FieldOffset(Offset = "0x15C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x197570", Offset = "0x197671")]
			private Quaternion <anchorRotation>k__BackingField;

			// Token: 0x0400B7AB RID: 47019
			[Token(Token = "0x401BA35")]
			[FieldOffset(Offset = "0x16C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x197580", Offset = "0x197681")]
			private Quaternion <anchorRelativeToHead>k__BackingField;

			// Token: 0x0400B7AC RID: 47020
			[Token(Token = "0x401BA36")]
			[FieldOffset(Offset = "0x17C")]
			private Quaternion headRotation;

			// Token: 0x0400B7AD RID: 47021
			[Token(Token = "0x401BA37")]
			[FieldOffset(Offset = "0x18C")]
			private Quaternion pelvisRotation;

			// Token: 0x0400B7AE RID: 47022
			[Token(Token = "0x401BA38")]
			[FieldOffset(Offset = "0x19C")]
			private Quaternion anchorRelativeToPelvis;

			// Token: 0x0400B7AF RID: 47023
			[Token(Token = "0x401BA39")]
			[FieldOffset(Offset = "0x1AC")]
			private Quaternion pelvisRelativeRotation;

			// Token: 0x0400B7B0 RID: 47024
			[Token(Token = "0x401BA3A")]
			[FieldOffset(Offset = "0x1BC")]
			private Quaternion chestRelativeRotation;

			// Token: 0x0400B7B1 RID: 47025
			[Token(Token = "0x401BA3B")]
			[FieldOffset(Offset = "0x1CC")]
			private Vector3 headDeltaPosition;

			// Token: 0x0400B7B2 RID: 47026
			[Token(Token = "0x401BA3C")]
			[FieldOffset(Offset = "0x1D8")]
			private Quaternion pelvisDeltaRotation;

			// Token: 0x0400B7B3 RID: 47027
			[Token(Token = "0x401BA3D")]
			[FieldOffset(Offset = "0x1E8")]
			private Quaternion chestTargetRotation;

			// Token: 0x0400B7B4 RID: 47028
			[Token(Token = "0x401BA3E")]
			[FieldOffset(Offset = "0x1F8")]
			private int pelvisIndex;

			// Token: 0x0400B7B5 RID: 47029
			[Token(Token = "0x401BA3F")]
			[FieldOffset(Offset = "0x1FC")]
			private int spineIndex;

			// Token: 0x0400B7B6 RID: 47030
			[Token(Token = "0x401BA40")]
			[FieldOffset(Offset = "0x200")]
			private int chestIndex;

			// Token: 0x0400B7B7 RID: 47031
			[Token(Token = "0x401BA41")]
			[FieldOffset(Offset = "0x204")]
			private int neckIndex;

			// Token: 0x0400B7B8 RID: 47032
			[Token(Token = "0x401BA42")]
			[FieldOffset(Offset = "0x208")]
			private int headIndex;

			// Token: 0x0400B7B9 RID: 47033
			[Token(Token = "0x401BA43")]
			[FieldOffset(Offset = "0x20C")]
			private float length;

			// Token: 0x0400B7BA RID: 47034
			[Token(Token = "0x401BA44")]
			[FieldOffset(Offset = "0x210")]
			private bool hasChest;

			// Token: 0x0400B7BB RID: 47035
			[Token(Token = "0x401BA45")]
			[FieldOffset(Offset = "0x211")]
			private bool hasNeck;

			// Token: 0x0400B7BC RID: 47036
			[Token(Token = "0x401BA46")]
			[FieldOffset(Offset = "0x212")]
			private bool hasLegs;

			// Token: 0x0400B7BD RID: 47037
			[Token(Token = "0x401BA47")]
			[FieldOffset(Offset = "0x214")]
			private float headHeight;

			// Token: 0x0400B7BE RID: 47038
			[Token(Token = "0x401BA48")]
			[FieldOffset(Offset = "0x218")]
			private float sizeMlp;

			// Token: 0x0400B7BF RID: 47039
			[Token(Token = "0x401BA49")]
			[FieldOffset(Offset = "0x21C")]
			private Vector3 chestForward;
		}

		// Token: 0x02000D54 RID: 3412
		[Token(Token = "0x2001403")]
		[Serializable]
		public enum PositionOffset
		{
			// Token: 0x0400B7C1 RID: 47041
			[Token(Token = "0x401BA4B")]
			Pelvis,
			// Token: 0x0400B7C2 RID: 47042
			[Token(Token = "0x401BA4C")]
			Chest,
			// Token: 0x0400B7C3 RID: 47043
			[Token(Token = "0x401BA4D")]
			Head,
			// Token: 0x0400B7C4 RID: 47044
			[Token(Token = "0x401BA4E")]
			LeftHand,
			// Token: 0x0400B7C5 RID: 47045
			[Token(Token = "0x401BA4F")]
			RightHand,
			// Token: 0x0400B7C6 RID: 47046
			[Token(Token = "0x401BA50")]
			LeftFoot,
			// Token: 0x0400B7C7 RID: 47047
			[Token(Token = "0x401BA51")]
			RightFoot,
			// Token: 0x0400B7C8 RID: 47048
			[Token(Token = "0x401BA52")]
			LeftHeel,
			// Token: 0x0400B7C9 RID: 47049
			[Token(Token = "0x401BA53")]
			RightHeel
		}

		// Token: 0x02000D55 RID: 3413
		[Token(Token = "0x2001404")]
		[Serializable]
		public enum RotationOffset
		{
			// Token: 0x0400B7CB RID: 47051
			[Token(Token = "0x401BA55")]
			Pelvis,
			// Token: 0x0400B7CC RID: 47052
			[Token(Token = "0x401BA56")]
			Chest,
			// Token: 0x0400B7CD RID: 47053
			[Token(Token = "0x401BA57")]
			Head
		}

		// Token: 0x02000D56 RID: 3414
		[Token(Token = "0x2001405")]
		[Serializable]
		public class VirtualBone
		{
			// Token: 0x06005870 RID: 22640 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60079D8")]
			[Address(RVA = "0x2CC9B50", Offset = "0x2CC9C51", VA = "0x2CC9B50")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			// Token: 0x06005871 RID: 22641 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60079D9")]
			[Address(RVA = "0x2CC9BF0", Offset = "0x2CC9CF1", VA = "0x2CC9BF0")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			// Token: 0x06005872 RID: 22642 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60079DA")]
			[Address(RVA = "0x2CD7DD0", Offset = "0x2CD7ED1", VA = "0x2CD7DD0")]
			public static void SwingRotation(IKSolverVR.VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			// Token: 0x06005873 RID: 22643 RVA: 0x0001D160 File Offset: 0x0001B360
			[Token(Token = "0x60079DB")]
			[Address(RVA = "0x2CCD550", Offset = "0x2CCD651", VA = "0x2CCD550")]
			public static float PreSolve(ref IKSolverVR.VirtualBone[] bones)
			{
				return 0f;
			}

			// Token: 0x06005874 RID: 22644 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60079DC")]
			[Address(RVA = "0x2CCDA80", Offset = "0x2CCDB81", VA = "0x2CCDA80")]
			public static void RotateAroundPoint(IKSolverVR.VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			// Token: 0x06005875 RID: 22645 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60079DD")]
			[Address(RVA = "0x2CD8060", Offset = "0x2CD8161", VA = "0x2CD8060")]
			public static void RotateBy(IKSolverVR.VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			// Token: 0x06005876 RID: 22646 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60079DE")]
			[Address(RVA = "0x2CCBE70", Offset = "0x2CCBF71", VA = "0x2CCBE70")]
			public static void RotateBy(IKSolverVR.VirtualBone[] bones, Quaternion rotation)
			{
			}

			// Token: 0x06005877 RID: 22647 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60079DF")]
			[Address(RVA = "0x2CD82A0", Offset = "0x2CD83A1", VA = "0x2CD82A0")]
			public static void RotateTo(IKSolverVR.VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			// Token: 0x06005878 RID: 22648 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60079E0")]
			[Address(RVA = "0x2CCC630", Offset = "0x2CCC731", VA = "0x2CCC630")]
			public static void SolveTrigonometric(IKSolverVR.VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			// Token: 0x06005879 RID: 22649 RVA: 0x0001D178 File Offset: 0x0001B378
			[Token(Token = "0x60079E1")]
			[Address(RVA = "0x2CD8360", Offset = "0x2CD8461", VA = "0x2CD8360")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			// Token: 0x0600587A RID: 22650 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60079E2")]
			[Address(RVA = "0x2CD70F0", Offset = "0x2CD71F1", VA = "0x2CD70F0")]
			public static void SolveFABRIK(IKSolverVR.VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			// Token: 0x0600587B RID: 22651 RVA: 0x0001D190 File Offset: 0x0001B390
			[Token(Token = "0x60079E3")]
			[Address(RVA = "0x2CD8590", Offset = "0x2CD8691", VA = "0x2CD8590")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			// Token: 0x0600587C RID: 22652 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60079E4")]
			[Address(RVA = "0x2CD86A0", Offset = "0x2CD87A1", VA = "0x2CD86A0")]
			public static void SolveCCD(IKSolverVR.VirtualBone[] bones, Vector3 targetPosition, float weight, int iterations)
			{
			}

			// Token: 0x0400B7CE RID: 47054
			[Token(Token = "0x401BA58")]
			[FieldOffset(Offset = "0x10")]
			public Vector3 readPosition;

			// Token: 0x0400B7CF RID: 47055
			[Token(Token = "0x401BA59")]
			[FieldOffset(Offset = "0x1C")]
			public Quaternion readRotation;

			// Token: 0x0400B7D0 RID: 47056
			[Token(Token = "0x401BA5A")]
			[FieldOffset(Offset = "0x2C")]
			public Vector3 solverPosition;

			// Token: 0x0400B7D1 RID: 47057
			[Token(Token = "0x401BA5B")]
			[FieldOffset(Offset = "0x38")]
			public Quaternion solverRotation;

			// Token: 0x0400B7D2 RID: 47058
			[Token(Token = "0x401BA5C")]
			[FieldOffset(Offset = "0x48")]
			public float length;

			// Token: 0x0400B7D3 RID: 47059
			[Token(Token = "0x401BA5D")]
			[FieldOffset(Offset = "0x4C")]
			public float sqrMag;

			// Token: 0x0400B7D4 RID: 47060
			[Token(Token = "0x401BA5E")]
			[FieldOffset(Offset = "0x50")]
			public Vector3 axis;
		}
	}
}
