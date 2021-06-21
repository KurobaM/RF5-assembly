using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityVector2
{
	// Token: 0x02001320 RID: 4896
	[Token(Token = "0x2000CEC")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14C940", Offset = "0x14CA41")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14C940", Offset = "0x14CA41")]
	public class Multiply : Action
	{
		// Token: 0x0600736E RID: 29550 RVA: 0x00027D98 File Offset: 0x00025F98
		[Token(Token = "0x6006022")]
		[Address(RVA = "0x29A0BC0", Offset = "0x29A0CC1", VA = "0x29A0BC0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600736F RID: 29551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006023")]
		[Address(RVA = "0x29A0CB0", Offset = "0x29A0DB1", VA = "0x29A0CB0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007370 RID: 29552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006024")]
		[Address(RVA = "0x29A0D60", Offset = "0x29A0E61", VA = "0x29A0D60")]
		public Multiply()
		{
		}

		// Token: 0x0401B654 RID: 112212
		[Token(Token = "0x4018079")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x185120", Offset = "0x185221")]
		public SharedVector2 vector2Variable;

		// Token: 0x0401B655 RID: 112213
		[Token(Token = "0x401807A")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x185160", Offset = "0x185261")]
		public SharedFloat multiplyBy;

		// Token: 0x0401B656 RID: 112214
		[Token(Token = "0x401807B")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1851A0", Offset = "0x1852A1")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x1851A0", Offset = "0x1852A1")]
		public SharedVector2 storeResult;
	}
}
