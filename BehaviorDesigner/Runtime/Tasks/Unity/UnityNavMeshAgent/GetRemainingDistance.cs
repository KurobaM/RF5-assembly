using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AI;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityNavMeshAgent
{
	// Token: 0x020013FC RID: 5116
	[Token(Token = "0x2000DC7")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x151BB0", Offset = "0x151CB1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x151BB0", Offset = "0x151CB1")]
	public class GetRemainingDistance : Action
	{
		// Token: 0x06007689 RID: 30345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600633D")]
		[Address(RVA = "0x28E9FA0", Offset = "0x28EA0A1", VA = "0x28E9FA0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600768A RID: 30346 RVA: 0x00029220 File Offset: 0x00027420
		[Token(Token = "0x600633E")]
		[Address(RVA = "0x28EA0A0", Offset = "0x28EA1A1", VA = "0x28EA0A0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600768B RID: 30347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600633F")]
		[Address(RVA = "0x28EA190", Offset = "0x28EA291", VA = "0x28EA190", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600768C RID: 30348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006340")]
		[Address(RVA = "0x28EA1E0", Offset = "0x28EA2E1", VA = "0x28EA1E0")]
		public GetRemainingDistance()
		{
		}

		// Token: 0x0401B954 RID: 112980
		[Token(Token = "0x4018375")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18D1B0", Offset = "0x18D2B1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B955 RID: 112981
		[Token(Token = "0x4018376")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "SharedRequiredAttribute", RVA = "0x18D1F0", Offset = "0x18D2F1")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18D1F0", Offset = "0x18D2F1")]
		public SharedFloat storeValue;

		// Token: 0x0401B956 RID: 112982
		[Token(Token = "0x4018377")]
		[FieldOffset(Offset = "0x60")]
		private NavMeshAgent navMeshAgent;

		// Token: 0x0401B957 RID: 112983
		[Token(Token = "0x4018378")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
