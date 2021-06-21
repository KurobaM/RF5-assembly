using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AI;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityNavMeshAgent
{
	// Token: 0x02001407 RID: 5127
	[Token(Token = "0x2000DD2")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x151FD0", Offset = "0x1520D1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x151FD0", Offset = "0x1520D1")]
	public class Stop : Action
	{
		// Token: 0x060076B5 RID: 30389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006369")]
		[Address(RVA = "0x2987A20", Offset = "0x2987B21", VA = "0x2987A20", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060076B6 RID: 30390 RVA: 0x00029328 File Offset: 0x00027528
		[Token(Token = "0x600636A")]
		[Address(RVA = "0x2987B20", Offset = "0x2987C21", VA = "0x2987B20", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060076B7 RID: 30391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600636B")]
		[Address(RVA = "0x2987C00", Offset = "0x2987D01", VA = "0x2987C00", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060076B8 RID: 30392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600636C")]
		[Address(RVA = "0x2987C10", Offset = "0x2987D11", VA = "0x2987C10")]
		public Stop()
		{
		}

		// Token: 0x0401B97D RID: 113021
		[Token(Token = "0x401839E")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18D6A0", Offset = "0x18D7A1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B97E RID: 113022
		[Token(Token = "0x401839F")]
		[FieldOffset(Offset = "0x58")]
		private NavMeshAgent navMeshAgent;

		// Token: 0x0401B97F RID: 113023
		[Token(Token = "0x40183A0")]
		[FieldOffset(Offset = "0x60")]
		private GameObject prevGameObject;
	}
}
