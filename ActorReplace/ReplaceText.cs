using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ActorReplace
{
	// Token: 0x020014E2 RID: 5346
	[Token(Token = "0x2000EA5")]
	[Serializable]
	public class ReplaceText : ReplaceBase
	{
		// Token: 0x060079CF RID: 31183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006671")]
		[Address(RVA = "0x1D54060", Offset = "0x1D54161", VA = "0x1D54060", Slot = "4")]
		public override void Copy(ReplaceBase replace)
		{
		}

		// Token: 0x060079D0 RID: 31184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006672")]
		[Address(RVA = "0x1D53EC0", Offset = "0x1D53FC1", VA = "0x1D53EC0")]
		public ReplaceText()
		{
		}

		// Token: 0x0401BC93 RID: 113811
		[Token(Token = "0x4018685")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		public string TextId;
	}
}
