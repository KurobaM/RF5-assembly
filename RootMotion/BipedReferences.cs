using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x02000C96 RID: 3222
	[Token(Token = "0x200083D")]
	[Serializable]
	public class BipedReferences
	{
		// Token: 0x17000AC6 RID: 2758
		// (get) Token: 0x060052F0 RID: 21232 RVA: 0x0001B300 File Offset: 0x00019500
		[Token(Token = "0x17000890")]
		public virtual bool isFilled
		{
			[Token(Token = "0x6004510")]
			[Address(RVA = "0x29A65D0", Offset = "0x29A66D1", VA = "0x29A65D0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000AC7 RID: 2759
		// (get) Token: 0x060052F1 RID: 21233 RVA: 0x0001B318 File Offset: 0x00019518
		[Token(Token = "0x17000891")]
		public bool isEmpty
		{
			[Token(Token = "0x6004511")]
			[Address(RVA = "0x29A69B0", Offset = "0x29A6AB1", VA = "0x29A69B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060052F2 RID: 21234 RVA: 0x0001B330 File Offset: 0x00019530
		[Token(Token = "0x6004512")]
		[Address(RVA = "0x29A69C0", Offset = "0x29A6AC1", VA = "0x29A69C0", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		// Token: 0x060052F3 RID: 21235 RVA: 0x0001B348 File Offset: 0x00019548
		[Token(Token = "0x6004513")]
		[Address(RVA = "0x29A6DE0", Offset = "0x29A6EE1", VA = "0x29A6DE0", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		// Token: 0x060052F4 RID: 21236 RVA: 0x0001B360 File Offset: 0x00019560
		[Token(Token = "0x6004514")]
		[Address(RVA = "0x29A7210", Offset = "0x29A7311", VA = "0x29A7210")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, BipedReferences.AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		// Token: 0x060052F5 RID: 21237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004515")]
		[Address(RVA = "0x29A7A00", Offset = "0x29A7B01", VA = "0x29A7A00")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, BipedReferences.AutoDetectParams autoDetectParams)
		{
		}

		// Token: 0x060052F6 RID: 21238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004516")]
		[Address(RVA = "0x29A7500", Offset = "0x29A7601", VA = "0x29A7500")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, BipedReferences.AutoDetectParams autoDetectParams)
		{
		}

		// Token: 0x060052F7 RID: 21239 RVA: 0x0001B378 File Offset: 0x00019578
		[Token(Token = "0x6004517")]
		[Address(RVA = "0x29A82C0", Offset = "0x29A83C1", VA = "0x29A82C0")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		// Token: 0x060052F8 RID: 21240 RVA: 0x0001B390 File Offset: 0x00019590
		[Token(Token = "0x6004518")]
		[Address(RVA = "0x29A83C0", Offset = "0x29A84C1", VA = "0x29A83C0")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		// Token: 0x060052F9 RID: 21241 RVA: 0x0001B3A8 File Offset: 0x000195A8
		[Token(Token = "0x6004519")]
		[Address(RVA = "0x29A89E0", Offset = "0x29A8AE1", VA = "0x29A89E0")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		// Token: 0x060052FA RID: 21242 RVA: 0x0001B3C0 File Offset: 0x000195C0
		[Token(Token = "0x600451A")]
		[Address(RVA = "0x29A87C0", Offset = "0x29A88C1", VA = "0x29A87C0")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, BipedReferences.AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		// Token: 0x060052FB RID: 21243 RVA: 0x0001B3D8 File Offset: 0x000195D8
		[Token(Token = "0x600451B")]
		[Address(RVA = "0x29A8630", Offset = "0x29A8731", VA = "0x29A8630")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, BipedReferences.AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		// Token: 0x060052FC RID: 21244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600451C")]
		[Address(RVA = "0x29A8460", Offset = "0x29A8561", VA = "0x29A8460")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		// Token: 0x060052FD RID: 21245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600451D")]
		[Address(RVA = "0x29A88D0", Offset = "0x29A89D1", VA = "0x29A88D0")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		// Token: 0x060052FE RID: 21246 RVA: 0x0001B3F0 File Offset: 0x000195F0
		[Token(Token = "0x600451E")]
		[Address(RVA = "0x29A8AE0", Offset = "0x29A8BE1", VA = "0x29A8AE0")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		// Token: 0x060052FF RID: 21247 RVA: 0x0001B408 File Offset: 0x00019608
		[Token(Token = "0x600451F")]
		[Address(RVA = "0x29A9660", Offset = "0x29A9761", VA = "0x29A9660")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		// Token: 0x06005300 RID: 21248 RVA: 0x0001B420 File Offset: 0x00019620
		[Token(Token = "0x6004520")]
		[Address(RVA = "0x29A9130", Offset = "0x29A9231", VA = "0x29A9130")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		// Token: 0x06005301 RID: 21249 RVA: 0x0001B438 File Offset: 0x00019638
		[Token(Token = "0x6004521")]
		[Address(RVA = "0x29A99D0", Offset = "0x29A9AD1", VA = "0x29A99D0")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		// Token: 0x06005302 RID: 21250 RVA: 0x0001B450 File Offset: 0x00019650
		[Token(Token = "0x6004522")]
		[Address(RVA = "0x29A9480", Offset = "0x29A9581", VA = "0x29A9480")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		// Token: 0x06005303 RID: 21251 RVA: 0x0001B468 File Offset: 0x00019668
		[Token(Token = "0x6004523")]
		[Address(RVA = "0x29A99E0", Offset = "0x29A9AE1", VA = "0x29A99E0")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		// Token: 0x06005304 RID: 21252 RVA: 0x0001B480 File Offset: 0x00019680
		[Token(Token = "0x6004524")]
		[Address(RVA = "0x29A99F0", Offset = "0x29A9AF1", VA = "0x29A99F0")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		// Token: 0x06005305 RID: 21253 RVA: 0x0001B498 File Offset: 0x00019698
		[Token(Token = "0x6004525")]
		[Address(RVA = "0x29A9BC0", Offset = "0x29A9CC1", VA = "0x29A9BC0")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		// Token: 0x06005306 RID: 21254 RVA: 0x0001B4B0 File Offset: 0x000196B0
		[Token(Token = "0x6004526")]
		[Address(RVA = "0x29A9DF0", Offset = "0x29A9EF1", VA = "0x29A9DF0")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return 0f;
		}

		// Token: 0x06005307 RID: 21255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004527")]
		[Address(RVA = "0x29A7470", Offset = "0x29A7571", VA = "0x29A7470")]
		public BipedReferences()
		{
		}

		// Token: 0x0400B1E6 RID: 45542
		[Token(Token = "0x400856D")]
		[FieldOffset(Offset = "0x10")]
		public Transform root;

		// Token: 0x0400B1E7 RID: 45543
		[Token(Token = "0x400856E")]
		[FieldOffset(Offset = "0x18")]
		public Transform pelvis;

		// Token: 0x0400B1E8 RID: 45544
		[Token(Token = "0x400856F")]
		[FieldOffset(Offset = "0x20")]
		public Transform leftThigh;

		// Token: 0x0400B1E9 RID: 45545
		[Token(Token = "0x4008570")]
		[FieldOffset(Offset = "0x28")]
		public Transform leftCalf;

		// Token: 0x0400B1EA RID: 45546
		[Token(Token = "0x4008571")]
		[FieldOffset(Offset = "0x30")]
		public Transform leftFoot;

		// Token: 0x0400B1EB RID: 45547
		[Token(Token = "0x4008572")]
		[FieldOffset(Offset = "0x38")]
		public Transform rightThigh;

		// Token: 0x0400B1EC RID: 45548
		[Token(Token = "0x4008573")]
		[FieldOffset(Offset = "0x40")]
		public Transform rightCalf;

		// Token: 0x0400B1ED RID: 45549
		[Token(Token = "0x4008574")]
		[FieldOffset(Offset = "0x48")]
		public Transform rightFoot;

		// Token: 0x0400B1EE RID: 45550
		[Token(Token = "0x4008575")]
		[FieldOffset(Offset = "0x50")]
		public Transform leftUpperArm;

		// Token: 0x0400B1EF RID: 45551
		[Token(Token = "0x4008576")]
		[FieldOffset(Offset = "0x58")]
		public Transform leftForearm;

		// Token: 0x0400B1F0 RID: 45552
		[Token(Token = "0x4008577")]
		[FieldOffset(Offset = "0x60")]
		public Transform leftHand;

		// Token: 0x0400B1F1 RID: 45553
		[Token(Token = "0x4008578")]
		[FieldOffset(Offset = "0x68")]
		public Transform rightUpperArm;

		// Token: 0x0400B1F2 RID: 45554
		[Token(Token = "0x4008579")]
		[FieldOffset(Offset = "0x70")]
		public Transform rightForearm;

		// Token: 0x0400B1F3 RID: 45555
		[Token(Token = "0x400857A")]
		[FieldOffset(Offset = "0x78")]
		public Transform rightHand;

		// Token: 0x0400B1F4 RID: 45556
		[Token(Token = "0x400857B")]
		[FieldOffset(Offset = "0x80")]
		public Transform head;

		// Token: 0x0400B1F5 RID: 45557
		[Token(Token = "0x400857C")]
		[FieldOffset(Offset = "0x88")]
		public Transform[] spine;

		// Token: 0x0400B1F6 RID: 45558
		[Token(Token = "0x400857D")]
		[FieldOffset(Offset = "0x90")]
		public Transform[] eyes;

		// Token: 0x02000C97 RID: 3223
		[Token(Token = "0x20013D2")]
		public struct AutoDetectParams
		{
			// Token: 0x06005308 RID: 21256 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60078AA")]
			[Address(RVA = "0x36F960", Offset = "0x36FA61", VA = "0x36F960")]
			public AutoDetectParams(bool legsParentInSpine, bool includeEyes)
			{
			}

			// Token: 0x17000AC8 RID: 2760
			// (get) Token: 0x06005309 RID: 21257 RVA: 0x0001B4C8 File Offset: 0x000196C8
			[Token(Token = "0x17000DF3")]
			public static BipedReferences.AutoDetectParams Default
			{
				[Token(Token = "0x60078AB")]
				[Address(RVA = "0x29A9F40", Offset = "0x29AA041", VA = "0x29A9F40")]
				get
				{
					return default(BipedReferences.AutoDetectParams);
				}
			}

			// Token: 0x0400B1F7 RID: 45559
			[Token(Token = "0x401B8BD")]
			[FieldOffset(Offset = "0x0")]
			public bool legsParentInSpine;

			// Token: 0x0400B1F8 RID: 45560
			[Token(Token = "0x401B8BE")]
			[FieldOffset(Offset = "0x1")]
			public bool includeEyes;
		}
	}
}
