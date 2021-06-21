using System;
using Define;
using Il2CppDummyDll;

namespace RF5UI
{
	// Token: 0x02000E9B RID: 3739
	[Token(Token = "0x2000994")]
	public class MakingTable
	{
		// Token: 0x060061D3 RID: 25043 RVA: 0x00020CB8 File Offset: 0x0001EEB8
		[Token(Token = "0x6005101")]
		[Address(RVA = "0x1F26D50", Offset = "0x1F26E51", VA = "0x1F26D50")]
		public int GetNeed(int id, MakingTable.NeedType type)
		{
			return 0;
		}

		// Token: 0x060061D4 RID: 25044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005102")]
		[Address(RVA = "0x1F26DB0", Offset = "0x1F26EB1", VA = "0x1F26DB0")]
		public MakingTable()
		{
		}

		// Token: 0x0400C182 RID: 49538
		[Token(Token = "0x4009115")]
		[FieldOffset(Offset = "0x10")]
		public readonly string[] EndScriptFesCancel;

		// Token: 0x0400C183 RID: 49539
		[Token(Token = "0x4009116")]
		[FieldOffset(Offset = "0x18")]
		public readonly string[] EndScriptTable;

		// Token: 0x0400C184 RID: 49540
		[Token(Token = "0x4009117")]
		[FieldOffset(Offset = "0x20")]
		public readonly int[,] MakingNeeds;

		// Token: 0x0400C185 RID: 49541
		[Token(Token = "0x4009118")]
		[FieldOffset(Offset = "0x28")]
		public readonly MakingID[] LicenseTable;

		// Token: 0x0400C186 RID: 49542
		[Token(Token = "0x4009119")]
		[FieldOffset(Offset = "0x30")]
		public readonly MakingID[] FestivalTable;

		// Token: 0x0400C187 RID: 49543
		[Token(Token = "0x400911A")]
		[FieldOffset(Offset = "0x38")]
		public readonly MakingID[] OtherTable;

		// Token: 0x0400C188 RID: 49544
		[Token(Token = "0x400911B")]
		[FieldOffset(Offset = "0x40")]
		public readonly MakingID[] DevelopTable;

		// Token: 0x0400C189 RID: 49545
		[Token(Token = "0x400911C")]
		[FieldOffset(Offset = "0x48")]
		public readonly MakingID[] ExtraTable;

		// Token: 0x0400C18A RID: 49546
		[Token(Token = "0x400911D")]
		[FieldOffset(Offset = "0x50")]
		public readonly MakingID[] VillaTable;

		// Token: 0x0400C18B RID: 49547
		[Token(Token = "0x400911E")]
		[FieldOffset(Offset = "0x58")]
		public readonly string[,] MakingTopicText;

		// Token: 0x02000E9C RID: 3740
		[Token(Token = "0x2001473")]
		public enum NeedType
		{
			// Token: 0x0400C18D RID: 49549
			[Token(Token = "0x401BC7A")]
			SeedPoint,
			// Token: 0x0400C18E RID: 49550
			[Token(Token = "0x401BC7B")]
			Lumber,
			// Token: 0x0400C18F RID: 49551
			[Token(Token = "0x401BC7C")]
			Stone,
			// Token: 0x0400C190 RID: 49552
			[Token(Token = "0x401BC7D")]
			Gold,
			// Token: 0x0400C191 RID: 49553
			[Token(Token = "0x401BC7E")]
			Max
		}
	}
}
