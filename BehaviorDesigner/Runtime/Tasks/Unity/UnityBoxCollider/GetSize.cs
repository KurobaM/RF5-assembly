using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityBoxCollider
{
	// Token: 0x02001477 RID: 5239
	[Token(Token = "0x2000E3D")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x1547F0", Offset = "0x1548F1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x1547F0", Offset = "0x1548F1")]
	public class GetSize : Action
	{
		// Token: 0x0600782A RID: 30762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064DE")]
		[Address(RVA = "0x28DF3B0", Offset = "0x28DF4B1", VA = "0x28DF3B0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600782B RID: 30763 RVA: 0x00029D48 File Offset: 0x00027F48
		[Token(Token = "0x60064DF")]
		[Address(RVA = "0x28DF4B0", Offset = "0x28DF5B1", VA = "0x28DF4B0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600782C RID: 30764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064E0")]
		[Address(RVA = "0x28DF5A0", Offset = "0x28DF6A1", VA = "0x28DF5A0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600782D RID: 30765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064E1")]
		[Address(RVA = "0x28DF630", Offset = "0x28DF731", VA = "0x28DF630")]
		public GetSize()
		{
		}

		// Token: 0x0401BAE7 RID: 113383
		[Token(Token = "0x40184E5")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x191110", Offset = "0x191211")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BAE8 RID: 113384
		[Token(Token = "0x40184E6")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x191150", Offset = "0x191251")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x191150", Offset = "0x191251")]
		public SharedVector3 storeValue;

		// Token: 0x0401BAE9 RID: 113385
		[Token(Token = "0x40184E7")]
		[FieldOffset(Offset = "0x60")]
		private BoxCollider boxCollider;

		// Token: 0x0401BAEA RID: 113386
		[Token(Token = "0x40184E8")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
