using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityGameObject
{
	// Token: 0x02001450 RID: 5200
	[Token(Token = "0x2000E16")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x153950", Offset = "0x153A51")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x153950", Offset = "0x153A51")]
	public class SendMessage : Action
	{
		// Token: 0x06007794 RID: 30612 RVA: 0x00029988 File Offset: 0x00027B88
		[Token(Token = "0x6006448")]
		[Address(RVA = "0x28E5B30", Offset = "0x28E5C31", VA = "0x28E5B30", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007795 RID: 30613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006449")]
		[Address(RVA = "0x28E5C50", Offset = "0x28E5D51", VA = "0x28E5C50", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007796 RID: 30614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600644A")]
		[Address(RVA = "0x28E5CC0", Offset = "0x28E5DC1", VA = "0x28E5CC0")]
		public SendMessage()
		{
		}

		// Token: 0x0401BA56 RID: 113238
		[Token(Token = "0x4018454")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18FBA0", Offset = "0x18FCA1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BA57 RID: 113239
		[Token(Token = "0x4018455")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18FBE0", Offset = "0x18FCE1")]
		public SharedString message;

		// Token: 0x0401BA58 RID: 113240
		[Token(Token = "0x4018456")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18FC20", Offset = "0x18FD21")]
		public SharedGenericVariable value;
	}
}
