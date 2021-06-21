using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using nn.account;

namespace nn.ec
{
	// Token: 0x020015D9 RID: 5593
	[Token(Token = "0x2000F61")]
	public struct PurchasedItemInfo
	{
		// Token: 0x06007F54 RID: 32596 RVA: 0x0002D9A8 File Offset: 0x0002BBA8
		[Token(Token = "0x60069B9")]
		[Address(RVA = "0x364890", Offset = "0x364991", VA = "0x364890")]
		public CourseId GetCourseId()
		{
			return default(CourseId);
		}

		// Token: 0x06007F55 RID: 32597
		[Token(Token = "0x60069BA")]
		[Address(RVA = "0x2853E60", Offset = "0x2853F61", VA = "0x2853E60")]
		[PreserveSig]
		private static extern CourseId GetCourseId(PurchasedItemInfo info);

		// Token: 0x0401C144 RID: 115012
		[Token(Token = "0x401898B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public PurchasedItemInfo.Type type;

		// Token: 0x0401C145 RID: 115013
		[Token(Token = "0x401898C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public NetworkServiceAccountId nsaId;

		// Token: 0x0401C146 RID: 115014
		[Token(Token = "0x401898D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal CourseId _courseId;

		// Token: 0x020015DA RID: 5594
		[Token(Token = "0x20015CA")]
		public enum Type
		{
			// Token: 0x0401C148 RID: 115016
			[Token(Token = "0x401C378")]
			Subscription,
			// Token: 0x0401C149 RID: 115017
			[Token(Token = "0x401C379")]
			Consumable
		}
	}
}
