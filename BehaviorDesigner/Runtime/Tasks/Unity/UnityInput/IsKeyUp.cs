using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityInput
{
	// Token: 0x02001441 RID: 5185
	[Token(Token = "0x2000E07")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x1533B0", Offset = "0x1534B1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x1533B0", Offset = "0x1534B1")]
	public class IsKeyUp : Conditional
	{
		// Token: 0x06007767 RID: 30567 RVA: 0x00029820 File Offset: 0x00027A20
		[Token(Token = "0x600641B")]
		[Address(RVA = "0x28E68C0", Offset = "0x28E69C1", VA = "0x28E68C0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007768 RID: 30568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600641C")]
		[Address(RVA = "0x28E68F0", Offset = "0x28E69F1", VA = "0x28E68F0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007769 RID: 30569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600641D")]
		[Address(RVA = "0x28E6900", Offset = "0x28E6A01", VA = "0x28E6900")]
		public IsKeyUp()
		{
		}

		// Token: 0x0401BA3A RID: 113210
		[Token(Token = "0x4018438")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18F440", Offset = "0x18F541")]
		public KeyCode key;
	}
}
