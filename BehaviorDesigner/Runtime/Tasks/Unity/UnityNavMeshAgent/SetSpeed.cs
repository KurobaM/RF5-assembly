using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AI;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityNavMeshAgent
{
	// Token: 0x02001406 RID: 5126
	[Token(Token = "0x2000DD1")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x151F70", Offset = "0x152071")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x151F70", Offset = "0x152071")]
	public class SetSpeed : Action
	{
		// Token: 0x060076B1 RID: 30385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006365")]
		[Address(RVA = "0x29877D0", Offset = "0x29878D1", VA = "0x29877D0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060076B2 RID: 30386 RVA: 0x00029310 File Offset: 0x00027510
		[Token(Token = "0x6006366")]
		[Address(RVA = "0x29878D0", Offset = "0x29879D1", VA = "0x29878D0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060076B3 RID: 30387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006367")]
		[Address(RVA = "0x29879C0", Offset = "0x2987AC1", VA = "0x29879C0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060076B4 RID: 30388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006368")]
		[Address(RVA = "0x2987A10", Offset = "0x2987B11", VA = "0x2987A10")]
		public SetSpeed()
		{
		}

		// Token: 0x0401B979 RID: 113017
		[Token(Token = "0x401839A")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18D620", Offset = "0x18D721")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B97A RID: 113018
		[Token(Token = "0x401839B")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18D660", Offset = "0x18D761")]
		public SharedFloat speed;

		// Token: 0x0401B97B RID: 113019
		[Token(Token = "0x401839C")]
		[FieldOffset(Offset = "0x60")]
		private NavMeshAgent navMeshAgent;

		// Token: 0x0401B97C RID: 113020
		[Token(Token = "0x401839D")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
