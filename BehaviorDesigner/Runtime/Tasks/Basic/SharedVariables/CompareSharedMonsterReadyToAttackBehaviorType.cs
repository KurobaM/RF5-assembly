using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Basic.SharedVariables
{
	// Token: 0x020014D7 RID: 5335
	[Token(Token = "0x2000E9A")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x156AD0", Offset = "0x156BD1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x156AD0", Offset = "0x156BD1")]
	public class CompareSharedMonsterReadyToAttackBehaviorType : Conditional
	{
		// Token: 0x060079AA RID: 31146 RVA: 0x0002A648 File Offset: 0x00028848
		[Token(Token = "0x600664C")]
		[Address(RVA = "0x220EB20", Offset = "0x220EC21", VA = "0x220EB20", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060079AB RID: 31147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600664D")]
		[Address(RVA = "0x220EBB0", Offset = "0x220ECB1", VA = "0x220EBB0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060079AC RID: 31148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600664E")]
		[Address(RVA = "0x220EBF0", Offset = "0x220ECF1", VA = "0x220EBF0")]
		public CompareSharedMonsterReadyToAttackBehaviorType()
		{
		}

		// Token: 0x0401BC6B RID: 113771
		[Token(Token = "0x401865D")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x194740", Offset = "0x194841")]
		public SharedMovementBehaviorType variable;

		// Token: 0x0401BC6C RID: 113772
		[Token(Token = "0x401865E")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x194780", Offset = "0x194881")]
		public SharedMovementBehaviorType compareTo;
	}
}
