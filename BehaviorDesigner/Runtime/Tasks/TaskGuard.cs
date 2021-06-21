using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks
{
	// Token: 0x020012FD RID: 4861
	[Token(Token = "0x2000CCA")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14BCA0", Offset = "0x14BDA1")]
	[Attribute(Name = "TaskIconAttribute", RVA = "0x14BCA0", Offset = "0x14BDA1")]
	public class TaskGuard : Decorator
	{
		// Token: 0x06007303 RID: 29443 RVA: 0x00027A50 File Offset: 0x00025C50
		[Token(Token = "0x6005FB7")]
		[Address(RVA = "0x221BE80", Offset = "0x221BF81", VA = "0x221BE80", Slot = "33")]
		public override bool CanExecute()
		{
			return default(bool);
		}

		// Token: 0x06007304 RID: 29444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FB8")]
		[Address(RVA = "0x221BF10", Offset = "0x221C011", VA = "0x221BF10", Slot = "38")]
		public override void OnChildStarted()
		{
		}

		// Token: 0x06007305 RID: 29445 RVA: 0x00027A68 File Offset: 0x00025C68
		[Token(Token = "0x6005FB9")]
		[Address(RVA = "0x221BFC0", Offset = "0x221C0C1", VA = "0x221BFC0", Slot = "40")]
		public override TaskStatus OverrideStatus(TaskStatus status)
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007306 RID: 29446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FBA")]
		[Address(RVA = "0x221BF90", Offset = "0x221C091", VA = "0x221BF90")]
		public void taskExecuting(bool increase)
		{
		}

		// Token: 0x06007307 RID: 29447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FBB")]
		[Address(RVA = "0x221C050", Offset = "0x221C151", VA = "0x221C050", Slot = "9")]
		public override void OnEnd()
		{
		}

		// Token: 0x06007308 RID: 29448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FBC")]
		[Address(RVA = "0x221C0D0", Offset = "0x221C1D1", VA = "0x221C0D0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007309 RID: 29449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FBD")]
		[Address(RVA = "0x221C1A0", Offset = "0x221C2A1", VA = "0x221C1A0")]
		public TaskGuard()
		{
		}

		// Token: 0x0401B5F8 RID: 112120
		[Token(Token = "0x4018021")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x183A30", Offset = "0x183B31")]
		public SharedInt maxTaskAccessCount;

		// Token: 0x0401B5F9 RID: 112121
		[Token(Token = "0x4018022")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x183A70", Offset = "0x183B71")]
		[Attribute(Name = "LinkedTaskAttribute", RVA = "0x183A70", Offset = "0x183B71")]
		public TaskGuard[] linkedTaskGuards;

		// Token: 0x0401B5FA RID: 112122
		[Token(Token = "0x4018023")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x183AC0", Offset = "0x183BC1")]
		public SharedBool waitUntilTaskAvailable;

		// Token: 0x0401B5FB RID: 112123
		[Token(Token = "0x4018024")]
		[FieldOffset(Offset = "0x70")]
		private int executingTasks;

		// Token: 0x0401B5FC RID: 112124
		[Token(Token = "0x4018025")]
		[FieldOffset(Offset = "0x74")]
		private bool executing;
	}
}
