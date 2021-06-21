using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityGameObject
{
	// Token: 0x02001452 RID: 5202
	[Token(Token = "0x2000E18")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x153A10", Offset = "0x153B11")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x153A10", Offset = "0x153B11")]
	public class SetTag : Action
	{
		// Token: 0x0600779A RID: 30618 RVA: 0x000299B8 File Offset: 0x00027BB8
		[Token(Token = "0x600644E")]
		[Address(RVA = "0x28E5DD0", Offset = "0x28E5ED1", VA = "0x28E5DD0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600779B RID: 30619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600644F")]
		[Address(RVA = "0x28E5E70", Offset = "0x28E5F71", VA = "0x28E5E70", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600779C RID: 30620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006450")]
		[Address(RVA = "0x28E5EE0", Offset = "0x28E5FE1", VA = "0x28E5EE0")]
		public SetTag()
		{
		}

		// Token: 0x0401BA5B RID: 113243
		[Token(Token = "0x4018459")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18FCE0", Offset = "0x18FDE1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BA5C RID: 113244
		[Token(Token = "0x401845A")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18FD20", Offset = "0x18FE21")]
		public SharedString tag;
	}
}
