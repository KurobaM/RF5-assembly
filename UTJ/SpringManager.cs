using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace UTJ
{
	// Token: 0x02000C07 RID: 3079
	[Token(Token = "0x20007EB")]
	public class SpringManager : MonoBehaviour
	{
		// Token: 0x06004E58 RID: 20056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600413B")]
		[Address(RVA = "0x23B09D0", Offset = "0x23B0AD1", VA = "0x23B09D0")]
		public void CleanUpBoneColliders()
		{
		}

		// Token: 0x06004E59 RID: 20057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600413C")]
		[Address(RVA = "0x23B0D20", Offset = "0x23B0E21", VA = "0x23B0D20")]
		public void FindSpringBones(bool includeInactive = false)
		{
		}

		// Token: 0x06004E5A RID: 20058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600413D")]
		[Address(RVA = "0x23B1000", Offset = "0x23B1101", VA = "0x23B1000")]
		public void UpdateBoneIsAnimatedStates(IList<string> animatedBoneNames)
		{
		}

		// Token: 0x06004E5B RID: 20059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600413E")]
		[Address(RVA = "0x23B11D0", Offset = "0x23B12D1", VA = "0x23B11D0")]
		public void ResetPosition()
		{
		}

		// Token: 0x06004E5C RID: 20060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600413F")]
		[Address(RVA = "0x23B11E0", Offset = "0x23B12E1", VA = "0x23B11E0")]
		public void UpdateDynamics()
		{
		}

		// Token: 0x06004E5D RID: 20061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004140")]
		[Address(RVA = "0x23B1510", Offset = "0x23B1611", VA = "0x23B1510")]
		public void InitializeDynamics()
		{
		}

		// Token: 0x06004E5E RID: 20062 RVA: 0x00019038 File Offset: 0x00017238
		[Token(Token = "0x6004141")]
		[Address(RVA = "0x23B1760", Offset = "0x23B1861", VA = "0x23B1760")]
		private static int GetObjectDepth(Transform inObject)
		{
			return 0;
		}

		// Token: 0x06004E5F RID: 20063 RVA: 0x00019050 File Offset: 0x00017250
		[Token(Token = "0x6004142")]
		[Address(RVA = "0x23B1610", Offset = "0x23B1711", VA = "0x23B1610")]
		private Vector3 GetSumOfForcesOnBone(SpringBone springBone)
		{
			return default(Vector3);
		}

		// Token: 0x06004E60 RID: 20064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004143")]
		[Address(RVA = "0x23B1810", Offset = "0x23B1911", VA = "0x23B1810")]
		private void Awake()
		{
		}

		// Token: 0x06004E61 RID: 20065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004144")]
		[Address(RVA = "0x23B1910", Offset = "0x23B1A11", VA = "0x23B1910")]
		private void Start()
		{
		}

		// Token: 0x06004E62 RID: 20066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004145")]
		[Address(RVA = "0x23B1990", Offset = "0x23B1A91", VA = "0x23B1990")]
		private void LateUpdate()
		{
		}

		// Token: 0x06004E63 RID: 20067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004146")]
		[Address(RVA = "0x23B19A0", Offset = "0x23B1AA1", VA = "0x23B19A0")]
		public SpringManager()
		{
		}

		// Token: 0x0400AF92 RID: 44946
		[Token(Token = "0x4008418")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x176D30", Offset = "0x176E31")]
		public bool automaticUpdates;

		// Token: 0x0400AF93 RID: 44947
		[Token(Token = "0x4008419")]
		[FieldOffset(Offset = "0x19")]
		public bool isPaused;

		// Token: 0x0400AF94 RID: 44948
		[Token(Token = "0x400841A")]
		[FieldOffset(Offset = "0x1A")]
		public bool isStarted;

		// Token: 0x0400AF95 RID: 44949
		[Token(Token = "0x400841B")]
		[FieldOffset(Offset = "0x1C")]
		public int simulationFrameRate;

		// Token: 0x0400AF96 RID: 44950
		[Token(Token = "0x400841C")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "RangeAttribute", RVA = "0x176D70", Offset = "0x176E71")]
		public float dynamicRatio;

		// Token: 0x0400AF97 RID: 44951
		[Token(Token = "0x400841D")]
		[FieldOffset(Offset = "0x24")]
		public Vector3 gravity;

		// Token: 0x0400AF98 RID: 44952
		[Token(Token = "0x400841E")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "RangeAttribute", RVA = "0x176D90", Offset = "0x176E91")]
		public float bounce;

		// Token: 0x0400AF99 RID: 44953
		[Token(Token = "0x400841F")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "RangeAttribute", RVA = "0x176DB0", Offset = "0x176EB1")]
		public float friction;

		// Token: 0x0400AF9A RID: 44954
		[Token(Token = "0x4008420")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x176DD0", Offset = "0x176ED1")]
		public bool enableAngleLimits;

		// Token: 0x0400AF9B RID: 44955
		[Token(Token = "0x4008421")]
		[FieldOffset(Offset = "0x39")]
		public bool enableCollision;

		// Token: 0x0400AF9C RID: 44956
		[Token(Token = "0x4008422")]
		[FieldOffset(Offset = "0x3A")]
		public bool enableLengthLimits;

		// Token: 0x0400AF9D RID: 44957
		[Token(Token = "0x4008423")]
		[FieldOffset(Offset = "0x3B")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x176E10", Offset = "0x176F11")]
		public bool collideWithGround;

		// Token: 0x0400AF9E RID: 44958
		[Token(Token = "0x4008424")]
		[FieldOffset(Offset = "0x3C")]
		public float groundHeight;

		// Token: 0x0400AF9F RID: 44959
		[Token(Token = "0x4008425")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x176E50", Offset = "0x176F51")]
		public SpringBone[] springBones;

		// Token: 0x0400AFA0 RID: 44960
		[Token(Token = "0x4008426")]
		private const float ResetSeconds = 1f;

		// Token: 0x0400AFA1 RID: 44961
		[Token(Token = "0x4008427")]
		[FieldOffset(Offset = "0x48")]
		private bool isResetPosition;

		// Token: 0x0400AFA2 RID: 44962
		[Token(Token = "0x4008428")]
		[FieldOffset(Offset = "0x50")]
		private bool[] boneIsAnimatedStates;

		// Token: 0x0400AFA3 RID: 44963
		[Token(Token = "0x4008429")]
		[FieldOffset(Offset = "0x58")]
		private ForceProvider[] forceProviders;

		// Token: 0x02000C08 RID: 3080
		[Token(Token = "0x2001397")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159590", Offset = "0x159691")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004E65 RID: 20069 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60077EC")]
			[Address(RVA = "0x23B1AA0", Offset = "0x23B1BA1", VA = "0x23B1AA0")]
			public <>c()
			{
			}

			// Token: 0x06004E66 RID: 20070 RVA: 0x00019068 File Offset: 0x00017268
			[Token(Token = "0x60077ED")]
			[Address(RVA = "0x23B1AB0", Offset = "0x23B1BB1", VA = "0x23B1AB0")]
			internal bool <CleanUpBoneColliders>b__15_0(SpringSphereCollider collider)
			{
				return default(bool);
			}

			// Token: 0x06004E67 RID: 20071 RVA: 0x00019080 File Offset: 0x00017280
			[Token(Token = "0x60077EE")]
			[Address(RVA = "0x23B1B20", Offset = "0x23B1C21", VA = "0x23B1B20")]
			internal bool <CleanUpBoneColliders>b__15_1(SpringCapsuleCollider collider)
			{
				return default(bool);
			}

			// Token: 0x06004E68 RID: 20072 RVA: 0x00019098 File Offset: 0x00017298
			[Token(Token = "0x60077EF")]
			[Address(RVA = "0x23B1B90", Offset = "0x23B1C91", VA = "0x23B1B90")]
			internal bool <CleanUpBoneColliders>b__15_2(SpringPanelCollider collider)
			{
				return default(bool);
			}

			// Token: 0x06004E69 RID: 20073 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60077F0")]
			[Address(RVA = "0x23B1C00", Offset = "0x23B1D01", VA = "0x23B1C00")]
			internal <>f__AnonymousType0<SpringBone, int> <FindSpringBones>b__16_0(SpringBone bone)
			{
				return null;
			}

			// Token: 0x06004E6A RID: 20074 RVA: 0x000190B0 File Offset: 0x000172B0
			[Token(Token = "0x60077F1")]
			[Address(RVA = "0x23B1D20", Offset = "0x23B1E21", VA = "0x23B1D20")]
			internal int <FindSpringBones>b__16_1(<>f__AnonymousType0<SpringBone, int> a, <>f__AnonymousType0<SpringBone, int> b)
			{
				return 0;
			}

			// Token: 0x06004E6B RID: 20075 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60077F2")]
			[Address(RVA = "0x23B1DA0", Offset = "0x23B1EA1", VA = "0x23B1DA0")]
			internal SpringBone <FindSpringBones>b__16_2(<>f__AnonymousType0<SpringBone, int> item)
			{
				return null;
			}

			// Token: 0x0400AFA4 RID: 44964
			[Token(Token = "0x401B7C4")]
			[FieldOffset(Offset = "0x0")]
			public static readonly SpringManager.<>c <>9;

			// Token: 0x0400AFA5 RID: 44965
			[Token(Token = "0x401B7C5")]
			[FieldOffset(Offset = "0x8")]
			public static Func<SpringSphereCollider, bool> <>9__15_0;

			// Token: 0x0400AFA6 RID: 44966
			[Token(Token = "0x401B7C6")]
			[FieldOffset(Offset = "0x10")]
			public static Func<SpringCapsuleCollider, bool> <>9__15_1;

			// Token: 0x0400AFA7 RID: 44967
			[Token(Token = "0x401B7C7")]
			[FieldOffset(Offset = "0x18")]
			public static Func<SpringPanelCollider, bool> <>9__15_2;

			// Token: 0x0400AFA8 RID: 44968
			[Token(Token = "0x401B7C8")]
			[FieldOffset(Offset = "0x20")]
			public static Func<SpringBone, <>f__AnonymousType0<SpringBone, int>> <>9__16_0;

			// Token: 0x0400AFA9 RID: 44969
			[Token(Token = "0x401B7C9")]
			[FieldOffset(Offset = "0x28")]
			public static Comparison<<>f__AnonymousType0<SpringBone, int>> <>9__16_1;

			// Token: 0x0400AFAA RID: 44970
			[Token(Token = "0x401B7CA")]
			[FieldOffset(Offset = "0x30")]
			public static Func<<>f__AnonymousType0<SpringBone, int>, SpringBone> <>9__16_2;
		}
	}
}
