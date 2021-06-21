using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AI;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityNavMeshAgent
{
	// Token: 0x020014CE RID: 5326
	[Token(Token = "0x2000E91")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x156770", Offset = "0x156871")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x156770", Offset = "0x156871")]
	public class IsEnableNavMeshAgent : Conditional
	{
		// Token: 0x0600798E RID: 31118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006630")]
		[Address(RVA = "0x220F2C0", Offset = "0x220F3C1", VA = "0x220F2C0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600798F RID: 31119 RVA: 0x0002A570 File Offset: 0x00028770
		[Token(Token = "0x6006631")]
		[Address(RVA = "0x220F3A0", Offset = "0x220F4A1", VA = "0x220F3A0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007990 RID: 31120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006632")]
		[Address(RVA = "0x220F490", Offset = "0x220F591", VA = "0x220F490", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007991 RID: 31121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006633")]
		[Address(RVA = "0x220F4A0", Offset = "0x220F5A1", VA = "0x220F4A0")]
		public IsEnableNavMeshAgent()
		{
		}

		// Token: 0x0401BC5C RID: 113756
		[Token(Token = "0x401864E")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1943E0", Offset = "0x1944E1")]
		public SharedBool UseNavMeshAgent;

		// Token: 0x0401BC5D RID: 113757
		[Token(Token = "0x401864F")]
		[FieldOffset(Offset = "0x58")]
		private NavMeshAgent navMeshAgent;

		// Token: 0x0401BC5E RID: 113758
		[Token(Token = "0x4018650")]
		[FieldOffset(Offset = "0x60")]
		private GameObject prevGameObject;
	}
}
