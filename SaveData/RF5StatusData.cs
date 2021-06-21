using System;
using System.Collections.Generic;
using BinaryStream;
using Define;
using Il2CppDummyDll;

namespace SaveData
{
	// Token: 0x02000EE0 RID: 3808
	[Token(Token = "0x20009BF")]
	public class RF5StatusData : SaveDataValueBase
	{
		// Token: 0x17000CCA RID: 3274
		// (get) Token: 0x0600638B RID: 25483 RVA: 0x000215A0 File Offset: 0x0001F7A0
		[Token(Token = "0x17000A0C")]
		public int PlayerLevel
		{
			[Token(Token = "0x600529C")]
			[Address(RVA = "0x1F085D0", Offset = "0x1F086D1", VA = "0x1F085D0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600638C RID: 25484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600529D")]
		[Address(RVA = "0x1F05ED0", Offset = "0x1F05FD1", VA = "0x1F05ED0")]
		public RF5StatusData()
		{
		}

		// Token: 0x0600638D RID: 25485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600529E")]
		[Address(RVA = "0x1F08640", Offset = "0x1F08741", VA = "0x1F08640", Slot = "4")]
		public override void Initialize()
		{
		}

		// Token: 0x0600638E RID: 25486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600529F")]
		[Address(RVA = "0x1F087D0", Offset = "0x1F088D1", VA = "0x1F087D0")]
		public void InitializeForNewGame()
		{
		}

		// Token: 0x0600638F RID: 25487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052A0")]
		[Address(RVA = "0x1F08DB0", Offset = "0x1F08EB1", VA = "0x1F08DB0", Slot = "5")]
		public override void BeforeSave()
		{
		}

		// Token: 0x06006390 RID: 25488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052A1")]
		[Address(RVA = "0x1F08DC0", Offset = "0x1F08EC1", VA = "0x1F08DC0", Slot = "6")]
		public override void AfterLoad()
		{
		}

		// Token: 0x06006391 RID: 25489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052A2")]
		[Address(RVA = "0x1F08DD0", Offset = "0x1F08ED1", VA = "0x1F08DD0", Slot = "7")]
		public override void Writer(BinaryWriter writer)
		{
		}

		// Token: 0x06006392 RID: 25490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052A3")]
		[Address(RVA = "0x1F06FA0", Offset = "0x1F070A1", VA = "0x1F06FA0")]
		public void Reader0000(BinaryReader reader)
		{
		}

		// Token: 0x0400C386 RID: 50054
		[Token(Token = "0x400927B")]
		[FieldOffset(Offset = "0x10")]
		public readonly Dictionary<ActorID, HumanStatusData> HumanStatusDatas;

		// Token: 0x0400C387 RID: 50055
		[Token(Token = "0x400927C")]
		[FieldOffset(Offset = "0x18")]
		public readonly List<FriendMonsterStatusData> FriendMonsterStatusDatas;

		// Token: 0x0400C388 RID: 50056
		[Token(Token = "0x400927D")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ActorID[] SaveActors;

		// Token: 0x0400C389 RID: 50057
		[Token(Token = "0x400927E")]
		[FieldOffset(Offset = "0x8")]
		private static readonly ActorID[] ReadActors_000;
	}
}
