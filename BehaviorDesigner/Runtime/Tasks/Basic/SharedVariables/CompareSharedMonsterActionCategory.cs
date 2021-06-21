using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Basic.SharedVariables
{
	// Token: 0x020014D2 RID: 5330
	[Token(Token = "0x2000E95")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x1568F0", Offset = "0x1569F1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x1568F0", Offset = "0x1569F1")]
	public class CompareSharedMonsterActionCategory : Conditional
	{
		// Token: 0x0600799B RID: 31131 RVA: 0x0002A5D0 File Offset: 0x000287D0
		[Token(Token = "0x600663D")]
		[Address(RVA = "0x220E960", Offset = "0x220EA61", VA = "0x220E960", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600799C RID: 31132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600663E")]
		[Address(RVA = "0x220E9F0", Offset = "0x220EAF1", VA = "0x220E9F0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600799D RID: 31133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600663F")]
		[Address(RVA = "0x220EA30", Offset = "0x220EB31", VA = "0x220EA30")]
		public CompareSharedMonsterActionCategory()
		{
		}

		// Token: 0x0401BC62 RID: 113762
		[Token(Token = "0x4018654")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1944E0", Offset = "0x1945E1")]
		public SharedMonsterActionCategory variable;

		// Token: 0x0401BC63 RID: 113763
		[Token(Token = "0x4018655")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x194520", Offset = "0x194621")]
		public SharedMonsterActionCategory compareTo;
	}
}
