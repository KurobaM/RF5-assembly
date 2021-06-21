using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace SandBox
{
	// Token: 0x02000EB7 RID: 3767
	[Token(Token = "0x20009A3")]
	public class TimelineToActionScriptExpoter : MonoBehaviour
	{
		// Token: 0x0600624E RID: 25166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600516F")]
		[Address(RVA = "0x1EF8860", Offset = "0x1EF8961", VA = "0x1EF8860")]
		public void Export()
		{
		}

		// Token: 0x0600624F RID: 25167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005170")]
		[Address(RVA = "0x1EF92B0", Offset = "0x1EF93B1", VA = "0x1EF92B0")]
		public TimelineToActionScriptExpoter()
		{
		}

		// Token: 0x0400C286 RID: 49798
		[Token(Token = "0x40091D4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private PlayableDirector _playableDirector;

		// Token: 0x02000EB8 RID: 3768
		[Token(Token = "0x2001480")]
		[Serializable]
		public class ActionScriptData
		{
			// Token: 0x06006250 RID: 25168 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007B8E")]
			[Address(RVA = "0x1EF91B0", Offset = "0x1EF92B1", VA = "0x1EF91B0")]
			public string GetStr()
			{
				return null;
			}

			// Token: 0x06006251 RID: 25169 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B8F")]
			[Address(RVA = "0x1EF91A0", Offset = "0x1EF92A1", VA = "0x1EF91A0")]
			public ActionScriptData()
			{
			}

			// Token: 0x0400C287 RID: 49799
			[Token(Token = "0x401BCBE")]
			[FieldOffset(Offset = "0x10")]
			public string Delta;

			// Token: 0x0400C288 RID: 49800
			[Token(Token = "0x401BCBF")]
			[FieldOffset(Offset = "0x18")]
			public ActionCommand Command;

			// Token: 0x0400C289 RID: 49801
			[Token(Token = "0x401BCC0")]
			[FieldOffset(Offset = "0x20")]
			public string var1;

			// Token: 0x0400C28A RID: 49802
			[Token(Token = "0x401BCC1")]
			[FieldOffset(Offset = "0x28")]
			public string var2;

			// Token: 0x0400C28B RID: 49803
			[Token(Token = "0x401BCC2")]
			[FieldOffset(Offset = "0x30")]
			public string var3;

			// Token: 0x0400C28C RID: 49804
			[Token(Token = "0x401BCC3")]
			[FieldOffset(Offset = "0x38")]
			public string var4;

			// Token: 0x0400C28D RID: 49805
			[Token(Token = "0x401BCC4")]
			[FieldOffset(Offset = "0x40")]
			public string var5;

			// Token: 0x0400C28E RID: 49806
			[Token(Token = "0x401BCC5")]
			[FieldOffset(Offset = "0x48")]
			public string var6;

			// Token: 0x0400C28F RID: 49807
			[Token(Token = "0x401BCC6")]
			[FieldOffset(Offset = "0x50")]
			public string var7;

			// Token: 0x0400C290 RID: 49808
			[Token(Token = "0x401BCC7")]
			[FieldOffset(Offset = "0x58")]
			public string var8;
		}
	}
}
