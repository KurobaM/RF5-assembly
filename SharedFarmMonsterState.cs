using System;
using BehaviorDesigner.Runtime;
using Define;
using Il2CppDummyDll;

// Token: 0x02000162 RID: 354
[Token(Token = "0x2000116")]
[Attribute(Name = "TaskCategoryAttribute", RVA = "0x145700", Offset = "0x145801")]
[Serializable]
public class SharedFarmMonsterState : SharedVariable<FarmMonsterState>
{
	// Token: 0x06000759 RID: 1881 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000638")]
	[Address(RVA = "0x1E36B70", Offset = "0x1E36C71", VA = "0x1E36B70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x0600075A RID: 1882 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000639")]
	[Address(RVA = "0x1E36C00", Offset = "0x1E36D01", VA = "0x1E36C00")]
	public static implicit operator SharedFarmMonsterState(FarmMonsterState value)
	{
		return null;
	}

	// Token: 0x0600075B RID: 1883 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600063A")]
	[Address(RVA = "0x1E36CB0", Offset = "0x1E36DB1", VA = "0x1E36CB0")]
	public SharedFarmMonsterState()
	{
	}
}
