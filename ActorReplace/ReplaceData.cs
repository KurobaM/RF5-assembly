using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

namespace ActorReplace
{
	// Token: 0x020014E0 RID: 5344
	[Token(Token = "0x2000EA3")]
	[Serializable]
	public class ReplaceData
	{
		// Token: 0x060079C7 RID: 31175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006669")]
		[Address(RVA = "0x1D53E80", Offset = "0x1D53F81", VA = "0x1D53E80")]
		public ReplaceData()
		{
		}

		// Token: 0x060079C8 RID: 31176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600666A")]
		[Address(RVA = "0x1D4E190", Offset = "0x1D4E291", VA = "0x1D4E190")]
		public void ResetReplaceClip(int count)
		{
		}

		// Token: 0x060079C9 RID: 31177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600666B")]
		[Address(RVA = "0x1D4E330", Offset = "0x1D4E431", VA = "0x1D4E330")]
		public void ResetReplaceAvator(int count)
		{
		}

		// Token: 0x060079CA RID: 31178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600666C")]
		[Address(RVA = "0x1D4E4D0", Offset = "0x1D4E5D1", VA = "0x1D4E4D0")]
		public void ResetReplaceSound(int count)
		{
		}

		// Token: 0x060079CB RID: 31179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600666D")]
		[Address(RVA = "0x1D4E670", Offset = "0x1D4E771", VA = "0x1D4E670")]
		public void ResetReplaceText(int count)
		{
		}

		// Token: 0x0401BC8A RID: 113802
		[Token(Token = "0x401867C")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		public ActorID actorID;

		// Token: 0x0401BC8B RID: 113803
		[Token(Token = "0x401867D")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		public CharID charID;

		// Token: 0x0401BC8C RID: 113804
		[Token(Token = "0x401867E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public PlayerGender playerLook;

		// Token: 0x0401BC8D RID: 113805
		[Token(Token = "0x401867F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		public ReplaceClip[] replaceClips;

		// Token: 0x0401BC8E RID: 113806
		[Token(Token = "0x4018680")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		public ReplaceAvator[] replaceAvators;

		// Token: 0x0401BC8F RID: 113807
		[Token(Token = "0x4018681")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		public ReplaceSound[] replaceSounds;

		// Token: 0x0401BC90 RID: 113808
		[Token(Token = "0x4018682")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		public ReplaceText[] replaceTexts;
	}
}
