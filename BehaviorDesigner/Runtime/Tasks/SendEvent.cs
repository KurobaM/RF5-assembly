using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks
{
	// Token: 0x020012DD RID: 4829
	[Token(Token = "0x2000CAA")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14B030", Offset = "0x14B131")]
	[Attribute(Name = "HelpURLAttribute", RVA = "0x14B030", Offset = "0x14B131")]
	[Attribute(Name = "TaskIconAttribute", RVA = "0x14B030", Offset = "0x14B131")]
	public class SendEvent : Action
	{
		// Token: 0x06007231 RID: 29233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EE5")]
		[Address(RVA = "0x2219BF0", Offset = "0x2219CF1", VA = "0x2219BF0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007232 RID: 29234 RVA: 0x00027450 File Offset: 0x00025650
		[Token(Token = "0x6005EE6")]
		[Address(RVA = "0x2219D90", Offset = "0x2219E91", VA = "0x2219D90", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007233 RID: 29235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EE7")]
		[Address(RVA = "0x2219FB0", Offset = "0x221A0B1", VA = "0x2219FB0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007234 RID: 29236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EE8")]
		[Address(RVA = "0x221A0B0", Offset = "0x221A1B1", VA = "0x221A0B0")]
		public SendEvent()
		{
		}

		// Token: 0x0401B588 RID: 112008
		[Token(Token = "0x4017FB1")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x182B80", Offset = "0x182C81")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B589 RID: 112009
		[Token(Token = "0x4017FB2")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x182BC0", Offset = "0x182CC1")]
		public SharedString eventName;

		// Token: 0x0401B58A RID: 112010
		[Token(Token = "0x4017FB3")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x182C00", Offset = "0x182D01")]
		public SharedInt group;

		// Token: 0x0401B58B RID: 112011
		[Token(Token = "0x4017FB4")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x182C40", Offset = "0x182D41")]
		[Attribute(Name = "SharedRequiredAttribute", RVA = "0x182C40", Offset = "0x182D41")]
		public SharedVariable argument1;

		// Token: 0x0401B58C RID: 112012
		[Token(Token = "0x4017FB5")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x182C90", Offset = "0x182D91")]
		[Attribute(Name = "SharedRequiredAttribute", RVA = "0x182C90", Offset = "0x182D91")]
		public SharedVariable argument2;

		// Token: 0x0401B58D RID: 112013
		[Token(Token = "0x4017FB6")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x182CE0", Offset = "0x182DE1")]
		[Attribute(Name = "SharedRequiredAttribute", RVA = "0x182CE0", Offset = "0x182DE1")]
		public SharedVariable argument3;

		// Token: 0x0401B58E RID: 112014
		[Token(Token = "0x4017FB7")]
		[FieldOffset(Offset = "0x80")]
		private BehaviorTree behaviorTree;
	}
}
