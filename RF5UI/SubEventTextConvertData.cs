using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RF5UI
{
	// Token: 0x02000E8A RID: 3722
	[Token(Token = "0x2000989")]
	[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x149720", Offset = "0x149821")]
	[Serializable]
	public class SubEventTextConvertData : ScriptableObject
	{
		// Token: 0x06006165 RID: 24933 RVA: 0x00020B50 File Offset: 0x0001ED50
		[Token(Token = "0x60050A2")]
		[Address(RVA = "0x1F2B5F0", Offset = "0x1F2B6F1", VA = "0x1F2B5F0")]
		private int GetNowProgress(int progressId)
		{
			return 0;
		}

		// Token: 0x06006166 RID: 24934 RVA: 0x00020B68 File Offset: 0x0001ED68
		[Token(Token = "0x60050A3")]
		[Address(RVA = "0x1F2B7F0", Offset = "0x1F2B8F1", VA = "0x1F2B7F0")]
		public int GetTextId(int progressId)
		{
			return 0;
		}

		// Token: 0x06006167 RID: 24935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050A4")]
		[Address(RVA = "0x1F2B870", Offset = "0x1F2B971", VA = "0x1F2B870")]
		public string GetTopicText(int textId)
		{
			return null;
		}

		// Token: 0x06006168 RID: 24936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050A5")]
		[Address(RVA = "0x1F2B9D0", Offset = "0x1F2BAD1", VA = "0x1F2B9D0")]
		public string GetDetailText(int textId)
		{
			return null;
		}

		// Token: 0x06006169 RID: 24937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050A6")]
		[Address(RVA = "0x1F2BB30", Offset = "0x1F2BC31", VA = "0x1F2BB30")]
		public SubEventTextConvertData()
		{
		}

		// Token: 0x0400C10F RID: 49423
		[Token(Token = "0x40090B0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public int[] GameFlagID;

		// Token: 0x0400C110 RID: 49424
		[Token(Token = "0x40090B1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		public int[] Number;

		// Token: 0x0400C111 RID: 49425
		[Token(Token = "0x40090B2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		public int[] STEP;

		// Token: 0x0400C112 RID: 49426
		[Token(Token = "0x40090B3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		public int[] TextID;

		// Token: 0x02000E8B RID: 3723
		[Token(Token = "0x200146D")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1599E0", Offset = "0x159AE1")]
		private sealed class <>c__DisplayClass4_0
		{
			// Token: 0x0600616A RID: 24938 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B72")]
			[Address(RVA = "0x1F2B7E0", Offset = "0x1F2B8E1", VA = "0x1F2B7E0")]
			public <>c__DisplayClass4_0()
			{
			}

			// Token: 0x0600616B RID: 24939 RVA: 0x00020B80 File Offset: 0x0001ED80
			[Token(Token = "0x6007B73")]
			[Address(RVA = "0x1F2BB40", Offset = "0x1F2BC41", VA = "0x1F2BB40")]
			internal bool <GetNowProgress>b__0(int a)
			{
				return default(bool);
			}

			// Token: 0x0400C113 RID: 49427
			[Token(Token = "0x401BC6B")]
			[FieldOffset(Offset = "0x10")]
			public int progressId;
		}
	}
}
