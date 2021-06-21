using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x02000C9A RID: 3226
	[Token(Token = "0x2000840")]
	public class Hierarchy
	{
		// Token: 0x0600530D RID: 21261 RVA: 0x0001B4E0 File Offset: 0x000196E0
		[Token(Token = "0x600452B")]
		[Address(RVA = "0x27D5B40", Offset = "0x27D5C41", VA = "0x27D5B40")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		// Token: 0x0600530E RID: 21262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600452C")]
		[Address(RVA = "0x27D5D30", Offset = "0x27D5E31", VA = "0x27D5D30")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		// Token: 0x0600530F RID: 21263 RVA: 0x0001B4F8 File Offset: 0x000196F8
		[Token(Token = "0x600452D")]
		[Address(RVA = "0x27D5BC0", Offset = "0x27D5CC1", VA = "0x27D5BC0")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		// Token: 0x06005310 RID: 21264 RVA: 0x0001B510 File Offset: 0x00019710
		[Token(Token = "0x600452E")]
		[Address(RVA = "0x27D5E60", Offset = "0x27D5F61", VA = "0x27D5E60")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		// Token: 0x06005311 RID: 21265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600452F")]
		[Address(RVA = "0x27D5F80", Offset = "0x27D6081", VA = "0x27D5F80")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		// Token: 0x06005312 RID: 21266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004530")]
		[Address(RVA = "0x27D6240", Offset = "0x27D6341", VA = "0x27D6240")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		// Token: 0x06005313 RID: 21267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004531")]
		[Address(RVA = "0x27D6360", Offset = "0x27D6461", VA = "0x27D6360")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		// Token: 0x06005314 RID: 21268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004532")]
		[Address(RVA = "0x27D65B0", Offset = "0x27D66B1", VA = "0x27D65B0")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		// Token: 0x06005315 RID: 21269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004533")]
		[Address(RVA = "0x27D6940", Offset = "0x27D6A41", VA = "0x27D6940")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		// Token: 0x06005316 RID: 21270 RVA: 0x0001B528 File Offset: 0x00019728
		[Token(Token = "0x6004534")]
		[Address(RVA = "0x27D6730", Offset = "0x27D6831", VA = "0x27D6730")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		// Token: 0x06005317 RID: 21271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004535")]
		[Address(RVA = "0x27D6B40", Offset = "0x27D6C41", VA = "0x27D6B40")]
		public Hierarchy()
		{
		}
	}
}
