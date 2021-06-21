using System;
using System.Collections.Generic;
using DataTable;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000375 RID: 885
[Token(Token = "0x20002A1")]
[Serializable]
public class FootStepDataTable
{
	// Token: 0x060016C6 RID: 5830 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001437")]
	[Address(RVA = "0x1ECD7E0", Offset = "0x1ECD8E1", VA = "0x1ECD7E0")]
	public static FootStepDataTable GetDataTable(FootStepType type)
	{
		return null;
	}

	// Token: 0x060016C7 RID: 5831 RVA: 0x0000A110 File Offset: 0x00008310
	[Token(Token = "0x6001438")]
	[Address(RVA = "0x1ECD980", Offset = "0x1ECDA81", VA = "0x1ECD980")]
	public static bool HasDataTable(FootStepType type)
	{
		return default(bool);
	}

	// Token: 0x060016C8 RID: 5832 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001439")]
	[Address(RVA = "0x1ECDAC0", Offset = "0x1ECDBC1", VA = "0x1ECDAC0")]
	public static SerializeFootStepDataTable[] GetDataTables()
	{
		return null;
	}

	// Token: 0x060016C9 RID: 5833 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600143A")]
	[Address(RVA = "0x1ECD970", Offset = "0x1ECDA71", VA = "0x1ECD970")]
	public FootStepDataTable()
	{
	}

	// Token: 0x04000F25 RID: 3877
	[Token(Token = "0x4000BED")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public FootStepGroupDataTableArray Group;

	// Token: 0x04000F26 RID: 3878
	[Token(Token = "0x4000BEE")]
	[FieldOffset(Offset = "0x0")]
	private static FootStepDataTableArray _FootStepDataTableArray;

	// Token: 0x02000376 RID: 886
	[Token(Token = "0x200105D")]
	[Serializable]
	public class GroupDataTable
	{
		// Token: 0x060016CA RID: 5834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D7A")]
		[Address(RVA = "0x1ECDBE0", Offset = "0x1ECDCE1", VA = "0x1ECDBE0")]
		public GroupDataTable()
		{
		}

		// Token: 0x04000F27 RID: 3879
		[Token(Token = "0x4018FAB")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		public EffectID stepEffectID;

		// Token: 0x04000F28 RID: 3880
		[Token(Token = "0x4018FAC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public List<SoundID> stepSoundIDList;

		// Token: 0x04000F29 RID: 3881
		[Token(Token = "0x4018FAD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		public EffectID landingEffectID;

		// Token: 0x04000F2A RID: 3882
		[Token(Token = "0x4018FAE")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		public SoundID landingSoundID;

		// Token: 0x04000F2B RID: 3883
		[Token(Token = "0x4018FAF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		public EffectID slideEffectID;

		// Token: 0x04000F2C RID: 3884
		[Token(Token = "0x4018FB0")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		public SoundID slideSoundID;
	}
}
