using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks
{
	// Token: 0x020012DE RID: 4830
	[Token(Token = "0x2000CAB")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14B0C0", Offset = "0x14B1C1")]
	[Attribute(Name = "TaskIconAttribute", RVA = "0x14B0C0", Offset = "0x14B1C1")]
	public class StartBehaviorTree : Action
	{
		// Token: 0x06007235 RID: 29237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EE9")]
		[Address(RVA = "0x221B2D0", Offset = "0x221B3D1", VA = "0x221B2D0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007236 RID: 29238 RVA: 0x00027468 File Offset: 0x00025668
		[Token(Token = "0x6005EEA")]
		[Address(RVA = "0x221B5D0", Offset = "0x221B6D1", VA = "0x221B5D0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007237 RID: 29239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EEB")]
		[Address(RVA = "0x221B6A0", Offset = "0x221B7A1", VA = "0x221B6A0")]
		private void BehaviorEnded(Behavior behavior)
		{
		}

		// Token: 0x06007238 RID: 29240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EEC")]
		[Address(RVA = "0x221B6B0", Offset = "0x221B7B1", VA = "0x221B6B0", Slot = "9")]
		public override void OnEnd()
		{
		}

		// Token: 0x06007239 RID: 29241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EED")]
		[Address(RVA = "0x221B7A0", Offset = "0x221B8A1", VA = "0x221B7A0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600723A RID: 29242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EEE")]
		[Address(RVA = "0x221B960", Offset = "0x221BA61", VA = "0x221B960")]
		public StartBehaviorTree()
		{
		}

		// Token: 0x0401B58F RID: 112015
		[Token(Token = "0x4017FB8")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x182D30", Offset = "0x182E31")]
		public SharedGameObject behaviorGameObject;

		// Token: 0x0401B590 RID: 112016
		[Token(Token = "0x4017FB9")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x182D70", Offset = "0x182E71")]
		public SharedInt group;

		// Token: 0x0401B591 RID: 112017
		[Token(Token = "0x4017FBA")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x182DB0", Offset = "0x182EB1")]
		public SharedBool waitForCompletion;

		// Token: 0x0401B592 RID: 112018
		[Token(Token = "0x4017FBB")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x182DF0", Offset = "0x182EF1")]
		public SharedBool synchronizeVariables;

		// Token: 0x0401B593 RID: 112019
		[Token(Token = "0x4017FBC")]
		[FieldOffset(Offset = "0x70")]
		private bool behaviorComplete;

		// Token: 0x0401B594 RID: 112020
		[Token(Token = "0x4017FBD")]
		[FieldOffset(Offset = "0x78")]
		private Behavior behavior;
	}
}
