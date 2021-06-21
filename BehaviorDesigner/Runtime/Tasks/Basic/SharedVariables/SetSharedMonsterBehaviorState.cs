using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Basic.SharedVariables
{
	// Token: 0x020014D4 RID: 5332
	[Token(Token = "0x2000E97")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x1569B0", Offset = "0x156AB1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x1569B0", Offset = "0x156AB1")]
	public class SetSharedMonsterBehaviorState : Action
	{
		// Token: 0x060079A1 RID: 31137 RVA: 0x0002A600 File Offset: 0x00028800
		[Token(Token = "0x6006643")]
		[Address(RVA = "0x220F120", Offset = "0x220F221", VA = "0x220F120", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060079A2 RID: 31138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006644")]
		[Address(RVA = "0x220F1A0", Offset = "0x220F2A1", VA = "0x220F1A0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060079A3 RID: 31139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006645")]
		[Address(RVA = "0x220F1E0", Offset = "0x220F2E1", VA = "0x220F1E0")]
		public SetSharedMonsterBehaviorState()
		{
		}

		// Token: 0x0401BC65 RID: 113765
		[Token(Token = "0x4018657")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1945A0", Offset = "0x1946A1")]
		public SharedMonsterBehaviorState targetValue;

		// Token: 0x0401BC66 RID: 113766
		[Token(Token = "0x4018658")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x1945E0", Offset = "0x1946E1")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1945E0", Offset = "0x1946E1")]
		public SharedMonsterBehaviorState targetVariable;
	}
}
