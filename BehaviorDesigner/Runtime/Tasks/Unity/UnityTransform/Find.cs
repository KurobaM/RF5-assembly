using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityTransform
{
	// Token: 0x02001326 RID: 4902
	[Token(Token = "0x2000CF1")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14CB20", Offset = "0x14CC21")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14CB20", Offset = "0x14CC21")]
	public class Find : Action
	{
		// Token: 0x0600737D RID: 29565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006031")]
		[Address(RVA = "0x299A820", Offset = "0x299A921", VA = "0x299A820", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600737E RID: 29566 RVA: 0x00027E10 File Offset: 0x00026010
		[Token(Token = "0x6006032")]
		[Address(RVA = "0x299A920", Offset = "0x299AA21", VA = "0x299A920", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600737F RID: 29567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006033")]
		[Address(RVA = "0x299AA90", Offset = "0x299AB91", VA = "0x299AA90", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007380 RID: 29568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006034")]
		[Address(RVA = "0x299AAE0", Offset = "0x299ABE1", VA = "0x299AAE0")]
		public Find()
		{
		}

		// Token: 0x0401B666 RID: 112230
		[Token(Token = "0x4018087")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1854C0", Offset = "0x1855C1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B667 RID: 112231
		[Token(Token = "0x4018088")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x185500", Offset = "0x185601")]
		public SharedString transformName;

		// Token: 0x0401B668 RID: 112232
		[Token(Token = "0x4018089")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x185540", Offset = "0x185641")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x185540", Offset = "0x185641")]
		public SharedTransform storeValue;

		// Token: 0x0401B669 RID: 112233
		[Token(Token = "0x401808A")]
		[FieldOffset(Offset = "0x68")]
		private Transform targetTransform;

		// Token: 0x0401B66A RID: 112234
		[Token(Token = "0x401808B")]
		[FieldOffset(Offset = "0x70")]
		private GameObject prevGameObject;
	}
}
