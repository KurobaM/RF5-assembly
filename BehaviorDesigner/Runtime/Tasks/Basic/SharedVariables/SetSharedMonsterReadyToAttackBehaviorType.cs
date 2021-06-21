using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Basic.SharedVariables
{
	// Token: 0x020014D6 RID: 5334
	[Token(Token = "0x2000E99")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x156A70", Offset = "0x156B71")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x156A70", Offset = "0x156B71")]
	public class SetSharedMonsterReadyToAttackBehaviorType : Action
	{
		// Token: 0x060079A7 RID: 31143 RVA: 0x0002A630 File Offset: 0x00028830
		[Token(Token = "0x6006649")]
		[Address(RVA = "0x220F1F0", Offset = "0x220F2F1", VA = "0x220F1F0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060079A8 RID: 31144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600664A")]
		[Address(RVA = "0x220F270", Offset = "0x220F371", VA = "0x220F270", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060079A9 RID: 31145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600664B")]
		[Address(RVA = "0x220F2B0", Offset = "0x220F3B1", VA = "0x220F2B0")]
		public SetSharedMonsterReadyToAttackBehaviorType()
		{
		}

		// Token: 0x0401BC69 RID: 113769
		[Token(Token = "0x401865B")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1946B0", Offset = "0x1947B1")]
		public SharedMovementBehaviorType targetValue;

		// Token: 0x0401BC6A RID: 113770
		[Token(Token = "0x401865C")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x1946F0", Offset = "0x1947F1")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1946F0", Offset = "0x1947F1")]
		public SharedMovementBehaviorType targetVariable;
	}
}
