using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AI;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityNavMeshAgent
{
	// Token: 0x02001402 RID: 5122
	[Token(Token = "0x2000DCD")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x151DF0", Offset = "0x151EF1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x151DF0", Offset = "0x151EF1")]
	public class SetAcceleration : Action
	{
		// Token: 0x060076A1 RID: 30369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006355")]
		[Address(RVA = "0x2986E70", Offset = "0x2986F71", VA = "0x2986E70", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060076A2 RID: 30370 RVA: 0x000292B0 File Offset: 0x000274B0
		[Token(Token = "0x6006356")]
		[Address(RVA = "0x2986F70", Offset = "0x2987071", VA = "0x2986F70", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060076A3 RID: 30371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006357")]
		[Address(RVA = "0x2987060", Offset = "0x2987161", VA = "0x2987060", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060076A4 RID: 30372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006358")]
		[Address(RVA = "0x29870B0", Offset = "0x29871B1", VA = "0x29870B0")]
		public SetAcceleration()
		{
		}

		// Token: 0x0401B969 RID: 113001
		[Token(Token = "0x401838A")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18D410", Offset = "0x18D511")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B96A RID: 113002
		[Token(Token = "0x401838B")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18D450", Offset = "0x18D551")]
		public SharedFloat acceleration;

		// Token: 0x0401B96B RID: 113003
		[Token(Token = "0x401838C")]
		[FieldOffset(Offset = "0x60")]
		private NavMeshAgent navMeshAgent;

		// Token: 0x0401B96C RID: 113004
		[Token(Token = "0x401838D")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
