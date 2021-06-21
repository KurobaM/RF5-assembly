using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AI;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityNavMeshAgent
{
	// Token: 0x020013F8 RID: 5112
	[Token(Token = "0x2000DC3")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x151A30", Offset = "0x151B31")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x151A30", Offset = "0x151B31")]
	public class GetAcceleration : Action
	{
		// Token: 0x06007679 RID: 30329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600632D")]
		[Address(RVA = "0x28E9620", Offset = "0x28E9721", VA = "0x28E9620", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600767A RID: 30330 RVA: 0x000291C0 File Offset: 0x000273C0
		[Token(Token = "0x600632E")]
		[Address(RVA = "0x28E9720", Offset = "0x28E9821", VA = "0x28E9720", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600767B RID: 30331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600632F")]
		[Address(RVA = "0x28E9810", Offset = "0x28E9911", VA = "0x28E9810", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600767C RID: 30332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006330")]
		[Address(RVA = "0x28E9860", Offset = "0x28E9961", VA = "0x28E9860")]
		public GetAcceleration()
		{
		}

		// Token: 0x0401B944 RID: 112964
		[Token(Token = "0x4018365")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18CF70", Offset = "0x18D071")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B945 RID: 112965
		[Token(Token = "0x4018366")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "SharedRequiredAttribute", RVA = "0x18CFB0", Offset = "0x18D0B1")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18CFB0", Offset = "0x18D0B1")]
		public SharedFloat storeValue;

		// Token: 0x0401B946 RID: 112966
		[Token(Token = "0x4018367")]
		[FieldOffset(Offset = "0x60")]
		private NavMeshAgent navMeshAgent;

		// Token: 0x0401B947 RID: 112967
		[Token(Token = "0x4018368")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
