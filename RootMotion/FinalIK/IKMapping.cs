using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000D2E RID: 3374
	[Token(Token = "0x20008B5")]
	[Serializable]
	public class IKMapping
	{
		// Token: 0x06005691 RID: 22161 RVA: 0x0001C7D0 File Offset: 0x0001A9D0
		[Token(Token = "0x6004831")]
		[Address(RVA = "0x2C15380", Offset = "0x2C15481", VA = "0x2C15380", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		// Token: 0x06005692 RID: 22162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004832")]
		[Address(RVA = "0x2C15390", Offset = "0x2C15491", VA = "0x2C15390", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		// Token: 0x06005693 RID: 22163 RVA: 0x0001C7E8 File Offset: 0x0001A9E8
		[Token(Token = "0x6004833")]
		[Address(RVA = "0x2C153A0", Offset = "0x2C154A1", VA = "0x2C153A0")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		// Token: 0x06005694 RID: 22164 RVA: 0x0001C800 File Offset: 0x0001AA00
		[Token(Token = "0x6004834")]
		[Address(RVA = "0x2C154E0", Offset = "0x2C155E1", VA = "0x2C154E0")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		// Token: 0x06005695 RID: 22165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004835")]
		[Address(RVA = "0x2C155F0", Offset = "0x2C156F1", VA = "0x2C155F0")]
		public IKMapping()
		{
		}

		// Token: 0x02000D2F RID: 3375
		[Token(Token = "0x20013F2")]
		[Serializable]
		public class BoneMap
		{
			// Token: 0x06005696 RID: 22166 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600792A")]
			[Address(RVA = "0x2C15600", Offset = "0x2C15701", VA = "0x2C15600")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			// Token: 0x17000B0E RID: 2830
			// (get) Token: 0x06005697 RID: 22167 RVA: 0x0001C818 File Offset: 0x0001AA18
			[Token(Token = "0x17000E11")]
			public Vector3 swingDirection
			{
				[Token(Token = "0x600792B")]
				[Address(RVA = "0x2C15650", Offset = "0x2C15751", VA = "0x2C15650")]
				get
				{
					return default(Vector3);
				}
			}

			// Token: 0x06005698 RID: 22168 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600792C")]
			[Address(RVA = "0x2C15720", Offset = "0x2C15821", VA = "0x2C15720")]
			public void StoreDefaultLocalState()
			{
			}

			// Token: 0x06005699 RID: 22169 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600792D")]
			[Address(RVA = "0x2C15780", Offset = "0x2C15881", VA = "0x2C15780")]
			public void FixTransform(bool position)
			{
			}

			// Token: 0x17000B0F RID: 2831
			// (get) Token: 0x0600569A RID: 22170 RVA: 0x0001C830 File Offset: 0x0001AA30
			[Token(Token = "0x17000E12")]
			public bool isNodeBone
			{
				[Token(Token = "0x600792E")]
				[Address(RVA = "0x2C157D0", Offset = "0x2C158D1", VA = "0x2C157D0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0600569B RID: 22171 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600792F")]
			[Address(RVA = "0x2C157E0", Offset = "0x2C158E1", VA = "0x2C157E0")]
			public void SetLength(IKMapping.BoneMap nextBone)
			{
			}

			// Token: 0x0600569C RID: 22172 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007930")]
			[Address(RVA = "0x2C158D0", Offset = "0x2C159D1", VA = "0x2C158D0")]
			public void SetLocalSwingAxis(IKMapping.BoneMap swingTarget)
			{
			}

			// Token: 0x0600569D RID: 22173 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007931")]
			[Address(RVA = "0x2C158E0", Offset = "0x2C159E1", VA = "0x2C158E0")]
			public void SetLocalSwingAxis(IKMapping.BoneMap bone1, IKMapping.BoneMap bone2)
			{
			}

			// Token: 0x0600569E RID: 22174 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007932")]
			[Address(RVA = "0x2C15A70", Offset = "0x2C15B71", VA = "0x2C15A70")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			// Token: 0x0600569F RID: 22175 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007933")]
			[Address(RVA = "0x2C15B80", Offset = "0x2C15C81", VA = "0x2C15B80")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			// Token: 0x060056A0 RID: 22176 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007934")]
			[Address(RVA = "0x2C15C50", Offset = "0x2C15D51", VA = "0x2C15C50")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			// Token: 0x060056A1 RID: 22177 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007935")]
			[Address(RVA = "0x2C16030", Offset = "0x2C16131", VA = "0x2C16030")]
			public void SetIKPosition()
			{
			}

			// Token: 0x060056A2 RID: 22178 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007936")]
			[Address(RVA = "0x2C16070", Offset = "0x2C16171", VA = "0x2C16070")]
			public void MaintainRotation()
			{
			}

			// Token: 0x060056A3 RID: 22179 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007937")]
			[Address(RVA = "0x2C160B0", Offset = "0x2C161B1", VA = "0x2C160B0")]
			public void SetToIKPosition()
			{
			}

			// Token: 0x060056A4 RID: 22180 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007938")]
			[Address(RVA = "0x2C160E0", Offset = "0x2C161E1", VA = "0x2C160E0")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			// Token: 0x060056A5 RID: 22181 RVA: 0x0001C848 File Offset: 0x0001AA48
			[Token(Token = "0x6007939")]
			[Address(RVA = "0x2C16220", Offset = "0x2C16321", VA = "0x2C16220")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			// Token: 0x060056A6 RID: 22182 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600793A")]
			[Address(RVA = "0x2C16570", Offset = "0x2C16671", VA = "0x2C16570")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			// Token: 0x060056A7 RID: 22183 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600793B")]
			[Address(RVA = "0x2C165A0", Offset = "0x2C166A1", VA = "0x2C165A0")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			// Token: 0x060056A8 RID: 22184 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600793C")]
			[Address(RVA = "0x2C16740", Offset = "0x2C16841", VA = "0x2C16740")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			// Token: 0x060056A9 RID: 22185 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600793D")]
			[Address(RVA = "0x2C167B0", Offset = "0x2C168B1", VA = "0x2C167B0")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			// Token: 0x060056AA RID: 22186 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600793E")]
			[Address(RVA = "0x2C169F0", Offset = "0x2C16AF1", VA = "0x2C169F0")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			// Token: 0x060056AB RID: 22187 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600793F")]
			[Address(RVA = "0x2C16C20", Offset = "0x2C16D21", VA = "0x2C16C20")]
			public void RotateToMaintain(float weight)
			{
			}

			// Token: 0x060056AC RID: 22188 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007940")]
			[Address(RVA = "0x2C16D40", Offset = "0x2C16E41", VA = "0x2C16D40")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			// Token: 0x060056AD RID: 22189 RVA: 0x0001C860 File Offset: 0x0001AA60
			[Token(Token = "0x6007941")]
			[Address(RVA = "0x2C16370", Offset = "0x2C16471", VA = "0x2C16370")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			// Token: 0x17000B10 RID: 2832
			// (get) Token: 0x060056AE RID: 22190 RVA: 0x0001C878 File Offset: 0x0001AA78
			[Token(Token = "0x17000E13")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x6007942")]
				[Address(RVA = "0x2C15E00", Offset = "0x2C15F01", VA = "0x2C15E00")]
				get
				{
					return default(Quaternion);
				}
			}

			// Token: 0x060056AF RID: 22191 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007943")]
			[Address(RVA = "0x2C16EE0", Offset = "0x2C16FE1", VA = "0x2C16EE0")]
			public BoneMap()
			{
			}

			// Token: 0x0400B61B RID: 46619
			[Token(Token = "0x401B973")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			// Token: 0x0400B61C RID: 46620
			[Token(Token = "0x401B974")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int chainIndex;

			// Token: 0x0400B61D RID: 46621
			[Token(Token = "0x401B975")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int nodeIndex;

			// Token: 0x0400B61E RID: 46622
			[Token(Token = "0x401B976")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 defaultLocalPosition;

			// Token: 0x0400B61F RID: 46623
			[Token(Token = "0x401B977")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion defaultLocalRotation;

			// Token: 0x0400B620 RID: 46624
			[Token(Token = "0x401B978")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 localSwingAxis;

			// Token: 0x0400B621 RID: 46625
			[Token(Token = "0x401B979")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 localTwistAxis;

			// Token: 0x0400B622 RID: 46626
			[Token(Token = "0x401B97A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 planePosition;

			// Token: 0x0400B623 RID: 46627
			[Token(Token = "0x401B97B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 ikPosition;

			// Token: 0x0400B624 RID: 46628
			[Token(Token = "0x401B97C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion defaultLocalTargetRotation;

			// Token: 0x0400B625 RID: 46629
			[Token(Token = "0x401B97D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			private Quaternion maintainRotation;

			// Token: 0x0400B626 RID: 46630
			[Token(Token = "0x401B97E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			public float length;

			// Token: 0x0400B627 RID: 46631
			[Token(Token = "0x401B97F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public Quaternion animatedRotation;

			// Token: 0x0400B628 RID: 46632
			[Token(Token = "0x401B980")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private Transform planeBone1;

			// Token: 0x0400B629 RID: 46633
			[Token(Token = "0x401B981")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private Transform planeBone2;

			// Token: 0x0400B62A RID: 46634
			[Token(Token = "0x401B982")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Transform planeBone3;

			// Token: 0x0400B62B RID: 46635
			[Token(Token = "0x401B983")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private int plane1ChainIndex;

			// Token: 0x0400B62C RID: 46636
			[Token(Token = "0x401B984")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private int plane1NodeIndex;

			// Token: 0x0400B62D RID: 46637
			[Token(Token = "0x401B985")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private int plane2ChainIndex;

			// Token: 0x0400B62E RID: 46638
			[Token(Token = "0x401B986")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			private int plane2NodeIndex;

			// Token: 0x0400B62F RID: 46639
			[Token(Token = "0x401B987")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private int plane3ChainIndex;

			// Token: 0x0400B630 RID: 46640
			[Token(Token = "0x401B988")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private int plane3NodeIndex;
		}
	}
}
