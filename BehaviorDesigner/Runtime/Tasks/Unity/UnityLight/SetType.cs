using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityLight
{
	// Token: 0x02001434 RID: 5172
	[Token(Token = "0x2000DFA")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x152ED0", Offset = "0x152FD1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x152ED0", Offset = "0x152FD1")]
	public class SetType : Action
	{
		// Token: 0x0600773F RID: 30527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063F3")]
		[Address(RVA = "0x28E9420", Offset = "0x28E9521", VA = "0x28E9420", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007740 RID: 30528 RVA: 0x000296E8 File Offset: 0x000278E8
		[Token(Token = "0x60063F4")]
		[Address(RVA = "0x28E9520", Offset = "0x28E9621", VA = "0x28E9520", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007741 RID: 30529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063F5")]
		[Address(RVA = "0x28E9600", Offset = "0x28E9701", VA = "0x28E9600", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007742 RID: 30530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063F6")]
		[Address(RVA = "0x28E9610", Offset = "0x28E9711", VA = "0x28E9610")]
		public SetType()
		{
		}

		// Token: 0x0401BA21 RID: 113185
		[Token(Token = "0x401841F")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18EE00", Offset = "0x18EF01")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BA22 RID: 113186
		[Token(Token = "0x4018420")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18EE40", Offset = "0x18EF41")]
		public LightType type;

		// Token: 0x0401BA23 RID: 113187
		[Token(Token = "0x4018421")]
		[FieldOffset(Offset = "0x60")]
		private Light light;

		// Token: 0x0401BA24 RID: 113188
		[Token(Token = "0x4018422")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
