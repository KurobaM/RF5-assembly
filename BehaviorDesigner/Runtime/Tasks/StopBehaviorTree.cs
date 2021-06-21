using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks
{
	// Token: 0x020012DF RID: 4831
	[Token(Token = "0x2000CAC")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14B120", Offset = "0x14B221")]
	[Attribute(Name = "TaskIconAttribute", RVA = "0x14B120", Offset = "0x14B221")]
	public class StopBehaviorTree : Action
	{
		// Token: 0x0600723B RID: 29243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EEF")]
		[Address(RVA = "0x221BA20", Offset = "0x221BB21", VA = "0x221BA20", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600723C RID: 29244 RVA: 0x00027480 File Offset: 0x00025680
		[Token(Token = "0x6005EF0")]
		[Address(RVA = "0x221BBC0", Offset = "0x221BCC1", VA = "0x221BBC0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600723D RID: 29245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EF1")]
		[Address(RVA = "0x221BC80", Offset = "0x221BD81", VA = "0x221BC80", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600723E RID: 29246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EF2")]
		[Address(RVA = "0x221BDC0", Offset = "0x221BEC1", VA = "0x221BDC0")]
		public StopBehaviorTree()
		{
		}

		// Token: 0x0401B595 RID: 112021
		[Token(Token = "0x4017FBE")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x182E30", Offset = "0x182F31")]
		public SharedGameObject behaviorGameObject;

		// Token: 0x0401B596 RID: 112022
		[Token(Token = "0x4017FBF")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x182E70", Offset = "0x182F71")]
		public SharedInt group;

		// Token: 0x0401B597 RID: 112023
		[Token(Token = "0x4017FC0")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x182EB0", Offset = "0x182FB1")]
		public SharedBool pauseBehavior;

		// Token: 0x0401B598 RID: 112024
		[Token(Token = "0x4017FC1")]
		[FieldOffset(Offset = "0x68")]
		private Behavior behavior;
	}
}
