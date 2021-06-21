using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

namespace RF5UI
{
	// Token: 0x02000E86 RID: 3718
	[Token(Token = "0x2000986")]
	[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x1496F0", Offset = "0x1497F1")]
	[Serializable]
	public class LoveEventTextConvertData : ScriptableObject
	{
		// Token: 0x06006156 RID: 24918 RVA: 0x00020AC0 File Offset: 0x0001ECC0
		[Token(Token = "0x6005095")]
		[Address(RVA = "0x21835F0", Offset = "0x21836F1", VA = "0x21835F0")]
		public int GetIndex(GameFlagData gameFlagData)
		{
			return 0;
		}

		// Token: 0x06006157 RID: 24919 RVA: 0x00020AD8 File Offset: 0x0001ECD8
		[Token(Token = "0x6005096")]
		[Address(RVA = "0x21836F0", Offset = "0x21837F1", VA = "0x21836F0")]
		public int GetNPCID(GameFlagData GameFlagId)
		{
			return 0;
		}

		// Token: 0x06006158 RID: 24920 RVA: 0x00020AF0 File Offset: 0x0001ECF0
		[Token(Token = "0x6005097")]
		[Address(RVA = "0x2183740", Offset = "0x2183841", VA = "0x2183740")]
		public int GetNowProgress()
		{
			return 0;
		}

		// Token: 0x06006159 RID: 24921 RVA: 0x00020B08 File Offset: 0x0001ED08
		[Token(Token = "0x6005098")]
		[Address(RVA = "0x21838B0", Offset = "0x21839B1", VA = "0x21838B0")]
		public int GetTextId(int progressId)
		{
			return 0;
		}

		// Token: 0x0600615A RID: 24922 RVA: 0x00020B20 File Offset: 0x0001ED20
		[Token(Token = "0x6005099")]
		[Address(RVA = "0x2183910", Offset = "0x2183A11", VA = "0x2183910")]
		public int GetCharaID(int progressId)
		{
			return 0;
		}

		// Token: 0x0600615B RID: 24923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600509A")]
		[Address(RVA = "0x2183950", Offset = "0x2183A51", VA = "0x2183950")]
		public string GetTopicText(int progressId)
		{
			return null;
		}

		// Token: 0x0600615C RID: 24924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600509B")]
		[Address(RVA = "0x2183AE0", Offset = "0x2183BE1", VA = "0x2183AE0")]
		public string GetDetailText(int progressId)
		{
			return null;
		}

		// Token: 0x0600615D RID: 24925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600509C")]
		[Address(RVA = "0x2183C70", Offset = "0x2183D71", VA = "0x2183C70")]
		public LoveEventTextConvertData()
		{
		}

		// Token: 0x0400C107 RID: 49415
		[Token(Token = "0x40090A9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public int[] CharaID;

		// Token: 0x0400C108 RID: 49416
		[Token(Token = "0x40090AA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		public int[] GameFlagID;

		// Token: 0x0400C109 RID: 49417
		[Token(Token = "0x40090AB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		public int[] Number;

		// Token: 0x0400C10A RID: 49418
		[Token(Token = "0x40090AC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		public int[] STEP;

		// Token: 0x0400C10B RID: 49419
		[Token(Token = "0x40090AD")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		public int[] TextID;

		// Token: 0x02000E87 RID: 3719
		[Token(Token = "0x200146C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1599D0", Offset = "0x159AD1")]
		private sealed class <>c__DisplayClass5_0
		{
			// Token: 0x0600615E RID: 24926 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B70")]
			[Address(RVA = "0x21836E0", Offset = "0x21837E1", VA = "0x21836E0")]
			public <>c__DisplayClass5_0()
			{
			}

			// Token: 0x0600615F RID: 24927 RVA: 0x00020B38 File Offset: 0x0001ED38
			[Token(Token = "0x6007B71")]
			[Address(RVA = "0x2183C80", Offset = "0x2183D81", VA = "0x2183C80")]
			internal bool <GetIndex>b__0(int a)
			{
				return default(bool);
			}

			// Token: 0x0400C10C RID: 49420
			[Token(Token = "0x401BC6A")]
			[FieldOffset(Offset = "0x10")]
			public int findid;
		}
	}
}
