using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityQuaternion
{
	// Token: 0x020013C5 RID: 5061
	[Token(Token = "0x2000D90")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x150710", Offset = "0x150811")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x150710", Offset = "0x150811")]
	public class Identity : Action
	{
		// Token: 0x060075C5 RID: 30149 RVA: 0x00028CF8 File Offset: 0x00026EF8
		[Token(Token = "0x6006279")]
		[Address(RVA = "0x298EBD0", Offset = "0x298ECD1", VA = "0x298EBD0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060075C6 RID: 30150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600627A")]
		[Address(RVA = "0x298EC60", Offset = "0x298ED61", VA = "0x298EC60", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060075C7 RID: 30151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600627B")]
		[Address(RVA = "0x298ECE0", Offset = "0x298EDE1", VA = "0x298ECE0")]
		public Identity()
		{
		}

		// Token: 0x0401B885 RID: 112773
		[Token(Token = "0x40182A6")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18AC20", Offset = "0x18AD21")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x18AC20", Offset = "0x18AD21")]
		public SharedQuaternion storeResult;
	}
}
