using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks
{
	// Token: 0x020012DC RID: 4828
	[Token(Token = "0x2000CA9")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14AFD0", Offset = "0x14B0D1")]
	[Attribute(Name = "TaskIconAttribute", RVA = "0x14AFD0", Offset = "0x14B0D1")]
	public class RestartBehaviorTree : Action
	{
		// Token: 0x0600722D RID: 29229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EE1")]
		[Address(RVA = "0x2219500", Offset = "0x2219601", VA = "0x2219500", Slot = "4")]
		public override void OnAwake()
		{
		}

		// Token: 0x0600722E RID: 29230 RVA: 0x00027438 File Offset: 0x00025638
		[Token(Token = "0x6005EE2")]
		[Address(RVA = "0x22196A0", Offset = "0x22197A1", VA = "0x22196A0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600722F RID: 29231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EE3")]
		[Address(RVA = "0x2219750", Offset = "0x2219851", VA = "0x2219750", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007230 RID: 29232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EE4")]
		[Address(RVA = "0x2219760", Offset = "0x2219861", VA = "0x2219760")]
		public RestartBehaviorTree()
		{
		}

		// Token: 0x0401B585 RID: 112005
		[Token(Token = "0x4017FAE")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x182B00", Offset = "0x182C01")]
		public SharedGameObject behaviorGameObject;

		// Token: 0x0401B586 RID: 112006
		[Token(Token = "0x4017FAF")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x182B40", Offset = "0x182C41")]
		public SharedInt group;

		// Token: 0x0401B587 RID: 112007
		[Token(Token = "0x4017FB0")]
		[FieldOffset(Offset = "0x60")]
		private Behavior behavior;
	}
}
