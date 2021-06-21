using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks
{
	// Token: 0x020012CC RID: 4812
	[Token(Token = "0x2000C99")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14A8B0", Offset = "0x14A9B1")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14A8B0", Offset = "0x14A9B1")]
	[Attribute(Name = "TaskIconAttribute", RVA = "0x14A8B0", Offset = "0x14A9B1")]
	public class SetTakebehindParameter : Action
	{
		// Token: 0x060071FB RID: 29179 RVA: 0x000272A0 File Offset: 0x000254A0
		[Token(Token = "0x6005EAF")]
		[Address(RVA = "0x221B050", Offset = "0x221B151", VA = "0x221B050", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060071FC RID: 29180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EB0")]
		[Address(RVA = "0x221B2B0", Offset = "0x221B3B1", VA = "0x221B2B0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060071FD RID: 29181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EB1")]
		[Address(RVA = "0x221B2C0", Offset = "0x221B3C1", VA = "0x221B2C0")]
		public SetTakebehindParameter()
		{
		}

		// Token: 0x0401B548 RID: 111944
		[Token(Token = "0x4017F71")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x181E60", Offset = "0x181F61")]
		public SharedGameObject Target;

		// Token: 0x0401B549 RID: 111945
		[Token(Token = "0x4017F72")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x181EA0", Offset = "0x181FA1")]
		public SharedFloat TakebehindRange;

		// Token: 0x0401B54A RID: 111946
		[Token(Token = "0x4017F73")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x181EE0", Offset = "0x181FE1")]
		public SharedVector3 MovePosition;
	}
}
