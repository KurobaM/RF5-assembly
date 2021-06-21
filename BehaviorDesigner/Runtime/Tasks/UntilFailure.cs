using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks
{
	// Token: 0x020012FE RID: 4862
	[Token(Token = "0x2000CCB")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14BD00", Offset = "0x14BE01")]
	[Attribute(Name = "TaskIconAttribute", RVA = "0x14BD00", Offset = "0x14BE01")]
	public class UntilFailure : Decorator
	{
		// Token: 0x0600730A RID: 29450 RVA: 0x00027A80 File Offset: 0x00025C80
		[Token(Token = "0x6005FBE")]
		[Address(RVA = "0x244B500", Offset = "0x244B601", VA = "0x244B500", Slot = "33")]
		public override bool CanExecute()
		{
			return default(bool);
		}

		// Token: 0x0600730B RID: 29451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FBF")]
		[Address(RVA = "0x244B520", Offset = "0x244B621", VA = "0x244B520", Slot = "36")]
		public override void OnChildExecuted(TaskStatus childStatus)
		{
		}

		// Token: 0x0600730C RID: 29452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FC0")]
		[Address(RVA = "0x244B530", Offset = "0x244B631", VA = "0x244B530", Slot = "9")]
		public override void OnEnd()
		{
		}

		// Token: 0x0600730D RID: 29453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FC1")]
		[Address(RVA = "0x244B540", Offset = "0x244B641", VA = "0x244B540")]
		public UntilFailure()
		{
		}

		// Token: 0x0401B5FD RID: 112125
		[Token(Token = "0x4018026")]
		[FieldOffset(Offset = "0x58")]
		private TaskStatus executionStatus;
	}
}
