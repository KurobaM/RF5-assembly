using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityGameObject
{
	// Token: 0x02001446 RID: 5190
	[Token(Token = "0x2000E0C")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x153590", Offset = "0x153691")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x153590", Offset = "0x153691")]
	public class CompareLayerMask : Conditional
	{
		// Token: 0x06007776 RID: 30582 RVA: 0x00029898 File Offset: 0x00027A98
		[Token(Token = "0x600642A")]
		[Address(RVA = "0x28E4D50", Offset = "0x28E4E51", VA = "0x28E4D50", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007777 RID: 30583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600642B")]
		[Address(RVA = "0x28E4DF0", Offset = "0x28E4EF1", VA = "0x28E4DF0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007778 RID: 30584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600642C")]
		[Address(RVA = "0x28E4E00", Offset = "0x28E4F01", VA = "0x28E4E00")]
		public CompareLayerMask()
		{
		}

		// Token: 0x0401BA3F RID: 113215
		[Token(Token = "0x401843D")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18F580", Offset = "0x18F681")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BA40 RID: 113216
		[Token(Token = "0x401843E")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18F5C0", Offset = "0x18F6C1")]
		public LayerMask layermask;
	}
}
