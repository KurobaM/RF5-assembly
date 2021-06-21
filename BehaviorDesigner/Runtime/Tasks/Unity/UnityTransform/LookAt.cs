using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityTransform
{
	// Token: 0x02001336 RID: 4918
	[Token(Token = "0x2000D01")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14D120", Offset = "0x14D221")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14D120", Offset = "0x14D221")]
	public class LookAt : Action
	{
		// Token: 0x060073BD RID: 29629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006071")]
		[Address(RVA = "0x299D2A0", Offset = "0x299D3A1", VA = "0x299D2A0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060073BE RID: 29630 RVA: 0x00027F90 File Offset: 0x00026190
		[Token(Token = "0x6006072")]
		[Address(RVA = "0x299D3A0", Offset = "0x299D4A1", VA = "0x299D3A0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060073BF RID: 29631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006073")]
		[Address(RVA = "0x299D520", Offset = "0x299D621", VA = "0x299D520", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060073C0 RID: 29632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006074")]
		[Address(RVA = "0x299D5D0", Offset = "0x299D6D1", VA = "0x299D5D0")]
		public LookAt()
		{
		}

		// Token: 0x0401B6AB RID: 112299
		[Token(Token = "0x40180CC")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x185EF0", Offset = "0x185FF1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B6AC RID: 112300
		[Token(Token = "0x40180CD")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x185F30", Offset = "0x186031")]
		public SharedGameObject targetLookAt;

		// Token: 0x0401B6AD RID: 112301
		[Token(Token = "0x40180CE")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x185F70", Offset = "0x186071")]
		public SharedVector3 worldPosition;

		// Token: 0x0401B6AE RID: 112302
		[Token(Token = "0x40180CF")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x185FB0", Offset = "0x1860B1")]
		public Vector3 worldUp;

		// Token: 0x0401B6AF RID: 112303
		[Token(Token = "0x40180D0")]
		[FieldOffset(Offset = "0x78")]
		private Transform targetTransform;

		// Token: 0x0401B6B0 RID: 112304
		[Token(Token = "0x40180D1")]
		[FieldOffset(Offset = "0x80")]
		private GameObject prevGameObject;
	}
}
