using System;
using Il2CppDummyDll;

namespace ActorReplace
{
	// Token: 0x020014DD RID: 5341
	[Token(Token = "0x2000EA0")]
	public abstract class ReplaceBase
	{
		// Token: 0x060079C3 RID: 31171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006665")]
		[Address(RVA = "0x1D53D30", Offset = "0x1D53E31", VA = "0x1D53D30", Slot = "4")]
		public virtual void Copy(ReplaceBase replace)
		{
		}

		// Token: 0x060079C4 RID: 31172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006666")]
		[Address(RVA = "0x1D53D90", Offset = "0x1D53E91", VA = "0x1D53D90")]
		protected ReplaceBase()
		{
		}

		// Token: 0x0401BC83 RID: 113795
		[Token(Token = "0x4018675")]
		[FieldOffset(Offset = "0x10")]
		public string ClipName;

		// Token: 0x0401BC84 RID: 113796
		[Token(Token = "0x4018676")]
		[FieldOffset(Offset = "0x18")]
		public string TrackName;
	}
}
