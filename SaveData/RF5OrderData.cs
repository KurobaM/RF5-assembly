using System;
using System.Collections.Generic;
using BinaryStream;
using Il2CppDummyDll;
using RF5WANTED;

namespace SaveData
{
	// Token: 0x02000ED8 RID: 3800
	[Token(Token = "0x20009B9")]
	public class RF5OrderData : SaveDataValueBase
	{
		// Token: 0x06006352 RID: 25426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005263")]
		[Address(RVA = "0x1F051C0", Offset = "0x1F052C1", VA = "0x1F051C0")]
		public RF5OrderData()
		{
		}

		// Token: 0x06006353 RID: 25427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005264")]
		[Address(RVA = "0x1F051F0", Offset = "0x1F052F1", VA = "0x1F051F0", Slot = "4")]
		public override void Initialize()
		{
		}

		// Token: 0x06006354 RID: 25428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005265")]
		[Address(RVA = "0x1F05200", Offset = "0x1F05301", VA = "0x1F05200", Slot = "5")]
		public override void BeforeSave()
		{
		}

		// Token: 0x06006355 RID: 25429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005266")]
		[Address(RVA = "0x1F05260", Offset = "0x1F05361", VA = "0x1F05260", Slot = "6")]
		public override void AfterLoad()
		{
		}

		// Token: 0x06006356 RID: 25430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005267")]
		[Address(RVA = "0x1F05310", Offset = "0x1F05411", VA = "0x1F05310", Slot = "7")]
		public override void Writer(BinaryWriter writer)
		{
		}

		// Token: 0x06006357 RID: 25431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005268")]
		[Address(RVA = "0x1F053C0", Offset = "0x1F054C1", VA = "0x1F053C0")]
		public void Reader0000(BinaryReader reader)
		{
		}

		// Token: 0x06006358 RID: 25432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005269")]
		private void _writer<T>(BinaryWriter writer, T data) where T : new()
		{
		}

		// Token: 0x06006359 RID: 25433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600526A")]
		private void _writer_array<T>(BinaryWriter writer, IReadOnlyList<T> data) where T : new()
		{
		}

		// Token: 0x0600635A RID: 25434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600526B")]
		private T _reader<T>(BinaryReader reader) where T : new()
		{
			return null;
		}

		// Token: 0x0600635B RID: 25435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600526C")]
		private T[] _reader_array<T>(BinaryReader reader) where T : new()
		{
			return null;
		}

		// Token: 0x0400C334 RID: 49972
		[Token(Token = "0x4009243")]
		[FieldOffset(Offset = "0x10")]
		public OrderSaveData OrderSaveParameters;

		// Token: 0x0400C335 RID: 49973
		[Token(Token = "0x4009244")]
		[FieldOffset(Offset = "0x38")]
		public WantedSaveData WantedSaveData;
	}
}
