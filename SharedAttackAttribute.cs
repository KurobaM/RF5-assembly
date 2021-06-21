using System;
using BehaviorDesigner.Runtime;
using Define;
using Il2CppDummyDll;

// Token: 0x0200016E RID: 366
[Token(Token = "0x200011C")]
[Serializable]
public class SharedAttackAttribute : SharedVariable<AttackAttribute>
{
	// Token: 0x0600079D RID: 1949 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000674")]
	[Address(RVA = "0x1E36530", Offset = "0x1E36631", VA = "0x1E36530", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x0600079E RID: 1950 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000675")]
	[Address(RVA = "0x1E365C0", Offset = "0x1E366C1", VA = "0x1E365C0")]
	public static implicit operator SharedAttackAttribute(AttackAttribute value)
	{
		return null;
	}

	// Token: 0x0600079F RID: 1951 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000676")]
	[Address(RVA = "0x1E36670", Offset = "0x1E36771", VA = "0x1E36670")]
	public SharedAttackAttribute()
	{
	}
}
