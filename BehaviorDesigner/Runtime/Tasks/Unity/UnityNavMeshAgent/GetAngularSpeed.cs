using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AI;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityNavMeshAgent
{
	// Token: 0x020013F9 RID: 5113
	[Token(Token = "0x2000DC4")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x151A90", Offset = "0x151B91")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x151A90", Offset = "0x151B91")]
	public class GetAngularSpeed : Action
	{
		// Token: 0x0600767D RID: 30333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006331")]
		[Address(RVA = "0x28E9870", Offset = "0x28E9971", VA = "0x28E9870", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600767E RID: 30334 RVA: 0x000291D8 File Offset: 0x000273D8
		[Token(Token = "0x6006332")]
		[Address(RVA = "0x28E9970", Offset = "0x28E9A71", VA = "0x28E9970", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600767F RID: 30335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006333")]
		[Address(RVA = "0x28E9A60", Offset = "0x28E9B61", VA = "0x28E9A60", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007680 RID: 30336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006334")]
		[Address(RVA = "0x28E9AB0", Offset = "0x28E9BB1", VA = "0x28E9AB0")]
		public GetAngularSpeed()
		{
		}

		// Token: 0x0401B948 RID: 112968
		[Token(Token = "0x4018369")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18D000", Offset = "0x18D101")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B949 RID: 112969
		[Token(Token = "0x401836A")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "SharedRequiredAttribute", RVA = "0x18D040", Offset = "0x18D141")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18D040", Offset = "0x18D141")]
		public SharedFloat storeValue;

		// Token: 0x0401B94A RID: 112970
		[Token(Token = "0x401836B")]
		[FieldOffset(Offset = "0x60")]
		private NavMeshAgent navMeshAgent;

		// Token: 0x0401B94B RID: 112971
		[Token(Token = "0x401836C")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
