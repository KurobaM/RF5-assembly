using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityRigidbody
{
	// Token: 0x020013BD RID: 5053
	[Token(Token = "0x2000D88")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x150410", Offset = "0x150511")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x150410", Offset = "0x150511")]
	public class WakeUp : Conditional
	{
		// Token: 0x060075AA RID: 30122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600625E")]
		[Address(RVA = "0x2995050", Offset = "0x2995151", VA = "0x2995050", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060075AB RID: 30123 RVA: 0x00028C38 File Offset: 0x00026E38
		[Token(Token = "0x600625F")]
		[Address(RVA = "0x2995150", Offset = "0x2995251", VA = "0x2995150", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060075AC RID: 30124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006260")]
		[Address(RVA = "0x2995230", Offset = "0x2995331", VA = "0x2995230", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060075AD RID: 30125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006261")]
		[Address(RVA = "0x2995240", Offset = "0x2995341", VA = "0x2995240")]
		public WakeUp()
		{
		}

		// Token: 0x0401B86D RID: 112749
		[Token(Token = "0x401828E")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18A750", Offset = "0x18A851")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B86E RID: 112750
		[Token(Token = "0x401828F")]
		[FieldOffset(Offset = "0x58")]
		private Rigidbody rigidbody;

		// Token: 0x0401B86F RID: 112751
		[Token(Token = "0x4018290")]
		[FieldOffset(Offset = "0x60")]
		private GameObject prevGameObject;
	}
}
