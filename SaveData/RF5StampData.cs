using System;
using BinaryStream;
using Il2CppDummyDll;

namespace SaveData
{
	// Token: 0x02000EDF RID: 3807
	[Token(Token = "0x20009BE")]
	public class RF5StampData : SaveDataValueBase
	{
		// Token: 0x0600637F RID: 25471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005290")]
		[Address(RVA = "0x1EF7100", Offset = "0x1EF7201", VA = "0x1EF7100")]
		public void ReleaseNewStamp(StampEnum _stamp)
		{
		}

		// Token: 0x06006380 RID: 25472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005291")]
		[Address(RVA = "0x1F081A0", Offset = "0x1F082A1", VA = "0x1F081A0")]
		public void ReleaseNewStamp(StampEnum _stamp, float _record, StampLevel _stamp_level)
		{
		}

		// Token: 0x06006381 RID: 25473 RVA: 0x00021558 File Offset: 0x0001F758
		[Token(Token = "0x6005292")]
		[Address(RVA = "0x1EF70B0", Offset = "0x1EF71B1", VA = "0x1EF70B0")]
		public bool IsStampReleased(StampEnum _stamp)
		{
			return default(bool);
		}

		// Token: 0x06006382 RID: 25474 RVA: 0x00021570 File Offset: 0x0001F770
		[Token(Token = "0x6005293")]
		[Address(RVA = "0x1F08270", Offset = "0x1F08371", VA = "0x1F08270")]
		public bool IsAnyStampReleased()
		{
			return default(bool);
		}

		// Token: 0x06006383 RID: 25475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005294")]
		[Address(RVA = "0x1F082F0", Offset = "0x1F083F1", VA = "0x1F082F0")]
		public StampRecordData GetStampRecord(StampEnum _stamp)
		{
			return null;
		}

		// Token: 0x06006384 RID: 25476 RVA: 0x00021588 File Offset: 0x0001F788
		[Token(Token = "0x6005295")]
		[Address(RVA = "0x1F08330", Offset = "0x1F08431", VA = "0x1F08330")]
		public int GetStampProgress()
		{
			return 0;
		}

		// Token: 0x06006385 RID: 25477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005296")]
		[Address(RVA = "0x1F05E50", Offset = "0x1F05F51", VA = "0x1F05E50")]
		public RF5StampData()
		{
		}

		// Token: 0x06006386 RID: 25478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005297")]
		[Address(RVA = "0x1F083B0", Offset = "0x1F084B1", VA = "0x1F083B0", Slot = "4")]
		public override void Initialize()
		{
		}

		// Token: 0x06006387 RID: 25479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005298")]
		[Address(RVA = "0x1F084C0", Offset = "0x1F085C1", VA = "0x1F084C0", Slot = "5")]
		public override void BeforeSave()
		{
		}

		// Token: 0x06006388 RID: 25480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005299")]
		[Address(RVA = "0x1F084D0", Offset = "0x1F085D1", VA = "0x1F084D0", Slot = "6")]
		public override void AfterLoad()
		{
		}

		// Token: 0x06006389 RID: 25481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600529A")]
		[Address(RVA = "0x1F084E0", Offset = "0x1F085E1", VA = "0x1F084E0", Slot = "7")]
		public override void Writer(BinaryWriter writer)
		{
		}

		// Token: 0x0600638A RID: 25482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600529B")]
		[Address(RVA = "0x1F06EA0", Offset = "0x1F06FA1", VA = "0x1F06EA0")]
		public void Reader0000(BinaryReader reader)
		{
		}

		// Token: 0x0400C385 RID: 50053
		[Token(Token = "0x400927A")]
		[FieldOffset(Offset = "0x10")]
		public StampRecordData[] StampRecordData;
	}
}
