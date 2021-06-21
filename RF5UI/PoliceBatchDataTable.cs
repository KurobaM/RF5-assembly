using System;
using Define;
using Il2CppDummyDll;
using SaveData;

namespace RF5UI
{
	// Token: 0x02000EA0 RID: 3744
	[Token(Token = "0x2000997")]
	public class PoliceBatchDataTable
	{
		// Token: 0x060061E3 RID: 25059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005111")]
		[Address(RVA = "0x1F29C40", Offset = "0x1F29D41", VA = "0x1F29C40")]
		public static void SetFlag(bool value, PoliceBatchId policeBatchId)
		{
		}

		// Token: 0x060061E4 RID: 25060 RVA: 0x00020CE8 File Offset: 0x0001EEE8
		[Token(Token = "0x6005112")]
		[Address(RVA = "0x1F29D00", Offset = "0x1F29E01", VA = "0x1F29D00")]
		public static bool GetFlag(PoliceBatchId policeBatchId)
		{
			return default(bool);
		}

		// Token: 0x060061E5 RID: 25061 RVA: 0x00020D00 File Offset: 0x0001EF00
		[Token(Token = "0x6005113")]
		[Address(RVA = "0x1F29DC0", Offset = "0x1F29EC1", VA = "0x1F29DC0")]
		public static bool GetAny()
		{
			return default(bool);
		}

		// Token: 0x060061E6 RID: 25062 RVA: 0x00020D18 File Offset: 0x0001EF18
		[Token(Token = "0x6005114")]
		[Address(RVA = "0x1F29FA0", Offset = "0x1F2A0A1", VA = "0x1F29FA0")]
		public static bool CheckEquiped(PoliceBatchId id)
		{
			return default(bool);
		}

		// Token: 0x060061E7 RID: 25063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005115")]
		[Address(RVA = "0x1F2A000", Offset = "0x1F2A101", VA = "0x1F2A000")]
		public static void DoBatchChanged(PoliceBatchId policeBatchId)
		{
		}

		// Token: 0x060061E8 RID: 25064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005116")]
		[Address(RVA = "0x1F2A080", Offset = "0x1F2A181", VA = "0x1F2A080")]
		public static void DoBatchCancel(PoliceBatchId policeBatchId)
		{
		}

		// Token: 0x060061E9 RID: 25065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005117")]
		[Address(RVA = "0x1F2A100", Offset = "0x1F2A201", VA = "0x1F2A100")]
		public PoliceBatchDataTable()
		{
		}

		// Token: 0x0400C1A4 RID: 49572
		[Token(Token = "0x400912B")]
		[FieldOffset(Offset = "0x0")]
		public static readonly RF5PoliceBatchData.FLAG[] FlagIds;

		// Token: 0x0400C1A5 RID: 49573
		[Token(Token = "0x400912C")]
		[FieldOffset(Offset = "0x8")]
		public static readonly string[] NameTextId;

		// Token: 0x0400C1A6 RID: 49574
		[Token(Token = "0x400912D")]
		[FieldOffset(Offset = "0x10")]
		public static readonly string[] DiscriptTextId;
	}
}
