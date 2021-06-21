using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ActorReplace
{
	// Token: 0x020014DC RID: 5340
	[Token(Token = "0x2000E9F")]
	[Serializable]
	public class ReplaceAvator : ReplaceBase
	{
		// Token: 0x060079C1 RID: 31169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006663")]
		[Address(RVA = "0x1D53C60", Offset = "0x1D53D61", VA = "0x1D53C60", Slot = "4")]
		public override void Copy(ReplaceBase replace)
		{
		}

		// Token: 0x060079C2 RID: 31170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006664")]
		[Address(RVA = "0x1D53D80", Offset = "0x1D53E81", VA = "0x1D53D80")]
		public ReplaceAvator()
		{
		}

		// Token: 0x0401BC82 RID: 113794
		[Token(Token = "0x4018674")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		public Avatar avatar;
	}
}
