using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ActorReplace
{
	// Token: 0x020014E1 RID: 5345
	[Token(Token = "0x2000EA4")]
	[Serializable]
	public class ReplaceSound : ReplaceBase
	{
		// Token: 0x060079CC RID: 31180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600666E")]
		[Address(RVA = "0x1D53ED0", Offset = "0x1D53FD1", VA = "0x1D53ED0", Slot = "4")]
		public override void Copy(ReplaceBase replace)
		{
		}

		// Token: 0x060079CD RID: 31181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600666F")]
		[Address(RVA = "0x1D53FB0", Offset = "0x1D540B1", VA = "0x1D53FB0")]
		public void SetSoundId()
		{
		}

		// Token: 0x060079CE RID: 31182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006670")]
		[Address(RVA = "0x1D53EB0", Offset = "0x1D53FB1", VA = "0x1D53EB0")]
		public ReplaceSound()
		{
		}

		// Token: 0x0401BC91 RID: 113809
		[Token(Token = "0x4018683")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		public string soundName;

		// Token: 0x0401BC92 RID: 113810
		[Token(Token = "0x4018684")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		public SoundID soundId;
	}
}
