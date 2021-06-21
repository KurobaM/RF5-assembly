using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityTransform
{
	// Token: 0x0200132B RID: 4907
	[Token(Token = "0x2000CF6")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14CD00", Offset = "0x14CE01")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14CD00", Offset = "0x14CE01")]
	public class GetForwardVector : Action
	{
		// Token: 0x06007391 RID: 29585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006045")]
		[Address(RVA = "0x299B6F0", Offset = "0x299B7F1", VA = "0x299B6F0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007392 RID: 29586 RVA: 0x00027E88 File Offset: 0x00026088
		[Token(Token = "0x6006046")]
		[Address(RVA = "0x299B7F0", Offset = "0x299B8F1", VA = "0x299B7F0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007393 RID: 29587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006047")]
		[Address(RVA = "0x299B8E0", Offset = "0x299B9E1", VA = "0x299B8E0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007394 RID: 29588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006048")]
		[Address(RVA = "0x299B970", Offset = "0x299BA71", VA = "0x299B970")]
		public GetForwardVector()
		{
		}

		// Token: 0x0401B67F RID: 112255
		[Token(Token = "0x40180A0")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1858D0", Offset = "0x1859D1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B680 RID: 112256
		[Token(Token = "0x40180A1")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x185910", Offset = "0x185A11")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x185910", Offset = "0x185A11")]
		public SharedVector3 storeValue;

		// Token: 0x0401B681 RID: 112257
		[Token(Token = "0x40180A2")]
		[FieldOffset(Offset = "0x60")]
		private Transform targetTransform;

		// Token: 0x0401B682 RID: 112258
		[Token(Token = "0x40180A3")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
