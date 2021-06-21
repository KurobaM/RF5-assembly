using System;
using DataTable;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020003D0 RID: 976
[Token(Token = "0x20002F2")]
[Serializable]
public class VoiceGroupDataTable
{
	// Token: 0x0600178F RID: 6031 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60014F3")]
	[Address(RVA = "0x1E4A6C0", Offset = "0x1E4A7C1", VA = "0x1E4A6C0")]
	public static VoiceGroupDataTable GetDataTable(VoiceGroup group)
	{
		return null;
	}

	// Token: 0x06001790 RID: 6032 RVA: 0x0000A440 File Offset: 0x00008640
	[Token(Token = "0x60014F4")]
	[Address(RVA = "0x1E4A860", Offset = "0x1E4A961", VA = "0x1E4A860")]
	public static bool HasDataTable(VoiceGroup group)
	{
		return default(bool);
	}

	// Token: 0x06001791 RID: 6033 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014F5")]
	[Address(RVA = "0x1E4A850", Offset = "0x1E4A951", VA = "0x1E4A850")]
	public VoiceGroupDataTable()
	{
	}

	// Token: 0x040010F3 RID: 4339
	[Token(Token = "0x4000D8F")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public VoiceGroupDataTable.GroupData Data;

	// Token: 0x040010F4 RID: 4340
	[Token(Token = "0x4000D90")]
	[FieldOffset(Offset = "0x0")]
	private static VoiceGroupDataTableArray _VoiceGroupDataTableArray;

	// Token: 0x020003D1 RID: 977
	[Token(Token = "0x2001067")]
	[Serializable]
	public class GroupData
	{
		// Token: 0x06001792 RID: 6034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D87")]
		[Address(RVA = "0x1E4A9A0", Offset = "0x1E4AAA1", VA = "0x1E4A9A0")]
		public GroupData()
		{
		}

		// Token: 0x040010F5 RID: 4341
		[Token(Token = "0x4018FD7")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		public float Priority;
	}
}
