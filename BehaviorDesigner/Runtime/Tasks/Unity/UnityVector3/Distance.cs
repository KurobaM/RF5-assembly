using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityVector3
{
	// Token: 0x02001303 RID: 4867
	[Token(Token = "0x2000CD0")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14BEC0", Offset = "0x14BFC1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14BEC0", Offset = "0x14BFC1")]
	public class Distance : Action
	{
		// Token: 0x0600731A RID: 29466 RVA: 0x00027AF8 File Offset: 0x00025CF8
		[Token(Token = "0x6005FCE")]
		[Address(RVA = "0x24497B0", Offset = "0x24498B1", VA = "0x24497B0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600731B RID: 29467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FCF")]
		[Address(RVA = "0x24498C0", Offset = "0x24499C1", VA = "0x24498C0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600731C RID: 29468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FD0")]
		[Address(RVA = "0x2449980", Offset = "0x2449A81", VA = "0x2449980")]
		public Distance()
		{
		}

		// Token: 0x0401B605 RID: 112133
		[Token(Token = "0x401802E")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x183CA0", Offset = "0x183DA1")]
		public SharedVector3 firstVector3;

		// Token: 0x0401B606 RID: 112134
		[Token(Token = "0x401802F")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x183CE0", Offset = "0x183DE1")]
		public SharedVector3 secondVector3;

		// Token: 0x0401B607 RID: 112135
		[Token(Token = "0x4018030")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x183D20", Offset = "0x183E21")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x183D20", Offset = "0x183E21")]
		public SharedFloat storeResult;
	}
}
