using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityRigidbody2D
{
	// Token: 0x02001391 RID: 5009
	[Token(Token = "0x2000D5C")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14F340", Offset = "0x14F441")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14F340", Offset = "0x14F441")]
	public class SetAngularDrag : Action
	{
		// Token: 0x060074FA RID: 29946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061AE")]
		[Address(RVA = "0x2997850", Offset = "0x2997951", VA = "0x2997850", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060074FB RID: 29947 RVA: 0x00028818 File Offset: 0x00026A18
		[Token(Token = "0x60061AF")]
		[Address(RVA = "0x2997950", Offset = "0x2997A51", VA = "0x2997950", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060074FC RID: 29948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061B0")]
		[Address(RVA = "0x2997A40", Offset = "0x2997B41", VA = "0x2997A40", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060074FD RID: 29949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061B1")]
		[Address(RVA = "0x2997A90", Offset = "0x2997B91", VA = "0x2997A90")]
		public SetAngularDrag()
		{
		}

		// Token: 0x0401B7B9 RID: 112569
		[Token(Token = "0x40181DA")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x188FA0", Offset = "0x1890A1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B7BA RID: 112570
		[Token(Token = "0x40181DB")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x188FE0", Offset = "0x1890E1")]
		public SharedFloat angularDrag;

		// Token: 0x0401B7BB RID: 112571
		[Token(Token = "0x40181DC")]
		[FieldOffset(Offset = "0x60")]
		private Rigidbody2D rigidbody2D;

		// Token: 0x0401B7BC RID: 112572
		[Token(Token = "0x40181DD")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
