using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ActorReplace
{
	// Token: 0x020014DE RID: 5342
	[Token(Token = "0x2000EA1")]
	[Serializable]
	public class ReplaceClip : ReplaceBase
	{
		// Token: 0x060079C5 RID: 31173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006667")]
		[Address(RVA = "0x1D53DA0", Offset = "0x1D53EA1", VA = "0x1D53DA0", Slot = "4")]
		public override void Copy(ReplaceBase replace)
		{
		}

		// Token: 0x060079C6 RID: 31174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006668")]
		[Address(RVA = "0x1D53E70", Offset = "0x1D53F71", VA = "0x1D53E70")]
		public ReplaceClip()
		{
		}

		// Token: 0x0401BC85 RID: 113797
		[Token(Token = "0x4018677")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		public AnimationClip animationClip;
	}
}
