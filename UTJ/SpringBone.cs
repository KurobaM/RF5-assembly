using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace UTJ
{
	// Token: 0x02000C03 RID: 3075
	[Token(Token = "0x20007E9")]
	public class SpringBone : MonoBehaviour
	{
		// Token: 0x17000A17 RID: 2583
		// (get) Token: 0x06004E40 RID: 20032 RVA: 0x00018F30 File Offset: 0x00017130
		[Token(Token = "0x170007FC")]
		public Vector3 CurrentTipPosition
		{
			[Token(Token = "0x6004129")]
			[Address(RVA = "0x212C9A0", Offset = "0x212CAA1", VA = "0x212C9A0")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x06004E41 RID: 20033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600412A")]
		[Address(RVA = "0x212C9B0", Offset = "0x212CAB1", VA = "0x212C9B0")]
		public void Initialize(SpringManager owner)
		{
		}

		// Token: 0x06004E42 RID: 20034 RVA: 0x00018F48 File Offset: 0x00017148
		[Token(Token = "0x600412B")]
		[Address(RVA = "0x212CE60", Offset = "0x212CF61", VA = "0x212CE60")]
		public Vector3 ComputeChildPosition()
		{
			return default(Vector3);
		}

		// Token: 0x06004E43 RID: 20035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600412C")]
		[Address(RVA = "0x212D6D0", Offset = "0x212D7D1", VA = "0x212D6D0")]
		public void RemoveAllColliders()
		{
		}

		// Token: 0x06004E44 RID: 20036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600412D")]
		[Address(RVA = "0x212D780", Offset = "0x212D881", VA = "0x212D780")]
		public void UpdateSpring(float deltaTime, Vector3 externalForce)
		{
		}

		// Token: 0x06004E45 RID: 20037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600412E")]
		[Address(RVA = "0x212DBE0", Offset = "0x212DCE1", VA = "0x212DBE0")]
		public void SatisfyConstraintsAndComputeRotation(float deltaTime, float dynamicRatio)
		{
		}

		// Token: 0x06004E46 RID: 20038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600412F")]
		[Address(RVA = "0x212EE20", Offset = "0x212EF21", VA = "0x212EE20")]
		public void ComputeRotation(float dynamicRatio)
		{
		}

		// Token: 0x06004E47 RID: 20039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004130")]
		[Address(RVA = "0x212F0C0", Offset = "0x212F1C1", VA = "0x212F0C0")]
		public Transform GetPivotTransform()
		{
			return null;
		}

		// Token: 0x06004E48 RID: 20040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004131")]
		[Address(RVA = "0x212D520", Offset = "0x212D621", VA = "0x212D520")]
		private static IList<Transform> GetValidChildren(Transform parent)
		{
			return null;
		}

		// Token: 0x06004E49 RID: 20041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004132")]
		[Address(RVA = "0x212E8F0", Offset = "0x212E9F1", VA = "0x212E8F0")]
		private void ApplyAngleLimits(float deltaTime)
		{
		}

		// Token: 0x06004E4A RID: 20042 RVA: 0x00018F60 File Offset: 0x00017160
		[Token(Token = "0x6004133")]
		[Address(RVA = "0x212E3B0", Offset = "0x212E4B1", VA = "0x212E3B0")]
		private bool CheckForCollision()
		{
			return default(bool);
		}

		// Token: 0x06004E4B RID: 20043 RVA: 0x00018F78 File Offset: 0x00017178
		[Token(Token = "0x6004134")]
		[Address(RVA = "0x212E1C0", Offset = "0x212E2C1", VA = "0x212E1C0")]
		private bool CheckForGroundCollision()
		{
			return default(bool);
		}

		// Token: 0x06004E4C RID: 20044 RVA: 0x00018F90 File Offset: 0x00017190
		[Token(Token = "0x6004135")]
		[Address(RVA = "0x212F190", Offset = "0x212F291", VA = "0x212F190")]
		private Vector3 FixBoneLength(Vector3 headPosition, Vector3 tailPosition, float minLength, float maxLength)
		{
			return default(Vector3);
		}

		// Token: 0x06004E4D RID: 20045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004136")]
		[Address(RVA = "0x212D320", Offset = "0x212D421", VA = "0x212D320")]
		public void InitializeSpringLengthAndTipPosition()
		{
		}

		// Token: 0x06004E4E RID: 20046 RVA: 0x00018FA8 File Offset: 0x000171A8
		[Token(Token = "0x6004137")]
		[Address(RVA = "0x212EC10", Offset = "0x212ED11", VA = "0x212EC10")]
		private Quaternion ComputeRotation(Vector3 tipPosition)
		{
			return default(Quaternion);
		}

		// Token: 0x06004E4F RID: 20047 RVA: 0x00018FC0 File Offset: 0x000171C0
		[Token(Token = "0x6004138")]
		[Address(RVA = "0x212DF10", Offset = "0x212E011", VA = "0x212DF10")]
		private Vector3 ApplyLengthLimits(float deltaTime)
		{
			return default(Vector3);
		}

		// Token: 0x06004E50 RID: 20048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004139")]
		[Address(RVA = "0x212F360", Offset = "0x212F461", VA = "0x212F360")]
		public SpringBone()
		{
		}

		// Token: 0x0400AF73 RID: 44915
		[Token(Token = "0x4008402")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "RangeAttribute", RVA = "0x176CB0", Offset = "0x176DB1")]
		public float stiffnessForce;

		// Token: 0x0400AF74 RID: 44916
		[Token(Token = "0x4008403")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "RangeAttribute", RVA = "0x176CD0", Offset = "0x176DD1")]
		public float dragForce;

		// Token: 0x0400AF75 RID: 44917
		[Token(Token = "0x4008404")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 springForce;

		// Token: 0x0400AF76 RID: 44918
		[Token(Token = "0x4008405")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "RangeAttribute", RVA = "0x176CF0", Offset = "0x176DF1")]
		public float windInfluence;

		// Token: 0x0400AF77 RID: 44919
		[Token(Token = "0x4008406")]
		[FieldOffset(Offset = "0x30")]
		public Transform pivotNode;

		// Token: 0x0400AF78 RID: 44920
		[Token(Token = "0x4008407")]
		[FieldOffset(Offset = "0x38")]
		public float angularStiffness;

		// Token: 0x0400AF79 RID: 44921
		[Token(Token = "0x4008408")]
		[FieldOffset(Offset = "0x40")]
		public AngleLimits yAngleLimits;

		// Token: 0x0400AF7A RID: 44922
		[Token(Token = "0x4008409")]
		[FieldOffset(Offset = "0x48")]
		public AngleLimits zAngleLimits;

		// Token: 0x0400AF7B RID: 44923
		[Token(Token = "0x400840A")]
		[FieldOffset(Offset = "0x50")]
		public Transform[] lengthLimitTargets;

		// Token: 0x0400AF7C RID: 44924
		[Token(Token = "0x400840B")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "RangeAttribute", RVA = "0x176D10", Offset = "0x176E11")]
		public float radius;

		// Token: 0x0400AF7D RID: 44925
		[Token(Token = "0x400840C")]
		[FieldOffset(Offset = "0x60")]
		public SpringSphereCollider[] sphereColliders;

		// Token: 0x0400AF7E RID: 44926
		[Token(Token = "0x400840D")]
		[FieldOffset(Offset = "0x68")]
		public SpringCapsuleCollider[] capsuleColliders;

		// Token: 0x0400AF7F RID: 44927
		[Token(Token = "0x400840E")]
		[FieldOffset(Offset = "0x70")]
		public SpringPanelCollider[] panelColliders;

		// Token: 0x0400AF80 RID: 44928
		[Token(Token = "0x400840F")]
		[FieldOffset(Offset = "0x78")]
		private SpringManager manager;

		// Token: 0x0400AF81 RID: 44929
		[Token(Token = "0x4008410")]
		[FieldOffset(Offset = "0x80")]
		private Vector3 boneAxis;

		// Token: 0x0400AF82 RID: 44930
		[Token(Token = "0x4008411")]
		[FieldOffset(Offset = "0x8C")]
		private float springLength;

		// Token: 0x0400AF83 RID: 44931
		[Token(Token = "0x4008412")]
		[FieldOffset(Offset = "0x90")]
		private Quaternion skinAnimationLocalRotation;

		// Token: 0x0400AF84 RID: 44932
		[Token(Token = "0x4008413")]
		[FieldOffset(Offset = "0xA0")]
		private Quaternion initialLocalRotation;

		// Token: 0x0400AF85 RID: 44933
		[Token(Token = "0x4008414")]
		[FieldOffset(Offset = "0xB0")]
		private Quaternion actualLocalRotation;

		// Token: 0x0400AF86 RID: 44934
		[Token(Token = "0x4008415")]
		[FieldOffset(Offset = "0xC0")]
		private Vector3 currTipPos;

		// Token: 0x0400AF87 RID: 44935
		[Token(Token = "0x4008416")]
		[FieldOffset(Offset = "0xCC")]
		private Vector3 prevTipPos;

		// Token: 0x0400AF88 RID: 44936
		[Token(Token = "0x4008417")]
		[FieldOffset(Offset = "0xD8")]
		private float[] lengthsToLimitTargets;

		// Token: 0x02000C04 RID: 3076
		[Token(Token = "0x2001395")]
		public enum CollisionStatus
		{
			// Token: 0x0400AF8A RID: 44938
			[Token(Token = "0x401B7BC")]
			NoCollision,
			// Token: 0x0400AF8B RID: 44939
			[Token(Token = "0x401B7BD")]
			HeadIsEmbedded,
			// Token: 0x0400AF8C RID: 44940
			[Token(Token = "0x401B7BE")]
			TailCollision
		}

		// Token: 0x02000C05 RID: 3077
		[Token(Token = "0x2001396")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159580", Offset = "0x159681")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004E52 RID: 20050 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60077E6")]
			[Address(RVA = "0x212F520", Offset = "0x212F621", VA = "0x212F520")]
			public <>c()
			{
			}

			// Token: 0x06004E53 RID: 20051 RVA: 0x00018FD8 File Offset: 0x000171D8
			[Token(Token = "0x60077E7")]
			[Address(RVA = "0x212F530", Offset = "0x212F631", VA = "0x212F530")]
			internal bool <Initialize>b__16_0(SpringSphereCollider item)
			{
				return default(bool);
			}

			// Token: 0x06004E54 RID: 20052 RVA: 0x00018FF0 File Offset: 0x000171F0
			[Token(Token = "0x60077E8")]
			[Address(RVA = "0x212F5A0", Offset = "0x212F6A1", VA = "0x212F5A0")]
			internal bool <Initialize>b__16_1(SpringCapsuleCollider item)
			{
				return default(bool);
			}

			// Token: 0x06004E55 RID: 20053 RVA: 0x00019008 File Offset: 0x00017208
			[Token(Token = "0x60077E9")]
			[Address(RVA = "0x212F610", Offset = "0x212F711", VA = "0x212F610")]
			internal bool <Initialize>b__16_2(SpringPanelCollider item)
			{
				return default(bool);
			}

			// Token: 0x06004E56 RID: 20054 RVA: 0x00019020 File Offset: 0x00017220
			[Token(Token = "0x60077EA")]
			[Address(RVA = "0x212F680", Offset = "0x212F781", VA = "0x212F680")]
			internal bool <Initialize>b__16_3(Transform target)
			{
				return default(bool);
			}

			// Token: 0x0400AF8D RID: 44941
			[Token(Token = "0x401B7BF")]
			[FieldOffset(Offset = "0x0")]
			public static readonly SpringBone.<>c <>9;

			// Token: 0x0400AF8E RID: 44942
			[Token(Token = "0x401B7C0")]
			[FieldOffset(Offset = "0x8")]
			public static Func<SpringSphereCollider, bool> <>9__16_0;

			// Token: 0x0400AF8F RID: 44943
			[Token(Token = "0x401B7C1")]
			[FieldOffset(Offset = "0x10")]
			public static Func<SpringCapsuleCollider, bool> <>9__16_1;

			// Token: 0x0400AF90 RID: 44944
			[Token(Token = "0x401B7C2")]
			[FieldOffset(Offset = "0x18")]
			public static Func<SpringPanelCollider, bool> <>9__16_2;

			// Token: 0x0400AF91 RID: 44945
			[Token(Token = "0x401B7C3")]
			[FieldOffset(Offset = "0x20")]
			public static Func<Transform, bool> <>9__16_3;
		}
	}
}
