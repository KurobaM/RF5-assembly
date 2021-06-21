using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Basic.SharedVariables
{
	// Token: 0x020014D8 RID: 5336
	[Token(Token = "0x2000E9B")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x156B30", Offset = "0x156C31")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x156B30", Offset = "0x156C31")]
	public class CompareSharedMovementBehaviorType : Conditional
	{
		// Token: 0x060079AD RID: 31149 RVA: 0x0002A660 File Offset: 0x00028860
		[Token(Token = "0x600664F")]
		[Address(RVA = "0x220EC00", Offset = "0x220ED01", VA = "0x220EC00", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060079AE RID: 31150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006650")]
		[Address(RVA = "0x220EC90", Offset = "0x220ED91", VA = "0x220EC90", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060079AF RID: 31151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006651")]
		[Address(RVA = "0x220ECD0", Offset = "0x220EDD1", VA = "0x220ECD0")]
		public CompareSharedMovementBehaviorType()
		{
		}

		// Token: 0x0401BC6D RID: 113773
		[Token(Token = "0x401865F")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1947C0", Offset = "0x1948C1")]
		public SharedMovementBehaviorType variable;

		// Token: 0x0401BC6E RID: 113774
		[Token(Token = "0x4018660")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x194800", Offset = "0x194901")]
		public SharedMovementBehaviorType compareTo;
	}
}
