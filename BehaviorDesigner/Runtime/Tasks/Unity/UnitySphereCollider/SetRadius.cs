using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnitySphereCollider
{
	// Token: 0x0200135C RID: 4956
	[Token(Token = "0x2000D27")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14DF60", Offset = "0x14E061")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14DF60", Offset = "0x14E061")]
	public class SetRadius : Action
	{
		// Token: 0x06007448 RID: 29768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060FC")]
		[Address(RVA = "0x2999430", Offset = "0x2999531", VA = "0x2999430", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007449 RID: 29769 RVA: 0x00028320 File Offset: 0x00026520
		[Token(Token = "0x60060FD")]
		[Address(RVA = "0x2999530", Offset = "0x2999631", VA = "0x2999530", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600744A RID: 29770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060FE")]
		[Address(RVA = "0x2999620", Offset = "0x2999721", VA = "0x2999620", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600744B RID: 29771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060FF")]
		[Address(RVA = "0x2999670", Offset = "0x2999771", VA = "0x2999670")]
		public SetRadius()
		{
		}

		// Token: 0x0401B72D RID: 112429
		[Token(Token = "0x401814E")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x187350", Offset = "0x187451")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B72E RID: 112430
		[Token(Token = "0x401814F")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x187390", Offset = "0x187491")]
		public SharedFloat radius;

		// Token: 0x0401B72F RID: 112431
		[Token(Token = "0x4018150")]
		[FieldOffset(Offset = "0x60")]
		private SphereCollider sphereCollider;

		// Token: 0x0401B730 RID: 112432
		[Token(Token = "0x4018151")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
