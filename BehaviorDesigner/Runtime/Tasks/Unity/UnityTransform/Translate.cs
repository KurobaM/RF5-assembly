using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityTransform
{
	// Token: 0x02001344 RID: 4932
	[Token(Token = "0x2000D0F")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14D660", Offset = "0x14D761")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14D660", Offset = "0x14D761")]
	public class Translate : Action
	{
		// Token: 0x060073F5 RID: 29685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060A9")]
		[Address(RVA = "0x299F7D0", Offset = "0x299F8D1", VA = "0x299F7D0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060073F6 RID: 29686 RVA: 0x000280E0 File Offset: 0x000262E0
		[Token(Token = "0x60060AA")]
		[Address(RVA = "0x299F8D0", Offset = "0x299F9D1", VA = "0x299F8D0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060073F7 RID: 29687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060AB")]
		[Address(RVA = "0x299F9D0", Offset = "0x299FAD1", VA = "0x299F9D0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060073F8 RID: 29688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060AC")]
		[Address(RVA = "0x299FA70", Offset = "0x299FB71", VA = "0x299FA70")]
		public Translate()
		{
		}

		// Token: 0x0401B6E8 RID: 112360
		[Token(Token = "0x4018109")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x186730", Offset = "0x186831")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B6E9 RID: 112361
		[Token(Token = "0x401810A")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x186770", Offset = "0x186871")]
		public SharedVector3 translation;

		// Token: 0x0401B6EA RID: 112362
		[Token(Token = "0x401810B")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1867B0", Offset = "0x1868B1")]
		public Space relativeTo;

		// Token: 0x0401B6EB RID: 112363
		[Token(Token = "0x401810C")]
		[FieldOffset(Offset = "0x68")]
		private Transform targetTransform;

		// Token: 0x0401B6EC RID: 112364
		[Token(Token = "0x401810D")]
		[FieldOffset(Offset = "0x70")]
		private GameObject prevGameObject;
	}
}
