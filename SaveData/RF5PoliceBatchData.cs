using System;
using BinaryStream;
using Define;
using Il2CppDummyDll;

namespace SaveData
{
	// Token: 0x02000EDA RID: 3802
	[Token(Token = "0x20009BB")]
	public class RF5PoliceBatchData : SaveDataValueBase
	{
		// Token: 0x06006365 RID: 25445 RVA: 0x00021528 File Offset: 0x0001F728
		[Token(Token = "0x6005276")]
		[Address(RVA = "0x1F05B50", Offset = "0x1F05C51", VA = "0x1F05B50")]
		public bool GetSaveFlag(RF5PoliceBatchData.FLAG id)
		{
			return default(bool);
		}

		// Token: 0x06006366 RID: 25446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005277")]
		[Address(RVA = "0x1F05B70", Offset = "0x1F05C71", VA = "0x1F05B70")]
		public void SetSaveFlag(RF5PoliceBatchData.FLAG id, bool value)
		{
		}

		// Token: 0x06006367 RID: 25447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005278")]
		[Address(RVA = "0x1F05B90", Offset = "0x1F05C91", VA = "0x1F05B90")]
		public RF5PoliceBatchData()
		{
		}

		// Token: 0x06006368 RID: 25448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005279")]
		[Address(RVA = "0x1F05C20", Offset = "0x1F05D21", VA = "0x1F05C20", Slot = "4")]
		public override void Initialize()
		{
		}

		// Token: 0x06006369 RID: 25449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600527A")]
		[Address(RVA = "0x1F05C40", Offset = "0x1F05D41", VA = "0x1F05C40", Slot = "5")]
		public override void BeforeSave()
		{
		}

		// Token: 0x0600636A RID: 25450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600527B")]
		[Address(RVA = "0x1F05C50", Offset = "0x1F05D51", VA = "0x1F05C50", Slot = "6")]
		public override void AfterLoad()
		{
		}

		// Token: 0x0600636B RID: 25451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600527C")]
		[Address(RVA = "0x1F05C60", Offset = "0x1F05D61", VA = "0x1F05C60", Slot = "7")]
		public override void Writer(BinaryWriter writer)
		{
		}

		// Token: 0x0600636C RID: 25452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600527D")]
		[Address(RVA = "0x1F05CC0", Offset = "0x1F05DC1", VA = "0x1F05CC0")]
		public void Reader0000(BinaryReader reader)
		{
		}

		// Token: 0x0400C34A RID: 49994
		[Token(Token = "0x4009259")]
		[FieldOffset(Offset = "0x10")]
		public PoliceBatchId policeBatchIdSlotA;

		// Token: 0x0400C34B RID: 49995
		[Token(Token = "0x400925A")]
		[FieldOffset(Offset = "0x14")]
		public PoliceBatchId policeBatchIdSlotB;

		// Token: 0x0400C34C RID: 49996
		[Token(Token = "0x400925B")]
		[FieldOffset(Offset = "0x18")]
		public SaveFlagStorage SaveFlag;

		// Token: 0x02000EDB RID: 3803
		[Token(Token = "0x200148B")]
		public enum FLAG
		{
			// Token: 0x0400C34E RID: 49998
			[Token(Token = "0x401BCFE")]
			PoliceBatch_1,
			// Token: 0x0400C34F RID: 49999
			[Token(Token = "0x401BCFF")]
			PoliceBatch_2,
			// Token: 0x0400C350 RID: 50000
			[Token(Token = "0x401BD00")]
			PoliceBatch_3,
			// Token: 0x0400C351 RID: 50001
			[Token(Token = "0x401BD01")]
			PoliceBatch_4,
			// Token: 0x0400C352 RID: 50002
			[Token(Token = "0x401BD02")]
			PoliceBatch_5,
			// Token: 0x0400C353 RID: 50003
			[Token(Token = "0x401BD03")]
			PoliceBatch_6,
			// Token: 0x0400C354 RID: 50004
			[Token(Token = "0x401BD04")]
			PoliceBatch_7,
			// Token: 0x0400C355 RID: 50005
			[Token(Token = "0x401BD05")]
			PoliceBatch_8,
			// Token: 0x0400C356 RID: 50006
			[Token(Token = "0x401BD06")]
			PoliceBatch_9,
			// Token: 0x0400C357 RID: 50007
			[Token(Token = "0x401BD07")]
			PoliceBatch_10,
			// Token: 0x0400C358 RID: 50008
			[Token(Token = "0x401BD08")]
			Length
		}
	}
}
