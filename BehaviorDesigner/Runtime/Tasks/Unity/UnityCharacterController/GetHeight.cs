using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityCharacterController
{
	// Token: 0x0200145E RID: 5214
	[Token(Token = "0x2000E24")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x153E90", Offset = "0x153F91")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x153E90", Offset = "0x153F91")]
	public class GetHeight : Action
	{
		// Token: 0x060077C5 RID: 30661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006479")]
		[Address(RVA = "0x28E1630", Offset = "0x28E1731", VA = "0x28E1630", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060077C6 RID: 30662 RVA: 0x00029AF0 File Offset: 0x00027CF0
		[Token(Token = "0x600647A")]
		[Address(RVA = "0x28E1730", Offset = "0x28E1831", VA = "0x28E1730", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060077C7 RID: 30663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600647B")]
		[Address(RVA = "0x28E1820", Offset = "0x28E1921", VA = "0x28E1820", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060077C8 RID: 30664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600647C")]
		[Address(RVA = "0x28E1870", Offset = "0x28E1971", VA = "0x28E1870")]
		public GetHeight()
		{
		}

		// Token: 0x0401BA84 RID: 113284
		[Token(Token = "0x4018482")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1903E0", Offset = "0x1904E1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BA85 RID: 113285
		[Token(Token = "0x4018483")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x190420", Offset = "0x190521")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x190420", Offset = "0x190521")]
		public SharedFloat storeValue;

		// Token: 0x0401BA86 RID: 113286
		[Token(Token = "0x4018484")]
		[FieldOffset(Offset = "0x60")]
		private CharacterController characterController;

		// Token: 0x0401BA87 RID: 113287
		[Token(Token = "0x4018485")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
