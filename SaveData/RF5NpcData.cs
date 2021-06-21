using System;
using System.Collections.Generic;
using BinaryStream;
using Define;
using Il2CppDummyDll;

namespace SaveData
{
	// Token: 0x02000ED7 RID: 3799
	[Token(Token = "0x20009B8")]
	public class RF5NpcData : SaveDataValueBase
	{
		// Token: 0x0600634C RID: 25420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600525D")]
		[Address(RVA = "0x1F03CE0", Offset = "0x1F03DE1", VA = "0x1F03CE0")]
		public RF5NpcData()
		{
		}

		// Token: 0x0600634D RID: 25421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600525E")]
		[Address(RVA = "0x1F03D10", Offset = "0x1F03E11", VA = "0x1F03D10", Slot = "4")]
		public override void Initialize()
		{
		}

		// Token: 0x0600634E RID: 25422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600525F")]
		[Address(RVA = "0x1F03FF0", Offset = "0x1F040F1", VA = "0x1F03FF0", Slot = "5")]
		public override void BeforeSave()
		{
		}

		// Token: 0x0600634F RID: 25423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005260")]
		[Address(RVA = "0x1F040A0", Offset = "0x1F041A1", VA = "0x1F040A0", Slot = "6")]
		public override void AfterLoad()
		{
		}

		// Token: 0x06006350 RID: 25424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005261")]
		[Address(RVA = "0x1F040B0", Offset = "0x1F041B1", VA = "0x1F040B0", Slot = "7")]
		public override void Writer(BinaryWriter writer)
		{
		}

		// Token: 0x06006351 RID: 25425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005262")]
		[Address(RVA = "0x1F044A0", Offset = "0x1F045A1", VA = "0x1F044A0")]
		public void Reader0000(BinaryReader reader)
		{
		}

		// Token: 0x0400C32F RID: 49967
		[Token(Token = "0x400923E")]
		[FieldOffset(Offset = "0x10")]
		public List<NpcSaveParameter> NpcSaveParameters;

		// Token: 0x0400C330 RID: 49968
		[Token(Token = "0x400923F")]
		[FieldOffset(Offset = "0x18")]
		public NpcDateSaveParameter NpcDateSaveParam;

		// Token: 0x0400C331 RID: 49969
		[Token(Token = "0x4009240")]
		[FieldOffset(Offset = "0x20")]
		public ChildSaveData ChildSaveDatas;

		// Token: 0x0400C332 RID: 49970
		[Token(Token = "0x4009241")]
		[FieldOffset(Offset = "0x28")]
		public GiveBirthSaveParameter GiveBirthParams;

		// Token: 0x0400C333 RID: 49971
		[Token(Token = "0x4009242")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<ActorID, ItemStorageData> NpcHatCache;
	}
}
