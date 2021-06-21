using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Basic.SharedVariables
{
	// Token: 0x020014D5 RID: 5333
	[Token(Token = "0x2000E98")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x156A10", Offset = "0x156B11")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x156A10", Offset = "0x156B11")]
	public class CompareSharedMonsterBehaviorState : Conditional
	{
		// Token: 0x060079A4 RID: 31140 RVA: 0x0002A618 File Offset: 0x00028818
		[Token(Token = "0x6006646")]
		[Address(RVA = "0x220EA40", Offset = "0x220EB41", VA = "0x220EA40", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060079A5 RID: 31141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006647")]
		[Address(RVA = "0x220EAD0", Offset = "0x220EBD1", VA = "0x220EAD0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060079A6 RID: 31142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006648")]
		[Address(RVA = "0x220EB10", Offset = "0x220EC11", VA = "0x220EB10")]
		public CompareSharedMonsterBehaviorState()
		{
		}

		// Token: 0x0401BC67 RID: 113767
		[Token(Token = "0x4018659")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x194630", Offset = "0x194731")]
		public SharedMonsterBehaviorState variable;

		// Token: 0x0401BC68 RID: 113768
		[Token(Token = "0x401865A")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x194670", Offset = "0x194771")]
		public SharedMonsterBehaviorState compareTo;
	}
}
