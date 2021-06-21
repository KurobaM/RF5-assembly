using System;
using BehaviorDesigner.Runtime;
using Define;
using Il2CppDummyDll;

// Token: 0x02000161 RID: 353
[Token(Token = "0x2000115")]
[Attribute(Name = "TaskCategoryAttribute", RVA = "0x1456C0", Offset = "0x1457C1")]
[Serializable]
public class SharedFarmMonsterHutState : SharedVariable<FarmMonsterHutState>
{
	// Token: 0x06000756 RID: 1878 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000635")]
	[Address(RVA = "0x1E369E0", Offset = "0x1E36AE1", VA = "0x1E369E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06000757 RID: 1879 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000636")]
	[Address(RVA = "0x1E36A70", Offset = "0x1E36B71", VA = "0x1E36A70")]
	public static implicit operator SharedFarmMonsterHutState(FarmMonsterHutState value)
	{
		return null;
	}

	// Token: 0x06000758 RID: 1880 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000637")]
	[Address(RVA = "0x1E36B20", Offset = "0x1E36C21", VA = "0x1E36B20")]
	public SharedFarmMonsterHutState()
	{
	}
}
