using System;
using BehaviorDesigner.Runtime;
using Define;
using Il2CppDummyDll;

// Token: 0x02000163 RID: 355
[Token(Token = "0x2000117")]
[Attribute(Name = "TaskCategoryAttribute", RVA = "0x145740", Offset = "0x145841")]
[Serializable]
public class SharedFarmMonsterWorkState : SharedVariable<FarmMonsterWorkState>
{
	// Token: 0x0600075C RID: 1884 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600063B")]
	[Address(RVA = "0x1E36D00", Offset = "0x1E36E01", VA = "0x1E36D00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x0600075D RID: 1885 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600063C")]
	[Address(RVA = "0x1E36D90", Offset = "0x1E36E91", VA = "0x1E36D90")]
	public static implicit operator SharedFarmMonsterWorkState(FarmMonsterWorkState value)
	{
		return null;
	}

	// Token: 0x0600075E RID: 1886 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600063D")]
	[Address(RVA = "0x1E36E40", Offset = "0x1E36F41", VA = "0x1E36E40")]
	public SharedFarmMonsterWorkState()
	{
	}
}
