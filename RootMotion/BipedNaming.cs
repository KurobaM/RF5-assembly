using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x02000C93 RID: 3219
	[Token(Token = "0x200083C")]
	public static class BipedNaming
	{
		// Token: 0x060052D8 RID: 21208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044F8")]
		[Address(RVA = "0x29A24F0", Offset = "0x29A25F1", VA = "0x29A24F0")]
		public static Transform[] GetBonesOfType(BipedNaming.BoneType boneType, Transform[] bones)
		{
			return null;
		}

		// Token: 0x060052D9 RID: 21209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044F9")]
		[Address(RVA = "0x29A2860", Offset = "0x29A2961", VA = "0x29A2860")]
		public static Transform[] GetBonesOfSide(BipedNaming.BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		// Token: 0x060052DA RID: 21210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044FA")]
		[Address(RVA = "0x29A2AF0", Offset = "0x29A2BF1", VA = "0x29A2AF0")]
		public static Transform[] GetBonesOfTypeAndSide(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		// Token: 0x060052DB RID: 21211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044FB")]
		[Address(RVA = "0x29A2B80", Offset = "0x29A2C81", VA = "0x29A2B80")]
		public static Transform GetFirstBoneOfTypeAndSide(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		// Token: 0x060052DC RID: 21212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044FC")]
		[Address(RVA = "0x29A2C90", Offset = "0x29A2D91", VA = "0x29A2C90")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		// Token: 0x060052DD RID: 21213 RVA: 0x0001B198 File Offset: 0x00019398
		[Token(Token = "0x60044FD")]
		[Address(RVA = "0x29A26C0", Offset = "0x29A27C1", VA = "0x29A26C0")]
		public static BipedNaming.BoneType GetBoneType(string boneName)
		{
			return BipedNaming.BoneType.Unassigned;
		}

		// Token: 0x060052DE RID: 21214 RVA: 0x0001B1B0 File Offset: 0x000193B0
		[Token(Token = "0x60044FE")]
		[Address(RVA = "0x29A2A30", Offset = "0x29A2B31", VA = "0x29A2A30")]
		public static BipedNaming.BoneSide GetBoneSide(string boneName)
		{
			return BipedNaming.BoneSide.Center;
		}

		// Token: 0x060052DF RID: 21215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044FF")]
		[Address(RVA = "0x29A38D0", Offset = "0x29A39D1", VA = "0x29A38D0")]
		public static Transform GetBone(Transform[] transforms, BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide = BipedNaming.BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		// Token: 0x060052E0 RID: 21216 RVA: 0x0001B1C8 File Offset: 0x000193C8
		[Token(Token = "0x6004500")]
		[Address(RVA = "0x29A35B0", Offset = "0x29A36B1", VA = "0x29A35B0")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		// Token: 0x060052E1 RID: 21217 RVA: 0x0001B1E0 File Offset: 0x000193E0
		[Token(Token = "0x6004501")]
		[Address(RVA = "0x29A3740", Offset = "0x29A3841", VA = "0x29A3740")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		// Token: 0x060052E2 RID: 21218 RVA: 0x0001B1F8 File Offset: 0x000193F8
		[Token(Token = "0x6004502")]
		[Address(RVA = "0x29A2EF0", Offset = "0x29A2FF1", VA = "0x29A2EF0")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		// Token: 0x060052E3 RID: 21219 RVA: 0x0001B210 File Offset: 0x00019410
		[Token(Token = "0x6004503")]
		[Address(RVA = "0x29A3010", Offset = "0x29A3111", VA = "0x29A3010")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		// Token: 0x060052E4 RID: 21220 RVA: 0x0001B228 File Offset: 0x00019428
		[Token(Token = "0x6004504")]
		[Address(RVA = "0x29A3130", Offset = "0x29A3231", VA = "0x29A3130")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		// Token: 0x060052E5 RID: 21221 RVA: 0x0001B240 File Offset: 0x00019440
		[Token(Token = "0x6004505")]
		[Address(RVA = "0x29A3250", Offset = "0x29A3351", VA = "0x29A3250")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		// Token: 0x060052E6 RID: 21222 RVA: 0x0001B258 File Offset: 0x00019458
		[Token(Token = "0x6004506")]
		[Address(RVA = "0x29A3370", Offset = "0x29A3471", VA = "0x29A3370")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		// Token: 0x060052E7 RID: 21223 RVA: 0x0001B270 File Offset: 0x00019470
		[Token(Token = "0x6004507")]
		[Address(RVA = "0x29A3490", Offset = "0x29A3591", VA = "0x29A3490")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		// Token: 0x060052E8 RID: 21224 RVA: 0x0001B288 File Offset: 0x00019488
		[Token(Token = "0x6004508")]
		[Address(RVA = "0x29A3B60", Offset = "0x29A3C61", VA = "0x29A3B60")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		// Token: 0x060052E9 RID: 21225 RVA: 0x0001B2A0 File Offset: 0x000194A0
		[Token(Token = "0x6004509")]
		[Address(RVA = "0x29A2DC0", Offset = "0x29A2EC1", VA = "0x29A2DC0")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		// Token: 0x060052EA RID: 21226 RVA: 0x0001B2B8 File Offset: 0x000194B8
		[Token(Token = "0x600450A")]
		[Address(RVA = "0x29A3AC0", Offset = "0x29A3BC1", VA = "0x29A3AC0")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		// Token: 0x060052EB RID: 21227 RVA: 0x0001B2D0 File Offset: 0x000194D0
		[Token(Token = "0x600450B")]
		[Address(RVA = "0x29A3BD0", Offset = "0x29A3CD1", VA = "0x29A3BD0")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		// Token: 0x060052EC RID: 21228 RVA: 0x0001B2E8 File Offset: 0x000194E8
		[Token(Token = "0x600450C")]
		[Address(RVA = "0x29A3CF0", Offset = "0x29A3DF1", VA = "0x29A3CF0")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		// Token: 0x060052ED RID: 21229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600450D")]
		[Address(RVA = "0x29A3A40", Offset = "0x29A3B41", VA = "0x29A3A40")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		// Token: 0x060052EE RID: 21230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600450E")]
		[Address(RVA = "0x29A39C0", Offset = "0x29A3AC1", VA = "0x29A39C0")]
		private static string lastLetter(string boneName)
		{
			return null;
		}

		// Token: 0x0400B1C8 RID: 45512
		[Token(Token = "0x400855B")]
		[FieldOffset(Offset = "0x0")]
		public static string[] typeLeft;

		// Token: 0x0400B1C9 RID: 45513
		[Token(Token = "0x400855C")]
		[FieldOffset(Offset = "0x8")]
		public static string[] typeRight;

		// Token: 0x0400B1CA RID: 45514
		[Token(Token = "0x400855D")]
		[FieldOffset(Offset = "0x10")]
		public static string[] typeSpine;

		// Token: 0x0400B1CB RID: 45515
		[Token(Token = "0x400855E")]
		[FieldOffset(Offset = "0x18")]
		public static string[] typeHead;

		// Token: 0x0400B1CC RID: 45516
		[Token(Token = "0x400855F")]
		[FieldOffset(Offset = "0x20")]
		public static string[] typeArm;

		// Token: 0x0400B1CD RID: 45517
		[Token(Token = "0x4008560")]
		[FieldOffset(Offset = "0x28")]
		public static string[] typeLeg;

		// Token: 0x0400B1CE RID: 45518
		[Token(Token = "0x4008561")]
		[FieldOffset(Offset = "0x30")]
		public static string[] typeTail;

		// Token: 0x0400B1CF RID: 45519
		[Token(Token = "0x4008562")]
		[FieldOffset(Offset = "0x38")]
		public static string[] typeEye;

		// Token: 0x0400B1D0 RID: 45520
		[Token(Token = "0x4008563")]
		[FieldOffset(Offset = "0x40")]
		public static string[] typeExclude;

		// Token: 0x0400B1D1 RID: 45521
		[Token(Token = "0x4008564")]
		[FieldOffset(Offset = "0x48")]
		public static string[] typeExcludeSpine;

		// Token: 0x0400B1D2 RID: 45522
		[Token(Token = "0x4008565")]
		[FieldOffset(Offset = "0x50")]
		public static string[] typeExcludeHead;

		// Token: 0x0400B1D3 RID: 45523
		[Token(Token = "0x4008566")]
		[FieldOffset(Offset = "0x58")]
		public static string[] typeExcludeArm;

		// Token: 0x0400B1D4 RID: 45524
		[Token(Token = "0x4008567")]
		[FieldOffset(Offset = "0x60")]
		public static string[] typeExcludeLeg;

		// Token: 0x0400B1D5 RID: 45525
		[Token(Token = "0x4008568")]
		[FieldOffset(Offset = "0x68")]
		public static string[] typeExcludeTail;

		// Token: 0x0400B1D6 RID: 45526
		[Token(Token = "0x4008569")]
		[FieldOffset(Offset = "0x70")]
		public static string[] typeExcludeEye;

		// Token: 0x0400B1D7 RID: 45527
		[Token(Token = "0x400856A")]
		[FieldOffset(Offset = "0x78")]
		public static string[] pelvis;

		// Token: 0x0400B1D8 RID: 45528
		[Token(Token = "0x400856B")]
		[FieldOffset(Offset = "0x80")]
		public static string[] hand;

		// Token: 0x0400B1D9 RID: 45529
		[Token(Token = "0x400856C")]
		[FieldOffset(Offset = "0x88")]
		public static string[] foot;

		// Token: 0x02000C94 RID: 3220
		[Token(Token = "0x20013D0")]
		[Serializable]
		public enum BoneType
		{
			// Token: 0x0400B1DB RID: 45531
			[Token(Token = "0x401B8B2")]
			Unassigned,
			// Token: 0x0400B1DC RID: 45532
			[Token(Token = "0x401B8B3")]
			Spine,
			// Token: 0x0400B1DD RID: 45533
			[Token(Token = "0x401B8B4")]
			Head,
			// Token: 0x0400B1DE RID: 45534
			[Token(Token = "0x401B8B5")]
			Arm,
			// Token: 0x0400B1DF RID: 45535
			[Token(Token = "0x401B8B6")]
			Leg,
			// Token: 0x0400B1E0 RID: 45536
			[Token(Token = "0x401B8B7")]
			Tail,
			// Token: 0x0400B1E1 RID: 45537
			[Token(Token = "0x401B8B8")]
			Eye
		}

		// Token: 0x02000C95 RID: 3221
		[Token(Token = "0x20013D1")]
		[Serializable]
		public enum BoneSide
		{
			// Token: 0x0400B1E3 RID: 45539
			[Token(Token = "0x401B8BA")]
			Center,
			// Token: 0x0400B1E4 RID: 45540
			[Token(Token = "0x401B8BB")]
			Left,
			// Token: 0x0400B1E5 RID: 45541
			[Token(Token = "0x401B8BC")]
			Right
		}
	}
}
