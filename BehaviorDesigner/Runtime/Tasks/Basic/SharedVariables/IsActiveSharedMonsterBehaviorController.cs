using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Basic.SharedVariables
{
	// Token: 0x020014D3 RID: 5331
	[Token(Token = "0x2000E96")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x156950", Offset = "0x156A51")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x156950", Offset = "0x156A51")]
	public class IsActiveSharedMonsterBehaviorController : Conditional
	{
		// Token: 0x0600799E RID: 31134 RVA: 0x0002A5E8 File Offset: 0x000287E8
		[Token(Token = "0x6006640")]
		[Address(RVA = "0x220EF60", Offset = "0x220F061", VA = "0x220EF60", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600799F RID: 31135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006641")]
		[Address(RVA = "0x220F040", Offset = "0x220F141", VA = "0x220F040", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060079A0 RID: 31136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006642")]
		[Address(RVA = "0x220F050", Offset = "0x220F151", VA = "0x220F050")]
		public IsActiveSharedMonsterBehaviorController()
		{
		}

		// Token: 0x0401BC64 RID: 113764
		[Token(Token = "0x4018656")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x194560", Offset = "0x194661")]
		public SharedMonsterBehaviorController variable;
	}
}
