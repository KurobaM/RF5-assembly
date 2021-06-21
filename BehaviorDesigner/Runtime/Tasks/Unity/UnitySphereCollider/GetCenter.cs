using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnitySphereCollider
{
	// Token: 0x02001359 RID: 4953
	[Token(Token = "0x2000D24")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14DE40", Offset = "0x14DF41")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14DE40", Offset = "0x14DF41")]
	public class GetCenter : Action
	{
		// Token: 0x0600743C RID: 29756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060F0")]
		[Address(RVA = "0x2998CD0", Offset = "0x2998DD1", VA = "0x2998CD0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600743D RID: 29757 RVA: 0x000282D8 File Offset: 0x000264D8
		[Token(Token = "0x60060F1")]
		[Address(RVA = "0x2998DD0", Offset = "0x2998ED1", VA = "0x2998DD0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600743E RID: 29758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060F2")]
		[Address(RVA = "0x2998EC0", Offset = "0x2998FC1", VA = "0x2998EC0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600743F RID: 29759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060F3")]
		[Address(RVA = "0x2998F40", Offset = "0x2999041", VA = "0x2998F40")]
		public GetCenter()
		{
		}

		// Token: 0x0401B721 RID: 112417
		[Token(Token = "0x4018142")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1871B0", Offset = "0x1872B1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B722 RID: 112418
		[Token(Token = "0x4018143")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1871F0", Offset = "0x1872F1")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x1871F0", Offset = "0x1872F1")]
		public SharedVector3 storeValue;

		// Token: 0x0401B723 RID: 112419
		[Token(Token = "0x4018144")]
		[FieldOffset(Offset = "0x60")]
		private SphereCollider sphereCollider;

		// Token: 0x0401B724 RID: 112420
		[Token(Token = "0x4018145")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
