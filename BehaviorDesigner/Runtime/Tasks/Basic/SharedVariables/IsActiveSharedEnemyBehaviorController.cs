using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Basic.SharedVariables
{
	// Token: 0x020014D1 RID: 5329
	[Token(Token = "0x2000E94")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x156890", Offset = "0x156991")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x156890", Offset = "0x156991")]
	public class IsActiveSharedEnemyBehaviorController : Conditional
	{
		// Token: 0x06007998 RID: 31128 RVA: 0x0002A5B8 File Offset: 0x000287B8
		[Token(Token = "0x600663A")]
		[Address(RVA = "0x220EE60", Offset = "0x220EF61", VA = "0x220EE60", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007999 RID: 31129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600663B")]
		[Address(RVA = "0x220EF40", Offset = "0x220F041", VA = "0x220EF40", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600799A RID: 31130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600663C")]
		[Address(RVA = "0x220EF50", Offset = "0x220F051", VA = "0x220EF50")]
		public IsActiveSharedEnemyBehaviorController()
		{
		}

		// Token: 0x0401BC61 RID: 113761
		[Token(Token = "0x4018653")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1944A0", Offset = "0x1945A1")]
		public SharedEnemyBehaviorController variable;
	}
}
