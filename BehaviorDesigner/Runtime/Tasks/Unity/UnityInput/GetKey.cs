using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityInput
{
	// Token: 0x0200143B RID: 5179
	[Token(Token = "0x2000E01")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x153170", Offset = "0x153271")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x153170", Offset = "0x153271")]
	public class GetKey : Action
	{
		// Token: 0x06007755 RID: 30549 RVA: 0x00029790 File Offset: 0x00027990
		[Token(Token = "0x6006409")]
		[Address(RVA = "0x28E63F0", Offset = "0x28E64F1", VA = "0x28E63F0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007756 RID: 30550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600640A")]
		[Address(RVA = "0x28E6470", Offset = "0x28E6571", VA = "0x28E6470", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007757 RID: 30551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600640B")]
		[Address(RVA = "0x28E64B0", Offset = "0x28E65B1", VA = "0x28E64B0")]
		public GetKey()
		{
		}

		// Token: 0x0401BA32 RID: 113202
		[Token(Token = "0x4018430")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18F210", Offset = "0x18F311")]
		public KeyCode key;

		// Token: 0x0401BA33 RID: 113203
		[Token(Token = "0x4018431")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x18F250", Offset = "0x18F351")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18F250", Offset = "0x18F351")]
		public SharedBool storeResult;
	}
}
